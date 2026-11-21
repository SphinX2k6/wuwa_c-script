using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.InputSetting;

namespace CSharpScript.Game.Controller
{
	// Token: 0x020063FB RID: 25595
	[NullableContext(1)]
	[Nullable(0)]
	public class CustomKeyActionData
	{
		// Token: 0x0603E11D RID: 254237 RVA: 0x01201B0C File Offset: 0x011FFD0C
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

		// Token: 0x0603E11E RID: 254238 RVA: 0x01201B44 File Offset: 0x011FFD44
		public void ResetAllCustomAction(string keyName)
		{
			this.CustomKeyActionMap.Remove(keyName);
		}

		// Token: 0x0603E11F RID: 254239 RVA: 0x01201B54 File Offset: 0x011FFD54
		public void ResetCustomAction(string keyName, string actionName)
		{
			HashSet<string> hashSet;
			if (!this.CustomKeyActionMap.TryGetValue(keyName, out hashSet))
			{
				return;
			}
			hashSet.Remove(actionName);
		}

		// Token: 0x0603E120 RID: 254240 RVA: 0x01201B7C File Offset: 0x011FFD7C
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

		// Token: 0x0603E121 RID: 254241 RVA: 0x01201BAC File Offset: 0x011FFDAC
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

		// Token: 0x0603E122 RID: 254242 RVA: 0x01201C78 File Offset: 0x011FFE78
		public void SetActionEnable(string actionName, bool bEnable)
		{
			if (bEnable)
			{
				this.DisableActionSet.Remove(actionName);
				return;
			}
			this.DisableActionSet.Add(actionName);
		}

		// Token: 0x0603E123 RID: 254243 RVA: 0x01201C98 File Offset: 0x011FFE98
		public bool IsActionEnable(string actionName)
		{
			return this.CacheReasonSet.Count > 0 || !this.DisableActionSet.Contains(actionName);
		}

		// Token: 0x0603E124 RID: 254244 RVA: 0x01201CBC File Offset: 0x011FFEBC
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

		// Token: 0x0603E125 RID: 254245 RVA: 0x01201D30 File Offset: 0x011FFF30
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

		// Token: 0x0603E126 RID: 254246 RVA: 0x01201DA2 File Offset: 0x011FFFA2
		public void Clear()
		{
			this.CustomKeyActionMap.Clear();
			this.CacheReasonSet.Clear();
			this.DisableActionSet.Clear();
		}

		// Token: 0x04020F0E RID: 134926
		private readonly Dictionary<string, HashSet<string>> CustomKeyActionMap = new Dictionary<string, HashSet<string>>();

		// Token: 0x04020F0F RID: 134927
		private readonly HashSet<string> CacheReasonSet = new HashSet<string>();

		// Token: 0x04020F10 RID: 134928
		private readonly HashSet<string> DisableActionSet = new HashSet<string>();
	}
}
