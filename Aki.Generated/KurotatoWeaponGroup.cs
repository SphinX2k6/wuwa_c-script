using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EA0 RID: 3744
	public struct KurotatoWeaponGroup : IFlatbufferObject
	{
		// Token: 0x17001CD8 RID: 7384
		// (get) Token: 0x060092BE RID: 37566 RVA: 0x002932BA File Offset: 0x002914BA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060092BF RID: 37567 RVA: 0x002932C7 File Offset: 0x002914C7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060092C0 RID: 37568 RVA: 0x002932D0 File Offset: 0x002914D0
		public static KurotatoWeaponGroup GetRootAsKurotatoWeaponGroup(ByteBuffer _bb)
		{
			return KurotatoWeaponGroup.GetRootAsKurotatoWeaponGroup(_bb, default(KurotatoWeaponGroup));
		}

		// Token: 0x060092C1 RID: 37569 RVA: 0x002932EC File Offset: 0x002914EC
		public static KurotatoWeaponGroup GetRootAsKurotatoWeaponGroup(ByteBuffer _bb, KurotatoWeaponGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060092C2 RID: 37570 RVA: 0x00293309 File Offset: 0x00291509
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060092C3 RID: 37571 RVA: 0x00293318 File Offset: 0x00291518
		public KurotatoWeaponGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001CD9 RID: 7385
		// (get) Token: 0x060092C4 RID: 37572 RVA: 0x00293328 File Offset: 0x00291528
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

		// Token: 0x17001CDA RID: 7386
		// (get) Token: 0x060092C5 RID: 37573 RVA: 0x00293364 File Offset: 0x00291564
		public int ActivityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 3401;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001CDB RID: 7387
		// (get) Token: 0x060092C6 RID: 37574 RVA: 0x002933A4 File Offset: 0x002915A4
		public int TemplateId
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

		// Token: 0x17001CDC RID: 7388
		// (get) Token: 0x060092C7 RID: 37575 RVA: 0x002933E0 File Offset: 0x002915E0
		public int UnlockConditionId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060092C8 RID: 37576 RVA: 0x00293420 File Offset: 0x00291620
		public int WeaponBuildIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CDD RID: 7389
		// (get) Token: 0x060092C9 RID: 37577 RVA: 0x00293460 File Offset: 0x00291660
		public int WeaponBuildIdsLength
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

		// Token: 0x060092CA RID: 37578 RVA: 0x0029348C File Offset: 0x0029168C
		public Span<int> GetWeaponBuildIdsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x060092CB RID: 37579 RVA: 0x0029349C File Offset: 0x0029169C
		public int[] GetWeaponBuildIdsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17001CDE RID: 7390
		// (get) Token: 0x060092CC RID: 37580 RVA: 0x002934B4 File Offset: 0x002916B4
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

		// Token: 0x060092CD RID: 37581 RVA: 0x002934EC File Offset: 0x002916EC
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060092CE RID: 37582 RVA: 0x002934FC File Offset: 0x002916FC
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CDF RID: 7391
		// (get) Token: 0x060092CF RID: 37583 RVA: 0x00293514 File Offset: 0x00291714
		public bool IsVisibleInManual
		{
			get
			{
				int num = this.__p.__offset(16);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001CE0 RID: 7392
		// (get) Token: 0x060092D0 RID: 37584 RVA: 0x00293554 File Offset: 0x00291754
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

		// Token: 0x060092D1 RID: 37585 RVA: 0x0029358C File Offset: 0x0029178C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060092D2 RID: 37586 RVA: 0x0029359C File Offset: 0x0029179C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x060092D3 RID: 37587 RVA: 0x002935B4 File Offset: 0x002917B4
		public string DescParams(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CE1 RID: 7393
		// (get) Token: 0x060092D4 RID: 37588 RVA: 0x002935F0 File Offset: 0x002917F0
		public int DescParamsLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001CE2 RID: 7394
		// (get) Token: 0x060092D5 RID: 37589 RVA: 0x0029361C File Offset: 0x0029181C
		public string BgDesc
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060092D6 RID: 37590 RVA: 0x00293654 File Offset: 0x00291854
		public Span<byte> GetBgDescBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060092D7 RID: 37591 RVA: 0x00293664 File Offset: 0x00291864
		public byte[] GetBgDescArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CE3 RID: 7395
		// (get) Token: 0x060092D8 RID: 37592 RVA: 0x0029367C File Offset: 0x0029187C
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060092D9 RID: 37593 RVA: 0x002936B4 File Offset: 0x002918B4
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060092DA RID: 37594 RVA: 0x002936C4 File Offset: 0x002918C4
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x060092DB RID: 37595 RVA: 0x002936DC File Offset: 0x002918DC
		public string Tags(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CE4 RID: 7396
		// (get) Token: 0x060092DC RID: 37596 RVA: 0x00293718 File Offset: 0x00291918
		public int TagsLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001CE5 RID: 7397
		// (get) Token: 0x060092DD RID: 37597 RVA: 0x00293744 File Offset: 0x00291944
		public int Type
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060092DE RID: 37598 RVA: 0x00293781 File Offset: 0x00291981
		[NullableContext(1)]
		public string[] DescParams()
		{
			return this.DescParamsIter().ToArray<string>();
		}

		// Token: 0x060092DF RID: 37599 RVA: 0x0029378E File Offset: 0x0029198E
		[NullableContext(1)]
		public IEnumerable<string> DescParamsIter()
		{
			KurotatoWeaponGroup.<DescParamsIter>d__48 <DescParamsIter>d__ = new KurotatoWeaponGroup.<DescParamsIter>d__48(-2);
			<DescParamsIter>d__.<>3__<>4__this = this;
			return <DescParamsIter>d__;
		}

		// Token: 0x060092E0 RID: 37600 RVA: 0x002937A3 File Offset: 0x002919A3
		[NullableContext(1)]
		public string[] Tags()
		{
			return this.TagsIter().ToArray<string>();
		}

		// Token: 0x060092E1 RID: 37601 RVA: 0x002937B0 File Offset: 0x002919B0
		[NullableContext(1)]
		public IEnumerable<string> TagsIter()
		{
			KurotatoWeaponGroup.<TagsIter>d__50 <TagsIter>d__ = new KurotatoWeaponGroup.<TagsIter>d__50(-2);
			<TagsIter>d__.<>3__<>4__this = this;
			return <TagsIter>d__;
		}

		// Token: 0x060092E2 RID: 37602 RVA: 0x002937C5 File Offset: 0x002919C5
		[NullableContext(1)]
		public int[] WeaponBuildIds()
		{
			return this.GetWeaponBuildIdsArray();
		}

		// Token: 0x060092E3 RID: 37603 RVA: 0x002937CD File Offset: 0x002919CD
		[NullableContext(1)]
		public IEnumerable<int> WeaponBuildIdsIter()
		{
			KurotatoWeaponGroup.<WeaponBuildIdsIter>d__52 <WeaponBuildIdsIter>d__ = new KurotatoWeaponGroup.<WeaponBuildIdsIter>d__52(-2);
			<WeaponBuildIdsIter>d__.<>3__<>4__this = this;
			return <WeaponBuildIdsIter>d__;
		}

		// Token: 0x04005436 RID: 21558
		private Table __p;
	}
}
