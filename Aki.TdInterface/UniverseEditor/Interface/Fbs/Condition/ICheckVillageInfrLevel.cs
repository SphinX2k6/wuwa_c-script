using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005058 RID: 20568
	public struct ICheckVillageInfrLevel : IFlatbufferObject
	{
		// Token: 0x17009338 RID: 37688
		// (get) Token: 0x06020279 RID: 131705 RVA: 0x00475A00 File Offset: 0x00473C00
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602027A RID: 131706 RVA: 0x00475A0D File Offset: 0x00473C0D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602027B RID: 131707 RVA: 0x00475A14 File Offset: 0x00473C14
		public static ICheckVillageInfrLevel GetRootAsICheckVillageInfrLevel(ByteBuffer _bb)
		{
			return ICheckVillageInfrLevel.GetRootAsICheckVillageInfrLevel(_bb, default(ICheckVillageInfrLevel));
		}

		// Token: 0x0602027C RID: 131708 RVA: 0x00475A30 File Offset: 0x00473C30
		public static ICheckVillageInfrLevel GetRootAsICheckVillageInfrLevel(ByteBuffer _bb, ICheckVillageInfrLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602027D RID: 131709 RVA: 0x00475A4D File Offset: 0x00473C4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602027E RID: 131710 RVA: 0x00475A5C File Offset: 0x00473C5C
		public ICheckVillageInfrLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009339 RID: 37689
		// (get) Token: 0x0602027F RID: 131711 RVA: 0x00475A6C File Offset: 0x00473C6C
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

		// Token: 0x1700933A RID: 37690
		// (get) Token: 0x06020280 RID: 131712 RVA: 0x00475AA8 File Offset: 0x00473CA8
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

		// Token: 0x06020281 RID: 131713 RVA: 0x00475AE4 File Offset: 0x00473CE4
		public static Offset<ICheckVillageInfrLevel> CreateICheckVillageInfrLevel(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding, int Level = 0)
		{
			builder.StartTable(2);
			ICheckVillageInfrLevel.AddLevel(builder, Level);
			ICheckVillageInfrLevel.AddType(builder, Type);
			return ICheckVillageInfrLevel.EndICheckVillageInfrLevel(builder);
		}

		// Token: 0x06020282 RID: 131714 RVA: 0x00475B01 File Offset: 0x00473D01
		public static void StartICheckVillageInfrLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020283 RID: 131715 RVA: 0x00475B0A File Offset: 0x00473D0A
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020284 RID: 131716 RVA: 0x00475B15 File Offset: 0x00473D15
		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(1, level, 0);
		}

		// Token: 0x06020285 RID: 131717 RVA: 0x00475B20 File Offset: 0x00473D20
		public static Offset<ICheckVillageInfrLevel> EndICheckVillageInfrLevel(FlatBufferBuilder builder)
		{
			return new Offset<ICheckVillageInfrLevel>(builder.EndTable());
		}

		// Token: 0x06020286 RID: 131718 RVA: 0x00475B30 File Offset: 0x00473D30
		public ICheckVillageInfrLevelT UnPack()
		{
			ICheckVillageInfrLevelT checkVillageInfrLevelT = new ICheckVillageInfrLevelT();
			this.UnPackTo(checkVillageInfrLevelT);
			return checkVillageInfrLevelT;
		}

		// Token: 0x06020287 RID: 131719 RVA: 0x00475B4B File Offset: 0x00473D4B
		public void UnPackTo(ICheckVillageInfrLevelT _o)
		{
			_o.Type = this.Type;
			_o.Level = this.Level;
		}

		// Token: 0x06020288 RID: 131720 RVA: 0x00475B68 File Offset: 0x00473D68
		public static Offset<ICheckVillageInfrLevel> Pack(FlatBufferBuilder builder, ICheckVillageInfrLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckVillageInfrLevel>);
			}
			return ICheckVillageInfrLevel.CreateICheckVillageInfrLevel(builder, _o.Type, _o.Level);
		}

		// Token: 0x0400DF3C RID: 57148
		private Table __p;
	}
}
