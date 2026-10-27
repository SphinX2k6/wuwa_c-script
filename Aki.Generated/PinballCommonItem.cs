using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F26 RID: 3878
	public struct PinballCommonItem : IFlatbufferObject
	{
		// Token: 0x17002919 RID: 10521
		// (get) Token: 0x0600AE78 RID: 44664 RVA: 0x002C0A18 File Offset: 0x002BEC18
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AE79 RID: 44665 RVA: 0x002C0A25 File Offset: 0x002BEC25
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AE7A RID: 44666 RVA: 0x002C0A2C File Offset: 0x002BEC2C
		public static PinballCommonItem GetRootAsPinballCommonItem(ByteBuffer _bb)
		{
			return PinballCommonItem.GetRootAsPinballCommonItem(_bb, default(PinballCommonItem));
		}

		// Token: 0x0600AE7B RID: 44667 RVA: 0x002C0A48 File Offset: 0x002BEC48
		public static PinballCommonItem GetRootAsPinballCommonItem(ByteBuffer _bb, PinballCommonItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AE7C RID: 44668 RVA: 0x002C0A65 File Offset: 0x002BEC65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AE7D RID: 44669 RVA: 0x002C0A74 File Offset: 0x002BEC74
		public PinballCommonItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700291A RID: 10522
		// (get) Token: 0x0600AE7E RID: 44670 RVA: 0x002C0A84 File Offset: 0x002BEC84
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

		// Token: 0x1700291B RID: 10523
		// (get) Token: 0x0600AE7F RID: 44671 RVA: 0x002C0AC0 File Offset: 0x002BECC0
		public int DataId
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

		// Token: 0x1700291C RID: 10524
		// (get) Token: 0x0600AE80 RID: 44672 RVA: 0x002C0AFC File Offset: 0x002BECFC
		public int TemplateId
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

		// Token: 0x1700291D RID: 10525
		// (get) Token: 0x0600AE81 RID: 44673 RVA: 0x002C0B38 File Offset: 0x002BED38
		public int SimpleCombatSubtypeId
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

		// Token: 0x0600AE82 RID: 44674 RVA: 0x002C0B78 File Offset: 0x002BED78
		public int AbsorbEffects(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700291E RID: 10526
		// (get) Token: 0x0600AE83 RID: 44675 RVA: 0x002C0BB8 File Offset: 0x002BEDB8
		public int AbsorbEffectsLength
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

		// Token: 0x0600AE84 RID: 44676 RVA: 0x002C0BE4 File Offset: 0x002BEDE4
		public Span<int> GetAbsorbEffectsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600AE85 RID: 44677 RVA: 0x002C0BF4 File Offset: 0x002BEDF4
		public int[] GetAbsorbEffectsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x1700291F RID: 10527
		// (get) Token: 0x0600AE86 RID: 44678 RVA: 0x002C0C0C File Offset: 0x002BEE0C
		public int ContentType
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

		// Token: 0x17002920 RID: 10528
		// (get) Token: 0x0600AE87 RID: 44679 RVA: 0x002C0C4C File Offset: 0x002BEE4C
		public int Deathrattle
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

		// Token: 0x0600AE88 RID: 44680 RVA: 0x002C0C8C File Offset: 0x002BEE8C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AbsorbEffectsIter()或GetAbsorbEffectsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] AbsorbEffects()
		{
			PinballCommonItem pinballCommonItem = this;
			return pinballCommonItem.GetAbsorbEffectsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600AE89 RID: 44681 RVA: 0x002C0CB0 File Offset: 0x002BEEB0
		[NullableContext(1)]
		public readonly IEnumerable<int> AbsorbEffectsIter()
		{
			PinballCommonItem.<AbsorbEffectsIter>d__26 <AbsorbEffectsIter>d__ = new PinballCommonItem.<AbsorbEffectsIter>d__26(-2);
			<AbsorbEffectsIter>d__.<>3__<>4__this = this;
			return <AbsorbEffectsIter>d__;
		}

		// Token: 0x04004FEF RID: 20463
		private Table __p;
	}
}
