using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.SkipInterface
{
	// Token: 0x02004BA2 RID: 19362
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class SkipInterfaceModel : ModelBase
	{
		// Token: 0x060322AD RID: 205485 RVA: 0x00BA7DFC File Offset: 0x00BA5FFC
		protected override bool OnInit()
		{
			this.ResetToBattleViewCount = ConfigCommonParamById.GetIntConfig("ResetToBattleViewCount").GetValueOrDefault();
			return true;
		}

		// Token: 0x060322AE RID: 205486 RVA: 0x00BA7E24 File Offset: 0x00BA6024
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

		// Token: 0x060322AF RID: 205487 RVA: 0x00BA7EA0 File Offset: 0x00BA60A0
		public void FullUpdateAccessPathTimeServerConfig(AccessPathConfig[] configs)
		{
			this.AccessPathTimeServerConfigMap.Clear();
			foreach (AccessPathConfig accessPathConfig in configs)
			{
				this.AccessPathTimeServerConfigMap[accessPathConfig.Id] = accessPathConfig;
			}
		}

		// Token: 0x060322B0 RID: 205488 RVA: 0x00BA7EE0 File Offset: 0x00BA60E0
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

		// Token: 0x17007C4D RID: 31821
		// (get) Token: 0x060322B1 RID: 205489 RVA: 0x00BA7F25 File Offset: 0x00BA6125
		public static SkipInterfaceModel Instance
		{
			get
			{
				return SkipInterfaceModel._Instance;
			}
		}

		// Token: 0x060322B2 RID: 205490 RVA: 0x00BA7F2C File Offset: 0x00BA612C
		public static SkipInterfaceModel GetOrCreateInstance()
		{
			if (SkipInterfaceModel._Instance == null)
			{
				SkipInterfaceModel.CreateInstance();
			}
			return SkipInterfaceModel._Instance;
		}

		// Token: 0x060322B3 RID: 205491 RVA: 0x00BA7F40 File Offset: 0x00BA6140
		public static bool CreateInstance()
		{
			if (SkipInterfaceModel._Instance != null)
			{
				return true;
			}
			SkipInterfaceModel._Instance = new SkipInterfaceModel();
			return true;
		}

		// Token: 0x060322B4 RID: 205492 RVA: 0x00BA7F56 File Offset: 0x00BA6156
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060322B5 RID: 205493 RVA: 0x00BA7F58 File Offset: 0x00BA6158
		public static void ResetStaticDefaultValue()
		{
			SkipInterfaceModel._Instance = null;
		}

		// Token: 0x060322B6 RID: 205494 RVA: 0x00BA7F60 File Offset: 0x00BA6160
		static SkipInterfaceModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SkipInterfaceModel.CreateStaticDefaultValue), new Action(SkipInterfaceModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401AB7C RID: 109436
		public int ResetToBattleViewCount;

		// Token: 0x0401AB7D RID: 109437
		public int ContainerLimitCount = 3;

		// Token: 0x0401AB7E RID: 109438
		private readonly SkipConditionContext SkipConditionContext = new SkipConditionContext();

		// Token: 0x0401AB7F RID: 109439
		private readonly Dictionary<int, AccessPathConfig> AccessPathTimeServerConfigMap = new Dictionary<int, AccessPathConfig>();

		// Token: 0x0401AB80 RID: 109440
		[Nullable(2)]
		private static SkipInterfaceModel _Instance;
	}
}
