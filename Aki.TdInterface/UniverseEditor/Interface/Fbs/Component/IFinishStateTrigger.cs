using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005255 RID: 21077
	public struct IFinishStateTrigger : IFlatbufferObject
	{
		// Token: 0x17009A61 RID: 39521
		// (get) Token: 0x06022489 RID: 140425 RVA: 0x004C1030 File Offset: 0x004BF230
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602248A RID: 140426 RVA: 0x004C103D File Offset: 0x004BF23D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602248B RID: 140427 RVA: 0x004C1044 File Offset: 0x004BF244
		public static IFinishStateTrigger GetRootAsIFinishStateTrigger(ByteBuffer _bb)
		{
			return IFinishStateTrigger.GetRootAsIFinishStateTrigger(_bb, default(IFinishStateTrigger));
		}

		// Token: 0x0602248C RID: 140428 RVA: 0x004C1060 File Offset: 0x004BF260
		public static IFinishStateTrigger GetRootAsIFinishStateTrigger(ByteBuffer _bb, IFinishStateTrigger obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602248D RID: 140429 RVA: 0x004C107D File Offset: 0x004BF27D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602248E RID: 140430 RVA: 0x004C108C File Offset: 0x004BF28C
		public IFinishStateTrigger __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A62 RID: 39522
		// (get) Token: 0x0602248F RID: 140431 RVA: 0x004C109C File Offset: 0x004BF29C
		public bool IsSilenceEntities
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009A63 RID: 39523
		// (get) Token: 0x06022490 RID: 140432 RVA: 0x004C10DC File Offset: 0x004BF2DC
		public IEntityGroupCondition? GroupCondition
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IEntityGroupCondition?(default(IEntityGroupCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06022491 RID: 140433 RVA: 0x004C1139 File Offset: 0x004BF339
		public static Offset<IFinishStateTrigger> CreateIFinishStateTrigger(FlatBufferBuilder builder, bool IsSilenceEntities = false, Offset<IEntityGroupCondition> GroupConditionOffset = default(Offset<IEntityGroupCondition>))
		{
			builder.StartTable(2);
			IFinishStateTrigger.AddGroupCondition(builder, GroupConditionOffset);
			IFinishStateTrigger.AddIsSilenceEntities(builder, IsSilenceEntities);
			return IFinishStateTrigger.EndIFinishStateTrigger(builder);
		}

		// Token: 0x06022492 RID: 140434 RVA: 0x004C1156 File Offset: 0x004BF356
		public static void StartIFinishStateTrigger(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06022493 RID: 140435 RVA: 0x004C115F File Offset: 0x004BF35F
		public static void AddIsSilenceEntities(FlatBufferBuilder builder, bool isSilenceEntities)
		{
			builder.AddBool(0, isSilenceEntities, false);
		}

		// Token: 0x06022494 RID: 140436 RVA: 0x004C116A File Offset: 0x004BF36A
		public static void AddGroupCondition(FlatBufferBuilder builder, Offset<IEntityGroupCondition> groupConditionOffset)
		{
			builder.AddOffset(1, groupConditionOffset.Value, 0);
		}

		// Token: 0x06022495 RID: 140437 RVA: 0x004C117A File Offset: 0x004BF37A
		public static Offset<IFinishStateTrigger> EndIFinishStateTrigger(FlatBufferBuilder builder)
		{
			return new Offset<IFinishStateTrigger>(builder.EndTable());
		}

		// Token: 0x06022496 RID: 140438 RVA: 0x004C1188 File Offset: 0x004BF388
		public IFinishStateTriggerT UnPack()
		{
			IFinishStateTriggerT finishStateTriggerT = new IFinishStateTriggerT();
			this.UnPackTo(finishStateTriggerT);
			return finishStateTriggerT;
		}

		// Token: 0x06022497 RID: 140439 RVA: 0x004C11A4 File Offset: 0x004BF3A4
		public void UnPackTo(IFinishStateTriggerT _o)
		{
			_o.IsSilenceEntities = this.IsSilenceEntities;
			_o.GroupCondition = ((this.GroupCondition != null) ? this.GroupCondition.Value.UnPack() : null);
		}

		// Token: 0x06022498 RID: 140440 RVA: 0x004C11EC File Offset: 0x004BF3EC
		public static Offset<IFinishStateTrigger> Pack(FlatBufferBuilder builder, IFinishStateTriggerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFinishStateTrigger>);
			}
			Offset<IEntityGroupCondition> groupConditionOffset = (_o.GroupCondition == null) ? default(Offset<IEntityGroupCondition>) : IEntityGroupCondition.Pack(builder, _o.GroupCondition);
			return IFinishStateTrigger.CreateIFinishStateTrigger(builder, _o.IsSilenceEntities, groupConditionOffset);
		}

		// Token: 0x0400E3A6 RID: 58278
		private Table __p;
	}
}
