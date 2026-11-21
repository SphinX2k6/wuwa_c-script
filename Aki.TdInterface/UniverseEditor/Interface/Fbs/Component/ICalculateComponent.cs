using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200547E RID: 21630
	public struct ICalculateComponent : IFlatbufferObject
	{
		// Token: 0x170099E2 RID: 39394
		// (get) Token: 0x06021FF7 RID: 139255 RVA: 0x004AFCE9 File Offset: 0x004ADEE9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021FF8 RID: 139256 RVA: 0x004AFCF6 File Offset: 0x004ADEF6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021FF9 RID: 139257 RVA: 0x004AFD00 File Offset: 0x004ADF00
		public static ICalculateComponent GetRootAsICalculateComponent(ByteBuffer _bb)
		{
			return ICalculateComponent.GetRootAsICalculateComponent(_bb, default(ICalculateComponent));
		}

		// Token: 0x06021FFA RID: 139258 RVA: 0x004AFD1C File Offset: 0x004ADF1C
		public static ICalculateComponent GetRootAsICalculateComponent(ByteBuffer _bb, ICalculateComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021FFB RID: 139259 RVA: 0x004AFD39 File Offset: 0x004ADF39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021FFC RID: 139260 RVA: 0x004AFD48 File Offset: 0x004ADF48
		public ICalculateComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170099E3 RID: 39395
		// (get) Token: 0x06021FFD RID: 139261 RVA: 0x004AFD58 File Offset: 0x004ADF58
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06021FFE RID: 139262 RVA: 0x004AFD98 File Offset: 0x004ADF98
		public INumberVar? Vars(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new INumberVar?(default(INumberVar).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170099E4 RID: 39396
		// (get) Token: 0x06021FFF RID: 139263 RVA: 0x004AFDF8 File Offset: 0x004ADFF8
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

		// Token: 0x06022000 RID: 139264 RVA: 0x004AFE24 File Offset: 0x004AE024
		public IFunction? Functions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IFunction?(default(IFunction).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170099E5 RID: 39397
		// (get) Token: 0x06022001 RID: 139265 RVA: 0x004AFE84 File Offset: 0x004AE084
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

		// Token: 0x170099E6 RID: 39398
		// (get) Token: 0x06022002 RID: 139266 RVA: 0x004AFEB0 File Offset: 0x004AE0B0
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

		// Token: 0x06022003 RID: 139267 RVA: 0x004AFEED File Offset: 0x004AE0ED
		public static Offset<ICalculateComponent> CreateICalculateComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset VarsOffset = default(VectorOffset), VectorOffset FunctionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			ICalculateComponent.AddFunctions(builder, FunctionsOffset);
			ICalculateComponent.AddVars(builder, VarsOffset);
			ICalculateComponent.AddNullMask(builder, NullMask);
			ICalculateComponent.AddDisabled(builder, Disabled);
			return ICalculateComponent.EndICalculateComponent(builder);
		}

		// Token: 0x06022004 RID: 139268 RVA: 0x004AFF19 File Offset: 0x004AE119
		public static void StartICalculateComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06022005 RID: 139269 RVA: 0x004AFF22 File Offset: 0x004AE122
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06022006 RID: 139270 RVA: 0x004AFF2D File Offset: 0x004AE12D
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(1, varsOffset.Value, 0);
		}

		// Token: 0x06022007 RID: 139271 RVA: 0x004AFF40 File Offset: 0x004AE140
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, Offset<INumberVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022008 RID: 139272 RVA: 0x004AFF80 File Offset: 0x004AE180
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, Offset<INumberVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<INumberVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022009 RID: 139273 RVA: 0x004AFF9A File Offset: 0x004AE19A
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<INumberVar>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<INumberVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602200A RID: 139274 RVA: 0x004AFFB8 File Offset: 0x004AE1B8
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<INumberVar>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602200B RID: 139275 RVA: 0x004AFFD1 File Offset: 0x004AE1D1
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602200C RID: 139276 RVA: 0x004AFFDC File Offset: 0x004AE1DC
		public static void AddFunctions(FlatBufferBuilder builder, VectorOffset functionsOffset)
		{
			builder.AddOffset(2, functionsOffset.Value, 0);
		}

		// Token: 0x0602200D RID: 139277 RVA: 0x004AFFEC File Offset: 0x004AE1EC
		public static VectorOffset CreateFunctionsVector(FlatBufferBuilder builder, Offset<IFunction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602200E RID: 139278 RVA: 0x004B002C File Offset: 0x004AE22C
		public static VectorOffset CreateFunctionsVectorBlock(FlatBufferBuilder builder, Offset<IFunction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFunction>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602200F RID: 139279 RVA: 0x004B0046 File Offset: 0x004AE246
		public static VectorOffset CreateFunctionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFunction>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFunction>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022010 RID: 139280 RVA: 0x004B0064 File Offset: 0x004AE264
		public static VectorOffset CreateFunctionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFunction>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022011 RID: 139281 RVA: 0x004B007D File Offset: 0x004AE27D
		public static void StartFunctionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022012 RID: 139282 RVA: 0x004B0088 File Offset: 0x004AE288
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06022013 RID: 139283 RVA: 0x004B0093 File Offset: 0x004AE293
		public static Offset<ICalculateComponent> EndICalculateComponent(FlatBufferBuilder builder)
		{
			return new Offset<ICalculateComponent>(builder.EndTable());
		}

		// Token: 0x06022014 RID: 139284 RVA: 0x004B00A0 File Offset: 0x004AE2A0
		public ICalculateComponentT UnPack()
		{
			ICalculateComponentT calculateComponentT = new ICalculateComponentT();
			this.UnPackTo(calculateComponentT);
			return calculateComponentT;
		}

		// Token: 0x06022015 RID: 139285 RVA: 0x004B00BC File Offset: 0x004AE2BC
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

		// Token: 0x06022016 RID: 139286 RVA: 0x004B0188 File Offset: 0x004AE388
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

		// Token: 0x0400E973 RID: 59763
		private Table __p;
	}
}
