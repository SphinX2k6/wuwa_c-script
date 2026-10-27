using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020F2 RID: 8434
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemBoardWithReturn : ActionParams
	{
		// Token: 0x0600B998 RID: 47512 RVA: 0x001AD26C File Offset: 0x001AB46C
		private OpenSystemBoardWithReturn_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("OpenSystemBoardWithReturn 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			OpenSystemBoardWithReturn_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new OpenSystemBoardWithReturn_SetValue());
			}
			return result;
		}

		// Token: 0x0600B999 RID: 47513 RVA: 0x001AD2A4 File Offset: 0x001AB4A4
		public static OpenSystemBoardWithReturn Create([Nullable(2)] OpenSystemBoardWithReturn instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new OpenSystemBoardWithReturn
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B99A RID: 47514 RVA: 0x001AD2B7 File Offset: 0x001AB4B7
		public static OpenSystemBoardWithReturn CreateFromSetValue([Nullable(2)] OpenSystemBoardWithReturn_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new OpenSystemBoardWithReturn
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B99B RID: 47515 RVA: 0x001AD2CA File Offset: 0x001AB4CA
		public OpenSystemBoardWithReturn_SetValue ToSetValue()
		{
			return new OpenSystemBoardWithReturn_SetValue
			{
				SystemType = this.SystemType
			};
		}

		// Token: 0x170038BA RID: 14522
		// (get) Token: 0x0600B99C RID: 47516 RVA: 0x001AD2DD File Offset: 0x001AB4DD
		// (set) Token: 0x0600B99D RID: 47517 RVA: 0x001AD304 File Offset: 0x001AB504
		public virtual IOpenSystemBoardWithReturnType SystemType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SystemType;
				}
				OpenSystemBoardWithReturn_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SystemType;
			}
			set
			{
				this.GetOrCreatePoco().SystemType = value;
			}
		}

		// Token: 0x04006F2A RID: 28458
		[Nullable(2)]
		protected new OpenSystemBoardWithReturn FbInstance;

		// Token: 0x04006F2B RID: 28459
		[Nullable(2)]
		protected OpenSystemBoardWithReturn_SetValue PocoInterface;
	}
}
