using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200432E RID: 17198
	public struct IKurotatoSystemConfig : IFlatbufferObject
	{
		// Token: 0x170075B3 RID: 30131
		// (get) Token: 0x06018302 RID: 99074 RVA: 0x00372BE5 File Offset: 0x00370DE5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018303 RID: 99075 RVA: 0x00372BF2 File Offset: 0x00370DF2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018304 RID: 99076 RVA: 0x00372BFC File Offset: 0x00370DFC
		public static IKurotatoSystemConfig GetRootAsIKurotatoSystemConfig(ByteBuffer _bb)
		{
			return IKurotatoSystemConfig.GetRootAsIKurotatoSystemConfig(_bb, default(IKurotatoSystemConfig));
		}

		// Token: 0x06018305 RID: 99077 RVA: 0x00372C18 File Offset: 0x00370E18
		public static IKurotatoSystemConfig GetRootAsIKurotatoSystemConfig(ByteBuffer _bb, IKurotatoSystemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018306 RID: 99078 RVA: 0x00372C35 File Offset: 0x00370E35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018307 RID: 99079 RVA: 0x00372C44 File Offset: 0x00370E44
		public IKurotatoSystemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170075B4 RID: 30132
		// (get) Token: 0x06018308 RID: 99080 RVA: 0x00372C54 File Offset: 0x00370E54
		public EEnableSystemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEnableSystemType.GradingSystem;
				}
				return (EEnableSystemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018309 RID: 99081 RVA: 0x00372C90 File Offset: 0x00370E90
		public IKurotatoSystemVar? Vars(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IKurotatoSystemVar?(default(IKurotatoSystemVar).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170075B5 RID: 30133
		// (get) Token: 0x0601830A RID: 99082 RVA: 0x00372CF0 File Offset: 0x00370EF0
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

		// Token: 0x0601830B RID: 99083 RVA: 0x00372D1B File Offset: 0x00370F1B
		public static Offset<IKurotatoSystemConfig> CreateIKurotatoSystemConfig(FlatBufferBuilder builder, EEnableSystemType Type = EEnableSystemType.GradingSystem, VectorOffset VarsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IKurotatoSystemConfig.AddVars(builder, VarsOffset);
			IKurotatoSystemConfig.AddType(builder, Type);
			return IKurotatoSystemConfig.EndIKurotatoSystemConfig(builder);
		}

		// Token: 0x0601830C RID: 99084 RVA: 0x00372D38 File Offset: 0x00370F38
		public static void StartIKurotatoSystemConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601830D RID: 99085 RVA: 0x00372D41 File Offset: 0x00370F41
		public static void AddType(FlatBufferBuilder builder, EEnableSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601830E RID: 99086 RVA: 0x00372D4C File Offset: 0x00370F4C
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(1, varsOffset.Value, 0);
		}

		// Token: 0x0601830F RID: 99087 RVA: 0x00372D5C File Offset: 0x00370F5C
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, Offset<IKurotatoSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06018310 RID: 99088 RVA: 0x00372D9C File Offset: 0x00370F9C
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, Offset<IKurotatoSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IKurotatoSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018311 RID: 99089 RVA: 0x00372DB6 File Offset: 0x00370FB6
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IKurotatoSystemVar>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IKurotatoSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018312 RID: 99090 RVA: 0x00372DD4 File Offset: 0x00370FD4
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IKurotatoSystemVar>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018313 RID: 99091 RVA: 0x00372DED File Offset: 0x00370FED
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018314 RID: 99092 RVA: 0x00372DF8 File Offset: 0x00370FF8
		public static Offset<IKurotatoSystemConfig> EndIKurotatoSystemConfig(FlatBufferBuilder builder)
		{
			return new Offset<IKurotatoSystemConfig>(builder.EndTable());
		}

		// Token: 0x06018315 RID: 99093 RVA: 0x00372E08 File Offset: 0x00371008
		public IKurotatoSystemConfigT UnPack()
		{
			IKurotatoSystemConfigT kurotatoSystemConfigT = new IKurotatoSystemConfigT();
			this.UnPackTo(kurotatoSystemConfigT);
			return kurotatoSystemConfigT;
		}

		// Token: 0x06018316 RID: 99094 RVA: 0x00372E24 File Offset: 0x00371024
		public void UnPackTo(IKurotatoSystemConfigT _o)
		{
			_o.Type = this.Type;
			_o.Vars = new List<IKurotatoSystemVarT>();
			for (int i = 0; i < this.VarsLength; i++)
			{
				_o.Vars.Add((this.Vars(i) != null) ? this.Vars(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06018317 RID: 99095 RVA: 0x00372E90 File Offset: 0x00371090
		public static Offset<IKurotatoSystemConfig> Pack(FlatBufferBuilder builder, IKurotatoSystemConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IKurotatoSystemConfig>);
			}
			VectorOffset varsOffset = default(VectorOffset);
			if (_o.Vars != null)
			{
				Offset<IKurotatoSystemVar>[] array = new Offset<IKurotatoSystemVar>[_o.Vars.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IKurotatoSystemVar.Pack(builder, _o.Vars[i]);
				}
				varsOffset = IKurotatoSystemConfig.CreateVarsVector(builder, array);
			}
			return IKurotatoSystemConfig.CreateIKurotatoSystemConfig(builder, _o.Type, varsOffset);
		}

		// Token: 0x0400C2AA RID: 49834
		private Table __p;
	}
}
