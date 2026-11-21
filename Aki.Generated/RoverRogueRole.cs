using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200117F RID: 4479
	public struct RoverRogueRole : IFlatbufferObject
	{
		// Token: 0x170035AE RID: 13742
		// (get) Token: 0x0600D697 RID: 54935 RVA: 0x00327A2C File Offset: 0x00325C2C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D698 RID: 54936 RVA: 0x00327A39 File Offset: 0x00325C39
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D699 RID: 54937 RVA: 0x00327A40 File Offset: 0x00325C40
		public static RoverRogueRole GetRootAsRoverRogueRole(ByteBuffer _bb)
		{
			return RoverRogueRole.GetRootAsRoverRogueRole(_bb, default(RoverRogueRole));
		}

		// Token: 0x0600D69A RID: 54938 RVA: 0x00327A5C File Offset: 0x00325C5C
		public static RoverRogueRole GetRootAsRoverRogueRole(ByteBuffer _bb, RoverRogueRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D69B RID: 54939 RVA: 0x00327A79 File Offset: 0x00325C79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D69C RID: 54940 RVA: 0x00327A88 File Offset: 0x00325C88
		public RoverRogueRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170035AF RID: 13743
		// (get) Token: 0x0600D69D RID: 54941 RVA: 0x00327A98 File Offset: 0x00325C98
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

		// Token: 0x170035B0 RID: 13744
		// (get) Token: 0x0600D69E RID: 54942 RVA: 0x00327AD4 File Offset: 0x00325CD4
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

		// Token: 0x170035B1 RID: 13745
		// (get) Token: 0x0600D69F RID: 54943 RVA: 0x00327B10 File Offset: 0x00325D10
		public string RoleIcon
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

		// Token: 0x0600D6A0 RID: 54944 RVA: 0x00327B47 File Offset: 0x00325D47
		public Span<byte> GetRoleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D6A1 RID: 54945 RVA: 0x00327B56 File Offset: 0x00325D56
		public byte[] GetRoleIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170035B2 RID: 13746
		// (get) Token: 0x0600D6A2 RID: 54946 RVA: 0x00327B70 File Offset: 0x00325D70
		public string Stand
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

		// Token: 0x0600D6A3 RID: 54947 RVA: 0x00327BA8 File Offset: 0x00325DA8
		public Span<byte> GetStandBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D6A4 RID: 54948 RVA: 0x00327BB8 File Offset: 0x00325DB8
		public byte[] GetStandArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D6A5 RID: 54949 RVA: 0x00327BD0 File Offset: 0x00325DD0
		public string Stands(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170035B3 RID: 13747
		// (get) Token: 0x0600D6A6 RID: 54950 RVA: 0x00327C0C File Offset: 0x00325E0C
		public int StandsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170035B4 RID: 13748
		// (get) Token: 0x0600D6A7 RID: 54951 RVA: 0x00327C38 File Offset: 0x00325E38
		public int RoleSkinId
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

		// Token: 0x0600D6A8 RID: 54952 RVA: 0x00327C75 File Offset: 0x00325E75
		[NullableContext(1)]
		public string[] Stands()
		{
			return this.StandsIter().ToArray<string>();
		}

		// Token: 0x0600D6A9 RID: 54953 RVA: 0x00327C82 File Offset: 0x00325E82
		[NullableContext(1)]
		public IEnumerable<string> StandsIter()
		{
			RoverRogueRole.<StandsIter>d__26 <StandsIter>d__ = new RoverRogueRole.<StandsIter>d__26(-2);
			<StandsIter>d__.<>3__<>4__this = this;
			return <StandsIter>d__;
		}

		// Token: 0x0400578F RID: 22415
		private Table __p;
	}
}
