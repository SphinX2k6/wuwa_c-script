using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E43 RID: 24131
	public class TopBuffItemBuLing : TopBuffItem
	{
		// Token: 0x0603D5BF RID: 251327 RVA: 0x00ECACE8 File Offset: 0x00EC8EE8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603D5C0 RID: 251328 RVA: 0x00ECAE3C File Offset: 0x00EC903C
		protected override void OnStart()
		{
			base.InitTweenAnim(1);
			base.InitTweenAnim(2);
			base.InitTweenAnim(3);
			base.InitTweenAnim(4);
			base.InitTweenAnim(5);
			base.InitTweenAnim(6);
			base.GetItem(8).SetUIActive(false);
			base.GetItem(7).SetUIActive(false);
		}

		// Token: 0x0603D5C1 RID: 251329 RVA: 0x00ECAE90 File Offset: 0x00EC9090
		public void Refresh(int id, int state, int usedType, bool playAnim = false)
		{
			if (this.CurId != id)
			{
				if (id == 0)
				{
					if (this.CurState == 1)
					{
						if (usedType == 1)
						{
							this.PlayTweenAnimOnly(4);
						}
						else if (usedType == 2)
						{
							this.PlayTweenAnimOnly(3);
						}
					}
					else
					{
						this.PlayTweenAnimOnly(5);
					}
				}
				else
				{
					if (this.CurId == 0)
					{
						this.PlayTweenAnimOnly(1);
					}
					base.GetItem(8).SetUIActive(id == 1);
					base.GetItem(7).SetUIActive(id == 2);
				}
				this.CurId = id;
			}
			if (this.CurState != state)
			{
				if (this.CurState != 1 && state == 1)
				{
					base.StopTweenAnim(6);
					base.PlayTweenAnim(2);
				}
				else if (this.CurState == 1 && state != 1)
				{
					base.StopTweenAnim(2);
					base.PlayTweenAnim(6);
				}
				this.CurState = state;
			}
			if (id == 0)
			{
				if (this.HideTime == 0.0)
				{
					if (playAnim)
					{
						this.HideTime = Time.Instance.Now + 500.0;
						return;
					}
					base.SetVisible(1, false);
				}
				return;
			}
			this.HideTime = 0.0;
			base.SetVisible(1, true);
			int num = (id - 1) * 2 + ((state == 1) ? 1 : 0);
			if (this.IconIndex == num)
			{
				return;
			}
			this.IconIndex = num;
			string resourceId;
			if (!TopBuffItemBuLing.IconList.TryGetValue(num, out resourceId))
			{
				return;
			}
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			this.SetIcon(resourcePath);
		}

		// Token: 0x0603D5C2 RID: 251330 RVA: 0x00ECAFE5 File Offset: 0x00EC91E5
		[NullableContext(2)]
		public void SetIcon(string iconPath)
		{
			base.GetTexture(0).SetUIActive(false);
			if (string.IsNullOrEmpty(iconPath))
			{
				return;
			}
			this.LoadIconId = ResourceSystem.Instance.LoadAsync<UTexture>(iconPath, delegate([Nullable(2)] UTexture skillIconTexture, string _)
			{
				this.LoadIconId = -1;
				if (skillIconTexture == null)
				{
					return;
				}
				UUITexture texture = base.GetTexture(0);
				if (texture == null)
				{
					return;
				}
				texture.SetUIActive(true);
				texture.SetTexture(skillIconTexture);
			}, 103, "js_undefined");
		}

		// Token: 0x0603D5C3 RID: 251331 RVA: 0x00ECB021 File Offset: 0x00EC9221
		protected override void OnBeforeDestroyImplement()
		{
			base.OnBeforeDestroyImplement();
			if (this.LoadIconId != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.LoadIconId);
				this.LoadIconId = -1;
			}
		}

		// Token: 0x0603D5C4 RID: 251332 RVA: 0x00ECB049 File Offset: 0x00EC9249
		protected void PlayTweenAnimOnly(int componentType)
		{
			if (this.LastAni >= 0)
			{
				base.StopTweenAnim(this.LastAni);
			}
			this.LastAni = componentType;
			base.PlayTweenAnim(componentType);
		}

		// Token: 0x0603D5C5 RID: 251333 RVA: 0x00ECB06E File Offset: 0x00EC926E
		public void TickHiding(float delta)
		{
			if (this.HideTime <= 0.0)
			{
				return;
			}
			if (this.HideTime > Time.Instance.Now)
			{
				return;
			}
			base.SetVisible(1, false);
			this.HideTime = 0.0;
		}

		// Token: 0x0402000F RID: 131087
		private const double HIDE_ANIM_TIME = 500.0;

		// Token: 0x04020010 RID: 131088
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly string[] IconList = new string[]
		{
			"T_BulingBuffBlueNor",
			"T_BulingBuffBlueA",
			"T_BulingBuffOrangeNor",
			"T_BulingBuffOrangeA"
		};

		// Token: 0x04020011 RID: 131089
		private int IconIndex;

		// Token: 0x04020012 RID: 131090
		private int CurId;

		// Token: 0x04020013 RID: 131091
		private int CurState;

		// Token: 0x04020014 RID: 131092
		private int LastAni = -1;

		// Token: 0x04020015 RID: 131093
		private int LoadIconId;

		// Token: 0x04020016 RID: 131094
		private double HideTime;

		// Token: 0x0200C1C2 RID: 49602
		private enum EChildType
		{
			// Token: 0x0403A8D5 RID: 239829
			IconTexture,
			// Token: 0x0403A8D6 RID: 239830
			AniIn,
			// Token: 0x0403A8D7 RID: 239831
			AniUsable,
			// Token: 0x0403A8D8 RID: 239832
			AniUsedRight,
			// Token: 0x0403A8D9 RID: 239833
			AniUsedLeft,
			// Token: 0x0403A8DA RID: 239834
			AniPunish,
			// Token: 0x0403A8DB RID: 239835
			AniUsableOut,
			// Token: 0x0403A8DC RID: 239836
			OrangeNode,
			// Token: 0x0403A8DD RID: 239837
			BlueNode
		}
	}
}
