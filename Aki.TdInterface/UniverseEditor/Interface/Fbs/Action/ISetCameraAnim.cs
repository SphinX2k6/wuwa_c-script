using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FD1 RID: 28625
	public struct ISetCameraAnim : IFlatbufferObject
	{
		// Token: 0x1700D480 RID: 54400
		// (get) Token: 0x0603297D RID: 207229 RVA: 0x006D39E3 File Offset: 0x006D1BE3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603297E RID: 207230 RVA: 0x006D39F0 File Offset: 0x006D1BF0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603297F RID: 207231 RVA: 0x006D39F8 File Offset: 0x006D1BF8
		public static ISetCameraAnim GetRootAsISetCameraAnim(ByteBuffer _bb)
		{
			return ISetCameraAnim.GetRootAsISetCameraAnim(_bb, default(ISetCameraAnim));
		}

		// Token: 0x06032980 RID: 207232 RVA: 0x006D3A14 File Offset: 0x006D1C14
		public static ISetCameraAnim GetRootAsISetCameraAnim(ByteBuffer _bb, ISetCameraAnim obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032981 RID: 207233 RVA: 0x006D3A31 File Offset: 0x006D1C31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032982 RID: 207234 RVA: 0x006D3A40 File Offset: 0x006D1C40
		public ISetCameraAnim __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D481 RID: 54401
		// (get) Token: 0x06032983 RID: 207235 RVA: 0x006D3A50 File Offset: 0x006D1C50
		public string CameraAnimDataAsset
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

		// Token: 0x06032984 RID: 207236 RVA: 0x006D3A87 File Offset: 0x006D1C87
		public Span<byte> GetCameraAnimDataAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06032985 RID: 207237 RVA: 0x006D3A96 File Offset: 0x006D1C96
		public byte[] GetCameraAnimDataAssetArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700D482 RID: 54402
		// (get) Token: 0x06032986 RID: 207238 RVA: 0x006D3AA4 File Offset: 0x006D1CA4
		public float Speed
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

		// Token: 0x1700D483 RID: 54403
		// (get) Token: 0x06032987 RID: 207239 RVA: 0x006D3AE4 File Offset: 0x006D1CE4
		public bool UseNoise
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D484 RID: 54404
		// (get) Token: 0x06032988 RID: 207240 RVA: 0x006D3B24 File Offset: 0x006D1D24
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032989 RID: 207241 RVA: 0x006D3B61 File Offset: 0x006D1D61
		public static Offset<ISetCameraAnim> CreateISetCameraAnim(FlatBufferBuilder builder, StringOffset CameraAnimDataAssetOffset = default(StringOffset), float Speed = 0f, bool UseNoise = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			ISetCameraAnim.AddSpeed(builder, Speed);
			ISetCameraAnim.AddCameraAnimDataAsset(builder, CameraAnimDataAssetOffset);
			ISetCameraAnim.AddNullMask(builder, NullMask);
			ISetCameraAnim.AddUseNoise(builder, UseNoise);
			return ISetCameraAnim.EndISetCameraAnim(builder);
		}

		// Token: 0x0603298A RID: 207242 RVA: 0x006D3B8D File Offset: 0x006D1D8D
		public static void StartISetCameraAnim(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0603298B RID: 207243 RVA: 0x006D3B96 File Offset: 0x006D1D96
		public static void AddCameraAnimDataAsset(FlatBufferBuilder builder, StringOffset cameraAnimDataAssetOffset)
		{
			builder.AddOffset(0, cameraAnimDataAssetOffset.Value, 0);
		}

		// Token: 0x0603298C RID: 207244 RVA: 0x006D3BA6 File Offset: 0x006D1DA6
		public static void AddSpeed(FlatBufferBuilder builder, float speed)
		{
			builder.AddFloat(1, speed, 0.0);
		}

		// Token: 0x0603298D RID: 207245 RVA: 0x006D3BB9 File Offset: 0x006D1DB9
		public static void AddUseNoise(FlatBufferBuilder builder, bool useNoise)
		{
			builder.AddBool(2, useNoise, false);
		}

		// Token: 0x0603298E RID: 207246 RVA: 0x006D3BC4 File Offset: 0x006D1DC4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0603298F RID: 207247 RVA: 0x006D3BCF File Offset: 0x006D1DCF
		public static Offset<ISetCameraAnim> EndISetCameraAnim(FlatBufferBuilder builder)
		{
			return new Offset<ISetCameraAnim>(builder.EndTable());
		}

		// Token: 0x06032990 RID: 207248 RVA: 0x006D3BDC File Offset: 0x006D1DDC
		public ISetCameraAnimT UnPack()
		{
			ISetCameraAnimT setCameraAnimT = new ISetCameraAnimT();
			this.UnPackTo(setCameraAnimT);
			return setCameraAnimT;
		}

		// Token: 0x06032991 RID: 207249 RVA: 0x006D3BF7 File Offset: 0x006D1DF7
		public void UnPackTo(ISetCameraAnimT _o)
		{
			_o.CameraAnimDataAsset = this.CameraAnimDataAsset;
			_o.Speed = this.Speed;
			_o.UseNoise = this.UseNoise;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06032992 RID: 207250 RVA: 0x006D3C2C File Offset: 0x006D1E2C
		public static Offset<ISetCameraAnim> Pack(FlatBufferBuilder builder, ISetCameraAnimT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetCameraAnim>);
			}
			StringOffset cameraAnimDataAssetOffset = (_o.CameraAnimDataAsset == null) ? default(StringOffset) : builder.CreateString(_o.CameraAnimDataAsset);
			return ISetCameraAnim.CreateISetCameraAnim(builder, cameraAnimDataAssetOffset, _o.Speed, _o.UseNoise, _o.NullMask);
		}

		// Token: 0x040119DB RID: 72155
		private Table __p;
	}
}
