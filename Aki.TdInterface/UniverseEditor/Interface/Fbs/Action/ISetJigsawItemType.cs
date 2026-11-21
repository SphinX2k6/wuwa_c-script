using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077DC RID: 30684
	public struct ISetJigsawItemType : IFlatbufferObject
	{
		// Token: 0x1700E0E2 RID: 57570
		// (get) Token: 0x06035E57 RID: 220759 RVA: 0x007387F3 File Offset: 0x007369F3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035E58 RID: 220760 RVA: 0x00738800 File Offset: 0x00736A00
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035E59 RID: 220761 RVA: 0x00738808 File Offset: 0x00736A08
		public static ISetJigsawItemType GetRootAsISetJigsawItemType(ByteBuffer _bb)
		{
			return ISetJigsawItemType.GetRootAsISetJigsawItemType(_bb, default(ISetJigsawItemType));
		}

		// Token: 0x06035E5A RID: 220762 RVA: 0x00738824 File Offset: 0x00736A24
		public static ISetJigsawItemType GetRootAsISetJigsawItemType(ByteBuffer _bb, ISetJigsawItemType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035E5B RID: 220763 RVA: 0x00738841 File Offset: 0x00736A41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035E5C RID: 220764 RVA: 0x00738850 File Offset: 0x00736A50
		public ISetJigsawItemType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E0E3 RID: 57571
		// (get) Token: 0x06035E5D RID: 220765 RVA: 0x00738860 File Offset: 0x00736A60
		public ESetJigsawItemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESetJigsawItemType.MoveJigsawItem;
				}
				return (ESetJigsawItemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035E5E RID: 220766 RVA: 0x0073889C File Offset: 0x00736A9C
		public static Offset<ISetJigsawItemType> CreateISetJigsawItemType(FlatBufferBuilder builder, ESetJigsawItemType Type = ESetJigsawItemType.MoveJigsawItem)
		{
			builder.StartTable(1);
			ISetJigsawItemType.AddType(builder, Type);
			return ISetJigsawItemType.EndISetJigsawItemType(builder);
		}

		// Token: 0x06035E5F RID: 220767 RVA: 0x007388B2 File Offset: 0x00736AB2
		public static void StartISetJigsawItemType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035E60 RID: 220768 RVA: 0x007388BB File Offset: 0x00736ABB
		public static void AddType(FlatBufferBuilder builder, ESetJigsawItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035E61 RID: 220769 RVA: 0x007388C6 File Offset: 0x00736AC6
		public static Offset<ISetJigsawItemType> EndISetJigsawItemType(FlatBufferBuilder builder)
		{
			return new Offset<ISetJigsawItemType>(builder.EndTable());
		}

		// Token: 0x06035E62 RID: 220770 RVA: 0x007388D4 File Offset: 0x00736AD4
		public ISetJigsawItemTypeT UnPack()
		{
			ISetJigsawItemTypeT setJigsawItemTypeT = new ISetJigsawItemTypeT();
			this.UnPackTo(setJigsawItemTypeT);
			return setJigsawItemTypeT;
		}

		// Token: 0x06035E63 RID: 220771 RVA: 0x007388EF File Offset: 0x00736AEF
		public void UnPackTo(ISetJigsawItemTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035E64 RID: 220772 RVA: 0x00738900 File Offset: 0x00736B00
		public static Offset<ISetJigsawItemType> Pack(FlatBufferBuilder builder, ISetJigsawItemTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetJigsawItemType>);
			}
			return ISetJigsawItemType.CreateISetJigsawItemType(builder, _o.Type);
		}

		// Token: 0x04012A1C RID: 76316
		private Table __p;
	}
}
