using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021DE RID: 8670
	[NullableContext(1)]
	[Nullable(0)]
	public class SetSubScreenMode : ActionParams
	{
		// Token: 0x0600BE7F RID: 48767 RVA: 0x001B68DC File Offset: 0x001B4ADC
		private SetSubScreenMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetSubScreenMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetSubScreenMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetSubScreenMode_SetValue());
			}
			return result;
		}

		// Token: 0x0600BE80 RID: 48768 RVA: 0x001B6914 File Offset: 0x001B4B14
		public static SetSubScreenMode Create([Nullable(2)] SetSubScreenMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetSubScreenMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BE81 RID: 48769 RVA: 0x001B6927 File Offset: 0x001B4B27
		public static SetSubScreenMode CreateFromSetValue([Nullable(2)] SetSubScreenMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetSubScreenMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BE82 RID: 48770 RVA: 0x001B693A File Offset: 0x001B4B3A
		public SetSubScreenMode_SetValue ToSetValue()
		{
			return new SetSubScreenMode_SetValue
			{
				Config = this.Config
			};
		}

		// Token: 0x170039D4 RID: 14804
		// (get) Token: 0x0600BE83 RID: 48771 RVA: 0x001B694D File Offset: 0x001B4B4D
		// (set) Token: 0x0600BE84 RID: 48772 RVA: 0x001B6974 File Offset: 0x001B4B74
		public virtual ISubScreenModeConfig Config
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Config;
				}
				SetSubScreenMode_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Config;
			}
			set
			{
				this.GetOrCreatePoco().Config = value;
			}
		}

		// Token: 0x040071AE RID: 29102
		[Nullable(2)]
		protected new SetSubScreenMode FbInstance;

		// Token: 0x040071AF RID: 29103
		[Nullable(2)]
		protected SetSubScreenMode_SetValue PocoInterface;
	}
}
