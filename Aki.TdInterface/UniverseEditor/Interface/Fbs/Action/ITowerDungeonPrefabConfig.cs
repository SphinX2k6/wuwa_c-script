using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C14 RID: 31764
	public struct ITowerDungeonPrefabConfig : IFlatbufferObject
	{
		// Token: 0x1700EDD5 RID: 60885
		// (get) Token: 0x060393F0 RID: 234480 RVA: 0x007BB6DC File Offset: 0x007B98DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060393F1 RID: 234481 RVA: 0x007BB6E9 File Offset: 0x007B98E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060393F2 RID: 234482 RVA: 0x007BB6F0 File Offset: 0x007B98F0
		public static ITowerDungeonPrefabConfig GetRootAsITowerDungeonPrefabConfig(ByteBuffer _bb)
		{
			return ITowerDungeonPrefabConfig.GetRootAsITowerDungeonPrefabConfig(_bb, default(ITowerDungeonPrefabConfig));
		}

		// Token: 0x060393F3 RID: 234483 RVA: 0x007BB70C File Offset: 0x007B990C
		public static ITowerDungeonPrefabConfig GetRootAsITowerDungeonPrefabConfig(ByteBuffer _bb, ITowerDungeonPrefabConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060393F4 RID: 234484 RVA: 0x007BB729 File Offset: 0x007B9929
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060393F5 RID: 234485 RVA: 0x007BB738 File Offset: 0x007B9938
		public ITowerDungeonPrefabConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EDD6 RID: 60886
		// (get) Token: 0x060393F6 RID: 234486 RVA: 0x007BB748 File Offset: 0x007B9948
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

		// Token: 0x1700EDD7 RID: 60887
		// (get) Token: 0x060393F7 RID: 234487 RVA: 0x007BB784 File Offset: 0x007B9984
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

		// Token: 0x060393F8 RID: 234488 RVA: 0x007BB7C0 File Offset: 0x007B99C0
		public static Offset<ITowerDungeonPrefabConfig> CreateITowerDungeonPrefabConfig(FlatBufferBuilder builder, ECreatePrefabType Type = ECreatePrefabType.PrefabId, int Index = 0)
		{
			builder.StartTable(2);
			ITowerDungeonPrefabConfig.AddIndex(builder, Index);
			ITowerDungeonPrefabConfig.AddType(builder, Type);
			return ITowerDungeonPrefabConfig.EndITowerDungeonPrefabConfig(builder);
		}

		// Token: 0x060393F9 RID: 234489 RVA: 0x007BB7DD File Offset: 0x007B99DD
		public static void StartITowerDungeonPrefabConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060393FA RID: 234490 RVA: 0x007BB7E6 File Offset: 0x007B99E6
		public static void AddType(FlatBufferBuilder builder, ECreatePrefabType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060393FB RID: 234491 RVA: 0x007BB7F1 File Offset: 0x007B99F1
		public static void AddIndex(FlatBufferBuilder builder, int index)
		{
			builder.AddInt(1, index, 0);
		}

		// Token: 0x060393FC RID: 234492 RVA: 0x007BB7FC File Offset: 0x007B99FC
		public static Offset<ITowerDungeonPrefabConfig> EndITowerDungeonPrefabConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITowerDungeonPrefabConfig>(builder.EndTable());
		}

		// Token: 0x060393FD RID: 234493 RVA: 0x007BB80C File Offset: 0x007B9A0C
		public ITowerDungeonPrefabConfigT UnPack()
		{
			ITowerDungeonPrefabConfigT towerDungeonPrefabConfigT = new ITowerDungeonPrefabConfigT();
			this.UnPackTo(towerDungeonPrefabConfigT);
			return towerDungeonPrefabConfigT;
		}

		// Token: 0x060393FE RID: 234494 RVA: 0x007BB827 File Offset: 0x007B9A27
		public void UnPackTo(ITowerDungeonPrefabConfigT _o)
		{
			_o.Type = this.Type;
			_o.Index = this.Index;
		}

		// Token: 0x060393FF RID: 234495 RVA: 0x007BB844 File Offset: 0x007B9A44
		public static Offset<ITowerDungeonPrefabConfig> Pack(FlatBufferBuilder builder, ITowerDungeonPrefabConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITowerDungeonPrefabConfig>);
			}
			return ITowerDungeonPrefabConfig.CreateITowerDungeonPrefabConfig(builder, _o.Type, _o.Index);
		}

		// Token: 0x040132BD RID: 78525
		private Table __p;
	}
}
