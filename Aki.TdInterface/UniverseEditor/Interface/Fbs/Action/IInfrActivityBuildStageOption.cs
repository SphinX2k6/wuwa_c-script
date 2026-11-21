using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FFB RID: 28667
	public struct IInfrActivityBuildStageOption : IFlatbufferObject
	{
		// Token: 0x1700D1F7 RID: 53751
		// (get) Token: 0x06031AC8 RID: 203464 RVA: 0x006BA64E File Offset: 0x006B884E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031AC9 RID: 203465 RVA: 0x006BA65B File Offset: 0x006B885B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031ACA RID: 203466 RVA: 0x006BA664 File Offset: 0x006B8864
		public static IInfrActivityBuildStageOption GetRootAsIInfrActivityBuildStageOption(ByteBuffer _bb)
		{
			return IInfrActivityBuildStageOption.GetRootAsIInfrActivityBuildStageOption(_bb, default(IInfrActivityBuildStageOption));
		}

		// Token: 0x06031ACB RID: 203467 RVA: 0x006BA680 File Offset: 0x006B8880
		public static IInfrActivityBuildStageOption GetRootAsIInfrActivityBuildStageOption(ByteBuffer _bb, IInfrActivityBuildStageOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031ACC RID: 203468 RVA: 0x006BA69D File Offset: 0x006B889D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031ACD RID: 203469 RVA: 0x006BA6AC File Offset: 0x006B88AC
		public IInfrActivityBuildStageOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D1F8 RID: 53752
		// (get) Token: 0x06031ACE RID: 203470 RVA: 0x006BA6BC File Offset: 0x006B88BC
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

		// Token: 0x06031ACF RID: 203471 RVA: 0x006BA6F8 File Offset: 0x006B88F8
		public static Offset<IInfrActivityBuildStageOption> CreateIInfrActivityBuildStageOption(FlatBufferBuilder builder, EInfrActivityBuildStageType Type = EInfrActivityBuildStageType.Infrastructure)
		{
			builder.StartTable(1);
			IInfrActivityBuildStageOption.AddType(builder, Type);
			return IInfrActivityBuildStageOption.EndIInfrActivityBuildStageOption(builder);
		}

		// Token: 0x06031AD0 RID: 203472 RVA: 0x006BA70E File Offset: 0x006B890E
		public static void StartIInfrActivityBuildStageOption(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031AD1 RID: 203473 RVA: 0x006BA717 File Offset: 0x006B8917
		public static void AddType(FlatBufferBuilder builder, EInfrActivityBuildStageType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031AD2 RID: 203474 RVA: 0x006BA722 File Offset: 0x006B8922
		public static Offset<IInfrActivityBuildStageOption> EndIInfrActivityBuildStageOption(FlatBufferBuilder builder)
		{
			return new Offset<IInfrActivityBuildStageOption>(builder.EndTable());
		}

		// Token: 0x06031AD3 RID: 203475 RVA: 0x006BA730 File Offset: 0x006B8930
		public IInfrActivityBuildStageOptionT UnPack()
		{
			IInfrActivityBuildStageOptionT infrActivityBuildStageOptionT = new IInfrActivityBuildStageOptionT();
			this.UnPackTo(infrActivityBuildStageOptionT);
			return infrActivityBuildStageOptionT;
		}

		// Token: 0x06031AD4 RID: 203476 RVA: 0x006BA74B File Offset: 0x006B894B
		public void UnPackTo(IInfrActivityBuildStageOptionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031AD5 RID: 203477 RVA: 0x006BA75C File Offset: 0x006B895C
		public static Offset<IInfrActivityBuildStageOption> Pack(FlatBufferBuilder builder, IInfrActivityBuildStageOptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInfrActivityBuildStageOption>);
			}
			return IInfrActivityBuildStageOption.CreateIInfrActivityBuildStageOption(builder, _o.Type);
		}

		// Token: 0x04011F32 RID: 73522
		private Table __p;
	}
}
