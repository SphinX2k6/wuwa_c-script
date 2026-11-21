using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004661 RID: 18017
	public struct ITrackLocations : IFlatbufferObject
	{
		// Token: 0x17007E34 RID: 32308
		// (get) Token: 0x0601A6BC RID: 108220 RVA: 0x003C2E32 File Offset: 0x003C1032
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A6BD RID: 108221 RVA: 0x003C2E3F File Offset: 0x003C103F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A6BE RID: 108222 RVA: 0x003C2E48 File Offset: 0x003C1048
		public static ITrackLocations GetRootAsITrackLocations(ByteBuffer _bb)
		{
			return ITrackLocations.GetRootAsITrackLocations(_bb, default(ITrackLocations));
		}

		// Token: 0x0601A6BF RID: 108223 RVA: 0x003C2E64 File Offset: 0x003C1064
		public static ITrackLocations GetRootAsITrackLocations(ByteBuffer _bb, ITrackLocations obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A6C0 RID: 108224 RVA: 0x003C2E81 File Offset: 0x003C1081
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A6C1 RID: 108225 RVA: 0x003C2E90 File Offset: 0x003C1090
		public ITrackLocations __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E35 RID: 32309
		// (get) Token: 0x0601A6C2 RID: 108226 RVA: 0x003C2EA0 File Offset: 0x003C10A0
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

		// Token: 0x17007E36 RID: 32310
		// (get) Token: 0x0601A6C3 RID: 108227 RVA: 0x003C2EDC File Offset: 0x003C10DC
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

		// Token: 0x0601A6C4 RID: 108228 RVA: 0x003C2F18 File Offset: 0x003C1118
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601A6C5 RID: 108229 RVA: 0x003C2F5C File Offset: 0x003C115C
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x0601A6C6 RID: 108230 RVA: 0x003C2F78 File Offset: 0x003C1178
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x0601A6C7 RID: 108231 RVA: 0x003C2F94 File Offset: 0x003C1194
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x0601A6C8 RID: 108232 RVA: 0x003C2FB0 File Offset: 0x003C11B0
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x0601A6C9 RID: 108233 RVA: 0x003C2FCC File Offset: 0x003C11CC
		public IVectorInfo? Locations(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007E37 RID: 32311
		// (get) Token: 0x0601A6CA RID: 108234 RVA: 0x003C3030 File Offset: 0x003C1230
		public int LocationsLength
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

		// Token: 0x17007E38 RID: 32312
		// (get) Token: 0x0601A6CB RID: 108235 RVA: 0x003C305C File Offset: 0x003C125C
		public IOutOfRangeTrackTarget? OutOfRangeTrackTarget
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IOutOfRangeTrackTarget?(default(IOutOfRangeTrackTarget).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007E39 RID: 32313
		// (get) Token: 0x0601A6CC RID: 108236 RVA: 0x003C30BC File Offset: 0x003C12BC
		public IOutOfRangeTrackEntity? OutOfRangeTrackTargetEntity
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IOutOfRangeTrackEntity?(default(IOutOfRangeTrackEntity).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601A6CD RID: 108237 RVA: 0x003C311A File Offset: 0x003C131A
		public static Offset<ITrackLocations> CreateITrackLocations(FlatBufferBuilder builder, ETrackType Type = ETrackType.Locations, TGravityDirection GravityDirection_type = TGravityDirection.NONE, int GravityDirectionOffset = 0, VectorOffset LocationsOffset = default(VectorOffset), Offset<IOutOfRangeTrackTarget> OutOfRangeTrackTargetOffset = default(Offset<IOutOfRangeTrackTarget>), Offset<IOutOfRangeTrackEntity> OutOfRangeTrackTargetEntityOffset = default(Offset<IOutOfRangeTrackEntity>))
		{
			builder.StartTable(6);
			ITrackLocations.AddOutOfRangeTrackTargetEntity(builder, OutOfRangeTrackTargetEntityOffset);
			ITrackLocations.AddOutOfRangeTrackTarget(builder, OutOfRangeTrackTargetOffset);
			ITrackLocations.AddLocations(builder, LocationsOffset);
			ITrackLocations.AddGravityDirection(builder, GravityDirectionOffset);
			ITrackLocations.AddGravityDirectionType(builder, GravityDirection_type);
			ITrackLocations.AddType(builder, Type);
			return ITrackLocations.EndITrackLocations(builder);
		}

		// Token: 0x0601A6CE RID: 108238 RVA: 0x003C3156 File Offset: 0x003C1356
		public static void StartITrackLocations(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601A6CF RID: 108239 RVA: 0x003C315F File Offset: 0x003C135F
		public static void AddType(FlatBufferBuilder builder, ETrackType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A6D0 RID: 108240 RVA: 0x003C316A File Offset: 0x003C136A
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(1, (byte)gravityDirectionType, 0);
		}

		// Token: 0x0601A6D1 RID: 108241 RVA: 0x003C3175 File Offset: 0x003C1375
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(2, gravityDirectionOffset, 0);
		}

		// Token: 0x0601A6D2 RID: 108242 RVA: 0x003C3180 File Offset: 0x003C1380
		public static void AddLocations(FlatBufferBuilder builder, VectorOffset locationsOffset)
		{
			builder.AddOffset(3, locationsOffset.Value, 0);
		}

		// Token: 0x0601A6D3 RID: 108243 RVA: 0x003C3190 File Offset: 0x003C1390
		public static VectorOffset CreateLocationsVector(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A6D4 RID: 108244 RVA: 0x003C31D0 File Offset: 0x003C13D0
		public static VectorOffset CreateLocationsVectorBlock(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A6D5 RID: 108245 RVA: 0x003C31EA File Offset: 0x003C13EA
		public static VectorOffset CreateLocationsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVectorInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A6D6 RID: 108246 RVA: 0x003C3208 File Offset: 0x003C1408
		public static VectorOffset CreateLocationsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVectorInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A6D7 RID: 108247 RVA: 0x003C3221 File Offset: 0x003C1421
		public static void StartLocationsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A6D8 RID: 108248 RVA: 0x003C322C File Offset: 0x003C142C
		public static void AddOutOfRangeTrackTarget(FlatBufferBuilder builder, Offset<IOutOfRangeTrackTarget> outOfRangeTrackTargetOffset)
		{
			builder.AddOffset(4, outOfRangeTrackTargetOffset.Value, 0);
		}

		// Token: 0x0601A6D9 RID: 108249 RVA: 0x003C323C File Offset: 0x003C143C
		public static void AddOutOfRangeTrackTargetEntity(FlatBufferBuilder builder, Offset<IOutOfRangeTrackEntity> outOfRangeTrackTargetEntityOffset)
		{
			builder.AddOffset(5, outOfRangeTrackTargetEntityOffset.Value, 0);
		}

		// Token: 0x0601A6DA RID: 108250 RVA: 0x003C324C File Offset: 0x003C144C
		public static Offset<ITrackLocations> EndITrackLocations(FlatBufferBuilder builder)
		{
			return new Offset<ITrackLocations>(builder.EndTable());
		}

		// Token: 0x0601A6DB RID: 108251 RVA: 0x003C325C File Offset: 0x003C145C
		public ITrackLocationsT UnPack()
		{
			ITrackLocationsT trackLocationsT = new ITrackLocationsT();
			this.UnPackTo(trackLocationsT);
			return trackLocationsT;
		}

		// Token: 0x0601A6DC RID: 108252 RVA: 0x003C3278 File Offset: 0x003C1478
		public void UnPackTo(ITrackLocationsT _o)
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
			_o.Locations = new List<IVectorInfoT>();
			for (int i = 0; i < this.LocationsLength; i++)
			{
				_o.Locations.Add((this.Locations(i) != null) ? this.Locations(i).Value.UnPack() : null);
			}
			_o.OutOfRangeTrackTarget = ((this.OutOfRangeTrackTarget != null) ? this.OutOfRangeTrackTarget.Value.UnPack() : null);
			_o.OutOfRangeTrackTargetEntity = ((this.OutOfRangeTrackTargetEntity != null) ? this.OutOfRangeTrackTargetEntity.Value.UnPack() : null);
		}

		// Token: 0x0601A6DD RID: 108253 RVA: 0x003C3470 File Offset: 0x003C1670
		public static Offset<ITrackLocations> Pack(FlatBufferBuilder builder, ITrackLocationsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrackLocations>);
			}
			TGravityDirection gravityDirection_type = (_o.GravityDirection == null) ? TGravityDirection.NONE : _o.GravityDirection.Type;
			int gravityDirectionOffset = (_o.GravityDirection == null) ? 0 : TGravityDirectionUnion.Pack(builder, _o.GravityDirection);
			VectorOffset locationsOffset = default(VectorOffset);
			if (_o.Locations != null)
			{
				Offset<IVectorInfo>[] array = new Offset<IVectorInfo>[_o.Locations.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IVectorInfo.Pack(builder, _o.Locations[i]);
				}
				locationsOffset = ITrackLocations.CreateLocationsVector(builder, array);
			}
			Offset<IOutOfRangeTrackTarget> outOfRangeTrackTargetOffset = (_o.OutOfRangeTrackTarget == null) ? default(Offset<IOutOfRangeTrackTarget>) : IOutOfRangeTrackTarget.Pack(builder, _o.OutOfRangeTrackTarget);
			Offset<IOutOfRangeTrackEntity> outOfRangeTrackTargetEntityOffset = (_o.OutOfRangeTrackTargetEntity == null) ? default(Offset<IOutOfRangeTrackEntity>) : IOutOfRangeTrackEntity.Pack(builder, _o.OutOfRangeTrackTargetEntity);
			return ITrackLocations.CreateITrackLocations(builder, _o.Type, gravityDirection_type, gravityDirectionOffset, locationsOffset, outOfRangeTrackTargetOffset, outOfRangeTrackTargetEntityOffset);
		}

		// Token: 0x0400C87C RID: 51324
		private Table __p;
	}
}
