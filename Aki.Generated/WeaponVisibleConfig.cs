using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012D3 RID: 4819
	public struct WeaponVisibleConfig : IFlatbufferObject
	{
		// Token: 0x1700419A RID: 16794
		// (get) Token: 0x0600F602 RID: 62978 RVA: 0x0036F02F File Offset: 0x0036D22F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F603 RID: 62979 RVA: 0x0036F03C File Offset: 0x0036D23C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F604 RID: 62980 RVA: 0x0036F044 File Offset: 0x0036D244
		public static WeaponVisibleConfig GetRootAsWeaponVisibleConfig(ByteBuffer _bb)
		{
			return WeaponVisibleConfig.GetRootAsWeaponVisibleConfig(_bb, default(WeaponVisibleConfig));
		}

		// Token: 0x0600F605 RID: 62981 RVA: 0x0036F060 File Offset: 0x0036D260
		public static WeaponVisibleConfig GetRootAsWeaponVisibleConfig(ByteBuffer _bb, WeaponVisibleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F606 RID: 62982 RVA: 0x0036F07D File Offset: 0x0036D27D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F607 RID: 62983 RVA: 0x0036F08C File Offset: 0x0036D28C
		public WeaponVisibleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700419B RID: 16795
		// (get) Token: 0x0600F608 RID: 62984 RVA: 0x0036F09C File Offset: 0x0036D29C
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

		// Token: 0x0600F609 RID: 62985 RVA: 0x0036F0D8 File Offset: 0x0036D2D8
		public int BaseType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700419C RID: 16796
		// (get) Token: 0x0600F60A RID: 62986 RVA: 0x0036F118 File Offset: 0x0036D318
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

		// Token: 0x0600F60B RID: 62987 RVA: 0x0036F143 File Offset: 0x0036D343
		public Span<int> GetBaseTypeBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600F60C RID: 62988 RVA: 0x0036F152 File Offset: 0x0036D352
		public int[] GetBaseTypeArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600F60D RID: 62989 RVA: 0x0036F16C File Offset: 0x0036D36C
		public string VisibleTags(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700419D RID: 16797
		// (get) Token: 0x0600F60E RID: 62990 RVA: 0x0036F1A8 File Offset: 0x0036D3A8
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

		// Token: 0x0600F60F RID: 62991 RVA: 0x0036F1D4 File Offset: 0x0036D3D4
		public string HiddenTags(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700419E RID: 16798
		// (get) Token: 0x0600F610 RID: 62992 RVA: 0x0036F210 File Offset: 0x0036D410
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

		// Token: 0x0600F611 RID: 62993 RVA: 0x0036F23C File Offset: 0x0036D43C
		[NullableContext(1)]
		public int[] BaseType()
		{
			return this.GetBaseTypeArray();
		}

		// Token: 0x0600F612 RID: 62994 RVA: 0x0036F244 File Offset: 0x0036D444
		[NullableContext(1)]
		public IEnumerable<int> BaseTypeIter()
		{
			WeaponVisibleConfig.<BaseTypeIter>d__22 <BaseTypeIter>d__ = new WeaponVisibleConfig.<BaseTypeIter>d__22(-2);
			<BaseTypeIter>d__.<>3__<>4__this = this;
			return <BaseTypeIter>d__;
		}

		// Token: 0x0600F613 RID: 62995 RVA: 0x0036F259 File Offset: 0x0036D459
		[NullableContext(1)]
		public string[] HiddenTags()
		{
			return this.HiddenTagsIter().ToArray<string>();
		}

		// Token: 0x0600F614 RID: 62996 RVA: 0x0036F266 File Offset: 0x0036D466
		[NullableContext(1)]
		public IEnumerable<string> HiddenTagsIter()
		{
			WeaponVisibleConfig.<HiddenTagsIter>d__24 <HiddenTagsIter>d__ = new WeaponVisibleConfig.<HiddenTagsIter>d__24(-2);
			<HiddenTagsIter>d__.<>3__<>4__this = this;
			return <HiddenTagsIter>d__;
		}

		// Token: 0x0600F615 RID: 62997 RVA: 0x0036F27B File Offset: 0x0036D47B
		[NullableContext(1)]
		public string[] VisibleTags()
		{
			return this.VisibleTagsIter().ToArray<string>();
		}

		// Token: 0x0600F616 RID: 62998 RVA: 0x0036F288 File Offset: 0x0036D488
		[NullableContext(1)]
		public IEnumerable<string> VisibleTagsIter()
		{
			WeaponVisibleConfig.<VisibleTagsIter>d__26 <VisibleTagsIter>d__ = new WeaponVisibleConfig.<VisibleTagsIter>d__26(-2);
			<VisibleTagsIter>d__.<>3__<>4__this = this;
			return <VisibleTagsIter>d__;
		}

		// Token: 0x0400592B RID: 22827
		private Table __p;
	}
}
