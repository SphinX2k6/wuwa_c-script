using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073FD RID: 29693
	public struct IToggleDragActorPlayEnable : IFlatbufferObject
	{
		// Token: 0x1700E182 RID: 57730
		// (get) Token: 0x06035F07 RID: 220935 RVA: 0x007570D1 File Offset: 0x007552D1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035F08 RID: 220936 RVA: 0x007570DE File Offset: 0x007552DE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035F09 RID: 220937 RVA: 0x007570E8 File Offset: 0x007552E8
		public static IToggleDragActorPlayEnable GetRootAsIToggleDragActorPlayEnable(ByteBuffer _bb)
		{
			return IToggleDragActorPlayEnable.GetRootAsIToggleDragActorPlayEnable(_bb, default(IToggleDragActorPlayEnable));
		}

		// Token: 0x06035F0A RID: 220938 RVA: 0x00757104 File Offset: 0x00755304
		public static IToggleDragActorPlayEnable GetRootAsIToggleDragActorPlayEnable(ByteBuffer _bb, IToggleDragActorPlayEnable obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035F0B RID: 220939 RVA: 0x00757121 File Offset: 0x00755321
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035F0C RID: 220940 RVA: 0x00757130 File Offset: 0x00755330
		public IToggleDragActorPlayEnable __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E183 RID: 57731
		// (get) Token: 0x06035F0D RID: 220941 RVA: 0x00757140 File Offset: 0x00755340
		public EToggleDragActorPlayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EToggleDragActorPlayType.Enable;
				}
				return (EToggleDragActorPlayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E184 RID: 57732
		// (get) Token: 0x06035F0E RID: 220942 RVA: 0x0075717C File Offset: 0x0075537C
		public IFixedCameraConfig? CameraConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IFixedCameraConfig?(default(IFixedCameraConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E185 RID: 57733
		// (get) Token: 0x06035F0F RID: 220943 RVA: 0x007571DC File Offset: 0x007553DC
		public string TidMainText
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

		// Token: 0x06035F10 RID: 220944 RVA: 0x00757213 File Offset: 0x00755413
		public Span<byte> GetTidMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06035F11 RID: 220945 RVA: 0x00757222 File Offset: 0x00755422
		public byte[] GetTidMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700E186 RID: 57734
		// (get) Token: 0x06035F12 RID: 220946 RVA: 0x00757230 File Offset: 0x00755430
		public string TidSubText
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

		// Token: 0x06035F13 RID: 220947 RVA: 0x00757268 File Offset: 0x00755468
		public Span<byte> GetTidSubTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06035F14 RID: 220948 RVA: 0x00757278 File Offset: 0x00755478
		public byte[] GetTidSubTextArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700E187 RID: 57735
		// (get) Token: 0x06035F15 RID: 220949 RVA: 0x00757288 File Offset: 0x00755488
		public string TidHintText
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035F16 RID: 220950 RVA: 0x007572C0 File Offset: 0x007554C0
		public Span<byte> GetTidHintTextBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06035F17 RID: 220951 RVA: 0x007572D0 File Offset: 0x007554D0
		public byte[] GetTidHintTextArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700E188 RID: 57736
		// (get) Token: 0x06035F18 RID: 220952 RVA: 0x007572E0 File Offset: 0x007554E0
		public bool KeepDialog
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E189 RID: 57737
		// (get) Token: 0x06035F19 RID: 220953 RVA: 0x00757320 File Offset: 0x00755520
		public bool DisableExit
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E18A RID: 57738
		// (get) Token: 0x06035F1A RID: 220954 RVA: 0x00757360 File Offset: 0x00755560
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035F1B RID: 220955 RVA: 0x007573A0 File Offset: 0x007555A0
		public static Offset<IToggleDragActorPlayEnable> CreateIToggleDragActorPlayEnable(FlatBufferBuilder builder, EToggleDragActorPlayType Type = EToggleDragActorPlayType.Enable, Offset<IFixedCameraConfig> CameraConfigOffset = default(Offset<IFixedCameraConfig>), StringOffset TidMainTextOffset = default(StringOffset), StringOffset TidSubTextOffset = default(StringOffset), StringOffset TidHintTextOffset = default(StringOffset), bool KeepDialog = false, bool DisableExit = false, byte NullMask = 0)
		{
			builder.StartTable(8);
			IToggleDragActorPlayEnable.AddTidHintText(builder, TidHintTextOffset);
			IToggleDragActorPlayEnable.AddTidSubText(builder, TidSubTextOffset);
			IToggleDragActorPlayEnable.AddTidMainText(builder, TidMainTextOffset);
			IToggleDragActorPlayEnable.AddCameraConfig(builder, CameraConfigOffset);
			IToggleDragActorPlayEnable.AddNullMask(builder, NullMask);
			IToggleDragActorPlayEnable.AddDisableExit(builder, DisableExit);
			IToggleDragActorPlayEnable.AddKeepDialog(builder, KeepDialog);
			IToggleDragActorPlayEnable.AddType(builder, Type);
			return IToggleDragActorPlayEnable.EndIToggleDragActorPlayEnable(builder);
		}

		// Token: 0x06035F1C RID: 220956 RVA: 0x007573F7 File Offset: 0x007555F7
		public static void StartIToggleDragActorPlayEnable(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06035F1D RID: 220957 RVA: 0x00757400 File Offset: 0x00755600
		public static void AddType(FlatBufferBuilder builder, EToggleDragActorPlayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035F1E RID: 220958 RVA: 0x0075740B File Offset: 0x0075560B
		public static void AddCameraConfig(FlatBufferBuilder builder, Offset<IFixedCameraConfig> cameraConfigOffset)
		{
			builder.AddOffset(1, cameraConfigOffset.Value, 0);
		}

		// Token: 0x06035F1F RID: 220959 RVA: 0x0075741B File Offset: 0x0075561B
		public static void AddTidMainText(FlatBufferBuilder builder, StringOffset tidMainTextOffset)
		{
			builder.AddOffset(2, tidMainTextOffset.Value, 0);
		}

		// Token: 0x06035F20 RID: 220960 RVA: 0x0075742B File Offset: 0x0075562B
		public static void AddTidSubText(FlatBufferBuilder builder, StringOffset tidSubTextOffset)
		{
			builder.AddOffset(3, tidSubTextOffset.Value, 0);
		}

		// Token: 0x06035F21 RID: 220961 RVA: 0x0075743B File Offset: 0x0075563B
		public static void AddTidHintText(FlatBufferBuilder builder, StringOffset tidHintTextOffset)
		{
			builder.AddOffset(4, tidHintTextOffset.Value, 0);
		}

		// Token: 0x06035F22 RID: 220962 RVA: 0x0075744B File Offset: 0x0075564B
		public static void AddKeepDialog(FlatBufferBuilder builder, bool keepDialog)
		{
			builder.AddBool(5, keepDialog, false);
		}

		// Token: 0x06035F23 RID: 220963 RVA: 0x00757456 File Offset: 0x00755656
		public static void AddDisableExit(FlatBufferBuilder builder, bool disableExit)
		{
			builder.AddBool(6, disableExit, false);
		}

		// Token: 0x06035F24 RID: 220964 RVA: 0x00757461 File Offset: 0x00755661
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06035F25 RID: 220965 RVA: 0x0075746C File Offset: 0x0075566C
		public static Offset<IToggleDragActorPlayEnable> EndIToggleDragActorPlayEnable(FlatBufferBuilder builder)
		{
			return new Offset<IToggleDragActorPlayEnable>(builder.EndTable());
		}

		// Token: 0x06035F26 RID: 220966 RVA: 0x0075747C File Offset: 0x0075567C
		public IToggleDragActorPlayEnableT UnPack()
		{
			IToggleDragActorPlayEnableT toggleDragActorPlayEnableT = new IToggleDragActorPlayEnableT();
			this.UnPackTo(toggleDragActorPlayEnableT);
			return toggleDragActorPlayEnableT;
		}

		// Token: 0x06035F27 RID: 220967 RVA: 0x00757498 File Offset: 0x00755698
		public void UnPackTo(IToggleDragActorPlayEnableT _o)
		{
			_o.Type = this.Type;
			_o.CameraConfig = ((this.CameraConfig != null) ? this.CameraConfig.Value.UnPack() : null);
			_o.TidMainText = this.TidMainText;
			_o.TidSubText = this.TidSubText;
			_o.TidHintText = this.TidHintText;
			_o.KeepDialog = this.KeepDialog;
			_o.DisableExit = this.DisableExit;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06035F28 RID: 220968 RVA: 0x00757528 File Offset: 0x00755728
		public static Offset<IToggleDragActorPlayEnable> Pack(FlatBufferBuilder builder, IToggleDragActorPlayEnableT _o)
		{
			if (_o == null)
			{
				return default(Offset<IToggleDragActorPlayEnable>);
			}
			Offset<IFixedCameraConfig> cameraConfigOffset = (_o.CameraConfig == null) ? default(Offset<IFixedCameraConfig>) : IFixedCameraConfig.Pack(builder, _o.CameraConfig);
			StringOffset tidMainTextOffset = (_o.TidMainText == null) ? default(StringOffset) : builder.CreateString(_o.TidMainText);
			StringOffset tidSubTextOffset = (_o.TidSubText == null) ? default(StringOffset) : builder.CreateString(_o.TidSubText);
			StringOffset tidHintTextOffset = (_o.TidHintText == null) ? default(StringOffset) : builder.CreateString(_o.TidHintText);
			return IToggleDragActorPlayEnable.CreateIToggleDragActorPlayEnable(builder, _o.Type, cameraConfigOffset, tidMainTextOffset, tidSubTextOffset, tidHintTextOffset, _o.KeepDialog, _o.DisableExit, _o.NullMask);
		}

		// Token: 0x0401225D RID: 74333
		private Table __p;
	}
}
