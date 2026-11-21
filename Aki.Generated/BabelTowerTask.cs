using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C04 RID: 3076
	public struct BabelTowerTask : IFlatbufferObject
	{
		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x0600511B RID: 20763 RVA: 0x001FE7B9 File Offset: 0x001FC9B9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600511C RID: 20764 RVA: 0x001FE7C6 File Offset: 0x001FC9C6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600511D RID: 20765 RVA: 0x001FE7D0 File Offset: 0x001FC9D0
		public static BabelTowerTask GetRootAsBabelTowerTask(ByteBuffer _bb)
		{
			return BabelTowerTask.GetRootAsBabelTowerTask(_bb, default(BabelTowerTask));
		}

		// Token: 0x0600511E RID: 20766 RVA: 0x001FE7EC File Offset: 0x001FC9EC
		public static BabelTowerTask GetRootAsBabelTowerTask(ByteBuffer _bb, BabelTowerTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600511F RID: 20767 RVA: 0x001FE809 File Offset: 0x001FCA09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005120 RID: 20768 RVA: 0x001FE818 File Offset: 0x001FCA18
		public BabelTowerTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06005121 RID: 20769 RVA: 0x001FE828 File Offset: 0x001FCA28
		public int TaskId
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

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06005122 RID: 20770 RVA: 0x001FE864 File Offset: 0x001FCA64
		public int ActivityId
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

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06005123 RID: 20771 RVA: 0x001FE8A0 File Offset: 0x001FCAA0
		public int DropId
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

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06005124 RID: 20772 RVA: 0x001FE8DC File Offset: 0x001FCADC
		public int LevelId
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

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06005125 RID: 20773 RVA: 0x001FE91C File Offset: 0x001FCB1C
		public string Title
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

		// Token: 0x06005126 RID: 20774 RVA: 0x001FE954 File Offset: 0x001FCB54
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005127 RID: 20775 RVA: 0x001FE964 File Offset: 0x001FCB64
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x040050F6 RID: 20726
		private Table __p;
	}
}
