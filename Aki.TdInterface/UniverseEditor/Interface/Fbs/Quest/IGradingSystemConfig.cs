using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042B9 RID: 17081
	public struct IGradingSystemConfig : IFlatbufferObject
	{
		// Token: 0x170074DD RID: 29917
		// (get) Token: 0x06017EEC RID: 98028 RVA: 0x0036ACCB File Offset: 0x00368ECB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017EED RID: 98029 RVA: 0x0036ACD8 File Offset: 0x00368ED8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017EEE RID: 98030 RVA: 0x0036ACE0 File Offset: 0x00368EE0
		public static IGradingSystemConfig GetRootAsIGradingSystemConfig(ByteBuffer _bb)
		{
			return IGradingSystemConfig.GetRootAsIGradingSystemConfig(_bb, default(IGradingSystemConfig));
		}

		// Token: 0x06017EEF RID: 98031 RVA: 0x0036ACFC File Offset: 0x00368EFC
		public static IGradingSystemConfig GetRootAsIGradingSystemConfig(ByteBuffer _bb, IGradingSystemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017EF0 RID: 98032 RVA: 0x0036AD19 File Offset: 0x00368F19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017EF1 RID: 98033 RVA: 0x0036AD28 File Offset: 0x00368F28
		public IGradingSystemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170074DE RID: 29918
		// (get) Token: 0x06017EF2 RID: 98034 RVA: 0x0036AD38 File Offset: 0x00368F38
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

		// Token: 0x170074DF RID: 29919
		// (get) Token: 0x06017EF3 RID: 98035 RVA: 0x0036AD74 File Offset: 0x00368F74
		public int GradingSystemId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017EF4 RID: 98036 RVA: 0x0036ADB0 File Offset: 0x00368FB0
		public IGradingSystemVar? Vars(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IGradingSystemVar?(default(IGradingSystemVar).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170074E0 RID: 29920
		// (get) Token: 0x06017EF5 RID: 98037 RVA: 0x0036AE10 File Offset: 0x00369010
		public int VarsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170074E1 RID: 29921
		// (get) Token: 0x06017EF6 RID: 98038 RVA: 0x0036AE3C File Offset: 0x0036903C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017EF7 RID: 98039 RVA: 0x0036AE79 File Offset: 0x00369079
		public static Offset<IGradingSystemConfig> CreateIGradingSystemConfig(FlatBufferBuilder builder, EEnableSystemType Type = EEnableSystemType.GradingSystem, int GradingSystemId = 0, VectorOffset VarsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IGradingSystemConfig.AddVars(builder, VarsOffset);
			IGradingSystemConfig.AddGradingSystemId(builder, GradingSystemId);
			IGradingSystemConfig.AddNullMask(builder, NullMask);
			IGradingSystemConfig.AddType(builder, Type);
			return IGradingSystemConfig.EndIGradingSystemConfig(builder);
		}

		// Token: 0x06017EF8 RID: 98040 RVA: 0x0036AEA5 File Offset: 0x003690A5
		public static void StartIGradingSystemConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06017EF9 RID: 98041 RVA: 0x0036AEAE File Offset: 0x003690AE
		public static void AddType(FlatBufferBuilder builder, EEnableSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017EFA RID: 98042 RVA: 0x0036AEB9 File Offset: 0x003690B9
		public static void AddGradingSystemId(FlatBufferBuilder builder, int gradingSystemId)
		{
			builder.AddInt(1, gradingSystemId, 0);
		}

		// Token: 0x06017EFB RID: 98043 RVA: 0x0036AEC4 File Offset: 0x003690C4
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(2, varsOffset.Value, 0);
		}

		// Token: 0x06017EFC RID: 98044 RVA: 0x0036AED4 File Offset: 0x003690D4
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, Offset<IGradingSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06017EFD RID: 98045 RVA: 0x0036AF14 File Offset: 0x00369114
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, Offset<IGradingSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IGradingSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017EFE RID: 98046 RVA: 0x0036AF2E File Offset: 0x0036912E
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IGradingSystemVar>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IGradingSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017EFF RID: 98047 RVA: 0x0036AF4C File Offset: 0x0036914C
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IGradingSystemVar>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017F00 RID: 98048 RVA: 0x0036AF65 File Offset: 0x00369165
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017F01 RID: 98049 RVA: 0x0036AF70 File Offset: 0x00369170
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06017F02 RID: 98050 RVA: 0x0036AF7B File Offset: 0x0036917B
		public static Offset<IGradingSystemConfig> EndIGradingSystemConfig(FlatBufferBuilder builder)
		{
			return new Offset<IGradingSystemConfig>(builder.EndTable());
		}

		// Token: 0x06017F03 RID: 98051 RVA: 0x0036AF88 File Offset: 0x00369188
		public IGradingSystemConfigT UnPack()
		{
			IGradingSystemConfigT gradingSystemConfigT = new IGradingSystemConfigT();
			this.UnPackTo(gradingSystemConfigT);
			return gradingSystemConfigT;
		}

		// Token: 0x06017F04 RID: 98052 RVA: 0x0036AFA4 File Offset: 0x003691A4
		public void UnPackTo(IGradingSystemConfigT _o)
		{
			_o.Type = this.Type;
			_o.GradingSystemId = this.GradingSystemId;
			_o.Vars = new List<IGradingSystemVarT>();
			for (int i = 0; i < this.VarsLength; i++)
			{
				_o.Vars.Add((this.Vars(i) != null) ? this.Vars(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06017F05 RID: 98053 RVA: 0x0036B028 File Offset: 0x00369228
		public static Offset<IGradingSystemConfig> Pack(FlatBufferBuilder builder, IGradingSystemConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGradingSystemConfig>);
			}
			VectorOffset varsOffset = default(VectorOffset);
			if (_o.Vars != null)
			{
				Offset<IGradingSystemVar>[] array = new Offset<IGradingSystemVar>[_o.Vars.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IGradingSystemVar.Pack(builder, _o.Vars[i]);
				}
				varsOffset = IGradingSystemConfig.CreateVarsVector(builder, array);
			}
			return IGradingSystemConfig.CreateIGradingSystemConfig(builder, _o.Type, _o.GradingSystemId, varsOffset, _o.NullMask);
		}

		// Token: 0x0400C210 RID: 49680
		private Table __p;
	}
}
