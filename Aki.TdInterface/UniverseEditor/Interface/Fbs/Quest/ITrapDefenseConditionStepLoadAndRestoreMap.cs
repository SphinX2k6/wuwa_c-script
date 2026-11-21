using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004685 RID: 18053
	public struct ITrapDefenseConditionStepLoadAndRestoreMap : IFlatbufferObject
	{
		// Token: 0x17007E7D RID: 32381
		// (get) Token: 0x0601A810 RID: 108560 RVA: 0x003C5C2A File Offset: 0x003C3E2A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A811 RID: 108561 RVA: 0x003C5C37 File Offset: 0x003C3E37
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A812 RID: 108562 RVA: 0x003C5C40 File Offset: 0x003C3E40
		public static ITrapDefenseConditionStepLoadAndRestoreMap GetRootAsITrapDefenseConditionStepLoadAndRestoreMap(ByteBuffer _bb)
		{
			return ITrapDefenseConditionStepLoadAndRestoreMap.GetRootAsITrapDefenseConditionStepLoadAndRestoreMap(_bb, default(ITrapDefenseConditionStepLoadAndRestoreMap));
		}

		// Token: 0x0601A813 RID: 108563 RVA: 0x003C5C5C File Offset: 0x003C3E5C
		public static ITrapDefenseConditionStepLoadAndRestoreMap GetRootAsITrapDefenseConditionStepLoadAndRestoreMap(ByteBuffer _bb, ITrapDefenseConditionStepLoadAndRestoreMap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A814 RID: 108564 RVA: 0x003C5C79 File Offset: 0x003C3E79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A815 RID: 108565 RVA: 0x003C5C88 File Offset: 0x003C3E88
		public ITrapDefenseConditionStepLoadAndRestoreMap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E7E RID: 32382
		// (get) Token: 0x0601A816 RID: 108566 RVA: 0x003C5C98 File Offset: 0x003C3E98
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

		// Token: 0x0601A817 RID: 108567 RVA: 0x003C5CD4 File Offset: 0x003C3ED4
		public static Offset<ITrapDefenseConditionStepLoadAndRestoreMap> CreateITrapDefenseConditionStepLoadAndRestoreMap(FlatBufferBuilder builder, ETrapDefenseConditionStep Type = ETrapDefenseConditionStep.Reward)
		{
			builder.StartTable(1);
			ITrapDefenseConditionStepLoadAndRestoreMap.AddType(builder, Type);
			return ITrapDefenseConditionStepLoadAndRestoreMap.EndITrapDefenseConditionStepLoadAndRestoreMap(builder);
		}

		// Token: 0x0601A818 RID: 108568 RVA: 0x003C5CEA File Offset: 0x003C3EEA
		public static void StartITrapDefenseConditionStepLoadAndRestoreMap(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A819 RID: 108569 RVA: 0x003C5CF3 File Offset: 0x003C3EF3
		public static void AddType(FlatBufferBuilder builder, ETrapDefenseConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A81A RID: 108570 RVA: 0x003C5CFE File Offset: 0x003C3EFE
		public static Offset<ITrapDefenseConditionStepLoadAndRestoreMap> EndITrapDefenseConditionStepLoadAndRestoreMap(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseConditionStepLoadAndRestoreMap>(builder.EndTable());
		}

		// Token: 0x0601A81B RID: 108571 RVA: 0x003C5D0C File Offset: 0x003C3F0C
		public ITrapDefenseConditionStepLoadAndRestoreMapT UnPack()
		{
			ITrapDefenseConditionStepLoadAndRestoreMapT trapDefenseConditionStepLoadAndRestoreMapT = new ITrapDefenseConditionStepLoadAndRestoreMapT();
			this.UnPackTo(trapDefenseConditionStepLoadAndRestoreMapT);
			return trapDefenseConditionStepLoadAndRestoreMapT;
		}

		// Token: 0x0601A81C RID: 108572 RVA: 0x003C5D27 File Offset: 0x003C3F27
		public void UnPackTo(ITrapDefenseConditionStepLoadAndRestoreMapT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601A81D RID: 108573 RVA: 0x003C5D38 File Offset: 0x003C3F38
		public static Offset<ITrapDefenseConditionStepLoadAndRestoreMap> Pack(FlatBufferBuilder builder, ITrapDefenseConditionStepLoadAndRestoreMapT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseConditionStepLoadAndRestoreMap>);
			}
			return ITrapDefenseConditionStepLoadAndRestoreMap.CreateITrapDefenseConditionStepLoadAndRestoreMap(builder, _o.Type);
		}

		// Token: 0x0400C8BD RID: 51389
		private Table __p;
	}
}
