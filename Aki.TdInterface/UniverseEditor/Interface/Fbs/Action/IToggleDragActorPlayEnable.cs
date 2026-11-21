using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BE7 RID: 31719
	public struct IToggleDragActorPlayEnable : IFlatbufferObject
	{
		// Token: 0x1700ED97 RID: 60823
		// (get) Token: 0x060392BA RID: 234170 RVA: 0x007B9845 File Offset: 0x007B7A45
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060392BB RID: 234171 RVA: 0x007B9852 File Offset: 0x007B7A52
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060392BC RID: 234172 RVA: 0x007B985C File Offset: 0x007B7A5C
		public static IToggleDragActorPlayEnable GetRootAsIToggleDragActorPlayEnable(ByteBuffer _bb)
		{
			return IToggleDragActorPlayEnable.GetRootAsIToggleDragActorPlayEnable(_bb, default(IToggleDragActorPlayEnable));
		}

		// Token: 0x060392BD RID: 234173 RVA: 0x007B9878 File Offset: 0x007B7A78
		public static IToggleDragActorPlayEnable GetRootAsIToggleDragActorPlayEnable(ByteBuffer _bb, IToggleDragActorPlayEnable obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060392BE RID: 234174 RVA: 0x007B9895 File Offset: 0x007B7A95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060392BF RID: 234175 RVA: 0x007B98A4 File Offset: 0x007B7AA4
		public IToggleDragActorPlayEnable __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ED98 RID: 60824
		// (get) Token: 0x060392C0 RID: 234176 RVA: 0x007B98B4 File Offset: 0x007B7AB4
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

		// Token: 0x1700ED99 RID: 60825
		// (get) Token: 0x060392C1 RID: 234177 RVA: 0x007B98F0 File Offset: 0x007B7AF0
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

		// Token: 0x1700ED9A RID: 60826
		// (get) Token: 0x060392C2 RID: 234178 RVA: 0x007B9950 File Offset: 0x007B7B50
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

		// Token: 0x060392C3 RID: 234179 RVA: 0x007B9987 File Offset: 0x007B7B87
		public Span<byte> GetTidMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060392C4 RID: 234180 RVA: 0x007B9996 File Offset: 0x007B7B96
		public byte[] GetTidMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700ED9B RID: 60827
		// (get) Token: 0x060392C5 RID: 234181 RVA: 0x007B99A4 File Offset: 0x007B7BA4
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

		// Token: 0x060392C6 RID: 234182 RVA: 0x007B99DC File Offset: 0x007B7BDC
		public Span<byte> GetTidSubTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060392C7 RID: 234183 RVA: 0x007B99EC File Offset: 0x007B7BEC
		public byte[] GetTidSubTextArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700ED9C RID: 60828
		// (get) Token: 0x060392C8 RID: 234184 RVA: 0x007B99FC File Offset: 0x007B7BFC
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

		// Token: 0x060392C9 RID: 234185 RVA: 0x007B9A34 File Offset: 0x007B7C34
		public Span<byte> GetTidHintTextBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060392CA RID: 234186 RVA: 0x007B9A44 File Offset: 0x007B7C44
		public byte[] GetTidHintTextArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700ED9D RID: 60829
		// (get) Token: 0x060392CB RID: 234187 RVA: 0x007B9A54 File Offset: 0x007B7C54
		public bool KeepDialog
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700ED9E RID: 60830
		// (get) Token: 0x060392CC RID: 234188 RVA: 0x007B9A94 File Offset: 0x007B7C94
		public bool DisableExit
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700ED9F RID: 60831
		// (get) Token: 0x060392CD RID: 234189 RVA: 0x007B9AD4 File Offset: 0x007B7CD4
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

		// Token: 0x060392CE RID: 234190 RVA: 0x007B9B14 File Offset: 0x007B7D14
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

		// Token: 0x060392CF RID: 234191 RVA: 0x007B9B6B File Offset: 0x007B7D6B
		public static void StartIToggleDragActorPlayEnable(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x060392D0 RID: 234192 RVA: 0x007B9B74 File Offset: 0x007B7D74
		public static void AddType(FlatBufferBuilder builder, EToggleDragActorPlayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060392D1 RID: 234193 RVA: 0x007B9B7F File Offset: 0x007B7D7F
		public static void AddCameraConfig(FlatBufferBuilder builder, Offset<IFixedCameraConfig> cameraConfigOffset)
		{
			builder.AddOffset(1, cameraConfigOffset.Value, 0);
		}

		// Token: 0x060392D2 RID: 234194 RVA: 0x007B9B8F File Offset: 0x007B7D8F
		public static void AddTidMainText(FlatBufferBuilder builder, StringOffset tidMainTextOffset)
		{
			builder.AddOffset(2, tidMainTextOffset.Value, 0);
		}

		// Token: 0x060392D3 RID: 234195 RVA: 0x007B9B9F File Offset: 0x007B7D9F
		public static void AddTidSubText(FlatBufferBuilder builder, StringOffset tidSubTextOffset)
		{
			builder.AddOffset(3, tidSubTextOffset.Value, 0);
		}

		// Token: 0x060392D4 RID: 234196 RVA: 0x007B9BAF File Offset: 0x007B7DAF
		public static void AddTidHintText(FlatBufferBuilder builder, StringOffset tidHintTextOffset)
		{
			builder.AddOffset(4, tidHintTextOffset.Value, 0);
		}

		// Token: 0x060392D5 RID: 234197 RVA: 0x007B9BBF File Offset: 0x007B7DBF
		public static void AddKeepDialog(FlatBufferBuilder builder, bool keepDialog)
		{
			builder.AddBool(5, keepDialog, false);
		}

		// Token: 0x060392D6 RID: 234198 RVA: 0x007B9BCA File Offset: 0x007B7DCA
		public static void AddDisableExit(FlatBufferBuilder builder, bool disableExit)
		{
			builder.AddBool(6, disableExit, false);
		}

		// Token: 0x060392D7 RID: 234199 RVA: 0x007B9BD5 File Offset: 0x007B7DD5
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x060392D8 RID: 234200 RVA: 0x007B9BE0 File Offset: 0x007B7DE0
		public static Offset<IToggleDragActorPlayEnable> EndIToggleDragActorPlayEnable(FlatBufferBuilder builder)
		{
			return new Offset<IToggleDragActorPlayEnable>(builder.EndTable());
		}

		// Token: 0x060392D9 RID: 234201 RVA: 0x007B9BF0 File Offset: 0x007B7DF0
		public IToggleDragActorPlayEnableT UnPack()
		{
			IToggleDragActorPlayEnableT toggleDragActorPlayEnableT = new IToggleDragActorPlayEnableT();
			this.UnPackTo(toggleDragActorPlayEnableT);
			return toggleDragActorPlayEnableT;
		}

		// Token: 0x060392DA RID: 234202 RVA: 0x007B9C0C File Offset: 0x007B7E0C
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

		// Token: 0x060392DB RID: 234203 RVA: 0x007B9C9C File Offset: 0x007B7E9C
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

		// Token: 0x04013279 RID: 78457
		private Table __p;
	}
}
