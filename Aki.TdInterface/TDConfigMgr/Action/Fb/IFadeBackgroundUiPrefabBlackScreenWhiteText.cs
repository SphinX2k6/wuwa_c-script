using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A47 RID: 10823
	[NullableContext(2)]
	[Nullable(0)]
	public class IFadeBackgroundUiPrefabBlackScreenWhiteText : IFadeBackgroundUiPrefabType
	{
		// Token: 0x0600EF07 RID: 61191 RVA: 0x00230891 File Offset: 0x0022EA91
		[NullableContext(0)]
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

		// Token: 0x17004727 RID: 18215
		// (get) Token: 0x0600EF08 RID: 61192 RVA: 0x002308B0 File Offset: 0x0022EAB0
		public override EFadeBackgroundUiPrefabType Type
		{
			get
			{
				return (EFadeBackgroundUiPrefabType)this.Instance.Type;
			}
		}

		// Token: 0x17004728 RID: 18216
		// (get) Token: 0x0600EF09 RID: 61193 RVA: 0x002308BD File Offset: 0x0022EABD
		public virtual EBlackScreenWhiteTextStartAnimName StartAnimName
		{
			get
			{
				return (EBlackScreenWhiteTextStartAnimName)this.Instance.StartAnimName;
			}
		}

		// Token: 0x17004729 RID: 18217
		// (get) Token: 0x0600EF0A RID: 61194 RVA: 0x002308CA File Offset: 0x0022EACA
		public virtual string Text
		{
			get
			{
				return this.Instance.Text;
			}
		}

		// Token: 0x1700472A RID: 18218
		// (get) Token: 0x0600EF0B RID: 61195 RVA: 0x002308D7 File Offset: 0x0022EAD7
		public virtual string AudioEvent
		{
			get
			{
				return this.Instance.AudioEvent;
			}
		}

		// Token: 0x04008341 RID: 33601
		private IFadeBackgroundUiPrefabBlackScreenWhiteText Instance;
	}
}
