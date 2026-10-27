using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071A5 RID: 29093
	public struct ISpringArmSoftZoneConfig : IFlatbufferObject
	{
		// Token: 0x1700D80F RID: 55311
		// (get) Token: 0x0603394C RID: 211276 RVA: 0x006F2428 File Offset: 0x006F0628
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603394D RID: 211277 RVA: 0x006F2435 File Offset: 0x006F0635
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603394E RID: 211278 RVA: 0x006F243C File Offset: 0x006F063C
		public static ISpringArmSoftZoneConfig GetRootAsISpringArmSoftZoneConfig(ByteBuffer _bb)
		{
			return ISpringArmSoftZoneConfig.GetRootAsISpringArmSoftZoneConfig(_bb, default(ISpringArmSoftZoneConfig));
		}

		// Token: 0x0603394F RID: 211279 RVA: 0x006F2458 File Offset: 0x006F0658
		public static ISpringArmSoftZoneConfig GetRootAsISpringArmSoftZoneConfig(ByteBuffer _bb, ISpringArmSoftZoneConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033950 RID: 211280 RVA: 0x006F2475 File Offset: 0x006F0675
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033951 RID: 211281 RVA: 0x006F2484 File Offset: 0x006F0684
		public ISpringArmSoftZoneConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D810 RID: 55312
		// (get) Token: 0x06033952 RID: 211282 RVA: 0x006F2494 File Offset: 0x006F0694
		public ISingleAxisSpringArmSoftZoneConfig? LeftRightConfig
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new ISingleAxisSpringArmSoftZoneConfig?(default(ISingleAxisSpringArmSoftZoneConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D811 RID: 55313
		// (get) Token: 0x06033953 RID: 211283 RVA: 0x006F24F4 File Offset: 0x006F06F4
		public ISingleAxisSpringArmSoftZoneConfig? ForwardBackConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ISingleAxisSpringArmSoftZoneConfig?(default(ISingleAxisSpringArmSoftZoneConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D812 RID: 55314
		// (get) Token: 0x06033954 RID: 211284 RVA: 0x006F2554 File Offset: 0x006F0754
		public ISingleAxisSpringArmSoftZoneConfig? UpDownConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ISingleAxisSpringArmSoftZoneConfig?(default(ISingleAxisSpringArmSoftZoneConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06033955 RID: 211285 RVA: 0x006F25B1 File Offset: 0x006F07B1
		public static Offset<ISpringArmSoftZoneConfig> CreateISpringArmSoftZoneConfig(FlatBufferBuilder builder, Offset<ISingleAxisSpringArmSoftZoneConfig> LeftRightConfigOffset = default(Offset<ISingleAxisSpringArmSoftZoneConfig>), Offset<ISingleAxisSpringArmSoftZoneConfig> ForwardBackConfigOffset = default(Offset<ISingleAxisSpringArmSoftZoneConfig>), Offset<ISingleAxisSpringArmSoftZoneConfig> UpDownConfigOffset = default(Offset<ISingleAxisSpringArmSoftZoneConfig>))
		{
			builder.StartTable(3);
			ISpringArmSoftZoneConfig.AddUpDownConfig(builder, UpDownConfigOffset);
			ISpringArmSoftZoneConfig.AddForwardBackConfig(builder, ForwardBackConfigOffset);
			ISpringArmSoftZoneConfig.AddLeftRightConfig(builder, LeftRightConfigOffset);
			return ISpringArmSoftZoneConfig.EndISpringArmSoftZoneConfig(builder);
		}

		// Token: 0x06033956 RID: 211286 RVA: 0x006F25D5 File Offset: 0x006F07D5
		public static void StartISpringArmSoftZoneConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06033957 RID: 211287 RVA: 0x006F25DE File Offset: 0x006F07DE
		public static void AddLeftRightConfig(FlatBufferBuilder builder, Offset<ISingleAxisSpringArmSoftZoneConfig> leftRightConfigOffset)
		{
			builder.AddOffset(0, leftRightConfigOffset.Value, 0);
		}

		// Token: 0x06033958 RID: 211288 RVA: 0x006F25EE File Offset: 0x006F07EE
		public static void AddForwardBackConfig(FlatBufferBuilder builder, Offset<ISingleAxisSpringArmSoftZoneConfig> forwardBackConfigOffset)
		{
			builder.AddOffset(1, forwardBackConfigOffset.Value, 0);
		}

		// Token: 0x06033959 RID: 211289 RVA: 0x006F25FE File Offset: 0x006F07FE
		public static void AddUpDownConfig(FlatBufferBuilder builder, Offset<ISingleAxisSpringArmSoftZoneConfig> upDownConfigOffset)
		{
			builder.AddOffset(2, upDownConfigOffset.Value, 0);
		}

		// Token: 0x0603395A RID: 211290 RVA: 0x006F260E File Offset: 0x006F080E
		public static Offset<ISpringArmSoftZoneConfig> EndISpringArmSoftZoneConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISpringArmSoftZoneConfig>(builder.EndTable());
		}

		// Token: 0x0603395B RID: 211291 RVA: 0x006F261C File Offset: 0x006F081C
		public ISpringArmSoftZoneConfigT UnPack()
		{
			ISpringArmSoftZoneConfigT springArmSoftZoneConfigT = new ISpringArmSoftZoneConfigT();
			this.UnPackTo(springArmSoftZoneConfigT);
			return springArmSoftZoneConfigT;
		}

		// Token: 0x0603395C RID: 211292 RVA: 0x006F2638 File Offset: 0x006F0838
		public void UnPackTo(ISpringArmSoftZoneConfigT _o)
		{
			_o.LeftRightConfig = ((this.LeftRightConfig != null) ? this.LeftRightConfig.Value.UnPack() : null);
			_o.ForwardBackConfig = ((this.ForwardBackConfig != null) ? this.ForwardBackConfig.Value.UnPack() : null);
			_o.UpDownConfig = ((this.UpDownConfig != null) ? this.UpDownConfig.Value.UnPack() : null);
		}

		// Token: 0x0603395D RID: 211293 RVA: 0x006F26D4 File Offset: 0x006F08D4
		public static Offset<ISpringArmSoftZoneConfig> Pack(FlatBufferBuilder builder, ISpringArmSoftZoneConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpringArmSoftZoneConfig>);
			}
			Offset<ISingleAxisSpringArmSoftZoneConfig> leftRightConfigOffset = (_o.LeftRightConfig == null) ? default(Offset<ISingleAxisSpringArmSoftZoneConfig>) : ISingleAxisSpringArmSoftZoneConfig.Pack(builder, _o.LeftRightConfig);
			Offset<ISingleAxisSpringArmSoftZoneConfig> forwardBackConfigOffset = (_o.ForwardBackConfig == null) ? default(Offset<ISingleAxisSpringArmSoftZoneConfig>) : ISingleAxisSpringArmSoftZoneConfig.Pack(builder, _o.ForwardBackConfig);
			Offset<ISingleAxisSpringArmSoftZoneConfig> upDownConfigOffset = (_o.UpDownConfig == null) ? default(Offset<ISingleAxisSpringArmSoftZoneConfig>) : ISingleAxisSpringArmSoftZoneConfig.Pack(builder, _o.UpDownConfig);
			return ISpringArmSoftZoneConfig.CreateISpringArmSoftZoneConfig(builder, leftRightConfigOffset, forwardBackConfigOffset, upDownConfigOffset);
		}

		// Token: 0x04011C6D RID: 72813
		private Table __p;
	}
}
