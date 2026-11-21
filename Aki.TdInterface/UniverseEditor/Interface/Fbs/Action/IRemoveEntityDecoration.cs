using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075CA RID: 30154
	public struct IRemoveEntityDecoration : IFlatbufferObject
	{
		// Token: 0x1700DDAB RID: 56747
		// (get) Token: 0x06034E62 RID: 216674 RVA: 0x0071BF1E File Offset: 0x0071A11E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034E63 RID: 216675 RVA: 0x0071BF2B File Offset: 0x0071A12B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034E64 RID: 216676 RVA: 0x0071BF34 File Offset: 0x0071A134
		public static IRemoveEntityDecoration GetRootAsIRemoveEntityDecoration(ByteBuffer _bb)
		{
			return IRemoveEntityDecoration.GetRootAsIRemoveEntityDecoration(_bb, default(IRemoveEntityDecoration));
		}

		// Token: 0x06034E65 RID: 216677 RVA: 0x0071BF50 File Offset: 0x0071A150
		public static IRemoveEntityDecoration GetRootAsIRemoveEntityDecoration(ByteBuffer _bb, IRemoveEntityDecoration obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034E66 RID: 216678 RVA: 0x0071BF6D File Offset: 0x0071A16D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034E67 RID: 216679 RVA: 0x0071BF7C File Offset: 0x0071A17C
		public IRemoveEntityDecoration __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DDAC RID: 56748
		// (get) Token: 0x06034E68 RID: 216680 RVA: 0x0071BF8C File Offset: 0x0071A18C
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

		// Token: 0x06034E69 RID: 216681 RVA: 0x0071BFC8 File Offset: 0x0071A1C8
		public static Offset<IRemoveEntityDecoration> CreateIRemoveEntityDecoration(FlatBufferBuilder builder, EEntityDecorationType Type = EEntityDecorationType.Add)
		{
			builder.StartTable(1);
			IRemoveEntityDecoration.AddType(builder, Type);
			return IRemoveEntityDecoration.EndIRemoveEntityDecoration(builder);
		}

		// Token: 0x06034E6A RID: 216682 RVA: 0x0071BFDE File Offset: 0x0071A1DE
		public static void StartIRemoveEntityDecoration(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034E6B RID: 216683 RVA: 0x0071BFE7 File Offset: 0x0071A1E7
		public static void AddType(FlatBufferBuilder builder, EEntityDecorationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034E6C RID: 216684 RVA: 0x0071BFF2 File Offset: 0x0071A1F2
		public static Offset<IRemoveEntityDecoration> EndIRemoveEntityDecoration(FlatBufferBuilder builder)
		{
			return new Offset<IRemoveEntityDecoration>(builder.EndTable());
		}

		// Token: 0x06034E6D RID: 216685 RVA: 0x0071C000 File Offset: 0x0071A200
		public IRemoveEntityDecorationT UnPack()
		{
			IRemoveEntityDecorationT removeEntityDecorationT = new IRemoveEntityDecorationT();
			this.UnPackTo(removeEntityDecorationT);
			return removeEntityDecorationT;
		}

		// Token: 0x06034E6E RID: 216686 RVA: 0x0071C01B File Offset: 0x0071A21B
		public void UnPackTo(IRemoveEntityDecorationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06034E6F RID: 216687 RVA: 0x0071C02C File Offset: 0x0071A22C
		public static Offset<IRemoveEntityDecoration> Pack(FlatBufferBuilder builder, IRemoveEntityDecorationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemoveEntityDecoration>);
			}
			return IRemoveEntityDecoration.CreateIRemoveEntityDecoration(builder, _o.Type);
		}

		// Token: 0x040127B2 RID: 75698
		private Table __p;
	}
}
