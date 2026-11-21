using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200560D RID: 22029
	public struct IDollGrabShowcaseDollCameraConfig : IFlatbufferObject
	{
		// Token: 0x17009DFC RID: 40444
		// (get) Token: 0x06023207 RID: 143879 RVA: 0x004D5D28 File Offset: 0x004D3F28
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023208 RID: 143880 RVA: 0x004D5D35 File Offset: 0x004D3F35
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023209 RID: 143881 RVA: 0x004D5D3C File Offset: 0x004D3F3C
		public static IDollGrabShowcaseDollCameraConfig GetRootAsIDollGrabShowcaseDollCameraConfig(ByteBuffer _bb)
		{
			return IDollGrabShowcaseDollCameraConfig.GetRootAsIDollGrabShowcaseDollCameraConfig(_bb, default(IDollGrabShowcaseDollCameraConfig));
		}

		// Token: 0x0602320A RID: 143882 RVA: 0x004D5D58 File Offset: 0x004D3F58
		public static IDollGrabShowcaseDollCameraConfig GetRootAsIDollGrabShowcaseDollCameraConfig(ByteBuffer _bb, IDollGrabShowcaseDollCameraConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602320B RID: 143883 RVA: 0x004D5D75 File Offset: 0x004D3F75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602320C RID: 143884 RVA: 0x004D5D84 File Offset: 0x004D3F84
		public IDollGrabShowcaseDollCameraConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009DFD RID: 40445
		// (get) Token: 0x0602320D RID: 143885 RVA: 0x004D5D94 File Offset: 0x004D3F94
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

		// Token: 0x17009DFE RID: 40446
		// (get) Token: 0x0602320E RID: 143886 RVA: 0x004D5DF4 File Offset: 0x004D3FF4
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

		// Token: 0x0602320F RID: 143887 RVA: 0x004D5E51 File Offset: 0x004D4051
		public static Offset<IDollGrabShowcaseDollCameraConfig> CreateIDollGrabShowcaseDollCameraConfig(FlatBufferBuilder builder, Offset<IShowcaseFullViewCameraConfig> FullViewCameraOffset = default(Offset<IShowcaseFullViewCameraConfig>), Offset<IDollComboCamera> DollCameraOffset = default(Offset<IDollComboCamera>))
		{
			builder.StartTable(2);
			IDollGrabShowcaseDollCameraConfig.AddDollCamera(builder, DollCameraOffset);
			IDollGrabShowcaseDollCameraConfig.AddFullViewCamera(builder, FullViewCameraOffset);
			return IDollGrabShowcaseDollCameraConfig.EndIDollGrabShowcaseDollCameraConfig(builder);
		}

		// Token: 0x06023210 RID: 143888 RVA: 0x004D5E6E File Offset: 0x004D406E
		public static void StartIDollGrabShowcaseDollCameraConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06023211 RID: 143889 RVA: 0x004D5E77 File Offset: 0x004D4077
		public static void AddFullViewCamera(FlatBufferBuilder builder, Offset<IShowcaseFullViewCameraConfig> fullViewCameraOffset)
		{
			builder.AddOffset(0, fullViewCameraOffset.Value, 0);
		}

		// Token: 0x06023212 RID: 143890 RVA: 0x004D5E87 File Offset: 0x004D4087
		public static void AddDollCamera(FlatBufferBuilder builder, Offset<IDollComboCamera> dollCameraOffset)
		{
			builder.AddOffset(1, dollCameraOffset.Value, 0);
		}

		// Token: 0x06023213 RID: 143891 RVA: 0x004D5E97 File Offset: 0x004D4097
		public static Offset<IDollGrabShowcaseDollCameraConfig> EndIDollGrabShowcaseDollCameraConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDollGrabShowcaseDollCameraConfig>(builder.EndTable());
		}

		// Token: 0x06023214 RID: 143892 RVA: 0x004D5EA4 File Offset: 0x004D40A4
		public IDollGrabShowcaseDollCameraConfigT UnPack()
		{
			IDollGrabShowcaseDollCameraConfigT dollGrabShowcaseDollCameraConfigT = new IDollGrabShowcaseDollCameraConfigT();
			this.UnPackTo(dollGrabShowcaseDollCameraConfigT);
			return dollGrabShowcaseDollCameraConfigT;
		}

		// Token: 0x06023215 RID: 143893 RVA: 0x004D5EC0 File Offset: 0x004D40C0
		public void UnPackTo(IDollGrabShowcaseDollCameraConfigT _o)
		{
			_o.FullViewCamera = ((this.FullViewCamera != null) ? this.FullViewCamera.Value.UnPack() : null);
			_o.DollCamera = ((this.DollCamera != null) ? this.DollCamera.Value.UnPack() : null);
		}

		// Token: 0x06023216 RID: 143894 RVA: 0x004D5F2C File Offset: 0x004D412C
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

		// Token: 0x0400ECCD RID: 60621
		private Table __p;
	}
}
