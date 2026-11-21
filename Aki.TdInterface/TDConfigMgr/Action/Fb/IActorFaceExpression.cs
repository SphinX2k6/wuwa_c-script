using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027CF RID: 10191
	public class IActorFaceExpression
	{
		// Token: 0x0600E178 RID: 57720 RVA: 0x00212336 File Offset: 0x00210536
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

		// Token: 0x17003E88 RID: 16008
		// (get) Token: 0x0600E179 RID: 57721 RVA: 0x00212355 File Offset: 0x00210555
		public virtual int ActorIndex
		{
			get
			{
				return this.Instance.ActorIndex;
			}
		}

		// Token: 0x17003E89 RID: 16009
		// (get) Token: 0x0600E17A RID: 57722 RVA: 0x00212362 File Offset: 0x00210562
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

		// Token: 0x04007A83 RID: 31363
		private IActorFaceExpression Instance;

		// Token: 0x04007A84 RID: 31364
		private IActorFaceExpressionType _FaceExpressionCache;

		// Token: 0x04007A85 RID: 31365
		private bool _FaceExpressionInited;
	}
}
