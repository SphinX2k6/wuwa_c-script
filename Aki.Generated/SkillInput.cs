using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011BD RID: 4541
	public struct SkillInput : IFlatbufferObject
	{
		// Token: 0x170037EE RID: 14318
		// (get) Token: 0x0600DD07 RID: 56583 RVA: 0x00336AB0 File Offset: 0x00334CB0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DD08 RID: 56584 RVA: 0x00336ABD File Offset: 0x00334CBD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DD09 RID: 56585 RVA: 0x00336AC4 File Offset: 0x00334CC4
		public static SkillInput GetRootAsSkillInput(ByteBuffer _bb)
		{
			return SkillInput.GetRootAsSkillInput(_bb, default(SkillInput));
		}

		// Token: 0x0600DD0A RID: 56586 RVA: 0x00336AE0 File Offset: 0x00334CE0
		public static SkillInput GetRootAsSkillInput(ByteBuffer _bb, SkillInput obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DD0B RID: 56587 RVA: 0x00336AFD File Offset: 0x00334CFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DD0C RID: 56588 RVA: 0x00336B0C File Offset: 0x00334D0C
		public SkillInput __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170037EF RID: 14319
		// (get) Token: 0x0600DD0D RID: 56589 RVA: 0x00336B1C File Offset: 0x00334D1C
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

		// Token: 0x0600DD0E RID: 56590 RVA: 0x00336B58 File Offset: 0x00334D58
		public string InputArray(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170037F0 RID: 14320
		// (get) Token: 0x0600DD0F RID: 56591 RVA: 0x00336B94 File Offset: 0x00334D94
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

		// Token: 0x0600DD10 RID: 56592 RVA: 0x00336BC0 File Offset: 0x00334DC0
		public int SkillArray(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170037F1 RID: 14321
		// (get) Token: 0x0600DD11 RID: 56593 RVA: 0x00336C00 File Offset: 0x00334E00
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

		// Token: 0x0600DD12 RID: 56594 RVA: 0x00336C2B File Offset: 0x00334E2B
		public Span<int> GetSkillArrayBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600DD13 RID: 56595 RVA: 0x00336C3A File Offset: 0x00334E3A
		public int[] GetSkillArrayArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600DD14 RID: 56596 RVA: 0x00336C54 File Offset: 0x00334E54
		public string ImageArray(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170037F2 RID: 14322
		// (get) Token: 0x0600DD15 RID: 56597 RVA: 0x00336C90 File Offset: 0x00334E90
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

		// Token: 0x170037F3 RID: 14323
		// (get) Token: 0x0600DD16 RID: 56598 RVA: 0x00336CBC File Offset: 0x00334EBC
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

		// Token: 0x0600DD17 RID: 56599 RVA: 0x00336CF4 File Offset: 0x00334EF4
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600DD18 RID: 56600 RVA: 0x00336D04 File Offset: 0x00334F04
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DD19 RID: 56601 RVA: 0x00336D1C File Offset: 0x00334F1C
		[NullableContext(1)]
		public string[] ImageArray()
		{
			return this.ImageArrayIter().ToArray<string>();
		}

		// Token: 0x0600DD1A RID: 56602 RVA: 0x00336D29 File Offset: 0x00334F29
		[NullableContext(1)]
		public IEnumerable<string> ImageArrayIter()
		{
			SkillInput.<ImageArrayIter>d__26 <ImageArrayIter>d__ = new SkillInput.<ImageArrayIter>d__26(-2);
			<ImageArrayIter>d__.<>3__<>4__this = this;
			return <ImageArrayIter>d__;
		}

		// Token: 0x0600DD1B RID: 56603 RVA: 0x00336D3E File Offset: 0x00334F3E
		[NullableContext(1)]
		public string[] InputArray()
		{
			return this.InputArrayIter().ToArray<string>();
		}

		// Token: 0x0600DD1C RID: 56604 RVA: 0x00336D4B File Offset: 0x00334F4B
		[NullableContext(1)]
		public IEnumerable<string> InputArrayIter()
		{
			SkillInput.<InputArrayIter>d__28 <InputArrayIter>d__ = new SkillInput.<InputArrayIter>d__28(-2);
			<InputArrayIter>d__.<>3__<>4__this = this;
			return <InputArrayIter>d__;
		}

		// Token: 0x0600DD1D RID: 56605 RVA: 0x00336D60 File Offset: 0x00334F60
		[NullableContext(1)]
		public int[] SkillArray()
		{
			return this.GetSkillArrayArray();
		}

		// Token: 0x0600DD1E RID: 56606 RVA: 0x00336D68 File Offset: 0x00334F68
		[NullableContext(1)]
		public IEnumerable<int> SkillArrayIter()
		{
			SkillInput.<SkillArrayIter>d__30 <SkillArrayIter>d__ = new SkillInput.<SkillArrayIter>d__30(-2);
			<SkillArrayIter>d__.<>3__<>4__this = this;
			return <SkillArrayIter>d__;
		}

		// Token: 0x040057EA RID: 22506
		private Table __p;
	}
}
