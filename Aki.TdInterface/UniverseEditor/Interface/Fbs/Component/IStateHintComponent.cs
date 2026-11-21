using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FB7 RID: 24503
	public struct IStateHintComponent : IFlatbufferObject
	{
		// Token: 0x1700B578 RID: 46456
		// (get) Token: 0x06029394 RID: 168852 RVA: 0x005A0939 File Offset: 0x0059EB39
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029395 RID: 168853 RVA: 0x005A0946 File Offset: 0x0059EB46
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029396 RID: 168854 RVA: 0x005A0950 File Offset: 0x0059EB50
		public static IStateHintComponent GetRootAsIStateHintComponent(ByteBuffer _bb)
		{
			return IStateHintComponent.GetRootAsIStateHintComponent(_bb, default(IStateHintComponent));
		}

		// Token: 0x06029397 RID: 168855 RVA: 0x005A096C File Offset: 0x0059EB6C
		public static IStateHintComponent GetRootAsIStateHintComponent(ByteBuffer _bb, IStateHintComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029398 RID: 168856 RVA: 0x005A0989 File Offset: 0x0059EB89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029399 RID: 168857 RVA: 0x005A0998 File Offset: 0x0059EB98
		public IStateHintComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B579 RID: 46457
		// (get) Token: 0x0602939A RID: 168858 RVA: 0x005A09A8 File Offset: 0x0059EBA8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602939B RID: 168859 RVA: 0x005A09E8 File Offset: 0x0059EBE8
		public IEntityStateCondition? ActiveConditions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IEntityStateCondition?(default(IEntityStateCondition).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B57A RID: 46458
		// (get) Token: 0x0602939C RID: 168860 RVA: 0x005A0A48 File Offset: 0x0059EC48
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

		// Token: 0x1700B57B RID: 46459
		// (get) Token: 0x0602939D RID: 168861 RVA: 0x005A0A74 File Offset: 0x0059EC74
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

		// Token: 0x0602939E RID: 168862 RVA: 0x005A0AB0 File Offset: 0x0059ECB0
		public static Offset<IStateHintComponent> CreateIStateHintComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset ActiveConditionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IStateHintComponent.AddActiveConditions(builder, ActiveConditionsOffset);
			IStateHintComponent.AddNullMask(builder, NullMask);
			IStateHintComponent.AddDisabled(builder, Disabled);
			return IStateHintComponent.EndIStateHintComponent(builder);
		}

		// Token: 0x0602939F RID: 168863 RVA: 0x005A0AD4 File Offset: 0x0059ECD4
		public static void StartIStateHintComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060293A0 RID: 168864 RVA: 0x005A0ADD File Offset: 0x0059ECDD
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060293A1 RID: 168865 RVA: 0x005A0AE8 File Offset: 0x0059ECE8
		public static void AddActiveConditions(FlatBufferBuilder builder, VectorOffset activeConditionsOffset)
		{
			builder.AddOffset(1, activeConditionsOffset.Value, 0);
		}

		// Token: 0x060293A2 RID: 168866 RVA: 0x005A0AF8 File Offset: 0x0059ECF8
		public static VectorOffset CreateActiveConditionsVector(FlatBufferBuilder builder, Offset<IEntityStateCondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060293A3 RID: 168867 RVA: 0x005A0B38 File Offset: 0x0059ED38
		public static VectorOffset CreateActiveConditionsVectorBlock(FlatBufferBuilder builder, Offset<IEntityStateCondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityStateCondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x060293A4 RID: 168868 RVA: 0x005A0B52 File Offset: 0x0059ED52
		public static VectorOffset CreateActiveConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityStateCondition>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityStateCondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x060293A5 RID: 168869 RVA: 0x005A0B70 File Offset: 0x0059ED70
		public static VectorOffset CreateActiveConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityStateCondition>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060293A6 RID: 168870 RVA: 0x005A0B89 File Offset: 0x0059ED89
		public static void StartActiveConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060293A7 RID: 168871 RVA: 0x005A0B94 File Offset: 0x0059ED94
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060293A8 RID: 168872 RVA: 0x005A0B9F File Offset: 0x0059ED9F
		public static Offset<IStateHintComponent> EndIStateHintComponent(FlatBufferBuilder builder)
		{
			return new Offset<IStateHintComponent>(builder.EndTable());
		}

		// Token: 0x060293A9 RID: 168873 RVA: 0x005A0BAC File Offset: 0x0059EDAC
		public IStateHintComponentT UnPack()
		{
			IStateHintComponentT stateHintComponentT = new IStateHintComponentT();
			this.UnPackTo(stateHintComponentT);
			return stateHintComponentT;
		}

		// Token: 0x060293AA RID: 168874 RVA: 0x005A0BC8 File Offset: 0x0059EDC8
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

		// Token: 0x060293AB RID: 168875 RVA: 0x005A0C40 File Offset: 0x0059EE40
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

		// Token: 0x0400FCAD RID: 64685
		private Table __p;
	}
}
