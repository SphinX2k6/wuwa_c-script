using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040B5 RID: 16565
	public struct IRogueTowerTrialSystemConfig : IFlatbufferObject
	{
		// Token: 0x170074E7 RID: 29927
		// (get) Token: 0x06018211 RID: 98833 RVA: 0x0037A675 File Offset: 0x00378875
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018212 RID: 98834 RVA: 0x0037A682 File Offset: 0x00378882
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018213 RID: 98835 RVA: 0x0037A68C File Offset: 0x0037888C
		public static IRogueTowerTrialSystemConfig GetRootAsIRogueTowerTrialSystemConfig(ByteBuffer _bb)
		{
			return IRogueTowerTrialSystemConfig.GetRootAsIRogueTowerTrialSystemConfig(_bb, default(IRogueTowerTrialSystemConfig));
		}

		// Token: 0x06018214 RID: 98836 RVA: 0x0037A6A8 File Offset: 0x003788A8
		public static IRogueTowerTrialSystemConfig GetRootAsIRogueTowerTrialSystemConfig(ByteBuffer _bb, IRogueTowerTrialSystemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018215 RID: 98837 RVA: 0x0037A6C5 File Offset: 0x003788C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018216 RID: 98838 RVA: 0x0037A6D4 File Offset: 0x003788D4
		public IRogueTowerTrialSystemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170074E8 RID: 29928
		// (get) Token: 0x06018217 RID: 98839 RVA: 0x0037A6E4 File Offset: 0x003788E4
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

		// Token: 0x06018218 RID: 98840 RVA: 0x0037A720 File Offset: 0x00378920
		public IRogueTowerTrialSystemVar? Vars(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IRogueTowerTrialSystemVar?(default(IRogueTowerTrialSystemVar).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170074E9 RID: 29929
		// (get) Token: 0x06018219 RID: 98841 RVA: 0x0037A780 File Offset: 0x00378980
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

		// Token: 0x0601821A RID: 98842 RVA: 0x0037A7AB File Offset: 0x003789AB
		public static Offset<IRogueTowerTrialSystemConfig> CreateIRogueTowerTrialSystemConfig(FlatBufferBuilder builder, EEnableSystemType Type = EEnableSystemType.GradingSystem, VectorOffset VarsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IRogueTowerTrialSystemConfig.AddVars(builder, VarsOffset);
			IRogueTowerTrialSystemConfig.AddType(builder, Type);
			return IRogueTowerTrialSystemConfig.EndIRogueTowerTrialSystemConfig(builder);
		}

		// Token: 0x0601821B RID: 98843 RVA: 0x0037A7C8 File Offset: 0x003789C8
		public static void StartIRogueTowerTrialSystemConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601821C RID: 98844 RVA: 0x0037A7D1 File Offset: 0x003789D1
		public static void AddType(FlatBufferBuilder builder, EEnableSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601821D RID: 98845 RVA: 0x0037A7DC File Offset: 0x003789DC
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(1, varsOffset.Value, 0);
		}

		// Token: 0x0601821E RID: 98846 RVA: 0x0037A7EC File Offset: 0x003789EC
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, Offset<IRogueTowerTrialSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601821F RID: 98847 RVA: 0x0037A82C File Offset: 0x00378A2C
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, Offset<IRogueTowerTrialSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IRogueTowerTrialSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018220 RID: 98848 RVA: 0x0037A846 File Offset: 0x00378A46
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IRogueTowerTrialSystemVar>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IRogueTowerTrialSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018221 RID: 98849 RVA: 0x0037A864 File Offset: 0x00378A64
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IRogueTowerTrialSystemVar>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018222 RID: 98850 RVA: 0x0037A87D File Offset: 0x00378A7D
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018223 RID: 98851 RVA: 0x0037A888 File Offset: 0x00378A88
		public static Offset<IRogueTowerTrialSystemConfig> EndIRogueTowerTrialSystemConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRogueTowerTrialSystemConfig>(builder.EndTable());
		}

		// Token: 0x06018224 RID: 98852 RVA: 0x0037A898 File Offset: 0x00378A98
		public IRogueTowerTrialSystemConfigT UnPack()
		{
			IRogueTowerTrialSystemConfigT rogueTowerTrialSystemConfigT = new IRogueTowerTrialSystemConfigT();
			this.UnPackTo(rogueTowerTrialSystemConfigT);
			return rogueTowerTrialSystemConfigT;
		}

		// Token: 0x06018225 RID: 98853 RVA: 0x0037A8B4 File Offset: 0x00378AB4
		public void UnPackTo(IRogueTowerTrialSystemConfigT _o)
		{
			_o.Type = this.Type;
			_o.Vars = new List<IRogueTowerTrialSystemVarT>();
			for (int i = 0; i < this.VarsLength; i++)
			{
				_o.Vars.Add((this.Vars(i) != null) ? this.Vars(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06018226 RID: 98854 RVA: 0x0037A920 File Offset: 0x00378B20
		public static Offset<IRogueTowerTrialSystemConfig> Pack(FlatBufferBuilder builder, IRogueTowerTrialSystemConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRogueTowerTrialSystemConfig>);
			}
			VectorOffset varsOffset = default(VectorOffset);
			if (_o.Vars != null)
			{
				Offset<IRogueTowerTrialSystemVar>[] array = new Offset<IRogueTowerTrialSystemVar>[_o.Vars.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IRogueTowerTrialSystemVar.Pack(builder, _o.Vars[i]);
				}
				varsOffset = IRogueTowerTrialSystemConfig.CreateVarsVector(builder, array);
			}
			return IRogueTowerTrialSystemConfig.CreateIRogueTowerTrialSystemConfig(builder, _o.Type, varsOffset);
		}

		// Token: 0x0400BC4C RID: 48204
		private Table __p;
	}
}
