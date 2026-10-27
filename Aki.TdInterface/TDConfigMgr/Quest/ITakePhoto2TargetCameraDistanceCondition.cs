using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200117A RID: 4474
	[NullableContext(1)]
	[Nullable(0)]
	public class ITakePhoto2TargetCameraDistanceCondition
	{
		// Token: 0x060065A0 RID: 26016 RVA: 0x000F3D24 File Offset: 0x000F1F24
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

		// Token: 0x060065A1 RID: 26017 RVA: 0x000F3D5C File Offset: 0x000F1F5C
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

		// Token: 0x060065A2 RID: 26018 RVA: 0x000F3D6F File Offset: 0x000F1F6F
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

		// Token: 0x060065A3 RID: 26019 RVA: 0x000F3D82 File Offset: 0x000F1F82
		public ITakePhoto2TargetCameraDistanceCondition_SetValue ToSetValue()
		{
			return new ITakePhoto2TargetCameraDistanceCondition_SetValue
			{
				MaxDistance = this.MaxDistance
			};
		}

		// Token: 0x1700211E RID: 8478
		// (get) Token: 0x060065A4 RID: 26020 RVA: 0x000F3D95 File Offset: 0x000F1F95
		// (set) Token: 0x060065A5 RID: 26021 RVA: 0x000F3DC0 File Offset: 0x000F1FC0
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

		// Token: 0x04003CFD RID: 15613
		[Nullable(2)]
		protected ITakePhoto2TargetCameraDistanceCondition FbInstance;

		// Token: 0x04003CFE RID: 15614
		[Nullable(2)]
		protected ITakePhoto2TargetCameraDistanceCondition_SetValue PocoInterface;
	}
}
