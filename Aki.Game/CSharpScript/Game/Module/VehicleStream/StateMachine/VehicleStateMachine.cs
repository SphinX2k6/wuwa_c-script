using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.VehicleStream.StateMachine.States;

namespace CSharpScript.Game.Module.VehicleStream.StateMachine
{
	// Token: 0x020048B8 RID: 18616
	[NullableContext(2)]
	[Nullable(0)]
	public class VehicleStateMachine
	{
		// Token: 0x06030A72 RID: 199282 RVA: 0x00B4BA38 File Offset: 0x00B49C38
		public bool Start(EVehicleStateType state)
		{
			if (this.CurrentNode != null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.VehicleStream;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "状态机重复启动";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("state", state);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			this.CurrentNode = this.GetState(state);
			if (this.CurrentNode == null)
			{
				return false;
			}
			this.CurrentNode.Enter(EVehicleStateType.None, null);
			return true;
		}

		// Token: 0x06030A73 RID: 199283 RVA: 0x00B4BAA4 File Offset: 0x00B49CA4
		public void Destroy()
		{
			foreach (VehicleStateBase vehicleStateBase in this.StateMap.Values)
			{
				vehicleStateBase.Destroy();
			}
		}

		// Token: 0x06030A74 RID: 199284 RVA: 0x00B4BAFC File Offset: 0x00B49CFC
		public void Update(float delta)
		{
			if (this.CurrentNode == null)
			{
				return;
			}
			this.CurrentNode.Update(delta);
		}

		// Token: 0x06030A75 RID: 199285 RVA: 0x00B4BB13 File Offset: 0x00B49D13
		public void OnEnterPlayerRange()
		{
			if (this.CurrentNode == null)
			{
				return;
			}
			this.CurrentNode.OnEnterPlayerRange();
		}

		// Token: 0x06030A76 RID: 199286 RVA: 0x00B4BB29 File Offset: 0x00B49D29
		public void OnLeavePlayerRange()
		{
			if (this.CurrentNode == null)
			{
				return;
			}
			this.CurrentNode.OnLeavePlayerRange();
		}

		// Token: 0x06030A77 RID: 199287 RVA: 0x00B4BB40 File Offset: 0x00B49D40
		public bool Switch(EVehicleStateType state, string reason = null)
		{
			if (this.CurrentNode == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.VehicleStream;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "状态机没有开始";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("state", state);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			VehicleStateBase state2 = this.GetState(state);
			if (state2 == null)
			{
				return false;
			}
			EVehicleStateType state3 = this.CurrentNode.State;
			this.CurrentNode.Exit(state);
			this.CurrentNode = state2;
			this.CurrentNode.Enter(state3, reason);
			return true;
		}

		// Token: 0x06030A78 RID: 199288 RVA: 0x00B4BBC0 File Offset: 0x00B49DC0
		[NullableContext(1)]
		public void AddState(EVehicleStateType stateType, VehicleStateBase state)
		{
			if (this.StateMap.ContainsKey(stateType))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.VehicleStream;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "状态重复添加";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("state", stateType);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.StateMap[stateType] = state;
		}

		// Token: 0x06030A79 RID: 199289 RVA: 0x00B4BC18 File Offset: 0x00B49E18
		public VehicleStateBase GetState(EVehicleStateType state)
		{
			VehicleStateBase result;
			if (!this.StateMap.TryGetValue(state, out result))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.VehicleStream;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "状态不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("state", state);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return result;
		}

		// Token: 0x06030A7A RID: 199290 RVA: 0x00B4BC65 File Offset: 0x00B49E65
		public EVehicleStateType GetCurrentState()
		{
			VehicleStateBase currentNode = this.CurrentNode;
			if (currentNode == null)
			{
				return EVehicleStateType.None;
			}
			return currentNode.State;
		}

		// Token: 0x0401A27A RID: 107130
		[Nullable(1)]
		private readonly Dictionary<EVehicleStateType, VehicleStateBase> StateMap = new Dictionary<EVehicleStateType, VehicleStateBase>();

		// Token: 0x0401A27B RID: 107131
		private VehicleStateBase CurrentNode;
	}
}
