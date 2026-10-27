using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004238 RID: 16952
	public struct ITrapDefenseSystemConfig : IFlatbufferObject
	{
		// Token: 0x1700785B RID: 30811
		// (get) Token: 0x060190FE RID: 102654 RVA: 0x0039ACA9 File Offset: 0x00398EA9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060190FF RID: 102655 RVA: 0x0039ACB6 File Offset: 0x00398EB6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019100 RID: 102656 RVA: 0x0039ACC0 File Offset: 0x00398EC0
		public static ITrapDefenseSystemConfig GetRootAsITrapDefenseSystemConfig(ByteBuffer _bb)
		{
			return ITrapDefenseSystemConfig.GetRootAsITrapDefenseSystemConfig(_bb, default(ITrapDefenseSystemConfig));
		}

		// Token: 0x06019101 RID: 102657 RVA: 0x0039ACDC File Offset: 0x00398EDC
		public static ITrapDefenseSystemConfig GetRootAsITrapDefenseSystemConfig(ByteBuffer _bb, ITrapDefenseSystemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019102 RID: 102658 RVA: 0x0039ACF9 File Offset: 0x00398EF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019103 RID: 102659 RVA: 0x0039AD08 File Offset: 0x00398F08
		public ITrapDefenseSystemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700785C RID: 30812
		// (get) Token: 0x06019104 RID: 102660 RVA: 0x0039AD18 File Offset: 0x00398F18
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

		// Token: 0x1700785D RID: 30813
		// (get) Token: 0x06019105 RID: 102661 RVA: 0x0039AD54 File Offset: 0x00398F54
		public int TrapDefenseId
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

		// Token: 0x06019106 RID: 102662 RVA: 0x0039AD90 File Offset: 0x00398F90
		public ITrapDefenseSystemVar? Vars(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new ITrapDefenseSystemVar?(default(ITrapDefenseSystemVar).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700785E RID: 30814
		// (get) Token: 0x06019107 RID: 102663 RVA: 0x0039ADF0 File Offset: 0x00398FF0
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

		// Token: 0x06019108 RID: 102664 RVA: 0x0039AE1B File Offset: 0x0039901B
		public static Offset<ITrapDefenseSystemConfig> CreateITrapDefenseSystemConfig(FlatBufferBuilder builder, EEnableSystemType Type = EEnableSystemType.GradingSystem, int TrapDefenseId = 0, VectorOffset VarsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ITrapDefenseSystemConfig.AddVars(builder, VarsOffset);
			ITrapDefenseSystemConfig.AddTrapDefenseId(builder, TrapDefenseId);
			ITrapDefenseSystemConfig.AddType(builder, Type);
			return ITrapDefenseSystemConfig.EndITrapDefenseSystemConfig(builder);
		}

		// Token: 0x06019109 RID: 102665 RVA: 0x0039AE3F File Offset: 0x0039903F
		public static void StartITrapDefenseSystemConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601910A RID: 102666 RVA: 0x0039AE48 File Offset: 0x00399048
		public static void AddType(FlatBufferBuilder builder, EEnableSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601910B RID: 102667 RVA: 0x0039AE53 File Offset: 0x00399053
		public static void AddTrapDefenseId(FlatBufferBuilder builder, int trapDefenseId)
		{
			builder.AddInt(1, trapDefenseId, 0);
		}

		// Token: 0x0601910C RID: 102668 RVA: 0x0039AE5E File Offset: 0x0039905E
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(2, varsOffset.Value, 0);
		}

		// Token: 0x0601910D RID: 102669 RVA: 0x0039AE70 File Offset: 0x00399070
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, Offset<ITrapDefenseSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601910E RID: 102670 RVA: 0x0039AEB0 File Offset: 0x003990B0
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, Offset<ITrapDefenseSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITrapDefenseSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601910F RID: 102671 RVA: 0x0039AECA File Offset: 0x003990CA
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITrapDefenseSystemVar>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITrapDefenseSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019110 RID: 102672 RVA: 0x0039AEE8 File Offset: 0x003990E8
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITrapDefenseSystemVar>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019111 RID: 102673 RVA: 0x0039AF01 File Offset: 0x00399101
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019112 RID: 102674 RVA: 0x0039AF0C File Offset: 0x0039910C
		public static Offset<ITrapDefenseSystemConfig> EndITrapDefenseSystemConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseSystemConfig>(builder.EndTable());
		}

		// Token: 0x06019113 RID: 102675 RVA: 0x0039AF1C File Offset: 0x0039911C
		public ITrapDefenseSystemConfigT UnPack()
		{
			ITrapDefenseSystemConfigT trapDefenseSystemConfigT = new ITrapDefenseSystemConfigT();
			this.UnPackTo(trapDefenseSystemConfigT);
			return trapDefenseSystemConfigT;
		}

		// Token: 0x06019114 RID: 102676 RVA: 0x0039AF38 File Offset: 0x00399138
		public void UnPackTo(ITrapDefenseSystemConfigT _o)
		{
			_o.Type = this.Type;
			_o.TrapDefenseId = this.TrapDefenseId;
			_o.Vars = new List<ITrapDefenseSystemVarT>();
			for (int i = 0; i < this.VarsLength; i++)
			{
				_o.Vars.Add((this.Vars(i) != null) ? this.Vars(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06019115 RID: 102677 RVA: 0x0039AFB0 File Offset: 0x003991B0
		public static Offset<ITrapDefenseSystemConfig> Pack(FlatBufferBuilder builder, ITrapDefenseSystemConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseSystemConfig>);
			}
			VectorOffset varsOffset = default(VectorOffset);
			if (_o.Vars != null)
			{
				Offset<ITrapDefenseSystemVar>[] array = new Offset<ITrapDefenseSystemVar>[_o.Vars.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ITrapDefenseSystemVar.Pack(builder, _o.Vars[i]);
				}
				varsOffset = ITrapDefenseSystemConfig.CreateVarsVector(builder, array);
			}
			return ITrapDefenseSystemConfig.CreateITrapDefenseSystemConfig(builder, _o.Type, _o.TrapDefenseId, varsOffset);
		}

		// Token: 0x0400BEBA RID: 48826
		private Table __p;
	}
}
