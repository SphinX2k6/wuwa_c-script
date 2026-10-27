using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A99 RID: 15001
	public struct IGlobalVarConfigs : IFlatbufferObject
	{
		// Token: 0x170066C5 RID: 26309
		// (get) Token: 0x060145B4 RID: 83380 RVA: 0x002F8386 File Offset: 0x002F6586
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060145B5 RID: 83381 RVA: 0x002F8393 File Offset: 0x002F6593
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060145B6 RID: 83382 RVA: 0x002F839C File Offset: 0x002F659C
		public static IGlobalVarConfigs GetRootAsIGlobalVarConfigs(ByteBuffer _bb)
		{
			return IGlobalVarConfigs.GetRootAsIGlobalVarConfigs(_bb, default(IGlobalVarConfigs));
		}

		// Token: 0x060145B7 RID: 83383 RVA: 0x002F83B8 File Offset: 0x002F65B8
		public static IGlobalVarConfigs GetRootAsIGlobalVarConfigs(ByteBuffer _bb, IGlobalVarConfigs obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060145B8 RID: 83384 RVA: 0x002F83D5 File Offset: 0x002F65D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060145B9 RID: 83385 RVA: 0x002F83E4 File Offset: 0x002F65E4
		public IGlobalVarConfigs __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060145BA RID: 83386 RVA: 0x002F83F4 File Offset: 0x002F65F4
		public IVarDefine? Vars(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IVarDefine?(default(IVarDefine).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170066C6 RID: 26310
		// (get) Token: 0x060145BB RID: 83387 RVA: 0x002F8454 File Offset: 0x002F6654
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

		// Token: 0x060145BC RID: 83388 RVA: 0x002F847F File Offset: 0x002F667F
		public static Offset<IGlobalVarConfigs> CreateIGlobalVarConfigs(FlatBufferBuilder builder, VectorOffset VarsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IGlobalVarConfigs.AddVars(builder, VarsOffset);
			return IGlobalVarConfigs.EndIGlobalVarConfigs(builder);
		}

		// Token: 0x060145BD RID: 83389 RVA: 0x002F8495 File Offset: 0x002F6695
		public static void StartIGlobalVarConfigs(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060145BE RID: 83390 RVA: 0x002F849E File Offset: 0x002F669E
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(0, varsOffset.Value, 0);
		}

		// Token: 0x060145BF RID: 83391 RVA: 0x002F84B0 File Offset: 0x002F66B0
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, Offset<IVarDefine>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060145C0 RID: 83392 RVA: 0x002F84F0 File Offset: 0x002F66F0
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, Offset<IVarDefine>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVarDefine>>(data);
			return builder.EndVector();
		}

		// Token: 0x060145C1 RID: 83393 RVA: 0x002F850A File Offset: 0x002F670A
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVarDefine>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVarDefine>>(data);
			return builder.EndVector();
		}

		// Token: 0x060145C2 RID: 83394 RVA: 0x002F8528 File Offset: 0x002F6728
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVarDefine>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060145C3 RID: 83395 RVA: 0x002F8541 File Offset: 0x002F6741
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060145C4 RID: 83396 RVA: 0x002F854C File Offset: 0x002F674C
		public static Offset<IGlobalVarConfigs> EndIGlobalVarConfigs(FlatBufferBuilder builder)
		{
			return new Offset<IGlobalVarConfigs>(builder.EndTable());
		}

		// Token: 0x060145C5 RID: 83397 RVA: 0x002F855C File Offset: 0x002F675C
		public IGlobalVarConfigsT UnPack()
		{
			IGlobalVarConfigsT globalVarConfigsT = new IGlobalVarConfigsT();
			this.UnPackTo(globalVarConfigsT);
			return globalVarConfigsT;
		}

		// Token: 0x060145C6 RID: 83398 RVA: 0x002F8578 File Offset: 0x002F6778
		public void UnPackTo(IGlobalVarConfigsT _o)
		{
			_o.Vars = new List<IVarDefineT>();
			for (int i = 0; i < this.VarsLength; i++)
			{
				_o.Vars.Add((this.Vars(i) != null) ? this.Vars(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060145C7 RID: 83399 RVA: 0x002F85D8 File Offset: 0x002F67D8
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

		// Token: 0x0400AF19 RID: 44825
		private Table __p;
	}
}
