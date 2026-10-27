using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001084 RID: 4228
	public struct RoverRogueRole : IFlatbufferObject
	{
		// Token: 0x170034A1 RID: 13473
		// (get) Token: 0x0600CEC4 RID: 52932 RVA: 0x003083BC File Offset: 0x003065BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CEC5 RID: 52933 RVA: 0x003083C9 File Offset: 0x003065C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CEC6 RID: 52934 RVA: 0x003083D0 File Offset: 0x003065D0
		public static RoverRogueRole GetRootAsRoverRogueRole(ByteBuffer _bb)
		{
			return RoverRogueRole.GetRootAsRoverRogueRole(_bb, default(RoverRogueRole));
		}

		// Token: 0x0600CEC7 RID: 52935 RVA: 0x003083EC File Offset: 0x003065EC
		public static RoverRogueRole GetRootAsRoverRogueRole(ByteBuffer _bb, RoverRogueRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CEC8 RID: 52936 RVA: 0x00308409 File Offset: 0x00306609
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CEC9 RID: 52937 RVA: 0x00308418 File Offset: 0x00306618
		public RoverRogueRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170034A2 RID: 13474
		// (get) Token: 0x0600CECA RID: 52938 RVA: 0x00308428 File Offset: 0x00306628
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

		// Token: 0x170034A3 RID: 13475
		// (get) Token: 0x0600CECB RID: 52939 RVA: 0x00308464 File Offset: 0x00306664
		public int ActivityId
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

		// Token: 0x170034A4 RID: 13476
		// (get) Token: 0x0600CECC RID: 52940 RVA: 0x003084A0 File Offset: 0x003066A0
		public string RoleIcon
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

		// Token: 0x0600CECD RID: 52941 RVA: 0x003084D7 File Offset: 0x003066D7
		public Span<byte> GetRoleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600CECE RID: 52942 RVA: 0x003084E6 File Offset: 0x003066E6
		public byte[] GetRoleIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170034A5 RID: 13477
		// (get) Token: 0x0600CECF RID: 52943 RVA: 0x00308500 File Offset: 0x00306700
		public string Stand
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CED0 RID: 52944 RVA: 0x00308538 File Offset: 0x00306738
		public Span<byte> GetStandBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600CED1 RID: 52945 RVA: 0x00308548 File Offset: 0x00306748
		public byte[] GetStandArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CED2 RID: 52946 RVA: 0x00308560 File Offset: 0x00306760
		public string Stands(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170034A6 RID: 13478
		// (get) Token: 0x0600CED3 RID: 52947 RVA: 0x0030859C File Offset: 0x0030679C
		public int StandsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170034A7 RID: 13479
		// (get) Token: 0x0600CED4 RID: 52948 RVA: 0x003085C8 File Offset: 0x003067C8
		public int RoleSkinId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CED5 RID: 52949 RVA: 0x00308605 File Offset: 0x00306805
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用StandsIter()或GetStandsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Stands()
		{
			return this.StandsIter().ToArray<string>();
		}

		// Token: 0x0600CED6 RID: 52950 RVA: 0x00308612 File Offset: 0x00306812
		[NullableContext(1)]
		public readonly IEnumerable<string> StandsIter()
		{
			RoverRogueRole.<StandsIter>d__26 <StandsIter>d__ = new RoverRogueRole.<StandsIter>d__26(-2);
			<StandsIter>d__.<>3__<>4__this = this;
			return <StandsIter>d__;
		}

		// Token: 0x04005190 RID: 20880
		private Table __p;
	}
}
