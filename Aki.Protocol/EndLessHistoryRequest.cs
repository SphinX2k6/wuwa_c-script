using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200043F RID: 1087
	[NetMessage(EMessageId.EndLessHistoryRequest)]
	public sealed class EndLessHistoryRequest : IMessage<EndLessHistoryRequest>, IMessage, IEquatable<EndLessHistoryRequest>, IDeepCloneable<EndLessHistoryRequest>, IBufferMessage
	{
		// Token: 0x0600680F RID: 26639 RVA: 0x000F9C94 File Offset: 0x000F7E94
		[NullableContext(1)]
		public static EndLessHistoryRequest Create()
		{
			return new EndLessHistoryRequest();
		}

		// Token: 0x17001394 RID: 5012
		// (get) Token: 0x06006810 RID: 26640 RVA: 0x000F9C9B File Offset: 0x000F7E9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001395 RID: 5013
		// (get) Token: 0x06006811 RID: 26641 RVA: 0x000F9C9E File Offset: 0x000F7E9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EndLessHistoryRequest.Descriptor;
			}
		}

		// Token: 0x06006812 RID: 26642 RVA: 0x000F9CA5 File Offset: 0x000F7EA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndLessHistoryRequest()
		{
		}

		// Token: 0x06006813 RID: 26643 RVA: 0x000F9CAD File Offset: 0x000F7EAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndLessHistoryRequest(EndLessHistoryRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006814 RID: 26644 RVA: 0x000F9CC6 File Offset: 0x000F7EC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndLessHistoryRequest Clone()
		{
			return new EndLessHistoryRequest(this);
		}

		// Token: 0x06006815 RID: 26645 RVA: 0x000F9CCE File Offset: 0x000F7ECE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EndLessHistoryRequest);
		}

		// Token: 0x06006816 RID: 26646 RVA: 0x000F9CDC File Offset: 0x000F7EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EndLessHistoryRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06006817 RID: 26647 RVA: 0x000F9CFC File Offset: 0x000F7EFC
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

		// Token: 0x06006818 RID: 26648 RVA: 0x000F9D22 File Offset: 0x000F7F22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006819 RID: 26649 RVA: 0x000F9D2F File Offset: 0x000F7F2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600681A RID: 26650 RVA: 0x000F9D38 File Offset: 0x000F7F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600681B RID: 26651 RVA: 0x000F9D50 File Offset: 0x000F7F50
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

		// Token: 0x0600681C RID: 26652 RVA: 0x000F9D76 File Offset: 0x000F7F76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EndLessHistoryRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600681D RID: 26653 RVA: 0x000F9D93 File Offset: 0x000F7F93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600681E RID: 26654 RVA: 0x000F9D9C File Offset: 0x000F7F9C
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

		// Token: 0x04003994 RID: 14740
		private UnknownFieldSet _unknownFields;
	}
}
