using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A71 RID: 27249
	public struct IClientSetSeasonStateConfig : IFlatbufferObject
	{
		// Token: 0x1700C828 RID: 51240
		// (get) Token: 0x0602EC0B RID: 191499 RVA: 0x0065F3B4 File Offset: 0x0065D5B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EC0C RID: 191500 RVA: 0x0065F3C1 File Offset: 0x0065D5C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EC0D RID: 191501 RVA: 0x0065F3C8 File Offset: 0x0065D5C8
		public static IClientSetSeasonStateConfig GetRootAsIClientSetSeasonStateConfig(ByteBuffer _bb)
		{
			return IClientSetSeasonStateConfig.GetRootAsIClientSetSeasonStateConfig(_bb, default(IClientSetSeasonStateConfig));
		}

		// Token: 0x0602EC0E RID: 191502 RVA: 0x0065F3E4 File Offset: 0x0065D5E4
		public static IClientSetSeasonStateConfig GetRootAsIClientSetSeasonStateConfig(ByteBuffer _bb, IClientSetSeasonStateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EC0F RID: 191503 RVA: 0x0065F401 File Offset: 0x0065D601
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EC10 RID: 191504 RVA: 0x0065F410 File Offset: 0x0065D610
		public IClientSetSeasonStateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C829 RID: 51241
		// (get) Token: 0x0602EC11 RID: 191505 RVA: 0x0065F420 File Offset: 0x0065D620
		public EClientSetSeasonStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientSetSeasonStateType.SwitchSeason;
				}
				return (EClientSetSeasonStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EC12 RID: 191506 RVA: 0x0065F45C File Offset: 0x0065D65C
		public static Offset<IClientSetSeasonStateConfig> CreateIClientSetSeasonStateConfig(FlatBufferBuilder builder, EClientSetSeasonStateType Type = EClientSetSeasonStateType.SwitchSeason)
		{
			builder.StartTable(1);
			IClientSetSeasonStateConfig.AddType(builder, Type);
			return IClientSetSeasonStateConfig.EndIClientSetSeasonStateConfig(builder);
		}

		// Token: 0x0602EC13 RID: 191507 RVA: 0x0065F472 File Offset: 0x0065D672
		public static void StartIClientSetSeasonStateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602EC14 RID: 191508 RVA: 0x0065F47B File Offset: 0x0065D67B
		public static void AddType(FlatBufferBuilder builder, EClientSetSeasonStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EC15 RID: 191509 RVA: 0x0065F486 File Offset: 0x0065D686
		public static Offset<IClientSetSeasonStateConfig> EndIClientSetSeasonStateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IClientSetSeasonStateConfig>(builder.EndTable());
		}

		// Token: 0x0602EC16 RID: 191510 RVA: 0x0065F494 File Offset: 0x0065D694
		public IClientSetSeasonStateConfigT UnPack()
		{
			IClientSetSeasonStateConfigT clientSetSeasonStateConfigT = new IClientSetSeasonStateConfigT();
			this.UnPackTo(clientSetSeasonStateConfigT);
			return clientSetSeasonStateConfigT;
		}

		// Token: 0x0602EC17 RID: 191511 RVA: 0x0065F4AF File Offset: 0x0065D6AF
		public void UnPackTo(IClientSetSeasonStateConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602EC18 RID: 191512 RVA: 0x0065F4C0 File Offset: 0x0065D6C0
		public static Offset<IClientSetSeasonStateConfig> Pack(FlatBufferBuilder builder, IClientSetSeasonStateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientSetSeasonStateConfig>);
			}
			return IClientSetSeasonStateConfig.CreateIClientSetSeasonStateConfig(builder, _o.Type);
		}

		// Token: 0x040117FC RID: 71676
		private Table __p;
	}
}
