using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CFD RID: 23805
	public class LevelEventSlidePerformStart : LevelEventBase
	{
		// Token: 0x0603A3C6 RID: 238534 RVA: 0x0107493F File Offset: 0x01072B3F
		public LevelEventSlidePerformStart(int id) : base(id)
		{
		}

		// Token: 0x0603A3C7 RID: 238535 RVA: 0x01074948 File Offset: 0x01072B48
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (inParams == null)
			{
				global::Log.Instance.Error(ELogModule.Event, ELogAuthor.CWZ, "LevelEventSlidePerformStart 参数配置错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			SlidePerformStart slidePerformStart = inParams as SlidePerformStart;
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			Entity entity = (baseCharacter != null) ? baseCharacter.GetEntityNoBlueprint() : null;
			if (entity == null)
			{
				return;
			}
			CharacterRailSlideComponent component = entity.GetComponent<CharacterRailSlideComponent>();
			if (component == null)
			{
				return;
			}
			component.StartRailSlide(slidePerformStart.SlideEntityId, slidePerformStart.SlidePerformConfig.SlopeSlidePerformDaPath, null, null);
		}
	}
}
