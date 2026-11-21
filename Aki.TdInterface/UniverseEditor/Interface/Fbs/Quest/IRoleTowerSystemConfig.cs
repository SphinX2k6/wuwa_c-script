using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004523 RID: 17699
	public struct IRoleTowerSystemConfig : IFlatbufferObject
	{
		// Token: 0x17007B1C RID: 31516
		// (get) Token: 0x060199D5 RID: 104917 RVA: 0x003A61C1 File Offset: 0x003A43C1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060199D6 RID: 104918 RVA: 0x003A61CE File Offset: 0x003A43CE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060199D7 RID: 104919 RVA: 0x003A61D8 File Offset: 0x003A43D8
		public static IRoleTowerSystemConfig GetRootAsIRoleTowerSystemConfig(ByteBuffer _bb)
		{
			return IRoleTowerSystemConfig.GetRootAsIRoleTowerSystemConfig(_bb, default(IRoleTowerSystemConfig));
		}

		// Token: 0x060199D8 RID: 104920 RVA: 0x003A61F4 File Offset: 0x003A43F4
		public static IRoleTowerSystemConfig GetRootAsIRoleTowerSystemConfig(ByteBuffer _bb, IRoleTowerSystemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060199D9 RID: 104921 RVA: 0x003A6211 File Offset: 0x003A4411
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060199DA RID: 104922 RVA: 0x003A6220 File Offset: 0x003A4420
		public IRoleTowerSystemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B1D RID: 31517
		// (get) Token: 0x060199DB RID: 104923 RVA: 0x003A6230 File Offset: 0x003A4430
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

		// Token: 0x060199DC RID: 104924 RVA: 0x003A626C File Offset: 0x003A446C
		public IRoleTowerSystemVar? Vars(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IRoleTowerSystemVar?(default(IRoleTowerSystemVar).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007B1E RID: 31518
		// (get) Token: 0x060199DD RID: 104925 RVA: 0x003A62CC File Offset: 0x003A44CC
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

		// Token: 0x060199DE RID: 104926 RVA: 0x003A62F7 File Offset: 0x003A44F7
		public static Offset<IRoleTowerSystemConfig> CreateIRoleTowerSystemConfig(FlatBufferBuilder builder, EEnableSystemType Type = EEnableSystemType.GradingSystem, VectorOffset VarsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IRoleTowerSystemConfig.AddVars(builder, VarsOffset);
			IRoleTowerSystemConfig.AddType(builder, Type);
			return IRoleTowerSystemConfig.EndIRoleTowerSystemConfig(builder);
		}

		// Token: 0x060199DF RID: 104927 RVA: 0x003A6314 File Offset: 0x003A4514
		public static void StartIRoleTowerSystemConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060199E0 RID: 104928 RVA: 0x003A631D File Offset: 0x003A451D
		public static void AddType(FlatBufferBuilder builder, EEnableSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060199E1 RID: 104929 RVA: 0x003A6328 File Offset: 0x003A4528
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(1, varsOffset.Value, 0);
		}

		// Token: 0x060199E2 RID: 104930 RVA: 0x003A6338 File Offset: 0x003A4538
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, Offset<IRoleTowerSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060199E3 RID: 104931 RVA: 0x003A6378 File Offset: 0x003A4578
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, Offset<IRoleTowerSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IRoleTowerSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x060199E4 RID: 104932 RVA: 0x003A6392 File Offset: 0x003A4592
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IRoleTowerSystemVar>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IRoleTowerSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x060199E5 RID: 104933 RVA: 0x003A63B0 File Offset: 0x003A45B0
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IRoleTowerSystemVar>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060199E6 RID: 104934 RVA: 0x003A63C9 File Offset: 0x003A45C9
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060199E7 RID: 104935 RVA: 0x003A63D4 File Offset: 0x003A45D4
		public static Offset<IRoleTowerSystemConfig> EndIRoleTowerSystemConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRoleTowerSystemConfig>(builder.EndTable());
		}

		// Token: 0x060199E8 RID: 104936 RVA: 0x003A63E4 File Offset: 0x003A45E4
		public IRoleTowerSystemConfigT UnPack()
		{
			IRoleTowerSystemConfigT roleTowerSystemConfigT = new IRoleTowerSystemConfigT();
			this.UnPackTo(roleTowerSystemConfigT);
			return roleTowerSystemConfigT;
		}

		// Token: 0x060199E9 RID: 104937 RVA: 0x003A6400 File Offset: 0x003A4600
		public void UnPackTo(IRoleTowerSystemConfigT _o)
		{
			_o.Type = this.Type;
			_o.Vars = new List<IRoleTowerSystemVarT>();
			for (int i = 0; i < this.VarsLength; i++)
			{
				_o.Vars.Add((this.Vars(i) != null) ? this.Vars(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060199EA RID: 104938 RVA: 0x003A646C File Offset: 0x003A466C
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

		// Token: 0x0400C663 RID: 50787
		private Table __p;
	}
}
