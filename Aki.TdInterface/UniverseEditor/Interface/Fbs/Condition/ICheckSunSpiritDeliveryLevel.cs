using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B35 RID: 19253
	public struct ICheckSunSpiritDeliveryLevel : IFlatbufferObject
	{
		// Token: 0x17008BAC RID: 35756
		// (get) Token: 0x0601E4BE RID: 124094 RVA: 0x0043EDA1 File Offset: 0x0043CFA1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E4BF RID: 124095 RVA: 0x0043EDAE File Offset: 0x0043CFAE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E4C0 RID: 124096 RVA: 0x0043EDB8 File Offset: 0x0043CFB8
		public static ICheckSunSpiritDeliveryLevel GetRootAsICheckSunSpiritDeliveryLevel(ByteBuffer _bb)
		{
			return ICheckSunSpiritDeliveryLevel.GetRootAsICheckSunSpiritDeliveryLevel(_bb, default(ICheckSunSpiritDeliveryLevel));
		}

		// Token: 0x0601E4C1 RID: 124097 RVA: 0x0043EDD4 File Offset: 0x0043CFD4
		public static ICheckSunSpiritDeliveryLevel GetRootAsICheckSunSpiritDeliveryLevel(ByteBuffer _bb, ICheckSunSpiritDeliveryLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E4C2 RID: 124098 RVA: 0x0043EDF1 File Offset: 0x0043CFF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E4C3 RID: 124099 RVA: 0x0043EE00 File Offset: 0x0043D000
		public ICheckSunSpiritDeliveryLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008BAD RID: 35757
		// (get) Token: 0x0601E4C4 RID: 124100 RVA: 0x0043EE10 File Offset: 0x0043D010
		public ECheckSystemStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckSystemStateType.TrackMoonBuilding;
				}
				return (ECheckSystemStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008BAE RID: 35758
		// (get) Token: 0x0601E4C5 RID: 124101 RVA: 0x0043EE4C File Offset: 0x0043D04C
		public int Level
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

		// Token: 0x0601E4C6 RID: 124102 RVA: 0x0043EE88 File Offset: 0x0043D088
		public static Offset<ICheckSunSpiritDeliveryLevel> CreateICheckSunSpiritDeliveryLevel(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding, int Level = 0)
		{
			builder.StartTable(2);
			ICheckSunSpiritDeliveryLevel.AddLevel(builder, Level);
			ICheckSunSpiritDeliveryLevel.AddType(builder, Type);
			return ICheckSunSpiritDeliveryLevel.EndICheckSunSpiritDeliveryLevel(builder);
		}

		// Token: 0x0601E4C7 RID: 124103 RVA: 0x0043EEA5 File Offset: 0x0043D0A5
		public static void StartICheckSunSpiritDeliveryLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E4C8 RID: 124104 RVA: 0x0043EEAE File Offset: 0x0043D0AE
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E4C9 RID: 124105 RVA: 0x0043EEB9 File Offset: 0x0043D0B9
		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(1, level, 0);
		}

		// Token: 0x0601E4CA RID: 124106 RVA: 0x0043EEC4 File Offset: 0x0043D0C4
		public static Offset<ICheckSunSpiritDeliveryLevel> EndICheckSunSpiritDeliveryLevel(FlatBufferBuilder builder)
		{
			return new Offset<ICheckSunSpiritDeliveryLevel>(builder.EndTable());
		}

		// Token: 0x0601E4CB RID: 124107 RVA: 0x0043EED4 File Offset: 0x0043D0D4
		public ICheckSunSpiritDeliveryLevelT UnPack()
		{
			ICheckSunSpiritDeliveryLevelT checkSunSpiritDeliveryLevelT = new ICheckSunSpiritDeliveryLevelT();
			this.UnPackTo(checkSunSpiritDeliveryLevelT);
			return checkSunSpiritDeliveryLevelT;
		}

		// Token: 0x0601E4CC RID: 124108 RVA: 0x0043EEEF File Offset: 0x0043D0EF
		public void UnPackTo(ICheckSunSpiritDeliveryLevelT _o)
		{
			_o.Type = this.Type;
			_o.Level = this.Level;
		}

		// Token: 0x0601E4CD RID: 124109 RVA: 0x0043EF0C File Offset: 0x0043D10C
		public static Offset<ICheckSunSpiritDeliveryLevel> Pack(FlatBufferBuilder builder, ICheckSunSpiritDeliveryLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckSunSpiritDeliveryLevel>);
			}
			return ICheckSunSpiritDeliveryLevel.CreateICheckSunSpiritDeliveryLevel(builder, _o.Type, _o.Level);
		}

		// Token: 0x0400D3DB RID: 54235
		private Table __p;
	}
}
