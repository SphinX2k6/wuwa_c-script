using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F18 RID: 7960
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkBackgroundClean : ITalkBackground
	{
		// Token: 0x0600AA32 RID: 43570 RVA: 0x0017F588 File Offset: 0x0017D788
		private ITalkBackgroundClean_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkBackgroundClean 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkBackgroundClean_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkBackgroundClean_SetValue());
			}
			return result;
		}

		// Token: 0x0600AA33 RID: 43571 RVA: 0x0017F5C0 File Offset: 0x0017D7C0
		public static ITalkBackgroundClean Create([Nullable(2)] ITalkBackgroundClean instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkBackgroundClean
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AA34 RID: 43572 RVA: 0x0017F5D3 File Offset: 0x0017D7D3
		public static ITalkBackgroundClean CreateFromSetValue([Nullable(2)] ITalkBackgroundClean_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkBackgroundClean
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AA35 RID: 43573 RVA: 0x0017F5E6 File Offset: 0x0017D7E6
		public new ITalkBackgroundClean_SetValue ToSetValue()
		{
			return new ITalkBackgroundClean_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170033CD RID: 13261
		// (get) Token: 0x0600AA36 RID: 43574 RVA: 0x0017F5F9 File Offset: 0x0017D7F9
		// (set) Token: 0x0600AA37 RID: 43575 RVA: 0x0017F624 File Offset: 0x0017D824
		public override ETalkBackgroundType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkBackgroundType.Clean;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006521 RID: 25889
		[Nullable(2)]
		protected new ITalkBackgroundClean FbInstance;

		// Token: 0x04006522 RID: 25890
		[Nullable(2)]
		protected new ITalkBackgroundClean_SetValue PocoInterface;
	}
}
