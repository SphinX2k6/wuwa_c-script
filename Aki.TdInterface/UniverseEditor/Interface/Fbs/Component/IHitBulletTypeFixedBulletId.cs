using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005377 RID: 21367
	public struct IHitBulletTypeFixedBulletId : IFlatbufferObject
	{
		// Token: 0x17009CFE RID: 40190
		// (get) Token: 0x06022F7A RID: 143226 RVA: 0x004D7840 File Offset: 0x004D5A40
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022F7B RID: 143227 RVA: 0x004D784D File Offset: 0x004D5A4D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022F7C RID: 143228 RVA: 0x004D7854 File Offset: 0x004D5A54
		public static IHitBulletTypeFixedBulletId GetRootAsIHitBulletTypeFixedBulletId(ByteBuffer _bb)
		{
			return IHitBulletTypeFixedBulletId.GetRootAsIHitBulletTypeFixedBulletId(_bb, default(IHitBulletTypeFixedBulletId));
		}

		// Token: 0x06022F7D RID: 143229 RVA: 0x004D7870 File Offset: 0x004D5A70
		public static IHitBulletTypeFixedBulletId GetRootAsIHitBulletTypeFixedBulletId(ByteBuffer _bb, IHitBulletTypeFixedBulletId obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022F7E RID: 143230 RVA: 0x004D788D File Offset: 0x004D5A8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022F7F RID: 143231 RVA: 0x004D789C File Offset: 0x004D5A9C
		public IHitBulletTypeFixedBulletId __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009CFF RID: 40191
		// (get) Token: 0x06022F80 RID: 143232 RVA: 0x004D78AC File Offset: 0x004D5AAC
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

		// Token: 0x06022F81 RID: 143233 RVA: 0x004D78E8 File Offset: 0x004D5AE8
		public long BulletId(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x17009D00 RID: 40192
		// (get) Token: 0x06022F82 RID: 143234 RVA: 0x004D7928 File Offset: 0x004D5B28
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

		// Token: 0x06022F83 RID: 143235 RVA: 0x004D7953 File Offset: 0x004D5B53
		public Span<long> GetBulletIdBytes()
		{
			return this.__p.__vector_as_span<long>(6, 8);
		}

		// Token: 0x06022F84 RID: 143236 RVA: 0x004D7962 File Offset: 0x004D5B62
		public long[] GetBulletIdArray()
		{
			return this.__p.__vector_as_array<long>(6);
		}

		// Token: 0x17009D01 RID: 40193
		// (get) Token: 0x06022F85 RID: 143237 RVA: 0x004D7970 File Offset: 0x004D5B70
		public bool PlayerAttack
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009D02 RID: 40194
		// (get) Token: 0x06022F86 RID: 143238 RVA: 0x004D79B0 File Offset: 0x004D5BB0
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

		// Token: 0x06022F87 RID: 143239 RVA: 0x004D79ED File Offset: 0x004D5BED
		public static Offset<IHitBulletTypeFixedBulletId> CreateIHitBulletTypeFixedBulletId(FlatBufferBuilder builder, EHitBulletType Type = EHitBulletType.OnlyDropAttack, VectorOffset BulletIdOffset = default(VectorOffset), bool PlayerAttack = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IHitBulletTypeFixedBulletId.AddBulletId(builder, BulletIdOffset);
			IHitBulletTypeFixedBulletId.AddNullMask(builder, NullMask);
			IHitBulletTypeFixedBulletId.AddPlayerAttack(builder, PlayerAttack);
			IHitBulletTypeFixedBulletId.AddType(builder, Type);
			return IHitBulletTypeFixedBulletId.EndIHitBulletTypeFixedBulletId(builder);
		}

		// Token: 0x06022F88 RID: 143240 RVA: 0x004D7A19 File Offset: 0x004D5C19
		public static void StartIHitBulletTypeFixedBulletId(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06022F89 RID: 143241 RVA: 0x004D7A22 File Offset: 0x004D5C22
		public static void AddType(FlatBufferBuilder builder, EHitBulletType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022F8A RID: 143242 RVA: 0x004D7A2D File Offset: 0x004D5C2D
		public static void AddBulletId(FlatBufferBuilder builder, VectorOffset bulletIdOffset)
		{
			builder.AddOffset(1, bulletIdOffset.Value, 0);
		}

		// Token: 0x06022F8B RID: 143243 RVA: 0x004D7A40 File Offset: 0x004D5C40
		public static VectorOffset CreateBulletIdVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06022F8C RID: 143244 RVA: 0x004D7A77 File Offset: 0x004D5C77
		public static VectorOffset CreateBulletIdVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x06022F8D RID: 143245 RVA: 0x004D7A91 File Offset: 0x004D5C91
		public static VectorOffset CreateBulletIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x06022F8E RID: 143246 RVA: 0x004D7AAF File Offset: 0x004D5CAF
		public static VectorOffset CreateBulletIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022F8F RID: 143247 RVA: 0x004D7AC8 File Offset: 0x004D5CC8
		public static void StartBulletIdVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x06022F90 RID: 143248 RVA: 0x004D7AD3 File Offset: 0x004D5CD3
		public static void AddPlayerAttack(FlatBufferBuilder builder, bool playerAttack)
		{
			builder.AddBool(2, playerAttack, false);
		}

		// Token: 0x06022F91 RID: 143249 RVA: 0x004D7ADE File Offset: 0x004D5CDE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06022F92 RID: 143250 RVA: 0x004D7AE9 File Offset: 0x004D5CE9
		public static Offset<IHitBulletTypeFixedBulletId> EndIHitBulletTypeFixedBulletId(FlatBufferBuilder builder)
		{
			return new Offset<IHitBulletTypeFixedBulletId>(builder.EndTable());
		}

		// Token: 0x06022F93 RID: 143251 RVA: 0x004D7AF8 File Offset: 0x004D5CF8
		public IHitBulletTypeFixedBulletIdT UnPack()
		{
			IHitBulletTypeFixedBulletIdT hitBulletTypeFixedBulletIdT = new IHitBulletTypeFixedBulletIdT();
			this.UnPackTo(hitBulletTypeFixedBulletIdT);
			return hitBulletTypeFixedBulletIdT;
		}

		// Token: 0x06022F94 RID: 143252 RVA: 0x004D7B14 File Offset: 0x004D5D14
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

		// Token: 0x06022F95 RID: 143253 RVA: 0x004D7B74 File Offset: 0x004D5D74
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

		// Token: 0x0400E553 RID: 58707
		private Table __p;
	}
}
