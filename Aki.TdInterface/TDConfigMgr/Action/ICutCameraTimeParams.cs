using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AE9 RID: 6889
	public class ICutCameraTimeParams
	{
		// Token: 0x06009253 RID: 37459 RVA: 0x00156E94 File Offset: 0x00155094
		private ICutCameraTimeParams_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICutCameraTimeParams 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICutCameraTimeParams_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICutCameraTimeParams_SetValue());
			}
			return result;
		}

		// Token: 0x06009254 RID: 37460 RVA: 0x00156ECC File Offset: 0x001550CC
		public static ICutCameraTimeParams Create([Nullable(2)] ICutCameraTimeParams instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICutCameraTimeParams
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009255 RID: 37461 RVA: 0x00156EDF File Offset: 0x001550DF
		public static ICutCameraTimeParams CreateFromSetValue([Nullable(2)] ICutCameraTimeParams_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICutCameraTimeParams
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009256 RID: 37462 RVA: 0x00156EF2 File Offset: 0x001550F2
		public ICutCameraTimeParams_SetValue ToSetValue()
		{
			return new ICutCameraTimeParams_SetValue
			{
				CutStayTime = this.CutStayTime
			};
		}

		// Token: 0x17002ED8 RID: 11992
		// (get) Token: 0x06009257 RID: 37463 RVA: 0x00156F05 File Offset: 0x00155105
		// (set) Token: 0x06009258 RID: 37464 RVA: 0x00156F34 File Offset: 0x00155134
		public virtual float CutStayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CutStayTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.CutStayTime;
			}
			set
			{
				this.GetOrCreatePoco().CutStayTime = value;
			}
		}

		// Token: 0x04005B2D RID: 23341
		[Nullable(2)]
		protected ICutCameraTimeParams FbInstance;

		// Token: 0x04005B2E RID: 23342
		[Nullable(2)]
		protected ICutCameraTimeParams_SetValue PocoInterface;
	}
}
