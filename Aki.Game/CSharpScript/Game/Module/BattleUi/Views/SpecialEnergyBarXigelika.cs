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
	// Token: 0x02004DF0 RID: 19952
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarXigelika : SpecialEnergyBarBase
	{
		// Token: 0x06032304 RID: 205572 RVA: 0x00E10A28 File Offset: 0x00E0EC28
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

		// Token: 0x06032305 RID: 205573 RVA: 0x00E10AB4 File Offset: 0x00E0ECB4
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarXigelika.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarXigelika.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032306 RID: 205574 RVA: 0x00E10AF8 File Offset: 0x00E0ECF8
		protected UniTask InitBarItem1()
		{
			SpecialEnergyBarXigelika.<InitBarItem1>d__22 <InitBarItem1>d__;
			<InitBarItem1>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem1>d__.<>4__this = this;
			<InitBarItem1>d__.<>1__state = -1;
			<InitBarItem1>d__.<>t__builder.Start<SpecialEnergyBarXigelika.<InitBarItem1>d__22>(ref <InitBarItem1>d__);
			return <InitBarItem1>d__.<>t__builder.Task;
		}

		// Token: 0x06032307 RID: 205575 RVA: 0x00E10B3C File Offset: 0x00E0ED3C
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

		// Token: 0x06032308 RID: 205576 RVA: 0x00E10BA0 File Offset: 0x00E0EDA0
		private void UpdateTagState(bool[] arr, int[] tagIds)
		{
			for (int i = 0; i < tagIds.Length; i++)
			{
				arr[i] = this.TagComponent.HasTag(tagIds[i]);
			}
		}

		// Token: 0x06032309 RID: 205577 RVA: 0x00E10BCC File Offset: 0x00E0EDCC
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

		// Token: 0x0603230A RID: 205578 RVA: 0x00E10CB7 File Offset: 0x00E0EEB7
		private void RemoveNextFrameTimer()
		{
			if (this.NextFrameTimer != null && TimerSystem.GameplayTimeInstance.Has(this.NextFrameTimer))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.NextFrameTimer);
			}
			this.NextFrameTimer = null;
		}

		// Token: 0x0603230B RID: 205579 RVA: 0x00E10CEC File Offset: 0x00E0EEEC
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

		// Token: 0x0603230C RID: 205580 RVA: 0x00E10D4C File Offset: 0x00E0EF4C
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

		// Token: 0x0603230D RID: 205581 RVA: 0x00E10E72 File Offset: 0x00E0F072
		private void MarkPlayTwoFx(int tagId, bool tagExist)
		{
			if (!tagExist)
			{
				this.IsPlayTwoFx = true;
			}
		}

		// Token: 0x0603230E RID: 205582 RVA: 0x00E10E7E File Offset: 0x00E0F07E
		private void OnEnergyBxChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.RefreshIcons();
			this.RefreshHeads();
		}

		// Token: 0x0603230F RID: 205583 RVA: 0x00E10E8C File Offset: 0x00E0F08C
		private void OnEnergyCxChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.UpdateBarC();
		}

		// Token: 0x06032310 RID: 205584 RVA: 0x00E10E94 File Offset: 0x00E0F094
		private void OnRefreshIcons()
		{
			this.RefreshIcons();
			this.RefreshHeads();
		}

		// Token: 0x06032311 RID: 205585 RVA: 0x00E10EA2 File Offset: 0x00E0F0A2
		private void OnRefreshHeads()
		{
			this.RefreshIcons();
			this.RefreshHeads();
		}

		// Token: 0x06032312 RID: 205586 RVA: 0x00E10EB0 File Offset: 0x00E0F0B0
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

		// Token: 0x06032313 RID: 205587 RVA: 0x00E10F74 File Offset: 0x00E0F174
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

		// Token: 0x06032314 RID: 205588 RVA: 0x00E10FC4 File Offset: 0x00E0F1C4
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

		// Token: 0x06032315 RID: 205589 RVA: 0x00E11014 File Offset: 0x00E0F214
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

		// Token: 0x06032316 RID: 205590 RVA: 0x00E11224 File Offset: 0x00E0F424
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

		// Token: 0x06032317 RID: 205591 RVA: 0x00E113F9 File Offset: 0x00E0F5F9
		protected override void ClearAllTweenAnim()
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer != null)
			{
				tweenAnimPlayer.Clear(true);
			}
			base.ClearAllTweenAnim();
		}

		// Token: 0x06032318 RID: 205592 RVA: 0x00E11413 File Offset: 0x00E0F613
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

		// Token: 0x06032319 RID: 205593 RVA: 0x00E1142D File Offset: 0x00E0F62D
		protected override void OnBeforeDestroy()
		{
			this.RunneIconItems.Clear();
			this.RemoveNextFrameTimer();
			base.OnBeforeDestroy();
		}

		// Token: 0x0401A972 RID: 108914
		private const int BTN_E_CONFIG = 141201;

		// Token: 0x0401A973 RID: 108915
		private const EAttributeType ENERGY_B_ATTR_ID = EAttributeType.SpecialEnergy2;

		// Token: 0x0401A974 RID: 108916
		private const EAttributeType ENERGY_B_MAX_ATTR_ID = EAttributeType.SpecialEnergy2Max;

		// Token: 0x0401A975 RID: 108917
		private const EAttributeType ENERGY_C_ATTR_ID = EAttributeType.SpecialEnergy3;

		// Token: 0x0401A976 RID: 108918
		private const EAttributeType ENERGY_C_MAX_ATTR_ID = EAttributeType.SpecialEnergy3Max;

		// Token: 0x0401A977 RID: 108919
		[StaticVariableRuleIgnore]
		private static readonly int[] locTagA = new int[]
		{
			GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.A印记1"],
			GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.A印记2"],
			GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.A印记3"],
			GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.A印记4"]
		};

		// Token: 0x0401A978 RID: 108920
		[StaticVariableRuleIgnore]
		private static readonly int[] locTagB = new int[]
		{
			GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.B印记1"],
			GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.B印记2"],
			GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.B印记3"],
			GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.B印记4"]
		};

		// Token: 0x0401A979 RID: 108921
		[StaticVariableRuleIgnore]
		private static readonly int[] locUsedTagA = new int[]
		{
			GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.已使用A印记1"],
			GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.已使用A印记2"],
			GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.已使用A印记3"],
			GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.已使用A印记4"]
		};

		// Token: 0x0401A97A RID: 108922
		[StaticVariableRuleIgnore]
		private static readonly int[] locUsedTagB = new int[]
		{
			GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.已使用B印记1"],
			GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.已使用B印记2"],
			GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.已使用B印记3"],
			GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.已使用B印记4"]
		};

		// Token: 0x0401A97B RID: 108923
		[Nullable(2)]
		private SpecialEnergyBarXigelikaSlot BarSlot;

		// Token: 0x0401A97C RID: 108924
		private readonly bool[] RunneIconDataA = new bool[4];

		// Token: 0x0401A97D RID: 108925
		private readonly bool[] RunneIconDataB = new bool[4];

		// Token: 0x0401A97E RID: 108926
		private readonly int[] RunneIconState = new int[]
		{
			-1,
			-1,
			-1,
			-1
		};

		// Token: 0x0401A97F RID: 108927
		private readonly bool[] RunneHeadDataA = new bool[4];

		// Token: 0x0401A980 RID: 108928
		private readonly bool[] RunneHeadDataB = new bool[4];

		// Token: 0x0401A981 RID: 108929
		private readonly bool[] RunneHeadState = new bool[2];

		// Token: 0x0401A982 RID: 108930
		private readonly List<UUIItem> RunneIconItems = new List<UUIItem>();

		// Token: 0x0401A983 RID: 108931
		private readonly List<SpecialEnergyBarInfo> ConfigList = new List<SpecialEnergyBarInfo>();

		// Token: 0x0401A984 RID: 108932
		private int ValidHeadCount;

		// Token: 0x0401A985 RID: 108933
		private bool IsWaitingNextFrame;

		// Token: 0x0401A986 RID: 108934
		[Nullable(2)]
		private TimerHandle NextFrameTimer;

		// Token: 0x0401A987 RID: 108935
		private bool IsPlayTwoFx;

		// Token: 0x0401A988 RID: 108936
		private float LastPercentC;

		// Token: 0x0200AB7F RID: 43903
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x040350F9 RID: 217337
			Slot4,
			// Token: 0x040350FA RID: 217338
			RunneIconAS,
			// Token: 0x040350FB RID: 217339
			RunneIconAM,
			// Token: 0x040350FC RID: 217340
			RunneIconBS,
			// Token: 0x040350FD RID: 217341
			RunneIconBM,
			// Token: 0x040350FE RID: 217342
			RunneIconCS,
			// Token: 0x040350FF RID: 217343
			RunneIconCM,
			// Token: 0x04035100 RID: 217344
			RunneIconDS,
			// Token: 0x04035101 RID: 217345
			RunneIconDM,
			// Token: 0x04035102 RID: 217346
			BuffBar1,
			// Token: 0x04035103 RID: 217347
			BuffBar2,
			// Token: 0x04035104 RID: 217348
			BuffLightBar,
			// Token: 0x04035105 RID: 217349
			AniReset,
			// Token: 0x04035106 RID: 217350
			AniRuneA,
			// Token: 0x04035107 RID: 217351
			AniRuneB,
			// Token: 0x04035108 RID: 217352
			AniRuneC,
			// Token: 0x04035109 RID: 217353
			AniRuneD,
			// Token: 0x0403510A RID: 217354
			AniActiveA,
			// Token: 0x0403510B RID: 217355
			AniActiveB,
			// Token: 0x0403510C RID: 217356
			AniActiveC,
			// Token: 0x0403510D RID: 217357
			AniActiveD,
			// Token: 0x0403510E RID: 217358
			AniTransL,
			// Token: 0x0403510F RID: 217359
			AniTransR,
			// Token: 0x04035110 RID: 217360
			AniEnhance,
			// Token: 0x04035111 RID: 217361
			AniBarHLight,
			// Token: 0x04035112 RID: 217362
			PnlActiveBg,
			// Token: 0x04035113 RID: 217363
			SprFrameL,
			// Token: 0x04035114 RID: 217364
			SprFrameR,
			// Token: 0x04035115 RID: 217365
			MaxCount
		}
	}
}
