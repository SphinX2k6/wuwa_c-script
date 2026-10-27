using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000832 RID: 2098
	[NetMessage(EMessageId.InteractiveUpdateRequest)]
	public sealed class InteractiveUpdateRequest : IMessage<InteractiveUpdateRequest>, IMessage, IEquatable<InteractiveUpdateRequest>, IDeepCloneable<InteractiveUpdateRequest>, IBufferMessage
	{
		// Token: 0x0600BB7C RID: 47996 RVA: 0x001BE968 File Offset: 0x001BCB68
		[NullableContext(1)]
		public static InteractiveUpdateRequest Create()
		{
			return new InteractiveUpdateRequest();
		}

		// Token: 0x170025DD RID: 9693
		// (get) Token: 0x0600BB7D RID: 47997 RVA: 0x001BE96F File Offset: 0x001BCB6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025DE RID: 9694
		// (get) Token: 0x0600BB7E RID: 47998 RVA: 0x001BE972 File Offset: 0x001BCB72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InteractiveUpdateRequest.Descriptor;
			}
		}

		// Token: 0x0600BB7F RID: 47999 RVA: 0x001BE979 File Offset: 0x001BCB79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractiveUpdateRequest()
		{
		}

		// Token: 0x0600BB80 RID: 48000 RVA: 0x001BE981 File Offset: 0x001BCB81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractiveUpdateRequest(InteractiveUpdateRequest other) : this()
		{
			this.interactiveId_ = other.interactiveId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BB81 RID: 48001 RVA: 0x001BE9A6 File Offset: 0x001BCBA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractiveUpdateRequest Clone()
		{
			return new InteractiveUpdateRequest(this);
		}

		// Token: 0x170025DF RID: 9695
		// (get) Token: 0x0600BB82 RID: 48002 RVA: 0x001BE9AE File Offset: 0x001BCBAE
		// (set) Token: 0x0600BB83 RID: 48003 RVA: 0x001BE9B6 File Offset: 0x001BCBB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InteractiveId
		{
			get
			{
				return this.interactiveId_;
			}
			set
			{
				this.interactiveId_ = value;
			}
		}

		// Token: 0x0600BB84 RID: 48004 RVA: 0x001BE9BF File Offset: 0x001BCBBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InteractiveUpdateRequest);
		}

		// Token: 0x0600BB85 RID: 48005 RVA: 0x001BE9CD File Offset: 0x001BCBCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InteractiveUpdateRequest other)
		{
			return other != null && (other == this || (this.InteractiveId == other.InteractiveId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BB86 RID: 48006 RVA: 0x001BE9FC File Offset: 0x001BCBFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InteractiveId != 0)
			{
				num ^= this.InteractiveId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BB87 RID: 48007 RVA: 0x001BEA3B File Offset: 0x001BCC3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BB88 RID: 48008 RVA: 0x001BEA48 File Offset: 0x001BCC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BB89 RID: 48009 RVA: 0x001BEA51 File Offset: 0x001BCC51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InteractiveId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.InteractiveId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BB8A RID: 48010 RVA: 0x001BEA84 File Offset: 0x001BCC84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InteractiveId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InteractiveId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BB8B RID: 48011 RVA: 0x001BEAC2 File Offset: 0x001BCCC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InteractiveUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InteractiveId != 0)
			{
				this.InteractiveId = other.InteractiveId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BB8C RID: 48012 RVA: 0x001BEAF3 File Offset: 0x001BCCF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BB8D RID: 48013 RVA: 0x001BEAFC File Offset: 0x001BCCFC
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.InteractiveId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400524B RID: 21067
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400524C RID: 21068
		public const int InteractiveIdFieldNumber = 9;

		// Token: 0x0400524D RID: 21069
		private int interactiveId_;
	}
}
