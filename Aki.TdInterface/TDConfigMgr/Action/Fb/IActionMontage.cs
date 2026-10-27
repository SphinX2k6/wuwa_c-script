using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200251B RID: 9499
	[NullableContext(1)]
	[Nullable(0)]
	public class IActionMontage
	{
		// Token: 0x0600D3E0 RID: 54240 RVA: 0x001F63B9 File Offset: 0x001F45B9
		public static IActionMontage Create(IActionMontage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActionMontage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B6C RID: 15212
		// (get) Token: 0x0600D3E1 RID: 54241 RVA: 0x001F63D8 File Offset: 0x001F45D8
		public virtual EActionMontageType MontageType
		{
			get
			{
				return (EActionMontageType)this.Instance.MontageType;
			}
		}

		// Token: 0x17003B6D RID: 15213
		// (get) Token: 0x0600D3E2 RID: 54242 RVA: 0x001F63E5 File Offset: 0x001F45E5
		public virtual string Path
		{
			get
			{
				return this.Instance.Path;
			}
		}

		// Token: 0x0400741B RID: 29723
		private IActionMontage Instance;
	}
}
