using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045BD RID: 17853
	public struct ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion : IFlatbufferObject
	{
		// Token: 0x17007EEC RID: 32492
		// (get) Token: 0x0601B00D RID: 110605 RVA: 0x003D99B8 File Offset: 0x003D7BB8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B00E RID: 110606 RVA: 0x003D99C5 File Offset: 0x003D7BC5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B00F RID: 110607 RVA: 0x003D99CC File Offset: 0x003D7BCC
		public static ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion GetRootAsITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion(ByteBuffer _bb)
		{
			return ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion.GetRootAsITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion(_bb, default(ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion));
		}

		// Token: 0x0601B010 RID: 110608 RVA: 0x003D99E8 File Offset: 0x003D7BE8
		public static ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion GetRootAsITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion(ByteBuffer _bb, ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B011 RID: 110609 RVA: 0x003D9A05 File Offset: 0x003D7C05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B012 RID: 110610 RVA: 0x003D9A14 File Offset: 0x003D7C14
		public ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007EED RID: 32493
		// (get) Token: 0x0601B013 RID: 110611 RVA: 0x003D9A24 File Offset: 0x003D7C24
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

		// Token: 0x0601B014 RID: 110612 RVA: 0x003D9A60 File Offset: 0x003D7C60
		public static Offset<ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion> CreateITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion(FlatBufferBuilder builder, ETrapDefenseSpawnMonsterCondition Type = ETrapDefenseSpawnMonsterCondition.Completed)
		{
			builder.StartTable(1);
			ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion.AddType(builder, Type);
			return ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion.EndITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion(builder);
		}

		// Token: 0x0601B015 RID: 110613 RVA: 0x003D9A76 File Offset: 0x003D7C76
		public static void StartITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B016 RID: 110614 RVA: 0x003D9A7F File Offset: 0x003D7C7F
		public static void AddType(FlatBufferBuilder builder, ETrapDefenseSpawnMonsterCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B017 RID: 110615 RVA: 0x003D9A8A File Offset: 0x003D7C8A
		public static Offset<ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion> EndITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion>(builder.EndTable());
		}

		// Token: 0x0601B018 RID: 110616 RVA: 0x003D9A98 File Offset: 0x003D7C98
		public ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletionT UnPack()
		{
			ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletionT trapDefenseSpawnMonsterConditionAllOpenedIsCompletionT = new ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletionT();
			this.UnPackTo(trapDefenseSpawnMonsterConditionAllOpenedIsCompletionT);
			return trapDefenseSpawnMonsterConditionAllOpenedIsCompletionT;
		}

		// Token: 0x0601B019 RID: 110617 RVA: 0x003D9AB3 File Offset: 0x003D7CB3
		public void UnPackTo(ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B01A RID: 110618 RVA: 0x003D9AC4 File Offset: 0x003D7CC4
		public static Offset<ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion> Pack(FlatBufferBuilder builder, ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion>);
			}
			return ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion.CreateITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion(builder, _o.Type);
		}

		// Token: 0x0400C68B RID: 50827
		private Table __p;
	}
}
