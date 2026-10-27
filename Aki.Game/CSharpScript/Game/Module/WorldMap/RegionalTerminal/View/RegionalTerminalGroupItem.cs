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
	// Token: 0x02004858 RID: 18520
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RegionalTerminalGroupItem : GridProxyAbstract<RegionalTerminalGroupData>
	{
		// Token: 0x06030772 RID: 198514 RVA: 0x00B40D0C File Offset: 0x00B3EF0C
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

		// Token: 0x06030773 RID: 198515 RVA: 0x00B40E1C File Offset: 0x00B3F01C
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

		// Token: 0x06030774 RID: 198516 RVA: 0x00B40E95 File Offset: 0x00B3F095
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

		// Token: 0x06030775 RID: 198517 RVA: 0x00B40EC4 File Offset: 0x00B3F0C4
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

		// Token: 0x06030776 RID: 198518 RVA: 0x00B40F0F File Offset: 0x00B3F10F
		private RegionalTerminalGameplayItem CreateGameplayItem()
		{
			return new RegionalTerminalGameplayItem
			{
				OnClickToggleCallBack = new Action<bool, RegionalTerminalGameplayData>(this.OnClickToggle),
				IsToggleSelectOn = new Func<RegionalTerminalGameplayData, bool>(this.IsToggleSelectOn)
			};
		}

		// Token: 0x06030777 RID: 198519 RVA: 0x00B40F3C File Offset: 0x00B3F13C
		public void RefreshFunctional()
		{
			foreach (RegionalTerminalGameplayItem regionalTerminalGameplayItem in this.LayoutGameplay.GetLayoutItemList())
			{
				regionalTerminalGameplayItem.RefreshFunctional();
			}
		}

		// Token: 0x06030778 RID: 198520 RVA: 0x00B40F94 File Offset: 0x00B3F194
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

		// Token: 0x06030779 RID: 198521 RVA: 0x00B40FE1 File Offset: 0x00B3F1E1
		[NullableContext(2)]
		public RegionalTerminalGameplayItem GetGameplayItem(int gameplayId)
		{
			return this.LayoutGameplay.GetLayoutItemByKey(gameplayId);
		}

		// Token: 0x0603077A RID: 198522 RVA: 0x00B40FF4 File Offset: 0x00B3F1F4
		private void OnClickToggle(bool state, RegionalTerminalGameplayData data)
		{
			Action<bool, RegionalTerminalGameplayData, int> onClickToggleCallBack = this.OnClickToggleCallBack;
			if (onClickToggleCallBack == null)
			{
				return;
			}
			onClickToggleCallBack(state, data, this.Data.GroupId);
		}

		// Token: 0x0603077B RID: 198523 RVA: 0x00B41013 File Offset: 0x00B3F213
		private bool IsToggleSelectOn(RegionalTerminalGameplayData data)
		{
			Func<RegionalTerminalGameplayData, bool> isToggleSelectOnCallBack = this.IsToggleSelectOnCallBack;
			return isToggleSelectOnCallBack != null && isToggleSelectOnCallBack(data);
		}

		// Token: 0x0603077C RID: 198524 RVA: 0x00B41027 File Offset: 0x00B3F227
		public override object GetKey(RegionalTerminalGroupData data, int displayIndex)
		{
			return data.GroupId;
		}

		// Token: 0x0401A0A3 RID: 106659
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401A0A4 RID: 106660
		[Nullable(2)]
		private RegionalTerminalGroupData Data;

		// Token: 0x0401A0A5 RID: 106661
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RegionalTerminalGameplayItem, RegionalTerminalGameplayData> LayoutGameplay;

		// Token: 0x0401A0A6 RID: 106662
		private bool IsSelectOn;

		// Token: 0x0401A0A7 RID: 106663
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<bool, RegionalTerminalGameplayData, int> OnClickToggleCallBack;

		// Token: 0x0401A0A8 RID: 106664
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<RegionalTerminalGameplayData, bool> IsToggleSelectOnCallBack;

		// Token: 0x0200AB3E RID: 43838
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x0403409F RID: 213151
			public const int TexLogo = 0;

			// Token: 0x040340A0 RID: 213152
			public const int TexLogo2 = 1;

			// Token: 0x040340A1 RID: 213153
			public const int TxtName = 2;

			// Token: 0x040340A2 RID: 213154
			public const int SpriteName = 3;

			// Token: 0x040340A3 RID: 213155
			public const int LayoutGameplay = 4;

			// Token: 0x040340A4 RID: 213156
			public const int ItemGameplay = 5;

			// Token: 0x040340A5 RID: 213157
			public const int ItemSelectOn = 6;
		}
	}
}
