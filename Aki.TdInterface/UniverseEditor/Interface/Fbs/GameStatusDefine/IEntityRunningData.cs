using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B53 RID: 19283
	public struct IEntityRunningData : IFlatbufferObject
	{
		// Token: 0x170087EC RID: 34796
		// (get) Token: 0x0601D402 RID: 119810 RVA: 0x0041B948 File Offset: 0x00419B48
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D403 RID: 119811 RVA: 0x0041B955 File Offset: 0x00419B55
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D404 RID: 119812 RVA: 0x0041B95C File Offset: 0x00419B5C
		public static IEntityRunningData GetRootAsIEntityRunningData(ByteBuffer _bb)
		{
			return IEntityRunningData.GetRootAsIEntityRunningData(_bb, default(IEntityRunningData));
		}

		// Token: 0x0601D405 RID: 119813 RVA: 0x0041B978 File Offset: 0x00419B78
		public static IEntityRunningData GetRootAsIEntityRunningData(ByteBuffer _bb, IEntityRunningData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D406 RID: 119814 RVA: 0x0041B995 File Offset: 0x00419B95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D407 RID: 119815 RVA: 0x0041B9A4 File Offset: 0x00419BA4
		public IEntityRunningData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170087ED RID: 34797
		// (get) Token: 0x0601D408 RID: 119816 RVA: 0x0041B9B4 File Offset: 0x00419BB4
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

		// Token: 0x170087EE RID: 34798
		// (get) Token: 0x0601D409 RID: 119817 RVA: 0x0041B9F0 File Offset: 0x00419BF0
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

		// Token: 0x170087EF RID: 34799
		// (get) Token: 0x0601D40A RID: 119818 RVA: 0x0041BA2C File Offset: 0x00419C2C
		public bool IsProxy
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170087F0 RID: 34800
		// (get) Token: 0x0601D40B RID: 119819 RVA: 0x0041BA6C File Offset: 0x00419C6C
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

		// Token: 0x170087F1 RID: 34801
		// (get) Token: 0x0601D40C RID: 119820 RVA: 0x0041BAAC File Offset: 0x00419CAC
		public bool IsAwake
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170087F2 RID: 34802
		// (get) Token: 0x0601D40D RID: 119821 RVA: 0x0041BAEC File Offset: 0x00419CEC
		public bool IsVisable
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170087F3 RID: 34803
		// (get) Token: 0x0601D40E RID: 119822 RVA: 0x0041BB2C File Offset: 0x00419D2C
		public bool IsLock
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170087F4 RID: 34804
		// (get) Token: 0x0601D40F RID: 119823 RVA: 0x0041BB6C File Offset: 0x00419D6C
		public bool IsInAOI
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170087F5 RID: 34805
		// (get) Token: 0x0601D410 RID: 119824 RVA: 0x0041BBAC File Offset: 0x00419DAC
		public bool IsInRange
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170087F6 RID: 34806
		// (get) Token: 0x0601D411 RID: 119825 RVA: 0x0041BBEC File Offset: 0x00419DEC
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

		// Token: 0x0601D412 RID: 119826 RVA: 0x0041BC24 File Offset: 0x00419E24
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0601D413 RID: 119827 RVA: 0x0041BC34 File Offset: 0x00419E34
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x0601D414 RID: 119828 RVA: 0x0041BC44 File Offset: 0x00419E44
		public Record_String_String? Vars(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new Record_String_String?(default(Record_String_String).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170087F7 RID: 34807
		// (get) Token: 0x0601D415 RID: 119829 RVA: 0x0041BCA8 File Offset: 0x00419EA8
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

		// Token: 0x0601D416 RID: 119830 RVA: 0x0041BCD4 File Offset: 0x00419ED4
		public int Options(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170087F8 RID: 34808
		// (get) Token: 0x0601D417 RID: 119831 RVA: 0x0041BD14 File Offset: 0x00419F14
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

		// Token: 0x0601D418 RID: 119832 RVA: 0x0041BD40 File Offset: 0x00419F40
		public Span<int> GetOptionsBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0601D419 RID: 119833 RVA: 0x0041BD50 File Offset: 0x00419F50
		public int[] GetOptionsArray()
		{
			return this.__p.__vector_as_array<int>(26);
		}

		// Token: 0x0601D41A RID: 119834 RVA: 0x0041BD60 File Offset: 0x00419F60
		public Record_Int_EActionState? AllActions(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new Record_Int_EActionState?(default(Record_Int_EActionState).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170087F9 RID: 34809
		// (get) Token: 0x0601D41B RID: 119835 RVA: 0x0041BDC4 File Offset: 0x00419FC4
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

		// Token: 0x0601D41C RID: 119836 RVA: 0x0041BDF0 File Offset: 0x00419FF0
		public Record_Int_Int? InRangeEntityStateInfo(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new Record_Int_Int?(default(Record_Int_Int).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170087FA RID: 34810
		// (get) Token: 0x0601D41D RID: 119837 RVA: 0x0041BE54 File Offset: 0x0041A054
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

		// Token: 0x170087FB RID: 34811
		// (get) Token: 0x0601D41E RID: 119838 RVA: 0x0041BE80 File Offset: 0x0041A080
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

		// Token: 0x0601D41F RID: 119839 RVA: 0x0041BEC0 File Offset: 0x0041A0C0
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

		// Token: 0x0601D420 RID: 119840 RVA: 0x0041BF50 File Offset: 0x0041A150
		public static void StartIEntityRunningData(FlatBufferBuilder builder)
		{
			builder.StartTable(15);
		}

		// Token: 0x0601D421 RID: 119841 RVA: 0x0041BF5A File Offset: 0x0041A15A
		public static void AddInstId(FlatBufferBuilder builder, int instId)
		{
			builder.AddInt(0, instId, 0);
		}

		// Token: 0x0601D422 RID: 119842 RVA: 0x0041BF65 File Offset: 0x0041A165
		public static void AddConfigID(FlatBufferBuilder builder, int configID)
		{
			builder.AddInt(1, configID, 0);
		}

		// Token: 0x0601D423 RID: 119843 RVA: 0x0041BF70 File Offset: 0x0041A170
		public static void AddIsProxy(FlatBufferBuilder builder, bool isProxy)
		{
			builder.AddBool(2, isProxy, false);
		}

		// Token: 0x0601D424 RID: 119844 RVA: 0x0041BF7B File Offset: 0x0041A17B
		public static void AddProxyState(FlatBufferBuilder builder, EEntityProxyType proxyState)
		{
			builder.AddByte(3, (byte)proxyState, 0);
		}

		// Token: 0x0601D425 RID: 119845 RVA: 0x0041BF86 File Offset: 0x0041A186
		public static void AddIsAwake(FlatBufferBuilder builder, bool isAwake)
		{
			builder.AddBool(4, isAwake, false);
		}

		// Token: 0x0601D426 RID: 119846 RVA: 0x0041BF91 File Offset: 0x0041A191
		public static void AddIsVisable(FlatBufferBuilder builder, bool isVisable)
		{
			builder.AddBool(5, isVisable, false);
		}

		// Token: 0x0601D427 RID: 119847 RVA: 0x0041BF9C File Offset: 0x0041A19C
		public static void AddIsLock(FlatBufferBuilder builder, bool isLock)
		{
			builder.AddBool(6, isLock, false);
		}

		// Token: 0x0601D428 RID: 119848 RVA: 0x0041BFA7 File Offset: 0x0041A1A7
		public static void AddIsInAOI(FlatBufferBuilder builder, bool isInAOI)
		{
			builder.AddBool(7, isInAOI, false);
		}

		// Token: 0x0601D429 RID: 119849 RVA: 0x0041BFB2 File Offset: 0x0041A1B2
		public static void AddIsInRange(FlatBufferBuilder builder, bool isInRange)
		{
			builder.AddBool(8, isInRange, false);
		}

		// Token: 0x0601D42A RID: 119850 RVA: 0x0041BFBD File Offset: 0x0041A1BD
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(9, stateOffset.Value, 0);
		}

		// Token: 0x0601D42B RID: 119851 RVA: 0x0041BFCE File Offset: 0x0041A1CE
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(10, varsOffset.Value, 0);
		}

		// Token: 0x0601D42C RID: 119852 RVA: 0x0041BFE0 File Offset: 0x0041A1E0
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, Offset<Record_String_String>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D42D RID: 119853 RVA: 0x0041C020 File Offset: 0x0041A220
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, Offset<Record_String_String>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_String_String>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D42E RID: 119854 RVA: 0x0041C03A File Offset: 0x0041A23A
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_String_String>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_String_String>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D42F RID: 119855 RVA: 0x0041C058 File Offset: 0x0041A258
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_String_String>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D430 RID: 119856 RVA: 0x0041C071 File Offset: 0x0041A271
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D431 RID: 119857 RVA: 0x0041C07C File Offset: 0x0041A27C
		public static void AddOptions(FlatBufferBuilder builder, VectorOffset optionsOffset)
		{
			builder.AddOffset(11, optionsOffset.Value, 0);
		}

		// Token: 0x0601D432 RID: 119858 RVA: 0x0041C090 File Offset: 0x0041A290
		public static VectorOffset CreateOptionsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D433 RID: 119859 RVA: 0x0041C0C7 File Offset: 0x0041A2C7
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D434 RID: 119860 RVA: 0x0041C0E1 File Offset: 0x0041A2E1
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D435 RID: 119861 RVA: 0x0041C0FF File Offset: 0x0041A2FF
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D436 RID: 119862 RVA: 0x0041C118 File Offset: 0x0041A318
		public static void StartOptionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D437 RID: 119863 RVA: 0x0041C123 File Offset: 0x0041A323
		public static void AddAllActions(FlatBufferBuilder builder, VectorOffset allActionsOffset)
		{
			builder.AddOffset(12, allActionsOffset.Value, 0);
		}

		// Token: 0x0601D438 RID: 119864 RVA: 0x0041C134 File Offset: 0x0041A334
		public static VectorOffset CreateAllActionsVector(FlatBufferBuilder builder, Offset<Record_Int_EActionState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D439 RID: 119865 RVA: 0x0041C174 File Offset: 0x0041A374
		public static VectorOffset CreateAllActionsVectorBlock(FlatBufferBuilder builder, Offset<Record_Int_EActionState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_Int_EActionState>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D43A RID: 119866 RVA: 0x0041C18E File Offset: 0x0041A38E
		public static VectorOffset CreateAllActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_Int_EActionState>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_Int_EActionState>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D43B RID: 119867 RVA: 0x0041C1AC File Offset: 0x0041A3AC
		public static VectorOffset CreateAllActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_Int_EActionState>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D43C RID: 119868 RVA: 0x0041C1C5 File Offset: 0x0041A3C5
		public static void StartAllActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D43D RID: 119869 RVA: 0x0041C1D0 File Offset: 0x0041A3D0
		public static void AddInRangeEntityStateInfo(FlatBufferBuilder builder, VectorOffset inRangeEntityStateInfoOffset)
		{
			builder.AddOffset(13, inRangeEntityStateInfoOffset.Value, 0);
		}

		// Token: 0x0601D43E RID: 119870 RVA: 0x0041C1E4 File Offset: 0x0041A3E4
		public static VectorOffset CreateInRangeEntityStateInfoVector(FlatBufferBuilder builder, Offset<Record_Int_Int>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D43F RID: 119871 RVA: 0x0041C224 File Offset: 0x0041A424
		public static VectorOffset CreateInRangeEntityStateInfoVectorBlock(FlatBufferBuilder builder, Offset<Record_Int_Int>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_Int_Int>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D440 RID: 119872 RVA: 0x0041C23E File Offset: 0x0041A43E
		public static VectorOffset CreateInRangeEntityStateInfoVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_Int_Int>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_Int_Int>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D441 RID: 119873 RVA: 0x0041C25C File Offset: 0x0041A45C
		public static VectorOffset CreateInRangeEntityStateInfoVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_Int_Int>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D442 RID: 119874 RVA: 0x0041C275 File Offset: 0x0041A475
		public static void StartInRangeEntityStateInfoVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D443 RID: 119875 RVA: 0x0041C280 File Offset: 0x0041A480
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(14, nullMask, 0);
		}

		// Token: 0x0601D444 RID: 119876 RVA: 0x0041C28C File Offset: 0x0041A48C
		public static Offset<IEntityRunningData> EndIEntityRunningData(FlatBufferBuilder builder)
		{
			return new Offset<IEntityRunningData>(builder.EndTable());
		}

		// Token: 0x0601D445 RID: 119877 RVA: 0x0041C29C File Offset: 0x0041A49C
		public IEntityRunningDataT UnPack()
		{
			IEntityRunningDataT entityRunningDataT = new IEntityRunningDataT();
			this.UnPackTo(entityRunningDataT);
			return entityRunningDataT;
		}

		// Token: 0x0601D446 RID: 119878 RVA: 0x0041C2B8 File Offset: 0x0041A4B8
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

		// Token: 0x0601D447 RID: 119879 RVA: 0x0041C480 File Offset: 0x0041A680
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

		// Token: 0x0400D3B4 RID: 54196
		private Table __p;
	}
}
