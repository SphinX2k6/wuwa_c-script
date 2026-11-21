using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044F0 RID: 17648
	public struct IRogueAbilitySelect : IFlatbufferObject
	{
		// Token: 0x17007AE3 RID: 31459
		// (get) Token: 0x06019886 RID: 104582 RVA: 0x003A41BD File Offset: 0x003A23BD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019887 RID: 104583 RVA: 0x003A41CA File Offset: 0x003A23CA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019888 RID: 104584 RVA: 0x003A41D4 File Offset: 0x003A23D4
		public static IRogueAbilitySelect GetRootAsIRogueAbilitySelect(ByteBuffer _bb)
		{
			return IRogueAbilitySelect.GetRootAsIRogueAbilitySelect(_bb, default(IRogueAbilitySelect));
		}

		// Token: 0x06019889 RID: 104585 RVA: 0x003A41F0 File Offset: 0x003A23F0
		public static IRogueAbilitySelect GetRootAsIRogueAbilitySelect(ByteBuffer _bb, IRogueAbilitySelect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601988A RID: 104586 RVA: 0x003A420D File Offset: 0x003A240D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601988B RID: 104587 RVA: 0x003A421C File Offset: 0x003A241C
		public IRogueAbilitySelect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007AE4 RID: 31460
		// (get) Token: 0x0601988C RID: 104588 RVA: 0x003A422C File Offset: 0x003A242C
		public EShowUiType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EShowUiType.All;
				}
				return (EShowUiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007AE5 RID: 31461
		// (get) Token: 0x0601988D RID: 104589 RVA: 0x003A4268 File Offset: 0x003A2468
		public ERogueAbilityType AbilityType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ERogueAbilityType.None;
				}
				return (ERogueAbilityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007AE6 RID: 31462
		// (get) Token: 0x0601988E RID: 104590 RVA: 0x003A42A4 File Offset: 0x003A24A4
		public int BindId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601988F RID: 104591 RVA: 0x003A42E0 File Offset: 0x003A24E0
		public static Offset<IRogueAbilitySelect> CreateIRogueAbilitySelect(FlatBufferBuilder builder, EShowUiType Type = EShowUiType.All, ERogueAbilityType AbilityType = ERogueAbilityType.None, int BindId = 0)
		{
			builder.StartTable(3);
			IRogueAbilitySelect.AddBindId(builder, BindId);
			IRogueAbilitySelect.AddAbilityType(builder, AbilityType);
			IRogueAbilitySelect.AddType(builder, Type);
			return IRogueAbilitySelect.EndIRogueAbilitySelect(builder);
		}

		// Token: 0x06019890 RID: 104592 RVA: 0x003A4304 File Offset: 0x003A2504
		public static void StartIRogueAbilitySelect(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06019891 RID: 104593 RVA: 0x003A430D File Offset: 0x003A250D
		public static void AddType(FlatBufferBuilder builder, EShowUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019892 RID: 104594 RVA: 0x003A4318 File Offset: 0x003A2518
		public static void AddAbilityType(FlatBufferBuilder builder, ERogueAbilityType abilityType)
		{
			builder.AddByte(1, (byte)abilityType, 0);
		}

		// Token: 0x06019893 RID: 104595 RVA: 0x003A4323 File Offset: 0x003A2523
		public static void AddBindId(FlatBufferBuilder builder, int bindId)
		{
			builder.AddInt(2, bindId, 0);
		}

		// Token: 0x06019894 RID: 104596 RVA: 0x003A432E File Offset: 0x003A252E
		public static Offset<IRogueAbilitySelect> EndIRogueAbilitySelect(FlatBufferBuilder builder)
		{
			return new Offset<IRogueAbilitySelect>(builder.EndTable());
		}

		// Token: 0x06019895 RID: 104597 RVA: 0x003A433C File Offset: 0x003A253C
		public IRogueAbilitySelectT UnPack()
		{
			IRogueAbilitySelectT rogueAbilitySelectT = new IRogueAbilitySelectT();
			this.UnPackTo(rogueAbilitySelectT);
			return rogueAbilitySelectT;
		}

		// Token: 0x06019896 RID: 104598 RVA: 0x003A4357 File Offset: 0x003A2557
		public void UnPackTo(IRogueAbilitySelectT _o)
		{
			_o.Type = this.Type;
			_o.AbilityType = this.AbilityType;
			_o.BindId = this.BindId;
		}

		// Token: 0x06019897 RID: 104599 RVA: 0x003A4380 File Offset: 0x003A2580
		public static Offset<IRogueAbilitySelect> Pack(FlatBufferBuilder builder, IRogueAbilitySelectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRogueAbilitySelect>);
			}
			return IRogueAbilitySelect.CreateIRogueAbilitySelect(builder, _o.Type, _o.AbilityType, _o.BindId);
		}

		// Token: 0x0400C62F RID: 50735
		private Table __p;
	}
}
