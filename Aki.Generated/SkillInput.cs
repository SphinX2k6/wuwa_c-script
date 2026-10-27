using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010C2 RID: 4290
	public struct SkillInput : IFlatbufferObject
	{
		// Token: 0x170036DD RID: 14045
		// (get) Token: 0x0600D52A RID: 54570 RVA: 0x00317910 File Offset: 0x00315B10
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D52B RID: 54571 RVA: 0x0031791D File Offset: 0x00315B1D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D52C RID: 54572 RVA: 0x00317924 File Offset: 0x00315B24
		public static SkillInput GetRootAsSkillInput(ByteBuffer _bb)
		{
			return SkillInput.GetRootAsSkillInput(_bb, default(SkillInput));
		}

		// Token: 0x0600D52D RID: 54573 RVA: 0x00317940 File Offset: 0x00315B40
		public static SkillInput GetRootAsSkillInput(ByteBuffer _bb, SkillInput obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D52E RID: 54574 RVA: 0x0031795D File Offset: 0x00315B5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D52F RID: 54575 RVA: 0x0031796C File Offset: 0x00315B6C
		public SkillInput __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170036DE RID: 14046
		// (get) Token: 0x0600D530 RID: 54576 RVA: 0x0031797C File Offset: 0x00315B7C
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

		// Token: 0x0600D531 RID: 54577 RVA: 0x003179B8 File Offset: 0x00315BB8
		public string InputArray(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170036DF RID: 14047
		// (get) Token: 0x0600D532 RID: 54578 RVA: 0x003179F4 File Offset: 0x00315BF4
		public int InputArrayLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D533 RID: 54579 RVA: 0x00317A20 File Offset: 0x00315C20
		public int SkillArray(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170036E0 RID: 14048
		// (get) Token: 0x0600D534 RID: 54580 RVA: 0x00317A60 File Offset: 0x00315C60
		public int SkillArrayLength
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

		// Token: 0x0600D535 RID: 54581 RVA: 0x00317A8B File Offset: 0x00315C8B
		public Span<int> GetSkillArrayBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600D536 RID: 54582 RVA: 0x00317A9A File Offset: 0x00315C9A
		public int[] GetSkillArrayArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600D537 RID: 54583 RVA: 0x00317AB4 File Offset: 0x00315CB4
		public string ImageArray(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170036E1 RID: 14049
		// (get) Token: 0x0600D538 RID: 54584 RVA: 0x00317AF0 File Offset: 0x00315CF0
		public int ImageArrayLength
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

		// Token: 0x170036E2 RID: 14050
		// (get) Token: 0x0600D539 RID: 54585 RVA: 0x00317B1C File Offset: 0x00315D1C
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

		// Token: 0x0600D53A RID: 54586 RVA: 0x00317B54 File Offset: 0x00315D54
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D53B RID: 54587 RVA: 0x00317B64 File Offset: 0x00315D64
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D53C RID: 54588 RVA: 0x00317B7C File Offset: 0x00315D7C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ImageArrayIter()或GetImageArrayBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ImageArray()
		{
			return this.ImageArrayIter().ToArray<string>();
		}

		// Token: 0x0600D53D RID: 54589 RVA: 0x00317B89 File Offset: 0x00315D89
		[NullableContext(1)]
		public readonly IEnumerable<string> ImageArrayIter()
		{
			SkillInput.<ImageArrayIter>d__26 <ImageArrayIter>d__ = new SkillInput.<ImageArrayIter>d__26(-2);
			<ImageArrayIter>d__.<>3__<>4__this = this;
			return <ImageArrayIter>d__;
		}

		// Token: 0x0600D53E RID: 54590 RVA: 0x00317B9E File Offset: 0x00315D9E
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InputArrayIter()或GetInputArrayBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] InputArray()
		{
			return this.InputArrayIter().ToArray<string>();
		}

		// Token: 0x0600D53F RID: 54591 RVA: 0x00317BAB File Offset: 0x00315DAB
		[NullableContext(1)]
		public readonly IEnumerable<string> InputArrayIter()
		{
			SkillInput.<InputArrayIter>d__28 <InputArrayIter>d__ = new SkillInput.<InputArrayIter>d__28(-2);
			<InputArrayIter>d__.<>3__<>4__this = this;
			return <InputArrayIter>d__;
		}

		// Token: 0x0600D540 RID: 54592 RVA: 0x00317BC0 File Offset: 0x00315DC0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillArrayIter()或GetSkillArrayBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SkillArray()
		{
			SkillInput skillInput = this;
			return skillInput.GetSkillArrayArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D541 RID: 54593 RVA: 0x00317BE4 File Offset: 0x00315DE4
		[NullableContext(1)]
		public readonly IEnumerable<int> SkillArrayIter()
		{
			SkillInput.<SkillArrayIter>d__30 <SkillArrayIter>d__ = new SkillInput.<SkillArrayIter>d__30(-2);
			<SkillArrayIter>d__.<>3__<>4__this = this;
			return <SkillArrayIter>d__;
		}

		// Token: 0x040051EB RID: 20971
		private Table __p;
	}
}
