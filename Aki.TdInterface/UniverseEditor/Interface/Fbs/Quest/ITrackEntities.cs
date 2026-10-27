using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041FC RID: 16892
	public struct ITrackEntities : IFlatbufferObject
	{
		// Token: 0x170077E0 RID: 30688
		// (get) Token: 0x06018EBA RID: 102074 RVA: 0x00395DF2 File Offset: 0x00393FF2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018EBB RID: 102075 RVA: 0x00395DFF File Offset: 0x00393FFF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018EBC RID: 102076 RVA: 0x00395E08 File Offset: 0x00394008
		public static ITrackEntities GetRootAsITrackEntities(ByteBuffer _bb)
		{
			return ITrackEntities.GetRootAsITrackEntities(_bb, default(ITrackEntities));
		}

		// Token: 0x06018EBD RID: 102077 RVA: 0x00395E24 File Offset: 0x00394024
		public static ITrackEntities GetRootAsITrackEntities(ByteBuffer _bb, ITrackEntities obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018EBE RID: 102078 RVA: 0x00395E41 File Offset: 0x00394041
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018EBF RID: 102079 RVA: 0x00395E50 File Offset: 0x00394050
		public ITrackEntities __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170077E1 RID: 30689
		// (get) Token: 0x06018EC0 RID: 102080 RVA: 0x00395E60 File Offset: 0x00394060
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

		// Token: 0x170077E2 RID: 30690
		// (get) Token: 0x06018EC1 RID: 102081 RVA: 0x00395E9C File Offset: 0x0039409C
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

		// Token: 0x06018EC2 RID: 102082 RVA: 0x00395ED8 File Offset: 0x003940D8
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06018EC3 RID: 102083 RVA: 0x00395F1C File Offset: 0x0039411C
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x06018EC4 RID: 102084 RVA: 0x00395F38 File Offset: 0x00394138
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x06018EC5 RID: 102085 RVA: 0x00395F54 File Offset: 0x00394154
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x06018EC6 RID: 102086 RVA: 0x00395F70 File Offset: 0x00394170
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x06018EC7 RID: 102087 RVA: 0x00395F8C File Offset: 0x0039418C
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170077E3 RID: 30691
		// (get) Token: 0x06018EC8 RID: 102088 RVA: 0x00395FCC File Offset: 0x003941CC
		public int EntityIdsLength
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

		// Token: 0x06018EC9 RID: 102089 RVA: 0x00395FF8 File Offset: 0x003941F8
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06018ECA RID: 102090 RVA: 0x00396008 File Offset: 0x00394208
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x170077E4 RID: 30692
		// (get) Token: 0x06018ECB RID: 102091 RVA: 0x00396018 File Offset: 0x00394218
		public IOutOfRangeTrackTarget? OutOfRangeTrackTargetLocation
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

		// Token: 0x170077E5 RID: 30693
		// (get) Token: 0x06018ECC RID: 102092 RVA: 0x00396078 File Offset: 0x00394278
		public IOutOfRangeTrackEntity? OutOfRangeTrackTarget
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

		// Token: 0x06018ECD RID: 102093 RVA: 0x003960D6 File Offset: 0x003942D6
		public static Offset<ITrackEntities> CreateITrackEntities(FlatBufferBuilder builder, ETrackType Type = ETrackType.Locations, TGravityDirection GravityDirection_type = TGravityDirection.NONE, int GravityDirectionOffset = 0, VectorOffset EntityIdsOffset = default(VectorOffset), Offset<IOutOfRangeTrackTarget> OutOfRangeTrackTargetLocationOffset = default(Offset<IOutOfRangeTrackTarget>), Offset<IOutOfRangeTrackEntity> OutOfRangeTrackTargetOffset = default(Offset<IOutOfRangeTrackEntity>))
		{
			builder.StartTable(6);
			ITrackEntities.AddOutOfRangeTrackTarget(builder, OutOfRangeTrackTargetOffset);
			ITrackEntities.AddOutOfRangeTrackTargetLocation(builder, OutOfRangeTrackTargetLocationOffset);
			ITrackEntities.AddEntityIds(builder, EntityIdsOffset);
			ITrackEntities.AddGravityDirection(builder, GravityDirectionOffset);
			ITrackEntities.AddGravityDirectionType(builder, GravityDirection_type);
			ITrackEntities.AddType(builder, Type);
			return ITrackEntities.EndITrackEntities(builder);
		}

		// Token: 0x06018ECE RID: 102094 RVA: 0x00396112 File Offset: 0x00394312
		public static void StartITrackEntities(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06018ECF RID: 102095 RVA: 0x0039611B File Offset: 0x0039431B
		public static void AddType(FlatBufferBuilder builder, ETrackType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018ED0 RID: 102096 RVA: 0x00396126 File Offset: 0x00394326
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(1, (byte)gravityDirectionType, 0);
		}

		// Token: 0x06018ED1 RID: 102097 RVA: 0x00396131 File Offset: 0x00394331
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(2, gravityDirectionOffset, 0);
		}

		// Token: 0x06018ED2 RID: 102098 RVA: 0x0039613C File Offset: 0x0039433C
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(3, entityIdsOffset.Value, 0);
		}

		// Token: 0x06018ED3 RID: 102099 RVA: 0x0039614C File Offset: 0x0039434C
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06018ED4 RID: 102100 RVA: 0x00396183 File Offset: 0x00394383
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018ED5 RID: 102101 RVA: 0x0039619D File Offset: 0x0039439D
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018ED6 RID: 102102 RVA: 0x003961BB File Offset: 0x003943BB
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018ED7 RID: 102103 RVA: 0x003961D4 File Offset: 0x003943D4
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018ED8 RID: 102104 RVA: 0x003961DF File Offset: 0x003943DF
		public static void AddOutOfRangeTrackTargetLocation(FlatBufferBuilder builder, Offset<IOutOfRangeTrackTarget> outOfRangeTrackTargetLocationOffset)
		{
			builder.AddOffset(4, outOfRangeTrackTargetLocationOffset.Value, 0);
		}

		// Token: 0x06018ED9 RID: 102105 RVA: 0x003961EF File Offset: 0x003943EF
		public static void AddOutOfRangeTrackTarget(FlatBufferBuilder builder, Offset<IOutOfRangeTrackEntity> outOfRangeTrackTargetOffset)
		{
			builder.AddOffset(5, outOfRangeTrackTargetOffset.Value, 0);
		}

		// Token: 0x06018EDA RID: 102106 RVA: 0x003961FF File Offset: 0x003943FF
		public static Offset<ITrackEntities> EndITrackEntities(FlatBufferBuilder builder)
		{
			return new Offset<ITrackEntities>(builder.EndTable());
		}

		// Token: 0x06018EDB RID: 102107 RVA: 0x0039620C File Offset: 0x0039440C
		public ITrackEntitiesT UnPack()
		{
			ITrackEntitiesT trackEntitiesT = new ITrackEntitiesT();
			this.UnPackTo(trackEntitiesT);
			return trackEntitiesT;
		}

		// Token: 0x06018EDC RID: 102108 RVA: 0x00396228 File Offset: 0x00394428
		public void UnPackTo(ITrackEntitiesT _o)
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
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.OutOfRangeTrackTargetLocation = ((this.OutOfRangeTrackTargetLocation != null) ? this.OutOfRangeTrackTargetLocation.Value.UnPack() : null);
			_o.OutOfRangeTrackTarget = ((this.OutOfRangeTrackTarget != null) ? this.OutOfRangeTrackTarget.Value.UnPack() : null);
		}

		// Token: 0x06018EDD RID: 102109 RVA: 0x003963F8 File Offset: 0x003945F8
		public static Offset<ITrackEntities> Pack(FlatBufferBuilder builder, ITrackEntitiesT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrackEntities>);
			}
			TGravityDirection gravityDirection_type = (_o.GravityDirection == null) ? TGravityDirection.NONE : _o.GravityDirection.Type;
			int gravityDirectionOffset = (_o.GravityDirection == null) ? 0 : TGravityDirectionUnion.Pack(builder, _o.GravityDirection);
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = ITrackEntities.CreateEntityIdsVector(builder, data);
			}
			Offset<IOutOfRangeTrackTarget> outOfRangeTrackTargetLocationOffset = (_o.OutOfRangeTrackTargetLocation == null) ? default(Offset<IOutOfRangeTrackTarget>) : IOutOfRangeTrackTarget.Pack(builder, _o.OutOfRangeTrackTargetLocation);
			Offset<IOutOfRangeTrackEntity> outOfRangeTrackTargetOffset = (_o.OutOfRangeTrackTarget == null) ? default(Offset<IOutOfRangeTrackEntity>) : IOutOfRangeTrackEntity.Pack(builder, _o.OutOfRangeTrackTarget);
			return ITrackEntities.CreateITrackEntities(builder, _o.Type, gravityDirection_type, gravityDirectionOffset, entityIdsOffset, outOfRangeTrackTargetLocationOffset, outOfRangeTrackTargetOffset);
		}

		// Token: 0x0400BE5C RID: 48732
		private Table __p;
	}
}
