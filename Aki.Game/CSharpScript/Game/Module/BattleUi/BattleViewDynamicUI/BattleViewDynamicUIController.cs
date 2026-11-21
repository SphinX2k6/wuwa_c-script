using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.BattleViewDynamicUI
{
	// Token: 0x02004E3C RID: 20028
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class BattleViewDynamicUIController : UiControllerBase
	{
		// Token: 0x0603261F RID: 206367 RVA: 0x00E218A0 File Offset: 0x00E1FAA0
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x06032620 RID: 206368 RVA: 0x00E218A3 File Offset: 0x00E1FAA3
		protected override bool OnClear()
		{
			this.PendingUITypes.Clear();
			this.ClearAllDynamicUI();
			this.CurrentBattleView = null;
			return true;
		}

		// Token: 0x06032621 RID: 206369 RVA: 0x00E218BE File Offset: 0x00E1FABE
		protected override bool OnLeaveLevel()
		{
			this.PendingUITypes.Clear();
			this.ClearAllDynamicUI();
			this.CurrentBattleView = null;
			return true;
		}

		// Token: 0x06032622 RID: 206370 RVA: 0x00E218D9 File Offset: 0x00E1FAD9
		public void RegisterBattleView(BattleView battleView)
		{
			this.CurrentBattleView = battleView;
			this.FlushPendingUITypes();
		}

		// Token: 0x06032623 RID: 206371 RVA: 0x00E218E8 File Offset: 0x00E1FAE8
		public void UnregisterBattleView(BattleView battleView)
		{
			if (this.CurrentBattleView == battleView)
			{
				this.PendingUITypes.Clear();
				this.ClearAllDynamicUI();
				this.CurrentBattleView = null;
			}
		}

		// Token: 0x06032624 RID: 206372 RVA: 0x00E2190C File Offset: 0x00E1FB0C
		public void TryCreateDynamicUI(EBattleViewDynamicUIType uiType)
		{
			BattleViewDynamicUIConfig battleViewDynamicUIConfig;
			if (!BattleViewDynamicUIDefine.BattleViewDynamicUIConfigMap.TryGetValue(uiType, out battleViewDynamicUIConfig))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.LXH;
				string message = "[BattleViewDynamicUI] 未找到对应配置，请在 BattleViewDynamicUIDefine 中注册";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("uiType", uiType.ToString());
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (string.IsNullOrEmpty(battleViewDynamicUIConfig.ResourceId))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Battle;
				ELogAuthor author2 = ELogAuthor.LXH;
				string message2 = "[BattleViewDynamicUI] resourceId 为空";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("uiType", uiType.ToString());
				instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			BattleView currentBattleView = this.CurrentBattleView;
			if (currentBattleView == null || currentBattleView.IsDestroyOrDestroying)
			{
				if (!this.PendingUITypes.Contains(uiType))
				{
					this.PendingUITypes.Add(uiType);
				}
				return;
			}
			if (this.DynamicUIMap.ContainsKey(uiType))
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.Battle;
				ELogAuthor author3 = ELogAuthor.LXH;
				string message3 = "[BattleViewDynamicUI] 该 uiType 已存在或正在加载中，忽略重复创建请求";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("uiType", uiType.ToString());
				instance3.Warn(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				return;
			}
			UUIItem dynamicUIRootItem = currentBattleView.GetDynamicUIRootItem(battleViewDynamicUIConfig.ChildType);
			if (dynamicUIRootItem == null || !dynamicUIRootItem.IsValid())
			{
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.Battle;
				ELogAuthor author4 = ELogAuthor.LXH;
				string message4 = "[BattleViewDynamicUI] GetDynamicUIRootItem 返回无效节点，请检查配置";
				ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("uiType", uiType.ToString());
				instance4.Warn(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
				return;
			}
			this.DynamicUIMap[uiType] = new DynamicUIRecord
			{
				IsLoading = true
			};
			BattleViewDynamicUiBase panel = battleViewDynamicUIConfig.CreateUi();
			this.CreateDynamicUIAsync(uiType, battleViewDynamicUIConfig.ResourceId, dynamicUIRootItem, panel).Forget();
		}

		// Token: 0x06032625 RID: 206373 RVA: 0x00E21A90 File Offset: 0x00E1FC90
		public void TryDestroyDynamicUI(EBattleViewDynamicUIType uiType)
		{
			DynamicUIRecord uiRecord;
			if (!this.DynamicUIMap.TryGetValue(uiType, out uiRecord))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.LXH;
				string message = "[BattleViewDynamicUI] TryDestroyDynamicUI：未找到对应实例，可能已销毁或从未创建";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("uiType", uiType.ToString());
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.DynamicUIMap.Remove(uiType);
			BattleViewDynamicUIController.DestroyUIFromRecord(uiRecord);
		}

		// Token: 0x06032626 RID: 206374 RVA: 0x00E21AF4 File Offset: 0x00E1FCF4
		public void ClearAllDynamicUI()
		{
			if (this.DynamicUIMap.Count == 0)
			{
				return;
			}
			this.IsClearing = true;
			foreach (DynamicUIRecord uiRecord in this.DynamicUIMap.Values)
			{
				BattleViewDynamicUIController.DestroyUIFromRecord(uiRecord);
			}
			this.DynamicUIMap.Clear();
			this.IsClearing = false;
		}

		// Token: 0x06032627 RID: 206375 RVA: 0x00E21B70 File Offset: 0x00E1FD70
		private UniTask CreateDynamicUIAsync(EBattleViewDynamicUIType uiType, string resourceId, UUIItem parentItem, BattleViewDynamicUiBase panel)
		{
			BattleViewDynamicUIController.<CreateDynamicUIAsync>d__12 <CreateDynamicUIAsync>d__;
			<CreateDynamicUIAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateDynamicUIAsync>d__.<>4__this = this;
			<CreateDynamicUIAsync>d__.uiType = uiType;
			<CreateDynamicUIAsync>d__.resourceId = resourceId;
			<CreateDynamicUIAsync>d__.parentItem = parentItem;
			<CreateDynamicUIAsync>d__.panel = panel;
			<CreateDynamicUIAsync>d__.<>1__state = -1;
			<CreateDynamicUIAsync>d__.<>t__builder.Start<BattleViewDynamicUIController.<CreateDynamicUIAsync>d__12>(ref <CreateDynamicUIAsync>d__);
			return <CreateDynamicUIAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032628 RID: 206376 RVA: 0x00E21BD4 File Offset: 0x00E1FDD4
		private void OnUILoadCompleted(EBattleViewDynamicUIType uiType, BattleViewDynamicUiBase panel)
		{
			if (this.IsClearing)
			{
				if (!panel.IsDestroyOrDestroying)
				{
					panel.Destroy(null);
				}
				return;
			}
			if (!this.DynamicUIMap.ContainsKey(uiType))
			{
				if (!panel.IsDestroyOrDestroying)
				{
					panel.Destroy(null);
				}
				return;
			}
			if (panel.IsDestroyOrDestroying)
			{
				this.DynamicUIMap.Remove(uiType);
				return;
			}
			this.DynamicUIMap[uiType] = new DynamicUIRecord
			{
				Instance = panel,
				IsLoading = false
			};
		}

		// Token: 0x06032629 RID: 206377 RVA: 0x00E21C4C File Offset: 0x00E1FE4C
		private void FlushPendingUITypes()
		{
			if (this.PendingUITypes.Count == 0)
			{
				return;
			}
			EBattleViewDynamicUIType[] array = this.PendingUITypes.ToArray();
			this.PendingUITypes.Clear();
			foreach (EBattleViewDynamicUIType uiType in array)
			{
				this.TryCreateDynamicUI(uiType);
			}
		}

		// Token: 0x0603262A RID: 206378 RVA: 0x00E21C98 File Offset: 0x00E1FE98
		private static void DestroyUIFromRecord(DynamicUIRecord uiRecord)
		{
			if (uiRecord.IsLoading || uiRecord.Instance == null)
			{
				return;
			}
			BattleViewDynamicUiBase instance = uiRecord.Instance;
			if (instance.IsDestroyOrDestroying)
			{
				return;
			}
			instance.Destroy(null);
		}

		// Token: 0x17006245 RID: 25157
		// (get) Token: 0x0603262B RID: 206379 RVA: 0x00E21CCD File Offset: 0x00E1FECD
		public static BattleViewDynamicUIController Instance
		{
			get
			{
				return BattleViewDynamicUIController._Instance;
			}
		}

		// Token: 0x0603262C RID: 206380 RVA: 0x00E21CD4 File Offset: 0x00E1FED4
		public static BattleViewDynamicUIController GetOrCreateInstance()
		{
			if (BattleViewDynamicUIController._Instance == null)
			{
				BattleViewDynamicUIController.CreateInstance();
			}
			return BattleViewDynamicUIController._Instance;
		}

		// Token: 0x0603262D RID: 206381 RVA: 0x00E21CE8 File Offset: 0x00E1FEE8
		public static bool CreateInstance()
		{
			if (BattleViewDynamicUIController._Instance != null)
			{
				return true;
			}
			BattleViewDynamicUIController._Instance = new BattleViewDynamicUIController();
			return true;
		}

		// Token: 0x0603262E RID: 206382 RVA: 0x00E21CFE File Offset: 0x00E1FEFE
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603262F RID: 206383 RVA: 0x00E21D00 File Offset: 0x00E1FF00
		public static void ResetStaticDefaultValue()
		{
			BattleViewDynamicUIController._Instance = null;
		}

		// Token: 0x06032630 RID: 206384 RVA: 0x00E21D08 File Offset: 0x00E1FF08
		static BattleViewDynamicUIController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BattleViewDynamicUIController.CreateStaticDefaultValue), new Action(BattleViewDynamicUIController.ResetStaticDefaultValue));
		}

		// Token: 0x0401AB72 RID: 109426
		[Nullable(2)]
		private BattleView CurrentBattleView;

		// Token: 0x0401AB73 RID: 109427
		private readonly Dictionary<EBattleViewDynamicUIType, DynamicUIRecord> DynamicUIMap = new Dictionary<EBattleViewDynamicUIType, DynamicUIRecord>();

		// Token: 0x0401AB74 RID: 109428
		private bool IsClearing;

		// Token: 0x0401AB75 RID: 109429
		private readonly List<EBattleViewDynamicUIType> PendingUITypes = new List<EBattleViewDynamicUIType>();

		// Token: 0x0401AB76 RID: 109430
		[Nullable(2)]
		private static BattleViewDynamicUIController _Instance;
	}
}
