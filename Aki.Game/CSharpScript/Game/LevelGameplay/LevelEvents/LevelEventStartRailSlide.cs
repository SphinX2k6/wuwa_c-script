using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move;
using CSharpScript.Game.NewWorld.Character.Common.Controller;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B98 RID: 27544
	public class LevelEventStartRailSlide : LevelEventBase
	{
		// Token: 0x060442D7 RID: 279255 RVA: 0x010CD061 File Offset: 0x010CB261
		public LevelEventStartRailSlide(int id) : base(id)
		{
		}

		// Token: 0x060442D8 RID: 279256 RVA: 0x010CD06C File Offset: 0x010CB26C
		[NullableContext(1)]
		public unsafe override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
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
				string message = "LevelEventStartRailSlide 参数配置错误";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PbDataId", valueOrDefault);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			SlideRailStart slideRailStart = inParams as SlideRailStart;
			if (slideRailStart == null)
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.Event;
				ELogAuthor author2 = ELogAuthor.CWZ;
				string message2 = "LevelEventStartRailSlide 参数类型错误";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("PbDataId", valueOrDefault);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			ISlideRailFollowConfig slideRailFollowConfig = slideRailStart.SlideRailFollowConfig;
			if (((slideRailFollowConfig != null) ? slideRailFollowConfig.FollowDaPath : null) != null)
			{
				int entityId = slideRailStart.SlideRailFollowConfig.EntityId;
				string slidePerformDaPath = slideRailStart.SlidePerformDaPath;
				string followDaPath = slideRailStart.SlideRailFollowConfig.FollowDaPath;
				CharacterRailSlideController.Instance.AddRailFollower(entityId, slideRailStart.RailEntityId, followDaPath, slidePerformDaPath);
				return;
			}
			if (entity == null)
			{
				global::Log instance3 = global::Log.Instance;
				ELogModule module3 = ELogModule.Event;
				ELogAuthor author3 = ELogAuthor.CWZ;
				string message3 = "LevelEventStartRailSlide 执行失败，玩家实体不存在";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PbDataId", valueOrDefault);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("RailEntityId", slideRailStart.RailEntityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("DaPath", slideRailStart.SlidePerformDaPath);
				instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return;
			}
			CharacterRailSlideComponent component2 = entity.GetComponent<CharacterRailSlideComponent>();
			if (component2 == null)
			{
				global::Log instance4 = global::Log.Instance;
				ELogModule module4 = ELogModule.Event;
				ELogAuthor author4 = ELogAuthor.CWZ;
				string message4 = "LevelEventStartRailSlide 执行失败，玩家缺少滑轨组件";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("PbDataId", valueOrDefault);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("RailEntityId", slideRailStart.RailEntityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("DaPath", slideRailStart.SlidePerformDaPath);
				instance4.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				return;
			}
			CharacterRailSlideComponent characterRailSlideComponent = component2;
			int railEntityId = slideRailStart.RailEntityId;
			string slidePerformDaPath2 = slideRailStart.SlidePerformDaPath;
			Action<bool> callback = null;
			ISlideRailRTPCParams rtpcparams = slideRailStart.RTPCParams;
			characterRailSlideComponent.StartRailSlide(railEntityId, slidePerformDaPath2, callback, (rtpcparams != null) ? rtpcparams.RTPCName : null);
		}
	}
}
