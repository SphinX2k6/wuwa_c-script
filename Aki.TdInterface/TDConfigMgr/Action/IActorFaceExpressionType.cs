using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001764 RID: 5988
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorFaceExpressionType
	{
		// Token: 0x06007EC7 RID: 32455 RVA: 0x0012F6B8 File Offset: 0x0012D8B8
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

		// Token: 0x06007EC8 RID: 32456 RVA: 0x0012F6F0 File Offset: 0x0012D8F0
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

		// Token: 0x06007EC9 RID: 32457 RVA: 0x0012F703 File Offset: 0x0012D903
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

		// Token: 0x06007ECA RID: 32458 RVA: 0x0012F716 File Offset: 0x0012D916
		public IActorFaceExpressionType_SetValue ToSetValue()
		{
			return new IActorFaceExpressionType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170029A2 RID: 10658
		// (get) Token: 0x06007ECB RID: 32459 RVA: 0x0012F729 File Offset: 0x0012D929
		// (set) Token: 0x06007ECC RID: 32460 RVA: 0x0012F754 File Offset: 0x0012D954
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

		// Token: 0x040050AF RID: 20655
		[Nullable(2)]
		protected IActorFaceExpressionType FbInstance;

		// Token: 0x040050B0 RID: 20656
		[Nullable(2)]
		protected IActorFaceExpressionType_SetValue PocoInterface;
	}
}
