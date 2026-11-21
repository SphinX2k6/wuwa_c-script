using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D70 RID: 32112
	public struct IVisualNovelDisplayItemBase : IFlatbufferObject
	{
		// Token: 0x1700F049 RID: 61513
		// (get) Token: 0x06039F8C RID: 237452 RVA: 0x007D11FE File Offset: 0x007CF3FE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039F8D RID: 237453 RVA: 0x007D120B File Offset: 0x007CF40B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039F8E RID: 237454 RVA: 0x007D1214 File Offset: 0x007CF414
		public static IVisualNovelDisplayItemBase GetRootAsIVisualNovelDisplayItemBase(ByteBuffer _bb)
		{
			return IVisualNovelDisplayItemBase.GetRootAsIVisualNovelDisplayItemBase(_bb, default(IVisualNovelDisplayItemBase));
		}

		// Token: 0x06039F8F RID: 237455 RVA: 0x007D1230 File Offset: 0x007CF430
		public static IVisualNovelDisplayItemBase GetRootAsIVisualNovelDisplayItemBase(ByteBuffer _bb, IVisualNovelDisplayItemBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039F90 RID: 237456 RVA: 0x007D124D File Offset: 0x007CF44D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039F91 RID: 237457 RVA: 0x007D125C File Offset: 0x007CF45C
		public IVisualNovelDisplayItemBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F04A RID: 61514
		// (get) Token: 0x06039F92 RID: 237458 RVA: 0x007D126C File Offset: 0x007CF46C
		public EVisualNovelDisplayItemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelDisplayItemType.Image;
				}
				return (EVisualNovelDisplayItemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039F93 RID: 237459 RVA: 0x007D12A8 File Offset: 0x007CF4A8
		public static Offset<IVisualNovelDisplayItemBase> CreateIVisualNovelDisplayItemBase(FlatBufferBuilder builder, EVisualNovelDisplayItemType Type = EVisualNovelDisplayItemType.Image)
		{
			builder.StartTable(1);
			IVisualNovelDisplayItemBase.AddType(builder, Type);
			return IVisualNovelDisplayItemBase.EndIVisualNovelDisplayItemBase(builder);
		}

		// Token: 0x06039F94 RID: 237460 RVA: 0x007D12BE File Offset: 0x007CF4BE
		public static void StartIVisualNovelDisplayItemBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06039F95 RID: 237461 RVA: 0x007D12C7 File Offset: 0x007CF4C7
		public static void AddType(FlatBufferBuilder builder, EVisualNovelDisplayItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039F96 RID: 237462 RVA: 0x007D12D2 File Offset: 0x007CF4D2
		public static Offset<IVisualNovelDisplayItemBase> EndIVisualNovelDisplayItemBase(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelDisplayItemBase>(builder.EndTable());
		}

		// Token: 0x06039F97 RID: 237463 RVA: 0x007D12E0 File Offset: 0x007CF4E0
		public IVisualNovelDisplayItemBaseT UnPack()
		{
			IVisualNovelDisplayItemBaseT visualNovelDisplayItemBaseT = new IVisualNovelDisplayItemBaseT();
			this.UnPackTo(visualNovelDisplayItemBaseT);
			return visualNovelDisplayItemBaseT;
		}

		// Token: 0x06039F98 RID: 237464 RVA: 0x007D12FB File Offset: 0x007CF4FB
		public void UnPackTo(IVisualNovelDisplayItemBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06039F99 RID: 237465 RVA: 0x007D130C File Offset: 0x007CF50C
		public static Offset<IVisualNovelDisplayItemBase> Pack(FlatBufferBuilder builder, IVisualNovelDisplayItemBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelDisplayItemBase>);
			}
			return IVisualNovelDisplayItemBase.CreateIVisualNovelDisplayItemBase(builder, _o.Type);
		}

		// Token: 0x040134B2 RID: 79026
		private Table __p;
	}
}
