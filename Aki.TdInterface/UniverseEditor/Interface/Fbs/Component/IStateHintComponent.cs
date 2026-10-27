using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059AA RID: 22954
	public struct IStateHintComponent : IFlatbufferObject
	{
		// Token: 0x1700AC44 RID: 44100
		// (get) Token: 0x06026E2A RID: 159274 RVA: 0x00559CCD File Offset: 0x00557ECD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026E2B RID: 159275 RVA: 0x00559CDA File Offset: 0x00557EDA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026E2C RID: 159276 RVA: 0x00559CE4 File Offset: 0x00557EE4
		public static IStateHintComponent GetRootAsIStateHintComponent(ByteBuffer _bb)
		{
			return IStateHintComponent.GetRootAsIStateHintComponent(_bb, default(IStateHintComponent));
		}

		// Token: 0x06026E2D RID: 159277 RVA: 0x00559D00 File Offset: 0x00557F00
		public static IStateHintComponent GetRootAsIStateHintComponent(ByteBuffer _bb, IStateHintComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026E2E RID: 159278 RVA: 0x00559D1D File Offset: 0x00557F1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026E2F RID: 159279 RVA: 0x00559D2C File Offset: 0x00557F2C
		public IStateHintComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC45 RID: 44101
		// (get) Token: 0x06026E30 RID: 159280 RVA: 0x00559D3C File Offset: 0x00557F3C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06026E31 RID: 159281 RVA: 0x00559D7C File Offset: 0x00557F7C
		public IEntityStateCondition? ActiveConditions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IEntityStateCondition?(default(IEntityStateCondition).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AC46 RID: 44102
		// (get) Token: 0x06026E32 RID: 159282 RVA: 0x00559DDC File Offset: 0x00557FDC
		public int ActiveConditionsLength
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

		// Token: 0x1700AC47 RID: 44103
		// (get) Token: 0x06026E33 RID: 159283 RVA: 0x00559E08 File Offset: 0x00558008
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026E34 RID: 159284 RVA: 0x00559E44 File Offset: 0x00558044
		public static Offset<IStateHintComponent> CreateIStateHintComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset ActiveConditionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IStateHintComponent.AddActiveConditions(builder, ActiveConditionsOffset);
			IStateHintComponent.AddNullMask(builder, NullMask);
			IStateHintComponent.AddDisabled(builder, Disabled);
			return IStateHintComponent.EndIStateHintComponent(builder);
		}

		// Token: 0x06026E35 RID: 159285 RVA: 0x00559E68 File Offset: 0x00558068
		public static void StartIStateHintComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06026E36 RID: 159286 RVA: 0x00559E71 File Offset: 0x00558071
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06026E37 RID: 159287 RVA: 0x00559E7C File Offset: 0x0055807C
		public static void AddActiveConditions(FlatBufferBuilder builder, VectorOffset activeConditionsOffset)
		{
			builder.AddOffset(1, activeConditionsOffset.Value, 0);
		}

		// Token: 0x06026E38 RID: 159288 RVA: 0x00559E8C File Offset: 0x0055808C
		public static VectorOffset CreateActiveConditionsVector(FlatBufferBuilder builder, Offset<IEntityStateCondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026E39 RID: 159289 RVA: 0x00559ECC File Offset: 0x005580CC
		public static VectorOffset CreateActiveConditionsVectorBlock(FlatBufferBuilder builder, Offset<IEntityStateCondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityStateCondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026E3A RID: 159290 RVA: 0x00559EE6 File Offset: 0x005580E6
		public static VectorOffset CreateActiveConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityStateCondition>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityStateCondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026E3B RID: 159291 RVA: 0x00559F04 File Offset: 0x00558104
		public static VectorOffset CreateActiveConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityStateCondition>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026E3C RID: 159292 RVA: 0x00559F1D File Offset: 0x0055811D
		public static void StartActiveConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026E3D RID: 159293 RVA: 0x00559F28 File Offset: 0x00558128
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06026E3E RID: 159294 RVA: 0x00559F33 File Offset: 0x00558133
		public static Offset<IStateHintComponent> EndIStateHintComponent(FlatBufferBuilder builder)
		{
			return new Offset<IStateHintComponent>(builder.EndTable());
		}

		// Token: 0x06026E3F RID: 159295 RVA: 0x00559F40 File Offset: 0x00558140
		public IStateHintComponentT UnPack()
		{
			IStateHintComponentT stateHintComponentT = new IStateHintComponentT();
			this.UnPackTo(stateHintComponentT);
			return stateHintComponentT;
		}

		// Token: 0x06026E40 RID: 159296 RVA: 0x00559F5C File Offset: 0x0055815C
		public void UnPackTo(IStateHintComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.ActiveConditions = new List<IEntityStateConditionT>();
			for (int i = 0; i < this.ActiveConditionsLength; i++)
			{
				_o.ActiveConditions.Add((this.ActiveConditions(i) != null) ? this.ActiveConditions(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06026E41 RID: 159297 RVA: 0x00559FD4 File Offset: 0x005581D4
		public static Offset<IStateHintComponent> Pack(FlatBufferBuilder builder, IStateHintComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStateHintComponent>);
			}
			VectorOffset activeConditionsOffset = default(VectorOffset);
			if (_o.ActiveConditions != null)
			{
				Offset<IEntityStateCondition>[] array = new Offset<IEntityStateCondition>[_o.ActiveConditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityStateCondition.Pack(builder, _o.ActiveConditions[i]);
				}
				activeConditionsOffset = IStateHintComponent.CreateActiveConditionsVector(builder, array);
			}
			return IStateHintComponent.CreateIStateHintComponent(builder, _o.Disabled, activeConditionsOffset, _o.NullMask);
		}

		// Token: 0x0400EFB8 RID: 61368
		private Table __p;
	}
}
