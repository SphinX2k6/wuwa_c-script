using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C43 RID: 3139
	public struct Character : IFlatbufferObject
	{
		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06005849 RID: 22601 RVA: 0x0020F8D1 File Offset: 0x0020DAD1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600584A RID: 22602 RVA: 0x0020F8DE File Offset: 0x0020DADE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600584B RID: 22603 RVA: 0x0020F8E8 File Offset: 0x0020DAE8
		public static Character GetRootAsCharacter(ByteBuffer _bb)
		{
			return Character.GetRootAsCharacter(_bb, default(Character));
		}

		// Token: 0x0600584C RID: 22604 RVA: 0x0020F904 File Offset: 0x0020DB04
		public static Character GetRootAsCharacter(ByteBuffer _bb, Character obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600584D RID: 22605 RVA: 0x0020F921 File Offset: 0x0020DB21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600584E RID: 22606 RVA: 0x0020F930 File Offset: 0x0020DB30
		public Character __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x0600584F RID: 22607 RVA: 0x0020F940 File Offset: 0x0020DB40
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

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06005850 RID: 22608 RVA: 0x0020F97C File Offset: 0x0020DB7C
		public string Name
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

		// Token: 0x06005851 RID: 22609 RVA: 0x0020F9B3 File Offset: 0x0020DBB3
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005852 RID: 22610 RVA: 0x0020F9C2 File Offset: 0x0020DBC2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06005853 RID: 22611 RVA: 0x0020F9DC File Offset: 0x0020DBDC
		public string ScoreName
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

		// Token: 0x06005854 RID: 22612 RVA: 0x0020FA13 File Offset: 0x0020DC13
		public Span<byte> GetScoreNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005855 RID: 22613 RVA: 0x0020FA22 File Offset: 0x0020DC22
		public byte[] GetScoreNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06005856 RID: 22614 RVA: 0x0020FA3C File Offset: 0x0020DC3C
		public string Color
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

		// Token: 0x06005857 RID: 22615 RVA: 0x0020FA74 File Offset: 0x0020DC74
		public Span<byte> GetColorBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005858 RID: 22616 RVA: 0x0020FA84 File Offset: 0x0020DC84
		public byte[] GetColorArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06005859 RID: 22617 RVA: 0x0020FA9C File Offset: 0x0020DC9C
		public string BarSprite
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600585A RID: 22618 RVA: 0x0020FAD4 File Offset: 0x0020DCD4
		public Span<byte> GetBarSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600585B RID: 22619 RVA: 0x0020FAE4 File Offset: 0x0020DCE4
		public byte[] GetBarSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04005143 RID: 20803
		private Table __p;
	}
}
