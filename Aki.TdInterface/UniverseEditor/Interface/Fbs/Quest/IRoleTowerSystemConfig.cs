using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040E2 RID: 16610
	public struct IRoleTowerSystemConfig : IFlatbufferObject
	{
		// Token: 0x17007516 RID: 29974
		// (get) Token: 0x06018334 RID: 99124 RVA: 0x0037C271 File Offset: 0x0037A471
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018335 RID: 99125 RVA: 0x0037C27E File Offset: 0x0037A47E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018336 RID: 99126 RVA: 0x0037C288 File Offset: 0x0037A488
		public static IRoleTowerSystemConfig GetRootAsIRoleTowerSystemConfig(ByteBuffer _bb)
		{
			return IRoleTowerSystemConfig.GetRootAsIRoleTowerSystemConfig(_bb, default(IRoleTowerSystemConfig));
		}

		// Token: 0x06018337 RID: 99127 RVA: 0x0037C2A4 File Offset: 0x0037A4A4
		public static IRoleTowerSystemConfig GetRootAsIRoleTowerSystemConfig(ByteBuffer _bb, IRoleTowerSystemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018338 RID: 99128 RVA: 0x0037C2C1 File Offset: 0x0037A4C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018339 RID: 99129 RVA: 0x0037C2D0 File Offset: 0x0037A4D0
		public IRoleTowerSystemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007517 RID: 29975
		// (get) Token: 0x0601833A RID: 99130 RVA: 0x0037C2E0 File Offset: 0x0037A4E0
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

		// Token: 0x0601833B RID: 99131 RVA: 0x0037C31C File Offset: 0x0037A51C
		public IRoleTowerSystemVar? Vars(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IRoleTowerSystemVar?(default(IRoleTowerSystemVar).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007518 RID: 29976
		// (get) Token: 0x0601833C RID: 99132 RVA: 0x0037C37C File Offset: 0x0037A57C
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

		// Token: 0x0601833D RID: 99133 RVA: 0x0037C3A7 File Offset: 0x0037A5A7
		public static Offset<IRoleTowerSystemConfig> CreateIRoleTowerSystemConfig(FlatBufferBuilder builder, EEnableSystemType Type = EEnableSystemType.GradingSystem, VectorOffset VarsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IRoleTowerSystemConfig.AddVars(builder, VarsOffset);
			IRoleTowerSystemConfig.AddType(builder, Type);
			return IRoleTowerSystemConfig.EndIRoleTowerSystemConfig(builder);
		}

		// Token: 0x0601833E RID: 99134 RVA: 0x0037C3C4 File Offset: 0x0037A5C4
		public static void StartIRoleTowerSystemConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601833F RID: 99135 RVA: 0x0037C3CD File Offset: 0x0037A5CD
		public static void AddType(FlatBufferBuilder builder, EEnableSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018340 RID: 99136 RVA: 0x0037C3D8 File Offset: 0x0037A5D8
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(1, varsOffset.Value, 0);
		}

		// Token: 0x06018341 RID: 99137 RVA: 0x0037C3E8 File Offset: 0x0037A5E8
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, Offset<IRoleTowerSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06018342 RID: 99138 RVA: 0x0037C428 File Offset: 0x0037A628
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, Offset<IRoleTowerSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IRoleTowerSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018343 RID: 99139 RVA: 0x0037C442 File Offset: 0x0037A642
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IRoleTowerSystemVar>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IRoleTowerSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018344 RID: 99140 RVA: 0x0037C460 File Offset: 0x0037A660
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IRoleTowerSystemVar>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018345 RID: 99141 RVA: 0x0037C479 File Offset: 0x0037A679
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018346 RID: 99142 RVA: 0x0037C484 File Offset: 0x0037A684
		public static Offset<IRoleTowerSystemConfig> EndIRoleTowerSystemConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRoleTowerSystemConfig>(builder.EndTable());
		}

		// Token: 0x06018347 RID: 99143 RVA: 0x0037C494 File Offset: 0x0037A694
		public IRoleTowerSystemConfigT UnPack()
		{
			IRoleTowerSystemConfigT roleTowerSystemConfigT = new IRoleTowerSystemConfigT();
			this.UnPackTo(roleTowerSystemConfigT);
			return roleTowerSystemConfigT;
		}

		// Token: 0x06018348 RID: 99144 RVA: 0x0037C4B0 File Offset: 0x0037A6B0
		public void UnPackTo(IRoleTowerSystemConfigT _o)
		{
			_o.Type = this.Type;
			_o.Vars = new List<IRoleTowerSystemVarT>();
			for (int i = 0; i < this.VarsLength; i++)
			{
				_o.Vars.Add((this.Vars(i) != null) ? this.Vars(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06018349 RID: 99145 RVA: 0x0037C51C File Offset: 0x0037A71C
		public static Offset<IRoleTowerSystemConfig> Pack(FlatBufferBuilder builder, IRoleTowerSystemConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleTowerSystemConfig>);
			}
			VectorOffset varsOffset = default(VectorOffset);
			if (_o.Vars != null)
			{
				Offset<IRoleTowerSystemVar>[] array = new Offset<IRoleTowerSystemVar>[_o.Vars.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IRoleTowerSystemVar.Pack(builder, _o.Vars[i]);
				}
				varsOffset = IRoleTowerSystemConfig.CreateVarsVector(builder, array);
			}
			return IRoleTowerSystemConfig.CreateIRoleTowerSystemConfig(builder, _o.Type, varsOffset);
		}

		// Token: 0x0400BC7A RID: 48250
		private Table __p;
	}
}
