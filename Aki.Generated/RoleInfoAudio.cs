using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001051 RID: 4177
	public struct RoleInfoAudio : IFlatbufferObject
	{
		// Token: 0x170032C9 RID: 13001
		// (get) Token: 0x0600C972 RID: 51570 RVA: 0x002FC998 File Offset: 0x002FAB98
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C973 RID: 51571 RVA: 0x002FC9A5 File Offset: 0x002FABA5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C974 RID: 51572 RVA: 0x002FC9AC File Offset: 0x002FABAC
		public static RoleInfoAudio GetRootAsRoleInfoAudio(ByteBuffer _bb)
		{
			return RoleInfoAudio.GetRootAsRoleInfoAudio(_bb, default(RoleInfoAudio));
		}

		// Token: 0x0600C975 RID: 51573 RVA: 0x002FC9C8 File Offset: 0x002FABC8
		public static RoleInfoAudio GetRootAsRoleInfoAudio(ByteBuffer _bb, RoleInfoAudio obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C976 RID: 51574 RVA: 0x002FC9E5 File Offset: 0x002FABE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C977 RID: 51575 RVA: 0x002FC9F4 File Offset: 0x002FABF4
		public RoleInfoAudio __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170032CA RID: 13002
		// (get) Token: 0x0600C978 RID: 51576 RVA: 0x002FCA04 File Offset: 0x002FAC04
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

		// Token: 0x170032CB RID: 13003
		// (get) Token: 0x0600C979 RID: 51577 RVA: 0x002FCA40 File Offset: 0x002FAC40
		public string FootstepEvent
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

		// Token: 0x0600C97A RID: 51578 RVA: 0x002FCA77 File Offset: 0x002FAC77
		public Span<byte> GetFootstepEventBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C97B RID: 51579 RVA: 0x002FCA86 File Offset: 0x002FAC86
		public byte[] GetFootstepEventArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170032CC RID: 13004
		// (get) Token: 0x0600C97C RID: 51580 RVA: 0x002FCAA0 File Offset: 0x002FACA0
		public string FoleyEvent
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

		// Token: 0x0600C97D RID: 51581 RVA: 0x002FCAD7 File Offset: 0x002FACD7
		public Span<byte> GetFoleyEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C97E RID: 51582 RVA: 0x002FCAE6 File Offset: 0x002FACE6
		public byte[] GetFoleyEventArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04005152 RID: 20818
		private Table __p;
	}
}
