using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C49 RID: 23625
	public class TInteractPlayerDiractionOptionUnion
	{
		// Token: 0x1700B20E RID: 45582
		// (get) Token: 0x0602880D RID: 165901 RVA: 0x005925EE File Offset: 0x005907EE
		// (set) Token: 0x0602880E RID: 165902 RVA: 0x005925F6 File Offset: 0x005907F6
		public TInteractPlayerDiractionOption Type { get; set; }

		// Token: 0x1700B20F RID: 45583
		// (get) Token: 0x0602880F RID: 165903 RVA: 0x005925FF File Offset: 0x005907FF
		// (set) Token: 0x06028810 RID: 165904 RVA: 0x00592607 File Offset: 0x00590807
		public object Value { get; set; }

		// Token: 0x06028811 RID: 165905 RVA: 0x00592610 File Offset: 0x00590810
		public TInteractPlayerDiractionOptionUnion()
		{
			this.Type = TInteractPlayerDiractionOption.NONE;
			this.Value = null;
		}

		// Token: 0x06028812 RID: 165906 RVA: 0x00592626 File Offset: 0x00590826
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028813 RID: 165907 RVA: 0x00592638 File Offset: 0x00590838
		public IInteractPlayerDiractionToLeisureT AsIInteractPlayerDiractionToLeisure()
		{
			return this.As<IInteractPlayerDiractionToLeisureT>();
		}

		// Token: 0x06028814 RID: 165908 RVA: 0x00592640 File Offset: 0x00590840
		public static TInteractPlayerDiractionOptionUnion FromIInteractPlayerDiractionToLeisure(IInteractPlayerDiractionToLeisureT _iinteractplayerdiractiontoleisure)
		{
			return new TInteractPlayerDiractionOptionUnion
			{
				Type = TInteractPlayerDiractionOption.IInteractPlayerDiractionToLeisure,
				Value = _iinteractplayerdiractiontoleisure
			};
		}

		// Token: 0x06028815 RID: 165909 RVA: 0x00592655 File Offset: 0x00590855
		public IInteractPlayerDiractionToNpcT AsIInteractPlayerDiractionToNpc()
		{
			return this.As<IInteractPlayerDiractionToNpcT>();
		}

		// Token: 0x06028816 RID: 165910 RVA: 0x0059265D File Offset: 0x0059085D
		public static TInteractPlayerDiractionOptionUnion FromIInteractPlayerDiractionToNpc(IInteractPlayerDiractionToNpcT _iinteractplayerdiractiontonpc)
		{
			return new TInteractPlayerDiractionOptionUnion
			{
				Type = TInteractPlayerDiractionOption.IInteractPlayerDiractionToNpc,
				Value = _iinteractplayerdiractiontonpc
			};
		}

		// Token: 0x06028817 RID: 165911 RVA: 0x00592674 File Offset: 0x00590874
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
