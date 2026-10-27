using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010CB RID: 4299
	public struct Skybox : IFlatbufferObject
	{
		// Token: 0x17003732 RID: 14130
		// (get) Token: 0x0600D650 RID: 54864 RVA: 0x0031A77D File Offset: 0x0031897D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D651 RID: 54865 RVA: 0x0031A78A File Offset: 0x0031898A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D652 RID: 54866 RVA: 0x0031A794 File Offset: 0x00318994
		public static Skybox GetRootAsSkybox(ByteBuffer _bb)
		{
			return Skybox.GetRootAsSkybox(_bb, default(Skybox));
		}

		// Token: 0x0600D653 RID: 54867 RVA: 0x0031A7B0 File Offset: 0x003189B0
		public static Skybox GetRootAsSkybox(ByteBuffer _bb, Skybox obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D654 RID: 54868 RVA: 0x0031A7CD File Offset: 0x003189CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D655 RID: 54869 RVA: 0x0031A7DC File Offset: 0x003189DC
		public Skybox __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003733 RID: 14131
		// (get) Token: 0x0600D656 RID: 54870 RVA: 0x0031A7EC File Offset: 0x003189EC
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

		// Token: 0x17003734 RID: 14132
		// (get) Token: 0x0600D657 RID: 54871 RVA: 0x0031A828 File Offset: 0x00318A28
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

		// Token: 0x0600D658 RID: 54872 RVA: 0x0031A85F File Offset: 0x00318A5F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D659 RID: 54873 RVA: 0x0031A86E File Offset: 0x00318A6E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003735 RID: 14133
		// (get) Token: 0x0600D65A RID: 54874 RVA: 0x0031A888 File Offset: 0x00318A88
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

		// Token: 0x0600D65B RID: 54875 RVA: 0x0031A8BF File Offset: 0x00318ABF
		public Span<byte> GetStaticSkyboxBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D65C RID: 54876 RVA: 0x0031A8CE File Offset: 0x00318ACE
		public byte[] GetStaticSkyboxArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003736 RID: 14134
		// (get) Token: 0x0600D65D RID: 54877 RVA: 0x0031A8E8 File Offset: 0x00318AE8
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

		// Token: 0x0600D65E RID: 54878 RVA: 0x0031A920 File Offset: 0x00318B20
		public Span<byte> GetDynamicSkyboxBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D65F RID: 54879 RVA: 0x0031A930 File Offset: 0x00318B30
		public byte[] GetDynamicSkyboxArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040051FD RID: 20989
		private Table __p;
	}
}
