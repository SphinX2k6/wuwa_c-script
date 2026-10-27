using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005653 RID: 22099
	public struct INpcSpecialMarkIgnoreCameraHideNpc : IFlatbufferObject
	{
		// Token: 0x1700A3AC RID: 41900
		// (get) Token: 0x06024BC5 RID: 150469 RVA: 0x00511A5C File Offset: 0x0050FC5C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024BC6 RID: 150470 RVA: 0x00511A69 File Offset: 0x0050FC69
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024BC7 RID: 150471 RVA: 0x00511A70 File Offset: 0x0050FC70
		public static INpcSpecialMarkIgnoreCameraHideNpc GetRootAsINpcSpecialMarkIgnoreCameraHideNpc(ByteBuffer _bb)
		{
			return INpcSpecialMarkIgnoreCameraHideNpc.GetRootAsINpcSpecialMarkIgnoreCameraHideNpc(_bb, default(INpcSpecialMarkIgnoreCameraHideNpc));
		}

		// Token: 0x06024BC8 RID: 150472 RVA: 0x00511A8C File Offset: 0x0050FC8C
		public static INpcSpecialMarkIgnoreCameraHideNpc GetRootAsINpcSpecialMarkIgnoreCameraHideNpc(ByteBuffer _bb, INpcSpecialMarkIgnoreCameraHideNpc obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024BC9 RID: 150473 RVA: 0x00511AA9 File Offset: 0x0050FCA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024BCA RID: 150474 RVA: 0x00511AB8 File Offset: 0x0050FCB8
		public INpcSpecialMarkIgnoreCameraHideNpc __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A3AD RID: 41901
		// (get) Token: 0x06024BCB RID: 150475 RVA: 0x00511AC8 File Offset: 0x0050FCC8
		public ESpecialNpcMarkType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpecialNpcMarkType.TrafficLight;
				}
				return (ESpecialNpcMarkType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024BCC RID: 150476 RVA: 0x00511B04 File Offset: 0x0050FD04
		public static Offset<INpcSpecialMarkIgnoreCameraHideNpc> CreateINpcSpecialMarkIgnoreCameraHideNpc(FlatBufferBuilder builder, ESpecialNpcMarkType Type = ESpecialNpcMarkType.TrafficLight)
		{
			builder.StartTable(1);
			INpcSpecialMarkIgnoreCameraHideNpc.AddType(builder, Type);
			return INpcSpecialMarkIgnoreCameraHideNpc.EndINpcSpecialMarkIgnoreCameraHideNpc(builder);
		}

		// Token: 0x06024BCD RID: 150477 RVA: 0x00511B1A File Offset: 0x0050FD1A
		public static void StartINpcSpecialMarkIgnoreCameraHideNpc(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024BCE RID: 150478 RVA: 0x00511B23 File Offset: 0x0050FD23
		public static void AddType(FlatBufferBuilder builder, ESpecialNpcMarkType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024BCF RID: 150479 RVA: 0x00511B2E File Offset: 0x0050FD2E
		public static Offset<INpcSpecialMarkIgnoreCameraHideNpc> EndINpcSpecialMarkIgnoreCameraHideNpc(FlatBufferBuilder builder)
		{
			return new Offset<INpcSpecialMarkIgnoreCameraHideNpc>(builder.EndTable());
		}

		// Token: 0x06024BD0 RID: 150480 RVA: 0x00511B3C File Offset: 0x0050FD3C
		public INpcSpecialMarkIgnoreCameraHideNpcT UnPack()
		{
			INpcSpecialMarkIgnoreCameraHideNpcT npcSpecialMarkIgnoreCameraHideNpcT = new INpcSpecialMarkIgnoreCameraHideNpcT();
			this.UnPackTo(npcSpecialMarkIgnoreCameraHideNpcT);
			return npcSpecialMarkIgnoreCameraHideNpcT;
		}

		// Token: 0x06024BD1 RID: 150481 RVA: 0x00511B57 File Offset: 0x0050FD57
		public void UnPackTo(INpcSpecialMarkIgnoreCameraHideNpcT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06024BD2 RID: 150482 RVA: 0x00511B68 File Offset: 0x0050FD68
		public static Offset<INpcSpecialMarkIgnoreCameraHideNpc> Pack(FlatBufferBuilder builder, INpcSpecialMarkIgnoreCameraHideNpcT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcSpecialMarkIgnoreCameraHideNpc>);
			}
			return INpcSpecialMarkIgnoreCameraHideNpc.CreateINpcSpecialMarkIgnoreCameraHideNpc(builder, _o.Type);
		}

		// Token: 0x0400EA03 RID: 59907
		private Table __p;
	}
}
