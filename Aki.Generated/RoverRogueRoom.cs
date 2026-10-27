using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001087 RID: 4231
	public struct RoverRogueRoom : IFlatbufferObject
	{
		// Token: 0x170034C2 RID: 13506
		// (get) Token: 0x0600CF27 RID: 53031 RVA: 0x0030916C File Offset: 0x0030736C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CF28 RID: 53032 RVA: 0x00309179 File Offset: 0x00307379
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CF29 RID: 53033 RVA: 0x00309180 File Offset: 0x00307380
		public static RoverRogueRoom GetRootAsRoverRogueRoom(ByteBuffer _bb)
		{
			return RoverRogueRoom.GetRootAsRoverRogueRoom(_bb, default(RoverRogueRoom));
		}

		// Token: 0x0600CF2A RID: 53034 RVA: 0x0030919C File Offset: 0x0030739C
		public static RoverRogueRoom GetRootAsRoverRogueRoom(ByteBuffer _bb, RoverRogueRoom obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CF2B RID: 53035 RVA: 0x003091B9 File Offset: 0x003073B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CF2C RID: 53036 RVA: 0x003091C8 File Offset: 0x003073C8
		public RoverRogueRoom __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170034C3 RID: 13507
		// (get) Token: 0x0600CF2D RID: 53037 RVA: 0x003091D8 File Offset: 0x003073D8
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

		// Token: 0x170034C4 RID: 13508
		// (get) Token: 0x0600CF2E RID: 53038 RVA: 0x00309214 File Offset: 0x00307414
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

		// Token: 0x0600CF2F RID: 53039 RVA: 0x0030924B File Offset: 0x0030744B
		public Span<byte> GetRoomTypeIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CF30 RID: 53040 RVA: 0x0030925A File Offset: 0x0030745A
		public byte[] GetRoomTypeIdArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CF31 RID: 53041 RVA: 0x00309274 File Offset: 0x00307474
		public string SubLevels(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170034C5 RID: 13509
		// (get) Token: 0x0600CF32 RID: 53042 RVA: 0x003092B0 File Offset: 0x003074B0
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

		// Token: 0x170034C6 RID: 13510
		// (get) Token: 0x0600CF33 RID: 53043 RVA: 0x003092DC File Offset: 0x003074DC
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

		// Token: 0x170034C7 RID: 13511
		// (get) Token: 0x0600CF34 RID: 53044 RVA: 0x0030931C File Offset: 0x0030751C
		public bool EnableRepeat
		{
			get
			{
				int num = this.__p.__offset(12);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600CF35 RID: 53045 RVA: 0x0030935C File Offset: 0x0030755C
		public long RoleBuffList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x170034C8 RID: 13512
		// (get) Token: 0x0600CF36 RID: 53046 RVA: 0x003093A0 File Offset: 0x003075A0
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

		// Token: 0x0600CF37 RID: 53047 RVA: 0x003093CC File Offset: 0x003075CC
		public Span<long> GetRoleBuffListBytes()
		{
			return this.__p.__vector_as_span<long>(14, 8);
		}

		// Token: 0x0600CF38 RID: 53048 RVA: 0x003093DC File Offset: 0x003075DC
		public long[] GetRoleBuffListArray()
		{
			return this.__p.__vector_as_array<long>(14) ?? Array.Empty<long>();
		}

		// Token: 0x0600CF39 RID: 53049 RVA: 0x003093F4 File Offset: 0x003075F4
		public long EnemyBuffList(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x170034C9 RID: 13513
		// (get) Token: 0x0600CF3A RID: 53050 RVA: 0x00309438 File Offset: 0x00307638
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

		// Token: 0x0600CF3B RID: 53051 RVA: 0x00309464 File Offset: 0x00307664
		public Span<long> GetEnemyBuffListBytes()
		{
			return this.__p.__vector_as_span<long>(16, 8);
		}

		// Token: 0x0600CF3C RID: 53052 RVA: 0x00309474 File Offset: 0x00307674
		public long[] GetEnemyBuffListArray()
		{
			return this.__p.__vector_as_array<long>(16) ?? Array.Empty<long>();
		}

		// Token: 0x170034CA RID: 13514
		// (get) Token: 0x0600CF3D RID: 53053 RVA: 0x0030948C File Offset: 0x0030768C
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

		// Token: 0x0600CF3E RID: 53054 RVA: 0x003094C4 File Offset: 0x003076C4
		public Span<byte> GetMusicStateBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600CF3F RID: 53055 RVA: 0x003094D4 File Offset: 0x003076D4
		public byte[] GetMusicStateArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CF40 RID: 53056 RVA: 0x003094EC File Offset: 0x003076EC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EnemyBuffListIter()或GetEnemyBuffListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] EnemyBuffList()
		{
			RoverRogueRoom roverRogueRoom = this;
			return roverRogueRoom.GetEnemyBuffListArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600CF41 RID: 53057 RVA: 0x00309510 File Offset: 0x00307710
		[NullableContext(1)]
		public readonly IEnumerable<long> EnemyBuffListIter()
		{
			RoverRogueRoom.<EnemyBuffListIter>d__36 <EnemyBuffListIter>d__ = new RoverRogueRoom.<EnemyBuffListIter>d__36(-2);
			<EnemyBuffListIter>d__.<>3__<>4__this = this;
			return <EnemyBuffListIter>d__;
		}

		// Token: 0x0600CF42 RID: 53058 RVA: 0x00309528 File Offset: 0x00307728
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RoleBuffListIter()或GetRoleBuffListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] RoleBuffList()
		{
			RoverRogueRoom roverRogueRoom = this;
			return roverRogueRoom.GetRoleBuffListArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600CF43 RID: 53059 RVA: 0x0030954C File Offset: 0x0030774C
		[NullableContext(1)]
		public readonly IEnumerable<long> RoleBuffListIter()
		{
			RoverRogueRoom.<RoleBuffListIter>d__38 <RoleBuffListIter>d__ = new RoverRogueRoom.<RoleBuffListIter>d__38(-2);
			<RoleBuffListIter>d__.<>3__<>4__this = this;
			return <RoleBuffListIter>d__;
		}

		// Token: 0x0600CF44 RID: 53060 RVA: 0x00309561 File Offset: 0x00307761
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SubLevelsIter()或GetSubLevelsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] SubLevels()
		{
			return this.SubLevelsIter().ToArray<string>();
		}

		// Token: 0x0600CF45 RID: 53061 RVA: 0x0030956E File Offset: 0x0030776E
		[NullableContext(1)]
		public readonly IEnumerable<string> SubLevelsIter()
		{
			RoverRogueRoom.<SubLevelsIter>d__40 <SubLevelsIter>d__ = new RoverRogueRoom.<SubLevelsIter>d__40(-2);
			<SubLevelsIter>d__.<>3__<>4__this = this;
			return <SubLevelsIter>d__;
		}

		// Token: 0x04005194 RID: 20884
		private Table __p;
	}
}
