using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E59 RID: 20057
	public struct IAddBuffMode : IFlatbufferObject
	{
		// Token: 0x17008F8D RID: 36749
		// (get) Token: 0x0601F7CE RID: 128974 RVA: 0x00462E3E File Offset: 0x0046103E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F7CF RID: 128975 RVA: 0x00462E4B File Offset: 0x0046104B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F7D0 RID: 128976 RVA: 0x00462E54 File Offset: 0x00461054
		public static IAddBuffMode GetRootAsIAddBuffMode(ByteBuffer _bb)
		{
			return IAddBuffMode.GetRootAsIAddBuffMode(_bb, default(IAddBuffMode));
		}

		// Token: 0x0601F7D1 RID: 128977 RVA: 0x00462E70 File Offset: 0x00461070
		public static IAddBuffMode GetRootAsIAddBuffMode(ByteBuffer _bb, IAddBuffMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F7D2 RID: 128978 RVA: 0x00462E8D File Offset: 0x0046108D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F7D3 RID: 128979 RVA: 0x00462E9C File Offset: 0x0046109C
		public IAddBuffMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F8E RID: 36750
		// (get) Token: 0x0601F7D4 RID: 128980 RVA: 0x00462EAC File Offset: 0x004610AC
		public EBuffProducerMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBuffProducerMode.Immediate;
				}
				return (EBuffProducerMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F7D5 RID: 128981 RVA: 0x00462EE8 File Offset: 0x004610E8
		public static Offset<IAddBuffMode> CreateIAddBuffMode(FlatBufferBuilder builder, EBuffProducerMode Type = EBuffProducerMode.Immediate)
		{
			builder.StartTable(1);
			IAddBuffMode.AddType(builder, Type);
			return IAddBuffMode.EndIAddBuffMode(builder);
		}

		// Token: 0x0601F7D6 RID: 128982 RVA: 0x00462EFE File Offset: 0x004610FE
		public static void StartIAddBuffMode(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601F7D7 RID: 128983 RVA: 0x00462F07 File Offset: 0x00461107
		public static void AddType(FlatBufferBuilder builder, EBuffProducerMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F7D8 RID: 128984 RVA: 0x00462F12 File Offset: 0x00461112
		public static Offset<IAddBuffMode> EndIAddBuffMode(FlatBufferBuilder builder)
		{
			return new Offset<IAddBuffMode>(builder.EndTable());
		}

		// Token: 0x0601F7D9 RID: 128985 RVA: 0x00462F20 File Offset: 0x00461120
		public IAddBuffModeT UnPack()
		{
			IAddBuffModeT addBuffModeT = new IAddBuffModeT();
			this.UnPackTo(addBuffModeT);
			return addBuffModeT;
		}

		// Token: 0x0601F7DA RID: 128986 RVA: 0x00462F3B File Offset: 0x0046113B
		public void UnPackTo(IAddBuffModeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601F7DB RID: 128987 RVA: 0x00462F4C File Offset: 0x0046114C
		public static Offset<IAddBuffMode> Pack(FlatBufferBuilder builder, IAddBuffModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAddBuffMode>);
			}
			return IAddBuffMode.CreateIAddBuffMode(builder, _o.Type);
		}

		// Token: 0x0400DBF7 RID: 56311
		private Table __p;
	}
}
