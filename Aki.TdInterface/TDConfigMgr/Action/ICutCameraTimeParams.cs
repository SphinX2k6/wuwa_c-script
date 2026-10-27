using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200195E RID: 6494
	[NullableContext(1)]
	[Nullable(0)]
	public class ICutCameraTimeParams
	{
		// Token: 0x06008B1D RID: 35613 RVA: 0x00147458 File Offset: 0x00145658
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

		// Token: 0x06008B1E RID: 35614 RVA: 0x00147490 File Offset: 0x00145690
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

		// Token: 0x06008B1F RID: 35615 RVA: 0x001474A3 File Offset: 0x001456A3
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

		// Token: 0x06008B20 RID: 35616 RVA: 0x001474B6 File Offset: 0x001456B6
		public ICutCameraTimeParams_SetValue ToSetValue()
		{
			return new ICutCameraTimeParams_SetValue
			{
				CutStayTime = this.CutStayTime
			};
		}

		// Token: 0x17002CD6 RID: 11478
		// (get) Token: 0x06008B21 RID: 35617 RVA: 0x001474C9 File Offset: 0x001456C9
		// (set) Token: 0x06008B22 RID: 35618 RVA: 0x001474F8 File Offset: 0x001456F8
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

		// Token: 0x040056D9 RID: 22233
		[Nullable(2)]
		protected ICutCameraTimeParams FbInstance;

		// Token: 0x040056DA RID: 22234
		[Nullable(2)]
		protected ICutCameraTimeParams_SetValue PocoInterface;
	}
}
