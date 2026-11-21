using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018E5 RID: 6373
	public class IActorFaceExpressionType
	{
		// Token: 0x060085B7 RID: 34231 RVA: 0x0013E918 File Offset: 0x0013CB18
		private IActorFaceExpressionType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorFaceExpressionType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorFaceExpressionType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorFaceExpressionType_SetValue());
			}
			return result;
		}

		// Token: 0x060085B8 RID: 34232 RVA: 0x0013E950 File Offset: 0x0013CB50
		public static IActorFaceExpressionType Create([Nullable(2)] IActorFaceExpressionType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorFaceExpressionType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060085B9 RID: 34233 RVA: 0x0013E963 File Offset: 0x0013CB63
		public static IActorFaceExpressionType CreateFromSetValue([Nullable(2)] IActorFaceExpressionType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorFaceExpressionType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060085BA RID: 34234 RVA: 0x0013E976 File Offset: 0x0013CB76
		public IActorFaceExpressionType_SetValue ToSetValue()
		{
			return new IActorFaceExpressionType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002B90 RID: 11152
		// (get) Token: 0x060085BB RID: 34235 RVA: 0x0013E989 File Offset: 0x0013CB89
		// (set) Token: 0x060085BC RID: 34236 RVA: 0x0013E9B4 File Offset: 0x0013CBB4
		public virtual EActorFaceExpressionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EActorFaceExpressionType.Play;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040054E5 RID: 21733
		[Nullable(2)]
		protected IActorFaceExpressionType FbInstance;

		// Token: 0x040054E6 RID: 21734
		[Nullable(2)]
		protected IActorFaceExpressionType_SetValue PocoInterface;
	}
}
