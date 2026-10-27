using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002265 RID: 8805
	[NullableContext(1)]
	[Nullable(0)]
	public class UnlockSystemItem : ActionParams
	{
		// Token: 0x0600C124 RID: 49444 RVA: 0x001BB500 File Offset: 0x001B9700
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

		// Token: 0x0600C125 RID: 49445 RVA: 0x001BB538 File Offset: 0x001B9738
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

		// Token: 0x0600C126 RID: 49446 RVA: 0x001BB54B File Offset: 0x001B974B
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

		// Token: 0x0600C127 RID: 49447 RVA: 0x001BB55E File Offset: 0x001B975E
		public UnlockSystemItem_SetValue ToSetValue()
		{
			return new UnlockSystemItem_SetValue
			{
				SystemOption = this.SystemOption
			};
		}

		// Token: 0x17003A68 RID: 14952
		// (get) Token: 0x0600C128 RID: 49448 RVA: 0x001BB571 File Offset: 0x001B9771
		// (set) Token: 0x0600C129 RID: 49449 RVA: 0x001BB598 File Offset: 0x001B9798
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

		// Token: 0x04007317 RID: 29463
		[Nullable(2)]
		protected new UnlockSystemItem FbInstance;

		// Token: 0x04007318 RID: 29464
		[Nullable(2)]
		protected UnlockSystemItem_SetValue PocoInterface;
	}
}
