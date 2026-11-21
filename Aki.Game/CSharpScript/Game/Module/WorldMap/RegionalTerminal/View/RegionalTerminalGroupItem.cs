using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.WorldMap.RegionalTerminal.Data;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.RegionalTerminal.View
{
	// Token: 0x02003789 RID: 14217
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RegionalTerminalGroupItem : GridProxyAbstract<RegionalTerminalGroupData>
	{
		// Token: 0x06024F41 RID: 151361 RVA: 0x00A70F50 File Offset: 0x00A6F150
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06024F42 RID: 151362 RVA: 0x00A71060 File Offset: 0x00A6F260
		protected override void OnStart()
		{
			this.LayoutGameplay = new GenericLayout<RegionalTerminalGameplayItem, RegionalTerminalGameplayData>(base.GetGridLayout(4), new Func<RegionalTerminalGameplayItem>(this.CreateGameplayItem), null, true, true);
			AUIBaseActor auibaseActor = base.GetGridLayout(4).GetOwner() as AUIBaseActor;
			if (auibaseActor != null)
			{
				auibaseActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnEventSequence));
			}
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			base.GetItem(6).SetUIActive(false);
		}

		// Token: 0x06024F43 RID: 151363 RVA: 0x00A710D9 File Offset: 0x00A6F2D9
		private void OnEventSequence(string sequenceName, string eventName)
		{
			if (sequenceName == "Start" && eventName == "Start")
			{
				GenericLayout<RegionalTerminalGameplayItem, RegionalTerminalGameplayData> layoutGameplay = this.LayoutGameplay;
				if (layoutGameplay == null)
				{
					return;
				}
				layoutGameplay.PlayGridAnim();
			}
		}

		// Token: 0x06024F44 RID: 151364 RVA: 0x00A71108 File Offset: 0x00A6F308
		public override UniTask RefreshAsync(RegionalTerminalGroupData data, bool isSelected, int gridIndex)
		{
			RegionalTerminalGroupItem.<RefreshAsync>d__10 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.data = data;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<RegionalTerminalGroupItem.<RefreshAsync>d__10>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024F45 RID: 151365 RVA: 0x00A71153 File Offset: 0x00A6F353
		private RegionalTerminalGameplayItem CreateGameplayItem()
		{
			return new RegionalTerminalGameplayItem
			{
				OnClickToggleCallBack = new Action<bool, RegionalTerminalGameplayData>(this.OnClickToggle),
				IsToggleSelectOn = new Func<RegionalTerminalGameplayData, bool>(this.IsToggleSelectOn)
			};
		}

		// Token: 0x06024F46 RID: 151366 RVA: 0x00A71180 File Offset: 0x00A6F380
		public void RefreshFunctional()
		{
			foreach (RegionalTerminalGameplayItem regionalTerminalGameplayItem in this.LayoutGameplay.GetLayoutItemList())
			{
				regionalTerminalGameplayItem.RefreshFunctional();
			}
		}

		// Token: 0x06024F47 RID: 151367 RVA: 0x00A711D8 File Offset: 0x00A6F3D8
		public void SetSelectOn(bool state)
		{
			if (this.IsSelectOn == state)
			{
				return;
			}
			this.IsSelectOn = state;
			base.GetItem(6).SetUIActive(state);
			if (state)
			{
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer == null)
				{
					return;
				}
				levelSequencePlayer.PlayOrReplaySequenceByName("Select", false, null);
			}
		}

		// Token: 0x06024F48 RID: 151368 RVA: 0x00A71225 File Offset: 0x00A6F425
		[NullableContext(2)]
		public RegionalTerminalGameplayItem GetGameplayItem(int gameplayId)
		{
			return this.LayoutGameplay.GetLayoutItemByKey(gameplayId);
		}

		// Token: 0x06024F49 RID: 151369 RVA: 0x00A71238 File Offset: 0x00A6F438
		private void OnClickToggle(bool state, RegionalTerminalGameplayData data)
		{
			Action<bool, RegionalTerminalGameplayData, int> onClickToggleCallBack = this.OnClickToggleCallBack;
			if (onClickToggleCallBack == null)
			{
				return;
			}
			onClickToggleCallBack(state, data, this.Data.GroupId);
		}

		// Token: 0x06024F4A RID: 151370 RVA: 0x00A71257 File Offset: 0x00A6F457
		private bool IsToggleSelectOn(RegionalTerminalGameplayData data)
		{
			Func<RegionalTerminalGameplayData, bool> isToggleSelectOnCallBack = this.IsToggleSelectOnCallBack;
			return isToggleSelectOnCallBack != null && isToggleSelectOnCallBack(data);
		}

		// Token: 0x06024F4B RID: 151371 RVA: 0x00A7126B File Offset: 0x00A6F46B
		public override object GetKey(RegionalTerminalGroupData data, int displayIndex)
		{
			return data.GroupId;
		}

		// Token: 0x04014757 RID: 83799
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04014758 RID: 83800
		[Nullable(2)]
		private RegionalTerminalGroupData Data;

		// Token: 0x04014759 RID: 83801
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RegionalTerminalGameplayItem, RegionalTerminalGameplayData> LayoutGameplay;

		// Token: 0x0401475A RID: 83802
		private bool IsSelectOn;

		// Token: 0x0401475B RID: 83803
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<bool, RegionalTerminalGameplayData, int> OnClickToggleCallBack;

		// Token: 0x0401475C RID: 83804
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<RegionalTerminalGameplayData, bool> IsToggleSelectOnCallBack;

		// Token: 0x020094EC RID: 38124
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x0402E817 RID: 190487
			public const int TexLogo = 0;

			// Token: 0x0402E818 RID: 190488
			public const int TexLogo2 = 1;

			// Token: 0x0402E819 RID: 190489
			public const int TxtName = 2;

			// Token: 0x0402E81A RID: 190490
			public const int SpriteName = 3;

			// Token: 0x0402E81B RID: 190491
			public const int LayoutGameplay = 4;

			// Token: 0x0402E81C RID: 190492
			public const int ItemGameplay = 5;

			// Token: 0x0402E81D RID: 190493
			public const int ItemSelectOn = 6;
		}
	}
}
