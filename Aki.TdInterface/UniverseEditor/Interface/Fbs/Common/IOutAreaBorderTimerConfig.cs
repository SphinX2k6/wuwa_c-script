using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E1E RID: 24094
	public struct IOutAreaBorderTimerConfig : IFlatbufferObject
	{
		// Token: 0x1700B43F RID: 46143
		// (get) Token: 0x060293FC RID: 168956 RVA: 0x005A867E File Offset: 0x005A687E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060293FD RID: 168957 RVA: 0x005A868B File Offset: 0x005A688B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060293FE RID: 168958 RVA: 0x005A8694 File Offset: 0x005A6894
		public static IOutAreaBorderTimerConfig GetRootAsIOutAreaBorderTimerConfig(ByteBuffer _bb)
		{
			return IOutAreaBorderTimerConfig.GetRootAsIOutAreaBorderTimerConfig(_bb, default(IOutAreaBorderTimerConfig));
		}

		// Token: 0x060293FF RID: 168959 RVA: 0x005A86B0 File Offset: 0x005A68B0
		public static IOutAreaBorderTimerConfig GetRootAsIOutAreaBorderTimerConfig(ByteBuffer _bb, IOutAreaBorderTimerConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029400 RID: 168960 RVA: 0x005A86CD File Offset: 0x005A68CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029401 RID: 168961 RVA: 0x005A86DC File Offset: 0x005A68DC
		public IOutAreaBorderTimerConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B440 RID: 46144
		// (get) Token: 0x06029402 RID: 168962 RVA: 0x005A86EC File Offset: 0x005A68EC
		public EOutAreaBorderType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EOutAreaBorderType.TeleportTimer;
				}
				return (EOutAreaBorderType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B441 RID: 46145
		// (get) Token: 0x06029403 RID: 168963 RVA: 0x005A8728 File Offset: 0x005A6928
		public float OutAreaBorderTime
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B442 RID: 46146
		// (get) Token: 0x06029404 RID: 168964 RVA: 0x005A8768 File Offset: 0x005A6968
		public int TeleportTransitionConfigId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B443 RID: 46147
		// (get) Token: 0x06029405 RID: 168965 RVA: 0x005A87A4 File Offset: 0x005A69A4
		public IOutAreaBorderDownTimeTextTip? OutAreaBorderTipOption
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IOutAreaBorderDownTimeTextTip?(default(IOutAreaBorderDownTimeTextTip).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B444 RID: 46148
		// (get) Token: 0x06029406 RID: 168966 RVA: 0x005A8804 File Offset: 0x005A6A04
		public IOutAreaBorderBuffEffect? OutAreaBorderEffectOption
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IOutAreaBorderBuffEffect?(default(IOutAreaBorderBuffEffect).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06029407 RID: 168967 RVA: 0x005A8862 File Offset: 0x005A6A62
		public static Offset<IOutAreaBorderTimerConfig> CreateIOutAreaBorderTimerConfig(FlatBufferBuilder builder, EOutAreaBorderType Type = EOutAreaBorderType.TeleportTimer, float OutAreaBorderTime = 0f, int TeleportTransitionConfigId = 0, Offset<IOutAreaBorderDownTimeTextTip> OutAreaBorderTipOptionOffset = default(Offset<IOutAreaBorderDownTimeTextTip>), Offset<IOutAreaBorderBuffEffect> OutAreaBorderEffectOptionOffset = default(Offset<IOutAreaBorderBuffEffect>))
		{
			builder.StartTable(5);
			IOutAreaBorderTimerConfig.AddOutAreaBorderEffectOption(builder, OutAreaBorderEffectOptionOffset);
			IOutAreaBorderTimerConfig.AddOutAreaBorderTipOption(builder, OutAreaBorderTipOptionOffset);
			IOutAreaBorderTimerConfig.AddTeleportTransitionConfigId(builder, TeleportTransitionConfigId);
			IOutAreaBorderTimerConfig.AddOutAreaBorderTime(builder, OutAreaBorderTime);
			IOutAreaBorderTimerConfig.AddType(builder, Type);
			return IOutAreaBorderTimerConfig.EndIOutAreaBorderTimerConfig(builder);
		}

		// Token: 0x06029408 RID: 168968 RVA: 0x005A8896 File Offset: 0x005A6A96
		public static void StartIOutAreaBorderTimerConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06029409 RID: 168969 RVA: 0x005A889F File Offset: 0x005A6A9F
		public static void AddType(FlatBufferBuilder builder, EOutAreaBorderType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602940A RID: 168970 RVA: 0x005A88AA File Offset: 0x005A6AAA
		public static void AddOutAreaBorderTime(FlatBufferBuilder builder, float outAreaBorderTime)
		{
			builder.AddFloat(1, outAreaBorderTime, 0.0);
		}

		// Token: 0x0602940B RID: 168971 RVA: 0x005A88BD File Offset: 0x005A6ABD
		public static void AddTeleportTransitionConfigId(FlatBufferBuilder builder, int teleportTransitionConfigId)
		{
			builder.AddInt(2, teleportTransitionConfigId, 0);
		}

		// Token: 0x0602940C RID: 168972 RVA: 0x005A88C8 File Offset: 0x005A6AC8
		public static void AddOutAreaBorderTipOption(FlatBufferBuilder builder, Offset<IOutAreaBorderDownTimeTextTip> outAreaBorderTipOptionOffset)
		{
			builder.AddOffset(3, outAreaBorderTipOptionOffset.Value, 0);
		}

		// Token: 0x0602940D RID: 168973 RVA: 0x005A88D8 File Offset: 0x005A6AD8
		public static void AddOutAreaBorderEffectOption(FlatBufferBuilder builder, Offset<IOutAreaBorderBuffEffect> outAreaBorderEffectOptionOffset)
		{
			builder.AddOffset(4, outAreaBorderEffectOptionOffset.Value, 0);
		}

		// Token: 0x0602940E RID: 168974 RVA: 0x005A88E8 File Offset: 0x005A6AE8
		public static Offset<IOutAreaBorderTimerConfig> EndIOutAreaBorderTimerConfig(FlatBufferBuilder builder)
		{
			return new Offset<IOutAreaBorderTimerConfig>(builder.EndTable());
		}

		// Token: 0x0602940F RID: 168975 RVA: 0x005A88F8 File Offset: 0x005A6AF8
		public IOutAreaBorderTimerConfigT UnPack()
		{
			IOutAreaBorderTimerConfigT outAreaBorderTimerConfigT = new IOutAreaBorderTimerConfigT();
			this.UnPackTo(outAreaBorderTimerConfigT);
			return outAreaBorderTimerConfigT;
		}

		// Token: 0x06029410 RID: 168976 RVA: 0x005A8914 File Offset: 0x005A6B14
		public void UnPackTo(IOutAreaBorderTimerConfigT _o)
		{
			_o.Type = this.Type;
			_o.OutAreaBorderTime = this.OutAreaBorderTime;
			_o.TeleportTransitionConfigId = this.TeleportTransitionConfigId;
			_o.OutAreaBorderTipOption = ((this.OutAreaBorderTipOption != null) ? this.OutAreaBorderTipOption.Value.UnPack() : null);
			_o.OutAreaBorderEffectOption = ((this.OutAreaBorderEffectOption != null) ? this.OutAreaBorderEffectOption.Value.UnPack() : null);
		}

		// Token: 0x06029411 RID: 168977 RVA: 0x005A89A4 File Offset: 0x005A6BA4
		public static Offset<IOutAreaBorderTimerConfig> Pack(FlatBufferBuilder builder, IOutAreaBorderTimerConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOutAreaBorderTimerConfig>);
			}
			Offset<IOutAreaBorderDownTimeTextTip> outAreaBorderTipOptionOffset = (_o.OutAreaBorderTipOption == null) ? default(Offset<IOutAreaBorderDownTimeTextTip>) : IOutAreaBorderDownTimeTextTip.Pack(builder, _o.OutAreaBorderTipOption);
			Offset<IOutAreaBorderBuffEffect> outAreaBorderEffectOptionOffset = (_o.OutAreaBorderEffectOption == null) ? default(Offset<IOutAreaBorderBuffEffect>) : IOutAreaBorderBuffEffect.Pack(builder, _o.OutAreaBorderEffectOption);
			return IOutAreaBorderTimerConfig.CreateIOutAreaBorderTimerConfig(builder, _o.Type, _o.OutAreaBorderTime, _o.TeleportTransitionConfigId, outAreaBorderTipOptionOffset, outAreaBorderEffectOptionOffset);
		}

		// Token: 0x0400F815 RID: 63509
		private Table __p;
	}
}
