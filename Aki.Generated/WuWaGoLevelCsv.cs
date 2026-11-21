using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012DF RID: 4831
	public struct WuWaGoLevelCsv : IFlatbufferObject
	{
		// Token: 0x170041EB RID: 16875
		// (get) Token: 0x0600F6DB RID: 63195 RVA: 0x00370DC6 File Offset: 0x0036EFC6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F6DC RID: 63196 RVA: 0x00370DD3 File Offset: 0x0036EFD3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F6DD RID: 63197 RVA: 0x00370DDC File Offset: 0x0036EFDC
		public static WuWaGoLevelCsv GetRootAsWuWaGoLevelCsv(ByteBuffer _bb)
		{
			return WuWaGoLevelCsv.GetRootAsWuWaGoLevelCsv(_bb, default(WuWaGoLevelCsv));
		}

		// Token: 0x0600F6DE RID: 63198 RVA: 0x00370DF8 File Offset: 0x0036EFF8
		public static WuWaGoLevelCsv GetRootAsWuWaGoLevelCsv(ByteBuffer _bb, WuWaGoLevelCsv obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F6DF RID: 63199 RVA: 0x00370E15 File Offset: 0x0036F015
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F6E0 RID: 63200 RVA: 0x00370E24 File Offset: 0x0036F024
		public WuWaGoLevelCsv __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170041EC RID: 16876
		// (get) Token: 0x0600F6E1 RID: 63201 RVA: 0x00370E34 File Offset: 0x0036F034
		public string Key
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F6E2 RID: 63202 RVA: 0x00370E6B File Offset: 0x0036F06B
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600F6E3 RID: 63203 RVA: 0x00370E7A File Offset: 0x0036F07A
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x170041ED RID: 16877
		// (get) Token: 0x0600F6E4 RID: 63204 RVA: 0x00370E94 File Offset: 0x0036F094
		public string RoleList
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

		// Token: 0x0600F6E5 RID: 63205 RVA: 0x00370ECB File Offset: 0x0036F0CB
		public Span<byte> GetRoleListBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600F6E6 RID: 63206 RVA: 0x00370EDA File Offset: 0x0036F0DA
		public byte[] GetRoleListArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170041EE RID: 16878
		// (get) Token: 0x0600F6E7 RID: 63207 RVA: 0x00370EF4 File Offset: 0x0036F0F4
		public string GridDatas
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

		// Token: 0x0600F6E8 RID: 63208 RVA: 0x00370F2B File Offset: 0x0036F12B
		public Span<byte> GetGridDatasBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600F6E9 RID: 63209 RVA: 0x00370F3A File Offset: 0x0036F13A
		public byte[] GetGridDatasArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04005939 RID: 22841
		private Table __p;
	}
}
