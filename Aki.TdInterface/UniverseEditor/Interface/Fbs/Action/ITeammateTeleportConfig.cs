using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B4B RID: 31563
	public struct ITeammateTeleportConfig : IFlatbufferObject
	{
		// Token: 0x1700EC5F RID: 60511
		// (get) Token: 0x06038D79 RID: 232825 RVA: 0x007AF945 File Offset: 0x007ADB45
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038D7A RID: 232826 RVA: 0x007AF952 File Offset: 0x007ADB52
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038D7B RID: 232827 RVA: 0x007AF95C File Offset: 0x007ADB5C
		public static ITeammateTeleportConfig GetRootAsITeammateTeleportConfig(ByteBuffer _bb)
		{
			return ITeammateTeleportConfig.GetRootAsITeammateTeleportConfig(_bb, default(ITeammateTeleportConfig));
		}

		// Token: 0x06038D7C RID: 232828 RVA: 0x007AF978 File Offset: 0x007ADB78
		public static ITeammateTeleportConfig GetRootAsITeammateTeleportConfig(ByteBuffer _bb, ITeammateTeleportConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038D7D RID: 232829 RVA: 0x007AF995 File Offset: 0x007ADB95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038D7E RID: 232830 RVA: 0x007AF9A4 File Offset: 0x007ADBA4
		public ITeammateTeleportConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EC60 RID: 60512
		// (get) Token: 0x06038D7F RID: 232831 RVA: 0x007AF9B4 File Offset: 0x007ADBB4
		public ETeammateTeleportType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeammateTeleportType.TelePortAfterTimeOut;
				}
				return (ETeammateTeleportType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06038D80 RID: 232832 RVA: 0x007AF9F0 File Offset: 0x007ADBF0
		public static Offset<ITeammateTeleportConfig> CreateITeammateTeleportConfig(FlatBufferBuilder builder, ETeammateTeleportType Type = ETeammateTeleportType.TelePortAfterTimeOut)
		{
			builder.StartTable(1);
			ITeammateTeleportConfig.AddType(builder, Type);
			return ITeammateTeleportConfig.EndITeammateTeleportConfig(builder);
		}

		// Token: 0x06038D81 RID: 232833 RVA: 0x007AFA06 File Offset: 0x007ADC06
		public static void StartITeammateTeleportConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06038D82 RID: 232834 RVA: 0x007AFA0F File Offset: 0x007ADC0F
		public static void AddType(FlatBufferBuilder builder, ETeammateTeleportType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038D83 RID: 232835 RVA: 0x007AFA1A File Offset: 0x007ADC1A
		public static Offset<ITeammateTeleportConfig> EndITeammateTeleportConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITeammateTeleportConfig>(builder.EndTable());
		}

		// Token: 0x06038D84 RID: 232836 RVA: 0x007AFA28 File Offset: 0x007ADC28
		public ITeammateTeleportConfigT UnPack()
		{
			ITeammateTeleportConfigT teammateTeleportConfigT = new ITeammateTeleportConfigT();
			this.UnPackTo(teammateTeleportConfigT);
			return teammateTeleportConfigT;
		}

		// Token: 0x06038D85 RID: 232837 RVA: 0x007AFA43 File Offset: 0x007ADC43
		public void UnPackTo(ITeammateTeleportConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06038D86 RID: 232838 RVA: 0x007AFA54 File Offset: 0x007ADC54
		public static Offset<ITeammateTeleportConfig> Pack(FlatBufferBuilder builder, ITeammateTeleportConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeammateTeleportConfig>);
			}
			return ITeammateTeleportConfig.CreateITeammateTeleportConfig(builder, _o.Type);
		}

		// Token: 0x04013186 RID: 78214
		private Table __p;
	}
}
