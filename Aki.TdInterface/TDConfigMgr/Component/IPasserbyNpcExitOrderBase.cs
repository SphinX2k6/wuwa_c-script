using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000631 RID: 1585
	public class IPasserbyNpcExitOrderBase
	{
		// Token: 0x06002154 RID: 8532 RVA: 0x0005CEB0 File Offset: 0x0005B0B0
		private IPasserbyNpcExitOrderBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPasserbyNpcExitOrderBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPasserbyNpcExitOrderBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPasserbyNpcExitOrderBase_SetValue());
			}
			return result;
		}

		// Token: 0x06002155 RID: 8533 RVA: 0x0005CEE8 File Offset: 0x0005B0E8
		public static IPasserbyNpcExitOrderBase Create([Nullable(2)] IPasserbyNpcExitOrderBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcExitOrderBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002156 RID: 8534 RVA: 0x0005CEFB File Offset: 0x0005B0FB
		public static IPasserbyNpcExitOrderBase CreateFromSetValue([Nullable(2)] IPasserbyNpcExitOrderBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPasserbyNpcExitOrderBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002157 RID: 8535 RVA: 0x0005CF0E File Offset: 0x0005B10E
		public IPasserbyNpcExitOrderBase_SetValue ToSetValue()
		{
			return new IPasserbyNpcExitOrderBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06002158 RID: 8536 RVA: 0x0005CF21 File Offset: 0x0005B121
		// (set) Token: 0x06002159 RID: 8537 RVA: 0x0005CF4C File Offset: 0x0005B14C
		public virtual EPasserbyNpcExitOrderType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPasserbyNpcExitOrderType.NearSplineStartFirst;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400179A RID: 6042
		[Nullable(2)]
		protected IPasserbyNpcExitOrderBase FbInstance;

		// Token: 0x0400179B RID: 6043
		[Nullable(2)]
		protected IPasserbyNpcExitOrderBase_SetValue PocoInterface;
	}
}
