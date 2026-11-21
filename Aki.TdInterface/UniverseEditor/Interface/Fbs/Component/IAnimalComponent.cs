using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053CD RID: 21453
	public struct IAnimalComponent : IFlatbufferObject
	{
		// Token: 0x170097BF RID: 38847
		// (get) Token: 0x060217F5 RID: 137205 RVA: 0x0049EB69 File Offset: 0x0049CD69
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060217F6 RID: 137206 RVA: 0x0049EB76 File Offset: 0x0049CD76
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060217F7 RID: 137207 RVA: 0x0049EB80 File Offset: 0x0049CD80
		public static IAnimalComponent GetRootAsIAnimalComponent(ByteBuffer _bb)
		{
			return IAnimalComponent.GetRootAsIAnimalComponent(_bb, default(IAnimalComponent));
		}

		// Token: 0x060217F8 RID: 137208 RVA: 0x0049EB9C File Offset: 0x0049CD9C
		public static IAnimalComponent GetRootAsIAnimalComponent(ByteBuffer _bb, IAnimalComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060217F9 RID: 137209 RVA: 0x0049EBB9 File Offset: 0x0049CDB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060217FA RID: 137210 RVA: 0x0049EBC8 File Offset: 0x0049CDC8
		public IAnimalComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170097C0 RID: 38848
		// (get) Token: 0x060217FB RID: 137211 RVA: 0x0049EBD8 File Offset: 0x0049CDD8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170097C1 RID: 38849
		// (get) Token: 0x060217FC RID: 137212 RVA: 0x0049EC18 File Offset: 0x0049CE18
		public bool IsStare
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170097C2 RID: 38850
		// (get) Token: 0x060217FD RID: 137213 RVA: 0x0049EC58 File Offset: 0x0049CE58
		public int AnimalAttackRange
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

		// Token: 0x170097C3 RID: 38851
		// (get) Token: 0x060217FE RID: 137214 RVA: 0x0049EC94 File Offset: 0x0049CE94
		public int MoveRange
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170097C4 RID: 38852
		// (get) Token: 0x060217FF RID: 137215 RVA: 0x0049ECD4 File Offset: 0x0049CED4
		public bool UseRangeComponentAsMoveRange
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170097C5 RID: 38853
		// (get) Token: 0x06021800 RID: 137216 RVA: 0x0049ED14 File Offset: 0x0049CF14
		public bool CanKillSelf
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170097C6 RID: 38854
		// (get) Token: 0x06021801 RID: 137217 RVA: 0x0049ED54 File Offset: 0x0049CF54
		public bool PlayDeathAnimOnDestroy
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170097C7 RID: 38855
		// (get) Token: 0x06021802 RID: 137218 RVA: 0x0049ED94 File Offset: 0x0049CF94
		public ICollectAnimalConfig? SpecialAnimalConfig
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new ICollectAnimalConfig?(default(ICollectAnimalConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06021803 RID: 137219 RVA: 0x0049EDF4 File Offset: 0x0049CFF4
		public IAnimalEmotionBubbleEntry? EmotionBubbleMap(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new IAnimalEmotionBubbleEntry?(default(IAnimalEmotionBubbleEntry).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170097C8 RID: 38856
		// (get) Token: 0x06021804 RID: 137220 RVA: 0x0049EE58 File Offset: 0x0049D058
		public int EmotionBubbleMapLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06021805 RID: 137221 RVA: 0x0049EE84 File Offset: 0x0049D084
		public EExtraMovementAbility ExtraMovementAbilities(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return EExtraMovementAbility.Diving;
			}
			return (EExtraMovementAbility)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x170097C9 RID: 38857
		// (get) Token: 0x06021806 RID: 137222 RVA: 0x0049EEC4 File Offset: 0x0049D0C4
		public int ExtraMovementAbilitiesLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06021807 RID: 137223 RVA: 0x0049EEF0 File Offset: 0x0049D0F0
		public Span<EExtraMovementAbility> GetExtraMovementAbilitiesBytes()
		{
			return this.__p.__vector_as_span<EExtraMovementAbility>(22, 1);
		}

		// Token: 0x06021808 RID: 137224 RVA: 0x0049EF00 File Offset: 0x0049D100
		public EExtraMovementAbility[] GetExtraMovementAbilitiesArray()
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			EExtraMovementAbility[] array = new EExtraMovementAbility[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (EExtraMovementAbility)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x170097CA RID: 38858
		// (get) Token: 0x06021809 RID: 137225 RVA: 0x0049EF6C File Offset: 0x0049D16C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602180A RID: 137226 RVA: 0x0049EFAC File Offset: 0x0049D1AC
		public static Offset<IAnimalComponent> CreateIAnimalComponent(FlatBufferBuilder builder, bool Disabled = false, bool IsStare = false, int AnimalAttackRange = 0, int MoveRange = 0, bool UseRangeComponentAsMoveRange = false, bool CanKillSelf = false, bool PlayDeathAnimOnDestroy = false, Offset<ICollectAnimalConfig> SpecialAnimalConfigOffset = default(Offset<ICollectAnimalConfig>), VectorOffset EmotionBubbleMapOffset = default(VectorOffset), VectorOffset ExtraMovementAbilitiesOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(11);
			IAnimalComponent.AddExtraMovementAbilities(builder, ExtraMovementAbilitiesOffset);
			IAnimalComponent.AddEmotionBubbleMap(builder, EmotionBubbleMapOffset);
			IAnimalComponent.AddSpecialAnimalConfig(builder, SpecialAnimalConfigOffset);
			IAnimalComponent.AddMoveRange(builder, MoveRange);
			IAnimalComponent.AddAnimalAttackRange(builder, AnimalAttackRange);
			IAnimalComponent.AddNullMask(builder, NullMask);
			IAnimalComponent.AddPlayDeathAnimOnDestroy(builder, PlayDeathAnimOnDestroy);
			IAnimalComponent.AddCanKillSelf(builder, CanKillSelf);
			IAnimalComponent.AddUseRangeComponentAsMoveRange(builder, UseRangeComponentAsMoveRange);
			IAnimalComponent.AddIsStare(builder, IsStare);
			IAnimalComponent.AddDisabled(builder, Disabled);
			return IAnimalComponent.EndIAnimalComponent(builder);
		}

		// Token: 0x0602180B RID: 137227 RVA: 0x0049F01C File Offset: 0x0049D21C
		public static void StartIAnimalComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x0602180C RID: 137228 RVA: 0x0049F026 File Offset: 0x0049D226
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602180D RID: 137229 RVA: 0x0049F031 File Offset: 0x0049D231
		public static void AddIsStare(FlatBufferBuilder builder, bool isStare)
		{
			builder.AddBool(1, isStare, false);
		}

		// Token: 0x0602180E RID: 137230 RVA: 0x0049F03C File Offset: 0x0049D23C
		public static void AddAnimalAttackRange(FlatBufferBuilder builder, int animalAttackRange)
		{
			builder.AddInt(2, animalAttackRange, 0);
		}

		// Token: 0x0602180F RID: 137231 RVA: 0x0049F047 File Offset: 0x0049D247
		public static void AddMoveRange(FlatBufferBuilder builder, int moveRange)
		{
			builder.AddInt(3, moveRange, 0);
		}

		// Token: 0x06021810 RID: 137232 RVA: 0x0049F052 File Offset: 0x0049D252
		public static void AddUseRangeComponentAsMoveRange(FlatBufferBuilder builder, bool useRangeComponentAsMoveRange)
		{
			builder.AddBool(4, useRangeComponentAsMoveRange, false);
		}

		// Token: 0x06021811 RID: 137233 RVA: 0x0049F05D File Offset: 0x0049D25D
		public static void AddCanKillSelf(FlatBufferBuilder builder, bool canKillSelf)
		{
			builder.AddBool(5, canKillSelf, false);
		}

		// Token: 0x06021812 RID: 137234 RVA: 0x0049F068 File Offset: 0x0049D268
		public static void AddPlayDeathAnimOnDestroy(FlatBufferBuilder builder, bool playDeathAnimOnDestroy)
		{
			builder.AddBool(6, playDeathAnimOnDestroy, false);
		}

		// Token: 0x06021813 RID: 137235 RVA: 0x0049F073 File Offset: 0x0049D273
		public static void AddSpecialAnimalConfig(FlatBufferBuilder builder, Offset<ICollectAnimalConfig> specialAnimalConfigOffset)
		{
			builder.AddOffset(7, specialAnimalConfigOffset.Value, 0);
		}

		// Token: 0x06021814 RID: 137236 RVA: 0x0049F083 File Offset: 0x0049D283
		public static void AddEmotionBubbleMap(FlatBufferBuilder builder, VectorOffset emotionBubbleMapOffset)
		{
			builder.AddOffset(8, emotionBubbleMapOffset.Value, 0);
		}

		// Token: 0x06021815 RID: 137237 RVA: 0x0049F094 File Offset: 0x0049D294
		public static VectorOffset CreateEmotionBubbleMapVector(FlatBufferBuilder builder, Offset<IAnimalEmotionBubbleEntry>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021816 RID: 137238 RVA: 0x0049F0D4 File Offset: 0x0049D2D4
		public static VectorOffset CreateEmotionBubbleMapVectorBlock(FlatBufferBuilder builder, Offset<IAnimalEmotionBubbleEntry>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IAnimalEmotionBubbleEntry>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021817 RID: 137239 RVA: 0x0049F0EE File Offset: 0x0049D2EE
		public static VectorOffset CreateEmotionBubbleMapVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IAnimalEmotionBubbleEntry>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IAnimalEmotionBubbleEntry>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021818 RID: 137240 RVA: 0x0049F10C File Offset: 0x0049D30C
		public static VectorOffset CreateEmotionBubbleMapVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IAnimalEmotionBubbleEntry>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021819 RID: 137241 RVA: 0x0049F125 File Offset: 0x0049D325
		public static void StartEmotionBubbleMapVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602181A RID: 137242 RVA: 0x0049F130 File Offset: 0x0049D330
		public static void AddExtraMovementAbilities(FlatBufferBuilder builder, VectorOffset extraMovementAbilitiesOffset)
		{
			builder.AddOffset(9, extraMovementAbilitiesOffset.Value, 0);
		}

		// Token: 0x0602181B RID: 137243 RVA: 0x0049F144 File Offset: 0x0049D344
		public static VectorOffset CreateExtraMovementAbilitiesVector(FlatBufferBuilder builder, EExtraMovementAbility[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602181C RID: 137244 RVA: 0x0049F17B File Offset: 0x0049D37B
		public static VectorOffset CreateExtraMovementAbilitiesVectorBlock(FlatBufferBuilder builder, EExtraMovementAbility[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<EExtraMovementAbility>(data);
			return builder.EndVector();
		}

		// Token: 0x0602181D RID: 137245 RVA: 0x0049F195 File Offset: 0x0049D395
		public static VectorOffset CreateExtraMovementAbilitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<EExtraMovementAbility> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<EExtraMovementAbility>(data);
			return builder.EndVector();
		}

		// Token: 0x0602181E RID: 137246 RVA: 0x0049F1B3 File Offset: 0x0049D3B3
		public static VectorOffset CreateExtraMovementAbilitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EExtraMovementAbility>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602181F RID: 137247 RVA: 0x0049F1CC File Offset: 0x0049D3CC
		public static void StartExtraMovementAbilitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06021820 RID: 137248 RVA: 0x0049F1D7 File Offset: 0x0049D3D7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x06021821 RID: 137249 RVA: 0x0049F1E3 File Offset: 0x0049D3E3
		public static Offset<IAnimalComponent> EndIAnimalComponent(FlatBufferBuilder builder)
		{
			return new Offset<IAnimalComponent>(builder.EndTable());
		}

		// Token: 0x06021822 RID: 137250 RVA: 0x0049F1F0 File Offset: 0x0049D3F0
		public IAnimalComponentT UnPack()
		{
			IAnimalComponentT animalComponentT = new IAnimalComponentT();
			this.UnPackTo(animalComponentT);
			return animalComponentT;
		}

		// Token: 0x06021823 RID: 137251 RVA: 0x0049F20C File Offset: 0x0049D40C
		public void UnPackTo(IAnimalComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.IsStare = this.IsStare;
			_o.AnimalAttackRange = this.AnimalAttackRange;
			_o.MoveRange = this.MoveRange;
			_o.UseRangeComponentAsMoveRange = this.UseRangeComponentAsMoveRange;
			_o.CanKillSelf = this.CanKillSelf;
			_o.PlayDeathAnimOnDestroy = this.PlayDeathAnimOnDestroy;
			_o.SpecialAnimalConfig = ((this.SpecialAnimalConfig != null) ? this.SpecialAnimalConfig.Value.UnPack() : null);
			_o.EmotionBubbleMap = new List<IAnimalEmotionBubbleEntryT>();
			for (int i = 0; i < this.EmotionBubbleMapLength; i++)
			{
				_o.EmotionBubbleMap.Add((this.EmotionBubbleMap(i) != null) ? this.EmotionBubbleMap(i).Value.UnPack() : null);
			}
			_o.ExtraMovementAbilities = new List<EExtraMovementAbility>();
			for (int j = 0; j < this.ExtraMovementAbilitiesLength; j++)
			{
				_o.ExtraMovementAbilities.Add(this.ExtraMovementAbilities(j));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021824 RID: 137252 RVA: 0x0049F330 File Offset: 0x0049D530
		public static Offset<IAnimalComponent> Pack(FlatBufferBuilder builder, IAnimalComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAnimalComponent>);
			}
			Offset<ICollectAnimalConfig> specialAnimalConfigOffset = (_o.SpecialAnimalConfig == null) ? default(Offset<ICollectAnimalConfig>) : ICollectAnimalConfig.Pack(builder, _o.SpecialAnimalConfig);
			VectorOffset emotionBubbleMapOffset = default(VectorOffset);
			if (_o.EmotionBubbleMap != null)
			{
				Offset<IAnimalEmotionBubbleEntry>[] array = new Offset<IAnimalEmotionBubbleEntry>[_o.EmotionBubbleMap.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IAnimalEmotionBubbleEntry.Pack(builder, _o.EmotionBubbleMap[i]);
				}
				emotionBubbleMapOffset = IAnimalComponent.CreateEmotionBubbleMapVector(builder, array);
			}
			VectorOffset extraMovementAbilitiesOffset = default(VectorOffset);
			if (_o.ExtraMovementAbilities != null)
			{
				EExtraMovementAbility[] data = _o.ExtraMovementAbilities.ToArray();
				extraMovementAbilitiesOffset = IAnimalComponent.CreateExtraMovementAbilitiesVector(builder, data);
			}
			return IAnimalComponent.CreateIAnimalComponent(builder, _o.Disabled, _o.IsStare, _o.AnimalAttackRange, _o.MoveRange, _o.UseRangeComponentAsMoveRange, _o.CanKillSelf, _o.PlayDeathAnimOnDestroy, specialAnimalConfigOffset, emotionBubbleMapOffset, extraMovementAbilitiesOffset, _o.NullMask);
		}

		// Token: 0x0400E81A RID: 59418
		private Table __p;
	}
}
