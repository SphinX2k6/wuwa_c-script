using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.InstanceDungeon.ExchangeReward
{
	// Token: 0x0200488B RID: 18571
	[NullableContext(1)]
	[Nullable(0)]
	public class ExchangeRewardController : ControllerBase
	{
		// Token: 0x0602EB11 RID: 191249 RVA: 0x00D08708 File Offset: 0x00D06908
		protected override bool OnInit()
		{
			this.OnAddEvents();
			this.OnRegisterNetEvent();
			return true;
		}

		// Token: 0x0602EB12 RID: 191250 RVA: 0x00D08717 File Offset: 0x00D06917
		protected override bool OnClear()
		{
			this.OnRemoveEvents();
			this.OnUnRegisterNetEvent();
			return true;
		}

		// Token: 0x0602EB13 RID: 191251 RVA: 0x00D08726 File Offset: 0x00D06926
		protected void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
		}

		// Token: 0x0602EB14 RID: 191252 RVA: 0x00D08744 File Offset: 0x00D06944
		protected void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
		}

		// Token: 0x0602EB15 RID: 191253 RVA: 0x00D08762 File Offset: 0x00D06962
		protected void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.ExchangeRewardInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnExchangeRewardInfoNotify));
			Net.Instance.Register(ENotifyMessageId.ExchangeSharedInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnExchangeSharedInfoNotify));
		}

		// Token: 0x0602EB16 RID: 191254 RVA: 0x00D0879C File Offset: 0x00D0699C
		protected void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.ExchangeRewardInfoNotify);
			Net.Instance.UnRegister(ENotifyMessageId.ExchangeSharedInfoNotify);
		}

		// Token: 0x0602EB17 RID: 191255 RVA: 0x00D087C0 File Offset: 0x00D069C0
		[NullableContext(2)]
		private void OnExchangeRewardInfoNotify(IMessage msg, Net.CallbackStatus callbackStatus)
		{
			ExchangeRewardInfoNotify message = (ExchangeRewardInfoNotify)msg;
			ExchangeRewardModel.Instance.OnExchangeRewardNotify(message);
		}

		// Token: 0x0602EB18 RID: 191256 RVA: 0x00D087E0 File Offset: 0x00D069E0
		[NullableContext(2)]
		private void OnExchangeSharedInfoNotify(IMessage msg, Net.CallbackStatus callbackStatus)
		{
			ExchangeSharedInfoNotify message = (ExchangeSharedInfoNotify)msg;
			ExchangeRewardModel.Instance.OnShareInfoNotify(message);
		}

		// Token: 0x0602EB19 RID: 191257 RVA: 0x00D087FF File Offset: 0x00D069FF
		private void OnLoadingNetDataDone()
		{
			this.RequestExchangeData().Forget();
		}

		// Token: 0x0602EB1A RID: 191258 RVA: 0x00D0880C File Offset: 0x00D06A0C
		public UniTask RequestExchangeData()
		{
			ExchangeRewardController.<RequestExchangeData>d__9 <RequestExchangeData>d__;
			<RequestExchangeData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestExchangeData>d__.<>1__state = -1;
			<RequestExchangeData>d__.<>t__builder.Start<ExchangeRewardController.<RequestExchangeData>d__9>(ref <RequestExchangeData>d__);
			return <RequestExchangeData>d__.<>t__builder.Task;
		}

		// Token: 0x17005E68 RID: 24168
		// (get) Token: 0x0602EB1B RID: 191259 RVA: 0x00D08847 File Offset: 0x00D06A47
		public static ExchangeRewardController Instance
		{
			get
			{
				return ExchangeRewardController._Instance;
			}
		}

		// Token: 0x0602EB1C RID: 191260 RVA: 0x00D0884E File Offset: 0x00D06A4E
		public static ExchangeRewardController GetOrCreateInstance()
		{
			if (ExchangeRewardController._Instance == null)
			{
				ExchangeRewardController.CreateInstance();
			}
			return ExchangeRewardController._Instance;
		}

		// Token: 0x0602EB1D RID: 191261 RVA: 0x00D08862 File Offset: 0x00D06A62
		public static bool CreateInstance()
		{
			if (ExchangeRewardController._Instance != null)
			{
				return true;
			}
			ExchangeRewardController._Instance = new ExchangeRewardController();
			return true;
		}

		// Token: 0x0602EB1E RID: 191262 RVA: 0x00D08878 File Offset: 0x00D06A78
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602EB1F RID: 191263 RVA: 0x00D0887A File Offset: 0x00D06A7A
		public static void ResetStaticDefaultValue()
		{
			ExchangeRewardController._Instance = null;
		}

		// Token: 0x0602EB20 RID: 191264 RVA: 0x00D08882 File Offset: 0x00D06A82
		static ExchangeRewardController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ExchangeRewardController.CreateStaticDefaultValue), new Action(ExchangeRewardController.ResetStaticDefaultValue));
		}

		// Token: 0x04018D1E RID: 101662
		[Nullable(2)]
		private static ExchangeRewardController _Instance;
	}
}
