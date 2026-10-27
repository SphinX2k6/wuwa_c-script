using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B85 RID: 27525
	public class LevelEventSlidePerformStart : LevelEventBase
	{
		// Token: 0x06044274 RID: 279156 RVA: 0x010CACA7 File Offset: 0x010C8EA7
		public LevelEventSlidePerformStart(int id) : base(id)
		{
		}

		// Token: 0x06044275 RID: 279157 RVA: 0x010CACB0 File Offset: 0x010C8EB0
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
