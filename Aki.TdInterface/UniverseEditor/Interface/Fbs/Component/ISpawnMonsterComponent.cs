using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F5A RID: 24410
	public struct ISpawnMonsterComponent : IFlatbufferObject
	{
		// Token: 0x1700B4C1 RID: 46273
		// (get) Token: 0x0602904E RID: 168014 RVA: 0x0059A53A File Offset: 0x0059873A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602904F RID: 168015 RVA: 0x0059A547 File Offset: 0x00598747
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029050 RID: 168016 RVA: 0x0059A550 File Offset: 0x00598750
		public static ISpawnMonsterComponent GetRootAsISpawnMonsterComponent(ByteBuffer _bb)
		{
			return ISpawnMonsterComponent.GetRootAsISpawnMonsterComponent(_bb, default(ISpawnMonsterComponent));
		}

		// Token: 0x06029051 RID: 168017 RVA: 0x0059A56C File Offset: 0x0059876C
		public static ISpawnMonsterComponent GetRootAsISpawnMonsterComponent(ByteBuffer _bb, ISpawnMonsterComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029052 RID: 168018 RVA: 0x0059A589 File Offset: 0x00598789
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029053 RID: 168019 RVA: 0x0059A598 File Offset: 0x00598798
		public ISpawnMonsterComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B4C2 RID: 46274
		// (get) Token: 0x06029054 RID: 168020 RVA: 0x0059A5A8 File Offset: 0x005987A8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B4C3 RID: 46275
		// (get) Token: 0x06029055 RID: 168021 RVA: 0x0059A5E8 File Offset: 0x005987E8
		public TSpawnMonsterStartCondition ActiveTypeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TSpawnMonsterStartCondition.NONE;
				}
				return (TSpawnMonsterStartCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029056 RID: 168022 RVA: 0x0059A624 File Offset: 0x00598824
		public TTable? ActiveType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06029057 RID: 168023 RVA: 0x0059A668 File Offset: 0x00598868
		public IImmediateStartCondition ActiveTypeAsIImmediateStartCondition()
		{
			return this.ActiveType<IImmediateStartCondition>().Value;
		}

		// Token: 0x06029058 RID: 168024 RVA: 0x0059A684 File Offset: 0x00598884
		public ITriggerRangeStartCondition ActiveTypeAsITriggerRangeStartCondition()
		{
			return this.ActiveType<ITriggerRangeStartCondition>().Value;
		}

		// Token: 0x06029059 RID: 168025 RVA: 0x0059A6A0 File Offset: 0x005988A0
		public ISpawnMonsterConfig? SpawnMonsterConfigs(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new ISpawnMonsterConfig?(default(ISpawnMonsterConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B4C4 RID: 46276
		// (get) Token: 0x0602905A RID: 168026 RVA: 0x0059A704 File Offset: 0x00598904
		public int SpawnMonsterConfigsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700B4C5 RID: 46277
		// (get) Token: 0x0602905B RID: 168027 RVA: 0x0059A730 File Offset: 0x00598930
		public bool IssharedHatred
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B4C6 RID: 46278
		// (get) Token: 0x0602905C RID: 168028 RVA: 0x0059A770 File Offset: 0x00598970
		public ISpawnMonsterConstraintAnnularSector? SpawnMonsterConstraintType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new ISpawnMonsterConstraintAnnularSector?(default(ISpawnMonsterConstraintAnnularSector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B4C7 RID: 46279
		// (get) Token: 0x0602905D RID: 168029 RVA: 0x0059A7D0 File Offset: 0x005989D0
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

		// Token: 0x0602905E RID: 168030 RVA: 0x0059A810 File Offset: 0x00598A10
		public static Offset<ISpawnMonsterComponent> CreateISpawnMonsterComponent(FlatBufferBuilder builder, bool Disabled = false, TSpawnMonsterStartCondition ActiveType_type = TSpawnMonsterStartCondition.NONE, int ActiveTypeOffset = 0, VectorOffset SpawnMonsterConfigsOffset = default(VectorOffset), bool IssharedHatred = false, Offset<ISpawnMonsterConstraintAnnularSector> SpawnMonsterConstraintTypeOffset = default(Offset<ISpawnMonsterConstraintAnnularSector>), byte NullMask = 0)
		{
			builder.StartTable(7);
			ISpawnMonsterComponent.AddSpawnMonsterConstraintType(builder, SpawnMonsterConstraintTypeOffset);
			ISpawnMonsterComponent.AddSpawnMonsterConfigs(builder, SpawnMonsterConfigsOffset);
			ISpawnMonsterComponent.AddActiveType(builder, ActiveTypeOffset);
			ISpawnMonsterComponent.AddNullMask(builder, NullMask);
			ISpawnMonsterComponent.AddIssharedHatred(builder, IssharedHatred);
			ISpawnMonsterComponent.AddActiveTypeType(builder, ActiveType_type);
			ISpawnMonsterComponent.AddDisabled(builder, Disabled);
			return ISpawnMonsterComponent.EndISpawnMonsterComponent(builder);
		}

		// Token: 0x0602905F RID: 168031 RVA: 0x0059A85F File Offset: 0x00598A5F
		public static void StartISpawnMonsterComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06029060 RID: 168032 RVA: 0x0059A868 File Offset: 0x00598A68
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06029061 RID: 168033 RVA: 0x0059A873 File Offset: 0x00598A73
		public static void AddActiveTypeType(FlatBufferBuilder builder, TSpawnMonsterStartCondition activeTypeType)
		{
			builder.AddByte(1, (byte)activeTypeType, 0);
		}

		// Token: 0x06029062 RID: 168034 RVA: 0x0059A87E File Offset: 0x00598A7E
		public static void AddActiveType(FlatBufferBuilder builder, int activeTypeOffset)
		{
			builder.AddOffset(2, activeTypeOffset, 0);
		}

		// Token: 0x06029063 RID: 168035 RVA: 0x0059A889 File Offset: 0x00598A89
		public static void AddSpawnMonsterConfigs(FlatBufferBuilder builder, VectorOffset spawnMonsterConfigsOffset)
		{
			builder.AddOffset(3, spawnMonsterConfigsOffset.Value, 0);
		}

		// Token: 0x06029064 RID: 168036 RVA: 0x0059A89C File Offset: 0x00598A9C
		public static VectorOffset CreateSpawnMonsterConfigsVector(FlatBufferBuilder builder, Offset<ISpawnMonsterConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06029065 RID: 168037 RVA: 0x0059A8DC File Offset: 0x00598ADC
		public static VectorOffset CreateSpawnMonsterConfigsVectorBlock(FlatBufferBuilder builder, Offset<ISpawnMonsterConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISpawnMonsterConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029066 RID: 168038 RVA: 0x0059A8F6 File Offset: 0x00598AF6
		public static VectorOffset CreateSpawnMonsterConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISpawnMonsterConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISpawnMonsterConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029067 RID: 168039 RVA: 0x0059A914 File Offset: 0x00598B14
		public static VectorOffset CreateSpawnMonsterConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISpawnMonsterConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029068 RID: 168040 RVA: 0x0059A92D File Offset: 0x00598B2D
		public static void StartSpawnMonsterConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029069 RID: 168041 RVA: 0x0059A938 File Offset: 0x00598B38
		public static void AddIssharedHatred(FlatBufferBuilder builder, bool issharedHatred)
		{
			builder.AddBool(4, issharedHatred, false);
		}

		// Token: 0x0602906A RID: 168042 RVA: 0x0059A943 File Offset: 0x00598B43
		public static void AddSpawnMonsterConstraintType(FlatBufferBuilder builder, Offset<ISpawnMonsterConstraintAnnularSector> spawnMonsterConstraintTypeOffset)
		{
			builder.AddOffset(5, spawnMonsterConstraintTypeOffset.Value, 0);
		}

		// Token: 0x0602906B RID: 168043 RVA: 0x0059A953 File Offset: 0x00598B53
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602906C RID: 168044 RVA: 0x0059A95E File Offset: 0x00598B5E
		public static Offset<ISpawnMonsterComponent> EndISpawnMonsterComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISpawnMonsterComponent>(builder.EndTable());
		}

		// Token: 0x0602906D RID: 168045 RVA: 0x0059A96C File Offset: 0x00598B6C
		public ISpawnMonsterComponentT UnPack()
		{
			ISpawnMonsterComponentT spawnMonsterComponentT = new ISpawnMonsterComponentT();
			this.UnPackTo(spawnMonsterComponentT);
			return spawnMonsterComponentT;
		}

		// Token: 0x0602906E RID: 168046 RVA: 0x0059A988 File Offset: 0x00598B88
		public void UnPackTo(ISpawnMonsterComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.ActiveType = new TSpawnMonsterStartConditionUnion();
			_o.ActiveType.Type = this.ActiveTypeType;
			TSpawnMonsterStartCondition activeTypeType = this.ActiveTypeType;
			if (activeTypeType != TSpawnMonsterStartCondition.IImmediateStartCondition)
			{
				if (activeTypeType == TSpawnMonsterStartCondition.ITriggerRangeStartCondition)
				{
					_o.ActiveType.Value = ((this.ActiveType<ITriggerRangeStartCondition>() != null) ? this.ActiveType<ITriggerRangeStartCondition>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.ActiveType.Value = ((this.ActiveType<IImmediateStartCondition>() != null) ? this.ActiveType<IImmediateStartCondition>().Value.UnPack() : null);
			}
			_o.SpawnMonsterConfigs = new List<ISpawnMonsterConfigT>();
			for (int i = 0; i < this.SpawnMonsterConfigsLength; i++)
			{
				_o.SpawnMonsterConfigs.Add((this.SpawnMonsterConfigs(i) != null) ? this.SpawnMonsterConfigs(i).Value.UnPack() : null);
			}
			_o.IssharedHatred = this.IssharedHatred;
			_o.SpawnMonsterConstraintType = ((this.SpawnMonsterConstraintType != null) ? this.SpawnMonsterConstraintType.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602906F RID: 168047 RVA: 0x0059AAE0 File Offset: 0x00598CE0
		public static Offset<ISpawnMonsterComponent> Pack(FlatBufferBuilder builder, ISpawnMonsterComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpawnMonsterComponent>);
			}
			TSpawnMonsterStartCondition activeType_type = (_o.ActiveType == null) ? TSpawnMonsterStartCondition.NONE : _o.ActiveType.Type;
			int activeTypeOffset = (_o.ActiveType == null) ? 0 : TSpawnMonsterStartConditionUnion.Pack(builder, _o.ActiveType);
			VectorOffset spawnMonsterConfigsOffset = default(VectorOffset);
			if (_o.SpawnMonsterConfigs != null)
			{
				Offset<ISpawnMonsterConfig>[] array = new Offset<ISpawnMonsterConfig>[_o.SpawnMonsterConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISpawnMonsterConfig.Pack(builder, _o.SpawnMonsterConfigs[i]);
				}
				spawnMonsterConfigsOffset = ISpawnMonsterComponent.CreateSpawnMonsterConfigsVector(builder, array);
			}
			Offset<ISpawnMonsterConstraintAnnularSector> spawnMonsterConstraintTypeOffset = (_o.SpawnMonsterConstraintType == null) ? default(Offset<ISpawnMonsterConstraintAnnularSector>) : ISpawnMonsterConstraintAnnularSector.Pack(builder, _o.SpawnMonsterConstraintType);
			return ISpawnMonsterComponent.CreateISpawnMonsterComponent(builder, _o.Disabled, activeType_type, activeTypeOffset, spawnMonsterConfigsOffset, _o.IssharedHatred, spawnMonsterConstraintTypeOffset, _o.NullMask);
		}

		// Token: 0x0400FC1A RID: 64538
		private Table __p;
	}
}
