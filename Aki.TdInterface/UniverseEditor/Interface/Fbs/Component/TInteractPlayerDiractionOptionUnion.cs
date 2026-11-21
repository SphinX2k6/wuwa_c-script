using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200626E RID: 25198
	public class TInteractPlayerDiractionOptionUnion
	{
		// Token: 0x1700BB60 RID: 47968
		// (get) Token: 0x0602AE1B RID: 175643 RVA: 0x005DA806 File Offset: 0x005D8A06
		// (set) Token: 0x0602AE1C RID: 175644 RVA: 0x005DA80E File Offset: 0x005D8A0E
		public TInteractPlayerDiractionOption Type { get; set; }

		// Token: 0x1700BB61 RID: 47969
		// (get) Token: 0x0602AE1D RID: 175645 RVA: 0x005DA817 File Offset: 0x005D8A17
		// (set) Token: 0x0602AE1E RID: 175646 RVA: 0x005DA81F File Offset: 0x005D8A1F
		public object Value { get; set; }

		// Token: 0x0602AE1F RID: 175647 RVA: 0x005DA828 File Offset: 0x005D8A28
		public TInteractPlayerDiractionOptionUnion()
		{
			this.Type = TInteractPlayerDiractionOption.NONE;
			this.Value = null;
		}

		// Token: 0x0602AE20 RID: 175648 RVA: 0x005DA83E File Offset: 0x005D8A3E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AE21 RID: 175649 RVA: 0x005DA850 File Offset: 0x005D8A50
		public IInteractPlayerDiractionToLeisureT AsIInteractPlayerDiractionToLeisure()
		{
			return this.As<IInteractPlayerDiractionToLeisureT>();
		}

		// Token: 0x0602AE22 RID: 175650 RVA: 0x005DA858 File Offset: 0x005D8A58
		public static TInteractPlayerDiractionOptionUnion FromIInteractPlayerDiractionToLeisure(IInteractPlayerDiractionToLeisureT _iinteractplayerdiractiontoleisure)
		{
			return new TInteractPlayerDiractionOptionUnion
			{
				Type = TInteractPlayerDiractionOption.IInteractPlayerDiractionToLeisure,
				Value = _iinteractplayerdiractiontoleisure
			};
		}

		// Token: 0x0602AE23 RID: 175651 RVA: 0x005DA86D File Offset: 0x005D8A6D
		public IInteractPlayerDiractionToNpcT AsIInteractPlayerDiractionToNpc()
		{
			return this.As<IInteractPlayerDiractionToNpcT>();
		}

		// Token: 0x0602AE24 RID: 175652 RVA: 0x005DA875 File Offset: 0x005D8A75
		public static TInteractPlayerDiractionOptionUnion FromIInteractPlayerDiractionToNpc(IInteractPlayerDiractionToNpcT _iinteractplayerdiractiontonpc)
		{
			return new TInteractPlayerDiractionOptionUnion
			{
				Type = TInteractPlayerDiractionOption.IInteractPlayerDiractionToNpc,
				Value = _iinteractplayerdiractiontonpc
			};
		}

		// Token: 0x0602AE25 RID: 175653 RVA: 0x005DA88C File Offset: 0x005D8A8C
		public static int Pack(FlatBufferBuilder builder, TInteractPlayerDiractionOptionUnion _o)
		{
			TInteractPlayerDiractionOption type = _o.Type;
			if (type == TInteractPlayerDiractionOption.IInteractPlayerDiractionToLeisure)
			{
				return IInteractPlayerDiractionToLeisure.Pack(builder, _o.AsIInteractPlayerDiractionToLeisure()).Value;
			}
			if (type != TInteractPlayerDiractionOption.IInteractPlayerDiractionToNpc)
			{
				return 0;
			}
			return IInteractPlayerDiractionToNpc.Pack(builder, _o.AsIInteractPlayerDiractionToNpc()).Value;
		}
	}
}
