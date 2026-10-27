using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EF0 RID: 16112
	public struct IKurotatoSystemConfig : IFlatbufferObject
	{
		// Token: 0x17006FC4 RID: 28612
		// (get) Token: 0x06016CAB RID: 93355 RVA: 0x00349A19 File Offset: 0x00347C19
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016CAC RID: 93356 RVA: 0x00349A26 File Offset: 0x00347C26
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016CAD RID: 93357 RVA: 0x00349A30 File Offset: 0x00347C30
		public static IKurotatoSystemConfig GetRootAsIKurotatoSystemConfig(ByteBuffer _bb)
		{
			return IKurotatoSystemConfig.GetRootAsIKurotatoSystemConfig(_bb, default(IKurotatoSystemConfig));
		}

		// Token: 0x06016CAE RID: 93358 RVA: 0x00349A4C File Offset: 0x00347C4C
		public static IKurotatoSystemConfig GetRootAsIKurotatoSystemConfig(ByteBuffer _bb, IKurotatoSystemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016CAF RID: 93359 RVA: 0x00349A69 File Offset: 0x00347C69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016CB0 RID: 93360 RVA: 0x00349A78 File Offset: 0x00347C78
		public IKurotatoSystemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006FC5 RID: 28613
		// (get) Token: 0x06016CB1 RID: 93361 RVA: 0x00349A88 File Offset: 0x00347C88
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

		// Token: 0x06016CB2 RID: 93362 RVA: 0x00349AC4 File Offset: 0x00347CC4
		public IKurotatoSystemVar? Vars(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IKurotatoSystemVar?(default(IKurotatoSystemVar).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006FC6 RID: 28614
		// (get) Token: 0x06016CB3 RID: 93363 RVA: 0x00349B24 File Offset: 0x00347D24
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

		// Token: 0x06016CB4 RID: 93364 RVA: 0x00349B4F File Offset: 0x00347D4F
		public static Offset<IKurotatoSystemConfig> CreateIKurotatoSystemConfig(FlatBufferBuilder builder, EEnableSystemType Type = EEnableSystemType.GradingSystem, VectorOffset VarsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IKurotatoSystemConfig.AddVars(builder, VarsOffset);
			IKurotatoSystemConfig.AddType(builder, Type);
			return IKurotatoSystemConfig.EndIKurotatoSystemConfig(builder);
		}

		// Token: 0x06016CB5 RID: 93365 RVA: 0x00349B6C File Offset: 0x00347D6C
		public static void StartIKurotatoSystemConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06016CB6 RID: 93366 RVA: 0x00349B75 File Offset: 0x00347D75
		public static void AddType(FlatBufferBuilder builder, EEnableSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016CB7 RID: 93367 RVA: 0x00349B80 File Offset: 0x00347D80
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(1, varsOffset.Value, 0);
		}

		// Token: 0x06016CB8 RID: 93368 RVA: 0x00349B90 File Offset: 0x00347D90
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, Offset<IKurotatoSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06016CB9 RID: 93369 RVA: 0x00349BD0 File Offset: 0x00347DD0
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, Offset<IKurotatoSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IKurotatoSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016CBA RID: 93370 RVA: 0x00349BEA File Offset: 0x00347DEA
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IKurotatoSystemVar>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IKurotatoSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016CBB RID: 93371 RVA: 0x00349C08 File Offset: 0x00347E08
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IKurotatoSystemVar>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016CBC RID: 93372 RVA: 0x00349C21 File Offset: 0x00347E21
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016CBD RID: 93373 RVA: 0x00349C2C File Offset: 0x00347E2C
		public static Offset<IKurotatoSystemConfig> EndIKurotatoSystemConfig(FlatBufferBuilder builder)
		{
			return new Offset<IKurotatoSystemConfig>(builder.EndTable());
		}

		// Token: 0x06016CBE RID: 93374 RVA: 0x00349C3C File Offset: 0x00347E3C
		public IKurotatoSystemConfigT UnPack()
		{
			IKurotatoSystemConfigT kurotatoSystemConfigT = new IKurotatoSystemConfigT();
			this.UnPackTo(kurotatoSystemConfigT);
			return kurotatoSystemConfigT;
		}

		// Token: 0x06016CBF RID: 93375 RVA: 0x00349C58 File Offset: 0x00347E58
		public void UnPackTo(IKurotatoSystemConfigT _o)
		{
			_o.Type = this.Type;
			_o.Vars = new List<IKurotatoSystemVarT>();
			for (int i = 0; i < this.VarsLength; i++)
			{
				_o.Vars.Add((this.Vars(i) != null) ? this.Vars(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06016CC0 RID: 93376 RVA: 0x00349CC4 File Offset: 0x00347EC4
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

		// Token: 0x0400B8CD RID: 47309
		private Table __p;
	}
}
