using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200121F RID: 4639
	public struct SpringFestivalReward : IFlatbufferObject
	{
		// Token: 0x17003B7C RID: 15228
		// (get) Token: 0x0600E611 RID: 58897 RVA: 0x0034B568 File Offset: 0x00349768
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E612 RID: 58898 RVA: 0x0034B575 File Offset: 0x00349775
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E613 RID: 58899 RVA: 0x0034B57C File Offset: 0x0034977C
		public static SpringFestivalReward GetRootAsSpringFestivalReward(ByteBuffer _bb)
		{
			return SpringFestivalReward.GetRootAsSpringFestivalReward(_bb, default(SpringFestivalReward));
		}

		// Token: 0x0600E614 RID: 58900 RVA: 0x0034B598 File Offset: 0x00349798
		public static SpringFestivalReward GetRootAsSpringFestivalReward(ByteBuffer _bb, SpringFestivalReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E615 RID: 58901 RVA: 0x0034B5B5 File Offset: 0x003497B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E616 RID: 58902 RVA: 0x0034B5C4 File Offset: 0x003497C4
		public SpringFestivalReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B7D RID: 15229
		// (get) Token: 0x0600E617 RID: 58903 RVA: 0x0034B5D4 File Offset: 0x003497D4
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

		// Token: 0x17003B7E RID: 15230
		// (get) Token: 0x0600E618 RID: 58904 RVA: 0x0034B610 File Offset: 0x00349810
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

		// Token: 0x17003B7F RID: 15231
		// (get) Token: 0x0600E619 RID: 58905 RVA: 0x0034B64C File Offset: 0x0034984C
		public int TabId
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

		// Token: 0x17003B80 RID: 15232
		// (get) Token: 0x0600E61A RID: 58906 RVA: 0x0034B688 File Offset: 0x00349888
		public int Sort
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

		// Token: 0x17003B81 RID: 15233
		// (get) Token: 0x0600E61B RID: 58907 RVA: 0x0034B6C8 File Offset: 0x003498C8
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E61C RID: 58908 RVA: 0x0034B700 File Offset: 0x00349900
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600E61D RID: 58909 RVA: 0x0034B710 File Offset: 0x00349910
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B82 RID: 15234
		// (get) Token: 0x0600E61E RID: 58910 RVA: 0x0034B728 File Offset: 0x00349928
		public int ConditionGroup
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

		// Token: 0x17003B83 RID: 15235
		// (get) Token: 0x0600E61F RID: 58911 RVA: 0x0034B768 File Offset: 0x00349968
		public int DropId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003B84 RID: 15236
		// (get) Token: 0x0600E620 RID: 58912 RVA: 0x0034B7A8 File Offset: 0x003499A8
		public int SkipType
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E621 RID: 58913 RVA: 0x0034B7E8 File Offset: 0x003499E8
		public string SkipParam(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003B85 RID: 15237
		// (get) Token: 0x0600E622 RID: 58914 RVA: 0x0034B824 File Offset: 0x00349A24
		public int SkipParamLength
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

		// Token: 0x0600E623 RID: 58915 RVA: 0x0034B850 File Offset: 0x00349A50
		[NullableContext(1)]
		public string[] SkipParam()
		{
			return this.SkipParamIter().ToArray<string>();
		}

		// Token: 0x0600E624 RID: 58916 RVA: 0x0034B85D File Offset: 0x00349A5D
		[NullableContext(1)]
		public IEnumerable<string> SkipParamIter()
		{
			SpringFestivalReward.<SkipParamIter>d__30 <SkipParamIter>d__ = new SpringFestivalReward.<SkipParamIter>d__30(-2);
			<SkipParamIter>d__.<>3__<>4__this = this;
			return <SkipParamIter>d__;
		}

		// Token: 0x04005860 RID: 22624
		private Table __p;
	}
}
