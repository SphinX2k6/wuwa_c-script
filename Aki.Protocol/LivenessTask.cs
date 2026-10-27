using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000935 RID: 2357
	public sealed class LivenessTask : IMessage<LivenessTask>, IMessage, IEquatable<LivenessTask>, IDeepCloneable<LivenessTask>, IBufferMessage
	{
		// Token: 0x0600CFBE RID: 53182 RVA: 0x001E94CC File Offset: 0x001E76CC
		[NullableContext(1)]
		public static LivenessTask Create()
		{
			return new LivenessTask();
		}

		// Token: 0x170029F7 RID: 10743
		// (get) Token: 0x0600CFBF RID: 53183 RVA: 0x001E94D3 File Offset: 0x001E76D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LivenessTask> Parser
		{
			get
			{
				return LivenessTask._parser;
			}
		}

		// Token: 0x170029F8 RID: 10744
		// (get) Token: 0x0600CFC0 RID: 53184 RVA: 0x001E94DA File Offset: 0x001E76DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029F9 RID: 10745
		// (get) Token: 0x0600CFC1 RID: 53185 RVA: 0x001E94DD File Offset: 0x001E76DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LivenessTask.Descriptor;
			}
		}

		// Token: 0x0600CFC2 RID: 53186 RVA: 0x001E94E4 File Offset: 0x001E76E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessTask()
		{
		}

		// Token: 0x0600CFC3 RID: 53187 RVA: 0x001E94EC File Offset: 0x001E76EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessTask(LivenessTask other) : this()
		{
			this.id_ = other.id_;
			this.current_ = other.current_;
			this.target_ = other.target_;
			this.isFinished_ = other.isFinished_;
			this.isTaken_ = other.isTaken_;
			this.isConditionUnlock_ = other.isConditionUnlock_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CFC4 RID: 53188 RVA: 0x001E9558 File Offset: 0x001E7758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessTask Clone()
		{
			return new LivenessTask(this);
		}

		// Token: 0x170029FA RID: 10746
		// (get) Token: 0x0600CFC5 RID: 53189 RVA: 0x001E9560 File Offset: 0x001E7760
		// (set) Token: 0x0600CFC6 RID: 53190 RVA: 0x001E9568 File Offset: 0x001E7768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170029FB RID: 10747
		// (get) Token: 0x0600CFC7 RID: 53191 RVA: 0x001E9571 File Offset: 0x001E7771
		// (set) Token: 0x0600CFC8 RID: 53192 RVA: 0x001E9579 File Offset: 0x001E7779
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Current
		{
			get
			{
				return this.current_;
			}
			set
			{
				this.current_ = value;
			}
		}

		// Token: 0x170029FC RID: 10748
		// (get) Token: 0x0600CFC9 RID: 53193 RVA: 0x001E9582 File Offset: 0x001E7782
		// (set) Token: 0x0600CFCA RID: 53194 RVA: 0x001E958A File Offset: 0x001E778A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Target
		{
			get
			{
				return this.target_;
			}
			set
			{
				this.target_ = value;
			}
		}

		// Token: 0x170029FD RID: 10749
		// (get) Token: 0x0600CFCB RID: 53195 RVA: 0x001E9593 File Offset: 0x001E7793
		// (set) Token: 0x0600CFCC RID: 53196 RVA: 0x001E959B File Offset: 0x001E779B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFinished
		{
			get
			{
				return this.isFinished_;
			}
			set
			{
				this.isFinished_ = value;
			}
		}

		// Token: 0x170029FE RID: 10750
		// (get) Token: 0x0600CFCD RID: 53197 RVA: 0x001E95A4 File Offset: 0x001E77A4
		// (set) Token: 0x0600CFCE RID: 53198 RVA: 0x001E95AC File Offset: 0x001E77AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsTaken
		{
			get
			{
				return this.isTaken_;
			}
			set
			{
				this.isTaken_ = value;
			}
		}

		// Token: 0x170029FF RID: 10751
		// (get) Token: 0x0600CFCF RID: 53199 RVA: 0x001E95B5 File Offset: 0x001E77B5
		// (set) Token: 0x0600CFD0 RID: 53200 RVA: 0x001E95BD File Offset: 0x001E77BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsConditionUnlock
		{
			get
			{
				return this.isConditionUnlock_;
			}
			set
			{
				this.isConditionUnlock_ = value;
			}
		}

		// Token: 0x0600CFD1 RID: 53201 RVA: 0x001E95C6 File Offset: 0x001E77C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LivenessTask);
		}

		// Token: 0x0600CFD2 RID: 53202 RVA: 0x001E95D4 File Offset: 0x001E77D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LivenessTask other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Current == other.Current && this.Target == other.Target && this.IsFinished == other.IsFinished && this.IsTaken == other.IsTaken && this.IsConditionUnlock == other.IsConditionUnlock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CFD3 RID: 53203 RVA: 0x001E9660 File Offset: 0x001E7860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Current != 0)
			{
				int num2 = num;
				int num3 = this.Current;
				num = (num2 ^ num3.GetHashCode());
			}
			if (this.Target != 0)
			{
				num ^= this.Target.GetHashCode();
			}
			if (this.IsFinished)
			{
				num ^= this.IsFinished.GetHashCode();
			}
			if (this.IsTaken)
			{
				num ^= this.IsTaken.GetHashCode();
			}
			if (this.IsConditionUnlock)
			{
				num ^= this.IsConditionUnlock.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CFD4 RID: 53204 RVA: 0x001E971C File Offset: 0x001E791C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CFD5 RID: 53205 RVA: 0x001E9729 File Offset: 0x001E7929
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CFD6 RID: 53206 RVA: 0x001E9734 File Offset: 0x001E7934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Current != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Current);
			}
			if (this.Target != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Target);
			}
			if (this.IsFinished)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsFinished);
			}
			if (this.IsTaken)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsTaken);
			}
			if (this.IsConditionUnlock)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsConditionUnlock);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CFD7 RID: 53207 RVA: 0x001E97FC File Offset: 0x001E79FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Current != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Current);
			}
			if (this.Target != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Target);
			}
			if (this.IsFinished)
			{
				num += 2;
			}
			if (this.IsTaken)
			{
				num += 2;
			}
			if (this.IsConditionUnlock)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CFD8 RID: 53208 RVA: 0x001E9890 File Offset: 0x001E7A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LivenessTask other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Current != 0)
			{
				this.Current = other.Current;
			}
			if (other.Target != 0)
			{
				this.Target = other.Target;
			}
			if (other.IsFinished)
			{
				this.IsFinished = other.IsFinished;
			}
			if (other.IsTaken)
			{
				this.IsTaken = other.IsTaken;
			}
			if (other.IsConditionUnlock)
			{
				this.IsConditionUnlock = other.IsConditionUnlock;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CFD9 RID: 53209 RVA: 0x001E9930 File Offset: 0x001E7B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CFDA RID: 53210 RVA: 0x001E993C File Offset: 0x001E7B3C
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Current = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.Target = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.IsFinished = input.ReadBool();
						continue;
					}
					if (num == 40U)
					{
						this.IsTaken = input.ReadBool();
						continue;
					}
					if (num == 48U)
					{
						this.IsConditionUnlock = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005799 RID: 22425
		private static readonly MessageParser<LivenessTask> _parser = new MessageParser<LivenessTask>(() => new LivenessTask());

		// Token: 0x0400579A RID: 22426
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400579B RID: 22427
		public const int IdFieldNumber = 1;

		// Token: 0x0400579C RID: 22428
		private int id_;

		// Token: 0x0400579D RID: 22429
		public const int CurrentFieldNumber = 2;

		// Token: 0x0400579E RID: 22430
		private int current_;

		// Token: 0x0400579F RID: 22431
		public const int TargetFieldNumber = 3;

		// Token: 0x040057A0 RID: 22432
		private int target_;

		// Token: 0x040057A1 RID: 22433
		public const int IsFinishedFieldNumber = 4;

		// Token: 0x040057A2 RID: 22434
		private bool isFinished_;

		// Token: 0x040057A3 RID: 22435
		public const int IsTakenFieldNumber = 5;

		// Token: 0x040057A4 RID: 22436
		private bool isTaken_;

		// Token: 0x040057A5 RID: 22437
		public const int IsConditionUnlockFieldNumber = 6;

		// Token: 0x040057A6 RID: 22438
		private bool isConditionUnlock_;
	}
}
