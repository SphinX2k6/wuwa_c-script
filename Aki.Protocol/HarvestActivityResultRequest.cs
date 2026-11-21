using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000735 RID: 1845
	[NetMessage(EMessageId.HarvestActivityResultRequest)]
	public sealed class HarvestActivityResultRequest : IMessage<HarvestActivityResultRequest>, IMessage, IEquatable<HarvestActivityResultRequest>, IDeepCloneable<HarvestActivityResultRequest>, IBufferMessage
	{
		// Token: 0x0600A790 RID: 42896 RVA: 0x001939ED File Offset: 0x00191BED
		[NullableContext(1)]
		public static HarvestActivityResultRequest Create()
		{
			return new HarvestActivityResultRequest();
		}

		// Token: 0x170021AD RID: 8621
		// (get) Token: 0x0600A791 RID: 42897 RVA: 0x001939F4 File Offset: 0x00191BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021AE RID: 8622
		// (get) Token: 0x0600A792 RID: 42898 RVA: 0x001939F7 File Offset: 0x00191BF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HarvestActivityResultRequest.Descriptor;
			}
		}

		// Token: 0x0600A793 RID: 42899 RVA: 0x001939FE File Offset: 0x00191BFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityResultRequest()
		{
		}

		// Token: 0x0600A794 RID: 42900 RVA: 0x00193A06 File Offset: 0x00191C06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityResultRequest(HarvestActivityResultRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A795 RID: 42901 RVA: 0x00193A1F File Offset: 0x00191C1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityResultRequest Clone()
		{
			return new HarvestActivityResultRequest(this);
		}

		// Token: 0x0600A796 RID: 42902 RVA: 0x00193A27 File Offset: 0x00191C27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HarvestActivityResultRequest);
		}

		// Token: 0x0600A797 RID: 42903 RVA: 0x00193A35 File Offset: 0x00191C35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HarvestActivityResultRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600A798 RID: 42904 RVA: 0x00193A54 File Offset: 0x00191C54
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

		// Token: 0x0600A799 RID: 42905 RVA: 0x00193A7A File Offset: 0x00191C7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A79A RID: 42906 RVA: 0x00193A87 File Offset: 0x00191C87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A79B RID: 42907 RVA: 0x00193A90 File Offset: 0x00191C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A79C RID: 42908 RVA: 0x00193AA8 File Offset: 0x00191CA8
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

		// Token: 0x0600A79D RID: 42909 RVA: 0x00193ACE File Offset: 0x00191CCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HarvestActivityResultRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A79E RID: 42910 RVA: 0x00193AEB File Offset: 0x00191CEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A79F RID: 42911 RVA: 0x00193AF4 File Offset: 0x00191CF4
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

		// Token: 0x04004CF2 RID: 19698
		private UnknownFieldSet _unknownFields;
	}
}
