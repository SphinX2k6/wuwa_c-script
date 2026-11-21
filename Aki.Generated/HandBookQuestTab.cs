using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E09 RID: 3593
	public struct HandBookQuestTab : IFlatbufferObject
	{
		// Token: 0x17001746 RID: 5958
		// (get) Token: 0x0600841B RID: 33819 RVA: 0x00271928 File Offset: 0x0026FB28
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600841C RID: 33820 RVA: 0x00271935 File Offset: 0x0026FB35
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600841D RID: 33821 RVA: 0x0027193C File Offset: 0x0026FB3C
		public static HandBookQuestTab GetRootAsHandBookQuestTab(ByteBuffer _bb)
		{
			return HandBookQuestTab.GetRootAsHandBookQuestTab(_bb, default(HandBookQuestTab));
		}

		// Token: 0x0600841E RID: 33822 RVA: 0x00271958 File Offset: 0x0026FB58
		public static HandBookQuestTab GetRootAsHandBookQuestTab(ByteBuffer _bb, HandBookQuestTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600841F RID: 33823 RVA: 0x00271975 File Offset: 0x0026FB75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008420 RID: 33824 RVA: 0x00271984 File Offset: 0x0026FB84
		public HandBookQuestTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001747 RID: 5959
		// (get) Token: 0x06008421 RID: 33825 RVA: 0x00271994 File Offset: 0x0026FB94
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

		// Token: 0x17001748 RID: 5960
		// (get) Token: 0x06008422 RID: 33826 RVA: 0x002719D0 File Offset: 0x0026FBD0
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

		// Token: 0x06008423 RID: 33827 RVA: 0x00271A07 File Offset: 0x0026FC07
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008424 RID: 33828 RVA: 0x00271A16 File Offset: 0x0026FC16
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001749 RID: 5961
		// (get) Token: 0x06008425 RID: 33829 RVA: 0x00271A30 File Offset: 0x0026FC30
		public string Icon
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

		// Token: 0x06008426 RID: 33830 RVA: 0x00271A67 File Offset: 0x0026FC67
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008427 RID: 33831 RVA: 0x00271A76 File Offset: 0x0026FC76
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700174A RID: 5962
		// (get) Token: 0x06008428 RID: 33832 RVA: 0x00271A90 File Offset: 0x0026FC90
		public int Type
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

		// Token: 0x04005381 RID: 21377
		private Table __p;
	}
}
