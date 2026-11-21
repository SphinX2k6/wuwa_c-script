using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EBF RID: 3775
	public class ILookAtTargetPlayer : ILookAtTargetBase
	{
		// Token: 0x06005514 RID: 21780 RVA: 0x000D1304 File Offset: 0x000CF504
		public static ILookAtTargetPlayer Create(ILookAtTargetPlayer? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILookAtTargetPlayer
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B91 RID: 7057
		// (get) Token: 0x06005515 RID: 21781 RVA: 0x000D1323 File Offset: 0x000CF523
		public override ELookAtTargetType Type
		{
			get
			{
				return (ELookAtTargetType)this.Instance.Type;
			}
		}

		// Token: 0x0400309C RID: 12444
		private ILookAtTargetPlayer Instance;
	}
}
