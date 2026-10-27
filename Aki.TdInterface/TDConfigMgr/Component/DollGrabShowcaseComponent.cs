using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000054 RID: 84
	[NullableContext(1)]
	[Nullable(0)]
	public class DollGrabShowcaseComponent : IComponentBase
	{
		// Token: 0x060002D0 RID: 720 RVA: 0x0001A75C File Offset: 0x0001895C
		private DollGrabShowcaseComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("DollGrabShowcaseComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			DollGrabShowcaseComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new DollGrabShowcaseComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0001A794 File Offset: 0x00018994
		public static DollGrabShowcaseComponent Create([Nullable(2)] DollGrabShowcaseComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DollGrabShowcaseComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0001A7A7 File Offset: 0x000189A7
		public static DollGrabShowcaseComponent CreateFromSetValue([Nullable(2)] DollGrabShowcaseComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new DollGrabShowcaseComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0001A7BC File Offset: 0x000189BC
		public new DollGrabShowcaseComponent_SetValue ToSetValue()
		{
			return new DollGrabShowcaseComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				BelongType = this.BelongType,
				BindInfiniteModeDollGrabEntityId = this.BindInfiniteModeDollGrabEntityId,
				CameraConfig = this.CameraConfig,
				DeliveryRewards = this.DeliveryRewards
			};
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x0001A818 File Offset: 0x00018A18
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x0001A852 File Offset: 0x00018A52
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				DollGrabShowcaseComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x0001A860 File Offset: 0x00018A60
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x0001A88A File Offset: 0x00018A8A
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x0001A898 File Offset: 0x00018A98
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x0001A8C3 File Offset: 0x00018AC3
		public virtual EDollGrabShowcaseBelongType BelongType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BelongType;
				}
				if (this.PocoInterface == null)
				{
					return EDollGrabShowcaseBelongType.LandOfXuanfang;
				}
				return this.PocoInterface.BelongType;
			}
			set
			{
				this.GetOrCreatePoco().BelongType = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060002DA RID: 730 RVA: 0x0001A8D4 File Offset: 0x00018AD4
		// (set) Token: 0x060002DB RID: 731 RVA: 0x0001A90E File Offset: 0x00018B0E
		public virtual int? BindInfiniteModeDollGrabEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BindInfiniteModeDollGrabEntityId;
				}
				DollGrabShowcaseComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BindInfiniteModeDollGrabEntityId;
			}
			set
			{
				this.GetOrCreatePoco().BindInfiniteModeDollGrabEntityId = value;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060002DC RID: 732 RVA: 0x0001A91C File Offset: 0x00018B1C
		// (set) Token: 0x060002DD RID: 733 RVA: 0x0001A97D File Offset: 0x00018B7D
		[Nullable(2)]
		public virtual IDollGrabShowcaseDollCameraConfig CameraConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._CameraConfigInited)
				{
					return this._CameraConfigCache;
				}
				this._CameraConfigInited = true;
				if (this.FbInstance != null)
				{
					this._CameraConfigCache = IDollGrabShowcaseDollCameraConfig.Create(this.FbInstance.CameraConfig);
				}
				else
				{
					DollGrabShowcaseComponent_SetValue pocoInterface = this.PocoInterface;
					this._CameraConfigCache = ((pocoInterface != null) ? pocoInterface.CameraConfig : null);
				}
				return this._CameraConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().CameraConfig = value;
				this._CameraConfigInited = false;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060002DE RID: 734 RVA: 0x0001A994 File Offset: 0x00018B94
		// (set) Token: 0x060002DF RID: 735 RVA: 0x0001AA27 File Offset: 0x00018C27
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
				if (this.FbInstance != null)
				{
					List<IShowcaseDeliveryReward> deliveryRewards = this.FbInstance.DeliveryRewards;
					if (deliveryRewards != null)
					{
						this._DeliveryRewardsCache = new List<IShowcaseDeliveryReward>(deliveryRewards.Count);
						for (int i = 0; i < deliveryRewards.Count; i++)
						{
							this._DeliveryRewardsCache.Add(IShowcaseDeliveryReward.Create(deliveryRewards[i]));
						}
					}
				}
				else
				{
					DollGrabShowcaseComponent_SetValue pocoInterface = this.PocoInterface;
					this._DeliveryRewardsCache = ((pocoInterface != null) ? pocoInterface.DeliveryRewards : null);
				}
				return this._DeliveryRewardsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().DeliveryRewards = value;
				this._DeliveryRewardsInited = false;
			}
		}

		// Token: 0x040001CF RID: 463
		[Nullable(2)]
		protected new DollGrabShowcaseComponent FbInstance;

		// Token: 0x040001D0 RID: 464
		[Nullable(2)]
		protected new DollGrabShowcaseComponent_SetValue PocoInterface;

		// Token: 0x040001D1 RID: 465
		private IDollGrabShowcaseDollCameraConfig _CameraConfigCache;

		// Token: 0x040001D2 RID: 466
		private bool _CameraConfigInited;

		// Token: 0x040001D3 RID: 467
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IShowcaseDeliveryReward> _DeliveryRewardsCache;

		// Token: 0x040001D4 RID: 468
		private bool _DeliveryRewardsInited;
	}
}
