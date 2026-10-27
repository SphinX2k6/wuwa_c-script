using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DCE RID: 3534
	public struct LinkCharacter : IFlatbufferObject
	{
		// Token: 0x17001D04 RID: 7428
		// (get) Token: 0x06008E5E RID: 36446 RVA: 0x00278495 File Offset: 0x00276695
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008E5F RID: 36447 RVA: 0x002784A2 File Offset: 0x002766A2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008E60 RID: 36448 RVA: 0x002784AC File Offset: 0x002766AC
		public static LinkCharacter GetRootAsLinkCharacter(ByteBuffer _bb)
		{
			return LinkCharacter.GetRootAsLinkCharacter(_bb, default(LinkCharacter));
		}

		// Token: 0x06008E61 RID: 36449 RVA: 0x002784C8 File Offset: 0x002766C8
		public static LinkCharacter GetRootAsLinkCharacter(ByteBuffer _bb, LinkCharacter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008E62 RID: 36450 RVA: 0x002784E5 File Offset: 0x002766E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008E63 RID: 36451 RVA: 0x002784F4 File Offset: 0x002766F4
		public LinkCharacter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D05 RID: 7429
		// (get) Token: 0x06008E64 RID: 36452 RVA: 0x00278504 File Offset: 0x00276704
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

		// Token: 0x17001D06 RID: 7430
		// (get) Token: 0x06008E65 RID: 36453 RVA: 0x00278540 File Offset: 0x00276740
		public int RoleId
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

		// Token: 0x17001D07 RID: 7431
		// (get) Token: 0x06008E66 RID: 36454 RVA: 0x0027857C File Offset: 0x0027677C
		public int NeedLoadMesh
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

		// Token: 0x17001D08 RID: 7432
		// (get) Token: 0x06008E67 RID: 36455 RVA: 0x002785B8 File Offset: 0x002767B8
		public string CharacterDataAsset
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

		// Token: 0x06008E68 RID: 36456 RVA: 0x002785F0 File Offset: 0x002767F0
		public Span<byte> GetCharacterDataAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008E69 RID: 36457 RVA: 0x00278600 File Offset: 0x00276800
		public byte[] GetCharacterDataAssetArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x06008E6A RID: 36458 RVA: 0x00278618 File Offset: 0x00276818
		public string WeaponMeshList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D09 RID: 7433
		// (get) Token: 0x06008E6B RID: 36459 RVA: 0x00278654 File Offset: 0x00276854
		public int WeaponMeshListLength
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

		// Token: 0x06008E6C RID: 36460 RVA: 0x00278680 File Offset: 0x00276880
		public string WeaponAnimList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D0A RID: 7434
		// (get) Token: 0x06008E6D RID: 36461 RVA: 0x002786BC File Offset: 0x002768BC
		public int WeaponAnimListLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008E6E RID: 36462 RVA: 0x002786E8 File Offset: 0x002768E8
		public string CompNameList(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D0B RID: 7435
		// (get) Token: 0x06008E6F RID: 36463 RVA: 0x00278724 File Offset: 0x00276924
		public int CompNameListLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001D0C RID: 7436
		// (get) Token: 0x06008E70 RID: 36464 RVA: 0x00278750 File Offset: 0x00276950
		public string RoleLinkAudio
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

		// Token: 0x06008E71 RID: 36465 RVA: 0x00278788 File Offset: 0x00276988
		public Span<byte> GetRoleLinkAudioBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06008E72 RID: 36466 RVA: 0x00278798 File Offset: 0x00276998
		public byte[] GetRoleLinkAudioArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x06008E73 RID: 36467 RVA: 0x002787B0 File Offset: 0x002769B0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CompNameListIter()或GetCompNameListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] CompNameList()
		{
			return this.CompNameListIter().ToArray<string>();
		}

		// Token: 0x06008E74 RID: 36468 RVA: 0x002787BD File Offset: 0x002769BD
		[NullableContext(1)]
		public readonly IEnumerable<string> CompNameListIter()
		{
			LinkCharacter.<CompNameListIter>d__32 <CompNameListIter>d__ = new LinkCharacter.<CompNameListIter>d__32(-2);
			<CompNameListIter>d__.<>3__<>4__this = this;
			return <CompNameListIter>d__;
		}

		// Token: 0x06008E75 RID: 36469 RVA: 0x002787D2 File Offset: 0x002769D2
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用WeaponAnimListIter()或GetWeaponAnimListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] WeaponAnimList()
		{
			return this.WeaponAnimListIter().ToArray<string>();
		}

		// Token: 0x06008E76 RID: 36470 RVA: 0x002787DF File Offset: 0x002769DF
		[NullableContext(1)]
		public readonly IEnumerable<string> WeaponAnimListIter()
		{
			LinkCharacter.<WeaponAnimListIter>d__34 <WeaponAnimListIter>d__ = new LinkCharacter.<WeaponAnimListIter>d__34(-2);
			<WeaponAnimListIter>d__.<>3__<>4__this = this;
			return <WeaponAnimListIter>d__;
		}

		// Token: 0x06008E77 RID: 36471 RVA: 0x002787F4 File Offset: 0x002769F4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用WeaponMeshListIter()或GetWeaponMeshListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] WeaponMeshList()
		{
			return this.WeaponMeshListIter().ToArray<string>();
		}

		// Token: 0x06008E78 RID: 36472 RVA: 0x00278801 File Offset: 0x00276A01
		[NullableContext(1)]
		public readonly IEnumerable<string> WeaponMeshListIter()
		{
			LinkCharacter.<WeaponMeshListIter>d__36 <WeaponMeshListIter>d__ = new LinkCharacter.<WeaponMeshListIter>d__36(-2);
			<WeaponMeshListIter>d__.<>3__<>4__this = this;
			return <WeaponMeshListIter>d__;
		}

		// Token: 0x04004E64 RID: 20068
		private Table __p;
	}
}
