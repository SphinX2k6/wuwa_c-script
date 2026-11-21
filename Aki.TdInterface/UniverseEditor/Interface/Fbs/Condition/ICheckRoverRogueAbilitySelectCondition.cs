using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005007 RID: 20487
	public struct ICheckRoverRogueAbilitySelectCondition : IFlatbufferObject
	{
		// Token: 0x1700928D RID: 37517
		// (get) Token: 0x0601FF87 RID: 130951 RVA: 0x0046FF0E File Offset: 0x0046E10E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FF88 RID: 130952 RVA: 0x0046FF1B File Offset: 0x0046E11B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FF89 RID: 130953 RVA: 0x0046FF24 File Offset: 0x0046E124
		public static ICheckRoverRogueAbilitySelectCondition GetRootAsICheckRoverRogueAbilitySelectCondition(ByteBuffer _bb)
		{
			return ICheckRoverRogueAbilitySelectCondition.GetRootAsICheckRoverRogueAbilitySelectCondition(_bb, default(ICheckRoverRogueAbilitySelectCondition));
		}

		// Token: 0x0601FF8A RID: 130954 RVA: 0x0046FF40 File Offset: 0x0046E140
		public static ICheckRoverRogueAbilitySelectCondition GetRootAsICheckRoverRogueAbilitySelectCondition(ByteBuffer _bb, ICheckRoverRogueAbilitySelectCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FF8B RID: 130955 RVA: 0x0046FF5D File Offset: 0x0046E15D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FF8C RID: 130956 RVA: 0x0046FF6C File Offset: 0x0046E16C
		public ICheckRoverRogueAbilitySelectCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700928E RID: 37518
		// (get) Token: 0x0601FF8D RID: 130957 RVA: 0x0046FF7C File Offset: 0x0046E17C
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

		// Token: 0x1700928F RID: 37519
		// (get) Token: 0x0601FF8E RID: 130958 RVA: 0x0046FFB8 File Offset: 0x0046E1B8
		public ERoverRogueAbilitySelectType SelectType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ERoverRogueAbilitySelectType.Shop;
				}
				return (ERoverRogueAbilitySelectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009290 RID: 37520
		// (get) Token: 0x0601FF8F RID: 130959 RVA: 0x0046FFF4 File Offset: 0x0046E1F4
		public bool IsReceived
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601FF90 RID: 130960 RVA: 0x00470033 File Offset: 0x0046E233
		public static Offset<ICheckRoverRogueAbilitySelectCondition> CreateICheckRoverRogueAbilitySelectCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ERoverRogueAbilitySelectType SelectType = ERoverRogueAbilitySelectType.Shop, bool IsReceived = false)
		{
			builder.StartTable(3);
			ICheckRoverRogueAbilitySelectCondition.AddIsReceived(builder, IsReceived);
			ICheckRoverRogueAbilitySelectCondition.AddSelectType(builder, SelectType);
			ICheckRoverRogueAbilitySelectCondition.AddType(builder, Type);
			return ICheckRoverRogueAbilitySelectCondition.EndICheckRoverRogueAbilitySelectCondition(builder);
		}

		// Token: 0x0601FF91 RID: 130961 RVA: 0x00470057 File Offset: 0x0046E257
		public static void StartICheckRoverRogueAbilitySelectCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601FF92 RID: 130962 RVA: 0x00470060 File Offset: 0x0046E260
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FF93 RID: 130963 RVA: 0x0047006B File Offset: 0x0046E26B
		public static void AddSelectType(FlatBufferBuilder builder, ERoverRogueAbilitySelectType selectType)
		{
			builder.AddByte(1, (byte)selectType, 0);
		}

		// Token: 0x0601FF94 RID: 130964 RVA: 0x00470076 File Offset: 0x0046E276
		public static void AddIsReceived(FlatBufferBuilder builder, bool isReceived)
		{
			builder.AddBool(2, isReceived, false);
		}

		// Token: 0x0601FF95 RID: 130965 RVA: 0x00470081 File Offset: 0x0046E281
		public static Offset<ICheckRoverRogueAbilitySelectCondition> EndICheckRoverRogueAbilitySelectCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckRoverRogueAbilitySelectCondition>(builder.EndTable());
		}

		// Token: 0x0601FF96 RID: 130966 RVA: 0x00470090 File Offset: 0x0046E290
		public ICheckRoverRogueAbilitySelectConditionT UnPack()
		{
			ICheckRoverRogueAbilitySelectConditionT checkRoverRogueAbilitySelectConditionT = new ICheckRoverRogueAbilitySelectConditionT();
			this.UnPackTo(checkRoverRogueAbilitySelectConditionT);
			return checkRoverRogueAbilitySelectConditionT;
		}

		// Token: 0x0601FF97 RID: 130967 RVA: 0x004700AB File Offset: 0x0046E2AB
		public void UnPackTo(ICheckRoverRogueAbilitySelectConditionT _o)
		{
			_o.Type = this.Type;
			_o.SelectType = this.SelectType;
			_o.IsReceived = this.IsReceived;
		}

		// Token: 0x0601FF98 RID: 130968 RVA: 0x004700D4 File Offset: 0x0046E2D4
		public static Offset<ICheckRoverRogueAbilitySelectCondition> Pack(FlatBufferBuilder builder, ICheckRoverRogueAbilitySelectConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckRoverRogueAbilitySelectCondition>);
			}
			return ICheckRoverRogueAbilitySelectCondition.CreateICheckRoverRogueAbilitySelectCondition(builder, _o.Type, _o.SelectType, _o.IsReceived);
		}

		// Token: 0x0400DEBF RID: 57023
		private Table __p;
	}
}
