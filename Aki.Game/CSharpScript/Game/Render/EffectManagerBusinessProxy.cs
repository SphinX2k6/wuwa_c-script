using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034F8 RID: 13560
	[NullableContext(1)]
	[Nullable(0)]
	public class EffectManagerBusinessProxy : Singleton
	{
		// Token: 0x0602280D RID: 141325 RVA: 0x009CAF8D File Offset: 0x009C918D
		private void EffectReadyCallBack(int handle, string reason)
		{
			if (!EffectSystem.Instance.GetHideOnBurstSkill(handle))
			{
				return;
			}
			this.EffectsDestroyOnBurstSkill.Add(handle);
		}

		// Token: 0x0602280E RID: 141326 RVA: 0x009CAFAA File Offset: 0x009C91AA
		private void EffectFinishCallBack(int handle, string reason, bool immediately)
		{
			this.EffectsDestroyOnBurstSkill.Remove(handle);
		}

		// Token: 0x0602280F RID: 141327 RVA: 0x009CAFB9 File Offset: 0x009C91B9
		private void OnChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			this.CurrentCharacter = ((baseCharacter != null) ? baseCharacter.GetEntityNoBlueprint() : null);
			TsBaseCharacter baseCharacter2 = Global.BaseCharacter;
			this.CurrentCharacterEntityId = ((baseCharacter2 != null) ? baseCharacter2.GetEntityIdNoBlueprint() : 0);
		}

		// Token: 0x06022810 RID: 141328 RVA: 0x009CAFEC File Offset: 0x009C91EC
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

		// Token: 0x06022811 RID: 141329 RVA: 0x009CB0C0 File Offset: 0x009C92C0
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

		// Token: 0x1700485F RID: 18527
		// (get) Token: 0x06022812 RID: 141330 RVA: 0x009CB160 File Offset: 0x009C9360
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

		// Token: 0x06022813 RID: 141331 RVA: 0x009CB183 File Offset: 0x009C9383
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06022814 RID: 141332 RVA: 0x009CB185 File Offset: 0x009C9385
		public static void ResetStaticDefaultValue()
		{
			EffectManagerBusinessProxy instance = EffectManagerBusinessProxy._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			EffectManagerBusinessProxy._instance = null;
		}

		// Token: 0x06022815 RID: 141333 RVA: 0x009CB19E File Offset: 0x009C939E
		static EffectManagerBusinessProxy()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(EffectManagerBusinessProxy.CreateStaticDefaultValue), new Action(EffectManagerBusinessProxy.ResetStaticDefaultValue));
		}

		// Token: 0x04013137 RID: 78135
		[Nullable(2)]
		private Stat DestroyOnBurstStat;

		// Token: 0x04013138 RID: 78136
		[Nullable(2)]
		private HashSet<int> EffectsDestroyOnBurstSkill;

		// Token: 0x04013139 RID: 78137
		[Nullable(2)]
		private Entity CurrentCharacter;

		// Token: 0x0401313A RID: 78138
		private int CurrentCharacterEntityId;

		// Token: 0x0401313B RID: 78139
		[Nullable(2)]
		private static EffectManagerBusinessProxy _instance;
	}
}
