using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200113A RID: 4410
	public struct RoleInfoLang : IFlatbufferObject
	{
		// Token: 0x17003349 RID: 13129
		// (get) Token: 0x0600CFCF RID: 53199 RVA: 0x00318811 File Offset: 0x00316A11
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CFD0 RID: 53200 RVA: 0x0031881E File Offset: 0x00316A1E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CFD1 RID: 53201 RVA: 0x00318828 File Offset: 0x00316A28
		public static RoleInfoLang GetRootAsRoleInfoLang(ByteBuffer _bb)
		{
			return RoleInfoLang.GetRootAsRoleInfoLang(_bb, default(RoleInfoLang));
		}

		// Token: 0x0600CFD2 RID: 53202 RVA: 0x00318844 File Offset: 0x00316A44
		public static RoleInfoLang GetRootAsRoleInfoLang(ByteBuffer _bb, RoleInfoLang obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CFD3 RID: 53203 RVA: 0x00318861 File Offset: 0x00316A61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CFD4 RID: 53204 RVA: 0x00318870 File Offset: 0x00316A70
		public RoleInfoLang __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700334A RID: 13130
		// (get) Token: 0x0600CFD5 RID: 53205 RVA: 0x00318880 File Offset: 0x00316A80
		public int RoleId
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

		// Token: 0x1700334B RID: 13131
		// (get) Token: 0x0600CFD6 RID: 53206 RVA: 0x003188BC File Offset: 0x00316ABC
		public string StateGroupName
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

		// Token: 0x0600CFD7 RID: 53207 RVA: 0x003188F3 File Offset: 0x00316AF3
		public Span<byte> GetStateGroupNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CFD8 RID: 53208 RVA: 0x00318902 File Offset: 0x00316B02
		public byte[] GetStateGroupNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700334C RID: 13132
		// (get) Token: 0x0600CFD9 RID: 53209 RVA: 0x0031891C File Offset: 0x00316B1C
		public string InterruptEvent
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

		// Token: 0x0600CFDA RID: 53210 RVA: 0x00318953 File Offset: 0x00316B53
		public Span<byte> GetInterruptEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600CFDB RID: 53211 RVA: 0x00318962 File Offset: 0x00316B62
		public byte[] GetInterruptEventArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0400573B RID: 22331
		private Table __p;
	}
}
