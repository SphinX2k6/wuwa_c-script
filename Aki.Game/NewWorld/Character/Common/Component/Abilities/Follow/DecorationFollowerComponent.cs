using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;

namespace Aki.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02002F94 RID: 12180
	[NullableContext(2)]
	[Nullable(0)]
	public class DecorationFollowerComponent : EntityComponent
	{
		// Token: 0x17002DB9 RID: 11705
		// (get) Token: 0x0601CE36 RID: 118326 RVA: 0x008D3C6D File Offset: 0x008D1E6D
		// (set) Token: 0x0601CE37 RID: 118327 RVA: 0x008D3C75 File Offset: 0x008D1E75
		public EFollowDecorationType? Type { get; private set; }

		// Token: 0x17002DBA RID: 11706
		// (get) Token: 0x0601CE38 RID: 118328 RVA: 0x008D3C80 File Offset: 0x008D1E80
		public bool IsChair
		{
			get
			{
				EFollowDecorationType? type = this.Type;
				EFollowDecorationType efollowDecorationType = EFollowDecorationType.Chair;
				return type.GetValueOrDefault() == efollowDecorationType & type != null;
			}
		}

		// Token: 0x17002DBB RID: 11707
		// (get) Token: 0x0601CE39 RID: 118329 RVA: 0x008D3CA8 File Offset: 0x008D1EA8
		public ChairFollowerConfig ChairConfig
		{
			get
			{
				ChairFollowerConfig chairFollowerConfig = this.TypeConfig as ChairFollowerConfig;
				if (chairFollowerConfig == null)
				{
					return null;
				}
				return chairFollowerConfig;
			}
		}

		// Token: 0x17002DBC RID: 11708
		// (get) Token: 0x0601CE3A RID: 118330 RVA: 0x008D3CC7 File Offset: 0x008D1EC7
		public bool NeedExternalPerformanceControl
		{
			get
			{
				IDecorationFollowerConfig typeConfig = this.TypeConfig;
				return typeConfig != null && typeConfig.NeedExternalPerformanceControl;
			}
		}

		// Token: 0x0601CE3B RID: 118331 RVA: 0x008D3CDC File Offset: 0x008D1EDC
		protected override bool OnInitData(IEntityArgs args = null)
		{
			FollowDecorationComponent followDecorationComponent = args.GetP1<CreateEntityData>().GetParam<DecorationFollowerComponent>() as FollowDecorationComponent;
			IFollowDecorationChairConfig followDecorationChairConfig = (followDecorationComponent != null) ? followDecorationComponent.DecorationConfig : null;
			this.Type = ((followDecorationChairConfig != null) ? new EFollowDecorationType?(followDecorationChairConfig.Type) : null);
			if (followDecorationChairConfig == null)
			{
				return true;
			}
			this.TypeConfig = this.CreateTypeConfig(followDecorationChairConfig);
			return true;
		}

		// Token: 0x0601CE3C RID: 118332 RVA: 0x008D3D38 File Offset: 0x008D1F38
		[NullableContext(1)]
		[return: Nullable(2)]
		private IDecorationFollowerConfig CreateTypeConfig(IFollowDecorationChairConfig decorationConfig)
		{
			Func<IDecorationFollowerConfig> func;
			if (!DecorationFollowerComponent.DecorationConfigFactory.TryGetValue(decorationConfig.Type, out func))
			{
				return null;
			}
			IDecorationFollowerConfig decorationFollowerConfig = func();
			decorationFollowerConfig.ApplyRawConfig(decorationConfig);
			return decorationFollowerConfig;
		}

		// Token: 0x0601CE3D RID: 118333 RVA: 0x008D3D68 File Offset: 0x008D1F68
		protected override bool OnInit()
		{
			IDecorationFollowerConfig typeConfig = this.TypeConfig;
			if (typeConfig != null)
			{
				typeConfig.Load(delegate
				{
				});
			}
			if (this.NeedExternalPerformanceControl)
			{
				Entity entity = base.Entity;
				if (entity != null)
				{
					SceneItemStateComponent component = entity.GetComponent<SceneItemStateComponent>();
					if (component != null)
					{
						component.SetPerformanceStateControlledExternally(true);
					}
				}
			}
			return true;
		}

		// Token: 0x0601CE3E RID: 118334 RVA: 0x008D3DCC File Offset: 0x008D1FCC
		protected override bool OnStart()
		{
			if (!this.IsChair)
			{
				return true;
			}
			Entity chairEntity = base.Entity;
			this.ChairBindingRetryTimer = TimerSystem.Instance.Next(delegate(float _)
			{
				this.ChairBindingRetryTimer = null;
				if (!chairEntity.Valid || this.Entity != chairEntity || !this.IsChair)
				{
					return;
				}
				this.TryBindChairToOwnerHandler();
			}, null, null);
			return true;
		}

		// Token: 0x0601CE3F RID: 118335 RVA: 0x008D3E1B File Offset: 0x008D201B
		protected override bool OnClear()
		{
			this.ClearChairBindingRetry();
			return base.OnClear();
		}

		// Token: 0x0601CE40 RID: 118336 RVA: 0x008D3E2C File Offset: 0x008D202C
		private void TryBindChairToOwnerHandler()
		{
			Entity entity = base.Entity;
			CreatureDataComponent creatureDataComponent = (entity != null) ? entity.GetComponent<CreatureDataComponent>() : null;
			int num = (creatureDataComponent != null) ? creatureDataComponent.GetSummonerPlayerId() : 0;
			CreatureModel instance = CreatureModel.Instance;
			int num2 = (instance != null) ? instance.GetPlayerId() : 0;
			if (num2 <= 0)
			{
				this.ScheduleChairBindingRetry();
				return;
			}
			long num3 = (creatureDataComponent != null) ? creatureDataComponent.SummonerPlayerEntityId : 0L;
			if (num <= 0 && num3 > 0L)
			{
				CreatureModel instance2 = CreatureModel.Instance;
				object obj;
				if (instance2 == null)
				{
					obj = null;
				}
				else
				{
					EntityHandle entity2 = instance2.GetEntity(num3);
					obj = ((entity2 != null) ? entity2.Entity : null);
				}
				object obj2 = obj;
				int? num4;
				if (obj2 == null)
				{
					num4 = null;
				}
				else
				{
					CreatureDataComponent component = obj2.GetComponent<CreatureDataComponent>();
					num4 = ((component != null) ? new int?(component.GetPlayerId()) : null);
				}
				int? num5 = num4;
				if (num5 != null && num5.GetValueOrDefault() > 0)
				{
					num = num5.Value;
				}
			}
			if (num <= 0)
			{
				if (num3 <= 0L)
				{
					Log.Instance.Warn(ELogModule.SceneItem, ELogAuthor.CK, "[PlayerFollowerChairHandler.Remote] 放弃: 椅子无召唤者归属信息(服务端未下发)", default(ReadOnlySpan<ValueTuple<string, object>>));
					this.ClearChairBindingRetry();
					return;
				}
				this.ScheduleChairBindingRetry();
				return;
			}
			else
			{
				Entity entity3 = base.Entity;
				if (entity3 == null)
				{
					Log.Instance.Warn(ELogModule.SceneItem, ELogAuthor.CK, "[PlayerFollowerChairHandler.Remote] 跳过: 椅子实体为空", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				IPlayerFollowerChairHandler playerFollowHandler = FollowUtils.GetPlayerFollowHandler<IPlayerFollowerChairHandler>(num);
				if (playerFollowHandler == null)
				{
					this.ScheduleChairBindingRetry();
					return;
				}
				this.ClearChairBindingRetry();
				if (num == num2)
				{
					playerFollowHandler.TryRebindLocalChairEntity(entity3);
					return;
				}
				playerFollowHandler.TryStartRemoteVisibilityByChairEntity(entity3);
				return;
			}
		}

		// Token: 0x0601CE41 RID: 118337 RVA: 0x008D3F88 File Offset: 0x008D2188
		private void ScheduleChairBindingRetry()
		{
			if (this.ChairBindingRetryTimer != null)
			{
				return;
			}
			this.ChairBindingRetryTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.ChairBindingRetryTimer = null;
				this.ChairBindingRetryCount++;
				this.TryBindChairToOwnerHandler();
			}, (float)((this.ChairBindingRetryCount < 20) ? 500 : 5000), null, null, true, 1f);
		}

		// Token: 0x0601CE42 RID: 118338 RVA: 0x008D3FD9 File Offset: 0x008D21D9
		private void ClearChairBindingRetry()
		{
			if (this.ChairBindingRetryTimer != null)
			{
				TimerSystem.Instance.Remove(this.ChairBindingRetryTimer);
				this.ChairBindingRetryTimer = null;
			}
			this.ChairBindingRetryCount = 0;
		}

		// Token: 0x0601CE43 RID: 118339 RVA: 0x008D4004 File Offset: 0x008D2204
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			DecorationFollowerComponent decorationFollowerComponent = (DecorationFollowerComponent)componentTemplate;
			this.ChairBindingRetryCount = decorationFollowerComponent.ChairBindingRetryCount;
			if (decorationFollowerComponent.ChairBindingRetryTimer == null)
			{
				this.ChairBindingRetryTimer = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ChairBindingRetryTimer), "ChairBindingRetryTimer"))
			{
				return false;
			}
			if (decorationFollowerComponent.TypeConfig == null)
			{
				this.TypeConfig = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TypeConfig), "TypeConfig"))
			{
				return false;
			}
			this.Type = decorationFollowerComponent.Type;
			return true;
		}

		// Token: 0x17002DBD RID: 11709
		// (get) Token: 0x0601CE44 RID: 118340 RVA: 0x008D4092 File Offset: 0x008D2292
		public override bool NeedInitInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17002DBE RID: 11710
		// (get) Token: 0x0601CE45 RID: 118341 RVA: 0x008D4095 File Offset: 0x008D2295
		public override bool NeedClearInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17002DBF RID: 11711
		// (get) Token: 0x0601CE46 RID: 118342 RVA: 0x008D4098 File Offset: 0x008D2298
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0400F396 RID: 62358
		private const int CHAIR_BINDING_FAST_RETRY_INTERVAL_MS = 500;

		// Token: 0x0400F397 RID: 62359
		private const int CHAIR_BINDING_FAST_RETRY_MAX_COUNT = 20;

		// Token: 0x0400F398 RID: 62360
		private const int CHAIR_BINDING_SLOW_RETRY_INTERVAL_MS = 5000;

		// Token: 0x0400F399 RID: 62361
		[Nullable(1)]
		private static readonly Dictionary<EFollowDecorationType, Func<IDecorationFollowerConfig>> DecorationConfigFactory = new Dictionary<EFollowDecorationType, Func<IDecorationFollowerConfig>>
		{
			{
				EFollowDecorationType.Chair,
				() => new ChairFollowerConfig()
			}
		};

		// Token: 0x0400F39A RID: 62362
		private int ChairBindingRetryCount;

		// Token: 0x0400F39B RID: 62363
		private TimerHandle ChairBindingRetryTimer;

		// Token: 0x0400F39C RID: 62364
		private IDecorationFollowerConfig TypeConfig;
	}
}
