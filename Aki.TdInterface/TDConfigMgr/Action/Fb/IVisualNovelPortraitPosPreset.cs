using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002571 RID: 9585
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelPortraitPosPreset
	{
		// Token: 0x0600D718 RID: 55064 RVA: 0x00200BA2 File Offset: 0x001FEDA2
		public static IVisualNovelPortraitPosPreset Create(IVisualNovelPortraitPosPreset? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPortraitPosPreset
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003DF8 RID: 15864
		// (get) Token: 0x0600D719 RID: 55065 RVA: 0x00200BC1 File Offset: 0x001FEDC1
		public virtual string Name
		{
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17003DF9 RID: 15865
		// (get) Token: 0x0600D71A RID: 55066 RVA: 0x00200BCE File Offset: 0x001FEDCE
		public virtual int PosX
		{
			get
			{
				return this.Instance.PosX;
			}
		}

		// Token: 0x17003DFA RID: 15866
		// (get) Token: 0x0600D71B RID: 55067 RVA: 0x00200BDB File Offset: 0x001FEDDB
		public virtual int PosY
		{
			get
			{
				return this.Instance.PosY;
			}
		}

		// Token: 0x04007713 RID: 30483
		private IVisualNovelPortraitPosPreset Instance;
	}
}
