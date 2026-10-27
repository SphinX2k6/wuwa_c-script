using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200757A RID: 30074
	public struct IVisualNovelDisplayItemBase : IFlatbufferObject
	{
		// Token: 0x1700E419 RID: 58393
		// (get) Token: 0x06036B64 RID: 224100 RVA: 0x0076DC5A File Offset: 0x0076BE5A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036B65 RID: 224101 RVA: 0x0076DC67 File Offset: 0x0076BE67
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036B66 RID: 224102 RVA: 0x0076DC70 File Offset: 0x0076BE70
		public static IVisualNovelDisplayItemBase GetRootAsIVisualNovelDisplayItemBase(ByteBuffer _bb)
		{
			return IVisualNovelDisplayItemBase.GetRootAsIVisualNovelDisplayItemBase(_bb, default(IVisualNovelDisplayItemBase));
		}

		// Token: 0x06036B67 RID: 224103 RVA: 0x0076DC8C File Offset: 0x0076BE8C
		public static IVisualNovelDisplayItemBase GetRootAsIVisualNovelDisplayItemBase(ByteBuffer _bb, IVisualNovelDisplayItemBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036B68 RID: 224104 RVA: 0x0076DCA9 File Offset: 0x0076BEA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036B69 RID: 224105 RVA: 0x0076DCB8 File Offset: 0x0076BEB8
		public IVisualNovelDisplayItemBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E41A RID: 58394
		// (get) Token: 0x06036B6A RID: 224106 RVA: 0x0076DCC8 File Offset: 0x0076BEC8
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

		// Token: 0x06036B6B RID: 224107 RVA: 0x0076DD04 File Offset: 0x0076BF04
		public static Offset<IVisualNovelDisplayItemBase> CreateIVisualNovelDisplayItemBase(FlatBufferBuilder builder, EVisualNovelDisplayItemType Type = EVisualNovelDisplayItemType.Image)
		{
			builder.StartTable(1);
			IVisualNovelDisplayItemBase.AddType(builder, Type);
			return IVisualNovelDisplayItemBase.EndIVisualNovelDisplayItemBase(builder);
		}

		// Token: 0x06036B6C RID: 224108 RVA: 0x0076DD1A File Offset: 0x0076BF1A
		public static void StartIVisualNovelDisplayItemBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036B6D RID: 224109 RVA: 0x0076DD23 File Offset: 0x0076BF23
		public static void AddType(FlatBufferBuilder builder, EVisualNovelDisplayItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036B6E RID: 224110 RVA: 0x0076DD2E File Offset: 0x0076BF2E
		public static Offset<IVisualNovelDisplayItemBase> EndIVisualNovelDisplayItemBase(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelDisplayItemBase>(builder.EndTable());
		}

		// Token: 0x06036B6F RID: 224111 RVA: 0x0076DD3C File Offset: 0x0076BF3C
		public IVisualNovelDisplayItemBaseT UnPack()
		{
			IVisualNovelDisplayItemBaseT visualNovelDisplayItemBaseT = new IVisualNovelDisplayItemBaseT();
			this.UnPackTo(visualNovelDisplayItemBaseT);
			return visualNovelDisplayItemBaseT;
		}

		// Token: 0x06036B70 RID: 224112 RVA: 0x0076DD57 File Offset: 0x0076BF57
		public void UnPackTo(IVisualNovelDisplayItemBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036B71 RID: 224113 RVA: 0x0076DD68 File Offset: 0x0076BF68
		public static Offset<IVisualNovelDisplayItemBase> Pack(FlatBufferBuilder builder, IVisualNovelDisplayItemBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelDisplayItemBase>);
			}
			return IVisualNovelDisplayItemBase.CreateIVisualNovelDisplayItemBase(builder, _o.Type);
		}

		// Token: 0x0401247E RID: 74878
		private Table __p;
	}
}
