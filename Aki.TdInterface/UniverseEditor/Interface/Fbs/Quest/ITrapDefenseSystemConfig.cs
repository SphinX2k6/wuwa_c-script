using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004694 RID: 18068
	public struct ITrapDefenseSystemConfig : IFlatbufferObject
	{
		// Token: 0x17007E8C RID: 32396
		// (get) Token: 0x0601A86A RID: 108650 RVA: 0x003C6381 File Offset: 0x003C4581
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A86B RID: 108651 RVA: 0x003C638E File Offset: 0x003C458E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A86C RID: 108652 RVA: 0x003C6398 File Offset: 0x003C4598
		public static ITrapDefenseSystemConfig GetRootAsITrapDefenseSystemConfig(ByteBuffer _bb)
		{
			return ITrapDefenseSystemConfig.GetRootAsITrapDefenseSystemConfig(_bb, default(ITrapDefenseSystemConfig));
		}

		// Token: 0x0601A86D RID: 108653 RVA: 0x003C63B4 File Offset: 0x003C45B4
		public static ITrapDefenseSystemConfig GetRootAsITrapDefenseSystemConfig(ByteBuffer _bb, ITrapDefenseSystemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A86E RID: 108654 RVA: 0x003C63D1 File Offset: 0x003C45D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A86F RID: 108655 RVA: 0x003C63E0 File Offset: 0x003C45E0
		public ITrapDefenseSystemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E8D RID: 32397
		// (get) Token: 0x0601A870 RID: 108656 RVA: 0x003C63F0 File Offset: 0x003C45F0
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

		// Token: 0x17007E8E RID: 32398
		// (get) Token: 0x0601A871 RID: 108657 RVA: 0x003C642C File Offset: 0x003C462C
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

		// Token: 0x0601A872 RID: 108658 RVA: 0x003C6468 File Offset: 0x003C4668
		public ITrapDefenseSystemVar? Vars(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new ITrapDefenseSystemVar?(default(ITrapDefenseSystemVar).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007E8F RID: 32399
		// (get) Token: 0x0601A873 RID: 108659 RVA: 0x003C64C8 File Offset: 0x003C46C8
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

		// Token: 0x0601A874 RID: 108660 RVA: 0x003C64F3 File Offset: 0x003C46F3
		public static Offset<ITrapDefenseSystemConfig> CreateITrapDefenseSystemConfig(FlatBufferBuilder builder, EEnableSystemType Type = EEnableSystemType.GradingSystem, int TrapDefenseId = 0, VectorOffset VarsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ITrapDefenseSystemConfig.AddVars(builder, VarsOffset);
			ITrapDefenseSystemConfig.AddTrapDefenseId(builder, TrapDefenseId);
			ITrapDefenseSystemConfig.AddType(builder, Type);
			return ITrapDefenseSystemConfig.EndITrapDefenseSystemConfig(builder);
		}

		// Token: 0x0601A875 RID: 108661 RVA: 0x003C6517 File Offset: 0x003C4717
		public static void StartITrapDefenseSystemConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601A876 RID: 108662 RVA: 0x003C6520 File Offset: 0x003C4720
		public static void AddType(FlatBufferBuilder builder, EEnableSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A877 RID: 108663 RVA: 0x003C652B File Offset: 0x003C472B
		public static void AddTrapDefenseId(FlatBufferBuilder builder, int trapDefenseId)
		{
			builder.AddInt(1, trapDefenseId, 0);
		}

		// Token: 0x0601A878 RID: 108664 RVA: 0x003C6536 File Offset: 0x003C4736
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(2, varsOffset.Value, 0);
		}

		// Token: 0x0601A879 RID: 108665 RVA: 0x003C6548 File Offset: 0x003C4748
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, Offset<ITrapDefenseSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A87A RID: 108666 RVA: 0x003C6588 File Offset: 0x003C4788
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, Offset<ITrapDefenseSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITrapDefenseSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A87B RID: 108667 RVA: 0x003C65A2 File Offset: 0x003C47A2
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITrapDefenseSystemVar>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITrapDefenseSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A87C RID: 108668 RVA: 0x003C65C0 File Offset: 0x003C47C0
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITrapDefenseSystemVar>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A87D RID: 108669 RVA: 0x003C65D9 File Offset: 0x003C47D9
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A87E RID: 108670 RVA: 0x003C65E4 File Offset: 0x003C47E4
		public static Offset<ITrapDefenseSystemConfig> EndITrapDefenseSystemConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseSystemConfig>(builder.EndTable());
		}

		// Token: 0x0601A87F RID: 108671 RVA: 0x003C65F4 File Offset: 0x003C47F4
		public ITrapDefenseSystemConfigT UnPack()
		{
			ITrapDefenseSystemConfigT trapDefenseSystemConfigT = new ITrapDefenseSystemConfigT();
			this.UnPackTo(trapDefenseSystemConfigT);
			return trapDefenseSystemConfigT;
		}

		// Token: 0x0601A880 RID: 108672 RVA: 0x003C6610 File Offset: 0x003C4810
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

		// Token: 0x0601A881 RID: 108673 RVA: 0x003C6688 File Offset: 0x003C4888
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

		// Token: 0x0400C8C7 RID: 51399
		private Table __p;
	}
}
