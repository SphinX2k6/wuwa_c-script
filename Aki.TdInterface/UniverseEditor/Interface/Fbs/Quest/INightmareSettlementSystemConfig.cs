using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200439A RID: 17306
	public struct INightmareSettlementSystemConfig : IFlatbufferObject
	{
		// Token: 0x170076BB RID: 30395
		// (get) Token: 0x06018774 RID: 100212 RVA: 0x0037C880 File Offset: 0x0037AA80
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018775 RID: 100213 RVA: 0x0037C88D File Offset: 0x0037AA8D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018776 RID: 100214 RVA: 0x0037C894 File Offset: 0x0037AA94
		public static INightmareSettlementSystemConfig GetRootAsINightmareSettlementSystemConfig(ByteBuffer _bb)
		{
			return INightmareSettlementSystemConfig.GetRootAsINightmareSettlementSystemConfig(_bb, default(INightmareSettlementSystemConfig));
		}

		// Token: 0x06018777 RID: 100215 RVA: 0x0037C8B0 File Offset: 0x0037AAB0
		public static INightmareSettlementSystemConfig GetRootAsINightmareSettlementSystemConfig(ByteBuffer _bb, INightmareSettlementSystemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018778 RID: 100216 RVA: 0x0037C8CD File Offset: 0x0037AACD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018779 RID: 100217 RVA: 0x0037C8DC File Offset: 0x0037AADC
		public INightmareSettlementSystemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170076BC RID: 30396
		// (get) Token: 0x0601877A RID: 100218 RVA: 0x0037C8EC File Offset: 0x0037AAEC
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

		// Token: 0x0601877B RID: 100219 RVA: 0x0037C928 File Offset: 0x0037AB28
		public INightmareSettlementSystemVar? SystemVars(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new INightmareSettlementSystemVar?(default(INightmareSettlementSystemVar).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170076BD RID: 30397
		// (get) Token: 0x0601877C RID: 100220 RVA: 0x0037C988 File Offset: 0x0037AB88
		public int SystemVarsLength
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

		// Token: 0x0601877D RID: 100221 RVA: 0x0037C9B3 File Offset: 0x0037ABB3
		public static Offset<INightmareSettlementSystemConfig> CreateINightmareSettlementSystemConfig(FlatBufferBuilder builder, EEnableSystemType Type = EEnableSystemType.GradingSystem, VectorOffset SystemVarsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			INightmareSettlementSystemConfig.AddSystemVars(builder, SystemVarsOffset);
			INightmareSettlementSystemConfig.AddType(builder, Type);
			return INightmareSettlementSystemConfig.EndINightmareSettlementSystemConfig(builder);
		}

		// Token: 0x0601877E RID: 100222 RVA: 0x0037C9D0 File Offset: 0x0037ABD0
		public static void StartINightmareSettlementSystemConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601877F RID: 100223 RVA: 0x0037C9D9 File Offset: 0x0037ABD9
		public static void AddType(FlatBufferBuilder builder, EEnableSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018780 RID: 100224 RVA: 0x0037C9E4 File Offset: 0x0037ABE4
		public static void AddSystemVars(FlatBufferBuilder builder, VectorOffset systemVarsOffset)
		{
			builder.AddOffset(1, systemVarsOffset.Value, 0);
		}

		// Token: 0x06018781 RID: 100225 RVA: 0x0037C9F4 File Offset: 0x0037ABF4
		public static VectorOffset CreateSystemVarsVector(FlatBufferBuilder builder, Offset<INightmareSettlementSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06018782 RID: 100226 RVA: 0x0037CA34 File Offset: 0x0037AC34
		public static VectorOffset CreateSystemVarsVectorBlock(FlatBufferBuilder builder, Offset<INightmareSettlementSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<INightmareSettlementSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018783 RID: 100227 RVA: 0x0037CA4E File Offset: 0x0037AC4E
		public static VectorOffset CreateSystemVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<INightmareSettlementSystemVar>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<INightmareSettlementSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018784 RID: 100228 RVA: 0x0037CA6C File Offset: 0x0037AC6C
		public static VectorOffset CreateSystemVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<INightmareSettlementSystemVar>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018785 RID: 100229 RVA: 0x0037CA85 File Offset: 0x0037AC85
		public static void StartSystemVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018786 RID: 100230 RVA: 0x0037CA90 File Offset: 0x0037AC90
		public static Offset<INightmareSettlementSystemConfig> EndINightmareSettlementSystemConfig(FlatBufferBuilder builder)
		{
			return new Offset<INightmareSettlementSystemConfig>(builder.EndTable());
		}

		// Token: 0x06018787 RID: 100231 RVA: 0x0037CAA0 File Offset: 0x0037ACA0
		public INightmareSettlementSystemConfigT UnPack()
		{
			INightmareSettlementSystemConfigT nightmareSettlementSystemConfigT = new INightmareSettlementSystemConfigT();
			this.UnPackTo(nightmareSettlementSystemConfigT);
			return nightmareSettlementSystemConfigT;
		}

		// Token: 0x06018788 RID: 100232 RVA: 0x0037CABC File Offset: 0x0037ACBC
		public void UnPackTo(INightmareSettlementSystemConfigT _o)
		{
			_o.Type = this.Type;
			_o.SystemVars = new List<INightmareSettlementSystemVarT>();
			for (int i = 0; i < this.SystemVarsLength; i++)
			{
				_o.SystemVars.Add((this.SystemVars(i) != null) ? this.SystemVars(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06018789 RID: 100233 RVA: 0x0037CB28 File Offset: 0x0037AD28
		public static Offset<INightmareSettlementSystemConfig> Pack(FlatBufferBuilder builder, INightmareSettlementSystemConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<INightmareSettlementSystemConfig>);
			}
			VectorOffset systemVarsOffset = default(VectorOffset);
			if (_o.SystemVars != null)
			{
				Offset<INightmareSettlementSystemVar>[] array = new Offset<INightmareSettlementSystemVar>[_o.SystemVars.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = INightmareSettlementSystemVar.Pack(builder, _o.SystemVars[i]);
				}
				systemVarsOffset = INightmareSettlementSystemConfig.CreateSystemVarsVector(builder, array);
			}
			return INightmareSettlementSystemConfig.CreateINightmareSettlementSystemConfig(builder, _o.Type, systemVarsOffset);
		}

		// Token: 0x0400C34F RID: 49999
		private Table __p;
	}
}
