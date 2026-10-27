using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E66 RID: 15974
	public struct IFlipperSystemConfig : IFlatbufferObject
	{
		// Token: 0x17006EBD RID: 28349
		// (get) Token: 0x060167CA RID: 92106 RVA: 0x003401A1 File Offset: 0x0033E3A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060167CB RID: 92107 RVA: 0x003401AE File Offset: 0x0033E3AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060167CC RID: 92108 RVA: 0x003401B8 File Offset: 0x0033E3B8
		public static IFlipperSystemConfig GetRootAsIFlipperSystemConfig(ByteBuffer _bb)
		{
			return IFlipperSystemConfig.GetRootAsIFlipperSystemConfig(_bb, default(IFlipperSystemConfig));
		}

		// Token: 0x060167CD RID: 92109 RVA: 0x003401D4 File Offset: 0x0033E3D4
		public static IFlipperSystemConfig GetRootAsIFlipperSystemConfig(ByteBuffer _bb, IFlipperSystemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060167CE RID: 92110 RVA: 0x003401F1 File Offset: 0x0033E3F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060167CF RID: 92111 RVA: 0x00340200 File Offset: 0x0033E400
		public IFlipperSystemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006EBE RID: 28350
		// (get) Token: 0x060167D0 RID: 92112 RVA: 0x00340210 File Offset: 0x0033E410
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

		// Token: 0x060167D1 RID: 92113 RVA: 0x0034024C File Offset: 0x0033E44C
		public IFlipperSystemVar? Vars(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IFlipperSystemVar?(default(IFlipperSystemVar).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006EBF RID: 28351
		// (get) Token: 0x060167D2 RID: 92114 RVA: 0x003402AC File Offset: 0x0033E4AC
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

		// Token: 0x060167D3 RID: 92115 RVA: 0x003402D7 File Offset: 0x0033E4D7
		public static Offset<IFlipperSystemConfig> CreateIFlipperSystemConfig(FlatBufferBuilder builder, EEnableSystemType Type = EEnableSystemType.GradingSystem, VectorOffset VarsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IFlipperSystemConfig.AddVars(builder, VarsOffset);
			IFlipperSystemConfig.AddType(builder, Type);
			return IFlipperSystemConfig.EndIFlipperSystemConfig(builder);
		}

		// Token: 0x060167D4 RID: 92116 RVA: 0x003402F4 File Offset: 0x0033E4F4
		public static void StartIFlipperSystemConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060167D5 RID: 92117 RVA: 0x003402FD File Offset: 0x0033E4FD
		public static void AddType(FlatBufferBuilder builder, EEnableSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060167D6 RID: 92118 RVA: 0x00340308 File Offset: 0x0033E508
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(1, varsOffset.Value, 0);
		}

		// Token: 0x060167D7 RID: 92119 RVA: 0x00340318 File Offset: 0x0033E518
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, Offset<IFlipperSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060167D8 RID: 92120 RVA: 0x00340358 File Offset: 0x0033E558
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, Offset<IFlipperSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFlipperSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x060167D9 RID: 92121 RVA: 0x00340372 File Offset: 0x0033E572
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFlipperSystemVar>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFlipperSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x060167DA RID: 92122 RVA: 0x00340390 File Offset: 0x0033E590
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFlipperSystemVar>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060167DB RID: 92123 RVA: 0x003403A9 File Offset: 0x0033E5A9
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060167DC RID: 92124 RVA: 0x003403B4 File Offset: 0x0033E5B4
		public static Offset<IFlipperSystemConfig> EndIFlipperSystemConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFlipperSystemConfig>(builder.EndTable());
		}

		// Token: 0x060167DD RID: 92125 RVA: 0x003403C4 File Offset: 0x0033E5C4
		public IFlipperSystemConfigT UnPack()
		{
			IFlipperSystemConfigT flipperSystemConfigT = new IFlipperSystemConfigT();
			this.UnPackTo(flipperSystemConfigT);
			return flipperSystemConfigT;
		}

		// Token: 0x060167DE RID: 92126 RVA: 0x003403E0 File Offset: 0x0033E5E0
		public void UnPackTo(IFlipperSystemConfigT _o)
		{
			_o.Type = this.Type;
			_o.Vars = new List<IFlipperSystemVarT>();
			for (int i = 0; i < this.VarsLength; i++)
			{
				_o.Vars.Add((this.Vars(i) != null) ? this.Vars(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060167DF RID: 92127 RVA: 0x0034044C File Offset: 0x0033E64C
		public static Offset<IFlipperSystemConfig> Pack(FlatBufferBuilder builder, IFlipperSystemConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlipperSystemConfig>);
			}
			VectorOffset varsOffset = default(VectorOffset);
			if (_o.Vars != null)
			{
				Offset<IFlipperSystemVar>[] array = new Offset<IFlipperSystemVar>[_o.Vars.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IFlipperSystemVar.Pack(builder, _o.Vars[i]);
				}
				varsOffset = IFlipperSystemConfig.CreateVarsVector(builder, array);
			}
			return IFlipperSystemConfig.CreateIFlipperSystemConfig(builder, _o.Type, varsOffset);
		}

		// Token: 0x0400B817 RID: 47127
		private Table __p;
	}
}
