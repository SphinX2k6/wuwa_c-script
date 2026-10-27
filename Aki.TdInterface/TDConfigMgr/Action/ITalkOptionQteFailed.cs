using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F7A RID: 8058
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkOptionQteFailed : ITalkOptionParamType
	{
		// Token: 0x0600B14A RID: 45386 RVA: 0x0019DD2C File Offset: 0x0019BF2C
		private ITalkOptionQteFailed_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkOptionQteFailed 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkOptionQteFailed_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkOptionQteFailed_SetValue());
			}
			return result;
		}

		// Token: 0x0600B14B RID: 45387 RVA: 0x0019DD64 File Offset: 0x0019BF64
		public static ITalkOptionQteFailed Create([Nullable(2)] ITalkOptionQteFailed instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionQteFailed
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B14C RID: 45388 RVA: 0x0019DD77 File Offset: 0x0019BF77
		public static ITalkOptionQteFailed CreateFromSetValue([Nullable(2)] ITalkOptionQteFailed_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkOptionQteFailed
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B14D RID: 45389 RVA: 0x0019DD8A File Offset: 0x0019BF8A
		public new ITalkOptionQteFailed_SetValue ToSetValue()
		{
			return new ITalkOptionQteFailed_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170036C6 RID: 14022
		// (get) Token: 0x0600B14E RID: 45390 RVA: 0x0019DD9D File Offset: 0x0019BF9D
		// (set) Token: 0x0600B14F RID: 45391 RVA: 0x0019DDC8 File Offset: 0x0019BFC8
		public override ETalkOptionParamType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkOptionParamType.QteSucceed;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006B3D RID: 27453
		[Nullable(2)]
		protected new ITalkOptionQteFailed FbInstance;

		// Token: 0x04006B3E RID: 27454
		[Nullable(2)]
		protected new ITalkOptionQteFailed_SetValue PocoInterface;
	}
}
