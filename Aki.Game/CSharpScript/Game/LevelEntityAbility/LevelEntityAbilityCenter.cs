using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.ElementalCasket;
using CSharpScript.Game.NewWorld.Player.Ability;

namespace CSharpScript.Game.LevelEntityAbility
{
	// Token: 0x02006FB1 RID: 28593
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEntityAbilityCenter : Singleton
	{
		// Token: 0x060457CD RID: 284621 RVA: 0x0113CB71 File Offset: 0x0113AD71
		public void Init()
		{
			this.RegisterAllAbility();
		}

		// Token: 0x060457CE RID: 284622 RVA: 0x0113CB79 File Offset: 0x0113AD79
		public void Clear()
		{
			this.Registrations.Clear();
			this.BlockTagToAbilities.Clear();
		}

		// Token: 0x060457CF RID: 284623 RVA: 0x0113CB94 File Offset: 0x0113AD94
		private void RegisterAllAbility()
		{
			this.Register<PlayerElementalFieldAbility>(ELevelEntityAbilityType.PlayerElementalField, (ELevelEntityAbilityType type, EAbilityTickPhase tickPhase, int tickOrder, bool needTickActivate) => new PlayerElementalFieldAbility(type, tickPhase, tickOrder, needTickActivate), new LevelAbilityConfig
			{
				NeedTickActivate = new bool?(true)
			});
			this.Register<PlayerElementalFieldEffectAbility>(ELevelEntityAbilityType.PlayerElementalFieldEffect, (ELevelEntityAbilityType type, EAbilityTickPhase tickPhase, int tickOrder, bool needTickActivate) => new PlayerElementalFieldEffectAbility(type, tickPhase, tickOrder, needTickActivate), new LevelAbilityConfig
			{
				NeedTickActivate = new bool?(true)
			});
			this.Register<PlayerElementalFieldToggleAbility>(ELevelEntityAbilityType.PlayerElementalFieldToggle, (ELevelEntityAbilityType type, EAbilityTickPhase tickPhase, int tickOrder, bool needTickActivate) => new PlayerElementalFieldToggleAbility(type, tickPhase, tickOrder, needTickActivate), new LevelAbilityConfig
			{
				NeedTickActivate = new bool?(true)
			});
			this.Register<PlayerElementalDetectableAbility>(ELevelEntityAbilityType.PlayerElementalDetectable, (ELevelEntityAbilityType type, EAbilityTickPhase tickPhase, int tickOrder, bool needTickActivate) => new PlayerElementalDetectableAbility(type, tickPhase, tickOrder, needTickActivate), new LevelAbilityConfig
			{
				NeedTickActivate = new bool?(true)
			});
			this.Register<PlayerElementalReactionAbility>(ELevelEntityAbilityType.PlayerElementalReaction, (ELevelEntityAbilityType type, EAbilityTickPhase tickPhase, int tickOrder, bool needTickActivate) => new PlayerElementalReactionAbility(type, tickPhase, tickOrder, needTickActivate), new LevelAbilityConfig
			{
				NeedTickActivate = new bool?(true)
			});
			this.Register<PlayerElementalFieldBlockAbility>(ELevelEntityAbilityType.PlayerElementalFieldBlock, (ELevelEntityAbilityType type, EAbilityTickPhase tickPhase, int tickOrder, bool needTickActivate) => new PlayerElementalFieldBlockAbility(type, tickPhase, tickOrder, needTickActivate), null);
			this.Register<PlayerElementalFieldRenderMaskAbility>(ELevelEntityAbilityType.PlayerElementalFieldRenderMask, (ELevelEntityAbilityType type, EAbilityTickPhase tickPhase, int tickOrder, bool needTickActivate) => new PlayerElementalFieldRenderMaskAbility(type, tickPhase, tickOrder, needTickActivate), new LevelAbilityConfig
			{
				NeedTickActivate = new bool?(true)
			});
			this.Register<PlayerElementalCoreDrawAbility>(ELevelEntityAbilityType.PlayerElementalCoreDraw, (ELevelEntityAbilityType type, EAbilityTickPhase tickPhase, int tickOrder, bool needTickActivate) => new PlayerElementalCoreDrawAbility(type, tickPhase, tickOrder, needTickActivate), new LevelAbilityConfig
			{
				NeedTickActivate = new bool?(true),
				TickPhase = new EAbilityTickPhase?(EAbilityTickPhase.AfterTick)
			});
			this.Register<PlayerElementalCoreHoldAbility>(ELevelEntityAbilityType.PlayerElementalCoreHold, (ELevelEntityAbilityType type, EAbilityTickPhase tickPhase, int tickOrder, bool needTickActivate) => new PlayerElementalCoreHoldAbility(type, tickPhase, tickOrder, needTickActivate), new LevelAbilityConfig
			{
				NeedTickActivate = new bool?(true),
				TickPhase = new EAbilityTickPhase?(EAbilityTickPhase.AfterTick)
			});
			this.Register<PlayerElementalCoreReturnAbility>(ELevelEntityAbilityType.PlayerElementalCoreReturn, (ELevelEntityAbilityType type, EAbilityTickPhase tickPhase, int tickOrder, bool needTickActivate) => new PlayerElementalCoreReturnAbility(type, tickPhase, tickOrder, needTickActivate), new LevelAbilityConfig
			{
				NeedTickActivate = new bool?(true),
				TickPhase = new EAbilityTickPhase?(EAbilityTickPhase.AfterTick)
			});
			this.Register<PlayerElementalCoreResetAbility>(ELevelEntityAbilityType.PlayerElementalCoreReset, (ELevelEntityAbilityType type, EAbilityTickPhase tickPhase, int tickOrder, bool needTickActivate) => new PlayerElementalCoreResetAbility(type, tickPhase, tickOrder, needTickActivate), new LevelAbilityConfig
			{
				NeedTickActivate = new bool?(true),
				TickPhase = new EAbilityTickPhase?(EAbilityTickPhase.AfterTick)
			});
			this.Register<PlayerElementalCoreMatchAbility>(ELevelEntityAbilityType.PlayerElementalCoreMatch, (ELevelEntityAbilityType type, EAbilityTickPhase tickPhase, int tickOrder, bool needTickActivate) => new PlayerElementalCoreMatchAbility(type, tickPhase, tickOrder, needTickActivate), new LevelAbilityConfig
			{
				NeedTickActivate = new bool?(true),
				TickPhase = new EAbilityTickPhase?(EAbilityTickPhase.AfterTick)
			});
			this.Register<PlayerElementalCoreMismatchAbility>(ELevelEntityAbilityType.PlayerElementalCoreMismatch, (ELevelEntityAbilityType type, EAbilityTickPhase tickPhase, int tickOrder, bool needTickActivate) => new PlayerElementalCoreMismatchAbility(type, tickPhase, tickOrder, needTickActivate), new LevelAbilityConfig
			{
				NeedTickActivate = new bool?(true),
				TickPhase = new EAbilityTickPhase?(EAbilityTickPhase.AfterTick)
			});
			this.Register<PlayerElementalCoreEffectAbility>(ELevelEntityAbilityType.PlayerElementalCoreEffect, (ELevelEntityAbilityType type, EAbilityTickPhase tickPhase, int tickOrder, bool needTickActivate) => new PlayerElementalCoreEffectAbility(type, tickPhase, tickOrder, needTickActivate), new LevelAbilityConfig
			{
				NeedTickActivate = new bool?(true),
				TickPhase = new EAbilityTickPhase?(EAbilityTickPhase.AfterTick)
			});
			this.Register<PlayerSearchSceneInteractPointAbility>(ELevelEntityAbilityType.PlayerSearchSceneInteractPoint, (ELevelEntityAbilityType type, EAbilityTickPhase tickPhase, int tickOrder, bool needTickActivate) => new PlayerSearchSceneInteractPointAbility(type, tickPhase, tickOrder, needTickActivate), new LevelAbilityConfig
			{
				NeedTickActivate = new bool?(true)
			});
			this.Register<PlayerSceneInteractPointViewAbility>(ELevelEntityAbilityType.PlayerSceneInteractPointView, (ELevelEntityAbilityType type, EAbilityTickPhase tickPhase, int tickOrder, bool needTickActivate) => new PlayerSceneInteractPointViewAbility(type, tickPhase, tickOrder, needTickActivate), new LevelAbilityConfig
			{
				NeedTickActivate = new bool?(true)
			});
			this.Register<PlayerSceneInteractTagAbility>(ELevelEntityAbilityType.PlayerSceneInteractTag, (ELevelEntityAbilityType type, EAbilityTickPhase tickPhase, int tickOrder, bool needTickActivate) => new PlayerSceneInteractTagAbility(type, tickPhase, tickOrder, needTickActivate), new LevelAbilityConfig
			{
				NeedTickActivate = new bool?(true)
			});
		}

		// Token: 0x060457D0 RID: 284624 RVA: 0x0113CF94 File Offset: 0x0113B194
		private void Register<[Nullable(0)] T>(ELevelEntityAbilityType type, Func<ELevelEntityAbilityType, EAbilityTickPhase, int, bool, T> creator, [Nullable(2)] LevelAbilityConfig config) where T : LevelEntityAbilityBase
		{
			if (this.Registrations.ContainsKey(type))
			{
				return;
			}
			if (config == null)
			{
				this.Registrations[type] = new AbilityRegistration
				{
					Creator = creator,
					Config = new LevelAbilityConfig
					{
						TickPhase = new EAbilityTickPhase?(EAbilityTickPhase.Tick),
						TickOrder = new int?(100),
						NeedTickActivate = new bool?(false),
						Events = null,
						BlockedTags = null
					}
				};
				return;
			}
			List<int> list = this.ExpandBlockedTags(config.BlockedTags);
			config.BlockedTags = list;
			this.Registrations[type] = new AbilityRegistration
			{
				Creator = creator,
				Config = new LevelAbilityConfig
				{
					TickPhase = new EAbilityTickPhase?(config.TickPhase.GetValueOrDefault()),
					TickOrder = new int?(config.TickOrder.GetValueOrDefault(100)),
					NeedTickActivate = new bool?(config.NeedTickActivate.GetValueOrDefault()),
					Events = config.Events,
					BlockedTags = config.BlockedTags
				}
			};
			if (list != null)
			{
				foreach (int tag in list)
				{
					this.IndexBlockTag(tag, type);
				}
			}
		}

		// Token: 0x060457D1 RID: 284625 RVA: 0x0113D0F0 File Offset: 0x0113B2F0
		[NullableContext(2)]
		private List<int> ExpandBlockedTags(List<int> blockedTags)
		{
			if (blockedTags == null || blockedTags.Count == 0)
			{
				return null;
			}
			HashSet<int> hashSet = new HashSet<int>();
			foreach (int value in blockedTags)
			{
				int? num = new int?(value);
				while (num != null && !hashSet.Contains(num.Value))
				{
					hashSet.Add(num.Value);
					num = new int?(GameplayTagUtils.GetParentTag(num.Value));
				}
			}
			return new List<int>(hashSet);
		}

		// Token: 0x060457D2 RID: 284626 RVA: 0x0113D194 File Offset: 0x0113B394
		private void IndexBlockTag(int tag, ELevelEntityAbilityType type)
		{
			HashSet<ELevelEntityAbilityType> hashSet = this.BlockTagToAbilities.GetValueOrDefault(tag);
			if (hashSet == null)
			{
				hashSet = new HashSet<ELevelEntityAbilityType>();
				this.BlockTagToAbilities[tag] = hashSet;
			}
			hashSet.Add(type);
		}

		// Token: 0x060457D3 RID: 284627 RVA: 0x0113D1CC File Offset: 0x0113B3CC
		[NullableContext(2)]
		public LevelEntityAbilityBase CreateAbility(ELevelEntityAbilityType type)
		{
			AbilityRegistration abilityRegistration;
			if (!this.Registrations.TryGetValue(type, out abilityRegistration))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Capability;
				ELogAuthor author = ELogAuthor.LYY;
				string message = "LevelEntityAbility 未注册，无法创建";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("type", type);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			LevelAbilityConfig config = abilityRegistration.Config;
			return abilityRegistration.Creator(type, config.TickPhase.Value, config.TickOrder.Value, config.NeedTickActivate.Value);
		}

		// Token: 0x060457D4 RID: 284628 RVA: 0x0113D259 File Offset: 0x0113B459
		[NullableContext(2)]
		public ILevelAbilityConfig GetConfig(ELevelEntityAbilityType type)
		{
			AbilityRegistration valueOrDefault = this.Registrations.GetValueOrDefault(type);
			if (valueOrDefault == null)
			{
				return null;
			}
			return valueOrDefault.Config;
		}

		// Token: 0x060457D5 RID: 284629 RVA: 0x0113D272 File Offset: 0x0113B472
		[NullableContext(2)]
		public IReadOnlySet<ELevelEntityAbilityType> GetAbilitiesByBlockTag(int tag)
		{
			return this.BlockTagToAbilities.GetValueOrDefault(tag);
		}

		// Token: 0x17009B71 RID: 39793
		// (get) Token: 0x060457D6 RID: 284630 RVA: 0x0113D280 File Offset: 0x0113B480
		public static LevelEntityAbilityCenter Instance
		{
			get
			{
				if (LevelEntityAbilityCenter._instance == null)
				{
					LevelEntityAbilityCenter._instance = new LevelEntityAbilityCenter();
					LevelEntityAbilityCenter._instance.OnInit();
				}
				return LevelEntityAbilityCenter._instance;
			}
		}

		// Token: 0x060457D7 RID: 284631 RVA: 0x0113D2A3 File Offset: 0x0113B4A3
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060457D8 RID: 284632 RVA: 0x0113D2A5 File Offset: 0x0113B4A5
		public static void ResetStaticDefaultValue()
		{
			LevelEntityAbilityCenter instance = LevelEntityAbilityCenter._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			LevelEntityAbilityCenter._instance = null;
		}

		// Token: 0x060457D9 RID: 284633 RVA: 0x0113D2BE File Offset: 0x0113B4BE
		static LevelEntityAbilityCenter()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelEntityAbilityCenter.CreateStaticDefaultValue), new Action(LevelEntityAbilityCenter.ResetStaticDefaultValue));
		}

		// Token: 0x04024419 RID: 148505
		private readonly Dictionary<ELevelEntityAbilityType, AbilityRegistration> Registrations = new Dictionary<ELevelEntityAbilityType, AbilityRegistration>();

		// Token: 0x0402441A RID: 148506
		private readonly Dictionary<int, HashSet<ELevelEntityAbilityType>> BlockTagToAbilities = new Dictionary<int, HashSet<ELevelEntityAbilityType>>();

		// Token: 0x0402441B RID: 148507
		[Nullable(2)]
		private static LevelEntityAbilityCenter _instance;
	}
}
