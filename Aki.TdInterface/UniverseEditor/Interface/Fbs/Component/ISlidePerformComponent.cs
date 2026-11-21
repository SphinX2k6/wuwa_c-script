using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F39 RID: 24377
	public struct ISlidePerformComponent : IFlatbufferObject
	{
		// Token: 0x1700B47B RID: 46203
		// (get) Token: 0x06028F3A RID: 167738 RVA: 0x00598560 File Offset: 0x00596760
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028F3B RID: 167739 RVA: 0x0059856D File Offset: 0x0059676D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028F3C RID: 167740 RVA: 0x00598574 File Offset: 0x00596774
		public static ISlidePerformComponent GetRootAsISlidePerformComponent(ByteBuffer _bb)
		{
			return ISlidePerformComponent.GetRootAsISlidePerformComponent(_bb, default(ISlidePerformComponent));
		}

		// Token: 0x06028F3D RID: 167741 RVA: 0x00598590 File Offset: 0x00596790
		public static ISlidePerformComponent GetRootAsISlidePerformComponent(ByteBuffer _bb, ISlidePerformComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028F3E RID: 167742 RVA: 0x005985AD File Offset: 0x005967AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028F3F RID: 167743 RVA: 0x005985BC File Offset: 0x005967BC
		public ISlidePerformComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B47C RID: 46204
		// (get) Token: 0x06028F40 RID: 167744 RVA: 0x005985CC File Offset: 0x005967CC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B47D RID: 46205
		// (get) Token: 0x06028F41 RID: 167745 RVA: 0x0059860C File Offset: 0x0059680C
		public int SlideSpeed
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

		// Token: 0x1700B47E RID: 46206
		// (get) Token: 0x06028F42 RID: 167746 RVA: 0x00598648 File Offset: 0x00596848
		public int UpSpeed
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

		// Token: 0x1700B47F RID: 46207
		// (get) Token: 0x06028F43 RID: 167747 RVA: 0x00598684 File Offset: 0x00596884
		public int DownSpeed
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B480 RID: 46208
		// (get) Token: 0x06028F44 RID: 167748 RVA: 0x005986C4 File Offset: 0x005968C4
		public int RailSplineEntityId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028F45 RID: 167749 RVA: 0x00598704 File Offset: 0x00596904
		public IExchangeSlideRailConfig? ExchangeRailConfigs(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IExchangeSlideRailConfig?(default(IExchangeSlideRailConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B481 RID: 46209
		// (get) Token: 0x06028F46 RID: 167750 RVA: 0x00598768 File Offset: 0x00596968
		public int ExchangeRailConfigsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700B482 RID: 46210
		// (get) Token: 0x06028F47 RID: 167751 RVA: 0x00598794 File Offset: 0x00596994
		public ISlopeSlidePerform? SlidePerformConfig
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new ISlopeSlidePerform?(default(ISlopeSlidePerform).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B483 RID: 46211
		// (get) Token: 0x06028F48 RID: 167752 RVA: 0x005987F4 File Offset: 0x005969F4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028F49 RID: 167753 RVA: 0x00598834 File Offset: 0x00596A34
		public static Offset<ISlidePerformComponent> CreateISlidePerformComponent(FlatBufferBuilder builder, bool Disabled = false, int SlideSpeed = 0, int UpSpeed = 0, int DownSpeed = 0, int RailSplineEntityId = 0, VectorOffset ExchangeRailConfigsOffset = default(VectorOffset), Offset<ISlopeSlidePerform> SlidePerformConfigOffset = default(Offset<ISlopeSlidePerform>), byte NullMask = 0)
		{
			builder.StartTable(8);
			ISlidePerformComponent.AddSlidePerformConfig(builder, SlidePerformConfigOffset);
			ISlidePerformComponent.AddExchangeRailConfigs(builder, ExchangeRailConfigsOffset);
			ISlidePerformComponent.AddRailSplineEntityId(builder, RailSplineEntityId);
			ISlidePerformComponent.AddDownSpeed(builder, DownSpeed);
			ISlidePerformComponent.AddUpSpeed(builder, UpSpeed);
			ISlidePerformComponent.AddSlideSpeed(builder, SlideSpeed);
			ISlidePerformComponent.AddNullMask(builder, NullMask);
			ISlidePerformComponent.AddDisabled(builder, Disabled);
			return ISlidePerformComponent.EndISlidePerformComponent(builder);
		}

		// Token: 0x06028F4A RID: 167754 RVA: 0x0059888B File Offset: 0x00596A8B
		public static void StartISlidePerformComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06028F4B RID: 167755 RVA: 0x00598894 File Offset: 0x00596A94
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06028F4C RID: 167756 RVA: 0x0059889F File Offset: 0x00596A9F
		public static void AddSlideSpeed(FlatBufferBuilder builder, int slideSpeed)
		{
			builder.AddInt(1, slideSpeed, 0);
		}

		// Token: 0x06028F4D RID: 167757 RVA: 0x005988AA File Offset: 0x00596AAA
		public static void AddUpSpeed(FlatBufferBuilder builder, int upSpeed)
		{
			builder.AddInt(2, upSpeed, 0);
		}

		// Token: 0x06028F4E RID: 167758 RVA: 0x005988B5 File Offset: 0x00596AB5
		public static void AddDownSpeed(FlatBufferBuilder builder, int downSpeed)
		{
			builder.AddInt(3, downSpeed, 0);
		}

		// Token: 0x06028F4F RID: 167759 RVA: 0x005988C0 File Offset: 0x00596AC0
		public static void AddRailSplineEntityId(FlatBufferBuilder builder, int railSplineEntityId)
		{
			builder.AddInt(4, railSplineEntityId, 0);
		}

		// Token: 0x06028F50 RID: 167760 RVA: 0x005988CB File Offset: 0x00596ACB
		public static void AddExchangeRailConfigs(FlatBufferBuilder builder, VectorOffset exchangeRailConfigsOffset)
		{
			builder.AddOffset(5, exchangeRailConfigsOffset.Value, 0);
		}

		// Token: 0x06028F51 RID: 167761 RVA: 0x005988DC File Offset: 0x00596ADC
		public static VectorOffset CreateExchangeRailConfigsVector(FlatBufferBuilder builder, Offset<IExchangeSlideRailConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06028F52 RID: 167762 RVA: 0x0059891C File Offset: 0x00596B1C
		public static VectorOffset CreateExchangeRailConfigsVectorBlock(FlatBufferBuilder builder, Offset<IExchangeSlideRailConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IExchangeSlideRailConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028F53 RID: 167763 RVA: 0x00598936 File Offset: 0x00596B36
		public static VectorOffset CreateExchangeRailConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IExchangeSlideRailConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IExchangeSlideRailConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028F54 RID: 167764 RVA: 0x00598954 File Offset: 0x00596B54
		public static VectorOffset CreateExchangeRailConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IExchangeSlideRailConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028F55 RID: 167765 RVA: 0x0059896D File Offset: 0x00596B6D
		public static void StartExchangeRailConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028F56 RID: 167766 RVA: 0x00598978 File Offset: 0x00596B78
		public static void AddSlidePerformConfig(FlatBufferBuilder builder, Offset<ISlopeSlidePerform> slidePerformConfigOffset)
		{
			builder.AddOffset(6, slidePerformConfigOffset.Value, 0);
		}

		// Token: 0x06028F57 RID: 167767 RVA: 0x00598988 File Offset: 0x00596B88
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06028F58 RID: 167768 RVA: 0x00598993 File Offset: 0x00596B93
		public static Offset<ISlidePerformComponent> EndISlidePerformComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISlidePerformComponent>(builder.EndTable());
		}

		// Token: 0x06028F59 RID: 167769 RVA: 0x005989A0 File Offset: 0x00596BA0
		public ISlidePerformComponentT UnPack()
		{
			ISlidePerformComponentT slidePerformComponentT = new ISlidePerformComponentT();
			this.UnPackTo(slidePerformComponentT);
			return slidePerformComponentT;
		}

		// Token: 0x06028F5A RID: 167770 RVA: 0x005989BC File Offset: 0x00596BBC
		public void UnPackTo(ISlidePerformComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.SlideSpeed = this.SlideSpeed;
			_o.UpSpeed = this.UpSpeed;
			_o.DownSpeed = this.DownSpeed;
			_o.RailSplineEntityId = this.RailSplineEntityId;
			_o.ExchangeRailConfigs = new List<IExchangeSlideRailConfigT>();
			for (int i = 0; i < this.ExchangeRailConfigsLength; i++)
			{
				_o.ExchangeRailConfigs.Add((this.ExchangeRailConfigs(i) != null) ? this.ExchangeRailConfigs(i).Value.UnPack() : null);
			}
			_o.SlidePerformConfig = ((this.SlidePerformConfig != null) ? this.SlidePerformConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06028F5B RID: 167771 RVA: 0x00598A94 File Offset: 0x00596C94
		public static Offset<ISlidePerformComponent> Pack(FlatBufferBuilder builder, ISlidePerformComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISlidePerformComponent>);
			}
			VectorOffset exchangeRailConfigsOffset = default(VectorOffset);
			if (_o.ExchangeRailConfigs != null)
			{
				Offset<IExchangeSlideRailConfig>[] array = new Offset<IExchangeSlideRailConfig>[_o.ExchangeRailConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IExchangeSlideRailConfig.Pack(builder, _o.ExchangeRailConfigs[i]);
				}
				exchangeRailConfigsOffset = ISlidePerformComponent.CreateExchangeRailConfigsVector(builder, array);
			}
			Offset<ISlopeSlidePerform> slidePerformConfigOffset = (_o.SlidePerformConfig == null) ? default(Offset<ISlopeSlidePerform>) : ISlopeSlidePerform.Pack(builder, _o.SlidePerformConfig);
			return ISlidePerformComponent.CreateISlidePerformComponent(builder, _o.Disabled, _o.SlideSpeed, _o.UpSpeed, _o.DownSpeed, _o.RailSplineEntityId, exchangeRailConfigsOffset, slidePerformConfigOffset, _o.NullMask);
		}

		// Token: 0x0400FBE2 RID: 64482
		private Table __p;
	}
}
