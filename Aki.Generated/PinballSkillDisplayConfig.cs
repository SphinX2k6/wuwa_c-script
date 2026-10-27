using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F38 RID: 3896
	public struct PinballSkillDisplayConfig : IFlatbufferObject
	{
		// Token: 0x170029D8 RID: 10712
		// (get) Token: 0x0600B04F RID: 45135 RVA: 0x002C4DFD File Offset: 0x002C2FFD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B050 RID: 45136 RVA: 0x002C4E0A File Offset: 0x002C300A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B051 RID: 45137 RVA: 0x002C4E14 File Offset: 0x002C3014
		public static PinballSkillDisplayConfig GetRootAsPinballSkillDisplayConfig(ByteBuffer _bb)
		{
			return PinballSkillDisplayConfig.GetRootAsPinballSkillDisplayConfig(_bb, default(PinballSkillDisplayConfig));
		}

		// Token: 0x0600B052 RID: 45138 RVA: 0x002C4E30 File Offset: 0x002C3030
		public static PinballSkillDisplayConfig GetRootAsPinballSkillDisplayConfig(ByteBuffer _bb, PinballSkillDisplayConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B053 RID: 45139 RVA: 0x002C4E4D File Offset: 0x002C304D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B054 RID: 45140 RVA: 0x002C4E5C File Offset: 0x002C305C
		public PinballSkillDisplayConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170029D9 RID: 10713
		// (get) Token: 0x0600B055 RID: 45141 RVA: 0x002C4E6C File Offset: 0x002C306C
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

		// Token: 0x170029DA RID: 10714
		// (get) Token: 0x0600B056 RID: 45142 RVA: 0x002C4EA8 File Offset: 0x002C30A8
		public string Name
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

		// Token: 0x0600B057 RID: 45143 RVA: 0x002C4EDF File Offset: 0x002C30DF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B058 RID: 45144 RVA: 0x002C4EEE File Offset: 0x002C30EE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170029DB RID: 10715
		// (get) Token: 0x0600B059 RID: 45145 RVA: 0x002C4F08 File Offset: 0x002C3108
		public string Desc
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

		// Token: 0x0600B05A RID: 45146 RVA: 0x002C4F3F File Offset: 0x002C313F
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B05B RID: 45147 RVA: 0x002C4F4E File Offset: 0x002C314E
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B05C RID: 45148 RVA: 0x002C4F68 File Offset: 0x002C3168
		public string ValueList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170029DC RID: 10716
		// (get) Token: 0x0600B05D RID: 45149 RVA: 0x002C4FA4 File Offset: 0x002C31A4
		public int ValueListLength
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

		// Token: 0x170029DD RID: 10717
		// (get) Token: 0x0600B05E RID: 45150 RVA: 0x002C4FD0 File Offset: 0x002C31D0
		public bool IsCaptainSkill
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600B05F RID: 45151 RVA: 0x002C5010 File Offset: 0x002C3210
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ValueListIter()或GetValueListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ValueList()
		{
			return this.ValueListIter().ToArray<string>();
		}

		// Token: 0x0600B060 RID: 45152 RVA: 0x002C501D File Offset: 0x002C321D
		[NullableContext(1)]
		public readonly IEnumerable<string> ValueListIter()
		{
			PinballSkillDisplayConfig.<ValueListIter>d__24 <ValueListIter>d__ = new PinballSkillDisplayConfig.<ValueListIter>d__24(-2);
			<ValueListIter>d__.<>3__<>4__this = this;
			return <ValueListIter>d__;
		}

		// Token: 0x04005002 RID: 20482
		private Table __p;
	}
}
