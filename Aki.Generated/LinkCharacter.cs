using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EB3 RID: 3763
	public struct LinkCharacter : IFlatbufferObject
	{
		// Token: 0x17001D68 RID: 7528
		// (get) Token: 0x0600947A RID: 38010 RVA: 0x00296985 File Offset: 0x00294B85
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600947B RID: 38011 RVA: 0x00296992 File Offset: 0x00294B92
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600947C RID: 38012 RVA: 0x0029699C File Offset: 0x00294B9C
		public static LinkCharacter GetRootAsLinkCharacter(ByteBuffer _bb)
		{
			return LinkCharacter.GetRootAsLinkCharacter(_bb, default(LinkCharacter));
		}

		// Token: 0x0600947D RID: 38013 RVA: 0x002969B8 File Offset: 0x00294BB8
		public static LinkCharacter GetRootAsLinkCharacter(ByteBuffer _bb, LinkCharacter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600947E RID: 38014 RVA: 0x002969D5 File Offset: 0x00294BD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600947F RID: 38015 RVA: 0x002969E4 File Offset: 0x00294BE4
		public LinkCharacter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D69 RID: 7529
		// (get) Token: 0x06009480 RID: 38016 RVA: 0x002969F4 File Offset: 0x00294BF4
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

		// Token: 0x17001D6A RID: 7530
		// (get) Token: 0x06009481 RID: 38017 RVA: 0x00296A30 File Offset: 0x00294C30
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

		// Token: 0x17001D6B RID: 7531
		// (get) Token: 0x06009482 RID: 38018 RVA: 0x00296A6C File Offset: 0x00294C6C
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

		// Token: 0x17001D6C RID: 7532
		// (get) Token: 0x06009483 RID: 38019 RVA: 0x00296AA8 File Offset: 0x00294CA8
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

		// Token: 0x06009484 RID: 38020 RVA: 0x00296AE0 File Offset: 0x00294CE0
		public Span<byte> GetCharacterDataAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009485 RID: 38021 RVA: 0x00296AF0 File Offset: 0x00294CF0
		public byte[] GetCharacterDataAssetArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x06009486 RID: 38022 RVA: 0x00296B08 File Offset: 0x00294D08
		public string WeaponMeshList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D6D RID: 7533
		// (get) Token: 0x06009487 RID: 38023 RVA: 0x00296B44 File Offset: 0x00294D44
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

		// Token: 0x06009488 RID: 38024 RVA: 0x00296B70 File Offset: 0x00294D70
		public string WeaponAnimList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D6E RID: 7534
		// (get) Token: 0x06009489 RID: 38025 RVA: 0x00296BAC File Offset: 0x00294DAC
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

		// Token: 0x0600948A RID: 38026 RVA: 0x00296BD8 File Offset: 0x00294DD8
		public string CompNameList(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D6F RID: 7535
		// (get) Token: 0x0600948B RID: 38027 RVA: 0x00296C14 File Offset: 0x00294E14
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

		// Token: 0x17001D70 RID: 7536
		// (get) Token: 0x0600948C RID: 38028 RVA: 0x00296C40 File Offset: 0x00294E40
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

		// Token: 0x0600948D RID: 38029 RVA: 0x00296C78 File Offset: 0x00294E78
		public Span<byte> GetRoleLinkAudioBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600948E RID: 38030 RVA: 0x00296C88 File Offset: 0x00294E88
		public byte[] GetRoleLinkAudioArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600948F RID: 38031 RVA: 0x00296CA0 File Offset: 0x00294EA0
		[NullableContext(1)]
		public string[] CompNameList()
		{
			return this.CompNameListIter().ToArray<string>();
		}

		// Token: 0x06009490 RID: 38032 RVA: 0x00296CAD File Offset: 0x00294EAD
		[NullableContext(1)]
		public IEnumerable<string> CompNameListIter()
		{
			LinkCharacter.<CompNameListIter>d__32 <CompNameListIter>d__ = new LinkCharacter.<CompNameListIter>d__32(-2);
			<CompNameListIter>d__.<>3__<>4__this = this;
			return <CompNameListIter>d__;
		}

		// Token: 0x06009491 RID: 38033 RVA: 0x00296CC2 File Offset: 0x00294EC2
		[NullableContext(1)]
		public string[] WeaponAnimList()
		{
			return this.WeaponAnimListIter().ToArray<string>();
		}

		// Token: 0x06009492 RID: 38034 RVA: 0x00296CCF File Offset: 0x00294ECF
		[NullableContext(1)]
		public IEnumerable<string> WeaponAnimListIter()
		{
			LinkCharacter.<WeaponAnimListIter>d__34 <WeaponAnimListIter>d__ = new LinkCharacter.<WeaponAnimListIter>d__34(-2);
			<WeaponAnimListIter>d__.<>3__<>4__this = this;
			return <WeaponAnimListIter>d__;
		}

		// Token: 0x06009493 RID: 38035 RVA: 0x00296CE4 File Offset: 0x00294EE4
		[NullableContext(1)]
		public string[] WeaponMeshList()
		{
			return this.WeaponMeshListIter().ToArray<string>();
		}

		// Token: 0x06009494 RID: 38036 RVA: 0x00296CF1 File Offset: 0x00294EF1
		[NullableContext(1)]
		public IEnumerable<string> WeaponMeshListIter()
		{
			LinkCharacter.<WeaponMeshListIter>d__36 <WeaponMeshListIter>d__ = new LinkCharacter.<WeaponMeshListIter>d__36(-2);
			<WeaponMeshListIter>d__.<>3__<>4__this = this;
			return <WeaponMeshListIter>d__;
		}

		// Token: 0x04005449 RID: 21577
		private Table __p;
	}
}
