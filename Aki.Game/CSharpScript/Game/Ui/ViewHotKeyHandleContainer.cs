using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046B7 RID: 18103
	[NullableContext(1)]
	[Nullable(0)]
	public class ViewHotKeyHandleContainer
	{
		// Token: 0x0602EB08 RID: 191240 RVA: 0x00ACE5F0 File Offset: 0x00ACC7F0
		public void Add(ViewHotKeyHandle viewHotKeyHandle)
		{
			EUiViewName? viewName = viewHotKeyHandle.ViewName;
			if (viewName == null)
			{
				return;
			}
			EUiViewName value = viewName.Value;
			List<ViewHotKeyHandle> list;
			if (this.ViewNameViewHotKeyHandleMapping.TryGetValue(value, out list))
			{
				list.Add(viewHotKeyHandle);
			}
			else
			{
				this.ViewNameViewHotKeyHandleMapping[value] = new List<ViewHotKeyHandle>
				{
					viewHotKeyHandle
				};
			}
			Action callback;
			if (this.ViewNameOpenFuncMapping.TryGetValue(value, out callback))
			{
				viewHotKeyHandle.BindOpenViewCallback(callback);
			}
			Action callback2;
			if (this.ViewNameCloseFuncMapping.TryGetValue(value, out callback2))
			{
				viewHotKeyHandle.BindCloseViewCallback(callback2);
			}
		}

		// Token: 0x0602EB09 RID: 191241 RVA: 0x00ACE678 File Offset: 0x00ACC878
		public void Remove(ViewHotKeyHandle viewHotKeyHandle)
		{
			EUiViewName? viewName = viewHotKeyHandle.ViewName;
			if (viewName == null)
			{
				return;
			}
			EUiViewName value = viewName.Value;
			List<ViewHotKeyHandle> list;
			if (!this.ViewNameViewHotKeyHandleMapping.TryGetValue(value, out list))
			{
				return;
			}
			int num = list.IndexOf(viewHotKeyHandle);
			if (num < 0)
			{
				return;
			}
			viewHotKeyHandle.Destroy();
			list.RemoveAt(num);
			if (list.Count == 0)
			{
				this.ViewNameViewHotKeyHandleMapping.Remove(value);
			}
		}

		// Token: 0x0602EB0A RID: 191242 RVA: 0x00ACE6E0 File Offset: 0x00ACC8E0
		public void Clear()
		{
			foreach (List<ViewHotKeyHandle> list in this.ViewNameViewHotKeyHandleMapping.Values)
			{
				foreach (ViewHotKeyHandle viewHotKeyHandle in list)
				{
					viewHotKeyHandle.Destroy();
				}
			}
			this.ViewNameViewHotKeyHandleMapping.Clear();
		}

		// Token: 0x0602EB0B RID: 191243 RVA: 0x00ACE774 File Offset: 0x00ACC974
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public ViewHotKeyHandle[] Get(EUiViewName viewName)
		{
			List<ViewHotKeyHandle> list;
			if (this.ViewNameViewHotKeyHandleMapping.TryGetValue(viewName, out list))
			{
				return list.ToArray();
			}
			return null;
		}

		// Token: 0x0602EB0C RID: 191244 RVA: 0x00ACE79C File Offset: 0x00ACC99C
		public ViewHotKeyHandle[] GetAll()
		{
			List<ViewHotKeyHandle> list = new List<ViewHotKeyHandle>();
			foreach (List<ViewHotKeyHandle> list2 in this.ViewNameViewHotKeyHandleMapping.Values)
			{
				foreach (ViewHotKeyHandle item in list2)
				{
					list.Add(item);
				}
			}
			return list.ToArray();
		}

		// Token: 0x0602EB0D RID: 191245 RVA: 0x00ACE834 File Offset: 0x00ACCA34
		public void ForEach(Action<ViewHotKeyHandle> callback)
		{
			foreach (List<ViewHotKeyHandle> list in this.ViewNameViewHotKeyHandleMapping.Values)
			{
				foreach (ViewHotKeyHandle obj in list)
				{
					callback(obj);
				}
			}
		}

		// Token: 0x0602EB0E RID: 191246 RVA: 0x00ACE8C0 File Offset: 0x00ACCAC0
		public bool IsDataExist(int configId)
		{
			foreach (List<ViewHotKeyHandle> list in this.ViewNameViewHotKeyHandleMapping.Values)
			{
				foreach (ViewHotKeyHandle viewHotKeyHandle in list)
				{
					int? configId2 = viewHotKeyHandle.ConfigId;
					if (configId2.GetValueOrDefault() == configId & configId2 != null)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0602EB0F RID: 191247 RVA: 0x00ACE96C File Offset: 0x00ACCB6C
		public void RegisterOpenViewFunc(EUiViewName viewName, Action @delegate)
		{
			this.ViewNameOpenFuncMapping[viewName] = @delegate;
		}

		// Token: 0x0602EB10 RID: 191248 RVA: 0x00ACE97B File Offset: 0x00ACCB7B
		public void RegisterCloseViewFunc(EUiViewName viewName, Action @delegate)
		{
			this.ViewNameCloseFuncMapping[viewName] = @delegate;
		}

		// Token: 0x040196C2 RID: 104130
		private readonly Dictionary<EUiViewName, List<ViewHotKeyHandle>> ViewNameViewHotKeyHandleMapping = new Dictionary<EUiViewName, List<ViewHotKeyHandle>>();

		// Token: 0x040196C3 RID: 104131
		private readonly Dictionary<EUiViewName, Action> ViewNameOpenFuncMapping = new Dictionary<EUiViewName, Action>();

		// Token: 0x040196C4 RID: 104132
		private readonly Dictionary<EUiViewName, Action> ViewNameCloseFuncMapping = new Dictionary<EUiViewName, Action>();
	}
}
