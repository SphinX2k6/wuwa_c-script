using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CC3 RID: 19651
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleSkillDotIndicatorItem : UiPanelBase
	{
		// Token: 0x06031203 RID: 201219 RVA: 0x00DB7B07 File Offset: 0x00DB5D07
		private string GetResourceId()
		{
			return "UiItem_LuhesSkillPoint";
		}

		// Token: 0x06031204 RID: 201220 RVA: 0x00DB7B0E File Offset: 0x00DB5D0E
		public BattleSkillDotIndicatorItem(UUIItem parentItem)
		{
			base.CreateByResourceIdAsync(this.GetResourceId(), parentItem, false).Forget();
		}

		// Token: 0x06031205 RID: 201221 RVA: 0x00DB7B40 File Offset: 0x00DB5D40
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031206 RID: 201222 RVA: 0x00DB7BCC File Offset: 0x00DB5DCC
		protected override UniTask OnBeforeStartAsync()
		{
			BattleSkillDotIndicatorItem.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattleSkillDotIndicatorItem.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031207 RID: 201223 RVA: 0x00DB7C0F File Offset: 0x00DB5E0F
		protected override void OnStart()
		{
			this.IsEnable = true;
			this.SetIconPath(this.IconPath, true);
		}

		// Token: 0x170061D1 RID: 25041
		// (get) Token: 0x06031208 RID: 201224 RVA: 0x00DB7C25 File Offset: 0x00DB5E25
		public bool IsComponentActive
		{
			get
			{
				return this.IsActive;
			}
		}

		// Token: 0x06031209 RID: 201225 RVA: 0x00DB7C2D File Offset: 0x00DB5E2D
		public void SetComponentActive(bool bShow)
		{
			if (this.IsActive != bShow)
			{
				base.SetUiActive(bShow);
			}
			this.IsActive = bShow;
		}

		// Token: 0x0603120A RID: 201226 RVA: 0x00DB7C48 File Offset: 0x00DB5E48
		public void SetCount(int num, bool force = false)
		{
			if (this.CurrentCount == num && !force)
			{
				return;
			}
			this.CurrentCount = num;
			if (!base.GetActive() && !force)
			{
				return;
			}
			for (int i = 0; i < this.DotViews.Count; i++)
			{
				this.DotViews[i].SetDotState(i < num, force);
			}
		}

		// Token: 0x0603120B RID: 201227 RVA: 0x00DB7CA4 File Offset: 0x00DB5EA4
		public void SetIconPath(string iconPath, bool force = false)
		{
			if (this.IconPath == iconPath && !force)
			{
				return;
			}
			this.IconPath = iconPath;
			if (!this.IsEnable)
			{
				return;
			}
			if (this.LoadHandleId != 0)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.LoadHandleId);
				this.LoadHandleId = 0;
			}
			if (StringUtils.IsEmpty(this.IconPath))
			{
				using (List<SkillButtonDotIndicator>.Enumerator enumerator = this.DotViews.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						SkillButtonDotIndicator skillButtonDotIndicator = enumerator.Current;
						skillButtonDotIndicator.SetIconResource(null);
					}
					return;
				}
			}
			this.LoadHandleId = ResourceSystem.Instance.LoadAsync<UTexture>(this.IconPath, delegate([Nullable(2)] UTexture textureData, string _)
			{
				if (!this.IsEnable)
				{
					return;
				}
				if (this.IconPath != iconPath)
				{
					return;
				}
				foreach (SkillButtonDotIndicator skillButtonDotIndicator2 in this.DotViews)
				{
					skillButtonDotIndicator2.SetIconResource(textureData);
				}
			}, 100, "js_undefined");
		}

		// Token: 0x0603120C RID: 201228 RVA: 0x00DB7D8C File Offset: 0x00DB5F8C
		protected override void OnBeforeDestroy()
		{
			this.IsEnable = false;
			this.DotViews.Clear();
			if (this.LoadHandleId != 0)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.LoadHandleId);
				this.LoadHandleId = 0;
			}
		}

		// Token: 0x0401A097 RID: 106647
		private readonly List<SkillButtonDotIndicator> DotViews = new List<SkillButtonDotIndicator>();

		// Token: 0x0401A098 RID: 106648
		private string IconPath = "";

		// Token: 0x0401A099 RID: 106649
		private int LoadHandleId;

		// Token: 0x0401A09A RID: 106650
		private bool IsEnable;

		// Token: 0x0401A09B RID: 106651
		private bool IsActive;

		// Token: 0x0401A09C RID: 106652
		private int CurrentCount;

		// Token: 0x0200A941 RID: 43329
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x040344A8 RID: 214184
			Dot1,
			// Token: 0x040344A9 RID: 214185
			Dot2,
			// Token: 0x040344AA RID: 214186
			Dot3
		}
	}
}
