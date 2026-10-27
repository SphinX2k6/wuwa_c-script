using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054F1 RID: 21745
	public struct ILevelSequenceSectionInfo : IFlatbufferObject
	{
		// Token: 0x1700A06B RID: 41067
		// (get) Token: 0x06023E23 RID: 146979 RVA: 0x004F623A File Offset: 0x004F443A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023E24 RID: 146980 RVA: 0x004F6247 File Offset: 0x004F4447
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023E25 RID: 146981 RVA: 0x004F6250 File Offset: 0x004F4450
		public static ILevelSequenceSectionInfo GetRootAsILevelSequenceSectionInfo(ByteBuffer _bb)
		{
			return ILevelSequenceSectionInfo.GetRootAsILevelSequenceSectionInfo(_bb, default(ILevelSequenceSectionInfo));
		}

		// Token: 0x06023E26 RID: 146982 RVA: 0x004F626C File Offset: 0x004F446C
		public static ILevelSequenceSectionInfo GetRootAsILevelSequenceSectionInfo(ByteBuffer _bb, ILevelSequenceSectionInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023E27 RID: 146983 RVA: 0x004F6289 File Offset: 0x004F4489
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023E28 RID: 146984 RVA: 0x004F6298 File Offset: 0x004F4498
		public ILevelSequenceSectionInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A06C RID: 41068
		// (get) Token: 0x06023E29 RID: 146985 RVA: 0x004F62A8 File Offset: 0x004F44A8
		public ELevelSequenceSectionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELevelSequenceSectionType.Mark;
				}
				return (ELevelSequenceSectionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A06D RID: 41069
		// (get) Token: 0x06023E2A RID: 146986 RVA: 0x004F62E4 File Offset: 0x004F44E4
		public string Key
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023E2B RID: 146987 RVA: 0x004F631B File Offset: 0x004F451B
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06023E2C RID: 146988 RVA: 0x004F632A File Offset: 0x004F452A
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700A06E RID: 41070
		// (get) Token: 0x06023E2D RID: 146989 RVA: 0x004F6338 File Offset: 0x004F4538
		public int FrameId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A06F RID: 41071
		// (get) Token: 0x06023E2E RID: 146990 RVA: 0x004F6374 File Offset: 0x004F4574
		public string State
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023E2F RID: 146991 RVA: 0x004F63AC File Offset: 0x004F45AC
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06023E30 RID: 146992 RVA: 0x004F63BC File Offset: 0x004F45BC
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x06023E31 RID: 146993 RVA: 0x004F63CC File Offset: 0x004F45CC
		public string LoopStates(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A070 RID: 41072
		// (get) Token: 0x06023E32 RID: 146994 RVA: 0x004F6408 File Offset: 0x004F4608
		public int LoopStatesLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06023E33 RID: 146995 RVA: 0x004F6434 File Offset: 0x004F4634
		public IActionInfo? ActionList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A071 RID: 41073
		// (get) Token: 0x06023E34 RID: 146996 RVA: 0x004F6498 File Offset: 0x004F4698
		public int ActionListLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A072 RID: 41074
		// (get) Token: 0x06023E35 RID: 146997 RVA: 0x004F64C4 File Offset: 0x004F46C4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023E36 RID: 146998 RVA: 0x004F6504 File Offset: 0x004F4704
		public static Offset<ILevelSequenceSectionInfo> CreateILevelSequenceSectionInfo(FlatBufferBuilder builder, ELevelSequenceSectionType Type = ELevelSequenceSectionType.Mark, StringOffset KeyOffset = default(StringOffset), int FrameId = 0, StringOffset StateOffset = default(StringOffset), VectorOffset LoopStatesOffset = default(VectorOffset), VectorOffset ActionListOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(7);
			ILevelSequenceSectionInfo.AddActionList(builder, ActionListOffset);
			ILevelSequenceSectionInfo.AddLoopStates(builder, LoopStatesOffset);
			ILevelSequenceSectionInfo.AddState(builder, StateOffset);
			ILevelSequenceSectionInfo.AddFrameId(builder, FrameId);
			ILevelSequenceSectionInfo.AddKey(builder, KeyOffset);
			ILevelSequenceSectionInfo.AddNullMask(builder, NullMask);
			ILevelSequenceSectionInfo.AddType(builder, Type);
			return ILevelSequenceSectionInfo.EndILevelSequenceSectionInfo(builder);
		}

		// Token: 0x06023E37 RID: 146999 RVA: 0x004F6553 File Offset: 0x004F4753
		public static void StartILevelSequenceSectionInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06023E38 RID: 147000 RVA: 0x004F655C File Offset: 0x004F475C
		public static void AddType(FlatBufferBuilder builder, ELevelSequenceSectionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023E39 RID: 147001 RVA: 0x004F6567 File Offset: 0x004F4767
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(1, keyOffset.Value, 0);
		}

		// Token: 0x06023E3A RID: 147002 RVA: 0x004F6577 File Offset: 0x004F4777
		public static void AddFrameId(FlatBufferBuilder builder, int frameId)
		{
			builder.AddInt(2, frameId, 0);
		}

		// Token: 0x06023E3B RID: 147003 RVA: 0x004F6582 File Offset: 0x004F4782
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(3, stateOffset.Value, 0);
		}

		// Token: 0x06023E3C RID: 147004 RVA: 0x004F6592 File Offset: 0x004F4792
		public static void AddLoopStates(FlatBufferBuilder builder, VectorOffset loopStatesOffset)
		{
			builder.AddOffset(4, loopStatesOffset.Value, 0);
		}

		// Token: 0x06023E3D RID: 147005 RVA: 0x004F65A4 File Offset: 0x004F47A4
		public static VectorOffset CreateLoopStatesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023E3E RID: 147006 RVA: 0x004F65E4 File Offset: 0x004F47E4
		public static VectorOffset CreateLoopStatesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06023E3F RID: 147007 RVA: 0x004F65FE File Offset: 0x004F47FE
		public static VectorOffset CreateLoopStatesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06023E40 RID: 147008 RVA: 0x004F661C File Offset: 0x004F481C
		public static VectorOffset CreateLoopStatesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023E41 RID: 147009 RVA: 0x004F6635 File Offset: 0x004F4835
		public static void StartLoopStatesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023E42 RID: 147010 RVA: 0x004F6640 File Offset: 0x004F4840
		public static void AddActionList(FlatBufferBuilder builder, VectorOffset actionListOffset)
		{
			builder.AddOffset(5, actionListOffset.Value, 0);
		}

		// Token: 0x06023E43 RID: 147011 RVA: 0x004F6650 File Offset: 0x004F4850
		public static VectorOffset CreateActionListVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023E44 RID: 147012 RVA: 0x004F6690 File Offset: 0x004F4890
		public static VectorOffset CreateActionListVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023E45 RID: 147013 RVA: 0x004F66AA File Offset: 0x004F48AA
		public static VectorOffset CreateActionListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023E46 RID: 147014 RVA: 0x004F66C8 File Offset: 0x004F48C8
		public static VectorOffset CreateActionListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023E47 RID: 147015 RVA: 0x004F66E1 File Offset: 0x004F48E1
		public static void StartActionListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023E48 RID: 147016 RVA: 0x004F66EC File Offset: 0x004F48EC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06023E49 RID: 147017 RVA: 0x004F66F7 File Offset: 0x004F48F7
		public static Offset<ILevelSequenceSectionInfo> EndILevelSequenceSectionInfo(FlatBufferBuilder builder)
		{
			return new Offset<ILevelSequenceSectionInfo>(builder.EndTable());
		}

		// Token: 0x06023E4A RID: 147018 RVA: 0x004F6704 File Offset: 0x004F4904
		public ILevelSequenceSectionInfoT UnPack()
		{
			ILevelSequenceSectionInfoT levelSequenceSectionInfoT = new ILevelSequenceSectionInfoT();
			this.UnPackTo(levelSequenceSectionInfoT);
			return levelSequenceSectionInfoT;
		}

		// Token: 0x06023E4B RID: 147019 RVA: 0x004F6720 File Offset: 0x004F4920
		public void UnPackTo(ILevelSequenceSectionInfoT _o)
		{
			_o.Type = this.Type;
			_o.Key = this.Key;
			_o.FrameId = this.FrameId;
			_o.State = this.State;
			_o.LoopStates = new List<string>();
			for (int i = 0; i < this.LoopStatesLength; i++)
			{
				_o.LoopStates.Add(this.LoopStates(i));
			}
			_o.ActionList = new List<IActionInfoT>();
			for (int j = 0; j < this.ActionListLength; j++)
			{
				_o.ActionList.Add((this.ActionList(j) != null) ? this.ActionList(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023E4C RID: 147020 RVA: 0x004F67EC File Offset: 0x004F49EC
		public static Offset<ILevelSequenceSectionInfo> Pack(FlatBufferBuilder builder, ILevelSequenceSectionInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelSequenceSectionInfo>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			VectorOffset loopStatesOffset = default(VectorOffset);
			if (_o.LoopStates != null)
			{
				StringOffset[] array = new StringOffset[_o.LoopStates.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.LoopStates[i]);
				}
				loopStatesOffset = ILevelSequenceSectionInfo.CreateLoopStatesVector(builder, array);
			}
			VectorOffset actionListOffset = default(VectorOffset);
			if (_o.ActionList != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ActionList.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ActionList[j]);
				}
				actionListOffset = ILevelSequenceSectionInfo.CreateActionListVector(builder, array2);
			}
			return ILevelSequenceSectionInfo.CreateILevelSequenceSectionInfo(builder, _o.Type, keyOffset, _o.FrameId, stateOffset, loopStatesOffset, actionListOffset, _o.NullMask);
		}

		// Token: 0x0400E7CE RID: 59342
		private Table __p;
	}
}
