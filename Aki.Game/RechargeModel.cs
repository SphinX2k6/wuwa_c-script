using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002740 RID: 10048
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class RechargeModel : ModelBase
{
	// Token: 0x060149D3 RID: 84435 RVA: 0x0053774C File Offset: 0x0053594C
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

	// Token: 0x060149D4 RID: 84436 RVA: 0x0053778C File Offset: 0x0053598C
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

	// Token: 0x060149D5 RID: 84437 RVA: 0x005377E4 File Offset: 0x005359E4
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

	// Token: 0x060149D6 RID: 84438 RVA: 0x00537834 File Offset: 0x00535A34
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

	// Token: 0x17001AFE RID: 6910
	// (get) Token: 0x060149D7 RID: 84439 RVA: 0x00537889 File Offset: 0x00535A89
	public static RechargeModel Instance
	{
		get
		{
			return RechargeModel._Instance;
		}
	}

	// Token: 0x060149D8 RID: 84440 RVA: 0x00537890 File Offset: 0x00535A90
	public static RechargeModel GetOrCreateInstance()
	{
		if (RechargeModel._Instance == null)
		{
			RechargeModel.CreateInstance();
		}
		return RechargeModel._Instance;
	}

	// Token: 0x060149D9 RID: 84441 RVA: 0x005378A4 File Offset: 0x00535AA4
	public static bool CreateInstance()
	{
		if (RechargeModel._Instance != null)
		{
			return true;
		}
		RechargeModel._Instance = new RechargeModel();
		return true;
	}

	// Token: 0x060149DA RID: 84442 RVA: 0x005378BA File Offset: 0x00535ABA
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060149DB RID: 84443 RVA: 0x005378BC File Offset: 0x00535ABC
	public static void ResetStaticDefaultValue()
	{
		RechargeModel._Instance = null;
	}

	// Token: 0x060149DC RID: 84444 RVA: 0x005378C4 File Offset: 0x00535AC4
	static RechargeModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RechargeModel.CreateStaticDefaultValue), new Action(RechargeModel.ResetStaticDefaultValue));
	}

	// Token: 0x04009AE0 RID: 39648
	private readonly Dictionary<int, RechargeInfo> RechargeInfoMap = new Dictionary<int, RechargeInfo>();

	// Token: 0x04009AE1 RID: 39649
	[Nullable(2)]
	private static RechargeModel _Instance;
}
