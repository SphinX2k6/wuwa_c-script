using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Core.Config;
using CSharpScript.Core.Extension;

namespace CSharpScript.Game.World.Model
{
	// Token: 0x0200344E RID: 13390
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class DamageModel : ModelBase
	{
		// Token: 0x06022279 RID: 139897 RVA: 0x009AD48E File Offset: 0x009AB68E
		protected override bool OnInit()
		{
			this.UseConfigMapValue = (Info.Instance.IsPs5Platform() || CloudGameManager.Instance.IsCloudGame);
			if (this.UseConfigMapValue)
			{
				this.PreloadAllDamageConfigs();
			}
			return true;
		}

		// Token: 0x0602227A RID: 139898 RVA: 0x009AD4C0 File Offset: 0x009AB6C0
		private void PreloadAllDamageConfigs()
		{
			Dictionary<long, Damage> dictionary = new Dictionary<long, Damage>();
			IReadOnlyList<Damage> configList = ConfigDamageByAll.GetConfigList(true);
			if (configList != null)
			{
				using (IEnumerator<Damage> enumerator = configList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Damage value = enumerator.Current;
						dictionary[value.Id] = value;
					}
					goto IL_61;
				}
			}
			Log.Instance.Warn(ELogModule.Battle, ELogAuthor.GHY, "[Damage] 全量预热失败：GetConfigList 返回空，二级缓存未建立", default(ReadOnlySpan<ValueTuple<string, object>>));
			IL_61:
			this.DamageConfigMap = dictionary;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.GHY;
			string message = "[热更][db_damage.db] 全量预热完成";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("二级缓存条数", dictionary.Count);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0602227B RID: 139899 RVA: 0x009AD578 File Offset: 0x009AB778
		public void OnConfigReload()
		{
			this.DamageSnapshotMap.Clear();
			if (!this.UseConfigMapValue)
			{
				return;
			}
			this.PreloadAllDamageConfigs();
			Log.Instance.Info(ELogModule.Battle, ELogAuthor.GHY, "[热更][db_damage.db] 配置热更回调：已清空并重建全量二级缓存", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0602227C RID: 139900 RVA: 0x009AD5BC File Offset: 0x009AB7BC
		public Damage? GetDamageConfigById(long damageId)
		{
			DamageSnapshot damageSnapshotById = this.GetDamageSnapshotById(damageId);
			if (damageSnapshotById == null)
			{
				return null;
			}
			return new Damage?(damageSnapshotById.Config);
		}

		// Token: 0x0602227D RID: 139901 RVA: 0x009AD5E8 File Offset: 0x009AB7E8
		[NullableContext(2)]
		public DamageSnapshot GetDamageSnapshotById(long damageId)
		{
			if (damageId <= 0L)
			{
				return null;
			}
			DamageSnapshot damageSnapshot;
			if (this.DamageSnapshotMap.TryGetValue(damageId, out damageSnapshot))
			{
				return damageSnapshot;
			}
			Damage? damage;
			if (this.UseConfigMapValue)
			{
				damage = this.DamageConfigMap.GetValueOrNull(damageId);
			}
			else
			{
				damage = ConfigDamageById.GetConfig(damageId, true);
			}
			if (damage == null)
			{
				return null;
			}
			damageSnapshot = new DamageSnapshot(damage.Value);
			this.DamageSnapshotMap[damageId] = damageSnapshot;
			return damageSnapshot;
		}

		// Token: 0x0602227E RID: 139902 RVA: 0x009AD653 File Offset: 0x009AB853
		protected override bool OnClear()
		{
			if (this.ReloadCallback != null)
			{
				ConfigReloadHub.UnregisterReloadCallback("db_damage.db", this.ReloadCallback);
				this.ReloadCallback = null;
			}
			Dictionary<long, Damage> damageConfigMap = this.DamageConfigMap;
			if (damageConfigMap != null)
			{
				damageConfigMap.Clear();
			}
			this.DamageSnapshotMap.Clear();
			return true;
		}

		// Token: 0x170047C5 RID: 18373
		// (get) Token: 0x0602227F RID: 139903 RVA: 0x009AD691 File Offset: 0x009AB891
		public static DamageModel Instance
		{
			get
			{
				return DamageModel._Instance;
			}
		}

		// Token: 0x06022280 RID: 139904 RVA: 0x009AD698 File Offset: 0x009AB898
		public static DamageModel GetOrCreateInstance()
		{
			if (DamageModel._Instance == null)
			{
				DamageModel.CreateInstance();
			}
			return DamageModel._Instance;
		}

		// Token: 0x06022281 RID: 139905 RVA: 0x009AD6AC File Offset: 0x009AB8AC
		public static bool CreateInstance()
		{
			if (DamageModel._Instance != null)
			{
				return true;
			}
			DamageModel._Instance = new DamageModel();
			return true;
		}

		// Token: 0x06022282 RID: 139906 RVA: 0x009AD6C2 File Offset: 0x009AB8C2
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06022283 RID: 139907 RVA: 0x009AD6C4 File Offset: 0x009AB8C4
		public static void ResetStaticDefaultValue()
		{
			DamageModel._Instance = null;
		}

		// Token: 0x06022284 RID: 139908 RVA: 0x009AD6CC File Offset: 0x009AB8CC
		static DamageModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DamageModel.CreateStaticDefaultValue), new Action(DamageModel.ResetStaticDefaultValue));
		}

		// Token: 0x04012CC2 RID: 76994
		private const string DamageDbName = "db_damage.db";

		// Token: 0x04012CC3 RID: 76995
		[Nullable(2)]
		private Dictionary<long, Damage> DamageConfigMap;

		// Token: 0x04012CC4 RID: 76996
		private readonly Dictionary<long, DamageSnapshot> DamageSnapshotMap = new Dictionary<long, DamageSnapshot>();

		// Token: 0x04012CC5 RID: 76997
		[Nullable(2)]
		private Action ReloadCallback;

		// Token: 0x04012CC6 RID: 76998
		private bool UseConfigMapValue;

		// Token: 0x04012CC7 RID: 76999
		[Nullable(2)]
		private static DamageModel _Instance;
	}
}
