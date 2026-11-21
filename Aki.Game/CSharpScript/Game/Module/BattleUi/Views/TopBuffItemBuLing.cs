using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E28 RID: 20008
	public class TopBuffItemBuLing : TopBuffItem
	{
		// Token: 0x0603254F RID: 206159 RVA: 0x00E1C254 File Offset: 0x00E1A454
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

		// Token: 0x06032550 RID: 206160 RVA: 0x00E1C3A8 File Offset: 0x00E1A5A8
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

		// Token: 0x06032551 RID: 206161 RVA: 0x00E1C3FC File Offset: 0x00E1A5FC
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

		// Token: 0x06032552 RID: 206162 RVA: 0x00E1C551 File Offset: 0x00E1A751
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

		// Token: 0x06032553 RID: 206163 RVA: 0x00E1C58D File Offset: 0x00E1A78D
		protected override void OnBeforeDestroyImplement()
		{
			base.OnBeforeDestroyImplement();
			if (this.LoadIconId != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.LoadIconId);
				this.LoadIconId = -1;
			}
		}

		// Token: 0x06032554 RID: 206164 RVA: 0x00E1C5B5 File Offset: 0x00E1A7B5
		protected void PlayTweenAnimOnly(int componentType)
		{
			if (this.LastAni >= 0)
			{
				base.StopTweenAnim(this.LastAni);
			}
			this.LastAni = componentType;
			base.PlayTweenAnim(componentType);
		}

		// Token: 0x06032555 RID: 206165 RVA: 0x00E1C5DA File Offset: 0x00E1A7DA
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

		// Token: 0x0401AAD6 RID: 109270
		private const double HIDE_ANIM_TIME = 500.0;

		// Token: 0x0401AAD7 RID: 109271
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly string[] IconList = new string[]
		{
			"T_BulingBuffBlueNor",
			"T_BulingBuffBlueA",
			"T_BulingBuffOrangeNor",
			"T_BulingBuffOrangeA"
		};

		// Token: 0x0401AAD8 RID: 109272
		private int IconIndex;

		// Token: 0x0401AAD9 RID: 109273
		private int CurId;

		// Token: 0x0401AADA RID: 109274
		private int CurState;

		// Token: 0x0401AADB RID: 109275
		private int LastAni = -1;

		// Token: 0x0401AADC RID: 109276
		private int LoadIconId;

		// Token: 0x0401AADD RID: 109277
		private double HideTime;

		// Token: 0x0200ABD1 RID: 43985
		private enum EChildType
		{
			// Token: 0x040352C7 RID: 217799
			IconTexture,
			// Token: 0x040352C8 RID: 217800
			AniIn,
			// Token: 0x040352C9 RID: 217801
			AniUsable,
			// Token: 0x040352CA RID: 217802
			AniUsedRight,
			// Token: 0x040352CB RID: 217803
			AniUsedLeft,
			// Token: 0x040352CC RID: 217804
			AniPunish,
			// Token: 0x040352CD RID: 217805
			AniUsableOut,
			// Token: 0x040352CE RID: 217806
			OrangeNode,
			// Token: 0x040352CF RID: 217807
			BlueNode
		}
	}
}
