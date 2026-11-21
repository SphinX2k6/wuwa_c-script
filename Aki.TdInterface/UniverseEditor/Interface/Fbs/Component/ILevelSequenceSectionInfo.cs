using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A77 RID: 23159
	public struct ILevelSequenceSectionInfo : IFlatbufferObject
	{
		// Token: 0x1700A8A5 RID: 43173
		// (get) Token: 0x06025EDD RID: 155357 RVA: 0x0053335E File Offset: 0x0053155E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025EDE RID: 155358 RVA: 0x0053336B File Offset: 0x0053156B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025EDF RID: 155359 RVA: 0x00533374 File Offset: 0x00531574
		public static ILevelSequenceSectionInfo GetRootAsILevelSequenceSectionInfo(ByteBuffer _bb)
		{
			return ILevelSequenceSectionInfo.GetRootAsILevelSequenceSectionInfo(_bb, default(ILevelSequenceSectionInfo));
		}

		// Token: 0x06025EE0 RID: 155360 RVA: 0x00533390 File Offset: 0x00531590
		public static ILevelSequenceSectionInfo GetRootAsILevelSequenceSectionInfo(ByteBuffer _bb, ILevelSequenceSectionInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025EE1 RID: 155361 RVA: 0x005333AD File Offset: 0x005315AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025EE2 RID: 155362 RVA: 0x005333BC File Offset: 0x005315BC
		public ILevelSequenceSectionInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A8A6 RID: 43174
		// (get) Token: 0x06025EE3 RID: 155363 RVA: 0x005333CC File Offset: 0x005315CC
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

		// Token: 0x1700A8A7 RID: 43175
		// (get) Token: 0x06025EE4 RID: 155364 RVA: 0x00533408 File Offset: 0x00531608
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

		// Token: 0x06025EE5 RID: 155365 RVA: 0x0053343F File Offset: 0x0053163F
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06025EE6 RID: 155366 RVA: 0x0053344E File Offset: 0x0053164E
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700A8A8 RID: 43176
		// (get) Token: 0x06025EE7 RID: 155367 RVA: 0x0053345C File Offset: 0x0053165C
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

		// Token: 0x1700A8A9 RID: 43177
		// (get) Token: 0x06025EE8 RID: 155368 RVA: 0x00533498 File Offset: 0x00531698
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

		// Token: 0x06025EE9 RID: 155369 RVA: 0x005334D0 File Offset: 0x005316D0
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06025EEA RID: 155370 RVA: 0x005334E0 File Offset: 0x005316E0
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x06025EEB RID: 155371 RVA: 0x005334F0 File Offset: 0x005316F0
		public string LoopStates(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A8AA RID: 43178
		// (get) Token: 0x06025EEC RID: 155372 RVA: 0x0053352C File Offset: 0x0053172C
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

		// Token: 0x06025EED RID: 155373 RVA: 0x00533558 File Offset: 0x00531758
		public IActionInfo? ActionList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A8AB RID: 43179
		// (get) Token: 0x06025EEE RID: 155374 RVA: 0x005335BC File Offset: 0x005317BC
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

		// Token: 0x1700A8AC RID: 43180
		// (get) Token: 0x06025EEF RID: 155375 RVA: 0x005335E8 File Offset: 0x005317E8
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

		// Token: 0x06025EF0 RID: 155376 RVA: 0x00533628 File Offset: 0x00531828
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

		// Token: 0x06025EF1 RID: 155377 RVA: 0x00533677 File Offset: 0x00531877
		public static void StartILevelSequenceSectionInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06025EF2 RID: 155378 RVA: 0x00533680 File Offset: 0x00531880
		public static void AddType(FlatBufferBuilder builder, ELevelSequenceSectionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025EF3 RID: 155379 RVA: 0x0053368B File Offset: 0x0053188B
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(1, keyOffset.Value, 0);
		}

		// Token: 0x06025EF4 RID: 155380 RVA: 0x0053369B File Offset: 0x0053189B
		public static void AddFrameId(FlatBufferBuilder builder, int frameId)
		{
			builder.AddInt(2, frameId, 0);
		}

		// Token: 0x06025EF5 RID: 155381 RVA: 0x005336A6 File Offset: 0x005318A6
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(3, stateOffset.Value, 0);
		}

		// Token: 0x06025EF6 RID: 155382 RVA: 0x005336B6 File Offset: 0x005318B6
		public static void AddLoopStates(FlatBufferBuilder builder, VectorOffset loopStatesOffset)
		{
			builder.AddOffset(4, loopStatesOffset.Value, 0);
		}

		// Token: 0x06025EF7 RID: 155383 RVA: 0x005336C8 File Offset: 0x005318C8
		public static VectorOffset CreateLoopStatesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025EF8 RID: 155384 RVA: 0x00533708 File Offset: 0x00531908
		public static VectorOffset CreateLoopStatesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06025EF9 RID: 155385 RVA: 0x00533722 File Offset: 0x00531922
		public static VectorOffset CreateLoopStatesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06025EFA RID: 155386 RVA: 0x00533740 File Offset: 0x00531940
		public static VectorOffset CreateLoopStatesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025EFB RID: 155387 RVA: 0x00533759 File Offset: 0x00531959
		public static void StartLoopStatesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025EFC RID: 155388 RVA: 0x00533764 File Offset: 0x00531964
		public static void AddActionList(FlatBufferBuilder builder, VectorOffset actionListOffset)
		{
			builder.AddOffset(5, actionListOffset.Value, 0);
		}

		// Token: 0x06025EFD RID: 155389 RVA: 0x00533774 File Offset: 0x00531974
		public static VectorOffset CreateActionListVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025EFE RID: 155390 RVA: 0x005337B4 File Offset: 0x005319B4
		public static VectorOffset CreateActionListVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025EFF RID: 155391 RVA: 0x005337CE File Offset: 0x005319CE
		public static VectorOffset CreateActionListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025F00 RID: 155392 RVA: 0x005337EC File Offset: 0x005319EC
		public static VectorOffset CreateActionListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025F01 RID: 155393 RVA: 0x00533805 File Offset: 0x00531A05
		public static void StartActionListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025F02 RID: 155394 RVA: 0x00533810 File Offset: 0x00531A10
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06025F03 RID: 155395 RVA: 0x0053381B File Offset: 0x00531A1B
		public static Offset<ILevelSequenceSectionInfo> EndILevelSequenceSectionInfo(FlatBufferBuilder builder)
		{
			return new Offset<ILevelSequenceSectionInfo>(builder.EndTable());
		}

		// Token: 0x06025F04 RID: 155396 RVA: 0x00533828 File Offset: 0x00531A28
		public ILevelSequenceSectionInfoT UnPack()
		{
			ILevelSequenceSectionInfoT levelSequenceSectionInfoT = new ILevelSequenceSectionInfoT();
			this.UnPackTo(levelSequenceSectionInfoT);
			return levelSequenceSectionInfoT;
		}

		// Token: 0x06025F05 RID: 155397 RVA: 0x00533844 File Offset: 0x00531A44
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

		// Token: 0x06025F06 RID: 155398 RVA: 0x00533910 File Offset: 0x00531B10
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

		// Token: 0x0400F3FF RID: 62463
		private Table __p;
	}
}
