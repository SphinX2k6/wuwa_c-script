using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FC2 RID: 28610
	public struct IHideWorldEntityAndLevelPlayGroup : IFlatbufferObject
	{
		// Token: 0x1700D18E RID: 53646
		// (get) Token: 0x060318C8 RID: 202952 RVA: 0x006B6FE4 File Offset: 0x006B51E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060318C9 RID: 202953 RVA: 0x006B6FF1 File Offset: 0x006B51F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060318CA RID: 202954 RVA: 0x006B6FF8 File Offset: 0x006B51F8
		public static IHideWorldEntityAndLevelPlayGroup GetRootAsIHideWorldEntityAndLevelPlayGroup(ByteBuffer _bb)
		{
			return IHideWorldEntityAndLevelPlayGroup.GetRootAsIHideWorldEntityAndLevelPlayGroup(_bb, default(IHideWorldEntityAndLevelPlayGroup));
		}

		// Token: 0x060318CB RID: 202955 RVA: 0x006B7014 File Offset: 0x006B5214
		public static IHideWorldEntityAndLevelPlayGroup GetRootAsIHideWorldEntityAndLevelPlayGroup(ByteBuffer _bb, IHideWorldEntityAndLevelPlayGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060318CC RID: 202956 RVA: 0x006B7031 File Offset: 0x006B5231
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060318CD RID: 202957 RVA: 0x006B7040 File Offset: 0x006B5240
		public IHideWorldEntityAndLevelPlayGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D18F RID: 53647
		// (get) Token: 0x060318CE RID: 202958 RVA: 0x006B7050 File Offset: 0x006B5250
		public EHideType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHideType.WorldMonsterAndMonsterTreasure;
				}
				return (EHideType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060318CF RID: 202959 RVA: 0x006B708C File Offset: 0x006B528C
		public int HideRangeEntities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D190 RID: 53648
		// (get) Token: 0x060318D0 RID: 202960 RVA: 0x006B70CC File Offset: 0x006B52CC
		public int HideRangeEntitiesLength
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

		// Token: 0x060318D1 RID: 202961 RVA: 0x006B70F7 File Offset: 0x006B52F7
		public Span<int> GetHideRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060318D2 RID: 202962 RVA: 0x006B7106 File Offset: 0x006B5306
		public int[] GetHideRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x060318D3 RID: 202963 RVA: 0x006B7114 File Offset: 0x006B5314
		public int ExcludeEntities(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D191 RID: 53649
		// (get) Token: 0x060318D4 RID: 202964 RVA: 0x006B7154 File Offset: 0x006B5354
		public int ExcludeEntitiesLength
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

		// Token: 0x060318D5 RID: 202965 RVA: 0x006B717F File Offset: 0x006B537F
		public Span<int> GetExcludeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x060318D6 RID: 202966 RVA: 0x006B718E File Offset: 0x006B538E
		public int[] GetExcludeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x060318D7 RID: 202967 RVA: 0x006B719C File Offset: 0x006B539C
		public int ExcludeLevelPlays(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D192 RID: 53650
		// (get) Token: 0x060318D8 RID: 202968 RVA: 0x006B71DC File Offset: 0x006B53DC
		public int ExcludeLevelPlaysLength
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

		// Token: 0x060318D9 RID: 202969 RVA: 0x006B7208 File Offset: 0x006B5408
		public Span<int> GetExcludeLevelPlaysBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x060318DA RID: 202970 RVA: 0x006B7218 File Offset: 0x006B5418
		public int[] GetExcludeLevelPlaysArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x060318DB RID: 202971 RVA: 0x006B7228 File Offset: 0x006B5428
		public int AppendEntities(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D193 RID: 53651
		// (get) Token: 0x060318DC RID: 202972 RVA: 0x006B7268 File Offset: 0x006B5468
		public int AppendEntitiesLength
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

		// Token: 0x060318DD RID: 202973 RVA: 0x006B7294 File Offset: 0x006B5494
		public Span<int> GetAppendEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x060318DE RID: 202974 RVA: 0x006B72A4 File Offset: 0x006B54A4
		public int[] GetAppendEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(12);
		}

		// Token: 0x060318DF RID: 202975 RVA: 0x006B72B4 File Offset: 0x006B54B4
		public int AppendLevelPlays(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D194 RID: 53652
		// (get) Token: 0x060318E0 RID: 202976 RVA: 0x006B72F4 File Offset: 0x006B54F4
		public int AppendLevelPlaysLength
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

		// Token: 0x060318E1 RID: 202977 RVA: 0x006B7320 File Offset: 0x006B5520
		public Span<int> GetAppendLevelPlaysBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x060318E2 RID: 202978 RVA: 0x006B7330 File Offset: 0x006B5530
		public int[] GetAppendLevelPlaysArray()
		{
			return this.__p.__vector_as_array<int>(14);
		}

		// Token: 0x1700D195 RID: 53653
		// (get) Token: 0x060318E3 RID: 202979 RVA: 0x006B7340 File Offset: 0x006B5540
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

		// Token: 0x060318E4 RID: 202980 RVA: 0x006B7380 File Offset: 0x006B5580
		public static Offset<IHideWorldEntityAndLevelPlayGroup> CreateIHideWorldEntityAndLevelPlayGroup(FlatBufferBuilder builder, EHideType Type = EHideType.WorldMonsterAndMonsterTreasure, VectorOffset HideRangeEntitiesOffset = default(VectorOffset), VectorOffset ExcludeEntitiesOffset = default(VectorOffset), VectorOffset ExcludeLevelPlaysOffset = default(VectorOffset), VectorOffset AppendEntitiesOffset = default(VectorOffset), VectorOffset AppendLevelPlaysOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(7);
			IHideWorldEntityAndLevelPlayGroup.AddAppendLevelPlays(builder, AppendLevelPlaysOffset);
			IHideWorldEntityAndLevelPlayGroup.AddAppendEntities(builder, AppendEntitiesOffset);
			IHideWorldEntityAndLevelPlayGroup.AddExcludeLevelPlays(builder, ExcludeLevelPlaysOffset);
			IHideWorldEntityAndLevelPlayGroup.AddExcludeEntities(builder, ExcludeEntitiesOffset);
			IHideWorldEntityAndLevelPlayGroup.AddHideRangeEntities(builder, HideRangeEntitiesOffset);
			IHideWorldEntityAndLevelPlayGroup.AddNullMask(builder, NullMask);
			IHideWorldEntityAndLevelPlayGroup.AddType(builder, Type);
			return IHideWorldEntityAndLevelPlayGroup.EndIHideWorldEntityAndLevelPlayGroup(builder);
		}

		// Token: 0x060318E5 RID: 202981 RVA: 0x006B73CF File Offset: 0x006B55CF
		public static void StartIHideWorldEntityAndLevelPlayGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060318E6 RID: 202982 RVA: 0x006B73D8 File Offset: 0x006B55D8
		public static void AddType(FlatBufferBuilder builder, EHideType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060318E7 RID: 202983 RVA: 0x006B73E3 File Offset: 0x006B55E3
		public static void AddHideRangeEntities(FlatBufferBuilder builder, VectorOffset hideRangeEntitiesOffset)
		{
			builder.AddOffset(1, hideRangeEntitiesOffset.Value, 0);
		}

		// Token: 0x060318E8 RID: 202984 RVA: 0x006B73F4 File Offset: 0x006B55F4
		public static VectorOffset CreateHideRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060318E9 RID: 202985 RVA: 0x006B742B File Offset: 0x006B562B
		public static VectorOffset CreateHideRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060318EA RID: 202986 RVA: 0x006B7445 File Offset: 0x006B5645
		public static VectorOffset CreateHideRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060318EB RID: 202987 RVA: 0x006B7463 File Offset: 0x006B5663
		public static VectorOffset CreateHideRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060318EC RID: 202988 RVA: 0x006B747C File Offset: 0x006B567C
		public static void StartHideRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060318ED RID: 202989 RVA: 0x006B7487 File Offset: 0x006B5687
		public static void AddExcludeEntities(FlatBufferBuilder builder, VectorOffset excludeEntitiesOffset)
		{
			builder.AddOffset(2, excludeEntitiesOffset.Value, 0);
		}

		// Token: 0x060318EE RID: 202990 RVA: 0x006B7498 File Offset: 0x006B5698
		public static VectorOffset CreateExcludeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060318EF RID: 202991 RVA: 0x006B74CF File Offset: 0x006B56CF
		public static VectorOffset CreateExcludeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060318F0 RID: 202992 RVA: 0x006B74E9 File Offset: 0x006B56E9
		public static VectorOffset CreateExcludeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060318F1 RID: 202993 RVA: 0x006B7507 File Offset: 0x006B5707
		public static VectorOffset CreateExcludeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060318F2 RID: 202994 RVA: 0x006B7520 File Offset: 0x006B5720
		public static void StartExcludeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060318F3 RID: 202995 RVA: 0x006B752B File Offset: 0x006B572B
		public static void AddExcludeLevelPlays(FlatBufferBuilder builder, VectorOffset excludeLevelPlaysOffset)
		{
			builder.AddOffset(3, excludeLevelPlaysOffset.Value, 0);
		}

		// Token: 0x060318F4 RID: 202996 RVA: 0x006B753C File Offset: 0x006B573C
		public static VectorOffset CreateExcludeLevelPlaysVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060318F5 RID: 202997 RVA: 0x006B7573 File Offset: 0x006B5773
		public static VectorOffset CreateExcludeLevelPlaysVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060318F6 RID: 202998 RVA: 0x006B758D File Offset: 0x006B578D
		public static VectorOffset CreateExcludeLevelPlaysVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060318F7 RID: 202999 RVA: 0x006B75AB File Offset: 0x006B57AB
		public static VectorOffset CreateExcludeLevelPlaysVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060318F8 RID: 203000 RVA: 0x006B75C4 File Offset: 0x006B57C4
		public static void StartExcludeLevelPlaysVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060318F9 RID: 203001 RVA: 0x006B75CF File Offset: 0x006B57CF
		public static void AddAppendEntities(FlatBufferBuilder builder, VectorOffset appendEntitiesOffset)
		{
			builder.AddOffset(4, appendEntitiesOffset.Value, 0);
		}

		// Token: 0x060318FA RID: 203002 RVA: 0x006B75E0 File Offset: 0x006B57E0
		public static VectorOffset CreateAppendEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060318FB RID: 203003 RVA: 0x006B7617 File Offset: 0x006B5817
		public static VectorOffset CreateAppendEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060318FC RID: 203004 RVA: 0x006B7631 File Offset: 0x006B5831
		public static VectorOffset CreateAppendEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060318FD RID: 203005 RVA: 0x006B764F File Offset: 0x006B584F
		public static VectorOffset CreateAppendEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060318FE RID: 203006 RVA: 0x006B7668 File Offset: 0x006B5868
		public static void StartAppendEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060318FF RID: 203007 RVA: 0x006B7673 File Offset: 0x006B5873
		public static void AddAppendLevelPlays(FlatBufferBuilder builder, VectorOffset appendLevelPlaysOffset)
		{
			builder.AddOffset(5, appendLevelPlaysOffset.Value, 0);
		}

		// Token: 0x06031900 RID: 203008 RVA: 0x006B7684 File Offset: 0x006B5884
		public static VectorOffset CreateAppendLevelPlaysVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06031901 RID: 203009 RVA: 0x006B76BB File Offset: 0x006B58BB
		public static VectorOffset CreateAppendLevelPlaysVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06031902 RID: 203010 RVA: 0x006B76D5 File Offset: 0x006B58D5
		public static VectorOffset CreateAppendLevelPlaysVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06031903 RID: 203011 RVA: 0x006B76F3 File Offset: 0x006B58F3
		public static VectorOffset CreateAppendLevelPlaysVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031904 RID: 203012 RVA: 0x006B770C File Offset: 0x006B590C
		public static void StartAppendLevelPlaysVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06031905 RID: 203013 RVA: 0x006B7717 File Offset: 0x006B5917
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06031906 RID: 203014 RVA: 0x006B7722 File Offset: 0x006B5922
		public static Offset<IHideWorldEntityAndLevelPlayGroup> EndIHideWorldEntityAndLevelPlayGroup(FlatBufferBuilder builder)
		{
			return new Offset<IHideWorldEntityAndLevelPlayGroup>(builder.EndTable());
		}

		// Token: 0x06031907 RID: 203015 RVA: 0x006B7730 File Offset: 0x006B5930
		public IHideWorldEntityAndLevelPlayGroupT UnPack()
		{
			IHideWorldEntityAndLevelPlayGroupT hideWorldEntityAndLevelPlayGroupT = new IHideWorldEntityAndLevelPlayGroupT();
			this.UnPackTo(hideWorldEntityAndLevelPlayGroupT);
			return hideWorldEntityAndLevelPlayGroupT;
		}

		// Token: 0x06031908 RID: 203016 RVA: 0x006B774C File Offset: 0x006B594C
		public void UnPackTo(IHideWorldEntityAndLevelPlayGroupT _o)
		{
			_o.Type = this.Type;
			_o.HideRangeEntities = new List<int>();
			for (int i = 0; i < this.HideRangeEntitiesLength; i++)
			{
				_o.HideRangeEntities.Add(this.HideRangeEntities(i));
			}
			_o.ExcludeEntities = new List<int>();
			for (int j = 0; j < this.ExcludeEntitiesLength; j++)
			{
				_o.ExcludeEntities.Add(this.ExcludeEntities(j));
			}
			_o.ExcludeLevelPlays = new List<int>();
			for (int k = 0; k < this.ExcludeLevelPlaysLength; k++)
			{
				_o.ExcludeLevelPlays.Add(this.ExcludeLevelPlays(k));
			}
			_o.AppendEntities = new List<int>();
			for (int l = 0; l < this.AppendEntitiesLength; l++)
			{
				_o.AppendEntities.Add(this.AppendEntities(l));
			}
			_o.AppendLevelPlays = new List<int>();
			for (int m = 0; m < this.AppendLevelPlaysLength; m++)
			{
				_o.AppendLevelPlays.Add(this.AppendLevelPlays(m));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06031909 RID: 203017 RVA: 0x006B785C File Offset: 0x006B5A5C
		public static Offset<IHideWorldEntityAndLevelPlayGroup> Pack(FlatBufferBuilder builder, IHideWorldEntityAndLevelPlayGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHideWorldEntityAndLevelPlayGroup>);
			}
			VectorOffset hideRangeEntitiesOffset = default(VectorOffset);
			if (_o.HideRangeEntities != null)
			{
				int[] data = _o.HideRangeEntities.ToArray();
				hideRangeEntitiesOffset = IHideWorldEntityAndLevelPlayGroup.CreateHideRangeEntitiesVector(builder, data);
			}
			VectorOffset excludeEntitiesOffset = default(VectorOffset);
			if (_o.ExcludeEntities != null)
			{
				int[] data2 = _o.ExcludeEntities.ToArray();
				excludeEntitiesOffset = IHideWorldEntityAndLevelPlayGroup.CreateExcludeEntitiesVector(builder, data2);
			}
			VectorOffset excludeLevelPlaysOffset = default(VectorOffset);
			if (_o.ExcludeLevelPlays != null)
			{
				int[] data3 = _o.ExcludeLevelPlays.ToArray();
				excludeLevelPlaysOffset = IHideWorldEntityAndLevelPlayGroup.CreateExcludeLevelPlaysVector(builder, data3);
			}
			VectorOffset appendEntitiesOffset = default(VectorOffset);
			if (_o.AppendEntities != null)
			{
				int[] data4 = _o.AppendEntities.ToArray();
				appendEntitiesOffset = IHideWorldEntityAndLevelPlayGroup.CreateAppendEntitiesVector(builder, data4);
			}
			VectorOffset appendLevelPlaysOffset = default(VectorOffset);
			if (_o.AppendLevelPlays != null)
			{
				int[] data5 = _o.AppendLevelPlays.ToArray();
				appendLevelPlaysOffset = IHideWorldEntityAndLevelPlayGroup.CreateAppendLevelPlaysVector(builder, data5);
			}
			return IHideWorldEntityAndLevelPlayGroup.CreateIHideWorldEntityAndLevelPlayGroup(builder, _o.Type, hideRangeEntitiesOffset, excludeEntitiesOffset, excludeLevelPlaysOffset, appendEntitiesOffset, appendLevelPlaysOffset, _o.NullMask);
		}

		// Token: 0x04011EF4 RID: 73460
		private Table __p;
	}
}
