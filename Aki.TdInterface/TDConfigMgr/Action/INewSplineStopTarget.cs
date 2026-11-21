using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E53 RID: 7763
	public class INewSplineStopTarget
	{
		// Token: 0x0600A509 RID: 42249 RVA: 0x00178A6C File Offset: 0x00176C6C
		private INewSplineStopTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INewSplineStopTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INewSplineStopTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INewSplineStopTarget_SetValue());
			}
			return result;
		}

		// Token: 0x0600A50A RID: 42250 RVA: 0x00178AA4 File Offset: 0x00176CA4
		public static INewSplineStopTarget Create([Nullable(2)] INewSplineStopTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INewSplineStopTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A50B RID: 42251 RVA: 0x00178AB7 File Offset: 0x00176CB7
		public static INewSplineStopTarget CreateFromSetValue([Nullable(2)] INewSplineStopTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INewSplineStopTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A50C RID: 42252 RVA: 0x00178ACA File Offset: 0x00176CCA
		public INewSplineStopTarget_SetValue ToSetValue()
		{
			return new INewSplineStopTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003316 RID: 13078
		// (get) Token: 0x0600A50D RID: 42253 RVA: 0x00178ADD File Offset: 0x00176CDD
		// (set) Token: 0x0600A50E RID: 42254 RVA: 0x00178B08 File Offset: 0x00176D08
		public virtual ENewSplineMoveTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENewSplineMoveTargetType.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040063BB RID: 25531
		[Nullable(2)]
		protected INewSplineStopTarget FbInstance;

		// Token: 0x040063BC RID: 25532
		[Nullable(2)]
		protected INewSplineStopTarget_SetValue PocoInterface;
	}
}
