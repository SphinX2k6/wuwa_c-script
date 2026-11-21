using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B33 RID: 11059
	public class IProjectorPuzzle : IUiGame
	{
		// Token: 0x0600F33B RID: 62267 RVA: 0x00238146 File Offset: 0x00236346
		public static IProjectorPuzzle Create(IProjectorPuzzle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IProjectorPuzzle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004983 RID: 18819
		// (get) Token: 0x0600F33C RID: 62268 RVA: 0x00238165 File Offset: 0x00236365
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x04008577 RID: 34167
		private IProjectorPuzzle Instance;
	}
}
