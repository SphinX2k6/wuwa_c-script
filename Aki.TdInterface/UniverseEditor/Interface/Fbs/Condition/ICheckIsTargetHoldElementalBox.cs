using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A9F RID: 19103
	public struct ICheckIsTargetHoldElementalBox : IFlatbufferObject
	{
		// Token: 0x17008A69 RID: 35433
		// (get) Token: 0x0601DF7A RID: 122746 RVA: 0x00435112 File Offset: 0x00433312
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DF7B RID: 122747 RVA: 0x0043511F File Offset: 0x0043331F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DF7C RID: 122748 RVA: 0x00435128 File Offset: 0x00433328
		public static ICheckIsTargetHoldElementalBox GetRootAsICheckIsTargetHoldElementalBox(ByteBuffer _bb)
		{
			return ICheckIsTargetHoldElementalBox.GetRootAsICheckIsTargetHoldElementalBox(_bb, default(ICheckIsTargetHoldElementalBox));
		}

		// Token: 0x0601DF7D RID: 122749 RVA: 0x00435144 File Offset: 0x00433344
		public static ICheckIsTargetHoldElementalBox GetRootAsICheckIsTargetHoldElementalBox(ByteBuffer _bb, ICheckIsTargetHoldElementalBox obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DF7E RID: 122750 RVA: 0x00435161 File Offset: 0x00433361
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DF7F RID: 122751 RVA: 0x00435170 File Offset: 0x00433370
		public ICheckIsTargetHoldElementalBox __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A6A RID: 35434
		// (get) Token: 0x0601DF80 RID: 122752 RVA: 0x00435180 File Offset: 0x00433380
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

		// Token: 0x17008A6B RID: 35435
		// (get) Token: 0x0601DF81 RID: 122753 RVA: 0x004351BC File Offset: 0x004333BC
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

		// Token: 0x0601DF82 RID: 122754 RVA: 0x004351F8 File Offset: 0x004333F8
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601DF83 RID: 122755 RVA: 0x0043523C File Offset: 0x0043343C
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x0601DF84 RID: 122756 RVA: 0x00435258 File Offset: 0x00433458
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x0601DF85 RID: 122757 RVA: 0x00435274 File Offset: 0x00433474
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x0601DF86 RID: 122758 RVA: 0x00435290 File Offset: 0x00433490
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x17008A6C RID: 35436
		// (get) Token: 0x0601DF87 RID: 122759 RVA: 0x004352AC File Offset: 0x004334AC
		public bool IsHolding
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008A6D RID: 35437
		// (get) Token: 0x0601DF88 RID: 122760 RVA: 0x004352EC File Offset: 0x004334EC
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

		// Token: 0x17008A6E RID: 35438
		// (get) Token: 0x0601DF89 RID: 122761 RVA: 0x0043532C File Offset: 0x0043352C
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

		// Token: 0x17008A6F RID: 35439
		// (get) Token: 0x0601DF8A RID: 122762 RVA: 0x0043536C File Offset: 0x0043356C
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

		// Token: 0x0601DF8B RID: 122763 RVA: 0x004353AC File Offset: 0x004335AC
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

		// Token: 0x0601DF8C RID: 122764 RVA: 0x004353FB File Offset: 0x004335FB
		public static void StartICheckIsTargetHoldElementalBox(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601DF8D RID: 122765 RVA: 0x00435404 File Offset: 0x00433604
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DF8E RID: 122766 RVA: 0x0043540F File Offset: 0x0043360F
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0601DF8F RID: 122767 RVA: 0x0043541A File Offset: 0x0043361A
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0601DF90 RID: 122768 RVA: 0x00435425 File Offset: 0x00433625
		public static void AddIsHolding(FlatBufferBuilder builder, bool isHolding)
		{
			builder.AddBool(3, isHolding, false);
		}

		// Token: 0x0601DF91 RID: 122769 RVA: 0x00435430 File Offset: 0x00433630
		public static void AddTargetElementalType(FlatBufferBuilder builder, EElementalType targetElementalType)
		{
			builder.AddByte(4, (byte)targetElementalType, 0);
		}

		// Token: 0x0601DF92 RID: 122770 RVA: 0x0043543B File Offset: 0x0043363B
		public static void AddElementalBoxId(FlatBufferBuilder builder, int elementalBoxId)
		{
			builder.AddInt(5, elementalBoxId, 0);
		}

		// Token: 0x0601DF93 RID: 122771 RVA: 0x00435446 File Offset: 0x00433646
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0601DF94 RID: 122772 RVA: 0x00435451 File Offset: 0x00433651
		public static Offset<ICheckIsTargetHoldElementalBox> EndICheckIsTargetHoldElementalBox(FlatBufferBuilder builder)
		{
			return new Offset<ICheckIsTargetHoldElementalBox>(builder.EndTable());
		}

		// Token: 0x0601DF95 RID: 122773 RVA: 0x00435460 File Offset: 0x00433660
		public ICheckIsTargetHoldElementalBoxT UnPack()
		{
			ICheckIsTargetHoldElementalBoxT checkIsTargetHoldElementalBoxT = new ICheckIsTargetHoldElementalBoxT();
			this.UnPackTo(checkIsTargetHoldElementalBoxT);
			return checkIsTargetHoldElementalBoxT;
		}

		// Token: 0x0601DF96 RID: 122774 RVA: 0x0043547C File Offset: 0x0043367C
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

		// Token: 0x0601DF97 RID: 122775 RVA: 0x004355E8 File Offset: 0x004337E8
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

		// Token: 0x0400D312 RID: 54034
		private Table __p;
	}
}
