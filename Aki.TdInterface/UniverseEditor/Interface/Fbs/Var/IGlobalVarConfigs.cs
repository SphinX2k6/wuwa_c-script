using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E9B RID: 16027
	public struct IGlobalVarConfigs : IFlatbufferObject
	{
		// Token: 0x17006C60 RID: 27744
		// (get) Token: 0x06015A5A RID: 88666 RVA: 0x0031E594 File Offset: 0x0031C794
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015A5B RID: 88667 RVA: 0x0031E5A1 File Offset: 0x0031C7A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015A5C RID: 88668 RVA: 0x0031E5A8 File Offset: 0x0031C7A8
		public static IGlobalVarConfigs GetRootAsIGlobalVarConfigs(ByteBuffer _bb)
		{
			return IGlobalVarConfigs.GetRootAsIGlobalVarConfigs(_bb, default(IGlobalVarConfigs));
		}

		// Token: 0x06015A5D RID: 88669 RVA: 0x0031E5C4 File Offset: 0x0031C7C4
		public static IGlobalVarConfigs GetRootAsIGlobalVarConfigs(ByteBuffer _bb, IGlobalVarConfigs obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015A5E RID: 88670 RVA: 0x0031E5E1 File Offset: 0x0031C7E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015A5F RID: 88671 RVA: 0x0031E5F0 File Offset: 0x0031C7F0
		public IGlobalVarConfigs __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06015A60 RID: 88672 RVA: 0x0031E600 File Offset: 0x0031C800
		public IVarDefine? Vars(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IVarDefine?(default(IVarDefine).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006C61 RID: 27745
		// (get) Token: 0x06015A61 RID: 88673 RVA: 0x0031E660 File Offset: 0x0031C860
		public int VarsLength
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

		// Token: 0x06015A62 RID: 88674 RVA: 0x0031E68B File Offset: 0x0031C88B
		public static Offset<IGlobalVarConfigs> CreateIGlobalVarConfigs(FlatBufferBuilder builder, VectorOffset VarsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IGlobalVarConfigs.AddVars(builder, VarsOffset);
			return IGlobalVarConfigs.EndIGlobalVarConfigs(builder);
		}

		// Token: 0x06015A63 RID: 88675 RVA: 0x0031E6A1 File Offset: 0x0031C8A1
		public static void StartIGlobalVarConfigs(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015A64 RID: 88676 RVA: 0x0031E6AA File Offset: 0x0031C8AA
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(0, varsOffset.Value, 0);
		}

		// Token: 0x06015A65 RID: 88677 RVA: 0x0031E6BC File Offset: 0x0031C8BC
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, Offset<IVarDefine>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06015A66 RID: 88678 RVA: 0x0031E6FC File Offset: 0x0031C8FC
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, Offset<IVarDefine>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVarDefine>>(data);
			return builder.EndVector();
		}

		// Token: 0x06015A67 RID: 88679 RVA: 0x0031E716 File Offset: 0x0031C916
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVarDefine>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVarDefine>>(data);
			return builder.EndVector();
		}

		// Token: 0x06015A68 RID: 88680 RVA: 0x0031E734 File Offset: 0x0031C934
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVarDefine>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06015A69 RID: 88681 RVA: 0x0031E74D File Offset: 0x0031C94D
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06015A6A RID: 88682 RVA: 0x0031E758 File Offset: 0x0031C958
		public static Offset<IGlobalVarConfigs> EndIGlobalVarConfigs(FlatBufferBuilder builder)
		{
			return new Offset<IGlobalVarConfigs>(builder.EndTable());
		}

		// Token: 0x06015A6B RID: 88683 RVA: 0x0031E768 File Offset: 0x0031C968
		public IGlobalVarConfigsT UnPack()
		{
			IGlobalVarConfigsT globalVarConfigsT = new IGlobalVarConfigsT();
			this.UnPackTo(globalVarConfigsT);
			return globalVarConfigsT;
		}

		// Token: 0x06015A6C RID: 88684 RVA: 0x0031E784 File Offset: 0x0031C984
		public void UnPackTo(IGlobalVarConfigsT _o)
		{
			_o.Vars = new List<IVarDefineT>();
			for (int i = 0; i < this.VarsLength; i++)
			{
				_o.Vars.Add((this.Vars(i) != null) ? this.Vars(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06015A6D RID: 88685 RVA: 0x0031E7E4 File Offset: 0x0031C9E4
		public static Offset<IGlobalVarConfigs> Pack(FlatBufferBuilder builder, IGlobalVarConfigsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGlobalVarConfigs>);
			}
			VectorOffset varsOffset = default(VectorOffset);
			if (_o.Vars != null)
			{
				Offset<IVarDefine>[] array = new Offset<IVarDefine>[_o.Vars.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IVarDefine.Pack(builder, _o.Vars[i]);
				}
				varsOffset = IGlobalVarConfigs.CreateVarsVector(builder, array);
			}
			return IGlobalVarConfigs.CreateIGlobalVarConfigs(builder, varsOffset);
		}

		// Token: 0x0400B884 RID: 47236
		private Table __p;
	}
}
