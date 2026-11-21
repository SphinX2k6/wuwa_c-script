using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B2E RID: 11054
	public class IColorPiece
	{
		// Token: 0x0600F327 RID: 62247 RVA: 0x00237F24 File Offset: 0x00236124
		public static IColorPiece Create(IColorPiece? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IColorPiece
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004979 RID: 18809
		// (get) Token: 0x0600F328 RID: 62248 RVA: 0x00237F43 File Offset: 0x00236143
		public virtual EPieceColorType Color
		{
			get
			{
				return (EPieceColorType)this.Instance.Color;
			}
		}

		// Token: 0x0400856C RID: 34156
		private IColorPiece Instance;
	}
}
