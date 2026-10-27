using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x020046EB RID: 18155
	public struct IEntityRunningData : IFlatbufferObject
	{
		// Token: 0x170081AB RID: 33195
		// (get) Token: 0x0601BC2D RID: 113709 RVA: 0x003EF6AC File Offset: 0x003ED8AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BC2E RID: 113710 RVA: 0x003EF6B9 File Offset: 0x003ED8B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BC2F RID: 113711 RVA: 0x003EF6C0 File Offset: 0x003ED8C0
		public static IEntityRunningData GetRootAsIEntityRunningData(ByteBuffer _bb)
		{
			return IEntityRunningData.GetRootAsIEntityRunningData(_bb, default(IEntityRunningData));
		}

		// Token: 0x0601BC30 RID: 113712 RVA: 0x003EF6DC File Offset: 0x003ED8DC
		public static IEntityRunningData GetRootAsIEntityRunningData(ByteBuffer _bb, IEntityRunningData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BC31 RID: 113713 RVA: 0x003EF6F9 File Offset: 0x003ED8F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BC32 RID: 113714 RVA: 0x003EF708 File Offset: 0x003ED908
		public IEntityRunningData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170081AC RID: 33196
		// (get) Token: 0x0601BC33 RID: 113715 RVA: 0x003EF718 File Offset: 0x003ED918
		public int InstId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170081AD RID: 33197
		// (get) Token: 0x0601BC34 RID: 113716 RVA: 0x003EF754 File Offset: 0x003ED954
		public int ConfigID
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170081AE RID: 33198
		// (get) Token: 0x0601BC35 RID: 113717 RVA: 0x003EF790 File Offset: 0x003ED990
		public bool IsProxy
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170081AF RID: 33199
		// (get) Token: 0x0601BC36 RID: 113718 RVA: 0x003EF7D0 File Offset: 0x003ED9D0
		public EEntityProxyType ProxyState
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EEntityProxyType.None;
				}
				return (EEntityProxyType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170081B0 RID: 33200
		// (get) Token: 0x0601BC37 RID: 113719 RVA: 0x003EF810 File Offset: 0x003EDA10
		public bool IsAwake
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170081B1 RID: 33201
		// (get) Token: 0x0601BC38 RID: 113720 RVA: 0x003EF850 File Offset: 0x003EDA50
		public bool IsVisable
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170081B2 RID: 33202
		// (get) Token: 0x0601BC39 RID: 113721 RVA: 0x003EF890 File Offset: 0x003EDA90
		public bool IsLock
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170081B3 RID: 33203
		// (get) Token: 0x0601BC3A RID: 113722 RVA: 0x003EF8D0 File Offset: 0x003EDAD0
		public bool IsInAOI
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170081B4 RID: 33204
		// (get) Token: 0x0601BC3B RID: 113723 RVA: 0x003EF910 File Offset: 0x003EDB10
		public bool IsInRange
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170081B5 RID: 33205
		// (get) Token: 0x0601BC3C RID: 113724 RVA: 0x003EF950 File Offset: 0x003EDB50
		public string State
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BC3D RID: 113725 RVA: 0x003EF988 File Offset: 0x003EDB88
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0601BC3E RID: 113726 RVA: 0x003EF998 File Offset: 0x003EDB98
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x0601BC3F RID: 113727 RVA: 0x003EF9A8 File Offset: 0x003EDBA8
		public Record_String_String? Vars(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new Record_String_String?(default(Record_String_String).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170081B6 RID: 33206
		// (get) Token: 0x0601BC40 RID: 113728 RVA: 0x003EFA0C File Offset: 0x003EDC0C
		public int VarsLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601BC41 RID: 113729 RVA: 0x003EFA38 File Offset: 0x003EDC38
		public int Options(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170081B7 RID: 33207
		// (get) Token: 0x0601BC42 RID: 113730 RVA: 0x003EFA78 File Offset: 0x003EDC78
		public int OptionsLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601BC43 RID: 113731 RVA: 0x003EFAA4 File Offset: 0x003EDCA4
		public Span<int> GetOptionsBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0601BC44 RID: 113732 RVA: 0x003EFAB4 File Offset: 0x003EDCB4
		public int[] GetOptionsArray()
		{
			return this.__p.__vector_as_array<int>(26);
		}

		// Token: 0x0601BC45 RID: 113733 RVA: 0x003EFAC4 File Offset: 0x003EDCC4
		public Record_Int_EActionState? AllActions(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new Record_Int_EActionState?(default(Record_Int_EActionState).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170081B8 RID: 33208
		// (get) Token: 0x0601BC46 RID: 113734 RVA: 0x003EFB28 File Offset: 0x003EDD28
		public int AllActionsLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601BC47 RID: 113735 RVA: 0x003EFB54 File Offset: 0x003EDD54
		public Record_Int_Int? InRangeEntityStateInfo(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new Record_Int_Int?(default(Record_Int_Int).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170081B9 RID: 33209
		// (get) Token: 0x0601BC48 RID: 113736 RVA: 0x003EFBB8 File Offset: 0x003EDDB8
		public int InRangeEntityStateInfoLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170081BA RID: 33210
		// (get) Token: 0x0601BC49 RID: 113737 RVA: 0x003EFBE4 File Offset: 0x003EDDE4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BC4A RID: 113738 RVA: 0x003EFC24 File Offset: 0x003EDE24
		public static Offset<IEntityRunningData> CreateIEntityRunningData(FlatBufferBuilder builder, int InstId = 0, int configID = 0, bool IsProxy = false, EEntityProxyType ProxyState = EEntityProxyType.None, bool isAwake = false, bool isVisable = false, bool isLock = false, bool isInAOI = false, bool isInRange = false, StringOffset stateOffset = default(StringOffset), VectorOffset VarsOffset = default(VectorOffset), VectorOffset OptionsOffset = default(VectorOffset), VectorOffset AllActionsOffset = default(VectorOffset), VectorOffset InRangeEntityStateInfoOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(15);
			IEntityRunningData.AddInRangeEntityStateInfo(builder, InRangeEntityStateInfoOffset);
			IEntityRunningData.AddAllActions(builder, AllActionsOffset);
			IEntityRunningData.AddOptions(builder, OptionsOffset);
			IEntityRunningData.AddVars(builder, VarsOffset);
			IEntityRunningData.AddState(builder, stateOffset);
			IEntityRunningData.AddConfigID(builder, configID);
			IEntityRunningData.AddInstId(builder, InstId);
			IEntityRunningData.AddNullMask(builder, NullMask);
			IEntityRunningData.AddIsInRange(builder, isInRange);
			IEntityRunningData.AddIsInAOI(builder, isInAOI);
			IEntityRunningData.AddIsLock(builder, isLock);
			IEntityRunningData.AddIsVisable(builder, isVisable);
			IEntityRunningData.AddIsAwake(builder, isAwake);
			IEntityRunningData.AddProxyState(builder, ProxyState);
			IEntityRunningData.AddIsProxy(builder, IsProxy);
			return IEntityRunningData.EndIEntityRunningData(builder);
		}

		// Token: 0x0601BC4B RID: 113739 RVA: 0x003EFCB4 File Offset: 0x003EDEB4
		public static void StartIEntityRunningData(FlatBufferBuilder builder)
		{
			builder.StartTable(15);
		}

		// Token: 0x0601BC4C RID: 113740 RVA: 0x003EFCBE File Offset: 0x003EDEBE
		public static void AddInstId(FlatBufferBuilder builder, int instId)
		{
			builder.AddInt(0, instId, 0);
		}

		// Token: 0x0601BC4D RID: 113741 RVA: 0x003EFCC9 File Offset: 0x003EDEC9
		public static void AddConfigID(FlatBufferBuilder builder, int configID)
		{
			builder.AddInt(1, configID, 0);
		}

		// Token: 0x0601BC4E RID: 113742 RVA: 0x003EFCD4 File Offset: 0x003EDED4
		public static void AddIsProxy(FlatBufferBuilder builder, bool isProxy)
		{
			builder.AddBool(2, isProxy, false);
		}

		// Token: 0x0601BC4F RID: 113743 RVA: 0x003EFCDF File Offset: 0x003EDEDF
		public static void AddProxyState(FlatBufferBuilder builder, EEntityProxyType proxyState)
		{
			builder.AddByte(3, (byte)proxyState, 0);
		}

		// Token: 0x0601BC50 RID: 113744 RVA: 0x003EFCEA File Offset: 0x003EDEEA
		public static void AddIsAwake(FlatBufferBuilder builder, bool isAwake)
		{
			builder.AddBool(4, isAwake, false);
		}

		// Token: 0x0601BC51 RID: 113745 RVA: 0x003EFCF5 File Offset: 0x003EDEF5
		public static void AddIsVisable(FlatBufferBuilder builder, bool isVisable)
		{
			builder.AddBool(5, isVisable, false);
		}

		// Token: 0x0601BC52 RID: 113746 RVA: 0x003EFD00 File Offset: 0x003EDF00
		public static void AddIsLock(FlatBufferBuilder builder, bool isLock)
		{
			builder.AddBool(6, isLock, false);
		}

		// Token: 0x0601BC53 RID: 113747 RVA: 0x003EFD0B File Offset: 0x003EDF0B
		public static void AddIsInAOI(FlatBufferBuilder builder, bool isInAOI)
		{
			builder.AddBool(7, isInAOI, false);
		}

		// Token: 0x0601BC54 RID: 113748 RVA: 0x003EFD16 File Offset: 0x003EDF16
		public static void AddIsInRange(FlatBufferBuilder builder, bool isInRange)
		{
			builder.AddBool(8, isInRange, false);
		}

		// Token: 0x0601BC55 RID: 113749 RVA: 0x003EFD21 File Offset: 0x003EDF21
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(9, stateOffset.Value, 0);
		}

		// Token: 0x0601BC56 RID: 113750 RVA: 0x003EFD32 File Offset: 0x003EDF32
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(10, varsOffset.Value, 0);
		}

		// Token: 0x0601BC57 RID: 113751 RVA: 0x003EFD44 File Offset: 0x003EDF44
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, Offset<Record_String_String>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BC58 RID: 113752 RVA: 0x003EFD84 File Offset: 0x003EDF84
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, Offset<Record_String_String>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_String_String>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BC59 RID: 113753 RVA: 0x003EFD9E File Offset: 0x003EDF9E
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_String_String>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_String_String>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BC5A RID: 113754 RVA: 0x003EFDBC File Offset: 0x003EDFBC
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_String_String>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BC5B RID: 113755 RVA: 0x003EFDD5 File Offset: 0x003EDFD5
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BC5C RID: 113756 RVA: 0x003EFDE0 File Offset: 0x003EDFE0
		public static void AddOptions(FlatBufferBuilder builder, VectorOffset optionsOffset)
		{
			builder.AddOffset(11, optionsOffset.Value, 0);
		}

		// Token: 0x0601BC5D RID: 113757 RVA: 0x003EFDF4 File Offset: 0x003EDFF4
		public static VectorOffset CreateOptionsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BC5E RID: 113758 RVA: 0x003EFE2B File Offset: 0x003EE02B
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BC5F RID: 113759 RVA: 0x003EFE45 File Offset: 0x003EE045
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BC60 RID: 113760 RVA: 0x003EFE63 File Offset: 0x003EE063
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BC61 RID: 113761 RVA: 0x003EFE7C File Offset: 0x003EE07C
		public static void StartOptionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BC62 RID: 113762 RVA: 0x003EFE87 File Offset: 0x003EE087
		public static void AddAllActions(FlatBufferBuilder builder, VectorOffset allActionsOffset)
		{
			builder.AddOffset(12, allActionsOffset.Value, 0);
		}

		// Token: 0x0601BC63 RID: 113763 RVA: 0x003EFE98 File Offset: 0x003EE098
		public static VectorOffset CreateAllActionsVector(FlatBufferBuilder builder, Offset<Record_Int_EActionState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BC64 RID: 113764 RVA: 0x003EFED8 File Offset: 0x003EE0D8
		public static VectorOffset CreateAllActionsVectorBlock(FlatBufferBuilder builder, Offset<Record_Int_EActionState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_Int_EActionState>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BC65 RID: 113765 RVA: 0x003EFEF2 File Offset: 0x003EE0F2
		public static VectorOffset CreateAllActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_Int_EActionState>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_Int_EActionState>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BC66 RID: 113766 RVA: 0x003EFF10 File Offset: 0x003EE110
		public static VectorOffset CreateAllActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_Int_EActionState>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BC67 RID: 113767 RVA: 0x003EFF29 File Offset: 0x003EE129
		public static void StartAllActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BC68 RID: 113768 RVA: 0x003EFF34 File Offset: 0x003EE134
		public static void AddInRangeEntityStateInfo(FlatBufferBuilder builder, VectorOffset inRangeEntityStateInfoOffset)
		{
			builder.AddOffset(13, inRangeEntityStateInfoOffset.Value, 0);
		}

		// Token: 0x0601BC69 RID: 113769 RVA: 0x003EFF48 File Offset: 0x003EE148
		public static VectorOffset CreateInRangeEntityStateInfoVector(FlatBufferBuilder builder, Offset<Record_Int_Int>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BC6A RID: 113770 RVA: 0x003EFF88 File Offset: 0x003EE188
		public static VectorOffset CreateInRangeEntityStateInfoVectorBlock(FlatBufferBuilder builder, Offset<Record_Int_Int>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_Int_Int>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BC6B RID: 113771 RVA: 0x003EFFA2 File Offset: 0x003EE1A2
		public static VectorOffset CreateInRangeEntityStateInfoVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_Int_Int>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_Int_Int>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BC6C RID: 113772 RVA: 0x003EFFC0 File Offset: 0x003EE1C0
		public static VectorOffset CreateInRangeEntityStateInfoVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_Int_Int>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BC6D RID: 113773 RVA: 0x003EFFD9 File Offset: 0x003EE1D9
		public static void StartInRangeEntityStateInfoVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BC6E RID: 113774 RVA: 0x003EFFE4 File Offset: 0x003EE1E4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(14, nullMask, 0);
		}

		// Token: 0x0601BC6F RID: 113775 RVA: 0x003EFFF0 File Offset: 0x003EE1F0
		public static Offset<IEntityRunningData> EndIEntityRunningData(FlatBufferBuilder builder)
		{
			return new Offset<IEntityRunningData>(builder.EndTable());
		}

		// Token: 0x0601BC70 RID: 113776 RVA: 0x003F0000 File Offset: 0x003EE200
		public IEntityRunningDataT UnPack()
		{
			IEntityRunningDataT entityRunningDataT = new IEntityRunningDataT();
			this.UnPackTo(entityRunningDataT);
			return entityRunningDataT;
		}

		// Token: 0x0601BC71 RID: 113777 RVA: 0x003F001C File Offset: 0x003EE21C
		public void UnPackTo(IEntityRunningDataT _o)
		{
			_o.InstId = this.InstId;
			_o.ConfigID = this.ConfigID;
			_o.IsProxy = this.IsProxy;
			_o.ProxyState = this.ProxyState;
			_o.IsAwake = this.IsAwake;
			_o.IsVisable = this.IsVisable;
			_o.IsLock = this.IsLock;
			_o.IsInAOI = this.IsInAOI;
			_o.IsInRange = this.IsInRange;
			_o.State = this.State;
			_o.Vars = new List<Record_String_StringT>();
			for (int i = 0; i < this.VarsLength; i++)
			{
				_o.Vars.Add((this.Vars(i) != null) ? this.Vars(i).Value.UnPack() : null);
			}
			_o.Options = new List<int>();
			for (int j = 0; j < this.OptionsLength; j++)
			{
				_o.Options.Add(this.Options(j));
			}
			_o.AllActions = new List<Record_Int_EActionStateT>();
			for (int k = 0; k < this.AllActionsLength; k++)
			{
				_o.AllActions.Add((this.AllActions(k) != null) ? this.AllActions(k).Value.UnPack() : null);
			}
			_o.InRangeEntityStateInfo = new List<Record_Int_IntT>();
			for (int l = 0; l < this.InRangeEntityStateInfoLength; l++)
			{
				_o.InRangeEntityStateInfo.Add((this.InRangeEntityStateInfo(l) != null) ? this.InRangeEntityStateInfo(l).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601BC72 RID: 113778 RVA: 0x003F01E4 File Offset: 0x003EE3E4
		public static Offset<IEntityRunningData> Pack(FlatBufferBuilder builder, IEntityRunningDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityRunningData>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			VectorOffset varsOffset = default(VectorOffset);
			if (_o.Vars != null)
			{
				Offset<Record_String_String>[] array = new Offset<Record_String_String>[_o.Vars.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = Record_String_String.Pack(builder, _o.Vars[i]);
				}
				varsOffset = IEntityRunningData.CreateVarsVector(builder, array);
			}
			VectorOffset optionsOffset = default(VectorOffset);
			if (_o.Options != null)
			{
				int[] data = _o.Options.ToArray();
				optionsOffset = IEntityRunningData.CreateOptionsVector(builder, data);
			}
			VectorOffset allActionsOffset = default(VectorOffset);
			if (_o.AllActions != null)
			{
				Offset<Record_Int_EActionState>[] array2 = new Offset<Record_Int_EActionState>[_o.AllActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = Record_Int_EActionState.Pack(builder, _o.AllActions[j]);
				}
				allActionsOffset = IEntityRunningData.CreateAllActionsVector(builder, array2);
			}
			VectorOffset inRangeEntityStateInfoOffset = default(VectorOffset);
			if (_o.InRangeEntityStateInfo != null)
			{
				Offset<Record_Int_Int>[] array3 = new Offset<Record_Int_Int>[_o.InRangeEntityStateInfo.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = Record_Int_Int.Pack(builder, _o.InRangeEntityStateInfo[k]);
				}
				inRangeEntityStateInfoOffset = IEntityRunningData.CreateInRangeEntityStateInfoVector(builder, array3);
			}
			return IEntityRunningData.CreateIEntityRunningData(builder, _o.InstId, _o.ConfigID, _o.IsProxy, _o.ProxyState, _o.IsAwake, _o.IsVisable, _o.IsLock, _o.IsInAOI, _o.IsInRange, stateOffset, varsOffset, optionsOffset, allActionsOffset, inRangeEntityStateInfoOffset, _o.NullMask);
		}

		// Token: 0x0400C985 RID: 51589
		private Table __p;
	}
}
