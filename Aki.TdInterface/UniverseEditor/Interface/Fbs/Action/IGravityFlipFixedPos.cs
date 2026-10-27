using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200689D RID: 26781
	public struct IGravityFlipFixedPos : IFlatbufferObject
	{
		// Token: 0x1700C6D3 RID: 50899
		// (get) Token: 0x0602EB56 RID: 191318 RVA: 0x0065E34F File Offset: 0x0065C54F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EB57 RID: 191319 RVA: 0x0065E35C File Offset: 0x0065C55C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EB58 RID: 191320 RVA: 0x0065E364 File Offset: 0x0065C564
		public static IGravityFlipFixedPos GetRootAsIGravityFlipFixedPos(ByteBuffer _bb)
		{
			return IGravityFlipFixedPos.GetRootAsIGravityFlipFixedPos(_bb, default(IGravityFlipFixedPos));
		}

		// Token: 0x0602EB59 RID: 191321 RVA: 0x0065E380 File Offset: 0x0065C580
		public static IGravityFlipFixedPos GetRootAsIGravityFlipFixedPos(ByteBuffer _bb, IGravityFlipFixedPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EB5A RID: 191322 RVA: 0x0065E39D File Offset: 0x0065C59D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EB5B RID: 191323 RVA: 0x0065E3AC File Offset: 0x0065C5AC
		public IGravityFlipFixedPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C6D4 RID: 50900
		// (get) Token: 0x0602EB5C RID: 191324 RVA: 0x0065E3BC File Offset: 0x0065C5BC
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

		// Token: 0x1700C6D5 RID: 50901
		// (get) Token: 0x0602EB5D RID: 191325 RVA: 0x0065E3F8 File Offset: 0x0065C5F8
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

		// Token: 0x0602EB5E RID: 191326 RVA: 0x0065E434 File Offset: 0x0065C634
		public static Offset<IGravityFlipFixedPos> CreateIGravityFlipFixedPos(FlatBufferBuilder builder, ETeleportType Type = ETeleportType.FixedPos, int GravityAndPosEntityId = 0)
		{
			builder.StartTable(2);
			IGravityFlipFixedPos.AddGravityAndPosEntityId(builder, GravityAndPosEntityId);
			IGravityFlipFixedPos.AddType(builder, Type);
			return IGravityFlipFixedPos.EndIGravityFlipFixedPos(builder);
		}

		// Token: 0x0602EB5F RID: 191327 RVA: 0x0065E451 File Offset: 0x0065C651
		public static void StartIGravityFlipFixedPos(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602EB60 RID: 191328 RVA: 0x0065E45A File Offset: 0x0065C65A
		public static void AddType(FlatBufferBuilder builder, ETeleportType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EB61 RID: 191329 RVA: 0x0065E465 File Offset: 0x0065C665
		public static void AddGravityAndPosEntityId(FlatBufferBuilder builder, int gravityAndPosEntityId)
		{
			builder.AddInt(1, gravityAndPosEntityId, 0);
		}

		// Token: 0x0602EB62 RID: 191330 RVA: 0x0065E470 File Offset: 0x0065C670
		public static Offset<IGravityFlipFixedPos> EndIGravityFlipFixedPos(FlatBufferBuilder builder)
		{
			return new Offset<IGravityFlipFixedPos>(builder.EndTable());
		}

		// Token: 0x0602EB63 RID: 191331 RVA: 0x0065E480 File Offset: 0x0065C680
		public IGravityFlipFixedPosT UnPack()
		{
			IGravityFlipFixedPosT gravityFlipFixedPosT = new IGravityFlipFixedPosT();
			this.UnPackTo(gravityFlipFixedPosT);
			return gravityFlipFixedPosT;
		}

		// Token: 0x0602EB64 RID: 191332 RVA: 0x0065E49B File Offset: 0x0065C69B
		public void UnPackTo(IGravityFlipFixedPosT _o)
		{
			_o.Type = this.Type;
			_o.GravityAndPosEntityId = this.GravityAndPosEntityId;
		}

		// Token: 0x0602EB65 RID: 191333 RVA: 0x0065E4B8 File Offset: 0x0065C6B8
		public static Offset<IGravityFlipFixedPos> Pack(FlatBufferBuilder builder, IGravityFlipFixedPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGravityFlipFixedPos>);
			}
			return IGravityFlipFixedPos.CreateIGravityFlipFixedPos(builder, _o.Type, _o.GravityAndPosEntityId);
		}

		// Token: 0x04010FED RID: 69613
		private Table __p;
	}
}
