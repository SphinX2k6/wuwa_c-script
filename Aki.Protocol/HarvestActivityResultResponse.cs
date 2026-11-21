using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000736 RID: 1846
	[NetMessage(EMessageId.HarvestActivityResultResponse)]
	public sealed class HarvestActivityResultResponse : IMessage<HarvestActivityResultResponse>, IMessage, IEquatable<HarvestActivityResultResponse>, IDeepCloneable<HarvestActivityResultResponse>, IBufferMessage
	{
		// Token: 0x0600A7A0 RID: 42912 RVA: 0x00193B26 File Offset: 0x00191D26
		[NullableContext(1)]
		public static HarvestActivityResultResponse Create()
		{
			return new HarvestActivityResultResponse();
		}

		// Token: 0x170021AF RID: 8623
		// (get) Token: 0x0600A7A1 RID: 42913 RVA: 0x00193B2D File Offset: 0x00191D2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021B0 RID: 8624
		// (get) Token: 0x0600A7A2 RID: 42914 RVA: 0x00193B30 File Offset: 0x00191D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HarvestActivityResultResponse.Descriptor;
			}
		}

		// Token: 0x0600A7A3 RID: 42915 RVA: 0x00193B37 File Offset: 0x00191D37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityResultResponse()
		{
		}

		// Token: 0x0600A7A4 RID: 42916 RVA: 0x00193B3F File Offset: 0x00191D3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityResultResponse(HarvestActivityResultResponse other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A7A5 RID: 42917 RVA: 0x00193B58 File Offset: 0x00191D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityResultResponse Clone()
		{
			return new HarvestActivityResultResponse(this);
		}

		// Token: 0x0600A7A6 RID: 42918 RVA: 0x00193B60 File Offset: 0x00191D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HarvestActivityResultResponse);
		}

		// Token: 0x0600A7A7 RID: 42919 RVA: 0x00193B6E File Offset: 0x00191D6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HarvestActivityResultResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600A7A8 RID: 42920 RVA: 0x00193B8C File Offset: 0x00191D8C
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

		// Token: 0x0600A7A9 RID: 42921 RVA: 0x00193BB2 File Offset: 0x00191DB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A7AA RID: 42922 RVA: 0x00193BBF File Offset: 0x00191DBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A7AB RID: 42923 RVA: 0x00193BC8 File Offset: 0x00191DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A7AC RID: 42924 RVA: 0x00193BE0 File Offset: 0x00191DE0
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

		// Token: 0x0600A7AD RID: 42925 RVA: 0x00193C06 File Offset: 0x00191E06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HarvestActivityResultResponse other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A7AE RID: 42926 RVA: 0x00193C23 File Offset: 0x00191E23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A7AF RID: 42927 RVA: 0x00193C2C File Offset: 0x00191E2C
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

		// Token: 0x04004CF3 RID: 19699
		private UnknownFieldSet _unknownFields;
	}
}
