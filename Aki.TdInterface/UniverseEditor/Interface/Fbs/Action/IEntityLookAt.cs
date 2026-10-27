using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066DE RID: 26334
	public struct IEntityLookAt : IFlatbufferObject
	{
		// Token: 0x1700C3A1 RID: 50081
		// (get) Token: 0x0602DC77 RID: 187511 RVA: 0x00642CA2 File Offset: 0x00640EA2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DC78 RID: 187512 RVA: 0x00642CAF File Offset: 0x00640EAF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DC79 RID: 187513 RVA: 0x00642CB8 File Offset: 0x00640EB8
		public static IEntityLookAt GetRootAsIEntityLookAt(ByteBuffer _bb)
		{
			return IEntityLookAt.GetRootAsIEntityLookAt(_bb, default(IEntityLookAt));
		}

		// Token: 0x0602DC7A RID: 187514 RVA: 0x00642CD4 File Offset: 0x00640ED4
		public static IEntityLookAt GetRootAsIEntityLookAt(ByteBuffer _bb, IEntityLookAt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DC7B RID: 187515 RVA: 0x00642CF1 File Offset: 0x00640EF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DC7C RID: 187516 RVA: 0x00642D00 File Offset: 0x00640F00
		public IEntityLookAt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C3A2 RID: 50082
		// (get) Token: 0x0602DC7D RID: 187517 RVA: 0x00642D10 File Offset: 0x00640F10
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

		// Token: 0x1700C3A3 RID: 50083
		// (get) Token: 0x0602DC7E RID: 187518 RVA: 0x00642D4C File Offset: 0x00640F4C
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

		// Token: 0x1700C3A4 RID: 50084
		// (get) Token: 0x0602DC7F RID: 187519 RVA: 0x00642DAC File Offset: 0x00640FAC
		public bool CameraMove
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C3A5 RID: 50085
		// (get) Token: 0x0602DC80 RID: 187520 RVA: 0x00642DEC File Offset: 0x00640FEC
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

		// Token: 0x0602DC81 RID: 187521 RVA: 0x00642E29 File Offset: 0x00641029
		public static Offset<IEntityLookAt> CreateIEntityLookAt(FlatBufferBuilder builder, int EntityId = 0, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), bool CameraMove = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IEntityLookAt.AddPos(builder, PosOffset);
			IEntityLookAt.AddEntityId(builder, EntityId);
			IEntityLookAt.AddNullMask(builder, NullMask);
			IEntityLookAt.AddCameraMove(builder, CameraMove);
			return IEntityLookAt.EndIEntityLookAt(builder);
		}

		// Token: 0x0602DC82 RID: 187522 RVA: 0x00642E55 File Offset: 0x00641055
		public static void StartIEntityLookAt(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602DC83 RID: 187523 RVA: 0x00642E5E File Offset: 0x0064105E
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x0602DC84 RID: 187524 RVA: 0x00642E69 File Offset: 0x00641069
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x0602DC85 RID: 187525 RVA: 0x00642E79 File Offset: 0x00641079
		public static void AddCameraMove(FlatBufferBuilder builder, bool cameraMove)
		{
			builder.AddBool(2, cameraMove, false);
		}

		// Token: 0x0602DC86 RID: 187526 RVA: 0x00642E84 File Offset: 0x00641084
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602DC87 RID: 187527 RVA: 0x00642E8F File Offset: 0x0064108F
		public static Offset<IEntityLookAt> EndIEntityLookAt(FlatBufferBuilder builder)
		{
			return new Offset<IEntityLookAt>(builder.EndTable());
		}

		// Token: 0x0602DC88 RID: 187528 RVA: 0x00642E9C File Offset: 0x0064109C
		public IEntityLookAtT UnPack()
		{
			IEntityLookAtT entityLookAtT = new IEntityLookAtT();
			this.UnPackTo(entityLookAtT);
			return entityLookAtT;
		}

		// Token: 0x0602DC89 RID: 187529 RVA: 0x00642EB8 File Offset: 0x006410B8
		public void UnPackTo(IEntityLookAtT _o)
		{
			_o.EntityId = this.EntityId;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.CameraMove = this.CameraMove;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602DC8A RID: 187530 RVA: 0x00642F18 File Offset: 0x00641118
		public static Offset<IEntityLookAt> Pack(FlatBufferBuilder builder, IEntityLookAtT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityLookAt>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			return IEntityLookAt.CreateIEntityLookAt(builder, _o.EntityId, posOffset, _o.CameraMove, _o.NullMask);
		}

		// Token: 0x04010DA8 RID: 69032
		private Table __p;
	}
}
