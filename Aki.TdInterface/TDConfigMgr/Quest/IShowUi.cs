using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001262 RID: 4706
	public class IShowUi
	{
		// Token: 0x060069FF RID: 27135 RVA: 0x000FDD64 File Offset: 0x000FBF64
		private IShowUi_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IShowUi 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IShowUi_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IShowUi_SetValue());
			}
			return result;
		}

		// Token: 0x06006A00 RID: 27136 RVA: 0x000FDD9C File Offset: 0x000FBF9C
		public static IShowUi Create([Nullable(2)] IShowUi instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowUi
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006A01 RID: 27137 RVA: 0x000FDDAF File Offset: 0x000FBFAF
		public static IShowUi CreateFromSetValue([Nullable(2)] IShowUi_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IShowUi
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006A02 RID: 27138 RVA: 0x000FDDC2 File Offset: 0x000FBFC2
		public IShowUi_SetValue ToSetValue()
		{
			return new IShowUi_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700226C RID: 8812
		// (get) Token: 0x06006A03 RID: 27139 RVA: 0x000FDDD5 File Offset: 0x000FBFD5
		// (set) Token: 0x06006A04 RID: 27140 RVA: 0x000FDE00 File Offset: 0x000FC000
		public virtual EShowUiType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EShowUiType.All;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003F76 RID: 16246
		[Nullable(2)]
		protected IShowUi FbInstance;

		// Token: 0x04003F77 RID: 16247
		[Nullable(2)]
		protected IShowUi_SetValue PocoInterface;
	}
}
