using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D55 RID: 27989
	public struct IEntityDecorationConfig : IFlatbufferObject
	{
		// Token: 0x1700CD4D RID: 52557
		// (get) Token: 0x0603047E RID: 197758 RVA: 0x0068FD58 File Offset: 0x0068DF58
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603047F RID: 197759 RVA: 0x0068FD65 File Offset: 0x0068DF65
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030480 RID: 197760 RVA: 0x0068FD6C File Offset: 0x0068DF6C
		public static IEntityDecorationConfig GetRootAsIEntityDecorationConfig(ByteBuffer _bb)
		{
			return IEntityDecorationConfig.GetRootAsIEntityDecorationConfig(_bb, default(IEntityDecorationConfig));
		}

		// Token: 0x06030481 RID: 197761 RVA: 0x0068FD88 File Offset: 0x0068DF88
		public static IEntityDecorationConfig GetRootAsIEntityDecorationConfig(ByteBuffer _bb, IEntityDecorationConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030482 RID: 197762 RVA: 0x0068FDA5 File Offset: 0x0068DFA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030483 RID: 197763 RVA: 0x0068FDB4 File Offset: 0x0068DFB4
		public IEntityDecorationConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD4E RID: 52558
		// (get) Token: 0x06030484 RID: 197764 RVA: 0x0068FDC4 File Offset: 0x0068DFC4
		public EEntityDecorationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEntityDecorationType.Add;
				}
				return (EEntityDecorationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030485 RID: 197765 RVA: 0x0068FE00 File Offset: 0x0068E000
		public static Offset<IEntityDecorationConfig> CreateIEntityDecorationConfig(FlatBufferBuilder builder, EEntityDecorationType Type = EEntityDecorationType.Add)
		{
			builder.StartTable(1);
			IEntityDecorationConfig.AddType(builder, Type);
			return IEntityDecorationConfig.EndIEntityDecorationConfig(builder);
		}

		// Token: 0x06030486 RID: 197766 RVA: 0x0068FE16 File Offset: 0x0068E016
		public static void StartIEntityDecorationConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030487 RID: 197767 RVA: 0x0068FE1F File Offset: 0x0068E01F
		public static void AddType(FlatBufferBuilder builder, EEntityDecorationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030488 RID: 197768 RVA: 0x0068FE2A File Offset: 0x0068E02A
		public static Offset<IEntityDecorationConfig> EndIEntityDecorationConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEntityDecorationConfig>(builder.EndTable());
		}

		// Token: 0x06030489 RID: 197769 RVA: 0x0068FE38 File Offset: 0x0068E038
		public IEntityDecorationConfigT UnPack()
		{
			IEntityDecorationConfigT entityDecorationConfigT = new IEntityDecorationConfigT();
			this.UnPackTo(entityDecorationConfigT);
			return entityDecorationConfigT;
		}

		// Token: 0x0603048A RID: 197770 RVA: 0x0068FE53 File Offset: 0x0068E053
		public void UnPackTo(IEntityDecorationConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603048B RID: 197771 RVA: 0x0068FE64 File Offset: 0x0068E064
		public static Offset<IEntityDecorationConfig> Pack(FlatBufferBuilder builder, IEntityDecorationConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityDecorationConfig>);
			}
			return IEntityDecorationConfig.CreateIEntityDecorationConfig(builder, _o.Type);
		}

		// Token: 0x04011BCB RID: 72651
		private Table __p;
	}
}
