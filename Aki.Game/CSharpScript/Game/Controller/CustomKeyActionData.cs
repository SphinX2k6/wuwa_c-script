using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.InputSetting;

namespace CSharpScript.Game.Controller
{
	// Token: 0x0200727C RID: 29308
	[NullableContext(1)]
	[Nullable(0)]
	public class CustomKeyActionData
	{
		// Token: 0x06047D5D RID: 294237 RVA: 0x012612CC File Offset: 0x0125F4CC
		public void SetCustomAction(string keyName, string actionName)
		{
			HashSet<string> hashSet;
			if (!this.CustomKeyActionMap.TryGetValue(keyName, out hashSet))
			{
				hashSet = new HashSet<string>();
				this.CustomKeyActionMap.Add(keyName, hashSet);
			}
			hashSet.Add(actionName);
		}

		// Token: 0x06047D5E RID: 294238 RVA: 0x01261304 File Offset: 0x0125F504
		public void ResetAllCustomAction(string keyName)
		{
			this.CustomKeyActionMap.Remove(keyName);
		}

		// Token: 0x06047D5F RID: 294239 RVA: 0x01261314 File Offset: 0x0125F514
		public void ResetCustomAction(string keyName, string actionName)
		{
			HashSet<string> hashSet;
			if (!this.CustomKeyActionMap.TryGetValue(keyName, out hashSet))
			{
				return;
			}
			hashSet.Remove(actionName);
		}

		// Token: 0x06047D60 RID: 294240 RVA: 0x0126133C File Offset: 0x0125F53C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public IReadOnlySet<string> GetCustomActionName(string keyName)
		{
			if (this.CacheReasonSet.Count > 0)
			{
				return null;
			}
			HashSet<string> result;
			if (!this.CustomKeyActionMap.TryGetValue(keyName, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06047D61 RID: 294241 RVA: 0x0126136C File Offset: 0x0125F56C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> GetCurrentPlatformCustomActionKeyNameList(string actionName)
		{
			if (this.CustomKeyActionMap == null)
			{
				return null;
			}
			bool flag = Info.Instance.IsInKeyBoard();
			bool flag2 = Info.Instance.IsInGamepad();
			List<string> list = new List<string>();
			foreach (KeyValuePair<string, HashSet<string>> keyValuePair in this.CustomKeyActionMap)
			{
				string key = keyValuePair.Key;
				if (keyValuePair.Value.Contains(actionName))
				{
					if (flag && InputSettings.Instance.IsKeyboardKey(key))
					{
						list.Add(key);
					}
					else if (flag2 && InputSettings.Instance.IsGamepadKey(key))
					{
						list.Add(key);
					}
				}
			}
			if (list.Count <= 0)
			{
				return null;
			}
			return list;
		}

		// Token: 0x06047D62 RID: 294242 RVA: 0x01261438 File Offset: 0x0125F638
		public void SetActionEnable(string actionName, bool bEnable)
		{
			if (bEnable)
			{
				this.DisableActionSet.Remove(actionName);
				return;
			}
			this.DisableActionSet.Add(actionName);
		}

		// Token: 0x06047D63 RID: 294243 RVA: 0x01261458 File Offset: 0x0125F658
		public bool IsActionEnable(string actionName)
		{
			return this.CacheReasonSet.Count > 0 || !this.DisableActionSet.Contains(actionName);
		}

		// Token: 0x06047D64 RID: 294244 RVA: 0x0126147C File Offset: 0x0125F67C
		public unsafe void DisableCustomInputData(string reason)
		{
			this.CacheReasonSet.Add(reason);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InputSettings;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[CustomAction]临时禁用自定义输入数据";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CacheReasonSet", this.CacheReasonSet);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x06047D65 RID: 294245 RVA: 0x012614F0 File Offset: 0x0125F6F0
		public unsafe void EnableCustomInputData(string reason)
		{
			this.CacheReasonSet.Remove(reason);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InputSettings;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[CustomAction]恢复使用自定义输入数据";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CacheReasonSet", this.CacheReasonSet);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x06047D66 RID: 294246 RVA: 0x01261562 File Offset: 0x0125F762
		public void Clear()
		{
			this.CustomKeyActionMap.Clear();
			this.CacheReasonSet.Clear();
			this.DisableActionSet.Clear();
		}

		// Token: 0x04025C4E RID: 154702
		private readonly Dictionary<string, HashSet<string>> CustomKeyActionMap = new Dictionary<string, HashSet<string>>();

		// Token: 0x04025C4F RID: 154703
		private readonly HashSet<string> CacheReasonSet = new HashSet<string>();

		// Token: 0x04025C50 RID: 154704
		private readonly HashSet<string> DisableActionSet = new HashSet<string>();
	}
}
