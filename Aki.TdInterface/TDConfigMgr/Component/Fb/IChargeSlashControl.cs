using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D9D RID: 3485
	[NullableContext(2)]
	[Nullable(0)]
	public class IChargeSlashControl : ICurveControlConfig
	{
		// Token: 0x06004F39 RID: 20281 RVA: 0x000C4672 File Offset: 0x000C2872
		[NullableContext(1)]
		public static IChargeSlashControl Create(IChargeSlashControl? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChargeSlashControl
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170019BC RID: 6588
		// (get) Token: 0x06004F3A RID: 20282 RVA: 0x000C4691 File Offset: 0x000C2891
		public override ECurveControlType Type
		{
			get
			{
				return (ECurveControlType)this.Instance.Type;
			}
		}

		// Token: 0x170019BD RID: 6589
		// (get) Token: 0x06004F3B RID: 20283 RVA: 0x000C469E File Offset: 0x000C289E
		public virtual int UpHeight
		{
			get
			{
				return this.Instance.UpHeight;
			}
		}

		// Token: 0x170019BE RID: 6590
		// (get) Token: 0x06004F3C RID: 20284 RVA: 0x000C46AB File Offset: 0x000C28AB
		public virtual string UpCurvePath
		{
			get
			{
				return this.Instance.UpCurvePath;
			}
		}

		// Token: 0x04002D7E RID: 11646
		private IChargeSlashControl Instance;
	}
}
