using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FE6 RID: 4070
	public class IAtomicProcessBase
	{
		// Token: 0x06005934 RID: 22836 RVA: 0x000D9F28 File Offset: 0x000D8128
		private IAtomicProcessBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAtomicProcessBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAtomicProcessBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAtomicProcessBase_SetValue());
			}
			return result;
		}

		// Token: 0x06005935 RID: 22837 RVA: 0x000D9F60 File Offset: 0x000D8160
		public static IAtomicProcessBase Create([Nullable(2)] IAtomicProcessBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAtomicProcessBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005936 RID: 22838 RVA: 0x000D9F73 File Offset: 0x000D8173
		public static IAtomicProcessBase CreateFromSetValue([Nullable(2)] IAtomicProcessBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAtomicProcessBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005937 RID: 22839 RVA: 0x000D9F86 File Offset: 0x000D8186
		public IAtomicProcessBase_SetValue ToSetValue()
		{
			return new IAtomicProcessBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001DBB RID: 7611
		// (get) Token: 0x06005938 RID: 22840 RVA: 0x000D9F99 File Offset: 0x000D8199
		// (set) Token: 0x06005939 RID: 22841 RVA: 0x000D9FC4 File Offset: 0x000D81C4
		public virtual EAtomicProcess Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAtomicProcess.StoveCoreFall;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040035C0 RID: 13760
		[Nullable(2)]
		protected IAtomicProcessBase FbInstance;

		// Token: 0x040035C1 RID: 13761
		[Nullable(2)]
		protected IAtomicProcessBase_SetValue PocoInterface;
	}
}
