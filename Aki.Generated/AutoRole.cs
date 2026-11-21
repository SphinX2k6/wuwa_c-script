using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BEC RID: 3052
	public struct AutoRole : IFlatbufferObject
	{
		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06004F0F RID: 20239 RVA: 0x001F9F5D File Offset: 0x001F815D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004F10 RID: 20240 RVA: 0x001F9F6A File Offset: 0x001F816A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004F11 RID: 20241 RVA: 0x001F9F74 File Offset: 0x001F8174
		public static AutoRole GetRootAsAutoRole(ByteBuffer _bb)
		{
			return AutoRole.GetRootAsAutoRole(_bb, default(AutoRole));
		}

		// Token: 0x06004F12 RID: 20242 RVA: 0x001F9F90 File Offset: 0x001F8190
		public static AutoRole GetRootAsAutoRole(ByteBuffer _bb, AutoRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004F13 RID: 20243 RVA: 0x001F9FAD File Offset: 0x001F81AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004F14 RID: 20244 RVA: 0x001F9FBC File Offset: 0x001F81BC
		public AutoRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06004F15 RID: 20245 RVA: 0x001F9FCC File Offset: 0x001F81CC
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

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06004F16 RID: 20246 RVA: 0x001FA008 File Offset: 0x001F8208
		public int ModelId
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

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06004F17 RID: 20247 RVA: 0x001FA044 File Offset: 0x001F8244
		public int AiId
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

		// Token: 0x040050D4 RID: 20692
		private Table __p;
	}
}
