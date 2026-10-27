using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066D8 RID: 26328
	public struct IEntityControlConfig : IFlatbufferObject
	{
		// Token: 0x1700C393 RID: 50067
		// (get) Token: 0x0602DC43 RID: 187459 RVA: 0x00642784 File Offset: 0x00640984
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DC44 RID: 187460 RVA: 0x00642791 File Offset: 0x00640991
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DC45 RID: 187461 RVA: 0x00642798 File Offset: 0x00640998
		public static IEntityControlConfig GetRootAsIEntityControlConfig(ByteBuffer _bb)
		{
			return IEntityControlConfig.GetRootAsIEntityControlConfig(_bb, default(IEntityControlConfig));
		}

		// Token: 0x0602DC46 RID: 187462 RVA: 0x006427B4 File Offset: 0x006409B4
		public static IEntityControlConfig GetRootAsIEntityControlConfig(ByteBuffer _bb, IEntityControlConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DC47 RID: 187463 RVA: 0x006427D1 File Offset: 0x006409D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DC48 RID: 187464 RVA: 0x006427E0 File Offset: 0x006409E0
		public IEntityControlConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C394 RID: 50068
		// (get) Token: 0x0602DC49 RID: 187465 RVA: 0x006427F0 File Offset: 0x006409F0
		public bool IsControlPlayer
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C395 RID: 50069
		// (get) Token: 0x0602DC4A RID: 187466 RVA: 0x00642830 File Offset: 0x00640A30
		public bool HideSkipButton
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C396 RID: 50070
		// (get) Token: 0x0602DC4B RID: 187467 RVA: 0x00642870 File Offset: 0x00640A70
		public EEntityControlCameraMode CameraMode
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EEntityControlCameraMode.UseSequenceCamera;
				}
				return (EEntityControlCameraMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C397 RID: 50071
		// (get) Token: 0x0602DC4C RID: 187468 RVA: 0x006428AC File Offset: 0x00640AAC
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

		// Token: 0x0602DC4D RID: 187469 RVA: 0x006428E9 File Offset: 0x00640AE9
		public static Offset<IEntityControlConfig> CreateIEntityControlConfig(FlatBufferBuilder builder, bool IsControlPlayer = false, bool HideSkipButton = false, EEntityControlCameraMode CameraMode = EEntityControlCameraMode.UseSequenceCamera, byte NullMask = 0)
		{
			builder.StartTable(4);
			IEntityControlConfig.AddNullMask(builder, NullMask);
			IEntityControlConfig.AddCameraMode(builder, CameraMode);
			IEntityControlConfig.AddHideSkipButton(builder, HideSkipButton);
			IEntityControlConfig.AddIsControlPlayer(builder, IsControlPlayer);
			return IEntityControlConfig.EndIEntityControlConfig(builder);
		}

		// Token: 0x0602DC4E RID: 187470 RVA: 0x00642915 File Offset: 0x00640B15
		public static void StartIEntityControlConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602DC4F RID: 187471 RVA: 0x0064291E File Offset: 0x00640B1E
		public static void AddIsControlPlayer(FlatBufferBuilder builder, bool isControlPlayer)
		{
			builder.AddBool(0, isControlPlayer, false);
		}

		// Token: 0x0602DC50 RID: 187472 RVA: 0x00642929 File Offset: 0x00640B29
		public static void AddHideSkipButton(FlatBufferBuilder builder, bool hideSkipButton)
		{
			builder.AddBool(1, hideSkipButton, false);
		}

		// Token: 0x0602DC51 RID: 187473 RVA: 0x00642934 File Offset: 0x00640B34
		public static void AddCameraMode(FlatBufferBuilder builder, EEntityControlCameraMode cameraMode)
		{
			builder.AddByte(2, (byte)cameraMode, 0);
		}

		// Token: 0x0602DC52 RID: 187474 RVA: 0x0064293F File Offset: 0x00640B3F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602DC53 RID: 187475 RVA: 0x0064294A File Offset: 0x00640B4A
		public static Offset<IEntityControlConfig> EndIEntityControlConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEntityControlConfig>(builder.EndTable());
		}

		// Token: 0x0602DC54 RID: 187476 RVA: 0x00642958 File Offset: 0x00640B58
		public IEntityControlConfigT UnPack()
		{
			IEntityControlConfigT entityControlConfigT = new IEntityControlConfigT();
			this.UnPackTo(entityControlConfigT);
			return entityControlConfigT;
		}

		// Token: 0x0602DC55 RID: 187477 RVA: 0x00642973 File Offset: 0x00640B73
		public void UnPackTo(IEntityControlConfigT _o)
		{
			_o.IsControlPlayer = this.IsControlPlayer;
			_o.HideSkipButton = this.HideSkipButton;
			_o.CameraMode = this.CameraMode;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602DC56 RID: 187478 RVA: 0x006429A8 File Offset: 0x00640BA8
		public static Offset<IEntityControlConfig> Pack(FlatBufferBuilder builder, IEntityControlConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityControlConfig>);
			}
			return IEntityControlConfig.CreateIEntityControlConfig(builder, _o.IsControlPlayer, _o.HideSkipButton, _o.CameraMode, _o.NullMask);
		}

		// Token: 0x04010DA0 RID: 69024
		private Table __p;
	}
}
