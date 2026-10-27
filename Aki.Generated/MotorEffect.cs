using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E38 RID: 3640
	public struct MotorEffect : IFlatbufferObject
	{
		// Token: 0x1700205E RID: 8286
		// (get) Token: 0x06009793 RID: 38803 RVA: 0x0028CF36 File Offset: 0x0028B136
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009794 RID: 38804 RVA: 0x0028CF43 File Offset: 0x0028B143
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009795 RID: 38805 RVA: 0x0028CF4C File Offset: 0x0028B14C
		public static MotorEffect GetRootAsMotorEffect(ByteBuffer _bb)
		{
			return MotorEffect.GetRootAsMotorEffect(_bb, default(MotorEffect));
		}

		// Token: 0x06009796 RID: 38806 RVA: 0x0028CF68 File Offset: 0x0028B168
		public static MotorEffect GetRootAsMotorEffect(ByteBuffer _bb, MotorEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009797 RID: 38807 RVA: 0x0028CF85 File Offset: 0x0028B185
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009798 RID: 38808 RVA: 0x0028CF94 File Offset: 0x0028B194
		public MotorEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700205F RID: 8287
		// (get) Token: 0x06009799 RID: 38809 RVA: 0x0028CFA4 File Offset: 0x0028B1A4
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

		// Token: 0x17002060 RID: 8288
		// (get) Token: 0x0600979A RID: 38810 RVA: 0x0028CFE0 File Offset: 0x0028B1E0
		public int Type
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

		// Token: 0x17002061 RID: 8289
		// (get) Token: 0x0600979B RID: 38811 RVA: 0x0028D01C File Offset: 0x0028B21C
		public int SkillLevel
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

		// Token: 0x0600979C RID: 38812 RVA: 0x0028D058 File Offset: 0x0028B258
		public long DamageIdList(int j)
		{
			int num = this.__p.__offset(10);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17002062 RID: 8290
		// (get) Token: 0x0600979D RID: 38813 RVA: 0x0028D0A4 File Offset: 0x0028B2A4
		public int DamageIdListLength
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

		// Token: 0x0600979E RID: 38814 RVA: 0x0028D0D0 File Offset: 0x0028B2D0
		public Span<long> GetDamageIdListBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(10, 8));
		}

		// Token: 0x0600979F RID: 38815 RVA: 0x0028D0E5 File Offset: 0x0028B2E5
		public long[] GetDamageIdListArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(10) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x17002063 RID: 8291
		// (get) Token: 0x060097A0 RID: 38816 RVA: 0x0028D124 File Offset: 0x0028B324
		public string Param1
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

		// Token: 0x060097A1 RID: 38817 RVA: 0x0028D15C File Offset: 0x0028B35C
		public Span<byte> GetParam1Bytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060097A2 RID: 38818 RVA: 0x0028D16C File Offset: 0x0028B36C
		public byte[] GetParam1Array()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x060097A3 RID: 38819 RVA: 0x0028D184 File Offset: 0x0028B384
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DamageIdListIter()或GetDamageIdListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] DamageIdList()
		{
			MotorEffect motorEffect = this;
			return motorEffect.GetDamageIdListArray() ?? Array.Empty<long>();
		}

		// Token: 0x060097A4 RID: 38820 RVA: 0x0028D1A8 File Offset: 0x0028B3A8
		[NullableContext(1)]
		public readonly IEnumerable<long> DamageIdListIter()
		{
			MotorEffect.<DamageIdListIter>d__24 <DamageIdListIter>d__ = new MotorEffect.<DamageIdListIter>d__24(-2);
			<DamageIdListIter>d__.<>3__<>4__this = this;
			return <DamageIdListIter>d__;
		}

		// Token: 0x04004EE0 RID: 20192
		private Table __p;
	}
}
