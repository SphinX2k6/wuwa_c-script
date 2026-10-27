using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002846 RID: 10310
	[NullableContext(1)]
	[Nullable(0)]
	public class IModifyTipText : IInteractEffect
	{
		// Token: 0x0600E48E RID: 58510 RVA: 0x0021A292 File Offset: 0x00218492
		public static IModifyTipText Create(IModifyTipText? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IModifyTipText
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045C4 RID: 17860
		// (get) Token: 0x0600E48F RID: 58511 RVA: 0x0021A2B1 File Offset: 0x002184B1
		public override EInteractEffectType Type
		{
			get
			{
				return (EInteractEffectType)this.Instance.Type;
			}
		}

		// Token: 0x170045C5 RID: 17861
		// (get) Token: 0x0600E490 RID: 58512 RVA: 0x0021A2C0 File Offset: 0x002184C0
		public override float? DelayTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.DelayTime);
			}
		}

		// Token: 0x170045C6 RID: 17862
		// (get) Token: 0x0600E491 RID: 58513 RVA: 0x0021A2F6 File Offset: 0x002184F6
		public virtual string TipText
		{
			get
			{
				return this.Instance.TipText;
			}
		}

		// Token: 0x04007E70 RID: 32368
		private IModifyTipText Instance;
	}
}
