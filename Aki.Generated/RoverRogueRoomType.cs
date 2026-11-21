using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001184 RID: 4484
	public struct RoverRogueRoomType : IFlatbufferObject
	{
		// Token: 0x170035DC RID: 13788
		// (get) Token: 0x0600D722 RID: 55074 RVA: 0x00328CB8 File Offset: 0x00326EB8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D723 RID: 55075 RVA: 0x00328CC5 File Offset: 0x00326EC5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D724 RID: 55076 RVA: 0x00328CCC File Offset: 0x00326ECC
		public static RoverRogueRoomType GetRootAsRoverRogueRoomType(ByteBuffer _bb)
		{
			return RoverRogueRoomType.GetRootAsRoverRogueRoomType(_bb, default(RoverRogueRoomType));
		}

		// Token: 0x0600D725 RID: 55077 RVA: 0x00328CE8 File Offset: 0x00326EE8
		public static RoverRogueRoomType GetRootAsRoverRogueRoomType(ByteBuffer _bb, RoverRogueRoomType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D726 RID: 55078 RVA: 0x00328D05 File Offset: 0x00326F05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D727 RID: 55079 RVA: 0x00328D14 File Offset: 0x00326F14
		public RoverRogueRoomType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170035DD RID: 13789
		// (get) Token: 0x0600D728 RID: 55080 RVA: 0x00328D24 File Offset: 0x00326F24
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

		// Token: 0x170035DE RID: 13790
		// (get) Token: 0x0600D729 RID: 55081 RVA: 0x00328D60 File Offset: 0x00326F60
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

		// Token: 0x170035DF RID: 13791
		// (get) Token: 0x0600D72A RID: 55082 RVA: 0x00328D9C File Offset: 0x00326F9C
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

		// Token: 0x0600D72B RID: 55083 RVA: 0x00328DD3 File Offset: 0x00326FD3
		public Span<byte> GetRoomTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D72C RID: 55084 RVA: 0x00328DE2 File Offset: 0x00326FE2
		public byte[] GetRoomTypeArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170035E0 RID: 13792
		// (get) Token: 0x0600D72D RID: 55085 RVA: 0x00328DFC File Offset: 0x00326FFC
		public bool EnableRoomReward
		{
			get
			{
				int num = this.__p.__offset(10);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170035E1 RID: 13793
		// (get) Token: 0x0600D72E RID: 55086 RVA: 0x00328E3C File Offset: 0x0032703C
		public bool EnableLootChange
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170035E2 RID: 13794
		// (get) Token: 0x0600D72F RID: 55087 RVA: 0x00328E7C File Offset: 0x0032707C
		public bool EnableBlessGroupe
		{
			get
			{
				int num = this.__p.__offset(14);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170035E3 RID: 13795
		// (get) Token: 0x0600D730 RID: 55088 RVA: 0x00328EBC File Offset: 0x003270BC
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

		// Token: 0x0600D731 RID: 55089 RVA: 0x00328EF4 File Offset: 0x003270F4
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600D732 RID: 55090 RVA: 0x00328F04 File Offset: 0x00327104
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170035E4 RID: 13796
		// (get) Token: 0x0600D733 RID: 55091 RVA: 0x00328F1C File Offset: 0x0032711C
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

		// Token: 0x0600D734 RID: 55092 RVA: 0x00328F54 File Offset: 0x00327154
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600D735 RID: 55093 RVA: 0x00328F64 File Offset: 0x00327164
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170035E5 RID: 13797
		// (get) Token: 0x0600D736 RID: 55094 RVA: 0x00328F7C File Offset: 0x0032717C
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

		// Token: 0x0600D737 RID: 55095 RVA: 0x00328FB4 File Offset: 0x003271B4
		public Span<byte> GetMusicStateBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600D738 RID: 55096 RVA: 0x00328FC4 File Offset: 0x003271C4
		public byte[] GetMusicStateArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x04005795 RID: 22421
		private Table __p;
	}
}
