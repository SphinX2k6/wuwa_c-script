using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EC9 RID: 28361
	public struct IFocusOnMapMark : IFlatbufferObject
	{
		// Token: 0x1700D00C RID: 53260
		// (get) Token: 0x06031123 RID: 200995 RVA: 0x006A77F6 File Offset: 0x006A59F6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031124 RID: 200996 RVA: 0x006A7803 File Offset: 0x006A5A03
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031125 RID: 200997 RVA: 0x006A780C File Offset: 0x006A5A0C
		public static IFocusOnMapMark GetRootAsIFocusOnMapMark(ByteBuffer _bb)
		{
			return IFocusOnMapMark.GetRootAsIFocusOnMapMark(_bb, default(IFocusOnMapMark));
		}

		// Token: 0x06031126 RID: 200998 RVA: 0x006A7828 File Offset: 0x006A5A28
		public static IFocusOnMapMark GetRootAsIFocusOnMapMark(ByteBuffer _bb, IFocusOnMapMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031127 RID: 200999 RVA: 0x006A7845 File Offset: 0x006A5A45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031128 RID: 201000 RVA: 0x006A7854 File Offset: 0x006A5A54
		public IFocusOnMapMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D00D RID: 53261
		// (get) Token: 0x06031129 RID: 201001 RVA: 0x006A7864 File Offset: 0x006A5A64
		public EMapMarkType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMapMarkType.Custom;
				}
				return (EMapMarkType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603112A RID: 201002 RVA: 0x006A78A0 File Offset: 0x006A5AA0
		public static Offset<IFocusOnMapMark> CreateIFocusOnMapMark(FlatBufferBuilder builder, EMapMarkType Type = EMapMarkType.Custom)
		{
			builder.StartTable(1);
			IFocusOnMapMark.AddType(builder, Type);
			return IFocusOnMapMark.EndIFocusOnMapMark(builder);
		}

		// Token: 0x0603112B RID: 201003 RVA: 0x006A78B6 File Offset: 0x006A5AB6
		public static void StartIFocusOnMapMark(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603112C RID: 201004 RVA: 0x006A78BF File Offset: 0x006A5ABF
		public static void AddType(FlatBufferBuilder builder, EMapMarkType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603112D RID: 201005 RVA: 0x006A78CA File Offset: 0x006A5ACA
		public static Offset<IFocusOnMapMark> EndIFocusOnMapMark(FlatBufferBuilder builder)
		{
			return new Offset<IFocusOnMapMark>(builder.EndTable());
		}

		// Token: 0x0603112E RID: 201006 RVA: 0x006A78D8 File Offset: 0x006A5AD8
		public IFocusOnMapMarkT UnPack()
		{
			IFocusOnMapMarkT focusOnMapMarkT = new IFocusOnMapMarkT();
			this.UnPackTo(focusOnMapMarkT);
			return focusOnMapMarkT;
		}

		// Token: 0x0603112F RID: 201007 RVA: 0x006A78F3 File Offset: 0x006A5AF3
		public void UnPackTo(IFocusOnMapMarkT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031130 RID: 201008 RVA: 0x006A7904 File Offset: 0x006A5B04
		public static Offset<IFocusOnMapMark> Pack(FlatBufferBuilder builder, IFocusOnMapMarkT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFocusOnMapMark>);
			}
			return IFocusOnMapMark.CreateIFocusOnMapMark(builder, _o.Type);
		}

		// Token: 0x04011DC6 RID: 73158
		private Table __p;
	}
}
