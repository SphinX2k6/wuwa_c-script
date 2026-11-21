using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core
{
	// Token: 0x020054A8 RID: 21672
	[NullableContext(1)]
	[Nullable(0)]
	public class Piece
	{
		// Token: 0x17006888 RID: 26760
		// (get) Token: 0x06035BC1 RID: 220097 RVA: 0x00F03783 File Offset: 0x00F01983
		// (set) Token: 0x06035BC2 RID: 220098 RVA: 0x00F0378B File Offset: 0x00F0198B
		public EPieceCaps Caps { get; private set; }

		// Token: 0x17006889 RID: 26761
		// (get) Token: 0x06035BC3 RID: 220099 RVA: 0x00F03794 File Offset: 0x00F01994
		public bool IsMatchable
		{
			get
			{
				return this.Has(EPieceCaps.Matchable);
			}
		}

		// Token: 0x06035BC4 RID: 220100 RVA: 0x00F037A1 File Offset: 0x00F019A1
		public bool Has(EPieceCaps cap)
		{
			return (this.Caps & cap) > EPieceCaps.None;
		}

		// Token: 0x06035BC5 RID: 220101 RVA: 0x00F037B0 File Offset: 0x00F019B0
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

		// Token: 0x06035BC6 RID: 220102 RVA: 0x00F03838 File Offset: 0x00F01A38
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

		// Token: 0x06035BC7 RID: 220103 RVA: 0x00F038B0 File Offset: 0x00F01AB0
		public void Append(IPieceComponent comp)
		{
			this.Components.Add(comp);
			this.EnsureStateCapacity(this.Components.Count);
			this.States[this.Components.Count - 1] = default(PieceComponentState);
			comp.OnAttach(ref this.States[this.Components.Count - 1]);
			this.Caps |= comp.Caps;
		}

		// Token: 0x06035BC8 RID: 220104 RVA: 0x00F0392C File Offset: 0x00F01B2C
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

		// Token: 0x06035BC9 RID: 220105 RVA: 0x00F03998 File Offset: 0x00F01B98
		private void RebuildCaps()
		{
			EPieceCaps epieceCaps = EPieceCaps.None;
			foreach (IPieceComponent pieceComponent in this.Components)
			{
				epieceCaps |= pieceComponent.Caps;
			}
			this.Caps = epieceCaps;
		}

		// Token: 0x06035BCA RID: 220106 RVA: 0x00F039F8 File Offset: 0x00F01BF8
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

		// Token: 0x06035BCB RID: 220107 RVA: 0x00F03A7E File Offset: 0x00F01C7E
		public void Reset()
		{
			this.Components.Clear();
			this.Caps = EPieceCaps.None;
		}

		// Token: 0x06035BCC RID: 220108 RVA: 0x00F03A92 File Offset: 0x00F01C92
		private void EnsureStateCapacity(int count)
		{
			if (this.States.Length < count)
			{
				Array.Resize<PieceComponentState>(ref this.States, count);
			}
		}

		// Token: 0x0401C726 RID: 116518
		public readonly List<IPieceComponent> Components = new List<IPieceComponent>();

		// Token: 0x0401C727 RID: 116519
		private PieceComponentState[] States = new PieceComponentState[4];

		// Token: 0x0401C729 RID: 116521
		private PieceComponentState Missing;

		// Token: 0x0401C72A RID: 116522
		public EPieceType Type;
	}
}
