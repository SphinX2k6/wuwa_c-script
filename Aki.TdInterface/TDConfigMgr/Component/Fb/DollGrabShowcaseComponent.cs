using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EFB RID: 3835
	[NullableContext(2)]
	[Nullable(0)]
	public class DollGrabShowcaseComponent : IComponentBase
	{
		// Token: 0x06005649 RID: 22089 RVA: 0x000D3C39 File Offset: 0x000D1E39
		[NullableContext(0)]
		public static DollGrabShowcaseComponent Create(IDollGrabShowcaseComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DollGrabShowcaseComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001C4E RID: 7246
		// (get) Token: 0x0600564A RID: 22090 RVA: 0x000D3C58 File Offset: 0x000D1E58
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001C4F RID: 7247
		// (get) Token: 0x0600564B RID: 22091 RVA: 0x000D3C90 File Offset: 0x000D1E90
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C50 RID: 7248
		// (get) Token: 0x0600564C RID: 22092 RVA: 0x000D3CA6 File Offset: 0x000D1EA6
		public virtual EDollGrabShowcaseBelongType BelongType
		{
			get
			{
				return (EDollGrabShowcaseBelongType)this.Instance.BelongType;
			}
		}

		// Token: 0x17001C51 RID: 7249
		// (get) Token: 0x0600564D RID: 22093 RVA: 0x000D3CB4 File Offset: 0x000D1EB4
		public virtual int? BindInfiniteModeDollGrabEntityId
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.BindInfiniteModeDollGrabEntityId);
			}
		}

		// Token: 0x17001C52 RID: 7250
		// (get) Token: 0x0600564E RID: 22094 RVA: 0x000D3CEA File Offset: 0x000D1EEA
		public virtual IDollGrabShowcaseDollCameraConfig CameraConfig
		{
			get
			{
				if (this._CameraConfigInited)
				{
					return this._CameraConfigCache;
				}
				this._CameraConfigInited = true;
				this._CameraConfigCache = IDollGrabShowcaseDollCameraConfig.Create(this.Instance.CameraConfig);
				return this._CameraConfigCache;
			}
		}

		// Token: 0x17001C53 RID: 7251
		// (get) Token: 0x0600564F RID: 22095 RVA: 0x000D3D20 File Offset: 0x000D1F20
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IShowcaseDeliveryReward> DeliveryRewards
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._DeliveryRewardsInited)
				{
					return this._DeliveryRewardsCache;
				}
				this._DeliveryRewardsInited = true;
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				int deliveryRewardsLength = this.Instance.DeliveryRewardsLength;
				this._DeliveryRewardsCache = new List<IShowcaseDeliveryReward>(deliveryRewardsLength);
				for (int i = 0; i < deliveryRewardsLength; i++)
				{
					this._DeliveryRewardsCache.Add(IShowcaseDeliveryReward.Create(this.Instance.DeliveryRewards(i)));
				}
				return this._DeliveryRewardsCache;
			}
		}

		// Token: 0x04003170 RID: 12656
		private IDollGrabShowcaseComponent Instance;

		// Token: 0x04003171 RID: 12657
		private IDollGrabShowcaseDollCameraConfig _CameraConfigCache;

		// Token: 0x04003172 RID: 12658
		private bool _CameraConfigInited;

		// Token: 0x04003173 RID: 12659
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IShowcaseDeliveryReward> _DeliveryRewardsCache;

		// Token: 0x04003174 RID: 12660
		private bool _DeliveryRewardsInited;
	}
}
