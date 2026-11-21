using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E4F RID: 7759
	public class INewSplineMoveTarget
	{
		// Token: 0x0600A4F9 RID: 42233 RVA: 0x001788F4 File Offset: 0x00176AF4
		private INewSplineMoveTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INewSplineMoveTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INewSplineMoveTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INewSplineMoveTarget_SetValue());
			}
			return result;
		}

		// Token: 0x0600A4FA RID: 42234 RVA: 0x0017892C File Offset: 0x00176B2C
		public static INewSplineMoveTarget Create([Nullable(2)] INewSplineMoveTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INewSplineMoveTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A4FB RID: 42235 RVA: 0x0017893F File Offset: 0x00176B3F
		public static INewSplineMoveTarget CreateFromSetValue([Nullable(2)] INewSplineMoveTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INewSplineMoveTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A4FC RID: 42236 RVA: 0x00178952 File Offset: 0x00176B52
		public INewSplineMoveTarget_SetValue ToSetValue()
		{
			return new INewSplineMoveTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003314 RID: 13076
		// (get) Token: 0x0600A4FD RID: 42237 RVA: 0x00178965 File Offset: 0x00176B65
		// (set) Token: 0x0600A4FE RID: 42238 RVA: 0x00178990 File Offset: 0x00176B90
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

		// Token: 0x040063B5 RID: 25525
		[Nullable(2)]
		protected INewSplineMoveTarget FbInstance;

		// Token: 0x040063B6 RID: 25526
		[Nullable(2)]
		protected INewSplineMoveTarget_SetValue PocoInterface;
	}
}
