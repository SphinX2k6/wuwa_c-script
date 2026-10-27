using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F4F RID: 20303
	public struct ICalculateComponent : IFlatbufferObject
	{
		// Token: 0x17009269 RID: 37481
		// (get) Token: 0x060202A5 RID: 131749 RVA: 0x00479CF9 File Offset: 0x00477EF9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060202A6 RID: 131750 RVA: 0x00479D06 File Offset: 0x00477F06
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060202A7 RID: 131751 RVA: 0x00479D10 File Offset: 0x00477F10
		public static ICalculateComponent GetRootAsICalculateComponent(ByteBuffer _bb)
		{
			return ICalculateComponent.GetRootAsICalculateComponent(_bb, default(ICalculateComponent));
		}

		// Token: 0x060202A8 RID: 131752 RVA: 0x00479D2C File Offset: 0x00477F2C
		public static ICalculateComponent GetRootAsICalculateComponent(ByteBuffer _bb, ICalculateComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060202A9 RID: 131753 RVA: 0x00479D49 File Offset: 0x00477F49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060202AA RID: 131754 RVA: 0x00479D58 File Offset: 0x00477F58
		public ICalculateComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700926A RID: 37482
		// (get) Token: 0x060202AB RID: 131755 RVA: 0x00479D68 File Offset: 0x00477F68
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060202AC RID: 131756 RVA: 0x00479DA8 File Offset: 0x00477FA8
		public INumberVar? Vars(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new INumberVar?(default(INumberVar).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700926B RID: 37483
		// (get) Token: 0x060202AD RID: 131757 RVA: 0x00479E08 File Offset: 0x00478008
		public int VarsLength
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

		// Token: 0x060202AE RID: 131758 RVA: 0x00479E34 File Offset: 0x00478034
		public IFunction? Functions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IFunction?(default(IFunction).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700926C RID: 37484
		// (get) Token: 0x060202AF RID: 131759 RVA: 0x00479E94 File Offset: 0x00478094
		public int FunctionsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700926D RID: 37485
		// (get) Token: 0x060202B0 RID: 131760 RVA: 0x00479EC0 File Offset: 0x004780C0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060202B1 RID: 131761 RVA: 0x00479EFD File Offset: 0x004780FD
		public static Offset<ICalculateComponent> CreateICalculateComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset VarsOffset = default(VectorOffset), VectorOffset FunctionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			ICalculateComponent.AddFunctions(builder, FunctionsOffset);
			ICalculateComponent.AddVars(builder, VarsOffset);
			ICalculateComponent.AddNullMask(builder, NullMask);
			ICalculateComponent.AddDisabled(builder, Disabled);
			return ICalculateComponent.EndICalculateComponent(builder);
		}

		// Token: 0x060202B2 RID: 131762 RVA: 0x00479F29 File Offset: 0x00478129
		public static void StartICalculateComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060202B3 RID: 131763 RVA: 0x00479F32 File Offset: 0x00478132
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060202B4 RID: 131764 RVA: 0x00479F3D File Offset: 0x0047813D
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(1, varsOffset.Value, 0);
		}

		// Token: 0x060202B5 RID: 131765 RVA: 0x00479F50 File Offset: 0x00478150
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, Offset<INumberVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060202B6 RID: 131766 RVA: 0x00479F90 File Offset: 0x00478190
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, Offset<INumberVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<INumberVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x060202B7 RID: 131767 RVA: 0x00479FAA File Offset: 0x004781AA
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<INumberVar>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<INumberVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x060202B8 RID: 131768 RVA: 0x00479FC8 File Offset: 0x004781C8
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<INumberVar>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060202B9 RID: 131769 RVA: 0x00479FE1 File Offset: 0x004781E1
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060202BA RID: 131770 RVA: 0x00479FEC File Offset: 0x004781EC
		public static void AddFunctions(FlatBufferBuilder builder, VectorOffset functionsOffset)
		{
			builder.AddOffset(2, functionsOffset.Value, 0);
		}

		// Token: 0x060202BB RID: 131771 RVA: 0x00479FFC File Offset: 0x004781FC
		public static VectorOffset CreateFunctionsVector(FlatBufferBuilder builder, Offset<IFunction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060202BC RID: 131772 RVA: 0x0047A03C File Offset: 0x0047823C
		public static VectorOffset CreateFunctionsVectorBlock(FlatBufferBuilder builder, Offset<IFunction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFunction>>(data);
			return builder.EndVector();
		}

		// Token: 0x060202BD RID: 131773 RVA: 0x0047A056 File Offset: 0x00478256
		public static VectorOffset CreateFunctionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFunction>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFunction>>(data);
			return builder.EndVector();
		}

		// Token: 0x060202BE RID: 131774 RVA: 0x0047A074 File Offset: 0x00478274
		public static VectorOffset CreateFunctionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFunction>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060202BF RID: 131775 RVA: 0x0047A08D File Offset: 0x0047828D
		public static void StartFunctionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060202C0 RID: 131776 RVA: 0x0047A098 File Offset: 0x00478298
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060202C1 RID: 131777 RVA: 0x0047A0A3 File Offset: 0x004782A3
		public static Offset<ICalculateComponent> EndICalculateComponent(FlatBufferBuilder builder)
		{
			return new Offset<ICalculateComponent>(builder.EndTable());
		}

		// Token: 0x060202C2 RID: 131778 RVA: 0x0047A0B0 File Offset: 0x004782B0
		public ICalculateComponentT UnPack()
		{
			ICalculateComponentT calculateComponentT = new ICalculateComponentT();
			this.UnPackTo(calculateComponentT);
			return calculateComponentT;
		}

		// Token: 0x060202C3 RID: 131779 RVA: 0x0047A0CC File Offset: 0x004782CC
		public void UnPackTo(ICalculateComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Vars = new List<INumberVarT>();
			for (int i = 0; i < this.VarsLength; i++)
			{
				_o.Vars.Add((this.Vars(i) != null) ? this.Vars(i).Value.UnPack() : null);
			}
			_o.Functions = new List<IFunctionT>();
			for (int j = 0; j < this.FunctionsLength; j++)
			{
				_o.Functions.Add((this.Functions(j) != null) ? this.Functions(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060202C4 RID: 131780 RVA: 0x0047A198 File Offset: 0x00478398
		public static Offset<ICalculateComponent> Pack(FlatBufferBuilder builder, ICalculateComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICalculateComponent>);
			}
			VectorOffset varsOffset = default(VectorOffset);
			if (_o.Vars != null)
			{
				Offset<INumberVar>[] array = new Offset<INumberVar>[_o.Vars.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = INumberVar.Pack(builder, _o.Vars[i]);
				}
				varsOffset = ICalculateComponent.CreateVarsVector(builder, array);
			}
			VectorOffset functionsOffset = default(VectorOffset);
			if (_o.Functions != null)
			{
				Offset<IFunction>[] array2 = new Offset<IFunction>[_o.Functions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IFunction.Pack(builder, _o.Functions[j]);
				}
				functionsOffset = ICalculateComponent.CreateFunctionsVector(builder, array2);
			}
			return ICalculateComponent.CreateICalculateComponent(builder, _o.Disabled, varsOffset, functionsOffset, _o.NullMask);
		}

		// Token: 0x0400DDC9 RID: 56777
		private Table __p;
	}
}
