using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001054 RID: 4180
	public struct RoleMorph : IFlatbufferObject
	{
		// Token: 0x170032D6 RID: 13014
		// (get) Token: 0x0600C996 RID: 51606 RVA: 0x002FCDC5 File Offset: 0x002FAFC5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C997 RID: 51607 RVA: 0x002FCDD2 File Offset: 0x002FAFD2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C998 RID: 51608 RVA: 0x002FCDDC File Offset: 0x002FAFDC
		public static RoleMorph GetRootAsRoleMorph(ByteBuffer _bb)
		{
			return RoleMorph.GetRootAsRoleMorph(_bb, default(RoleMorph));
		}

		// Token: 0x0600C999 RID: 51609 RVA: 0x002FCDF8 File Offset: 0x002FAFF8
		public static RoleMorph GetRootAsRoleMorph(ByteBuffer _bb, RoleMorph obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C99A RID: 51610 RVA: 0x002FCE15 File Offset: 0x002FB015
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C99B RID: 51611 RVA: 0x002FCE24 File Offset: 0x002FB024
		public RoleMorph __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170032D7 RID: 13015
		// (get) Token: 0x0600C99C RID: 51612 RVA: 0x002FCE34 File Offset: 0x002FB034
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

		// Token: 0x170032D8 RID: 13016
		// (get) Token: 0x0600C99D RID: 51613 RVA: 0x002FCE70 File Offset: 0x002FB070
		public int RoleId
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

		// Token: 0x170032D9 RID: 13017
		// (get) Token: 0x0600C99E RID: 51614 RVA: 0x002FCEAC File Offset: 0x002FB0AC
		public int Morph
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

		// Token: 0x170032DA RID: 13018
		// (get) Token: 0x0600C99F RID: 51615 RVA: 0x002FCEE8 File Offset: 0x002FB0E8
		public int SkinId
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

		// Token: 0x170032DB RID: 13019
		// (get) Token: 0x0600C9A0 RID: 51616 RVA: 0x002FCF28 File Offset: 0x002FB128
		public int MeshId
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

		// Token: 0x170032DC RID: 13020
		// (get) Token: 0x0600C9A1 RID: 51617 RVA: 0x002FCF68 File Offset: 0x002FB168
		public int UiMeshId
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

		// Token: 0x170032DD RID: 13021
		// (get) Token: 0x0600C9A2 RID: 51618 RVA: 0x002FCFA8 File Offset: 0x002FB1A8
		public string UiScenePerformanceABP
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

		// Token: 0x0600C9A3 RID: 51619 RVA: 0x002FCFE0 File Offset: 0x002FB1E0
		public Span<byte> GetUiScenePerformanceABPBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C9A4 RID: 51620 RVA: 0x002FCFF0 File Offset: 0x002FB1F0
		public byte[] GetUiScenePerformanceABPArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170032DE RID: 13022
		// (get) Token: 0x0600C9A5 RID: 51621 RVA: 0x002FD008 File Offset: 0x002FB208
		public string RoleBody
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

		// Token: 0x0600C9A6 RID: 51622 RVA: 0x002FD040 File Offset: 0x002FB240
		public Span<byte> GetRoleBodyBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600C9A7 RID: 51623 RVA: 0x002FD050 File Offset: 0x002FB250
		public byte[] GetRoleBodyArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x04005155 RID: 20821
		private Table __p;
	}
}
