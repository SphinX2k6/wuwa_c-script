using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053EC RID: 21484
	public struct IImmediateStartCondition : IFlatbufferObject
	{
		// Token: 0x17009E1F RID: 40479
		// (get) Token: 0x0602347D RID: 144509 RVA: 0x004E2965 File Offset: 0x004E0B65
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602347E RID: 144510 RVA: 0x004E2972 File Offset: 0x004E0B72
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602347F RID: 144511 RVA: 0x004E297C File Offset: 0x004E0B7C
		public static IImmediateStartCondition GetRootAsIImmediateStartCondition(ByteBuffer _bb)
		{
			return IImmediateStartCondition.GetRootAsIImmediateStartCondition(_bb, default(IImmediateStartCondition));
		}

		// Token: 0x06023480 RID: 144512 RVA: 0x004E2998 File Offset: 0x004E0B98
		public static IImmediateStartCondition GetRootAsIImmediateStartCondition(ByteBuffer _bb, IImmediateStartCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023481 RID: 144513 RVA: 0x004E29B5 File Offset: 0x004E0BB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023482 RID: 144514 RVA: 0x004E29C4 File Offset: 0x004E0BC4
		public IImmediateStartCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E20 RID: 40480
		// (get) Token: 0x06023483 RID: 144515 RVA: 0x004E29D4 File Offset: 0x004E0BD4
		public ESpawnMonsterStartCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpawnMonsterStartCondition.Immediate;
				}
				return (ESpawnMonsterStartCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023484 RID: 144516 RVA: 0x004E2A10 File Offset: 0x004E0C10
		public static Offset<IImmediateStartCondition> CreateIImmediateStartCondition(FlatBufferBuilder builder, ESpawnMonsterStartCondition Type = ESpawnMonsterStartCondition.Immediate)
		{
			builder.StartTable(1);
			IImmediateStartCondition.AddType(builder, Type);
			return IImmediateStartCondition.EndIImmediateStartCondition(builder);
		}

		// Token: 0x06023485 RID: 144517 RVA: 0x004E2A26 File Offset: 0x004E0C26
		public static void StartIImmediateStartCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06023486 RID: 144518 RVA: 0x004E2A2F File Offset: 0x004E0C2F
		public static void AddType(FlatBufferBuilder builder, ESpawnMonsterStartCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023487 RID: 144519 RVA: 0x004E2A3A File Offset: 0x004E0C3A
		public static Offset<IImmediateStartCondition> EndIImmediateStartCondition(FlatBufferBuilder builder)
		{
			return new Offset<IImmediateStartCondition>(builder.EndTable());
		}

		// Token: 0x06023488 RID: 144520 RVA: 0x004E2A48 File Offset: 0x004E0C48
		public IImmediateStartConditionT UnPack()
		{
			IImmediateStartConditionT immediateStartConditionT = new IImmediateStartConditionT();
			this.UnPackTo(immediateStartConditionT);
			return immediateStartConditionT;
		}

		// Token: 0x06023489 RID: 144521 RVA: 0x004E2A63 File Offset: 0x004E0C63
		public void UnPackTo(IImmediateStartConditionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602348A RID: 144522 RVA: 0x004E2A74 File Offset: 0x004E0C74
		public static Offset<IImmediateStartCondition> Pack(FlatBufferBuilder builder, IImmediateStartConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IImmediateStartCondition>);
			}
			return IImmediateStartCondition.CreateIImmediateStartCondition(builder, _o.Type);
		}

		// Token: 0x0400E62D RID: 58925
		private Table __p;
	}
}
