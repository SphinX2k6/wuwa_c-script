using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B0B RID: 2827
	public sealed class NewPlayerSupportActivityData : IMessage<NewPlayerSupportActivityData>, IMessage, IEquatable<NewPlayerSupportActivityData>, IDeepCloneable<NewPlayerSupportActivityData>, IBufferMessage
	{
		// Token: 0x0600F5CE RID: 62926 RVA: 0x0023DCAE File Offset: 0x0023BEAE
		[NullableContext(1)]
		public static NewPlayerSupportActivityData Create()
		{
			return new NewPlayerSupportActivityData();
		}

		// Token: 0x17003209 RID: 12809
		// (get) Token: 0x0600F5CF RID: 62927 RVA: 0x0023DCB5 File Offset: 0x0023BEB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700320A RID: 12810
		// (get) Token: 0x0600F5D0 RID: 62928 RVA: 0x0023DCB8 File Offset: 0x0023BEB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewPlayerSupportActivityData.Descriptor;
			}
		}

		// Token: 0x0600F5D1 RID: 62929 RVA: 0x0023DCBF File Offset: 0x0023BEBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportActivityData()
		{
		}

		// Token: 0x0600F5D2 RID: 62930 RVA: 0x0023DCE0 File Offset: 0x0023BEE0
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

		// Token: 0x0600F5D3 RID: 62931 RVA: 0x0023DD5A File Offset: 0x0023BF5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportActivityData Clone()
		{
			return new NewPlayerSupportActivityData(this);
		}

		// Token: 0x1700320B RID: 12811
		// (get) Token: 0x0600F5D4 RID: 62932 RVA: 0x0023DD62 File Offset: 0x0023BF62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NewTrialRoleInfo> TrialRoleInfoList
		{
			get
			{
				return this.trialRoleInfoList_;
			}
		}

		// Token: 0x1700320C RID: 12812
		// (get) Token: 0x0600F5D5 RID: 62933 RVA: 0x0023DD6A File Offset: 0x0023BF6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x1700320D RID: 12813
		// (get) Token: 0x0600F5D6 RID: 62934 RVA: 0x0023DD72 File Offset: 0x0023BF72
		// (set) Token: 0x0600F5D7 RID: 62935 RVA: 0x0023DD7A File Offset: 0x0023BF7A
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

		// Token: 0x1700320E RID: 12814
		// (get) Token: 0x0600F5D8 RID: 62936 RVA: 0x0023DD83 File Offset: 0x0023BF83
		// (set) Token: 0x0600F5D9 RID: 62937 RVA: 0x0023DD8B File Offset: 0x0023BF8B
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

		// Token: 0x1700320F RID: 12815
		// (get) Token: 0x0600F5DA RID: 62938 RVA: 0x0023DD94 File Offset: 0x0023BF94
		// (set) Token: 0x0600F5DB RID: 62939 RVA: 0x0023DD9C File Offset: 0x0023BF9C
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

		// Token: 0x0600F5DC RID: 62940 RVA: 0x0023DDA5 File Offset: 0x0023BFA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewPlayerSupportActivityData);
		}

		// Token: 0x0600F5DD RID: 62941 RVA: 0x0023DDB4 File Offset: 0x0023BFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewPlayerSupportActivityData other)
		{
			return other != null && (other == this || (this.trialRoleInfoList_.Equals(other.trialRoleInfoList_) && this.conditionTasks_.Equals(other.conditionTasks_) && this.CurUseTrialRoleId == other.CurUseTrialRoleId && object.Equals(this.CurUseRoleInfo, other.CurUseRoleInfo) && this.NewPlayerPoolFinalGachaRoleId == other.NewPlayerPoolFinalGachaRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F5DE RID: 62942 RVA: 0x0023DE3C File Offset: 0x0023C03C
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

		// Token: 0x0600F5DF RID: 62943 RVA: 0x0023DEC6 File Offset: 0x0023C0C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F5E0 RID: 62944 RVA: 0x0023DED3 File Offset: 0x0023C0D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F5E1 RID: 62945 RVA: 0x0023DEDC File Offset: 0x0023C0DC
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

		// Token: 0x0600F5E2 RID: 62946 RVA: 0x0023DF74 File Offset: 0x0023C174
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

		// Token: 0x0600F5E3 RID: 62947 RVA: 0x0023E008 File Offset: 0x0023C208
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

		// Token: 0x0600F5E4 RID: 62948 RVA: 0x0023E0A6 File Offset: 0x0023C2A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F5E5 RID: 62949 RVA: 0x0023E0B0 File Offset: 0x0023C2B0
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

		// Token: 0x0400631D RID: 25373
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400631E RID: 25374
		public const int TrialRoleInfoListFieldNumber = 1;

		// Token: 0x0400631F RID: 25375
		private static readonly FieldCodec<NewTrialRoleInfo> _repeated_trialRoleInfoList_codec = FieldCodec.ForMessage<NewTrialRoleInfo>(10U, NewTrialRoleInfo.Parser);

		// Token: 0x04006320 RID: 25376
		private readonly RepeatedField<NewTrialRoleInfo> trialRoleInfoList_ = new RepeatedField<NewTrialRoleInfo>();

		// Token: 0x04006321 RID: 25377
		public const int ConditionTasksFieldNumber = 2;

		// Token: 0x04006322 RID: 25378
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(18U, ConditionTask.Parser);

		// Token: 0x04006323 RID: 25379
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();

		// Token: 0x04006324 RID: 25380
		public const int CurUseTrialRoleIdFieldNumber = 3;

		// Token: 0x04006325 RID: 25381
		private int curUseTrialRoleId_;

		// Token: 0x04006326 RID: 25382
		public const int CurUseRoleInfoFieldNumber = 4;

		// Token: 0x04006327 RID: 25383
		private roleInfo curUseRoleInfo_;

		// Token: 0x04006328 RID: 25384
		public const int NewPlayerPoolFinalGachaRoleIdFieldNumber = 5;

		// Token: 0x04006329 RID: 25385
		private int newPlayerPoolFinalGachaRoleId_;
	}
}
