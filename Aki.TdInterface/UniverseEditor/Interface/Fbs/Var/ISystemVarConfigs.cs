using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AD8 RID: 15064
	public struct ISystemVarConfigs : IFlatbufferObject
	{
		// Token: 0x17006751 RID: 26449
		// (get) Token: 0x06014813 RID: 83987 RVA: 0x002FC7B8 File Offset: 0x002FA9B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014814 RID: 83988 RVA: 0x002FC7C5 File Offset: 0x002FA9C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014815 RID: 83989 RVA: 0x002FC7CC File Offset: 0x002FA9CC
		public static ISystemVarConfigs GetRootAsISystemVarConfigs(ByteBuffer _bb)
		{
			return ISystemVarConfigs.GetRootAsISystemVarConfigs(_bb, default(ISystemVarConfigs));
		}

		// Token: 0x06014816 RID: 83990 RVA: 0x002FC7E8 File Offset: 0x002FA9E8
		public static ISystemVarConfigs GetRootAsISystemVarConfigs(ByteBuffer _bb, ISystemVarConfigs obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014817 RID: 83991 RVA: 0x002FC805 File Offset: 0x002FAA05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014818 RID: 83992 RVA: 0x002FC814 File Offset: 0x002FAA14
		public ISystemVarConfigs __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06014819 RID: 83993 RVA: 0x002FC824 File Offset: 0x002FAA24
		public Record_ESystemModuleName_ISystemVarDefines? Vars(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new Record_ESystemModuleName_ISystemVarDefines?(default(Record_ESystemModuleName_ISystemVarDefines).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006752 RID: 26450
		// (get) Token: 0x0601481A RID: 83994 RVA: 0x002FC884 File Offset: 0x002FAA84
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

		// Token: 0x0601481B RID: 83995 RVA: 0x002FC8AF File Offset: 0x002FAAAF
		public static Offset<ISystemVarConfigs> CreateISystemVarConfigs(FlatBufferBuilder builder, VectorOffset VarsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			ISystemVarConfigs.AddVars(builder, VarsOffset);
			return ISystemVarConfigs.EndISystemVarConfigs(builder);
		}

		// Token: 0x0601481C RID: 83996 RVA: 0x002FC8C5 File Offset: 0x002FAAC5
		public static void StartISystemVarConfigs(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601481D RID: 83997 RVA: 0x002FC8CE File Offset: 0x002FAACE
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(0, varsOffset.Value, 0);
		}

		// Token: 0x0601481E RID: 83998 RVA: 0x002FC8E0 File Offset: 0x002FAAE0
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, Offset<Record_ESystemModuleName_ISystemVarDefines>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601481F RID: 83999 RVA: 0x002FC920 File Offset: 0x002FAB20
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, Offset<Record_ESystemModuleName_ISystemVarDefines>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_ESystemModuleName_ISystemVarDefines>>(data);
			return builder.EndVector();
		}

		// Token: 0x06014820 RID: 84000 RVA: 0x002FC93A File Offset: 0x002FAB3A
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_ESystemModuleName_ISystemVarDefines>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_ESystemModuleName_ISystemVarDefines>>(data);
			return builder.EndVector();
		}

		// Token: 0x06014821 RID: 84001 RVA: 0x002FC958 File Offset: 0x002FAB58
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_ESystemModuleName_ISystemVarDefines>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06014822 RID: 84002 RVA: 0x002FC971 File Offset: 0x002FAB71
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06014823 RID: 84003 RVA: 0x002FC97C File Offset: 0x002FAB7C
		public static Offset<ISystemVarConfigs> EndISystemVarConfigs(FlatBufferBuilder builder)
		{
			return new Offset<ISystemVarConfigs>(builder.EndTable());
		}

		// Token: 0x06014824 RID: 84004 RVA: 0x002FC98C File Offset: 0x002FAB8C
		public ISystemVarConfigsT UnPack()
		{
			ISystemVarConfigsT systemVarConfigsT = new ISystemVarConfigsT();
			this.UnPackTo(systemVarConfigsT);
			return systemVarConfigsT;
		}

		// Token: 0x06014825 RID: 84005 RVA: 0x002FC9A8 File Offset: 0x002FABA8
		public void UnPackTo(ISystemVarConfigsT _o)
		{
			_o.Vars = new List<Record_ESystemModuleName_ISystemVarDefinesT>();
			for (int i = 0; i < this.VarsLength; i++)
			{
				_o.Vars.Add((this.Vars(i) != null) ? this.Vars(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06014826 RID: 84006 RVA: 0x002FCA08 File Offset: 0x002FAC08
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

		// Token: 0x0400AF95 RID: 44949
		private Table __p;
	}
}
