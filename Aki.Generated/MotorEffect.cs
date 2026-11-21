using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F1D RID: 3869
	public struct MotorEffect : IFlatbufferObject
	{
		// Token: 0x170020C3 RID: 8387
		// (get) Token: 0x06009DB3 RID: 40371 RVA: 0x002AABB6 File Offset: 0x002A8DB6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009DB4 RID: 40372 RVA: 0x002AABC3 File Offset: 0x002A8DC3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009DB5 RID: 40373 RVA: 0x002AABCC File Offset: 0x002A8DCC
		public static MotorEffect GetRootAsMotorEffect(ByteBuffer _bb)
		{
			return MotorEffect.GetRootAsMotorEffect(_bb, default(MotorEffect));
		}

		// Token: 0x06009DB6 RID: 40374 RVA: 0x002AABE8 File Offset: 0x002A8DE8
		public static MotorEffect GetRootAsMotorEffect(ByteBuffer _bb, MotorEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009DB7 RID: 40375 RVA: 0x002AAC05 File Offset: 0x002A8E05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009DB8 RID: 40376 RVA: 0x002AAC14 File Offset: 0x002A8E14
		public MotorEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170020C4 RID: 8388
		// (get) Token: 0x06009DB9 RID: 40377 RVA: 0x002AAC24 File Offset: 0x002A8E24
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

		// Token: 0x170020C5 RID: 8389
		// (get) Token: 0x06009DBA RID: 40378 RVA: 0x002AAC60 File Offset: 0x002A8E60
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

		// Token: 0x170020C6 RID: 8390
		// (get) Token: 0x06009DBB RID: 40379 RVA: 0x002AAC9C File Offset: 0x002A8E9C
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

		// Token: 0x06009DBC RID: 40380 RVA: 0x002AACD8 File Offset: 0x002A8ED8
		public long DamageIdList(int j)
		{
			int num = this.__p.__offset(10);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x170020C7 RID: 8391
		// (get) Token: 0x06009DBD RID: 40381 RVA: 0x002AAD24 File Offset: 0x002A8F24
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

		// Token: 0x06009DBE RID: 40382 RVA: 0x002AAD50 File Offset: 0x002A8F50
		public Span<long> GetDamageIdListBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(10, 8));
		}

		// Token: 0x06009DBF RID: 40383 RVA: 0x002AAD65 File Offset: 0x002A8F65
		public long[] GetDamageIdListArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(10) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x170020C8 RID: 8392
		// (get) Token: 0x06009DC0 RID: 40384 RVA: 0x002AADA4 File Offset: 0x002A8FA4
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

		// Token: 0x06009DC1 RID: 40385 RVA: 0x002AADDC File Offset: 0x002A8FDC
		public Span<byte> GetParam1Bytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009DC2 RID: 40386 RVA: 0x002AADEC File Offset: 0x002A8FEC
		public byte[] GetParam1Array()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x06009DC3 RID: 40387 RVA: 0x002AAE04 File Offset: 0x002A9004
		[NullableContext(1)]
		public long[] DamageIdList()
		{
			return this.GetDamageIdListArray();
		}

		// Token: 0x06009DC4 RID: 40388 RVA: 0x002AAE0C File Offset: 0x002A900C
		[NullableContext(1)]
		public IEnumerable<long> DamageIdListIter()
		{
			MotorEffect.<DamageIdListIter>d__24 <DamageIdListIter>d__ = new MotorEffect.<DamageIdListIter>d__24(-2);
			<DamageIdListIter>d__.<>3__<>4__this = this;
			return <DamageIdListIter>d__;
		}

		// Token: 0x040054C5 RID: 21701
		private Table __p;
	}
}
