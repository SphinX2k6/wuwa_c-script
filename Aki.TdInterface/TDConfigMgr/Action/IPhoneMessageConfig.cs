using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CE0 RID: 7392
	[NullableContext(1)]
	[Nullable(0)]
	public class IPhoneMessageConfig
	{
		// Token: 0x06009EAD RID: 40621 RVA: 0x0016ACC8 File Offset: 0x00168EC8
		private IPhoneMessageConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPhoneMessageConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPhoneMessageConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPhoneMessageConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06009EAE RID: 40622 RVA: 0x0016AD00 File Offset: 0x00168F00
		public static IPhoneMessageConfig Create([Nullable(2)] IPhoneMessageConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhoneMessageConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009EAF RID: 40623 RVA: 0x0016AD13 File Offset: 0x00168F13
		public static IPhoneMessageConfig CreateFromSetValue([Nullable(2)] IPhoneMessageConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPhoneMessageConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009EB0 RID: 40624 RVA: 0x0016AD26 File Offset: 0x00168F26
		public IPhoneMessageConfig_SetValue ToSetValue()
		{
			return new IPhoneMessageConfig_SetValue
			{
				IsJumpToFirstOption = this.IsJumpToFirstOption
			};
		}

		// Token: 0x1700315D RID: 12637
		// (get) Token: 0x06009EB1 RID: 40625 RVA: 0x0016AD3C File Offset: 0x00168F3C
		// (set) Token: 0x06009EB2 RID: 40626 RVA: 0x0016AD76 File Offset: 0x00168F76
		public virtual bool? IsJumpToFirstOption
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsJumpToFirstOption;
				}
				IPhoneMessageConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsJumpToFirstOption;
			}
			set
			{
				this.GetOrCreatePoco().IsJumpToFirstOption = value;
			}
		}

		// Token: 0x04005FDC RID: 24540
		[Nullable(2)]
		protected IPhoneMessageConfig FbInstance;

		// Token: 0x04005FDD RID: 24541
		[Nullable(2)]
		protected IPhoneMessageConfig_SetValue PocoInterface;
	}
}
