using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DFF RID: 3583
	[NullableContext(2)]
	[Nullable(0)]
	public class DollGrabShowcaseComponent : IComponentBase
	{
		// Token: 0x06005122 RID: 20770 RVA: 0x000C8371 File Offset: 0x000C6571
		[NullableContext(1)]
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

		// Token: 0x17001AE1 RID: 6881
		// (get) Token: 0x06005123 RID: 20771 RVA: 0x000C8390 File Offset: 0x000C6590
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

		// Token: 0x17001AE2 RID: 6882
		// (get) Token: 0x06005124 RID: 20772 RVA: 0x000C83C8 File Offset: 0x000C65C8
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001AE3 RID: 6883
		// (get) Token: 0x06005125 RID: 20773 RVA: 0x000C83DE File Offset: 0x000C65DE
		public virtual EDollGrabShowcaseBelongType BelongType
		{
			get
			{
				return (EDollGrabShowcaseBelongType)this.Instance.BelongType;
			}
		}

		// Token: 0x17001AE4 RID: 6884
		// (get) Token: 0x06005126 RID: 20774 RVA: 0x000C83EC File Offset: 0x000C65EC
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

		// Token: 0x17001AE5 RID: 6885
		// (get) Token: 0x06005127 RID: 20775 RVA: 0x000C8422 File Offset: 0x000C6622
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

		// Token: 0x17001AE6 RID: 6886
		// (get) Token: 0x06005128 RID: 20776 RVA: 0x000C8458 File Offset: 0x000C6658
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IShowcaseDeliveryReward> DeliveryRewards
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x04002EA8 RID: 11944
		private IDollGrabShowcaseComponent Instance;

		// Token: 0x04002EA9 RID: 11945
		private IDollGrabShowcaseDollCameraConfig _CameraConfigCache;

		// Token: 0x04002EAA RID: 11946
		private bool _CameraConfigInited;

		// Token: 0x04002EAB RID: 11947
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IShowcaseDeliveryReward> _DeliveryRewardsCache;

		// Token: 0x04002EAC RID: 11948
		private bool _DeliveryRewardsInited;
	}
}
