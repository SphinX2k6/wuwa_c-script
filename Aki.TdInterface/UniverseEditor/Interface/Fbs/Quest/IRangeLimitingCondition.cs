using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044A8 RID: 17576
	public struct IRangeLimitingCondition : IFlatbufferObject
	{
		// Token: 0x17007A2C RID: 31276
		// (get) Token: 0x0601956C RID: 103788 RVA: 0x0039DD30 File Offset: 0x0039BF30
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601956D RID: 103789 RVA: 0x0039DD3D File Offset: 0x0039BF3D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601956E RID: 103790 RVA: 0x0039DD44 File Offset: 0x0039BF44
		public static IRangeLimitingCondition GetRootAsIRangeLimitingCondition(ByteBuffer _bb)
		{
			return IRangeLimitingCondition.GetRootAsIRangeLimitingCondition(_bb, default(IRangeLimitingCondition));
		}

		// Token: 0x0601956F RID: 103791 RVA: 0x0039DD60 File Offset: 0x0039BF60
		public static IRangeLimitingCondition GetRootAsIRangeLimitingCondition(ByteBuffer _bb, IRangeLimitingCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019570 RID: 103792 RVA: 0x0039DD7D File Offset: 0x0039BF7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019571 RID: 103793 RVA: 0x0039DD8C File Offset: 0x0039BF8C
		public IRangeLimitingCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007A2D RID: 31277
		// (get) Token: 0x06019572 RID: 103794 RVA: 0x0039DD9C File Offset: 0x0039BF9C
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

		// Token: 0x17007A2E RID: 31278
		// (get) Token: 0x06019573 RID: 103795 RVA: 0x0039DDD8 File Offset: 0x0039BFD8
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

		// Token: 0x17007A2F RID: 31279
		// (get) Token: 0x06019574 RID: 103796 RVA: 0x0039DE38 File Offset: 0x0039C038
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

		// Token: 0x17007A30 RID: 31280
		// (get) Token: 0x06019575 RID: 103797 RVA: 0x0039DE74 File Offset: 0x0039C074
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

		// Token: 0x06019576 RID: 103798 RVA: 0x0039DEAC File Offset: 0x0039C0AC
		public Span<byte> GetRangeEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06019577 RID: 103799 RVA: 0x0039DEBC File Offset: 0x0039C0BC
		public byte[] GetRangeEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x17007A31 RID: 31281
		// (get) Token: 0x06019578 RID: 103800 RVA: 0x0039DECC File Offset: 0x0039C0CC
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

		// Token: 0x17007A32 RID: 31282
		// (get) Token: 0x06019579 RID: 103801 RVA: 0x0039DF10 File Offset: 0x0039C110
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

		// Token: 0x17007A33 RID: 31283
		// (get) Token: 0x0601957A RID: 103802 RVA: 0x0039DF50 File Offset: 0x0039C150
		public bool RequiresSecondConfirmation
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601957B RID: 103803 RVA: 0x0039DF90 File Offset: 0x0039C190
		public int RangeEntities(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007A34 RID: 31284
		// (get) Token: 0x0601957C RID: 103804 RVA: 0x0039DFD0 File Offset: 0x0039C1D0
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

		// Token: 0x0601957D RID: 103805 RVA: 0x0039DFFC File Offset: 0x0039C1FC
		public Span<int> GetRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0601957E RID: 103806 RVA: 0x0039E00C File Offset: 0x0039C20C
		public int[] GetRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(18);
		}

		// Token: 0x0601957F RID: 103807 RVA: 0x0039E01C File Offset: 0x0039C21C
		public int WarningRangeEntities(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007A35 RID: 31285
		// (get) Token: 0x06019580 RID: 103808 RVA: 0x0039E05C File Offset: 0x0039C25C
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

		// Token: 0x06019581 RID: 103809 RVA: 0x0039E088 File Offset: 0x0039C288
		public Span<int> GetWarningRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x06019582 RID: 103810 RVA: 0x0039E098 File Offset: 0x0039C298
		public int[] GetWarningRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(20);
		}

		// Token: 0x17007A36 RID: 31286
		// (get) Token: 0x06019583 RID: 103811 RVA: 0x0039E0A8 File Offset: 0x0039C2A8
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

		// Token: 0x06019584 RID: 103812 RVA: 0x0039E108 File Offset: 0x0039C308
		public int AcceptableDungeonIds(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007A37 RID: 31287
		// (get) Token: 0x06019585 RID: 103813 RVA: 0x0039E148 File Offset: 0x0039C348
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

		// Token: 0x06019586 RID: 103814 RVA: 0x0039E174 File Offset: 0x0039C374
		public Span<int> GetAcceptableDungeonIdsBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x06019587 RID: 103815 RVA: 0x0039E184 File Offset: 0x0039C384
		public int[] GetAcceptableDungeonIdsArray()
		{
			return this.__p.__vector_as_array<int>(24);
		}

		// Token: 0x17007A38 RID: 31288
		// (get) Token: 0x06019588 RID: 103816 RVA: 0x0039E194 File Offset: 0x0039C394
		public bool OnlyFailOnceOutsideDungeon
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007A39 RID: 31289
		// (get) Token: 0x06019589 RID: 103817 RVA: 0x0039E1D4 File Offset: 0x0039C3D4
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

		// Token: 0x0601958A RID: 103818 RVA: 0x0039E214 File Offset: 0x0039C414
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

		// Token: 0x0601958B RID: 103819 RVA: 0x0039E294 File Offset: 0x0039C494
		public static void StartIRangeLimitingCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(13);
		}

		// Token: 0x0601958C RID: 103820 RVA: 0x0039E29E File Offset: 0x0039C49E
		public static void AddPriority(FlatBufferBuilder builder, ERangeLimitingPriority priority)
		{
			builder.AddByte(0, (byte)priority, 0);
		}

		// Token: 0x0601958D RID: 103821 RVA: 0x0039E2A9 File Offset: 0x0039C4A9
		public static void AddPoint(FlatBufferBuilder builder, Offset<IVectorInfo> pointOffset)
		{
			builder.AddOffset(1, pointOffset.Value, 0);
		}

		// Token: 0x0601958E RID: 103822 RVA: 0x0039E2B9 File Offset: 0x0039C4B9
		public static void AddRange(FlatBufferBuilder builder, int range)
		{
			builder.AddInt(2, range, 0);
		}

		// Token: 0x0601958F RID: 103823 RVA: 0x0039E2C4 File Offset: 0x0039C4C4
		public static void AddRangeEffectPath(FlatBufferBuilder builder, StringOffset rangeEffectPathOffset)
		{
			builder.AddOffset(3, rangeEffectPathOffset.Value, 0);
		}

		// Token: 0x06019590 RID: 103824 RVA: 0x0039E2D4 File Offset: 0x0039C4D4
		public static void AddOverRangeCountdown(FlatBufferBuilder builder, float overRangeCountdown)
		{
			builder.AddFloat(4, overRangeCountdown, 0.0);
		}

		// Token: 0x06019591 RID: 103825 RVA: 0x0039E2E7 File Offset: 0x0039C4E7
		public static void AddWarningRange(FlatBufferBuilder builder, int warningRange)
		{
			builder.AddInt(5, warningRange, 0);
		}

		// Token: 0x06019592 RID: 103826 RVA: 0x0039E2F2 File Offset: 0x0039C4F2
		public static void AddRequiresSecondConfirmation(FlatBufferBuilder builder, bool requiresSecondConfirmation)
		{
			builder.AddBool(6, requiresSecondConfirmation, false);
		}

		// Token: 0x06019593 RID: 103827 RVA: 0x0039E2FD File Offset: 0x0039C4FD
		public static void AddRangeEntities(FlatBufferBuilder builder, VectorOffset rangeEntitiesOffset)
		{
			builder.AddOffset(7, rangeEntitiesOffset.Value, 0);
		}

		// Token: 0x06019594 RID: 103828 RVA: 0x0039E310 File Offset: 0x0039C510
		public static VectorOffset CreateRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019595 RID: 103829 RVA: 0x0039E347 File Offset: 0x0039C547
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019596 RID: 103830 RVA: 0x0039E361 File Offset: 0x0039C561
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019597 RID: 103831 RVA: 0x0039E37F File Offset: 0x0039C57F
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019598 RID: 103832 RVA: 0x0039E398 File Offset: 0x0039C598
		public static void StartRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019599 RID: 103833 RVA: 0x0039E3A3 File Offset: 0x0039C5A3
		public static void AddWarningRangeEntities(FlatBufferBuilder builder, VectorOffset warningRangeEntitiesOffset)
		{
			builder.AddOffset(8, warningRangeEntitiesOffset.Value, 0);
		}

		// Token: 0x0601959A RID: 103834 RVA: 0x0039E3B4 File Offset: 0x0039C5B4
		public static VectorOffset CreateWarningRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601959B RID: 103835 RVA: 0x0039E3EB File Offset: 0x0039C5EB
		public static VectorOffset CreateWarningRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601959C RID: 103836 RVA: 0x0039E405 File Offset: 0x0039C605
		public static VectorOffset CreateWarningRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601959D RID: 103837 RVA: 0x0039E423 File Offset: 0x0039C623
		public static VectorOffset CreateWarningRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601959E RID: 103838 RVA: 0x0039E43C File Offset: 0x0039C63C
		public static void StartWarningRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601959F RID: 103839 RVA: 0x0039E447 File Offset: 0x0039C647
		public static void AddWarningPreform(FlatBufferBuilder builder, Offset<IWarningPreform> warningPreformOffset)
		{
			builder.AddOffset(9, warningPreformOffset.Value, 0);
		}

		// Token: 0x060195A0 RID: 103840 RVA: 0x0039E458 File Offset: 0x0039C658
		public static void AddAcceptableDungeonIds(FlatBufferBuilder builder, VectorOffset acceptableDungeonIdsOffset)
		{
			builder.AddOffset(10, acceptableDungeonIdsOffset.Value, 0);
		}

		// Token: 0x060195A1 RID: 103841 RVA: 0x0039E46C File Offset: 0x0039C66C
		public static VectorOffset CreateAcceptableDungeonIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060195A2 RID: 103842 RVA: 0x0039E4A3 File Offset: 0x0039C6A3
		public static VectorOffset CreateAcceptableDungeonIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060195A3 RID: 103843 RVA: 0x0039E4BD File Offset: 0x0039C6BD
		public static VectorOffset CreateAcceptableDungeonIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060195A4 RID: 103844 RVA: 0x0039E4DB File Offset: 0x0039C6DB
		public static VectorOffset CreateAcceptableDungeonIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060195A5 RID: 103845 RVA: 0x0039E4F4 File Offset: 0x0039C6F4
		public static void StartAcceptableDungeonIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060195A6 RID: 103846 RVA: 0x0039E4FF File Offset: 0x0039C6FF
		public static void AddOnlyFailOnceOutsideDungeon(FlatBufferBuilder builder, bool onlyFailOnceOutsideDungeon)
		{
			builder.AddBool(11, onlyFailOnceOutsideDungeon, false);
		}

		// Token: 0x060195A7 RID: 103847 RVA: 0x0039E50B File Offset: 0x0039C70B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(12, nullMask, 0);
		}

		// Token: 0x060195A8 RID: 103848 RVA: 0x0039E517 File Offset: 0x0039C717
		public static Offset<IRangeLimitingCondition> EndIRangeLimitingCondition(FlatBufferBuilder builder)
		{
			return new Offset<IRangeLimitingCondition>(builder.EndTable());
		}

		// Token: 0x060195A9 RID: 103849 RVA: 0x0039E524 File Offset: 0x0039C724
		public IRangeLimitingConditionT UnPack()
		{
			IRangeLimitingConditionT rangeLimitingConditionT = new IRangeLimitingConditionT();
			this.UnPackTo(rangeLimitingConditionT);
			return rangeLimitingConditionT;
		}

		// Token: 0x060195AA RID: 103850 RVA: 0x0039E540 File Offset: 0x0039C740
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

		// Token: 0x060195AB RID: 103851 RVA: 0x0039E6A0 File Offset: 0x0039C8A0
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

		// Token: 0x0400C5B3 RID: 50611
		private Table __p;
	}
}
