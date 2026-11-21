using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.ElementalCasket;
using CSharpScript.Game.NewWorld.Player.Ability;

namespace CSharpScript.Game.LevelEntityAbility
{
	// Token: 0x02006132 RID: 24882
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEntityAbilityCenter : Singleton
	{
		// Token: 0x0603B97D RID: 244093 RVA: 0x010E699D File Offset: 0x010E4B9D
		public void Init()
		{
			this.RegisterAllAbility();
		}

		// Token: 0x0603B97E RID: 244094 RVA: 0x010E69A5 File Offset: 0x010E4BA5
		public void Clear()
		{
			this.Registrations.Clear();
			this.BlockTagToAbilities.Clear();
		}

		// Token: 0x0603B97F RID: 244095 RVA: 0x010E69C0 File Offset: 0x010E4BC0
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

		// Token: 0x0603B980 RID: 244096 RVA: 0x010E6DC0 File Offset: 0x010E4FC0
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

		// Token: 0x0603B981 RID: 244097 RVA: 0x010E6F1C File Offset: 0x010E511C
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

		// Token: 0x0603B982 RID: 244098 RVA: 0x010E6FC0 File Offset: 0x010E51C0
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

		// Token: 0x0603B983 RID: 244099 RVA: 0x010E6FF8 File Offset: 0x010E51F8
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

		// Token: 0x0603B984 RID: 244100 RVA: 0x010E7085 File Offset: 0x010E5285
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

		// Token: 0x0603B985 RID: 244101 RVA: 0x010E709E File Offset: 0x010E529E
		[NullableContext(2)]
		public IReadOnlySet<ELevelEntityAbilityType> GetAbilitiesByBlockTag(int tag)
		{
			return this.BlockTagToAbilities.GetValueOrDefault(tag);
		}

		// Token: 0x170070B1 RID: 28849
		// (get) Token: 0x0603B986 RID: 244102 RVA: 0x010E70AC File Offset: 0x010E52AC
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

		// Token: 0x0603B987 RID: 244103 RVA: 0x010E70CF File Offset: 0x010E52CF
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603B988 RID: 244104 RVA: 0x010E70D1 File Offset: 0x010E52D1
		public static void ResetStaticDefaultValue()
		{
			LevelEntityAbilityCenter instance = LevelEntityAbilityCenter._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			LevelEntityAbilityCenter._instance = null;
		}

		// Token: 0x0603B989 RID: 244105 RVA: 0x010E70EA File Offset: 0x010E52EA
		static LevelEntityAbilityCenter()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelEntityAbilityCenter.CreateStaticDefaultValue), new Action(LevelEntityAbilityCenter.ResetStaticDefaultValue));
		}

		// Token: 0x0401F6CE RID: 128718
		private readonly Dictionary<ELevelEntityAbilityType, AbilityRegistration> Registrations = new Dictionary<ELevelEntityAbilityType, AbilityRegistration>();

		// Token: 0x0401F6CF RID: 128719
		private readonly Dictionary<int, HashSet<ELevelEntityAbilityType>> BlockTagToAbilities = new Dictionary<int, HashSet<ELevelEntityAbilityType>>();

		// Token: 0x0401F6D0 RID: 128720
		[Nullable(2)]
		private static LevelEntityAbilityCenter _instance;
	}
}
