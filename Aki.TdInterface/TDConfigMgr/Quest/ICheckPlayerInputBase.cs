using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001008 RID: 4104
	public class ICheckPlayerInputBase
	{
		// Token: 0x060059E8 RID: 23016 RVA: 0x000DB644 File Offset: 0x000D9844
		private ICheckPlayerInputBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICheckPlayerInputBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICheckPlayerInputBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICheckPlayerInputBase_SetValue());
			}
			return result;
		}

		// Token: 0x060059E9 RID: 23017 RVA: 0x000DB67C File Offset: 0x000D987C
		public static ICheckPlayerInputBase Create([Nullable(2)] ICheckPlayerInputBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckPlayerInputBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x060059EA RID: 23018 RVA: 0x000DB68F File Offset: 0x000D988F
		public static ICheckPlayerInputBase CreateFromSetValue([Nullable(2)] ICheckPlayerInputBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICheckPlayerInputBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x060059EB RID: 23019 RVA: 0x000DB6A2 File Offset: 0x000D98A2
		public ICheckPlayerInputBase_SetValue ToSetValue()
		{
			return new ICheckPlayerInputBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001DE4 RID: 7652
		// (get) Token: 0x060059EC RID: 23020 RVA: 0x000DB6B5 File Offset: 0x000D98B5
		// (set) Token: 0x060059ED RID: 23021 RVA: 0x000DB6E0 File Offset: 0x000D98E0
		public virtual ECheckPlayerInputType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECheckPlayerInputType.PressButton;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003632 RID: 13874
		[Nullable(2)]
		protected ICheckPlayerInputBase FbInstance;

		// Token: 0x04003633 RID: 13875
		[Nullable(2)]
		protected ICheckPlayerInputBase_SetValue PocoInterface;
	}
}
