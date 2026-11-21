using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057BD RID: 22461
	public struct IFinishStateTrigger : IFlatbufferObject
	{
		// Token: 0x1700A25D RID: 41565
		// (get) Token: 0x0602441F RID: 148511 RVA: 0x004FBAF4 File Offset: 0x004F9CF4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024420 RID: 148512 RVA: 0x004FBB01 File Offset: 0x004F9D01
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024421 RID: 148513 RVA: 0x004FBB08 File Offset: 0x004F9D08
		public static IFinishStateTrigger GetRootAsIFinishStateTrigger(ByteBuffer _bb)
		{
			return IFinishStateTrigger.GetRootAsIFinishStateTrigger(_bb, default(IFinishStateTrigger));
		}

		// Token: 0x06024422 RID: 148514 RVA: 0x004FBB24 File Offset: 0x004F9D24
		public static IFinishStateTrigger GetRootAsIFinishStateTrigger(ByteBuffer _bb, IFinishStateTrigger obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024423 RID: 148515 RVA: 0x004FBB41 File Offset: 0x004F9D41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024424 RID: 148516 RVA: 0x004FBB50 File Offset: 0x004F9D50
		public IFinishStateTrigger __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A25E RID: 41566
		// (get) Token: 0x06024425 RID: 148517 RVA: 0x004FBB60 File Offset: 0x004F9D60
		public bool IsSilenceEntities
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A25F RID: 41567
		// (get) Token: 0x06024426 RID: 148518 RVA: 0x004FBBA0 File Offset: 0x004F9DA0
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

		// Token: 0x06024427 RID: 148519 RVA: 0x004FBBFD File Offset: 0x004F9DFD
		public static Offset<IFinishStateTrigger> CreateIFinishStateTrigger(FlatBufferBuilder builder, bool IsSilenceEntities = false, Offset<IEntityGroupCondition> GroupConditionOffset = default(Offset<IEntityGroupCondition>))
		{
			builder.StartTable(2);
			IFinishStateTrigger.AddGroupCondition(builder, GroupConditionOffset);
			IFinishStateTrigger.AddIsSilenceEntities(builder, IsSilenceEntities);
			return IFinishStateTrigger.EndIFinishStateTrigger(builder);
		}

		// Token: 0x06024428 RID: 148520 RVA: 0x004FBC1A File Offset: 0x004F9E1A
		public static void StartIFinishStateTrigger(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06024429 RID: 148521 RVA: 0x004FBC23 File Offset: 0x004F9E23
		public static void AddIsSilenceEntities(FlatBufferBuilder builder, bool isSilenceEntities)
		{
			builder.AddBool(0, isSilenceEntities, false);
		}

		// Token: 0x0602442A RID: 148522 RVA: 0x004FBC2E File Offset: 0x004F9E2E
		public static void AddGroupCondition(FlatBufferBuilder builder, Offset<IEntityGroupCondition> groupConditionOffset)
		{
			builder.AddOffset(1, groupConditionOffset.Value, 0);
		}

		// Token: 0x0602442B RID: 148523 RVA: 0x004FBC3E File Offset: 0x004F9E3E
		public static Offset<IFinishStateTrigger> EndIFinishStateTrigger(FlatBufferBuilder builder)
		{
			return new Offset<IFinishStateTrigger>(builder.EndTable());
		}

		// Token: 0x0602442C RID: 148524 RVA: 0x004FBC4C File Offset: 0x004F9E4C
		public IFinishStateTriggerT UnPack()
		{
			IFinishStateTriggerT finishStateTriggerT = new IFinishStateTriggerT();
			this.UnPackTo(finishStateTriggerT);
			return finishStateTriggerT;
		}

		// Token: 0x0602442D RID: 148525 RVA: 0x004FBC68 File Offset: 0x004F9E68
		public void UnPackTo(IFinishStateTriggerT _o)
		{
			_o.IsSilenceEntities = this.IsSilenceEntities;
			_o.GroupCondition = ((this.GroupCondition != null) ? this.GroupCondition.Value.UnPack() : null);
		}

		// Token: 0x0602442E RID: 148526 RVA: 0x004FBCB0 File Offset: 0x004F9EB0
		public static Offset<IFinishStateTrigger> Pack(FlatBufferBuilder builder, IFinishStateTriggerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFinishStateTrigger>);
			}
			Offset<IEntityGroupCondition> groupConditionOffset = (_o.GroupCondition == null) ? default(Offset<IEntityGroupCondition>) : IEntityGroupCondition.Pack(builder, _o.GroupCondition);
			return IFinishStateTrigger.CreateIFinishStateTrigger(builder, _o.IsSilenceEntities, groupConditionOffset);
		}

		// Token: 0x0400EFAC RID: 61356
		private Table __p;
	}
}
