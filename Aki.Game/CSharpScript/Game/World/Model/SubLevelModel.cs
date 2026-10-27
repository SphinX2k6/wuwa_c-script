using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.World.Model
{
	// Token: 0x0200452B RID: 17707
	[NullableContext(1)]
	[Nullable(0)]
	public class SubLevelModel : ModelBase
	{
		// Token: 0x0602DBC0 RID: 187328 RVA: 0x00A82560 File Offset: 0x00A80760
		protected override bool OnLeaveLevel()
		{
			List<string> list = new List<string>();
			foreach (string item in this.PreloadLevelMap.Keys)
			{
				list.Add(item);
			}
			foreach (string item2 in this.SubLevelMap.Keys)
			{
				list.Add(item2);
			}
			foreach (string path in list)
			{
				this.RemoveSubLevel(path, true);
			}
			list.Clear();
			this.IsInSubLevelSwitchingInternal = false;
			this.IsBlockingInputInSwitchingInternal = false;
			return true;
		}

		// Token: 0x0602DBC1 RID: 187329 RVA: 0x00A8265C File Offset: 0x00A8085C
		public void SetSubLevelSwitching(bool bBlockInput)
		{
			this.IsInSubLevelSwitchingInternal = true;
			this.IsBlockingInputInSwitchingInternal = bBlockInput;
		}

		// Token: 0x0602DBC2 RID: 187330 RVA: 0x00A8266C File Offset: 0x00A8086C
		public void UnsetSubLevelSwitching()
		{
			this.IsInSubLevelSwitchingInternal = false;
			this.IsBlockingInputInSwitchingInternal = false;
		}

		// Token: 0x0602DBC3 RID: 187331 RVA: 0x00A8267C File Offset: 0x00A8087C
		public bool IsInSubLevelSwitching()
		{
			return this.IsInSubLevelSwitchingInternal;
		}

		// Token: 0x0602DBC4 RID: 187332 RVA: 0x00A82684 File Offset: 0x00A80884
		public bool IsInSubLevelSwitchingAndBlockingInput()
		{
			return this.IsInSubLevelSwitchingInternal && this.IsBlockingInputInSwitchingInternal;
		}

		// Token: 0x0602DBC5 RID: 187333 RVA: 0x00A82696 File Offset: 0x00A80896
		public Dictionary<string, SubLevel> GetAllPreloadSubLevels()
		{
			return this.PreloadLevelMap;
		}

		// Token: 0x0602DBC6 RID: 187334 RVA: 0x00A8269E File Offset: 0x00A8089E
		public Dictionary<string, SubLevel> GetAllSubLevels()
		{
			return this.SubLevelMap;
		}

		// Token: 0x0602DBC7 RID: 187335 RVA: 0x00A826A6 File Offset: 0x00A808A6
		public Dictionary<string, SubLevel> GetAllUnloadSubLevels()
		{
			return this.UnloadLevelMap;
		}

		// Token: 0x0602DBC8 RID: 187336 RVA: 0x00A826B0 File Offset: 0x00A808B0
		[return: Nullable(2)]
		public SubLevel AddPreloadSubLevel(string path)
		{
			if (this.PreloadLevelMap.ContainsKey(path))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.World;
				ELogAuthor author = ELogAuthor.LFJW;
				string message = "[GameModeModel.AddPreloadSubLevel] 重复添加预加载的Level，因为存在于this.PreloadLevelMap中";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", path);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			if (this.SubLevelMap.ContainsKey(path))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.World;
				ELogAuthor author2 = ELogAuthor.LFJW;
				string message2 = "[GameModeModel.AddPreloadSubLevel] 重复添加预加载Level，因为存在于SubLevelMap中";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Path", path);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return null;
			}
			SubLevel subLevel = new SubLevel(path, false);
			this.PreloadLevelMap[path] = subLevel;
			return subLevel;
		}

		// Token: 0x0602DBC9 RID: 187337 RVA: 0x00A8273F File Offset: 0x00A8093F
		public bool RemovePreloadSubLevel(string path)
		{
			return this.PreloadLevelMap.Remove(path);
		}

		// Token: 0x0602DBCA RID: 187338 RVA: 0x00A82750 File Offset: 0x00A80950
		[return: Nullable(2)]
		public SubLevel GetPreloadSubLevel(string path)
		{
			SubLevel result;
			if (!this.PreloadLevelMap.TryGetValue(path, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0602DBCB RID: 187339 RVA: 0x00A82770 File Offset: 0x00A80970
		[return: Nullable(2)]
		public SubLevel GetPreloadOrLoadedSubLevel(string path)
		{
			SubLevel result;
			if (this.PreloadLevelMap.TryGetValue(path, out result))
			{
				return result;
			}
			if (!this.SubLevelMap.TryGetValue(path, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0602DBCC RID: 187340 RVA: 0x00A827A4 File Offset: 0x00A809A4
		[return: Nullable(2)]
		public SubLevel GetSubLevel(string path)
		{
			SubLevel result;
			if (!this.SubLevelMap.TryGetValue(path, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0602DBCD RID: 187341 RVA: 0x00A827C4 File Offset: 0x00A809C4
		[return: Nullable(2)]
		public SubLevel AddSubLevel(string path, bool visibleAfterLoad)
		{
			if (this.SubLevelMap.ContainsKey(path))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.World;
				ELogAuthor author = ELogAuthor.LFJW;
				string message = "[GameModeModel.AddSubLevel] 重复添加子关卡。";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", path);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			SubLevel subLevel = new SubLevel(path, visibleAfterLoad);
			this.SubLevelMap[path] = subLevel;
			return subLevel;
		}

		// Token: 0x0602DBCE RID: 187342 RVA: 0x00A82820 File Offset: 0x00A80A20
		[NullableContext(0)]
		public UniTask<bool> RemoveSubLevel([Nullable(1)] string path, bool bForceRemove = false)
		{
			SubLevelModel.<RemoveSubLevel>d__19 <RemoveSubLevel>d__;
			<RemoveSubLevel>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RemoveSubLevel>d__.<>4__this = this;
			<RemoveSubLevel>d__.path = path;
			<RemoveSubLevel>d__.bForceRemove = bForceRemove;
			<RemoveSubLevel>d__.<>1__state = -1;
			<RemoveSubLevel>d__.<>t__builder.Start<SubLevelModel.<RemoveSubLevel>d__19>(ref <RemoveSubLevel>d__);
			return <RemoveSubLevel>d__.<>t__builder.Task;
		}

		// Token: 0x0602DBCF RID: 187343 RVA: 0x00A82874 File Offset: 0x00A80A74
		public void MovePreloadSubLevelToSubLevel(string path)
		{
			SubLevel preloadSubLevel = this.GetPreloadSubLevel(path);
			if (preloadSubLevel == null)
			{
				return;
			}
			this.RemovePreloadSubLevel(path);
			this.AddSubLevelInstance(preloadSubLevel);
		}

		// Token: 0x0602DBD0 RID: 187344 RVA: 0x00A828A0 File Offset: 0x00A80AA0
		private bool AddSubLevelInstance(SubLevel level)
		{
			if (this.SubLevelMap.ContainsKey(level.Path))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.World;
				ELogAuthor author = ELogAuthor.LFJW;
				string message = "[GameModeModel.AddSubLevelInstance] 重复添加子关卡。";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", level.Path);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			this.SubLevelMap[level.Path] = level;
			return true;
		}

		// Token: 0x0602DBD1 RID: 187345 RVA: 0x00A82900 File Offset: 0x00A80B00
		[return: Nullable(2)]
		public SubLevel GetUnloadSubLevel(string path)
		{
			SubLevel result;
			if (!this.UnloadLevelMap.TryGetValue(path, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0602DBD2 RID: 187346 RVA: 0x00A82920 File Offset: 0x00A80B20
		public void AddUnloadSubLevel(string path, SubLevel subLevel)
		{
			this.UnloadLevelMap[path] = subLevel;
		}

		// Token: 0x0602DBD3 RID: 187347 RVA: 0x00A8292F File Offset: 0x00A80B2F
		public bool RemoveUnloadSubLevel(string path)
		{
			return this.UnloadLevelMap.Remove(path);
		}

		// Token: 0x17007513 RID: 29971
		// (get) Token: 0x0602DBD4 RID: 187348 RVA: 0x00A8293D File Offset: 0x00A80B3D
		public static SubLevelModel Instance
		{
			get
			{
				return SubLevelModel._Instance;
			}
		}

		// Token: 0x0602DBD5 RID: 187349 RVA: 0x00A82944 File Offset: 0x00A80B44
		public static SubLevelModel GetOrCreateInstance()
		{
			if (SubLevelModel._Instance == null)
			{
				SubLevelModel.CreateInstance();
			}
			return SubLevelModel._Instance;
		}

		// Token: 0x0602DBD6 RID: 187350 RVA: 0x00A82958 File Offset: 0x00A80B58
		public static bool CreateInstance()
		{
			if (SubLevelModel._Instance != null)
			{
				return true;
			}
			SubLevelModel._Instance = new SubLevelModel();
			return true;
		}

		// Token: 0x0602DBD7 RID: 187351 RVA: 0x00A8296E File Offset: 0x00A80B6E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602DBD8 RID: 187352 RVA: 0x00A82970 File Offset: 0x00A80B70
		public static void ResetStaticDefaultValue()
		{
			SubLevelModel._Instance = null;
		}

		// Token: 0x0602DBD9 RID: 187353 RVA: 0x00A82978 File Offset: 0x00A80B78
		static SubLevelModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SubLevelModel.CreateStaticDefaultValue), new Action(SubLevelModel.ResetStaticDefaultValue));
		}

		// Token: 0x040186AC RID: 100012
		private readonly Dictionary<string, SubLevel> PreloadLevelMap = new Dictionary<string, SubLevel>();

		// Token: 0x040186AD RID: 100013
		private readonly Dictionary<string, SubLevel> SubLevelMap = new Dictionary<string, SubLevel>();

		// Token: 0x040186AE RID: 100014
		private readonly Dictionary<string, SubLevel> UnloadLevelMap = new Dictionary<string, SubLevel>();

		// Token: 0x040186AF RID: 100015
		private bool IsInSubLevelSwitchingInternal;

		// Token: 0x040186B0 RID: 100016
		private bool IsBlockingInputInSwitchingInternal;

		// Token: 0x040186B1 RID: 100017
		[Nullable(2)]
		private static SubLevelModel _Instance;
	}
}
