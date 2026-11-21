using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Explore
{
	// Token: 0x02006351 RID: 25425
	public class CompositeExploreSkillSession : IStaticVariableResetter
	{
		// Token: 0x0603D9C3 RID: 252355 RVA: 0x011D82F6 File Offset: 0x011D64F6
		static CompositeExploreSkillSession()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CompositeExploreSkillSession.CreateStaticDefaultValue), new Action(CompositeExploreSkillSession.ResetStaticDefaultValue));
		}

		// Token: 0x0603D9C4 RID: 252356 RVA: 0x011D8315 File Offset: 0x011D6515
		public static void CreateStaticDefaultValue()
		{
			CompositeExploreSkillSession.CompositeExploreSkillConfigs = new Dictionary<int, ICompositeExploreSkillConfig>
			{
				{
					10001035,
					new CompositeExploreSkillConfig
					{
						Name = "MotorcycleKiteHook",
						EntrySkillId = 10001035,
						ExitSkillId = 210130
					}
				}
			};
		}

		// Token: 0x0603D9C5 RID: 252357 RVA: 0x011D8352 File Offset: 0x011D6552
		public static void ResetStaticDefaultValue()
		{
			CompositeExploreSkillSession.CompositeExploreSkillConfigs = null;
		}

		// Token: 0x0603D9C6 RID: 252358 RVA: 0x011D835A File Offset: 0x011D655A
		public bool IsCompositeSessionExpired()
		{
			return this.ActiveCompositeSession != null && Time.Instance.Now - this.ActiveCompositeSession.CreatedTime >= 5000.0;
		}

		// Token: 0x0603D9C7 RID: 252359 RVA: 0x011D838C File Offset: 0x011D658C
		[NullableContext(1)]
		public unsafe bool TryCleanStaleCompositeSession(int skillId, ELogModule logModule, string reason)
		{
			ICompositeSkillSession activeCompositeSession = this.ActiveCompositeSession;
			if (activeCompositeSession == null)
			{
				return false;
			}
			bool flag = this.IsCompositeSessionExpired();
			bool flag2 = skillId != activeCompositeSession.Config.EntrySkillId && skillId != activeCompositeSession.Config.ExitSkillId;
			if (flag || flag2)
			{
				Log instance = Log.Instance;
				ELogAuthor author = ELogAuthor.CK;
				string message = "复合探索技能会话被容错清除: " + reason;
				<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("SkillId", skillId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CompositeName", activeCompositeSession.Config.Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Expired", flag);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("UnrelatedSkill", flag2);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("SessionAge", Time.Instance.Now - activeCompositeSession.CreatedTime);
				instance.Warn(logModule, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
				this.ActiveCompositeSession = null;
				return true;
			}
			return false;
		}

		// Token: 0x04020AE4 RID: 133860
		private const int COMPOSITE_SESSION_TIMEOUT_MS = 5000;

		// Token: 0x04020AE5 RID: 133861
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static Dictionary<int, ICompositeExploreSkillConfig> CompositeExploreSkillConfigs;

		// Token: 0x04020AE6 RID: 133862
		[Nullable(2)]
		public ICompositeSkillSession ActiveCompositeSession;
	}
}
