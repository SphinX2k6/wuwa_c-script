using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049DF RID: 18911
	public struct ICheckElementalBoxState : IFlatbufferObject
	{
		// Token: 0x170088C4 RID: 35012
		// (get) Token: 0x0601D89E RID: 120990 RVA: 0x00428990 File Offset: 0x00426B90
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D89F RID: 120991 RVA: 0x0042899D File Offset: 0x00426B9D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D8A0 RID: 120992 RVA: 0x004289A4 File Offset: 0x00426BA4
		public static ICheckElementalBoxState GetRootAsICheckElementalBoxState(ByteBuffer _bb)
		{
			return ICheckElementalBoxState.GetRootAsICheckElementalBoxState(_bb, default(ICheckElementalBoxState));
		}

		// Token: 0x0601D8A1 RID: 120993 RVA: 0x004289C0 File Offset: 0x00426BC0
		public static ICheckElementalBoxState GetRootAsICheckElementalBoxState(ByteBuffer _bb, ICheckElementalBoxState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D8A2 RID: 120994 RVA: 0x004289DD File Offset: 0x00426BDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D8A3 RID: 120995 RVA: 0x004289EC File Offset: 0x00426BEC
		public ICheckElementalBoxState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170088C5 RID: 35013
		// (get) Token: 0x0601D8A4 RID: 120996 RVA: 0x004289FC File Offset: 0x00426BFC
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

		// Token: 0x170088C6 RID: 35014
		// (get) Token: 0x0601D8A5 RID: 120997 RVA: 0x00428A38 File Offset: 0x00426C38
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

		// Token: 0x0601D8A6 RID: 120998 RVA: 0x00428A74 File Offset: 0x00426C74
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601D8A7 RID: 120999 RVA: 0x00428AB8 File Offset: 0x00426CB8
		public IElementalBoxStateFoundationSelfTarget TargetAsIElementalBoxStateFoundationSelfTarget()
		{
			return this.Target<IElementalBoxStateFoundationSelfTarget>().Value;
		}

		// Token: 0x0601D8A8 RID: 121000 RVA: 0x00428AD4 File Offset: 0x00426CD4
		public IElementalBoxStateFoundationTarget TargetAsIElementalBoxStateFoundationTarget()
		{
			return this.Target<IElementalBoxStateFoundationTarget>().Value;
		}

		// Token: 0x0601D8A9 RID: 121001 RVA: 0x00428AF0 File Offset: 0x00426CF0
		public IElementalBoxStatePlayerTarget TargetAsIElementalBoxStatePlayerTarget()
		{
			return this.Target<IElementalBoxStatePlayerTarget>().Value;
		}

		// Token: 0x0601D8AA RID: 121002 RVA: 0x00428B0C File Offset: 0x00426D0C
		public IElementalBoxStateSpecifiedTarget TargetAsIElementalBoxStateSpecifiedTarget()
		{
			return this.Target<IElementalBoxStateSpecifiedTarget>().Value;
		}

		// Token: 0x0601D8AB RID: 121003 RVA: 0x00428B27 File Offset: 0x00426D27
		public static Offset<ICheckElementalBoxState> CreateICheckElementalBoxState(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TElementalBoxStateTarget Target_type = TElementalBoxStateTarget.NONE, int TargetOffset = 0)
		{
			builder.StartTable(3);
			ICheckElementalBoxState.AddTarget(builder, TargetOffset);
			ICheckElementalBoxState.AddTargetType(builder, Target_type);
			ICheckElementalBoxState.AddType(builder, Type);
			return ICheckElementalBoxState.EndICheckElementalBoxState(builder);
		}

		// Token: 0x0601D8AC RID: 121004 RVA: 0x00428B4B File Offset: 0x00426D4B
		public static void StartICheckElementalBoxState(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601D8AD RID: 121005 RVA: 0x00428B54 File Offset: 0x00426D54
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D8AE RID: 121006 RVA: 0x00428B5F File Offset: 0x00426D5F
		public static void AddTargetType(FlatBufferBuilder builder, TElementalBoxStateTarget targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0601D8AF RID: 121007 RVA: 0x00428B6A File Offset: 0x00426D6A
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0601D8B0 RID: 121008 RVA: 0x00428B75 File Offset: 0x00426D75
		public static Offset<ICheckElementalBoxState> EndICheckElementalBoxState(FlatBufferBuilder builder)
		{
			return new Offset<ICheckElementalBoxState>(builder.EndTable());
		}

		// Token: 0x0601D8B1 RID: 121009 RVA: 0x00428B84 File Offset: 0x00426D84
		public ICheckElementalBoxStateT UnPack()
		{
			ICheckElementalBoxStateT checkElementalBoxStateT = new ICheckElementalBoxStateT();
			this.UnPackTo(checkElementalBoxStateT);
			return checkElementalBoxStateT;
		}

		// Token: 0x0601D8B2 RID: 121010 RVA: 0x00428BA0 File Offset: 0x00426DA0
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

		// Token: 0x0601D8B3 RID: 121011 RVA: 0x00428CD0 File Offset: 0x00426ED0
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

		// Token: 0x0400D20F RID: 53775
		private Table __p;
	}
}
