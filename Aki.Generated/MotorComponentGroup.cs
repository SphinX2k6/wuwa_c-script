using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E2F RID: 3631
	public struct MotorComponentGroup : IFlatbufferObject
	{
		// Token: 0x17002014 RID: 8212
		// (get) Token: 0x060096B8 RID: 38584 RVA: 0x0028B084 File Offset: 0x00289284
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060096B9 RID: 38585 RVA: 0x0028B091 File Offset: 0x00289291
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060096BA RID: 38586 RVA: 0x0028B098 File Offset: 0x00289298
		public static MotorComponentGroup GetRootAsMotorComponentGroup(ByteBuffer _bb)
		{
			return MotorComponentGroup.GetRootAsMotorComponentGroup(_bb, default(MotorComponentGroup));
		}

		// Token: 0x060096BB RID: 38587 RVA: 0x0028B0B4 File Offset: 0x002892B4
		public static MotorComponentGroup GetRootAsMotorComponentGroup(ByteBuffer _bb, MotorComponentGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060096BC RID: 38588 RVA: 0x0028B0D1 File Offset: 0x002892D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060096BD RID: 38589 RVA: 0x0028B0E0 File Offset: 0x002892E0
		public MotorComponentGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002015 RID: 8213
		// (get) Token: 0x060096BE RID: 38590 RVA: 0x0028B0F0 File Offset: 0x002892F0
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

		// Token: 0x17002016 RID: 8214
		// (get) Token: 0x060096BF RID: 38591 RVA: 0x0028B12C File Offset: 0x0028932C
		public string Desc
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

		// Token: 0x060096C0 RID: 38592 RVA: 0x0028B163 File Offset: 0x00289363
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060096C1 RID: 38593 RVA: 0x0028B172 File Offset: 0x00289372
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x060096C2 RID: 38594 RVA: 0x0028B18C File Offset: 0x0028938C
		public int ConflictGroup(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002017 RID: 8215
		// (get) Token: 0x060096C3 RID: 38595 RVA: 0x0028B1CC File Offset: 0x002893CC
		public int ConflictGroupLength
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

		// Token: 0x060096C4 RID: 38596 RVA: 0x0028B1F7 File Offset: 0x002893F7
		public Span<int> GetConflictGroupBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x060096C5 RID: 38597 RVA: 0x0028B206 File Offset: 0x00289406
		public int[] GetConflictGroupArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x060096C6 RID: 38598 RVA: 0x0028B220 File Offset: 0x00289420
		public string Region(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002018 RID: 8216
		// (get) Token: 0x060096C7 RID: 38599 RVA: 0x0028B25C File Offset: 0x0028945C
		public int RegionLength
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

		// Token: 0x060096C8 RID: 38600 RVA: 0x0028B288 File Offset: 0x00289488
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ConflictGroupIter()或GetConflictGroupBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ConflictGroup()
		{
			MotorComponentGroup motorComponentGroup = this;
			return motorComponentGroup.GetConflictGroupArray() ?? Array.Empty<int>();
		}

		// Token: 0x060096C9 RID: 38601 RVA: 0x0028B2AC File Offset: 0x002894AC
		[NullableContext(1)]
		public readonly IEnumerable<int> ConflictGroupIter()
		{
			MotorComponentGroup.<ConflictGroupIter>d__23 <ConflictGroupIter>d__ = new MotorComponentGroup.<ConflictGroupIter>d__23(-2);
			<ConflictGroupIter>d__.<>3__<>4__this = this;
			return <ConflictGroupIter>d__;
		}

		// Token: 0x060096CA RID: 38602 RVA: 0x0028B2C1 File Offset: 0x002894C1
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RegionIter()或GetRegionBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Region()
		{
			return this.RegionIter().ToArray<string>();
		}

		// Token: 0x060096CB RID: 38603 RVA: 0x0028B2CE File Offset: 0x002894CE
		[NullableContext(1)]
		public readonly IEnumerable<string> RegionIter()
		{
			MotorComponentGroup.<RegionIter>d__25 <RegionIter>d__ = new MotorComponentGroup.<RegionIter>d__25(-2);
			<RegionIter>d__.<>3__<>4__this = this;
			return <RegionIter>d__;
		}

		// Token: 0x04004ED4 RID: 20180
		private Table __p;
	}
}
