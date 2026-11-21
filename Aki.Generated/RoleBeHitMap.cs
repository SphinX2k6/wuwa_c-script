using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001122 RID: 4386
	public struct RoleBeHitMap : IFlatbufferObject
	{
		// Token: 0x17003278 RID: 12920
		// (get) Token: 0x0600CD99 RID: 52633 RVA: 0x003139BD File Offset: 0x00311BBD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CD9A RID: 52634 RVA: 0x003139CA File Offset: 0x00311BCA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CD9B RID: 52635 RVA: 0x003139D4 File Offset: 0x00311BD4
		public static RoleBeHitMap GetRootAsRoleBeHitMap(ByteBuffer _bb)
		{
			return RoleBeHitMap.GetRootAsRoleBeHitMap(_bb, default(RoleBeHitMap));
		}

		// Token: 0x0600CD9C RID: 52636 RVA: 0x003139F0 File Offset: 0x00311BF0
		public static RoleBeHitMap GetRootAsRoleBeHitMap(ByteBuffer _bb, RoleBeHitMap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CD9D RID: 52637 RVA: 0x00313A0D File Offset: 0x00311C0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CD9E RID: 52638 RVA: 0x00313A1C File Offset: 0x00311C1C
		public RoleBeHitMap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003279 RID: 12921
		// (get) Token: 0x0600CD9F RID: 52639 RVA: 0x00313A2C File Offset: 0x00311C2C
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

		// Token: 0x1700327A RID: 12922
		// (get) Token: 0x0600CDA0 RID: 52640 RVA: 0x00313A68 File Offset: 0x00311C68
		public string StateMachineName
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

		// Token: 0x0600CDA1 RID: 52641 RVA: 0x00313A9F File Offset: 0x00311C9F
		public Span<byte> GetStateMachineNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CDA2 RID: 52642 RVA: 0x00313AAE File Offset: 0x00311CAE
		public byte[] GetStateMachineNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0400571F RID: 22303
		private Table __p;
	}
}
