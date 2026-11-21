using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C6C RID: 3180
	public struct ComicDisplayConfig : IFlatbufferObject
	{
		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06005D0C RID: 23820 RVA: 0x0021A1E0 File Offset: 0x002183E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005D0D RID: 23821 RVA: 0x0021A1ED File Offset: 0x002183ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005D0E RID: 23822 RVA: 0x0021A1F4 File Offset: 0x002183F4
		public static ComicDisplayConfig GetRootAsComicDisplayConfig(ByteBuffer _bb)
		{
			return ComicDisplayConfig.GetRootAsComicDisplayConfig(_bb, default(ComicDisplayConfig));
		}

		// Token: 0x06005D0F RID: 23823 RVA: 0x0021A210 File Offset: 0x00218410
		public static ComicDisplayConfig GetRootAsComicDisplayConfig(ByteBuffer _bb, ComicDisplayConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005D10 RID: 23824 RVA: 0x0021A22D File Offset: 0x0021842D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005D11 RID: 23825 RVA: 0x0021A23C File Offset: 0x0021843C
		public ComicDisplayConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06005D12 RID: 23826 RVA: 0x0021A24C File Offset: 0x0021844C
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

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06005D13 RID: 23827 RVA: 0x0021A288 File Offset: 0x00218488
		public string ViewName
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

		// Token: 0x06005D14 RID: 23828 RVA: 0x0021A2BF File Offset: 0x002184BF
		public Span<byte> GetViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005D15 RID: 23829 RVA: 0x0021A2CE File Offset: 0x002184CE
		public byte[] GetViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06005D16 RID: 23830 RVA: 0x0021A2E8 File Offset: 0x002184E8
		public string ResourceId
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

		// Token: 0x06005D17 RID: 23831 RVA: 0x0021A31F File Offset: 0x0021851F
		public Span<byte> GetResourceIdBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005D18 RID: 23832 RVA: 0x0021A32E File Offset: 0x0021852E
		public byte[] GetResourceIdArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06005D19 RID: 23833 RVA: 0x0021A348 File Offset: 0x00218548
		public int PrefabList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06005D1A RID: 23834 RVA: 0x0021A388 File Offset: 0x00218588
		public int PrefabListLength
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

		// Token: 0x06005D1B RID: 23835 RVA: 0x0021A3B4 File Offset: 0x002185B4
		public Span<int> GetPrefabListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06005D1C RID: 23836 RVA: 0x0021A3C4 File Offset: 0x002185C4
		public int[] GetPrefabListArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x06005D1D RID: 23837 RVA: 0x0021A3DC File Offset: 0x002185DC
		[NullableContext(1)]
		public int[] PrefabList()
		{
			return this.GetPrefabListArray();
		}

		// Token: 0x06005D1E RID: 23838 RVA: 0x0021A3E4 File Offset: 0x002185E4
		[NullableContext(1)]
		public IEnumerable<int> PrefabListIter()
		{
			ComicDisplayConfig.<PrefabListIter>d__24 <PrefabListIter>d__ = new ComicDisplayConfig.<PrefabListIter>d__24(-2);
			<PrefabListIter>d__.<>3__<>4__this = this;
			return <PrefabListIter>d__;
		}

		// Token: 0x0400517B RID: 20859
		private Table __p;
	}
}
