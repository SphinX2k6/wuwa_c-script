using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043A6 RID: 17318
	public struct IOutOfRangeTrackEntity : IFlatbufferObject
	{
		// Token: 0x170076CC RID: 30412
		// (get) Token: 0x060187CA RID: 100298 RVA: 0x0037D180 File Offset: 0x0037B380
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060187CB RID: 100299 RVA: 0x0037D18D File Offset: 0x0037B38D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060187CC RID: 100300 RVA: 0x0037D194 File Offset: 0x0037B394
		public static IOutOfRangeTrackEntity GetRootAsIOutOfRangeTrackEntity(ByteBuffer _bb)
		{
			return IOutOfRangeTrackEntity.GetRootAsIOutOfRangeTrackEntity(_bb, default(IOutOfRangeTrackEntity));
		}

		// Token: 0x060187CD RID: 100301 RVA: 0x0037D1B0 File Offset: 0x0037B3B0
		public static IOutOfRangeTrackEntity GetRootAsIOutOfRangeTrackEntity(ByteBuffer _bb, IOutOfRangeTrackEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060187CE RID: 100302 RVA: 0x0037D1CD File Offset: 0x0037B3CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060187CF RID: 100303 RVA: 0x0037D1DC File Offset: 0x0037B3DC
		public IOutOfRangeTrackEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170076CD RID: 30413
		// (get) Token: 0x060187D0 RID: 100304 RVA: 0x0037D1EC File Offset: 0x0037B3EC
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

		// Token: 0x170076CE RID: 30414
		// (get) Token: 0x060187D1 RID: 100305 RVA: 0x0037D228 File Offset: 0x0037B428
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

		// Token: 0x170076CF RID: 30415
		// (get) Token: 0x060187D2 RID: 100306 RVA: 0x0037D288 File Offset: 0x0037B488
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

		// Token: 0x170076D0 RID: 30416
		// (get) Token: 0x060187D3 RID: 100307 RVA: 0x0037D2C4 File Offset: 0x0037B4C4
		public bool OverrideChildNodeTrackTarget
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170076D1 RID: 30417
		// (get) Token: 0x060187D4 RID: 100308 RVA: 0x0037D304 File Offset: 0x0037B504
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

		// Token: 0x060187D5 RID: 100309 RVA: 0x0037D341 File Offset: 0x0037B541
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

		// Token: 0x060187D6 RID: 100310 RVA: 0x0037D375 File Offset: 0x0037B575
		public static void StartIOutOfRangeTrackEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060187D7 RID: 100311 RVA: 0x0037D37E File Offset: 0x0037B57E
		public static void AddTrackEntityId(FlatBufferBuilder builder, int trackEntityId)
		{
			builder.AddInt(0, trackEntityId, 0);
		}

		// Token: 0x060187D8 RID: 100312 RVA: 0x0037D389 File Offset: 0x0037B589
		public static void AddCenter(FlatBufferBuilder builder, Offset<IVectorInfo> centerOffset)
		{
			builder.AddOffset(1, centerOffset.Value, 0);
		}

		// Token: 0x060187D9 RID: 100313 RVA: 0x0037D399 File Offset: 0x0037B599
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(2, radius, 0);
		}

		// Token: 0x060187DA RID: 100314 RVA: 0x0037D3A4 File Offset: 0x0037B5A4
		public static void AddOverrideChildNodeTrackTarget(FlatBufferBuilder builder, bool overrideChildNodeTrackTarget)
		{
			builder.AddBool(3, overrideChildNodeTrackTarget, false);
		}

		// Token: 0x060187DB RID: 100315 RVA: 0x0037D3AF File Offset: 0x0037B5AF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060187DC RID: 100316 RVA: 0x0037D3BA File Offset: 0x0037B5BA
		public static Offset<IOutOfRangeTrackEntity> EndIOutOfRangeTrackEntity(FlatBufferBuilder builder)
		{
			return new Offset<IOutOfRangeTrackEntity>(builder.EndTable());
		}

		// Token: 0x060187DD RID: 100317 RVA: 0x0037D3C8 File Offset: 0x0037B5C8
		public IOutOfRangeTrackEntityT UnPack()
		{
			IOutOfRangeTrackEntityT outOfRangeTrackEntityT = new IOutOfRangeTrackEntityT();
			this.UnPackTo(outOfRangeTrackEntityT);
			return outOfRangeTrackEntityT;
		}

		// Token: 0x060187DE RID: 100318 RVA: 0x0037D3E4 File Offset: 0x0037B5E4
		public void UnPackTo(IOutOfRangeTrackEntityT _o)
		{
			_o.TrackEntityId = this.TrackEntityId;
			_o.Center = ((this.Center != null) ? this.Center.Value.UnPack() : null);
			_o.Radius = this.Radius;
			_o.OverrideChildNodeTrackTarget = this.OverrideChildNodeTrackTarget;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060187DF RID: 100319 RVA: 0x0037D450 File Offset: 0x0037B650
		public static Offset<IOutOfRangeTrackEntity> Pack(FlatBufferBuilder builder, IOutOfRangeTrackEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOutOfRangeTrackEntity>);
			}
			Offset<IVectorInfo> centerOffset = (_o.Center == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Center);
			return IOutOfRangeTrackEntity.CreateIOutOfRangeTrackEntity(builder, _o.TrackEntityId, centerOffset, _o.Radius, _o.OverrideChildNodeTrackTarget, _o.NullMask);
		}

		// Token: 0x0400C35F RID: 50015
		private Table __p;
	}
}
