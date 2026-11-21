using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004655 RID: 18005
	public struct ITrackEntities : IFlatbufferObject
	{
		// Token: 0x17007E0E RID: 32270
		// (get) Token: 0x0601A614 RID: 108052 RVA: 0x003C1352 File Offset: 0x003BF552
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A615 RID: 108053 RVA: 0x003C135F File Offset: 0x003BF55F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A616 RID: 108054 RVA: 0x003C1368 File Offset: 0x003BF568
		public static ITrackEntities GetRootAsITrackEntities(ByteBuffer _bb)
		{
			return ITrackEntities.GetRootAsITrackEntities(_bb, default(ITrackEntities));
		}

		// Token: 0x0601A617 RID: 108055 RVA: 0x003C1384 File Offset: 0x003BF584
		public static ITrackEntities GetRootAsITrackEntities(ByteBuffer _bb, ITrackEntities obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A618 RID: 108056 RVA: 0x003C13A1 File Offset: 0x003BF5A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A619 RID: 108057 RVA: 0x003C13B0 File Offset: 0x003BF5B0
		public ITrackEntities __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E0F RID: 32271
		// (get) Token: 0x0601A61A RID: 108058 RVA: 0x003C13C0 File Offset: 0x003BF5C0
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

		// Token: 0x17007E10 RID: 32272
		// (get) Token: 0x0601A61B RID: 108059 RVA: 0x003C13FC File Offset: 0x003BF5FC
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

		// Token: 0x0601A61C RID: 108060 RVA: 0x003C1438 File Offset: 0x003BF638
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601A61D RID: 108061 RVA: 0x003C147C File Offset: 0x003BF67C
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x0601A61E RID: 108062 RVA: 0x003C1498 File Offset: 0x003BF698
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x0601A61F RID: 108063 RVA: 0x003C14B4 File Offset: 0x003BF6B4
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x0601A620 RID: 108064 RVA: 0x003C14D0 File Offset: 0x003BF6D0
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x0601A621 RID: 108065 RVA: 0x003C14EC File Offset: 0x003BF6EC
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007E11 RID: 32273
		// (get) Token: 0x0601A622 RID: 108066 RVA: 0x003C152C File Offset: 0x003BF72C
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

		// Token: 0x0601A623 RID: 108067 RVA: 0x003C1558 File Offset: 0x003BF758
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0601A624 RID: 108068 RVA: 0x003C1568 File Offset: 0x003BF768
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x17007E12 RID: 32274
		// (get) Token: 0x0601A625 RID: 108069 RVA: 0x003C1578 File Offset: 0x003BF778
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

		// Token: 0x17007E13 RID: 32275
		// (get) Token: 0x0601A626 RID: 108070 RVA: 0x003C15D8 File Offset: 0x003BF7D8
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

		// Token: 0x0601A627 RID: 108071 RVA: 0x003C1636 File Offset: 0x003BF836
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

		// Token: 0x0601A628 RID: 108072 RVA: 0x003C1672 File Offset: 0x003BF872
		public static void StartITrackEntities(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601A629 RID: 108073 RVA: 0x003C167B File Offset: 0x003BF87B
		public static void AddType(FlatBufferBuilder builder, ETrackType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A62A RID: 108074 RVA: 0x003C1686 File Offset: 0x003BF886
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(1, (byte)gravityDirectionType, 0);
		}

		// Token: 0x0601A62B RID: 108075 RVA: 0x003C1691 File Offset: 0x003BF891
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(2, gravityDirectionOffset, 0);
		}

		// Token: 0x0601A62C RID: 108076 RVA: 0x003C169C File Offset: 0x003BF89C
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(3, entityIdsOffset.Value, 0);
		}

		// Token: 0x0601A62D RID: 108077 RVA: 0x003C16AC File Offset: 0x003BF8AC
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A62E RID: 108078 RVA: 0x003C16E3 File Offset: 0x003BF8E3
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A62F RID: 108079 RVA: 0x003C16FD File Offset: 0x003BF8FD
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A630 RID: 108080 RVA: 0x003C171B File Offset: 0x003BF91B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A631 RID: 108081 RVA: 0x003C1734 File Offset: 0x003BF934
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A632 RID: 108082 RVA: 0x003C173F File Offset: 0x003BF93F
		public static void AddOutOfRangeTrackTargetLocation(FlatBufferBuilder builder, Offset<IOutOfRangeTrackTarget> outOfRangeTrackTargetLocationOffset)
		{
			builder.AddOffset(4, outOfRangeTrackTargetLocationOffset.Value, 0);
		}

		// Token: 0x0601A633 RID: 108083 RVA: 0x003C174F File Offset: 0x003BF94F
		public static void AddOutOfRangeTrackTarget(FlatBufferBuilder builder, Offset<IOutOfRangeTrackEntity> outOfRangeTrackTargetOffset)
		{
			builder.AddOffset(5, outOfRangeTrackTargetOffset.Value, 0);
		}

		// Token: 0x0601A634 RID: 108084 RVA: 0x003C175F File Offset: 0x003BF95F
		public static Offset<ITrackEntities> EndITrackEntities(FlatBufferBuilder builder)
		{
			return new Offset<ITrackEntities>(builder.EndTable());
		}

		// Token: 0x0601A635 RID: 108085 RVA: 0x003C176C File Offset: 0x003BF96C
		public ITrackEntitiesT UnPack()
		{
			ITrackEntitiesT trackEntitiesT = new ITrackEntitiesT();
			this.UnPackTo(trackEntitiesT);
			return trackEntitiesT;
		}

		// Token: 0x0601A636 RID: 108086 RVA: 0x003C1788 File Offset: 0x003BF988
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

		// Token: 0x0601A637 RID: 108087 RVA: 0x003C1958 File Offset: 0x003BFB58
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

		// Token: 0x0400C867 RID: 51303
		private Table __p;
	}
}
