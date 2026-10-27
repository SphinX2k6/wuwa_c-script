using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200122B RID: 4651
	[NetMessage(EMessageId.SimpleTrackReportRequest)]
	public sealed class SimpleTrackReportRequest : IMessage<SimpleTrackReportRequest>, IMessage, IEquatable<SimpleTrackReportRequest>, IDeepCloneable<SimpleTrackReportRequest>, IBufferMessage
	{
		// Token: 0x06018C93 RID: 101523 RVA: 0x0039B4AA File Offset: 0x003996AA
		[NullableContext(1)]
		public static SimpleTrackReportRequest Create()
		{
			return new SimpleTrackReportRequest();
		}

		// Token: 0x1700538A RID: 21386
		// (get) Token: 0x06018C94 RID: 101524 RVA: 0x0039B4B1 File Offset: 0x003996B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700538B RID: 21387
		// (get) Token: 0x06018C95 RID: 101525 RVA: 0x0039B4B4 File Offset: 0x003996B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SimpleTrackReportRequest.Descriptor;
			}
		}

		// Token: 0x06018C96 RID: 101526 RVA: 0x0039B4BB File Offset: 0x003996BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleTrackReportRequest()
		{
		}

		// Token: 0x06018C97 RID: 101527 RVA: 0x0039B4C3 File Offset: 0x003996C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleTrackReportRequest(SimpleTrackReportRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018C98 RID: 101528 RVA: 0x0039B4DC File Offset: 0x003996DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleTrackReportRequest Clone()
		{
			return new SimpleTrackReportRequest(this);
		}

		// Token: 0x06018C99 RID: 101529 RVA: 0x0039B4E4 File Offset: 0x003996E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SimpleTrackReportRequest);
		}

		// Token: 0x06018C9A RID: 101530 RVA: 0x0039B4F2 File Offset: 0x003996F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SimpleTrackReportRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06018C9B RID: 101531 RVA: 0x0039B510 File Offset: 0x00399710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018C9C RID: 101532 RVA: 0x0039B536 File Offset: 0x00399736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018C9D RID: 101533 RVA: 0x0039B543 File Offset: 0x00399743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018C9E RID: 101534 RVA: 0x0039B54C File Offset: 0x0039974C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018C9F RID: 101535 RVA: 0x0039B564 File Offset: 0x00399764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018CA0 RID: 101536 RVA: 0x0039B58A File Offset: 0x0039978A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SimpleTrackReportRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018CA1 RID: 101537 RVA: 0x0039B5A7 File Offset: 0x003997A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018CA2 RID: 101538 RVA: 0x0039B5B0 File Offset: 0x003997B0
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400923C RID: 37436
		private UnknownFieldSet _unknownFields;
	}
}
