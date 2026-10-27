using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DBB RID: 3515
	public struct KurotatoWeaponGroup : IFlatbufferObject
	{
		// Token: 0x17001C74 RID: 7284
		// (get) Token: 0x06008CA2 RID: 36002 RVA: 0x00274B81 File Offset: 0x00272D81
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008CA3 RID: 36003 RVA: 0x00274B8E File Offset: 0x00272D8E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008CA4 RID: 36004 RVA: 0x00274B98 File Offset: 0x00272D98
		public static KurotatoWeaponGroup GetRootAsKurotatoWeaponGroup(ByteBuffer _bb)
		{
			return KurotatoWeaponGroup.GetRootAsKurotatoWeaponGroup(_bb, default(KurotatoWeaponGroup));
		}

		// Token: 0x06008CA5 RID: 36005 RVA: 0x00274BB4 File Offset: 0x00272DB4
		public static KurotatoWeaponGroup GetRootAsKurotatoWeaponGroup(ByteBuffer _bb, KurotatoWeaponGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008CA6 RID: 36006 RVA: 0x00274BD1 File Offset: 0x00272DD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008CA7 RID: 36007 RVA: 0x00274BE0 File Offset: 0x00272DE0
		public KurotatoWeaponGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001C75 RID: 7285
		// (get) Token: 0x06008CA8 RID: 36008 RVA: 0x00274BF0 File Offset: 0x00272DF0
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

		// Token: 0x17001C76 RID: 7286
		// (get) Token: 0x06008CA9 RID: 36009 RVA: 0x00274C2C File Offset: 0x00272E2C
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

		// Token: 0x17001C77 RID: 7287
		// (get) Token: 0x06008CAA RID: 36010 RVA: 0x00274C6C File Offset: 0x00272E6C
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

		// Token: 0x17001C78 RID: 7288
		// (get) Token: 0x06008CAB RID: 36011 RVA: 0x00274CA8 File Offset: 0x00272EA8
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

		// Token: 0x06008CAC RID: 36012 RVA: 0x00274CE8 File Offset: 0x00272EE8
		public int WeaponBuildIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C79 RID: 7289
		// (get) Token: 0x06008CAD RID: 36013 RVA: 0x00274D28 File Offset: 0x00272F28
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

		// Token: 0x06008CAE RID: 36014 RVA: 0x00274D54 File Offset: 0x00272F54
		public Span<int> GetWeaponBuildIdsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06008CAF RID: 36015 RVA: 0x00274D64 File Offset: 0x00272F64
		public int[] GetWeaponBuildIdsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17001C7A RID: 7290
		// (get) Token: 0x06008CB0 RID: 36016 RVA: 0x00274D7C File Offset: 0x00272F7C
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

		// Token: 0x06008CB1 RID: 36017 RVA: 0x00274DB4 File Offset: 0x00272FB4
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06008CB2 RID: 36018 RVA: 0x00274DC4 File Offset: 0x00272FC4
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C7B RID: 7291
		// (get) Token: 0x06008CB3 RID: 36019 RVA: 0x00274DDC File Offset: 0x00272FDC
		public bool IsVisibleInManual
		{
			get
			{
				int num = this.__p.__offset(16);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001C7C RID: 7292
		// (get) Token: 0x06008CB4 RID: 36020 RVA: 0x00274E1C File Offset: 0x0027301C
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

		// Token: 0x06008CB5 RID: 36021 RVA: 0x00274E54 File Offset: 0x00273054
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06008CB6 RID: 36022 RVA: 0x00274E64 File Offset: 0x00273064
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x06008CB7 RID: 36023 RVA: 0x00274E7C File Offset: 0x0027307C
		public string DescParams(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C7D RID: 7293
		// (get) Token: 0x06008CB8 RID: 36024 RVA: 0x00274EB8 File Offset: 0x002730B8
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

		// Token: 0x17001C7E RID: 7294
		// (get) Token: 0x06008CB9 RID: 36025 RVA: 0x00274EE4 File Offset: 0x002730E4
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

		// Token: 0x06008CBA RID: 36026 RVA: 0x00274F1C File Offset: 0x0027311C
		public Span<byte> GetBgDescBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06008CBB RID: 36027 RVA: 0x00274F2C File Offset: 0x0027312C
		public byte[] GetBgDescArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C7F RID: 7295
		// (get) Token: 0x06008CBC RID: 36028 RVA: 0x00274F44 File Offset: 0x00273144
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

		// Token: 0x06008CBD RID: 36029 RVA: 0x00274F7C File Offset: 0x0027317C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06008CBE RID: 36030 RVA: 0x00274F8C File Offset: 0x0027318C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x06008CBF RID: 36031 RVA: 0x00274FA4 File Offset: 0x002731A4
		public string Tags(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C80 RID: 7296
		// (get) Token: 0x06008CC0 RID: 36032 RVA: 0x00274FE0 File Offset: 0x002731E0
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

		// Token: 0x17001C81 RID: 7297
		// (get) Token: 0x06008CC1 RID: 36033 RVA: 0x0027500C File Offset: 0x0027320C
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

		// Token: 0x06008CC2 RID: 36034 RVA: 0x00275049 File Offset: 0x00273249
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescParamsIter()或GetDescParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescParams()
		{
			return this.DescParamsIter().ToArray<string>();
		}

		// Token: 0x06008CC3 RID: 36035 RVA: 0x00275056 File Offset: 0x00273256
		[NullableContext(1)]
		public readonly IEnumerable<string> DescParamsIter()
		{
			KurotatoWeaponGroup.<DescParamsIter>d__48 <DescParamsIter>d__ = new KurotatoWeaponGroup.<DescParamsIter>d__48(-2);
			<DescParamsIter>d__.<>3__<>4__this = this;
			return <DescParamsIter>d__;
		}

		// Token: 0x06008CC4 RID: 36036 RVA: 0x0027506B File Offset: 0x0027326B
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TagsIter()或GetTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Tags()
		{
			return this.TagsIter().ToArray<string>();
		}

		// Token: 0x06008CC5 RID: 36037 RVA: 0x00275078 File Offset: 0x00273278
		[NullableContext(1)]
		public readonly IEnumerable<string> TagsIter()
		{
			KurotatoWeaponGroup.<TagsIter>d__50 <TagsIter>d__ = new KurotatoWeaponGroup.<TagsIter>d__50(-2);
			<TagsIter>d__.<>3__<>4__this = this;
			return <TagsIter>d__;
		}

		// Token: 0x06008CC6 RID: 36038 RVA: 0x00275090 File Offset: 0x00273290
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用WeaponBuildIdsIter()或GetWeaponBuildIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] WeaponBuildIds()
		{
			KurotatoWeaponGroup kurotatoWeaponGroup = this;
			return kurotatoWeaponGroup.GetWeaponBuildIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008CC7 RID: 36039 RVA: 0x002750B4 File Offset: 0x002732B4
		[NullableContext(1)]
		public readonly IEnumerable<int> WeaponBuildIdsIter()
		{
			KurotatoWeaponGroup.<WeaponBuildIdsIter>d__52 <WeaponBuildIdsIter>d__ = new KurotatoWeaponGroup.<WeaponBuildIdsIter>d__52(-2);
			<WeaponBuildIdsIter>d__.<>3__<>4__this = this;
			return <WeaponBuildIdsIter>d__;
		}

		// Token: 0x04004E51 RID: 20049
		private Table __p;
	}
}
