using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core
{
	// Token: 0x0200652A RID: 25898
	[NullableContext(1)]
	[Nullable(0)]
	public class Piece
	{
		// Token: 0x17009526 RID: 38182
		// (get) Token: 0x06040EFC RID: 265980 RVA: 0x00FBC73F File Offset: 0x00FBA93F
		// (set) Token: 0x06040EFD RID: 265981 RVA: 0x00FBC747 File Offset: 0x00FBA947
		public EPieceCaps Caps { get; private set; }

		// Token: 0x17009527 RID: 38183
		// (get) Token: 0x06040EFE RID: 265982 RVA: 0x00FBC750 File Offset: 0x00FBA950
		public bool IsMatchable
		{
			get
			{
				return this.Has(EPieceCaps.Matchable);
			}
		}

		// Token: 0x06040EFF RID: 265983 RVA: 0x00FBC75D File Offset: 0x00FBA95D
		public bool Has(EPieceCaps cap)
		{
			return (this.Caps & cap) > EPieceCaps.None;
		}

		// Token: 0x06040F00 RID: 265984 RVA: 0x00FBC76C File Offset: 0x00FBA96C
		public ref PieceComponentState StateOf(IPieceComponent comp)
		{
			for (int i = 0; i < this.Components.Count; i++)
			{
				if (this.Components[i] == comp)
				{
					return ref this.States[i];
				}
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.MatchThree;
			ELogAuthor author = ELogAuthor.CB;
			string message = "StateOf: 组件不在本棋子上";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", (int)this.Type);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.Missing = default(PieceComponentState);
			return ref this.Missing;
		}

		// Token: 0x06040F01 RID: 265985 RVA: 0x00FBC7F4 File Offset: 0x00FBA9F4
		public void Assign(IReadOnlyList<IPieceComponent> prototypes, EPieceCaps caps)
		{
			this.Components.Clear();
			this.EnsureStateCapacity(prototypes.Count);
			for (int i = 0; i < prototypes.Count; i++)
			{
				this.Components.Add(prototypes[i]);
				this.States[i] = default(PieceComponentState);
				prototypes[i].OnAttach(ref this.States[i]);
			}
			this.Caps = caps;
		}

		// Token: 0x06040F02 RID: 265986 RVA: 0x00FBC86C File Offset: 0x00FBAA6C
		public void Append(IPieceComponent comp)
		{
			this.Components.Add(comp);
			this.EnsureStateCapacity(this.Components.Count);
			this.States[this.Components.Count - 1] = default(PieceComponentState);
			comp.OnAttach(ref this.States[this.Components.Count - 1]);
			this.Caps |= comp.Caps;
		}

		// Token: 0x06040F03 RID: 265987 RVA: 0x00FBC8E8 File Offset: 0x00FBAAE8
		public bool Remove(IPieceComponent comp)
		{
			for (int i = 0; i < this.Components.Count; i++)
			{
				if (this.Components[i] == comp)
				{
					this.Components.RemoveAt(i);
					Array.Copy(this.States, i + 1, this.States, i, this.Components.Count - i);
					this.RebuildCaps();
					return true;
				}
			}
			return false;
		}

		// Token: 0x06040F04 RID: 265988 RVA: 0x00FBC954 File Offset: 0x00FBAB54
		private void RebuildCaps()
		{
			EPieceCaps epieceCaps = EPieceCaps.None;
			foreach (IPieceComponent pieceComponent in this.Components)
			{
				epieceCaps |= pieceComponent.Caps;
			}
			this.Caps = epieceCaps;
		}

		// Token: 0x06040F05 RID: 265989 RVA: 0x00FBC9B4 File Offset: 0x00FBABB4
		public void CopyFrom(Piece src)
		{
			this.Components.Clear();
			this.EnsureStateCapacity(src.Components.Count);
			for (int i = 0; i < src.Components.Count; i++)
			{
				this.Components.Add(src.Components[i]);
				this.States[i] = src.States[i];
			}
			this.Caps = src.Caps;
			this.Type = src.Type;
		}

		// Token: 0x06040F06 RID: 265990 RVA: 0x00FBCA3A File Offset: 0x00FBAC3A
		public void Reset()
		{
			this.Components.Clear();
			this.Caps = EPieceCaps.None;
		}

		// Token: 0x06040F07 RID: 265991 RVA: 0x00FBCA4E File Offset: 0x00FBAC4E
		private void EnsureStateCapacity(int count)
		{
			if (this.States.Length < count)
			{
				Array.Resize<PieceComponentState>(ref this.States, count);
			}
		}

		// Token: 0x04021DF5 RID: 138741
		public readonly List<IPieceComponent> Components = new List<IPieceComponent>();

		// Token: 0x04021DF6 RID: 138742
		private PieceComponentState[] States = new PieceComponentState[4];

		// Token: 0x04021DF8 RID: 138744
		private PieceComponentState Missing;

		// Token: 0x04021DF9 RID: 138745
		public EPieceType Type;
	}
}
