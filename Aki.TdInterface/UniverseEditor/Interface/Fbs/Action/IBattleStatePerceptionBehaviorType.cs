using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061F7 RID: 25079
	public struct IBattleStatePerceptionBehaviorType : IFlatbufferObject
	{
		// Token: 0x1700BAF2 RID: 47858
		// (get) Token: 0x0602B39F RID: 177055 RVA: 0x005F4B99 File Offset: 0x005F2D99
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B3A0 RID: 177056 RVA: 0x005F4BA6 File Offset: 0x005F2DA6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B3A1 RID: 177057 RVA: 0x005F4BB0 File Offset: 0x005F2DB0
		public static IBattleStatePerceptionBehaviorType GetRootAsIBattleStatePerceptionBehaviorType(ByteBuffer _bb)
		{
			return IBattleStatePerceptionBehaviorType.GetRootAsIBattleStatePerceptionBehaviorType(_bb, default(IBattleStatePerceptionBehaviorType));
		}

		// Token: 0x0602B3A2 RID: 177058 RVA: 0x005F4BCC File Offset: 0x005F2DCC
		public static IBattleStatePerceptionBehaviorType GetRootAsIBattleStatePerceptionBehaviorType(ByteBuffer _bb, IBattleStatePerceptionBehaviorType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B3A3 RID: 177059 RVA: 0x005F4BE9 File Offset: 0x005F2DE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B3A4 RID: 177060 RVA: 0x005F4BF8 File Offset: 0x005F2DF8
		public IBattleStatePerceptionBehaviorType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BAF3 RID: 47859
		// (get) Token: 0x0602B3A5 RID: 177061 RVA: 0x005F4C08 File Offset: 0x005F2E08
		public EBattleStatePerceptionBehavior Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBattleStatePerceptionBehavior.NotifyGatherToPlayer;
				}
				return (EBattleStatePerceptionBehavior)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B3A6 RID: 177062 RVA: 0x005F4C44 File Offset: 0x005F2E44
		public static Offset<IBattleStatePerceptionBehaviorType> CreateIBattleStatePerceptionBehaviorType(FlatBufferBuilder builder, EBattleStatePerceptionBehavior Type = EBattleStatePerceptionBehavior.NotifyGatherToPlayer)
		{
			builder.StartTable(1);
			IBattleStatePerceptionBehaviorType.AddType(builder, Type);
			return IBattleStatePerceptionBehaviorType.EndIBattleStatePerceptionBehaviorType(builder);
		}

		// Token: 0x0602B3A7 RID: 177063 RVA: 0x005F4C5A File Offset: 0x005F2E5A
		public static void StartIBattleStatePerceptionBehaviorType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B3A8 RID: 177064 RVA: 0x005F4C63 File Offset: 0x005F2E63
		public static void AddType(FlatBufferBuilder builder, EBattleStatePerceptionBehavior type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B3A9 RID: 177065 RVA: 0x005F4C6E File Offset: 0x005F2E6E
		public static Offset<IBattleStatePerceptionBehaviorType> EndIBattleStatePerceptionBehaviorType(FlatBufferBuilder builder)
		{
			return new Offset<IBattleStatePerceptionBehaviorType>(builder.EndTable());
		}

		// Token: 0x0602B3AA RID: 177066 RVA: 0x005F4C7C File Offset: 0x005F2E7C
		public IBattleStatePerceptionBehaviorTypeT UnPack()
		{
			IBattleStatePerceptionBehaviorTypeT battleStatePerceptionBehaviorTypeT = new IBattleStatePerceptionBehaviorTypeT();
			this.UnPackTo(battleStatePerceptionBehaviorTypeT);
			return battleStatePerceptionBehaviorTypeT;
		}

		// Token: 0x0602B3AB RID: 177067 RVA: 0x005F4C97 File Offset: 0x005F2E97
		public void UnPackTo(IBattleStatePerceptionBehaviorTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B3AC RID: 177068 RVA: 0x005F4CA8 File Offset: 0x005F2EA8
		public static Offset<IBattleStatePerceptionBehaviorType> Pack(FlatBufferBuilder builder, IBattleStatePerceptionBehaviorTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBattleStatePerceptionBehaviorType>);
			}
			return IBattleStatePerceptionBehaviorType.CreateIBattleStatePerceptionBehaviorType(builder, _o.Type);
		}

		// Token: 0x04010729 RID: 67369
		private Table __p;
	}
}
