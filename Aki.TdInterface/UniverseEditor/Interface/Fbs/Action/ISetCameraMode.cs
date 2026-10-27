using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FD4 RID: 28628
	public struct ISetCameraMode : IFlatbufferObject
	{
		// Token: 0x1700D489 RID: 54409
		// (get) Token: 0x0603299D RID: 207261 RVA: 0x006D3D44 File Offset: 0x006D1F44
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603299E RID: 207262 RVA: 0x006D3D51 File Offset: 0x006D1F51
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603299F RID: 207263 RVA: 0x006D3D58 File Offset: 0x006D1F58
		public static ISetCameraMode GetRootAsISetCameraMode(ByteBuffer _bb)
		{
			return ISetCameraMode.GetRootAsISetCameraMode(_bb, default(ISetCameraMode));
		}

		// Token: 0x060329A0 RID: 207264 RVA: 0x006D3D74 File Offset: 0x006D1F74
		public static ISetCameraMode GetRootAsISetCameraMode(ByteBuffer _bb, ISetCameraMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060329A1 RID: 207265 RVA: 0x006D3D91 File Offset: 0x006D1F91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060329A2 RID: 207266 RVA: 0x006D3DA0 File Offset: 0x006D1FA0
		public ISetCameraMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D48A RID: 54410
		// (get) Token: 0x060329A3 RID: 207267 RVA: 0x006D3DB0 File Offset: 0x006D1FB0
		public string Mode
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

		// Token: 0x060329A4 RID: 207268 RVA: 0x006D3DE7 File Offset: 0x006D1FE7
		public Span<byte> GetModeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060329A5 RID: 207269 RVA: 0x006D3DF6 File Offset: 0x006D1FF6
		public byte[] GetModeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x060329A6 RID: 207270 RVA: 0x006D3E04 File Offset: 0x006D2004
		public static Offset<ISetCameraMode> CreateISetCameraMode(FlatBufferBuilder builder, StringOffset ModeOffset = default(StringOffset))
		{
			builder.StartTable(1);
			ISetCameraMode.AddMode(builder, ModeOffset);
			return ISetCameraMode.EndISetCameraMode(builder);
		}

		// Token: 0x060329A7 RID: 207271 RVA: 0x006D3E1A File Offset: 0x006D201A
		public static void StartISetCameraMode(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060329A8 RID: 207272 RVA: 0x006D3E23 File Offset: 0x006D2023
		public static void AddMode(FlatBufferBuilder builder, StringOffset modeOffset)
		{
			builder.AddOffset(0, modeOffset.Value, 0);
		}

		// Token: 0x060329A9 RID: 207273 RVA: 0x006D3E33 File Offset: 0x006D2033
		public static Offset<ISetCameraMode> EndISetCameraMode(FlatBufferBuilder builder)
		{
			return new Offset<ISetCameraMode>(builder.EndTable());
		}

		// Token: 0x060329AA RID: 207274 RVA: 0x006D3E40 File Offset: 0x006D2040
		public ISetCameraModeT UnPack()
		{
			ISetCameraModeT setCameraModeT = new ISetCameraModeT();
			this.UnPackTo(setCameraModeT);
			return setCameraModeT;
		}

		// Token: 0x060329AB RID: 207275 RVA: 0x006D3E5B File Offset: 0x006D205B
		public void UnPackTo(ISetCameraModeT _o)
		{
			_o.Mode = this.Mode;
		}

		// Token: 0x060329AC RID: 207276 RVA: 0x006D3E6C File Offset: 0x006D206C
		public static Offset<ISetCameraMode> Pack(FlatBufferBuilder builder, ISetCameraModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetCameraMode>);
			}
			StringOffset modeOffset = (_o.Mode == null) ? default(StringOffset) : builder.CreateString(_o.Mode);
			return ISetCameraMode.CreateISetCameraMode(builder, modeOffset);
		}

		// Token: 0x040119E0 RID: 72160
		private Table __p;
	}
}
