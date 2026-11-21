using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007714 RID: 30484
	public struct ISeasonWeatherUnlockSpecial : IFlatbufferObject
	{
		// Token: 0x1700DF8E RID: 57230
		// (get) Token: 0x060357C5 RID: 219077 RVA: 0x0072BD3D File Offset: 0x00729F3D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060357C6 RID: 219078 RVA: 0x0072BD4A File Offset: 0x00729F4A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060357C7 RID: 219079 RVA: 0x0072BD54 File Offset: 0x00729F54
		public static ISeasonWeatherUnlockSpecial GetRootAsISeasonWeatherUnlockSpecial(ByteBuffer _bb)
		{
			return ISeasonWeatherUnlockSpecial.GetRootAsISeasonWeatherUnlockSpecial(_bb, default(ISeasonWeatherUnlockSpecial));
		}

		// Token: 0x060357C8 RID: 219080 RVA: 0x0072BD70 File Offset: 0x00729F70
		public static ISeasonWeatherUnlockSpecial GetRootAsISeasonWeatherUnlockSpecial(ByteBuffer _bb, ISeasonWeatherUnlockSpecial obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060357C9 RID: 219081 RVA: 0x0072BD8D File Offset: 0x00729F8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060357CA RID: 219082 RVA: 0x0072BD9C File Offset: 0x00729F9C
		public ISeasonWeatherUnlockSpecial __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DF8F RID: 57231
		// (get) Token: 0x060357CB RID: 219083 RVA: 0x0072BDAC File Offset: 0x00729FAC
		public int Weather
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060357CC RID: 219084 RVA: 0x0072BDE8 File Offset: 0x00729FE8
		public static Offset<ISeasonWeatherUnlockSpecial> CreateISeasonWeatherUnlockSpecial(FlatBufferBuilder builder, int Weather = 0)
		{
			builder.StartTable(1);
			ISeasonWeatherUnlockSpecial.AddWeather(builder, Weather);
			return ISeasonWeatherUnlockSpecial.EndISeasonWeatherUnlockSpecial(builder);
		}

		// Token: 0x060357CD RID: 219085 RVA: 0x0072BDFE File Offset: 0x00729FFE
		public static void StartISeasonWeatherUnlockSpecial(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060357CE RID: 219086 RVA: 0x0072BE07 File Offset: 0x0072A007
		public static void AddWeather(FlatBufferBuilder builder, int weather)
		{
			builder.AddInt(0, weather, 0);
		}

		// Token: 0x060357CF RID: 219087 RVA: 0x0072BE12 File Offset: 0x0072A012
		public static Offset<ISeasonWeatherUnlockSpecial> EndISeasonWeatherUnlockSpecial(FlatBufferBuilder builder)
		{
			return new Offset<ISeasonWeatherUnlockSpecial>(builder.EndTable());
		}

		// Token: 0x060357D0 RID: 219088 RVA: 0x0072BE20 File Offset: 0x0072A020
		public ISeasonWeatherUnlockSpecialT UnPack()
		{
			ISeasonWeatherUnlockSpecialT seasonWeatherUnlockSpecialT = new ISeasonWeatherUnlockSpecialT();
			this.UnPackTo(seasonWeatherUnlockSpecialT);
			return seasonWeatherUnlockSpecialT;
		}

		// Token: 0x060357D1 RID: 219089 RVA: 0x0072BE3B File Offset: 0x0072A03B
		public void UnPackTo(ISeasonWeatherUnlockSpecialT _o)
		{
			_o.Weather = this.Weather;
		}

		// Token: 0x060357D2 RID: 219090 RVA: 0x0072BE4C File Offset: 0x0072A04C
		public static Offset<ISeasonWeatherUnlockSpecial> Pack(FlatBufferBuilder builder, ISeasonWeatherUnlockSpecialT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISeasonWeatherUnlockSpecial>);
			}
			return ISeasonWeatherUnlockSpecial.CreateISeasonWeatherUnlockSpecial(builder, _o.Weather);
		}

		// Token: 0x0401292D RID: 76077
		private Table __p;
	}
}
