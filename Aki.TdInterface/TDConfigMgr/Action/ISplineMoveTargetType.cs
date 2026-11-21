using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020DE RID: 8414
	public class ISplineMoveTargetType
	{
		// Token: 0x0600B2A6 RID: 45734 RVA: 0x001911EC File Offset: 0x0018F3EC
		private ISplineMoveTargetType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISplineMoveTargetType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISplineMoveTargetType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISplineMoveTargetType_SetValue());
			}
			return result;
		}

		// Token: 0x0600B2A7 RID: 45735 RVA: 0x00191224 File Offset: 0x0018F424
		public static ISplineMoveTargetType Create([Nullable(2)] ISplineMoveTargetType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISplineMoveTargetType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B2A8 RID: 45736 RVA: 0x00191237 File Offset: 0x0018F437
		public static ISplineMoveTargetType CreateFromSetValue([Nullable(2)] ISplineMoveTargetType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISplineMoveTargetType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B2A9 RID: 45737 RVA: 0x0019124A File Offset: 0x0018F44A
		public ISplineMoveTargetType_SetValue ToSetValue()
		{
			return new ISplineMoveTargetType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003615 RID: 13845
		// (get) Token: 0x0600B2AA RID: 45738 RVA: 0x0019125D File Offset: 0x0018F45D
		// (set) Token: 0x0600B2AB RID: 45739 RVA: 0x00191288 File Offset: 0x0018F488
		public virtual ESplineMoveTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESplineMoveTargetType.Entity;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040069FA RID: 27130
		[Nullable(2)]
		protected ISplineMoveTargetType FbInstance;

		// Token: 0x040069FB RID: 27131
		[Nullable(2)]
		protected ISplineMoveTargetType_SetValue PocoInterface;
	}
}
