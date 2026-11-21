using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024D2 RID: 9426
	public class UnlockSystemItem : ActionParams
	{
		// Token: 0x0600CCEA RID: 52458 RVA: 0x001D2C84 File Offset: 0x001D0E84
		private UnlockSystemItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("UnlockSystemItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			UnlockSystemItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new UnlockSystemItem_SetValue());
			}
			return result;
		}

		// Token: 0x0600CCEB RID: 52459 RVA: 0x001D2CBC File Offset: 0x001D0EBC
		public static UnlockSystemItem Create([Nullable(2)] UnlockSystemItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new UnlockSystemItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CCEC RID: 52460 RVA: 0x001D2CCF File Offset: 0x001D0ECF
		public static UnlockSystemItem CreateFromSetValue([Nullable(2)] UnlockSystemItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new UnlockSystemItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CCED RID: 52461 RVA: 0x001D2CE2 File Offset: 0x001D0EE2
		public UnlockSystemItem_SetValue ToSetValue()
		{
			return new UnlockSystemItem_SetValue
			{
				SystemOption = this.SystemOption
			};
		}

		// Token: 0x17003D5F RID: 15711
		// (get) Token: 0x0600CCEE RID: 52462 RVA: 0x001D2CF5 File Offset: 0x001D0EF5
		// (set) Token: 0x0600CCEF RID: 52463 RVA: 0x001D2D1C File Offset: 0x001D0F1C
		public virtual IUnlockSystemItemType SystemOption
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SystemOption;
				}
				UnlockSystemItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SystemOption;
			}
			set
			{
				this.GetOrCreatePoco().SystemOption = value;
			}
		}

		// Token: 0x04007964 RID: 31076
		[Nullable(2)]
		protected new UnlockSystemItem FbInstance;

		// Token: 0x04007965 RID: 31077
		[Nullable(2)]
		protected UnlockSystemItem_SetValue PocoInterface;
	}
}
