using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014B0 RID: 5296
	[NullableContext(1)]
	[Nullable(0)]
	public class BvbPlayDialog : ActionParams
	{
		// Token: 0x06007894 RID: 30868 RVA: 0x001210E0 File Offset: 0x0011F2E0
		private BvbPlayDialog_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("BvbPlayDialog 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			BvbPlayDialog_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new BvbPlayDialog_SetValue());
			}
			return result;
		}

		// Token: 0x06007895 RID: 30869 RVA: 0x00121118 File Offset: 0x0011F318
		public static BvbPlayDialog Create([Nullable(2)] BvbPlayDialog instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new BvbPlayDialog
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007896 RID: 30870 RVA: 0x0012112B File Offset: 0x0011F32B
		public static BvbPlayDialog CreateFromSetValue([Nullable(2)] BvbPlayDialog_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new BvbPlayDialog
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007897 RID: 30871 RVA: 0x0012113E File Offset: 0x0011F33E
		public BvbPlayDialog_SetValue ToSetValue()
		{
			return new BvbPlayDialog_SetValue
			{
				DialogType = this.DialogType
			};
		}

		// Token: 0x17002878 RID: 10360
		// (get) Token: 0x06007898 RID: 30872 RVA: 0x00121151 File Offset: 0x0011F351
		// (set) Token: 0x06007899 RID: 30873 RVA: 0x0012117C File Offset: 0x0011F37C
		public virtual EBvbPlayDialogType DialogType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DialogType;
				}
				if (this.PocoInterface == null)
				{
					return EBvbPlayDialogType.DungeonBegin;
				}
				return this.PocoInterface.DialogType;
			}
			set
			{
				this.GetOrCreatePoco().DialogType = value;
			}
		}

		// Token: 0x04004611 RID: 17937
		[Nullable(2)]
		protected new BvbPlayDialog FbInstance;

		// Token: 0x04004612 RID: 17938
		[Nullable(2)]
		protected BvbPlayDialog_SetValue PocoInterface;
	}
}
