using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.VehicleStream.StateMachine.States;

namespace CSharpScript.Game.Module.VehicleStream.StateMachine
{
	// Token: 0x0200382F RID: 14383
	[NullableContext(2)]
	[Nullable(0)]
	public class VehicleStateMachine
	{
		// Token: 0x0602559E RID: 152990 RVA: 0x00A86840 File Offset: 0x00A84A40
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

		// Token: 0x0602559F RID: 152991 RVA: 0x00A868AC File Offset: 0x00A84AAC
		public void Destroy()
		{
			foreach (VehicleStateBase vehicleStateBase in this.StateMap.Values)
			{
				vehicleStateBase.Destroy();
			}
		}

		// Token: 0x060255A0 RID: 152992 RVA: 0x00A86904 File Offset: 0x00A84B04
		public void Update(float delta)
		{
			if (this.CurrentNode == null)
			{
				return;
			}
			this.CurrentNode.Update(delta);
		}

		// Token: 0x060255A1 RID: 152993 RVA: 0x00A8691B File Offset: 0x00A84B1B
		public void OnEnterPlayerRange()
		{
			if (this.CurrentNode == null)
			{
				return;
			}
			this.CurrentNode.OnEnterPlayerRange();
		}

		// Token: 0x060255A2 RID: 152994 RVA: 0x00A86931 File Offset: 0x00A84B31
		public void OnLeavePlayerRange()
		{
			if (this.CurrentNode == null)
			{
				return;
			}
			this.CurrentNode.OnLeavePlayerRange();
		}

		// Token: 0x060255A3 RID: 152995 RVA: 0x00A86948 File Offset: 0x00A84B48
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

		// Token: 0x060255A4 RID: 152996 RVA: 0x00A869C8 File Offset: 0x00A84BC8
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

		// Token: 0x060255A5 RID: 152997 RVA: 0x00A86A20 File Offset: 0x00A84C20
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

		// Token: 0x060255A6 RID: 152998 RVA: 0x00A86A6D File Offset: 0x00A84C6D
		public EVehicleStateType GetCurrentState()
		{
			VehicleStateBase currentNode = this.CurrentNode;
			if (currentNode == null)
			{
				return EVehicleStateType.None;
			}
			return currentNode.State;
		}

		// Token: 0x04014AED RID: 84717
		[Nullable(1)]
		private readonly Dictionary<EVehicleStateType, VehicleStateBase> StateMap = new Dictionary<EVehicleStateType, VehicleStateBase>();

		// Token: 0x04014AEE RID: 84718
		private VehicleStateBase CurrentNode;
	}
}
