using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004067 RID: 16487
	public struct IRangeLimitingCondition : IFlatbufferObject
	{
		// Token: 0x1700742A RID: 29738
		// (get) Token: 0x06017ED3 RID: 98003 RVA: 0x00373F3C File Offset: 0x0037213C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017ED4 RID: 98004 RVA: 0x00373F49 File Offset: 0x00372149
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017ED5 RID: 98005 RVA: 0x00373F50 File Offset: 0x00372150
		public static IRangeLimitingCondition GetRootAsIRangeLimitingCondition(ByteBuffer _bb)
		{
			return IRangeLimitingCondition.GetRootAsIRangeLimitingCondition(_bb, default(IRangeLimitingCondition));
		}

		// Token: 0x06017ED6 RID: 98006 RVA: 0x00373F6C File Offset: 0x0037216C
		public static IRangeLimitingCondition GetRootAsIRangeLimitingCondition(ByteBuffer _bb, IRangeLimitingCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017ED7 RID: 98007 RVA: 0x00373F89 File Offset: 0x00372189
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017ED8 RID: 98008 RVA: 0x00373F98 File Offset: 0x00372198
		public IRangeLimitingCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700742B RID: 29739
		// (get) Token: 0x06017ED9 RID: 98009 RVA: 0x00373FA8 File Offset: 0x003721A8
		public ERangeLimitingPriority Priority
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERangeLimitingPriority.Low;
				}
				return (ERangeLimitingPriority)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700742C RID: 29740
		// (get) Token: 0x06017EDA RID: 98010 RVA: 0x00373FE4 File Offset: 0x003721E4
		public IVectorInfo? Point
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700742D RID: 29741
		// (get) Token: 0x06017EDB RID: 98011 RVA: 0x00374044 File Offset: 0x00372244
		public int Range
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

		// Token: 0x1700742E RID: 29742
		// (get) Token: 0x06017EDC RID: 98012 RVA: 0x00374080 File Offset: 0x00372280
		public string RangeEffectPath
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

		// Token: 0x06017EDD RID: 98013 RVA: 0x003740B8 File Offset: 0x003722B8
		public Span<byte> GetRangeEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06017EDE RID: 98014 RVA: 0x003740C8 File Offset: 0x003722C8
		public byte[] GetRangeEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700742F RID: 29743
		// (get) Token: 0x06017EDF RID: 98015 RVA: 0x003740D8 File Offset: 0x003722D8
		public float OverRangeCountdown
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007430 RID: 29744
		// (get) Token: 0x06017EE0 RID: 98016 RVA: 0x0037411C File Offset: 0x0037231C
		public int WarningRange
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007431 RID: 29745
		// (get) Token: 0x06017EE1 RID: 98017 RVA: 0x0037415C File Offset: 0x0037235C
		public bool RequiresSecondConfirmation
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06017EE2 RID: 98018 RVA: 0x0037419C File Offset: 0x0037239C
		public int RangeEntities(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007432 RID: 29746
		// (get) Token: 0x06017EE3 RID: 98019 RVA: 0x003741DC File Offset: 0x003723DC
		public int RangeEntitiesLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06017EE4 RID: 98020 RVA: 0x00374208 File Offset: 0x00372408
		public Span<int> GetRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06017EE5 RID: 98021 RVA: 0x00374218 File Offset: 0x00372418
		public int[] GetRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(18);
		}

		// Token: 0x06017EE6 RID: 98022 RVA: 0x00374228 File Offset: 0x00372428
		public int WarningRangeEntities(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007433 RID: 29747
		// (get) Token: 0x06017EE7 RID: 98023 RVA: 0x00374268 File Offset: 0x00372468
		public int WarningRangeEntitiesLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06017EE8 RID: 98024 RVA: 0x00374294 File Offset: 0x00372494
		public Span<int> GetWarningRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x06017EE9 RID: 98025 RVA: 0x003742A4 File Offset: 0x003724A4
		public int[] GetWarningRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(20);
		}

		// Token: 0x17007434 RID: 29748
		// (get) Token: 0x06017EEA RID: 98026 RVA: 0x003742B4 File Offset: 0x003724B4
		public IWarningPreform? WarningPreform
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return new IWarningPreform?(default(IWarningPreform).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06017EEB RID: 98027 RVA: 0x00374314 File Offset: 0x00372514
		public int AcceptableDungeonIds(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007435 RID: 29749
		// (get) Token: 0x06017EEC RID: 98028 RVA: 0x00374354 File Offset: 0x00372554
		public int AcceptableDungeonIdsLength
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

		// Token: 0x06017EED RID: 98029 RVA: 0x00374380 File Offset: 0x00372580
		public Span<int> GetAcceptableDungeonIdsBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x06017EEE RID: 98030 RVA: 0x00374390 File Offset: 0x00372590
		public int[] GetAcceptableDungeonIdsArray()
		{
			return this.__p.__vector_as_array<int>(24);
		}

		// Token: 0x17007436 RID: 29750
		// (get) Token: 0x06017EEF RID: 98031 RVA: 0x003743A0 File Offset: 0x003725A0
		public bool OnlyFailOnceOutsideDungeon
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007437 RID: 29751
		// (get) Token: 0x06017EF0 RID: 98032 RVA: 0x003743E0 File Offset: 0x003725E0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017EF1 RID: 98033 RVA: 0x00374420 File Offset: 0x00372620
		public static Offset<IRangeLimitingCondition> CreateIRangeLimitingCondition(FlatBufferBuilder builder, ERangeLimitingPriority Priority = ERangeLimitingPriority.Low, Offset<IVectorInfo> PointOffset = default(Offset<IVectorInfo>), int Range = 0, StringOffset RangeEffectPathOffset = default(StringOffset), float OverRangeCountdown = 0f, int WarningRange = 0, bool RequiresSecondConfirmation = false, VectorOffset RangeEntitiesOffset = default(VectorOffset), VectorOffset WarningRangeEntitiesOffset = default(VectorOffset), Offset<IWarningPreform> WarningPreformOffset = default(Offset<IWarningPreform>), VectorOffset AcceptableDungeonIdsOffset = default(VectorOffset), bool OnlyFailOnceOutsideDungeon = false, byte NullMask = 0)
		{
			builder.StartTable(13);
			IRangeLimitingCondition.AddAcceptableDungeonIds(builder, AcceptableDungeonIdsOffset);
			IRangeLimitingCondition.AddWarningPreform(builder, WarningPreformOffset);
			IRangeLimitingCondition.AddWarningRangeEntities(builder, WarningRangeEntitiesOffset);
			IRangeLimitingCondition.AddRangeEntities(builder, RangeEntitiesOffset);
			IRangeLimitingCondition.AddWarningRange(builder, WarningRange);
			IRangeLimitingCondition.AddOverRangeCountdown(builder, OverRangeCountdown);
			IRangeLimitingCondition.AddRangeEffectPath(builder, RangeEffectPathOffset);
			IRangeLimitingCondition.AddRange(builder, Range);
			IRangeLimitingCondition.AddPoint(builder, PointOffset);
			IRangeLimitingCondition.AddNullMask(builder, NullMask);
			IRangeLimitingCondition.AddOnlyFailOnceOutsideDungeon(builder, OnlyFailOnceOutsideDungeon);
			IRangeLimitingCondition.AddRequiresSecondConfirmation(builder, RequiresSecondConfirmation);
			IRangeLimitingCondition.AddPriority(builder, Priority);
			return IRangeLimitingCondition.EndIRangeLimitingCondition(builder);
		}

		// Token: 0x06017EF2 RID: 98034 RVA: 0x003744A0 File Offset: 0x003726A0
		public static void StartIRangeLimitingCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(13);
		}

		// Token: 0x06017EF3 RID: 98035 RVA: 0x003744AA File Offset: 0x003726AA
		public static void AddPriority(FlatBufferBuilder builder, ERangeLimitingPriority priority)
		{
			builder.AddByte(0, (byte)priority, 0);
		}

		// Token: 0x06017EF4 RID: 98036 RVA: 0x003744B5 File Offset: 0x003726B5
		public static void AddPoint(FlatBufferBuilder builder, Offset<IVectorInfo> pointOffset)
		{
			builder.AddOffset(1, pointOffset.Value, 0);
		}

		// Token: 0x06017EF5 RID: 98037 RVA: 0x003744C5 File Offset: 0x003726C5
		public static void AddRange(FlatBufferBuilder builder, int range)
		{
			builder.AddInt(2, range, 0);
		}

		// Token: 0x06017EF6 RID: 98038 RVA: 0x003744D0 File Offset: 0x003726D0
		public static void AddRangeEffectPath(FlatBufferBuilder builder, StringOffset rangeEffectPathOffset)
		{
			builder.AddOffset(3, rangeEffectPathOffset.Value, 0);
		}

		// Token: 0x06017EF7 RID: 98039 RVA: 0x003744E0 File Offset: 0x003726E0
		public static void AddOverRangeCountdown(FlatBufferBuilder builder, float overRangeCountdown)
		{
			builder.AddFloat(4, overRangeCountdown, 0.0);
		}

		// Token: 0x06017EF8 RID: 98040 RVA: 0x003744F3 File Offset: 0x003726F3
		public static void AddWarningRange(FlatBufferBuilder builder, int warningRange)
		{
			builder.AddInt(5, warningRange, 0);
		}

		// Token: 0x06017EF9 RID: 98041 RVA: 0x003744FE File Offset: 0x003726FE
		public static void AddRequiresSecondConfirmation(FlatBufferBuilder builder, bool requiresSecondConfirmation)
		{
			builder.AddBool(6, requiresSecondConfirmation, false);
		}

		// Token: 0x06017EFA RID: 98042 RVA: 0x00374509 File Offset: 0x00372709
		public static void AddRangeEntities(FlatBufferBuilder builder, VectorOffset rangeEntitiesOffset)
		{
			builder.AddOffset(7, rangeEntitiesOffset.Value, 0);
		}

		// Token: 0x06017EFB RID: 98043 RVA: 0x0037451C File Offset: 0x0037271C
		public static VectorOffset CreateRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017EFC RID: 98044 RVA: 0x00374553 File Offset: 0x00372753
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017EFD RID: 98045 RVA: 0x0037456D File Offset: 0x0037276D
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017EFE RID: 98046 RVA: 0x0037458B File Offset: 0x0037278B
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017EFF RID: 98047 RVA: 0x003745A4 File Offset: 0x003727A4
		public static void StartRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017F00 RID: 98048 RVA: 0x003745AF File Offset: 0x003727AF
		public static void AddWarningRangeEntities(FlatBufferBuilder builder, VectorOffset warningRangeEntitiesOffset)
		{
			builder.AddOffset(8, warningRangeEntitiesOffset.Value, 0);
		}

		// Token: 0x06017F01 RID: 98049 RVA: 0x003745C0 File Offset: 0x003727C0
		public static VectorOffset CreateWarningRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017F02 RID: 98050 RVA: 0x003745F7 File Offset: 0x003727F7
		public static VectorOffset CreateWarningRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017F03 RID: 98051 RVA: 0x00374611 File Offset: 0x00372811
		public static VectorOffset CreateWarningRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017F04 RID: 98052 RVA: 0x0037462F File Offset: 0x0037282F
		public static VectorOffset CreateWarningRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017F05 RID: 98053 RVA: 0x00374648 File Offset: 0x00372848
		public static void StartWarningRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017F06 RID: 98054 RVA: 0x00374653 File Offset: 0x00372853
		public static void AddWarningPreform(FlatBufferBuilder builder, Offset<IWarningPreform> warningPreformOffset)
		{
			builder.AddOffset(9, warningPreformOffset.Value, 0);
		}

		// Token: 0x06017F07 RID: 98055 RVA: 0x00374664 File Offset: 0x00372864
		public static void AddAcceptableDungeonIds(FlatBufferBuilder builder, VectorOffset acceptableDungeonIdsOffset)
		{
			builder.AddOffset(10, acceptableDungeonIdsOffset.Value, 0);
		}

		// Token: 0x06017F08 RID: 98056 RVA: 0x00374678 File Offset: 0x00372878
		public static VectorOffset CreateAcceptableDungeonIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017F09 RID: 98057 RVA: 0x003746AF File Offset: 0x003728AF
		public static VectorOffset CreateAcceptableDungeonIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017F0A RID: 98058 RVA: 0x003746C9 File Offset: 0x003728C9
		public static VectorOffset CreateAcceptableDungeonIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017F0B RID: 98059 RVA: 0x003746E7 File Offset: 0x003728E7
		public static VectorOffset CreateAcceptableDungeonIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017F0C RID: 98060 RVA: 0x00374700 File Offset: 0x00372900
		public static void StartAcceptableDungeonIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017F0D RID: 98061 RVA: 0x0037470B File Offset: 0x0037290B
		public static void AddOnlyFailOnceOutsideDungeon(FlatBufferBuilder builder, bool onlyFailOnceOutsideDungeon)
		{
			builder.AddBool(11, onlyFailOnceOutsideDungeon, false);
		}

		// Token: 0x06017F0E RID: 98062 RVA: 0x00374717 File Offset: 0x00372917
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(12, nullMask, 0);
		}

		// Token: 0x06017F0F RID: 98063 RVA: 0x00374723 File Offset: 0x00372923
		public static Offset<IRangeLimitingCondition> EndIRangeLimitingCondition(FlatBufferBuilder builder)
		{
			return new Offset<IRangeLimitingCondition>(builder.EndTable());
		}

		// Token: 0x06017F10 RID: 98064 RVA: 0x00374730 File Offset: 0x00372930
		public IRangeLimitingConditionT UnPack()
		{
			IRangeLimitingConditionT rangeLimitingConditionT = new IRangeLimitingConditionT();
			this.UnPackTo(rangeLimitingConditionT);
			return rangeLimitingConditionT;
		}

		// Token: 0x06017F11 RID: 98065 RVA: 0x0037474C File Offset: 0x0037294C
		public void UnPackTo(IRangeLimitingConditionT _o)
		{
			_o.Priority = this.Priority;
			_o.Point = ((this.Point != null) ? this.Point.Value.UnPack() : null);
			_o.Range = this.Range;
			_o.RangeEffectPath = this.RangeEffectPath;
			_o.OverRangeCountdown = this.OverRangeCountdown;
			_o.WarningRange = this.WarningRange;
			_o.RequiresSecondConfirmation = this.RequiresSecondConfirmation;
			_o.RangeEntities = new List<int>();
			for (int i = 0; i < this.RangeEntitiesLength; i++)
			{
				_o.RangeEntities.Add(this.RangeEntities(i));
			}
			_o.WarningRangeEntities = new List<int>();
			for (int j = 0; j < this.WarningRangeEntitiesLength; j++)
			{
				_o.WarningRangeEntities.Add(this.WarningRangeEntities(j));
			}
			_o.WarningPreform = ((this.WarningPreform != null) ? this.WarningPreform.Value.UnPack() : null);
			_o.AcceptableDungeonIds = new List<int>();
			for (int k = 0; k < this.AcceptableDungeonIdsLength; k++)
			{
				_o.AcceptableDungeonIds.Add(this.AcceptableDungeonIds(k));
			}
			_o.OnlyFailOnceOutsideDungeon = this.OnlyFailOnceOutsideDungeon;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06017F12 RID: 98066 RVA: 0x003748AC File Offset: 0x00372AAC
		public static Offset<IRangeLimitingCondition> Pack(FlatBufferBuilder builder, IRangeLimitingConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRangeLimitingCondition>);
			}
			Offset<IVectorInfo> pointOffset = (_o.Point == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Point);
			StringOffset rangeEffectPathOffset = (_o.RangeEffectPath == null) ? default(StringOffset) : builder.CreateString(_o.RangeEffectPath);
			VectorOffset rangeEntitiesOffset = default(VectorOffset);
			if (_o.RangeEntities != null)
			{
				int[] data = _o.RangeEntities.ToArray();
				rangeEntitiesOffset = IRangeLimitingCondition.CreateRangeEntitiesVector(builder, data);
			}
			VectorOffset warningRangeEntitiesOffset = default(VectorOffset);
			if (_o.WarningRangeEntities != null)
			{
				int[] data2 = _o.WarningRangeEntities.ToArray();
				warningRangeEntitiesOffset = IRangeLimitingCondition.CreateWarningRangeEntitiesVector(builder, data2);
			}
			Offset<IWarningPreform> warningPreformOffset = (_o.WarningPreform == null) ? default(Offset<IWarningPreform>) : IWarningPreform.Pack(builder, _o.WarningPreform);
			VectorOffset acceptableDungeonIdsOffset = default(VectorOffset);
			if (_o.AcceptableDungeonIds != null)
			{
				int[] data3 = _o.AcceptableDungeonIds.ToArray();
				acceptableDungeonIdsOffset = IRangeLimitingCondition.CreateAcceptableDungeonIdsVector(builder, data3);
			}
			return IRangeLimitingCondition.CreateIRangeLimitingCondition(builder, _o.Priority, pointOffset, _o.Range, rangeEffectPathOffset, _o.OverRangeCountdown, _o.WarningRange, _o.RequiresSecondConfirmation, rangeEntitiesOffset, warningRangeEntitiesOffset, warningPreformOffset, acceptableDungeonIdsOffset, _o.OnlyFailOnceOutsideDungeon, _o.NullMask);
		}

		// Token: 0x0400BBCC RID: 48076
		private Table __p;
	}
}
