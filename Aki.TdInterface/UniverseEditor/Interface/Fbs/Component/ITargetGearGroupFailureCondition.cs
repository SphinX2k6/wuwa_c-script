using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A2E RID: 23086
	public struct ITargetGearGroupFailureCondition : IFlatbufferObject
	{
		// Token: 0x1700ADA9 RID: 44457
		// (get) Token: 0x060273EE RID: 160750 RVA: 0x0056698C File Offset: 0x00564B8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060273EF RID: 160751 RVA: 0x00566999 File Offset: 0x00564B99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060273F0 RID: 160752 RVA: 0x005669A0 File Offset: 0x00564BA0
		public static ITargetGearGroupFailureCondition GetRootAsITargetGearGroupFailureCondition(ByteBuffer _bb)
		{
			return ITargetGearGroupFailureCondition.GetRootAsITargetGearGroupFailureCondition(_bb, default(ITargetGearGroupFailureCondition));
		}

		// Token: 0x060273F1 RID: 160753 RVA: 0x005669BC File Offset: 0x00564BBC
		public static ITargetGearGroupFailureCondition GetRootAsITargetGearGroupFailureCondition(ByteBuffer _bb, ITargetGearGroupFailureCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060273F2 RID: 160754 RVA: 0x005669D9 File Offset: 0x00564BD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060273F3 RID: 160755 RVA: 0x005669E8 File Offset: 0x00564BE8
		public ITargetGearGroupFailureCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ADAA RID: 44458
		// (get) Token: 0x060273F4 RID: 160756 RVA: 0x005669F8 File Offset: 0x00564BF8
		public ETargetGearGroupFailureCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetGearGroupFailureCondition.ArbitraryState;
				}
				return (ETargetGearGroupFailureCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060273F5 RID: 160757 RVA: 0x00566A34 File Offset: 0x00564C34
		public static Offset<ITargetGearGroupFailureCondition> CreateITargetGearGroupFailureCondition(FlatBufferBuilder builder, ETargetGearGroupFailureCondition Type = ETargetGearGroupFailureCondition.ArbitraryState)
		{
			builder.StartTable(1);
			ITargetGearGroupFailureCondition.AddType(builder, Type);
			return ITargetGearGroupFailureCondition.EndITargetGearGroupFailureCondition(builder);
		}

		// Token: 0x060273F6 RID: 160758 RVA: 0x00566A4A File Offset: 0x00564C4A
		public static void StartITargetGearGroupFailureCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060273F7 RID: 160759 RVA: 0x00566A53 File Offset: 0x00564C53
		public static void AddType(FlatBufferBuilder builder, ETargetGearGroupFailureCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060273F8 RID: 160760 RVA: 0x00566A5E File Offset: 0x00564C5E
		public static Offset<ITargetGearGroupFailureCondition> EndITargetGearGroupFailureCondition(FlatBufferBuilder builder)
		{
			return new Offset<ITargetGearGroupFailureCondition>(builder.EndTable());
		}

		// Token: 0x060273F9 RID: 160761 RVA: 0x00566A6C File Offset: 0x00564C6C
		public ITargetGearGroupFailureConditionT UnPack()
		{
			ITargetGearGroupFailureConditionT targetGearGroupFailureConditionT = new ITargetGearGroupFailureConditionT();
			this.UnPackTo(targetGearGroupFailureConditionT);
			return targetGearGroupFailureConditionT;
		}

		// Token: 0x060273FA RID: 160762 RVA: 0x00566A87 File Offset: 0x00564C87
		public void UnPackTo(ITargetGearGroupFailureConditionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060273FB RID: 160763 RVA: 0x00566A98 File Offset: 0x00564C98
		public static Offset<ITargetGearGroupFailureCondition> Pack(FlatBufferBuilder builder, ITargetGearGroupFailureConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITargetGearGroupFailureCondition>);
			}
			return ITargetGearGroupFailureCondition.CreateITargetGearGroupFailureCondition(builder, _o.Type);
		}

		// Token: 0x0400F096 RID: 61590
		private Table __p;
	}
}
