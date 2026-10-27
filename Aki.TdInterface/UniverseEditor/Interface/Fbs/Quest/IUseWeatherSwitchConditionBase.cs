using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004265 RID: 16997
	public struct IUseWeatherSwitchConditionBase : IFlatbufferObject
	{
		// Token: 0x170078AF RID: 30895
		// (get) Token: 0x0601927D RID: 103037 RVA: 0x0039DA99 File Offset: 0x0039BC99
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601927E RID: 103038 RVA: 0x0039DAA6 File Offset: 0x0039BCA6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601927F RID: 103039 RVA: 0x0039DAB0 File Offset: 0x0039BCB0
		public static IUseWeatherSwitchConditionBase GetRootAsIUseWeatherSwitchConditionBase(ByteBuffer _bb)
		{
			return IUseWeatherSwitchConditionBase.GetRootAsIUseWeatherSwitchConditionBase(_bb, default(IUseWeatherSwitchConditionBase));
		}

		// Token: 0x06019280 RID: 103040 RVA: 0x0039DACC File Offset: 0x0039BCCC
		public static IUseWeatherSwitchConditionBase GetRootAsIUseWeatherSwitchConditionBase(ByteBuffer _bb, IUseWeatherSwitchConditionBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019281 RID: 103041 RVA: 0x0039DAE9 File Offset: 0x0039BCE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019282 RID: 103042 RVA: 0x0039DAF8 File Offset: 0x0039BCF8
		public IUseWeatherSwitchConditionBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170078B0 RID: 30896
		// (get) Token: 0x06019283 RID: 103043 RVA: 0x0039DB08 File Offset: 0x0039BD08
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

		// Token: 0x06019284 RID: 103044 RVA: 0x0039DB44 File Offset: 0x0039BD44
		public static Offset<IUseWeatherSwitchConditionBase> CreateIUseWeatherSwitchConditionBase(FlatBufferBuilder builder, EUseWeatherSwitchCheckType Type = EUseWeatherSwitchCheckType.SpecifiedWeather)
		{
			builder.StartTable(1);
			IUseWeatherSwitchConditionBase.AddType(builder, Type);
			return IUseWeatherSwitchConditionBase.EndIUseWeatherSwitchConditionBase(builder);
		}

		// Token: 0x06019285 RID: 103045 RVA: 0x0039DB5A File Offset: 0x0039BD5A
		public static void StartIUseWeatherSwitchConditionBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019286 RID: 103046 RVA: 0x0039DB63 File Offset: 0x0039BD63
		public static void AddType(FlatBufferBuilder builder, EUseWeatherSwitchCheckType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019287 RID: 103047 RVA: 0x0039DB6E File Offset: 0x0039BD6E
		public static Offset<IUseWeatherSwitchConditionBase> EndIUseWeatherSwitchConditionBase(FlatBufferBuilder builder)
		{
			return new Offset<IUseWeatherSwitchConditionBase>(builder.EndTable());
		}

		// Token: 0x06019288 RID: 103048 RVA: 0x0039DB7C File Offset: 0x0039BD7C
		public IUseWeatherSwitchConditionBaseT UnPack()
		{
			IUseWeatherSwitchConditionBaseT useWeatherSwitchConditionBaseT = new IUseWeatherSwitchConditionBaseT();
			this.UnPackTo(useWeatherSwitchConditionBaseT);
			return useWeatherSwitchConditionBaseT;
		}

		// Token: 0x06019289 RID: 103049 RVA: 0x0039DB97 File Offset: 0x0039BD97
		public void UnPackTo(IUseWeatherSwitchConditionBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601928A RID: 103050 RVA: 0x0039DBA8 File Offset: 0x0039BDA8
		public static Offset<IUseWeatherSwitchConditionBase> Pack(FlatBufferBuilder builder, IUseWeatherSwitchConditionBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUseWeatherSwitchConditionBase>);
			}
			return IUseWeatherSwitchConditionBase.CreateIUseWeatherSwitchConditionBase(builder, _o.Type);
		}

		// Token: 0x0400BEF4 RID: 48884
		private Table __p;
	}
}
