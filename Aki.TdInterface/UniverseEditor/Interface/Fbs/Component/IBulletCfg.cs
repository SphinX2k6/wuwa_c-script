using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F37 RID: 20279
	public struct IBulletCfg : IFlatbufferObject
	{
		// Token: 0x1700922B RID: 37419
		// (get) Token: 0x06020197 RID: 131479 RVA: 0x004773E5 File Offset: 0x004755E5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020198 RID: 131480 RVA: 0x004773F2 File Offset: 0x004755F2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020199 RID: 131481 RVA: 0x004773FC File Offset: 0x004755FC
		public static IBulletCfg GetRootAsIBulletCfg(ByteBuffer _bb)
		{
			return IBulletCfg.GetRootAsIBulletCfg(_bb, default(IBulletCfg));
		}

		// Token: 0x0602019A RID: 131482 RVA: 0x00477418 File Offset: 0x00475618
		public static IBulletCfg GetRootAsIBulletCfg(ByteBuffer _bb, IBulletCfg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602019B RID: 131483 RVA: 0x00477435 File Offset: 0x00475635
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602019C RID: 131484 RVA: 0x00477444 File Offset: 0x00475644
		public IBulletCfg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602019D RID: 131485 RVA: 0x00477454 File Offset: 0x00475654
		public TBulletCreateCondition CreateConditionsType(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return TBulletCreateCondition.NONE;
			}
			return (TBulletCreateCondition)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700922C RID: 37420
		// (get) Token: 0x0602019E RID: 131486 RVA: 0x00477494 File Offset: 0x00475694
		public int CreateConditionsTypeLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602019F RID: 131487 RVA: 0x004774BF File Offset: 0x004756BF
		public Span<TBulletCreateCondition> GetCreateConditionsTypeBytes()
		{
			return this.__p.__vector_as_span<TBulletCreateCondition>(4, 1);
		}

		// Token: 0x060201A0 RID: 131488 RVA: 0x004774D0 File Offset: 0x004756D0
		public TBulletCreateCondition[] GetCreateConditionsTypeArray()
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TBulletCreateCondition[] array = new TBulletCreateCondition[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TBulletCreateCondition)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x060201A1 RID: 131489 RVA: 0x0047753C File Offset: 0x0047573C
		public TTable? CreateConditions<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700922D RID: 37421
		// (get) Token: 0x060201A2 RID: 131490 RVA: 0x00477584 File Offset: 0x00475784
		public int CreateConditionsLength
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

		// Token: 0x060201A3 RID: 131491 RVA: 0x004775AF File Offset: 0x004757AF
		public static Offset<IBulletCfg> CreateIBulletCfg(FlatBufferBuilder builder, VectorOffset CreateConditions_typeOffset = default(VectorOffset), VectorOffset CreateConditionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IBulletCfg.AddCreateConditions(builder, CreateConditionsOffset);
			IBulletCfg.AddCreateConditionsType(builder, CreateConditions_typeOffset);
			return IBulletCfg.EndIBulletCfg(builder);
		}

		// Token: 0x060201A4 RID: 131492 RVA: 0x004775CC File Offset: 0x004757CC
		public static void StartIBulletCfg(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060201A5 RID: 131493 RVA: 0x004775D5 File Offset: 0x004757D5
		public static void AddCreateConditionsType(FlatBufferBuilder builder, VectorOffset createConditionsTypeOffset)
		{
			builder.AddOffset(0, createConditionsTypeOffset.Value, 0);
		}

		// Token: 0x060201A6 RID: 131494 RVA: 0x004775E8 File Offset: 0x004757E8
		public static VectorOffset CreateCreateConditionsTypeVector(FlatBufferBuilder builder, TBulletCreateCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060201A7 RID: 131495 RVA: 0x0047761F File Offset: 0x0047581F
		public static VectorOffset CreateCreateConditionsTypeVectorBlock(FlatBufferBuilder builder, TBulletCreateCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TBulletCreateCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x060201A8 RID: 131496 RVA: 0x00477639 File Offset: 0x00475839
		public static VectorOffset CreateCreateConditionsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TBulletCreateCondition> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TBulletCreateCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x060201A9 RID: 131497 RVA: 0x00477657 File Offset: 0x00475857
		public static VectorOffset CreateCreateConditionsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TBulletCreateCondition>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060201AA RID: 131498 RVA: 0x00477670 File Offset: 0x00475870
		public static void StartCreateConditionsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060201AB RID: 131499 RVA: 0x0047767B File Offset: 0x0047587B
		public static void AddCreateConditions(FlatBufferBuilder builder, VectorOffset createConditionsOffset)
		{
			builder.AddOffset(1, createConditionsOffset.Value, 0);
		}

		// Token: 0x060201AC RID: 131500 RVA: 0x0047768C File Offset: 0x0047588C
		public static VectorOffset CreateCreateConditionsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060201AD RID: 131501 RVA: 0x004776C3 File Offset: 0x004758C3
		public static VectorOffset CreateCreateConditionsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060201AE RID: 131502 RVA: 0x004776DD File Offset: 0x004758DD
		public static VectorOffset CreateCreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060201AF RID: 131503 RVA: 0x004776FB File Offset: 0x004758FB
		public static VectorOffset CreateCreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060201B0 RID: 131504 RVA: 0x00477714 File Offset: 0x00475914
		public static void StartCreateConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060201B1 RID: 131505 RVA: 0x0047771F File Offset: 0x0047591F
		public static Offset<IBulletCfg> EndIBulletCfg(FlatBufferBuilder builder)
		{
			return new Offset<IBulletCfg>(builder.EndTable());
		}

		// Token: 0x060201B2 RID: 131506 RVA: 0x0047772C File Offset: 0x0047592C
		public IBulletCfgT UnPack()
		{
			IBulletCfgT bulletCfgT = new IBulletCfgT();
			this.UnPackTo(bulletCfgT);
			return bulletCfgT;
		}

		// Token: 0x060201B3 RID: 131507 RVA: 0x00477748 File Offset: 0x00475948
		public void UnPackTo(IBulletCfgT _o)
		{
			_o.CreateConditions = new List<TBulletCreateConditionUnion>();
			for (int i = 0; i < this.CreateConditionsLength; i++)
			{
				TBulletCreateConditionUnion tbulletCreateConditionUnion = new TBulletCreateConditionUnion();
				tbulletCreateConditionUnion.Type = this.CreateConditionsType(i);
				switch (this.CreateConditionsType(i))
				{
				case TBulletCreateCondition.IOnCollisionCondition:
					tbulletCreateConditionUnion.Value = ((this.CreateConditions<IOnCollisionCondition>(i) != null) ? this.CreateConditions<IOnCollisionCondition>(i).Value.UnPack() : null);
					break;
				case TBulletCreateCondition.IOnHitCondition:
					tbulletCreateConditionUnion.Value = ((this.CreateConditions<IOnHitCondition>(i) != null) ? this.CreateConditions<IOnHitCondition>(i).Value.UnPack() : null);
					break;
				case TBulletCreateCondition.IOnMatchingCondition:
					tbulletCreateConditionUnion.Value = ((this.CreateConditions<IOnMatchingCondition>(i) != null) ? this.CreateConditions<IOnMatchingCondition>(i).Value.UnPack() : null);
					break;
				case TBulletCreateCondition.IOnOpenGravityCollisionCondition:
					tbulletCreateConditionUnion.Value = ((this.CreateConditions<IOnOpenGravityCollisionCondition>(i) != null) ? this.CreateConditions<IOnOpenGravityCollisionCondition>(i).Value.UnPack() : null);
					break;
				case TBulletCreateCondition.IOnThrowTriggerTimeCondition:
					tbulletCreateConditionUnion.Value = ((this.CreateConditions<IOnThrowTriggerTimeCondition>(i) != null) ? this.CreateConditions<IOnThrowTriggerTimeCondition>(i).Value.UnPack() : null);
					break;
				}
				_o.CreateConditions.Add(tbulletCreateConditionUnion);
			}
		}

		// Token: 0x060201B4 RID: 131508 RVA: 0x004778D0 File Offset: 0x00475AD0
		public static Offset<IBulletCfg> Pack(FlatBufferBuilder builder, IBulletCfgT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBulletCfg>);
			}
			VectorOffset createConditions_typeOffset = default(VectorOffset);
			if (_o.CreateConditions != null)
			{
				TBulletCreateCondition[] array = new TBulletCreateCondition[_o.CreateConditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.CreateConditions[i].Type;
				}
				createConditions_typeOffset = IBulletCfg.CreateCreateConditionsTypeVector(builder, array);
			}
			VectorOffset createConditionsOffset = default(VectorOffset);
			if (_o.CreateConditions != null)
			{
				int[] array2 = new int[_o.CreateConditions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TBulletCreateConditionUnion.Pack(builder, _o.CreateConditions[j]);
				}
				createConditionsOffset = IBulletCfg.CreateCreateConditionsVector(builder, array2);
			}
			return IBulletCfg.CreateIBulletCfg(builder, createConditions_typeOffset, createConditionsOffset);
		}

		// Token: 0x0400DD9E RID: 56734
		private Table __p;
	}
}
