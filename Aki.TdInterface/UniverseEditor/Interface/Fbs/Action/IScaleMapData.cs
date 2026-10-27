using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F18 RID: 28440
	public struct IScaleMapData : IFlatbufferObject
	{
		// Token: 0x1700D36F RID: 54127
		// (get) Token: 0x060323F3 RID: 205811 RVA: 0x006C9BF0 File Offset: 0x006C7DF0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060323F4 RID: 205812 RVA: 0x006C9BFD File Offset: 0x006C7DFD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060323F5 RID: 205813 RVA: 0x006C9C04 File Offset: 0x006C7E04
		public static IScaleMapData GetRootAsIScaleMapData(ByteBuffer _bb)
		{
			return IScaleMapData.GetRootAsIScaleMapData(_bb, default(IScaleMapData));
		}

		// Token: 0x060323F6 RID: 205814 RVA: 0x006C9C20 File Offset: 0x006C7E20
		public static IScaleMapData GetRootAsIScaleMapData(ByteBuffer _bb, IScaleMapData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060323F7 RID: 205815 RVA: 0x006C9C3D File Offset: 0x006C7E3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060323F8 RID: 205816 RVA: 0x006C9C4C File Offset: 0x006C7E4C
		public IScaleMapData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D370 RID: 54128
		// (get) Token: 0x060323F9 RID: 205817 RVA: 0x006C9C5C File Offset: 0x006C7E5C
		public string Key
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

		// Token: 0x060323FA RID: 205818 RVA: 0x006C9C93 File Offset: 0x006C7E93
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060323FB RID: 205819 RVA: 0x006C9CA2 File Offset: 0x006C7EA2
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700D371 RID: 54129
		// (get) Token: 0x060323FC RID: 205820 RVA: 0x006C9CB0 File Offset: 0x006C7EB0
		public float Scale
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060323FD RID: 205821 RVA: 0x006C9CF0 File Offset: 0x006C7EF0
		public static Offset<IScaleMapData> CreateIScaleMapData(FlatBufferBuilder builder, StringOffset KeyOffset = default(StringOffset), float Scale = 0f)
		{
			builder.StartTable(2);
			IScaleMapData.AddScale(builder, Scale);
			IScaleMapData.AddKey(builder, KeyOffset);
			return IScaleMapData.EndIScaleMapData(builder);
		}

		// Token: 0x060323FE RID: 205822 RVA: 0x006C9D0D File Offset: 0x006C7F0D
		public static void StartIScaleMapData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060323FF RID: 205823 RVA: 0x006C9D16 File Offset: 0x006C7F16
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(0, keyOffset.Value, 0);
		}

		// Token: 0x06032400 RID: 205824 RVA: 0x006C9D26 File Offset: 0x006C7F26
		public static void AddScale(FlatBufferBuilder builder, float scale)
		{
			builder.AddFloat(1, scale, 0.0);
		}

		// Token: 0x06032401 RID: 205825 RVA: 0x006C9D39 File Offset: 0x006C7F39
		public static Offset<IScaleMapData> EndIScaleMapData(FlatBufferBuilder builder)
		{
			return new Offset<IScaleMapData>(builder.EndTable());
		}

		// Token: 0x06032402 RID: 205826 RVA: 0x006C9D48 File Offset: 0x006C7F48
		public IScaleMapDataT UnPack()
		{
			IScaleMapDataT scaleMapDataT = new IScaleMapDataT();
			this.UnPackTo(scaleMapDataT);
			return scaleMapDataT;
		}

		// Token: 0x06032403 RID: 205827 RVA: 0x006C9D63 File Offset: 0x006C7F63
		public void UnPackTo(IScaleMapDataT _o)
		{
			_o.Key = this.Key;
			_o.Scale = this.Scale;
		}

		// Token: 0x06032404 RID: 205828 RVA: 0x006C9D80 File Offset: 0x006C7F80
		public static Offset<IScaleMapData> Pack(FlatBufferBuilder builder, IScaleMapDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IScaleMapData>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			return IScaleMapData.CreateIScaleMapData(builder, keyOffset, _o.Scale);
		}

		// Token: 0x04011903 RID: 71939
		private Table __p;
	}
}
