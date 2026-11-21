using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200448D RID: 17549
	public struct IQuestStatistics : IFlatbufferObject
	{
		// Token: 0x170079DB RID: 31195
		// (get) Token: 0x06019406 RID: 103430 RVA: 0x0039A3C4 File Offset: 0x003985C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019407 RID: 103431 RVA: 0x0039A3D1 File Offset: 0x003985D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019408 RID: 103432 RVA: 0x0039A3D8 File Offset: 0x003985D8
		public static IQuestStatistics GetRootAsIQuestStatistics(ByteBuffer _bb)
		{
			return IQuestStatistics.GetRootAsIQuestStatistics(_bb, default(IQuestStatistics));
		}

		// Token: 0x06019409 RID: 103433 RVA: 0x0039A3F4 File Offset: 0x003985F4
		public static IQuestStatistics GetRootAsIQuestStatistics(ByteBuffer _bb, IQuestStatistics obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601940A RID: 103434 RVA: 0x0039A411 File Offset: 0x00398611
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601940B RID: 103435 RVA: 0x0039A420 File Offset: 0x00398620
		public IQuestStatistics __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601940C RID: 103436 RVA: 0x0039A430 File Offset: 0x00398630
		public TQuestStatistics StatisticsConfigType(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return TQuestStatistics.NONE;
			}
			return (TQuestStatistics)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x170079DC RID: 31196
		// (get) Token: 0x0601940D RID: 103437 RVA: 0x0039A470 File Offset: 0x00398670
		public int StatisticsConfigTypeLength
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

		// Token: 0x0601940E RID: 103438 RVA: 0x0039A49B File Offset: 0x0039869B
		public Span<TQuestStatistics> GetStatisticsConfigTypeBytes()
		{
			return this.__p.__vector_as_span<TQuestStatistics>(4, 1);
		}

		// Token: 0x0601940F RID: 103439 RVA: 0x0039A4AC File Offset: 0x003986AC
		public TQuestStatistics[] GetStatisticsConfigTypeArray()
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TQuestStatistics[] array = new TQuestStatistics[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TQuestStatistics)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06019410 RID: 103440 RVA: 0x0039A518 File Offset: 0x00398718
		public TTable? StatisticsConfig<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x170079DD RID: 31197
		// (get) Token: 0x06019411 RID: 103441 RVA: 0x0039A560 File Offset: 0x00398760
		public int StatisticsConfigLength
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

		// Token: 0x06019412 RID: 103442 RVA: 0x0039A58C File Offset: 0x0039878C
		public ICommonCalculateVar? CalculationOnTriggeringStatistics(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new ICommonCalculateVar?(default(ICommonCalculateVar).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170079DE RID: 31198
		// (get) Token: 0x06019413 RID: 103443 RVA: 0x0039A5EC File Offset: 0x003987EC
		public int CalculationOnTriggeringStatisticsLength
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

		// Token: 0x170079DF RID: 31199
		// (get) Token: 0x06019414 RID: 103444 RVA: 0x0039A618 File Offset: 0x00398818
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019415 RID: 103445 RVA: 0x0039A655 File Offset: 0x00398855
		public static Offset<IQuestStatistics> CreateIQuestStatistics(FlatBufferBuilder builder, VectorOffset StatisticsConfig_typeOffset = default(VectorOffset), VectorOffset StatisticsConfigOffset = default(VectorOffset), VectorOffset CalculationOnTriggeringStatisticsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IQuestStatistics.AddCalculationOnTriggeringStatistics(builder, CalculationOnTriggeringStatisticsOffset);
			IQuestStatistics.AddStatisticsConfig(builder, StatisticsConfigOffset);
			IQuestStatistics.AddStatisticsConfigType(builder, StatisticsConfig_typeOffset);
			IQuestStatistics.AddNullMask(builder, NullMask);
			return IQuestStatistics.EndIQuestStatistics(builder);
		}

		// Token: 0x06019416 RID: 103446 RVA: 0x0039A681 File Offset: 0x00398881
		public static void StartIQuestStatistics(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06019417 RID: 103447 RVA: 0x0039A68A File Offset: 0x0039888A
		public static void AddStatisticsConfigType(FlatBufferBuilder builder, VectorOffset statisticsConfigTypeOffset)
		{
			builder.AddOffset(0, statisticsConfigTypeOffset.Value, 0);
		}

		// Token: 0x06019418 RID: 103448 RVA: 0x0039A69C File Offset: 0x0039889C
		public static VectorOffset CreateStatisticsConfigTypeVector(FlatBufferBuilder builder, TQuestStatistics[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019419 RID: 103449 RVA: 0x0039A6D3 File Offset: 0x003988D3
		public static VectorOffset CreateStatisticsConfigTypeVectorBlock(FlatBufferBuilder builder, TQuestStatistics[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TQuestStatistics>(data);
			return builder.EndVector();
		}

		// Token: 0x0601941A RID: 103450 RVA: 0x0039A6ED File Offset: 0x003988ED
		public static VectorOffset CreateStatisticsConfigTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TQuestStatistics> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TQuestStatistics>(data);
			return builder.EndVector();
		}

		// Token: 0x0601941B RID: 103451 RVA: 0x0039A70B File Offset: 0x0039890B
		public static VectorOffset CreateStatisticsConfigTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TQuestStatistics>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601941C RID: 103452 RVA: 0x0039A724 File Offset: 0x00398924
		public static void StartStatisticsConfigTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601941D RID: 103453 RVA: 0x0039A72F File Offset: 0x0039892F
		public static void AddStatisticsConfig(FlatBufferBuilder builder, VectorOffset statisticsConfigOffset)
		{
			builder.AddOffset(1, statisticsConfigOffset.Value, 0);
		}

		// Token: 0x0601941E RID: 103454 RVA: 0x0039A740 File Offset: 0x00398940
		public static VectorOffset CreateStatisticsConfigVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601941F RID: 103455 RVA: 0x0039A777 File Offset: 0x00398977
		public static VectorOffset CreateStatisticsConfigVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019420 RID: 103456 RVA: 0x0039A791 File Offset: 0x00398991
		public static VectorOffset CreateStatisticsConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019421 RID: 103457 RVA: 0x0039A7AF File Offset: 0x003989AF
		public static VectorOffset CreateStatisticsConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019422 RID: 103458 RVA: 0x0039A7C8 File Offset: 0x003989C8
		public static void StartStatisticsConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019423 RID: 103459 RVA: 0x0039A7D3 File Offset: 0x003989D3
		public static void AddCalculationOnTriggeringStatistics(FlatBufferBuilder builder, VectorOffset calculationOnTriggeringStatisticsOffset)
		{
			builder.AddOffset(2, calculationOnTriggeringStatisticsOffset.Value, 0);
		}

		// Token: 0x06019424 RID: 103460 RVA: 0x0039A7E4 File Offset: 0x003989E4
		public static VectorOffset CreateCalculationOnTriggeringStatisticsVector(FlatBufferBuilder builder, Offset<ICommonCalculateVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06019425 RID: 103461 RVA: 0x0039A824 File Offset: 0x00398A24
		public static VectorOffset CreateCalculationOnTriggeringStatisticsVectorBlock(FlatBufferBuilder builder, Offset<ICommonCalculateVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICommonCalculateVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019426 RID: 103462 RVA: 0x0039A83E File Offset: 0x00398A3E
		public static VectorOffset CreateCalculationOnTriggeringStatisticsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICommonCalculateVar>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICommonCalculateVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019427 RID: 103463 RVA: 0x0039A85C File Offset: 0x00398A5C
		public static VectorOffset CreateCalculationOnTriggeringStatisticsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICommonCalculateVar>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019428 RID: 103464 RVA: 0x0039A875 File Offset: 0x00398A75
		public static void StartCalculationOnTriggeringStatisticsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019429 RID: 103465 RVA: 0x0039A880 File Offset: 0x00398A80
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601942A RID: 103466 RVA: 0x0039A88B File Offset: 0x00398A8B
		public static Offset<IQuestStatistics> EndIQuestStatistics(FlatBufferBuilder builder)
		{
			return new Offset<IQuestStatistics>(builder.EndTable());
		}

		// Token: 0x0601942B RID: 103467 RVA: 0x0039A898 File Offset: 0x00398A98
		public IQuestStatisticsT UnPack()
		{
			IQuestStatisticsT questStatisticsT = new IQuestStatisticsT();
			this.UnPackTo(questStatisticsT);
			return questStatisticsT;
		}

		// Token: 0x0601942C RID: 103468 RVA: 0x0039A8B4 File Offset: 0x00398AB4
		public void UnPackTo(IQuestStatisticsT _o)
		{
			_o.StatisticsConfig = new List<TQuestStatisticsUnion>();
			for (int i = 0; i < this.StatisticsConfigLength; i++)
			{
				TQuestStatisticsUnion tquestStatisticsUnion = new TQuestStatisticsUnion();
				tquestStatisticsUnion.Type = this.StatisticsConfigType(i);
				switch (this.StatisticsConfigType(i))
				{
				case TQuestStatistics.IQuestMechaTrackScore:
					tquestStatisticsUnion.Value = ((this.StatisticsConfig<IQuestMechaTrackScore>(i) != null) ? this.StatisticsConfig<IQuestMechaTrackScore>(i).Value.UnPack() : null);
					break;
				case TQuestStatistics.IQuestMonsterHealthScore:
					tquestStatisticsUnion.Value = ((this.StatisticsConfig<IQuestMonsterHealthScore>(i) != null) ? this.StatisticsConfig<IQuestMonsterHealthScore>(i).Value.UnPack() : null);
					break;
				case TQuestStatistics.IQuestMonsterPoint:
					tquestStatisticsUnion.Value = ((this.StatisticsConfig<IQuestMonsterPoint>(i) != null) ? this.StatisticsConfig<IQuestMonsterPoint>(i).Value.UnPack() : null);
					break;
				case TQuestStatistics.IQuestMonsterRemainingHealth:
					tquestStatisticsUnion.Value = ((this.StatisticsConfig<IQuestMonsterRemainingHealth>(i) != null) ? this.StatisticsConfig<IQuestMonsterRemainingHealth>(i).Value.UnPack() : null);
					break;
				case TQuestStatistics.IQuestPlayerHitStatistics:
					tquestStatisticsUnion.Value = ((this.StatisticsConfig<IQuestPlayerHitStatistics>(i) != null) ? this.StatisticsConfig<IQuestPlayerHitStatistics>(i).Value.UnPack() : null);
					break;
				case TQuestStatistics.IQuestStaticTimer:
					tquestStatisticsUnion.Value = ((this.StatisticsConfig<IQuestStaticTimer>(i) != null) ? this.StatisticsConfig<IQuestStaticTimer>(i).Value.UnPack() : null);
					break;
				case TQuestStatistics.IQuestStatisticsCollect:
					tquestStatisticsUnion.Value = ((this.StatisticsConfig<IQuestStatisticsCollect>(i) != null) ? this.StatisticsConfig<IQuestStatisticsCollect>(i).Value.UnPack() : null);
					break;
				case TQuestStatistics.IQuestStatisticsPlayerTriggerMotion:
					tquestStatisticsUnion.Value = ((this.StatisticsConfig<IQuestStatisticsPlayerTriggerMotion>(i) != null) ? this.StatisticsConfig<IQuestStatisticsPlayerTriggerMotion>(i).Value.UnPack() : null);
					break;
				case TQuestStatistics.IQuestStatisticsUseSkill:
					tquestStatisticsUnion.Value = ((this.StatisticsConfig<IQuestStatisticsUseSkill>(i) != null) ? this.StatisticsConfig<IQuestStatisticsUseSkill>(i).Value.UnPack() : null);
					break;
				case TQuestStatistics.IQuestStatisticsUseSkillNew:
					tquestStatisticsUnion.Value = ((this.StatisticsConfig<IQuestStatisticsUseSkillNew>(i) != null) ? this.StatisticsConfig<IQuestStatisticsUseSkillNew>(i).Value.UnPack() : null);
					break;
				}
				_o.StatisticsConfig.Add(tquestStatisticsUnion);
			}
			_o.CalculationOnTriggeringStatistics = new List<ICommonCalculateVarT>();
			for (int j = 0; j < this.CalculationOnTriggeringStatisticsLength; j++)
			{
				_o.CalculationOnTriggeringStatistics.Add((this.CalculationOnTriggeringStatistics(j) != null) ? this.CalculationOnTriggeringStatistics(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601942D RID: 103469 RVA: 0x0039ABD4 File Offset: 0x00398DD4
		public static Offset<IQuestStatistics> Pack(FlatBufferBuilder builder, IQuestStatisticsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestStatistics>);
			}
			VectorOffset statisticsConfig_typeOffset = default(VectorOffset);
			if (_o.StatisticsConfig != null)
			{
				TQuestStatistics[] array = new TQuestStatistics[_o.StatisticsConfig.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.StatisticsConfig[i].Type;
				}
				statisticsConfig_typeOffset = IQuestStatistics.CreateStatisticsConfigTypeVector(builder, array);
			}
			VectorOffset statisticsConfigOffset = default(VectorOffset);
			if (_o.StatisticsConfig != null)
			{
				int[] array2 = new int[_o.StatisticsConfig.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TQuestStatisticsUnion.Pack(builder, _o.StatisticsConfig[j]);
				}
				statisticsConfigOffset = IQuestStatistics.CreateStatisticsConfigVector(builder, array2);
			}
			VectorOffset calculationOnTriggeringStatisticsOffset = default(VectorOffset);
			if (_o.CalculationOnTriggeringStatistics != null)
			{
				Offset<ICommonCalculateVar>[] array3 = new Offset<ICommonCalculateVar>[_o.CalculationOnTriggeringStatistics.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = ICommonCalculateVar.Pack(builder, _o.CalculationOnTriggeringStatistics[k]);
				}
				calculationOnTriggeringStatisticsOffset = IQuestStatistics.CreateCalculationOnTriggeringStatisticsVector(builder, array3);
			}
			return IQuestStatistics.CreateIQuestStatistics(builder, statisticsConfig_typeOffset, statisticsConfigOffset, calculationOnTriggeringStatisticsOffset, _o.NullMask);
		}

		// Token: 0x0400C579 RID: 50553
		private Table __p;
	}
}
