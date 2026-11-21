using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E9F RID: 20127
	public struct ICheckElementalBoxState : IFlatbufferObject
	{
		// Token: 0x17008F94 RID: 36756
		// (get) Token: 0x0601F311 RID: 127761 RVA: 0x004595FC File Offset: 0x004577FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F312 RID: 127762 RVA: 0x00459609 File Offset: 0x00457809
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F313 RID: 127763 RVA: 0x00459610 File Offset: 0x00457810
		public static ICheckElementalBoxState GetRootAsICheckElementalBoxState(ByteBuffer _bb)
		{
			return ICheckElementalBoxState.GetRootAsICheckElementalBoxState(_bb, default(ICheckElementalBoxState));
		}

		// Token: 0x0601F314 RID: 127764 RVA: 0x0045962C File Offset: 0x0045782C
		public static ICheckElementalBoxState GetRootAsICheckElementalBoxState(ByteBuffer _bb, ICheckElementalBoxState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F315 RID: 127765 RVA: 0x00459649 File Offset: 0x00457849
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F316 RID: 127766 RVA: 0x00459658 File Offset: 0x00457858
		public ICheckElementalBoxState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F95 RID: 36757
		// (get) Token: 0x0601F317 RID: 127767 RVA: 0x00459668 File Offset: 0x00457868
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

		// Token: 0x17008F96 RID: 36758
		// (get) Token: 0x0601F318 RID: 127768 RVA: 0x004596A4 File Offset: 0x004578A4
		public TElementalBoxStateTarget TargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TElementalBoxStateTarget.NONE;
				}
				return (TElementalBoxStateTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F319 RID: 127769 RVA: 0x004596E0 File Offset: 0x004578E0
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601F31A RID: 127770 RVA: 0x00459724 File Offset: 0x00457924
		public IElementalBoxStateFoundationSelfTarget TargetAsIElementalBoxStateFoundationSelfTarget()
		{
			return this.Target<IElementalBoxStateFoundationSelfTarget>().Value;
		}

		// Token: 0x0601F31B RID: 127771 RVA: 0x00459740 File Offset: 0x00457940
		public IElementalBoxStateFoundationTarget TargetAsIElementalBoxStateFoundationTarget()
		{
			return this.Target<IElementalBoxStateFoundationTarget>().Value;
		}

		// Token: 0x0601F31C RID: 127772 RVA: 0x0045975C File Offset: 0x0045795C
		public IElementalBoxStatePlayerTarget TargetAsIElementalBoxStatePlayerTarget()
		{
			return this.Target<IElementalBoxStatePlayerTarget>().Value;
		}

		// Token: 0x0601F31D RID: 127773 RVA: 0x00459778 File Offset: 0x00457978
		public IElementalBoxStateSpecifiedTarget TargetAsIElementalBoxStateSpecifiedTarget()
		{
			return this.Target<IElementalBoxStateSpecifiedTarget>().Value;
		}

		// Token: 0x0601F31E RID: 127774 RVA: 0x00459793 File Offset: 0x00457993
		public static Offset<ICheckElementalBoxState> CreateICheckElementalBoxState(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TElementalBoxStateTarget Target_type = TElementalBoxStateTarget.NONE, int TargetOffset = 0)
		{
			builder.StartTable(3);
			ICheckElementalBoxState.AddTarget(builder, TargetOffset);
			ICheckElementalBoxState.AddTargetType(builder, Target_type);
			ICheckElementalBoxState.AddType(builder, Type);
			return ICheckElementalBoxState.EndICheckElementalBoxState(builder);
		}

		// Token: 0x0601F31F RID: 127775 RVA: 0x004597B7 File Offset: 0x004579B7
		public static void StartICheckElementalBoxState(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F320 RID: 127776 RVA: 0x004597C0 File Offset: 0x004579C0
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F321 RID: 127777 RVA: 0x004597CB File Offset: 0x004579CB
		public static void AddTargetType(FlatBufferBuilder builder, TElementalBoxStateTarget targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0601F322 RID: 127778 RVA: 0x004597D6 File Offset: 0x004579D6
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0601F323 RID: 127779 RVA: 0x004597E1 File Offset: 0x004579E1
		public static Offset<ICheckElementalBoxState> EndICheckElementalBoxState(FlatBufferBuilder builder)
		{
			return new Offset<ICheckElementalBoxState>(builder.EndTable());
		}

		// Token: 0x0601F324 RID: 127780 RVA: 0x004597F0 File Offset: 0x004579F0
		public ICheckElementalBoxStateT UnPack()
		{
			ICheckElementalBoxStateT checkElementalBoxStateT = new ICheckElementalBoxStateT();
			this.UnPackTo(checkElementalBoxStateT);
			return checkElementalBoxStateT;
		}

		// Token: 0x0601F325 RID: 127781 RVA: 0x0045980C File Offset: 0x00457A0C
		public void UnPackTo(ICheckElementalBoxStateT _o)
		{
			_o.Type = this.Type;
			_o.Target = new TElementalBoxStateTargetUnion();
			_o.Target.Type = this.TargetType;
			switch (this.TargetType)
			{
			case TElementalBoxStateTarget.IElementalBoxStateFoundationSelfTarget:
				_o.Target.Value = ((this.Target<IElementalBoxStateFoundationSelfTarget>() != null) ? this.Target<IElementalBoxStateFoundationSelfTarget>().Value.UnPack() : null);
				return;
			case TElementalBoxStateTarget.IElementalBoxStateFoundationTarget:
				_o.Target.Value = ((this.Target<IElementalBoxStateFoundationTarget>() != null) ? this.Target<IElementalBoxStateFoundationTarget>().Value.UnPack() : null);
				return;
			case TElementalBoxStateTarget.IElementalBoxStatePlayerTarget:
				_o.Target.Value = ((this.Target<IElementalBoxStatePlayerTarget>() != null) ? this.Target<IElementalBoxStatePlayerTarget>().Value.UnPack() : null);
				return;
			case TElementalBoxStateTarget.IElementalBoxStateSpecifiedTarget:
				_o.Target.Value = ((this.Target<IElementalBoxStateSpecifiedTarget>() != null) ? this.Target<IElementalBoxStateSpecifiedTarget>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0601F326 RID: 127782 RVA: 0x0045993C File Offset: 0x00457B3C
		public static Offset<ICheckElementalBoxState> Pack(FlatBufferBuilder builder, ICheckElementalBoxStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckElementalBoxState>);
			}
			TElementalBoxStateTarget target_type = (_o.Target == null) ? TElementalBoxStateTarget.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TElementalBoxStateTargetUnion.Pack(builder, _o.Target);
			return ICheckElementalBoxState.CreateICheckElementalBoxState(builder, _o.Type, target_type, targetOffset);
		}

		// Token: 0x0400DCE3 RID: 56547
		private Table __p;
	}
}
