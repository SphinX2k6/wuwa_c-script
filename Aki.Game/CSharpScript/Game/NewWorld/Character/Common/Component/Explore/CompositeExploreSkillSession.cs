using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Explore
{
	// Token: 0x02007123 RID: 28963
	public class CompositeExploreSkillSession : IStaticVariableResetter
	{
		// Token: 0x06046B78 RID: 289656 RVA: 0x011CF6A6 File Offset: 0x011CD8A6
		static CompositeExploreSkillSession()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CompositeExploreSkillSession.CreateStaticDefaultValue), new Action(CompositeExploreSkillSession.ResetStaticDefaultValue));
		}

		// Token: 0x06046B79 RID: 289657 RVA: 0x011CF6C5 File Offset: 0x011CD8C5
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

		// Token: 0x06046B7A RID: 289658 RVA: 0x011CF702 File Offset: 0x011CD902
		public static void ResetStaticDefaultValue()
		{
			CompositeExploreSkillSession.CompositeExploreSkillConfigs = null;
		}

		// Token: 0x06046B7B RID: 289659 RVA: 0x011CF70A File Offset: 0x011CD90A
		public bool IsCompositeSessionExpired()
		{
			return this.ActiveCompositeSession != null && Time.Instance.Now - this.ActiveCompositeSession.CreatedTime >= 5000.0;
		}

		// Token: 0x06046B7C RID: 289660 RVA: 0x011CF73C File Offset: 0x011CD93C
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

		// Token: 0x04025204 RID: 152068
		private const int COMPOSITE_SESSION_TIMEOUT_MS = 5000;

		// Token: 0x04025205 RID: 152069
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static Dictionary<int, ICompositeExploreSkillConfig> CompositeExploreSkillConfigs;

		// Token: 0x04025206 RID: 152070
		[Nullable(2)]
		public ICompositeSkillSession ActiveCompositeSession;
	}
}
