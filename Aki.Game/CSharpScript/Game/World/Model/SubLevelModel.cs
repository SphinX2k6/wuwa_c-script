using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.World.Model
{
	// Token: 0x02003450 RID: 13392
	[NullableContext(1)]
	[Nullable(0)]
	public class SubLevelModel : ModelBase
	{
		// Token: 0x06022287 RID: 139911 RVA: 0x009AD778 File Offset: 0x009AB978
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

		// Token: 0x06022288 RID: 139912 RVA: 0x009AD874 File Offset: 0x009ABA74
		public void SetSubLevelSwitching(bool bBlockInput)
		{
			this.IsInSubLevelSwitchingInternal = true;
			this.IsBlockingInputInSwitchingInternal = bBlockInput;
		}

		// Token: 0x06022289 RID: 139913 RVA: 0x009AD884 File Offset: 0x009ABA84
		public void UnsetSubLevelSwitching()
		{
			this.IsInSubLevelSwitchingInternal = false;
			this.IsBlockingInputInSwitchingInternal = false;
		}

		// Token: 0x0602228A RID: 139914 RVA: 0x009AD894 File Offset: 0x009ABA94
		public bool IsInSubLevelSwitching()
		{
			return this.IsInSubLevelSwitchingInternal;
		}

		// Token: 0x0602228B RID: 139915 RVA: 0x009AD89C File Offset: 0x009ABA9C
		public bool IsInSubLevelSwitchingAndBlockingInput()
		{
			return this.IsInSubLevelSwitchingInternal && this.IsBlockingInputInSwitchingInternal;
		}

		// Token: 0x0602228C RID: 139916 RVA: 0x009AD8AE File Offset: 0x009ABAAE
		public Dictionary<string, SubLevel> GetAllPreloadSubLevels()
		{
			return this.PreloadLevelMap;
		}

		// Token: 0x0602228D RID: 139917 RVA: 0x009AD8B6 File Offset: 0x009ABAB6
		public Dictionary<string, SubLevel> GetAllSubLevels()
		{
			return this.SubLevelMap;
		}

		// Token: 0x0602228E RID: 139918 RVA: 0x009AD8BE File Offset: 0x009ABABE
		public Dictionary<string, SubLevel> GetAllUnloadSubLevels()
		{
			return this.UnloadLevelMap;
		}

		// Token: 0x0602228F RID: 139919 RVA: 0x009AD8C8 File Offset: 0x009ABAC8
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

		// Token: 0x06022290 RID: 139920 RVA: 0x009AD957 File Offset: 0x009ABB57
		public bool RemovePreloadSubLevel(string path)
		{
			return this.PreloadLevelMap.Remove(path);
		}

		// Token: 0x06022291 RID: 139921 RVA: 0x009AD968 File Offset: 0x009ABB68
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

		// Token: 0x06022292 RID: 139922 RVA: 0x009AD988 File Offset: 0x009ABB88
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

		// Token: 0x06022293 RID: 139923 RVA: 0x009AD9BC File Offset: 0x009ABBBC
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

		// Token: 0x06022294 RID: 139924 RVA: 0x009AD9DC File Offset: 0x009ABBDC
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

		// Token: 0x06022295 RID: 139925 RVA: 0x009ADA38 File Offset: 0x009ABC38
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

		// Token: 0x06022296 RID: 139926 RVA: 0x009ADA8C File Offset: 0x009ABC8C
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

		// Token: 0x06022297 RID: 139927 RVA: 0x009ADAB8 File Offset: 0x009ABCB8
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

		// Token: 0x06022298 RID: 139928 RVA: 0x009ADB18 File Offset: 0x009ABD18
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

		// Token: 0x06022299 RID: 139929 RVA: 0x009ADB38 File Offset: 0x009ABD38
		public void AddUnloadSubLevel(string path, SubLevel subLevel)
		{
			this.UnloadLevelMap[path] = subLevel;
		}

		// Token: 0x0602229A RID: 139930 RVA: 0x009ADB47 File Offset: 0x009ABD47
		public bool RemoveUnloadSubLevel(string path)
		{
			return this.UnloadLevelMap.Remove(path);
		}

		// Token: 0x170047C6 RID: 18374
		// (get) Token: 0x0602229B RID: 139931 RVA: 0x009ADB55 File Offset: 0x009ABD55
		public static SubLevelModel Instance
		{
			get
			{
				return SubLevelModel._Instance;
			}
		}

		// Token: 0x0602229C RID: 139932 RVA: 0x009ADB5C File Offset: 0x009ABD5C
		public static SubLevelModel GetOrCreateInstance()
		{
			if (SubLevelModel._Instance == null)
			{
				SubLevelModel.CreateInstance();
			}
			return SubLevelModel._Instance;
		}

		// Token: 0x0602229D RID: 139933 RVA: 0x009ADB70 File Offset: 0x009ABD70
		public static bool CreateInstance()
		{
			if (SubLevelModel._Instance != null)
			{
				return true;
			}
			SubLevelModel._Instance = new SubLevelModel();
			return true;
		}

		// Token: 0x0602229E RID: 139934 RVA: 0x009ADB86 File Offset: 0x009ABD86
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602229F RID: 139935 RVA: 0x009ADB88 File Offset: 0x009ABD88
		public static void ResetStaticDefaultValue()
		{
			SubLevelModel._Instance = null;
		}

		// Token: 0x060222A0 RID: 139936 RVA: 0x009ADB90 File Offset: 0x009ABD90
		static SubLevelModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SubLevelModel.CreateStaticDefaultValue), new Action(SubLevelModel.ResetStaticDefaultValue));
		}

		// Token: 0x04012CD0 RID: 77008
		private readonly Dictionary<string, SubLevel> PreloadLevelMap = new Dictionary<string, SubLevel>();

		// Token: 0x04012CD1 RID: 77009
		private readonly Dictionary<string, SubLevel> SubLevelMap = new Dictionary<string, SubLevel>();

		// Token: 0x04012CD2 RID: 77010
		private readonly Dictionary<string, SubLevel> UnloadLevelMap = new Dictionary<string, SubLevel>();

		// Token: 0x04012CD3 RID: 77011
		private bool IsInSubLevelSwitchingInternal;

		// Token: 0x04012CD4 RID: 77012
		private bool IsBlockingInputInSwitchingInternal;

		// Token: 0x04012CD5 RID: 77013
		[Nullable(2)]
		private static SubLevelModel _Instance;
	}
}
