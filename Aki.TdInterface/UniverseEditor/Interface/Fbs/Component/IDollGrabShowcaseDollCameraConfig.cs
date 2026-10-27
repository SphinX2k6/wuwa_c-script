using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050A8 RID: 20648
	public struct IDollGrabShowcaseDollCameraConfig : IFlatbufferObject
	{
		// Token: 0x1700960F RID: 38415
		// (get) Token: 0x060212B3 RID: 135859 RVA: 0x0049BD9C File Offset: 0x00499F9C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060212B4 RID: 135860 RVA: 0x0049BDA9 File Offset: 0x00499FA9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060212B5 RID: 135861 RVA: 0x0049BDB0 File Offset: 0x00499FB0
		public static IDollGrabShowcaseDollCameraConfig GetRootAsIDollGrabShowcaseDollCameraConfig(ByteBuffer _bb)
		{
			return IDollGrabShowcaseDollCameraConfig.GetRootAsIDollGrabShowcaseDollCameraConfig(_bb, default(IDollGrabShowcaseDollCameraConfig));
		}

		// Token: 0x060212B6 RID: 135862 RVA: 0x0049BDCC File Offset: 0x00499FCC
		public static IDollGrabShowcaseDollCameraConfig GetRootAsIDollGrabShowcaseDollCameraConfig(ByteBuffer _bb, IDollGrabShowcaseDollCameraConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060212B7 RID: 135863 RVA: 0x0049BDE9 File Offset: 0x00499FE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060212B8 RID: 135864 RVA: 0x0049BDF8 File Offset: 0x00499FF8
		public IDollGrabShowcaseDollCameraConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009610 RID: 38416
		// (get) Token: 0x060212B9 RID: 135865 RVA: 0x0049BE08 File Offset: 0x0049A008
		public IShowcaseFullViewCameraConfig? FullViewCamera
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IShowcaseFullViewCameraConfig?(default(IShowcaseFullViewCameraConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009611 RID: 38417
		// (get) Token: 0x060212BA RID: 135866 RVA: 0x0049BE68 File Offset: 0x0049A068
		public IDollComboCamera? DollCamera
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IDollComboCamera?(default(IDollComboCamera).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060212BB RID: 135867 RVA: 0x0049BEC5 File Offset: 0x0049A0C5
		public static Offset<IDollGrabShowcaseDollCameraConfig> CreateIDollGrabShowcaseDollCameraConfig(FlatBufferBuilder builder, Offset<IShowcaseFullViewCameraConfig> FullViewCameraOffset = default(Offset<IShowcaseFullViewCameraConfig>), Offset<IDollComboCamera> DollCameraOffset = default(Offset<IDollComboCamera>))
		{
			builder.StartTable(2);
			IDollGrabShowcaseDollCameraConfig.AddDollCamera(builder, DollCameraOffset);
			IDollGrabShowcaseDollCameraConfig.AddFullViewCamera(builder, FullViewCameraOffset);
			return IDollGrabShowcaseDollCameraConfig.EndIDollGrabShowcaseDollCameraConfig(builder);
		}

		// Token: 0x060212BC RID: 135868 RVA: 0x0049BEE2 File Offset: 0x0049A0E2
		public static void StartIDollGrabShowcaseDollCameraConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060212BD RID: 135869 RVA: 0x0049BEEB File Offset: 0x0049A0EB
		public static void AddFullViewCamera(FlatBufferBuilder builder, Offset<IShowcaseFullViewCameraConfig> fullViewCameraOffset)
		{
			builder.AddOffset(0, fullViewCameraOffset.Value, 0);
		}

		// Token: 0x060212BE RID: 135870 RVA: 0x0049BEFB File Offset: 0x0049A0FB
		public static void AddDollCamera(FlatBufferBuilder builder, Offset<IDollComboCamera> dollCameraOffset)
		{
			builder.AddOffset(1, dollCameraOffset.Value, 0);
		}

		// Token: 0x060212BF RID: 135871 RVA: 0x0049BF0B File Offset: 0x0049A10B
		public static Offset<IDollGrabShowcaseDollCameraConfig> EndIDollGrabShowcaseDollCameraConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDollGrabShowcaseDollCameraConfig>(builder.EndTable());
		}

		// Token: 0x060212C0 RID: 135872 RVA: 0x0049BF18 File Offset: 0x0049A118
		public IDollGrabShowcaseDollCameraConfigT UnPack()
		{
			IDollGrabShowcaseDollCameraConfigT dollGrabShowcaseDollCameraConfigT = new IDollGrabShowcaseDollCameraConfigT();
			this.UnPackTo(dollGrabShowcaseDollCameraConfigT);
			return dollGrabShowcaseDollCameraConfigT;
		}

		// Token: 0x060212C1 RID: 135873 RVA: 0x0049BF34 File Offset: 0x0049A134
		public void UnPackTo(IDollGrabShowcaseDollCameraConfigT _o)
		{
			_o.FullViewCamera = ((this.FullViewCamera != null) ? this.FullViewCamera.Value.UnPack() : null);
			_o.DollCamera = ((this.DollCamera != null) ? this.DollCamera.Value.UnPack() : null);
		}

		// Token: 0x060212C2 RID: 135874 RVA: 0x0049BFA0 File Offset: 0x0049A1A0
		public static Offset<IDollGrabShowcaseDollCameraConfig> Pack(FlatBufferBuilder builder, IDollGrabShowcaseDollCameraConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDollGrabShowcaseDollCameraConfig>);
			}
			Offset<IShowcaseFullViewCameraConfig> fullViewCameraOffset = (_o.FullViewCamera == null) ? default(Offset<IShowcaseFullViewCameraConfig>) : IShowcaseFullViewCameraConfig.Pack(builder, _o.FullViewCamera);
			Offset<IDollComboCamera> dollCameraOffset = (_o.DollCamera == null) ? default(Offset<IDollComboCamera>) : IDollComboCamera.Pack(builder, _o.DollCamera);
			return IDollGrabShowcaseDollCameraConfig.CreateIDollGrabShowcaseDollCameraConfig(builder, fullViewCameraOffset, dollCameraOffset);
		}

		// Token: 0x0400E0D0 RID: 57552
		private Table __p;
	}
}
