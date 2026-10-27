using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Aki.Config;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x0200672C RID: 26412
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchGameplayCommandMgr : DropCatchGameplayBaseMgr, ICommandContext
	{
		// Token: 0x06041EB6 RID: 270006 RVA: 0x00FFD0E2 File Offset: 0x00FFB2E2
		public DropCatchGameplayCommandMgr(IGameplayLogicContext context) : base(context)
		{
		}

		// Token: 0x06041EB7 RID: 270007 RVA: 0x00FFD122 File Offset: 0x00FFB322
		public IGameplayLogicContext GetLogicContext()
		{
			return this.Context;
		}

		// Token: 0x06041EB8 RID: 270008 RVA: 0x00FFD12A File Offset: 0x00FFB32A
		public override void Init()
		{
			this.GameplayTimeCommands.Clear();
			this.RemainingTimeCommands.Clear();
			this.SkillCommands.Clear();
			this.DropItemEffectCommands.Clear();
			this.TmpArray.Clear();
			this.InitCommands();
		}

		// Token: 0x06041EB9 RID: 270009 RVA: 0x00FFD16C File Offset: 0x00FFB36C
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

		// Token: 0x06041EBA RID: 270010 RVA: 0x00FFD270 File Offset: 0x00FFB470
		public override void OnTick(float deltaTime)
		{
			this.ProcessTimedCommands();
		}

		// Token: 0x06041EBB RID: 270011 RVA: 0x00FFD278 File Offset: 0x00FFB478
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

		// Token: 0x06041EBC RID: 270012 RVA: 0x00FFD2DC File Offset: 0x00FFB4DC
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

		// Token: 0x06041EBD RID: 270013 RVA: 0x00FFD340 File Offset: 0x00FFB540
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

		// Token: 0x06041EBE RID: 270014 RVA: 0x00FFD404 File Offset: 0x00FFB604
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

		// Token: 0x06041EBF RID: 270015 RVA: 0x00FFD470 File Offset: 0x00FFB670
		public void ExecuteSkillCommand()
		{
			foreach (CommandData commandData in this.SkillCommands)
			{
				this.ExecuteCommand(commandData.CommandName, commandData.Params);
			}
		}

		// Token: 0x06041EC0 RID: 270016 RVA: 0x00FFD4D0 File Offset: 0x00FFB6D0
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

		// Token: 0x06041EC1 RID: 270017 RVA: 0x00FFD708 File Offset: 0x00FFB908
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

		// Token: 0x04022581 RID: 140673
		private readonly Dictionary<float, List<CommandData>> GameplayTimeCommands = new Dictionary<float, List<CommandData>>();

		// Token: 0x04022582 RID: 140674
		private readonly Dictionary<float, List<CommandData>> RemainingTimeCommands = new Dictionary<float, List<CommandData>>();

		// Token: 0x04022583 RID: 140675
		private readonly List<CommandData> SkillCommands = new List<CommandData>();

		// Token: 0x04022584 RID: 140676
		private readonly Dictionary<int, List<CommandData>> DropItemEffectCommands = new Dictionary<int, List<CommandData>>();

		// Token: 0x04022585 RID: 140677
		private readonly List<float> TmpArray = new List<float>();
	}
}
