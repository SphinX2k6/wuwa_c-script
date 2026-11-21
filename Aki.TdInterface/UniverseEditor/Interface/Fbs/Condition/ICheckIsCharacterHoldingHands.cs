using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F47 RID: 20295
	public struct ICheckIsCharacterHoldingHands : IFlatbufferObject
	{
		// Token: 0x17009107 RID: 37127
		// (get) Token: 0x0601F91B RID: 129307 RVA: 0x0046456B File Offset: 0x0046276B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F91C RID: 129308 RVA: 0x00464578 File Offset: 0x00462778
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F91D RID: 129309 RVA: 0x00464580 File Offset: 0x00462780
		public static ICheckIsCharacterHoldingHands GetRootAsICheckIsCharacterHoldingHands(ByteBuffer _bb)
		{
			return ICheckIsCharacterHoldingHands.GetRootAsICheckIsCharacterHoldingHands(_bb, default(ICheckIsCharacterHoldingHands));
		}

		// Token: 0x0601F91E RID: 129310 RVA: 0x0046459C File Offset: 0x0046279C
		public static ICheckIsCharacterHoldingHands GetRootAsICheckIsCharacterHoldingHands(ByteBuffer _bb, ICheckIsCharacterHoldingHands obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F91F RID: 129311 RVA: 0x004645B9 File Offset: 0x004627B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F920 RID: 129312 RVA: 0x004645C8 File Offset: 0x004627C8
		public ICheckIsCharacterHoldingHands __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009108 RID: 37128
		// (get) Token: 0x0601F921 RID: 129313 RVA: 0x004645D8 File Offset: 0x004627D8
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

		// Token: 0x17009109 RID: 37129
		// (get) Token: 0x0601F922 RID: 129314 RVA: 0x00464614 File Offset: 0x00462814
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

		// Token: 0x0601F923 RID: 129315 RVA: 0x00464650 File Offset: 0x00462850
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601F924 RID: 129316 RVA: 0x00464694 File Offset: 0x00462894
		public ICheckIsEntityHoldingHands TargetAsICheckIsEntityHoldingHands()
		{
			return this.Target<ICheckIsEntityHoldingHands>().Value;
		}

		// Token: 0x0601F925 RID: 129317 RVA: 0x004646B0 File Offset: 0x004628B0
		public ICheckIsPlayerHoldingHands TargetAsICheckIsPlayerHoldingHands()
		{
			return this.Target<ICheckIsPlayerHoldingHands>().Value;
		}

		// Token: 0x1700910A RID: 37130
		// (get) Token: 0x0601F926 RID: 129318 RVA: 0x004646CC File Offset: 0x004628CC
		public bool IsHoldingHands
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601F927 RID: 129319 RVA: 0x0046470C File Offset: 0x0046290C
		public static Offset<ICheckIsCharacterHoldingHands> CreateICheckIsCharacterHoldingHands(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TCheckHoldingHandsCharacter Target_type = TCheckHoldingHandsCharacter.NONE, int TargetOffset = 0, bool IsHoldingHands = false)
		{
			builder.StartTable(4);
			ICheckIsCharacterHoldingHands.AddTarget(builder, TargetOffset);
			ICheckIsCharacterHoldingHands.AddIsHoldingHands(builder, IsHoldingHands);
			ICheckIsCharacterHoldingHands.AddTargetType(builder, Target_type);
			ICheckIsCharacterHoldingHands.AddType(builder, Type);
			return ICheckIsCharacterHoldingHands.EndICheckIsCharacterHoldingHands(builder);
		}

		// Token: 0x0601F928 RID: 129320 RVA: 0x00464738 File Offset: 0x00462938
		public static void StartICheckIsCharacterHoldingHands(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601F929 RID: 129321 RVA: 0x00464741 File Offset: 0x00462941
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F92A RID: 129322 RVA: 0x0046474C File Offset: 0x0046294C
		public static void AddTargetType(FlatBufferBuilder builder, TCheckHoldingHandsCharacter targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0601F92B RID: 129323 RVA: 0x00464757 File Offset: 0x00462957
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0601F92C RID: 129324 RVA: 0x00464762 File Offset: 0x00462962
		public static void AddIsHoldingHands(FlatBufferBuilder builder, bool isHoldingHands)
		{
			builder.AddBool(3, isHoldingHands, false);
		}

		// Token: 0x0601F92D RID: 129325 RVA: 0x0046476D File Offset: 0x0046296D
		public static Offset<ICheckIsCharacterHoldingHands> EndICheckIsCharacterHoldingHands(FlatBufferBuilder builder)
		{
			return new Offset<ICheckIsCharacterHoldingHands>(builder.EndTable());
		}

		// Token: 0x0601F92E RID: 129326 RVA: 0x0046477C File Offset: 0x0046297C
		public ICheckIsCharacterHoldingHandsT UnPack()
		{
			ICheckIsCharacterHoldingHandsT checkIsCharacterHoldingHandsT = new ICheckIsCharacterHoldingHandsT();
			this.UnPackTo(checkIsCharacterHoldingHandsT);
			return checkIsCharacterHoldingHandsT;
		}

		// Token: 0x0601F92F RID: 129327 RVA: 0x00464798 File Offset: 0x00462998
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

		// Token: 0x0601F930 RID: 129328 RVA: 0x00464858 File Offset: 0x00462A58
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

		// Token: 0x0400DDC9 RID: 56777
		private Table __p;
	}
}
