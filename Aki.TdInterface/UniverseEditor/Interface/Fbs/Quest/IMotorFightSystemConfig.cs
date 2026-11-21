using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004382 RID: 17282
	public struct IMotorFightSystemConfig : IFlatbufferObject
	{
		// Token: 0x17007692 RID: 30354
		// (get) Token: 0x060186B3 RID: 100019 RVA: 0x0037B172 File Offset: 0x00379372
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060186B4 RID: 100020 RVA: 0x0037B17F File Offset: 0x0037937F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060186B5 RID: 100021 RVA: 0x0037B188 File Offset: 0x00379388
		public static IMotorFightSystemConfig GetRootAsIMotorFightSystemConfig(ByteBuffer _bb)
		{
			return IMotorFightSystemConfig.GetRootAsIMotorFightSystemConfig(_bb, default(IMotorFightSystemConfig));
		}

		// Token: 0x060186B6 RID: 100022 RVA: 0x0037B1A4 File Offset: 0x003793A4
		public static IMotorFightSystemConfig GetRootAsIMotorFightSystemConfig(ByteBuffer _bb, IMotorFightSystemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060186B7 RID: 100023 RVA: 0x0037B1C1 File Offset: 0x003793C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060186B8 RID: 100024 RVA: 0x0037B1D0 File Offset: 0x003793D0
		public IMotorFightSystemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007693 RID: 30355
		// (get) Token: 0x060186B9 RID: 100025 RVA: 0x0037B1E0 File Offset: 0x003793E0
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

		// Token: 0x060186BA RID: 100026 RVA: 0x0037B21C File Offset: 0x0037941C
		public IMotorFightSystemVar? Vars(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IMotorFightSystemVar?(default(IMotorFightSystemVar).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007694 RID: 30356
		// (get) Token: 0x060186BB RID: 100027 RVA: 0x0037B27C File Offset: 0x0037947C
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

		// Token: 0x060186BC RID: 100028 RVA: 0x0037B2A7 File Offset: 0x003794A7
		public static Offset<IMotorFightSystemConfig> CreateIMotorFightSystemConfig(FlatBufferBuilder builder, EEnableSystemType Type = EEnableSystemType.GradingSystem, VectorOffset VarsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IMotorFightSystemConfig.AddVars(builder, VarsOffset);
			IMotorFightSystemConfig.AddType(builder, Type);
			return IMotorFightSystemConfig.EndIMotorFightSystemConfig(builder);
		}

		// Token: 0x060186BD RID: 100029 RVA: 0x0037B2C4 File Offset: 0x003794C4
		public static void StartIMotorFightSystemConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060186BE RID: 100030 RVA: 0x0037B2CD File Offset: 0x003794CD
		public static void AddType(FlatBufferBuilder builder, EEnableSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060186BF RID: 100031 RVA: 0x0037B2D8 File Offset: 0x003794D8
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(1, varsOffset.Value, 0);
		}

		// Token: 0x060186C0 RID: 100032 RVA: 0x0037B2E8 File Offset: 0x003794E8
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, Offset<IMotorFightSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060186C1 RID: 100033 RVA: 0x0037B328 File Offset: 0x00379528
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, Offset<IMotorFightSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMotorFightSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x060186C2 RID: 100034 RVA: 0x0037B342 File Offset: 0x00379542
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMotorFightSystemVar>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMotorFightSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x060186C3 RID: 100035 RVA: 0x0037B360 File Offset: 0x00379560
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMotorFightSystemVar>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060186C4 RID: 100036 RVA: 0x0037B379 File Offset: 0x00379579
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060186C5 RID: 100037 RVA: 0x0037B384 File Offset: 0x00379584
		public static Offset<IMotorFightSystemConfig> EndIMotorFightSystemConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMotorFightSystemConfig>(builder.EndTable());
		}

		// Token: 0x060186C6 RID: 100038 RVA: 0x0037B394 File Offset: 0x00379594
		public IMotorFightSystemConfigT UnPack()
		{
			IMotorFightSystemConfigT motorFightSystemConfigT = new IMotorFightSystemConfigT();
			this.UnPackTo(motorFightSystemConfigT);
			return motorFightSystemConfigT;
		}

		// Token: 0x060186C7 RID: 100039 RVA: 0x0037B3B0 File Offset: 0x003795B0
		public void UnPackTo(IMotorFightSystemConfigT _o)
		{
			_o.Type = this.Type;
			_o.Vars = new List<IMotorFightSystemVarT>();
			for (int i = 0; i < this.VarsLength; i++)
			{
				_o.Vars.Add((this.Vars(i) != null) ? this.Vars(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060186C8 RID: 100040 RVA: 0x0037B41C File Offset: 0x0037961C
		public static Offset<IMotorFightSystemConfig> Pack(FlatBufferBuilder builder, IMotorFightSystemConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorFightSystemConfig>);
			}
			VectorOffset varsOffset = default(VectorOffset);
			if (_o.Vars != null)
			{
				Offset<IMotorFightSystemVar>[] array = new Offset<IMotorFightSystemVar>[_o.Vars.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IMotorFightSystemVar.Pack(builder, _o.Vars[i]);
				}
				varsOffset = IMotorFightSystemConfig.CreateVarsVector(builder, array);
			}
			return IMotorFightSystemConfig.CreateIMotorFightSystemConfig(builder, _o.Type, varsOffset);
		}

		// Token: 0x0400C332 RID: 49970
		private Table __p;
	}
}
