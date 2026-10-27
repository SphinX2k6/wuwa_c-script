using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F68 RID: 16232
	public struct IOutOfRangeTrackEntity : IFlatbufferObject
	{
		// Token: 0x170070DB RID: 28891
		// (get) Token: 0x06017168 RID: 94568 RVA: 0x00353D0C File Offset: 0x00351F0C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017169 RID: 94569 RVA: 0x00353D19 File Offset: 0x00351F19
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601716A RID: 94570 RVA: 0x00353D20 File Offset: 0x00351F20
		public static IOutOfRangeTrackEntity GetRootAsIOutOfRangeTrackEntity(ByteBuffer _bb)
		{
			return IOutOfRangeTrackEntity.GetRootAsIOutOfRangeTrackEntity(_bb, default(IOutOfRangeTrackEntity));
		}

		// Token: 0x0601716B RID: 94571 RVA: 0x00353D3C File Offset: 0x00351F3C
		public static IOutOfRangeTrackEntity GetRootAsIOutOfRangeTrackEntity(ByteBuffer _bb, IOutOfRangeTrackEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601716C RID: 94572 RVA: 0x00353D59 File Offset: 0x00351F59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601716D RID: 94573 RVA: 0x00353D68 File Offset: 0x00351F68
		public IOutOfRangeTrackEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170070DC RID: 28892
		// (get) Token: 0x0601716E RID: 94574 RVA: 0x00353D78 File Offset: 0x00351F78
		public int TrackEntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170070DD RID: 28893
		// (get) Token: 0x0601716F RID: 94575 RVA: 0x00353DB4 File Offset: 0x00351FB4
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

		// Token: 0x170070DE RID: 28894
		// (get) Token: 0x06017170 RID: 94576 RVA: 0x00353E14 File Offset: 0x00352014
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

		// Token: 0x170070DF RID: 28895
		// (get) Token: 0x06017171 RID: 94577 RVA: 0x00353E50 File Offset: 0x00352050
		public bool OverrideChildNodeTrackTarget
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170070E0 RID: 28896
		// (get) Token: 0x06017172 RID: 94578 RVA: 0x00353E90 File Offset: 0x00352090
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017173 RID: 94579 RVA: 0x00353ECD File Offset: 0x003520CD
		public static Offset<IOutOfRangeTrackEntity> CreateIOutOfRangeTrackEntity(FlatBufferBuilder builder, int TrackEntityId = 0, Offset<IVectorInfo> CenterOffset = default(Offset<IVectorInfo>), int Radius = 0, bool OverrideChildNodeTrackTarget = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IOutOfRangeTrackEntity.AddRadius(builder, Radius);
			IOutOfRangeTrackEntity.AddCenter(builder, CenterOffset);
			IOutOfRangeTrackEntity.AddTrackEntityId(builder, TrackEntityId);
			IOutOfRangeTrackEntity.AddNullMask(builder, NullMask);
			IOutOfRangeTrackEntity.AddOverrideChildNodeTrackTarget(builder, OverrideChildNodeTrackTarget);
			return IOutOfRangeTrackEntity.EndIOutOfRangeTrackEntity(builder);
		}

		// Token: 0x06017174 RID: 94580 RVA: 0x00353F01 File Offset: 0x00352101
		public static void StartIOutOfRangeTrackEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06017175 RID: 94581 RVA: 0x00353F0A File Offset: 0x0035210A
		public static void AddTrackEntityId(FlatBufferBuilder builder, int trackEntityId)
		{
			builder.AddInt(0, trackEntityId, 0);
		}

		// Token: 0x06017176 RID: 94582 RVA: 0x00353F15 File Offset: 0x00352115
		public static void AddCenter(FlatBufferBuilder builder, Offset<IVectorInfo> centerOffset)
		{
			builder.AddOffset(1, centerOffset.Value, 0);
		}

		// Token: 0x06017177 RID: 94583 RVA: 0x00353F25 File Offset: 0x00352125
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(2, radius, 0);
		}

		// Token: 0x06017178 RID: 94584 RVA: 0x00353F30 File Offset: 0x00352130
		public static void AddOverrideChildNodeTrackTarget(FlatBufferBuilder builder, bool overrideChildNodeTrackTarget)
		{
			builder.AddBool(3, overrideChildNodeTrackTarget, false);
		}

		// Token: 0x06017179 RID: 94585 RVA: 0x00353F3B File Offset: 0x0035213B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601717A RID: 94586 RVA: 0x00353F46 File Offset: 0x00352146
		public static Offset<IOutOfRangeTrackEntity> EndIOutOfRangeTrackEntity(FlatBufferBuilder builder)
		{
			return new Offset<IOutOfRangeTrackEntity>(builder.EndTable());
		}

		// Token: 0x0601717B RID: 94587 RVA: 0x00353F54 File Offset: 0x00352154
		public IOutOfRangeTrackEntityT UnPack()
		{
			IOutOfRangeTrackEntityT outOfRangeTrackEntityT = new IOutOfRangeTrackEntityT();
			this.UnPackTo(outOfRangeTrackEntityT);
			return outOfRangeTrackEntityT;
		}

		// Token: 0x0601717C RID: 94588 RVA: 0x00353F70 File Offset: 0x00352170
		public void UnPackTo(IOutOfRangeTrackEntityT _o)
		{
			_o.TrackEntityId = this.TrackEntityId;
			_o.Center = ((this.Center != null) ? this.Center.Value.UnPack() : null);
			_o.Radius = this.Radius;
			_o.OverrideChildNodeTrackTarget = this.OverrideChildNodeTrackTarget;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601717D RID: 94589 RVA: 0x00353FDC File Offset: 0x003521DC
		public static Offset<IOutOfRangeTrackEntity> Pack(FlatBufferBuilder builder, IOutOfRangeTrackEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOutOfRangeTrackEntity>);
			}
			Offset<IVectorInfo> centerOffset = (_o.Center == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Center);
			return IOutOfRangeTrackEntity.CreateIOutOfRangeTrackEntity(builder, _o.TrackEntityId, centerOffset, _o.Radius, _o.OverrideChildNodeTrackTarget, _o.NullMask);
		}

		// Token: 0x0400B981 RID: 47489
		private Table __p;
	}
}
