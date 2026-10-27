using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x0200715E RID: 29022
	[NullableContext(2)]
	[Nullable(0)]
	public class DynamicPortalCreatorComponent : EntityComponent
	{
		// Token: 0x06046D77 RID: 290167 RVA: 0x011DBBA4 File Offset: 0x011D9DA4
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

		// Token: 0x06046D78 RID: 290168 RVA: 0x011DBC25 File Offset: 0x011D9E25
		protected override bool OnStart()
		{
			this.CreatureDataComp = base.Entity.GetComponent<CreatureDataComponent>();
			if (this.Config.Model.Type == EDynamicPortalCreateType.Bullet)
			{
				this.HitComp = base.Entity.GetComponent<SceneItemHitComponent>();
			}
			return true;
		}

		// Token: 0x06046D79 RID: 290169 RVA: 0x011DBC5C File Offset: 0x011D9E5C
		protected override void OnActivate()
		{
			if (this.Config.Model.Type == EDynamicPortalCreateType.Bullet)
			{
				this.AddHitEvent();
			}
		}

		// Token: 0x06046D7A RID: 290170 RVA: 0x011DBC76 File Offset: 0x011D9E76
		protected override bool OnEnd()
		{
			if (this.Config.Model.Type == EDynamicPortalCreateType.Bullet)
			{
				this.RemoveHitEvent();
			}
			return true;
		}

		// Token: 0x06046D7B RID: 290171 RVA: 0x011DBC91 File Offset: 0x011D9E91
		public IPortalRenderConfig GetPortalRenderConfig()
		{
			DynamicPortalCreatorComponent config = this.Config;
			if (config == null)
			{
				return null;
			}
			return config.Model.RenderConfig;
		}

		// Token: 0x06046D7C RID: 290172 RVA: 0x011DBCA9 File Offset: 0x011D9EA9
		private void AddHitEvent()
		{
			if (this.HitComp == null)
			{
				return;
			}
			this.HitComp.AddComponentHitCondition(this, new SceneItemHitComponent.TSceneItemHitConditionCheck(this.HitBulletIdCheck));
			EventSystem.Instance.AddWithTarget<global::HitInformation>(this, EEventName.OnSceneItemHitByHitData, new Action<global::HitInformation>(this.OnSceneItemHit));
		}

		// Token: 0x06046D7D RID: 290173 RVA: 0x011DBCEC File Offset: 0x011D9EEC
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

		// Token: 0x06046D7E RID: 290174 RVA: 0x011DBD58 File Offset: 0x011D9F58
		[NullableContext(1)]
		private bool HitBulletIdCheck(global::HitInformation hitData)
		{
			long bulletId = hitData.BulletId;
			return this.BulletIds.Contains(bulletId);
		}

		// Token: 0x06046D7F RID: 290175 RVA: 0x011DBD78 File Offset: 0x011D9F78
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(awakeDynamicPortalResponse.ErrorCode, 29309, null, true, true);
			}, 0);
		}

		// Token: 0x06046D80 RID: 290176 RVA: 0x011DBE04 File Offset: 0x011DA004
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			DynamicPortalCreatorComponent dynamicPortalCreatorComponent = (DynamicPortalCreatorComponent)componentTemplate;
			if (base.CanResetComponentProperty("CreatureDataComp"))
			{
				if (dynamicPortalCreatorComponent.CreatureDataComp == null)
				{
					this.CreatureDataComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureDataComp), "CreatureDataComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("Config"))
			{
				if (dynamicPortalCreatorComponent.Config == null)
				{
					this.Config = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<DynamicPortalCreatorComponent>(this.Config), "Config"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("HitComp"))
			{
				if (dynamicPortalCreatorComponent.HitComp == null)
				{
					this.HitComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemHitComponent>(this.HitComp), "HitComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("BulletIds") && dynamicPortalCreatorComponent.BulletIds != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<long>>(this.BulletIds), "BulletIds"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("BulletTypeConfig"))
			{
				if (dynamicPortalCreatorComponent.BulletTypeConfig == null)
				{
					this.BulletTypeConfig = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<IDynamicPortalByBullet>(this.BulletTypeConfig), "BulletTypeConfig"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x040252D7 RID: 152279
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x040252D8 RID: 152280
		private DynamicPortalCreatorComponent Config;

		// Token: 0x040252D9 RID: 152281
		private SceneItemHitComponent HitComp;

		// Token: 0x040252DA RID: 152282
		[Nullable(1)]
		private readonly List<long> BulletIds = new List<long>();

		// Token: 0x040252DB RID: 152283
		private IDynamicPortalByBullet BulletTypeConfig;
	}
}
