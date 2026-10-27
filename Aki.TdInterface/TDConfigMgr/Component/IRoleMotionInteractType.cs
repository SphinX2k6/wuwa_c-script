using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200068E RID: 1678
	[NullableContext(1)]
	[Nullable(0)]
	public class IRoleMotionInteractType
	{
		// Token: 0x060023EE RID: 9198 RVA: 0x00061B88 File Offset: 0x0005FD88
		private IRoleMotionInteractType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRoleMotionInteractType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRoleMotionInteractType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRoleMotionInteractType_SetValue());
			}
			return result;
		}

		// Token: 0x060023EF RID: 9199 RVA: 0x00061BC0 File Offset: 0x0005FDC0
		public static IRoleMotionInteractType Create([Nullable(2)] IRoleMotionInteractType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleMotionInteractType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060023F0 RID: 9200 RVA: 0x00061BD3 File Offset: 0x0005FDD3
		public static IRoleMotionInteractType CreateFromSetValue([Nullable(2)] IRoleMotionInteractType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRoleMotionInteractType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060023F1 RID: 9201 RVA: 0x00061BE6 File Offset: 0x0005FDE6
		public IRoleMotionInteractType_SetValue ToSetValue()
		{
			return new IRoleMotionInteractType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x060023F2 RID: 9202 RVA: 0x00061BF9 File Offset: 0x0005FDF9
		// (set) Token: 0x060023F3 RID: 9203 RVA: 0x00061C24 File Offset: 0x0005FE24
		public virtual ERoleMotionInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERoleMotionInteractType.PetalGrab;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040018BD RID: 6333
		[Nullable(2)]
		protected IRoleMotionInteractType FbInstance;

		// Token: 0x040018BE RID: 6334
		[Nullable(2)]
		protected IRoleMotionInteractType_SetValue PocoInterface;
	}
}
