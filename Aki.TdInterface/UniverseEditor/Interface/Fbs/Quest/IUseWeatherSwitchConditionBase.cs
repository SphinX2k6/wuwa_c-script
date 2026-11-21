using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046C1 RID: 18113
	public struct IUseWeatherSwitchConditionBase : IFlatbufferObject
	{
		// Token: 0x17007EE0 RID: 32480
		// (get) Token: 0x0601A9E9 RID: 109033 RVA: 0x003C9171 File Offset: 0x003C7371
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A9EA RID: 109034 RVA: 0x003C917E File Offset: 0x003C737E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A9EB RID: 109035 RVA: 0x003C9188 File Offset: 0x003C7388
		public static IUseWeatherSwitchConditionBase GetRootAsIUseWeatherSwitchConditionBase(ByteBuffer _bb)
		{
			return IUseWeatherSwitchConditionBase.GetRootAsIUseWeatherSwitchConditionBase(_bb, default(IUseWeatherSwitchConditionBase));
		}

		// Token: 0x0601A9EC RID: 109036 RVA: 0x003C91A4 File Offset: 0x003C73A4
		public static IUseWeatherSwitchConditionBase GetRootAsIUseWeatherSwitchConditionBase(ByteBuffer _bb, IUseWeatherSwitchConditionBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A9ED RID: 109037 RVA: 0x003C91C1 File Offset: 0x003C73C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A9EE RID: 109038 RVA: 0x003C91D0 File Offset: 0x003C73D0
		public IUseWeatherSwitchConditionBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007EE1 RID: 32481
		// (get) Token: 0x0601A9EF RID: 109039 RVA: 0x003C91E0 File Offset: 0x003C73E0
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

		// Token: 0x0601A9F0 RID: 109040 RVA: 0x003C921C File Offset: 0x003C741C
		public static Offset<IUseWeatherSwitchConditionBase> CreateIUseWeatherSwitchConditionBase(FlatBufferBuilder builder, EUseWeatherSwitchCheckType Type = EUseWeatherSwitchCheckType.SpecifiedWeather)
		{
			builder.StartTable(1);
			IUseWeatherSwitchConditionBase.AddType(builder, Type);
			return IUseWeatherSwitchConditionBase.EndIUseWeatherSwitchConditionBase(builder);
		}

		// Token: 0x0601A9F1 RID: 109041 RVA: 0x003C9232 File Offset: 0x003C7432
		public static void StartIUseWeatherSwitchConditionBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A9F2 RID: 109042 RVA: 0x003C923B File Offset: 0x003C743B
		public static void AddType(FlatBufferBuilder builder, EUseWeatherSwitchCheckType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A9F3 RID: 109043 RVA: 0x003C9246 File Offset: 0x003C7446
		public static Offset<IUseWeatherSwitchConditionBase> EndIUseWeatherSwitchConditionBase(FlatBufferBuilder builder)
		{
			return new Offset<IUseWeatherSwitchConditionBase>(builder.EndTable());
		}

		// Token: 0x0601A9F4 RID: 109044 RVA: 0x003C9254 File Offset: 0x003C7454
		public IUseWeatherSwitchConditionBaseT UnPack()
		{
			IUseWeatherSwitchConditionBaseT useWeatherSwitchConditionBaseT = new IUseWeatherSwitchConditionBaseT();
			this.UnPackTo(useWeatherSwitchConditionBaseT);
			return useWeatherSwitchConditionBaseT;
		}

		// Token: 0x0601A9F5 RID: 109045 RVA: 0x003C926F File Offset: 0x003C746F
		public void UnPackTo(IUseWeatherSwitchConditionBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601A9F6 RID: 109046 RVA: 0x003C9280 File Offset: 0x003C7480
		public static Offset<IUseWeatherSwitchConditionBase> Pack(FlatBufferBuilder builder, IUseWeatherSwitchConditionBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUseWeatherSwitchConditionBase>);
			}
			return IUseWeatherSwitchConditionBase.CreateIUseWeatherSwitchConditionBase(builder, _o.Type);
		}

		// Token: 0x0400C901 RID: 51457
		private Table __p;
	}
}
