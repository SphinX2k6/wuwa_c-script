using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F6E RID: 20334
	public struct ICheckIsTargetHoldElementalBox : IFlatbufferObject
	{
		// Token: 0x17009156 RID: 37206
		// (get) Token: 0x0601FA63 RID: 129635 RVA: 0x00466932 File Offset: 0x00464B32
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FA64 RID: 129636 RVA: 0x0046693F File Offset: 0x00464B3F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FA65 RID: 129637 RVA: 0x00466948 File Offset: 0x00464B48
		public static ICheckIsTargetHoldElementalBox GetRootAsICheckIsTargetHoldElementalBox(ByteBuffer _bb)
		{
			return ICheckIsTargetHoldElementalBox.GetRootAsICheckIsTargetHoldElementalBox(_bb, default(ICheckIsTargetHoldElementalBox));
		}

		// Token: 0x0601FA66 RID: 129638 RVA: 0x00466964 File Offset: 0x00464B64
		public static ICheckIsTargetHoldElementalBox GetRootAsICheckIsTargetHoldElementalBox(ByteBuffer _bb, ICheckIsTargetHoldElementalBox obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FA67 RID: 129639 RVA: 0x00466981 File Offset: 0x00464B81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FA68 RID: 129640 RVA: 0x00466990 File Offset: 0x00464B90
		public ICheckIsTargetHoldElementalBox __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009157 RID: 37207
		// (get) Token: 0x0601FA69 RID: 129641 RVA: 0x004669A0 File Offset: 0x00464BA0
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

		// Token: 0x17009158 RID: 37208
		// (get) Token: 0x0601FA6A RID: 129642 RVA: 0x004669DC File Offset: 0x00464BDC
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

		// Token: 0x0601FA6B RID: 129643 RVA: 0x00466A18 File Offset: 0x00464C18
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601FA6C RID: 129644 RVA: 0x00466A5C File Offset: 0x00464C5C
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x0601FA6D RID: 129645 RVA: 0x00466A78 File Offset: 0x00464C78
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x0601FA6E RID: 129646 RVA: 0x00466A94 File Offset: 0x00464C94
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x0601FA6F RID: 129647 RVA: 0x00466AB0 File Offset: 0x00464CB0
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x17009159 RID: 37209
		// (get) Token: 0x0601FA70 RID: 129648 RVA: 0x00466ACC File Offset: 0x00464CCC
		public bool IsHolding
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700915A RID: 37210
		// (get) Token: 0x0601FA71 RID: 129649 RVA: 0x00466B0C File Offset: 0x00464D0C
		public EElementalType TargetElementalType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return EElementalType.Fire;
				}
				return (EElementalType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700915B RID: 37211
		// (get) Token: 0x0601FA72 RID: 129650 RVA: 0x00466B4C File Offset: 0x00464D4C
		public int ElementalBoxId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700915C RID: 37212
		// (get) Token: 0x0601FA73 RID: 129651 RVA: 0x00466B8C File Offset: 0x00464D8C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FA74 RID: 129652 RVA: 0x00466BCC File Offset: 0x00464DCC
		public static Offset<ICheckIsTargetHoldElementalBox> CreateICheckIsTargetHoldElementalBox(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TTargetEntity Target_type = TTargetEntity.NONE, int TargetOffset = 0, bool IsHolding = false, EElementalType TargetElementalType = EElementalType.Fire, int ElementalBoxId = 0, byte NullMask = 0)
		{
			builder.StartTable(7);
			ICheckIsTargetHoldElementalBox.AddElementalBoxId(builder, ElementalBoxId);
			ICheckIsTargetHoldElementalBox.AddTarget(builder, TargetOffset);
			ICheckIsTargetHoldElementalBox.AddNullMask(builder, NullMask);
			ICheckIsTargetHoldElementalBox.AddTargetElementalType(builder, TargetElementalType);
			ICheckIsTargetHoldElementalBox.AddIsHolding(builder, IsHolding);
			ICheckIsTargetHoldElementalBox.AddTargetType(builder, Target_type);
			ICheckIsTargetHoldElementalBox.AddType(builder, Type);
			return ICheckIsTargetHoldElementalBox.EndICheckIsTargetHoldElementalBox(builder);
		}

		// Token: 0x0601FA75 RID: 129653 RVA: 0x00466C1B File Offset: 0x00464E1B
		public static void StartICheckIsTargetHoldElementalBox(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601FA76 RID: 129654 RVA: 0x00466C24 File Offset: 0x00464E24
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FA77 RID: 129655 RVA: 0x00466C2F File Offset: 0x00464E2F
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0601FA78 RID: 129656 RVA: 0x00466C3A File Offset: 0x00464E3A
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0601FA79 RID: 129657 RVA: 0x00466C45 File Offset: 0x00464E45
		public static void AddIsHolding(FlatBufferBuilder builder, bool isHolding)
		{
			builder.AddBool(3, isHolding, false);
		}

		// Token: 0x0601FA7A RID: 129658 RVA: 0x00466C50 File Offset: 0x00464E50
		public static void AddTargetElementalType(FlatBufferBuilder builder, EElementalType targetElementalType)
		{
			builder.AddByte(4, (byte)targetElementalType, 0);
		}

		// Token: 0x0601FA7B RID: 129659 RVA: 0x00466C5B File Offset: 0x00464E5B
		public static void AddElementalBoxId(FlatBufferBuilder builder, int elementalBoxId)
		{
			builder.AddInt(5, elementalBoxId, 0);
		}

		// Token: 0x0601FA7C RID: 129660 RVA: 0x00466C66 File Offset: 0x00464E66
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0601FA7D RID: 129661 RVA: 0x00466C71 File Offset: 0x00464E71
		public static Offset<ICheckIsTargetHoldElementalBox> EndICheckIsTargetHoldElementalBox(FlatBufferBuilder builder)
		{
			return new Offset<ICheckIsTargetHoldElementalBox>(builder.EndTable());
		}

		// Token: 0x0601FA7E RID: 129662 RVA: 0x00466C80 File Offset: 0x00464E80
		public ICheckIsTargetHoldElementalBoxT UnPack()
		{
			ICheckIsTargetHoldElementalBoxT checkIsTargetHoldElementalBoxT = new ICheckIsTargetHoldElementalBoxT();
			this.UnPackTo(checkIsTargetHoldElementalBoxT);
			return checkIsTargetHoldElementalBoxT;
		}

		// Token: 0x0601FA7F RID: 129663 RVA: 0x00466C9C File Offset: 0x00464E9C
		public void UnPackTo(ICheckIsTargetHoldElementalBoxT _o)
		{
			_o.Type = this.Type;
			_o.Target = new TTargetEntityUnion();
			_o.Target.Type = this.TargetType;
			switch (this.TargetType)
			{
			case TTargetEntity.IPlayerEntity:
				_o.Target.Value = ((this.Target<IPlayerEntity>() != null) ? this.Target<IPlayerEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ISelfEntity:
				_o.Target.Value = ((this.Target<ISelfEntity>() != null) ? this.Target<ISelfEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITargetEntity:
				_o.Target.Value = ((this.Target<ITargetEntity>() != null) ? this.Target<ITargetEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITriggeredEntity:
				_o.Target.Value = ((this.Target<ITriggeredEntity>() != null) ? this.Target<ITriggeredEntity>().Value.UnPack() : null);
				break;
			}
			_o.IsHolding = this.IsHolding;
			_o.TargetElementalType = this.TargetElementalType;
			_o.ElementalBoxId = this.ElementalBoxId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601FA80 RID: 129664 RVA: 0x00466E08 File Offset: 0x00465008
		public static Offset<ICheckIsTargetHoldElementalBox> Pack(FlatBufferBuilder builder, ICheckIsTargetHoldElementalBoxT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckIsTargetHoldElementalBox>);
			}
			TTargetEntity target_type = (_o.Target == null) ? TTargetEntity.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.Target);
			return ICheckIsTargetHoldElementalBox.CreateICheckIsTargetHoldElementalBox(builder, _o.Type, target_type, targetOffset, _o.IsHolding, _o.TargetElementalType, _o.ElementalBoxId, _o.NullMask);
		}

		// Token: 0x0400DDF7 RID: 56823
		private Table __p;
	}
}
