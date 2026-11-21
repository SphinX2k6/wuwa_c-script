using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200083F RID: 2111
	public class ITrampleTipType
	{
		// Token: 0x06002D70 RID: 11632 RVA: 0x000762BC File Offset: 0x000744BC
		private ITrampleTipType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrampleTipType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrampleTipType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrampleTipType_SetValue());
			}
			return result;
		}

		// Token: 0x06002D71 RID: 11633 RVA: 0x000762F4 File Offset: 0x000744F4
		public static ITrampleTipType Create([Nullable(2)] ITrampleTipType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrampleTipType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002D72 RID: 11634 RVA: 0x00076307 File Offset: 0x00074507
		public static ITrampleTipType CreateFromSetValue([Nullable(2)] ITrampleTipType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrampleTipType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002D73 RID: 11635 RVA: 0x0007631A File Offset: 0x0007451A
		public ITrampleTipType_SetValue ToSetValue()
		{
			return new ITrampleTipType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x06002D74 RID: 11636 RVA: 0x0007632D File Offset: 0x0007452D
		// (set) Token: 0x06002D75 RID: 11637 RVA: 0x00076358 File Offset: 0x00074558
		public virtual ETrampleTipType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETrampleTipType.CountDownTextTip;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001E4A RID: 7754
		[Nullable(2)]
		protected ITrampleTipType FbInstance;

		// Token: 0x04001E4B RID: 7755
		[Nullable(2)]
		protected ITrampleTipType_SetValue PocoInterface;
	}
}
