using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BF1 RID: 3057
	public struct AvgShowPrefab : IFlatbufferObject
	{
		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06004F53 RID: 20307 RVA: 0x001FA71C File Offset: 0x001F891C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004F54 RID: 20308 RVA: 0x001FA729 File Offset: 0x001F8929
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004F55 RID: 20309 RVA: 0x001FA730 File Offset: 0x001F8930
		public static AvgShowPrefab GetRootAsAvgShowPrefab(ByteBuffer _bb)
		{
			return AvgShowPrefab.GetRootAsAvgShowPrefab(_bb, default(AvgShowPrefab));
		}

		// Token: 0x06004F56 RID: 20310 RVA: 0x001FA74C File Offset: 0x001F894C
		public static AvgShowPrefab GetRootAsAvgShowPrefab(ByteBuffer _bb, AvgShowPrefab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004F57 RID: 20311 RVA: 0x001FA769 File Offset: 0x001F8969
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004F58 RID: 20312 RVA: 0x001FA778 File Offset: 0x001F8978
		public AvgShowPrefab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06004F59 RID: 20313 RVA: 0x001FA788 File Offset: 0x001F8988
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

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06004F5A RID: 20314 RVA: 0x001FA7C4 File Offset: 0x001F89C4
		public string Description
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

		// Token: 0x06004F5B RID: 20315 RVA: 0x001FA7FB File Offset: 0x001F89FB
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004F5C RID: 20316 RVA: 0x001FA80A File Offset: 0x001F8A0A
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06004F5D RID: 20317 RVA: 0x001FA824 File Offset: 0x001F8A24
		public string HeroinePrefabPath
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

		// Token: 0x06004F5E RID: 20318 RVA: 0x001FA85B File Offset: 0x001F8A5B
		public Span<byte> GetHeroinePrefabPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004F5F RID: 20319 RVA: 0x001FA86A File Offset: 0x001F8A6A
		public byte[] GetHeroinePrefabPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06004F60 RID: 20320 RVA: 0x001FA884 File Offset: 0x001F8A84
		public string HeroPrefabPath
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

		// Token: 0x06004F61 RID: 20321 RVA: 0x001FA8BC File Offset: 0x001F8ABC
		public Span<byte> GetHeroPrefabPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004F62 RID: 20322 RVA: 0x001FA8CC File Offset: 0x001F8ACC
		public byte[] GetHeroPrefabPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040050D9 RID: 20697
		private Table __p;
	}
}
