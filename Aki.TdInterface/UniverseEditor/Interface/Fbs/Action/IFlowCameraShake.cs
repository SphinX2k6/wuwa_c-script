using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E75 RID: 28277
	public struct IFlowCameraShake : IFlatbufferObject
	{
		// Token: 0x1700CF44 RID: 53060
		// (get) Token: 0x06030DB5 RID: 200117 RVA: 0x006A0DB3 File Offset: 0x0069EFB3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030DB6 RID: 200118 RVA: 0x006A0DC0 File Offset: 0x0069EFC0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030DB7 RID: 200119 RVA: 0x006A0DC8 File Offset: 0x0069EFC8
		public static IFlowCameraShake GetRootAsIFlowCameraShake(ByteBuffer _bb)
		{
			return IFlowCameraShake.GetRootAsIFlowCameraShake(_bb, default(IFlowCameraShake));
		}

		// Token: 0x06030DB8 RID: 200120 RVA: 0x006A0DE4 File Offset: 0x0069EFE4
		public static IFlowCameraShake GetRootAsIFlowCameraShake(ByteBuffer _bb, IFlowCameraShake obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030DB9 RID: 200121 RVA: 0x006A0E01 File Offset: 0x0069F001
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030DBA RID: 200122 RVA: 0x006A0E10 File Offset: 0x0069F010
		public IFlowCameraShake __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF45 RID: 53061
		// (get) Token: 0x06030DBB RID: 200123 RVA: 0x006A0E20 File Offset: 0x0069F020
		public string CameraShakeBp
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

		// Token: 0x06030DBC RID: 200124 RVA: 0x006A0E57 File Offset: 0x0069F057
		public Span<byte> GetCameraShakeBpBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06030DBD RID: 200125 RVA: 0x006A0E66 File Offset: 0x0069F066
		public byte[] GetCameraShakeBpArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06030DBE RID: 200126 RVA: 0x006A0E74 File Offset: 0x0069F074
		public static Offset<IFlowCameraShake> CreateIFlowCameraShake(FlatBufferBuilder builder, StringOffset CameraShakeBpOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IFlowCameraShake.AddCameraShakeBp(builder, CameraShakeBpOffset);
			return IFlowCameraShake.EndIFlowCameraShake(builder);
		}

		// Token: 0x06030DBF RID: 200127 RVA: 0x006A0E8A File Offset: 0x0069F08A
		public static void StartIFlowCameraShake(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030DC0 RID: 200128 RVA: 0x006A0E93 File Offset: 0x0069F093
		public static void AddCameraShakeBp(FlatBufferBuilder builder, StringOffset cameraShakeBpOffset)
		{
			builder.AddOffset(0, cameraShakeBpOffset.Value, 0);
		}

		// Token: 0x06030DC1 RID: 200129 RVA: 0x006A0EA3 File Offset: 0x0069F0A3
		public static Offset<IFlowCameraShake> EndIFlowCameraShake(FlatBufferBuilder builder)
		{
			return new Offset<IFlowCameraShake>(builder.EndTable());
		}

		// Token: 0x06030DC2 RID: 200130 RVA: 0x006A0EB0 File Offset: 0x0069F0B0
		public IFlowCameraShakeT UnPack()
		{
			IFlowCameraShakeT flowCameraShakeT = new IFlowCameraShakeT();
			this.UnPackTo(flowCameraShakeT);
			return flowCameraShakeT;
		}

		// Token: 0x06030DC3 RID: 200131 RVA: 0x006A0ECB File Offset: 0x0069F0CB
		public void UnPackTo(IFlowCameraShakeT _o)
		{
			_o.CameraShakeBp = this.CameraShakeBp;
		}

		// Token: 0x06030DC4 RID: 200132 RVA: 0x006A0EDC File Offset: 0x0069F0DC
		public static Offset<IFlowCameraShake> Pack(FlatBufferBuilder builder, IFlowCameraShakeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowCameraShake>);
			}
			StringOffset cameraShakeBpOffset = (_o.CameraShakeBp == null) ? default(StringOffset) : builder.CreateString(_o.CameraShakeBp);
			return IFlowCameraShake.CreateIFlowCameraShake(builder, cameraShakeBpOffset);
		}

		// Token: 0x04011D47 RID: 73031
		private Table __p;
	}
}
