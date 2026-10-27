using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200592C RID: 22828
	public struct ISlidePerformComponent : IFlatbufferObject
	{
		// Token: 0x1700AB47 RID: 43847
		// (get) Token: 0x060269D0 RID: 158160 RVA: 0x005518F4 File Offset: 0x0054FAF4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060269D1 RID: 158161 RVA: 0x00551901 File Offset: 0x0054FB01
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060269D2 RID: 158162 RVA: 0x00551908 File Offset: 0x0054FB08
		public static ISlidePerformComponent GetRootAsISlidePerformComponent(ByteBuffer _bb)
		{
			return ISlidePerformComponent.GetRootAsISlidePerformComponent(_bb, default(ISlidePerformComponent));
		}

		// Token: 0x060269D3 RID: 158163 RVA: 0x00551924 File Offset: 0x0054FB24
		public static ISlidePerformComponent GetRootAsISlidePerformComponent(ByteBuffer _bb, ISlidePerformComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060269D4 RID: 158164 RVA: 0x00551941 File Offset: 0x0054FB41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060269D5 RID: 158165 RVA: 0x00551950 File Offset: 0x0054FB50
		public ISlidePerformComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AB48 RID: 43848
		// (get) Token: 0x060269D6 RID: 158166 RVA: 0x00551960 File Offset: 0x0054FB60
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AB49 RID: 43849
		// (get) Token: 0x060269D7 RID: 158167 RVA: 0x005519A0 File Offset: 0x0054FBA0
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

		// Token: 0x1700AB4A RID: 43850
		// (get) Token: 0x060269D8 RID: 158168 RVA: 0x005519DC File Offset: 0x0054FBDC
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

		// Token: 0x1700AB4B RID: 43851
		// (get) Token: 0x060269D9 RID: 158169 RVA: 0x00551A18 File Offset: 0x0054FC18
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

		// Token: 0x1700AB4C RID: 43852
		// (get) Token: 0x060269DA RID: 158170 RVA: 0x00551A58 File Offset: 0x0054FC58
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

		// Token: 0x060269DB RID: 158171 RVA: 0x00551A98 File Offset: 0x0054FC98
		public IExchangeSlideRailConfig? ExchangeRailConfigs(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IExchangeSlideRailConfig?(default(IExchangeSlideRailConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AB4D RID: 43853
		// (get) Token: 0x060269DC RID: 158172 RVA: 0x00551AFC File Offset: 0x0054FCFC
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

		// Token: 0x1700AB4E RID: 43854
		// (get) Token: 0x060269DD RID: 158173 RVA: 0x00551B28 File Offset: 0x0054FD28
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

		// Token: 0x1700AB4F RID: 43855
		// (get) Token: 0x060269DE RID: 158174 RVA: 0x00551B88 File Offset: 0x0054FD88
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

		// Token: 0x060269DF RID: 158175 RVA: 0x00551BC8 File Offset: 0x0054FDC8
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

		// Token: 0x060269E0 RID: 158176 RVA: 0x00551C1F File Offset: 0x0054FE1F
		public static void StartISlidePerformComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x060269E1 RID: 158177 RVA: 0x00551C28 File Offset: 0x0054FE28
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060269E2 RID: 158178 RVA: 0x00551C33 File Offset: 0x0054FE33
		public static void AddSlideSpeed(FlatBufferBuilder builder, int slideSpeed)
		{
			builder.AddInt(1, slideSpeed, 0);
		}

		// Token: 0x060269E3 RID: 158179 RVA: 0x00551C3E File Offset: 0x0054FE3E
		public static void AddUpSpeed(FlatBufferBuilder builder, int upSpeed)
		{
			builder.AddInt(2, upSpeed, 0);
		}

		// Token: 0x060269E4 RID: 158180 RVA: 0x00551C49 File Offset: 0x0054FE49
		public static void AddDownSpeed(FlatBufferBuilder builder, int downSpeed)
		{
			builder.AddInt(3, downSpeed, 0);
		}

		// Token: 0x060269E5 RID: 158181 RVA: 0x00551C54 File Offset: 0x0054FE54
		public static void AddRailSplineEntityId(FlatBufferBuilder builder, int railSplineEntityId)
		{
			builder.AddInt(4, railSplineEntityId, 0);
		}

		// Token: 0x060269E6 RID: 158182 RVA: 0x00551C5F File Offset: 0x0054FE5F
		public static void AddExchangeRailConfigs(FlatBufferBuilder builder, VectorOffset exchangeRailConfigsOffset)
		{
			builder.AddOffset(5, exchangeRailConfigsOffset.Value, 0);
		}

		// Token: 0x060269E7 RID: 158183 RVA: 0x00551C70 File Offset: 0x0054FE70
		public static VectorOffset CreateExchangeRailConfigsVector(FlatBufferBuilder builder, Offset<IExchangeSlideRailConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060269E8 RID: 158184 RVA: 0x00551CB0 File Offset: 0x0054FEB0
		public static VectorOffset CreateExchangeRailConfigsVectorBlock(FlatBufferBuilder builder, Offset<IExchangeSlideRailConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IExchangeSlideRailConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060269E9 RID: 158185 RVA: 0x00551CCA File Offset: 0x0054FECA
		public static VectorOffset CreateExchangeRailConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IExchangeSlideRailConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IExchangeSlideRailConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060269EA RID: 158186 RVA: 0x00551CE8 File Offset: 0x0054FEE8
		public static VectorOffset CreateExchangeRailConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IExchangeSlideRailConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060269EB RID: 158187 RVA: 0x00551D01 File Offset: 0x0054FF01
		public static void StartExchangeRailConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060269EC RID: 158188 RVA: 0x00551D0C File Offset: 0x0054FF0C
		public static void AddSlidePerformConfig(FlatBufferBuilder builder, Offset<ISlopeSlidePerform> slidePerformConfigOffset)
		{
			builder.AddOffset(6, slidePerformConfigOffset.Value, 0);
		}

		// Token: 0x060269ED RID: 158189 RVA: 0x00551D1C File Offset: 0x0054FF1C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x060269EE RID: 158190 RVA: 0x00551D27 File Offset: 0x0054FF27
		public static Offset<ISlidePerformComponent> EndISlidePerformComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISlidePerformComponent>(builder.EndTable());
		}

		// Token: 0x060269EF RID: 158191 RVA: 0x00551D34 File Offset: 0x0054FF34
		public ISlidePerformComponentT UnPack()
		{
			ISlidePerformComponentT slidePerformComponentT = new ISlidePerformComponentT();
			this.UnPackTo(slidePerformComponentT);
			return slidePerformComponentT;
		}

		// Token: 0x060269F0 RID: 158192 RVA: 0x00551D50 File Offset: 0x0054FF50
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

		// Token: 0x060269F1 RID: 158193 RVA: 0x00551E28 File Offset: 0x00550028
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

		// Token: 0x0400EEED RID: 61165
		private Table __p;
	}
}
