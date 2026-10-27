using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E57 RID: 15959
	public struct IFlagChallengeSystemConfig : IFlatbufferObject
	{
		// Token: 0x17006EAB RID: 28331
		// (get) Token: 0x06016761 RID: 92001 RVA: 0x0033F57D File Offset: 0x0033D77D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016762 RID: 92002 RVA: 0x0033F58A File Offset: 0x0033D78A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016763 RID: 92003 RVA: 0x0033F594 File Offset: 0x0033D794
		public static IFlagChallengeSystemConfig GetRootAsIFlagChallengeSystemConfig(ByteBuffer _bb)
		{
			return IFlagChallengeSystemConfig.GetRootAsIFlagChallengeSystemConfig(_bb, default(IFlagChallengeSystemConfig));
		}

		// Token: 0x06016764 RID: 92004 RVA: 0x0033F5B0 File Offset: 0x0033D7B0
		public static IFlagChallengeSystemConfig GetRootAsIFlagChallengeSystemConfig(ByteBuffer _bb, IFlagChallengeSystemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016765 RID: 92005 RVA: 0x0033F5CD File Offset: 0x0033D7CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016766 RID: 92006 RVA: 0x0033F5DC File Offset: 0x0033D7DC
		public IFlagChallengeSystemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006EAC RID: 28332
		// (get) Token: 0x06016767 RID: 92007 RVA: 0x0033F5EC File Offset: 0x0033D7EC
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

		// Token: 0x06016768 RID: 92008 RVA: 0x0033F628 File Offset: 0x0033D828
		public IFlagChallengeSystemVar? Vars(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IFlagChallengeSystemVar?(default(IFlagChallengeSystemVar).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006EAD RID: 28333
		// (get) Token: 0x06016769 RID: 92009 RVA: 0x0033F688 File Offset: 0x0033D888
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

		// Token: 0x0601676A RID: 92010 RVA: 0x0033F6B3 File Offset: 0x0033D8B3
		public static Offset<IFlagChallengeSystemConfig> CreateIFlagChallengeSystemConfig(FlatBufferBuilder builder, EEnableSystemType Type = EEnableSystemType.GradingSystem, VectorOffset VarsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IFlagChallengeSystemConfig.AddVars(builder, VarsOffset);
			IFlagChallengeSystemConfig.AddType(builder, Type);
			return IFlagChallengeSystemConfig.EndIFlagChallengeSystemConfig(builder);
		}

		// Token: 0x0601676B RID: 92011 RVA: 0x0033F6D0 File Offset: 0x0033D8D0
		public static void StartIFlagChallengeSystemConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601676C RID: 92012 RVA: 0x0033F6D9 File Offset: 0x0033D8D9
		public static void AddType(FlatBufferBuilder builder, EEnableSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601676D RID: 92013 RVA: 0x0033F6E4 File Offset: 0x0033D8E4
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(1, varsOffset.Value, 0);
		}

		// Token: 0x0601676E RID: 92014 RVA: 0x0033F6F4 File Offset: 0x0033D8F4
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, Offset<IFlagChallengeSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601676F RID: 92015 RVA: 0x0033F734 File Offset: 0x0033D934
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, Offset<IFlagChallengeSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFlagChallengeSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016770 RID: 92016 RVA: 0x0033F74E File Offset: 0x0033D94E
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFlagChallengeSystemVar>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFlagChallengeSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016771 RID: 92017 RVA: 0x0033F76C File Offset: 0x0033D96C
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFlagChallengeSystemVar>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016772 RID: 92018 RVA: 0x0033F785 File Offset: 0x0033D985
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016773 RID: 92019 RVA: 0x0033F790 File Offset: 0x0033D990
		public static Offset<IFlagChallengeSystemConfig> EndIFlagChallengeSystemConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFlagChallengeSystemConfig>(builder.EndTable());
		}

		// Token: 0x06016774 RID: 92020 RVA: 0x0033F7A0 File Offset: 0x0033D9A0
		public IFlagChallengeSystemConfigT UnPack()
		{
			IFlagChallengeSystemConfigT flagChallengeSystemConfigT = new IFlagChallengeSystemConfigT();
			this.UnPackTo(flagChallengeSystemConfigT);
			return flagChallengeSystemConfigT;
		}

		// Token: 0x06016775 RID: 92021 RVA: 0x0033F7BC File Offset: 0x0033D9BC
		public void UnPackTo(IFlagChallengeSystemConfigT _o)
		{
			_o.Type = this.Type;
			_o.Vars = new List<IFlagChallengeSystemVarT>();
			for (int i = 0; i < this.VarsLength; i++)
			{
				_o.Vars.Add((this.Vars(i) != null) ? this.Vars(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06016776 RID: 92022 RVA: 0x0033F828 File Offset: 0x0033DA28
		public static Offset<IFlagChallengeSystemConfig> Pack(FlatBufferBuilder builder, IFlagChallengeSystemConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlagChallengeSystemConfig>);
			}
			VectorOffset varsOffset = default(VectorOffset);
			if (_o.Vars != null)
			{
				Offset<IFlagChallengeSystemVar>[] array = new Offset<IFlagChallengeSystemVar>[_o.Vars.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IFlagChallengeSystemVar.Pack(builder, _o.Vars[i]);
				}
				varsOffset = IFlagChallengeSystemConfig.CreateVarsVector(builder, array);
			}
			return IFlagChallengeSystemConfig.CreateIFlagChallengeSystemConfig(builder, _o.Type, varsOffset);
		}

		// Token: 0x0400B807 RID: 47111
		private Table __p;
	}
}
