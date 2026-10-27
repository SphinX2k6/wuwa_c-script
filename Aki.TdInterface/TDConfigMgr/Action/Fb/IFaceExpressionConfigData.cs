using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200297D RID: 10621
	[NullableContext(1)]
	[Nullable(0)]
	public class IFaceExpressionConfigData
	{
		// Token: 0x0600EB50 RID: 60240 RVA: 0x00226C47 File Offset: 0x00224E47
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

		// Token: 0x17004A18 RID: 18968
		// (get) Token: 0x0600EB51 RID: 60241 RVA: 0x00226C66 File Offset: 0x00224E66
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17004A19 RID: 18969
		// (get) Token: 0x0600EB52 RID: 60242 RVA: 0x00226C73 File Offset: 0x00224E73
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

		// Token: 0x17004A1A RID: 18970
		// (get) Token: 0x0600EB53 RID: 60243 RVA: 0x00226CA2 File Offset: 0x00224EA2
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

		// Token: 0x17004A1B RID: 18971
		// (get) Token: 0x0600EB54 RID: 60244 RVA: 0x00226CD4 File Offset: 0x00224ED4
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

		// Token: 0x04008195 RID: 33173
		private IFaceExpressionConfigData Instance;

		// Token: 0x04008196 RID: 33174
		private IFaceExpressionConfig _FaceExpressionCache;

		// Token: 0x04008197 RID: 33175
		private bool _FaceExpressionInited;

		// Token: 0x04008198 RID: 33176
		private IFaceExpressionConfig _MaleVariantCache;

		// Token: 0x04008199 RID: 33177
		private bool _MaleVariantInited;
	}
}
