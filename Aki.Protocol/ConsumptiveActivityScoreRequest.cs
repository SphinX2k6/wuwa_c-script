using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002EB RID: 747
	[NetMessage(EMessageId.ConsumptiveActivityScoreRequest)]
	public sealed class ConsumptiveActivityScoreRequest : IMessage<ConsumptiveActivityScoreRequest>, IMessage, IEquatable<ConsumptiveActivityScoreRequest>, IDeepCloneable<ConsumptiveActivityScoreRequest>, IBufferMessage
	{
		// Token: 0x06004C2C RID: 19500 RVA: 0x000B9D53 File Offset: 0x000B7F53
		[NullableContext(1)]
		public static ConsumptiveActivityScoreRequest Create()
		{
			return new ConsumptiveActivityScoreRequest();
		}

		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x06004C2D RID: 19501 RVA: 0x000B9D5A File Offset: 0x000B7F5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x06004C2E RID: 19502 RVA: 0x000B9D5D File Offset: 0x000B7F5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConsumptiveActivityScoreRequest.Descriptor;
			}
		}

		// Token: 0x06004C2F RID: 19503 RVA: 0x000B9D64 File Offset: 0x000B7F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveActivityScoreRequest()
		{
		}

		// Token: 0x06004C30 RID: 19504 RVA: 0x000B9D6C File Offset: 0x000B7F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveActivityScoreRequest(ConsumptiveActivityScoreRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004C31 RID: 19505 RVA: 0x000B9D91 File Offset: 0x000B7F91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveActivityScoreRequest Clone()
		{
			return new ConsumptiveActivityScoreRequest(this);
		}

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x06004C32 RID: 19506 RVA: 0x000B9D99 File Offset: 0x000B7F99
		// (set) Token: 0x06004C33 RID: 19507 RVA: 0x000B9DA1 File Offset: 0x000B7FA1
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

		// Token: 0x06004C34 RID: 19508 RVA: 0x000B9DAA File Offset: 0x000B7FAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConsumptiveActivityScoreRequest);
		}

		// Token: 0x06004C35 RID: 19509 RVA: 0x000B9DB8 File Offset: 0x000B7FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConsumptiveActivityScoreRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004C36 RID: 19510 RVA: 0x000B9DE8 File Offset: 0x000B7FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06004C37 RID: 19511 RVA: 0x000B9E27 File Offset: 0x000B8027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004C38 RID: 19512 RVA: 0x000B9E34 File Offset: 0x000B8034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004C39 RID: 19513 RVA: 0x000B9E3D File Offset: 0x000B803D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004C3A RID: 19514 RVA: 0x000B9E70 File Offset: 0x000B8070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06004C3B RID: 19515 RVA: 0x000B9EAE File Offset: 0x000B80AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConsumptiveActivityScoreRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004C3C RID: 19516 RVA: 0x000B9EDF File Offset: 0x000B80DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004C3D RID: 19517 RVA: 0x000B9EE8 File Offset: 0x000B80E8
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003144 RID: 12612
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003145 RID: 12613
		public const int ActivityIdFieldNumber = 11;

		// Token: 0x04003146 RID: 12614
		private int activityId_;
	}
}
