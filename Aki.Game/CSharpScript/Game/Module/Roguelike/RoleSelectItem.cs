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
	// Token: 0x02004E3E RID: 20030
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleSelectItem : GridProxyAbstract<RogueGainEntry>
	{
		// Token: 0x06033A37 RID: 211511 RVA: 0x00C15F9E File Offset: 0x00C1419E
		public override void Refresh(RogueGainEntry data, bool isSelected, int gridIndex)
		{
			this.Update(data);
		}

		// Token: 0x06033A38 RID: 211512 RVA: 0x00C15FA7 File Offset: 0x00C141A7
		public void Update(RogueGainEntry rogueGainEntry)
		{
			this.RogueGainEntry = rogueGainEntry;
			this.RefreshPanel();
		}

		// Token: 0x06033A39 RID: 211513 RVA: 0x00C15FB6 File Offset: 0x00C141B6
		public void SetLevelUpItem(bool bActive)
		{
			base.GetItem(7).SetUIActive(bActive);
		}

		// Token: 0x06033A3A RID: 211514 RVA: 0x00C15FC5 File Offset: 0x00C141C5
		public void SetSecondColorForAttrItem(HashSet<long> affixEntryId)
		{
			this.NewAffixEntryIdList = affixEntryId;
			this.RefreshAffixEntryList();
		}

		// Token: 0x06033A3B RID: 211515 RVA: 0x00C15FD4 File Offset: 0x00C141D4
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

		// Token: 0x06033A3C RID: 211516 RVA: 0x00C16206 File Offset: 0x00C14406
		protected override void OnStart()
		{
			this.RoleAttrLayout = new GenericLayout<RoleAttrItem, AffixEntry>(base.GetVerticalLayout(12), this.CreateRoleAttrItem, null, false, true);
		}

		// Token: 0x06033A3D RID: 211517 RVA: 0x00C16224 File Offset: 0x00C14424
		public void RefreshPanel()
		{
			this.RefreshRole();
			this.RefreshAffixEntryList();
			this.RefreshEmptyItem();
		}

		// Token: 0x06033A3E RID: 211518 RVA: 0x00C16238 File Offset: 0x00C14438
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

		// Token: 0x06033A3F RID: 211519 RVA: 0x00C1639C File Offset: 0x00C1459C
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

		// Token: 0x06033A40 RID: 211520 RVA: 0x00C163E4 File Offset: 0x00C145E4
		private void RefreshEmptyItem()
		{
			UUIItem item = base.GetItem(8);
			List<AffixEntry> affixEntryList = this.RogueGainEntry.AffixEntryList;
			item.SetUIActive(((affixEntryList != null) ? affixEntryList.Count : 0) <= 0);
		}

		// Token: 0x0401B624 RID: 112164
		private RogueGainEntry RogueGainEntry;

		// Token: 0x0401B625 RID: 112165
		private GenericLayout<RoleAttrItem, AffixEntry> RoleAttrLayout;

		// Token: 0x0401B626 RID: 112166
		private HashSet<long> NewAffixEntryIdList;

		// Token: 0x0401B627 RID: 112167
		private readonly Action DetailBtn = delegate()
		{
		};

		// Token: 0x0401B628 RID: 112168
		private readonly Func<RoleAttrItem> CreateRoleAttrItem = () => new RoleAttrItem();

		// Token: 0x0200AFF7 RID: 45047
		[NullableContext(0)]
		public static class ERoleSelectItemCom
		{
			// Token: 0x040356BE RID: 218814
			public const int QualityBgTexture = 0;

			// Token: 0x040356BF RID: 218815
			public const int RoleTexture = 1;

			// Token: 0x040356C0 RID: 218816
			public const int LineTexture = 2;

			// Token: 0x040356C1 RID: 218817
			public const int BorderSprite = 3;

			// Token: 0x040356C2 RID: 218818
			public const int RoleNameText = 4;

			// Token: 0x040356C3 RID: 218819
			public const int DetailBtn = 5;

			// Token: 0x040356C4 RID: 218820
			public const int AttrItem = 6;

			// Token: 0x040356C5 RID: 218821
			public const int LevelUpItem = 7;

			// Token: 0x040356C6 RID: 218822
			public const int EmptyItem = 8;

			// Token: 0x040356C7 RID: 218823
			public const int QualityNiagara = 9;

			// Token: 0x040356C8 RID: 218824
			public const int ViewportItem = 10;

			// Token: 0x040356C9 RID: 218825
			public const int ContentItem = 11;

			// Token: 0x040356CA RID: 218826
			public const int AttrLayout = 12;

			// Token: 0x040356CB RID: 218827
			public const int ScrollComponent = 13;
		}
	}
}
