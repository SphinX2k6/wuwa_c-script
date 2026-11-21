using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A28 RID: 18984
	public struct ITrapDefenseSpawnMonsterConditionBase : IFlatbufferObject
	{
		// Token: 0x17008530 RID: 34096
		// (get) Token: 0x0601C7F4 RID: 116724 RVA: 0x00405DC9 File Offset: 0x00403FC9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C7F5 RID: 116725 RVA: 0x00405DD6 File Offset: 0x00403FD6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C7F6 RID: 116726 RVA: 0x00405DE0 File Offset: 0x00403FE0
		public static ITrapDefenseSpawnMonsterConditionBase GetRootAsITrapDefenseSpawnMonsterConditionBase(ByteBuffer _bb)
		{
			return ITrapDefenseSpawnMonsterConditionBase.GetRootAsITrapDefenseSpawnMonsterConditionBase(_bb, default(ITrapDefenseSpawnMonsterConditionBase));
		}

		// Token: 0x0601C7F7 RID: 116727 RVA: 0x00405DFC File Offset: 0x00403FFC
		public static ITrapDefenseSpawnMonsterConditionBase GetRootAsITrapDefenseSpawnMonsterConditionBase(ByteBuffer _bb, ITrapDefenseSpawnMonsterConditionBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C7F8 RID: 116728 RVA: 0x00405E19 File Offset: 0x00404019
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C7F9 RID: 116729 RVA: 0x00405E28 File Offset: 0x00404028
		public ITrapDefenseSpawnMonsterConditionBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008531 RID: 34097
		// (get) Token: 0x0601C7FA RID: 116730 RVA: 0x00405E38 File Offset: 0x00404038
		public ETrapDefenseSpawnMonsterCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrapDefenseSpawnMonsterCondition.Completed;
				}
				return (ETrapDefenseSpawnMonsterCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C7FB RID: 116731 RVA: 0x00405E74 File Offset: 0x00404074
		public static Offset<ITrapDefenseSpawnMonsterConditionBase> CreateITrapDefenseSpawnMonsterConditionBase(FlatBufferBuilder builder, ETrapDefenseSpawnMonsterCondition Type = ETrapDefenseSpawnMonsterCondition.Completed)
		{
			builder.StartTable(1);
			ITrapDefenseSpawnMonsterConditionBase.AddType(builder, Type);
			return ITrapDefenseSpawnMonsterConditionBase.EndITrapDefenseSpawnMonsterConditionBase(builder);
		}

		// Token: 0x0601C7FC RID: 116732 RVA: 0x00405E8A File Offset: 0x0040408A
		public static void StartITrapDefenseSpawnMonsterConditionBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601C7FD RID: 116733 RVA: 0x00405E93 File Offset: 0x00404093
		public static void AddType(FlatBufferBuilder builder, ETrapDefenseSpawnMonsterCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C7FE RID: 116734 RVA: 0x00405E9E File Offset: 0x0040409E
		public static Offset<ITrapDefenseSpawnMonsterConditionBase> EndITrapDefenseSpawnMonsterConditionBase(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseSpawnMonsterConditionBase>(builder.EndTable());
		}

		// Token: 0x0601C7FF RID: 116735 RVA: 0x00405EAC File Offset: 0x004040AC
		public ITrapDefenseSpawnMonsterConditionBaseT UnPack()
		{
			ITrapDefenseSpawnMonsterConditionBaseT trapDefenseSpawnMonsterConditionBaseT = new ITrapDefenseSpawnMonsterConditionBaseT();
			this.UnPackTo(trapDefenseSpawnMonsterConditionBaseT);
			return trapDefenseSpawnMonsterConditionBaseT;
		}

		// Token: 0x0601C800 RID: 116736 RVA: 0x00405EC7 File Offset: 0x004040C7
		public void UnPackTo(ITrapDefenseSpawnMonsterConditionBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601C801 RID: 116737 RVA: 0x00405ED8 File Offset: 0x004040D8
		public static Offset<ITrapDefenseSpawnMonsterConditionBase> Pack(FlatBufferBuilder builder, ITrapDefenseSpawnMonsterConditionBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseSpawnMonsterConditionBase>);
			}
			return ITrapDefenseSpawnMonsterConditionBase.CreateITrapDefenseSpawnMonsterConditionBase(builder, _o.Type);
		}

		// Token: 0x0400D0BC RID: 53436
		private Table __p;
	}
}
