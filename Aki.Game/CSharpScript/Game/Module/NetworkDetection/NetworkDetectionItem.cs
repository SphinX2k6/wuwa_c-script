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
	// Token: 0x02004343 RID: 17219
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class NetworkDetectionItem : GridProxyAbstract<INetworkDetectionItemData>
	{
		// Token: 0x0602B7B7 RID: 178103 RVA: 0x00C38158 File Offset: 0x00C36358
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

		// Token: 0x0602B7B8 RID: 178104 RVA: 0x00C38245 File Offset: 0x00C36445
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0602B7B9 RID: 178105 RVA: 0x00C38258 File Offset: 0x00C36458
		[NullableContext(1)]
		public override void Refresh(INetworkDetectionItemData data, bool isSelected, int gridIndex)
		{
			this.NetworkDetectionItemData = data;
			this.UpdateView();
		}

		// Token: 0x0602B7BA RID: 178106 RVA: 0x00C38268 File Offset: 0x00C36468
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

		// Token: 0x0602B7BB RID: 178107 RVA: 0x00C3834C File Offset: 0x00C3654C
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

		// Token: 0x0602B7BC RID: 178108 RVA: 0x00C3839C File Offset: 0x00C3659C
		public UniTask<bool> Proceed()
		{
			NetworkDetectionItem.<Proceed>d__8 <Proceed>d__;
			<Proceed>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<Proceed>d__.<>4__this = this;
			<Proceed>d__.<>1__state = -1;
			<Proceed>d__.<>t__builder.Start<NetworkDetectionItem.<Proceed>d__8>(ref <Proceed>d__);
			return <Proceed>d__.<>t__builder.Task;
		}

		// Token: 0x0602B7BD RID: 178109 RVA: 0x00C383DF File Offset: 0x00C365DF
		[NullableContext(1)]
		public override object GetKey(INetworkDetectionItemData data, int displayIndex)
		{
			return displayIndex;
		}

		// Token: 0x040177EB RID: 96235
		[Nullable(2)]
		private INetworkDetectionItemData NetworkDetectionItemData;

		// Token: 0x040177EC RID: 96236
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x02009FFD RID: 40957
		private enum EComponents
		{
			// Token: 0x04031B4F RID: 203599
			TxtName,
			// Token: 0x04031B50 RID: 203600
			ErrorIcon,
			// Token: 0x04031B51 RID: 203601
			CorrectIcon,
			// Token: 0x04031B52 RID: 203602
			ProceedIcon,
			// Token: 0x04031B53 RID: 203603
			PnlError,
			// Token: 0x04031B54 RID: 203604
			TxtError
		}
	}
}
