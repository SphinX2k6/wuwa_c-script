using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Utils;
using Google.Protobuf;

namespace CSharpScript.Game.Module.CombatMessage
{
	// Token: 0x02004B8E RID: 19342
	public class CombatMessageBuffer
	{
		// Token: 0x170060C9 RID: 24777
		// (get) Token: 0x060304F0 RID: 197872 RVA: 0x00D78041 File Offset: 0x00D76241
		public double TimelineOffset
		{
			get
			{
				return this.TimelineOffsetBase + this.Buffer;
			}
		}

		// Token: 0x170060CA RID: 24778
		// (get) Token: 0x060304F1 RID: 197873 RVA: 0x00D78050 File Offset: 0x00D76250
		public double RemainBufferTime
		{
			get
			{
				return this.LastNotifyExecuteTime - Time.Instance.NowSeconds;
			}
		}

		// Token: 0x060304F2 RID: 197874 RVA: 0x00D78063 File Offset: 0x00D76263
		public CombatMessageBuffer(long creatureDataId)
		{
			this.CreatureDataId = creatureDataId;
		}

		// Token: 0x060304F3 RID: 197875 RVA: 0x00D78080 File Offset: 0x00D76280
		[NullableContext(1)]
		public unsafe void AddToQueue(ENotifyMessageId id, [Nullable(2)] Entity entity, CombatCommon combatCommon, IMessage message)
		{
			if (entity == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MultiplayerCombat;
				ELogAuthor author = ELogAuthor.ZQR;
				string message2 = "[CombatMessageModel.Push]失败, entity非法";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataId", this.CreatureDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			CharacterCombatMessageComponent characterCombatMessageComponent = (entity != null) ? entity.GetComponent<CharacterCombatMessageComponent>() : null;
			if (characterCombatMessageComponent == null)
			{
				CombatMessageController.Instance.Process(id, entity, message, combatCommon);
				return;
			}
			if (id == (ENotifyMessageId)0)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.MultiplayerCombat;
				ELogAuthor author2 = ELogAuthor.WCL;
				string message3 = "[CombatMessageModel.Push]失败, id非法";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("CreatureDataId", this.CreatureDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("id", id);
				instance2.Error(module2, author2, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return;
			}
			float timeStamp = combatCommon.TimeStamp;
			if (timeStamp == 0f)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.MultiplayerCombat;
				ELogAuthor author3 = ELogAuthor.WCL;
				string message4 = "[CombatMessageModel.Push]失败, messageTime非法";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("CreatureDataId", this.CreatureDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("id", id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("messageTime", timeStamp);
				instance3.Warn(module3, author3, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
				CombatMessageController.Instance.Process(id, entity, message, combatCommon);
				return;
			}
			CreatureDataComponent creatureDataComponent = (entity != null) ? entity.GetComponent<CreatureDataComponent>() : null;
			this.RecordMessageTime((double)timeStamp, creatureDataComponent.GetPbDataId(), false);
			double executeTime = (double)timeStamp + this.TimelineOffset;
			characterCombatMessageComponent.AddToQueue(id, combatCommon, message, executeTime);
		}

		// Token: 0x060304F4 RID: 197876 RVA: 0x00D78254 File Offset: 0x00D76454
		public void RecordMessageTime(double messageTime, int pbDataId, bool udpMessage = false)
		{
			double nowSeconds = Time.Instance.NowSeconds;
			if (!udpMessage || nowSeconds - this.LastMessageReceiveTime > 0.20000000298023224)
			{
				this.MessageReceiveTimeQueue.Push(new ValueTuple<double, double>(messageTime, nowSeconds));
				if (this.MessageReceiveTimeQueue.Size >= 20)
				{
					this.MessageReceiveTimeQueue.Pop();
				}
				this.LastMessageReceiveTime = nowSeconds;
			}
			this.RefreshDelayTime();
			double num = messageTime + this.TimelineOffset;
			if (num > this.LastNotifyExecuteTime)
			{
				this.LastNotifyExecuteTime = num;
			}
			this.ReportMoveDataReceiveInfo(nowSeconds - messageTime, pbDataId, udpMessage);
		}

		// Token: 0x060304F5 RID: 197877 RVA: 0x00D782E0 File Offset: 0x00D764E0
		private void RefreshDelayTime()
		{
			if (this.MessageReceiveTimeQueue.Size == 0)
			{
				return;
			}
			int i = this.MessageReceiveTimeQueue.Size - 1;
			ValueTuple<double, double> valueTuple = this.MessageReceiveTimeQueue.Get(i);
			double num = valueTuple.Item2 - valueTuple.Item1;
			double num2 = num;
			double item = valueTuple.Item1;
			int num3 = 0;
			while (i > 0)
			{
				num3++;
				double item2 = this.MessageReceiveTimeQueue.Get(i).Item1;
				double item3 = this.MessageReceiveTimeQueue.Get(i).Item2;
				if ((float)num3 > 3f && item - item2 > 5.0)
				{
					break;
				}
				double num4 = item3 - item2;
				if (num > num4)
				{
					num = num4;
				}
				else if (num2 < num4)
				{
					num2 = num4;
				}
				i--;
			}
			double num5 = num2 - num;
			num5 = MathUtils.Instance.Clamp(num5, num5, 0.5);
			this.TimelineOffsetBase = num;
			if (CombatMessageModel.Instance.MoveSyncUdpMode)
			{
				this.DesiredBuffer = num5 * 1.0499999523162842 + (double)CombatMessageModel.Instance.MoveSyncUdpSendInterval;
			}
			else
			{
				this.DesiredBuffer = num5 * 1.0499999523162842 + 0.07999999821186066;
			}
			this.RefreshBuffer(0.0);
		}

		// Token: 0x060304F6 RID: 197878 RVA: 0x00D78418 File Offset: 0x00D76618
		private void RefreshBuffer(double increment = 0.0)
		{
			if (this.DesiredBuffer < this.Buffer)
			{
				this.Buffer = Math.Max(this.DesiredBuffer, this.Buffer - increment);
				return;
			}
			if (this.RemainBufferTime > increment)
			{
				this.Buffer = Math.Min(this.DesiredBuffer, this.Buffer + increment);
				return;
			}
			this.Buffer = this.DesiredBuffer;
		}

		// Token: 0x060304F7 RID: 197879 RVA: 0x00D7847C File Offset: 0x00D7667C
		public void OnTick(float delta)
		{
			this.RefreshBuffer((double)(delta * 0.1f));
		}

		// Token: 0x060304F8 RID: 197880 RVA: 0x00D7848C File Offset: 0x00D7668C
		public void ReportMoveDataReceiveInfo(double offset, int pbDataId, bool udpMessage)
		{
			string data = Json.Encode(new Dictionary<string, object>
			{
				{
					"udp_mode",
					CombatMessageModel.Instance.MoveSyncUdpMode
				},
				{
					"creature_id",
					this.CreatureDataId
				},
				{
					"pb_data_id",
					pbDataId
				},
				{
					"offset",
					offset
				},
				{
					"timeline_offset",
					this.TimelineOffsetBase
				},
				{
					"buffer",
					this.Buffer
				},
				{
					"desired_buffer",
					this.DesiredBuffer
				},
				{
					"remain_buffer",
					this.RemainBufferTime
				},
				{
					"udp_message",
					udpMessage
				}
			}, null);
			CombatDebugController.Instance.DataReport("MOVE_SYNC_RECEIVE_INFO", data);
		}

		// Token: 0x04019983 RID: 104835
		public double TimelineOffsetBase;

		// Token: 0x04019984 RID: 104836
		public double DesiredBuffer;

		// Token: 0x04019985 RID: 104837
		public double Buffer;

		// Token: 0x04019986 RID: 104838
		public double LastNotifyExecuteTime;

		// Token: 0x04019987 RID: 104839
		private double LastMessageReceiveTime;

		// Token: 0x04019988 RID: 104840
		[Nullable(new byte[]
		{
			1,
			0
		})]
		private readonly Queue<ValueTuple<double, double>> MessageReceiveTimeQueue = new Queue<ValueTuple<double, double>>(4);

		// Token: 0x04019989 RID: 104841
		protected long CreatureDataId;
	}
}
