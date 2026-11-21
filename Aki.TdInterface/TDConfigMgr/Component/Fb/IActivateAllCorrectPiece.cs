using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D70 RID: 3440
	public class IActivateAllCorrectPiece : IJigsawCompleteCondition
	{
		// Token: 0x06004E33 RID: 20019 RVA: 0x000C2D79 File Offset: 0x000C0F79
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

		// Token: 0x1700174E RID: 5966
		// (get) Token: 0x06004E34 RID: 20020 RVA: 0x000C2D98 File Offset: 0x000C0F98
		public override EJigsawCompleteCondition Type
		{
			get
			{
				return (EJigsawCompleteCondition)this.Instance.Type;
			}
		}

		// Token: 0x04002C67 RID: 11367
		private IActivateAllCorrectPiece Instance;
	}
}
