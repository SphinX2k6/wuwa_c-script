using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C63 RID: 11363
	public class IFaceExpressionConfigData
	{
		// Token: 0x0600F9CB RID: 63947 RVA: 0x0024439F File Offset: 0x0024259F
		public static IFaceExpressionConfigData Create(IFaceExpressionConfigData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFaceExpressionConfigData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004DB3 RID: 19891
		// (get) Token: 0x0600F9CC RID: 63948 RVA: 0x002443BE File Offset: 0x002425BE
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17004DB4 RID: 19892
		// (get) Token: 0x0600F9CD RID: 63949 RVA: 0x002443CB File Offset: 0x002425CB
		public virtual IFaceExpressionConfig FaceExpression
		{
			get
			{
				if (this._FaceExpressionInited)
				{
					return this._FaceExpressionCache;
				}
				this._FaceExpressionInited = true;
				this._FaceExpressionCache = ActionReadHelper.ReadIFaceExpressionConfigData_FaceExpression(this.Instance);
				return this._FaceExpressionCache;
			}
		}

		// Token: 0x17004DB5 RID: 19893
		// (get) Token: 0x0600F9CE RID: 63950 RVA: 0x002443FA File Offset: 0x002425FA
		public virtual IFaceExpressionConfig MaleVariant
		{
			get
			{
				if (this._MaleVariantInited)
				{
					return this._MaleVariantCache;
				}
				this._MaleVariantInited = true;
				this._MaleVariantCache = ActionReadHelper.ReadIFaceExpressionConfigData_MaleVariant(this.Instance);
				return this._MaleVariantCache;
			}
		}

		// Token: 0x17004DB6 RID: 19894
		// (get) Token: 0x0600F9CF RID: 63951 RVA: 0x0024442C File Offset: 0x0024262C
		public virtual bool? CloseAutoBlink
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.CloseAutoBlink);
			}
		}

		// Token: 0x04008879 RID: 34937
		private IFaceExpressionConfigData Instance;

		// Token: 0x0400887A RID: 34938
		private IFaceExpressionConfig _FaceExpressionCache;

		// Token: 0x0400887B RID: 34939
		private bool _FaceExpressionInited;

		// Token: 0x0400887C RID: 34940
		private IFaceExpressionConfig _MaleVariantCache;

		// Token: 0x0400887D RID: 34941
		private bool _MaleVariantInited;
	}
}
