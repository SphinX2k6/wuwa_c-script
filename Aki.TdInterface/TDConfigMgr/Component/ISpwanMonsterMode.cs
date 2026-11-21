using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007A4 RID: 1956
	public class ISpwanMonsterMode
	{
		// Token: 0x060029C1 RID: 10689 RVA: 0x0006E478 File Offset: 0x0006C678
		private ISpwanMonsterMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISpwanMonsterMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISpwanMonsterMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISpwanMonsterMode_SetValue());
			}
			return result;
		}

		// Token: 0x060029C2 RID: 10690 RVA: 0x0006E4B0 File Offset: 0x0006C6B0
		public static ISpwanMonsterMode Create([Nullable(2)] ISpwanMonsterMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpwanMonsterMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x060029C3 RID: 10691 RVA: 0x0006E4C3 File Offset: 0x0006C6C3
		public static ISpwanMonsterMode CreateFromSetValue([Nullable(2)] ISpwanMonsterMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISpwanMonsterMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x060029C4 RID: 10692 RVA: 0x0006E4D6 File Offset: 0x0006C6D6
		public ISpwanMonsterMode_SetValue ToSetValue()
		{
			return new ISpwanMonsterMode_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x060029C5 RID: 10693 RVA: 0x0006E4E9 File Offset: 0x0006C6E9
		// (set) Token: 0x060029C6 RID: 10694 RVA: 0x0006E514 File Offset: 0x0006C714
		public virtual ESpawnMonsterConstraint Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpawnMonsterConstraint.CharacterForwardAnnularSector;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001C29 RID: 7209
		[Nullable(2)]
		protected ISpwanMonsterMode FbInstance;

		// Token: 0x04001C2A RID: 7210
		[Nullable(2)]
		protected ISpwanMonsterMode_SetValue PocoInterface;
	}
}
