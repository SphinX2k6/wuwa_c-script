using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Launcher.NetworkDetection;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.NetworkDetection
{
	// Token: 0x02005360 RID: 21344
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class NetworkDetectionItem : GridProxyAbstract<INetworkDetectionItemData>
	{
		// Token: 0x06036871 RID: 223345 RVA: 0x00CE92D0 File Offset: 0x00CE74D0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06036872 RID: 223346 RVA: 0x00CE93BD File Offset: 0x00CE75BD
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06036873 RID: 223347 RVA: 0x00CE93D0 File Offset: 0x00CE75D0
		[NullableContext(1)]
		public override void Refresh(INetworkDetectionItemData data, bool isSelected, int gridIndex)
		{
			this.NetworkDetectionItemData = data;
			this.UpdateView();
		}

		// Token: 0x06036874 RID: 223348 RVA: 0x00CE93E0 File Offset: 0x00CE75E0
		private void UpdateView()
		{
			INetworkDetectionEntry entryData = this.NetworkDetectionItemData.EntryData;
			INetworkDetectionResult result = this.NetworkDetectionItemData.Result;
			base.GetText(0).ShowTextNew(entryData.NameLocalKey);
			base.GetSprite(1).SetUIActive(result != null && !result.Success);
			base.GetSprite(2).SetUIActive(result != null && result.Success);
			base.GetSprite(3).SetUIActive(this.NetworkDetectionItemData.Proceed);
			bool flag = result != null && !result.Success && result != null && result.Code != null;
			if (flag)
			{
				string genericErrorCodeTips = LauncherNetworkDetectionModel.GetGenericErrorCodeTips(entryData.Type, result.Code.Value, result);
				base.GetText(5).SetText(genericErrorCodeTips, true);
				this.NetworkDetectionItemData.ErrorCodeText = genericErrorCodeTips;
			}
			base.GetItem(4).SetUIActive(flag);
		}

		// Token: 0x06036875 RID: 223349 RVA: 0x00CE94C4 File Offset: 0x00CE76C4
		protected override void OnBeforeDestroy()
		{
			if (this.NetworkDetectionItemData.EntryData.Type == ENetworkDetectionType.UdpPort)
			{
				if (LauncherNetworkDetectionController.Instance.GetGateWayUdpCheckState())
				{
					UKuroNetworkDetection.AbortGatewayUdpReachable();
					return;
				}
				INetworkDetectionResult result = this.NetworkDetectionItemData.Result;
				UKuroNetworkDetection.DetectionFinish(result != null && result.Success);
			}
		}

		// Token: 0x06036876 RID: 223350 RVA: 0x00CE9514 File Offset: 0x00CE7714
		public UniTask<bool> Proceed()
		{
			NetworkDetectionItem.<Proceed>d__8 <Proceed>d__;
			<Proceed>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<Proceed>d__.<>4__this = this;
			<Proceed>d__.<>1__state = -1;
			<Proceed>d__.<>t__builder.Start<NetworkDetectionItem.<Proceed>d__8>(ref <Proceed>d__);
			return <Proceed>d__.<>t__builder.Task;
		}

		// Token: 0x06036877 RID: 223351 RVA: 0x00CE9557 File Offset: 0x00CE7757
		[NullableContext(1)]
		public override object GetKey(INetworkDetectionItemData data, int displayIndex)
		{
			return displayIndex;
		}

		// Token: 0x0401CD57 RID: 118103
		[Nullable(2)]
		private INetworkDetectionItemData NetworkDetectionItemData;

		// Token: 0x0401CD58 RID: 118104
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200B5C4 RID: 46532
		private enum EComponents
		{
			// Token: 0x040370F7 RID: 225527
			TxtName,
			// Token: 0x040370F8 RID: 225528
			ErrorIcon,
			// Token: 0x040370F9 RID: 225529
			CorrectIcon,
			// Token: 0x040370FA RID: 225530
			ProceedIcon,
			// Token: 0x040370FB RID: 225531
			PnlError,
			// Token: 0x040370FC RID: 225532
			TxtError
		}
	}
}
