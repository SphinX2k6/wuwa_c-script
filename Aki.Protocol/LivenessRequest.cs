using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000931 RID: 2353
	[NetMessage(EMessageId.LivenessRequest)]
	public sealed class LivenessRequest : IMessage<LivenessRequest>, IMessage, IEquatable<LivenessRequest>, IDeepCloneable<LivenessRequest>, IBufferMessage
	{
		// Token: 0x0600CF76 RID: 53110 RVA: 0x001E8CD8 File Offset: 0x001E6ED8
		[NullableContext(1)]
		public static LivenessRequest Create()
		{
			return new LivenessRequest();
		}

		// Token: 0x170029EB RID: 10731
		// (get) Token: 0x0600CF77 RID: 53111 RVA: 0x001E8CDF File Offset: 0x001E6EDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029EC RID: 10732
		// (get) Token: 0x0600CF78 RID: 53112 RVA: 0x001E8CE2 File Offset: 0x001E6EE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LivenessRequest.Descriptor;
			}
		}

		// Token: 0x0600CF79 RID: 53113 RVA: 0x001E8CE9 File Offset: 0x001E6EE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessRequest()
		{
		}

		// Token: 0x0600CF7A RID: 53114 RVA: 0x001E8CF1 File Offset: 0x001E6EF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessRequest(LivenessRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CF7B RID: 53115 RVA: 0x001E8D0A File Offset: 0x001E6F0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessRequest Clone()
		{
			return new LivenessRequest(this);
		}

		// Token: 0x0600CF7C RID: 53116 RVA: 0x001E8D12 File Offset: 0x001E6F12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LivenessRequest);
		}

		// Token: 0x0600CF7D RID: 53117 RVA: 0x001E8D20 File Offset: 0x001E6F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LivenessRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600CF7E RID: 53118 RVA: 0x001E8D40 File Offset: 0x001E6F40
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

		// Token: 0x0600CF7F RID: 53119 RVA: 0x001E8D66 File Offset: 0x001E6F66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CF80 RID: 53120 RVA: 0x001E8D73 File Offset: 0x001E6F73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CF81 RID: 53121 RVA: 0x001E8D7C File Offset: 0x001E6F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CF82 RID: 53122 RVA: 0x001E8D94 File Offset: 0x001E6F94
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

		// Token: 0x0600CF83 RID: 53123 RVA: 0x001E8DBA File Offset: 0x001E6FBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LivenessRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CF84 RID: 53124 RVA: 0x001E8DD7 File Offset: 0x001E6FD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CF85 RID: 53125 RVA: 0x001E8DE0 File Offset: 0x001E6FE0
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

		// Token: 0x0400578B RID: 22411
		private UnknownFieldSet _unknownFields;
	}
}
