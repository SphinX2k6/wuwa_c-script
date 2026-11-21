using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035E8 RID: 13800
	[NullableContext(1)]
	[Nullable(0)]
	public class ViewHotKeyHandleContainer
	{
		// Token: 0x06023254 RID: 143956 RVA: 0x009FCEC4 File Offset: 0x009FB0C4
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

		// Token: 0x06023255 RID: 143957 RVA: 0x009FCF4C File Offset: 0x009FB14C
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

		// Token: 0x06023256 RID: 143958 RVA: 0x009FCFB4 File Offset: 0x009FB1B4
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

		// Token: 0x06023257 RID: 143959 RVA: 0x009FD048 File Offset: 0x009FB248
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

		// Token: 0x06023258 RID: 143960 RVA: 0x009FD070 File Offset: 0x009FB270
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

		// Token: 0x06023259 RID: 143961 RVA: 0x009FD108 File Offset: 0x009FB308
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

		// Token: 0x0602325A RID: 143962 RVA: 0x009FD194 File Offset: 0x009FB394
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

		// Token: 0x0602325B RID: 143963 RVA: 0x009FD240 File Offset: 0x009FB440
		public void RegisterOpenViewFunc(EUiViewName viewName, Action @delegate)
		{
			this.ViewNameOpenFuncMapping[viewName] = @delegate;
		}

		// Token: 0x0602325C RID: 143964 RVA: 0x009FD24F File Offset: 0x009FB44F
		public void RegisterCloseViewFunc(EUiViewName viewName, Action @delegate)
		{
			this.ViewNameCloseFuncMapping[viewName] = @delegate;
		}

		// Token: 0x04013D67 RID: 81255
		private readonly Dictionary<EUiViewName, List<ViewHotKeyHandle>> ViewNameViewHotKeyHandleMapping = new Dictionary<EUiViewName, List<ViewHotKeyHandle>>();

		// Token: 0x04013D68 RID: 81256
		private readonly Dictionary<EUiViewName, Action> ViewNameOpenFuncMapping = new Dictionary<EUiViewName, Action>();

		// Token: 0x04013D69 RID: 81257
		private readonly Dictionary<EUiViewName, Action> ViewNameCloseFuncMapping = new Dictionary<EUiViewName, Action>();
	}
}
