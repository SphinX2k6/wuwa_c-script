using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Map.Controller
{
	// Token: 0x02004564 RID: 17764
	[NullableContext(2)]
	[Nullable(0)]
	public class AreaAssistant : ControllerAssistantBase
	{
		// Token: 0x0602CBFE RID: 183294 RVA: 0x00C87530 File Offset: 0x00C85730
		protected override void OnDestroy()
		{
		}

		// Token: 0x0602CBFF RID: 183295 RVA: 0x00C87534 File Offset: 0x00C85734
		public override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.MapUnlockFieldNotify, new Action<IMessage, Net.CallbackStatus>(this.OnMapUnlockFieldNotify));
			Net.Instance.Register(ENotifyMessageId.MultiMapInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnMultiMapInfoNotify));
			Net.Instance.Register(ENotifyMessageId.UnlockMapBlockNotify, new Action<IMessage, Net.CallbackStatus>(this.OnUnlockMapBlockNotify));
			Net.Instance.Register(ENotifyMessageId.UnlockMultiMapNotify, new Action<IMessage, Net.CallbackStatus>(this.OnUnlockMultiMapNotify));
		}

		// Token: 0x0602CC00 RID: 183296 RVA: 0x00C875B4 File Offset: 0x00C857B4
		public override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.MapUnlockFieldNotify);
			Net.Instance.UnRegister(ENotifyMessageId.MultiMapInfoNotify);
			Net.Instance.UnRegister(ENotifyMessageId.UnlockMapBlockNotify);
			Net.Instance.UnRegister(ENotifyMessageId.UnlockMultiMapNotify);
		}

		// Token: 0x0602CC01 RID: 183297 RVA: 0x00C87604 File Offset: 0x00C85804
		private void OnUnlockMultiMapNotify(IMessage msg, Net.CallbackStatus status)
		{
			UnlockMultiMapNotify unlockMultiMapNotify = (UnlockMultiMapNotify)msg;
			MapModel.Instance.AddUnlockMultiMapIds(unlockMultiMapNotify.UnlockMultiMapId);
		}

		// Token: 0x0602CC02 RID: 183298 RVA: 0x00C87628 File Offset: 0x00C85828
		private void OnUnlockMapBlockNotify(IMessage msg, Net.CallbackStatus status)
		{
			UnlockMapBlockNotify unlockMapBlockNotify = (UnlockMapBlockNotify)msg;
			MapModel.Instance.AddUnlockMapBlockIds(unlockMapBlockNotify.UnlockBlockId);
		}

		// Token: 0x0602CC03 RID: 183299 RVA: 0x00C8764C File Offset: 0x00C8584C
		private void OnMultiMapInfoNotify(IMessage msg, Net.CallbackStatus status)
		{
			MultiMapInfoNotify multiMapInfoNotify = (MultiMapInfoNotify)msg;
			MapModel.Instance.SetUnlockMultiMapIds(new List<int>(multiMapInfoNotify.UnlockMultiMapId));
			MapModel.Instance.SetUnlockMapBlockIds(new List<int>(multiMapInfoNotify.UnlockBlockId));
		}

		// Token: 0x0602CC04 RID: 183300 RVA: 0x00C8768C File Offset: 0x00C8588C
		private void OnMapUnlockFieldNotify(IMessage msg, Net.CallbackStatus status)
		{
			MapUnlockFieldNotify mapUnlockFieldNotify = (MapUnlockFieldNotify)msg;
			MapModel.Instance.AddUnlockedFogs(mapUnlockFieldNotify.FieldId);
		}

		// Token: 0x0602CC05 RID: 183301 RVA: 0x00C876B0 File Offset: 0x00C858B0
		public UniTask RequestUnlockedAreaInfo()
		{
			AreaAssistant.<RequestUnlockedAreaInfo>d__7 <RequestUnlockedAreaInfo>d__;
			<RequestUnlockedAreaInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestUnlockedAreaInfo>d__.<>1__state = -1;
			<RequestUnlockedAreaInfo>d__.<>t__builder.Start<AreaAssistant.<RequestUnlockedAreaInfo>d__7>(ref <RequestUnlockedAreaInfo>d__);
			return <RequestUnlockedAreaInfo>d__.<>t__builder.Task;
		}
	}
}
