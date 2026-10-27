using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200296C RID: 10604
	[NullableContext(1)]
	[Nullable(0)]
	public class IJigsawPiece : IPieceBase
	{
		// Token: 0x0600EB01 RID: 60161 RVA: 0x002264BF File Offset: 0x002246BF
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

		// Token: 0x170049EB RID: 18923
		// (get) Token: 0x0600EB02 RID: 60162 RVA: 0x002264DE File Offset: 0x002246DE
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

		// Token: 0x170049EC RID: 18924
		// (get) Token: 0x0600EB03 RID: 60163 RVA: 0x00226512 File Offset: 0x00224712
		public override bool Active
		{
			get
			{
				return this.Instance.Active;
			}
		}

		// Token: 0x170049ED RID: 18925
		// (get) Token: 0x0600EB04 RID: 60164 RVA: 0x0022651F File Offset: 0x0022471F
		public virtual bool IsCorrect
		{
			get
			{
				return this.Instance.IsCorrect;
			}
		}

		// Token: 0x170049EE RID: 18926
		// (get) Token: 0x0600EB05 RID: 60165 RVA: 0x0022652C File Offset: 0x0022472C
		public virtual EJigsawPieceState InitState
		{
			get
			{
				return (EJigsawPieceState)this.Instance.InitState;
			}
		}

		// Token: 0x04008178 RID: 33144
		private IJigsawPiece Instance;

		// Token: 0x04008179 RID: 33145
		[Nullable(2)]
		private IPieceIndex _IndexCache;

		// Token: 0x0400817A RID: 33146
		private bool _IndexInited;
	}
}
