using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.SkipInterface
{
	// Token: 0x02003B4C RID: 15180
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class SkipInterfaceModel : ModelBase
	{
		// Token: 0x0602703D RID: 159805 RVA: 0x00AEBF48 File Offset: 0x00AEA148
		protected override bool OnInit()
		{
			this.ResetToBattleViewCount = ConfigCommonParamById.GetIntConfig("ResetToBattleViewCount").GetValueOrDefault();
			return true;
		}

		// Token: 0x0602703E RID: 159806 RVA: 0x00AEBF70 File Offset: 0x00AEA170
		public bool CheckAccessPathCondition(int id)
		{
			bool flag = true;
			AccessPath? accessPathConfig = SkipInterfaceConfig.Instance.GetAccessPathConfig(id);
			if (accessPathConfig != null)
			{
				int[] array = accessPathConfig.Value.ClientCondition();
				if (array != null && array.Length > 1)
				{
					int conditionType = array[0];
					int[] array2 = new int[array.Length - 1];
					Array.Copy(array, 1, array2, 0, array2.Length);
					flag = this.SkipConditionContext.Check((ESkipConditionType)conditionType, array2);
				}
			}
			return flag && this.IsAccessPathInOpenTime(id);
		}

		// Token: 0x0602703F RID: 159807 RVA: 0x00AEBFEC File Offset: 0x00AEA1EC
		public void FullUpdateAccessPathTimeServerConfig(IReadOnlyList<AccessPathConfig> configs)
		{
			this.AccessPathTimeServerConfigMap.Clear();
			foreach (AccessPathConfig accessPathConfig in configs)
			{
				this.AccessPathTimeServerConfigMap[accessPathConfig.Id] = accessPathConfig;
			}
		}

		// Token: 0x06027040 RID: 159808 RVA: 0x00AEC04C File Offset: 0x00AEA24C
		public bool IsAccessPathInOpenTime(int id)
		{
			AccessPathConfig accessPathConfig;
			if (this.AccessPathTimeServerConfigMap.TryGetValue(id, out accessPathConfig))
			{
				long beginTime = accessPathConfig.BeginTime;
				long endTime = accessPathConfig.EndTime;
				double serverTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
				return serverTimeStamp >= (double)beginTime && serverTimeStamp <= (double)endTime;
			}
			return true;
		}

		// Token: 0x17004FF7 RID: 20471
		// (get) Token: 0x06027041 RID: 159809 RVA: 0x00AEC091 File Offset: 0x00AEA291
		public static SkipInterfaceModel Instance
		{
			get
			{
				return SkipInterfaceModel._Instance;
			}
		}

		// Token: 0x06027042 RID: 159810 RVA: 0x00AEC098 File Offset: 0x00AEA298
		public static SkipInterfaceModel GetOrCreateInstance()
		{
			if (SkipInterfaceModel._Instance == null)
			{
				SkipInterfaceModel.CreateInstance();
			}
			return SkipInterfaceModel._Instance;
		}

		// Token: 0x06027043 RID: 159811 RVA: 0x00AEC0AC File Offset: 0x00AEA2AC
		public static bool CreateInstance()
		{
			if (SkipInterfaceModel._Instance != null)
			{
				return true;
			}
			SkipInterfaceModel._Instance = new SkipInterfaceModel();
			return true;
		}

		// Token: 0x06027044 RID: 159812 RVA: 0x00AEC0C2 File Offset: 0x00AEA2C2
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06027045 RID: 159813 RVA: 0x00AEC0C4 File Offset: 0x00AEA2C4
		public static void ResetStaticDefaultValue()
		{
			SkipInterfaceModel._Instance = null;
		}

		// Token: 0x06027046 RID: 159814 RVA: 0x00AEC0CC File Offset: 0x00AEA2CC
		static SkipInterfaceModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SkipInterfaceModel.CreateStaticDefaultValue), new Action(SkipInterfaceModel.ResetStaticDefaultValue));
		}

		// Token: 0x040154D0 RID: 87248
		public int ResetToBattleViewCount;

		// Token: 0x040154D1 RID: 87249
		public int ContainerLimitCount = 3;

		// Token: 0x040154D2 RID: 87250
		private readonly SkipConditionContext SkipConditionContext = new SkipConditionContext();

		// Token: 0x040154D3 RID: 87251
		private readonly Dictionary<int, AccessPathConfig> AccessPathTimeServerConfigMap = new Dictionary<int, AccessPathConfig>();

		// Token: 0x040154D4 RID: 87252
		[Nullable(2)]
		private static SkipInterfaceModel _Instance;
	}
}
