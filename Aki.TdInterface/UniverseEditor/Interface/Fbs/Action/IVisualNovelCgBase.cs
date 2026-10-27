using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007565 RID: 30053
	public struct IVisualNovelCgBase : IFlatbufferObject
	{
		// Token: 0x1700E3F3 RID: 58355
		// (get) Token: 0x06036AC2 RID: 223938 RVA: 0x0076CC4A File Offset: 0x0076AE4A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036AC3 RID: 223939 RVA: 0x0076CC57 File Offset: 0x0076AE57
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036AC4 RID: 223940 RVA: 0x0076CC60 File Offset: 0x0076AE60
		public static IVisualNovelCgBase GetRootAsIVisualNovelCgBase(ByteBuffer _bb)
		{
			return IVisualNovelCgBase.GetRootAsIVisualNovelCgBase(_bb, default(IVisualNovelCgBase));
		}

		// Token: 0x06036AC5 RID: 223941 RVA: 0x0076CC7C File Offset: 0x0076AE7C
		public static IVisualNovelCgBase GetRootAsIVisualNovelCgBase(ByteBuffer _bb, IVisualNovelCgBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036AC6 RID: 223942 RVA: 0x0076CC99 File Offset: 0x0076AE99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036AC7 RID: 223943 RVA: 0x0076CCA8 File Offset: 0x0076AEA8
		public IVisualNovelCgBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E3F4 RID: 58356
		// (get) Token: 0x06036AC8 RID: 223944 RVA: 0x0076CCB8 File Offset: 0x0076AEB8
		public EVisualNovelCgType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelCgType.LoadSpine;
				}
				return (EVisualNovelCgType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036AC9 RID: 223945 RVA: 0x0076CCF4 File Offset: 0x0076AEF4
		public static Offset<IVisualNovelCgBase> CreateIVisualNovelCgBase(FlatBufferBuilder builder, EVisualNovelCgType Type = EVisualNovelCgType.LoadSpine)
		{
			builder.StartTable(1);
			IVisualNovelCgBase.AddType(builder, Type);
			return IVisualNovelCgBase.EndIVisualNovelCgBase(builder);
		}

		// Token: 0x06036ACA RID: 223946 RVA: 0x0076CD0A File Offset: 0x0076AF0A
		public static void StartIVisualNovelCgBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036ACB RID: 223947 RVA: 0x0076CD13 File Offset: 0x0076AF13
		public static void AddType(FlatBufferBuilder builder, EVisualNovelCgType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036ACC RID: 223948 RVA: 0x0076CD1E File Offset: 0x0076AF1E
		public static Offset<IVisualNovelCgBase> EndIVisualNovelCgBase(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelCgBase>(builder.EndTable());
		}

		// Token: 0x06036ACD RID: 223949 RVA: 0x0076CD2C File Offset: 0x0076AF2C
		public IVisualNovelCgBaseT UnPack()
		{
			IVisualNovelCgBaseT visualNovelCgBaseT = new IVisualNovelCgBaseT();
			this.UnPackTo(visualNovelCgBaseT);
			return visualNovelCgBaseT;
		}

		// Token: 0x06036ACE RID: 223950 RVA: 0x0076CD47 File Offset: 0x0076AF47
		public void UnPackTo(IVisualNovelCgBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036ACF RID: 223951 RVA: 0x0076CD58 File Offset: 0x0076AF58
		public static Offset<IVisualNovelCgBase> Pack(FlatBufferBuilder builder, IVisualNovelCgBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelCgBase>);
			}
			return IVisualNovelCgBase.CreateIVisualNovelCgBase(builder, _o.Type);
		}

		// Token: 0x04012461 RID: 74849
		private Table __p;
	}
}
