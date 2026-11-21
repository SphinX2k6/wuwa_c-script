using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001139 RID: 4409
	public struct RoleInfoAudio : IFlatbufferObject
	{
		// Token: 0x17003345 RID: 13125
		// (get) Token: 0x0600CFC2 RID: 53186 RVA: 0x003186AC File Offset: 0x003168AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CFC3 RID: 53187 RVA: 0x003186B9 File Offset: 0x003168B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CFC4 RID: 53188 RVA: 0x003186C0 File Offset: 0x003168C0
		public static RoleInfoAudio GetRootAsRoleInfoAudio(ByteBuffer _bb)
		{
			return RoleInfoAudio.GetRootAsRoleInfoAudio(_bb, default(RoleInfoAudio));
		}

		// Token: 0x0600CFC5 RID: 53189 RVA: 0x003186DC File Offset: 0x003168DC
		public static RoleInfoAudio GetRootAsRoleInfoAudio(ByteBuffer _bb, RoleInfoAudio obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CFC6 RID: 53190 RVA: 0x003186F9 File Offset: 0x003168F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CFC7 RID: 53191 RVA: 0x00318708 File Offset: 0x00316908
		public RoleInfoAudio __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003346 RID: 13126
		// (get) Token: 0x0600CFC8 RID: 53192 RVA: 0x00318718 File Offset: 0x00316918
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

		// Token: 0x17003347 RID: 13127
		// (get) Token: 0x0600CFC9 RID: 53193 RVA: 0x00318754 File Offset: 0x00316954
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

		// Token: 0x0600CFCA RID: 53194 RVA: 0x0031878B File Offset: 0x0031698B
		public Span<byte> GetFootstepEventBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CFCB RID: 53195 RVA: 0x0031879A File Offset: 0x0031699A
		public byte[] GetFootstepEventArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003348 RID: 13128
		// (get) Token: 0x0600CFCC RID: 53196 RVA: 0x003187B4 File Offset: 0x003169B4
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

		// Token: 0x0600CFCD RID: 53197 RVA: 0x003187EB File Offset: 0x003169EB
		public Span<byte> GetFoleyEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600CFCE RID: 53198 RVA: 0x003187FA File Offset: 0x003169FA
		public byte[] GetFoleyEventArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0400573A RID: 22330
		private Table __p;
	}
}
