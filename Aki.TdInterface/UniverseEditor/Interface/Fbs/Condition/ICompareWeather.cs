using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BD1 RID: 19409
	public struct ICompareWeather : IFlatbufferObject
	{
		// Token: 0x17008CFE RID: 36094
		// (get) Token: 0x0601EA49 RID: 125513 RVA: 0x004493DF File Offset: 0x004475DF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EA4A RID: 125514 RVA: 0x004493EC File Offset: 0x004475EC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EA4B RID: 125515 RVA: 0x004493F4 File Offset: 0x004475F4
		public static ICompareWeather GetRootAsICompareWeather(ByteBuffer _bb)
		{
			return ICompareWeather.GetRootAsICompareWeather(_bb, default(ICompareWeather));
		}

		// Token: 0x0601EA4C RID: 125516 RVA: 0x00449410 File Offset: 0x00447610
		public static ICompareWeather GetRootAsICompareWeather(ByteBuffer _bb, ICompareWeather obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EA4D RID: 125517 RVA: 0x0044942D File Offset: 0x0044762D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EA4E RID: 125518 RVA: 0x0044943C File Offset: 0x0044763C
		public ICompareWeather __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008CFF RID: 36095
		// (get) Token: 0x0601EA4F RID: 125519 RVA: 0x0044944C File Offset: 0x0044764C
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008D00 RID: 36096
		// (get) Token: 0x0601EA50 RID: 125520 RVA: 0x00449488 File Offset: 0x00447688
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008D01 RID: 36097
		// (get) Token: 0x0601EA51 RID: 125521 RVA: 0x004494C4 File Offset: 0x004476C4
		public EWeather Weather
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EWeather.Sunny;
				}
				return (EWeather)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008D02 RID: 36098
		// (get) Token: 0x0601EA52 RID: 125522 RVA: 0x00449500 File Offset: 0x00447700
		public int WeatherId
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

		// Token: 0x17008D03 RID: 36099
		// (get) Token: 0x0601EA53 RID: 125523 RVA: 0x00449540 File Offset: 0x00447740
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

		// Token: 0x0601EA54 RID: 125524 RVA: 0x0044957D File Offset: 0x0044777D
		public static Offset<ICompareWeather> CreateICompareWeather(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECompare Compare = ECompare.Eq, EWeather Weather = EWeather.Sunny, int WeatherId = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			ICompareWeather.AddWeatherId(builder, WeatherId);
			ICompareWeather.AddNullMask(builder, NullMask);
			ICompareWeather.AddWeather(builder, Weather);
			ICompareWeather.AddCompare(builder, Compare);
			ICompareWeather.AddType(builder, Type);
			return ICompareWeather.EndICompareWeather(builder);
		}

		// Token: 0x0601EA55 RID: 125525 RVA: 0x004495B1 File Offset: 0x004477B1
		public static void StartICompareWeather(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601EA56 RID: 125526 RVA: 0x004495BA File Offset: 0x004477BA
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EA57 RID: 125527 RVA: 0x004495C5 File Offset: 0x004477C5
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0601EA58 RID: 125528 RVA: 0x004495D0 File Offset: 0x004477D0
		public static void AddWeather(FlatBufferBuilder builder, EWeather weather)
		{
			builder.AddByte(2, (byte)weather, 0);
		}

		// Token: 0x0601EA59 RID: 125529 RVA: 0x004495DB File Offset: 0x004477DB
		public static void AddWeatherId(FlatBufferBuilder builder, int weatherId)
		{
			builder.AddInt(3, weatherId, 0);
		}

		// Token: 0x0601EA5A RID: 125530 RVA: 0x004495E6 File Offset: 0x004477E6
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601EA5B RID: 125531 RVA: 0x004495F1 File Offset: 0x004477F1
		public static Offset<ICompareWeather> EndICompareWeather(FlatBufferBuilder builder)
		{
			return new Offset<ICompareWeather>(builder.EndTable());
		}

		// Token: 0x0601EA5C RID: 125532 RVA: 0x00449600 File Offset: 0x00447800
		public ICompareWeatherT UnPack()
		{
			ICompareWeatherT compareWeatherT = new ICompareWeatherT();
			this.UnPackTo(compareWeatherT);
			return compareWeatherT;
		}

		// Token: 0x0601EA5D RID: 125533 RVA: 0x0044961B File Offset: 0x0044781B
		public void UnPackTo(ICompareWeatherT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.Weather = this.Weather;
			_o.WeatherId = this.WeatherId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601EA5E RID: 125534 RVA: 0x0044965C File Offset: 0x0044785C
		public static Offset<ICompareWeather> Pack(FlatBufferBuilder builder, ICompareWeatherT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareWeather>);
			}
			return ICompareWeather.CreateICompareWeather(builder, _o.Type, _o.Compare, _o.Weather, _o.WeatherId, _o.NullMask);
		}

		// Token: 0x0400D4C2 RID: 54466
		private Table __p;
	}
}
