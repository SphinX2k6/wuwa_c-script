using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200119C RID: 4508
	[NetMessage(EMessageId.ScratchCardActivityInfoRequest)]
	public sealed class ScratchCardActivityInfoRequest : IMessage<ScratchCardActivityInfoRequest>, IMessage, IEquatable<ScratchCardActivityInfoRequest>, IDeepCloneable<ScratchCardActivityInfoRequest>, IBufferMessage
	{
		// Token: 0x06018058 RID: 98392 RVA: 0x0037CF2A File Offset: 0x0037B12A
		[NullableContext(1)]
		public static ScratchCardActivityInfoRequest Create()
		{
			return new ScratchCardActivityInfoRequest();
		}

		// Token: 0x170050B8 RID: 20664
		// (get) Token: 0x06018059 RID: 98393 RVA: 0x0037CF31 File Offset: 0x0037B131
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050B9 RID: 20665
		// (get) Token: 0x0601805A RID: 98394 RVA: 0x0037CF34 File Offset: 0x0037B134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ScratchCardActivityInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601805B RID: 98395 RVA: 0x0037CF3B File Offset: 0x0037B13B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardActivityInfoRequest()
		{
		}

		// Token: 0x0601805C RID: 98396 RVA: 0x0037CF43 File Offset: 0x0037B143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardActivityInfoRequest(ScratchCardActivityInfoRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601805D RID: 98397 RVA: 0x0037CF68 File Offset: 0x0037B168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardActivityInfoRequest Clone()
		{
			return new ScratchCardActivityInfoRequest(this);
		}

		// Token: 0x170050BA RID: 20666
		// (get) Token: 0x0601805E RID: 98398 RVA: 0x0037CF70 File Offset: 0x0037B170
		// (set) Token: 0x0601805F RID: 98399 RVA: 0x0037CF78 File Offset: 0x0037B178
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

		// Token: 0x06018060 RID: 98400 RVA: 0x0037CF81 File Offset: 0x0037B181
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ScratchCardActivityInfoRequest);
		}

		// Token: 0x06018061 RID: 98401 RVA: 0x0037CF8F File Offset: 0x0037B18F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ScratchCardActivityInfoRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018062 RID: 98402 RVA: 0x0037CFC0 File Offset: 0x0037B1C0
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

		// Token: 0x06018063 RID: 98403 RVA: 0x0037CFFF File Offset: 0x0037B1FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018064 RID: 98404 RVA: 0x0037D00C File Offset: 0x0037B20C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018065 RID: 98405 RVA: 0x0037D015 File Offset: 0x0037B215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018066 RID: 98406 RVA: 0x0037D048 File Offset: 0x0037B248
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

		// Token: 0x06018067 RID: 98407 RVA: 0x0037D086 File Offset: 0x0037B286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ScratchCardActivityInfoRequest other)
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

		// Token: 0x06018068 RID: 98408 RVA: 0x0037D0B7 File Offset: 0x0037B2B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018069 RID: 98409 RVA: 0x0037D0C0 File Offset: 0x0037B2C0
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008E3B RID: 36411
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E3C RID: 36412
		public const int ActivityIdFieldNumber = 8;

		// Token: 0x04008E3D RID: 36413
		private int activityId_;
	}
}
