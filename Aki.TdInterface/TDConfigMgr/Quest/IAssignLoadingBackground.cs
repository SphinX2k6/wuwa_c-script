using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FE2 RID: 4066
	public class IAssignLoadingBackground : IOperation
	{
		// Token: 0x0600591E RID: 22814 RVA: 0x000D9C64 File Offset: 0x000D7E64
		private IAssignLoadingBackground_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAssignLoadingBackground 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAssignLoadingBackground_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAssignLoadingBackground_SetValue());
			}
			return result;
		}

		// Token: 0x0600591F RID: 22815 RVA: 0x000D9C9C File Offset: 0x000D7E9C
		public static IAssignLoadingBackground Create([Nullable(2)] IAssignLoadingBackground instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAssignLoadingBackground
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005920 RID: 22816 RVA: 0x000D9CAF File Offset: 0x000D7EAF
		public static IAssignLoadingBackground CreateFromSetValue([Nullable(2)] IAssignLoadingBackground_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAssignLoadingBackground
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005921 RID: 22817 RVA: 0x000D9CC2 File Offset: 0x000D7EC2
		public new IAssignLoadingBackground_SetValue ToSetValue()
		{
			return new IAssignLoadingBackground_SetValue
			{
				Type = this.Type,
				ImagePath = this.ImagePath
			};
		}

		// Token: 0x17001DB6 RID: 7606
		// (get) Token: 0x06005922 RID: 22818 RVA: 0x000D9CE1 File Offset: 0x000D7EE1
		// (set) Token: 0x06005923 RID: 22819 RVA: 0x000D9D0C File Offset: 0x000D7F0C
		public override EOperation Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EOperation.DisableHLOD;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17001DB7 RID: 7607
		// (get) Token: 0x06005924 RID: 22820 RVA: 0x000D9D1A File Offset: 0x000D7F1A
		// (set) Token: 0x06005925 RID: 22821 RVA: 0x000D9D45 File Offset: 0x000D7F45
		public virtual string ImagePath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ImagePath;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ImagePath;
			}
			set
			{
				this.GetOrCreatePoco().ImagePath = value;
			}
		}

		// Token: 0x040035B3 RID: 13747
		[Nullable(2)]
		protected new IAssignLoadingBackground FbInstance;

		// Token: 0x040035B4 RID: 13748
		[Nullable(2)]
		protected new IAssignLoadingBackground_SetValue PocoInterface;
	}
}
