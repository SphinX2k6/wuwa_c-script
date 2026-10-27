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
	// Token: 0x02005E57 RID: 24151
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class BattleViewDynamicUIController : UiControllerBase
	{
		// Token: 0x0603D68F RID: 251535 RVA: 0x00ED0330 File Offset: 0x00ECE530
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0603D690 RID: 251536 RVA: 0x00ED0333 File Offset: 0x00ECE533
		protected override bool OnClear()
		{
			this.PendingUITypes.Clear();
			this.ClearAllDynamicUI();
			this.CurrentBattleView = null;
			return true;
		}

		// Token: 0x0603D691 RID: 251537 RVA: 0x00ED034E File Offset: 0x00ECE54E
		protected override bool OnLeaveLevel()
		{
			this.PendingUITypes.Clear();
			this.ClearAllDynamicUI();
			this.CurrentBattleView = null;
			return true;
		}

		// Token: 0x0603D692 RID: 251538 RVA: 0x00ED0369 File Offset: 0x00ECE569
		public void RegisterBattleView(BattleView battleView)
		{
			this.CurrentBattleView = battleView;
			this.FlushPendingUITypes();
		}

		// Token: 0x0603D693 RID: 251539 RVA: 0x00ED0378 File Offset: 0x00ECE578
		public void UnregisterBattleView(BattleView battleView)
		{
			if (this.CurrentBattleView == battleView)
			{
				this.PendingUITypes.Clear();
				this.ClearAllDynamicUI();
				this.CurrentBattleView = null;
			}
		}

		// Token: 0x0603D694 RID: 251540 RVA: 0x00ED039C File Offset: 0x00ECE59C
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

		// Token: 0x0603D695 RID: 251541 RVA: 0x00ED0520 File Offset: 0x00ECE720
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

		// Token: 0x0603D696 RID: 251542 RVA: 0x00ED0584 File Offset: 0x00ECE784
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

		// Token: 0x0603D697 RID: 251543 RVA: 0x00ED0600 File Offset: 0x00ECE800
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

		// Token: 0x0603D698 RID: 251544 RVA: 0x00ED0664 File Offset: 0x00ECE864
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

		// Token: 0x0603D699 RID: 251545 RVA: 0x00ED06DC File Offset: 0x00ECE8DC
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

		// Token: 0x0603D69A RID: 251546 RVA: 0x00ED0728 File Offset: 0x00ECE928
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

		// Token: 0x17008E73 RID: 36467
		// (get) Token: 0x0603D69B RID: 251547 RVA: 0x00ED075D File Offset: 0x00ECE95D
		public static BattleViewDynamicUIController Instance
		{
			get
			{
				return BattleViewDynamicUIController._Instance;
			}
		}

		// Token: 0x0603D69C RID: 251548 RVA: 0x00ED0764 File Offset: 0x00ECE964
		public static BattleViewDynamicUIController GetOrCreateInstance()
		{
			if (BattleViewDynamicUIController._Instance == null)
			{
				BattleViewDynamicUIController.CreateInstance();
			}
			return BattleViewDynamicUIController._Instance;
		}

		// Token: 0x0603D69D RID: 251549 RVA: 0x00ED0778 File Offset: 0x00ECE978
		public static bool CreateInstance()
		{
			if (BattleViewDynamicUIController._Instance != null)
			{
				return true;
			}
			BattleViewDynamicUIController._Instance = new BattleViewDynamicUIController();
			return true;
		}

		// Token: 0x0603D69E RID: 251550 RVA: 0x00ED078E File Offset: 0x00ECE98E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603D69F RID: 251551 RVA: 0x00ED0790 File Offset: 0x00ECE990
		public static void ResetStaticDefaultValue()
		{
			BattleViewDynamicUIController._Instance = null;
		}

		// Token: 0x0603D6A0 RID: 251552 RVA: 0x00ED0798 File Offset: 0x00ECE998
		static BattleViewDynamicUIController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BattleViewDynamicUIController.CreateStaticDefaultValue), new Action(BattleViewDynamicUIController.ResetStaticDefaultValue));
		}

		// Token: 0x040200AB RID: 131243
		[Nullable(2)]
		private BattleView CurrentBattleView;

		// Token: 0x040200AC RID: 131244
		private readonly Dictionary<EBattleViewDynamicUIType, DynamicUIRecord> DynamicUIMap = new Dictionary<EBattleViewDynamicUIType, DynamicUIRecord>();

		// Token: 0x040200AD RID: 131245
		private bool IsClearing;

		// Token: 0x040200AE RID: 131246
		private readonly List<EBattleViewDynamicUIType> PendingUITypes = new List<EBattleViewDynamicUIType>();

		// Token: 0x040200AF RID: 131247
		[Nullable(2)]
		private static BattleViewDynamicUIController _Instance;
	}
}
