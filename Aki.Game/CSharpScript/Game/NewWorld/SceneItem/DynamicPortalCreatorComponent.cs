using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x02006212 RID: 25106
	[NullableContext(2)]
	[Nullable(0)]
	public class DynamicPortalCreatorComponent : EntityComponent
	{
		// Token: 0x0603C5B7 RID: 247223 RVA: 0x01137934 File Offset: 0x01135B34
		protected override bool OnInitData(IEntityArgs args = null)
		{
			object param = args.GetP1<CreateEntityData>().GetParam<DynamicPortalCreatorComponent>();
			this.Config = (DynamicPortalCreatorComponent)param;
			if (this.Config.Model.Type == EDynamicPortalCreateType.Bullet)
			{
				this.BulletTypeConfig = this.Config.Model;
				this.BulletIds.Add((long)this.BulletTypeConfig.TypeA.BulletId);
				this.BulletIds.Add((long)this.BulletTypeConfig.TypeB.BulletId);
			}
			return true;
		}

		// Token: 0x0603C5B8 RID: 247224 RVA: 0x011379B5 File Offset: 0x01135BB5
		protected override bool OnStart()
		{
			this.CreatureDataComp = base.Entity.GetComponent<CreatureDataComponent>();
			if (this.Config.Model.Type == EDynamicPortalCreateType.Bullet)
			{
				this.HitComp = base.Entity.GetComponent<SceneItemHitComponent>();
			}
			return true;
		}

		// Token: 0x0603C5B9 RID: 247225 RVA: 0x011379EC File Offset: 0x01135BEC
		protected override void OnActivate()
		{
			if (this.Config.Model.Type == EDynamicPortalCreateType.Bullet)
			{
				this.AddHitEvent();
			}
		}

		// Token: 0x0603C5BA RID: 247226 RVA: 0x01137A06 File Offset: 0x01135C06
		protected override bool OnEnd()
		{
			if (this.Config.Model.Type == EDynamicPortalCreateType.Bullet)
			{
				this.RemoveHitEvent();
			}
			return true;
		}

		// Token: 0x0603C5BB RID: 247227 RVA: 0x01137A21 File Offset: 0x01135C21
		public IPortalRenderConfig GetPortalRenderConfig()
		{
			DynamicPortalCreatorComponent config = this.Config;
			if (config == null)
			{
				return null;
			}
			return config.Model.RenderConfig;
		}

		// Token: 0x0603C5BC RID: 247228 RVA: 0x01137A39 File Offset: 0x01135C39
		private void AddHitEvent()
		{
			if (this.HitComp == null)
			{
				return;
			}
			this.HitComp.AddComponentHitCondition(this, new SceneItemHitComponent.TSceneItemHitConditionCheck(this.HitBulletIdCheck));
			EventSystem.Instance.AddWithTarget<global::HitInformation>(this, EEventName.OnSceneItemHitByHitData, new Action<global::HitInformation>(this.OnSceneItemHit));
		}

		// Token: 0x0603C5BD RID: 247229 RVA: 0x01137A7C File Offset: 0x01135C7C
		private void RemoveHitEvent()
		{
			if (this.HitComp == null)
			{
				return;
			}
			this.HitComp.RemoveComponentHitCondition(this, new SceneItemHitComponent.TSceneItemHitConditionCheck(this.HitBulletIdCheck));
			if (EventSystem.Instance.HasWithTarget<global::HitInformation>(this, EEventName.OnSceneItemHitByHitData, new Action<global::HitInformation>(this.OnSceneItemHit)))
			{
				EventSystem.Instance.RemoveWithTarget<global::HitInformation>(this, EEventName.OnSceneItemHitByHitData, new Action<global::HitInformation>(this.OnSceneItemHit));
			}
		}

		// Token: 0x0603C5BE RID: 247230 RVA: 0x01137AE8 File Offset: 0x01135CE8
		[NullableContext(1)]
		private bool HitBulletIdCheck(global::HitInformation hitData)
		{
			long bulletId = hitData.BulletId;
			return this.BulletIds.Contains(bulletId);
		}

		// Token: 0x0603C5BF RID: 247231 RVA: 0x01137B08 File Offset: 0x01135D08
		[NullableContext(1)]
		private void OnSceneItemHit(global::HitInformation hitData)
		{
			AwakeDynamicPortalRequest awakeDynamicPortalRequest = AwakeDynamicPortalRequest.Create();
			awakeDynamicPortalRequest.EntityId = this.CreatureDataComp.GetCreatureDataId();
			awakeDynamicPortalRequest.BulletId = ((hitData.BulletId >= -2147483648L && hitData.BulletId <= 2147483647L) ? ((int)hitData.BulletId) : hitData.BulletEntityId);
			awakeDynamicPortalRequest.IsAwake = true;
			Net.Instance.Call(ERequestMessageId.AwakeDynamicPortalRequest, awakeDynamicPortalRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				AwakeDynamicPortalResponse awakeDynamicPortalResponse = (AwakeDynamicPortalResponse)msg;
				ErrorCode? errorCode = (awakeDynamicPortalResponse != null) ? new ErrorCode?(awakeDynamicPortalResponse.ErrorCode) : null;
				if (errorCode != null)
				{
					ErrorCode valueOrDefault = errorCode.GetValueOrDefault();
					if (valueOrDefault == ErrorCode.Success || valueOrDefault == ErrorCode.ErrPortalCreatorActive)
					{
						return;
					}
				}
				ErrorCodeController.Instance.OpenErrorCodeTipView(awakeDynamicPortalResponse.ErrorCode, 17133, null, true, true);
			}, 0);
		}

		// Token: 0x0603C5C0 RID: 247232 RVA: 0x01137B94 File Offset: 0x01135D94
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			DynamicPortalCreatorComponent dynamicPortalCreatorComponent = (DynamicPortalCreatorComponent)componentTemplate;
			if (dynamicPortalCreatorComponent.CreatureDataComp == null)
			{
				this.CreatureDataComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComp), "CreatureDataComp"))
			{
				return false;
			}
			if (dynamicPortalCreatorComponent.Config == null)
			{
				this.Config = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Config), "Config"))
			{
				return false;
			}
			if (dynamicPortalCreatorComponent.HitComp == null)
			{
				this.HitComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.HitComp), "HitComp"))
			{
				return false;
			}
			if (dynamicPortalCreatorComponent.BulletIds != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.BulletIds), "BulletIds"))
			{
				return false;
			}
			if (dynamicPortalCreatorComponent.BulletTypeConfig == null)
			{
				this.BulletTypeConfig = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BulletTypeConfig), "BulletTypeConfig"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x170071F3 RID: 29171
		// (get) Token: 0x0603C5C1 RID: 247233 RVA: 0x01137C82 File Offset: 0x01135E82
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170071F4 RID: 29172
		// (get) Token: 0x0603C5C2 RID: 247234 RVA: 0x01137C85 File Offset: 0x01135E85
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170071F5 RID: 29173
		// (get) Token: 0x0603C5C3 RID: 247235 RVA: 0x01137C88 File Offset: 0x01135E88
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401FF3E RID: 130878
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x0401FF3F RID: 130879
		private DynamicPortalCreatorComponent Config;

		// Token: 0x0401FF40 RID: 130880
		private SceneItemHitComponent HitComp;

		// Token: 0x0401FF41 RID: 130881
		[Nullable(1)]
		private readonly List<long> BulletIds = new List<long>();

		// Token: 0x0401FF42 RID: 130882
		private IDynamicPortalByBullet BulletTypeConfig;
	}
}
