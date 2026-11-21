using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063EF RID: 25583
	public struct IFollowShooterJellyFishAbility : IFlatbufferObject
	{
		// Token: 0x1700BD02 RID: 48386
		// (get) Token: 0x0602B75E RID: 178014 RVA: 0x005EBCA6 File Offset: 0x005E9EA6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B75F RID: 178015 RVA: 0x005EBCB3 File Offset: 0x005E9EB3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B760 RID: 178016 RVA: 0x005EBCBC File Offset: 0x005E9EBC
		public static IFollowShooterJellyFishAbility GetRootAsIFollowShooterJellyFishAbility(ByteBuffer _bb)
		{
			return IFollowShooterJellyFishAbility.GetRootAsIFollowShooterJellyFishAbility(_bb, default(IFollowShooterJellyFishAbility));
		}

		// Token: 0x0602B761 RID: 178017 RVA: 0x005EBCD8 File Offset: 0x005E9ED8
		public static IFollowShooterJellyFishAbility GetRootAsIFollowShooterJellyFishAbility(ByteBuffer _bb, IFollowShooterJellyFishAbility obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B762 RID: 178018 RVA: 0x005EBCF5 File Offset: 0x005E9EF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B763 RID: 178019 RVA: 0x005EBD04 File Offset: 0x005E9F04
		public IFollowShooterJellyFishAbility __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD03 RID: 48387
		// (get) Token: 0x0602B764 RID: 178020 RVA: 0x005EBD14 File Offset: 0x005E9F14
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

		// Token: 0x0602B765 RID: 178021 RVA: 0x005EBD50 File Offset: 0x005E9F50
		public EJellyFishAbilityType Abilities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return EJellyFishAbilityType.Shine;
			}
			return (EJellyFishAbilityType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700BD04 RID: 48388
		// (get) Token: 0x0602B766 RID: 178022 RVA: 0x005EBD90 File Offset: 0x005E9F90
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

		// Token: 0x0602B767 RID: 178023 RVA: 0x005EBDBB File Offset: 0x005E9FBB
		public Span<EJellyFishAbilityType> GetAbilitiesBytes()
		{
			return this.__p.__vector_as_span<EJellyFishAbilityType>(6, 1);
		}

		// Token: 0x0602B768 RID: 178024 RVA: 0x005EBDCC File Offset: 0x005E9FCC
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

		// Token: 0x0602B769 RID: 178025 RVA: 0x005EBE35 File Offset: 0x005EA035
		public static Offset<IFollowShooterJellyFishAbility> CreateIFollowShooterJellyFishAbility(FlatBufferBuilder builder, EFollowShooterType Type = EFollowShooterType.JellyFish, VectorOffset AbilitiesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IFollowShooterJellyFishAbility.AddAbilities(builder, AbilitiesOffset);
			IFollowShooterJellyFishAbility.AddType(builder, Type);
			return IFollowShooterJellyFishAbility.EndIFollowShooterJellyFishAbility(builder);
		}

		// Token: 0x0602B76A RID: 178026 RVA: 0x005EBE52 File Offset: 0x005EA052
		public static void StartIFollowShooterJellyFishAbility(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B76B RID: 178027 RVA: 0x005EBE5B File Offset: 0x005EA05B
		public static void AddType(FlatBufferBuilder builder, EFollowShooterType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B76C RID: 178028 RVA: 0x005EBE66 File Offset: 0x005EA066
		public static void AddAbilities(FlatBufferBuilder builder, VectorOffset abilitiesOffset)
		{
			builder.AddOffset(1, abilitiesOffset.Value, 0);
		}

		// Token: 0x0602B76D RID: 178029 RVA: 0x005EBE78 File Offset: 0x005EA078
		public static VectorOffset CreateAbilitiesVector(FlatBufferBuilder builder, EJellyFishAbilityType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602B76E RID: 178030 RVA: 0x005EBEAF File Offset: 0x005EA0AF
		public static VectorOffset CreateAbilitiesVectorBlock(FlatBufferBuilder builder, EJellyFishAbilityType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<EJellyFishAbilityType>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B76F RID: 178031 RVA: 0x005EBEC9 File Offset: 0x005EA0C9
		public static VectorOffset CreateAbilitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<EJellyFishAbilityType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<EJellyFishAbilityType>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B770 RID: 178032 RVA: 0x005EBEE7 File Offset: 0x005EA0E7
		public static VectorOffset CreateAbilitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EJellyFishAbilityType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602B771 RID: 178033 RVA: 0x005EBF00 File Offset: 0x005EA100
		public static void StartAbilitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602B772 RID: 178034 RVA: 0x005EBF0B File Offset: 0x005EA10B
		public static Offset<IFollowShooterJellyFishAbility> EndIFollowShooterJellyFishAbility(FlatBufferBuilder builder)
		{
			return new Offset<IFollowShooterJellyFishAbility>(builder.EndTable());
		}

		// Token: 0x0602B773 RID: 178035 RVA: 0x005EBF18 File Offset: 0x005EA118
		public IFollowShooterJellyFishAbilityT UnPack()
		{
			IFollowShooterJellyFishAbilityT followShooterJellyFishAbilityT = new IFollowShooterJellyFishAbilityT();
			this.UnPackTo(followShooterJellyFishAbilityT);
			return followShooterJellyFishAbilityT;
		}

		// Token: 0x0602B774 RID: 178036 RVA: 0x005EBF34 File Offset: 0x005EA134
		public void UnPackTo(IFollowShooterJellyFishAbilityT _o)
		{
			_o.Type = this.Type;
			_o.Abilities = new List<EJellyFishAbilityType>();
			for (int i = 0; i < this.AbilitiesLength; i++)
			{
				_o.Abilities.Add(this.Abilities(i));
			}
		}

		// Token: 0x0602B775 RID: 178037 RVA: 0x005EBF7C File Offset: 0x005EA17C
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

		// Token: 0x040104EA RID: 66794
		private Table __p;
	}
}
