using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EA4 RID: 20132
	public struct IAnimalComponent : IFlatbufferObject
	{
		// Token: 0x17009060 RID: 36960
		// (get) Token: 0x0601FB00 RID: 129792 RVA: 0x00469905 File Offset: 0x00467B05
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FB01 RID: 129793 RVA: 0x00469912 File Offset: 0x00467B12
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FB02 RID: 129794 RVA: 0x0046991C File Offset: 0x00467B1C
		public static IAnimalComponent GetRootAsIAnimalComponent(ByteBuffer _bb)
		{
			return IAnimalComponent.GetRootAsIAnimalComponent(_bb, default(IAnimalComponent));
		}

		// Token: 0x0601FB03 RID: 129795 RVA: 0x00469938 File Offset: 0x00467B38
		public static IAnimalComponent GetRootAsIAnimalComponent(ByteBuffer _bb, IAnimalComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FB04 RID: 129796 RVA: 0x00469955 File Offset: 0x00467B55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FB05 RID: 129797 RVA: 0x00469964 File Offset: 0x00467B64
		public IAnimalComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009061 RID: 36961
		// (get) Token: 0x0601FB06 RID: 129798 RVA: 0x00469974 File Offset: 0x00467B74
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009062 RID: 36962
		// (get) Token: 0x0601FB07 RID: 129799 RVA: 0x004699B4 File Offset: 0x00467BB4
		public bool IsStare
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009063 RID: 36963
		// (get) Token: 0x0601FB08 RID: 129800 RVA: 0x004699F4 File Offset: 0x00467BF4
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

		// Token: 0x17009064 RID: 36964
		// (get) Token: 0x0601FB09 RID: 129801 RVA: 0x00469A30 File Offset: 0x00467C30
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

		// Token: 0x17009065 RID: 36965
		// (get) Token: 0x0601FB0A RID: 129802 RVA: 0x00469A70 File Offset: 0x00467C70
		public bool UseRangeComponentAsMoveRange
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009066 RID: 36966
		// (get) Token: 0x0601FB0B RID: 129803 RVA: 0x00469AB0 File Offset: 0x00467CB0
		public bool CanKillSelf
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009067 RID: 36967
		// (get) Token: 0x0601FB0C RID: 129804 RVA: 0x00469AF0 File Offset: 0x00467CF0
		public bool PlayDeathAnimOnDestroy
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009068 RID: 36968
		// (get) Token: 0x0601FB0D RID: 129805 RVA: 0x00469B30 File Offset: 0x00467D30
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

		// Token: 0x0601FB0E RID: 129806 RVA: 0x00469B90 File Offset: 0x00467D90
		public IAnimalEmotionBubbleEntry? EmotionBubbleMap(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new IAnimalEmotionBubbleEntry?(default(IAnimalEmotionBubbleEntry).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009069 RID: 36969
		// (get) Token: 0x0601FB0F RID: 129807 RVA: 0x00469BF4 File Offset: 0x00467DF4
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

		// Token: 0x1700906A RID: 36970
		// (get) Token: 0x0601FB10 RID: 129808 RVA: 0x00469C20 File Offset: 0x00467E20
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FB11 RID: 129809 RVA: 0x00469C60 File Offset: 0x00467E60
		public static Offset<IAnimalComponent> CreateIAnimalComponent(FlatBufferBuilder builder, bool Disabled = false, bool IsStare = false, int AnimalAttackRange = 0, int MoveRange = 0, bool UseRangeComponentAsMoveRange = false, bool CanKillSelf = false, bool PlayDeathAnimOnDestroy = false, Offset<ICollectAnimalConfig> SpecialAnimalConfigOffset = default(Offset<ICollectAnimalConfig>), VectorOffset EmotionBubbleMapOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(10);
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

		// Token: 0x0601FB12 RID: 129810 RVA: 0x00469CC8 File Offset: 0x00467EC8
		public static void StartIAnimalComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x0601FB13 RID: 129811 RVA: 0x00469CD2 File Offset: 0x00467ED2
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0601FB14 RID: 129812 RVA: 0x00469CDD File Offset: 0x00467EDD
		public static void AddIsStare(FlatBufferBuilder builder, bool isStare)
		{
			builder.AddBool(1, isStare, false);
		}

		// Token: 0x0601FB15 RID: 129813 RVA: 0x00469CE8 File Offset: 0x00467EE8
		public static void AddAnimalAttackRange(FlatBufferBuilder builder, int animalAttackRange)
		{
			builder.AddInt(2, animalAttackRange, 0);
		}

		// Token: 0x0601FB16 RID: 129814 RVA: 0x00469CF3 File Offset: 0x00467EF3
		public static void AddMoveRange(FlatBufferBuilder builder, int moveRange)
		{
			builder.AddInt(3, moveRange, 0);
		}

		// Token: 0x0601FB17 RID: 129815 RVA: 0x00469CFE File Offset: 0x00467EFE
		public static void AddUseRangeComponentAsMoveRange(FlatBufferBuilder builder, bool useRangeComponentAsMoveRange)
		{
			builder.AddBool(4, useRangeComponentAsMoveRange, false);
		}

		// Token: 0x0601FB18 RID: 129816 RVA: 0x00469D09 File Offset: 0x00467F09
		public static void AddCanKillSelf(FlatBufferBuilder builder, bool canKillSelf)
		{
			builder.AddBool(5, canKillSelf, false);
		}

		// Token: 0x0601FB19 RID: 129817 RVA: 0x00469D14 File Offset: 0x00467F14
		public static void AddPlayDeathAnimOnDestroy(FlatBufferBuilder builder, bool playDeathAnimOnDestroy)
		{
			builder.AddBool(6, playDeathAnimOnDestroy, false);
		}

		// Token: 0x0601FB1A RID: 129818 RVA: 0x00469D1F File Offset: 0x00467F1F
		public static void AddSpecialAnimalConfig(FlatBufferBuilder builder, Offset<ICollectAnimalConfig> specialAnimalConfigOffset)
		{
			builder.AddOffset(7, specialAnimalConfigOffset.Value, 0);
		}

		// Token: 0x0601FB1B RID: 129819 RVA: 0x00469D2F File Offset: 0x00467F2F
		public static void AddEmotionBubbleMap(FlatBufferBuilder builder, VectorOffset emotionBubbleMapOffset)
		{
			builder.AddOffset(8, emotionBubbleMapOffset.Value, 0);
		}

		// Token: 0x0601FB1C RID: 129820 RVA: 0x00469D40 File Offset: 0x00467F40
		public static VectorOffset CreateEmotionBubbleMapVector(FlatBufferBuilder builder, Offset<IAnimalEmotionBubbleEntry>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601FB1D RID: 129821 RVA: 0x00469D80 File Offset: 0x00467F80
		public static VectorOffset CreateEmotionBubbleMapVectorBlock(FlatBufferBuilder builder, Offset<IAnimalEmotionBubbleEntry>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IAnimalEmotionBubbleEntry>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FB1E RID: 129822 RVA: 0x00469D9A File Offset: 0x00467F9A
		public static VectorOffset CreateEmotionBubbleMapVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IAnimalEmotionBubbleEntry>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IAnimalEmotionBubbleEntry>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FB1F RID: 129823 RVA: 0x00469DB8 File Offset: 0x00467FB8
		public static VectorOffset CreateEmotionBubbleMapVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IAnimalEmotionBubbleEntry>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601FB20 RID: 129824 RVA: 0x00469DD1 File Offset: 0x00467FD1
		public static void StartEmotionBubbleMapVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601FB21 RID: 129825 RVA: 0x00469DDC File Offset: 0x00467FDC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x0601FB22 RID: 129826 RVA: 0x00469DE8 File Offset: 0x00467FE8
		public static Offset<IAnimalComponent> EndIAnimalComponent(FlatBufferBuilder builder)
		{
			return new Offset<IAnimalComponent>(builder.EndTable());
		}

		// Token: 0x0601FB23 RID: 129827 RVA: 0x00469DF8 File Offset: 0x00467FF8
		public IAnimalComponentT UnPack()
		{
			IAnimalComponentT animalComponentT = new IAnimalComponentT();
			this.UnPackTo(animalComponentT);
			return animalComponentT;
		}

		// Token: 0x0601FB24 RID: 129828 RVA: 0x00469E14 File Offset: 0x00468014
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
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601FB25 RID: 129829 RVA: 0x00469F04 File Offset: 0x00468104
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
			return IAnimalComponent.CreateIAnimalComponent(builder, _o.Disabled, _o.IsStare, _o.AnimalAttackRange, _o.MoveRange, _o.UseRangeComponentAsMoveRange, _o.CanKillSelf, _o.PlayDeathAnimOnDestroy, specialAnimalConfigOffset, emotionBubbleMapOffset, _o.NullMask);
		}

		// Token: 0x0400DC7F RID: 56447
		private Table __p;
	}
}
