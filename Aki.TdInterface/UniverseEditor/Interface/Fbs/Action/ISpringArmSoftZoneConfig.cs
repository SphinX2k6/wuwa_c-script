using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200797A RID: 31098
	public struct ISpringArmSoftZoneConfig : IFlatbufferObject
	{
		// Token: 0x1700E406 RID: 58374
		// (get) Token: 0x06036C4A RID: 224330 RVA: 0x007536F4 File Offset: 0x007518F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036C4B RID: 224331 RVA: 0x00753701 File Offset: 0x00751901
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036C4C RID: 224332 RVA: 0x00753708 File Offset: 0x00751908
		public static ISpringArmSoftZoneConfig GetRootAsISpringArmSoftZoneConfig(ByteBuffer _bb)
		{
			return ISpringArmSoftZoneConfig.GetRootAsISpringArmSoftZoneConfig(_bb, default(ISpringArmSoftZoneConfig));
		}

		// Token: 0x06036C4D RID: 224333 RVA: 0x00753724 File Offset: 0x00751924
		public static ISpringArmSoftZoneConfig GetRootAsISpringArmSoftZoneConfig(ByteBuffer _bb, ISpringArmSoftZoneConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036C4E RID: 224334 RVA: 0x00753741 File Offset: 0x00751941
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036C4F RID: 224335 RVA: 0x00753750 File Offset: 0x00751950
		public ISpringArmSoftZoneConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E407 RID: 58375
		// (get) Token: 0x06036C50 RID: 224336 RVA: 0x00753760 File Offset: 0x00751960
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

		// Token: 0x1700E408 RID: 58376
		// (get) Token: 0x06036C51 RID: 224337 RVA: 0x007537C0 File Offset: 0x007519C0
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

		// Token: 0x1700E409 RID: 58377
		// (get) Token: 0x06036C52 RID: 224338 RVA: 0x00753820 File Offset: 0x00751A20
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

		// Token: 0x06036C53 RID: 224339 RVA: 0x0075387D File Offset: 0x00751A7D
		public static Offset<ISpringArmSoftZoneConfig> CreateISpringArmSoftZoneConfig(FlatBufferBuilder builder, Offset<ISingleAxisSpringArmSoftZoneConfig> LeftRightConfigOffset = default(Offset<ISingleAxisSpringArmSoftZoneConfig>), Offset<ISingleAxisSpringArmSoftZoneConfig> ForwardBackConfigOffset = default(Offset<ISingleAxisSpringArmSoftZoneConfig>), Offset<ISingleAxisSpringArmSoftZoneConfig> UpDownConfigOffset = default(Offset<ISingleAxisSpringArmSoftZoneConfig>))
		{
			builder.StartTable(3);
			ISpringArmSoftZoneConfig.AddUpDownConfig(builder, UpDownConfigOffset);
			ISpringArmSoftZoneConfig.AddForwardBackConfig(builder, ForwardBackConfigOffset);
			ISpringArmSoftZoneConfig.AddLeftRightConfig(builder, LeftRightConfigOffset);
			return ISpringArmSoftZoneConfig.EndISpringArmSoftZoneConfig(builder);
		}

		// Token: 0x06036C54 RID: 224340 RVA: 0x007538A1 File Offset: 0x00751AA1
		public static void StartISpringArmSoftZoneConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06036C55 RID: 224341 RVA: 0x007538AA File Offset: 0x00751AAA
		public static void AddLeftRightConfig(FlatBufferBuilder builder, Offset<ISingleAxisSpringArmSoftZoneConfig> leftRightConfigOffset)
		{
			builder.AddOffset(0, leftRightConfigOffset.Value, 0);
		}

		// Token: 0x06036C56 RID: 224342 RVA: 0x007538BA File Offset: 0x00751ABA
		public static void AddForwardBackConfig(FlatBufferBuilder builder, Offset<ISingleAxisSpringArmSoftZoneConfig> forwardBackConfigOffset)
		{
			builder.AddOffset(1, forwardBackConfigOffset.Value, 0);
		}

		// Token: 0x06036C57 RID: 224343 RVA: 0x007538CA File Offset: 0x00751ACA
		public static void AddUpDownConfig(FlatBufferBuilder builder, Offset<ISingleAxisSpringArmSoftZoneConfig> upDownConfigOffset)
		{
			builder.AddOffset(2, upDownConfigOffset.Value, 0);
		}

		// Token: 0x06036C58 RID: 224344 RVA: 0x007538DA File Offset: 0x00751ADA
		public static Offset<ISpringArmSoftZoneConfig> EndISpringArmSoftZoneConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISpringArmSoftZoneConfig>(builder.EndTable());
		}

		// Token: 0x06036C59 RID: 224345 RVA: 0x007538E8 File Offset: 0x00751AE8
		public ISpringArmSoftZoneConfigT UnPack()
		{
			ISpringArmSoftZoneConfigT springArmSoftZoneConfigT = new ISpringArmSoftZoneConfigT();
			this.UnPackTo(springArmSoftZoneConfigT);
			return springArmSoftZoneConfigT;
		}

		// Token: 0x06036C5A RID: 224346 RVA: 0x00753904 File Offset: 0x00751B04
		public void UnPackTo(ISpringArmSoftZoneConfigT _o)
		{
			_o.LeftRightConfig = ((this.LeftRightConfig != null) ? this.LeftRightConfig.Value.UnPack() : null);
			_o.ForwardBackConfig = ((this.ForwardBackConfig != null) ? this.ForwardBackConfig.Value.UnPack() : null);
			_o.UpDownConfig = ((this.UpDownConfig != null) ? this.UpDownConfig.Value.UnPack() : null);
		}

		// Token: 0x06036C5B RID: 224347 RVA: 0x007539A0 File Offset: 0x00751BA0
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

		// Token: 0x04012C6E RID: 76910
		private Table __p;
	}
}
