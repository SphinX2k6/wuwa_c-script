using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DDE RID: 3550
	public struct LoopTeleportVolumeFunction : IFlatbufferObject
	{
		// Token: 0x17001D74 RID: 7540
		// (get) Token: 0x06008FB2 RID: 36786 RVA: 0x0027B63C File Offset: 0x0027983C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008FB3 RID: 36787 RVA: 0x0027B649 File Offset: 0x00279849
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008FB4 RID: 36788 RVA: 0x0027B650 File Offset: 0x00279850
		public static LoopTeleportVolumeFunction GetRootAsLoopTeleportVolumeFunction(ByteBuffer _bb)
		{
			return LoopTeleportVolumeFunction.GetRootAsLoopTeleportVolumeFunction(_bb, default(LoopTeleportVolumeFunction));
		}

		// Token: 0x06008FB5 RID: 36789 RVA: 0x0027B66C File Offset: 0x0027986C
		public static LoopTeleportVolumeFunction GetRootAsLoopTeleportVolumeFunction(ByteBuffer _bb, LoopTeleportVolumeFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008FB6 RID: 36790 RVA: 0x0027B689 File Offset: 0x00279889
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008FB7 RID: 36791 RVA: 0x0027B698 File Offset: 0x00279898
		public LoopTeleportVolumeFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D75 RID: 7541
		// (get) Token: 0x06008FB8 RID: 36792 RVA: 0x0027B6A8 File Offset: 0x002798A8
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

		// Token: 0x17001D76 RID: 7542
		// (get) Token: 0x06008FB9 RID: 36793 RVA: 0x0027B6E4 File Offset: 0x002798E4
		public int VolumeId
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

		// Token: 0x17001D77 RID: 7543
		// (get) Token: 0x06008FBA RID: 36794 RVA: 0x0027B720 File Offset: 0x00279920
		public string Desc
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

		// Token: 0x06008FBB RID: 36795 RVA: 0x0027B757 File Offset: 0x00279957
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008FBC RID: 36796 RVA: 0x0027B766 File Offset: 0x00279966
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D78 RID: 7544
		// (get) Token: 0x06008FBD RID: 36797 RVA: 0x0027B780 File Offset: 0x00279980
		public string Conditions
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

		// Token: 0x06008FBE RID: 36798 RVA: 0x0027B7B8 File Offset: 0x002799B8
		public Span<byte> GetConditionsBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008FBF RID: 36799 RVA: 0x0027B7C8 File Offset: 0x002799C8
		public byte[] GetConditionsArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D79 RID: 7545
		// (get) Token: 0x06008FC0 RID: 36800 RVA: 0x0027B7E0 File Offset: 0x002799E0
		public string Actions
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

		// Token: 0x06008FC1 RID: 36801 RVA: 0x0027B818 File Offset: 0x00279A18
		public Span<byte> GetActionsBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008FC2 RID: 36802 RVA: 0x0027B828 File Offset: 0x00279A28
		public byte[] GetActionsArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D7A RID: 7546
		// (get) Token: 0x06008FC3 RID: 36803 RVA: 0x0027B840 File Offset: 0x00279A40
		public string ClientLogic
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008FC4 RID: 36804 RVA: 0x0027B878 File Offset: 0x00279A78
		public Span<byte> GetClientLogicBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06008FC5 RID: 36805 RVA: 0x0027B888 File Offset: 0x00279A88
		public byte[] GetClientLogicArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E7A RID: 20090
		private Table __p;
	}
}
