using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x020070D1 RID: 28881
	[NullableContext(1)]
	[Nullable(0)]
	public class PhysicsAssetLoader
	{
		// Token: 0x0604678E RID: 288654 RVA: 0x011B2220 File Offset: 0x011B0420
		public bool SetDataAndLoadAsset([Nullable(2)] CharacterActorComponent actorComp, PhysicsAssetConfig config, Action callBack)
		{
			this.LoadSuccess = false;
			if (config.BoneNamesLength == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Character;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "该角色未在角色物理资产配置表中配置骨骼名 /Config/j.角色物理资产";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("默认值Id", config.Id);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			string path = config.PhysicsAssetPath;
			if (string.IsNullOrEmpty(path))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Character;
				ELogAuthor author2 = ELogAuthor.LJM;
				string message2 = "该角色未在角色物理资产配置表中骨骼路径配置为空 /Config/j.角色物理资产";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("默认值Id", config.Id);
				instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			this.ActorComp = actorComp;
			ResourceSystem.Instance.LoadAsync<UPhysicsAsset>(path, delegate([Nullable(2)] UPhysicsAsset result, string _)
			{
				if (result == null)
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.Character;
					ELogAuthor author3 = ELogAuthor.LJM;
					string message3 = "该角色未在角色物理资产配置表中骨骼路径配置加载失败 /Config/j.角色物理资产";
					ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("path", path);
					instance3.Warn(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				}
				this.ActorComp.Actor.Mesh.SetPhysicsAsset(result, true);
				this.LoadSuccess = true;
				callBack();
			}, 100, "js_undefined");
			int boneNamesLength = config.BoneNamesLength;
			for (int i = 0; i < boneNamesLength; i++)
			{
				this.BoneNames.Add(config.BoneNames(i));
			}
			return true;
		}

		// Token: 0x0604678F RID: 288655 RVA: 0x011B2321 File Offset: 0x011B0521
		public void ClearData()
		{
			this.BoneNames.Clear();
			this.ActorComp = null;
			this.LoadSuccess = false;
		}

		// Token: 0x04024EFE RID: 151294
		public List<string> BoneNames = new List<string>();

		// Token: 0x04024EFF RID: 151295
		public bool LoadSuccess;

		// Token: 0x04024F00 RID: 151296
		[Nullable(2)]
		public CharacterActorComponent ActorComp;
	}
}
