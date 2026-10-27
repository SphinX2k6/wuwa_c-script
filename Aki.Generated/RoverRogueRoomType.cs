using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001089 RID: 4233
	public struct RoverRogueRoomType : IFlatbufferObject
	{
		// Token: 0x170034CF RID: 13519
		// (get) Token: 0x0600CF4F RID: 53071 RVA: 0x003096A4 File Offset: 0x003078A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CF50 RID: 53072 RVA: 0x003096B1 File Offset: 0x003078B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CF51 RID: 53073 RVA: 0x003096B8 File Offset: 0x003078B8
		public static RoverRogueRoomType GetRootAsRoverRogueRoomType(ByteBuffer _bb)
		{
			return RoverRogueRoomType.GetRootAsRoverRogueRoomType(_bb, default(RoverRogueRoomType));
		}

		// Token: 0x0600CF52 RID: 53074 RVA: 0x003096D4 File Offset: 0x003078D4
		public static RoverRogueRoomType GetRootAsRoverRogueRoomType(ByteBuffer _bb, RoverRogueRoomType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CF53 RID: 53075 RVA: 0x003096F1 File Offset: 0x003078F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CF54 RID: 53076 RVA: 0x00309700 File Offset: 0x00307900
		public RoverRogueRoomType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170034D0 RID: 13520
		// (get) Token: 0x0600CF55 RID: 53077 RVA: 0x00309710 File Offset: 0x00307910
		public int Id
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

		// Token: 0x170034D1 RID: 13521
		// (get) Token: 0x0600CF56 RID: 53078 RVA: 0x0030974C File Offset: 0x0030794C
		public int EnterEntityId
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

		// Token: 0x170034D2 RID: 13522
		// (get) Token: 0x0600CF57 RID: 53079 RVA: 0x00309788 File Offset: 0x00307988
		public string RoomType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CF58 RID: 53080 RVA: 0x003097BF File Offset: 0x003079BF
		public Span<byte> GetRoomTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600CF59 RID: 53081 RVA: 0x003097CE File Offset: 0x003079CE
		public byte[] GetRoomTypeArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170034D3 RID: 13523
		// (get) Token: 0x0600CF5A RID: 53082 RVA: 0x003097E8 File Offset: 0x003079E8
		public bool EnableRoomReward
		{
			get
			{
				int num = this.__p.__offset(10);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170034D4 RID: 13524
		// (get) Token: 0x0600CF5B RID: 53083 RVA: 0x00309828 File Offset: 0x00307A28
		public bool EnableLootChange
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170034D5 RID: 13525
		// (get) Token: 0x0600CF5C RID: 53084 RVA: 0x00309868 File Offset: 0x00307A68
		public bool EnableBlessGroupe
		{
			get
			{
				int num = this.__p.__offset(14);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170034D6 RID: 13526
		// (get) Token: 0x0600CF5D RID: 53085 RVA: 0x003098A8 File Offset: 0x00307AA8
		public string Name
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CF5E RID: 53086 RVA: 0x003098E0 File Offset: 0x00307AE0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600CF5F RID: 53087 RVA: 0x003098F0 File Offset: 0x00307AF0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170034D7 RID: 13527
		// (get) Token: 0x0600CF60 RID: 53088 RVA: 0x00309908 File Offset: 0x00307B08
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CF61 RID: 53089 RVA: 0x00309940 File Offset: 0x00307B40
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600CF62 RID: 53090 RVA: 0x00309950 File Offset: 0x00307B50
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170034D8 RID: 13528
		// (get) Token: 0x0600CF63 RID: 53091 RVA: 0x00309968 File Offset: 0x00307B68
		public string MusicState
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CF64 RID: 53092 RVA: 0x003099A0 File Offset: 0x00307BA0
		public Span<byte> GetMusicStateBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600CF65 RID: 53093 RVA: 0x003099B0 File Offset: 0x00307BB0
		public byte[] GetMusicStateArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x04005196 RID: 20886
		private Table __p;
	}
}
