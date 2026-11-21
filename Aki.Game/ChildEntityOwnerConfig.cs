using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Google.FlatBuffers;

// Token: 0x02002A6B RID: 10859
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ChildEntityOwnerConfig : ConfigBase
{
	// Token: 0x0601B8B9 RID: 112825 RVA: 0x0087CE10 File Offset: 0x0087B010
	protected override bool OnClear()
	{
		this.handleId = 0;
		return base.OnClear();
	}

	// Token: 0x0601B8BA RID: 112826 RVA: 0x0087CE20 File Offset: 0x0087B020
	[NullableContext(0)]
	[return: TupleElementNames(new string[]
	{
		"Success",
		"Data"
	})]
	public ValueTuple<bool, ChildEntityOwnerData?> GetChildEntityOwnerConfig([Nullable(1)] string guid)
	{
		if (this.handleId <= 0)
		{
			this.handleId = ConfigCommon.InitDataStatement(this.handleId, "db_childentityownerdata.db", "select BinData from `ChildEntityOwnerData` where Guid=?");
		}
		LogList<ValueTuple<string, object>> logList = new LogList<ValueTuple<string, object>>();
		logList.Add(new ValueTuple<string, object>("Guid", guid));
		if (!ConfigCommon.CheckStatement(this.handleId, logList))
		{
			return new ValueTuple<bool, ChildEntityOwnerData?>(false, null);
		}
		if (!ConfigCommon.BindString(this.handleId, 1, guid, logList))
		{
			ConfigCommon.Reset(this.handleId, logList);
			return new ValueTuple<bool, ChildEntityOwnerData?>(false, null);
		}
		int num = ConfigCommon.Step(this.handleId, false, logList);
		if (num <= 0)
		{
			bool flag = ConfigCommon.Reset(this.handleId, logList);
			return new ValueTuple<bool, ChildEntityOwnerData?>(num == 0 && flag, null);
		}
		ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(this.handleId, 0, logList);
		bool item = value.Item1;
		byte[] item2 = value.Item2;
		bool flag2 = ConfigCommon.Reset(this.handleId, logList);
		if (!item || item2 == null || !flag2)
		{
			return new ValueTuple<bool, ChildEntityOwnerData?>(false, null);
		}
		return new ValueTuple<bool, ChildEntityOwnerData?>(true, new ChildEntityOwnerData?(ChildEntityOwnerData.GetRootAsChildEntityOwnerData(new ByteBuffer(item2))));
	}

	// Token: 0x17002C91 RID: 11409
	// (get) Token: 0x0601B8BB RID: 112827 RVA: 0x0087CF45 File Offset: 0x0087B145
	public static ChildEntityOwnerConfig Instance
	{
		get
		{
			return ChildEntityOwnerConfig._Instance;
		}
	}

	// Token: 0x0601B8BC RID: 112828 RVA: 0x0087CF4C File Offset: 0x0087B14C
	public static ChildEntityOwnerConfig GetOrCreateInstance()
	{
		if (ChildEntityOwnerConfig._Instance == null)
		{
			ChildEntityOwnerConfig.CreateInstance();
		}
		return ChildEntityOwnerConfig._Instance;
	}

	// Token: 0x0601B8BD RID: 112829 RVA: 0x0087CF60 File Offset: 0x0087B160
	public static bool CreateInstance()
	{
		if (ChildEntityOwnerConfig._Instance != null)
		{
			return true;
		}
		ChildEntityOwnerConfig._Instance = new ChildEntityOwnerConfig();
		return true;
	}

	// Token: 0x0601B8BE RID: 112830 RVA: 0x0087CF76 File Offset: 0x0087B176
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601B8BF RID: 112831 RVA: 0x0087CF78 File Offset: 0x0087B178
	public static void ResetStaticDefaultValue()
	{
		ChildEntityOwnerConfig._Instance = null;
	}

	// Token: 0x0601B8C0 RID: 112832 RVA: 0x0087CF80 File Offset: 0x0087B180
	static ChildEntityOwnerConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ChildEntityOwnerConfig.CreateStaticDefaultValue), new Action(ChildEntityOwnerConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400EE01 RID: 60929
	private const string DbName = "db_childentityownerdata.db";

	// Token: 0x0400EE02 RID: 60930
	private const string Query = "select BinData from `ChildEntityOwnerData` where Guid=?";

	// Token: 0x0400EE03 RID: 60931
	private int handleId;

	// Token: 0x0400EE04 RID: 60932
	[Nullable(2)]
	private static ChildEntityOwnerConfig _Instance;
}
