using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005935 RID: 22837
	public struct ISlideRailComponent : IFlatbufferObject
	{
		// Token: 0x1700AB5D RID: 43869
		// (get) Token: 0x06026A22 RID: 158242 RVA: 0x005522FA File Offset: 0x005504FA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026A23 RID: 158243 RVA: 0x00552307 File Offset: 0x00550507
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026A24 RID: 158244 RVA: 0x00552310 File Offset: 0x00550510
		public static ISlideRailComponent GetRootAsISlideRailComponent(ByteBuffer _bb)
		{
			return ISlideRailComponent.GetRootAsISlideRailComponent(_bb, default(ISlideRailComponent));
		}

		// Token: 0x06026A25 RID: 158245 RVA: 0x0055232C File Offset: 0x0055052C
		public static ISlideRailComponent GetRootAsISlideRailComponent(ByteBuffer _bb, ISlideRailComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026A26 RID: 158246 RVA: 0x00552349 File Offset: 0x00550549
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026A27 RID: 158247 RVA: 0x00552358 File Offset: 0x00550558
		public ISlideRailComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AB5E RID: 43870
		// (get) Token: 0x06026A28 RID: 158248 RVA: 0x00552368 File Offset: 0x00550568
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AB5F RID: 43871
		// (get) Token: 0x06026A29 RID: 158249 RVA: 0x005523A8 File Offset: 0x005505A8
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

		// Token: 0x1700AB60 RID: 43872
		// (get) Token: 0x06026A2A RID: 158250 RVA: 0x005523E4 File Offset: 0x005505E4
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

		// Token: 0x1700AB61 RID: 43873
		// (get) Token: 0x06026A2B RID: 158251 RVA: 0x00552420 File Offset: 0x00550620
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

		// Token: 0x1700AB62 RID: 43874
		// (get) Token: 0x06026A2C RID: 158252 RVA: 0x00552460 File Offset: 0x00550660
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

		// Token: 0x06026A2D RID: 158253 RVA: 0x005524A0 File Offset: 0x005506A0
		public IExchangeSlideRailConfig? ExchangeRailConfigs(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IExchangeSlideRailConfig?(default(IExchangeSlideRailConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AB63 RID: 43875
		// (get) Token: 0x06026A2E RID: 158254 RVA: 0x00552504 File Offset: 0x00550704
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

		// Token: 0x1700AB64 RID: 43876
		// (get) Token: 0x06026A2F RID: 158255 RVA: 0x00552530 File Offset: 0x00550730
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

		// Token: 0x06026A30 RID: 158256 RVA: 0x00552570 File Offset: 0x00550770
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

		// Token: 0x06026A31 RID: 158257 RVA: 0x005525BF File Offset: 0x005507BF
		public static void StartISlideRailComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06026A32 RID: 158258 RVA: 0x005525C8 File Offset: 0x005507C8
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06026A33 RID: 158259 RVA: 0x005525D3 File Offset: 0x005507D3
		public static void AddSlideSpeed(FlatBufferBuilder builder, int slideSpeed)
		{
			builder.AddInt(1, slideSpeed, 0);
		}

		// Token: 0x06026A34 RID: 158260 RVA: 0x005525DE File Offset: 0x005507DE
		public static void AddUpSpeed(FlatBufferBuilder builder, int upSpeed)
		{
			builder.AddInt(2, upSpeed, 0);
		}

		// Token: 0x06026A35 RID: 158261 RVA: 0x005525E9 File Offset: 0x005507E9
		public static void AddDownSpeed(FlatBufferBuilder builder, int downSpeed)
		{
			builder.AddInt(3, downSpeed, 0);
		}

		// Token: 0x06026A36 RID: 158262 RVA: 0x005525F4 File Offset: 0x005507F4
		public static void AddRailSplineEntityId(FlatBufferBuilder builder, int railSplineEntityId)
		{
			builder.AddInt(4, railSplineEntityId, 0);
		}

		// Token: 0x06026A37 RID: 158263 RVA: 0x005525FF File Offset: 0x005507FF
		public static void AddExchangeRailConfigs(FlatBufferBuilder builder, VectorOffset exchangeRailConfigsOffset)
		{
			builder.AddOffset(5, exchangeRailConfigsOffset.Value, 0);
		}

		// Token: 0x06026A38 RID: 158264 RVA: 0x00552610 File Offset: 0x00550810
		public static VectorOffset CreateExchangeRailConfigsVector(FlatBufferBuilder builder, Offset<IExchangeSlideRailConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026A39 RID: 158265 RVA: 0x00552650 File Offset: 0x00550850
		public static VectorOffset CreateExchangeRailConfigsVectorBlock(FlatBufferBuilder builder, Offset<IExchangeSlideRailConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IExchangeSlideRailConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026A3A RID: 158266 RVA: 0x0055266A File Offset: 0x0055086A
		public static VectorOffset CreateExchangeRailConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IExchangeSlideRailConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IExchangeSlideRailConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026A3B RID: 158267 RVA: 0x00552688 File Offset: 0x00550888
		public static VectorOffset CreateExchangeRailConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IExchangeSlideRailConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026A3C RID: 158268 RVA: 0x005526A1 File Offset: 0x005508A1
		public static void StartExchangeRailConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026A3D RID: 158269 RVA: 0x005526AC File Offset: 0x005508AC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06026A3E RID: 158270 RVA: 0x005526B7 File Offset: 0x005508B7
		public static Offset<ISlideRailComponent> EndISlideRailComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISlideRailComponent>(builder.EndTable());
		}

		// Token: 0x06026A3F RID: 158271 RVA: 0x005526C4 File Offset: 0x005508C4
		public ISlideRailComponentT UnPack()
		{
			ISlideRailComponentT slideRailComponentT = new ISlideRailComponentT();
			this.UnPackTo(slideRailComponentT);
			return slideRailComponentT;
		}

		// Token: 0x06026A40 RID: 158272 RVA: 0x005526E0 File Offset: 0x005508E0
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

		// Token: 0x06026A41 RID: 158273 RVA: 0x00552788 File Offset: 0x00550988
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

		// Token: 0x0400EEFE RID: 61182
		private Table __p;
	}
}
