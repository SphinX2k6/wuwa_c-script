using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CAC RID: 19628
	public struct IRangeSphere : IFlatbufferObject
	{
		// Token: 0x17008E80 RID: 36480
		// (get) Token: 0x0601F22D RID: 127533 RVA: 0x0045943C File Offset: 0x0045763C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F22E RID: 127534 RVA: 0x00459449 File Offset: 0x00457649
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F22F RID: 127535 RVA: 0x00459450 File Offset: 0x00457650
		public static IRangeSphere GetRootAsIRangeSphere(ByteBuffer _bb)
		{
			return IRangeSphere.GetRootAsIRangeSphere(_bb, default(IRangeSphere));
		}

		// Token: 0x0601F230 RID: 127536 RVA: 0x0045946C File Offset: 0x0045766C
		public static IRangeSphere GetRootAsIRangeSphere(ByteBuffer _bb, IRangeSphere obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F231 RID: 127537 RVA: 0x00459489 File Offset: 0x00457689
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F232 RID: 127538 RVA: 0x00459498 File Offset: 0x00457698
		public IRangeSphere __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E81 RID: 36481
		// (get) Token: 0x0601F233 RID: 127539 RVA: 0x004594A8 File Offset: 0x004576A8
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008E82 RID: 36482
		// (get) Token: 0x0601F234 RID: 127540 RVA: 0x004594E4 File Offset: 0x004576E4
		public IVectorInfo? Center
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

		// Token: 0x17008E83 RID: 36483
		// (get) Token: 0x0601F235 RID: 127541 RVA: 0x00459544 File Offset: 0x00457744
		public int Radius
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

		// Token: 0x17008E84 RID: 36484
		// (get) Token: 0x0601F236 RID: 127542 RVA: 0x00459580 File Offset: 0x00457780
		public TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOptionType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TOnlinePlayerConditionTarget.NONE;
				}
				return (TOnlinePlayerConditionTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F237 RID: 127543 RVA: 0x004595C0 File Offset: 0x004577C0
		public TTable? OnlinePlayerConditionTargetOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601F238 RID: 127544 RVA: 0x00459608 File Offset: 0x00457808
		public IOnlinePlayerConditionTargetHost OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetHost()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value;
		}

		// Token: 0x0601F239 RID: 127545 RVA: 0x00459624 File Offset: 0x00457824
		public IOnlinePlayerConditionTargetParticipator OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetParticipator()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value;
		}

		// Token: 0x0601F23A RID: 127546 RVA: 0x00459640 File Offset: 0x00457840
		public int RangeEntities(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008E85 RID: 36485
		// (get) Token: 0x0601F23B RID: 127547 RVA: 0x00459680 File Offset: 0x00457880
		public int RangeEntitiesLength
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

		// Token: 0x0601F23C RID: 127548 RVA: 0x004596AC File Offset: 0x004578AC
		public Span<int> GetRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0601F23D RID: 127549 RVA: 0x004596BC File Offset: 0x004578BC
		public int[] GetRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(14);
		}

		// Token: 0x17008E86 RID: 36486
		// (get) Token: 0x0601F23E RID: 127550 RVA: 0x004596CC File Offset: 0x004578CC
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

		// Token: 0x0601F23F RID: 127551 RVA: 0x0045970C File Offset: 0x0045790C
		public static Offset<IRangeSphere> CreateIRangeSphere(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, Offset<IVectorInfo> CenterOffset = default(Offset<IVectorInfo>), int Radius = 0, TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOption_type = TOnlinePlayerConditionTarget.NONE, int OnlinePlayerConditionTargetOptionOffset = 0, VectorOffset RangeEntitiesOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(7);
			IRangeSphere.AddRangeEntities(builder, RangeEntitiesOffset);
			IRangeSphere.AddOnlinePlayerConditionTargetOption(builder, OnlinePlayerConditionTargetOptionOffset);
			IRangeSphere.AddRadius(builder, Radius);
			IRangeSphere.AddCenter(builder, CenterOffset);
			IRangeSphere.AddNullMask(builder, NullMask);
			IRangeSphere.AddOnlinePlayerConditionTargetOptionType(builder, OnlinePlayerConditionTargetOption_type);
			IRangeSphere.AddType(builder, Type);
			return IRangeSphere.EndIRangeSphere(builder);
		}

		// Token: 0x0601F240 RID: 127552 RVA: 0x0045975B File Offset: 0x0045795B
		public static void StartIRangeSphere(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601F241 RID: 127553 RVA: 0x00459764 File Offset: 0x00457964
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F242 RID: 127554 RVA: 0x0045976F File Offset: 0x0045796F
		public static void AddCenter(FlatBufferBuilder builder, Offset<IVectorInfo> centerOffset)
		{
			builder.AddOffset(1, centerOffset.Value, 0);
		}

		// Token: 0x0601F243 RID: 127555 RVA: 0x0045977F File Offset: 0x0045797F
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(2, radius, 0);
		}

		// Token: 0x0601F244 RID: 127556 RVA: 0x0045978A File Offset: 0x0045798A
		public static void AddOnlinePlayerConditionTargetOptionType(FlatBufferBuilder builder, TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType)
		{
			builder.AddByte(3, (byte)onlinePlayerConditionTargetOptionType, 0);
		}

		// Token: 0x0601F245 RID: 127557 RVA: 0x00459795 File Offset: 0x00457995
		public static void AddOnlinePlayerConditionTargetOption(FlatBufferBuilder builder, int onlinePlayerConditionTargetOptionOffset)
		{
			builder.AddOffset(4, onlinePlayerConditionTargetOptionOffset, 0);
		}

		// Token: 0x0601F246 RID: 127558 RVA: 0x004597A0 File Offset: 0x004579A0
		public static void AddRangeEntities(FlatBufferBuilder builder, VectorOffset rangeEntitiesOffset)
		{
			builder.AddOffset(5, rangeEntitiesOffset.Value, 0);
		}

		// Token: 0x0601F247 RID: 127559 RVA: 0x004597B0 File Offset: 0x004579B0
		public static VectorOffset CreateRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601F248 RID: 127560 RVA: 0x004597E7 File Offset: 0x004579E7
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F249 RID: 127561 RVA: 0x00459801 File Offset: 0x00457A01
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F24A RID: 127562 RVA: 0x0045981F File Offset: 0x00457A1F
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601F24B RID: 127563 RVA: 0x00459838 File Offset: 0x00457A38
		public static void StartRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601F24C RID: 127564 RVA: 0x00459843 File Offset: 0x00457A43
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0601F24D RID: 127565 RVA: 0x0045984E File Offset: 0x00457A4E
		public static Offset<IRangeSphere> EndIRangeSphere(FlatBufferBuilder builder)
		{
			return new Offset<IRangeSphere>(builder.EndTable());
		}

		// Token: 0x0601F24E RID: 127566 RVA: 0x0045985C File Offset: 0x00457A5C
		public IRangeSphereT UnPack()
		{
			IRangeSphereT rangeSphereT = new IRangeSphereT();
			this.UnPackTo(rangeSphereT);
			return rangeSphereT;
		}

		// Token: 0x0601F24F RID: 127567 RVA: 0x00459878 File Offset: 0x00457A78
		public void UnPackTo(IRangeSphereT _o)
		{
			_o.Type = this.Type;
			_o.Center = ((this.Center != null) ? this.Center.Value.UnPack() : null);
			_o.Radius = this.Radius;
			_o.OnlinePlayerConditionTargetOption = new TOnlinePlayerConditionTargetUnion();
			_o.OnlinePlayerConditionTargetOption.Type = this.OnlinePlayerConditionTargetOptionType;
			TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType = this.OnlinePlayerConditionTargetOptionType;
			if (onlinePlayerConditionTargetOptionType != TOnlinePlayerConditionTarget.IOnlinePlayerConditionTargetHost)
			{
				if (onlinePlayerConditionTargetOptionType == TOnlinePlayerConditionTarget.IOnlinePlayerConditionTargetParticipator)
				{
					_o.OnlinePlayerConditionTargetOption.Value = ((this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>() != null) ? this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.OnlinePlayerConditionTargetOption.Value = ((this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>() != null) ? this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value.UnPack() : null);
			}
			_o.RangeEntities = new List<int>();
			for (int i = 0; i < this.RangeEntitiesLength; i++)
			{
				_o.RangeEntities.Add(this.RangeEntities(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601F250 RID: 127568 RVA: 0x004599A8 File Offset: 0x00457BA8
		public static Offset<IRangeSphere> Pack(FlatBufferBuilder builder, IRangeSphereT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRangeSphere>);
			}
			Offset<IVectorInfo> centerOffset = (_o.Center == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Center);
			TOnlinePlayerConditionTarget onlinePlayerConditionTargetOption_type = (_o.OnlinePlayerConditionTargetOption == null) ? TOnlinePlayerConditionTarget.NONE : _o.OnlinePlayerConditionTargetOption.Type;
			int onlinePlayerConditionTargetOptionOffset = (_o.OnlinePlayerConditionTargetOption == null) ? 0 : TOnlinePlayerConditionTargetUnion.Pack(builder, _o.OnlinePlayerConditionTargetOption);
			VectorOffset rangeEntitiesOffset = default(VectorOffset);
			if (_o.RangeEntities != null)
			{
				int[] data = _o.RangeEntities.ToArray();
				rangeEntitiesOffset = IRangeSphere.CreateRangeEntitiesVector(builder, data);
			}
			return IRangeSphere.CreateIRangeSphere(builder, _o.Type, centerOffset, _o.Radius, onlinePlayerConditionTargetOption_type, onlinePlayerConditionTargetOptionOffset, rangeEntitiesOffset, _o.NullMask);
		}

		// Token: 0x0400D66B RID: 54891
		private Table __p;
	}
}
