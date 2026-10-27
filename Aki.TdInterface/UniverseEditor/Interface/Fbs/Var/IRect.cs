using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003ABA RID: 15034
	public struct IRect : IFlatbufferObject
	{
		// Token: 0x17006723 RID: 26403
		// (get) Token: 0x0601470E RID: 83726 RVA: 0x002FAA4A File Offset: 0x002F8C4A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601470F RID: 83727 RVA: 0x002FAA57 File Offset: 0x002F8C57
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014710 RID: 83728 RVA: 0x002FAA60 File Offset: 0x002F8C60
		public static IRect GetRootAsIRect(ByteBuffer _bb)
		{
			return IRect.GetRootAsIRect(_bb, default(IRect));
		}

		// Token: 0x06014711 RID: 83729 RVA: 0x002FAA7C File Offset: 0x002F8C7C
		public static IRect GetRootAsIRect(ByteBuffer _bb, IRect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014712 RID: 83730 RVA: 0x002FAA99 File Offset: 0x002F8C99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014713 RID: 83731 RVA: 0x002FAAA8 File Offset: 0x002F8CA8
		public IRect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006724 RID: 26404
		// (get) Token: 0x06014714 RID: 83732 RVA: 0x002FAAB8 File Offset: 0x002F8CB8
		public IVector2? Min
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVector2?(default(IVector2).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17006725 RID: 26405
		// (get) Token: 0x06014715 RID: 83733 RVA: 0x002FAB18 File Offset: 0x002F8D18
		public IVector2? Max
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVector2?(default(IVector2).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06014716 RID: 83734 RVA: 0x002FAB75 File Offset: 0x002F8D75
		public static Offset<IRect> CreateIRect(FlatBufferBuilder builder, Offset<IVector2> MinOffset = default(Offset<IVector2>), Offset<IVector2> MaxOffset = default(Offset<IVector2>))
		{
			builder.StartTable(2);
			IRect.AddMax(builder, MaxOffset);
			IRect.AddMin(builder, MinOffset);
			return IRect.EndIRect(builder);
		}

		// Token: 0x06014717 RID: 83735 RVA: 0x002FAB92 File Offset: 0x002F8D92
		public static void StartIRect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06014718 RID: 83736 RVA: 0x002FAB9B File Offset: 0x002F8D9B
		public static void AddMin(FlatBufferBuilder builder, Offset<IVector2> minOffset)
		{
			builder.AddOffset(0, minOffset.Value, 0);
		}

		// Token: 0x06014719 RID: 83737 RVA: 0x002FABAB File Offset: 0x002F8DAB
		public static void AddMax(FlatBufferBuilder builder, Offset<IVector2> maxOffset)
		{
			builder.AddOffset(1, maxOffset.Value, 0);
		}

		// Token: 0x0601471A RID: 83738 RVA: 0x002FABBB File Offset: 0x002F8DBB
		public static Offset<IRect> EndIRect(FlatBufferBuilder builder)
		{
			return new Offset<IRect>(builder.EndTable());
		}

		// Token: 0x0601471B RID: 83739 RVA: 0x002FABC8 File Offset: 0x002F8DC8
		public IRectT UnPack()
		{
			IRectT rectT = new IRectT();
			this.UnPackTo(rectT);
			return rectT;
		}

		// Token: 0x0601471C RID: 83740 RVA: 0x002FABE4 File Offset: 0x002F8DE4
		public void UnPackTo(IRectT _o)
		{
			_o.Min = ((this.Min != null) ? this.Min.Value.UnPack() : null);
			_o.Max = ((this.Max != null) ? this.Max.Value.UnPack() : null);
		}

		// Token: 0x0601471D RID: 83741 RVA: 0x002FAC50 File Offset: 0x002F8E50
		public static Offset<IRect> Pack(FlatBufferBuilder builder, IRectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRect>);
			}
			Offset<IVector2> minOffset = (_o.Min == null) ? default(Offset<IVector2>) : IVector2.Pack(builder, _o.Min);
			Offset<IVector2> maxOffset = (_o.Max == null) ? default(Offset<IVector2>) : IVector2.Pack(builder, _o.Max);
			return IRect.CreateIRect(builder, minOffset, maxOffset);
		}

		// Token: 0x0400AF58 RID: 44888
		private Table __p;
	}
}
