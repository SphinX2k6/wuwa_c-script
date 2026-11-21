using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F4E RID: 3918
	public struct MotorSkinShow : IFlatbufferObject
	{
		// Token: 0x17002288 RID: 8840
		// (get) Token: 0x0600A21E RID: 41502 RVA: 0x002B485B File Offset: 0x002B2A5B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A21F RID: 41503 RVA: 0x002B4868 File Offset: 0x002B2A68
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A220 RID: 41504 RVA: 0x002B4870 File Offset: 0x002B2A70
		public static MotorSkinShow GetRootAsMotorSkinShow(ByteBuffer _bb)
		{
			return MotorSkinShow.GetRootAsMotorSkinShow(_bb, default(MotorSkinShow));
		}

		// Token: 0x0600A221 RID: 41505 RVA: 0x002B488C File Offset: 0x002B2A8C
		public static MotorSkinShow GetRootAsMotorSkinShow(ByteBuffer _bb, MotorSkinShow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A222 RID: 41506 RVA: 0x002B48A9 File Offset: 0x002B2AA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A223 RID: 41507 RVA: 0x002B48B8 File Offset: 0x002B2AB8
		public MotorSkinShow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002289 RID: 8841
		// (get) Token: 0x0600A224 RID: 41508 RVA: 0x002B48C8 File Offset: 0x002B2AC8
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

		// Token: 0x1700228A RID: 8842
		// (get) Token: 0x0600A225 RID: 41509 RVA: 0x002B4904 File Offset: 0x002B2B04
		public int QualityId
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

		// Token: 0x1700228B RID: 8843
		// (get) Token: 0x0600A226 RID: 41510 RVA: 0x002B4940 File Offset: 0x002B2B40
		public int FreeItem
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

		// Token: 0x0600A227 RID: 41511 RVA: 0x002B497C File Offset: 0x002B2B7C
		public DicStringInt? ItemCount(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicStringInt?(default(DicStringInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700228C RID: 8844
		// (get) Token: 0x0600A228 RID: 41512 RVA: 0x002B49E0 File Offset: 0x002B2BE0
		public int ItemCountLength
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

		// Token: 0x1700228D RID: 8845
		// (get) Token: 0x0600A229 RID: 41513 RVA: 0x002B4A0C File Offset: 0x002B2C0C
		public string Icon
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

		// Token: 0x0600A22A RID: 41514 RVA: 0x002B4A44 File Offset: 0x002B2C44
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A22B RID: 41515 RVA: 0x002B4A54 File Offset: 0x002B2C54
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700228E RID: 8846
		// (get) Token: 0x0600A22C RID: 41516 RVA: 0x002B4A6C File Offset: 0x002B2C6C
		public string Name
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

		// Token: 0x0600A22D RID: 41517 RVA: 0x002B4AA4 File Offset: 0x002B2CA4
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A22E RID: 41518 RVA: 0x002B4AB4 File Offset: 0x002B2CB4
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700228F RID: 8847
		// (get) Token: 0x0600A22F RID: 41519 RVA: 0x002B4ACC File Offset: 0x002B2CCC
		public string TypeDescription
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

		// Token: 0x0600A230 RID: 41520 RVA: 0x002B4B04 File Offset: 0x002B2D04
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A231 RID: 41521 RVA: 0x002B4B14 File Offset: 0x002B2D14
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002290 RID: 8848
		// (get) Token: 0x0600A232 RID: 41522 RVA: 0x002B4B2C File Offset: 0x002B2D2C
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A233 RID: 41523 RVA: 0x002B4B64 File Offset: 0x002B2D64
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600A234 RID: 41524 RVA: 0x002B4B74 File Offset: 0x002B2D74
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002291 RID: 8849
		// (get) Token: 0x0600A235 RID: 41525 RVA: 0x002B4B8C File Offset: 0x002B2D8C
		public int JumpDiyRoot
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A236 RID: 41526 RVA: 0x002B4BCC File Offset: 0x002B2DCC
		[NullableContext(1)]
		public Dictionary<string, int> ItemCount()
		{
			return this.ItemCountIter().ToDictionary((DicStringInt element) => element.Key, (DicStringInt element) => element.Value);
		}

		// Token: 0x0600A237 RID: 41527 RVA: 0x002B4C22 File Offset: 0x002B2E22
		[NullableContext(1)]
		public IEnumerable<DicStringInt> ItemCountIter()
		{
			MotorSkinShow.<ItemCountIter>d__36 <ItemCountIter>d__ = new MotorSkinShow.<ItemCountIter>d__36(-2);
			<ItemCountIter>d__.<>3__<>4__this = this;
			return <ItemCountIter>d__;
		}

		// Token: 0x0600A238 RID: 41528 RVA: 0x002B4C38 File Offset: 0x002B2E38
		[NullableContext(1)]
		public int? GetItemCount(string key)
		{
			this.EnsureItemCountCacheIfNeeded();
			int value;
			if (!this.ItemCountCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600A239 RID: 41529 RVA: 0x002B4C6C File Offset: 0x002B2E6C
		private void EnsureItemCountCacheIfNeeded()
		{
			if (this.ItemCountCache != null)
			{
				return;
			}
			this.ItemCountCache = this.ItemCountIter().ToFrozenDictionary((DicStringInt kvp) => kvp.Key, (DicStringInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600A23A RID: 41530 RVA: 0x002B4CD2 File Offset: 0x002B2ED2
		[NullableContext(1)]
		public FrozenDictionary<string, int> GetItemCountFrozenDict()
		{
			this.EnsureItemCountCacheIfNeeded();
			return this.ItemCountCache;
		}

		// Token: 0x040054FA RID: 21754
		private Table __p;

		// Token: 0x040054FB RID: 21755
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, int> ItemCountCache;
	}
}
