using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004205 RID: 16901
	public struct ITrackLocations : IFlatbufferObject
	{
		// Token: 0x17007803 RID: 30723
		// (get) Token: 0x06018F50 RID: 102224 RVA: 0x0039775A File Offset: 0x0039595A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018F51 RID: 102225 RVA: 0x00397767 File Offset: 0x00395967
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018F52 RID: 102226 RVA: 0x00397770 File Offset: 0x00395970
		public static ITrackLocations GetRootAsITrackLocations(ByteBuffer _bb)
		{
			return ITrackLocations.GetRootAsITrackLocations(_bb, default(ITrackLocations));
		}

		// Token: 0x06018F53 RID: 102227 RVA: 0x0039778C File Offset: 0x0039598C
		public static ITrackLocations GetRootAsITrackLocations(ByteBuffer _bb, ITrackLocations obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018F54 RID: 102228 RVA: 0x003977A9 File Offset: 0x003959A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018F55 RID: 102229 RVA: 0x003977B8 File Offset: 0x003959B8
		public ITrackLocations __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007804 RID: 30724
		// (get) Token: 0x06018F56 RID: 102230 RVA: 0x003977C8 File Offset: 0x003959C8
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

		// Token: 0x17007805 RID: 30725
		// (get) Token: 0x06018F57 RID: 102231 RVA: 0x00397804 File Offset: 0x00395A04
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

		// Token: 0x06018F58 RID: 102232 RVA: 0x00397840 File Offset: 0x00395A40
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06018F59 RID: 102233 RVA: 0x00397884 File Offset: 0x00395A84
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x06018F5A RID: 102234 RVA: 0x003978A0 File Offset: 0x00395AA0
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x06018F5B RID: 102235 RVA: 0x003978BC File Offset: 0x00395ABC
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x06018F5C RID: 102236 RVA: 0x003978D8 File Offset: 0x00395AD8
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x06018F5D RID: 102237 RVA: 0x003978F4 File Offset: 0x00395AF4
		public IVectorInfo? Locations(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007806 RID: 30726
		// (get) Token: 0x06018F5E RID: 102238 RVA: 0x00397958 File Offset: 0x00395B58
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

		// Token: 0x17007807 RID: 30727
		// (get) Token: 0x06018F5F RID: 102239 RVA: 0x00397984 File Offset: 0x00395B84
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

		// Token: 0x17007808 RID: 30728
		// (get) Token: 0x06018F60 RID: 102240 RVA: 0x003979E4 File Offset: 0x00395BE4
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

		// Token: 0x06018F61 RID: 102241 RVA: 0x00397A42 File Offset: 0x00395C42
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

		// Token: 0x06018F62 RID: 102242 RVA: 0x00397A7E File Offset: 0x00395C7E
		public static void StartITrackLocations(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06018F63 RID: 102243 RVA: 0x00397A87 File Offset: 0x00395C87
		public static void AddType(FlatBufferBuilder builder, ETrackType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018F64 RID: 102244 RVA: 0x00397A92 File Offset: 0x00395C92
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(1, (byte)gravityDirectionType, 0);
		}

		// Token: 0x06018F65 RID: 102245 RVA: 0x00397A9D File Offset: 0x00395C9D
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(2, gravityDirectionOffset, 0);
		}

		// Token: 0x06018F66 RID: 102246 RVA: 0x00397AA8 File Offset: 0x00395CA8
		public static void AddLocations(FlatBufferBuilder builder, VectorOffset locationsOffset)
		{
			builder.AddOffset(3, locationsOffset.Value, 0);
		}

		// Token: 0x06018F67 RID: 102247 RVA: 0x00397AB8 File Offset: 0x00395CB8
		public static VectorOffset CreateLocationsVector(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06018F68 RID: 102248 RVA: 0x00397AF8 File Offset: 0x00395CF8
		public static VectorOffset CreateLocationsVectorBlock(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018F69 RID: 102249 RVA: 0x00397B12 File Offset: 0x00395D12
		public static VectorOffset CreateLocationsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVectorInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018F6A RID: 102250 RVA: 0x00397B30 File Offset: 0x00395D30
		public static VectorOffset CreateLocationsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVectorInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018F6B RID: 102251 RVA: 0x00397B49 File Offset: 0x00395D49
		public static void StartLocationsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018F6C RID: 102252 RVA: 0x00397B54 File Offset: 0x00395D54
		public static void AddOutOfRangeTrackTarget(FlatBufferBuilder builder, Offset<IOutOfRangeTrackTarget> outOfRangeTrackTargetOffset)
		{
			builder.AddOffset(4, outOfRangeTrackTargetOffset.Value, 0);
		}

		// Token: 0x06018F6D RID: 102253 RVA: 0x00397B64 File Offset: 0x00395D64
		public static void AddOutOfRangeTrackTargetEntity(FlatBufferBuilder builder, Offset<IOutOfRangeTrackEntity> outOfRangeTrackTargetEntityOffset)
		{
			builder.AddOffset(5, outOfRangeTrackTargetEntityOffset.Value, 0);
		}

		// Token: 0x06018F6E RID: 102254 RVA: 0x00397B74 File Offset: 0x00395D74
		public static Offset<ITrackLocations> EndITrackLocations(FlatBufferBuilder builder)
		{
			return new Offset<ITrackLocations>(builder.EndTable());
		}

		// Token: 0x06018F6F RID: 102255 RVA: 0x00397B84 File Offset: 0x00395D84
		public ITrackLocationsT UnPack()
		{
			ITrackLocationsT trackLocationsT = new ITrackLocationsT();
			this.UnPackTo(trackLocationsT);
			return trackLocationsT;
		}

		// Token: 0x06018F70 RID: 102256 RVA: 0x00397BA0 File Offset: 0x00395DA0
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

		// Token: 0x06018F71 RID: 102257 RVA: 0x00397D98 File Offset: 0x00395F98
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

		// Token: 0x0400BE6F RID: 48751
		private Table __p;
	}
}
