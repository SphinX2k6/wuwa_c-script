using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200404C RID: 16460
	public struct IQuestStatistics : IFlatbufferObject
	{
		// Token: 0x170073D9 RID: 29657
		// (get) Token: 0x06017D6D RID: 97645 RVA: 0x003705D0 File Offset: 0x0036E7D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017D6E RID: 97646 RVA: 0x003705DD File Offset: 0x0036E7DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017D6F RID: 97647 RVA: 0x003705E4 File Offset: 0x0036E7E4
		public static IQuestStatistics GetRootAsIQuestStatistics(ByteBuffer _bb)
		{
			return IQuestStatistics.GetRootAsIQuestStatistics(_bb, default(IQuestStatistics));
		}

		// Token: 0x06017D70 RID: 97648 RVA: 0x00370600 File Offset: 0x0036E800
		public static IQuestStatistics GetRootAsIQuestStatistics(ByteBuffer _bb, IQuestStatistics obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017D71 RID: 97649 RVA: 0x0037061D File Offset: 0x0036E81D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017D72 RID: 97650 RVA: 0x0037062C File Offset: 0x0036E82C
		public IQuestStatistics __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06017D73 RID: 97651 RVA: 0x0037063C File Offset: 0x0036E83C
		public TQuestStatistics StatisticsConfigType(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return TQuestStatistics.NONE;
			}
			return (TQuestStatistics)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x170073DA RID: 29658
		// (get) Token: 0x06017D74 RID: 97652 RVA: 0x0037067C File Offset: 0x0036E87C
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

		// Token: 0x06017D75 RID: 97653 RVA: 0x003706A7 File Offset: 0x0036E8A7
		public Span<TQuestStatistics> GetStatisticsConfigTypeBytes()
		{
			return this.__p.__vector_as_span<TQuestStatistics>(4, 1);
		}

		// Token: 0x06017D76 RID: 97654 RVA: 0x003706B8 File Offset: 0x0036E8B8
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

		// Token: 0x06017D77 RID: 97655 RVA: 0x00370724 File Offset: 0x0036E924
		public TTable? StatisticsConfig<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x170073DB RID: 29659
		// (get) Token: 0x06017D78 RID: 97656 RVA: 0x0037076C File Offset: 0x0036E96C
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

		// Token: 0x06017D79 RID: 97657 RVA: 0x00370798 File Offset: 0x0036E998
		public ICommonCalculateVar? CalculationOnTriggeringStatistics(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new ICommonCalculateVar?(default(ICommonCalculateVar).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170073DC RID: 29660
		// (get) Token: 0x06017D7A RID: 97658 RVA: 0x003707F8 File Offset: 0x0036E9F8
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

		// Token: 0x170073DD RID: 29661
		// (get) Token: 0x06017D7B RID: 97659 RVA: 0x00370824 File Offset: 0x0036EA24
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

		// Token: 0x06017D7C RID: 97660 RVA: 0x00370861 File Offset: 0x0036EA61
		public static Offset<IQuestStatistics> CreateIQuestStatistics(FlatBufferBuilder builder, VectorOffset StatisticsConfig_typeOffset = default(VectorOffset), VectorOffset StatisticsConfigOffset = default(VectorOffset), VectorOffset CalculationOnTriggeringStatisticsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IQuestStatistics.AddCalculationOnTriggeringStatistics(builder, CalculationOnTriggeringStatisticsOffset);
			IQuestStatistics.AddStatisticsConfig(builder, StatisticsConfigOffset);
			IQuestStatistics.AddStatisticsConfigType(builder, StatisticsConfig_typeOffset);
			IQuestStatistics.AddNullMask(builder, NullMask);
			return IQuestStatistics.EndIQuestStatistics(builder);
		}

		// Token: 0x06017D7D RID: 97661 RVA: 0x0037088D File Offset: 0x0036EA8D
		public static void StartIQuestStatistics(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06017D7E RID: 97662 RVA: 0x00370896 File Offset: 0x0036EA96
		public static void AddStatisticsConfigType(FlatBufferBuilder builder, VectorOffset statisticsConfigTypeOffset)
		{
			builder.AddOffset(0, statisticsConfigTypeOffset.Value, 0);
		}

		// Token: 0x06017D7F RID: 97663 RVA: 0x003708A8 File Offset: 0x0036EAA8
		public static VectorOffset CreateStatisticsConfigTypeVector(FlatBufferBuilder builder, TQuestStatistics[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017D80 RID: 97664 RVA: 0x003708DF File Offset: 0x0036EADF
		public static VectorOffset CreateStatisticsConfigTypeVectorBlock(FlatBufferBuilder builder, TQuestStatistics[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TQuestStatistics>(data);
			return builder.EndVector();
		}

		// Token: 0x06017D81 RID: 97665 RVA: 0x003708F9 File Offset: 0x0036EAF9
		public static VectorOffset CreateStatisticsConfigTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TQuestStatistics> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TQuestStatistics>(data);
			return builder.EndVector();
		}

		// Token: 0x06017D82 RID: 97666 RVA: 0x00370917 File Offset: 0x0036EB17
		public static VectorOffset CreateStatisticsConfigTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TQuestStatistics>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017D83 RID: 97667 RVA: 0x00370930 File Offset: 0x0036EB30
		public static void StartStatisticsConfigTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06017D84 RID: 97668 RVA: 0x0037093B File Offset: 0x0036EB3B
		public static void AddStatisticsConfig(FlatBufferBuilder builder, VectorOffset statisticsConfigOffset)
		{
			builder.AddOffset(1, statisticsConfigOffset.Value, 0);
		}

		// Token: 0x06017D85 RID: 97669 RVA: 0x0037094C File Offset: 0x0036EB4C
		public static VectorOffset CreateStatisticsConfigVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017D86 RID: 97670 RVA: 0x00370983 File Offset: 0x0036EB83
		public static VectorOffset CreateStatisticsConfigVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017D87 RID: 97671 RVA: 0x0037099D File Offset: 0x0036EB9D
		public static VectorOffset CreateStatisticsConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017D88 RID: 97672 RVA: 0x003709BB File Offset: 0x0036EBBB
		public static VectorOffset CreateStatisticsConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017D89 RID: 97673 RVA: 0x003709D4 File Offset: 0x0036EBD4
		public static void StartStatisticsConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017D8A RID: 97674 RVA: 0x003709DF File Offset: 0x0036EBDF
		public static void AddCalculationOnTriggeringStatistics(FlatBufferBuilder builder, VectorOffset calculationOnTriggeringStatisticsOffset)
		{
			builder.AddOffset(2, calculationOnTriggeringStatisticsOffset.Value, 0);
		}

		// Token: 0x06017D8B RID: 97675 RVA: 0x003709F0 File Offset: 0x0036EBF0
		public static VectorOffset CreateCalculationOnTriggeringStatisticsVector(FlatBufferBuilder builder, Offset<ICommonCalculateVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06017D8C RID: 97676 RVA: 0x00370A30 File Offset: 0x0036EC30
		public static VectorOffset CreateCalculationOnTriggeringStatisticsVectorBlock(FlatBufferBuilder builder, Offset<ICommonCalculateVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICommonCalculateVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017D8D RID: 97677 RVA: 0x00370A4A File Offset: 0x0036EC4A
		public static VectorOffset CreateCalculationOnTriggeringStatisticsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICommonCalculateVar>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICommonCalculateVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017D8E RID: 97678 RVA: 0x00370A68 File Offset: 0x0036EC68
		public static VectorOffset CreateCalculationOnTriggeringStatisticsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICommonCalculateVar>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017D8F RID: 97679 RVA: 0x00370A81 File Offset: 0x0036EC81
		public static void StartCalculationOnTriggeringStatisticsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017D90 RID: 97680 RVA: 0x00370A8C File Offset: 0x0036EC8C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06017D91 RID: 97681 RVA: 0x00370A97 File Offset: 0x0036EC97
		public static Offset<IQuestStatistics> EndIQuestStatistics(FlatBufferBuilder builder)
		{
			return new Offset<IQuestStatistics>(builder.EndTable());
		}

		// Token: 0x06017D92 RID: 97682 RVA: 0x00370AA4 File Offset: 0x0036ECA4
		public IQuestStatisticsT UnPack()
		{
			IQuestStatisticsT questStatisticsT = new IQuestStatisticsT();
			this.UnPackTo(questStatisticsT);
			return questStatisticsT;
		}

		// Token: 0x06017D93 RID: 97683 RVA: 0x00370AC0 File Offset: 0x0036ECC0
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

		// Token: 0x06017D94 RID: 97684 RVA: 0x00370DE0 File Offset: 0x0036EFE0
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

		// Token: 0x0400BB92 RID: 48018
		private Table __p;
	}
}
