using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AFC RID: 2812
	public struct AnimalHandBook : IFlatbufferObject
	{
		// Token: 0x170002EC RID: 748
		// (get) Token: 0x060047BA RID: 18362 RVA: 0x001D5C7D File Offset: 0x001D3E7D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060047BB RID: 18363 RVA: 0x001D5C8A File Offset: 0x001D3E8A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060047BC RID: 18364 RVA: 0x001D5C94 File Offset: 0x001D3E94
		public static AnimalHandBook GetRootAsAnimalHandBook(ByteBuffer _bb)
		{
			return AnimalHandBook.GetRootAsAnimalHandBook(_bb, default(AnimalHandBook));
		}

		// Token: 0x060047BD RID: 18365 RVA: 0x001D5CB0 File Offset: 0x001D3EB0
		public static AnimalHandBook GetRootAsAnimalHandBook(ByteBuffer _bb, AnimalHandBook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060047BE RID: 18366 RVA: 0x001D5CCD File Offset: 0x001D3ECD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060047BF RID: 18367 RVA: 0x001D5CDC File Offset: 0x001D3EDC
		public AnimalHandBook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x060047C0 RID: 18368 RVA: 0x001D5CEC File Offset: 0x001D3EEC
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

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x060047C1 RID: 18369 RVA: 0x001D5D28 File Offset: 0x001D3F28
		public int MeshId
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

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x060047C2 RID: 18370 RVA: 0x001D5D64 File Offset: 0x001D3F64
		public string Name
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

		// Token: 0x060047C3 RID: 18371 RVA: 0x001D5D9B File Offset: 0x001D3F9B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060047C4 RID: 18372 RVA: 0x001D5DAA File Offset: 0x001D3FAA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x060047C5 RID: 18373 RVA: 0x001D5DC4 File Offset: 0x001D3FC4
		public float Scale(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x060047C6 RID: 18374 RVA: 0x001D5E08 File Offset: 0x001D4008
		public int ScaleLength
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

		// Token: 0x060047C7 RID: 18375 RVA: 0x001D5E34 File Offset: 0x001D4034
		public Span<float> GetScaleBytes()
		{
			return this.__p.__vector_as_span<float>(10, 4);
		}

		// Token: 0x060047C8 RID: 18376 RVA: 0x001D5E44 File Offset: 0x001D4044
		public float[] GetScaleArray()
		{
			return this.__p.__vector_as_array<float>(10) ?? Array.Empty<float>();
		}

		// Token: 0x060047C9 RID: 18377 RVA: 0x001D5E5C File Offset: 0x001D405C
		public float Position(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x060047CA RID: 18378 RVA: 0x001D5EA0 File Offset: 0x001D40A0
		public int PositionLength
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

		// Token: 0x060047CB RID: 18379 RVA: 0x001D5ECC File Offset: 0x001D40CC
		public Span<float> GetPositionBytes()
		{
			return this.__p.__vector_as_span<float>(12, 4);
		}

		// Token: 0x060047CC RID: 18380 RVA: 0x001D5EDC File Offset: 0x001D40DC
		public float[] GetPositionArray()
		{
			return this.__p.__vector_as_array<float>(12) ?? Array.Empty<float>();
		}

		// Token: 0x060047CD RID: 18381 RVA: 0x001D5EF4 File Offset: 0x001D40F4
		public float Rotator(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x060047CE RID: 18382 RVA: 0x001D5F38 File Offset: 0x001D4138
		public int RotatorLength
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

		// Token: 0x060047CF RID: 18383 RVA: 0x001D5F64 File Offset: 0x001D4164
		public Span<float> GetRotatorBytes()
		{
			return this.__p.__vector_as_span<float>(14, 4);
		}

		// Token: 0x060047D0 RID: 18384 RVA: 0x001D5F74 File Offset: 0x001D4174
		public float[] GetRotatorArray()
		{
			return this.__p.__vector_as_array<float>(14) ?? Array.Empty<float>();
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x060047D1 RID: 18385 RVA: 0x001D5F8C File Offset: 0x001D418C
		public string StandAnim
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

		// Token: 0x060047D2 RID: 18386 RVA: 0x001D5FC4 File Offset: 0x001D41C4
		public Span<byte> GetStandAnimBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060047D3 RID: 18387 RVA: 0x001D5FD4 File Offset: 0x001D41D4
		public byte[] GetStandAnimArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x060047D4 RID: 18388 RVA: 0x001D5FEC File Offset: 0x001D41EC
		public string Icon
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

		// Token: 0x060047D5 RID: 18389 RVA: 0x001D6024 File Offset: 0x001D4224
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060047D6 RID: 18390 RVA: 0x001D6034 File Offset: 0x001D4234
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x060047D7 RID: 18391 RVA: 0x001D604C File Offset: 0x001D424C
		public string TypeDescrtption
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060047D8 RID: 18392 RVA: 0x001D6084 File Offset: 0x001D4284
		public Span<byte> GetTypeDescrtptionBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060047D9 RID: 18393 RVA: 0x001D6094 File Offset: 0x001D4294
		public byte[] GetTypeDescrtptionArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x060047DA RID: 18394 RVA: 0x001D60AC File Offset: 0x001D42AC
		public string Place
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

		// Token: 0x060047DB RID: 18395 RVA: 0x001D60E4 File Offset: 0x001D42E4
		public Span<byte> GetPlaceBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060047DC RID: 18396 RVA: 0x001D60F4 File Offset: 0x001D42F4
		public byte[] GetPlaceArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x060047DD RID: 18397 RVA: 0x001D610C File Offset: 0x001D430C
		public string Descrtption
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

		// Token: 0x060047DE RID: 18398 RVA: 0x001D6144 File Offset: 0x001D4344
		public Span<byte> GetDescrtptionBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060047DF RID: 18399 RVA: 0x001D6154 File Offset: 0x001D4354
		public byte[] GetDescrtptionArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x060047E0 RID: 18400 RVA: 0x001D616C File Offset: 0x001D436C
		public int DropItemId(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x060047E1 RID: 18401 RVA: 0x001D61AC File Offset: 0x001D43AC
		public int DropItemIdLength
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

		// Token: 0x060047E2 RID: 18402 RVA: 0x001D61D8 File Offset: 0x001D43D8
		public Span<int> GetDropItemIdBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x060047E3 RID: 18403 RVA: 0x001D61E8 File Offset: 0x001D43E8
		public int[] GetDropItemIdArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x060047E4 RID: 18404 RVA: 0x001D6200 File Offset: 0x001D4400
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DropItemIdIter()或GetDropItemIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DropItemId()
		{
			AnimalHandBook animalHandBook = this;
			return animalHandBook.GetDropItemIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x060047E5 RID: 18405 RVA: 0x001D6224 File Offset: 0x001D4424
		[NullableContext(1)]
		public readonly IEnumerable<int> DropItemIdIter()
		{
			AnimalHandBook.<DropItemIdIter>d__57 <DropItemIdIter>d__ = new AnimalHandBook.<DropItemIdIter>d__57(-2);
			<DropItemIdIter>d__.<>3__<>4__this = this;
			return <DropItemIdIter>d__;
		}

		// Token: 0x060047E6 RID: 18406 RVA: 0x001D623C File Offset: 0x001D443C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PositionIter()或GetPositionBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] Position()
		{
			AnimalHandBook animalHandBook = this;
			return animalHandBook.GetPositionArray() ?? Array.Empty<float>();
		}

		// Token: 0x060047E7 RID: 18407 RVA: 0x001D6260 File Offset: 0x001D4460
		[NullableContext(1)]
		public readonly IEnumerable<float> PositionIter()
		{
			AnimalHandBook.<PositionIter>d__59 <PositionIter>d__ = new AnimalHandBook.<PositionIter>d__59(-2);
			<PositionIter>d__.<>3__<>4__this = this;
			return <PositionIter>d__;
		}

		// Token: 0x060047E8 RID: 18408 RVA: 0x001D6278 File Offset: 0x001D4478
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RotatorIter()或GetRotatorBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] Rotator()
		{
			AnimalHandBook animalHandBook = this;
			return animalHandBook.GetRotatorArray() ?? Array.Empty<float>();
		}

		// Token: 0x060047E9 RID: 18409 RVA: 0x001D629C File Offset: 0x001D449C
		[NullableContext(1)]
		public readonly IEnumerable<float> RotatorIter()
		{
			AnimalHandBook.<RotatorIter>d__61 <RotatorIter>d__ = new AnimalHandBook.<RotatorIter>d__61(-2);
			<RotatorIter>d__.<>3__<>4__this = this;
			return <RotatorIter>d__;
		}

		// Token: 0x060047EA RID: 18410 RVA: 0x001D62B4 File Offset: 0x001D44B4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ScaleIter()或GetScaleBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] Scale()
		{
			AnimalHandBook animalHandBook = this;
			return animalHandBook.GetScaleArray() ?? Array.Empty<float>();
		}

		// Token: 0x060047EB RID: 18411 RVA: 0x001D62D8 File Offset: 0x001D44D8
		[NullableContext(1)]
		public readonly IEnumerable<float> ScaleIter()
		{
			AnimalHandBook.<ScaleIter>d__63 <ScaleIter>d__ = new AnimalHandBook.<ScaleIter>d__63(-2);
			<ScaleIter>d__.<>3__<>4__this = this;
			return <ScaleIter>d__;
		}

		// Token: 0x04004ADD RID: 19165
		private Table __p;
	}
}
