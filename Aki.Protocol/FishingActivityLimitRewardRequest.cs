using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200052D RID: 1325
	[NetMessage(EMessageId.FishingActivityLimitRewardRequest)]
	public sealed class FishingActivityLimitRewardRequest : IMessage<FishingActivityLimitRewardRequest>, IMessage, IEquatable<FishingActivityLimitRewardRequest>, IDeepCloneable<FishingActivityLimitRewardRequest>, IBufferMessage
	{
		// Token: 0x06007C9E RID: 31902 RVA: 0x0012E8FD File Offset: 0x0012CAFD
		[NullableContext(1)]
		public static FishingActivityLimitRewardRequest Create()
		{
			return new FishingActivityLimitRewardRequest();
		}

		// Token: 0x1700183B RID: 6203
		// (get) Token: 0x06007C9F RID: 31903 RVA: 0x0012E904 File Offset: 0x0012CB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700183C RID: 6204
		// (get) Token: 0x06007CA0 RID: 31904 RVA: 0x0012E907 File Offset: 0x0012CB07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingActivityLimitRewardRequest.Descriptor;
			}
		}

		// Token: 0x06007CA1 RID: 31905 RVA: 0x0012E90E File Offset: 0x0012CB0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityLimitRewardRequest()
		{
		}

		// Token: 0x06007CA2 RID: 31906 RVA: 0x0012E916 File Offset: 0x0012CB16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityLimitRewardRequest(FishingActivityLimitRewardRequest other) : this()
		{
			this.taskId_ = other.taskId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007CA3 RID: 31907 RVA: 0x0012E93B File Offset: 0x0012CB3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityLimitRewardRequest Clone()
		{
			return new FishingActivityLimitRewardRequest(this);
		}

		// Token: 0x1700183D RID: 6205
		// (get) Token: 0x06007CA4 RID: 31908 RVA: 0x0012E943 File Offset: 0x0012CB43
		// (set) Token: 0x06007CA5 RID: 31909 RVA: 0x0012E94B File Offset: 0x0012CB4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TaskId
		{
			get
			{
				return this.taskId_;
			}
			set
			{
				this.taskId_ = value;
			}
		}

		// Token: 0x06007CA6 RID: 31910 RVA: 0x0012E954 File Offset: 0x0012CB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingActivityLimitRewardRequest);
		}

		// Token: 0x06007CA7 RID: 31911 RVA: 0x0012E962 File Offset: 0x0012CB62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingActivityLimitRewardRequest other)
		{
			return other != null && (other == this || (this.TaskId == other.TaskId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007CA8 RID: 31912 RVA: 0x0012E990 File Offset: 0x0012CB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TaskId != 0)
			{
				num ^= this.TaskId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007CA9 RID: 31913 RVA: 0x0012E9CF File Offset: 0x0012CBCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007CAA RID: 31914 RVA: 0x0012E9DC File Offset: 0x0012CBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007CAB RID: 31915 RVA: 0x0012E9E5 File Offset: 0x0012CBE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TaskId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TaskId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007CAC RID: 31916 RVA: 0x0012EA18 File Offset: 0x0012CC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TaskId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TaskId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007CAD RID: 31917 RVA: 0x0012EA56 File Offset: 0x0012CC56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingActivityLimitRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TaskId != 0)
			{
				this.TaskId = other.TaskId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007CAE RID: 31918 RVA: 0x0012EA87 File Offset: 0x0012CC87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007CAF RID: 31919 RVA: 0x0012EA90 File Offset: 0x0012CC90
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TaskId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003FF9 RID: 16377
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003FFA RID: 16378
		public const int TaskIdFieldNumber = 4;

		// Token: 0x04003FFB RID: 16379
		private int taskId_;
	}
}
