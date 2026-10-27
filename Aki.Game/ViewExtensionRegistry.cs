using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001BD9 RID: 7129
[NullableContext(1)]
[Nullable(0)]
public class ViewExtensionRegistry
{
	// Token: 0x0600D489 RID: 54409 RVA: 0x0030EB24 File Offset: 0x0030CD24
	public static List<IViewExtension> AttachAll(List<IViewExtension> all)
	{
		List<IViewExtension> list = new List<IViewExtension>();
		foreach (IViewExtension viewExtension in all)
		{
			try
			{
				if (viewExtension.ShouldActivate())
				{
					list.Add(viewExtension);
				}
			}
			catch (Exception item)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Formation;
				ELogAuthor author = ELogAuthor.SYB;
				string message = "[ViewExtensionRegistry] ShouldActivate failed";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("err", item);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}
		foreach (IViewExtension viewExtension2 in list)
		{
			try
			{
				viewExtension2.OnViewStart();
			}
			catch (Exception item2)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Formation;
				ELogAuthor author2 = ELogAuthor.SYB;
				string message2 = "[ViewExtensionRegistry] OnViewStart failed";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("err", item2);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
		}
		return list;
	}

	// Token: 0x0600D48A RID: 54410 RVA: 0x0030EC34 File Offset: 0x0030CE34
	public static void DetachAll(List<IViewExtension> extensions)
	{
		foreach (IViewExtension viewExtension in extensions)
		{
			try
			{
				viewExtension.OnDetach();
			}
			catch (Exception item)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Formation;
				ELogAuthor author = ELogAuthor.SYB;
				string message = "[ViewExtensionRegistry] OnDetach failed";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("err", item);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}
	}

	// Token: 0x0600D48B RID: 54411 RVA: 0x0030ECB8 File Offset: 0x0030CEB8
	public static void InvokeViewRefresh(List<IViewExtension> extensions)
	{
		foreach (IViewExtension viewExtension in extensions)
		{
			try
			{
				viewExtension.OnViewRefresh();
			}
			catch (Exception item)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Formation;
				ELogAuthor author = ELogAuthor.SYB;
				string message = "[ViewExtensionRegistry] OnViewRefresh failed";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("err", item);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}
	}

	// Token: 0x0600D48C RID: 54412 RVA: 0x0030ED3C File Offset: 0x0030CF3C
	public static IEnterGateResult CollectEnterGate(List<IViewExtension> extensions)
	{
		foreach (IViewExtension viewExtension in extensions)
		{
			IEnterGateResult enterGateResult = viewExtension.ContributeEnterGate();
			if (enterGateResult != null && !enterGateResult.Ok)
			{
				return enterGateResult;
			}
		}
		return new IEnterGateResult
		{
			Ok = true
		};
	}
}
