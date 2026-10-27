using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F97 RID: 20375
	public struct IChessmanPickInteraction : IFlatbufferObject
	{
		// Token: 0x1700936C RID: 37740
		// (get) Token: 0x06020637 RID: 132663 RVA: 0x004818F6 File Offset: 0x0047FAF6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020638 RID: 132664 RVA: 0x00481903 File Offset: 0x0047FB03
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020639 RID: 132665 RVA: 0x0048190C File Offset: 0x0047FB0C
		public static IChessmanPickInteraction GetRootAsIChessmanPickInteraction(ByteBuffer _bb)
		{
			return IChessmanPickInteraction.GetRootAsIChessmanPickInteraction(_bb, default(IChessmanPickInteraction));
		}

		// Token: 0x0602063A RID: 132666 RVA: 0x00481928 File Offset: 0x0047FB28
		public static IChessmanPickInteraction GetRootAsIChessmanPickInteraction(ByteBuffer _bb, IChessmanPickInteraction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602063B RID: 132667 RVA: 0x00481945 File Offset: 0x0047FB45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602063C RID: 132668 RVA: 0x00481954 File Offset: 0x0047FB54
		public IChessmanPickInteraction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700936D RID: 37741
		// (get) Token: 0x0602063D RID: 132669 RVA: 0x00481964 File Offset: 0x0047FB64
		public EPickInteraction Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPickInteraction.ChessmanInteract;
				}
				return (EPickInteraction)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602063E RID: 132670 RVA: 0x004819A0 File Offset: 0x0047FBA0
		public IActionInfo? CheckedActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700936E RID: 37742
		// (get) Token: 0x0602063F RID: 132671 RVA: 0x00481A00 File Offset: 0x0047FC00
		public int CheckedActionsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06020640 RID: 132672 RVA: 0x00481A2C File Offset: 0x0047FC2C
		public IActionInfo? UncheckedActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700936F RID: 37743
		// (get) Token: 0x06020641 RID: 132673 RVA: 0x00481A8C File Offset: 0x0047FC8C
		public int UncheckedActionsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17009370 RID: 37744
		// (get) Token: 0x06020642 RID: 132674 RVA: 0x00481AB8 File Offset: 0x0047FCB8
		public int TargetChessboard
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009371 RID: 37745
		// (get) Token: 0x06020643 RID: 132675 RVA: 0x00481AF8 File Offset: 0x0047FCF8
		public string AvailablePosEffect
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020644 RID: 132676 RVA: 0x00481B30 File Offset: 0x0047FD30
		public Span<byte> GetAvailablePosEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06020645 RID: 132677 RVA: 0x00481B40 File Offset: 0x0047FD40
		public byte[] GetAvailablePosEffectArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x17009372 RID: 37746
		// (get) Token: 0x06020646 RID: 132678 RVA: 0x00481B50 File Offset: 0x0047FD50
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020647 RID: 132679 RVA: 0x00481B8D File Offset: 0x0047FD8D
		public static Offset<IChessmanPickInteraction> CreateIChessmanPickInteraction(FlatBufferBuilder builder, EPickInteraction Type = EPickInteraction.ChessmanInteract, VectorOffset CheckedActionsOffset = default(VectorOffset), VectorOffset UncheckedActionsOffset = default(VectorOffset), int TargetChessboard = 0, StringOffset AvailablePosEffectOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IChessmanPickInteraction.AddAvailablePosEffect(builder, AvailablePosEffectOffset);
			IChessmanPickInteraction.AddTargetChessboard(builder, TargetChessboard);
			IChessmanPickInteraction.AddUncheckedActions(builder, UncheckedActionsOffset);
			IChessmanPickInteraction.AddCheckedActions(builder, CheckedActionsOffset);
			IChessmanPickInteraction.AddNullMask(builder, NullMask);
			IChessmanPickInteraction.AddType(builder, Type);
			return IChessmanPickInteraction.EndIChessmanPickInteraction(builder);
		}

		// Token: 0x06020648 RID: 132680 RVA: 0x00481BC9 File Offset: 0x0047FDC9
		public static void StartIChessmanPickInteraction(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06020649 RID: 132681 RVA: 0x00481BD2 File Offset: 0x0047FDD2
		public static void AddType(FlatBufferBuilder builder, EPickInteraction type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602064A RID: 132682 RVA: 0x00481BDD File Offset: 0x0047FDDD
		public static void AddCheckedActions(FlatBufferBuilder builder, VectorOffset checkedActionsOffset)
		{
			builder.AddOffset(1, checkedActionsOffset.Value, 0);
		}

		// Token: 0x0602064B RID: 132683 RVA: 0x00481BF0 File Offset: 0x0047FDF0
		public static VectorOffset CreateCheckedActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602064C RID: 132684 RVA: 0x00481C30 File Offset: 0x0047FE30
		public static VectorOffset CreateCheckedActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602064D RID: 132685 RVA: 0x00481C4A File Offset: 0x0047FE4A
		public static VectorOffset CreateCheckedActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602064E RID: 132686 RVA: 0x00481C68 File Offset: 0x0047FE68
		public static VectorOffset CreateCheckedActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602064F RID: 132687 RVA: 0x00481C81 File Offset: 0x0047FE81
		public static void StartCheckedActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020650 RID: 132688 RVA: 0x00481C8C File Offset: 0x0047FE8C
		public static void AddUncheckedActions(FlatBufferBuilder builder, VectorOffset uncheckedActionsOffset)
		{
			builder.AddOffset(2, uncheckedActionsOffset.Value, 0);
		}

		// Token: 0x06020651 RID: 132689 RVA: 0x00481C9C File Offset: 0x0047FE9C
		public static VectorOffset CreateUncheckedActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06020652 RID: 132690 RVA: 0x00481CDC File Offset: 0x0047FEDC
		public static VectorOffset CreateUncheckedActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020653 RID: 132691 RVA: 0x00481CF6 File Offset: 0x0047FEF6
		public static VectorOffset CreateUncheckedActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020654 RID: 132692 RVA: 0x00481D14 File Offset: 0x0047FF14
		public static VectorOffset CreateUncheckedActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020655 RID: 132693 RVA: 0x00481D2D File Offset: 0x0047FF2D
		public static void StartUncheckedActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020656 RID: 132694 RVA: 0x00481D38 File Offset: 0x0047FF38
		public static void AddTargetChessboard(FlatBufferBuilder builder, int targetChessboard)
		{
			builder.AddInt(3, targetChessboard, 0);
		}

		// Token: 0x06020657 RID: 132695 RVA: 0x00481D43 File Offset: 0x0047FF43
		public static void AddAvailablePosEffect(FlatBufferBuilder builder, StringOffset availablePosEffectOffset)
		{
			builder.AddOffset(4, availablePosEffectOffset.Value, 0);
		}

		// Token: 0x06020658 RID: 132696 RVA: 0x00481D53 File Offset: 0x0047FF53
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06020659 RID: 132697 RVA: 0x00481D5E File Offset: 0x0047FF5E
		public static Offset<IChessmanPickInteraction> EndIChessmanPickInteraction(FlatBufferBuilder builder)
		{
			return new Offset<IChessmanPickInteraction>(builder.EndTable());
		}

		// Token: 0x0602065A RID: 132698 RVA: 0x00481D6C File Offset: 0x0047FF6C
		public IChessmanPickInteractionT UnPack()
		{
			IChessmanPickInteractionT chessmanPickInteractionT = new IChessmanPickInteractionT();
			this.UnPackTo(chessmanPickInteractionT);
			return chessmanPickInteractionT;
		}

		// Token: 0x0602065B RID: 132699 RVA: 0x00481D88 File Offset: 0x0047FF88
		public void UnPackTo(IChessmanPickInteractionT _o)
		{
			_o.Type = this.Type;
			_o.CheckedActions = new List<IActionInfoT>();
			for (int i = 0; i < this.CheckedActionsLength; i++)
			{
				_o.CheckedActions.Add((this.CheckedActions(i) != null) ? this.CheckedActions(i).Value.UnPack() : null);
			}
			_o.UncheckedActions = new List<IActionInfoT>();
			for (int j = 0; j < this.UncheckedActionsLength; j++)
			{
				_o.UncheckedActions.Add((this.UncheckedActions(j) != null) ? this.UncheckedActions(j).Value.UnPack() : null);
			}
			_o.TargetChessboard = this.TargetChessboard;
			_o.AvailablePosEffect = this.AvailablePosEffect;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602065C RID: 132700 RVA: 0x00481E6C File Offset: 0x0048006C
		public static Offset<IChessmanPickInteraction> Pack(FlatBufferBuilder builder, IChessmanPickInteractionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChessmanPickInteraction>);
			}
			VectorOffset checkedActionsOffset = default(VectorOffset);
			if (_o.CheckedActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.CheckedActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.CheckedActions[i]);
				}
				checkedActionsOffset = IChessmanPickInteraction.CreateCheckedActionsVector(builder, array);
			}
			VectorOffset uncheckedActionsOffset = default(VectorOffset);
			if (_o.UncheckedActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.UncheckedActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.UncheckedActions[j]);
				}
				uncheckedActionsOffset = IChessmanPickInteraction.CreateUncheckedActionsVector(builder, array2);
			}
			StringOffset availablePosEffectOffset = (_o.AvailablePosEffect == null) ? default(StringOffset) : builder.CreateString(_o.AvailablePosEffect);
			return IChessmanPickInteraction.CreateIChessmanPickInteraction(builder, _o.Type, checkedActionsOffset, uncheckedActionsOffset, _o.TargetChessboard, availablePosEffectOffset, _o.NullMask);
		}

		// Token: 0x0400DE5B RID: 56923
		private Table __p;
	}
}
