using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006C3 RID: 1731
	[NetMessage(EMessageId.GetDetectionLabelInfoRequest)]
	public sealed class GetDetectionLabelInfoRequest : IMessage<GetDetectionLabelInfoRequest>, IMessage, IEquatable<GetDetectionLabelInfoRequest>, IDeepCloneable<GetDetectionLabelInfoRequest>, IBufferMessage
	{
		// Token: 0x06009E6B RID: 40555 RVA: 0x00180810 File Offset: 0x0017EA10
		[NullableContext(1)]
		public static GetDetectionLabelInfoRequest Create()
		{
			return new GetDetectionLabelInfoRequest();
		}

		// Token: 0x17001FD6 RID: 8150
		// (get) Token: 0x06009E6C RID: 40556 RVA: 0x00180817 File Offset: 0x0017EA17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FD7 RID: 8151
		// (get) Token: 0x06009E6D RID: 40557 RVA: 0x0018081A File Offset: 0x0017EA1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetDetectionLabelInfoRequest.Descriptor;
			}
		}

		// Token: 0x06009E6E RID: 40558 RVA: 0x00180821 File Offset: 0x0017EA21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDetectionLabelInfoRequest()
		{
		}

		// Token: 0x06009E6F RID: 40559 RVA: 0x00180829 File Offset: 0x0017EA29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDetectionLabelInfoRequest(GetDetectionLabelInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009E70 RID: 40560 RVA: 0x00180842 File Offset: 0x0017EA42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDetectionLabelInfoRequest Clone()
		{
			return new GetDetectionLabelInfoRequest(this);
		}

		// Token: 0x06009E71 RID: 40561 RVA: 0x0018084A File Offset: 0x0017EA4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetDetectionLabelInfoRequest);
		}

		// Token: 0x06009E72 RID: 40562 RVA: 0x00180858 File Offset: 0x0017EA58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetDetectionLabelInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06009E73 RID: 40563 RVA: 0x00180878 File Offset: 0x0017EA78
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

		// Token: 0x06009E74 RID: 40564 RVA: 0x0018089E File Offset: 0x0017EA9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009E75 RID: 40565 RVA: 0x001808AB File Offset: 0x0017EAAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009E76 RID: 40566 RVA: 0x001808B4 File Offset: 0x0017EAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009E77 RID: 40567 RVA: 0x001808CC File Offset: 0x0017EACC
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

		// Token: 0x06009E78 RID: 40568 RVA: 0x001808F2 File Offset: 0x0017EAF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetDetectionLabelInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009E79 RID: 40569 RVA: 0x0018090F File Offset: 0x0017EB0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009E7A RID: 40570 RVA: 0x00180918 File Offset: 0x0017EB18
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

		// Token: 0x04004A31 RID: 18993
		private UnknownFieldSet _unknownFields;
	}
}
