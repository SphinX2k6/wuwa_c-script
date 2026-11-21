using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006038 RID: 24632
	public struct ITargetGearGroupConfig : IFlatbufferObject
	{
		// Token: 0x1700B6D3 RID: 46803
		// (get) Token: 0x06029918 RID: 170264 RVA: 0x005ACA57 File Offset: 0x005AAC57
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029919 RID: 170265 RVA: 0x005ACA64 File Offset: 0x005AAC64
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602991A RID: 170266 RVA: 0x005ACA6C File Offset: 0x005AAC6C
		public static ITargetGearGroupConfig GetRootAsITargetGearGroupConfig(ByteBuffer _bb)
		{
			return ITargetGearGroupConfig.GetRootAsITargetGearGroupConfig(_bb, default(ITargetGearGroupConfig));
		}

		// Token: 0x0602991B RID: 170267 RVA: 0x005ACA88 File Offset: 0x005AAC88
		public static ITargetGearGroupConfig GetRootAsITargetGearGroupConfig(ByteBuffer _bb, ITargetGearGroupConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602991C RID: 170268 RVA: 0x005ACAA5 File Offset: 0x005AACA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602991D RID: 170269 RVA: 0x005ACAB4 File Offset: 0x005AACB4
		public ITargetGearGroupConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602991E RID: 170270 RVA: 0x005ACAC4 File Offset: 0x005AACC4
		public int Entitys(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B6D4 RID: 46804
		// (get) Token: 0x0602991F RID: 170271 RVA: 0x005ACB04 File Offset: 0x005AAD04
		public int EntitysLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06029920 RID: 170272 RVA: 0x005ACB2F File Offset: 0x005AAD2F
		public Span<int> GetEntitysBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06029921 RID: 170273 RVA: 0x005ACB3E File Offset: 0x005AAD3E
		public int[] GetEntitysArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x1700B6D5 RID: 46805
		// (get) Token: 0x06029922 RID: 170274 RVA: 0x005ACB4C File Offset: 0x005AAD4C
		public TTargetGearGroupSuccessCondition SuccessConditionType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TTargetGearGroupSuccessCondition.NONE;
				}
				return (TTargetGearGroupSuccessCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029923 RID: 170275 RVA: 0x005ACB88 File Offset: 0x005AAD88
		public TTable? SuccessCondition<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06029924 RID: 170276 RVA: 0x005ACBCC File Offset: 0x005AADCC
		public ISuccessConditionCountDownState SuccessConditionAsISuccessConditionCountDownState()
		{
			return this.SuccessCondition<ISuccessConditionCountDownState>().Value;
		}

		// Token: 0x06029925 RID: 170277 RVA: 0x005ACBE8 File Offset: 0x005AADE8
		public ISuccessConditionSameArbitraryState SuccessConditionAsISuccessConditionSameArbitraryState()
		{
			return this.SuccessCondition<ISuccessConditionSameArbitraryState>().Value;
		}

		// Token: 0x06029926 RID: 170278 RVA: 0x005ACC04 File Offset: 0x005AAE04
		public ISuccessConditionSameSpecificState SuccessConditionAsISuccessConditionSameSpecificState()
		{
			return this.SuccessCondition<ISuccessConditionSameSpecificState>().Value;
		}

		// Token: 0x06029927 RID: 170279 RVA: 0x005ACC20 File Offset: 0x005AAE20
		public ISuccessConditionSpecificTargetState SuccessConditionAsISuccessConditionSpecificTargetState()
		{
			return this.SuccessCondition<ISuccessConditionSpecificTargetState>().Value;
		}

		// Token: 0x06029928 RID: 170280 RVA: 0x005ACC3C File Offset: 0x005AAE3C
		public TTargetGearGroupFailureCondition FailureConditionsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TTargetGearGroupFailureCondition.NONE;
			}
			return (TTargetGearGroupFailureCondition)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700B6D6 RID: 46806
		// (get) Token: 0x06029929 RID: 170281 RVA: 0x005ACC7C File Offset: 0x005AAE7C
		public int FailureConditionsTypeLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602992A RID: 170282 RVA: 0x005ACCA8 File Offset: 0x005AAEA8
		public Span<TTargetGearGroupFailureCondition> GetFailureConditionsTypeBytes()
		{
			return this.__p.__vector_as_span<TTargetGearGroupFailureCondition>(10, 1);
		}

		// Token: 0x0602992B RID: 170283 RVA: 0x005ACCB8 File Offset: 0x005AAEB8
		public TTargetGearGroupFailureCondition[] GetFailureConditionsTypeArray()
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TTargetGearGroupFailureCondition[] array = new TTargetGearGroupFailureCondition[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TTargetGearGroupFailureCondition)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0602992C RID: 170284 RVA: 0x005ACD24 File Offset: 0x005AAF24
		public TTable? FailureConditions<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700B6D7 RID: 46807
		// (get) Token: 0x0602992D RID: 170285 RVA: 0x005ACD6C File Offset: 0x005AAF6C
		public int FailureConditionsLength
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

		// Token: 0x0602992E RID: 170286 RVA: 0x005ACD98 File Offset: 0x005AAF98
		public ICheckGearHit? CheckGears(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new ICheckGearHit?(default(ICheckGearHit).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B6D8 RID: 46808
		// (get) Token: 0x0602992F RID: 170287 RVA: 0x005ACDFC File Offset: 0x005AAFFC
		public int CheckGearsLength
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

		// Token: 0x1700B6D9 RID: 46809
		// (get) Token: 0x06029930 RID: 170288 RVA: 0x005ACE28 File Offset: 0x005AB028
		public TGroupFinishConfig FinishConfigType
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return TGroupFinishConfig.NONE;
				}
				return (TGroupFinishConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029931 RID: 170289 RVA: 0x005ACE68 File Offset: 0x005AB068
		public TTable? FinishConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06029932 RID: 170290 RVA: 0x005ACEB0 File Offset: 0x005AB0B0
		public IGroupFinishDestroy FinishConfigAsIGroupFinishDestroy()
		{
			return this.FinishConfig<IGroupFinishDestroy>().Value;
		}

		// Token: 0x06029933 RID: 170291 RVA: 0x005ACECC File Offset: 0x005AB0CC
		public IGroupFinishSilence FinishConfigAsIGroupFinishSilence()
		{
			return this.FinishConfig<IGroupFinishSilence>().Value;
		}

		// Token: 0x1700B6DA RID: 46810
		// (get) Token: 0x06029934 RID: 170292 RVA: 0x005ACEE8 File Offset: 0x005AB0E8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029935 RID: 170293 RVA: 0x005ACF28 File Offset: 0x005AB128
		public static Offset<ITargetGearGroupConfig> CreateITargetGearGroupConfig(FlatBufferBuilder builder, VectorOffset EntitysOffset = default(VectorOffset), TTargetGearGroupSuccessCondition SuccessCondition_type = TTargetGearGroupSuccessCondition.NONE, int SuccessConditionOffset = 0, VectorOffset FailureConditions_typeOffset = default(VectorOffset), VectorOffset FailureConditionsOffset = default(VectorOffset), VectorOffset CheckGearsOffset = default(VectorOffset), TGroupFinishConfig FinishConfig_type = TGroupFinishConfig.NONE, int FinishConfigOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(9);
			ITargetGearGroupConfig.AddFinishConfig(builder, FinishConfigOffset);
			ITargetGearGroupConfig.AddCheckGears(builder, CheckGearsOffset);
			ITargetGearGroupConfig.AddFailureConditions(builder, FailureConditionsOffset);
			ITargetGearGroupConfig.AddFailureConditionsType(builder, FailureConditions_typeOffset);
			ITargetGearGroupConfig.AddSuccessCondition(builder, SuccessConditionOffset);
			ITargetGearGroupConfig.AddEntitys(builder, EntitysOffset);
			ITargetGearGroupConfig.AddNullMask(builder, NullMask);
			ITargetGearGroupConfig.AddFinishConfigType(builder, FinishConfig_type);
			ITargetGearGroupConfig.AddSuccessConditionType(builder, SuccessCondition_type);
			return ITargetGearGroupConfig.EndITargetGearGroupConfig(builder);
		}

		// Token: 0x06029936 RID: 170294 RVA: 0x005ACF88 File Offset: 0x005AB188
		public static void StartITargetGearGroupConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06029937 RID: 170295 RVA: 0x005ACF92 File Offset: 0x005AB192
		public static void AddEntitys(FlatBufferBuilder builder, VectorOffset entitysOffset)
		{
			builder.AddOffset(0, entitysOffset.Value, 0);
		}

		// Token: 0x06029938 RID: 170296 RVA: 0x005ACFA4 File Offset: 0x005AB1A4
		public static VectorOffset CreateEntitysVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06029939 RID: 170297 RVA: 0x005ACFDB File Offset: 0x005AB1DB
		public static VectorOffset CreateEntitysVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602993A RID: 170298 RVA: 0x005ACFF5 File Offset: 0x005AB1F5
		public static VectorOffset CreateEntitysVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602993B RID: 170299 RVA: 0x005AD013 File Offset: 0x005AB213
		public static VectorOffset CreateEntitysVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602993C RID: 170300 RVA: 0x005AD02C File Offset: 0x005AB22C
		public static void StartEntitysVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602993D RID: 170301 RVA: 0x005AD037 File Offset: 0x005AB237
		public static void AddSuccessConditionType(FlatBufferBuilder builder, TTargetGearGroupSuccessCondition successConditionType)
		{
			builder.AddByte(1, (byte)successConditionType, 0);
		}

		// Token: 0x0602993E RID: 170302 RVA: 0x005AD042 File Offset: 0x005AB242
		public static void AddSuccessCondition(FlatBufferBuilder builder, int successConditionOffset)
		{
			builder.AddOffset(2, successConditionOffset, 0);
		}

		// Token: 0x0602993F RID: 170303 RVA: 0x005AD04D File Offset: 0x005AB24D
		public static void AddFailureConditionsType(FlatBufferBuilder builder, VectorOffset failureConditionsTypeOffset)
		{
			builder.AddOffset(3, failureConditionsTypeOffset.Value, 0);
		}

		// Token: 0x06029940 RID: 170304 RVA: 0x005AD060 File Offset: 0x005AB260
		public static VectorOffset CreateFailureConditionsTypeVector(FlatBufferBuilder builder, TTargetGearGroupFailureCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06029941 RID: 170305 RVA: 0x005AD097 File Offset: 0x005AB297
		public static VectorOffset CreateFailureConditionsTypeVectorBlock(FlatBufferBuilder builder, TTargetGearGroupFailureCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TTargetGearGroupFailureCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x06029942 RID: 170306 RVA: 0x005AD0B1 File Offset: 0x005AB2B1
		public static VectorOffset CreateFailureConditionsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TTargetGearGroupFailureCondition> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TTargetGearGroupFailureCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x06029943 RID: 170307 RVA: 0x005AD0CF File Offset: 0x005AB2CF
		public static VectorOffset CreateFailureConditionsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TTargetGearGroupFailureCondition>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029944 RID: 170308 RVA: 0x005AD0E8 File Offset: 0x005AB2E8
		public static void StartFailureConditionsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06029945 RID: 170309 RVA: 0x005AD0F3 File Offset: 0x005AB2F3
		public static void AddFailureConditions(FlatBufferBuilder builder, VectorOffset failureConditionsOffset)
		{
			builder.AddOffset(4, failureConditionsOffset.Value, 0);
		}

		// Token: 0x06029946 RID: 170310 RVA: 0x005AD104 File Offset: 0x005AB304
		public static VectorOffset CreateFailureConditionsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06029947 RID: 170311 RVA: 0x005AD13B File Offset: 0x005AB33B
		public static VectorOffset CreateFailureConditionsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029948 RID: 170312 RVA: 0x005AD155 File Offset: 0x005AB355
		public static VectorOffset CreateFailureConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029949 RID: 170313 RVA: 0x005AD173 File Offset: 0x005AB373
		public static VectorOffset CreateFailureConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602994A RID: 170314 RVA: 0x005AD18C File Offset: 0x005AB38C
		public static void StartFailureConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602994B RID: 170315 RVA: 0x005AD197 File Offset: 0x005AB397
		public static void AddCheckGears(FlatBufferBuilder builder, VectorOffset checkGearsOffset)
		{
			builder.AddOffset(5, checkGearsOffset.Value, 0);
		}

		// Token: 0x0602994C RID: 170316 RVA: 0x005AD1A8 File Offset: 0x005AB3A8
		public static VectorOffset CreateCheckGearsVector(FlatBufferBuilder builder, Offset<ICheckGearHit>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602994D RID: 170317 RVA: 0x005AD1E8 File Offset: 0x005AB3E8
		public static VectorOffset CreateCheckGearsVectorBlock(FlatBufferBuilder builder, Offset<ICheckGearHit>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICheckGearHit>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602994E RID: 170318 RVA: 0x005AD202 File Offset: 0x005AB402
		public static VectorOffset CreateCheckGearsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICheckGearHit>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICheckGearHit>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602994F RID: 170319 RVA: 0x005AD220 File Offset: 0x005AB420
		public static VectorOffset CreateCheckGearsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICheckGearHit>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029950 RID: 170320 RVA: 0x005AD239 File Offset: 0x005AB439
		public static void StartCheckGearsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029951 RID: 170321 RVA: 0x005AD244 File Offset: 0x005AB444
		public static void AddFinishConfigType(FlatBufferBuilder builder, TGroupFinishConfig finishConfigType)
		{
			builder.AddByte(6, (byte)finishConfigType, 0);
		}

		// Token: 0x06029952 RID: 170322 RVA: 0x005AD24F File Offset: 0x005AB44F
		public static void AddFinishConfig(FlatBufferBuilder builder, int finishConfigOffset)
		{
			builder.AddOffset(7, finishConfigOffset, 0);
		}

		// Token: 0x06029953 RID: 170323 RVA: 0x005AD25A File Offset: 0x005AB45A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06029954 RID: 170324 RVA: 0x005AD265 File Offset: 0x005AB465
		public static Offset<ITargetGearGroupConfig> EndITargetGearGroupConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITargetGearGroupConfig>(builder.EndTable());
		}

		// Token: 0x06029955 RID: 170325 RVA: 0x005AD274 File Offset: 0x005AB474
		public ITargetGearGroupConfigT UnPack()
		{
			ITargetGearGroupConfigT targetGearGroupConfigT = new ITargetGearGroupConfigT();
			this.UnPackTo(targetGearGroupConfigT);
			return targetGearGroupConfigT;
		}

		// Token: 0x06029956 RID: 170326 RVA: 0x005AD290 File Offset: 0x005AB490
		public void UnPackTo(ITargetGearGroupConfigT _o)
		{
			_o.Entitys = new List<int>();
			for (int i = 0; i < this.EntitysLength; i++)
			{
				_o.Entitys.Add(this.Entitys(i));
			}
			_o.SuccessCondition = new TTargetGearGroupSuccessConditionUnion();
			_o.SuccessCondition.Type = this.SuccessConditionType;
			switch (this.SuccessConditionType)
			{
			case TTargetGearGroupSuccessCondition.ISuccessConditionCountDownState:
				_o.SuccessCondition.Value = ((this.SuccessCondition<ISuccessConditionCountDownState>() != null) ? this.SuccessCondition<ISuccessConditionCountDownState>().Value.UnPack() : null);
				break;
			case TTargetGearGroupSuccessCondition.ISuccessConditionSameArbitraryState:
				_o.SuccessCondition.Value = ((this.SuccessCondition<ISuccessConditionSameArbitraryState>() != null) ? this.SuccessCondition<ISuccessConditionSameArbitraryState>().Value.UnPack() : null);
				break;
			case TTargetGearGroupSuccessCondition.ISuccessConditionSameSpecificState:
				_o.SuccessCondition.Value = ((this.SuccessCondition<ISuccessConditionSameSpecificState>() != null) ? this.SuccessCondition<ISuccessConditionSameSpecificState>().Value.UnPack() : null);
				break;
			case TTargetGearGroupSuccessCondition.ISuccessConditionSpecificTargetState:
				_o.SuccessCondition.Value = ((this.SuccessCondition<ISuccessConditionSpecificTargetState>() != null) ? this.SuccessCondition<ISuccessConditionSpecificTargetState>().Value.UnPack() : null);
				break;
			}
			_o.FailureConditions = new List<TTargetGearGroupFailureConditionUnion>();
			for (int j = 0; j < this.FailureConditionsLength; j++)
			{
				TTargetGearGroupFailureConditionUnion ttargetGearGroupFailureConditionUnion = new TTargetGearGroupFailureConditionUnion();
				ttargetGearGroupFailureConditionUnion.Type = this.FailureConditionsType(j);
				switch (this.FailureConditionsType(j))
				{
				case TTargetGearGroupFailureCondition.IFailureConditionArbitraryState:
					ttargetGearGroupFailureConditionUnion.Value = ((this.FailureConditions<IFailureConditionArbitraryState>(j) != null) ? this.FailureConditions<IFailureConditionArbitraryState>(j).Value.UnPack() : null);
					break;
				case TTargetGearGroupFailureCondition.IFailureConditionHitTargetEntity:
					ttargetGearGroupFailureConditionUnion.Value = ((this.FailureConditions<IFailureConditionHitTargetEntity>(j) != null) ? this.FailureConditions<IFailureConditionHitTargetEntity>(j).Value.UnPack() : null);
					break;
				case TTargetGearGroupFailureCondition.IFailureConditionSequentialState:
					ttargetGearGroupFailureConditionUnion.Value = ((this.FailureConditions<IFailureConditionSequentialState>(j) != null) ? this.FailureConditions<IFailureConditionSequentialState>(j).Value.UnPack() : null);
					break;
				}
				_o.FailureConditions.Add(ttargetGearGroupFailureConditionUnion);
			}
			_o.CheckGears = new List<ICheckGearHitT>();
			for (int k = 0; k < this.CheckGearsLength; k++)
			{
				_o.CheckGears.Add((this.CheckGears(k) != null) ? this.CheckGears(k).Value.UnPack() : null);
			}
			_o.FinishConfig = new TGroupFinishConfigUnion();
			_o.FinishConfig.Type = this.FinishConfigType;
			TGroupFinishConfig finishConfigType = this.FinishConfigType;
			if (finishConfigType != TGroupFinishConfig.IGroupFinishDestroy)
			{
				if (finishConfigType == TGroupFinishConfig.IGroupFinishSilence)
				{
					_o.FinishConfig.Value = ((this.FinishConfig<IGroupFinishSilence>() != null) ? this.FinishConfig<IGroupFinishSilence>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.FinishConfig.Value = ((this.FinishConfig<IGroupFinishDestroy>() != null) ? this.FinishConfig<IGroupFinishDestroy>().Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06029957 RID: 170327 RVA: 0x005AD60C File Offset: 0x005AB80C
		public static Offset<ITargetGearGroupConfig> Pack(FlatBufferBuilder builder, ITargetGearGroupConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITargetGearGroupConfig>);
			}
			VectorOffset entitysOffset = default(VectorOffset);
			if (_o.Entitys != null)
			{
				int[] data = _o.Entitys.ToArray();
				entitysOffset = ITargetGearGroupConfig.CreateEntitysVector(builder, data);
			}
			TTargetGearGroupSuccessCondition successCondition_type = (_o.SuccessCondition == null) ? TTargetGearGroupSuccessCondition.NONE : _o.SuccessCondition.Type;
			int successConditionOffset = (_o.SuccessCondition == null) ? 0 : TTargetGearGroupSuccessConditionUnion.Pack(builder, _o.SuccessCondition);
			VectorOffset failureConditions_typeOffset = default(VectorOffset);
			if (_o.FailureConditions != null)
			{
				TTargetGearGroupFailureCondition[] array = new TTargetGearGroupFailureCondition[_o.FailureConditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.FailureConditions[i].Type;
				}
				failureConditions_typeOffset = ITargetGearGroupConfig.CreateFailureConditionsTypeVector(builder, array);
			}
			VectorOffset failureConditionsOffset = default(VectorOffset);
			if (_o.FailureConditions != null)
			{
				int[] array2 = new int[_o.FailureConditions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TTargetGearGroupFailureConditionUnion.Pack(builder, _o.FailureConditions[j]);
				}
				failureConditionsOffset = ITargetGearGroupConfig.CreateFailureConditionsVector(builder, array2);
			}
			VectorOffset checkGearsOffset = default(VectorOffset);
			if (_o.CheckGears != null)
			{
				Offset<ICheckGearHit>[] array3 = new Offset<ICheckGearHit>[_o.CheckGears.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = ICheckGearHit.Pack(builder, _o.CheckGears[k]);
				}
				checkGearsOffset = ITargetGearGroupConfig.CreateCheckGearsVector(builder, array3);
			}
			TGroupFinishConfig finishConfig_type = (_o.FinishConfig == null) ? TGroupFinishConfig.NONE : _o.FinishConfig.Type;
			int finishConfigOffset = (_o.FinishConfig == null) ? 0 : TGroupFinishConfigUnion.Pack(builder, _o.FinishConfig);
			return ITargetGearGroupConfig.CreateITargetGearGroupConfig(builder, entitysOffset, successCondition_type, successConditionOffset, failureConditions_typeOffset, failureConditionsOffset, checkGearsOffset, finishConfig_type, finishConfigOffset, _o.NullMask);
		}

		// Token: 0x0400FD86 RID: 64902
		private Table __p;
	}
}
