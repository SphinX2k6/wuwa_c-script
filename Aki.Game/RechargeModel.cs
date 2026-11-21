using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001C2B RID: 7211
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class RechargeModel : ModelBase
{
	// Token: 0x06011EB5 RID: 73397 RVA: 0x00546458 File Offset: 0x00544658
	public void SetRechargeInfo(int payId, string amount, string productId)
	{
		RechargeInfo rechargeInfo;
		if (!this.RechargeInfoMap.TryGetValue(payId, out rechargeInfo))
		{
			rechargeInfo = new RechargeInfo();
		}
		rechargeInfo.Init(payId, this.FormatNumberString(amount), productId);
		this.RechargeInfoMap[payId] = rechargeInfo;
	}

	// Token: 0x06011EB6 RID: 73398 RVA: 0x00546498 File Offset: 0x00544698
	public string GetPayIdAmount(int payId)
	{
		RechargeInfo rechargeInfo;
		if (this.RechargeInfoMap.TryGetValue(payId, out rechargeInfo))
		{
			return rechargeInfo.Amount;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Shop;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "获取PayId的服务器价格失败";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", payId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return "0";
	}

	// Token: 0x06011EB7 RID: 73399 RVA: 0x005464F0 File Offset: 0x005446F0
	private string FormatNumberString(string s)
	{
		float num;
		if (!float.TryParse(s, out num))
		{
			return s;
		}
		string text = num.ToString();
		int num2 = text.IndexOf('.');
		if (num2 == -1 || (num2 != -1 && text.Length - num2 - 1 == 1))
		{
			return num.ToString("F2");
		}
		return text;
	}

	// Token: 0x06011EB8 RID: 73400 RVA: 0x00546540 File Offset: 0x00544740
	public string GetPayIdProductId(int payId)
	{
		RechargeInfo rechargeInfo;
		if (this.RechargeInfoMap.TryGetValue(payId, out rechargeInfo))
		{
			return rechargeInfo.ProductId;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Shop;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "获取PayId的商品名称价格失败";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", payId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return "";
	}

	// Token: 0x17001B36 RID: 6966
	// (get) Token: 0x06011EB9 RID: 73401 RVA: 0x00546595 File Offset: 0x00544795
	public static RechargeModel Instance
	{
		get
		{
			return RechargeModel._Instance;
		}
	}

	// Token: 0x06011EBA RID: 73402 RVA: 0x0054659C File Offset: 0x0054479C
	public static RechargeModel GetOrCreateInstance()
	{
		if (RechargeModel._Instance == null)
		{
			RechargeModel.CreateInstance();
		}
		return RechargeModel._Instance;
	}

	// Token: 0x06011EBB RID: 73403 RVA: 0x005465B0 File Offset: 0x005447B0
	public static bool CreateInstance()
	{
		if (RechargeModel._Instance != null)
		{
			return true;
		}
		RechargeModel._Instance = new RechargeModel();
		return true;
	}

	// Token: 0x06011EBC RID: 73404 RVA: 0x005465C6 File Offset: 0x005447C6
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011EBD RID: 73405 RVA: 0x005465C8 File Offset: 0x005447C8
	public static void ResetStaticDefaultValue()
	{
		RechargeModel._Instance = null;
	}

	// Token: 0x06011EBE RID: 73406 RVA: 0x005465D0 File Offset: 0x005447D0
	static RechargeModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RechargeModel.CreateStaticDefaultValue), new Action(RechargeModel.ResetStaticDefaultValue));
	}

	// Token: 0x04009C38 RID: 39992
	private readonly Dictionary<int, RechargeInfo> RechargeInfoMap = new Dictionary<int, RechargeInfo>();

	// Token: 0x04009C39 RID: 39993
	[Nullable(2)]
	private static RechargeModel _Instance;
}
