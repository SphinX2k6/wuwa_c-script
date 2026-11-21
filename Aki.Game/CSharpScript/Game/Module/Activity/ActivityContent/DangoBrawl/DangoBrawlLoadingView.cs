using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Entity.Component;
using CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005771 RID: 22385
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlLoadingView : UiViewBase
	{
		// Token: 0x060373A4 RID: 226212 RVA: 0x00F6B56C File Offset: 0x00F6976C
		public DangoBrawlLoadingView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060373A5 RID: 226213 RVA: 0x00F6B5A4 File Offset: 0x00F697A4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060373A6 RID: 226214 RVA: 0x00F6B6F8 File Offset: 0x00F698F8
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlLoadingView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlLoadingView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060373A7 RID: 226215 RVA: 0x00F6B73B File Offset: 0x00F6993B
		protected override void OnStart()
		{
			this.RefreshInfo();
		}

		// Token: 0x060373A8 RID: 226216 RVA: 0x00F6B743 File Offset: 0x00F69943
		protected override void OnBeforeDestroy()
		{
			AUIBaseActor rootActor = this.RootActor;
			if (rootActor == null)
			{
				return;
			}
			rootActor.OnSequencePlayEvent.Unbind();
		}

		// Token: 0x060373A9 RID: 226217 RVA: 0x00F6B75A File Offset: 0x00F6995A
		private void OnPlaySequenceEvent(string sequenceName, string eventName)
		{
			if (eventName == "TrashTalkSelf")
			{
				this.PostTrashTalkAudio(true, this.SelfTrashTalkAudioEvent);
				return;
			}
			if (eventName == "TrashTalkOpponent")
			{
				this.PostTrashTalkAudio(false, this.OpponentTrashTalkAudioEvent);
			}
		}

		// Token: 0x060373AA RID: 226218 RVA: 0x00F6B794 File Offset: 0x00F69994
		private void PostTrashTalkAudio(bool isSelf, string eventName)
		{
			if (string.IsNullOrEmpty(eventName))
			{
				return;
			}
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			ACharacter acharacter;
			if (battleManager == null)
			{
				acharacter = null;
			}
			else
			{
				ActivityGameplayEntity entity = battleManager.GetEntity(isSelf);
				if (entity == null)
				{
					acharacter = null;
				}
				else
				{
					DangoBrawlActorComponent component = entity.GetComponent<DangoBrawlActorComponent>();
					acharacter = ((component != null) ? component.SpawnedActor : null);
				}
			}
			ACharacter acharacter2 = acharacter;
			if (acharacter2 == null || !acharacter2.IsValid())
			{
				return;
			}
			AudioSystem.Instance.PostEvent(eventName, acharacter2, null);
		}

		// Token: 0x060373AB RID: 226219 RVA: 0x00F6B7FD File Offset: 0x00F699FD
		protected override void OnFinishShow()
		{
			this.DoOnFinishShow().Forget();
		}

		// Token: 0x060373AC RID: 226220 RVA: 0x00F6B80C File Offset: 0x00F69A0C
		private void RefreshInfo()
		{
			ActivityDangoBrawlData myActivityData = ActivityDangoBrawlController.Instance.MyActivityData;
			DangoBrawlInstBaseNotify dangoBrawlInstBaseNotify = (myActivityData != null) ? myActivityData.InstBase : null;
			if (dangoBrawlInstBaseNotify == null)
			{
				return;
			}
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			if (battleManager == null)
			{
				return;
			}
			int challengeId = dangoBrawlInstBaseNotify.ChallengeId;
			object obj;
			if (myActivityData == null)
			{
				obj = null;
			}
			else
			{
				DangoBrawlOutGameData outGameData = myActivityData.GetOutGameData();
				obj = ((outGameData != null) ? outGameData.GetLevelData(challengeId) : null);
			}
			DangoBrawlChallenge? challengeConfigById = DangoBrawlConfig.Instance.GetChallengeConfigById(challengeId);
			object obj2 = obj;
			string textStringId = (((obj2 != null) ? obj2.Mode : EDangoBrawlLevelMode.Normal) == EDangoBrawlLevelMode.Normal) ? "DangoBrawlGeneral_1002" : "DangoBrawlGeneral_1003";
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textStringId, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), challengeConfigById.Value.Name, Array.Empty<object>());
			DangoBrawlRole? roleConfigById = DangoBrawlConfig.Instance.GetRoleConfigById(battleManager.GetDangoId(true));
			if (roleConfigById != null)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(5), roleConfigById.Value.Name, Array.Empty<object>());
				int[] trashTalkIdListArray = roleConfigById.Value.GetTrashTalkIdListArray();
				ValueTuple<string, string> randomTrashTalkTextKey = this.GetRandomTrashTalkTextKey(trashTalkIdListArray);
				this.SelfTrashTalkTextKey = randomTrashTalkTextKey.Item1;
				this.SelfTrashTalkAudioEvent = randomTrashTalkTextKey.Item2;
				this.RefreshOccupationIcon(roleConfigById.Value.OccupationId, 4);
			}
			DangoBrawlOpponent? opponentConfigById = DangoBrawlConfig.Instance.GetOpponentConfigById(battleManager.GetDangoId(false));
			if (opponentConfigById != null)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(7), opponentConfigById.Value.Name, Array.Empty<object>());
				int[] trashTalkIdListArray2 = opponentConfigById.Value.GetTrashTalkIdListArray();
				ValueTuple<string, string> randomTrashTalkTextKey = this.GetRandomTrashTalkTextKey(trashTalkIdListArray2);
				this.OpponentTrashTalkTextKey = randomTrashTalkTextKey.Item1;
				this.OpponentTrashTalkAudioEvent = randomTrashTalkTextKey.Item2;
				this.RefreshOccupationIcon(opponentConfigById.Value.OccupationId, 6);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), this.SelfTrashTalkTextKey, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), this.OpponentTrashTalkTextKey, Array.Empty<object>());
		}

		// Token: 0x060373AD RID: 226221 RVA: 0x00F6BA24 File Offset: 0x00F69C24
		private void RefreshOccupationIcon(int occupationId, int texComp)
		{
			DangoBrawlOccupation? occupationConfigById = DangoBrawlConfig.Instance.GetOccupationConfigById(occupationId);
			if (occupationConfigById == null)
			{
				return;
			}
			base.SetTextureByPath(occupationConfigById.Value.Icon, base.GetTexture(texComp), null, null);
		}

		// Token: 0x060373AE RID: 226222 RVA: 0x00F6BA70 File Offset: 0x00F69C70
		[return: TupleElementNames(new string[]
		{
			"TextKey",
			"AudioEvent"
		})]
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		private ValueTuple<string, string> GetRandomTrashTalkTextKey(int[] talkIdList)
		{
			if (talkIdList == null || talkIdList.Length == 0)
			{
				return new ValueTuple<string, string>(string.Empty, string.Empty);
			}
			int randomItem = MathUtils.Instance.GetRandomItem<int>(talkIdList);
			DangoTrashTalk? config = ConfigDangoTrashTalkById.GetConfig(randomItem, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DangoBrawl;
				ELogAuthor author = ELogAuthor.LSH;
				string message = "[LoadingTrashTalk] ConfigDangoTrashTalk 不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("talkId", randomItem);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return new ValueTuple<string, string>(string.Empty, string.Empty);
			}
			return new ValueTuple<string, string>(config.Value.Textkey, config.Value.AudioEvent);
		}

		// Token: 0x060373AF RID: 226223 RVA: 0x00F6BB14 File Offset: 0x00F69D14
		private UniTask DoOnFinishShow()
		{
			DangoBrawlLoadingView.<DoOnFinishShow>d__16 <DoOnFinishShow>d__;
			<DoOnFinishShow>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DoOnFinishShow>d__.<>4__this = this;
			<DoOnFinishShow>d__.<>1__state = -1;
			<DoOnFinishShow>d__.<>t__builder.Start<DangoBrawlLoadingView.<DoOnFinishShow>d__16>(ref <DoOnFinishShow>d__);
			return <DoOnFinishShow>d__.<>t__builder.Task;
		}

		// Token: 0x0401D2F4 RID: 119540
		private string SelfTrashTalkTextKey = string.Empty;

		// Token: 0x0401D2F5 RID: 119541
		private string OpponentTrashTalkTextKey = string.Empty;

		// Token: 0x0401D2F6 RID: 119542
		private string SelfTrashTalkAudioEvent = string.Empty;

		// Token: 0x0401D2F7 RID: 119543
		private string OpponentTrashTalkAudioEvent = string.Empty;

		// Token: 0x0200B387 RID: 45959
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04037806 RID: 227334
			TxtMode,
			// Token: 0x04037807 RID: 227335
			TxtTitle,
			// Token: 0x04037808 RID: 227336
			TxtContentLeft,
			// Token: 0x04037809 RID: 227337
			TxtContentRight,
			// Token: 0x0403780A RID: 227338
			TexIconBlue,
			// Token: 0x0403780B RID: 227339
			TxtNameBlue,
			// Token: 0x0403780C RID: 227340
			TexIconRed,
			// Token: 0x0403780D RID: 227341
			TxtNameRed,
			// Token: 0x0403780E RID: 227342
			UIView_BackpackBrawlLoading
		}
	}
}
