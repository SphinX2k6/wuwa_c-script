using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006948 RID: 26952
	public struct IInfrActivityBuildStageOption : IFlatbufferObject
	{
		// Token: 0x1700C7F4 RID: 51188
		// (get) Token: 0x0602F0F8 RID: 192760 RVA: 0x0066A166 File Offset: 0x00668366
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F0F9 RID: 192761 RVA: 0x0066A173 File Offset: 0x00668373
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F0FA RID: 192762 RVA: 0x0066A17C File Offset: 0x0066837C
		public static IInfrActivityBuildStageOption GetRootAsIInfrActivityBuildStageOption(ByteBuffer _bb)
		{
			return IInfrActivityBuildStageOption.GetRootAsIInfrActivityBuildStageOption(_bb, default(IInfrActivityBuildStageOption));
		}

		// Token: 0x0602F0FB RID: 192763 RVA: 0x0066A198 File Offset: 0x00668398
		public static IInfrActivityBuildStageOption GetRootAsIInfrActivityBuildStageOption(ByteBuffer _bb, IInfrActivityBuildStageOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F0FC RID: 192764 RVA: 0x0066A1B5 File Offset: 0x006683B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F0FD RID: 192765 RVA: 0x0066A1C4 File Offset: 0x006683C4
		public IInfrActivityBuildStageOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C7F5 RID: 51189
		// (get) Token: 0x0602F0FE RID: 192766 RVA: 0x0066A1D4 File Offset: 0x006683D4
		public EInfrActivityBuildStageType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInfrActivityBuildStageType.Infrastructure;
				}
				return (EInfrActivityBuildStageType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F0FF RID: 192767 RVA: 0x0066A210 File Offset: 0x00668410
		public static Offset<IInfrActivityBuildStageOption> CreateIInfrActivityBuildStageOption(FlatBufferBuilder builder, EInfrActivityBuildStageType Type = EInfrActivityBuildStageType.Infrastructure)
		{
			builder.StartTable(1);
			IInfrActivityBuildStageOption.AddType(builder, Type);
			return IInfrActivityBuildStageOption.EndIInfrActivityBuildStageOption(builder);
		}

		// Token: 0x0602F100 RID: 192768 RVA: 0x0066A226 File Offset: 0x00668426
		public static void StartIInfrActivityBuildStageOption(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F101 RID: 192769 RVA: 0x0066A22F File Offset: 0x0066842F
		public static void AddType(FlatBufferBuilder builder, EInfrActivityBuildStageType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F102 RID: 192770 RVA: 0x0066A23A File Offset: 0x0066843A
		public static Offset<IInfrActivityBuildStageOption> EndIInfrActivityBuildStageOption(FlatBufferBuilder builder)
		{
			return new Offset<IInfrActivityBuildStageOption>(builder.EndTable());
		}

		// Token: 0x0602F103 RID: 192771 RVA: 0x0066A248 File Offset: 0x00668448
		public IInfrActivityBuildStageOptionT UnPack()
		{
			IInfrActivityBuildStageOptionT infrActivityBuildStageOptionT = new IInfrActivityBuildStageOptionT();
			this.UnPackTo(infrActivityBuildStageOptionT);
			return infrActivityBuildStageOptionT;
		}

		// Token: 0x0602F104 RID: 192772 RVA: 0x0066A263 File Offset: 0x00668463
		public void UnPackTo(IInfrActivityBuildStageOptionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F105 RID: 192773 RVA: 0x0066A274 File Offset: 0x00668474
		public static Offset<IInfrActivityBuildStageOption> Pack(FlatBufferBuilder builder, IInfrActivityBuildStageOptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInfrActivityBuildStageOption>);
			}
			return IInfrActivityBuildStageOption.CreateIInfrActivityBuildStageOption(builder, _o.Type);
		}

		// Token: 0x040110C6 RID: 69830
		private Table __p;
	}
}
