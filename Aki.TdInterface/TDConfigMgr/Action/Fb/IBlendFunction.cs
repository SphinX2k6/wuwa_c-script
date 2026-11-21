using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B85 RID: 11141
	public class IBlendFunction
	{
		// Token: 0x0600F526 RID: 62758 RVA: 0x0023BC2A File Offset: 0x00239E2A
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

		// Token: 0x17004ACA RID: 19146
		// (get) Token: 0x0600F527 RID: 62759 RVA: 0x0023BC49 File Offset: 0x00239E49
		public virtual EViewTargetBlendFunction Type
		{
			get
			{
				return (EViewTargetBlendFunction)this.Instance.Type;
			}
		}

		// Token: 0x17004ACB RID: 19147
		// (get) Token: 0x0600F528 RID: 62760 RVA: 0x0023BC56 File Offset: 0x00239E56
		public virtual float BlendExp
		{
			get
			{
				return this.Instance.BlendExp;
			}
		}

		// Token: 0x17004ACC RID: 19148
		// (get) Token: 0x0600F529 RID: 62761 RVA: 0x0023BC63 File Offset: 0x00239E63
		[Nullable(2)]
		public virtual string CurveAsset
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.CurveAsset;
			}
		}

		// Token: 0x04008665 RID: 34405
		private IBlendFunction Instance;
	}
}
