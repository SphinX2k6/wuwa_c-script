using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055A7 RID: 21927
	public struct ICubeMapBinding : IFlatbufferObject
	{
		// Token: 0x17009D03 RID: 40195
		// (get) Token: 0x06022E0F RID: 142863 RVA: 0x004CDBB6 File Offset: 0x004CBDB6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022E10 RID: 142864 RVA: 0x004CDBC3 File Offset: 0x004CBDC3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022E11 RID: 142865 RVA: 0x004CDBCC File Offset: 0x004CBDCC
		public static ICubeMapBinding GetRootAsICubeMapBinding(ByteBuffer _bb)
		{
			return ICubeMapBinding.GetRootAsICubeMapBinding(_bb, default(ICubeMapBinding));
		}

		// Token: 0x06022E12 RID: 142866 RVA: 0x004CDBE8 File Offset: 0x004CBDE8
		public static ICubeMapBinding GetRootAsICubeMapBinding(ByteBuffer _bb, ICubeMapBinding obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022E13 RID: 142867 RVA: 0x004CDC05 File Offset: 0x004CBE05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022E14 RID: 142868 RVA: 0x004CDC14 File Offset: 0x004CBE14
		public ICubeMapBinding __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D04 RID: 40196
		// (get) Token: 0x06022E15 RID: 142869 RVA: 0x004CDC24 File Offset: 0x004CBE24
		public string CubeMapActorKey
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022E16 RID: 142870 RVA: 0x004CDC5B File Offset: 0x004CBE5B
		public Span<byte> GetCubeMapActorKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06022E17 RID: 142871 RVA: 0x004CDC6A File Offset: 0x004CBE6A
		public byte[] GetCubeMapActorKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17009D05 RID: 40197
		// (get) Token: 0x06022E18 RID: 142872 RVA: 0x004CDC78 File Offset: 0x004CBE78
		public string CubeMapPath
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

		// Token: 0x06022E19 RID: 142873 RVA: 0x004CDCAF File Offset: 0x004CBEAF
		public Span<byte> GetCubeMapPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06022E1A RID: 142874 RVA: 0x004CDCBE File Offset: 0x004CBEBE
		public byte[] GetCubeMapPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06022E1B RID: 142875 RVA: 0x004CDCCC File Offset: 0x004CBECC
		public static Offset<ICubeMapBinding> CreateICubeMapBinding(FlatBufferBuilder builder, StringOffset CubeMapActorKeyOffset = default(StringOffset), StringOffset CubeMapPathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ICubeMapBinding.AddCubeMapPath(builder, CubeMapPathOffset);
			ICubeMapBinding.AddCubeMapActorKey(builder, CubeMapActorKeyOffset);
			return ICubeMapBinding.EndICubeMapBinding(builder);
		}

		// Token: 0x06022E1C RID: 142876 RVA: 0x004CDCE9 File Offset: 0x004CBEE9
		public static void StartICubeMapBinding(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06022E1D RID: 142877 RVA: 0x004CDCF2 File Offset: 0x004CBEF2
		public static void AddCubeMapActorKey(FlatBufferBuilder builder, StringOffset cubeMapActorKeyOffset)
		{
			builder.AddOffset(0, cubeMapActorKeyOffset.Value, 0);
		}

		// Token: 0x06022E1E RID: 142878 RVA: 0x004CDD02 File Offset: 0x004CBF02
		public static void AddCubeMapPath(FlatBufferBuilder builder, StringOffset cubeMapPathOffset)
		{
			builder.AddOffset(1, cubeMapPathOffset.Value, 0);
		}

		// Token: 0x06022E1F RID: 142879 RVA: 0x004CDD12 File Offset: 0x004CBF12
		public static Offset<ICubeMapBinding> EndICubeMapBinding(FlatBufferBuilder builder)
		{
			return new Offset<ICubeMapBinding>(builder.EndTable());
		}

		// Token: 0x06022E20 RID: 142880 RVA: 0x004CDD20 File Offset: 0x004CBF20
		public ICubeMapBindingT UnPack()
		{
			ICubeMapBindingT cubeMapBindingT = new ICubeMapBindingT();
			this.UnPackTo(cubeMapBindingT);
			return cubeMapBindingT;
		}

		// Token: 0x06022E21 RID: 142881 RVA: 0x004CDD3B File Offset: 0x004CBF3B
		public void UnPackTo(ICubeMapBindingT _o)
		{
			_o.CubeMapActorKey = this.CubeMapActorKey;
			_o.CubeMapPath = this.CubeMapPath;
		}

		// Token: 0x06022E22 RID: 142882 RVA: 0x004CDD58 File Offset: 0x004CBF58
		public static Offset<ICubeMapBinding> Pack(FlatBufferBuilder builder, ICubeMapBindingT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICubeMapBinding>);
			}
			StringOffset cubeMapActorKeyOffset = (_o.CubeMapActorKey == null) ? default(StringOffset) : builder.CreateString(_o.CubeMapActorKey);
			StringOffset cubeMapPathOffset = (_o.CubeMapPath == null) ? default(StringOffset) : builder.CreateString(_o.CubeMapPath);
			return ICubeMapBinding.CreateICubeMapBinding(builder, cubeMapActorKeyOffset, cubeMapPathOffset);
		}

		// Token: 0x0400EC32 RID: 60466
		private Table __p;
	}
}
