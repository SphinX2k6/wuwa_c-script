using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200285A RID: 10330
	public class ISundialPuzzleGameplay : IUiGame
	{
		// Token: 0x0600E4FF RID: 58623 RVA: 0x0021B08C File Offset: 0x0021928C
		[NullableContext(1)]
		public static ISundialPuzzleGameplay Create(ISundialPuzzleGameplay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISundialPuzzleGameplay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700460D RID: 17933
		// (get) Token: 0x0600E500 RID: 58624 RVA: 0x0021B0AB File Offset: 0x002192AB
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x04007EAE RID: 32430
		private ISundialPuzzleGameplay Instance;
	}
}
