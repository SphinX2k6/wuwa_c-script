using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F5C RID: 16220
	public struct INightmareSettlementSystemConfig : IFlatbufferObject
	{
		// Token: 0x170070CA RID: 28874
		// (get) Token: 0x06017112 RID: 94482 RVA: 0x0035340C File Offset: 0x0035160C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017113 RID: 94483 RVA: 0x00353419 File Offset: 0x00351619
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017114 RID: 94484 RVA: 0x00353420 File Offset: 0x00351620
		public static INightmareSettlementSystemConfig GetRootAsINightmareSettlementSystemConfig(ByteBuffer _bb)
		{
			return INightmareSettlementSystemConfig.GetRootAsINightmareSettlementSystemConfig(_bb, default(INightmareSettlementSystemConfig));
		}

		// Token: 0x06017115 RID: 94485 RVA: 0x0035343C File Offset: 0x0035163C
		public static INightmareSettlementSystemConfig GetRootAsINightmareSettlementSystemConfig(ByteBuffer _bb, INightmareSettlementSystemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017116 RID: 94486 RVA: 0x00353459 File Offset: 0x00351659
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017117 RID: 94487 RVA: 0x00353468 File Offset: 0x00351668
		public INightmareSettlementSystemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170070CB RID: 28875
		// (get) Token: 0x06017118 RID: 94488 RVA: 0x00353478 File Offset: 0x00351678
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

		// Token: 0x06017119 RID: 94489 RVA: 0x003534B4 File Offset: 0x003516B4
		public INightmareSettlementSystemVar? SystemVars(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new INightmareSettlementSystemVar?(default(INightmareSettlementSystemVar).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170070CC RID: 28876
		// (get) Token: 0x0601711A RID: 94490 RVA: 0x00353514 File Offset: 0x00351714
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

		// Token: 0x0601711B RID: 94491 RVA: 0x0035353F File Offset: 0x0035173F
		public static Offset<INightmareSettlementSystemConfig> CreateINightmareSettlementSystemConfig(FlatBufferBuilder builder, EEnableSystemType Type = EEnableSystemType.GradingSystem, VectorOffset SystemVarsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			INightmareSettlementSystemConfig.AddSystemVars(builder, SystemVarsOffset);
			INightmareSettlementSystemConfig.AddType(builder, Type);
			return INightmareSettlementSystemConfig.EndINightmareSettlementSystemConfig(builder);
		}

		// Token: 0x0601711C RID: 94492 RVA: 0x0035355C File Offset: 0x0035175C
		public static void StartINightmareSettlementSystemConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601711D RID: 94493 RVA: 0x00353565 File Offset: 0x00351765
		public static void AddType(FlatBufferBuilder builder, EEnableSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601711E RID: 94494 RVA: 0x00353570 File Offset: 0x00351770
		public static void AddSystemVars(FlatBufferBuilder builder, VectorOffset systemVarsOffset)
		{
			builder.AddOffset(1, systemVarsOffset.Value, 0);
		}

		// Token: 0x0601711F RID: 94495 RVA: 0x00353580 File Offset: 0x00351780
		public static VectorOffset CreateSystemVarsVector(FlatBufferBuilder builder, Offset<INightmareSettlementSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06017120 RID: 94496 RVA: 0x003535C0 File Offset: 0x003517C0
		public static VectorOffset CreateSystemVarsVectorBlock(FlatBufferBuilder builder, Offset<INightmareSettlementSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<INightmareSettlementSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017121 RID: 94497 RVA: 0x003535DA File Offset: 0x003517DA
		public static VectorOffset CreateSystemVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<INightmareSettlementSystemVar>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<INightmareSettlementSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017122 RID: 94498 RVA: 0x003535F8 File Offset: 0x003517F8
		public static VectorOffset CreateSystemVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<INightmareSettlementSystemVar>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017123 RID: 94499 RVA: 0x00353611 File Offset: 0x00351811
		public static void StartSystemVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017124 RID: 94500 RVA: 0x0035361C File Offset: 0x0035181C
		public static Offset<INightmareSettlementSystemConfig> EndINightmareSettlementSystemConfig(FlatBufferBuilder builder)
		{
			return new Offset<INightmareSettlementSystemConfig>(builder.EndTable());
		}

		// Token: 0x06017125 RID: 94501 RVA: 0x0035362C File Offset: 0x0035182C
		public INightmareSettlementSystemConfigT UnPack()
		{
			INightmareSettlementSystemConfigT nightmareSettlementSystemConfigT = new INightmareSettlementSystemConfigT();
			this.UnPackTo(nightmareSettlementSystemConfigT);
			return nightmareSettlementSystemConfigT;
		}

		// Token: 0x06017126 RID: 94502 RVA: 0x00353648 File Offset: 0x00351848
		public void UnPackTo(INightmareSettlementSystemConfigT _o)
		{
			_o.Type = this.Type;
			_o.SystemVars = new List<INightmareSettlementSystemVarT>();
			for (int i = 0; i < this.SystemVarsLength; i++)
			{
				_o.SystemVars.Add((this.SystemVars(i) != null) ? this.SystemVars(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06017127 RID: 94503 RVA: 0x003536B4 File Offset: 0x003518B4
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

		// Token: 0x0400B971 RID: 47473
		private Table __p;
	}
}
