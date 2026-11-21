using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046BE RID: 18110
	public struct IUseWeatherSwitchConditionAnyWeather : IFlatbufferObject
	{
		// Token: 0x17007EDD RID: 32477
		// (get) Token: 0x0601A9D7 RID: 109015 RVA: 0x003C8FFB File Offset: 0x003C71FB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A9D8 RID: 109016 RVA: 0x003C9008 File Offset: 0x003C7208
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A9D9 RID: 109017 RVA: 0x003C9010 File Offset: 0x003C7210
		public static IUseWeatherSwitchConditionAnyWeather GetRootAsIUseWeatherSwitchConditionAnyWeather(ByteBuffer _bb)
		{
			return IUseWeatherSwitchConditionAnyWeather.GetRootAsIUseWeatherSwitchConditionAnyWeather(_bb, default(IUseWeatherSwitchConditionAnyWeather));
		}

		// Token: 0x0601A9DA RID: 109018 RVA: 0x003C902C File Offset: 0x003C722C
		public static IUseWeatherSwitchConditionAnyWeather GetRootAsIUseWeatherSwitchConditionAnyWeather(ByteBuffer _bb, IUseWeatherSwitchConditionAnyWeather obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A9DB RID: 109019 RVA: 0x003C9049 File Offset: 0x003C7249
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A9DC RID: 109020 RVA: 0x003C9058 File Offset: 0x003C7258
		public IUseWeatherSwitchConditionAnyWeather __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007EDE RID: 32478
		// (get) Token: 0x0601A9DD RID: 109021 RVA: 0x003C9068 File Offset: 0x003C7268
		public EUseWeatherSwitchCheckType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EUseWeatherSwitchCheckType.SpecifiedWeather;
				}
				return (EUseWeatherSwitchCheckType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A9DE RID: 109022 RVA: 0x003C90A4 File Offset: 0x003C72A4
		public static Offset<IUseWeatherSwitchConditionAnyWeather> CreateIUseWeatherSwitchConditionAnyWeather(FlatBufferBuilder builder, EUseWeatherSwitchCheckType Type = EUseWeatherSwitchCheckType.SpecifiedWeather)
		{
			builder.StartTable(1);
			IUseWeatherSwitchConditionAnyWeather.AddType(builder, Type);
			return IUseWeatherSwitchConditionAnyWeather.EndIUseWeatherSwitchConditionAnyWeather(builder);
		}

		// Token: 0x0601A9DF RID: 109023 RVA: 0x003C90BA File Offset: 0x003C72BA
		public static void StartIUseWeatherSwitchConditionAnyWeather(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A9E0 RID: 109024 RVA: 0x003C90C3 File Offset: 0x003C72C3
		public static void AddType(FlatBufferBuilder builder, EUseWeatherSwitchCheckType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A9E1 RID: 109025 RVA: 0x003C90CE File Offset: 0x003C72CE
		public static Offset<IUseWeatherSwitchConditionAnyWeather> EndIUseWeatherSwitchConditionAnyWeather(FlatBufferBuilder builder)
		{
			return new Offset<IUseWeatherSwitchConditionAnyWeather>(builder.EndTable());
		}

		// Token: 0x0601A9E2 RID: 109026 RVA: 0x003C90DC File Offset: 0x003C72DC
		public IUseWeatherSwitchConditionAnyWeatherT UnPack()
		{
			IUseWeatherSwitchConditionAnyWeatherT useWeatherSwitchConditionAnyWeatherT = new IUseWeatherSwitchConditionAnyWeatherT();
			this.UnPackTo(useWeatherSwitchConditionAnyWeatherT);
			return useWeatherSwitchConditionAnyWeatherT;
		}

		// Token: 0x0601A9E3 RID: 109027 RVA: 0x003C90F7 File Offset: 0x003C72F7
		public void UnPackTo(IUseWeatherSwitchConditionAnyWeatherT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601A9E4 RID: 109028 RVA: 0x003C9108 File Offset: 0x003C7308
		public static Offset<IUseWeatherSwitchConditionAnyWeather> Pack(FlatBufferBuilder builder, IUseWeatherSwitchConditionAnyWeatherT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUseWeatherSwitchConditionAnyWeather>);
			}
			return IUseWeatherSwitchConditionAnyWeather.CreateIUseWeatherSwitchConditionAnyWeather(builder, _o.Type);
		}

		// Token: 0x0400C8FF RID: 51455
		private Table __p;
	}
}
