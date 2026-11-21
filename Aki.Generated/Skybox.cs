using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011C6 RID: 4550
	public struct Skybox : IFlatbufferObject
	{
		// Token: 0x17003843 RID: 14403
		// (get) Token: 0x0600DE2D RID: 56877 RVA: 0x00339752 File Offset: 0x00337952
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DE2E RID: 56878 RVA: 0x0033975F File Offset: 0x0033795F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DE2F RID: 56879 RVA: 0x00339768 File Offset: 0x00337968
		public static Skybox GetRootAsSkybox(ByteBuffer _bb)
		{
			return Skybox.GetRootAsSkybox(_bb, default(Skybox));
		}

		// Token: 0x0600DE30 RID: 56880 RVA: 0x00339784 File Offset: 0x00337984
		public static Skybox GetRootAsSkybox(ByteBuffer _bb, Skybox obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DE31 RID: 56881 RVA: 0x003397A1 File Offset: 0x003379A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DE32 RID: 56882 RVA: 0x003397B0 File Offset: 0x003379B0
		public Skybox __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003844 RID: 14404
		// (get) Token: 0x0600DE33 RID: 56883 RVA: 0x003397C0 File Offset: 0x003379C0
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

		// Token: 0x17003845 RID: 14405
		// (get) Token: 0x0600DE34 RID: 56884 RVA: 0x003397FC File Offset: 0x003379FC
		public string Name
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

		// Token: 0x0600DE35 RID: 56885 RVA: 0x00339833 File Offset: 0x00337A33
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600DE36 RID: 56886 RVA: 0x00339842 File Offset: 0x00337A42
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003846 RID: 14406
		// (get) Token: 0x0600DE37 RID: 56887 RVA: 0x0033985C File Offset: 0x00337A5C
		public string StaticSkybox
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

		// Token: 0x0600DE38 RID: 56888 RVA: 0x00339893 File Offset: 0x00337A93
		public Span<byte> GetStaticSkyboxBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DE39 RID: 56889 RVA: 0x003398A2 File Offset: 0x00337AA2
		public byte[] GetStaticSkyboxArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003847 RID: 14407
		// (get) Token: 0x0600DE3A RID: 56890 RVA: 0x003398BC File Offset: 0x00337ABC
		public string DynamicSkybox
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

		// Token: 0x0600DE3B RID: 56891 RVA: 0x003398F4 File Offset: 0x00337AF4
		public Span<byte> GetDynamicSkyboxBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600DE3C RID: 56892 RVA: 0x00339904 File Offset: 0x00337B04
		public byte[] GetDynamicSkyboxArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040057FC RID: 22524
		private Table __p;
	}
}
