using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007586 RID: 30086
	public struct IVisualNovelDisplayItemPrefab : IFlatbufferObject
	{
		// Token: 0x1700E426 RID: 58406
		// (get) Token: 0x06036BAE RID: 224174 RVA: 0x0076E2D6 File Offset: 0x0076C4D6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036BAF RID: 224175 RVA: 0x0076E2E3 File Offset: 0x0076C4E3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036BB0 RID: 224176 RVA: 0x0076E2EC File Offset: 0x0076C4EC
		public static IVisualNovelDisplayItemPrefab GetRootAsIVisualNovelDisplayItemPrefab(ByteBuffer _bb)
		{
			return IVisualNovelDisplayItemPrefab.GetRootAsIVisualNovelDisplayItemPrefab(_bb, default(IVisualNovelDisplayItemPrefab));
		}

		// Token: 0x06036BB1 RID: 224177 RVA: 0x0076E308 File Offset: 0x0076C508
		public static IVisualNovelDisplayItemPrefab GetRootAsIVisualNovelDisplayItemPrefab(ByteBuffer _bb, IVisualNovelDisplayItemPrefab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036BB2 RID: 224178 RVA: 0x0076E325 File Offset: 0x0076C525
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036BB3 RID: 224179 RVA: 0x0076E334 File Offset: 0x0076C534
		public IVisualNovelDisplayItemPrefab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E427 RID: 58407
		// (get) Token: 0x06036BB4 RID: 224180 RVA: 0x0076E344 File Offset: 0x0076C544
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

		// Token: 0x1700E428 RID: 58408
		// (get) Token: 0x06036BB5 RID: 224181 RVA: 0x0076E380 File Offset: 0x0076C580
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

		// Token: 0x06036BB6 RID: 224182 RVA: 0x0076E3BC File Offset: 0x0076C5BC
		public static Offset<IVisualNovelDisplayItemPrefab> CreateIVisualNovelDisplayItemPrefab(FlatBufferBuilder builder, EVisualNovelDisplayItemType Type = EVisualNovelDisplayItemType.Image, int PrefabId = 0)
		{
			builder.StartTable(2);
			IVisualNovelDisplayItemPrefab.AddPrefabId(builder, PrefabId);
			IVisualNovelDisplayItemPrefab.AddType(builder, Type);
			return IVisualNovelDisplayItemPrefab.EndIVisualNovelDisplayItemPrefab(builder);
		}

		// Token: 0x06036BB7 RID: 224183 RVA: 0x0076E3D9 File Offset: 0x0076C5D9
		public static void StartIVisualNovelDisplayItemPrefab(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036BB8 RID: 224184 RVA: 0x0076E3E2 File Offset: 0x0076C5E2
		public static void AddType(FlatBufferBuilder builder, EVisualNovelDisplayItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036BB9 RID: 224185 RVA: 0x0076E3ED File Offset: 0x0076C5ED
		public static void AddPrefabId(FlatBufferBuilder builder, int prefabId)
		{
			builder.AddInt(1, prefabId, 0);
		}

		// Token: 0x06036BBA RID: 224186 RVA: 0x0076E3F8 File Offset: 0x0076C5F8
		public static Offset<IVisualNovelDisplayItemPrefab> EndIVisualNovelDisplayItemPrefab(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelDisplayItemPrefab>(builder.EndTable());
		}

		// Token: 0x06036BBB RID: 224187 RVA: 0x0076E408 File Offset: 0x0076C608
		public IVisualNovelDisplayItemPrefabT UnPack()
		{
			IVisualNovelDisplayItemPrefabT visualNovelDisplayItemPrefabT = new IVisualNovelDisplayItemPrefabT();
			this.UnPackTo(visualNovelDisplayItemPrefabT);
			return visualNovelDisplayItemPrefabT;
		}

		// Token: 0x06036BBC RID: 224188 RVA: 0x0076E423 File Offset: 0x0076C623
		public void UnPackTo(IVisualNovelDisplayItemPrefabT _o)
		{
			_o.Type = this.Type;
			_o.PrefabId = this.PrefabId;
		}

		// Token: 0x06036BBD RID: 224189 RVA: 0x0076E440 File Offset: 0x0076C640
		public static Offset<IVisualNovelDisplayItemPrefab> Pack(FlatBufferBuilder builder, IVisualNovelDisplayItemPrefabT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelDisplayItemPrefab>);
			}
			return IVisualNovelDisplayItemPrefab.CreateIVisualNovelDisplayItemPrefab(builder, _o.Type, _o.PrefabId);
		}

		// Token: 0x0401248D RID: 74893
		private Table __p;
	}
}
