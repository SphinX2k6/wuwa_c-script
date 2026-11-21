using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005469 RID: 21609
	public struct IBulletCfg : IFlatbufferObject
	{
		// Token: 0x170099AD RID: 39341
		// (get) Token: 0x06021F07 RID: 139015 RVA: 0x004AD779 File Offset: 0x004AB979
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021F08 RID: 139016 RVA: 0x004AD786 File Offset: 0x004AB986
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021F09 RID: 139017 RVA: 0x004AD790 File Offset: 0x004AB990
		public static IBulletCfg GetRootAsIBulletCfg(ByteBuffer _bb)
		{
			return IBulletCfg.GetRootAsIBulletCfg(_bb, default(IBulletCfg));
		}

		// Token: 0x06021F0A RID: 139018 RVA: 0x004AD7AC File Offset: 0x004AB9AC
		public static IBulletCfg GetRootAsIBulletCfg(ByteBuffer _bb, IBulletCfg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021F0B RID: 139019 RVA: 0x004AD7C9 File Offset: 0x004AB9C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021F0C RID: 139020 RVA: 0x004AD7D8 File Offset: 0x004AB9D8
		public IBulletCfg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06021F0D RID: 139021 RVA: 0x004AD7E8 File Offset: 0x004AB9E8
		public TBulletCreateCondition CreateConditionsType(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return TBulletCreateCondition.NONE;
			}
			return (TBulletCreateCondition)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x170099AE RID: 39342
		// (get) Token: 0x06021F0E RID: 139022 RVA: 0x004AD828 File Offset: 0x004ABA28
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

		// Token: 0x06021F0F RID: 139023 RVA: 0x004AD853 File Offset: 0x004ABA53
		public Span<TBulletCreateCondition> GetCreateConditionsTypeBytes()
		{
			return this.__p.__vector_as_span<TBulletCreateCondition>(4, 1);
		}

		// Token: 0x06021F10 RID: 139024 RVA: 0x004AD864 File Offset: 0x004ABA64
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

		// Token: 0x06021F11 RID: 139025 RVA: 0x004AD8D0 File Offset: 0x004ABAD0
		public TTable? CreateConditions<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x170099AF RID: 39343
		// (get) Token: 0x06021F12 RID: 139026 RVA: 0x004AD918 File Offset: 0x004ABB18
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

		// Token: 0x06021F13 RID: 139027 RVA: 0x004AD943 File Offset: 0x004ABB43
		public static Offset<IBulletCfg> CreateIBulletCfg(FlatBufferBuilder builder, VectorOffset CreateConditions_typeOffset = default(VectorOffset), VectorOffset CreateConditionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IBulletCfg.AddCreateConditions(builder, CreateConditionsOffset);
			IBulletCfg.AddCreateConditionsType(builder, CreateConditions_typeOffset);
			return IBulletCfg.EndIBulletCfg(builder);
		}

		// Token: 0x06021F14 RID: 139028 RVA: 0x004AD960 File Offset: 0x004ABB60
		public static void StartIBulletCfg(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06021F15 RID: 139029 RVA: 0x004AD969 File Offset: 0x004ABB69
		public static void AddCreateConditionsType(FlatBufferBuilder builder, VectorOffset createConditionsTypeOffset)
		{
			builder.AddOffset(0, createConditionsTypeOffset.Value, 0);
		}

		// Token: 0x06021F16 RID: 139030 RVA: 0x004AD97C File Offset: 0x004ABB7C
		public static VectorOffset CreateCreateConditionsTypeVector(FlatBufferBuilder builder, TBulletCreateCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06021F17 RID: 139031 RVA: 0x004AD9B3 File Offset: 0x004ABBB3
		public static VectorOffset CreateCreateConditionsTypeVectorBlock(FlatBufferBuilder builder, TBulletCreateCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TBulletCreateCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x06021F18 RID: 139032 RVA: 0x004AD9CD File Offset: 0x004ABBCD
		public static VectorOffset CreateCreateConditionsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TBulletCreateCondition> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TBulletCreateCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x06021F19 RID: 139033 RVA: 0x004AD9EB File Offset: 0x004ABBEB
		public static VectorOffset CreateCreateConditionsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TBulletCreateCondition>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021F1A RID: 139034 RVA: 0x004ADA04 File Offset: 0x004ABC04
		public static void StartCreateConditionsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06021F1B RID: 139035 RVA: 0x004ADA0F File Offset: 0x004ABC0F
		public static void AddCreateConditions(FlatBufferBuilder builder, VectorOffset createConditionsOffset)
		{
			builder.AddOffset(1, createConditionsOffset.Value, 0);
		}

		// Token: 0x06021F1C RID: 139036 RVA: 0x004ADA20 File Offset: 0x004ABC20
		public static VectorOffset CreateCreateConditionsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06021F1D RID: 139037 RVA: 0x004ADA57 File Offset: 0x004ABC57
		public static VectorOffset CreateCreateConditionsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06021F1E RID: 139038 RVA: 0x004ADA71 File Offset: 0x004ABC71
		public static VectorOffset CreateCreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06021F1F RID: 139039 RVA: 0x004ADA8F File Offset: 0x004ABC8F
		public static VectorOffset CreateCreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021F20 RID: 139040 RVA: 0x004ADAA8 File Offset: 0x004ABCA8
		public static void StartCreateConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021F21 RID: 139041 RVA: 0x004ADAB3 File Offset: 0x004ABCB3
		public static Offset<IBulletCfg> EndIBulletCfg(FlatBufferBuilder builder)
		{
			return new Offset<IBulletCfg>(builder.EndTable());
		}

		// Token: 0x06021F22 RID: 139042 RVA: 0x004ADAC0 File Offset: 0x004ABCC0
		public IBulletCfgT UnPack()
		{
			IBulletCfgT bulletCfgT = new IBulletCfgT();
			this.UnPackTo(bulletCfgT);
			return bulletCfgT;
		}

		// Token: 0x06021F23 RID: 139043 RVA: 0x004ADADC File Offset: 0x004ABCDC
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

		// Token: 0x06021F24 RID: 139044 RVA: 0x004ADC64 File Offset: 0x004ABE64
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

		// Token: 0x0400E94D RID: 59725
		private Table __p;
	}
}
