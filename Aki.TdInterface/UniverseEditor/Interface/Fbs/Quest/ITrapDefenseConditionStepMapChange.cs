using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200422C RID: 16940
	public struct ITrapDefenseConditionStepMapChange : IFlatbufferObject
	{
		// Token: 0x1700784F RID: 30799
		// (get) Token: 0x060190B6 RID: 102582 RVA: 0x0039A6C9 File Offset: 0x003988C9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060190B7 RID: 102583 RVA: 0x0039A6D6 File Offset: 0x003988D6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060190B8 RID: 102584 RVA: 0x0039A6E0 File Offset: 0x003988E0
		public static ITrapDefenseConditionStepMapChange GetRootAsITrapDefenseConditionStepMapChange(ByteBuffer _bb)
		{
			return ITrapDefenseConditionStepMapChange.GetRootAsITrapDefenseConditionStepMapChange(_bb, default(ITrapDefenseConditionStepMapChange));
		}

		// Token: 0x060190B9 RID: 102585 RVA: 0x0039A6FC File Offset: 0x003988FC
		public static ITrapDefenseConditionStepMapChange GetRootAsITrapDefenseConditionStepMapChange(ByteBuffer _bb, ITrapDefenseConditionStepMapChange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060190BA RID: 102586 RVA: 0x0039A719 File Offset: 0x00398919
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060190BB RID: 102587 RVA: 0x0039A728 File Offset: 0x00398928
		public ITrapDefenseConditionStepMapChange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007850 RID: 30800
		// (get) Token: 0x060190BC RID: 102588 RVA: 0x0039A738 File Offset: 0x00398938
		public ETrapDefenseConditionStep Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrapDefenseConditionStep.Reward;
				}
				return (ETrapDefenseConditionStep)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060190BD RID: 102589 RVA: 0x0039A774 File Offset: 0x00398974
		public static Offset<ITrapDefenseConditionStepMapChange> CreateITrapDefenseConditionStepMapChange(FlatBufferBuilder builder, ETrapDefenseConditionStep Type = ETrapDefenseConditionStep.Reward)
		{
			builder.StartTable(1);
			ITrapDefenseConditionStepMapChange.AddType(builder, Type);
			return ITrapDefenseConditionStepMapChange.EndITrapDefenseConditionStepMapChange(builder);
		}

		// Token: 0x060190BE RID: 102590 RVA: 0x0039A78A File Offset: 0x0039898A
		public static void StartITrapDefenseConditionStepMapChange(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060190BF RID: 102591 RVA: 0x0039A793 File Offset: 0x00398993
		public static void AddType(FlatBufferBuilder builder, ETrapDefenseConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060190C0 RID: 102592 RVA: 0x0039A79E File Offset: 0x0039899E
		public static Offset<ITrapDefenseConditionStepMapChange> EndITrapDefenseConditionStepMapChange(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseConditionStepMapChange>(builder.EndTable());
		}

		// Token: 0x060190C1 RID: 102593 RVA: 0x0039A7AC File Offset: 0x003989AC
		public ITrapDefenseConditionStepMapChangeT UnPack()
		{
			ITrapDefenseConditionStepMapChangeT trapDefenseConditionStepMapChangeT = new ITrapDefenseConditionStepMapChangeT();
			this.UnPackTo(trapDefenseConditionStepMapChangeT);
			return trapDefenseConditionStepMapChangeT;
		}

		// Token: 0x060190C2 RID: 102594 RVA: 0x0039A7C7 File Offset: 0x003989C7
		public void UnPackTo(ITrapDefenseConditionStepMapChangeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060190C3 RID: 102595 RVA: 0x0039A7D8 File Offset: 0x003989D8
		public static Offset<ITrapDefenseConditionStepMapChange> Pack(FlatBufferBuilder builder, ITrapDefenseConditionStepMapChangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseConditionStepMapChange>);
			}
			return ITrapDefenseConditionStepMapChange.CreateITrapDefenseConditionStepMapChange(builder, _o.Type);
		}

		// Token: 0x0400BEB2 RID: 48818
		private Table __p;
	}
}
