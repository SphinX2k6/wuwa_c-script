using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DBE RID: 7614
	[NullableContext(1)]
	[Nullable(0)]
	public class IRideMotorcycleInteract : ILeisureInteractType
	{
		// Token: 0x0600A317 RID: 41751 RVA: 0x00172878 File Offset: 0x00170A78
		private IRideMotorcycleInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRideMotorcycleInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRideMotorcycleInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRideMotorcycleInteract_SetValue());
			}
			return result;
		}

		// Token: 0x0600A318 RID: 41752 RVA: 0x001728B0 File Offset: 0x00170AB0
		public static IRideMotorcycleInteract Create([Nullable(2)] IRideMotorcycleInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRideMotorcycleInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A319 RID: 41753 RVA: 0x001728C3 File Offset: 0x00170AC3
		public static IRideMotorcycleInteract CreateFromSetValue([Nullable(2)] IRideMotorcycleInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRideMotorcycleInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A31A RID: 41754 RVA: 0x001728D6 File Offset: 0x00170AD6
		public new IRideMotorcycleInteract_SetValue ToSetValue()
		{
			return new IRideMotorcycleInteract_SetValue
			{
				Type = this.Type,
				MotorcycleEntityId = this.MotorcycleEntityId
			};
		}

		// Token: 0x17003245 RID: 12869
		// (get) Token: 0x0600A31B RID: 41755 RVA: 0x001728F5 File Offset: 0x00170AF5
		// (set) Token: 0x0600A31C RID: 41756 RVA: 0x00172920 File Offset: 0x00170B20
		public override ELeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELeisureInteract.CustomSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003246 RID: 12870
		// (get) Token: 0x0600A31D RID: 41757 RVA: 0x0017292E File Offset: 0x00170B2E
		// (set) Token: 0x0600A31E RID: 41758 RVA: 0x00172959 File Offset: 0x00170B59
		public virtual int MotorcycleEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MotorcycleEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MotorcycleEntityId;
			}
			set
			{
				this.GetOrCreatePoco().MotorcycleEntityId = value;
			}
		}

		// Token: 0x040061D8 RID: 25048
		[Nullable(2)]
		protected new IRideMotorcycleInteract FbInstance;

		// Token: 0x040061D9 RID: 25049
		[Nullable(2)]
		protected new IRideMotorcycleInteract_SetValue PocoInterface;
	}
}
