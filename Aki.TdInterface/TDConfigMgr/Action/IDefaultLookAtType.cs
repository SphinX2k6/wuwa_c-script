using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200197A RID: 6522
	[NullableContext(1)]
	[Nullable(0)]
	public class IDefaultLookAtType
	{
		// Token: 0x06008BB1 RID: 35761 RVA: 0x00148424 File Offset: 0x00146624
		private IDefaultLookAtType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDefaultLookAtType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDefaultLookAtType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDefaultLookAtType_SetValue());
			}
			return result;
		}

		// Token: 0x06008BB2 RID: 35762 RVA: 0x0014845C File Offset: 0x0014665C
		public static IDefaultLookAtType Create([Nullable(2)] IDefaultLookAtType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDefaultLookAtType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008BB3 RID: 35763 RVA: 0x0014846F File Offset: 0x0014666F
		public static IDefaultLookAtType CreateFromSetValue([Nullable(2)] IDefaultLookAtType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDefaultLookAtType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008BB4 RID: 35764 RVA: 0x00148482 File Offset: 0x00146682
		public IDefaultLookAtType_SetValue ToSetValue()
		{
			return new IDefaultLookAtType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002CF6 RID: 11510
		// (get) Token: 0x06008BB5 RID: 35765 RVA: 0x00148495 File Offset: 0x00146695
		// (set) Token: 0x06008BB6 RID: 35766 RVA: 0x001484C0 File Offset: 0x001466C0
		public virtual EDefaultLookAtType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDefaultLookAtType.LookAtBubbleEntity;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005717 RID: 22295
		[Nullable(2)]
		protected IDefaultLookAtType FbInstance;

		// Token: 0x04005718 RID: 22296
		[Nullable(2)]
		protected IDefaultLookAtType_SetValue PocoInterface;
	}
}
