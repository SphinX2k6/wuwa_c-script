using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Core.Config;
using CSharpScript.Core.Extension;

namespace CSharpScript.Game.World.Model
{
	// Token: 0x02004529 RID: 17705
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class DamageModel : ModelBase
	{
		// Token: 0x0602DBB2 RID: 187314 RVA: 0x00A82228 File Offset: 0x00A80428
		protected override bool OnInit()
		{
			this.UseConfigMapValue = (Info.Instance.IsPs5Platform() || CloudGameManager.Instance.IsCloudGame);
			if (this.UseConfigMapValue)
			{
				this.PreloadAllDamageConfigs();
			}
			if (Info.Instance.IsPlayInEditor)
			{
				this.ReloadCallback = new Action(this.OnConfigReload);
				ConfigReloadHub.RegisterReloadCallback("db_damage.db", this.ReloadCallback);
			}
			return true;
		}

		// Token: 0x0602DBB3 RID: 187315 RVA: 0x00A82294 File Offset: 0x00A80494
		private void PreloadAllDamageConfigs()
		{
			Dictionary<long, Damage> dictionary = new Dictionary<long, Damage>();
			IReadOnlyList<Damage> readOnlyList = Info.Instance.IsPlayInEditor ? ConfigDamageByAll.GetConfigList(false) : ConfigDamageByAll.GetConfigList(true);
			if (readOnlyList != null)
			{
				using (IEnumerator<Damage> enumerator = readOnlyList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Damage value = enumerator.Current;
						dictionary[value.Id] = value;
					}
					goto IL_75;
				}
			}
			Log.Instance.Warn(ELogModule.Battle, ELogAuthor.GHY, "[Damage] 全量预热失败：GetConfigList 返回空，二级缓存未建立", default(ReadOnlySpan<ValueTuple<string, object>>));
			IL_75:
			this.DamageConfigMap = dictionary;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.GHY;
			string message = "[热更][db_damage.db] 全量预热完成";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("二级缓存条数", dictionary.Count);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0602DBB4 RID: 187316 RVA: 0x00A82360 File Offset: 0x00A80560
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

		// Token: 0x0602DBB5 RID: 187317 RVA: 0x00A823A4 File Offset: 0x00A805A4
		public Damage? GetDamageConfigById(long damageId)
		{
			DamageSnapshot damageSnapshotById = this.GetDamageSnapshotById(damageId);
			if (damageSnapshotById == null)
			{
				return null;
			}
			return new Damage?(damageSnapshotById.Config);
		}

		// Token: 0x0602DBB6 RID: 187318 RVA: 0x00A823D0 File Offset: 0x00A805D0
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

		// Token: 0x0602DBB7 RID: 187319 RVA: 0x00A8243B File Offset: 0x00A8063B
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

		// Token: 0x17007512 RID: 29970
		// (get) Token: 0x0602DBB8 RID: 187320 RVA: 0x00A82479 File Offset: 0x00A80679
		public static DamageModel Instance
		{
			get
			{
				return DamageModel._Instance;
			}
		}

		// Token: 0x0602DBB9 RID: 187321 RVA: 0x00A82480 File Offset: 0x00A80680
		public static DamageModel GetOrCreateInstance()
		{
			if (DamageModel._Instance == null)
			{
				DamageModel.CreateInstance();
			}
			return DamageModel._Instance;
		}

		// Token: 0x0602DBBA RID: 187322 RVA: 0x00A82494 File Offset: 0x00A80694
		public static bool CreateInstance()
		{
			if (DamageModel._Instance != null)
			{
				return true;
			}
			DamageModel._Instance = new DamageModel();
			return true;
		}

		// Token: 0x0602DBBB RID: 187323 RVA: 0x00A824AA File Offset: 0x00A806AA
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602DBBC RID: 187324 RVA: 0x00A824AC File Offset: 0x00A806AC
		public static void ResetStaticDefaultValue()
		{
			DamageModel._Instance = null;
		}

		// Token: 0x0602DBBD RID: 187325 RVA: 0x00A824B4 File Offset: 0x00A806B4
		static DamageModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DamageModel.CreateStaticDefaultValue), new Action(DamageModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401869E RID: 99998
		private const string DamageDbName = "db_damage.db";

		// Token: 0x0401869F RID: 99999
		[Nullable(2)]
		private Dictionary<long, Damage> DamageConfigMap;

		// Token: 0x040186A0 RID: 100000
		private readonly Dictionary<long, DamageSnapshot> DamageSnapshotMap = new Dictionary<long, DamageSnapshot>();

		// Token: 0x040186A1 RID: 100001
		[Nullable(2)]
		private Action ReloadCallback;

		// Token: 0x040186A2 RID: 100002
		private bool UseConfigMapValue;

		// Token: 0x040186A3 RID: 100003
		[Nullable(2)]
		private static DamageModel _Instance;
	}
}
