using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058FD RID: 22781
	public struct IHitBulletTypeFixedBulletId : IFlatbufferObject
	{
		// Token: 0x1700A536 RID: 42294
		// (get) Token: 0x0602502E RID: 151598 RVA: 0x00514714 File Offset: 0x00512914
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602502F RID: 151599 RVA: 0x00514721 File Offset: 0x00512921
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025030 RID: 151600 RVA: 0x00514728 File Offset: 0x00512928
		public static IHitBulletTypeFixedBulletId GetRootAsIHitBulletTypeFixedBulletId(ByteBuffer _bb)
		{
			return IHitBulletTypeFixedBulletId.GetRootAsIHitBulletTypeFixedBulletId(_bb, default(IHitBulletTypeFixedBulletId));
		}

		// Token: 0x06025031 RID: 151601 RVA: 0x00514744 File Offset: 0x00512944
		public static IHitBulletTypeFixedBulletId GetRootAsIHitBulletTypeFixedBulletId(ByteBuffer _bb, IHitBulletTypeFixedBulletId obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025032 RID: 151602 RVA: 0x00514761 File Offset: 0x00512961
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025033 RID: 151603 RVA: 0x00514770 File Offset: 0x00512970
		public IHitBulletTypeFixedBulletId __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A537 RID: 42295
		// (get) Token: 0x06025034 RID: 151604 RVA: 0x00514780 File Offset: 0x00512980
		public EHitBulletType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHitBulletType.OnlyDropAttack;
				}
				return (EHitBulletType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025035 RID: 151605 RVA: 0x005147BC File Offset: 0x005129BC
		public long BulletId(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x1700A538 RID: 42296
		// (get) Token: 0x06025036 RID: 151606 RVA: 0x005147FC File Offset: 0x005129FC
		public int BulletIdLength
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

		// Token: 0x06025037 RID: 151607 RVA: 0x00514827 File Offset: 0x00512A27
		public Span<long> GetBulletIdBytes()
		{
			return this.__p.__vector_as_span<long>(6, 8);
		}

		// Token: 0x06025038 RID: 151608 RVA: 0x00514836 File Offset: 0x00512A36
		public long[] GetBulletIdArray()
		{
			return this.__p.__vector_as_array<long>(6);
		}

		// Token: 0x1700A539 RID: 42297
		// (get) Token: 0x06025039 RID: 151609 RVA: 0x00514844 File Offset: 0x00512A44
		public bool PlayerAttack
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A53A RID: 42298
		// (get) Token: 0x0602503A RID: 151610 RVA: 0x00514884 File Offset: 0x00512A84
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602503B RID: 151611 RVA: 0x005148C1 File Offset: 0x00512AC1
		public static Offset<IHitBulletTypeFixedBulletId> CreateIHitBulletTypeFixedBulletId(FlatBufferBuilder builder, EHitBulletType Type = EHitBulletType.OnlyDropAttack, VectorOffset BulletIdOffset = default(VectorOffset), bool PlayerAttack = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IHitBulletTypeFixedBulletId.AddBulletId(builder, BulletIdOffset);
			IHitBulletTypeFixedBulletId.AddNullMask(builder, NullMask);
			IHitBulletTypeFixedBulletId.AddPlayerAttack(builder, PlayerAttack);
			IHitBulletTypeFixedBulletId.AddType(builder, Type);
			return IHitBulletTypeFixedBulletId.EndIHitBulletTypeFixedBulletId(builder);
		}

		// Token: 0x0602503C RID: 151612 RVA: 0x005148ED File Offset: 0x00512AED
		public static void StartIHitBulletTypeFixedBulletId(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602503D RID: 151613 RVA: 0x005148F6 File Offset: 0x00512AF6
		public static void AddType(FlatBufferBuilder builder, EHitBulletType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602503E RID: 151614 RVA: 0x00514901 File Offset: 0x00512B01
		public static void AddBulletId(FlatBufferBuilder builder, VectorOffset bulletIdOffset)
		{
			builder.AddOffset(1, bulletIdOffset.Value, 0);
		}

		// Token: 0x0602503F RID: 151615 RVA: 0x00514914 File Offset: 0x00512B14
		public static VectorOffset CreateBulletIdVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06025040 RID: 151616 RVA: 0x0051494B File Offset: 0x00512B4B
		public static VectorOffset CreateBulletIdVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x06025041 RID: 151617 RVA: 0x00514965 File Offset: 0x00512B65
		public static VectorOffset CreateBulletIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x06025042 RID: 151618 RVA: 0x00514983 File Offset: 0x00512B83
		public static VectorOffset CreateBulletIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025043 RID: 151619 RVA: 0x0051499C File Offset: 0x00512B9C
		public static void StartBulletIdVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x06025044 RID: 151620 RVA: 0x005149A7 File Offset: 0x00512BA7
		public static void AddPlayerAttack(FlatBufferBuilder builder, bool playerAttack)
		{
			builder.AddBool(2, playerAttack, false);
		}

		// Token: 0x06025045 RID: 151621 RVA: 0x005149B2 File Offset: 0x00512BB2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06025046 RID: 151622 RVA: 0x005149BD File Offset: 0x00512BBD
		public static Offset<IHitBulletTypeFixedBulletId> EndIHitBulletTypeFixedBulletId(FlatBufferBuilder builder)
		{
			return new Offset<IHitBulletTypeFixedBulletId>(builder.EndTable());
		}

		// Token: 0x06025047 RID: 151623 RVA: 0x005149CC File Offset: 0x00512BCC
		public IHitBulletTypeFixedBulletIdT UnPack()
		{
			IHitBulletTypeFixedBulletIdT hitBulletTypeFixedBulletIdT = new IHitBulletTypeFixedBulletIdT();
			this.UnPackTo(hitBulletTypeFixedBulletIdT);
			return hitBulletTypeFixedBulletIdT;
		}

		// Token: 0x06025048 RID: 151624 RVA: 0x005149E8 File Offset: 0x00512BE8
		public void UnPackTo(IHitBulletTypeFixedBulletIdT _o)
		{
			_o.Type = this.Type;
			_o.BulletId = new List<long>();
			for (int i = 0; i < this.BulletIdLength; i++)
			{
				_o.BulletId.Add(this.BulletId(i));
			}
			_o.PlayerAttack = this.PlayerAttack;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025049 RID: 151625 RVA: 0x00514A48 File Offset: 0x00512C48
		public static Offset<IHitBulletTypeFixedBulletId> Pack(FlatBufferBuilder builder, IHitBulletTypeFixedBulletIdT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitBulletTypeFixedBulletId>);
			}
			VectorOffset bulletIdOffset = default(VectorOffset);
			if (_o.BulletId != null)
			{
				long[] data = _o.BulletId.ToArray();
				bulletIdOffset = IHitBulletTypeFixedBulletId.CreateBulletIdVector(builder, data);
			}
			return IHitBulletTypeFixedBulletId.CreateIHitBulletTypeFixedBulletId(builder, _o.Type, bulletIdOffset, _o.PlayerAttack, _o.NullMask);
		}

		// Token: 0x0400F183 RID: 61827
		private Table __p;
	}
}
