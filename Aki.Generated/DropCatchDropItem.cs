using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C0B RID: 3083
	public struct DropCatchDropItem : IFlatbufferObject
	{
		// Token: 0x17000DA2 RID: 3490
		// (get) Token: 0x06006530 RID: 25904 RVA: 0x0021A6BC File Offset: 0x002188BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006531 RID: 25905 RVA: 0x0021A6C9 File Offset: 0x002188C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006532 RID: 25906 RVA: 0x0021A6D0 File Offset: 0x002188D0
		public static DropCatchDropItem GetRootAsDropCatchDropItem(ByteBuffer _bb)
		{
			return DropCatchDropItem.GetRootAsDropCatchDropItem(_bb, default(DropCatchDropItem));
		}

		// Token: 0x06006533 RID: 25907 RVA: 0x0021A6EC File Offset: 0x002188EC
		public static DropCatchDropItem GetRootAsDropCatchDropItem(ByteBuffer _bb, DropCatchDropItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006534 RID: 25908 RVA: 0x0021A709 File Offset: 0x00218909
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006535 RID: 25909 RVA: 0x0021A718 File Offset: 0x00218918
		public DropCatchDropItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x06006536 RID: 25910 RVA: 0x0021A728 File Offset: 0x00218928
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

		// Token: 0x17000DA4 RID: 3492
		// (get) Token: 0x06006537 RID: 25911 RVA: 0x0021A764 File Offset: 0x00218964
		public float MoveSpeed
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006538 RID: 25912 RVA: 0x0021A7A4 File Offset: 0x002189A4
		public float Size(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x06006539 RID: 25913 RVA: 0x0021A7E8 File Offset: 0x002189E8
		public int SizeLength
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

		// Token: 0x0600653A RID: 25914 RVA: 0x0021A813 File Offset: 0x00218A13
		public Span<float> GetSizeBytes()
		{
			return this.__p.__vector_as_span<float>(8, 4);
		}

		// Token: 0x0600653B RID: 25915 RVA: 0x0021A822 File Offset: 0x00218A22
		public float[] GetSizeArray()
		{
			return this.__p.__vector_as_array<float>(8) ?? Array.Empty<float>();
		}

		// Token: 0x17000DA6 RID: 3494
		// (get) Token: 0x0600653C RID: 25916 RVA: 0x0021A83C File Offset: 0x00218A3C
		public string EffectCommands
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

		// Token: 0x0600653D RID: 25917 RVA: 0x0021A874 File Offset: 0x00218A74
		public Span<byte> GetEffectCommandsBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600653E RID: 25918 RVA: 0x0021A884 File Offset: 0x00218A84
		public byte[] GetEffectCommandsArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000DA7 RID: 3495
		// (get) Token: 0x0600653F RID: 25919 RVA: 0x0021A89C File Offset: 0x00218A9C
		public int Score
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000DA8 RID: 3496
		// (get) Token: 0x06006540 RID: 25920 RVA: 0x0021A8DC File Offset: 0x00218ADC
		public int Energy
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000DA9 RID: 3497
		// (get) Token: 0x06006541 RID: 25921 RVA: 0x0021A91C File Offset: 0x00218B1C
		public int EffectType
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000DAA RID: 3498
		// (get) Token: 0x06006542 RID: 25922 RVA: 0x0021A95C File Offset: 0x00218B5C
		public string Name
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

		// Token: 0x06006543 RID: 25923 RVA: 0x0021A994 File Offset: 0x00218B94
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06006544 RID: 25924 RVA: 0x0021A9A4 File Offset: 0x00218BA4
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000DAB RID: 3499
		// (get) Token: 0x06006545 RID: 25925 RVA: 0x0021A9BC File Offset: 0x00218BBC
		public string Desc
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

		// Token: 0x06006546 RID: 25926 RVA: 0x0021A9F4 File Offset: 0x00218BF4
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06006547 RID: 25927 RVA: 0x0021AA04 File Offset: 0x00218C04
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000DAC RID: 3500
		// (get) Token: 0x06006548 RID: 25928 RVA: 0x0021AA1C File Offset: 0x00218C1C
		public string Icon
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

		// Token: 0x06006549 RID: 25929 RVA: 0x0021AA54 File Offset: 0x00218C54
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600654A RID: 25930 RVA: 0x0021AA64 File Offset: 0x00218C64
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000DAD RID: 3501
		// (get) Token: 0x0600654B RID: 25931 RVA: 0x0021AA7C File Offset: 0x00218C7C
		public int Priority
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000DAE RID: 3502
		// (get) Token: 0x0600654C RID: 25932 RVA: 0x0021AABC File Offset: 0x00218CBC
		public int NiagaraType
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000DAF RID: 3503
		// (get) Token: 0x0600654D RID: 25933 RVA: 0x0021AAFC File Offset: 0x00218CFC
		public int ItemTemplate
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600654E RID: 25934 RVA: 0x0021AB3C File Offset: 0x00218D3C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SizeIter()或GetSizeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] Size()
		{
			DropCatchDropItem dropCatchDropItem = this;
			return dropCatchDropItem.GetSizeArray() ?? Array.Empty<float>();
		}

		// Token: 0x0600654F RID: 25935 RVA: 0x0021AB60 File Offset: 0x00218D60
		[NullableContext(1)]
		public readonly IEnumerable<float> SizeIter()
		{
			DropCatchDropItem.<SizeIter>d__46 <SizeIter>d__ = new DropCatchDropItem.<SizeIter>d__46(-2);
			<SizeIter>d__.<>3__<>4__this = this;
			return <SizeIter>d__;
		}

		// Token: 0x04004C47 RID: 19527
		private Table __p;
	}
}
