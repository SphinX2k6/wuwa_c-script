using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001147 RID: 4423
	public struct RoleSkinTrialInfo : IFlatbufferObject
	{
		// Token: 0x170033DE RID: 13278
		// (get) Token: 0x0600D187 RID: 53639 RVA: 0x0031C92E File Offset: 0x0031AB2E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D188 RID: 53640 RVA: 0x0031C93B File Offset: 0x0031AB3B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D189 RID: 53641 RVA: 0x0031C944 File Offset: 0x0031AB44
		public static RoleSkinTrialInfo GetRootAsRoleSkinTrialInfo(ByteBuffer _bb)
		{
			return RoleSkinTrialInfo.GetRootAsRoleSkinTrialInfo(_bb, default(RoleSkinTrialInfo));
		}

		// Token: 0x0600D18A RID: 53642 RVA: 0x0031C960 File Offset: 0x0031AB60
		public static RoleSkinTrialInfo GetRootAsRoleSkinTrialInfo(ByteBuffer _bb, RoleSkinTrialInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D18B RID: 53643 RVA: 0x0031C97D File Offset: 0x0031AB7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D18C RID: 53644 RVA: 0x0031C98C File Offset: 0x0031AB8C
		public RoleSkinTrialInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170033DF RID: 13279
		// (get) Token: 0x0600D18D RID: 53645 RVA: 0x0031C99C File Offset: 0x0031AB9C
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

		// Token: 0x170033E0 RID: 13280
		// (get) Token: 0x0600D18E RID: 53646 RVA: 0x0031C9D8 File Offset: 0x0031ABD8
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

		// Token: 0x170033E1 RID: 13281
		// (get) Token: 0x0600D18F RID: 53647 RVA: 0x0031CA14 File Offset: 0x0031AC14
		public int TrialRoleId
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

		// Token: 0x170033E2 RID: 13282
		// (get) Token: 0x0600D190 RID: 53648 RVA: 0x0031CA50 File Offset: 0x0031AC50
		public int PreviewSkinId
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

		// Token: 0x170033E3 RID: 13283
		// (get) Token: 0x0600D191 RID: 53649 RVA: 0x0031CA90 File Offset: 0x0031AC90
		public int InstanceId
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

		// Token: 0x170033E4 RID: 13284
		// (get) Token: 0x0600D192 RID: 53650 RVA: 0x0031CAD0 File Offset: 0x0031ACD0
		public int AccessId
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

		// Token: 0x170033E5 RID: 13285
		// (get) Token: 0x0600D193 RID: 53651 RVA: 0x0031CB10 File Offset: 0x0031AD10
		public int DropId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170033E6 RID: 13286
		// (get) Token: 0x0600D194 RID: 53652 RVA: 0x0031CB50 File Offset: 0x0031AD50
		public string RoleIcon
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

		// Token: 0x0600D195 RID: 53653 RVA: 0x0031CB88 File Offset: 0x0031AD88
		public Span<byte> GetRoleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600D196 RID: 53654 RVA: 0x0031CB98 File Offset: 0x0031AD98
		public byte[] GetRoleIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170033E7 RID: 13287
		// (get) Token: 0x0600D197 RID: 53655 RVA: 0x0031CBB0 File Offset: 0x0031ADB0
		public string Introduction
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D198 RID: 53656 RVA: 0x0031CBE8 File Offset: 0x0031ADE8
		public Span<byte> GetIntroductionBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600D199 RID: 53657 RVA: 0x0031CBF8 File Offset: 0x0031ADF8
		public byte[] GetIntroductionArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170033E8 RID: 13288
		// (get) Token: 0x0600D19A RID: 53658 RVA: 0x0031CC10 File Offset: 0x0031AE10
		public int UiConfigId
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400574B RID: 22347
		private Table __p;
	}
}
