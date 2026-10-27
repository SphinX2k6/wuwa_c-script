using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;

namespace Aki.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x020044C2 RID: 17602
	[NullableContext(2)]
	[Nullable(0)]
	public class DecorationFollowerComponent : EntityComponent
	{
		// Token: 0x1700739B RID: 29595
		// (get) Token: 0x0602D610 RID: 185872 RVA: 0x00A3D51D File Offset: 0x00A3B71D
		// (set) Token: 0x0602D611 RID: 185873 RVA: 0x00A3D525 File Offset: 0x00A3B725
		public EFollowDecorationType? Type { get; private set; }

		// Token: 0x1700739C RID: 29596
		// (get) Token: 0x0602D612 RID: 185874 RVA: 0x00A3D530 File Offset: 0x00A3B730
		public bool IsChair
		{
			get
			{
				EFollowDecorationType? type = this.Type;
				EFollowDecorationType efollowDecorationType = EFollowDecorationType.Chair;
				return type.GetValueOrDefault() == efollowDecorationType & type != null;
			}
		}

		// Token: 0x1700739D RID: 29597
		// (get) Token: 0x0602D613 RID: 185875 RVA: 0x00A3D558 File Offset: 0x00A3B758
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

		// Token: 0x1700739E RID: 29598
		// (get) Token: 0x0602D614 RID: 185876 RVA: 0x00A3D577 File Offset: 0x00A3B777
		public bool NeedExternalPerformanceControl
		{
			get
			{
				IDecorationFollowerConfig typeConfig = this.TypeConfig;
				return typeConfig != null && typeConfig.NeedExternalPerformanceControl;
			}
		}

		// Token: 0x0602D615 RID: 185877 RVA: 0x00A3D58C File Offset: 0x00A3B78C
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

		// Token: 0x0602D616 RID: 185878 RVA: 0x00A3D5E8 File Offset: 0x00A3B7E8
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

		// Token: 0x0602D617 RID: 185879 RVA: 0x00A3D618 File Offset: 0x00A3B818
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

		// Token: 0x0602D618 RID: 185880 RVA: 0x00A3D67C File Offset: 0x00A3B87C
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

		// Token: 0x0602D619 RID: 185881 RVA: 0x00A3D6CB File Offset: 0x00A3B8CB
		protected override bool OnClear()
		{
			this.ClearChairBindingRetry();
			return base.OnClear();
		}

		// Token: 0x0602D61A RID: 185882 RVA: 0x00A3D6DC File Offset: 0x00A3B8DC
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

		// Token: 0x0602D61B RID: 185883 RVA: 0x00A3D838 File Offset: 0x00A3BA38
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

		// Token: 0x0602D61C RID: 185884 RVA: 0x00A3D889 File Offset: 0x00A3BA89
		private void ClearChairBindingRetry()
		{
			if (this.ChairBindingRetryTimer != null)
			{
				TimerSystem.Instance.Remove(this.ChairBindingRetryTimer);
				this.ChairBindingRetryTimer = null;
			}
			this.ChairBindingRetryCount = 0;
		}

		// Token: 0x0602D61D RID: 185885 RVA: 0x00A3D8B4 File Offset: 0x00A3BAB4
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			DecorationFollowerComponent decorationFollowerComponent = (DecorationFollowerComponent)componentTemplate;
			if (base.CanResetComponentProperty("ChairBindingRetryCount"))
			{
				this.ChairBindingRetryCount = decorationFollowerComponent.ChairBindingRetryCount;
			}
			if (base.CanResetComponentProperty("ChairBindingRetryTimer"))
			{
				if (decorationFollowerComponent.ChairBindingRetryTimer == null)
				{
					this.ChairBindingRetryTimer = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TimerHandle>(this.ChairBindingRetryTimer), "ChairBindingRetryTimer"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TypeConfig"))
			{
				if (decorationFollowerComponent.TypeConfig == null)
				{
					this.TypeConfig = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<IDecorationFollowerConfig>(this.TypeConfig), "TypeConfig"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("<Type>k__BackingField"))
			{
				this.Type = decorationFollowerComponent.Type;
			}
			return true;
		}

		// Token: 0x0401840D RID: 99341
		private const int CHAIR_BINDING_FAST_RETRY_INTERVAL_MS = 500;

		// Token: 0x0401840E RID: 99342
		private const int CHAIR_BINDING_FAST_RETRY_MAX_COUNT = 20;

		// Token: 0x0401840F RID: 99343
		private const int CHAIR_BINDING_SLOW_RETRY_INTERVAL_MS = 5000;

		// Token: 0x04018410 RID: 99344
		[Nullable(1)]
		private static readonly Dictionary<EFollowDecorationType, Func<IDecorationFollowerConfig>> DecorationConfigFactory = new Dictionary<EFollowDecorationType, Func<IDecorationFollowerConfig>>
		{
			{
				EFollowDecorationType.Chair,
				() => new ChairFollowerConfig()
			}
		};

		// Token: 0x04018411 RID: 99345
		private int ChairBindingRetryCount;

		// Token: 0x04018412 RID: 99346
		private TimerHandle ChairBindingRetryTimer;

		// Token: 0x04018413 RID: 99347
		private IDecorationFollowerConfig TypeConfig;
	}
}
