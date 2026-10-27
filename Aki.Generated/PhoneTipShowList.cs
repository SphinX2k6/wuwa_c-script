using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F01 RID: 3841
	public struct PhoneTipShowList : IFlatbufferObject
	{
		// Token: 0x17002791 RID: 10129
		// (get) Token: 0x0600AAE5 RID: 43749 RVA: 0x002B86D5 File Offset: 0x002B68D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AAE6 RID: 43750 RVA: 0x002B86E2 File Offset: 0x002B68E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AAE7 RID: 43751 RVA: 0x002B86EC File Offset: 0x002B68EC
		public static PhoneTipShowList GetRootAsPhoneTipShowList(ByteBuffer _bb)
		{
			return PhoneTipShowList.GetRootAsPhoneTipShowList(_bb, default(PhoneTipShowList));
		}

		// Token: 0x0600AAE8 RID: 43752 RVA: 0x002B8708 File Offset: 0x002B6908
		public static PhoneTipShowList GetRootAsPhoneTipShowList(ByteBuffer _bb, PhoneTipShowList obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AAE9 RID: 43753 RVA: 0x002B8725 File Offset: 0x002B6925
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AAEA RID: 43754 RVA: 0x002B8734 File Offset: 0x002B6934
		public PhoneTipShowList __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002792 RID: 10130
		// (get) Token: 0x0600AAEB RID: 43755 RVA: 0x002B8744 File Offset: 0x002B6944
		public int DungeonSubType
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

		// Token: 0x0600AAEC RID: 43756 RVA: 0x002B8780 File Offset: 0x002B6980
		public int WorldDungeonSubTypeList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002793 RID: 10131
		// (get) Token: 0x0600AAED RID: 43757 RVA: 0x002B87C0 File Offset: 0x002B69C0
		public int WorldDungeonSubTypeListLength
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

		// Token: 0x0600AAEE RID: 43758 RVA: 0x002B87EB File Offset: 0x002B69EB
		public Span<int> GetWorldDungeonSubTypeListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600AAEF RID: 43759 RVA: 0x002B87FA File Offset: 0x002B69FA
		public int[] GetWorldDungeonSubTypeListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600AAF0 RID: 43760 RVA: 0x002B8814 File Offset: 0x002B6A14
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用WorldDungeonSubTypeListIter()或GetWorldDungeonSubTypeListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] WorldDungeonSubTypeList()
		{
			PhoneTipShowList phoneTipShowList = this;
			return phoneTipShowList.GetWorldDungeonSubTypeListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600AAF1 RID: 43761 RVA: 0x002B8838 File Offset: 0x002B6A38
		[NullableContext(1)]
		public readonly IEnumerable<int> WorldDungeonSubTypeListIter()
		{
			PhoneTipShowList.<WorldDungeonSubTypeListIter>d__16 <WorldDungeonSubTypeListIter>d__ = new PhoneTipShowList.<WorldDungeonSubTypeListIter>d__16(-2);
			<WorldDungeonSubTypeListIter>d__.<>3__<>4__this = this;
			return <WorldDungeonSubTypeListIter>d__;
		}

		// Token: 0x04004FC9 RID: 20425
		private Table __p;
	}
}
