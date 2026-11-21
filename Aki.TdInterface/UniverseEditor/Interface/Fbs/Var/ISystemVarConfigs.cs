using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EDA RID: 16090
	public struct ISystemVarConfigs : IFlatbufferObject
	{
		// Token: 0x17006CEC RID: 27884
		// (get) Token: 0x06015CBD RID: 89277 RVA: 0x00322A48 File Offset: 0x00320C48
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015CBE RID: 89278 RVA: 0x00322A55 File Offset: 0x00320C55
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015CBF RID: 89279 RVA: 0x00322A5C File Offset: 0x00320C5C
		public static ISystemVarConfigs GetRootAsISystemVarConfigs(ByteBuffer _bb)
		{
			return ISystemVarConfigs.GetRootAsISystemVarConfigs(_bb, default(ISystemVarConfigs));
		}

		// Token: 0x06015CC0 RID: 89280 RVA: 0x00322A78 File Offset: 0x00320C78
		public static ISystemVarConfigs GetRootAsISystemVarConfigs(ByteBuffer _bb, ISystemVarConfigs obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015CC1 RID: 89281 RVA: 0x00322A95 File Offset: 0x00320C95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015CC2 RID: 89282 RVA: 0x00322AA4 File Offset: 0x00320CA4
		public ISystemVarConfigs __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06015CC3 RID: 89283 RVA: 0x00322AB4 File Offset: 0x00320CB4
		public Record_ESystemModuleName_ISystemVarDefines? Vars(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new Record_ESystemModuleName_ISystemVarDefines?(default(Record_ESystemModuleName_ISystemVarDefines).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006CED RID: 27885
		// (get) Token: 0x06015CC4 RID: 89284 RVA: 0x00322B14 File Offset: 0x00320D14
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

		// Token: 0x06015CC5 RID: 89285 RVA: 0x00322B3F File Offset: 0x00320D3F
		public static Offset<ISystemVarConfigs> CreateISystemVarConfigs(FlatBufferBuilder builder, VectorOffset VarsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			ISystemVarConfigs.AddVars(builder, VarsOffset);
			return ISystemVarConfigs.EndISystemVarConfigs(builder);
		}

		// Token: 0x06015CC6 RID: 89286 RVA: 0x00322B55 File Offset: 0x00320D55
		public static void StartISystemVarConfigs(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015CC7 RID: 89287 RVA: 0x00322B5E File Offset: 0x00320D5E
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(0, varsOffset.Value, 0);
		}

		// Token: 0x06015CC8 RID: 89288 RVA: 0x00322B70 File Offset: 0x00320D70
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, Offset<Record_ESystemModuleName_ISystemVarDefines>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06015CC9 RID: 89289 RVA: 0x00322BB0 File Offset: 0x00320DB0
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, Offset<Record_ESystemModuleName_ISystemVarDefines>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_ESystemModuleName_ISystemVarDefines>>(data);
			return builder.EndVector();
		}

		// Token: 0x06015CCA RID: 89290 RVA: 0x00322BCA File Offset: 0x00320DCA
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_ESystemModuleName_ISystemVarDefines>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_ESystemModuleName_ISystemVarDefines>>(data);
			return builder.EndVector();
		}

		// Token: 0x06015CCB RID: 89291 RVA: 0x00322BE8 File Offset: 0x00320DE8
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_ESystemModuleName_ISystemVarDefines>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06015CCC RID: 89292 RVA: 0x00322C01 File Offset: 0x00320E01
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06015CCD RID: 89293 RVA: 0x00322C0C File Offset: 0x00320E0C
		public static Offset<ISystemVarConfigs> EndISystemVarConfigs(FlatBufferBuilder builder)
		{
			return new Offset<ISystemVarConfigs>(builder.EndTable());
		}

		// Token: 0x06015CCE RID: 89294 RVA: 0x00322C1C File Offset: 0x00320E1C
		public ISystemVarConfigsT UnPack()
		{
			ISystemVarConfigsT systemVarConfigsT = new ISystemVarConfigsT();
			this.UnPackTo(systemVarConfigsT);
			return systemVarConfigsT;
		}

		// Token: 0x06015CCF RID: 89295 RVA: 0x00322C38 File Offset: 0x00320E38
		public void UnPackTo(ISystemVarConfigsT _o)
		{
			_o.Vars = new List<Record_ESystemModuleName_ISystemVarDefinesT>();
			for (int i = 0; i < this.VarsLength; i++)
			{
				_o.Vars.Add((this.Vars(i) != null) ? this.Vars(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06015CD0 RID: 89296 RVA: 0x00322C98 File Offset: 0x00320E98
		public static Offset<ISystemVarConfigs> Pack(FlatBufferBuilder builder, ISystemVarConfigsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISystemVarConfigs>);
			}
			VectorOffset varsOffset = default(VectorOffset);
			if (_o.Vars != null)
			{
				Offset<Record_ESystemModuleName_ISystemVarDefines>[] array = new Offset<Record_ESystemModuleName_ISystemVarDefines>[_o.Vars.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = Record_ESystemModuleName_ISystemVarDefines.Pack(builder, _o.Vars[i]);
				}
				varsOffset = ISystemVarConfigs.CreateVarsVector(builder, array);
			}
			return ISystemVarConfigs.CreateISystemVarConfigs(builder, varsOffset);
		}

		// Token: 0x0400B902 RID: 47362
		private Table __p;
	}
}
