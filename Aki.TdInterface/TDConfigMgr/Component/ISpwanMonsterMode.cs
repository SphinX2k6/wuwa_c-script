using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000703 RID: 1795
	[NullableContext(1)]
	[Nullable(0)]
	public class ISpwanMonsterMode
	{
		// Token: 0x060026A1 RID: 9889 RVA: 0x00067408 File Offset: 0x00065608
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

		// Token: 0x060026A2 RID: 9890 RVA: 0x00067440 File Offset: 0x00065640
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

		// Token: 0x060026A3 RID: 9891 RVA: 0x00067453 File Offset: 0x00065653
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

		// Token: 0x060026A4 RID: 9892 RVA: 0x00067466 File Offset: 0x00065666
		public ISpwanMonsterMode_SetValue ToSetValue()
		{
			return new ISpwanMonsterMode_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x060026A5 RID: 9893 RVA: 0x00067479 File Offset: 0x00065679
		// (set) Token: 0x060026A6 RID: 9894 RVA: 0x000674A4 File Offset: 0x000656A4
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

		// Token: 0x04001A2A RID: 6698
		[Nullable(2)]
		protected ISpwanMonsterMode FbInstance;

		// Token: 0x04001A2B RID: 6699
		[Nullable(2)]
		protected ISpwanMonsterMode_SetValue PocoInterface;
	}
}
