using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028B0 RID: 10416
	[NullableContext(2)]
	[Nullable(0)]
	public class IBlendFunction
	{
		// Token: 0x0600E6F7 RID: 59127 RVA: 0x0021ECAA File Offset: 0x0021CEAA
		[NullableContext(1)]
		public static IBlendFunction Create(IBlendFunction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBlendFunction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004759 RID: 18265
		// (get) Token: 0x0600E6F8 RID: 59128 RVA: 0x0021ECC9 File Offset: 0x0021CEC9
		public virtual EViewTargetBlendFunction Type
		{
			get
			{
				return (EViewTargetBlendFunction)this.Instance.Type;
			}
		}

		// Token: 0x1700475A RID: 18266
		// (get) Token: 0x0600E6F9 RID: 59129 RVA: 0x0021ECD6 File Offset: 0x0021CED6
		public virtual float BlendExp
		{
			get
			{
				return this.Instance.BlendExp;
			}
		}

		// Token: 0x1700475B RID: 18267
		// (get) Token: 0x0600E6FA RID: 59130 RVA: 0x0021ECE3 File Offset: 0x0021CEE3
		public virtual string CurveAsset
		{
			get
			{
				return this.Instance.CurveAsset;
			}
		}

		// Token: 0x04007FA6 RID: 32678
		private IBlendFunction Instance;
	}
}
