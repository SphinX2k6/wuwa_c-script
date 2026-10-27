using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D5C RID: 15708
	public class ICheckPlayerInputBase_UnionUnion
	{
		// Token: 0x17006BCC RID: 27596
		// (get) Token: 0x06015BAB RID: 89003 RVA: 0x00322641 File Offset: 0x00320841
		// (set) Token: 0x06015BAC RID: 89004 RVA: 0x00322649 File Offset: 0x00320849
		public ICheckPlayerInputBase_Union Type { get; set; }

		// Token: 0x17006BCD RID: 27597
		// (get) Token: 0x06015BAD RID: 89005 RVA: 0x00322652 File Offset: 0x00320852
		// (set) Token: 0x06015BAE RID: 89006 RVA: 0x0032265A File Offset: 0x0032085A
		public object Value { get; set; }

		// Token: 0x06015BAF RID: 89007 RVA: 0x00322663 File Offset: 0x00320863
		public ICheckPlayerInputBase_UnionUnion()
		{
			this.Type = ICheckPlayerInputBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06015BB0 RID: 89008 RVA: 0x00322679 File Offset: 0x00320879
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06015BB1 RID: 89009 RVA: 0x0032268B File Offset: 0x0032088B
		public ICheckPlayerInputBaseT AsICheckPlayerInputBase()
		{
			return this.As<ICheckPlayerInputBaseT>();
		}

		// Token: 0x06015BB2 RID: 89010 RVA: 0x00322693 File Offset: 0x00320893
		public static ICheckPlayerInputBase_UnionUnion FromICheckPlayerInputBase(ICheckPlayerInputBaseT _icheckplayerinputbase)
		{
			return new ICheckPlayerInputBase_UnionUnion
			{
				Type = ICheckPlayerInputBase_Union.ICheckPlayerInputBase,
				Value = _icheckplayerinputbase
			};
		}

		// Token: 0x06015BB3 RID: 89011 RVA: 0x003226A8 File Offset: 0x003208A8
		public ICheckPlayerPressButtonT AsICheckPlayerPressButton()
		{
			return this.As<ICheckPlayerPressButtonT>();
		}

		// Token: 0x06015BB4 RID: 89012 RVA: 0x003226B0 File Offset: 0x003208B0
		public static ICheckPlayerInputBase_UnionUnion FromICheckPlayerPressButton(ICheckPlayerPressButtonT _icheckplayerpressbutton)
		{
			return new ICheckPlayerInputBase_UnionUnion
			{
				Type = ICheckPlayerInputBase_Union.ICheckPlayerPressButton,
				Value = _icheckplayerpressbutton
			};
		}

		// Token: 0x06015BB5 RID: 89013 RVA: 0x003226C8 File Offset: 0x003208C8
		public static int Pack(FlatBufferBuilder builder, ICheckPlayerInputBase_UnionUnion _o)
		{
			ICheckPlayerInputBase_Union type = _o.Type;
			if (type == ICheckPlayerInputBase_Union.ICheckPlayerInputBase)
			{
				return ICheckPlayerInputBase.Pack(builder, _o.AsICheckPlayerInputBase()).Value;
			}
			if (type != ICheckPlayerInputBase_Union.ICheckPlayerPressButton)
			{
				return 0;
			}
			return ICheckPlayerPressButton.Pack(builder, _o.AsICheckPlayerPressButton()).Value;
		}
	}
}
