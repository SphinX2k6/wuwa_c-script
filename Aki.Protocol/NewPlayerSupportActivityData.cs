using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B1C RID: 2844
	public sealed class NewPlayerSupportActivityData : IMessage<NewPlayerSupportActivityData>, IMessage, IEquatable<NewPlayerSupportActivityData>, IDeepCloneable<NewPlayerSupportActivityData>, IBufferMessage
	{
		// Token: 0x0600F6E8 RID: 63208 RVA: 0x0023FEC7 File Offset: 0x0023E0C7
		[NullableContext(1)]
		public static NewPlayerSupportActivityData Create()
		{
			return new NewPlayerSupportActivityData();
		}

		// Token: 0x17003247 RID: 12871
		// (get) Token: 0x0600F6E9 RID: 63209 RVA: 0x0023FECE File Offset: 0x0023E0CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003248 RID: 12872
		// (get) Token: 0x0600F6EA RID: 63210 RVA: 0x0023FED1 File Offset: 0x0023E0D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewPlayerSupportActivityData.Descriptor;
			}
		}

		// Token: 0x0600F6EB RID: 63211 RVA: 0x0023FED8 File Offset: 0x0023E0D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportActivityData()
		{
		}

		// Token: 0x0600F6EC RID: 63212 RVA: 0x0023FEF8 File Offset: 0x0023E0F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportActivityData(NewPlayerSupportActivityData other) : this()
		{
			this.trialRoleInfoList_ = other.trialRoleInfoList_.Clone();
			this.conditionTasks_ = other.conditionTasks_.Clone();
			this.curUseTrialRoleId_ = other.curUseTrialRoleId_;
			this.curUseRoleInfo_ = ((other.curUseRoleInfo_ != null) ? other.curUseRoleInfo_.Clone() : null);
			this.newPlayerPoolFinalGachaRoleId_ = other.newPlayerPoolFinalGachaRoleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F6ED RID: 63213 RVA: 0x0023FF72 File Offset: 0x0023E172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportActivityData Clone()
		{
			return new NewPlayerSupportActivityData(this);
		}

		// Token: 0x17003249 RID: 12873
		// (get) Token: 0x0600F6EE RID: 63214 RVA: 0x0023FF7A File Offset: 0x0023E17A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NewTrialRoleInfo> TrialRoleInfoList
		{
			get
			{
				return this.trialRoleInfoList_;
			}
		}

		// Token: 0x1700324A RID: 12874
		// (get) Token: 0x0600F6EF RID: 63215 RVA: 0x0023FF82 File Offset: 0x0023E182
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x1700324B RID: 12875
		// (get) Token: 0x0600F6F0 RID: 63216 RVA: 0x0023FF8A File Offset: 0x0023E18A
		// (set) Token: 0x0600F6F1 RID: 63217 RVA: 0x0023FF92 File Offset: 0x0023E192
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurUseTrialRoleId
		{
			get
			{
				return this.curUseTrialRoleId_;
			}
			set
			{
				this.curUseTrialRoleId_ = value;
			}
		}

		// Token: 0x1700324C RID: 12876
		// (get) Token: 0x0600F6F2 RID: 63218 RVA: 0x0023FF9B File Offset: 0x0023E19B
		// (set) Token: 0x0600F6F3 RID: 63219 RVA: 0x0023FFA3 File Offset: 0x0023E1A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public roleInfo CurUseRoleInfo
		{
			get
			{
				return this.curUseRoleInfo_;
			}
			set
			{
				this.curUseRoleInfo_ = value;
			}
		}

		// Token: 0x1700324D RID: 12877
		// (get) Token: 0x0600F6F4 RID: 63220 RVA: 0x0023FFAC File Offset: 0x0023E1AC
		// (set) Token: 0x0600F6F5 RID: 63221 RVA: 0x0023FFB4 File Offset: 0x0023E1B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NewPlayerPoolFinalGachaRoleId
		{
			get
			{
				return this.newPlayerPoolFinalGachaRoleId_;
			}
			set
			{
				this.newPlayerPoolFinalGachaRoleId_ = value;
			}
		}

		// Token: 0x0600F6F6 RID: 63222 RVA: 0x0023FFBD File Offset: 0x0023E1BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewPlayerSupportActivityData);
		}

		// Token: 0x0600F6F7 RID: 63223 RVA: 0x0023FFCC File Offset: 0x0023E1CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewPlayerSupportActivityData other)
		{
			return other != null && (other == this || (this.trialRoleInfoList_.Equals(other.trialRoleInfoList_) && this.conditionTasks_.Equals(other.conditionTasks_) && this.CurUseTrialRoleId == other.CurUseTrialRoleId && object.Equals(this.CurUseRoleInfo, other.CurUseRoleInfo) && this.NewPlayerPoolFinalGachaRoleId == other.NewPlayerPoolFinalGachaRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F6F8 RID: 63224 RVA: 0x00240054 File Offset: 0x0023E254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.trialRoleInfoList_.GetHashCode();
			num ^= this.conditionTasks_.GetHashCode();
			if (this.CurUseTrialRoleId != 0)
			{
				num ^= this.CurUseTrialRoleId.GetHashCode();
			}
			if (this.curUseRoleInfo_ != null)
			{
				num ^= this.CurUseRoleInfo.GetHashCode();
			}
			if (this.NewPlayerPoolFinalGachaRoleId != 0)
			{
				num ^= this.NewPlayerPoolFinalGachaRoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F6F9 RID: 63225 RVA: 0x002400DE File Offset: 0x0023E2DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F6FA RID: 63226 RVA: 0x002400EB File Offset: 0x0023E2EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F6FB RID: 63227 RVA: 0x002400F4 File Offset: 0x0023E2F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.trialRoleInfoList_.WriteTo(ref output, NewPlayerSupportActivityData._repeated_trialRoleInfoList_codec);
			this.conditionTasks_.WriteTo(ref output, NewPlayerSupportActivityData._repeated_conditionTasks_codec);
			if (this.CurUseTrialRoleId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CurUseTrialRoleId);
			}
			if (this.curUseRoleInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.CurUseRoleInfo);
			}
			if (this.NewPlayerPoolFinalGachaRoleId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.NewPlayerPoolFinalGachaRoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F6FC RID: 63228 RVA: 0x0024018C File Offset: 0x0023E38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.trialRoleInfoList_.CalculateSize(NewPlayerSupportActivityData._repeated_trialRoleInfoList_codec);
			num += this.conditionTasks_.CalculateSize(NewPlayerSupportActivityData._repeated_conditionTasks_codec);
			if (this.CurUseTrialRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurUseTrialRoleId);
			}
			if (this.curUseRoleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CurUseRoleInfo);
			}
			if (this.NewPlayerPoolFinalGachaRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NewPlayerPoolFinalGachaRoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F6FD RID: 63229 RVA: 0x00240220 File Offset: 0x0023E420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewPlayerSupportActivityData other)
		{
			if (other == null)
			{
				return;
			}
			this.trialRoleInfoList_.Add(other.trialRoleInfoList_);
			this.conditionTasks_.Add(other.conditionTasks_);
			if (other.CurUseTrialRoleId != 0)
			{
				this.CurUseTrialRoleId = other.CurUseTrialRoleId;
			}
			if (other.curUseRoleInfo_ != null)
			{
				if (this.curUseRoleInfo_ == null)
				{
					this.CurUseRoleInfo = new roleInfo();
				}
				this.CurUseRoleInfo.MergeFrom(other.CurUseRoleInfo);
			}
			if (other.NewPlayerPoolFinalGachaRoleId != 0)
			{
				this.NewPlayerPoolFinalGachaRoleId = other.NewPlayerPoolFinalGachaRoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F6FE RID: 63230 RVA: 0x002402BE File Offset: 0x0023E4BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F6FF RID: 63231 RVA: 0x002402C8 File Offset: 0x0023E4C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num <= 18U)
				{
					if (num == 10U)
					{
						this.trialRoleInfoList_.AddEntriesFrom(ref input, NewPlayerSupportActivityData._repeated_trialRoleInfoList_codec);
						continue;
					}
					if (num == 18U)
					{
						this.conditionTasks_.AddEntriesFrom(ref input, NewPlayerSupportActivityData._repeated_conditionTasks_codec);
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.CurUseTrialRoleId = input.ReadInt32();
						continue;
					}
					if (num == 34U)
					{
						if (this.curUseRoleInfo_ == null)
						{
							this.CurUseRoleInfo = new roleInfo();
						}
						input.ReadMessage(this.CurUseRoleInfo);
						continue;
					}
					if (num == 40U)
					{
						this.NewPlayerPoolFinalGachaRoleId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006314 RID: 25364
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006315 RID: 25365
		public const int TrialRoleInfoListFieldNumber = 1;

		// Token: 0x04006316 RID: 25366
		private static readonly FieldCodec<NewTrialRoleInfo> _repeated_trialRoleInfoList_codec = FieldCodec.ForMessage<NewTrialRoleInfo>(10U, NewTrialRoleInfo.Parser);

		// Token: 0x04006317 RID: 25367
		private readonly RepeatedField<NewTrialRoleInfo> trialRoleInfoList_ = new RepeatedField<NewTrialRoleInfo>();

		// Token: 0x04006318 RID: 25368
		public const int ConditionTasksFieldNumber = 2;

		// Token: 0x04006319 RID: 25369
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(18U, ConditionTask.Parser);

		// Token: 0x0400631A RID: 25370
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();

		// Token: 0x0400631B RID: 25371
		public const int CurUseTrialRoleIdFieldNumber = 3;

		// Token: 0x0400631C RID: 25372
		private int curUseTrialRoleId_;

		// Token: 0x0400631D RID: 25373
		public const int CurUseRoleInfoFieldNumber = 4;

		// Token: 0x0400631E RID: 25374
		private roleInfo curUseRoleInfo_;

		// Token: 0x0400631F RID: 25375
		public const int NewPlayerPoolFinalGachaRoleIdFieldNumber = 5;

		// Token: 0x04006320 RID: 25376
		private int newPlayerPoolFinalGachaRoleId_;
	}
}
