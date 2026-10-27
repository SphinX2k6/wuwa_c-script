using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EE3 RID: 3811
	[NetMessage(EMessageId.RegressRepeatedTaskRequest)]
	public sealed class RegressRepeatedTaskRequest : IMessage<RegressRepeatedTaskRequest>, IMessage, IEquatable<RegressRepeatedTaskRequest>, IDeepCloneable<RegressRepeatedTaskRequest>, IBufferMessage
	{
		// Token: 0x060146D0 RID: 83664 RVA: 0x002F7E31 File Offset: 0x002F6031
		[NullableContext(1)]
		public static RegressRepeatedTaskRequest Create()
		{
			return new RegressRepeatedTaskRequest();
		}

		// Token: 0x170043ED RID: 17389
		// (get) Token: 0x060146D1 RID: 83665 RVA: 0x002F7E38 File Offset: 0x002F6038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043EE RID: 17390
		// (get) Token: 0x060146D2 RID: 83666 RVA: 0x002F7E3B File Offset: 0x002F603B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressRepeatedTaskRequest.Descriptor;
			}
		}

		// Token: 0x060146D3 RID: 83667 RVA: 0x002F7E42 File Offset: 0x002F6042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressRepeatedTaskRequest()
		{
		}

		// Token: 0x060146D4 RID: 83668 RVA: 0x002F7E55 File Offset: 0x002F6055
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressRepeatedTaskRequest(RegressRepeatedTaskRequest other) : this()
		{
			this.taskId_ = other.taskId_.Clone();
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060146D5 RID: 83669 RVA: 0x002F7E8B File Offset: 0x002F608B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressRepeatedTaskRequest Clone()
		{
			return new RegressRepeatedTaskRequest(this);
		}

		// Token: 0x170043EF RID: 17391
		// (get) Token: 0x060146D6 RID: 83670 RVA: 0x002F7E93 File Offset: 0x002F6093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskId
		{
			get
			{
				return this.taskId_;
			}
		}

		// Token: 0x170043F0 RID: 17392
		// (get) Token: 0x060146D7 RID: 83671 RVA: 0x002F7E9B File Offset: 0x002F609B
		// (set) Token: 0x060146D8 RID: 83672 RVA: 0x002F7EA3 File Offset: 0x002F60A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x060146D9 RID: 83673 RVA: 0x002F7EAC File Offset: 0x002F60AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressRepeatedTaskRequest);
		}

		// Token: 0x060146DA RID: 83674 RVA: 0x002F7EBC File Offset: 0x002F60BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressRepeatedTaskRequest other)
		{
			return other != null && (other == this || (this.taskId_.Equals(other.taskId_) && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060146DB RID: 83675 RVA: 0x002F7F0C File Offset: 0x002F610C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.taskId_.GetHashCode();
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060146DC RID: 83676 RVA: 0x002F7F59 File Offset: 0x002F6159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060146DD RID: 83677 RVA: 0x002F7F66 File Offset: 0x002F6166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060146DE RID: 83678 RVA: 0x002F7F70 File Offset: 0x002F6170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ActivityId);
			}
			this.taskId_.WriteTo(ref output, RegressRepeatedTaskRequest._repeated_taskId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060146DF RID: 83679 RVA: 0x002F7FC0 File Offset: 0x002F61C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskId_.CalculateSize(RegressRepeatedTaskRequest._repeated_taskId_codec);
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060146E0 RID: 83680 RVA: 0x002F8014 File Offset: 0x002F6214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RegressRepeatedTaskRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.taskId_.Add(other.taskId_);
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060146E1 RID: 83681 RVA: 0x002F8061 File Offset: 0x002F6261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060146E2 RID: 83682 RVA: 0x002F806C File Offset: 0x002F626C
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
				if (num != 32U)
				{
					if (num != 56U && num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.taskId_.AddEntriesFrom(ref input, RegressRepeatedTaskRequest._repeated_taskId_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007BF9 RID: 31737
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007BFA RID: 31738
		public const int TaskIdFieldNumber = 7;

		// Token: 0x04007BFB RID: 31739
		private static readonly FieldCodec<int> _repeated_taskId_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04007BFC RID: 31740
		private readonly RepeatedField<int> taskId_ = new RepeatedField<int>();

		// Token: 0x04007BFD RID: 31741
		public const int ActivityIdFieldNumber = 4;

		// Token: 0x04007BFE RID: 31742
		private int activityId_;
	}
}
