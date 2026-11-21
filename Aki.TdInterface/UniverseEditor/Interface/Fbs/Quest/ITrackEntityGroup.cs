using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004658 RID: 18008
	public struct ITrackEntityGroup : IFlatbufferObject
	{
		// Token: 0x17007E19 RID: 32281
		// (get) Token: 0x0601A644 RID: 108100 RVA: 0x003C1B69 File Offset: 0x003BFD69
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A645 RID: 108101 RVA: 0x003C1B76 File Offset: 0x003BFD76
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A646 RID: 108102 RVA: 0x003C1B80 File Offset: 0x003BFD80
		public static ITrackEntityGroup GetRootAsITrackEntityGroup(ByteBuffer _bb)
		{
			return ITrackEntityGroup.GetRootAsITrackEntityGroup(_bb, default(ITrackEntityGroup));
		}

		// Token: 0x0601A647 RID: 108103 RVA: 0x003C1B9C File Offset: 0x003BFD9C
		public static ITrackEntityGroup GetRootAsITrackEntityGroup(ByteBuffer _bb, ITrackEntityGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A648 RID: 108104 RVA: 0x003C1BB9 File Offset: 0x003BFDB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A649 RID: 108105 RVA: 0x003C1BC8 File Offset: 0x003BFDC8
		public ITrackEntityGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E1A RID: 32282
		// (get) Token: 0x0601A64A RID: 108106 RVA: 0x003C1BD8 File Offset: 0x003BFDD8
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

		// Token: 0x17007E1B RID: 32283
		// (get) Token: 0x0601A64B RID: 108107 RVA: 0x003C1C14 File Offset: 0x003BFE14
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

		// Token: 0x0601A64C RID: 108108 RVA: 0x003C1C50 File Offset: 0x003BFE50
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601A64D RID: 108109 RVA: 0x003C1C94 File Offset: 0x003BFE94
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x0601A64E RID: 108110 RVA: 0x003C1CB0 File Offset: 0x003BFEB0
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x0601A64F RID: 108111 RVA: 0x003C1CCC File Offset: 0x003BFECC
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x0601A650 RID: 108112 RVA: 0x003C1CE8 File Offset: 0x003BFEE8
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x0601A651 RID: 108113 RVA: 0x003C1D04 File Offset: 0x003BFF04
		public int Entities(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007E1C RID: 32284
		// (get) Token: 0x0601A652 RID: 108114 RVA: 0x003C1D44 File Offset: 0x003BFF44
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

		// Token: 0x0601A653 RID: 108115 RVA: 0x003C1D70 File Offset: 0x003BFF70
		public Span<int> GetEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0601A654 RID: 108116 RVA: 0x003C1D80 File Offset: 0x003BFF80
		public int[] GetEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x17007E1D RID: 32285
		// (get) Token: 0x0601A655 RID: 108117 RVA: 0x003C1D90 File Offset: 0x003BFF90
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

		// Token: 0x0601A656 RID: 108118 RVA: 0x003C1DD0 File Offset: 0x003BFFD0
		public TTable? TrackRuleType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601A657 RID: 108119 RVA: 0x003C1E18 File Offset: 0x003C0018
		public ITrackRuleFindFirstNotMatchState TrackRuleTypeAsITrackRuleFindFirstNotMatchState()
		{
			return this.TrackRuleType<ITrackRuleFindFirstNotMatchState>().Value;
		}

		// Token: 0x0601A658 RID: 108120 RVA: 0x003C1E34 File Offset: 0x003C0034
		public ITrackRuleFindLastMatchState TrackRuleTypeAsITrackRuleFindLastMatchState()
		{
			return this.TrackRuleType<ITrackRuleFindLastMatchState>().Value;
		}

		// Token: 0x0601A659 RID: 108121 RVA: 0x003C1E4F File Offset: 0x003C004F
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

		// Token: 0x0601A65A RID: 108122 RVA: 0x003C1E8B File Offset: 0x003C008B
		public static void StartITrackEntityGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601A65B RID: 108123 RVA: 0x003C1E94 File Offset: 0x003C0094
		public static void AddType(FlatBufferBuilder builder, ETrackType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A65C RID: 108124 RVA: 0x003C1E9F File Offset: 0x003C009F
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(1, (byte)gravityDirectionType, 0);
		}

		// Token: 0x0601A65D RID: 108125 RVA: 0x003C1EAA File Offset: 0x003C00AA
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(2, gravityDirectionOffset, 0);
		}

		// Token: 0x0601A65E RID: 108126 RVA: 0x003C1EB5 File Offset: 0x003C00B5
		public static void AddEntities(FlatBufferBuilder builder, VectorOffset entitiesOffset)
		{
			builder.AddOffset(3, entitiesOffset.Value, 0);
		}

		// Token: 0x0601A65F RID: 108127 RVA: 0x003C1EC8 File Offset: 0x003C00C8
		public static VectorOffset CreateEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A660 RID: 108128 RVA: 0x003C1EFF File Offset: 0x003C00FF
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A661 RID: 108129 RVA: 0x003C1F19 File Offset: 0x003C0119
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A662 RID: 108130 RVA: 0x003C1F37 File Offset: 0x003C0137
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A663 RID: 108131 RVA: 0x003C1F50 File Offset: 0x003C0150
		public static void StartEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A664 RID: 108132 RVA: 0x003C1F5B File Offset: 0x003C015B
		public static void AddTrackRuleTypeType(FlatBufferBuilder builder, TTrackRuleType trackRuleTypeType)
		{
			builder.AddByte(4, (byte)trackRuleTypeType, 0);
		}

		// Token: 0x0601A665 RID: 108133 RVA: 0x003C1F66 File Offset: 0x003C0166
		public static void AddTrackRuleType(FlatBufferBuilder builder, int trackRuleTypeOffset)
		{
			builder.AddOffset(5, trackRuleTypeOffset, 0);
		}

		// Token: 0x0601A666 RID: 108134 RVA: 0x003C1F71 File Offset: 0x003C0171
		public static Offset<ITrackEntityGroup> EndITrackEntityGroup(FlatBufferBuilder builder)
		{
			return new Offset<ITrackEntityGroup>(builder.EndTable());
		}

		// Token: 0x0601A667 RID: 108135 RVA: 0x003C1F80 File Offset: 0x003C0180
		public ITrackEntityGroupT UnPack()
		{
			ITrackEntityGroupT trackEntityGroupT = new ITrackEntityGroupT();
			this.UnPackTo(trackEntityGroupT);
			return trackEntityGroupT;
		}

		// Token: 0x0601A668 RID: 108136 RVA: 0x003C1F9C File Offset: 0x003C019C
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

		// Token: 0x0601A669 RID: 108137 RVA: 0x003C21A8 File Offset: 0x003C03A8
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

		// Token: 0x0400C86D RID: 51309
		private Table __p;
	}
}
