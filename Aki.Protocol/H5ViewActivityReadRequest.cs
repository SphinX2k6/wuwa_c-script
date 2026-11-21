using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200071C RID: 1820
	[NetMessage(EMessageId.H5ViewActivityReadRequest)]
	public sealed class H5ViewActivityReadRequest : IMessage<H5ViewActivityReadRequest>, IMessage, IEquatable<H5ViewActivityReadRequest>, IDeepCloneable<H5ViewActivityReadRequest>, IBufferMessage
	{
		// Token: 0x0600A59C RID: 42396 RVA: 0x0018F7E0 File Offset: 0x0018D9E0
		[NullableContext(1)]
		public static H5ViewActivityReadRequest Create()
		{
			return new H5ViewActivityReadRequest();
		}

		// Token: 0x17002148 RID: 8520
		// (get) Token: 0x0600A59D RID: 42397 RVA: 0x0018F7E7 File Offset: 0x0018D9E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002149 RID: 8521
		// (get) Token: 0x0600A59E RID: 42398 RVA: 0x0018F7EA File Offset: 0x0018D9EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return H5ViewActivityReadRequest.Descriptor;
			}
		}

		// Token: 0x0600A59F RID: 42399 RVA: 0x0018F7F1 File Offset: 0x0018D9F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5ViewActivityReadRequest()
		{
		}

		// Token: 0x0600A5A0 RID: 42400 RVA: 0x0018F7F9 File Offset: 0x0018D9F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5ViewActivityReadRequest(H5ViewActivityReadRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A5A1 RID: 42401 RVA: 0x0018F81E File Offset: 0x0018DA1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5ViewActivityReadRequest Clone()
		{
			return new H5ViewActivityReadRequest(this);
		}

		// Token: 0x1700214A RID: 8522
		// (get) Token: 0x0600A5A2 RID: 42402 RVA: 0x0018F826 File Offset: 0x0018DA26
		// (set) Token: 0x0600A5A3 RID: 42403 RVA: 0x0018F82E File Offset: 0x0018DA2E
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

		// Token: 0x0600A5A4 RID: 42404 RVA: 0x0018F837 File Offset: 0x0018DA37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as H5ViewActivityReadRequest);
		}

		// Token: 0x0600A5A5 RID: 42405 RVA: 0x0018F845 File Offset: 0x0018DA45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(H5ViewActivityReadRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A5A6 RID: 42406 RVA: 0x0018F874 File Offset: 0x0018DA74
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

		// Token: 0x0600A5A7 RID: 42407 RVA: 0x0018F8B3 File Offset: 0x0018DAB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A5A8 RID: 42408 RVA: 0x0018F8C0 File Offset: 0x0018DAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A5A9 RID: 42409 RVA: 0x0018F8C9 File Offset: 0x0018DAC9
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

		// Token: 0x0600A5AA RID: 42410 RVA: 0x0018F8FC File Offset: 0x0018DAFC
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

		// Token: 0x0600A5AB RID: 42411 RVA: 0x0018F93A File Offset: 0x0018DB3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(H5ViewActivityReadRequest other)
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

		// Token: 0x0600A5AC RID: 42412 RVA: 0x0018F96B File Offset: 0x0018DB6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A5AD RID: 42413 RVA: 0x0018F974 File Offset: 0x0018DB74
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

		// Token: 0x04004C6A RID: 19562
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C6B RID: 19563
		public const int ActivityIdFieldNumber = 11;

		// Token: 0x04004C6C RID: 19564
		private int activityId_;
	}
}
