using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006400 RID: 25600
	public struct IClientTpRelativeEntityPos : IFlatbufferObject
	{
		// Token: 0x1700BE9F RID: 48799
		// (get) Token: 0x0602C498 RID: 181400 RVA: 0x0061418D File Offset: 0x0061238D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C499 RID: 181401 RVA: 0x0061419A File Offset: 0x0061239A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C49A RID: 181402 RVA: 0x006141A4 File Offset: 0x006123A4
		public static IClientTpRelativeEntityPos GetRootAsIClientTpRelativeEntityPos(ByteBuffer _bb)
		{
			return IClientTpRelativeEntityPos.GetRootAsIClientTpRelativeEntityPos(_bb, default(IClientTpRelativeEntityPos));
		}

		// Token: 0x0602C49B RID: 181403 RVA: 0x006141C0 File Offset: 0x006123C0
		public static IClientTpRelativeEntityPos GetRootAsIClientTpRelativeEntityPos(ByteBuffer _bb, IClientTpRelativeEntityPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C49C RID: 181404 RVA: 0x006141DD File Offset: 0x006123DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C49D RID: 181405 RVA: 0x006141EC File Offset: 0x006123EC
		public IClientTpRelativeEntityPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BEA0 RID: 48800
		// (get) Token: 0x0602C49E RID: 181406 RVA: 0x006141FC File Offset: 0x006123FC
		public EClientTeleportType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientTeleportType.RelativeEntityPos;
				}
				return (EClientTeleportType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BEA1 RID: 48801
		// (get) Token: 0x0602C49F RID: 181407 RVA: 0x00614238 File Offset: 0x00612438
		public int SourcePosEntityId
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

		// Token: 0x1700BEA2 RID: 48802
		// (get) Token: 0x0602C4A0 RID: 181408 RVA: 0x00614274 File Offset: 0x00612474
		public int TargetPosEntityId
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

		// Token: 0x0602C4A1 RID: 181409 RVA: 0x006142B0 File Offset: 0x006124B0
		public static Offset<IClientTpRelativeEntityPos> CreateIClientTpRelativeEntityPos(FlatBufferBuilder builder, EClientTeleportType Type = EClientTeleportType.RelativeEntityPos, int SourcePosEntityId = 0, int TargetPosEntityId = 0)
		{
			builder.StartTable(3);
			IClientTpRelativeEntityPos.AddTargetPosEntityId(builder, TargetPosEntityId);
			IClientTpRelativeEntityPos.AddSourcePosEntityId(builder, SourcePosEntityId);
			IClientTpRelativeEntityPos.AddType(builder, Type);
			return IClientTpRelativeEntityPos.EndIClientTpRelativeEntityPos(builder);
		}

		// Token: 0x0602C4A2 RID: 181410 RVA: 0x006142D4 File Offset: 0x006124D4
		public static void StartIClientTpRelativeEntityPos(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602C4A3 RID: 181411 RVA: 0x006142DD File Offset: 0x006124DD
		public static void AddType(FlatBufferBuilder builder, EClientTeleportType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C4A4 RID: 181412 RVA: 0x006142E8 File Offset: 0x006124E8
		public static void AddSourcePosEntityId(FlatBufferBuilder builder, int sourcePosEntityId)
		{
			builder.AddInt(1, sourcePosEntityId, 0);
		}

		// Token: 0x0602C4A5 RID: 181413 RVA: 0x006142F3 File Offset: 0x006124F3
		public static void AddTargetPosEntityId(FlatBufferBuilder builder, int targetPosEntityId)
		{
			builder.AddInt(2, targetPosEntityId, 0);
		}

		// Token: 0x0602C4A6 RID: 181414 RVA: 0x006142FE File Offset: 0x006124FE
		public static Offset<IClientTpRelativeEntityPos> EndIClientTpRelativeEntityPos(FlatBufferBuilder builder)
		{
			return new Offset<IClientTpRelativeEntityPos>(builder.EndTable());
		}

		// Token: 0x0602C4A7 RID: 181415 RVA: 0x0061430C File Offset: 0x0061250C
		public IClientTpRelativeEntityPosT UnPack()
		{
			IClientTpRelativeEntityPosT clientTpRelativeEntityPosT = new IClientTpRelativeEntityPosT();
			this.UnPackTo(clientTpRelativeEntityPosT);
			return clientTpRelativeEntityPosT;
		}

		// Token: 0x0602C4A8 RID: 181416 RVA: 0x00614327 File Offset: 0x00612527
		public void UnPackTo(IClientTpRelativeEntityPosT _o)
		{
			_o.Type = this.Type;
			_o.SourcePosEntityId = this.SourcePosEntityId;
			_o.TargetPosEntityId = this.TargetPosEntityId;
		}

		// Token: 0x0602C4A9 RID: 181417 RVA: 0x00614350 File Offset: 0x00612550
		public static Offset<IClientTpRelativeEntityPos> Pack(FlatBufferBuilder builder, IClientTpRelativeEntityPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientTpRelativeEntityPos>);
			}
			return IClientTpRelativeEntityPos.CreateIClientTpRelativeEntityPos(builder, _o.Type, _o.SourcePosEntityId, _o.TargetPosEntityId);
		}

		// Token: 0x040109EC RID: 68076
		private Table __p;
	}
}
