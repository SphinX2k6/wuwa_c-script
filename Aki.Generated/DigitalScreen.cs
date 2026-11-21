using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CD1 RID: 3281
	public struct DigitalScreen : IFlatbufferObject
	{
		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x060067E4 RID: 26596 RVA: 0x002326C9 File Offset: 0x002308C9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060067E5 RID: 26597 RVA: 0x002326D6 File Offset: 0x002308D6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060067E6 RID: 26598 RVA: 0x002326E0 File Offset: 0x002308E0
		public static DigitalScreen GetRootAsDigitalScreen(ByteBuffer _bb)
		{
			return DigitalScreen.GetRootAsDigitalScreen(_bb, default(DigitalScreen));
		}

		// Token: 0x060067E7 RID: 26599 RVA: 0x002326FC File Offset: 0x002308FC
		public static DigitalScreen GetRootAsDigitalScreen(ByteBuffer _bb, DigitalScreen obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060067E8 RID: 26600 RVA: 0x00232719 File Offset: 0x00230919
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060067E9 RID: 26601 RVA: 0x00232728 File Offset: 0x00230928
		public DigitalScreen __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x060067EA RID: 26602 RVA: 0x00232738 File Offset: 0x00230938
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

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x060067EB RID: 26603 RVA: 0x00232774 File Offset: 0x00230974
		public string BackgroundPicture
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

		// Token: 0x060067EC RID: 26604 RVA: 0x002327AB File Offset: 0x002309AB
		public Span<byte> GetBackgroundPictureBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060067ED RID: 26605 RVA: 0x002327BA File Offset: 0x002309BA
		public byte[] GetBackgroundPictureArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x060067EE RID: 26606 RVA: 0x002327D4 File Offset: 0x002309D4
		public int Prefab
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

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x060067EF RID: 26607 RVA: 0x00232810 File Offset: 0x00230A10
		public int ExistTime
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

		// Token: 0x060067F0 RID: 26608 RVA: 0x00232850 File Offset: 0x00230A50
		public int TextId(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x060067F1 RID: 26609 RVA: 0x00232890 File Offset: 0x00230A90
		public int TextIdLength
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

		// Token: 0x060067F2 RID: 26610 RVA: 0x002328BC File Offset: 0x00230ABC
		public Span<int> GetTextIdBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x060067F3 RID: 26611 RVA: 0x002328CC File Offset: 0x00230ACC
		public int[] GetTextIdArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x060067F4 RID: 26612 RVA: 0x002328E4 File Offset: 0x00230AE4
		public float TextFactor
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x060067F5 RID: 26613 RVA: 0x00232928 File Offset: 0x00230B28
		public string LogoIconPath
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

		// Token: 0x060067F6 RID: 26614 RVA: 0x00232960 File Offset: 0x00230B60
		public Span<byte> GetLogoIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060067F7 RID: 26615 RVA: 0x00232970 File Offset: 0x00230B70
		public byte[] GetLogoIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x060067F8 RID: 26616 RVA: 0x00232988 File Offset: 0x00230B88
		[NullableContext(1)]
		public int[] TextId()
		{
			return this.GetTextIdArray();
		}

		// Token: 0x060067F9 RID: 26617 RVA: 0x00232990 File Offset: 0x00230B90
		[NullableContext(1)]
		public IEnumerable<int> TextIdIter()
		{
			DigitalScreen.<TextIdIter>d__30 <TextIdIter>d__ = new DigitalScreen.<TextIdIter>d__30(-2);
			<TextIdIter>d__.<>3__<>4__this = this;
			return <TextIdIter>d__;
		}

		// Token: 0x040051FE RID: 20990
		private Table __p;
	}
}
