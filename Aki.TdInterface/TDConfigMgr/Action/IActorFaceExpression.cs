using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200175E RID: 5982
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorFaceExpression
	{
		// Token: 0x06007EA7 RID: 32423 RVA: 0x0012F358 File Offset: 0x0012D558
		private IActorFaceExpression_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorFaceExpression 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorFaceExpression_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorFaceExpression_SetValue());
			}
			return result;
		}

		// Token: 0x06007EA8 RID: 32424 RVA: 0x0012F390 File Offset: 0x0012D590
		public static IActorFaceExpression Create([Nullable(2)] IActorFaceExpression instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorFaceExpression
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007EA9 RID: 32425 RVA: 0x0012F3A3 File Offset: 0x0012D5A3
		public static IActorFaceExpression CreateFromSetValue([Nullable(2)] IActorFaceExpression_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorFaceExpression
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007EAA RID: 32426 RVA: 0x0012F3B6 File Offset: 0x0012D5B6
		public IActorFaceExpression_SetValue ToSetValue()
		{
			return new IActorFaceExpression_SetValue
			{
				ActorIndex = this.ActorIndex,
				FaceExpression = this.FaceExpression
			};
		}

		// Token: 0x1700299B RID: 10651
		// (get) Token: 0x06007EAB RID: 32427 RVA: 0x0012F3D5 File Offset: 0x0012D5D5
		// (set) Token: 0x06007EAC RID: 32428 RVA: 0x0012F400 File Offset: 0x0012D600
		public virtual int ActorIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ActorIndex;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ActorIndex;
			}
			set
			{
				this.GetOrCreatePoco().ActorIndex = value;
			}
		}

		// Token: 0x1700299C RID: 10652
		// (get) Token: 0x06007EAD RID: 32429 RVA: 0x0012F40E File Offset: 0x0012D60E
		// (set) Token: 0x06007EAE RID: 32430 RVA: 0x0012F435 File Offset: 0x0012D635
		public virtual IActorFaceExpressionType FaceExpression
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FaceExpression;
				}
				IActorFaceExpression_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FaceExpression;
			}
			set
			{
				this.GetOrCreatePoco().FaceExpression = value;
			}
		}

		// Token: 0x040050A2 RID: 20642
		[Nullable(2)]
		protected IActorFaceExpression FbInstance;

		// Token: 0x040050A3 RID: 20643
		[Nullable(2)]
		protected IActorFaceExpression_SetValue PocoInterface;
	}
}
