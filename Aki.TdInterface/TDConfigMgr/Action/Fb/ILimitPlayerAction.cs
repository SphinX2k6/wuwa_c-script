using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027CB RID: 10187
	public class ILimitPlayerAction : ILimitPlayerOption
	{
		// Token: 0x0600E282 RID: 57986 RVA: 0x002172EE File Offset: 0x002154EE
		[NullableContext(1)]
		public static ILimitPlayerAction Create(ILimitPlayerAction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILimitPlayerAction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044AE RID: 17582
		// (get) Token: 0x0600E283 RID: 57987 RVA: 0x0021730D File Offset: 0x0021550D
		public override ELimitPlayOperation Type
		{
			get
			{
				return (ELimitPlayOperation)this.Instance.Type;
			}
		}

		// Token: 0x04007D9D RID: 32157
		private ILimitPlayerAction Instance;
	}
}
