using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007908 RID: 30984
	public struct ISlashTowerPrefabConfig : IFlatbufferObject
	{
		// Token: 0x1700E349 RID: 58185
		// (get) Token: 0x060368DC RID: 223452 RVA: 0x0074D57D File Offset: 0x0074B77D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060368DD RID: 223453 RVA: 0x0074D58A File Offset: 0x0074B78A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060368DE RID: 223454 RVA: 0x0074D594 File Offset: 0x0074B794
		public static ISlashTowerPrefabConfig GetRootAsISlashTowerPrefabConfig(ByteBuffer _bb)
		{
			return ISlashTowerPrefabConfig.GetRootAsISlashTowerPrefabConfig(_bb, default(ISlashTowerPrefabConfig));
		}

		// Token: 0x060368DF RID: 223455 RVA: 0x0074D5B0 File Offset: 0x0074B7B0
		public static ISlashTowerPrefabConfig GetRootAsISlashTowerPrefabConfig(ByteBuffer _bb, ISlashTowerPrefabConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060368E0 RID: 223456 RVA: 0x0074D5CD File Offset: 0x0074B7CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060368E1 RID: 223457 RVA: 0x0074D5DC File Offset: 0x0074B7DC
		public ISlashTowerPrefabConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E34A RID: 58186
		// (get) Token: 0x060368E2 RID: 223458 RVA: 0x0074D5EC File Offset: 0x0074B7EC
		public ECreatePrefabType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECreatePrefabType.PrefabId;
				}
				return (ECreatePrefabType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E34B RID: 58187
		// (get) Token: 0x060368E3 RID: 223459 RVA: 0x0074D628 File Offset: 0x0074B828
		public int Index
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

		// Token: 0x060368E4 RID: 223460 RVA: 0x0074D664 File Offset: 0x0074B864
		public static Offset<ISlashTowerPrefabConfig> CreateISlashTowerPrefabConfig(FlatBufferBuilder builder, ECreatePrefabType Type = ECreatePrefabType.PrefabId, int Index = 0)
		{
			builder.StartTable(2);
			ISlashTowerPrefabConfig.AddIndex(builder, Index);
			ISlashTowerPrefabConfig.AddType(builder, Type);
			return ISlashTowerPrefabConfig.EndISlashTowerPrefabConfig(builder);
		}

		// Token: 0x060368E5 RID: 223461 RVA: 0x0074D681 File Offset: 0x0074B881
		public static void StartISlashTowerPrefabConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060368E6 RID: 223462 RVA: 0x0074D68A File Offset: 0x0074B88A
		public static void AddType(FlatBufferBuilder builder, ECreatePrefabType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060368E7 RID: 223463 RVA: 0x0074D695 File Offset: 0x0074B895
		public static void AddIndex(FlatBufferBuilder builder, int index)
		{
			builder.AddInt(1, index, 0);
		}

		// Token: 0x060368E8 RID: 223464 RVA: 0x0074D6A0 File Offset: 0x0074B8A0
		public static Offset<ISlashTowerPrefabConfig> EndISlashTowerPrefabConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISlashTowerPrefabConfig>(builder.EndTable());
		}

		// Token: 0x060368E9 RID: 223465 RVA: 0x0074D6B0 File Offset: 0x0074B8B0
		public ISlashTowerPrefabConfigT UnPack()
		{
			ISlashTowerPrefabConfigT slashTowerPrefabConfigT = new ISlashTowerPrefabConfigT();
			this.UnPackTo(slashTowerPrefabConfigT);
			return slashTowerPrefabConfigT;
		}

		// Token: 0x060368EA RID: 223466 RVA: 0x0074D6CB File Offset: 0x0074B8CB
		public void UnPackTo(ISlashTowerPrefabConfigT _o)
		{
			_o.Type = this.Type;
			_o.Index = this.Index;
		}

		// Token: 0x060368EB RID: 223467 RVA: 0x0074D6E8 File Offset: 0x0074B8E8
		public static Offset<ISlashTowerPrefabConfig> Pack(FlatBufferBuilder builder, ISlashTowerPrefabConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISlashTowerPrefabConfig>);
			}
			return ISlashTowerPrefabConfig.CreateISlashTowerPrefabConfig(builder, _o.Type, _o.Index);
		}

		// Token: 0x04012BC5 RID: 76741
		private Table __p;
	}
}
