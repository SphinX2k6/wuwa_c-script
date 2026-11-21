using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200645B RID: 25691
	public struct IOutAreaBorderTimerConfig : IFlatbufferObject
	{
		// Token: 0x1700BDA5 RID: 48549
		// (get) Token: 0x0602BA86 RID: 178822 RVA: 0x005F13AE File Offset: 0x005EF5AE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BA87 RID: 178823 RVA: 0x005F13BB File Offset: 0x005EF5BB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BA88 RID: 178824 RVA: 0x005F13C4 File Offset: 0x005EF5C4
		public static IOutAreaBorderTimerConfig GetRootAsIOutAreaBorderTimerConfig(ByteBuffer _bb)
		{
			return IOutAreaBorderTimerConfig.GetRootAsIOutAreaBorderTimerConfig(_bb, default(IOutAreaBorderTimerConfig));
		}

		// Token: 0x0602BA89 RID: 178825 RVA: 0x005F13E0 File Offset: 0x005EF5E0
		public static IOutAreaBorderTimerConfig GetRootAsIOutAreaBorderTimerConfig(ByteBuffer _bb, IOutAreaBorderTimerConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BA8A RID: 178826 RVA: 0x005F13FD File Offset: 0x005EF5FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BA8B RID: 178827 RVA: 0x005F140C File Offset: 0x005EF60C
		public IOutAreaBorderTimerConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BDA6 RID: 48550
		// (get) Token: 0x0602BA8C RID: 178828 RVA: 0x005F141C File Offset: 0x005EF61C
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

		// Token: 0x1700BDA7 RID: 48551
		// (get) Token: 0x0602BA8D RID: 178829 RVA: 0x005F1458 File Offset: 0x005EF658
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

		// Token: 0x1700BDA8 RID: 48552
		// (get) Token: 0x0602BA8E RID: 178830 RVA: 0x005F1498 File Offset: 0x005EF698
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

		// Token: 0x1700BDA9 RID: 48553
		// (get) Token: 0x0602BA8F RID: 178831 RVA: 0x005F14D4 File Offset: 0x005EF6D4
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

		// Token: 0x1700BDAA RID: 48554
		// (get) Token: 0x0602BA90 RID: 178832 RVA: 0x005F1534 File Offset: 0x005EF734
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

		// Token: 0x0602BA91 RID: 178833 RVA: 0x005F1592 File Offset: 0x005EF792
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

		// Token: 0x0602BA92 RID: 178834 RVA: 0x005F15C6 File Offset: 0x005EF7C6
		public static void StartIOutAreaBorderTimerConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602BA93 RID: 178835 RVA: 0x005F15CF File Offset: 0x005EF7CF
		public static void AddType(FlatBufferBuilder builder, EOutAreaBorderType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BA94 RID: 178836 RVA: 0x005F15DA File Offset: 0x005EF7DA
		public static void AddOutAreaBorderTime(FlatBufferBuilder builder, float outAreaBorderTime)
		{
			builder.AddFloat(1, outAreaBorderTime, 0.0);
		}

		// Token: 0x0602BA95 RID: 178837 RVA: 0x005F15ED File Offset: 0x005EF7ED
		public static void AddTeleportTransitionConfigId(FlatBufferBuilder builder, int teleportTransitionConfigId)
		{
			builder.AddInt(2, teleportTransitionConfigId, 0);
		}

		// Token: 0x0602BA96 RID: 178838 RVA: 0x005F15F8 File Offset: 0x005EF7F8
		public static void AddOutAreaBorderTipOption(FlatBufferBuilder builder, Offset<IOutAreaBorderDownTimeTextTip> outAreaBorderTipOptionOffset)
		{
			builder.AddOffset(3, outAreaBorderTipOptionOffset.Value, 0);
		}

		// Token: 0x0602BA97 RID: 178839 RVA: 0x005F1608 File Offset: 0x005EF808
		public static void AddOutAreaBorderEffectOption(FlatBufferBuilder builder, Offset<IOutAreaBorderBuffEffect> outAreaBorderEffectOptionOffset)
		{
			builder.AddOffset(4, outAreaBorderEffectOptionOffset.Value, 0);
		}

		// Token: 0x0602BA98 RID: 178840 RVA: 0x005F1618 File Offset: 0x005EF818
		public static Offset<IOutAreaBorderTimerConfig> EndIOutAreaBorderTimerConfig(FlatBufferBuilder builder)
		{
			return new Offset<IOutAreaBorderTimerConfig>(builder.EndTable());
		}

		// Token: 0x0602BA99 RID: 178841 RVA: 0x005F1628 File Offset: 0x005EF828
		public IOutAreaBorderTimerConfigT UnPack()
		{
			IOutAreaBorderTimerConfigT outAreaBorderTimerConfigT = new IOutAreaBorderTimerConfigT();
			this.UnPackTo(outAreaBorderTimerConfigT);
			return outAreaBorderTimerConfigT;
		}

		// Token: 0x0602BA9A RID: 178842 RVA: 0x005F1644 File Offset: 0x005EF844
		public void UnPackTo(IOutAreaBorderTimerConfigT _o)
		{
			_o.Type = this.Type;
			_o.OutAreaBorderTime = this.OutAreaBorderTime;
			_o.TeleportTransitionConfigId = this.TeleportTransitionConfigId;
			_o.OutAreaBorderTipOption = ((this.OutAreaBorderTipOption != null) ? this.OutAreaBorderTipOption.Value.UnPack() : null);
			_o.OutAreaBorderEffectOption = ((this.OutAreaBorderEffectOption != null) ? this.OutAreaBorderEffectOption.Value.UnPack() : null);
		}

		// Token: 0x0602BA9B RID: 178843 RVA: 0x005F16D4 File Offset: 0x005EF8D4
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

		// Token: 0x04010570 RID: 66928
		private Table __p;
	}
}
