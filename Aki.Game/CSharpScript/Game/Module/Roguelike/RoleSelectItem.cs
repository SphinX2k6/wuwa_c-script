using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003E07 RID: 15879
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleSelectItem : GridProxyAbstract<RogueGainEntry>
	{
		// Token: 0x060288A2 RID: 166050 RVA: 0x00B5F4C6 File Offset: 0x00B5D6C6
		public override void Refresh(RogueGainEntry data, bool isSelected, int gridIndex)
		{
			this.Update(data);
		}

		// Token: 0x060288A3 RID: 166051 RVA: 0x00B5F4CF File Offset: 0x00B5D6CF
		public void Update(RogueGainEntry rogueGainEntry)
		{
			this.RogueGainEntry = rogueGainEntry;
			this.RefreshPanel();
		}

		// Token: 0x060288A4 RID: 166052 RVA: 0x00B5F4DE File Offset: 0x00B5D6DE
		public void SetLevelUpItem(bool bActive)
		{
			base.GetItem(7).SetUIActive(bActive);
		}

		// Token: 0x060288A5 RID: 166053 RVA: 0x00B5F4ED File Offset: 0x00B5D6ED
		public void SetSecondColorForAttrItem(HashSet<long> affixEntryId)
		{
			this.NewAffixEntryIdList = affixEntryId;
			this.RefreshAffixEntryList();
		}

		// Token: 0x060288A6 RID: 166054 RVA: 0x00B5F4FC File Offset: 0x00B5D6FC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 14;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIScrollViewWithScrollbarComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(5, this.DetailBtn);
			this.BtnBindInfo = list2;
		}

		// Token: 0x060288A7 RID: 166055 RVA: 0x00B5F72E File Offset: 0x00B5D92E
		protected override void OnStart()
		{
			this.RoleAttrLayout = new GenericLayout<RoleAttrItem, AffixEntry>(base.GetVerticalLayout(12), this.CreateRoleAttrItem, null, false, true);
		}

		// Token: 0x060288A8 RID: 166056 RVA: 0x00B5F74C File Offset: 0x00B5D94C
		public void RefreshPanel()
		{
			this.RefreshRole();
			this.RefreshAffixEntryList();
			this.RefreshEmptyItem();
		}

		// Token: 0x060288A9 RID: 166057 RVA: 0x00B5F760 File Offset: 0x00B5D960
		private void RefreshRole()
		{
			if (RoguelikeConfig.Instance.GetRogueCharacterConfig(this.RogueGainEntry.ConfigId) == null)
			{
				return;
			}
			int num = Math.Min(5, this.RogueGainEntry.AffixEntryList.Count + 1);
			QualityInfo? qualityConfig = ItemConfig.Instance.GetQualityConfig(num);
			RogueQualityConfig? rogueQualityConfigByQualityId = RoguelikeConfig.Instance.GetRogueQualityConfigByQualityId(num);
			if (qualityConfig != null)
			{
				FColor color = FColor.FromHex(qualityConfig.Value.DropColor);
				base.GetTexture(0).SetColor(color);
				base.GetTexture(2).SetColor(color);
				base.GetSprite(3).SetColor(color);
			}
			if (rogueQualityConfigByQualityId != null)
			{
				FColor fcolor = FColor.FromHex(rogueQualityConfigByQualityId.Value.RoleNiagaraColor);
				FLinearColor value = new FLinearColor(ref fcolor);
				base.GetUiNiagara(9).SetNiagaraVarLinearColor("Color", value);
			}
			RoleDataBase roguelikeRoleData = RoguelikeModel.Instance.GetRoguelikeRoleData(this.RogueGainEntry.ConfigId);
			RoleInfo roleConfig = roguelikeRoleData.GetRoleConfig();
			base.GetText(4).ShowTextNew(roleConfig.Name);
			string formationRoleCard = roleConfig.FormationRoleCard;
			int roleSkinId = roguelikeRoleData.GetRoleSkinId();
			if (roleSkinId != -1)
			{
				formationRoleCard = SkinConfig.Instance.GetRoleSkinConfig(roleSkinId).Value.FormationRoleCard;
			}
			base.SetTextureByPath(formationRoleCard, base.GetTexture(1), null, null);
		}

		// Token: 0x060288AA RID: 166058 RVA: 0x00B5F8C4 File Offset: 0x00B5DAC4
		private void RefreshAffixEntryList()
		{
			this.RoleAttrLayout.RefreshByDataAsync(this.RogueGainEntry.AffixEntryList ?? new List<AffixEntry>(), false, null).ContinueWith(delegate()
			{
				if (this.NewAffixEntryIdList == null)
				{
					return;
				}
				RoleAttrItem lastRoleAttrItem = null;
				foreach (RoleAttrItem roleAttrItem in this.RoleAttrLayout.GetLayoutItemList())
				{
					HashSet<long> newAffixEntryIdList = this.NewAffixEntryIdList;
					if (newAffixEntryIdList != null && newAffixEntryIdList.Contains((long)roleAttrItem.AffixEntry.Id.Value))
					{
						roleAttrItem.SetSecondColor();
						roleAttrItem.RefreshPanel();
						lastRoleAttrItem = roleAttrItem;
					}
				}
				if (lastRoleAttrItem != null)
				{
					UUIScrollViewWithScrollbarComponent scrollView = base.GetScrollViewWithScrollbar(13);
					int count = 0;
					scrollView.OnLateUpdate.Bind(delegate(float deltaTime)
					{
						int count = count;
						count++;
						if (count == 2)
						{
							float height = lastRoleAttrItem.GetRootItem().GetHeight();
							float height2 = scrollView.GetViewport().GetUIItem().GetHeight();
							float height3 = scrollView.ContentUIItem.Get().GetHeight();
							float num;
							if (height > height2)
							{
								num = height3 - height2 * (float)((int)Math.Floor((double)(height / height2))) - height % height2 - 10f;
							}
							else
							{
								num = height3 - height2;
							}
							num = Math.Max(num, 0f);
							scrollView.ContentUIItem.Get().SetAnchorOffsetY(num);
							scrollView.OnLateUpdate.Unbind();
						}
					});
				}
			});
		}

		// Token: 0x060288AB RID: 166059 RVA: 0x00B5F90C File Offset: 0x00B5DB0C
		private void RefreshEmptyItem()
		{
			UUIItem item = base.GetItem(8);
			List<AffixEntry> affixEntryList = this.RogueGainEntry.AffixEntryList;
			item.SetUIActive(((affixEntryList != null) ? affixEntryList.Count : 0) <= 0);
		}

		// Token: 0x04015FF7 RID: 90103
		private RogueGainEntry RogueGainEntry;

		// Token: 0x04015FF8 RID: 90104
		private GenericLayout<RoleAttrItem, AffixEntry> RoleAttrLayout;

		// Token: 0x04015FF9 RID: 90105
		private HashSet<long> NewAffixEntryIdList;

		// Token: 0x04015FFA RID: 90106
		private readonly Action DetailBtn = delegate()
		{
		};

		// Token: 0x04015FFB RID: 90107
		private readonly Func<RoleAttrItem> CreateRoleAttrItem = () => new RoleAttrItem();

		// Token: 0x02009A29 RID: 39465
		[NullableContext(0)]
		public static class ERoleSelectItemCom
		{
			// Token: 0x040300EE RID: 196846
			public const int QualityBgTexture = 0;

			// Token: 0x040300EF RID: 196847
			public const int RoleTexture = 1;

			// Token: 0x040300F0 RID: 196848
			public const int LineTexture = 2;

			// Token: 0x040300F1 RID: 196849
			public const int BorderSprite = 3;

			// Token: 0x040300F2 RID: 196850
			public const int RoleNameText = 4;

			// Token: 0x040300F3 RID: 196851
			public const int DetailBtn = 5;

			// Token: 0x040300F4 RID: 196852
			public const int AttrItem = 6;

			// Token: 0x040300F5 RID: 196853
			public const int LevelUpItem = 7;

			// Token: 0x040300F6 RID: 196854
			public const int EmptyItem = 8;

			// Token: 0x040300F7 RID: 196855
			public const int QualityNiagara = 9;

			// Token: 0x040300F8 RID: 196856
			public const int ViewportItem = 10;

			// Token: 0x040300F9 RID: 196857
			public const int ContentItem = 11;

			// Token: 0x040300FA RID: 196858
			public const int AttrLayout = 12;

			// Token: 0x040300FB RID: 196859
			public const int ScrollComponent = 13;
		}
	}
}
