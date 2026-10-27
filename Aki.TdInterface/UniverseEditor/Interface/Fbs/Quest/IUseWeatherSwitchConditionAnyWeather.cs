using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004262 RID: 16994
	public struct IUseWeatherSwitchConditionAnyWeather : IFlatbufferObject
	{
		// Token: 0x170078AC RID: 30892
		// (get) Token: 0x0601926B RID: 103019 RVA: 0x0039D923 File Offset: 0x0039BB23
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601926C RID: 103020 RVA: 0x0039D930 File Offset: 0x0039BB30
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601926D RID: 103021 RVA: 0x0039D938 File Offset: 0x0039BB38
		public static IUseWeatherSwitchConditionAnyWeather GetRootAsIUseWeatherSwitchConditionAnyWeather(ByteBuffer _bb)
		{
			return IUseWeatherSwitchConditionAnyWeather.GetRootAsIUseWeatherSwitchConditionAnyWeather(_bb, default(IUseWeatherSwitchConditionAnyWeather));
		}

		// Token: 0x0601926E RID: 103022 RVA: 0x0039D954 File Offset: 0x0039BB54
		public static IUseWeatherSwitchConditionAnyWeather GetRootAsIUseWeatherSwitchConditionAnyWeather(ByteBuffer _bb, IUseWeatherSwitchConditionAnyWeather obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601926F RID: 103023 RVA: 0x0039D971 File Offset: 0x0039BB71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019270 RID: 103024 RVA: 0x0039D980 File Offset: 0x0039BB80
		public IUseWeatherSwitchConditionAnyWeather __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170078AD RID: 30893
		// (get) Token: 0x06019271 RID: 103025 RVA: 0x0039D990 File Offset: 0x0039BB90
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

		// Token: 0x06019272 RID: 103026 RVA: 0x0039D9CC File Offset: 0x0039BBCC
		public static Offset<IUseWeatherSwitchConditionAnyWeather> CreateIUseWeatherSwitchConditionAnyWeather(FlatBufferBuilder builder, EUseWeatherSwitchCheckType Type = EUseWeatherSwitchCheckType.SpecifiedWeather)
		{
			builder.StartTable(1);
			IUseWeatherSwitchConditionAnyWeather.AddType(builder, Type);
			return IUseWeatherSwitchConditionAnyWeather.EndIUseWeatherSwitchConditionAnyWeather(builder);
		}

		// Token: 0x06019273 RID: 103027 RVA: 0x0039D9E2 File Offset: 0x0039BBE2
		public static void StartIUseWeatherSwitchConditionAnyWeather(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019274 RID: 103028 RVA: 0x0039D9EB File Offset: 0x0039BBEB
		public static void AddType(FlatBufferBuilder builder, EUseWeatherSwitchCheckType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019275 RID: 103029 RVA: 0x0039D9F6 File Offset: 0x0039BBF6
		public static Offset<IUseWeatherSwitchConditionAnyWeather> EndIUseWeatherSwitchConditionAnyWeather(FlatBufferBuilder builder)
		{
			return new Offset<IUseWeatherSwitchConditionAnyWeather>(builder.EndTable());
		}

		// Token: 0x06019276 RID: 103030 RVA: 0x0039DA04 File Offset: 0x0039BC04
		public IUseWeatherSwitchConditionAnyWeatherT UnPack()
		{
			IUseWeatherSwitchConditionAnyWeatherT useWeatherSwitchConditionAnyWeatherT = new IUseWeatherSwitchConditionAnyWeatherT();
			this.UnPackTo(useWeatherSwitchConditionAnyWeatherT);
			return useWeatherSwitchConditionAnyWeatherT;
		}

		// Token: 0x06019277 RID: 103031 RVA: 0x0039DA1F File Offset: 0x0039BC1F
		public void UnPackTo(IUseWeatherSwitchConditionAnyWeatherT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019278 RID: 103032 RVA: 0x0039DA30 File Offset: 0x0039BC30
		public static Offset<IUseWeatherSwitchConditionAnyWeather> Pack(FlatBufferBuilder builder, IUseWeatherSwitchConditionAnyWeatherT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUseWeatherSwitchConditionAnyWeather>);
			}
			return IUseWeatherSwitchConditionAnyWeather.CreateIUseWeatherSwitchConditionAnyWeather(builder, _o.Type);
		}

		// Token: 0x0400BEF2 RID: 48882
		private Table __p;
	}
}
