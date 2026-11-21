using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044F6 RID: 17654
	public struct IRogueTowerTrialSystemConfig : IFlatbufferObject
	{
		// Token: 0x17007AED RID: 31469
		// (get) Token: 0x060198B2 RID: 104626 RVA: 0x003A45C5 File Offset: 0x003A27C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060198B3 RID: 104627 RVA: 0x003A45D2 File Offset: 0x003A27D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060198B4 RID: 104628 RVA: 0x003A45DC File Offset: 0x003A27DC
		public static IRogueTowerTrialSystemConfig GetRootAsIRogueTowerTrialSystemConfig(ByteBuffer _bb)
		{
			return IRogueTowerTrialSystemConfig.GetRootAsIRogueTowerTrialSystemConfig(_bb, default(IRogueTowerTrialSystemConfig));
		}

		// Token: 0x060198B5 RID: 104629 RVA: 0x003A45F8 File Offset: 0x003A27F8
		public static IRogueTowerTrialSystemConfig GetRootAsIRogueTowerTrialSystemConfig(ByteBuffer _bb, IRogueTowerTrialSystemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060198B6 RID: 104630 RVA: 0x003A4615 File Offset: 0x003A2815
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060198B7 RID: 104631 RVA: 0x003A4624 File Offset: 0x003A2824
		public IRogueTowerTrialSystemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007AEE RID: 31470
		// (get) Token: 0x060198B8 RID: 104632 RVA: 0x003A4634 File Offset: 0x003A2834
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

		// Token: 0x060198B9 RID: 104633 RVA: 0x003A4670 File Offset: 0x003A2870
		public IRogueTowerTrialSystemVar? Vars(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IRogueTowerTrialSystemVar?(default(IRogueTowerTrialSystemVar).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007AEF RID: 31471
		// (get) Token: 0x060198BA RID: 104634 RVA: 0x003A46D0 File Offset: 0x003A28D0
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

		// Token: 0x060198BB RID: 104635 RVA: 0x003A46FB File Offset: 0x003A28FB
		public static Offset<IRogueTowerTrialSystemConfig> CreateIRogueTowerTrialSystemConfig(FlatBufferBuilder builder, EEnableSystemType Type = EEnableSystemType.GradingSystem, VectorOffset VarsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IRogueTowerTrialSystemConfig.AddVars(builder, VarsOffset);
			IRogueTowerTrialSystemConfig.AddType(builder, Type);
			return IRogueTowerTrialSystemConfig.EndIRogueTowerTrialSystemConfig(builder);
		}

		// Token: 0x060198BC RID: 104636 RVA: 0x003A4718 File Offset: 0x003A2918
		public static void StartIRogueTowerTrialSystemConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060198BD RID: 104637 RVA: 0x003A4721 File Offset: 0x003A2921
		public static void AddType(FlatBufferBuilder builder, EEnableSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060198BE RID: 104638 RVA: 0x003A472C File Offset: 0x003A292C
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(1, varsOffset.Value, 0);
		}

		// Token: 0x060198BF RID: 104639 RVA: 0x003A473C File Offset: 0x003A293C
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, Offset<IRogueTowerTrialSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060198C0 RID: 104640 RVA: 0x003A477C File Offset: 0x003A297C
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, Offset<IRogueTowerTrialSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IRogueTowerTrialSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x060198C1 RID: 104641 RVA: 0x003A4796 File Offset: 0x003A2996
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IRogueTowerTrialSystemVar>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IRogueTowerTrialSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x060198C2 RID: 104642 RVA: 0x003A47B4 File Offset: 0x003A29B4
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IRogueTowerTrialSystemVar>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060198C3 RID: 104643 RVA: 0x003A47CD File Offset: 0x003A29CD
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060198C4 RID: 104644 RVA: 0x003A47D8 File Offset: 0x003A29D8
		public static Offset<IRogueTowerTrialSystemConfig> EndIRogueTowerTrialSystemConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRogueTowerTrialSystemConfig>(builder.EndTable());
		}

		// Token: 0x060198C5 RID: 104645 RVA: 0x003A47E8 File Offset: 0x003A29E8
		public IRogueTowerTrialSystemConfigT UnPack()
		{
			IRogueTowerTrialSystemConfigT rogueTowerTrialSystemConfigT = new IRogueTowerTrialSystemConfigT();
			this.UnPackTo(rogueTowerTrialSystemConfigT);
			return rogueTowerTrialSystemConfigT;
		}

		// Token: 0x060198C6 RID: 104646 RVA: 0x003A4804 File Offset: 0x003A2A04
		public void UnPackTo(IRogueTowerTrialSystemConfigT _o)
		{
			_o.Type = this.Type;
			_o.Vars = new List<IRogueTowerTrialSystemVarT>();
			for (int i = 0; i < this.VarsLength; i++)
			{
				_o.Vars.Add((this.Vars(i) != null) ? this.Vars(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060198C7 RID: 104647 RVA: 0x003A4870 File Offset: 0x003A2A70
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

		// Token: 0x0400C635 RID: 50741
		private Table __p;
	}
}
