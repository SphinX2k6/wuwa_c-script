using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041FF RID: 16895
	public struct ITrackEntityGroup : IFlatbufferObject
	{
		// Token: 0x170077EB RID: 30699
		// (get) Token: 0x06018EEA RID: 102122 RVA: 0x00396609 File Offset: 0x00394809
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018EEB RID: 102123 RVA: 0x00396616 File Offset: 0x00394816
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018EEC RID: 102124 RVA: 0x00396620 File Offset: 0x00394820
		public static ITrackEntityGroup GetRootAsITrackEntityGroup(ByteBuffer _bb)
		{
			return ITrackEntityGroup.GetRootAsITrackEntityGroup(_bb, default(ITrackEntityGroup));
		}

		// Token: 0x06018EED RID: 102125 RVA: 0x0039663C File Offset: 0x0039483C
		public static ITrackEntityGroup GetRootAsITrackEntityGroup(ByteBuffer _bb, ITrackEntityGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018EEE RID: 102126 RVA: 0x00396659 File Offset: 0x00394859
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018EEF RID: 102127 RVA: 0x00396668 File Offset: 0x00394868
		public ITrackEntityGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170077EC RID: 30700
		// (get) Token: 0x06018EF0 RID: 102128 RVA: 0x00396678 File Offset: 0x00394878
		public ETrackType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrackType.Locations;
				}
				return (ETrackType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170077ED RID: 30701
		// (get) Token: 0x06018EF1 RID: 102129 RVA: 0x003966B4 File Offset: 0x003948B4
		public TGravityDirection GravityDirectionType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TGravityDirection.NONE;
				}
				return (TGravityDirection)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018EF2 RID: 102130 RVA: 0x003966F0 File Offset: 0x003948F0
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06018EF3 RID: 102131 RVA: 0x00396734 File Offset: 0x00394934
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x06018EF4 RID: 102132 RVA: 0x00396750 File Offset: 0x00394950
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x06018EF5 RID: 102133 RVA: 0x0039676C File Offset: 0x0039496C
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x06018EF6 RID: 102134 RVA: 0x00396788 File Offset: 0x00394988
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x06018EF7 RID: 102135 RVA: 0x003967A4 File Offset: 0x003949A4
		public int Entities(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170077EE RID: 30702
		// (get) Token: 0x06018EF8 RID: 102136 RVA: 0x003967E4 File Offset: 0x003949E4
		public int EntitiesLength
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

		// Token: 0x06018EF9 RID: 102137 RVA: 0x00396810 File Offset: 0x00394A10
		public Span<int> GetEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06018EFA RID: 102138 RVA: 0x00396820 File Offset: 0x00394A20
		public int[] GetEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x170077EF RID: 30703
		// (get) Token: 0x06018EFB RID: 102139 RVA: 0x00396830 File Offset: 0x00394A30
		public TTrackRuleType TrackRuleTypeType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return TTrackRuleType.NONE;
				}
				return (TTrackRuleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018EFC RID: 102140 RVA: 0x00396870 File Offset: 0x00394A70
		public TTable? TrackRuleType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06018EFD RID: 102141 RVA: 0x003968B8 File Offset: 0x00394AB8
		public ITrackRuleFindFirstNotMatchState TrackRuleTypeAsITrackRuleFindFirstNotMatchState()
		{
			return this.TrackRuleType<ITrackRuleFindFirstNotMatchState>().Value;
		}

		// Token: 0x06018EFE RID: 102142 RVA: 0x003968D4 File Offset: 0x00394AD4
		public ITrackRuleFindLastMatchState TrackRuleTypeAsITrackRuleFindLastMatchState()
		{
			return this.TrackRuleType<ITrackRuleFindLastMatchState>().Value;
		}

		// Token: 0x06018EFF RID: 102143 RVA: 0x003968EF File Offset: 0x00394AEF
		public static Offset<ITrackEntityGroup> CreateITrackEntityGroup(FlatBufferBuilder builder, ETrackType Type = ETrackType.Locations, TGravityDirection GravityDirection_type = TGravityDirection.NONE, int GravityDirectionOffset = 0, VectorOffset EntitiesOffset = default(VectorOffset), TTrackRuleType TrackRuleType_type = TTrackRuleType.NONE, int TrackRuleTypeOffset = 0)
		{
			builder.StartTable(6);
			ITrackEntityGroup.AddTrackRuleType(builder, TrackRuleTypeOffset);
			ITrackEntityGroup.AddEntities(builder, EntitiesOffset);
			ITrackEntityGroup.AddGravityDirection(builder, GravityDirectionOffset);
			ITrackEntityGroup.AddTrackRuleTypeType(builder, TrackRuleType_type);
			ITrackEntityGroup.AddGravityDirectionType(builder, GravityDirection_type);
			ITrackEntityGroup.AddType(builder, Type);
			return ITrackEntityGroup.EndITrackEntityGroup(builder);
		}

		// Token: 0x06018F00 RID: 102144 RVA: 0x0039692B File Offset: 0x00394B2B
		public static void StartITrackEntityGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06018F01 RID: 102145 RVA: 0x00396934 File Offset: 0x00394B34
		public static void AddType(FlatBufferBuilder builder, ETrackType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018F02 RID: 102146 RVA: 0x0039693F File Offset: 0x00394B3F
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(1, (byte)gravityDirectionType, 0);
		}

		// Token: 0x06018F03 RID: 102147 RVA: 0x0039694A File Offset: 0x00394B4A
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(2, gravityDirectionOffset, 0);
		}

		// Token: 0x06018F04 RID: 102148 RVA: 0x00396955 File Offset: 0x00394B55
		public static void AddEntities(FlatBufferBuilder builder, VectorOffset entitiesOffset)
		{
			builder.AddOffset(3, entitiesOffset.Value, 0);
		}

		// Token: 0x06018F05 RID: 102149 RVA: 0x00396968 File Offset: 0x00394B68
		public static VectorOffset CreateEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06018F06 RID: 102150 RVA: 0x0039699F File Offset: 0x00394B9F
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018F07 RID: 102151 RVA: 0x003969B9 File Offset: 0x00394BB9
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018F08 RID: 102152 RVA: 0x003969D7 File Offset: 0x00394BD7
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018F09 RID: 102153 RVA: 0x003969F0 File Offset: 0x00394BF0
		public static void StartEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018F0A RID: 102154 RVA: 0x003969FB File Offset: 0x00394BFB
		public static void AddTrackRuleTypeType(FlatBufferBuilder builder, TTrackRuleType trackRuleTypeType)
		{
			builder.AddByte(4, (byte)trackRuleTypeType, 0);
		}

		// Token: 0x06018F0B RID: 102155 RVA: 0x00396A06 File Offset: 0x00394C06
		public static void AddTrackRuleType(FlatBufferBuilder builder, int trackRuleTypeOffset)
		{
			builder.AddOffset(5, trackRuleTypeOffset, 0);
		}

		// Token: 0x06018F0C RID: 102156 RVA: 0x00396A11 File Offset: 0x00394C11
		public static Offset<ITrackEntityGroup> EndITrackEntityGroup(FlatBufferBuilder builder)
		{
			return new Offset<ITrackEntityGroup>(builder.EndTable());
		}

		// Token: 0x06018F0D RID: 102157 RVA: 0x00396A20 File Offset: 0x00394C20
		public ITrackEntityGroupT UnPack()
		{
			ITrackEntityGroupT trackEntityGroupT = new ITrackEntityGroupT();
			this.UnPackTo(trackEntityGroupT);
			return trackEntityGroupT;
		}

		// Token: 0x06018F0E RID: 102158 RVA: 0x00396A3C File Offset: 0x00394C3C
		public void UnPackTo(ITrackEntityGroupT _o)
		{
			_o.Type = this.Type;
			_o.GravityDirection = new TGravityDirectionUnion();
			_o.GravityDirection.Type = this.GravityDirectionType;
			switch (this.GravityDirectionType)
			{
			case TGravityDirection.IGravityDirectionByEntityGravity:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionByEntityGravity>() != null) ? this.GravityDirection<IGravityDirectionByEntityGravity>().Value.UnPack() : null);
				break;
			case TGravityDirection.IGravityDirectionSelfRotation:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionSelfRotation>() != null) ? this.GravityDirection<IGravityDirectionSelfRotation>().Value.UnPack() : null);
				break;
			case TGravityDirection.IGravityDirectionVectorInfo:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionVectorInfo>() != null) ? this.GravityDirection<IGravityDirectionVectorInfo>().Value.UnPack() : null);
				break;
			case TGravityDirection.IGravityDirectionWorldAxis:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionWorldAxis>() != null) ? this.GravityDirection<IGravityDirectionWorldAxis>().Value.UnPack() : null);
				break;
			}
			_o.Entities = new List<int>();
			for (int i = 0; i < this.EntitiesLength; i++)
			{
				_o.Entities.Add(this.Entities(i));
			}
			_o.TrackRuleType = new TTrackRuleTypeUnion();
			_o.TrackRuleType.Type = this.TrackRuleTypeType;
			TTrackRuleType trackRuleTypeType = this.TrackRuleTypeType;
			if (trackRuleTypeType == TTrackRuleType.ITrackRuleFindFirstNotMatchState)
			{
				_o.TrackRuleType.Value = ((this.TrackRuleType<ITrackRuleFindFirstNotMatchState>() != null) ? this.TrackRuleType<ITrackRuleFindFirstNotMatchState>().Value.UnPack() : null);
				return;
			}
			if (trackRuleTypeType != TTrackRuleType.ITrackRuleFindLastMatchState)
			{
				return;
			}
			_o.TrackRuleType.Value = ((this.TrackRuleType<ITrackRuleFindLastMatchState>() != null) ? this.TrackRuleType<ITrackRuleFindLastMatchState>().Value.UnPack() : null);
		}

		// Token: 0x06018F0F RID: 102159 RVA: 0x00396C48 File Offset: 0x00394E48
		public static Offset<ITrackEntityGroup> Pack(FlatBufferBuilder builder, ITrackEntityGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrackEntityGroup>);
			}
			TGravityDirection gravityDirection_type = (_o.GravityDirection == null) ? TGravityDirection.NONE : _o.GravityDirection.Type;
			int gravityDirectionOffset = (_o.GravityDirection == null) ? 0 : TGravityDirectionUnion.Pack(builder, _o.GravityDirection);
			VectorOffset entitiesOffset = default(VectorOffset);
			if (_o.Entities != null)
			{
				int[] data = _o.Entities.ToArray();
				entitiesOffset = ITrackEntityGroup.CreateEntitiesVector(builder, data);
			}
			TTrackRuleType trackRuleType_type = (_o.TrackRuleType == null) ? TTrackRuleType.NONE : _o.TrackRuleType.Type;
			int trackRuleTypeOffset = (_o.TrackRuleType == null) ? 0 : TTrackRuleTypeUnion.Pack(builder, _o.TrackRuleType);
			return ITrackEntityGroup.CreateITrackEntityGroup(builder, _o.Type, gravityDirection_type, gravityDirectionOffset, entitiesOffset, trackRuleType_type, trackRuleTypeOffset);
		}

		// Token: 0x0400BE62 RID: 48738
		private Table __p;
	}
}
