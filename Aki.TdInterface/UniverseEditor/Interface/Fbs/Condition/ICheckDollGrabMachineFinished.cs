using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049CD RID: 18893
	public struct ICheckDollGrabMachineFinished : IFlatbufferObject
	{
		// Token: 0x1700889A RID: 34970
		// (get) Token: 0x0601D7FC RID: 120828 RVA: 0x00427802 File Offset: 0x00425A02
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D7FD RID: 120829 RVA: 0x0042780F File Offset: 0x00425A0F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D7FE RID: 120830 RVA: 0x00427818 File Offset: 0x00425A18
		public static ICheckDollGrabMachineFinished GetRootAsICheckDollGrabMachineFinished(ByteBuffer _bb)
		{
			return ICheckDollGrabMachineFinished.GetRootAsICheckDollGrabMachineFinished(_bb, default(ICheckDollGrabMachineFinished));
		}

		// Token: 0x0601D7FF RID: 120831 RVA: 0x00427834 File Offset: 0x00425A34
		public static ICheckDollGrabMachineFinished GetRootAsICheckDollGrabMachineFinished(ByteBuffer _bb, ICheckDollGrabMachineFinished obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D800 RID: 120832 RVA: 0x00427851 File Offset: 0x00425A51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D801 RID: 120833 RVA: 0x00427860 File Offset: 0x00425A60
		public ICheckDollGrabMachineFinished __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700889B RID: 34971
		// (get) Token: 0x0601D802 RID: 120834 RVA: 0x00427870 File Offset: 0x00425A70
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700889C RID: 34972
		// (get) Token: 0x0601D803 RID: 120835 RVA: 0x004278AC File Offset: 0x00425AAC
		public TTargetEntity TargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TTargetEntity.NONE;
				}
				return (TTargetEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D804 RID: 120836 RVA: 0x004278E8 File Offset: 0x00425AE8
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601D805 RID: 120837 RVA: 0x0042792C File Offset: 0x00425B2C
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x0601D806 RID: 120838 RVA: 0x00427948 File Offset: 0x00425B48
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x0601D807 RID: 120839 RVA: 0x00427964 File Offset: 0x00425B64
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x0601D808 RID: 120840 RVA: 0x00427980 File Offset: 0x00425B80
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x0601D809 RID: 120841 RVA: 0x0042799B File Offset: 0x00425B9B
		public static Offset<ICheckDollGrabMachineFinished> CreateICheckDollGrabMachineFinished(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TTargetEntity Target_type = TTargetEntity.NONE, int TargetOffset = 0)
		{
			builder.StartTable(3);
			ICheckDollGrabMachineFinished.AddTarget(builder, TargetOffset);
			ICheckDollGrabMachineFinished.AddTargetType(builder, Target_type);
			ICheckDollGrabMachineFinished.AddType(builder, Type);
			return ICheckDollGrabMachineFinished.EndICheckDollGrabMachineFinished(builder);
		}

		// Token: 0x0601D80A RID: 120842 RVA: 0x004279BF File Offset: 0x00425BBF
		public static void StartICheckDollGrabMachineFinished(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601D80B RID: 120843 RVA: 0x004279C8 File Offset: 0x00425BC8
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D80C RID: 120844 RVA: 0x004279D3 File Offset: 0x00425BD3
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0601D80D RID: 120845 RVA: 0x004279DE File Offset: 0x00425BDE
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0601D80E RID: 120846 RVA: 0x004279E9 File Offset: 0x00425BE9
		public static Offset<ICheckDollGrabMachineFinished> EndICheckDollGrabMachineFinished(FlatBufferBuilder builder)
		{
			return new Offset<ICheckDollGrabMachineFinished>(builder.EndTable());
		}

		// Token: 0x0601D80F RID: 120847 RVA: 0x004279F8 File Offset: 0x00425BF8
		public ICheckDollGrabMachineFinishedT UnPack()
		{
			ICheckDollGrabMachineFinishedT checkDollGrabMachineFinishedT = new ICheckDollGrabMachineFinishedT();
			this.UnPackTo(checkDollGrabMachineFinishedT);
			return checkDollGrabMachineFinishedT;
		}

		// Token: 0x0601D810 RID: 120848 RVA: 0x00427A14 File Offset: 0x00425C14
		public void UnPackTo(ICheckDollGrabMachineFinishedT _o)
		{
			_o.Type = this.Type;
			_o.Target = new TTargetEntityUnion();
			_o.Target.Type = this.TargetType;
			switch (this.TargetType)
			{
			case TTargetEntity.IPlayerEntity:
				_o.Target.Value = ((this.Target<IPlayerEntity>() != null) ? this.Target<IPlayerEntity>().Value.UnPack() : null);
				return;
			case TTargetEntity.ISelfEntity:
				_o.Target.Value = ((this.Target<ISelfEntity>() != null) ? this.Target<ISelfEntity>().Value.UnPack() : null);
				return;
			case TTargetEntity.ITargetEntity:
				_o.Target.Value = ((this.Target<ITargetEntity>() != null) ? this.Target<ITargetEntity>().Value.UnPack() : null);
				return;
			case TTargetEntity.ITriggeredEntity:
				_o.Target.Value = ((this.Target<ITriggeredEntity>() != null) ? this.Target<ITriggeredEntity>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0601D811 RID: 120849 RVA: 0x00427B44 File Offset: 0x00425D44
		public static Offset<ICheckDollGrabMachineFinished> Pack(FlatBufferBuilder builder, ICheckDollGrabMachineFinishedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckDollGrabMachineFinished>);
			}
			TTargetEntity target_type = (_o.Target == null) ? TTargetEntity.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.Target);
			return ICheckDollGrabMachineFinished.CreateICheckDollGrabMachineFinished(builder, _o.Type, target_type, targetOffset);
		}

		// Token: 0x0400D1F7 RID: 53751
		private Table __p;
	}
}
