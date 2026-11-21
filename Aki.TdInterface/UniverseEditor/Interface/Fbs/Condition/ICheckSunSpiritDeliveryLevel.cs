using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200501C RID: 20508
	public struct ICheckSunSpiritDeliveryLevel : IFlatbufferObject
	{
		// Token: 0x170092BC RID: 37564
		// (get) Token: 0x06020049 RID: 131145 RVA: 0x0047154D File Offset: 0x0046F74D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602004A RID: 131146 RVA: 0x0047155A File Offset: 0x0046F75A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602004B RID: 131147 RVA: 0x00471564 File Offset: 0x0046F764
		public static ICheckSunSpiritDeliveryLevel GetRootAsICheckSunSpiritDeliveryLevel(ByteBuffer _bb)
		{
			return ICheckSunSpiritDeliveryLevel.GetRootAsICheckSunSpiritDeliveryLevel(_bb, default(ICheckSunSpiritDeliveryLevel));
		}

		// Token: 0x0602004C RID: 131148 RVA: 0x00471580 File Offset: 0x0046F780
		public static ICheckSunSpiritDeliveryLevel GetRootAsICheckSunSpiritDeliveryLevel(ByteBuffer _bb, ICheckSunSpiritDeliveryLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602004D RID: 131149 RVA: 0x0047159D File Offset: 0x0046F79D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602004E RID: 131150 RVA: 0x004715AC File Offset: 0x0046F7AC
		public ICheckSunSpiritDeliveryLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170092BD RID: 37565
		// (get) Token: 0x0602004F RID: 131151 RVA: 0x004715BC File Offset: 0x0046F7BC
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

		// Token: 0x170092BE RID: 37566
		// (get) Token: 0x06020050 RID: 131152 RVA: 0x004715F8 File Offset: 0x0046F7F8
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

		// Token: 0x06020051 RID: 131153 RVA: 0x00471634 File Offset: 0x0046F834
		public static Offset<ICheckSunSpiritDeliveryLevel> CreateICheckSunSpiritDeliveryLevel(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding, int Level = 0)
		{
			builder.StartTable(2);
			ICheckSunSpiritDeliveryLevel.AddLevel(builder, Level);
			ICheckSunSpiritDeliveryLevel.AddType(builder, Type);
			return ICheckSunSpiritDeliveryLevel.EndICheckSunSpiritDeliveryLevel(builder);
		}

		// Token: 0x06020052 RID: 131154 RVA: 0x00471651 File Offset: 0x0046F851
		public static void StartICheckSunSpiritDeliveryLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020053 RID: 131155 RVA: 0x0047165A File Offset: 0x0046F85A
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020054 RID: 131156 RVA: 0x00471665 File Offset: 0x0046F865
		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(1, level, 0);
		}

		// Token: 0x06020055 RID: 131157 RVA: 0x00471670 File Offset: 0x0046F870
		public static Offset<ICheckSunSpiritDeliveryLevel> EndICheckSunSpiritDeliveryLevel(FlatBufferBuilder builder)
		{
			return new Offset<ICheckSunSpiritDeliveryLevel>(builder.EndTable());
		}

		// Token: 0x06020056 RID: 131158 RVA: 0x00471680 File Offset: 0x0046F880
		public ICheckSunSpiritDeliveryLevelT UnPack()
		{
			ICheckSunSpiritDeliveryLevelT checkSunSpiritDeliveryLevelT = new ICheckSunSpiritDeliveryLevelT();
			this.UnPackTo(checkSunSpiritDeliveryLevelT);
			return checkSunSpiritDeliveryLevelT;
		}

		// Token: 0x06020057 RID: 131159 RVA: 0x0047169B File Offset: 0x0046F89B
		public void UnPackTo(ICheckSunSpiritDeliveryLevelT _o)
		{
			_o.Type = this.Type;
			_o.Level = this.Level;
		}

		// Token: 0x06020058 RID: 131160 RVA: 0x004716B8 File Offset: 0x0046F8B8
		public static Offset<ICheckSunSpiritDeliveryLevel> Pack(FlatBufferBuilder builder, ICheckSunSpiritDeliveryLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckSunSpiritDeliveryLevel>);
			}
			return ICheckSunSpiritDeliveryLevel.CreateICheckSunSpiritDeliveryLevel(builder, _o.Type, _o.Level);
		}

		// Token: 0x0400DEDA RID: 57050
		private Table __p;
	}
}
