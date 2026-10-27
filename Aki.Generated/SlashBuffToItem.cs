using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010CF RID: 4303
	public struct SlashBuffToItem : IFlatbufferObject
	{
		// Token: 0x17003753 RID: 14163
		// (get) Token: 0x0600D6A7 RID: 54951 RVA: 0x0031B344 File Offset: 0x00319544
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D6A8 RID: 54952 RVA: 0x0031B351 File Offset: 0x00319551
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D6A9 RID: 54953 RVA: 0x0031B358 File Offset: 0x00319558
		public static SlashBuffToItem GetRootAsSlashBuffToItem(ByteBuffer _bb)
		{
			return SlashBuffToItem.GetRootAsSlashBuffToItem(_bb, default(SlashBuffToItem));
		}

		// Token: 0x0600D6AA RID: 54954 RVA: 0x0031B374 File Offset: 0x00319574
		public static SlashBuffToItem GetRootAsSlashBuffToItem(ByteBuffer _bb, SlashBuffToItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D6AB RID: 54955 RVA: 0x0031B391 File Offset: 0x00319591
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D6AC RID: 54956 RVA: 0x0031B3A0 File Offset: 0x003195A0
		public SlashBuffToItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003754 RID: 14164
		// (get) Token: 0x0600D6AD RID: 54957 RVA: 0x0031B3B0 File Offset: 0x003195B0
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

		// Token: 0x17003755 RID: 14165
		// (get) Token: 0x0600D6AE RID: 54958 RVA: 0x0031B3EC File Offset: 0x003195EC
		public int Season
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

		// Token: 0x17003756 RID: 14166
		// (get) Token: 0x0600D6AF RID: 54959 RVA: 0x0031B428 File Offset: 0x00319628
		public int ItemId
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

		// Token: 0x17003757 RID: 14167
		// (get) Token: 0x0600D6B0 RID: 54960 RVA: 0x0031B464 File Offset: 0x00319664
		public int Tips
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

		// Token: 0x17003758 RID: 14168
		// (get) Token: 0x0600D6B1 RID: 54961 RVA: 0x0031B4A4 File Offset: 0x003196A4
		public int StartSeason
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003759 RID: 14169
		// (get) Token: 0x0600D6B2 RID: 54962 RVA: 0x0031B4E4 File Offset: 0x003196E4
		public int EndSeason
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700375A RID: 14170
		// (get) Token: 0x0600D6B3 RID: 54963 RVA: 0x0031B524 File Offset: 0x00319724
		public bool Unlimited
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600D6B4 RID: 54964 RVA: 0x0031B564 File Offset: 0x00319764
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x1700375B RID: 14171
		// (get) Token: 0x0600D6B5 RID: 54965 RVA: 0x0031B5A8 File Offset: 0x003197A8
		public int BuffIdsLength
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

		// Token: 0x0600D6B6 RID: 54966 RVA: 0x0031B5D4 File Offset: 0x003197D4
		public Span<long> GetBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(18, 8);
		}

		// Token: 0x0600D6B7 RID: 54967 RVA: 0x0031B5E4 File Offset: 0x003197E4
		public long[] GetBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(18) ?? Array.Empty<long>();
		}

		// Token: 0x1700375C RID: 14172
		// (get) Token: 0x0600D6B8 RID: 54968 RVA: 0x0031B5FC File Offset: 0x003197FC
		public int BuffTime
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D6B9 RID: 54969 RVA: 0x0031B63C File Offset: 0x0031983C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffIdsIter()或GetBuffIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] BuffIds()
		{
			SlashBuffToItem slashBuffToItem = this;
			return slashBuffToItem.GetBuffIdsArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600D6BA RID: 54970 RVA: 0x0031B660 File Offset: 0x00319860
		[NullableContext(1)]
		public readonly IEnumerable<long> BuffIdsIter()
		{
			SlashBuffToItem.<BuffIdsIter>d__30 <BuffIdsIter>d__ = new SlashBuffToItem.<BuffIdsIter>d__30(-2);
			<BuffIdsIter>d__.<>3__<>4__this = this;
			return <BuffIdsIter>d__;
		}

		// Token: 0x04005201 RID: 20993
		private Table __p;
	}
}
