using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000659 RID: 1625
	public class IPasserbyNpcSpawnBase
	{
		// Token: 0x06002222 RID: 8738 RVA: 0x0005E728 File Offset: 0x0005C928
		private IPasserbyNpcSpawnBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPasserbyNpcSpawnBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPasserbyNpcSpawnBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPasserbyNpcSpawnBase_SetValue());
			}
			return result;
		}

		// Token: 0x06002223 RID: 8739 RVA: 0x0005E760 File Offset: 0x0005C960
		public static IPasserbyNpcSpawnBase Create([Nullable(2)] IPasserbyNpcSpawnBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcSpawnBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002224 RID: 8740 RVA: 0x0005E773 File Offset: 0x0005C973
		public static IPasserbyNpcSpawnBase CreateFromSetValue([Nullable(2)] IPasserbyNpcSpawnBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPasserbyNpcSpawnBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002225 RID: 8741 RVA: 0x0005E786 File Offset: 0x0005C986
		public IPasserbyNpcSpawnBase_SetValue ToSetValue()
		{
			return new IPasserbyNpcSpawnBase_SetValue
			{
				Type = this.Type,
				MaxSpawnCount = this.MaxSpawnCount,
				MinDistance = this.MinDistance
			};
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06002226 RID: 8742 RVA: 0x0005E7B1 File Offset: 0x0005C9B1
		// (set) Token: 0x06002227 RID: 8743 RVA: 0x0005E7DC File Offset: 0x0005C9DC
		public virtual EPasserbyNpcSpawnType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPasserbyNpcSpawnType.FixInterval;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06002228 RID: 8744 RVA: 0x0005E7EA File Offset: 0x0005C9EA
		// (set) Token: 0x06002229 RID: 8745 RVA: 0x0005E815 File Offset: 0x0005CA15
		public virtual int MaxSpawnCount
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxSpawnCount;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MaxSpawnCount;
			}
			set
			{
				this.GetOrCreatePoco().MaxSpawnCount = value;
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x0600222A RID: 8746 RVA: 0x0005E824 File Offset: 0x0005CA24
		// (set) Token: 0x0600222B RID: 8747 RVA: 0x0005E85E File Offset: 0x0005CA5E
		public virtual int? MinDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MinDistance;
				}
				IPasserbyNpcSpawnBase_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MinDistance;
			}
			set
			{
				this.GetOrCreatePoco().MinDistance = value;
			}
		}

		// Token: 0x04001803 RID: 6147
		[Nullable(2)]
		protected IPasserbyNpcSpawnBase FbInstance;

		// Token: 0x04001804 RID: 6148
		[Nullable(2)]
		protected IPasserbyNpcSpawnBase_SetValue PocoInterface;
	}
}
