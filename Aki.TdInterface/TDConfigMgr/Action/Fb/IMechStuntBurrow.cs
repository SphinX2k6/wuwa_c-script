using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002810 RID: 10256
	public class IMechStuntBurrow : IMechStuntConfigType
	{
		// Token: 0x0600E387 RID: 58247 RVA: 0x0021878A File Offset: 0x0021698A
		[NullableContext(1)]
		public static IMechStuntBurrow Create(IMechStuntBurrow? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechStuntBurrow
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004529 RID: 17705
		// (get) Token: 0x0600E388 RID: 58248 RVA: 0x002187A9 File Offset: 0x002169A9
		public override EMechStuntType Type
		{
			get
			{
				return (EMechStuntType)this.Instance.Type;
			}
		}

		// Token: 0x04007DF6 RID: 32246
		private IMechStuntBurrow Instance;
	}
}
