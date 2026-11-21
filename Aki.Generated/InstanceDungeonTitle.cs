using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E56 RID: 3670
	public struct InstanceDungeonTitle : IFlatbufferObject
	{
		// Token: 0x17001A14 RID: 6676
		// (get) Token: 0x06008B8F RID: 35727 RVA: 0x0028238B File Offset: 0x0028058B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008B90 RID: 35728 RVA: 0x00282398 File Offset: 0x00280598
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008B91 RID: 35729 RVA: 0x002823A0 File Offset: 0x002805A0
		public static InstanceDungeonTitle GetRootAsInstanceDungeonTitle(ByteBuffer _bb)
		{
			return InstanceDungeonTitle.GetRootAsInstanceDungeonTitle(_bb, default(InstanceDungeonTitle));
		}

		// Token: 0x06008B92 RID: 35730 RVA: 0x002823BC File Offset: 0x002805BC
		public static InstanceDungeonTitle GetRootAsInstanceDungeonTitle(ByteBuffer _bb, InstanceDungeonTitle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008B93 RID: 35731 RVA: 0x002823D9 File Offset: 0x002805D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008B94 RID: 35732 RVA: 0x002823E8 File Offset: 0x002805E8
		public InstanceDungeonTitle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A15 RID: 6677
		// (get) Token: 0x06008B95 RID: 35733 RVA: 0x002823F8 File Offset: 0x002805F8
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

		// Token: 0x17001A16 RID: 6678
		// (get) Token: 0x06008B96 RID: 35734 RVA: 0x00282434 File Offset: 0x00280634
		public string CommonText
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

		// Token: 0x06008B97 RID: 35735 RVA: 0x0028246B File Offset: 0x0028066B
		public Span<byte> GetCommonTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008B98 RID: 35736 RVA: 0x0028247A File Offset: 0x0028067A
		public byte[] GetCommonTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A17 RID: 6679
		// (get) Token: 0x06008B99 RID: 35737 RVA: 0x00282494 File Offset: 0x00280694
		public string IconTexture
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

		// Token: 0x06008B9A RID: 35738 RVA: 0x002824CB File Offset: 0x002806CB
		public Span<byte> GetIconTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008B9B RID: 35739 RVA: 0x002824DA File Offset: 0x002806DA
		public byte[] GetIconTextureArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040053DE RID: 21470
		private Table __p;
	}
}
