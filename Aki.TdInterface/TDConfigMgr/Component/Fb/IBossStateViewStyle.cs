using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C12 RID: 3090
	public class IBossStateViewStyle
	{
		// Token: 0x060046E5 RID: 18149 RVA: 0x000B2CBE File Offset: 0x000B0EBE
		[NullableContext(1)]
		public static IBossStateViewStyle Create(IBossStateViewStyle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBossStateViewStyle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700147E RID: 5246
		// (get) Token: 0x060046E6 RID: 18150 RVA: 0x000B2CDD File Offset: 0x000B0EDD
		public virtual EBossStateViewStyle Type
		{
			get
			{
				return (EBossStateViewStyle)this.Instance.Type;
			}
		}

		// Token: 0x04002847 RID: 10311
		private IBossStateViewStyle Instance;
	}
}
