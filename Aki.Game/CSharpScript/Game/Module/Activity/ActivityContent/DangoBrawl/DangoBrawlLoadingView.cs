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
	// Token: 0x02006821 RID: 26657
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlLoadingView : UiViewBase
	{
		// Token: 0x06042850 RID: 272464 RVA: 0x0102A030 File Offset: 0x01028230
		public DangoBrawlLoadingView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06042851 RID: 272465 RVA: 0x0102A068 File Offset: 0x01028268
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

		// Token: 0x06042852 RID: 272466 RVA: 0x0102A1BC File Offset: 0x010283BC
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlLoadingView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlLoadingView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042853 RID: 272467 RVA: 0x0102A1FF File Offset: 0x010283FF
		protected override void OnStart()
		{
			this.RefreshInfo();
		}

		// Token: 0x06042854 RID: 272468 RVA: 0x0102A207 File Offset: 0x01028407
		protected override void OnBeforeDestroy()
		{
			AUIBaseActor rootActor = this.RootActor;
			if (rootActor == null)
			{
				return;
			}
			rootActor.OnSequencePlayEvent.Unbind();
		}

		// Token: 0x06042855 RID: 272469 RVA: 0x0102A21E File Offset: 0x0102841E
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

		// Token: 0x06042856 RID: 272470 RVA: 0x0102A258 File Offset: 0x01028458
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

		// Token: 0x06042857 RID: 272471 RVA: 0x0102A2C1 File Offset: 0x010284C1
		protected override void OnFinishShow()
		{
			this.DoOnFinishShow().Forget();
		}

		// Token: 0x06042858 RID: 272472 RVA: 0x0102A2D0 File Offset: 0x010284D0
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

		// Token: 0x06042859 RID: 272473 RVA: 0x0102A4E8 File Offset: 0x010286E8
		private void RefreshOccupationIcon(int occupationId, int texComp)
		{
			DangoBrawlOccupation? occupationConfigById = DangoBrawlConfig.Instance.GetOccupationConfigById(occupationId);
			if (occupationConfigById == null)
			{
				return;
			}
			base.SetTextureByPath(occupationConfigById.Value.Icon, base.GetTexture(texComp), null, null);
		}

		// Token: 0x0604285A RID: 272474 RVA: 0x0102A534 File Offset: 0x01028734
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

		// Token: 0x0604285B RID: 272475 RVA: 0x0102A5D8 File Offset: 0x010287D8
		private UniTask DoOnFinishShow()
		{
			DangoBrawlLoadingView.<DoOnFinishShow>d__16 <DoOnFinishShow>d__;
			<DoOnFinishShow>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DoOnFinishShow>d__.<>4__this = this;
			<DoOnFinishShow>d__.<>1__state = -1;
			<DoOnFinishShow>d__.<>t__builder.Start<DangoBrawlLoadingView.<DoOnFinishShow>d__16>(ref <DoOnFinishShow>d__);
			return <DoOnFinishShow>d__.<>t__builder.Task;
		}

		// Token: 0x04022A97 RID: 141975
		private string SelfTrashTalkTextKey = string.Empty;

		// Token: 0x04022A98 RID: 141976
		private string OpponentTrashTalkTextKey = string.Empty;

		// Token: 0x04022A99 RID: 141977
		private string SelfTrashTalkAudioEvent = string.Empty;

		// Token: 0x04022A9A RID: 141978
		private string OpponentTrashTalkAudioEvent = string.Empty;

		// Token: 0x0200C9BB RID: 51643
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403CF1C RID: 249628
			TxtMode,
			// Token: 0x0403CF1D RID: 249629
			TxtTitle,
			// Token: 0x0403CF1E RID: 249630
			TxtContentLeft,
			// Token: 0x0403CF1F RID: 249631
			TxtContentRight,
			// Token: 0x0403CF20 RID: 249632
			TexIconBlue,
			// Token: 0x0403CF21 RID: 249633
			TxtNameBlue,
			// Token: 0x0403CF22 RID: 249634
			TexIconRed,
			// Token: 0x0403CF23 RID: 249635
			TxtNameRed,
			// Token: 0x0403CF24 RID: 249636
			UIView_BackpackBrawlLoading
		}
	}
}
