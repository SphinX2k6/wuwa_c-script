using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002528 RID: 9512
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorFaceExpression
	{
		// Token: 0x0600D418 RID: 54296 RVA: 0x001F68D6 File Offset: 0x001F4AD6
		public static IActorFaceExpression Create(IActorFaceExpression? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorFaceExpression
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B8A RID: 15242
		// (get) Token: 0x0600D419 RID: 54297 RVA: 0x001F68F5 File Offset: 0x001F4AF5
		public virtual int ActorIndex
		{
			get
			{
				return this.Instance.ActorIndex;
			}
		}

		// Token: 0x17003B8B RID: 15243
		// (get) Token: 0x0600D41A RID: 54298 RVA: 0x001F6902 File Offset: 0x001F4B02
		public virtual IActorFaceExpressionType FaceExpression
		{
			get
			{
				if (this._FaceExpressionInited)
				{
					return this._FaceExpressionCache;
				}
				this._FaceExpressionInited = true;
				this._FaceExpressionCache = ActionReadHelper.ReadIActorFaceExpression_FaceExpression(this.Instance);
				return this._FaceExpressionCache;
			}
		}

		// Token: 0x0400742E RID: 29742
		private IActorFaceExpression Instance;

		// Token: 0x0400742F RID: 29743
		private IActorFaceExpressionType _FaceExpressionCache;

		// Token: 0x04007430 RID: 29744
		private bool _FaceExpressionInited;
	}
}
