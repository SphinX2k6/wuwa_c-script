using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050BE RID: 20670
	public struct ICompareWeather : IFlatbufferObject
	{
		// Token: 0x17009422 RID: 37922
		// (get) Token: 0x06020617 RID: 132631 RVA: 0x0047C2EB File Offset: 0x0047A4EB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020618 RID: 132632 RVA: 0x0047C2F8 File Offset: 0x0047A4F8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020619 RID: 132633 RVA: 0x0047C300 File Offset: 0x0047A500
		public static ICompareWeather GetRootAsICompareWeather(ByteBuffer _bb)
		{
			return ICompareWeather.GetRootAsICompareWeather(_bb, default(ICompareWeather));
		}

		// Token: 0x0602061A RID: 132634 RVA: 0x0047C31C File Offset: 0x0047A51C
		public static ICompareWeather GetRootAsICompareWeather(ByteBuffer _bb, ICompareWeather obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602061B RID: 132635 RVA: 0x0047C339 File Offset: 0x0047A539
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602061C RID: 132636 RVA: 0x0047C348 File Offset: 0x0047A548
		public ICompareWeather __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009423 RID: 37923
		// (get) Token: 0x0602061D RID: 132637 RVA: 0x0047C358 File Offset: 0x0047A558
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

		// Token: 0x17009424 RID: 37924
		// (get) Token: 0x0602061E RID: 132638 RVA: 0x0047C394 File Offset: 0x0047A594
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

		// Token: 0x17009425 RID: 37925
		// (get) Token: 0x0602061F RID: 132639 RVA: 0x0047C3D0 File Offset: 0x0047A5D0
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

		// Token: 0x17009426 RID: 37926
		// (get) Token: 0x06020620 RID: 132640 RVA: 0x0047C40C File Offset: 0x0047A60C
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

		// Token: 0x17009427 RID: 37927
		// (get) Token: 0x06020621 RID: 132641 RVA: 0x0047C44C File Offset: 0x0047A64C
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

		// Token: 0x06020622 RID: 132642 RVA: 0x0047C489 File Offset: 0x0047A689
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

		// Token: 0x06020623 RID: 132643 RVA: 0x0047C4BD File Offset: 0x0047A6BD
		public static void StartICompareWeather(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06020624 RID: 132644 RVA: 0x0047C4C6 File Offset: 0x0047A6C6
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020625 RID: 132645 RVA: 0x0047C4D1 File Offset: 0x0047A6D1
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x06020626 RID: 132646 RVA: 0x0047C4DC File Offset: 0x0047A6DC
		public static void AddWeather(FlatBufferBuilder builder, EWeather weather)
		{
			builder.AddByte(2, (byte)weather, 0);
		}

		// Token: 0x06020627 RID: 132647 RVA: 0x0047C4E7 File Offset: 0x0047A6E7
		public static void AddWeatherId(FlatBufferBuilder builder, int weatherId)
		{
			builder.AddInt(3, weatherId, 0);
		}

		// Token: 0x06020628 RID: 132648 RVA: 0x0047C4F2 File Offset: 0x0047A6F2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06020629 RID: 132649 RVA: 0x0047C4FD File Offset: 0x0047A6FD
		public static Offset<ICompareWeather> EndICompareWeather(FlatBufferBuilder builder)
		{
			return new Offset<ICompareWeather>(builder.EndTable());
		}

		// Token: 0x0602062A RID: 132650 RVA: 0x0047C50C File Offset: 0x0047A70C
		public ICompareWeatherT UnPack()
		{
			ICompareWeatherT compareWeatherT = new ICompareWeatherT();
			this.UnPackTo(compareWeatherT);
			return compareWeatherT;
		}

		// Token: 0x0602062B RID: 132651 RVA: 0x0047C527 File Offset: 0x0047A727
		public void UnPackTo(ICompareWeatherT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.Weather = this.Weather;
			_o.WeatherId = this.WeatherId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602062C RID: 132652 RVA: 0x0047C568 File Offset: 0x0047A768
		public static Offset<ICompareWeather> Pack(FlatBufferBuilder builder, ICompareWeatherT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareWeather>);
			}
			return ICompareWeather.CreateICompareWeather(builder, _o.Type, _o.Compare, _o.Weather, _o.WeatherId, _o.NullMask);
		}

		// Token: 0x0400DFCD RID: 57293
		private Table __p;
	}
}
