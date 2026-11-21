using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D3A RID: 3386
	public struct ExploreType : IFlatbufferObject
	{
		// Token: 0x1700107C RID: 4220
		// (get) Token: 0x06007238 RID: 29240 RVA: 0x00249520 File Offset: 0x00247720
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007239 RID: 29241 RVA: 0x0024952D File Offset: 0x0024772D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600723A RID: 29242 RVA: 0x00249534 File Offset: 0x00247734
		public static ExploreType GetRootAsExploreType(ByteBuffer _bb)
		{
			return ExploreType.GetRootAsExploreType(_bb, default(ExploreType));
		}

		// Token: 0x0600723B RID: 29243 RVA: 0x00249550 File Offset: 0x00247750
		public static ExploreType GetRootAsExploreType(ByteBuffer _bb, ExploreType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600723C RID: 29244 RVA: 0x0024956D File Offset: 0x0024776D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600723D RID: 29245 RVA: 0x0024957C File Offset: 0x0024777C
		public ExploreType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700107D RID: 4221
		// (get) Token: 0x0600723E RID: 29246 RVA: 0x0024958C File Offset: 0x0024778C
		public int ExploreTypeKey
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

		// Token: 0x1700107E RID: 4222
		// (get) Token: 0x0600723F RID: 29247 RVA: 0x002495C8 File Offset: 0x002477C8
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

		// Token: 0x06007240 RID: 29248 RVA: 0x002495FF File Offset: 0x002477FF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007241 RID: 29249 RVA: 0x0024960E File Offset: 0x0024780E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700107F RID: 4223
		// (get) Token: 0x06007242 RID: 29250 RVA: 0x00249628 File Offset: 0x00247828
		public string Icon
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

		// Token: 0x06007243 RID: 29251 RVA: 0x0024965F File Offset: 0x0024785F
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007244 RID: 29252 RVA: 0x0024966E File Offset: 0x0024786E
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001080 RID: 4224
		// (get) Token: 0x06007245 RID: 29253 RVA: 0x00249688 File Offset: 0x00247888
		public string DescBg
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007246 RID: 29254 RVA: 0x002496C0 File Offset: 0x002478C0
		public Span<byte> GetDescBgBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007247 RID: 29255 RVA: 0x002496D0 File Offset: 0x002478D0
		public byte[] GetDescBgArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001081 RID: 4225
		// (get) Token: 0x06007248 RID: 29256 RVA: 0x002496E8 File Offset: 0x002478E8
		public string LockDescId
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

		// Token: 0x06007249 RID: 29257 RVA: 0x00249720 File Offset: 0x00247920
		public Span<byte> GetLockDescIdBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600724A RID: 29258 RVA: 0x00249730 File Offset: 0x00247930
		public byte[] GetLockDescIdArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001082 RID: 4226
		// (get) Token: 0x0600724B RID: 29259 RVA: 0x00249748 File Offset: 0x00247948
		public string DescId
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

		// Token: 0x0600724C RID: 29260 RVA: 0x00249780 File Offset: 0x00247980
		public Span<byte> GetDescIdBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600724D RID: 29261 RVA: 0x00249790 File Offset: 0x00247990
		public byte[] GetDescIdArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001083 RID: 4227
		// (get) Token: 0x0600724E RID: 29262 RVA: 0x002497A8 File Offset: 0x002479A8
		public int CountMode
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

		// Token: 0x17001084 RID: 4228
		// (get) Token: 0x0600724F RID: 29263 RVA: 0x002497E8 File Offset: 0x002479E8
		public int SortIndex
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005285 RID: 21125
		private Table __p;
	}
}
