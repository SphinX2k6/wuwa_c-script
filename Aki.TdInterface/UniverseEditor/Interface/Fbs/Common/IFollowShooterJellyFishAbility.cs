using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DB2 RID: 23986
	public struct IFollowShooterJellyFishAbility : IFlatbufferObject
	{
		// Token: 0x1700B39C RID: 45980
		// (get) Token: 0x060290D4 RID: 168148 RVA: 0x005A2F76 File Offset: 0x005A1176
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060290D5 RID: 168149 RVA: 0x005A2F83 File Offset: 0x005A1183
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060290D6 RID: 168150 RVA: 0x005A2F8C File Offset: 0x005A118C
		public static IFollowShooterJellyFishAbility GetRootAsIFollowShooterJellyFishAbility(ByteBuffer _bb)
		{
			return IFollowShooterJellyFishAbility.GetRootAsIFollowShooterJellyFishAbility(_bb, default(IFollowShooterJellyFishAbility));
		}

		// Token: 0x060290D7 RID: 168151 RVA: 0x005A2FA8 File Offset: 0x005A11A8
		public static IFollowShooterJellyFishAbility GetRootAsIFollowShooterJellyFishAbility(ByteBuffer _bb, IFollowShooterJellyFishAbility obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060290D8 RID: 168152 RVA: 0x005A2FC5 File Offset: 0x005A11C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060290D9 RID: 168153 RVA: 0x005A2FD4 File Offset: 0x005A11D4
		public IFollowShooterJellyFishAbility __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B39D RID: 45981
		// (get) Token: 0x060290DA RID: 168154 RVA: 0x005A2FE4 File Offset: 0x005A11E4
		public EFollowShooterType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFollowShooterType.JellyFish;
				}
				return (EFollowShooterType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060290DB RID: 168155 RVA: 0x005A3020 File Offset: 0x005A1220
		public EJellyFishAbilityType Abilities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return EJellyFishAbilityType.Shine;
			}
			return (EJellyFishAbilityType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700B39E RID: 45982
		// (get) Token: 0x060290DC RID: 168156 RVA: 0x005A3060 File Offset: 0x005A1260
		public int AbilitiesLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060290DD RID: 168157 RVA: 0x005A308B File Offset: 0x005A128B
		public Span<EJellyFishAbilityType> GetAbilitiesBytes()
		{
			return this.__p.__vector_as_span<EJellyFishAbilityType>(6, 1);
		}

		// Token: 0x060290DE RID: 168158 RVA: 0x005A309C File Offset: 0x005A129C
		public EJellyFishAbilityType[] GetAbilitiesArray()
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			EJellyFishAbilityType[] array = new EJellyFishAbilityType[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (EJellyFishAbilityType)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x060290DF RID: 168159 RVA: 0x005A3105 File Offset: 0x005A1305
		public static Offset<IFollowShooterJellyFishAbility> CreateIFollowShooterJellyFishAbility(FlatBufferBuilder builder, EFollowShooterType Type = EFollowShooterType.JellyFish, VectorOffset AbilitiesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IFollowShooterJellyFishAbility.AddAbilities(builder, AbilitiesOffset);
			IFollowShooterJellyFishAbility.AddType(builder, Type);
			return IFollowShooterJellyFishAbility.EndIFollowShooterJellyFishAbility(builder);
		}

		// Token: 0x060290E0 RID: 168160 RVA: 0x005A3122 File Offset: 0x005A1322
		public static void StartIFollowShooterJellyFishAbility(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060290E1 RID: 168161 RVA: 0x005A312B File Offset: 0x005A132B
		public static void AddType(FlatBufferBuilder builder, EFollowShooterType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060290E2 RID: 168162 RVA: 0x005A3136 File Offset: 0x005A1336
		public static void AddAbilities(FlatBufferBuilder builder, VectorOffset abilitiesOffset)
		{
			builder.AddOffset(1, abilitiesOffset.Value, 0);
		}

		// Token: 0x060290E3 RID: 168163 RVA: 0x005A3148 File Offset: 0x005A1348
		public static VectorOffset CreateAbilitiesVector(FlatBufferBuilder builder, EJellyFishAbilityType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060290E4 RID: 168164 RVA: 0x005A317F File Offset: 0x005A137F
		public static VectorOffset CreateAbilitiesVectorBlock(FlatBufferBuilder builder, EJellyFishAbilityType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<EJellyFishAbilityType>(data);
			return builder.EndVector();
		}

		// Token: 0x060290E5 RID: 168165 RVA: 0x005A3199 File Offset: 0x005A1399
		public static VectorOffset CreateAbilitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<EJellyFishAbilityType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<EJellyFishAbilityType>(data);
			return builder.EndVector();
		}

		// Token: 0x060290E6 RID: 168166 RVA: 0x005A31B7 File Offset: 0x005A13B7
		public static VectorOffset CreateAbilitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EJellyFishAbilityType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060290E7 RID: 168167 RVA: 0x005A31D0 File Offset: 0x005A13D0
		public static void StartAbilitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060290E8 RID: 168168 RVA: 0x005A31DB File Offset: 0x005A13DB
		public static Offset<IFollowShooterJellyFishAbility> EndIFollowShooterJellyFishAbility(FlatBufferBuilder builder)
		{
			return new Offset<IFollowShooterJellyFishAbility>(builder.EndTable());
		}

		// Token: 0x060290E9 RID: 168169 RVA: 0x005A31E8 File Offset: 0x005A13E8
		public IFollowShooterJellyFishAbilityT UnPack()
		{
			IFollowShooterJellyFishAbilityT followShooterJellyFishAbilityT = new IFollowShooterJellyFishAbilityT();
			this.UnPackTo(followShooterJellyFishAbilityT);
			return followShooterJellyFishAbilityT;
		}

		// Token: 0x060290EA RID: 168170 RVA: 0x005A3204 File Offset: 0x005A1404
		public void UnPackTo(IFollowShooterJellyFishAbilityT _o)
		{
			_o.Type = this.Type;
			_o.Abilities = new List<EJellyFishAbilityType>();
			for (int i = 0; i < this.AbilitiesLength; i++)
			{
				_o.Abilities.Add(this.Abilities(i));
			}
		}

		// Token: 0x060290EB RID: 168171 RVA: 0x005A324C File Offset: 0x005A144C
		public static Offset<IFollowShooterJellyFishAbility> Pack(FlatBufferBuilder builder, IFollowShooterJellyFishAbilityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFollowShooterJellyFishAbility>);
			}
			VectorOffset abilitiesOffset = default(VectorOffset);
			if (_o.Abilities != null)
			{
				EJellyFishAbilityType[] data = _o.Abilities.ToArray();
				abilitiesOffset = IFollowShooterJellyFishAbility.CreateAbilitiesVector(builder, data);
			}
			return IFollowShooterJellyFishAbility.CreateIFollowShooterJellyFishAbility(builder, _o.Type, abilitiesOffset);
		}

		// Token: 0x0400F78F RID: 63375
		private Table __p;
	}
}
