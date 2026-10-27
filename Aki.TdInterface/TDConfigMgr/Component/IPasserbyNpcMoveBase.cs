using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005C6 RID: 1478
	[NullableContext(1)]
	[Nullable(0)]
	public class IPasserbyNpcMoveBase
	{
		// Token: 0x06001F4A RID: 8010 RVA: 0x00057F68 File Offset: 0x00056168
		private IPasserbyNpcMoveBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPasserbyNpcMoveBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPasserbyNpcMoveBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPasserbyNpcMoveBase_SetValue());
			}
			return result;
		}

		// Token: 0x06001F4B RID: 8011 RVA: 0x00057FA0 File Offset: 0x000561A0
		public static IPasserbyNpcMoveBase Create([Nullable(2)] IPasserbyNpcMoveBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcMoveBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001F4C RID: 8012 RVA: 0x00057FB3 File Offset: 0x000561B3
		public static IPasserbyNpcMoveBase CreateFromSetValue([Nullable(2)] IPasserbyNpcMoveBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPasserbyNpcMoveBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001F4D RID: 8013 RVA: 0x00057FC6 File Offset: 0x000561C6
		public IPasserbyNpcMoveBase_SetValue ToSetValue()
		{
			return new IPasserbyNpcMoveBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06001F4E RID: 8014 RVA: 0x00057FD9 File Offset: 0x000561D9
		// (set) Token: 0x06001F4F RID: 8015 RVA: 0x00058004 File Offset: 0x00056204
		public virtual EPasserbyNpcMoveType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPasserbyNpcMoveType.Spline;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001629 RID: 5673
		[Nullable(2)]
		protected IPasserbyNpcMoveBase FbInstance;

		// Token: 0x0400162A RID: 5674
		[Nullable(2)]
		protected IPasserbyNpcMoveBase_SetValue PocoInterface;
	}
}
