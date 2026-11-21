using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D52 RID: 27986
	public struct IEntityControlConfig : IFlatbufferObject
	{
		// Token: 0x1700CD44 RID: 52548
		// (get) Token: 0x06030460 RID: 197728 RVA: 0x0068FA38 File Offset: 0x0068DC38
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030461 RID: 197729 RVA: 0x0068FA45 File Offset: 0x0068DC45
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030462 RID: 197730 RVA: 0x0068FA4C File Offset: 0x0068DC4C
		public static IEntityControlConfig GetRootAsIEntityControlConfig(ByteBuffer _bb)
		{
			return IEntityControlConfig.GetRootAsIEntityControlConfig(_bb, default(IEntityControlConfig));
		}

		// Token: 0x06030463 RID: 197731 RVA: 0x0068FA68 File Offset: 0x0068DC68
		public static IEntityControlConfig GetRootAsIEntityControlConfig(ByteBuffer _bb, IEntityControlConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030464 RID: 197732 RVA: 0x0068FA85 File Offset: 0x0068DC85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030465 RID: 197733 RVA: 0x0068FA94 File Offset: 0x0068DC94
		public IEntityControlConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD45 RID: 52549
		// (get) Token: 0x06030466 RID: 197734 RVA: 0x0068FAA4 File Offset: 0x0068DCA4
		public bool IsControlPlayer
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CD46 RID: 52550
		// (get) Token: 0x06030467 RID: 197735 RVA: 0x0068FAE4 File Offset: 0x0068DCE4
		public bool HideSkipButton
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CD47 RID: 52551
		// (get) Token: 0x06030468 RID: 197736 RVA: 0x0068FB24 File Offset: 0x0068DD24
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

		// Token: 0x1700CD48 RID: 52552
		// (get) Token: 0x06030469 RID: 197737 RVA: 0x0068FB60 File Offset: 0x0068DD60
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

		// Token: 0x0603046A RID: 197738 RVA: 0x0068FB9D File Offset: 0x0068DD9D
		public static Offset<IEntityControlConfig> CreateIEntityControlConfig(FlatBufferBuilder builder, bool IsControlPlayer = false, bool HideSkipButton = false, EEntityControlCameraMode CameraMode = EEntityControlCameraMode.UseSequenceCamera, byte NullMask = 0)
		{
			builder.StartTable(4);
			IEntityControlConfig.AddNullMask(builder, NullMask);
			IEntityControlConfig.AddCameraMode(builder, CameraMode);
			IEntityControlConfig.AddHideSkipButton(builder, HideSkipButton);
			IEntityControlConfig.AddIsControlPlayer(builder, IsControlPlayer);
			return IEntityControlConfig.EndIEntityControlConfig(builder);
		}

		// Token: 0x0603046B RID: 197739 RVA: 0x0068FBC9 File Offset: 0x0068DDC9
		public static void StartIEntityControlConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0603046C RID: 197740 RVA: 0x0068FBD2 File Offset: 0x0068DDD2
		public static void AddIsControlPlayer(FlatBufferBuilder builder, bool isControlPlayer)
		{
			builder.AddBool(0, isControlPlayer, false);
		}

		// Token: 0x0603046D RID: 197741 RVA: 0x0068FBDD File Offset: 0x0068DDDD
		public static void AddHideSkipButton(FlatBufferBuilder builder, bool hideSkipButton)
		{
			builder.AddBool(1, hideSkipButton, false);
		}

		// Token: 0x0603046E RID: 197742 RVA: 0x0068FBE8 File Offset: 0x0068DDE8
		public static void AddCameraMode(FlatBufferBuilder builder, EEntityControlCameraMode cameraMode)
		{
			builder.AddByte(2, (byte)cameraMode, 0);
		}

		// Token: 0x0603046F RID: 197743 RVA: 0x0068FBF3 File Offset: 0x0068DDF3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06030470 RID: 197744 RVA: 0x0068FBFE File Offset: 0x0068DDFE
		public static Offset<IEntityControlConfig> EndIEntityControlConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEntityControlConfig>(builder.EndTable());
		}

		// Token: 0x06030471 RID: 197745 RVA: 0x0068FC0C File Offset: 0x0068DE0C
		public IEntityControlConfigT UnPack()
		{
			IEntityControlConfigT entityControlConfigT = new IEntityControlConfigT();
			this.UnPackTo(entityControlConfigT);
			return entityControlConfigT;
		}

		// Token: 0x06030472 RID: 197746 RVA: 0x0068FC27 File Offset: 0x0068DE27
		public void UnPackTo(IEntityControlConfigT _o)
		{
			_o.IsControlPlayer = this.IsControlPlayer;
			_o.HideSkipButton = this.HideSkipButton;
			_o.CameraMode = this.CameraMode;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06030473 RID: 197747 RVA: 0x0068FC5C File Offset: 0x0068DE5C
		public static Offset<IEntityControlConfig> Pack(FlatBufferBuilder builder, IEntityControlConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityControlConfig>);
			}
			return IEntityControlConfig.CreateIEntityControlConfig(builder, _o.IsControlPlayer, _o.HideSkipButton, _o.CameraMode, _o.NullMask);
		}

		// Token: 0x04011BC6 RID: 72646
		private Table __p;
	}
}
