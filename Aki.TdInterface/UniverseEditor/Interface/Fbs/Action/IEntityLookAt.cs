using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D5E RID: 27998
	public struct IEntityLookAt : IFlatbufferObject
	{
		// Token: 0x1700CD57 RID: 52567
		// (get) Token: 0x060304B4 RID: 197812 RVA: 0x00690216 File Offset: 0x0068E416
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060304B5 RID: 197813 RVA: 0x00690223 File Offset: 0x0068E423
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060304B6 RID: 197814 RVA: 0x0069022C File Offset: 0x0068E42C
		public static IEntityLookAt GetRootAsIEntityLookAt(ByteBuffer _bb)
		{
			return IEntityLookAt.GetRootAsIEntityLookAt(_bb, default(IEntityLookAt));
		}

		// Token: 0x060304B7 RID: 197815 RVA: 0x00690248 File Offset: 0x0068E448
		public static IEntityLookAt GetRootAsIEntityLookAt(ByteBuffer _bb, IEntityLookAt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060304B8 RID: 197816 RVA: 0x00690265 File Offset: 0x0068E465
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060304B9 RID: 197817 RVA: 0x00690274 File Offset: 0x0068E474
		public IEntityLookAt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD58 RID: 52568
		// (get) Token: 0x060304BA RID: 197818 RVA: 0x00690284 File Offset: 0x0068E484
		public int EntityId
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

		// Token: 0x1700CD59 RID: 52569
		// (get) Token: 0x060304BB RID: 197819 RVA: 0x006902C0 File Offset: 0x0068E4C0
		public IVectorInfo? Pos
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

		// Token: 0x1700CD5A RID: 52570
		// (get) Token: 0x060304BC RID: 197820 RVA: 0x00690320 File Offset: 0x0068E520
		public bool CameraMove
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CD5B RID: 52571
		// (get) Token: 0x060304BD RID: 197821 RVA: 0x00690360 File Offset: 0x0068E560
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060304BE RID: 197822 RVA: 0x0069039D File Offset: 0x0068E59D
		public static Offset<IEntityLookAt> CreateIEntityLookAt(FlatBufferBuilder builder, int EntityId = 0, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), bool CameraMove = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IEntityLookAt.AddPos(builder, PosOffset);
			IEntityLookAt.AddEntityId(builder, EntityId);
			IEntityLookAt.AddNullMask(builder, NullMask);
			IEntityLookAt.AddCameraMove(builder, CameraMove);
			return IEntityLookAt.EndIEntityLookAt(builder);
		}

		// Token: 0x060304BF RID: 197823 RVA: 0x006903C9 File Offset: 0x0068E5C9
		public static void StartIEntityLookAt(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060304C0 RID: 197824 RVA: 0x006903D2 File Offset: 0x0068E5D2
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x060304C1 RID: 197825 RVA: 0x006903DD File Offset: 0x0068E5DD
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x060304C2 RID: 197826 RVA: 0x006903ED File Offset: 0x0068E5ED
		public static void AddCameraMove(FlatBufferBuilder builder, bool cameraMove)
		{
			builder.AddBool(2, cameraMove, false);
		}

		// Token: 0x060304C3 RID: 197827 RVA: 0x006903F8 File Offset: 0x0068E5F8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060304C4 RID: 197828 RVA: 0x00690403 File Offset: 0x0068E603
		public static Offset<IEntityLookAt> EndIEntityLookAt(FlatBufferBuilder builder)
		{
			return new Offset<IEntityLookAt>(builder.EndTable());
		}

		// Token: 0x060304C5 RID: 197829 RVA: 0x00690410 File Offset: 0x0068E610
		public IEntityLookAtT UnPack()
		{
			IEntityLookAtT entityLookAtT = new IEntityLookAtT();
			this.UnPackTo(entityLookAtT);
			return entityLookAtT;
		}

		// Token: 0x060304C6 RID: 197830 RVA: 0x0069042C File Offset: 0x0068E62C
		public void UnPackTo(IEntityLookAtT _o)
		{
			_o.EntityId = this.EntityId;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.CameraMove = this.CameraMove;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060304C7 RID: 197831 RVA: 0x0069048C File Offset: 0x0068E68C
		public static Offset<IEntityLookAt> Pack(FlatBufferBuilder builder, IEntityLookAtT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityLookAt>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			return IEntityLookAt.CreateIEntityLookAt(builder, _o.EntityId, posOffset, _o.CameraMove, _o.NullMask);
		}

		// Token: 0x04011BD7 RID: 72663
		private Table __p;
	}
}
