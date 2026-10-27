using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Map.Controller
{
	// Token: 0x0200558E RID: 21902
	[NullableContext(2)]
	[Nullable(0)]
	public class AreaAssistant : ControllerAssistantBase
	{
		// Token: 0x06037D00 RID: 228608 RVA: 0x00D39858 File Offset: 0x00D37A58
		protected override void OnDestroy()
		{
		}

		// Token: 0x06037D01 RID: 228609 RVA: 0x00D3985C File Offset: 0x00D37A5C
		public override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.MapUnlockFieldNotify, new Action<IMessage, Net.CallbackStatus>(this.OnMapUnlockFieldNotify));
			Net.Instance.Register(ENotifyMessageId.MultiMapInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnMultiMapInfoNotify));
			Net.Instance.Register(ENotifyMessageId.UnlockMapBlockNotify, new Action<IMessage, Net.CallbackStatus>(this.OnUnlockMapBlockNotify));
			Net.Instance.Register(ENotifyMessageId.UnlockMultiMapNotify, new Action<IMessage, Net.CallbackStatus>(this.OnUnlockMultiMapNotify));
		}

		// Token: 0x06037D02 RID: 228610 RVA: 0x00D398DC File Offset: 0x00D37ADC
		public override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.MapUnlockFieldNotify);
			Net.Instance.UnRegister(ENotifyMessageId.MultiMapInfoNotify);
			Net.Instance.UnRegister(ENotifyMessageId.UnlockMapBlockNotify);
			Net.Instance.UnRegister(ENotifyMessageId.UnlockMultiMapNotify);
		}

		// Token: 0x06037D03 RID: 228611 RVA: 0x00D3992C File Offset: 0x00D37B2C
		private void OnUnlockMultiMapNotify(IMessage msg, Net.CallbackStatus status)
		{
			UnlockMultiMapNotify unlockMultiMapNotify = (UnlockMultiMapNotify)msg;
			MapModel.Instance.AddUnlockMultiMapIds(unlockMultiMapNotify.UnlockMultiMapId.ToList<int>());
		}

		// Token: 0x06037D04 RID: 228612 RVA: 0x00D39958 File Offset: 0x00D37B58
		private void OnUnlockMapBlockNotify(IMessage msg, Net.CallbackStatus status)
		{
			UnlockMapBlockNotify unlockMapBlockNotify = (UnlockMapBlockNotify)msg;
			MapModel.Instance.AddUnlockMapBlockIds(unlockMapBlockNotify.UnlockBlockId.ToList<int>());
		}

		// Token: 0x06037D05 RID: 228613 RVA: 0x00D39984 File Offset: 0x00D37B84
		private void OnMultiMapInfoNotify(IMessage msg, Net.CallbackStatus status)
		{
			MultiMapInfoNotify multiMapInfoNotify = (MultiMapInfoNotify)msg;
			MapModel.Instance.SetUnlockMultiMapIds(multiMapInfoNotify.UnlockMultiMapId.ToList<int>());
			MapModel.Instance.SetUnlockMapBlockIds(multiMapInfoNotify.UnlockBlockId.ToList<int>());
		}

		// Token: 0x06037D06 RID: 228614 RVA: 0x00D399C4 File Offset: 0x00D37BC4
		private void OnMapUnlockFieldNotify(IMessage msg, Net.CallbackStatus status)
		{
			MapUnlockFieldNotify mapUnlockFieldNotify = (MapUnlockFieldNotify)msg;
			MapModel.Instance.AddUnlockedFogs(mapUnlockFieldNotify.FieldId);
		}

		// Token: 0x06037D07 RID: 228615 RVA: 0x00D399E8 File Offset: 0x00D37BE8
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
