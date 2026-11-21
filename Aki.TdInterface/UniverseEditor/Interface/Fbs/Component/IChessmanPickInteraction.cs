using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054C6 RID: 21702
	public struct IChessmanPickInteraction : IFlatbufferObject
	{
		// Token: 0x17009AE5 RID: 39653
		// (get) Token: 0x06022389 RID: 140169 RVA: 0x004B78E6 File Offset: 0x004B5AE6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602238A RID: 140170 RVA: 0x004B78F3 File Offset: 0x004B5AF3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602238B RID: 140171 RVA: 0x004B78FC File Offset: 0x004B5AFC
		public static IChessmanPickInteraction GetRootAsIChessmanPickInteraction(ByteBuffer _bb)
		{
			return IChessmanPickInteraction.GetRootAsIChessmanPickInteraction(_bb, default(IChessmanPickInteraction));
		}

		// Token: 0x0602238C RID: 140172 RVA: 0x004B7918 File Offset: 0x004B5B18
		public static IChessmanPickInteraction GetRootAsIChessmanPickInteraction(ByteBuffer _bb, IChessmanPickInteraction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602238D RID: 140173 RVA: 0x004B7935 File Offset: 0x004B5B35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602238E RID: 140174 RVA: 0x004B7944 File Offset: 0x004B5B44
		public IChessmanPickInteraction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009AE6 RID: 39654
		// (get) Token: 0x0602238F RID: 140175 RVA: 0x004B7954 File Offset: 0x004B5B54
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

		// Token: 0x06022390 RID: 140176 RVA: 0x004B7990 File Offset: 0x004B5B90
		public IActionInfo? CheckedActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009AE7 RID: 39655
		// (get) Token: 0x06022391 RID: 140177 RVA: 0x004B79F0 File Offset: 0x004B5BF0
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

		// Token: 0x06022392 RID: 140178 RVA: 0x004B7A1C File Offset: 0x004B5C1C
		public IActionInfo? UncheckedActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009AE8 RID: 39656
		// (get) Token: 0x06022393 RID: 140179 RVA: 0x004B7A7C File Offset: 0x004B5C7C
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

		// Token: 0x17009AE9 RID: 39657
		// (get) Token: 0x06022394 RID: 140180 RVA: 0x004B7AA8 File Offset: 0x004B5CA8
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

		// Token: 0x17009AEA RID: 39658
		// (get) Token: 0x06022395 RID: 140181 RVA: 0x004B7AE8 File Offset: 0x004B5CE8
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

		// Token: 0x06022396 RID: 140182 RVA: 0x004B7B20 File Offset: 0x004B5D20
		public Span<byte> GetAvailablePosEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06022397 RID: 140183 RVA: 0x004B7B30 File Offset: 0x004B5D30
		public byte[] GetAvailablePosEffectArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x17009AEB RID: 39659
		// (get) Token: 0x06022398 RID: 140184 RVA: 0x004B7B40 File Offset: 0x004B5D40
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

		// Token: 0x06022399 RID: 140185 RVA: 0x004B7B7D File Offset: 0x004B5D7D
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

		// Token: 0x0602239A RID: 140186 RVA: 0x004B7BB9 File Offset: 0x004B5DB9
		public static void StartIChessmanPickInteraction(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602239B RID: 140187 RVA: 0x004B7BC2 File Offset: 0x004B5DC2
		public static void AddType(FlatBufferBuilder builder, EPickInteraction type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602239C RID: 140188 RVA: 0x004B7BCD File Offset: 0x004B5DCD
		public static void AddCheckedActions(FlatBufferBuilder builder, VectorOffset checkedActionsOffset)
		{
			builder.AddOffset(1, checkedActionsOffset.Value, 0);
		}

		// Token: 0x0602239D RID: 140189 RVA: 0x004B7BE0 File Offset: 0x004B5DE0
		public static VectorOffset CreateCheckedActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602239E RID: 140190 RVA: 0x004B7C20 File Offset: 0x004B5E20
		public static VectorOffset CreateCheckedActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602239F RID: 140191 RVA: 0x004B7C3A File Offset: 0x004B5E3A
		public static VectorOffset CreateCheckedActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060223A0 RID: 140192 RVA: 0x004B7C58 File Offset: 0x004B5E58
		public static VectorOffset CreateCheckedActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060223A1 RID: 140193 RVA: 0x004B7C71 File Offset: 0x004B5E71
		public static void StartCheckedActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060223A2 RID: 140194 RVA: 0x004B7C7C File Offset: 0x004B5E7C
		public static void AddUncheckedActions(FlatBufferBuilder builder, VectorOffset uncheckedActionsOffset)
		{
			builder.AddOffset(2, uncheckedActionsOffset.Value, 0);
		}

		// Token: 0x060223A3 RID: 140195 RVA: 0x004B7C8C File Offset: 0x004B5E8C
		public static VectorOffset CreateUncheckedActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060223A4 RID: 140196 RVA: 0x004B7CCC File Offset: 0x004B5ECC
		public static VectorOffset CreateUncheckedActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060223A5 RID: 140197 RVA: 0x004B7CE6 File Offset: 0x004B5EE6
		public static VectorOffset CreateUncheckedActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060223A6 RID: 140198 RVA: 0x004B7D04 File Offset: 0x004B5F04
		public static VectorOffset CreateUncheckedActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060223A7 RID: 140199 RVA: 0x004B7D1D File Offset: 0x004B5F1D
		public static void StartUncheckedActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060223A8 RID: 140200 RVA: 0x004B7D28 File Offset: 0x004B5F28
		public static void AddTargetChessboard(FlatBufferBuilder builder, int targetChessboard)
		{
			builder.AddInt(3, targetChessboard, 0);
		}

		// Token: 0x060223A9 RID: 140201 RVA: 0x004B7D33 File Offset: 0x004B5F33
		public static void AddAvailablePosEffect(FlatBufferBuilder builder, StringOffset availablePosEffectOffset)
		{
			builder.AddOffset(4, availablePosEffectOffset.Value, 0);
		}

		// Token: 0x060223AA RID: 140202 RVA: 0x004B7D43 File Offset: 0x004B5F43
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060223AB RID: 140203 RVA: 0x004B7D4E File Offset: 0x004B5F4E
		public static Offset<IChessmanPickInteraction> EndIChessmanPickInteraction(FlatBufferBuilder builder)
		{
			return new Offset<IChessmanPickInteraction>(builder.EndTable());
		}

		// Token: 0x060223AC RID: 140204 RVA: 0x004B7D5C File Offset: 0x004B5F5C
		public IChessmanPickInteractionT UnPack()
		{
			IChessmanPickInteractionT chessmanPickInteractionT = new IChessmanPickInteractionT();
			this.UnPackTo(chessmanPickInteractionT);
			return chessmanPickInteractionT;
		}

		// Token: 0x060223AD RID: 140205 RVA: 0x004B7D78 File Offset: 0x004B5F78
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

		// Token: 0x060223AE RID: 140206 RVA: 0x004B7E5C File Offset: 0x004B605C
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

		// Token: 0x0400EA05 RID: 59909
		private Table __p;
	}
}
