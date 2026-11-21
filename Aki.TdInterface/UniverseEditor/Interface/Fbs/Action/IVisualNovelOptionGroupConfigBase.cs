using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D82 RID: 32130
	public struct IVisualNovelOptionGroupConfigBase : IFlatbufferObject
	{
		// Token: 0x1700F05E RID: 61534
		// (get) Token: 0x06039FFE RID: 237566 RVA: 0x007D1BF1 File Offset: 0x007CFDF1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039FFF RID: 237567 RVA: 0x007D1BFE File Offset: 0x007CFDFE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A000 RID: 237568 RVA: 0x007D1C08 File Offset: 0x007CFE08
		public static IVisualNovelOptionGroupConfigBase GetRootAsIVisualNovelOptionGroupConfigBase(ByteBuffer _bb)
		{
			return IVisualNovelOptionGroupConfigBase.GetRootAsIVisualNovelOptionGroupConfigBase(_bb, default(IVisualNovelOptionGroupConfigBase));
		}

		// Token: 0x0603A001 RID: 237569 RVA: 0x007D1C24 File Offset: 0x007CFE24
		public static IVisualNovelOptionGroupConfigBase GetRootAsIVisualNovelOptionGroupConfigBase(ByteBuffer _bb, IVisualNovelOptionGroupConfigBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A002 RID: 237570 RVA: 0x007D1C41 File Offset: 0x007CFE41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A003 RID: 237571 RVA: 0x007D1C50 File Offset: 0x007CFE50
		public IVisualNovelOptionGroupConfigBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F05F RID: 61535
		// (get) Token: 0x0603A004 RID: 237572 RVA: 0x007D1C60 File Offset: 0x007CFE60
		public EVisualNovelOptionGroupType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelOptionGroupType.Normal;
				}
				return (EVisualNovelOptionGroupType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603A005 RID: 237573 RVA: 0x007D1C9C File Offset: 0x007CFE9C
		public static Offset<IVisualNovelOptionGroupConfigBase> CreateIVisualNovelOptionGroupConfigBase(FlatBufferBuilder builder, EVisualNovelOptionGroupType Type = EVisualNovelOptionGroupType.Normal)
		{
			builder.StartTable(1);
			IVisualNovelOptionGroupConfigBase.AddType(builder, Type);
			return IVisualNovelOptionGroupConfigBase.EndIVisualNovelOptionGroupConfigBase(builder);
		}

		// Token: 0x0603A006 RID: 237574 RVA: 0x007D1CB2 File Offset: 0x007CFEB2
		public static void StartIVisualNovelOptionGroupConfigBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603A007 RID: 237575 RVA: 0x007D1CBB File Offset: 0x007CFEBB
		public static void AddType(FlatBufferBuilder builder, EVisualNovelOptionGroupType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A008 RID: 237576 RVA: 0x007D1CC6 File Offset: 0x007CFEC6
		public static Offset<IVisualNovelOptionGroupConfigBase> EndIVisualNovelOptionGroupConfigBase(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelOptionGroupConfigBase>(builder.EndTable());
		}

		// Token: 0x0603A009 RID: 237577 RVA: 0x007D1CD4 File Offset: 0x007CFED4
		public IVisualNovelOptionGroupConfigBaseT UnPack()
		{
			IVisualNovelOptionGroupConfigBaseT visualNovelOptionGroupConfigBaseT = new IVisualNovelOptionGroupConfigBaseT();
			this.UnPackTo(visualNovelOptionGroupConfigBaseT);
			return visualNovelOptionGroupConfigBaseT;
		}

		// Token: 0x0603A00A RID: 237578 RVA: 0x007D1CEF File Offset: 0x007CFEEF
		public void UnPackTo(IVisualNovelOptionGroupConfigBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603A00B RID: 237579 RVA: 0x007D1D00 File Offset: 0x007CFF00
		public static Offset<IVisualNovelOptionGroupConfigBase> Pack(FlatBufferBuilder builder, IVisualNovelOptionGroupConfigBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelOptionGroupConfigBase>);
			}
			return IVisualNovelOptionGroupConfigBase.CreateIVisualNovelOptionGroupConfigBase(builder, _o.Type);
		}

		// Token: 0x040134C6 RID: 79046
		private Table __p;
	}
}
