using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FA9 RID: 8105
	public class IRemoveEntityDecoration : IEntityDecorationConfig
	{
		// Token: 0x0600AC4F RID: 44111 RVA: 0x001859DC File Offset: 0x00183BDC
		private IRemoveEntityDecoration_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRemoveEntityDecoration 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRemoveEntityDecoration_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRemoveEntityDecoration_SetValue());
			}
			return result;
		}

		// Token: 0x0600AC50 RID: 44112 RVA: 0x00185A14 File Offset: 0x00183C14
		public static IRemoveEntityDecoration Create([Nullable(2)] IRemoveEntityDecoration instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRemoveEntityDecoration
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AC51 RID: 44113 RVA: 0x00185A27 File Offset: 0x00183C27
		public static IRemoveEntityDecoration CreateFromSetValue([Nullable(2)] IRemoveEntityDecoration_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRemoveEntityDecoration
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AC52 RID: 44114 RVA: 0x00185A3A File Offset: 0x00183C3A
		public new IRemoveEntityDecoration_SetValue ToSetValue()
		{
			return new IRemoveEntityDecoration_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170034B8 RID: 13496
		// (get) Token: 0x0600AC53 RID: 44115 RVA: 0x00185A4D File Offset: 0x00183C4D
		// (set) Token: 0x0600AC54 RID: 44116 RVA: 0x00185A78 File Offset: 0x00183C78
		public override EEntityDecorationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEntityDecorationType.Add;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006705 RID: 26373
		[Nullable(2)]
		protected new IRemoveEntityDecoration FbInstance;

		// Token: 0x04006706 RID: 26374
		[Nullable(2)]
		protected new IRemoveEntityDecoration_SetValue PocoInterface;
	}
}
