using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018DF RID: 6367
	public class IActorFaceExpression
	{
		// Token: 0x06008597 RID: 34199 RVA: 0x0013E5B8 File Offset: 0x0013C7B8
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

		// Token: 0x06008598 RID: 34200 RVA: 0x0013E5F0 File Offset: 0x0013C7F0
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

		// Token: 0x06008599 RID: 34201 RVA: 0x0013E603 File Offset: 0x0013C803
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

		// Token: 0x0600859A RID: 34202 RVA: 0x0013E616 File Offset: 0x0013C816
		public IActorFaceExpression_SetValue ToSetValue()
		{
			return new IActorFaceExpression_SetValue
			{
				ActorIndex = this.ActorIndex,
				FaceExpression = this.FaceExpression
			};
		}

		// Token: 0x17002B89 RID: 11145
		// (get) Token: 0x0600859B RID: 34203 RVA: 0x0013E635 File Offset: 0x0013C835
		// (set) Token: 0x0600859C RID: 34204 RVA: 0x0013E660 File Offset: 0x0013C860
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

		// Token: 0x17002B8A RID: 11146
		// (get) Token: 0x0600859D RID: 34205 RVA: 0x0013E66E File Offset: 0x0013C86E
		// (set) Token: 0x0600859E RID: 34206 RVA: 0x0013E695 File Offset: 0x0013C895
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

		// Token: 0x040054D8 RID: 21720
		[Nullable(2)]
		protected IActorFaceExpression FbInstance;

		// Token: 0x040054D9 RID: 21721
		[Nullable(2)]
		protected IActorFaceExpression_SetValue PocoInterface;
	}
}
