using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B98 RID: 7064
	[NullableContext(1)]
	[Nullable(0)]
	public class ILimitPlayerUI : ILimitPlayerOption
	{
		// Token: 0x0600973B RID: 38715 RVA: 0x0015CE08 File Offset: 0x0015B008
		private ILimitPlayerUI_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILimitPlayerUI 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILimitPlayerUI_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILimitPlayerUI_SetValue());
			}
			return result;
		}

		// Token: 0x0600973C RID: 38716 RVA: 0x0015CE40 File Offset: 0x0015B040
		public static ILimitPlayerUI Create([Nullable(2)] ILimitPlayerUI instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILimitPlayerUI
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600973D RID: 38717 RVA: 0x0015CE53 File Offset: 0x0015B053
		public static ILimitPlayerUI CreateFromSetValue([Nullable(2)] ILimitPlayerUI_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILimitPlayerUI
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600973E RID: 38718 RVA: 0x0015CE66 File Offset: 0x0015B066
		public new ILimitPlayerUI_SetValue ToSetValue()
		{
			return new ILimitPlayerUI_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F90 RID: 12176
		// (get) Token: 0x0600973F RID: 38719 RVA: 0x0015CE79 File Offset: 0x0015B079
		// (set) Token: 0x06009740 RID: 38720 RVA: 0x0015CEA4 File Offset: 0x0015B0A4
		public override ELimitPlayOperation Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELimitPlayOperation.AllowCamera;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005C53 RID: 23635
		[Nullable(2)]
		protected new ILimitPlayerUI FbInstance;

		// Token: 0x04005C54 RID: 23636
		[Nullable(2)]
		protected new ILimitPlayerUI_SetValue PocoInterface;
	}
}
