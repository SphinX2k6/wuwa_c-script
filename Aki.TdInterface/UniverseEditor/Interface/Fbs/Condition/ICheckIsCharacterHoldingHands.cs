using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A81 RID: 19073
	public struct ICheckIsCharacterHoldingHands : IFlatbufferObject
	{
		// Token: 0x17008A2B RID: 35371
		// (get) Token: 0x0601DE78 RID: 122488 RVA: 0x004333DF File Offset: 0x004315DF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DE79 RID: 122489 RVA: 0x004333EC File Offset: 0x004315EC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DE7A RID: 122490 RVA: 0x004333F4 File Offset: 0x004315F4
		public static ICheckIsCharacterHoldingHands GetRootAsICheckIsCharacterHoldingHands(ByteBuffer _bb)
		{
			return ICheckIsCharacterHoldingHands.GetRootAsICheckIsCharacterHoldingHands(_bb, default(ICheckIsCharacterHoldingHands));
		}

		// Token: 0x0601DE7B RID: 122491 RVA: 0x00433410 File Offset: 0x00431610
		public static ICheckIsCharacterHoldingHands GetRootAsICheckIsCharacterHoldingHands(ByteBuffer _bb, ICheckIsCharacterHoldingHands obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DE7C RID: 122492 RVA: 0x0043342D File Offset: 0x0043162D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DE7D RID: 122493 RVA: 0x0043343C File Offset: 0x0043163C
		public ICheckIsCharacterHoldingHands __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A2C RID: 35372
		// (get) Token: 0x0601DE7E RID: 122494 RVA: 0x0043344C File Offset: 0x0043164C
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

		// Token: 0x17008A2D RID: 35373
		// (get) Token: 0x0601DE7F RID: 122495 RVA: 0x00433488 File Offset: 0x00431688
		public TCheckHoldingHandsCharacter TargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TCheckHoldingHandsCharacter.NONE;
				}
				return (TCheckHoldingHandsCharacter)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601DE80 RID: 122496 RVA: 0x004334C4 File Offset: 0x004316C4
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601DE81 RID: 122497 RVA: 0x00433508 File Offset: 0x00431708
		public ICheckIsEntityHoldingHands TargetAsICheckIsEntityHoldingHands()
		{
			return this.Target<ICheckIsEntityHoldingHands>().Value;
		}

		// Token: 0x0601DE82 RID: 122498 RVA: 0x00433524 File Offset: 0x00431724
		public ICheckIsPlayerHoldingHands TargetAsICheckIsPlayerHoldingHands()
		{
			return this.Target<ICheckIsPlayerHoldingHands>().Value;
		}

		// Token: 0x17008A2E RID: 35374
		// (get) Token: 0x0601DE83 RID: 122499 RVA: 0x00433540 File Offset: 0x00431740
		public bool IsHoldingHands
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601DE84 RID: 122500 RVA: 0x00433580 File Offset: 0x00431780
		public static Offset<ICheckIsCharacterHoldingHands> CreateICheckIsCharacterHoldingHands(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TCheckHoldingHandsCharacter Target_type = TCheckHoldingHandsCharacter.NONE, int TargetOffset = 0, bool IsHoldingHands = false)
		{
			builder.StartTable(4);
			ICheckIsCharacterHoldingHands.AddTarget(builder, TargetOffset);
			ICheckIsCharacterHoldingHands.AddIsHoldingHands(builder, IsHoldingHands);
			ICheckIsCharacterHoldingHands.AddTargetType(builder, Target_type);
			ICheckIsCharacterHoldingHands.AddType(builder, Type);
			return ICheckIsCharacterHoldingHands.EndICheckIsCharacterHoldingHands(builder);
		}

		// Token: 0x0601DE85 RID: 122501 RVA: 0x004335AC File Offset: 0x004317AC
		public static void StartICheckIsCharacterHoldingHands(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601DE86 RID: 122502 RVA: 0x004335B5 File Offset: 0x004317B5
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DE87 RID: 122503 RVA: 0x004335C0 File Offset: 0x004317C0
		public static void AddTargetType(FlatBufferBuilder builder, TCheckHoldingHandsCharacter targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0601DE88 RID: 122504 RVA: 0x004335CB File Offset: 0x004317CB
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0601DE89 RID: 122505 RVA: 0x004335D6 File Offset: 0x004317D6
		public static void AddIsHoldingHands(FlatBufferBuilder builder, bool isHoldingHands)
		{
			builder.AddBool(3, isHoldingHands, false);
		}

		// Token: 0x0601DE8A RID: 122506 RVA: 0x004335E1 File Offset: 0x004317E1
		public static Offset<ICheckIsCharacterHoldingHands> EndICheckIsCharacterHoldingHands(FlatBufferBuilder builder)
		{
			return new Offset<ICheckIsCharacterHoldingHands>(builder.EndTable());
		}

		// Token: 0x0601DE8B RID: 122507 RVA: 0x004335F0 File Offset: 0x004317F0
		public ICheckIsCharacterHoldingHandsT UnPack()
		{
			ICheckIsCharacterHoldingHandsT checkIsCharacterHoldingHandsT = new ICheckIsCharacterHoldingHandsT();
			this.UnPackTo(checkIsCharacterHoldingHandsT);
			return checkIsCharacterHoldingHandsT;
		}

		// Token: 0x0601DE8C RID: 122508 RVA: 0x0043360C File Offset: 0x0043180C
		public void UnPackTo(ICheckIsCharacterHoldingHandsT _o)
		{
			_o.Type = this.Type;
			_o.Target = new TCheckHoldingHandsCharacterUnion();
			_o.Target.Type = this.TargetType;
			TCheckHoldingHandsCharacter targetType = this.TargetType;
			if (targetType != TCheckHoldingHandsCharacter.ICheckIsEntityHoldingHands)
			{
				if (targetType == TCheckHoldingHandsCharacter.ICheckIsPlayerHoldingHands)
				{
					_o.Target.Value = ((this.Target<ICheckIsPlayerHoldingHands>() != null) ? this.Target<ICheckIsPlayerHoldingHands>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.Target.Value = ((this.Target<ICheckIsEntityHoldingHands>() != null) ? this.Target<ICheckIsEntityHoldingHands>().Value.UnPack() : null);
			}
			_o.IsHoldingHands = this.IsHoldingHands;
		}

		// Token: 0x0601DE8D RID: 122509 RVA: 0x004336CC File Offset: 0x004318CC
		public static Offset<ICheckIsCharacterHoldingHands> Pack(FlatBufferBuilder builder, ICheckIsCharacterHoldingHandsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckIsCharacterHoldingHands>);
			}
			TCheckHoldingHandsCharacter target_type = (_o.Target == null) ? TCheckHoldingHandsCharacter.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TCheckHoldingHandsCharacterUnion.Pack(builder, _o.Target);
			return ICheckIsCharacterHoldingHands.CreateICheckIsCharacterHoldingHands(builder, _o.Type, target_type, targetOffset, _o.IsHoldingHands);
		}

		// Token: 0x0400D2EE RID: 53998
		private Table __p;
	}
}
