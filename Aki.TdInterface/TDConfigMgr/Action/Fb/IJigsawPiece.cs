using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C51 RID: 11345
	public class IJigsawPiece : IPieceBase
	{
		// Token: 0x0600F977 RID: 63863 RVA: 0x00243B77 File Offset: 0x00241D77
		public static IJigsawPiece Create(IJigsawPiece? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IJigsawPiece
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D83 RID: 19843
		// (get) Token: 0x0600F978 RID: 63864 RVA: 0x00243B96 File Offset: 0x00241D96
		public override IPieceIndex Index
		{
			get
			{
				if (this._IndexInited)
				{
					return this._IndexCache;
				}
				this._IndexInited = true;
				this._IndexCache = IPieceIndex.Create(this.Instance.Index);
				return this._IndexCache;
			}
		}

		// Token: 0x17004D84 RID: 19844
		// (get) Token: 0x0600F979 RID: 63865 RVA: 0x00243BCA File Offset: 0x00241DCA
		public override bool Active
		{
			get
			{
				return this.Instance.Active;
			}
		}

		// Token: 0x17004D85 RID: 19845
		// (get) Token: 0x0600F97A RID: 63866 RVA: 0x00243BD7 File Offset: 0x00241DD7
		public virtual bool IsCorrect
		{
			get
			{
				return this.Instance.IsCorrect;
			}
		}

		// Token: 0x17004D86 RID: 19846
		// (get) Token: 0x0600F97B RID: 63867 RVA: 0x00243BE4 File Offset: 0x00241DE4
		public virtual EJigsawPieceState InitState
		{
			get
			{
				return (EJigsawPieceState)this.Instance.InitState;
			}
		}

		// Token: 0x04008859 RID: 34905
		private IJigsawPiece Instance;

		// Token: 0x0400885A RID: 34906
		[Nullable(2)]
		private IPieceIndex _IndexCache;

		// Token: 0x0400885B RID: 34907
		private bool _IndexInited;
	}
}
