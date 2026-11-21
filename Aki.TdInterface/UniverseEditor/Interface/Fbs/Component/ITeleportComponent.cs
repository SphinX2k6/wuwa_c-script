using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006059 RID: 24665
	public struct ITeleportComponent : IFlatbufferObject
	{
		// Token: 0x1700B716 RID: 46870
		// (get) Token: 0x06029A5C RID: 170588 RVA: 0x005AF870 File Offset: 0x005ADA70
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029A5D RID: 170589 RVA: 0x005AF87D File Offset: 0x005ADA7D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029A5E RID: 170590 RVA: 0x005AF884 File Offset: 0x005ADA84
		public static ITeleportComponent GetRootAsITeleportComponent(ByteBuffer _bb)
		{
			return ITeleportComponent.GetRootAsITeleportComponent(_bb, default(ITeleportComponent));
		}

		// Token: 0x06029A5F RID: 170591 RVA: 0x005AF8A0 File Offset: 0x005ADAA0
		public static ITeleportComponent GetRootAsITeleportComponent(ByteBuffer _bb, ITeleportComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029A60 RID: 170592 RVA: 0x005AF8BD File Offset: 0x005ADABD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029A61 RID: 170593 RVA: 0x005AF8CC File Offset: 0x005ADACC
		public ITeleportComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B717 RID: 46871
		// (get) Token: 0x06029A62 RID: 170594 RVA: 0x005AF8DC File Offset: 0x005ADADC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B718 RID: 46872
		// (get) Token: 0x06029A63 RID: 170595 RVA: 0x005AF91C File Offset: 0x005ADB1C
		public int TeleporterId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B719 RID: 46873
		// (get) Token: 0x06029A64 RID: 170596 RVA: 0x005AF958 File Offset: 0x005ADB58
		public IPosA? TeleportPos
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IPosA?(default(IPosA).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B71A RID: 46874
		// (get) Token: 0x06029A65 RID: 170597 RVA: 0x005AF9B8 File Offset: 0x005ADBB8
		public IGravityFlipTeleportConfig? GravityConfig
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IGravityFlipTeleportConfig?(default(IGravityFlipTeleportConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B71B RID: 46875
		// (get) Token: 0x06029A66 RID: 170598 RVA: 0x005AFA18 File Offset: 0x005ADC18
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029A67 RID: 170599 RVA: 0x005AFA55 File Offset: 0x005ADC55
		public static Offset<ITeleportComponent> CreateITeleportComponent(FlatBufferBuilder builder, bool Disabled = false, int TeleporterId = 0, Offset<IPosA> TeleportPosOffset = default(Offset<IPosA>), Offset<IGravityFlipTeleportConfig> GravityConfigOffset = default(Offset<IGravityFlipTeleportConfig>), byte NullMask = 0)
		{
			builder.StartTable(5);
			ITeleportComponent.AddGravityConfig(builder, GravityConfigOffset);
			ITeleportComponent.AddTeleportPos(builder, TeleportPosOffset);
			ITeleportComponent.AddTeleporterId(builder, TeleporterId);
			ITeleportComponent.AddNullMask(builder, NullMask);
			ITeleportComponent.AddDisabled(builder, Disabled);
			return ITeleportComponent.EndITeleportComponent(builder);
		}

		// Token: 0x06029A68 RID: 170600 RVA: 0x005AFA89 File Offset: 0x005ADC89
		public static void StartITeleportComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06029A69 RID: 170601 RVA: 0x005AFA92 File Offset: 0x005ADC92
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06029A6A RID: 170602 RVA: 0x005AFA9D File Offset: 0x005ADC9D
		public static void AddTeleporterId(FlatBufferBuilder builder, int teleporterId)
		{
			builder.AddInt(1, teleporterId, 0);
		}

		// Token: 0x06029A6B RID: 170603 RVA: 0x005AFAA8 File Offset: 0x005ADCA8
		public static void AddTeleportPos(FlatBufferBuilder builder, Offset<IPosA> teleportPosOffset)
		{
			builder.AddOffset(2, teleportPosOffset.Value, 0);
		}

		// Token: 0x06029A6C RID: 170604 RVA: 0x005AFAB8 File Offset: 0x005ADCB8
		public static void AddGravityConfig(FlatBufferBuilder builder, Offset<IGravityFlipTeleportConfig> gravityConfigOffset)
		{
			builder.AddOffset(3, gravityConfigOffset.Value, 0);
		}

		// Token: 0x06029A6D RID: 170605 RVA: 0x005AFAC8 File Offset: 0x005ADCC8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06029A6E RID: 170606 RVA: 0x005AFAD3 File Offset: 0x005ADCD3
		public static Offset<ITeleportComponent> EndITeleportComponent(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportComponent>(builder.EndTable());
		}

		// Token: 0x06029A6F RID: 170607 RVA: 0x005AFAE0 File Offset: 0x005ADCE0
		public ITeleportComponentT UnPack()
		{
			ITeleportComponentT teleportComponentT = new ITeleportComponentT();
			this.UnPackTo(teleportComponentT);
			return teleportComponentT;
		}

		// Token: 0x06029A70 RID: 170608 RVA: 0x005AFAFC File Offset: 0x005ADCFC
		public void UnPackTo(ITeleportComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.TeleporterId = this.TeleporterId;
			_o.TeleportPos = ((this.TeleportPos != null) ? this.TeleportPos.Value.UnPack() : null);
			_o.GravityConfig = ((this.GravityConfig != null) ? this.GravityConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06029A71 RID: 170609 RVA: 0x005AFB8C File Offset: 0x005ADD8C
		public static Offset<ITeleportComponent> Pack(FlatBufferBuilder builder, ITeleportComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportComponent>);
			}
			Offset<IPosA> teleportPosOffset = (_o.TeleportPos == null) ? default(Offset<IPosA>) : IPosA.Pack(builder, _o.TeleportPos);
			Offset<IGravityFlipTeleportConfig> gravityConfigOffset = (_o.GravityConfig == null) ? default(Offset<IGravityFlipTeleportConfig>) : IGravityFlipTeleportConfig.Pack(builder, _o.GravityConfig);
			return ITeleportComponent.CreateITeleportComponent(builder, _o.Disabled, _o.TeleporterId, teleportPosOffset, gravityConfigOffset, _o.NullMask);
		}

		// Token: 0x0400FDC6 RID: 64966
		private Table __p;
	}
}
