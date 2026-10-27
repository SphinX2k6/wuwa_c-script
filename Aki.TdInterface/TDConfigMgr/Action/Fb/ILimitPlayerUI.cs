using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027CF RID: 10191
	public class ILimitPlayerUI : ILimitPlayerOption
	{
		// Token: 0x0600E292 RID: 58002 RVA: 0x002173F2 File Offset: 0x002155F2
		[NullableContext(1)]
		public static ILimitPlayerUI Create(ILimitPlayerUI? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILimitPlayerUI
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044B6 RID: 17590
		// (get) Token: 0x0600E293 RID: 58003 RVA: 0x00217411 File Offset: 0x00215611
		public override ELimitPlayOperation Type
		{
			get
			{
				return (ELimitPlayOperation)this.Instance.Type;
			}
		}

		// Token: 0x04007DA1 RID: 32161
		private ILimitPlayerUI Instance;
	}
}
