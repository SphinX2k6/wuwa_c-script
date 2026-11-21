using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012B4 RID: 4788
	public class ITakePhoto2TargetCameraDistanceCondition
	{
		// Token: 0x06006BD7 RID: 27607 RVA: 0x001014F0 File Offset: 0x000FF6F0
		private ITakePhoto2TargetCameraDistanceCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITakePhoto2TargetCameraDistanceCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITakePhoto2TargetCameraDistanceCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITakePhoto2TargetCameraDistanceCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06006BD8 RID: 27608 RVA: 0x00101528 File Offset: 0x000FF728
		public static ITakePhoto2TargetCameraDistanceCondition Create([Nullable(2)] ITakePhoto2TargetCameraDistanceCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2TargetCameraDistanceCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006BD9 RID: 27609 RVA: 0x0010153B File Offset: 0x000FF73B
		public static ITakePhoto2TargetCameraDistanceCondition CreateFromSetValue([Nullable(2)] ITakePhoto2TargetCameraDistanceCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITakePhoto2TargetCameraDistanceCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006BDA RID: 27610 RVA: 0x0010154E File Offset: 0x000FF74E
		public ITakePhoto2TargetCameraDistanceCondition_SetValue ToSetValue()
		{
			return new ITakePhoto2TargetCameraDistanceCondition_SetValue
			{
				MaxDistance = this.MaxDistance
			};
		}

		// Token: 0x170022DD RID: 8925
		// (get) Token: 0x06006BDB RID: 27611 RVA: 0x00101561 File Offset: 0x000FF761
		// (set) Token: 0x06006BDC RID: 27612 RVA: 0x0010158C File Offset: 0x000FF78C
		public virtual int MaxDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxDistance;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MaxDistance;
			}
			set
			{
				this.GetOrCreatePoco().MaxDistance = value;
			}
		}

		// Token: 0x04004065 RID: 16485
		[Nullable(2)]
		protected ITakePhoto2TargetCameraDistanceCondition FbInstance;

		// Token: 0x04004066 RID: 16486
		[Nullable(2)]
		protected ITakePhoto2TargetCameraDistanceCondition_SetValue PocoInterface;
	}
}
