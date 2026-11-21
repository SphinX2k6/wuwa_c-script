using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004173 RID: 16755
	public class ICheckPlayerInputBase_UnionUnion
	{
		// Token: 0x17007186 RID: 29062
		// (get) Token: 0x060170E3 RID: 94435 RVA: 0x003498B9 File Offset: 0x00347AB9
		// (set) Token: 0x060170E4 RID: 94436 RVA: 0x003498C1 File Offset: 0x00347AC1
		public ICheckPlayerInputBase_Union Type { get; set; }

		// Token: 0x17007187 RID: 29063
		// (get) Token: 0x060170E5 RID: 94437 RVA: 0x003498CA File Offset: 0x00347ACA
		// (set) Token: 0x060170E6 RID: 94438 RVA: 0x003498D2 File Offset: 0x00347AD2
		public object Value { get; set; }

		// Token: 0x060170E7 RID: 94439 RVA: 0x003498DB File Offset: 0x00347ADB
		public ICheckPlayerInputBase_UnionUnion()
		{
			this.Type = ICheckPlayerInputBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060170E8 RID: 94440 RVA: 0x003498F1 File Offset: 0x00347AF1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060170E9 RID: 94441 RVA: 0x00349903 File Offset: 0x00347B03
		public ICheckPlayerInputBaseT AsICheckPlayerInputBase()
		{
			return this.As<ICheckPlayerInputBaseT>();
		}

		// Token: 0x060170EA RID: 94442 RVA: 0x0034990B File Offset: 0x00347B0B
		public static ICheckPlayerInputBase_UnionUnion FromICheckPlayerInputBase(ICheckPlayerInputBaseT _icheckplayerinputbase)
		{
			return new ICheckPlayerInputBase_UnionUnion
			{
				Type = ICheckPlayerInputBase_Union.ICheckPlayerInputBase,
				Value = _icheckplayerinputbase
			};
		}

		// Token: 0x060170EB RID: 94443 RVA: 0x00349920 File Offset: 0x00347B20
		public ICheckPlayerPressButtonT AsICheckPlayerPressButton()
		{
			return this.As<ICheckPlayerPressButtonT>();
		}

		// Token: 0x060170EC RID: 94444 RVA: 0x00349928 File Offset: 0x00347B28
		public static ICheckPlayerInputBase_UnionUnion FromICheckPlayerPressButton(ICheckPlayerPressButtonT _icheckplayerpressbutton)
		{
			return new ICheckPlayerInputBase_UnionUnion
			{
				Type = ICheckPlayerInputBase_Union.ICheckPlayerPressButton,
				Value = _icheckplayerpressbutton
			};
		}

		// Token: 0x060170ED RID: 94445 RVA: 0x00349940 File Offset: 0x00347B40
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
