using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.InstanceDungeon.ExchangeReward
{
	// Token: 0x020058B3 RID: 22707
	[NullableContext(1)]
	[Nullable(0)]
	public class ExchangeRewardController : ControllerBase
	{
		// Token: 0x06039BEE RID: 236526 RVA: 0x00DB97F0 File Offset: 0x00DB79F0
		protected override bool OnInit()
		{
			this.OnAddEvents();
			this.OnRegisterNetEvent();
			return true;
		}

		// Token: 0x06039BEF RID: 236527 RVA: 0x00DB97FF File Offset: 0x00DB79FF
		protected override bool OnClear()
		{
			this.OnRemoveEvents();
			this.OnUnRegisterNetEvent();
			return true;
		}

		// Token: 0x06039BF0 RID: 236528 RVA: 0x00DB980E File Offset: 0x00DB7A0E
		protected void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
		}

		// Token: 0x06039BF1 RID: 236529 RVA: 0x00DB982C File Offset: 0x00DB7A2C
		protected void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
		}

		// Token: 0x06039BF2 RID: 236530 RVA: 0x00DB984A File Offset: 0x00DB7A4A
		protected void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.ExchangeRewardInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnExchangeRewardInfoNotify));
			Net.Instance.Register(ENotifyMessageId.ExchangeSharedInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnExchangeSharedInfoNotify));
		}

		// Token: 0x06039BF3 RID: 236531 RVA: 0x00DB9884 File Offset: 0x00DB7A84
		protected void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.ExchangeRewardInfoNotify);
			Net.Instance.UnRegister(ENotifyMessageId.ExchangeSharedInfoNotify);
		}

		// Token: 0x06039BF4 RID: 236532 RVA: 0x00DB98A8 File Offset: 0x00DB7AA8
		[NullableContext(2)]
		private void OnExchangeRewardInfoNotify(IMessage msg, Net.CallbackStatus callbackStatus)
		{
			ExchangeRewardInfoNotify message = (ExchangeRewardInfoNotify)msg;
			ExchangeRewardModel.Instance.OnExchangeRewardNotify(message);
		}

		// Token: 0x06039BF5 RID: 236533 RVA: 0x00DB98C8 File Offset: 0x00DB7AC8
		[NullableContext(2)]
		private void OnExchangeSharedInfoNotify(IMessage msg, Net.CallbackStatus callbackStatus)
		{
			ExchangeSharedInfoNotify message = (ExchangeSharedInfoNotify)msg;
			ExchangeRewardModel.Instance.OnShareInfoNotify(message);
		}

		// Token: 0x06039BF6 RID: 236534 RVA: 0x00DB98E7 File Offset: 0x00DB7AE7
		private void OnLoadingNetDataDone()
		{
			this.RequestExchangeData().Forget();
		}

		// Token: 0x06039BF7 RID: 236535 RVA: 0x00DB98F4 File Offset: 0x00DB7AF4
		public UniTask RequestExchangeData()
		{
			ExchangeRewardController.<RequestExchangeData>d__9 <RequestExchangeData>d__;
			<RequestExchangeData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestExchangeData>d__.<>1__state = -1;
			<RequestExchangeData>d__.<>t__builder.Start<ExchangeRewardController.<RequestExchangeData>d__9>(ref <RequestExchangeData>d__);
			return <RequestExchangeData>d__.<>t__builder.Task;
		}

		// Token: 0x17008A9C RID: 35484
		// (get) Token: 0x06039BF8 RID: 236536 RVA: 0x00DB992F File Offset: 0x00DB7B2F
		public static ExchangeRewardController Instance
		{
			get
			{
				return ExchangeRewardController._Instance;
			}
		}

		// Token: 0x06039BF9 RID: 236537 RVA: 0x00DB9936 File Offset: 0x00DB7B36
		public static ExchangeRewardController GetOrCreateInstance()
		{
			if (ExchangeRewardController._Instance == null)
			{
				ExchangeRewardController.CreateInstance();
			}
			return ExchangeRewardController._Instance;
		}

		// Token: 0x06039BFA RID: 236538 RVA: 0x00DB994A File Offset: 0x00DB7B4A
		public static bool CreateInstance()
		{
			if (ExchangeRewardController._Instance != null)
			{
				return true;
			}
			ExchangeRewardController._Instance = new ExchangeRewardController();
			return true;
		}

		// Token: 0x06039BFB RID: 236539 RVA: 0x00DB9960 File Offset: 0x00DB7B60
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06039BFC RID: 236540 RVA: 0x00DB9962 File Offset: 0x00DB7B62
		public static void ResetStaticDefaultValue()
		{
			ExchangeRewardController._Instance = null;
		}

		// Token: 0x06039BFD RID: 236541 RVA: 0x00DB996A File Offset: 0x00DB7B6A
		static ExchangeRewardController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ExchangeRewardController.CreateStaticDefaultValue), new Action(ExchangeRewardController.ResetStaticDefaultValue));
		}

		// Token: 0x0401E281 RID: 123521
		[Nullable(2)]
		private static ExchangeRewardController _Instance;
	}
}
