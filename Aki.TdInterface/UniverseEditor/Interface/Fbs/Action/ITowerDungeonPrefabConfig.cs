using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007421 RID: 29729
	public struct ITowerDungeonPrefabConfig : IFlatbufferObject
	{
		// Token: 0x1700E1B8 RID: 57784
		// (get) Token: 0x06036007 RID: 221191 RVA: 0x007589B0 File Offset: 0x00756BB0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036008 RID: 221192 RVA: 0x007589BD File Offset: 0x00756BBD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036009 RID: 221193 RVA: 0x007589C4 File Offset: 0x00756BC4
		public static ITowerDungeonPrefabConfig GetRootAsITowerDungeonPrefabConfig(ByteBuffer _bb)
		{
			return ITowerDungeonPrefabConfig.GetRootAsITowerDungeonPrefabConfig(_bb, default(ITowerDungeonPrefabConfig));
		}

		// Token: 0x0603600A RID: 221194 RVA: 0x007589E0 File Offset: 0x00756BE0
		public static ITowerDungeonPrefabConfig GetRootAsITowerDungeonPrefabConfig(ByteBuffer _bb, ITowerDungeonPrefabConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603600B RID: 221195 RVA: 0x007589FD File Offset: 0x00756BFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603600C RID: 221196 RVA: 0x00758A0C File Offset: 0x00756C0C
		public ITowerDungeonPrefabConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E1B9 RID: 57785
		// (get) Token: 0x0603600D RID: 221197 RVA: 0x00758A1C File Offset: 0x00756C1C
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

		// Token: 0x1700E1BA RID: 57786
		// (get) Token: 0x0603600E RID: 221198 RVA: 0x00758A58 File Offset: 0x00756C58
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

		// Token: 0x0603600F RID: 221199 RVA: 0x00758A94 File Offset: 0x00756C94
		public static Offset<ITowerDungeonPrefabConfig> CreateITowerDungeonPrefabConfig(FlatBufferBuilder builder, ECreatePrefabType Type = ECreatePrefabType.PrefabId, int Index = 0)
		{
			builder.StartTable(2);
			ITowerDungeonPrefabConfig.AddIndex(builder, Index);
			ITowerDungeonPrefabConfig.AddType(builder, Type);
			return ITowerDungeonPrefabConfig.EndITowerDungeonPrefabConfig(builder);
		}

		// Token: 0x06036010 RID: 221200 RVA: 0x00758AB1 File Offset: 0x00756CB1
		public static void StartITowerDungeonPrefabConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036011 RID: 221201 RVA: 0x00758ABA File Offset: 0x00756CBA
		public static void AddType(FlatBufferBuilder builder, ECreatePrefabType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036012 RID: 221202 RVA: 0x00758AC5 File Offset: 0x00756CC5
		public static void AddIndex(FlatBufferBuilder builder, int index)
		{
			builder.AddInt(1, index, 0);
		}

		// Token: 0x06036013 RID: 221203 RVA: 0x00758AD0 File Offset: 0x00756CD0
		public static Offset<ITowerDungeonPrefabConfig> EndITowerDungeonPrefabConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITowerDungeonPrefabConfig>(builder.EndTable());
		}

		// Token: 0x06036014 RID: 221204 RVA: 0x00758AE0 File Offset: 0x00756CE0
		public ITowerDungeonPrefabConfigT UnPack()
		{
			ITowerDungeonPrefabConfigT towerDungeonPrefabConfigT = new ITowerDungeonPrefabConfigT();
			this.UnPackTo(towerDungeonPrefabConfigT);
			return towerDungeonPrefabConfigT;
		}

		// Token: 0x06036015 RID: 221205 RVA: 0x00758AFB File Offset: 0x00756CFB
		public void UnPackTo(ITowerDungeonPrefabConfigT _o)
		{
			_o.Type = this.Type;
			_o.Index = this.Index;
		}

		// Token: 0x06036016 RID: 221206 RVA: 0x00758B18 File Offset: 0x00756D18
		public static Offset<ITowerDungeonPrefabConfig> Pack(FlatBufferBuilder builder, ITowerDungeonPrefabConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITowerDungeonPrefabConfig>);
			}
			return ITowerDungeonPrefabConfig.CreateITowerDungeonPrefabConfig(builder, _o.Type, _o.Index);
		}

		// Token: 0x04012296 RID: 74390
		private Table __p;
	}
}
