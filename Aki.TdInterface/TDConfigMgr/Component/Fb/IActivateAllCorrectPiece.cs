using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C8E RID: 3214
	public class IActivateAllCorrectPiece : IJigsawCompleteCondition
	{
		// Token: 0x06004985 RID: 18821 RVA: 0x000B8369 File Offset: 0x000B6569
		[NullableContext(1)]
		public static IActivateAllCorrectPiece Create(IActivateAllCorrectPiece? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActivateAllCorrectPiece
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001626 RID: 5670
		// (get) Token: 0x06004986 RID: 18822 RVA: 0x000B8388 File Offset: 0x000B6588
		public override EJigsawCompleteCondition Type
		{
			get
			{
				return (EJigsawCompleteCondition)this.Instance.Type;
			}
		}

		// Token: 0x040029ED RID: 10733
		private IActivateAllCorrectPiece Instance;
	}
}
