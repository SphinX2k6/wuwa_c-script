using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D7C RID: 32124
	public struct IVisualNovelDisplayItemPrefab : IFlatbufferObject
	{
		// Token: 0x1700F056 RID: 61526
		// (get) Token: 0x06039FD6 RID: 237526 RVA: 0x007D187A File Offset: 0x007CFA7A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039FD7 RID: 237527 RVA: 0x007D1887 File Offset: 0x007CFA87
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039FD8 RID: 237528 RVA: 0x007D1890 File Offset: 0x007CFA90
		public static IVisualNovelDisplayItemPrefab GetRootAsIVisualNovelDisplayItemPrefab(ByteBuffer _bb)
		{
			return IVisualNovelDisplayItemPrefab.GetRootAsIVisualNovelDisplayItemPrefab(_bb, default(IVisualNovelDisplayItemPrefab));
		}

		// Token: 0x06039FD9 RID: 237529 RVA: 0x007D18AC File Offset: 0x007CFAAC
		public static IVisualNovelDisplayItemPrefab GetRootAsIVisualNovelDisplayItemPrefab(ByteBuffer _bb, IVisualNovelDisplayItemPrefab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039FDA RID: 237530 RVA: 0x007D18C9 File Offset: 0x007CFAC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039FDB RID: 237531 RVA: 0x007D18D8 File Offset: 0x007CFAD8
		public IVisualNovelDisplayItemPrefab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F057 RID: 61527
		// (get) Token: 0x06039FDC RID: 237532 RVA: 0x007D18E8 File Offset: 0x007CFAE8
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

		// Token: 0x1700F058 RID: 61528
		// (get) Token: 0x06039FDD RID: 237533 RVA: 0x007D1924 File Offset: 0x007CFB24
		public int PrefabId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039FDE RID: 237534 RVA: 0x007D1960 File Offset: 0x007CFB60
		public static Offset<IVisualNovelDisplayItemPrefab> CreateIVisualNovelDisplayItemPrefab(FlatBufferBuilder builder, EVisualNovelDisplayItemType Type = EVisualNovelDisplayItemType.Image, int PrefabId = 0)
		{
			builder.StartTable(2);
			IVisualNovelDisplayItemPrefab.AddPrefabId(builder, PrefabId);
			IVisualNovelDisplayItemPrefab.AddType(builder, Type);
			return IVisualNovelDisplayItemPrefab.EndIVisualNovelDisplayItemPrefab(builder);
		}

		// Token: 0x06039FDF RID: 237535 RVA: 0x007D197D File Offset: 0x007CFB7D
		public static void StartIVisualNovelDisplayItemPrefab(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06039FE0 RID: 237536 RVA: 0x007D1986 File Offset: 0x007CFB86
		public static void AddType(FlatBufferBuilder builder, EVisualNovelDisplayItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039FE1 RID: 237537 RVA: 0x007D1991 File Offset: 0x007CFB91
		public static void AddPrefabId(FlatBufferBuilder builder, int prefabId)
		{
			builder.AddInt(1, prefabId, 0);
		}

		// Token: 0x06039FE2 RID: 237538 RVA: 0x007D199C File Offset: 0x007CFB9C
		public static Offset<IVisualNovelDisplayItemPrefab> EndIVisualNovelDisplayItemPrefab(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelDisplayItemPrefab>(builder.EndTable());
		}

		// Token: 0x06039FE3 RID: 237539 RVA: 0x007D19AC File Offset: 0x007CFBAC
		public IVisualNovelDisplayItemPrefabT UnPack()
		{
			IVisualNovelDisplayItemPrefabT visualNovelDisplayItemPrefabT = new IVisualNovelDisplayItemPrefabT();
			this.UnPackTo(visualNovelDisplayItemPrefabT);
			return visualNovelDisplayItemPrefabT;
		}

		// Token: 0x06039FE4 RID: 237540 RVA: 0x007D19C7 File Offset: 0x007CFBC7
		public void UnPackTo(IVisualNovelDisplayItemPrefabT _o)
		{
			_o.Type = this.Type;
			_o.PrefabId = this.PrefabId;
		}

		// Token: 0x06039FE5 RID: 237541 RVA: 0x007D19E4 File Offset: 0x007CFBE4
		public static Offset<IVisualNovelDisplayItemPrefab> Pack(FlatBufferBuilder builder, IVisualNovelDisplayItemPrefabT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelDisplayItemPrefab>);
			}
			return IVisualNovelDisplayItemPrefab.CreateIVisualNovelDisplayItemPrefab(builder, _o.Type, _o.PrefabId);
		}

		// Token: 0x040134C1 RID: 79041
		private Table __p;
	}
}
