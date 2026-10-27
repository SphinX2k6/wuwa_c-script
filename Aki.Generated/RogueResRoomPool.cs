using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001010 RID: 4112
	public struct RogueResRoomPool : IFlatbufferObject
	{
		// Token: 0x170030B3 RID: 12467
		// (get) Token: 0x0600C3B1 RID: 50097 RVA: 0x002EF3D4 File Offset: 0x002ED5D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C3B2 RID: 50098 RVA: 0x002EF3E1 File Offset: 0x002ED5E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C3B3 RID: 50099 RVA: 0x002EF3E8 File Offset: 0x002ED5E8
		public static RogueResRoomPool GetRootAsRogueResRoomPool(ByteBuffer _bb)
		{
			return RogueResRoomPool.GetRootAsRogueResRoomPool(_bb, default(RogueResRoomPool));
		}

		// Token: 0x0600C3B4 RID: 50100 RVA: 0x002EF404 File Offset: 0x002ED604
		public static RogueResRoomPool GetRootAsRogueResRoomPool(ByteBuffer _bb, RogueResRoomPool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C3B5 RID: 50101 RVA: 0x002EF421 File Offset: 0x002ED621
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C3B6 RID: 50102 RVA: 0x002EF430 File Offset: 0x002ED630
		public RogueResRoomPool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170030B4 RID: 12468
		// (get) Token: 0x0600C3B7 RID: 50103 RVA: 0x002EF440 File Offset: 0x002ED640
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

		// Token: 0x170030B5 RID: 12469
		// (get) Token: 0x0600C3B8 RID: 50104 RVA: 0x002EF47C File Offset: 0x002ED67C
		public int BehaviorTree
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

		// Token: 0x170030B6 RID: 12470
		// (get) Token: 0x0600C3B9 RID: 50105 RVA: 0x002EF4B8 File Offset: 0x002ED6B8
		public string RoomsMusicState
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

		// Token: 0x0600C3BA RID: 50106 RVA: 0x002EF4EF File Offset: 0x002ED6EF
		public Span<byte> GetRoomsMusicStateBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C3BB RID: 50107 RVA: 0x002EF4FE File Offset: 0x002ED6FE
		public byte[] GetRoomsMusicStateArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C3BC RID: 50108 RVA: 0x002EF518 File Offset: 0x002ED718
		public string MonsterDesc(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170030B7 RID: 12471
		// (get) Token: 0x0600C3BD RID: 50109 RVA: 0x002EF554 File Offset: 0x002ED754
		public int MonsterDescLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C3BE RID: 50110 RVA: 0x002EF580 File Offset: 0x002ED780
		public string MonsterDescParams(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170030B8 RID: 12472
		// (get) Token: 0x0600C3BF RID: 50111 RVA: 0x002EF5BC File Offset: 0x002ED7BC
		public int MonsterDescParamsLength
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

		// Token: 0x0600C3C0 RID: 50112 RVA: 0x002EF5E8 File Offset: 0x002ED7E8
		public string MonsterFig(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170030B9 RID: 12473
		// (get) Token: 0x0600C3C1 RID: 50113 RVA: 0x002EF624 File Offset: 0x002ED824
		public int MonsterFigLength
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

		// Token: 0x0600C3C2 RID: 50114 RVA: 0x002EF650 File Offset: 0x002ED850
		public string EnvDesc(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170030BA RID: 12474
		// (get) Token: 0x0600C3C3 RID: 50115 RVA: 0x002EF68C File Offset: 0x002ED88C
		public int EnvDescLength
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

		// Token: 0x0600C3C4 RID: 50116 RVA: 0x002EF6B8 File Offset: 0x002ED8B8
		public string EnvFig(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170030BB RID: 12475
		// (get) Token: 0x0600C3C5 RID: 50117 RVA: 0x002EF6F4 File Offset: 0x002ED8F4
		public int EnvFigLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C3C6 RID: 50118 RVA: 0x002EF720 File Offset: 0x002ED920
		public string EnvDescParams(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170030BC RID: 12476
		// (get) Token: 0x0600C3C7 RID: 50119 RVA: 0x002EF75C File Offset: 0x002ED95C
		public int EnvDescParamsLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C3C8 RID: 50120 RVA: 0x002EF788 File Offset: 0x002ED988
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EnvDescIter()或GetEnvDescBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] EnvDesc()
		{
			return this.EnvDescIter().ToArray<string>();
		}

		// Token: 0x0600C3C9 RID: 50121 RVA: 0x002EF795 File Offset: 0x002ED995
		[NullableContext(1)]
		public readonly IEnumerable<string> EnvDescIter()
		{
			RogueResRoomPool.<EnvDescIter>d__35 <EnvDescIter>d__ = new RogueResRoomPool.<EnvDescIter>d__35(-2);
			<EnvDescIter>d__.<>3__<>4__this = this;
			return <EnvDescIter>d__;
		}

		// Token: 0x0600C3CA RID: 50122 RVA: 0x002EF7AA File Offset: 0x002ED9AA
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EnvDescParamsIter()或GetEnvDescParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] EnvDescParams()
		{
			return this.EnvDescParamsIter().ToArray<string>();
		}

		// Token: 0x0600C3CB RID: 50123 RVA: 0x002EF7B7 File Offset: 0x002ED9B7
		[NullableContext(1)]
		public readonly IEnumerable<string> EnvDescParamsIter()
		{
			RogueResRoomPool.<EnvDescParamsIter>d__37 <EnvDescParamsIter>d__ = new RogueResRoomPool.<EnvDescParamsIter>d__37(-2);
			<EnvDescParamsIter>d__.<>3__<>4__this = this;
			return <EnvDescParamsIter>d__;
		}

		// Token: 0x0600C3CC RID: 50124 RVA: 0x002EF7CC File Offset: 0x002ED9CC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EnvFigIter()或GetEnvFigBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] EnvFig()
		{
			return this.EnvFigIter().ToArray<string>();
		}

		// Token: 0x0600C3CD RID: 50125 RVA: 0x002EF7D9 File Offset: 0x002ED9D9
		[NullableContext(1)]
		public readonly IEnumerable<string> EnvFigIter()
		{
			RogueResRoomPool.<EnvFigIter>d__39 <EnvFigIter>d__ = new RogueResRoomPool.<EnvFigIter>d__39(-2);
			<EnvFigIter>d__.<>3__<>4__this = this;
			return <EnvFigIter>d__;
		}

		// Token: 0x0600C3CE RID: 50126 RVA: 0x002EF7EE File Offset: 0x002ED9EE
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MonsterDescIter()或GetMonsterDescBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] MonsterDesc()
		{
			return this.MonsterDescIter().ToArray<string>();
		}

		// Token: 0x0600C3CF RID: 50127 RVA: 0x002EF7FB File Offset: 0x002ED9FB
		[NullableContext(1)]
		public readonly IEnumerable<string> MonsterDescIter()
		{
			RogueResRoomPool.<MonsterDescIter>d__41 <MonsterDescIter>d__ = new RogueResRoomPool.<MonsterDescIter>d__41(-2);
			<MonsterDescIter>d__.<>3__<>4__this = this;
			return <MonsterDescIter>d__;
		}

		// Token: 0x0600C3D0 RID: 50128 RVA: 0x002EF810 File Offset: 0x002EDA10
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MonsterDescParamsIter()或GetMonsterDescParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] MonsterDescParams()
		{
			return this.MonsterDescParamsIter().ToArray<string>();
		}

		// Token: 0x0600C3D1 RID: 50129 RVA: 0x002EF81D File Offset: 0x002EDA1D
		[NullableContext(1)]
		public readonly IEnumerable<string> MonsterDescParamsIter()
		{
			RogueResRoomPool.<MonsterDescParamsIter>d__43 <MonsterDescParamsIter>d__ = new RogueResRoomPool.<MonsterDescParamsIter>d__43(-2);
			<MonsterDescParamsIter>d__.<>3__<>4__this = this;
			return <MonsterDescParamsIter>d__;
		}

		// Token: 0x0600C3D2 RID: 50130 RVA: 0x002EF832 File Offset: 0x002EDA32
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MonsterFigIter()或GetMonsterFigBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] MonsterFig()
		{
			return this.MonsterFigIter().ToArray<string>();
		}

		// Token: 0x0600C3D3 RID: 50131 RVA: 0x002EF83F File Offset: 0x002EDA3F
		[NullableContext(1)]
		public readonly IEnumerable<string> MonsterFigIter()
		{
			RogueResRoomPool.<MonsterFigIter>d__45 <MonsterFigIter>d__ = new RogueResRoomPool.<MonsterFigIter>d__45(-2);
			<MonsterFigIter>d__.<>3__<>4__this = this;
			return <MonsterFigIter>d__;
		}

		// Token: 0x040050FD RID: 20733
		private Table __p;
	}
}
