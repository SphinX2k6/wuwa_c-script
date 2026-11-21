using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Aki.Config;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x0200567C RID: 22140
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchGameplayCommandMgr : DropCatchGameplayBaseMgr, ICommandContext
	{
		// Token: 0x06036A02 RID: 223746 RVA: 0x00F3E4AE File Offset: 0x00F3C6AE
		public DropCatchGameplayCommandMgr(IGameplayLogicContext context) : base(context)
		{
		}

		// Token: 0x06036A03 RID: 223747 RVA: 0x00F3E4EE File Offset: 0x00F3C6EE
		public IGameplayLogicContext GetLogicContext()
		{
			return this.Context;
		}

		// Token: 0x06036A04 RID: 223748 RVA: 0x00F3E4F6 File Offset: 0x00F3C6F6
		public override void Init()
		{
			this.GameplayTimeCommands.Clear();
			this.RemainingTimeCommands.Clear();
			this.SkillCommands.Clear();
			this.DropItemEffectCommands.Clear();
			this.TmpArray.Clear();
			this.InitCommands();
		}

		// Token: 0x06036A05 RID: 223749 RVA: 0x00F3E538 File Offset: 0x00F3C738
		private void InitCommands()
		{
			DropCatchGameplay? gameplayConfig = this.Context.GetProxy().GetGameplayConfig();
			if (gameplayConfig == null)
			{
				return;
			}
			this.LoadTimeCommands(gameplayConfig.Value.GameplayTimeCommands, delegate(TimeCommands timeCommands)
			{
				float key = timeCommands.Time * (float)TimeUtil.Instance.InverseMillisecond;
				List<CommandData> list;
				if (!this.GameplayTimeCommands.TryGetValue(key, out list))
				{
					list = new List<CommandData>();
					this.GameplayTimeCommands.Add(key, list);
				}
				list.AddRange(timeCommands.Commands);
			});
			this.LoadTimeCommands(gameplayConfig.Value.RemainingTimeCommands, delegate(TimeCommands timeCommands)
			{
				float key = timeCommands.Time * (float)TimeUtil.Instance.InverseMillisecond;
				List<CommandData> list;
				if (!this.RemainingTimeCommands.TryGetValue(key, out list))
				{
					list = new List<CommandData>();
					this.RemainingTimeCommands.Add(key, list);
				}
				list.AddRange(timeCommands.Commands);
			});
			this.LoadCommands(gameplayConfig.Value.SkillCommands, delegate(CommandData cmd)
			{
				this.SkillCommands.Add(cmd);
			});
			IReadOnlyList<DropCatchDropItem> allDropItemConfig = DropCatchConfig.Instance.GetAllDropItemConfig();
			if (allDropItemConfig != null)
			{
				using (IEnumerator<DropCatchDropItem> enumerator = allDropItemConfig.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						DropCatchDropItem dropItemConfig = enumerator.Current;
						this.LoadCommands(dropItemConfig.EffectCommands, delegate(CommandData cmd)
						{
							List<CommandData> list;
							if (!this.DropItemEffectCommands.TryGetValue(dropItemConfig.Id, out list))
							{
								list = new List<CommandData>();
								this.DropItemEffectCommands.Add(dropItemConfig.Id, list);
							}
							list.Add(cmd);
						});
					}
				}
			}
		}

		// Token: 0x06036A06 RID: 223750 RVA: 0x00F3E63C File Offset: 0x00F3C83C
		public override void OnTick(float deltaTime)
		{
			this.ProcessTimedCommands();
		}

		// Token: 0x06036A07 RID: 223751 RVA: 0x00F3E644 File Offset: 0x00F3C844
		private void LoadCommands(string serializedValue, Action<CommandData> addFn)
		{
			if (StringUtils.IsEmpty(serializedValue))
			{
				return;
			}
			List<CommandData> list = Json.Parse<List<CommandData>>(serializedValue, null);
			if (list != null)
			{
				foreach (CommandData obj in list)
				{
					addFn(obj);
				}
			}
		}

		// Token: 0x06036A08 RID: 223752 RVA: 0x00F3E6A8 File Offset: 0x00F3C8A8
		private void LoadTimeCommands(string serializedValue, Action<TimeCommands> addFn)
		{
			if (StringUtils.IsEmpty(serializedValue))
			{
				return;
			}
			List<TimeCommands> list = Json.Parse<List<TimeCommands>>(serializedValue, null);
			if (list != null)
			{
				foreach (TimeCommands obj in list)
				{
					addFn(obj);
				}
			}
		}

		// Token: 0x06036A09 RID: 223753 RVA: 0x00F3E70C File Offset: 0x00F3C90C
		[NullableContext(2)]
		public unsafe void ExecuteCommand(EDropCatchCommandName commandName, object @params)
		{
			IDropCatchCommand dropCatchCommand;
			if (!DropCatchDefine.Instance.CommandClass.TryGetValue(commandName.ToEnumString(), out dropCatchCommand))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DropCatch;
				ELogAuthor author = ELogAuthor.CB;
				string message = "ExecuteCommand failed";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CommandName", commandName);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			@params = DropCatchGameplayCommandMgr.DeserializeParams(commandName, @params);
			dropCatchCommand.Execute(this, @params);
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.DropCatch;
			ELogAuthor author2 = ELogAuthor.CB;
			string message2 = "ExecuteCommand success";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CommandName", commandName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Params", @params);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x06036A0A RID: 223754 RVA: 0x00F3E7D0 File Offset: 0x00F3C9D0
		public void ExecuteDropItemEffectCommand(int itemId)
		{
			List<CommandData> list;
			if (!this.DropItemEffectCommands.TryGetValue(itemId, out list))
			{
				return;
			}
			foreach (CommandData commandData in list)
			{
				this.ExecuteCommand(commandData.CommandName, commandData.Params);
			}
		}

		// Token: 0x06036A0B RID: 223755 RVA: 0x00F3E83C File Offset: 0x00F3CA3C
		public void ExecuteSkillCommand()
		{
			foreach (CommandData commandData in this.SkillCommands)
			{
				this.ExecuteCommand(commandData.CommandName, commandData.Params);
			}
		}

		// Token: 0x06036A0C RID: 223756 RVA: 0x00F3E89C File Offset: 0x00F3CA9C
		private void ProcessTimedCommands()
		{
			float time = this.Context.GetGameplayTimeMgr().GetTime();
			this.TmpArray.Clear();
			foreach (KeyValuePair<float, List<CommandData>> keyValuePair in this.GameplayTimeCommands)
			{
				float key = keyValuePair.Key;
				List<CommandData> value = keyValuePair.Value;
				if (time >= key)
				{
					foreach (CommandData commandData in value)
					{
						this.ExecuteCommand(commandData.CommandName, commandData.Params);
					}
					this.TmpArray.Add(key);
				}
			}
			foreach (float key2 in this.TmpArray)
			{
				this.GameplayTimeCommands.Remove(key2);
			}
			float remainingTime = this.Context.GetGameplayTimeMgr().GetRemainingTime();
			this.TmpArray.Clear();
			foreach (KeyValuePair<float, List<CommandData>> keyValuePair2 in this.RemainingTimeCommands)
			{
				float key3 = keyValuePair2.Key;
				List<CommandData> value2 = keyValuePair2.Value;
				if (remainingTime <= key3)
				{
					foreach (CommandData commandData2 in value2)
					{
						this.ExecuteCommand(commandData2.CommandName, commandData2.Params);
					}
					this.TmpArray.Add(key3);
				}
			}
			foreach (float key4 in this.TmpArray)
			{
				this.RemainingTimeCommands.Remove(key4);
			}
		}

		// Token: 0x06036A0D RID: 223757 RVA: 0x00F3EAD4 File Offset: 0x00F3CCD4
		[NullableContext(2)]
		private static object DeserializeParams(EDropCatchCommandName commandName, object @params)
		{
			if (!(@params is JsonElement))
			{
				return @params;
			}
			JsonElement element = (JsonElement)@params;
			Type returnType;
			if (!DropCatchDefine.Instance.CommandParamsTypeMap.TryGetValue(commandName, out returnType))
			{
				return @params;
			}
			return element.Deserialize(returnType, JsonSettings.DecodeOptions);
		}

		// Token: 0x0401CDDA RID: 118234
		private readonly Dictionary<float, List<CommandData>> GameplayTimeCommands = new Dictionary<float, List<CommandData>>();

		// Token: 0x0401CDDB RID: 118235
		private readonly Dictionary<float, List<CommandData>> RemainingTimeCommands = new Dictionary<float, List<CommandData>>();

		// Token: 0x0401CDDC RID: 118236
		private readonly List<CommandData> SkillCommands = new List<CommandData>();

		// Token: 0x0401CDDD RID: 118237
		private readonly Dictionary<int, List<CommandData>> DropItemEffectCommands = new Dictionary<int, List<CommandData>>();

		// Token: 0x0401CDDE RID: 118238
		private readonly List<float> TmpArray = new List<float>();
	}
}
