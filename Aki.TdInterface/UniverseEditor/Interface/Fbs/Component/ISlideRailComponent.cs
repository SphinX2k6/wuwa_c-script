using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F42 RID: 24386
	public struct ISlideRailComponent : IFlatbufferObject
	{
		// Token: 0x1700B491 RID: 46225
		// (get) Token: 0x06028F8C RID: 167820 RVA: 0x00598F66 File Offset: 0x00597166
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028F8D RID: 167821 RVA: 0x00598F73 File Offset: 0x00597173
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028F8E RID: 167822 RVA: 0x00598F7C File Offset: 0x0059717C
		public static ISlideRailComponent GetRootAsISlideRailComponent(ByteBuffer _bb)
		{
			return ISlideRailComponent.GetRootAsISlideRailComponent(_bb, default(ISlideRailComponent));
		}

		// Token: 0x06028F8F RID: 167823 RVA: 0x00598F98 File Offset: 0x00597198
		public static ISlideRailComponent GetRootAsISlideRailComponent(ByteBuffer _bb, ISlideRailComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028F90 RID: 167824 RVA: 0x00598FB5 File Offset: 0x005971B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028F91 RID: 167825 RVA: 0x00598FC4 File Offset: 0x005971C4
		public ISlideRailComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B492 RID: 46226
		// (get) Token: 0x06028F92 RID: 167826 RVA: 0x00598FD4 File Offset: 0x005971D4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B493 RID: 46227
		// (get) Token: 0x06028F93 RID: 167827 RVA: 0x00599014 File Offset: 0x00597214
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

		// Token: 0x1700B494 RID: 46228
		// (get) Token: 0x06028F94 RID: 167828 RVA: 0x00599050 File Offset: 0x00597250
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

		// Token: 0x1700B495 RID: 46229
		// (get) Token: 0x06028F95 RID: 167829 RVA: 0x0059908C File Offset: 0x0059728C
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

		// Token: 0x1700B496 RID: 46230
		// (get) Token: 0x06028F96 RID: 167830 RVA: 0x005990CC File Offset: 0x005972CC
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

		// Token: 0x06028F97 RID: 167831 RVA: 0x0059910C File Offset: 0x0059730C
		public IExchangeSlideRailConfig? ExchangeRailConfigs(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IExchangeSlideRailConfig?(default(IExchangeSlideRailConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B497 RID: 46231
		// (get) Token: 0x06028F98 RID: 167832 RVA: 0x00599170 File Offset: 0x00597370
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

		// Token: 0x1700B498 RID: 46232
		// (get) Token: 0x06028F99 RID: 167833 RVA: 0x0059919C File Offset: 0x0059739C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028F9A RID: 167834 RVA: 0x005991DC File Offset: 0x005973DC
		public static Offset<ISlideRailComponent> CreateISlideRailComponent(FlatBufferBuilder builder, bool Disabled = false, int SlideSpeed = 0, int UpSpeed = 0, int DownSpeed = 0, int RailSplineEntityId = 0, VectorOffset ExchangeRailConfigsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(7);
			ISlideRailComponent.AddExchangeRailConfigs(builder, ExchangeRailConfigsOffset);
			ISlideRailComponent.AddRailSplineEntityId(builder, RailSplineEntityId);
			ISlideRailComponent.AddDownSpeed(builder, DownSpeed);
			ISlideRailComponent.AddUpSpeed(builder, UpSpeed);
			ISlideRailComponent.AddSlideSpeed(builder, SlideSpeed);
			ISlideRailComponent.AddNullMask(builder, NullMask);
			ISlideRailComponent.AddDisabled(builder, Disabled);
			return ISlideRailComponent.EndISlideRailComponent(builder);
		}

		// Token: 0x06028F9B RID: 167835 RVA: 0x0059922B File Offset: 0x0059742B
		public static void StartISlideRailComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06028F9C RID: 167836 RVA: 0x00599234 File Offset: 0x00597434
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06028F9D RID: 167837 RVA: 0x0059923F File Offset: 0x0059743F
		public static void AddSlideSpeed(FlatBufferBuilder builder, int slideSpeed)
		{
			builder.AddInt(1, slideSpeed, 0);
		}

		// Token: 0x06028F9E RID: 167838 RVA: 0x0059924A File Offset: 0x0059744A
		public static void AddUpSpeed(FlatBufferBuilder builder, int upSpeed)
		{
			builder.AddInt(2, upSpeed, 0);
		}

		// Token: 0x06028F9F RID: 167839 RVA: 0x00599255 File Offset: 0x00597455
		public static void AddDownSpeed(FlatBufferBuilder builder, int downSpeed)
		{
			builder.AddInt(3, downSpeed, 0);
		}

		// Token: 0x06028FA0 RID: 167840 RVA: 0x00599260 File Offset: 0x00597460
		public static void AddRailSplineEntityId(FlatBufferBuilder builder, int railSplineEntityId)
		{
			builder.AddInt(4, railSplineEntityId, 0);
		}

		// Token: 0x06028FA1 RID: 167841 RVA: 0x0059926B File Offset: 0x0059746B
		public static void AddExchangeRailConfigs(FlatBufferBuilder builder, VectorOffset exchangeRailConfigsOffset)
		{
			builder.AddOffset(5, exchangeRailConfigsOffset.Value, 0);
		}

		// Token: 0x06028FA2 RID: 167842 RVA: 0x0059927C File Offset: 0x0059747C
		public static VectorOffset CreateExchangeRailConfigsVector(FlatBufferBuilder builder, Offset<IExchangeSlideRailConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06028FA3 RID: 167843 RVA: 0x005992BC File Offset: 0x005974BC
		public static VectorOffset CreateExchangeRailConfigsVectorBlock(FlatBufferBuilder builder, Offset<IExchangeSlideRailConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IExchangeSlideRailConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028FA4 RID: 167844 RVA: 0x005992D6 File Offset: 0x005974D6
		public static VectorOffset CreateExchangeRailConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IExchangeSlideRailConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IExchangeSlideRailConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028FA5 RID: 167845 RVA: 0x005992F4 File Offset: 0x005974F4
		public static VectorOffset CreateExchangeRailConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IExchangeSlideRailConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028FA6 RID: 167846 RVA: 0x0059930D File Offset: 0x0059750D
		public static void StartExchangeRailConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028FA7 RID: 167847 RVA: 0x00599318 File Offset: 0x00597518
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06028FA8 RID: 167848 RVA: 0x00599323 File Offset: 0x00597523
		public static Offset<ISlideRailComponent> EndISlideRailComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISlideRailComponent>(builder.EndTable());
		}

		// Token: 0x06028FA9 RID: 167849 RVA: 0x00599330 File Offset: 0x00597530
		public ISlideRailComponentT UnPack()
		{
			ISlideRailComponentT slideRailComponentT = new ISlideRailComponentT();
			this.UnPackTo(slideRailComponentT);
			return slideRailComponentT;
		}

		// Token: 0x06028FAA RID: 167850 RVA: 0x0059934C File Offset: 0x0059754C
		public void UnPackTo(ISlideRailComponentT _o)
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
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06028FAB RID: 167851 RVA: 0x005993F4 File Offset: 0x005975F4
		public static Offset<ISlideRailComponent> Pack(FlatBufferBuilder builder, ISlideRailComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISlideRailComponent>);
			}
			VectorOffset exchangeRailConfigsOffset = default(VectorOffset);
			if (_o.ExchangeRailConfigs != null)
			{
				Offset<IExchangeSlideRailConfig>[] array = new Offset<IExchangeSlideRailConfig>[_o.ExchangeRailConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IExchangeSlideRailConfig.Pack(builder, _o.ExchangeRailConfigs[i]);
				}
				exchangeRailConfigsOffset = ISlideRailComponent.CreateExchangeRailConfigsVector(builder, array);
			}
			return ISlideRailComponent.CreateISlideRailComponent(builder, _o.Disabled, _o.SlideSpeed, _o.UpSpeed, _o.DownSpeed, _o.RailSplineEntityId, exchangeRailConfigsOffset, _o.NullMask);
		}

		// Token: 0x0400FBF3 RID: 64499
		private Table __p;
	}
}
