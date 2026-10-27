using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move;
using CSharpScript.Game.NewWorld.Character.Common.Controller;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B9B RID: 27547
	public class LevelEventStopRailSlide : LevelEventBase
	{
		// Token: 0x060442DE RID: 279262 RVA: 0x010CD3DA File Offset: 0x010CB5DA
		public LevelEventStopRailSlide(int id) : base(id)
		{
		}

		// Token: 0x060442DF RID: 279263 RVA: 0x010CD3E4 File Offset: 0x010CB5E4
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			Entity entity = (baseCharacter != null) ? baseCharacter.GetEntityNoBlueprint() : null;
			int? num;
			if (entity == null)
			{
				num = null;
			}
			else
			{
				CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
				num = ((component != null) ? new int?(component.GetPbDataId()) : null);
			}
			int? num2 = num;
			int valueOrDefault = num2.GetValueOrDefault();
			if (inParams == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Event;
				ELogAuthor author = ELogAuthor.CWZ;
				string message = "LevelEventStopRailSlide 参数配置错误";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PbDataId", valueOrDefault);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			SlideRailEnd slideRailEnd = inParams as SlideRailEnd;
			if (slideRailEnd == null)
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.Event;
				ELogAuthor author2 = ELogAuthor.CWZ;
				string message2 = "LevelEventStopRailSlide 参数类型错误";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("PbDataId", valueOrDefault);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			ISlideRailEndType endTarget = slideRailEnd.EndTarget;
			ESlideRailEndType type = endTarget.Type;
			if (type != ESlideRailEndType.Player)
			{
				if (type != ESlideRailEndType.AiFollower)
				{
					global::Log instance3 = global::Log.Instance;
					ELogModule module3 = ELogModule.Event;
					ELogAuthor author3 = ELogAuthor.CWZ;
					string message3 = "LevelEventStopRailSlide 未知的EndTarget类型";
					ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("PbDataId", 0);
					instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
					return;
				}
				int aiEntityId = ((IAiFollowerSlideRailEnd)endTarget).AiEntityId;
				CharacterRailSlideController.Instance.RemoveActiveFollower(aiEntityId);
				EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(aiEntityId);
				WorldEntity worldEntity = (entityByPbDataId != null) ? entityByPbDataId.Entity : null;
				if (worldEntity == null || !worldEntity.Valid)
				{
					return;
				}
				CharacterRailSlideComponent component2 = worldEntity.GetComponent<CharacterRailSlideComponent>();
				if (component2 == null)
				{
					global::Log instance4 = global::Log.Instance;
					ELogModule module4 = ELogModule.Event;
					ELogAuthor author4 = ELogAuthor.CWZ;
					string message4 = "LevelEventStopRailSlide 执行失败，AiFollower缺少滑轨组件";
					ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("PbDataId", aiEntityId);
					instance4.Error(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
					return;
				}
				component2.ForceExitSplineRailSlide("LevelEventStopRailSlide", true);
				return;
			}
			else
			{
				if (entity == null)
				{
					global::Log instance5 = global::Log.Instance;
					ELogModule module5 = ELogModule.Event;
					ELogAuthor author5 = ELogAuthor.CWZ;
					string message5 = "LevelEventStopRailSlide 执行失败，玩家实体不存在";
					ValueTuple<string, object> valueTuple5 = new ValueTuple<string, object>("PbDataId", valueOrDefault);
					instance5.Error(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple5));
					return;
				}
				CharacterRailSlideComponent component3 = entity.GetComponent<CharacterRailSlideComponent>();
				if (component3 == null)
				{
					global::Log instance6 = global::Log.Instance;
					ELogModule module6 = ELogModule.Event;
					ELogAuthor author6 = ELogAuthor.CWZ;
					string message6 = "LevelEventStopRailSlide 执行失败，玩家缺少滑轨组件";
					ValueTuple<string, object> valueTuple6 = new ValueTuple<string, object>("PbDataId", valueOrDefault);
					instance6.Error(module6, author6, message6, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple6));
					return;
				}
				component3.ForceExitSplineRailSlide("LevelEventStopRailSlide", true);
				return;
			}
		}
	}
}
