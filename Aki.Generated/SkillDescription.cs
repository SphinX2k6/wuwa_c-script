using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010BE RID: 4286
	public struct SkillDescription : IFlatbufferObject
	{
		// Token: 0x170036AD RID: 13997
		// (get) Token: 0x0600D49B RID: 54427 RVA: 0x003161F8 File Offset: 0x003143F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D49C RID: 54428 RVA: 0x00316205 File Offset: 0x00314405
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D49D RID: 54429 RVA: 0x0031620C File Offset: 0x0031440C
		public static SkillDescription GetRootAsSkillDescription(ByteBuffer _bb)
		{
			return SkillDescription.GetRootAsSkillDescription(_bb, default(SkillDescription));
		}

		// Token: 0x0600D49E RID: 54430 RVA: 0x00316228 File Offset: 0x00314428
		public static SkillDescription GetRootAsSkillDescription(ByteBuffer _bb, SkillDescription obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D49F RID: 54431 RVA: 0x00316245 File Offset: 0x00314445
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D4A0 RID: 54432 RVA: 0x00316254 File Offset: 0x00314454
		public SkillDescription __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170036AE RID: 13998
		// (get) Token: 0x0600D4A1 RID: 54433 RVA: 0x00316264 File Offset: 0x00314464
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

		// Token: 0x170036AF RID: 13999
		// (get) Token: 0x0600D4A2 RID: 54434 RVA: 0x003162A0 File Offset: 0x003144A0
		public int SkillLevelGroupId
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

		// Token: 0x170036B0 RID: 14000
		// (get) Token: 0x0600D4A3 RID: 54435 RVA: 0x003162DC File Offset: 0x003144DC
		public string AttributeName
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

		// Token: 0x0600D4A4 RID: 54436 RVA: 0x00316313 File Offset: 0x00314513
		public Span<byte> GetAttributeNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D4A5 RID: 54437 RVA: 0x00316322 File Offset: 0x00314522
		public byte[] GetAttributeNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D4A6 RID: 54438 RVA: 0x0031633C File Offset: 0x0031453C
		public StringArray? SkillDetailNum(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new StringArray?(default(StringArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170036B1 RID: 14001
		// (get) Token: 0x0600D4A7 RID: 54439 RVA: 0x003163A0 File Offset: 0x003145A0
		public int SkillDetailNumLength
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

		// Token: 0x170036B2 RID: 14002
		// (get) Token: 0x0600D4A8 RID: 54440 RVA: 0x003163CC File Offset: 0x003145CC
		public string Description
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

		// Token: 0x0600D4A9 RID: 54441 RVA: 0x00316404 File Offset: 0x00314604
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D4AA RID: 54442 RVA: 0x00316414 File Offset: 0x00314614
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170036B3 RID: 14003
		// (get) Token: 0x0600D4AB RID: 54443 RVA: 0x0031642C File Offset: 0x0031462C
		public int Order
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

		// Token: 0x0600D4AC RID: 54444 RVA: 0x00316469 File Offset: 0x00314669
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillDetailNumIter()或GetSkillDetailNumBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly StringArray[] SkillDetailNum()
		{
			return this.SkillDetailNumIter().ToArray<StringArray>();
		}

		// Token: 0x0600D4AD RID: 54445 RVA: 0x00316476 File Offset: 0x00314676
		[NullableContext(1)]
		public readonly IEnumerable<StringArray> SkillDetailNumIter()
		{
			SkillDescription.<SkillDetailNumIter>d__26 <SkillDetailNumIter>d__ = new SkillDescription.<SkillDetailNumIter>d__26(-2);
			<SkillDetailNumIter>d__.<>3__<>4__this = this;
			return <SkillDetailNumIter>d__;
		}

		// Token: 0x040051E3 RID: 20963
		private Table __p;
	}
}
