using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E40 RID: 3648
	public struct MotorFightBuffGate : IFlatbufferObject
	{
		// Token: 0x1700209E RID: 8350
		// (get) Token: 0x06009806 RID: 38918 RVA: 0x0028E16D File Offset: 0x0028C36D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009807 RID: 38919 RVA: 0x0028E17A File Offset: 0x0028C37A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009808 RID: 38920 RVA: 0x0028E184 File Offset: 0x0028C384
		public static MotorFightBuffGate GetRootAsMotorFightBuffGate(ByteBuffer _bb)
		{
			return MotorFightBuffGate.GetRootAsMotorFightBuffGate(_bb, default(MotorFightBuffGate));
		}

		// Token: 0x06009809 RID: 38921 RVA: 0x0028E1A0 File Offset: 0x0028C3A0
		public static MotorFightBuffGate GetRootAsMotorFightBuffGate(ByteBuffer _bb, MotorFightBuffGate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600980A RID: 38922 RVA: 0x0028E1BD File Offset: 0x0028C3BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600980B RID: 38923 RVA: 0x0028E1CC File Offset: 0x0028C3CC
		public MotorFightBuffGate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700209F RID: 8351
		// (get) Token: 0x0600980C RID: 38924 RVA: 0x0028E1DC File Offset: 0x0028C3DC
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

		// Token: 0x170020A0 RID: 8352
		// (get) Token: 0x0600980D RID: 38925 RVA: 0x0028E218 File Offset: 0x0028C418
		public int GateTemptId
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

		// Token: 0x0600980E RID: 38926 RVA: 0x0028E254 File Offset: 0x0028C454
		public int BuffEffect(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170020A1 RID: 8353
		// (get) Token: 0x0600980F RID: 38927 RVA: 0x0028E294 File Offset: 0x0028C494
		public int BuffEffectLength
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

		// Token: 0x06009810 RID: 38928 RVA: 0x0028E2BF File Offset: 0x0028C4BF
		public Span<int> GetBuffEffectBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06009811 RID: 38929 RVA: 0x0028E2CE File Offset: 0x0028C4CE
		public int[] GetBuffEffectArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x170020A2 RID: 8354
		// (get) Token: 0x06009812 RID: 38930 RVA: 0x0028E2E8 File Offset: 0x0028C4E8
		public int Height
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009813 RID: 38931 RVA: 0x0028E328 File Offset: 0x0028C528
		public int BornBuff(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170020A3 RID: 8355
		// (get) Token: 0x06009814 RID: 38932 RVA: 0x0028E368 File Offset: 0x0028C568
		public int BornBuffLength
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

		// Token: 0x06009815 RID: 38933 RVA: 0x0028E394 File Offset: 0x0028C594
		public Span<int> GetBornBuffBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06009816 RID: 38934 RVA: 0x0028E3A4 File Offset: 0x0028C5A4
		public int[] GetBornBuffArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x170020A4 RID: 8356
		// (get) Token: 0x06009817 RID: 38935 RVA: 0x0028E3BC File Offset: 0x0028C5BC
		public string DetailDesc
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009818 RID: 38936 RVA: 0x0028E3F4 File Offset: 0x0028C5F4
		public Span<byte> GetDetailDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009819 RID: 38937 RVA: 0x0028E404 File Offset: 0x0028C604
		public byte[] GetDetailDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170020A5 RID: 8357
		// (get) Token: 0x0600981A RID: 38938 RVA: 0x0028E41C File Offset: 0x0028C61C
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600981B RID: 38939 RVA: 0x0028E454 File Offset: 0x0028C654
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600981C RID: 38940 RVA: 0x0028E464 File Offset: 0x0028C664
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600981D RID: 38941 RVA: 0x0028E47C File Offset: 0x0028C67C
		public string DescArgs(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170020A6 RID: 8358
		// (get) Token: 0x0600981E RID: 38942 RVA: 0x0028E4B8 File Offset: 0x0028C6B8
		public int DescArgsLength
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

		// Token: 0x170020A7 RID: 8359
		// (get) Token: 0x0600981F RID: 38943 RVA: 0x0028E4E4 File Offset: 0x0028C6E4
		public int AffectedByRate
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

		// Token: 0x170020A8 RID: 8360
		// (get) Token: 0x06009820 RID: 38944 RVA: 0x0028E524 File Offset: 0x0028C724
		public int Type
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170020A9 RID: 8361
		// (get) Token: 0x06009821 RID: 38945 RVA: 0x0028E564 File Offset: 0x0028C764
		public int Quality
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 3;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009822 RID: 38946 RVA: 0x0028E5A4 File Offset: 0x0028C7A4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BornBuffIter()或GetBornBuffBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BornBuff()
		{
			MotorFightBuffGate motorFightBuffGate = this;
			return motorFightBuffGate.GetBornBuffArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009823 RID: 38947 RVA: 0x0028E5C8 File Offset: 0x0028C7C8
		[NullableContext(1)]
		public readonly IEnumerable<int> BornBuffIter()
		{
			MotorFightBuffGate.<BornBuffIter>d__42 <BornBuffIter>d__ = new MotorFightBuffGate.<BornBuffIter>d__42(-2);
			<BornBuffIter>d__.<>3__<>4__this = this;
			return <BornBuffIter>d__;
		}

		// Token: 0x06009824 RID: 38948 RVA: 0x0028E5E0 File Offset: 0x0028C7E0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffEffectIter()或GetBuffEffectBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BuffEffect()
		{
			MotorFightBuffGate motorFightBuffGate = this;
			return motorFightBuffGate.GetBuffEffectArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009825 RID: 38949 RVA: 0x0028E604 File Offset: 0x0028C804
		[NullableContext(1)]
		public readonly IEnumerable<int> BuffEffectIter()
		{
			MotorFightBuffGate.<BuffEffectIter>d__44 <BuffEffectIter>d__ = new MotorFightBuffGate.<BuffEffectIter>d__44(-2);
			<BuffEffectIter>d__.<>3__<>4__this = this;
			return <BuffEffectIter>d__;
		}

		// Token: 0x06009826 RID: 38950 RVA: 0x0028E619 File Offset: 0x0028C819
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescArgsIter()或GetDescArgsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescArgs()
		{
			return this.DescArgsIter().ToArray<string>();
		}

		// Token: 0x06009827 RID: 38951 RVA: 0x0028E626 File Offset: 0x0028C826
		[NullableContext(1)]
		public readonly IEnumerable<string> DescArgsIter()
		{
			MotorFightBuffGate.<DescArgsIter>d__46 <DescArgsIter>d__ = new MotorFightBuffGate.<DescArgsIter>d__46(-2);
			<DescArgsIter>d__.<>3__<>4__this = this;
			return <DescArgsIter>d__;
		}

		// Token: 0x04004EE8 RID: 20200
		private Table __p;
	}
}
