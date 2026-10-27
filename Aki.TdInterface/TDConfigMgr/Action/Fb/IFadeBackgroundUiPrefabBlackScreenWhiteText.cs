using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002775 RID: 10101
	[NullableContext(2)]
	[Nullable(0)]
	public class IFadeBackgroundUiPrefabBlackScreenWhiteText : IFadeBackgroundUiPrefabType
	{
		// Token: 0x0600E0E9 RID: 57577 RVA: 0x00213AFD File Offset: 0x00211CFD
		[NullableContext(1)]
		public static IFadeBackgroundUiPrefabBlackScreenWhiteText Create(IFadeBackgroundUiPrefabBlackScreenWhiteText? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFadeBackgroundUiPrefabBlackScreenWhiteText
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043C1 RID: 17345
		// (get) Token: 0x0600E0EA RID: 57578 RVA: 0x00213B1C File Offset: 0x00211D1C
		public override EFadeBackgroundUiPrefabType Type
		{
			get
			{
				return (EFadeBackgroundUiPrefabType)this.Instance.Type;
			}
		}

		// Token: 0x170043C2 RID: 17346
		// (get) Token: 0x0600E0EB RID: 57579 RVA: 0x00213B29 File Offset: 0x00211D29
		public virtual EBlackScreenWhiteTextStartAnimName StartAnimName
		{
			get
			{
				return (EBlackScreenWhiteTextStartAnimName)this.Instance.StartAnimName;
			}
		}

		// Token: 0x170043C3 RID: 17347
		// (get) Token: 0x0600E0EC RID: 57580 RVA: 0x00213B36 File Offset: 0x00211D36
		public virtual string Text
		{
			get
			{
				return this.Instance.Text;
			}
		}

		// Token: 0x170043C4 RID: 17348
		// (get) Token: 0x0600E0ED RID: 57581 RVA: 0x00213B43 File Offset: 0x00211D43
		public virtual string AudioEvent
		{
			get
			{
				return this.Instance.AudioEvent;
			}
		}

		// Token: 0x04007C8B RID: 31883
		private IFadeBackgroundUiPrefabBlackScreenWhiteText Instance;
	}
}
