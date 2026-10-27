using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200119D RID: 4509
	public struct WeaponVisibleConfig : IFlatbufferObject
	{
		// Token: 0x17003E35 RID: 15925
		// (get) Token: 0x0600E891 RID: 59537 RVA: 0x0034432B File Offset: 0x0034252B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E892 RID: 59538 RVA: 0x00344338 File Offset: 0x00342538
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E893 RID: 59539 RVA: 0x00344340 File Offset: 0x00342540
		public static WeaponVisibleConfig GetRootAsWeaponVisibleConfig(ByteBuffer _bb)
		{
			return WeaponVisibleConfig.GetRootAsWeaponVisibleConfig(_bb, default(WeaponVisibleConfig));
		}

		// Token: 0x0600E894 RID: 59540 RVA: 0x0034435C File Offset: 0x0034255C
		public static WeaponVisibleConfig GetRootAsWeaponVisibleConfig(ByteBuffer _bb, WeaponVisibleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E895 RID: 59541 RVA: 0x00344379 File Offset: 0x00342579
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E896 RID: 59542 RVA: 0x00344388 File Offset: 0x00342588
		public WeaponVisibleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E36 RID: 15926
		// (get) Token: 0x0600E897 RID: 59543 RVA: 0x00344398 File Offset: 0x00342598
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

		// Token: 0x0600E898 RID: 59544 RVA: 0x003443D4 File Offset: 0x003425D4
		public int BaseType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003E37 RID: 15927
		// (get) Token: 0x0600E899 RID: 59545 RVA: 0x00344414 File Offset: 0x00342614
		public int BaseTypeLength
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

		// Token: 0x0600E89A RID: 59546 RVA: 0x0034443F File Offset: 0x0034263F
		public Span<int> GetBaseTypeBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600E89B RID: 59547 RVA: 0x0034444E File Offset: 0x0034264E
		public int[] GetBaseTypeArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600E89C RID: 59548 RVA: 0x00344468 File Offset: 0x00342668
		public string VisibleTags(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003E38 RID: 15928
		// (get) Token: 0x0600E89D RID: 59549 RVA: 0x003444A4 File Offset: 0x003426A4
		public int VisibleTagsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E89E RID: 59550 RVA: 0x003444D0 File Offset: 0x003426D0
		public string HiddenTags(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003E39 RID: 15929
		// (get) Token: 0x0600E89F RID: 59551 RVA: 0x0034450C File Offset: 0x0034270C
		public int HiddenTagsLength
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

		// Token: 0x0600E8A0 RID: 59552 RVA: 0x00344538 File Offset: 0x00342738
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BaseTypeIter()或GetBaseTypeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BaseType()
		{
			WeaponVisibleConfig weaponVisibleConfig = this;
			return weaponVisibleConfig.GetBaseTypeArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E8A1 RID: 59553 RVA: 0x0034455C File Offset: 0x0034275C
		[NullableContext(1)]
		public readonly IEnumerable<int> BaseTypeIter()
		{
			WeaponVisibleConfig.<BaseTypeIter>d__22 <BaseTypeIter>d__ = new WeaponVisibleConfig.<BaseTypeIter>d__22(-2);
			<BaseTypeIter>d__.<>3__<>4__this = this;
			return <BaseTypeIter>d__;
		}

		// Token: 0x0600E8A2 RID: 59554 RVA: 0x00344571 File Offset: 0x00342771
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用HiddenTagsIter()或GetHiddenTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] HiddenTags()
		{
			return this.HiddenTagsIter().ToArray<string>();
		}

		// Token: 0x0600E8A3 RID: 59555 RVA: 0x0034457E File Offset: 0x0034277E
		[NullableContext(1)]
		public readonly IEnumerable<string> HiddenTagsIter()
		{
			WeaponVisibleConfig.<HiddenTagsIter>d__24 <HiddenTagsIter>d__ = new WeaponVisibleConfig.<HiddenTagsIter>d__24(-2);
			<HiddenTagsIter>d__.<>3__<>4__this = this;
			return <HiddenTagsIter>d__;
		}

		// Token: 0x0600E8A4 RID: 59556 RVA: 0x00344593 File Offset: 0x00342793
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用VisibleTagsIter()或GetVisibleTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] VisibleTags()
		{
			return this.VisibleTagsIter().ToArray<string>();
		}

		// Token: 0x0600E8A5 RID: 59557 RVA: 0x003445A0 File Offset: 0x003427A0
		[NullableContext(1)]
		public readonly IEnumerable<string> VisibleTagsIter()
		{
			WeaponVisibleConfig.<VisibleTagsIter>d__26 <VisibleTagsIter>d__ = new WeaponVisibleConfig.<VisibleTagsIter>d__26(-2);
			<VisibleTagsIter>d__.<>3__<>4__this = this;
			return <VisibleTagsIter>d__;
		}

		// Token: 0x040052E8 RID: 21224
		private Table __p;
	}
}
