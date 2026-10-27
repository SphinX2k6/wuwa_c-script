using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040AF RID: 16559
	public struct IRogueAbilitySelect : IFlatbufferObject
	{
		// Token: 0x170074DD RID: 29917
		// (get) Token: 0x060181E5 RID: 98789 RVA: 0x0037A26D File Offset: 0x0037846D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060181E6 RID: 98790 RVA: 0x0037A27A File Offset: 0x0037847A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060181E7 RID: 98791 RVA: 0x0037A284 File Offset: 0x00378484
		public static IRogueAbilitySelect GetRootAsIRogueAbilitySelect(ByteBuffer _bb)
		{
			return IRogueAbilitySelect.GetRootAsIRogueAbilitySelect(_bb, default(IRogueAbilitySelect));
		}

		// Token: 0x060181E8 RID: 98792 RVA: 0x0037A2A0 File Offset: 0x003784A0
		public static IRogueAbilitySelect GetRootAsIRogueAbilitySelect(ByteBuffer _bb, IRogueAbilitySelect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060181E9 RID: 98793 RVA: 0x0037A2BD File Offset: 0x003784BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060181EA RID: 98794 RVA: 0x0037A2CC File Offset: 0x003784CC
		public IRogueAbilitySelect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170074DE RID: 29918
		// (get) Token: 0x060181EB RID: 98795 RVA: 0x0037A2DC File Offset: 0x003784DC
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

		// Token: 0x170074DF RID: 29919
		// (get) Token: 0x060181EC RID: 98796 RVA: 0x0037A318 File Offset: 0x00378518
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

		// Token: 0x170074E0 RID: 29920
		// (get) Token: 0x060181ED RID: 98797 RVA: 0x0037A354 File Offset: 0x00378554
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

		// Token: 0x060181EE RID: 98798 RVA: 0x0037A390 File Offset: 0x00378590
		public static Offset<IRogueAbilitySelect> CreateIRogueAbilitySelect(FlatBufferBuilder builder, EShowUiType Type = EShowUiType.All, ERogueAbilityType AbilityType = ERogueAbilityType.None, int BindId = 0)
		{
			builder.StartTable(3);
			IRogueAbilitySelect.AddBindId(builder, BindId);
			IRogueAbilitySelect.AddAbilityType(builder, AbilityType);
			IRogueAbilitySelect.AddType(builder, Type);
			return IRogueAbilitySelect.EndIRogueAbilitySelect(builder);
		}

		// Token: 0x060181EF RID: 98799 RVA: 0x0037A3B4 File Offset: 0x003785B4
		public static void StartIRogueAbilitySelect(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060181F0 RID: 98800 RVA: 0x0037A3BD File Offset: 0x003785BD
		public static void AddType(FlatBufferBuilder builder, EShowUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060181F1 RID: 98801 RVA: 0x0037A3C8 File Offset: 0x003785C8
		public static void AddAbilityType(FlatBufferBuilder builder, ERogueAbilityType abilityType)
		{
			builder.AddByte(1, (byte)abilityType, 0);
		}

		// Token: 0x060181F2 RID: 98802 RVA: 0x0037A3D3 File Offset: 0x003785D3
		public static void AddBindId(FlatBufferBuilder builder, int bindId)
		{
			builder.AddInt(2, bindId, 0);
		}

		// Token: 0x060181F3 RID: 98803 RVA: 0x0037A3DE File Offset: 0x003785DE
		public static Offset<IRogueAbilitySelect> EndIRogueAbilitySelect(FlatBufferBuilder builder)
		{
			return new Offset<IRogueAbilitySelect>(builder.EndTable());
		}

		// Token: 0x060181F4 RID: 98804 RVA: 0x0037A3EC File Offset: 0x003785EC
		public IRogueAbilitySelectT UnPack()
		{
			IRogueAbilitySelectT rogueAbilitySelectT = new IRogueAbilitySelectT();
			this.UnPackTo(rogueAbilitySelectT);
			return rogueAbilitySelectT;
		}

		// Token: 0x060181F5 RID: 98805 RVA: 0x0037A407 File Offset: 0x00378607
		public void UnPackTo(IRogueAbilitySelectT _o)
		{
			_o.Type = this.Type;
			_o.AbilityType = this.AbilityType;
			_o.BindId = this.BindId;
		}

		// Token: 0x060181F6 RID: 98806 RVA: 0x0037A430 File Offset: 0x00378630
		public static Offset<IRogueAbilitySelect> Pack(FlatBufferBuilder builder, IRogueAbilitySelectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRogueAbilitySelect>);
			}
			return IRogueAbilitySelect.CreateIRogueAbilitySelect(builder, _o.Type, _o.AbilityType, _o.BindId);
		}

		// Token: 0x0400BC46 RID: 48198
		private Table __p;
	}
}
