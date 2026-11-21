using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051A5 RID: 20901
	public struct IRangeSphere : IFlatbufferObject
	{
		// Token: 0x170095AE RID: 38318
		// (get) Token: 0x06020E4F RID: 134735 RVA: 0x0048CF8C File Offset: 0x0048B18C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020E50 RID: 134736 RVA: 0x0048CF99 File Offset: 0x0048B199
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020E51 RID: 134737 RVA: 0x0048CFA0 File Offset: 0x0048B1A0
		public static IRangeSphere GetRootAsIRangeSphere(ByteBuffer _bb)
		{
			return IRangeSphere.GetRootAsIRangeSphere(_bb, default(IRangeSphere));
		}

		// Token: 0x06020E52 RID: 134738 RVA: 0x0048CFBC File Offset: 0x0048B1BC
		public static IRangeSphere GetRootAsIRangeSphere(ByteBuffer _bb, IRangeSphere obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020E53 RID: 134739 RVA: 0x0048CFD9 File Offset: 0x0048B1D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020E54 RID: 134740 RVA: 0x0048CFE8 File Offset: 0x0048B1E8
		public IRangeSphere __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170095AF RID: 38319
		// (get) Token: 0x06020E55 RID: 134741 RVA: 0x0048CFF8 File Offset: 0x0048B1F8
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

		// Token: 0x170095B0 RID: 38320
		// (get) Token: 0x06020E56 RID: 134742 RVA: 0x0048D034 File Offset: 0x0048B234
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

		// Token: 0x170095B1 RID: 38321
		// (get) Token: 0x06020E57 RID: 134743 RVA: 0x0048D094 File Offset: 0x0048B294
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

		// Token: 0x170095B2 RID: 38322
		// (get) Token: 0x06020E58 RID: 134744 RVA: 0x0048D0D0 File Offset: 0x0048B2D0
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

		// Token: 0x06020E59 RID: 134745 RVA: 0x0048D110 File Offset: 0x0048B310
		public TTable? OnlinePlayerConditionTargetOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06020E5A RID: 134746 RVA: 0x0048D158 File Offset: 0x0048B358
		public IOnlinePlayerConditionTargetHost OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetHost()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value;
		}

		// Token: 0x06020E5B RID: 134747 RVA: 0x0048D174 File Offset: 0x0048B374
		public IOnlinePlayerConditionTargetParticipator OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetParticipator()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value;
		}

		// Token: 0x06020E5C RID: 134748 RVA: 0x0048D190 File Offset: 0x0048B390
		public int RangeEntities(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170095B3 RID: 38323
		// (get) Token: 0x06020E5D RID: 134749 RVA: 0x0048D1D0 File Offset: 0x0048B3D0
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

		// Token: 0x06020E5E RID: 134750 RVA: 0x0048D1FC File Offset: 0x0048B3FC
		public Span<int> GetRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06020E5F RID: 134751 RVA: 0x0048D20C File Offset: 0x0048B40C
		public int[] GetRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(14);
		}

		// Token: 0x170095B4 RID: 38324
		// (get) Token: 0x06020E60 RID: 134752 RVA: 0x0048D21C File Offset: 0x0048B41C
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

		// Token: 0x06020E61 RID: 134753 RVA: 0x0048D25C File Offset: 0x0048B45C
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

		// Token: 0x06020E62 RID: 134754 RVA: 0x0048D2AB File Offset: 0x0048B4AB
		public static void StartIRangeSphere(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06020E63 RID: 134755 RVA: 0x0048D2B4 File Offset: 0x0048B4B4
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020E64 RID: 134756 RVA: 0x0048D2BF File Offset: 0x0048B4BF
		public static void AddCenter(FlatBufferBuilder builder, Offset<IVectorInfo> centerOffset)
		{
			builder.AddOffset(1, centerOffset.Value, 0);
		}

		// Token: 0x06020E65 RID: 134757 RVA: 0x0048D2CF File Offset: 0x0048B4CF
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(2, radius, 0);
		}

		// Token: 0x06020E66 RID: 134758 RVA: 0x0048D2DA File Offset: 0x0048B4DA
		public static void AddOnlinePlayerConditionTargetOptionType(FlatBufferBuilder builder, TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType)
		{
			builder.AddByte(3, (byte)onlinePlayerConditionTargetOptionType, 0);
		}

		// Token: 0x06020E67 RID: 134759 RVA: 0x0048D2E5 File Offset: 0x0048B4E5
		public static void AddOnlinePlayerConditionTargetOption(FlatBufferBuilder builder, int onlinePlayerConditionTargetOptionOffset)
		{
			builder.AddOffset(4, onlinePlayerConditionTargetOptionOffset, 0);
		}

		// Token: 0x06020E68 RID: 134760 RVA: 0x0048D2F0 File Offset: 0x0048B4F0
		public static void AddRangeEntities(FlatBufferBuilder builder, VectorOffset rangeEntitiesOffset)
		{
			builder.AddOffset(5, rangeEntitiesOffset.Value, 0);
		}

		// Token: 0x06020E69 RID: 134761 RVA: 0x0048D300 File Offset: 0x0048B500
		public static VectorOffset CreateRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06020E6A RID: 134762 RVA: 0x0048D337 File Offset: 0x0048B537
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06020E6B RID: 134763 RVA: 0x0048D351 File Offset: 0x0048B551
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06020E6C RID: 134764 RVA: 0x0048D36F File Offset: 0x0048B56F
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020E6D RID: 134765 RVA: 0x0048D388 File Offset: 0x0048B588
		public static void StartRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020E6E RID: 134766 RVA: 0x0048D393 File Offset: 0x0048B593
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06020E6F RID: 134767 RVA: 0x0048D39E File Offset: 0x0048B59E
		public static Offset<IRangeSphere> EndIRangeSphere(FlatBufferBuilder builder)
		{
			return new Offset<IRangeSphere>(builder.EndTable());
		}

		// Token: 0x06020E70 RID: 134768 RVA: 0x0048D3AC File Offset: 0x0048B5AC
		public IRangeSphereT UnPack()
		{
			IRangeSphereT rangeSphereT = new IRangeSphereT();
			this.UnPackTo(rangeSphereT);
			return rangeSphereT;
		}

		// Token: 0x06020E71 RID: 134769 RVA: 0x0048D3C8 File Offset: 0x0048B5C8
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

		// Token: 0x06020E72 RID: 134770 RVA: 0x0048D4F8 File Offset: 0x0048B6F8
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

		// Token: 0x0400E192 RID: 57746
		private Table __p;
	}
}
