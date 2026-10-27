using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Weather;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EBE RID: 20158
	[NullableContext(2)]
	[Nullable(0)]
	[Controller(0)]
	public class RogueBattleController : UiControllerBase
	{
		// Token: 0x06033C37 RID: 212023 RVA: 0x00C2087C File Offset: 0x00C1EA7C
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.RogueResRoomInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueRoomInfoNotify));
			Net.Instance.Register(ENotifyMessageId.RogueResInstOptionsUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueResInstOptionsUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RogueResGainDataUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueResGainDataUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RogueResElementUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueResElementUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RogueResRoleBondUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueResRoleBondUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RogueResFormationUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueResFormationUpdateNotify));
		}

		// Token: 0x06033C38 RID: 212024 RVA: 0x00C20934 File Offset: 0x00C1EB34
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.RogueResRoomInfoNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RogueResInstOptionsUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RogueResGainDataUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RogueResElementUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RogueResRoleBondUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RogueResFormationUpdateNotify);
		}

		// Token: 0x06033C39 RID: 212025 RVA: 0x00C209A1 File Offset: 0x00C1EBA1
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.LeaveInstanceDungeon, new Action(this.OnLeaveInstanceDungeon));
		}

		// Token: 0x06033C3A RID: 212026 RVA: 0x00C209BF File Offset: 0x00C1EBBF
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.LeaveInstanceDungeon, new Action(this.OnLeaveInstanceDungeon));
		}

		// Token: 0x06033C3B RID: 212027 RVA: 0x00C209DD File Offset: 0x00C1EBDD
		protected void OnLeaveInstanceDungeon()
		{
			RogueBattleModel.Instance.ClearData();
		}

		// Token: 0x06033C3C RID: 212028 RVA: 0x00C209EC File Offset: 0x00C1EBEC
		protected void OnRogueResRoleBondUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			RogueResRoleBondUpdateNotify notify = (RogueResRoleBondUpdateNotify)msg;
			RogueBattleModel.Instance.UpdateFetterData(notify);
		}

		// Token: 0x06033C3D RID: 212029 RVA: 0x00C20A0C File Offset: 0x00C1EC0C
		protected void OnRogueResElementUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			RogueResElementUpdateNotify notify = (RogueResElementUpdateNotify)msg;
			RogueBattleModel.Instance.UpdateElementData(notify);
		}

		// Token: 0x06033C3E RID: 212030 RVA: 0x00C20A2C File Offset: 0x00C1EC2C
		protected void OnRogueResGainDataUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			RogueResGainDataUpdateNotify data = (RogueResGainDataUpdateNotify)msg;
			RogueBattleModel.Instance.UpdateGainData(data);
		}

		// Token: 0x06033C3F RID: 212031 RVA: 0x00C20A4C File Offset: 0x00C1EC4C
		protected void OnRogueRoomInfoNotify(IMessage msg, Net.CallbackStatus _)
		{
			RogueResRoomInfoNotify rogueResRoomInfoNotify = (RogueResRoomInfoNotify)msg;
			RogueResRoomPool? roomPoolConfig = RogueBattleConfig.Instance.GetRoomPoolConfig(rogueResRoomInfoNotify.RoguelikeRoomId);
			RogueResRoomType value = RogueBattleConfig.Instance.GetRogueRoomType(rogueResRoomInfoNotify.RoguelikeRoomTypeId).Value;
			RogueBattleModel.Instance.CurrentRoomTypeId = value.RoomType;
			RogueBattleModel.Instance.CurrentRoomId = rogueResRoomInfoNotify.RoguelikeRoomId;
			if (roomPoolConfig != null && !StringUtils.IsEmpty(roomPoolConfig.Value.RoomsMusicState))
			{
				RogueBattleModel.Instance.CurrentRoomMusicState = roomPoolConfig.Value.RoomsMusicState;
			}
			else
			{
				RogueBattleModel.Instance.CurrentRoomMusicState = value.RoomsMusicState;
			}
			if (rogueResRoomInfoNotify.SkyBoxId != 0)
			{
				WeatherModel.Instance.GetWorldWeatherActor().ChangeWeather(rogueResRoomInfoNotify.SkyBoxId, 0f);
				return;
			}
			WeatherController.Instance.StopWeather();
		}

		// Token: 0x06033C40 RID: 212032 RVA: 0x00C20B28 File Offset: 0x00C1ED28
		protected void OnRogueResInstOptionsUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			RogueResInstOptionsUpdateNotify data = (RogueResInstOptionsUpdateNotify)msg;
			RogueBattleModel.Instance.UpdateOptionData(data);
		}

		// Token: 0x06033C41 RID: 212033 RVA: 0x00C20B48 File Offset: 0x00C1ED48
		protected void OnRogueResFormationUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			RogueResFormationUpdateNotify rogueResFormationUpdateNotify = (RogueResFormationUpdateNotify)msg;
			for (int i = 0; i < rogueResFormationUpdateNotify.RogueResFormations.Count; i++)
			{
				RogueBattleModel.Instance.UpdateFormationData(i, rogueResFormationUpdateNotify.RogueResFormations[i]);
			}
		}

		// Token: 0x06033C42 RID: 212034 RVA: 0x00C20B8C File Offset: 0x00C1ED8C
		public UniTask GotoNextRoomRequest()
		{
			RogueBattleController.<GotoNextRoomRequest>d__11 <GotoNextRoomRequest>d__;
			<GotoNextRoomRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<GotoNextRoomRequest>d__.<>1__state = -1;
			<GotoNextRoomRequest>d__.<>t__builder.Start<RogueBattleController.<GotoNextRoomRequest>d__11>(ref <GotoNextRoomRequest>d__);
			return <GotoNextRoomRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06033C43 RID: 212035 RVA: 0x00C20BC8 File Offset: 0x00C1EDC8
		public UniTask SwitchFormationRequest(int index)
		{
			RogueBattleController.<SwitchFormationRequest>d__12 <SwitchFormationRequest>d__;
			<SwitchFormationRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SwitchFormationRequest>d__.index = index;
			<SwitchFormationRequest>d__.<>1__state = -1;
			<SwitchFormationRequest>d__.<>t__builder.Start<RogueBattleController.<SwitchFormationRequest>d__12>(ref <SwitchFormationRequest>d__);
			return <SwitchFormationRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06033C44 RID: 212036 RVA: 0x00C20C0C File Offset: 0x00C1EE0C
		[NullableContext(1)]
		public UniTask ChangeFormationAllListRequest(int formationIndex, List<int> roleIdList)
		{
			RogueBattleController.<ChangeFormationAllListRequest>d__13 <ChangeFormationAllListRequest>d__;
			<ChangeFormationAllListRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ChangeFormationAllListRequest>d__.formationIndex = formationIndex;
			<ChangeFormationAllListRequest>d__.roleIdList = roleIdList;
			<ChangeFormationAllListRequest>d__.<>1__state = -1;
			<ChangeFormationAllListRequest>d__.<>t__builder.Start<RogueBattleController.<ChangeFormationAllListRequest>d__13>(ref <ChangeFormationAllListRequest>d__);
			return <ChangeFormationAllListRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06033C45 RID: 212037 RVA: 0x00C20C58 File Offset: 0x00C1EE58
		public UniTask ChangeFormationRequest(int formationIndex, int position, int roleId)
		{
			RogueBattleController.<ChangeFormationRequest>d__14 <ChangeFormationRequest>d__;
			<ChangeFormationRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ChangeFormationRequest>d__.formationIndex = formationIndex;
			<ChangeFormationRequest>d__.position = position;
			<ChangeFormationRequest>d__.roleId = roleId;
			<ChangeFormationRequest>d__.<>1__state = -1;
			<ChangeFormationRequest>d__.<>t__builder.Start<RogueBattleController.<ChangeFormationRequest>d__14>(ref <ChangeFormationRequest>d__);
			return <ChangeFormationRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06033C46 RID: 212038 RVA: 0x00C20CAC File Offset: 0x00C1EEAC
		public UniTask SelectTokenRequest(int index)
		{
			RogueBattleController.<SelectTokenRequest>d__15 <SelectTokenRequest>d__;
			<SelectTokenRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SelectTokenRequest>d__.index = index;
			<SelectTokenRequest>d__.<>1__state = -1;
			<SelectTokenRequest>d__.<>t__builder.Start<RogueBattleController.<SelectTokenRequest>d__15>(ref <SelectTokenRequest>d__);
			return <SelectTokenRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06033C47 RID: 212039 RVA: 0x00C20CF0 File Offset: 0x00C1EEF0
		[NullableContext(0)]
		public UniTask<bool> OpenBuffSelectViewById(int bindId)
		{
			RogueBattleController.<OpenBuffSelectViewById>d__16 <OpenBuffSelectViewById>d__;
			<OpenBuffSelectViewById>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenBuffSelectViewById>d__.<>4__this = this;
			<OpenBuffSelectViewById>d__.bindId = bindId;
			<OpenBuffSelectViewById>d__.<>1__state = -1;
			<OpenBuffSelectViewById>d__.<>t__builder.Start<RogueBattleController.<OpenBuffSelectViewById>d__16>(ref <OpenBuffSelectViewById>d__);
			return <OpenBuffSelectViewById>d__.<>t__builder.Task;
		}

		// Token: 0x06033C48 RID: 212040 RVA: 0x00C20D3C File Offset: 0x00C1EF3C
		public EUiViewName? GetViewNameByGainType(RogueResDataType type)
		{
			switch (type)
			{
			case RogueResDataType.Token:
				return new EUiViewName?(EUiViewName.RogueBattleSelectTokenView);
			case RogueResDataType.TokenShop:
				return new EUiViewName?(EUiViewName.RogueBattleShopView);
			case RogueResDataType.Phantom:
				return new EUiViewName?(EUiViewName.RogueBattlePhantomSelectView);
			case RogueResDataType.Event:
				return new EUiViewName?(EUiViewName.RogueBattleRandomEventView);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RogueBattle;
			ELogAuthor author = ELogAuthor.LPH;
			string message = "当前增益类型没有对应的界面数据";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("type", type.ToString());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}

		// Token: 0x17007EE0 RID: 32480
		// (get) Token: 0x06033C49 RID: 212041 RVA: 0x00C20DD6 File Offset: 0x00C1EFD6
		[Nullable(1)]
		public static RogueBattleController Instance
		{
			[NullableContext(1)]
			get
			{
				return RogueBattleController._Instance;
			}
		}

		// Token: 0x06033C4A RID: 212042 RVA: 0x00C20DDD File Offset: 0x00C1EFDD
		[NullableContext(1)]
		public static RogueBattleController GetOrCreateInstance()
		{
			if (RogueBattleController._Instance == null)
			{
				RogueBattleController.CreateInstance();
			}
			return RogueBattleController._Instance;
		}

		// Token: 0x06033C4B RID: 212043 RVA: 0x00C20DF1 File Offset: 0x00C1EFF1
		public static bool CreateInstance()
		{
			if (RogueBattleController._Instance != null)
			{
				return true;
			}
			RogueBattleController._Instance = new RogueBattleController();
			return true;
		}

		// Token: 0x06033C4C RID: 212044 RVA: 0x00C20E07 File Offset: 0x00C1F007
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06033C4D RID: 212045 RVA: 0x00C20E09 File Offset: 0x00C1F009
		public static void ResetStaticDefaultValue()
		{
			RogueBattleController._Instance = null;
		}

		// Token: 0x06033C4E RID: 212046 RVA: 0x00C20E11 File Offset: 0x00C1F011
		static RogueBattleController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RogueBattleController.CreateStaticDefaultValue), new Action(RogueBattleController.ResetStaticDefaultValue));
		}

		// Token: 0x0401B815 RID: 112661
		private static RogueBattleController _Instance;
	}
}
