using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F3E RID: 28478
	public struct IGravityFlipFixedPos : IFlatbufferObject
	{
		// Token: 0x1700D0B9 RID: 53433
		// (get) Token: 0x06031490 RID: 201872 RVA: 0x006AD3CF File Offset: 0x006AB5CF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031491 RID: 201873 RVA: 0x006AD3DC File Offset: 0x006AB5DC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031492 RID: 201874 RVA: 0x006AD3E4 File Offset: 0x006AB5E4
		public static IGravityFlipFixedPos GetRootAsIGravityFlipFixedPos(ByteBuffer _bb)
		{
			return IGravityFlipFixedPos.GetRootAsIGravityFlipFixedPos(_bb, default(IGravityFlipFixedPos));
		}

		// Token: 0x06031493 RID: 201875 RVA: 0x006AD400 File Offset: 0x006AB600
		public static IGravityFlipFixedPos GetRootAsIGravityFlipFixedPos(ByteBuffer _bb, IGravityFlipFixedPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031494 RID: 201876 RVA: 0x006AD41D File Offset: 0x006AB61D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031495 RID: 201877 RVA: 0x006AD42C File Offset: 0x006AB62C
		public IGravityFlipFixedPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D0BA RID: 53434
		// (get) Token: 0x06031496 RID: 201878 RVA: 0x006AD43C File Offset: 0x006AB63C
		public ETeleportType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeleportType.FixedPos;
				}
				return (ETeleportType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D0BB RID: 53435
		// (get) Token: 0x06031497 RID: 201879 RVA: 0x006AD478 File Offset: 0x006AB678
		public int GravityAndPosEntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031498 RID: 201880 RVA: 0x006AD4B4 File Offset: 0x006AB6B4
		public static Offset<IGravityFlipFixedPos> CreateIGravityFlipFixedPos(FlatBufferBuilder builder, ETeleportType Type = ETeleportType.FixedPos, int GravityAndPosEntityId = 0)
		{
			builder.StartTable(2);
			IGravityFlipFixedPos.AddGravityAndPosEntityId(builder, GravityAndPosEntityId);
			IGravityFlipFixedPos.AddType(builder, Type);
			return IGravityFlipFixedPos.EndIGravityFlipFixedPos(builder);
		}

		// Token: 0x06031499 RID: 201881 RVA: 0x006AD4D1 File Offset: 0x006AB6D1
		public static void StartIGravityFlipFixedPos(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603149A RID: 201882 RVA: 0x006AD4DA File Offset: 0x006AB6DA
		public static void AddType(FlatBufferBuilder builder, ETeleportType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603149B RID: 201883 RVA: 0x006AD4E5 File Offset: 0x006AB6E5
		public static void AddGravityAndPosEntityId(FlatBufferBuilder builder, int gravityAndPosEntityId)
		{
			builder.AddInt(1, gravityAndPosEntityId, 0);
		}

		// Token: 0x0603149C RID: 201884 RVA: 0x006AD4F0 File Offset: 0x006AB6F0
		public static Offset<IGravityFlipFixedPos> EndIGravityFlipFixedPos(FlatBufferBuilder builder)
		{
			return new Offset<IGravityFlipFixedPos>(builder.EndTable());
		}

		// Token: 0x0603149D RID: 201885 RVA: 0x006AD500 File Offset: 0x006AB700
		public IGravityFlipFixedPosT UnPack()
		{
			IGravityFlipFixedPosT gravityFlipFixedPosT = new IGravityFlipFixedPosT();
			this.UnPackTo(gravityFlipFixedPosT);
			return gravityFlipFixedPosT;
		}

		// Token: 0x0603149E RID: 201886 RVA: 0x006AD51B File Offset: 0x006AB71B
		public void UnPackTo(IGravityFlipFixedPosT _o)
		{
			_o.Type = this.Type;
			_o.GravityAndPosEntityId = this.GravityAndPosEntityId;
		}

		// Token: 0x0603149F RID: 201887 RVA: 0x006AD538 File Offset: 0x006AB738
		public static Offset<IGravityFlipFixedPos> Pack(FlatBufferBuilder builder, IGravityFlipFixedPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGravityFlipFixedPos>);
			}
			return IGravityFlipFixedPos.CreateIGravityFlipFixedPos(builder, _o.Type, _o.GravityAndPosEntityId);
		}

		// Token: 0x04011E42 RID: 73282
		private Table __p;
	}
}
