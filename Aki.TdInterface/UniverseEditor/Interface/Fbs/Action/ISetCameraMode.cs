using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200779D RID: 30621
	public struct ISetCameraMode : IFlatbufferObject
	{
		// Token: 0x1700E05D RID: 57437
		// (get) Token: 0x06035C03 RID: 220163 RVA: 0x00733988 File Offset: 0x00731B88
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035C04 RID: 220164 RVA: 0x00733995 File Offset: 0x00731B95
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035C05 RID: 220165 RVA: 0x0073399C File Offset: 0x00731B9C
		public static ISetCameraMode GetRootAsISetCameraMode(ByteBuffer _bb)
		{
			return ISetCameraMode.GetRootAsISetCameraMode(_bb, default(ISetCameraMode));
		}

		// Token: 0x06035C06 RID: 220166 RVA: 0x007339B8 File Offset: 0x00731BB8
		public static ISetCameraMode GetRootAsISetCameraMode(ByteBuffer _bb, ISetCameraMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035C07 RID: 220167 RVA: 0x007339D5 File Offset: 0x00731BD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035C08 RID: 220168 RVA: 0x007339E4 File Offset: 0x00731BE4
		public ISetCameraMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E05E RID: 57438
		// (get) Token: 0x06035C09 RID: 220169 RVA: 0x007339F4 File Offset: 0x00731BF4
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

		// Token: 0x06035C0A RID: 220170 RVA: 0x00733A2B File Offset: 0x00731C2B
		public Span<byte> GetModeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06035C0B RID: 220171 RVA: 0x00733A3A File Offset: 0x00731C3A
		public byte[] GetModeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06035C0C RID: 220172 RVA: 0x00733A48 File Offset: 0x00731C48
		public static Offset<ISetCameraMode> CreateISetCameraMode(FlatBufferBuilder builder, StringOffset ModeOffset = default(StringOffset))
		{
			builder.StartTable(1);
			ISetCameraMode.AddMode(builder, ModeOffset);
			return ISetCameraMode.EndISetCameraMode(builder);
		}

		// Token: 0x06035C0D RID: 220173 RVA: 0x00733A5E File Offset: 0x00731C5E
		public static void StartISetCameraMode(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035C0E RID: 220174 RVA: 0x00733A67 File Offset: 0x00731C67
		public static void AddMode(FlatBufferBuilder builder, StringOffset modeOffset)
		{
			builder.AddOffset(0, modeOffset.Value, 0);
		}

		// Token: 0x06035C0F RID: 220175 RVA: 0x00733A77 File Offset: 0x00731C77
		public static Offset<ISetCameraMode> EndISetCameraMode(FlatBufferBuilder builder)
		{
			return new Offset<ISetCameraMode>(builder.EndTable());
		}

		// Token: 0x06035C10 RID: 220176 RVA: 0x00733A84 File Offset: 0x00731C84
		public ISetCameraModeT UnPack()
		{
			ISetCameraModeT setCameraModeT = new ISetCameraModeT();
			this.UnPackTo(setCameraModeT);
			return setCameraModeT;
		}

		// Token: 0x06035C11 RID: 220177 RVA: 0x00733A9F File Offset: 0x00731C9F
		public void UnPackTo(ISetCameraModeT _o)
		{
			_o.Mode = this.Mode;
		}

		// Token: 0x06035C12 RID: 220178 RVA: 0x00733AB0 File Offset: 0x00731CB0
		public static Offset<ISetCameraMode> Pack(FlatBufferBuilder builder, ISetCameraModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetCameraMode>);
			}
			StringOffset modeOffset = (_o.Mode == null) ? default(StringOffset) : builder.CreateString(_o.Mode);
			return ISetCameraMode.CreateISetCameraMode(builder, modeOffset);
		}

		// Token: 0x040129C5 RID: 76229
		private Table __p;
	}
}
