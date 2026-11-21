using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001182 RID: 4482
	public struct RoverRogueRoom : IFlatbufferObject
	{
		// Token: 0x170035CF RID: 13775
		// (get) Token: 0x0600D6FA RID: 55034 RVA: 0x003287BC File Offset: 0x003269BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D6FB RID: 55035 RVA: 0x003287C9 File Offset: 0x003269C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D6FC RID: 55036 RVA: 0x003287D0 File Offset: 0x003269D0
		public static RoverRogueRoom GetRootAsRoverRogueRoom(ByteBuffer _bb)
		{
			return RoverRogueRoom.GetRootAsRoverRogueRoom(_bb, default(RoverRogueRoom));
		}

		// Token: 0x0600D6FD RID: 55037 RVA: 0x003287EC File Offset: 0x003269EC
		public static RoverRogueRoom GetRootAsRoverRogueRoom(ByteBuffer _bb, RoverRogueRoom obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D6FE RID: 55038 RVA: 0x00328809 File Offset: 0x00326A09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D6FF RID: 55039 RVA: 0x00328818 File Offset: 0x00326A18
		public RoverRogueRoom __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170035D0 RID: 13776
		// (get) Token: 0x0600D700 RID: 55040 RVA: 0x00328828 File Offset: 0x00326A28
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

		// Token: 0x170035D1 RID: 13777
		// (get) Token: 0x0600D701 RID: 55041 RVA: 0x00328864 File Offset: 0x00326A64
		public string RoomTypeId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D702 RID: 55042 RVA: 0x0032889B File Offset: 0x00326A9B
		public Span<byte> GetRoomTypeIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D703 RID: 55043 RVA: 0x003288AA File Offset: 0x00326AAA
		public byte[] GetRoomTypeIdArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D704 RID: 55044 RVA: 0x003288C4 File Offset: 0x00326AC4
		public string SubLevels(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170035D2 RID: 13778
		// (get) Token: 0x0600D705 RID: 55045 RVA: 0x00328900 File Offset: 0x00326B00
		public int SubLevelsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170035D3 RID: 13779
		// (get) Token: 0x0600D706 RID: 55046 RVA: 0x0032892C File Offset: 0x00326B2C
		public int BornEntityId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170035D4 RID: 13780
		// (get) Token: 0x0600D707 RID: 55047 RVA: 0x0032896C File Offset: 0x00326B6C
		public bool EnableRepeat
		{
			get
			{
				int num = this.__p.__offset(12);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600D708 RID: 55048 RVA: 0x003289AC File Offset: 0x00326BAC
		public long RoleBuffList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x170035D5 RID: 13781
		// (get) Token: 0x0600D709 RID: 55049 RVA: 0x003289F0 File Offset: 0x00326BF0
		public int RoleBuffListLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D70A RID: 55050 RVA: 0x00328A1C File Offset: 0x00326C1C
		public Span<long> GetRoleBuffListBytes()
		{
			return this.__p.__vector_as_span<long>(14, 8);
		}

		// Token: 0x0600D70B RID: 55051 RVA: 0x00328A2C File Offset: 0x00326C2C
		public long[] GetRoleBuffListArray()
		{
			return this.__p.__vector_as_array<long>(14) ?? Array.Empty<long>();
		}

		// Token: 0x0600D70C RID: 55052 RVA: 0x00328A44 File Offset: 0x00326C44
		public long EnemyBuffList(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x170035D6 RID: 13782
		// (get) Token: 0x0600D70D RID: 55053 RVA: 0x00328A88 File Offset: 0x00326C88
		public int EnemyBuffListLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D70E RID: 55054 RVA: 0x00328AB4 File Offset: 0x00326CB4
		public Span<long> GetEnemyBuffListBytes()
		{
			return this.__p.__vector_as_span<long>(16, 8);
		}

		// Token: 0x0600D70F RID: 55055 RVA: 0x00328AC4 File Offset: 0x00326CC4
		public long[] GetEnemyBuffListArray()
		{
			return this.__p.__vector_as_array<long>(16) ?? Array.Empty<long>();
		}

		// Token: 0x170035D7 RID: 13783
		// (get) Token: 0x0600D710 RID: 55056 RVA: 0x00328ADC File Offset: 0x00326CDC
		public string MusicState
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

		// Token: 0x0600D711 RID: 55057 RVA: 0x00328B14 File Offset: 0x00326D14
		public Span<byte> GetMusicStateBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600D712 RID: 55058 RVA: 0x00328B24 File Offset: 0x00326D24
		public byte[] GetMusicStateArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D713 RID: 55059 RVA: 0x00328B3C File Offset: 0x00326D3C
		[NullableContext(1)]
		public long[] EnemyBuffList()
		{
			return this.GetEnemyBuffListArray();
		}

		// Token: 0x0600D714 RID: 55060 RVA: 0x00328B44 File Offset: 0x00326D44
		[NullableContext(1)]
		public IEnumerable<long> EnemyBuffListIter()
		{
			RoverRogueRoom.<EnemyBuffListIter>d__36 <EnemyBuffListIter>d__ = new RoverRogueRoom.<EnemyBuffListIter>d__36(-2);
			<EnemyBuffListIter>d__.<>3__<>4__this = this;
			return <EnemyBuffListIter>d__;
		}

		// Token: 0x0600D715 RID: 55061 RVA: 0x00328B59 File Offset: 0x00326D59
		[NullableContext(1)]
		public long[] RoleBuffList()
		{
			return this.GetRoleBuffListArray();
		}

		// Token: 0x0600D716 RID: 55062 RVA: 0x00328B61 File Offset: 0x00326D61
		[NullableContext(1)]
		public IEnumerable<long> RoleBuffListIter()
		{
			RoverRogueRoom.<RoleBuffListIter>d__38 <RoleBuffListIter>d__ = new RoverRogueRoom.<RoleBuffListIter>d__38(-2);
			<RoleBuffListIter>d__.<>3__<>4__this = this;
			return <RoleBuffListIter>d__;
		}

		// Token: 0x0600D717 RID: 55063 RVA: 0x00328B76 File Offset: 0x00326D76
		[NullableContext(1)]
		public string[] SubLevels()
		{
			return this.SubLevelsIter().ToArray<string>();
		}

		// Token: 0x0600D718 RID: 55064 RVA: 0x00328B83 File Offset: 0x00326D83
		[NullableContext(1)]
		public IEnumerable<string> SubLevelsIter()
		{
			RoverRogueRoom.<SubLevelsIter>d__40 <SubLevelsIter>d__ = new RoverRogueRoom.<SubLevelsIter>d__40(-2);
			<SubLevelsIter>d__.<>3__<>4__this = this;
			return <SubLevelsIter>d__;
		}

		// Token: 0x04005793 RID: 22419
		private Table __p;
	}
}
