using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045B0 RID: 17840
	public struct ISurvivorsRougeSystemConfig : IFlatbufferObject
	{
		// Token: 0x17007CAD RID: 31917
		// (get) Token: 0x0601A056 RID: 106582 RVA: 0x003B5611 File Offset: 0x003B3811
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A057 RID: 106583 RVA: 0x003B561E File Offset: 0x003B381E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A058 RID: 106584 RVA: 0x003B5628 File Offset: 0x003B3828
		public static ISurvivorsRougeSystemConfig GetRootAsISurvivorsRougeSystemConfig(ByteBuffer _bb)
		{
			return ISurvivorsRougeSystemConfig.GetRootAsISurvivorsRougeSystemConfig(_bb, default(ISurvivorsRougeSystemConfig));
		}

		// Token: 0x0601A059 RID: 106585 RVA: 0x003B5644 File Offset: 0x003B3844
		public static ISurvivorsRougeSystemConfig GetRootAsISurvivorsRougeSystemConfig(ByteBuffer _bb, ISurvivorsRougeSystemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A05A RID: 106586 RVA: 0x003B5661 File Offset: 0x003B3861
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A05B RID: 106587 RVA: 0x003B5670 File Offset: 0x003B3870
		public ISurvivorsRougeSystemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007CAE RID: 31918
		// (get) Token: 0x0601A05C RID: 106588 RVA: 0x003B5680 File Offset: 0x003B3880
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

		// Token: 0x0601A05D RID: 106589 RVA: 0x003B56BC File Offset: 0x003B38BC
		public ISurvivorsRougeSystemVar? Vars(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISurvivorsRougeSystemVar?(default(ISurvivorsRougeSystemVar).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007CAF RID: 31919
		// (get) Token: 0x0601A05E RID: 106590 RVA: 0x003B571C File Offset: 0x003B391C
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

		// Token: 0x0601A05F RID: 106591 RVA: 0x003B5747 File Offset: 0x003B3947
		public static Offset<ISurvivorsRougeSystemConfig> CreateISurvivorsRougeSystemConfig(FlatBufferBuilder builder, EEnableSystemType Type = EEnableSystemType.GradingSystem, VectorOffset VarsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISurvivorsRougeSystemConfig.AddVars(builder, VarsOffset);
			ISurvivorsRougeSystemConfig.AddType(builder, Type);
			return ISurvivorsRougeSystemConfig.EndISurvivorsRougeSystemConfig(builder);
		}

		// Token: 0x0601A060 RID: 106592 RVA: 0x003B5764 File Offset: 0x003B3964
		public static void StartISurvivorsRougeSystemConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601A061 RID: 106593 RVA: 0x003B576D File Offset: 0x003B396D
		public static void AddType(FlatBufferBuilder builder, EEnableSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A062 RID: 106594 RVA: 0x003B5778 File Offset: 0x003B3978
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(1, varsOffset.Value, 0);
		}

		// Token: 0x0601A063 RID: 106595 RVA: 0x003B5788 File Offset: 0x003B3988
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, Offset<ISurvivorsRougeSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A064 RID: 106596 RVA: 0x003B57C8 File Offset: 0x003B39C8
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, Offset<ISurvivorsRougeSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISurvivorsRougeSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A065 RID: 106597 RVA: 0x003B57E2 File Offset: 0x003B39E2
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISurvivorsRougeSystemVar>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISurvivorsRougeSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A066 RID: 106598 RVA: 0x003B5800 File Offset: 0x003B3A00
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISurvivorsRougeSystemVar>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A067 RID: 106599 RVA: 0x003B5819 File Offset: 0x003B3A19
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A068 RID: 106600 RVA: 0x003B5824 File Offset: 0x003B3A24
		public static Offset<ISurvivorsRougeSystemConfig> EndISurvivorsRougeSystemConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISurvivorsRougeSystemConfig>(builder.EndTable());
		}

		// Token: 0x0601A069 RID: 106601 RVA: 0x003B5834 File Offset: 0x003B3A34
		public ISurvivorsRougeSystemConfigT UnPack()
		{
			ISurvivorsRougeSystemConfigT survivorsRougeSystemConfigT = new ISurvivorsRougeSystemConfigT();
			this.UnPackTo(survivorsRougeSystemConfigT);
			return survivorsRougeSystemConfigT;
		}

		// Token: 0x0601A06A RID: 106602 RVA: 0x003B5850 File Offset: 0x003B3A50
		public void UnPackTo(ISurvivorsRougeSystemConfigT _o)
		{
			_o.Type = this.Type;
			_o.Vars = new List<ISurvivorsRougeSystemVarT>();
			for (int i = 0; i < this.VarsLength; i++)
			{
				_o.Vars.Add((this.Vars(i) != null) ? this.Vars(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601A06B RID: 106603 RVA: 0x003B58BC File Offset: 0x003B3ABC
		public static Offset<ISurvivorsRougeSystemConfig> Pack(FlatBufferBuilder builder, ISurvivorsRougeSystemConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISurvivorsRougeSystemConfig>);
			}
			VectorOffset varsOffset = default(VectorOffset);
			if (_o.Vars != null)
			{
				Offset<ISurvivorsRougeSystemVar>[] array = new Offset<ISurvivorsRougeSystemVar>[_o.Vars.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISurvivorsRougeSystemVar.Pack(builder, _o.Vars[i]);
				}
				varsOffset = ISurvivorsRougeSystemConfig.CreateVarsVector(builder, array);
			}
			return ISurvivorsRougeSystemConfig.CreateISurvivorsRougeSystemConfig(builder, _o.Type, varsOffset);
		}

		// Token: 0x0400C775 RID: 51061
		private Table __p;
	}
}
