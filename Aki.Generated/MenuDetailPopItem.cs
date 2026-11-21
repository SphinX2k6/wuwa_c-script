using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EEE RID: 3822
	public struct MenuDetailPopItem : IFlatbufferObject
	{
		// Token: 0x17001F6D RID: 8045
		// (get) Token: 0x06009A2D RID: 39469 RVA: 0x002A3445 File Offset: 0x002A1645
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009A2E RID: 39470 RVA: 0x002A3452 File Offset: 0x002A1652
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009A2F RID: 39471 RVA: 0x002A345C File Offset: 0x002A165C
		public static MenuDetailPopItem GetRootAsMenuDetailPopItem(ByteBuffer _bb)
		{
			return MenuDetailPopItem.GetRootAsMenuDetailPopItem(_bb, default(MenuDetailPopItem));
		}

		// Token: 0x06009A30 RID: 39472 RVA: 0x002A3478 File Offset: 0x002A1678
		public static MenuDetailPopItem GetRootAsMenuDetailPopItem(ByteBuffer _bb, MenuDetailPopItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009A31 RID: 39473 RVA: 0x002A3495 File Offset: 0x002A1695
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009A32 RID: 39474 RVA: 0x002A34A4 File Offset: 0x002A16A4
		public MenuDetailPopItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F6E RID: 8046
		// (get) Token: 0x06009A33 RID: 39475 RVA: 0x002A34B4 File Offset: 0x002A16B4
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

		// Token: 0x17001F6F RID: 8047
		// (get) Token: 0x06009A34 RID: 39476 RVA: 0x002A34F0 File Offset: 0x002A16F0
		public int ShowType
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

		// Token: 0x17001F70 RID: 8048
		// (get) Token: 0x06009A35 RID: 39477 RVA: 0x002A352C File Offset: 0x002A172C
		public string Title
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

		// Token: 0x06009A36 RID: 39478 RVA: 0x002A3563 File Offset: 0x002A1763
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009A37 RID: 39479 RVA: 0x002A3572 File Offset: 0x002A1772
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06009A38 RID: 39480 RVA: 0x002A358C File Offset: 0x002A178C
		public string WideVideoTitleList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F71 RID: 8049
		// (get) Token: 0x06009A39 RID: 39481 RVA: 0x002A35C8 File Offset: 0x002A17C8
		public int WideVideoTitleListLength
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

		// Token: 0x17001F72 RID: 8050
		// (get) Token: 0x06009A3A RID: 39482 RVA: 0x002A35F4 File Offset: 0x002A17F4
		public string ResourcePath
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

		// Token: 0x06009A3B RID: 39483 RVA: 0x002A362C File Offset: 0x002A182C
		public Span<byte> GetResourcePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009A3C RID: 39484 RVA: 0x002A363C File Offset: 0x002A183C
		public byte[] GetResourcePathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x06009A3D RID: 39485 RVA: 0x002A3654 File Offset: 0x002A1854
		[NullableContext(1)]
		public string[] WideVideoTitleList()
		{
			return this.WideVideoTitleListIter().ToArray<string>();
		}

		// Token: 0x06009A3E RID: 39486 RVA: 0x002A3661 File Offset: 0x002A1861
		[NullableContext(1)]
		public IEnumerable<string> WideVideoTitleListIter()
		{
			MenuDetailPopItem.<WideVideoTitleListIter>d__24 <WideVideoTitleListIter>d__ = new MenuDetailPopItem.<WideVideoTitleListIter>d__24(-2);
			<WideVideoTitleListIter>d__.<>3__<>4__this = this;
			return <WideVideoTitleListIter>d__;
		}

		// Token: 0x04005493 RID: 21651
		private Table __p;
	}
}
