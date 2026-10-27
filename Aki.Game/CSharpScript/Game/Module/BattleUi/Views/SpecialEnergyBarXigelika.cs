using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E0B RID: 24075
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarXigelika : SpecialEnergyBarBase
	{
		// Token: 0x0603D375 RID: 250741 RVA: 0x00EBF4C8 File Offset: 0x00EBD6C8
		protected override void OnRegisterComponent()
		{
			Dictionary<int, Type> dictionary = new Dictionary<int, Type>
			{
				{
					9,
					typeof(UUISprite)
				},
				{
					10,
					typeof(UUISprite)
				},
				{
					11,
					typeof(UUISprite)
				}
			};
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>();
			for (int i = 0; i < 28; i++)
			{
				Type type;
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(i, dictionary.TryGetValue(i, out type) ? type : typeof(UUIItem)));
			}
		}

		// Token: 0x0603D376 RID: 250742 RVA: 0x00EBF554 File Offset: 0x00EBD754
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarXigelika.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarXigelika.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D377 RID: 250743 RVA: 0x00EBF598 File Offset: 0x00EBD798
		protected UniTask InitBarItem1()
		{
			SpecialEnergyBarXigelika.<InitBarItem1>d__22 <InitBarItem1>d__;
			<InitBarItem1>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem1>d__.<>4__this = this;
			<InitBarItem1>d__.<>1__state = -1;
			<InitBarItem1>d__.<>t__builder.Start<SpecialEnergyBarXigelika.<InitBarItem1>d__22>(ref <InitBarItem1>d__);
			return <InitBarItem1>d__.<>t__builder.Task;
		}

		// Token: 0x0603D378 RID: 250744 RVA: 0x00EBF5DC File Offset: 0x00EBD7DC
		private void SwitchBarButton()
		{
			if (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.信心值Max"]))
			{
				SpecialEnergyBarXigelikaSlot barSlot = this.BarSlot;
				if (barSlot == null)
				{
					return;
				}
				barSlot.SwitchKeyItem(this.ConfigList[1]);
				return;
			}
			else
			{
				SpecialEnergyBarXigelikaSlot barSlot2 = this.BarSlot;
				if (barSlot2 == null)
				{
					return;
				}
				barSlot2.SwitchKeyItem(this.ConfigList[0]);
				return;
			}
		}

		// Token: 0x0603D379 RID: 250745 RVA: 0x00EBF640 File Offset: 0x00EBD840
		private void UpdateTagState(bool[] arr, int[] tagIds)
		{
			for (int i = 0; i < tagIds.Length; i++)
			{
				arr[i] = this.TagComponent.HasTag(tagIds[i]);
			}
		}

		// Token: 0x0603D37A RID: 250746 RVA: 0x00EBF66C File Offset: 0x00EBD86C
		protected unsafe override void OnStart()
		{
			for (int i = 1; i <= 8; i++)
			{
				this.RunneIconItems.Add(base.GetItem(i));
			}
			for (int j = 12; j <= 24; j++)
			{
				base.InitTweenAnim(j);
			}
			this.UpdateTagState(this.RunneIconDataA, SpecialEnergyBarXigelika.locTagA);
			this.UpdateTagState(this.RunneIconDataB, SpecialEnergyBarXigelika.locTagB);
			this.UpdateTagState(this.RunneHeadDataA, SpecialEnergyBarXigelika.locUsedTagA);
			this.UpdateTagState(this.RunneHeadDataB, SpecialEnergyBarXigelika.locUsedTagB);
			this.RefreshIcons();
			this.RefreshHeads();
			this.UpdateBarC();
			if (this.PercentMachine.GetCurPercent() == 0f)
			{
				BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
				int num = 1;
				List<int> list = new List<int>(num);
				CollectionsMarshal.SetCount<int>(list, num);
				Span<int> span = CollectionsMarshal.AsSpan<int>(list);
				int index = 0;
				*span[index] = 23;
				tweenAnimPlayer.StopAllBut(list);
				this.TweenAnimPlayer.PlayTweenAnim(12);
			}
			this.SwitchBarButton();
		}

		// Token: 0x0603D37B RID: 250747 RVA: 0x00EBF757 File Offset: 0x00EBD957
		private void RemoveNextFrameTimer()
		{
			if (this.NextFrameTimer != null && TimerSystem.GameplayTimeInstance.Has(this.NextFrameTimer))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.NextFrameTimer);
			}
			this.NextFrameTimer = null;
		}

		// Token: 0x0603D37C RID: 250748 RVA: 0x00EBF78C File Offset: 0x00EBD98C
		private void BindCountTags(int[] tagIds, bool[] outResult, Action onChanged)
		{
			TTimerAction <>9__1;
			for (int i = 0; i < tagIds.Length; i++)
			{
				int index = i;
				base.ListenForTagAddOrRemoveChanged(tagIds[i], delegate(int tagId, bool exist)
				{
					outResult[index] = exist;
					if (!this.IsWaitingNextFrame)
					{
						this.IsWaitingNextFrame = true;
						SpecialEnergyBarXigelika <>4__this = this;
						TimerSystemInstance gameplayTimeInstance = TimerSystem.GameplayTimeInstance;
						TTimerAction action;
						if ((action = <>9__1) == null)
						{
							action = (<>9__1 = delegate(float delta)
							{
								this.IsWaitingNextFrame = false;
								this.RemoveNextFrameTimer();
								Action onChanged2 = onChanged;
								if (onChanged2 == null)
								{
									return;
								}
								onChanged2();
							});
						}
						<>4__this.NextFrameTimer = gameplayTimeInstance.Next(action, null, null);
					}
				});
			}
		}

		// Token: 0x0603D37D RID: 250749 RVA: 0x00EBF7EC File Offset: 0x00EBD9EC
		protected override void AddEvents()
		{
			base.AddEvents();
			this.BindCountTags(SpecialEnergyBarXigelika.locTagA, this.RunneIconDataA, new Action(this.OnRefreshIcons));
			this.BindCountTags(SpecialEnergyBarXigelika.locTagB, this.RunneIconDataB, new Action(this.OnRefreshIcons));
			this.BindCountTags(SpecialEnergyBarXigelika.locUsedTagA, this.RunneHeadDataA, new Action(this.OnRefreshHeads));
			this.BindCountTags(SpecialEnergyBarXigelika.locUsedTagB, this.RunneHeadDataB, new Action(this.OnRefreshHeads));
			base.ListenForAttributeChanged(EAttributeType.SpecialEnergy2, new Action<EAttributeType, float, float>(this.OnEnergyBxChanged));
			base.ListenForAttributeChanged(EAttributeType.SpecialEnergy3, new Action<EAttributeType, float, float>(this.OnEnergyCxChanged));
			base.ListenForAttributeChanged(EAttributeType.SpecialEnergy3Max, new Action<EAttributeType, float, float>(this.OnEnergyCxChanged));
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.信心值Max"], delegate(int tagId, bool exist)
			{
				this.SwitchBarButton();
				if (!exist)
				{
					BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
					if (tweenAnimPlayer == null)
					{
						return;
					}
					tweenAnimPlayer.PlayTweenAnim(23);
				}
			});
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.速读"], new BaseTagComponent.TTagSwitchedCallback(this.MarkPlayTwoFx));
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.复读"], new BaseTagComponent.TTagSwitchedCallback(this.MarkPlayTwoFx));
		}

		// Token: 0x0603D37E RID: 250750 RVA: 0x00EBF912 File Offset: 0x00EBDB12
		private void MarkPlayTwoFx(int tagId, bool tagExist)
		{
			if (!tagExist)
			{
				this.IsPlayTwoFx = true;
			}
		}

		// Token: 0x0603D37F RID: 250751 RVA: 0x00EBF91E File Offset: 0x00EBDB1E
		private void OnEnergyBxChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.RefreshIcons();
			this.RefreshHeads();
		}

		// Token: 0x0603D380 RID: 250752 RVA: 0x00EBF92C File Offset: 0x00EBDB2C
		private void OnEnergyCxChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.UpdateBarC();
		}

		// Token: 0x0603D381 RID: 250753 RVA: 0x00EBF934 File Offset: 0x00EBDB34
		private void OnRefreshIcons()
		{
			this.RefreshIcons();
			this.RefreshHeads();
		}

		// Token: 0x0603D382 RID: 250754 RVA: 0x00EBF942 File Offset: 0x00EBDB42
		private void OnRefreshHeads()
		{
			this.RefreshIcons();
			this.RefreshHeads();
		}

		// Token: 0x0603D383 RID: 250755 RVA: 0x00EBF950 File Offset: 0x00EBDB50
		private void UpdateBarC()
		{
			float energyPercentC = this.GetEnergyPercentC();
			bool flag = energyPercentC <= 0.5f;
			float fillAmount = flag ? (energyPercentC * 2f) : ((energyPercentC - 0.5f) * 2f);
			base.GetSprite(10).SetUIActive(!flag);
			if (flag)
			{
				base.GetSprite(9).SetFillAmount(fillAmount);
			}
			else
			{
				base.GetSprite(9).SetFillAmount(1f);
				base.GetSprite(10).SetFillAmount(fillAmount);
			}
			if (((double)energyPercentC < 0.5 && (double)this.LastPercentC == 0.5) || (energyPercentC < 1f && this.LastPercentC >= 1f))
			{
				base.PlayTweenAnim(24);
			}
			this.LastPercentC = energyPercentC;
		}

		// Token: 0x0603D384 RID: 250756 RVA: 0x00EBFA14 File Offset: 0x00EBDC14
		private float GetEnergyPercentB()
		{
			BaseAttributeComponent attributeComponent = this.AttributeComponent;
			float num = (attributeComponent != null) ? attributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy2) : 0f;
			BaseAttributeComponent attributeComponent2 = this.AttributeComponent;
			float num2 = (attributeComponent2 != null) ? attributeComponent2.GetCurrentValue(EAttributeType.SpecialEnergy2Max) : 0f;
			if (num2 <= 0f)
			{
				return 0f;
			}
			return num / num2;
		}

		// Token: 0x0603D385 RID: 250757 RVA: 0x00EBFA64 File Offset: 0x00EBDC64
		private float GetEnergyPercentC()
		{
			BaseAttributeComponent attributeComponent = this.AttributeComponent;
			float num = (attributeComponent != null) ? attributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy3) : 0f;
			BaseAttributeComponent attributeComponent2 = this.AttributeComponent;
			float num2 = (attributeComponent2 != null) ? attributeComponent2.GetCurrentValue(EAttributeType.SpecialEnergy3Max) : 0f;
			if (num2 <= 0f)
			{
				return 0f;
			}
			return num / num2;
		}

		// Token: 0x0603D386 RID: 250758 RVA: 0x00EBFAB4 File Offset: 0x00EBDCB4
		private void RefreshIcons()
		{
			bool[] runneIconDataA = this.RunneIconDataA;
			bool[] runneIconDataB = this.RunneIconDataB;
			bool[] runneHeadDataA = this.RunneHeadDataA;
			bool[] runneHeadDataB = this.RunneHeadDataB;
			bool flag = (runneIconDataA[0] || runneIconDataB[0]) && (runneIconDataA[1] || runneIconDataB[1]);
			bool flag2 = (runneIconDataA[2] || runneIconDataB[2]) && (runneIconDataA[3] || runneIconDataB[3]);
			bool flag3 = false;
			for (int i = 0; i < 4; i++)
			{
				int num = this.RunneIconState[i];
				int num2 = runneIconDataA[i] ? 0 : (runneIconDataB[i] ? 1 : -1);
				if ((i <= 1 && flag) || (i > 1 && flag2))
				{
					num2 += 2;
				}
				if (runneHeadDataA[i])
				{
					num2 = 4;
				}
				else if (runneHeadDataB[i])
				{
					num2 = 5;
				}
				if (num2 >= 0)
				{
					this.RunneIconItems[i * 2].SetUIActive(num2 % 2 == 0);
					this.RunneIconItems[i * 2 + 1].SetUIActive(num2 % 2 == 1);
					if (num < 0 && 0 <= num2 && num2 < 2)
					{
						BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
						if (tweenAnimPlayer != null)
						{
							tweenAnimPlayer.PlayTweenAnim(13 + i);
						}
					}
					bool flag4 = num != num2 && ((i == 0 && !flag) || (i == 2 && !flag2));
					bool flag5 = num != num2 && num < 2 && ((i == 0 && flag) || (i == 2 && flag2));
					bool flag6 = num != num2 && i % 2 == 0;
					bool flag7 = num != num2 && i % 2 == 1;
					bool flag8 = flag4 || flag5 || flag7 || flag3 || this.IsPlayTwoFx;
					flag3 = flag6;
					if (flag8 && num2 >= 2 && num2 <= 3)
					{
						BattleUiTweenAnimPlayer tweenAnimPlayer2 = this.TweenAnimPlayer;
						if (tweenAnimPlayer2 != null)
						{
							tweenAnimPlayer2.PlayTweenAnim(17 + i);
						}
					}
				}
				else
				{
					this.RunneIconItems[i * 2].SetUIActive(false);
					this.RunneIconItems[i * 2 + 1].SetUIActive(false);
				}
				this.RunneIconState[i] = num2;
			}
			this.IsPlayTwoFx = false;
		}

		// Token: 0x0603D387 RID: 250759 RVA: 0x00EBFCC4 File Offset: 0x00EBDEC4
		private unsafe void RefreshHeads()
		{
			bool[] runneHeadDataA = this.RunneHeadDataA;
			bool[] runneHeadDataB = this.RunneHeadDataB;
			int num = 0;
			for (int i = 0; i < 4; i++)
			{
				if (runneHeadDataA[i] && runneHeadDataB[i])
				{
					Log.Instance.Warn(ELogModule.Battle, ELogAuthor.HWR, "西格莉卡能量条 日月灵都是已用状态", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				num += ((runneHeadDataA[i] || runneHeadDataB[i]) ? 1 : 0);
				SpecialEnergyBarXigelikaSlot barSlot = this.BarSlot;
				if (barSlot != null)
				{
					barSlot.SetSegmentVisible(i, !runneHeadDataA[i] && !runneHeadDataB[i]);
				}
			}
			float energyPercentB = this.GetEnergyPercentB();
			bool flag = (runneHeadDataA[0] || runneHeadDataB[0]) && (runneHeadDataA[1] || runneHeadDataB[1]) && energyPercentB >= 0.5f;
			bool flag2 = (runneHeadDataA[2] || runneHeadDataB[2]) && (runneHeadDataA[3] || runneHeadDataB[3]) && energyPercentB >= 1f;
			if (flag)
			{
				if (!this.RunneHeadState[0])
				{
					BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
					if (tweenAnimPlayer != null)
					{
						tweenAnimPlayer.PlayTweenAnim(21);
					}
					this.RunneHeadState[0] = true;
				}
			}
			else
			{
				this.RunneHeadState[0] = false;
			}
			if (flag2)
			{
				if (!this.RunneHeadState[1])
				{
					BattleUiTweenAnimPlayer tweenAnimPlayer2 = this.TweenAnimPlayer;
					if (tweenAnimPlayer2 != null)
					{
						tweenAnimPlayer2.PlayTweenAnim(22);
					}
					this.RunneHeadState[1] = true;
				}
			}
			else
			{
				this.RunneHeadState[1] = false;
			}
			base.GetItem(25).SetUIActive(flag || flag2);
			base.GetItem(26).SetUIActive(flag);
			base.GetItem(27).SetUIActive(flag2);
			if (num == 0 && this.ValidHeadCount > 0)
			{
				BattleUiTweenAnimPlayer tweenAnimPlayer3 = this.TweenAnimPlayer;
				if (tweenAnimPlayer3 != null)
				{
					int num2 = 1;
					List<int> list = new List<int>(num2);
					CollectionsMarshal.SetCount<int>(list, num2);
					Span<int> span = CollectionsMarshal.AsSpan<int>(list);
					int index = 0;
					*span[index] = 23;
					tweenAnimPlayer3.StopAllBut(list);
				}
				BattleUiTweenAnimPlayer tweenAnimPlayer4 = this.TweenAnimPlayer;
				if (tweenAnimPlayer4 != null)
				{
					tweenAnimPlayer4.PlayTweenAnim(12);
				}
			}
			this.ValidHeadCount = num;
		}

		// Token: 0x0603D388 RID: 250760 RVA: 0x00EBFE99 File Offset: 0x00EBE099
		protected override void ClearAllTweenAnim()
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer != null)
			{
				tweenAnimPlayer.Clear(true);
			}
			base.ClearAllTweenAnim();
		}

		// Token: 0x0603D389 RID: 250761 RVA: 0x00EBFEB3 File Offset: 0x00EBE0B3
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarXigelikaSlot barSlot = this.BarSlot;
			if (barSlot == null)
			{
				return;
			}
			barSlot.Tick(delta);
		}

		// Token: 0x0603D38A RID: 250762 RVA: 0x00EBFECD File Offset: 0x00EBE0CD
		protected override void OnBeforeDestroy()
		{
			this.RunneIconItems.Clear();
			this.RemoveNextFrameTimer();
			base.OnBeforeDestroy();
		}

		// Token: 0x0401FEAB RID: 130731
		private const int BTN_E_CONFIG = 141201;

		// Token: 0x0401FEAC RID: 130732
		private const EAttributeType ENERGY_B_ATTR_ID = EAttributeType.SpecialEnergy2;

		// Token: 0x0401FEAD RID: 130733
		private const EAttributeType ENERGY_B_MAX_ATTR_ID = EAttributeType.SpecialEnergy2Max;

		// Token: 0x0401FEAE RID: 130734
		private const EAttributeType ENERGY_C_ATTR_ID = EAttributeType.SpecialEnergy3;

		// Token: 0x0401FEAF RID: 130735
		private const EAttributeType ENERGY_C_MAX_ATTR_ID = EAttributeType.SpecialEnergy3Max;

		// Token: 0x0401FEB0 RID: 130736
		[StaticVariableRuleIgnore]
		private static readonly int[] locTagA = new int[]
		{
			GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.A印记1"],
			GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.A印记2"],
			GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.A印记3"],
			GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.A印记4"]
		};

		// Token: 0x0401FEB1 RID: 130737
		[StaticVariableRuleIgnore]
		private static readonly int[] locTagB = new int[]
		{
			GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.B印记1"],
			GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.B印记2"],
			GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.B印记3"],
			GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.B印记4"]
		};

		// Token: 0x0401FEB2 RID: 130738
		[StaticVariableRuleIgnore]
		private static readonly int[] locUsedTagA = new int[]
		{
			GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.已使用A印记1"],
			GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.已使用A印记2"],
			GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.已使用A印记3"],
			GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.已使用A印记4"]
		};

		// Token: 0x0401FEB3 RID: 130739
		[StaticVariableRuleIgnore]
		private static readonly int[] locUsedTagB = new int[]
		{
			GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.已使用B印记1"],
			GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.已使用B印记2"],
			GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.已使用B印记3"],
			GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.已使用B印记4"]
		};

		// Token: 0x0401FEB4 RID: 130740
		[Nullable(2)]
		private SpecialEnergyBarXigelikaSlot BarSlot;

		// Token: 0x0401FEB5 RID: 130741
		private readonly bool[] RunneIconDataA = new bool[4];

		// Token: 0x0401FEB6 RID: 130742
		private readonly bool[] RunneIconDataB = new bool[4];

		// Token: 0x0401FEB7 RID: 130743
		private readonly int[] RunneIconState = new int[]
		{
			-1,
			-1,
			-1,
			-1
		};

		// Token: 0x0401FEB8 RID: 130744
		private readonly bool[] RunneHeadDataA = new bool[4];

		// Token: 0x0401FEB9 RID: 130745
		private readonly bool[] RunneHeadDataB = new bool[4];

		// Token: 0x0401FEBA RID: 130746
		private readonly bool[] RunneHeadState = new bool[2];

		// Token: 0x0401FEBB RID: 130747
		private readonly List<UUIItem> RunneIconItems = new List<UUIItem>();

		// Token: 0x0401FEBC RID: 130748
		private readonly List<SpecialEnergyBarInfo> ConfigList = new List<SpecialEnergyBarInfo>();

		// Token: 0x0401FEBD RID: 130749
		private int ValidHeadCount;

		// Token: 0x0401FEBE RID: 130750
		private bool IsWaitingNextFrame;

		// Token: 0x0401FEBF RID: 130751
		[Nullable(2)]
		private TimerHandle NextFrameTimer;

		// Token: 0x0401FEC0 RID: 130752
		private bool IsPlayTwoFx;

		// Token: 0x0401FEC1 RID: 130753
		private float LastPercentC;

		// Token: 0x0200C170 RID: 49520
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A707 RID: 239367
			Slot4,
			// Token: 0x0403A708 RID: 239368
			RunneIconAS,
			// Token: 0x0403A709 RID: 239369
			RunneIconAM,
			// Token: 0x0403A70A RID: 239370
			RunneIconBS,
			// Token: 0x0403A70B RID: 239371
			RunneIconBM,
			// Token: 0x0403A70C RID: 239372
			RunneIconCS,
			// Token: 0x0403A70D RID: 239373
			RunneIconCM,
			// Token: 0x0403A70E RID: 239374
			RunneIconDS,
			// Token: 0x0403A70F RID: 239375
			RunneIconDM,
			// Token: 0x0403A710 RID: 239376
			BuffBar1,
			// Token: 0x0403A711 RID: 239377
			BuffBar2,
			// Token: 0x0403A712 RID: 239378
			BuffLightBar,
			// Token: 0x0403A713 RID: 239379
			AniReset,
			// Token: 0x0403A714 RID: 239380
			AniRuneA,
			// Token: 0x0403A715 RID: 239381
			AniRuneB,
			// Token: 0x0403A716 RID: 239382
			AniRuneC,
			// Token: 0x0403A717 RID: 239383
			AniRuneD,
			// Token: 0x0403A718 RID: 239384
			AniActiveA,
			// Token: 0x0403A719 RID: 239385
			AniActiveB,
			// Token: 0x0403A71A RID: 239386
			AniActiveC,
			// Token: 0x0403A71B RID: 239387
			AniActiveD,
			// Token: 0x0403A71C RID: 239388
			AniTransL,
			// Token: 0x0403A71D RID: 239389
			AniTransR,
			// Token: 0x0403A71E RID: 239390
			AniEnhance,
			// Token: 0x0403A71F RID: 239391
			AniBarHLight,
			// Token: 0x0403A720 RID: 239392
			PnlActiveBg,
			// Token: 0x0403A721 RID: 239393
			SprFrameL,
			// Token: 0x0403A722 RID: 239394
			SprFrameR,
			// Token: 0x0403A723 RID: 239395
			MaxCount
		}
	}
}
