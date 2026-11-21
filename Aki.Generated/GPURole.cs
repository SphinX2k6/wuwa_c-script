using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DF3 RID: 3571
	public struct GPURole : IFlatbufferObject
	{
		// Token: 0x1700166F RID: 5743
		// (get) Token: 0x060081EA RID: 33258 RVA: 0x0026CBA1 File Offset: 0x0026ADA1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060081EB RID: 33259 RVA: 0x0026CBAE File Offset: 0x0026ADAE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060081EC RID: 33260 RVA: 0x0026CBB8 File Offset: 0x0026ADB8
		public static GPURole GetRootAsGPURole(ByteBuffer _bb)
		{
			return GPURole.GetRootAsGPURole(_bb, default(GPURole));
		}

		// Token: 0x060081ED RID: 33261 RVA: 0x0026CBD4 File Offset: 0x0026ADD4
		public static GPURole GetRootAsGPURole(ByteBuffer _bb, GPURole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060081EE RID: 33262 RVA: 0x0026CBF1 File Offset: 0x0026ADF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060081EF RID: 33263 RVA: 0x0026CC00 File Offset: 0x0026AE00
		public GPURole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001670 RID: 5744
		// (get) Token: 0x060081F0 RID: 33264 RVA: 0x0026CC10 File Offset: 0x0026AE10
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

		// Token: 0x17001671 RID: 5745
		// (get) Token: 0x060081F1 RID: 33265 RVA: 0x0026CC4C File Offset: 0x0026AE4C
		public int SimpleCombatSubtypeId
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

		// Token: 0x17001672 RID: 5746
		// (get) Token: 0x060081F2 RID: 33266 RVA: 0x0026CC88 File Offset: 0x0026AE88
		public int RoleId
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

		// Token: 0x17001673 RID: 5747
		// (get) Token: 0x060081F3 RID: 33267 RVA: 0x0026CCC4 File Offset: 0x0026AEC4
		public int TemplateId
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

		// Token: 0x060081F4 RID: 33268 RVA: 0x0026CD04 File Offset: 0x0026AF04
		public int InitBuffs(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001674 RID: 5748
		// (get) Token: 0x060081F5 RID: 33269 RVA: 0x0026CD44 File Offset: 0x0026AF44
		public int InitBuffsLength
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

		// Token: 0x060081F6 RID: 33270 RVA: 0x0026CD70 File Offset: 0x0026AF70
		public Span<int> GetInitBuffsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x060081F7 RID: 33271 RVA: 0x0026CD80 File Offset: 0x0026AF80
		public int[] GetInitBuffsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17001675 RID: 5749
		// (get) Token: 0x060081F8 RID: 33272 RVA: 0x0026CD98 File Offset: 0x0026AF98
		public int Prop
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

		// Token: 0x060081F9 RID: 33273 RVA: 0x0026CDD5 File Offset: 0x0026AFD5
		[NullableContext(1)]
		public int[] InitBuffs()
		{
			return this.GetInitBuffsArray();
		}

		// Token: 0x060081FA RID: 33274 RVA: 0x0026CDDD File Offset: 0x0026AFDD
		[NullableContext(1)]
		public IEnumerable<int> InitBuffsIter()
		{
			GPURole.<InitBuffsIter>d__24 <InitBuffsIter>d__ = new GPURole.<InitBuffsIter>d__24(-2);
			<InitBuffsIter>d__.<>3__<>4__this = this;
			return <InitBuffsIter>d__;
		}

		// Token: 0x04005369 RID: 21353
		private Table __p;
	}
}
