using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200285B RID: 10331
	public class IColorPiece
	{
		// Token: 0x0600E502 RID: 58626 RVA: 0x0021B0C0 File Offset: 0x002192C0
		[NullableContext(1)]
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

		// Token: 0x1700460E RID: 17934
		// (get) Token: 0x0600E503 RID: 58627 RVA: 0x0021B0DF File Offset: 0x002192DF
		public virtual EPieceColorType Color
		{
			get
			{
				return (EPieceColorType)this.Instance.Color;
			}
		}

		// Token: 0x04007EAF RID: 32431
		private IColorPiece Instance;
	}
}
