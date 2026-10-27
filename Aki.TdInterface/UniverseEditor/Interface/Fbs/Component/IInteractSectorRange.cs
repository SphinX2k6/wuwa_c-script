using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005473 RID: 21619
	public struct IInteractSectorRange : IFlatbufferObject
	{
		// Token: 0x17009F21 RID: 40737
		// (get) Token: 0x060238FF RID: 145663 RVA: 0x004EB0CE File Offset: 0x004E92CE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023900 RID: 145664 RVA: 0x004EB0DB File Offset: 0x004E92DB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023901 RID: 145665 RVA: 0x004EB0E4 File Offset: 0x004E92E4
		public static IInteractSectorRange GetRootAsIInteractSectorRange(ByteBuffer _bb)
		{
			return IInteractSectorRange.GetRootAsIInteractSectorRange(_bb, default(IInteractSectorRange));
		}

		// Token: 0x06023902 RID: 145666 RVA: 0x004EB100 File Offset: 0x004E9300
		public static IInteractSectorRange GetRootAsIInteractSectorRange(ByteBuffer _bb, IInteractSectorRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023903 RID: 145667 RVA: 0x004EB11D File Offset: 0x004E931D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023904 RID: 145668 RVA: 0x004EB12C File Offset: 0x004E932C
		public IInteractSectorRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F22 RID: 40738
		// (get) Token: 0x06023905 RID: 145669 RVA: 0x004EB13C File Offset: 0x004E933C
		public float Begin
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009F23 RID: 40739
		// (get) Token: 0x06023906 RID: 145670 RVA: 0x004EB17C File Offset: 0x004E937C
		public float End
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023907 RID: 145671 RVA: 0x004EB1BC File Offset: 0x004E93BC
		public static Offset<IInteractSectorRange> CreateIInteractSectorRange(FlatBufferBuilder builder, float Begin = 0f, float End = 0f)
		{
			builder.StartTable(2);
			IInteractSectorRange.AddEnd(builder, End);
			IInteractSectorRange.AddBegin(builder, Begin);
			return IInteractSectorRange.EndIInteractSectorRange(builder);
		}

		// Token: 0x06023908 RID: 145672 RVA: 0x004EB1D9 File Offset: 0x004E93D9
		public static void StartIInteractSectorRange(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06023909 RID: 145673 RVA: 0x004EB1E2 File Offset: 0x004E93E2
		public static void AddBegin(FlatBufferBuilder builder, float begin)
		{
			builder.AddFloat(0, begin, 0.0);
		}

		// Token: 0x0602390A RID: 145674 RVA: 0x004EB1F5 File Offset: 0x004E93F5
		public static void AddEnd(FlatBufferBuilder builder, float end)
		{
			builder.AddFloat(1, end, 0.0);
		}

		// Token: 0x0602390B RID: 145675 RVA: 0x004EB208 File Offset: 0x004E9408
		public static Offset<IInteractSectorRange> EndIInteractSectorRange(FlatBufferBuilder builder)
		{
			return new Offset<IInteractSectorRange>(builder.EndTable());
		}

		// Token: 0x0602390C RID: 145676 RVA: 0x004EB218 File Offset: 0x004E9418
		public IInteractSectorRangeT UnPack()
		{
			IInteractSectorRangeT interactSectorRangeT = new IInteractSectorRangeT();
			this.UnPackTo(interactSectorRangeT);
			return interactSectorRangeT;
		}

		// Token: 0x0602390D RID: 145677 RVA: 0x004EB233 File Offset: 0x004E9433
		public void UnPackTo(IInteractSectorRangeT _o)
		{
			_o.Begin = this.Begin;
			_o.End = this.End;
		}

		// Token: 0x0602390E RID: 145678 RVA: 0x004EB250 File Offset: 0x004E9450
		public static Offset<IInteractSectorRange> Pack(FlatBufferBuilder builder, IInteractSectorRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractSectorRange>);
			}
			return IInteractSectorRange.CreateIInteractSectorRange(builder, _o.Begin, _o.End);
		}

		// Token: 0x0400E6F1 RID: 59121
		private Table __p;
	}
}
