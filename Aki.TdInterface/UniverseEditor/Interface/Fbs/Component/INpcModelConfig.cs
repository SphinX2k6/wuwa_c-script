using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005629 RID: 22057
	public struct INpcModelConfig : IFlatbufferObject
	{
		// Token: 0x1700A341 RID: 41793
		// (get) Token: 0x060249F9 RID: 150009 RVA: 0x0050D7FC File Offset: 0x0050B9FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060249FA RID: 150010 RVA: 0x0050D809 File Offset: 0x0050BA09
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060249FB RID: 150011 RVA: 0x0050D810 File Offset: 0x0050BA10
		public static INpcModelConfig GetRootAsINpcModelConfig(ByteBuffer _bb)
		{
			return INpcModelConfig.GetRootAsINpcModelConfig(_bb, default(INpcModelConfig));
		}

		// Token: 0x060249FC RID: 150012 RVA: 0x0050D82C File Offset: 0x0050BA2C
		public static INpcModelConfig GetRootAsINpcModelConfig(ByteBuffer _bb, INpcModelConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060249FD RID: 150013 RVA: 0x0050D849 File Offset: 0x0050BA49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060249FE RID: 150014 RVA: 0x0050D858 File Offset: 0x0050BA58
		public INpcModelConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A342 RID: 41794
		// (get) Token: 0x060249FF RID: 150015 RVA: 0x0050D868 File Offset: 0x0050BA68
		public ENpcModelType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENpcModelType.Mesh;
				}
				return (ENpcModelType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024A00 RID: 150016 RVA: 0x0050D8A4 File Offset: 0x0050BAA4
		public static Offset<INpcModelConfig> CreateINpcModelConfig(FlatBufferBuilder builder, ENpcModelType Type = ENpcModelType.Mesh)
		{
			builder.StartTable(1);
			INpcModelConfig.AddType(builder, Type);
			return INpcModelConfig.EndINpcModelConfig(builder);
		}

		// Token: 0x06024A01 RID: 150017 RVA: 0x0050D8BA File Offset: 0x0050BABA
		public static void StartINpcModelConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024A02 RID: 150018 RVA: 0x0050D8C3 File Offset: 0x0050BAC3
		public static void AddType(FlatBufferBuilder builder, ENpcModelType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024A03 RID: 150019 RVA: 0x0050D8CE File Offset: 0x0050BACE
		public static Offset<INpcModelConfig> EndINpcModelConfig(FlatBufferBuilder builder)
		{
			return new Offset<INpcModelConfig>(builder.EndTable());
		}

		// Token: 0x06024A04 RID: 150020 RVA: 0x0050D8DC File Offset: 0x0050BADC
		public INpcModelConfigT UnPack()
		{
			INpcModelConfigT npcModelConfigT = new INpcModelConfigT();
			this.UnPackTo(npcModelConfigT);
			return npcModelConfigT;
		}

		// Token: 0x06024A05 RID: 150021 RVA: 0x0050D8F7 File Offset: 0x0050BAF7
		public void UnPackTo(INpcModelConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06024A06 RID: 150022 RVA: 0x0050D908 File Offset: 0x0050BB08
		public static Offset<INpcModelConfig> Pack(FlatBufferBuilder builder, INpcModelConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcModelConfig>);
			}
			return INpcModelConfig.CreateINpcModelConfig(builder, _o.Type);
		}

		// Token: 0x0400E9B5 RID: 59829
		private Table __p;
	}
}
