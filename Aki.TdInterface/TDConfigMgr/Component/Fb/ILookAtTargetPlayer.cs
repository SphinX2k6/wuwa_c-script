using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DC3 RID: 3523
	public class ILookAtTargetPlayer : ILookAtTargetBase
	{
		// Token: 0x06004FEF RID: 20463 RVA: 0x000C5AB4 File Offset: 0x000C3CB4
		[NullableContext(1)]
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

		// Token: 0x17001A26 RID: 6694
		// (get) Token: 0x06004FF0 RID: 20464 RVA: 0x000C5AD3 File Offset: 0x000C3CD3
		public override ELookAtTargetType Type
		{
			get
			{
				return (ELookAtTargetType)this.Instance.Type;
			}
		}

		// Token: 0x04002DD6 RID: 11734
		private ILookAtTargetPlayer Instance;
	}
}
