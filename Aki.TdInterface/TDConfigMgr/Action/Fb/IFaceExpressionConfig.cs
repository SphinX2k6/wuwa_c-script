using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C5E RID: 11358
	public class IFaceExpressionConfig
	{
		// Token: 0x0600F9B7 RID: 63927 RVA: 0x0024425A File Offset: 0x0024245A
		public static IFaceExpressionConfig Create(IFaceExpressionConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFaceExpressionConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004DA9 RID: 19881
		// (get) Token: 0x0600F9B8 RID: 63928 RVA: 0x00244279 File Offset: 0x00242479
		public virtual EFaceExpressionConfigType Type
		{
			get
			{
				return (EFaceExpressionConfigType)this.Instance.Type;
			}
		}

		// Token: 0x04008874 RID: 34932
		private IFaceExpressionConfig Instance;
	}
}
