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
	// Token: 0x02003E87 RID: 16007
	[NullableContext(2)]
	[Nullable(0)]
	[Controller(0)]
	public class RogueBattleController : UiControllerBase
	{
		// Token: 0x06028AA2 RID: 166562 RVA: 0x00B69D94 File Offset: 0x00B67F94
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.RogueResRoomInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueRoomInfoNotify));
			Net.Instance.Register(ENotifyMessageId.RogueResInstOptionsUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueResInstOptionsUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RogueResGainDataUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueResGainDataUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RogueResElementUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueResElementUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RogueResRoleBondUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueResRoleBondUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RogueResFormationUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueResFormationUpdateNotify));
		}

		// Token: 0x06028AA3 RID: 166563 RVA: 0x00B69E4C File Offset: 0x00B6804C
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.RogueResRoomInfoNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RogueResInstOptionsUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RogueResGainDataUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RogueResElementUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RogueResRoleBondUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RogueResFormationUpdateNotify);
		}

		// Token: 0x06028AA4 RID: 166564 RVA: 0x00B69EB9 File Offset: 0x00B680B9
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.LeaveInstanceDungeon, new Action(this.OnLeaveInstanceDungeon));
		}

		// Token: 0x06028AA5 RID: 166565 RVA: 0x00B69ED7 File Offset: 0x00B680D7
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.LeaveInstanceDungeon, new Action(this.OnLeaveInstanceDungeon));
		}

		// Token: 0x06028AA6 RID: 166566 RVA: 0x00B69EF5 File Offset: 0x00B680F5
		protected void OnLeaveInstanceDungeon()
		{
			RogueBattleModel.Instance.ClearData();
		}

		// Token: 0x06028AA7 RID: 166567 RVA: 0x00B69F04 File Offset: 0x00B68104
		protected void OnRogueResRoleBondUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			RogueResRoleBondUpdateNotify notify = (RogueResRoleBondUpdateNotify)msg;
			RogueBattleModel.Instance.UpdateFetterData(notify);
		}

		// Token: 0x06028AA8 RID: 166568 RVA: 0x00B69F24 File Offset: 0x00B68124
		protected void OnRogueResElementUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			RogueResElementUpdateNotify notify = (RogueResElementUpdateNotify)msg;
			RogueBattleModel.Instance.UpdateElementData(notify);
		}

		// Token: 0x06028AA9 RID: 166569 RVA: 0x00B69F44 File Offset: 0x00B68144
		protected void OnRogueResGainDataUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			RogueResGainDataUpdateNotify data = (RogueResGainDataUpdateNotify)msg;
			RogueBattleModel.Instance.UpdateGainData(data);
		}

		// Token: 0x06028AAA RID: 166570 RVA: 0x00B69F64 File Offset: 0x00B68164
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

		// Token: 0x06028AAB RID: 166571 RVA: 0x00B6A040 File Offset: 0x00B68240
		protected void OnRogueResInstOptionsUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			RogueResInstOptionsUpdateNotify data = (RogueResInstOptionsUpdateNotify)msg;
			RogueBattleModel.Instance.UpdateOptionData(data);
		}

		// Token: 0x06028AAC RID: 166572 RVA: 0x00B6A060 File Offset: 0x00B68260
		protected void OnRogueResFormationUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			RogueResFormationUpdateNotify rogueResFormationUpdateNotify = (RogueResFormationUpdateNotify)msg;
			for (int i = 0; i < rogueResFormationUpdateNotify.RogueResFormations.Count; i++)
			{
				RogueBattleModel.Instance.UpdateFormationData(i, rogueResFormationUpdateNotify.RogueResFormations[i]);
			}
		}

		// Token: 0x06028AAD RID: 166573 RVA: 0x00B6A0A4 File Offset: 0x00B682A4
		public UniTask GotoNextRoomRequest()
		{
			RogueBattleController.<GotoNextRoomRequest>d__11 <GotoNextRoomRequest>d__;
			<GotoNextRoomRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<GotoNextRoomRequest>d__.<>1__state = -1;
			<GotoNextRoomRequest>d__.<>t__builder.Start<RogueBattleController.<GotoNextRoomRequest>d__11>(ref <GotoNextRoomRequest>d__);
			return <GotoNextRoomRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06028AAE RID: 166574 RVA: 0x00B6A0E0 File Offset: 0x00B682E0
		public UniTask SwitchFormationRequest(int index)
		{
			RogueBattleController.<SwitchFormationRequest>d__12 <SwitchFormationRequest>d__;
			<SwitchFormationRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SwitchFormationRequest>d__.index = index;
			<SwitchFormationRequest>d__.<>1__state = -1;
			<SwitchFormationRequest>d__.<>t__builder.Start<RogueBattleController.<SwitchFormationRequest>d__12>(ref <SwitchFormationRequest>d__);
			return <SwitchFormationRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06028AAF RID: 166575 RVA: 0x00B6A124 File Offset: 0x00B68324
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

		// Token: 0x06028AB0 RID: 166576 RVA: 0x00B6A170 File Offset: 0x00B68370
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

		// Token: 0x06028AB1 RID: 166577 RVA: 0x00B6A1C4 File Offset: 0x00B683C4
		public UniTask SelectTokenRequest(int index)
		{
			RogueBattleController.<SelectTokenRequest>d__15 <SelectTokenRequest>d__;
			<SelectTokenRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SelectTokenRequest>d__.index = index;
			<SelectTokenRequest>d__.<>1__state = -1;
			<SelectTokenRequest>d__.<>t__builder.Start<RogueBattleController.<SelectTokenRequest>d__15>(ref <SelectTokenRequest>d__);
			return <SelectTokenRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06028AB2 RID: 166578 RVA: 0x00B6A208 File Offset: 0x00B68408
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

		// Token: 0x06028AB3 RID: 166579 RVA: 0x00B6A254 File Offset: 0x00B68454
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

		// Token: 0x17005290 RID: 21136
		// (get) Token: 0x06028AB4 RID: 166580 RVA: 0x00B6A2EE File Offset: 0x00B684EE
		[Nullable(1)]
		public static RogueBattleController Instance
		{
			[NullableContext(1)]
			get
			{
				return RogueBattleController._Instance;
			}
		}

		// Token: 0x06028AB5 RID: 166581 RVA: 0x00B6A2F5 File Offset: 0x00B684F5
		[NullableContext(1)]
		public static RogueBattleController GetOrCreateInstance()
		{
			if (RogueBattleController._Instance == null)
			{
				RogueBattleController.CreateInstance();
			}
			return RogueBattleController._Instance;
		}

		// Token: 0x06028AB6 RID: 166582 RVA: 0x00B6A309 File Offset: 0x00B68509
		public static bool CreateInstance()
		{
			if (RogueBattleController._Instance != null)
			{
				return true;
			}
			RogueBattleController._Instance = new RogueBattleController();
			return true;
		}

		// Token: 0x06028AB7 RID: 166583 RVA: 0x00B6A31F File Offset: 0x00B6851F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06028AB8 RID: 166584 RVA: 0x00B6A321 File Offset: 0x00B68521
		public static void ResetStaticDefaultValue()
		{
			RogueBattleController._Instance = null;
		}

		// Token: 0x06028AB9 RID: 166585 RVA: 0x00B6A329 File Offset: 0x00B68529
		static RogueBattleController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RogueBattleController.CreateStaticDefaultValue), new Action(RogueBattleController.ResetStaticDefaultValue));
		}

		// Token: 0x040161E8 RID: 90600
		private static RogueBattleController _Instance;
	}
}
