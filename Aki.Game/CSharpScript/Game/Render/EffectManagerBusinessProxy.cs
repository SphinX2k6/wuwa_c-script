using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045D0 RID: 17872
	[NullableContext(1)]
	[Nullable(0)]
	public class EffectManagerBusinessProxy : Singleton
	{
		// Token: 0x0602E122 RID: 188706 RVA: 0x00A9ECC5 File Offset: 0x00A9CEC5
		private void EffectReadyCallBack(int handle, string reason)
		{
			if (!EffectSystem.Instance.GetHideOnBurstSkill(handle))
			{
				return;
			}
			this.EffectsDestroyOnBurstSkill.Add(handle);
		}

		// Token: 0x0602E123 RID: 188707 RVA: 0x00A9ECE2 File Offset: 0x00A9CEE2
		private void EffectFinishCallBack(int handle, string reason, bool immediately)
		{
			this.EffectsDestroyOnBurstSkill.Remove(handle);
		}

		// Token: 0x0602E124 RID: 188708 RVA: 0x00A9ECF1 File Offset: 0x00A9CEF1
		private void OnChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			this.CurrentCharacter = ((baseCharacter != null) ? baseCharacter.GetEntityNoBlueprint() : null);
			TsBaseCharacter baseCharacter2 = Global.BaseCharacter;
			this.CurrentCharacterEntityId = ((baseCharacter2 != null) ? baseCharacter2.GetEntityIdNoBlueprint() : 0);
		}

		// Token: 0x0602E125 RID: 188709 RVA: 0x00A9ED24 File Offset: 0x00A9CF24
		private void OnCharUseSkill(int charId, int skillId, bool isAutonomousProxy)
		{
			if (this.CurrentCharacter == null || charId != this.CurrentCharacterEntityId)
			{
				return;
			}
			CharacterSkillComponent component = this.CurrentCharacter.GetComponent<CharacterSkillComponent>();
			if (component != null && component.HasSkillGenre(skillId, ESkillGenre.大招3))
			{
				foreach (int num in this.EffectsDestroyOnBurstSkill)
				{
					if (EffectSystem.Instance.IsValid(num))
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.RenderEffect;
						ELogAuthor author = ELogAuthor.LSY;
						string message = "Effect Recycled By Burst";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", EffectSystem.Instance.GetPath(num));
						instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						EffectSystem.Instance.StopEffectById(num, "[EffectManagerBusinessProxy.OnCharUseSkill]", true, null);
					}
				}
			}
		}

		// Token: 0x0602E126 RID: 188710 RVA: 0x00A9EDF8 File Offset: 0x00A9CFF8
		protected override bool OnInit()
		{
			this.DestroyOnBurstStat = Stat.Create("EffectManagerBusinessProxy_DestroyOnBurst", "", "");
			this.EffectsDestroyOnBurstSkill = new HashSet<int>();
			EventSystem.Instance.Add<int, string>(EEventName.BeforePlayEffect, new Action<int, string>(this.EffectReadyCallBack));
			EventSystem.Instance.Add<int, string, bool>(EEventName.FinishEffect, new Action<int, string, bool>(this.EffectFinishCallBack));
			EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
			EventSystem.Instance.Add<int, int, bool>(EEventName.CharUseSkill, new Action<int, int, bool>(this.OnCharUseSkill));
			return true;
		}

		// Token: 0x170075A8 RID: 30120
		// (get) Token: 0x0602E127 RID: 188711 RVA: 0x00A9EE98 File Offset: 0x00A9D098
		public static EffectManagerBusinessProxy Instance
		{
			get
			{
				if (EffectManagerBusinessProxy._instance == null)
				{
					EffectManagerBusinessProxy._instance = new EffectManagerBusinessProxy();
					EffectManagerBusinessProxy._instance.OnInit();
				}
				return EffectManagerBusinessProxy._instance;
			}
		}

		// Token: 0x0602E128 RID: 188712 RVA: 0x00A9EEBB File Offset: 0x00A9D0BB
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E129 RID: 188713 RVA: 0x00A9EEBD File Offset: 0x00A9D0BD
		public static void ResetStaticDefaultValue()
		{
			EffectManagerBusinessProxy instance = EffectManagerBusinessProxy._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			EffectManagerBusinessProxy._instance = null;
		}

		// Token: 0x0602E12A RID: 188714 RVA: 0x00A9EED6 File Offset: 0x00A9D0D6
		static EffectManagerBusinessProxy()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(EffectManagerBusinessProxy.CreateStaticDefaultValue), new Action(EffectManagerBusinessProxy.ResetStaticDefaultValue));
		}

		// Token: 0x04018AFC RID: 101116
		[Nullable(2)]
		private Stat DestroyOnBurstStat;

		// Token: 0x04018AFD RID: 101117
		[Nullable(2)]
		private HashSet<int> EffectsDestroyOnBurstSkill;

		// Token: 0x04018AFE RID: 101118
		[Nullable(2)]
		private Entity CurrentCharacter;

		// Token: 0x04018AFF RID: 101119
		private int CurrentCharacterEntityId;

		// Token: 0x04018B00 RID: 101120
		[Nullable(2)]
		private static EffectManagerBusinessProxy _instance;
	}
}
