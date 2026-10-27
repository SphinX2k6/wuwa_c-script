using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200594D RID: 22861
	public struct ISpawnMonsterComponent : IFlatbufferObject
	{
		// Token: 0x1700AB8D RID: 43917
		// (get) Token: 0x06026AE4 RID: 158436 RVA: 0x005538CE File Offset: 0x00551ACE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026AE5 RID: 158437 RVA: 0x005538DB File Offset: 0x00551ADB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026AE6 RID: 158438 RVA: 0x005538E4 File Offset: 0x00551AE4
		public static ISpawnMonsterComponent GetRootAsISpawnMonsterComponent(ByteBuffer _bb)
		{
			return ISpawnMonsterComponent.GetRootAsISpawnMonsterComponent(_bb, default(ISpawnMonsterComponent));
		}

		// Token: 0x06026AE7 RID: 158439 RVA: 0x00553900 File Offset: 0x00551B00
		public static ISpawnMonsterComponent GetRootAsISpawnMonsterComponent(ByteBuffer _bb, ISpawnMonsterComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026AE8 RID: 158440 RVA: 0x0055391D File Offset: 0x00551B1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026AE9 RID: 158441 RVA: 0x0055392C File Offset: 0x00551B2C
		public ISpawnMonsterComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AB8E RID: 43918
		// (get) Token: 0x06026AEA RID: 158442 RVA: 0x0055393C File Offset: 0x00551B3C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AB8F RID: 43919
		// (get) Token: 0x06026AEB RID: 158443 RVA: 0x0055397C File Offset: 0x00551B7C
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

		// Token: 0x06026AEC RID: 158444 RVA: 0x005539B8 File Offset: 0x00551BB8
		public TTable? ActiveType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06026AED RID: 158445 RVA: 0x005539FC File Offset: 0x00551BFC
		public IImmediateStartCondition ActiveTypeAsIImmediateStartCondition()
		{
			return this.ActiveType<IImmediateStartCondition>().Value;
		}

		// Token: 0x06026AEE RID: 158446 RVA: 0x00553A18 File Offset: 0x00551C18
		public ITriggerRangeStartCondition ActiveTypeAsITriggerRangeStartCondition()
		{
			return this.ActiveType<ITriggerRangeStartCondition>().Value;
		}

		// Token: 0x06026AEF RID: 158447 RVA: 0x00553A34 File Offset: 0x00551C34
		public ISpawnMonsterConfig? SpawnMonsterConfigs(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new ISpawnMonsterConfig?(default(ISpawnMonsterConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AB90 RID: 43920
		// (get) Token: 0x06026AF0 RID: 158448 RVA: 0x00553A98 File Offset: 0x00551C98
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

		// Token: 0x1700AB91 RID: 43921
		// (get) Token: 0x06026AF1 RID: 158449 RVA: 0x00553AC4 File Offset: 0x00551CC4
		public bool IssharedHatred
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AB92 RID: 43922
		// (get) Token: 0x06026AF2 RID: 158450 RVA: 0x00553B04 File Offset: 0x00551D04
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

		// Token: 0x1700AB93 RID: 43923
		// (get) Token: 0x06026AF3 RID: 158451 RVA: 0x00553B64 File Offset: 0x00551D64
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

		// Token: 0x06026AF4 RID: 158452 RVA: 0x00553BA4 File Offset: 0x00551DA4
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

		// Token: 0x06026AF5 RID: 158453 RVA: 0x00553BF3 File Offset: 0x00551DF3
		public static void StartISpawnMonsterComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06026AF6 RID: 158454 RVA: 0x00553BFC File Offset: 0x00551DFC
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06026AF7 RID: 158455 RVA: 0x00553C07 File Offset: 0x00551E07
		public static void AddActiveTypeType(FlatBufferBuilder builder, TSpawnMonsterStartCondition activeTypeType)
		{
			builder.AddByte(1, (byte)activeTypeType, 0);
		}

		// Token: 0x06026AF8 RID: 158456 RVA: 0x00553C12 File Offset: 0x00551E12
		public static void AddActiveType(FlatBufferBuilder builder, int activeTypeOffset)
		{
			builder.AddOffset(2, activeTypeOffset, 0);
		}

		// Token: 0x06026AF9 RID: 158457 RVA: 0x00553C1D File Offset: 0x00551E1D
		public static void AddSpawnMonsterConfigs(FlatBufferBuilder builder, VectorOffset spawnMonsterConfigsOffset)
		{
			builder.AddOffset(3, spawnMonsterConfigsOffset.Value, 0);
		}

		// Token: 0x06026AFA RID: 158458 RVA: 0x00553C30 File Offset: 0x00551E30
		public static VectorOffset CreateSpawnMonsterConfigsVector(FlatBufferBuilder builder, Offset<ISpawnMonsterConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026AFB RID: 158459 RVA: 0x00553C70 File Offset: 0x00551E70
		public static VectorOffset CreateSpawnMonsterConfigsVectorBlock(FlatBufferBuilder builder, Offset<ISpawnMonsterConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISpawnMonsterConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026AFC RID: 158460 RVA: 0x00553C8A File Offset: 0x00551E8A
		public static VectorOffset CreateSpawnMonsterConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISpawnMonsterConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISpawnMonsterConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026AFD RID: 158461 RVA: 0x00553CA8 File Offset: 0x00551EA8
		public static VectorOffset CreateSpawnMonsterConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISpawnMonsterConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026AFE RID: 158462 RVA: 0x00553CC1 File Offset: 0x00551EC1
		public static void StartSpawnMonsterConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026AFF RID: 158463 RVA: 0x00553CCC File Offset: 0x00551ECC
		public static void AddIssharedHatred(FlatBufferBuilder builder, bool issharedHatred)
		{
			builder.AddBool(4, issharedHatred, false);
		}

		// Token: 0x06026B00 RID: 158464 RVA: 0x00553CD7 File Offset: 0x00551ED7
		public static void AddSpawnMonsterConstraintType(FlatBufferBuilder builder, Offset<ISpawnMonsterConstraintAnnularSector> spawnMonsterConstraintTypeOffset)
		{
			builder.AddOffset(5, spawnMonsterConstraintTypeOffset.Value, 0);
		}

		// Token: 0x06026B01 RID: 158465 RVA: 0x00553CE7 File Offset: 0x00551EE7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06026B02 RID: 158466 RVA: 0x00553CF2 File Offset: 0x00551EF2
		public static Offset<ISpawnMonsterComponent> EndISpawnMonsterComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISpawnMonsterComponent>(builder.EndTable());
		}

		// Token: 0x06026B03 RID: 158467 RVA: 0x00553D00 File Offset: 0x00551F00
		public ISpawnMonsterComponentT UnPack()
		{
			ISpawnMonsterComponentT spawnMonsterComponentT = new ISpawnMonsterComponentT();
			this.UnPackTo(spawnMonsterComponentT);
			return spawnMonsterComponentT;
		}

		// Token: 0x06026B04 RID: 158468 RVA: 0x00553D1C File Offset: 0x00551F1C
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

		// Token: 0x06026B05 RID: 158469 RVA: 0x00553E74 File Offset: 0x00552074
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

		// Token: 0x0400EF25 RID: 61221
		private Table __p;
	}
}
