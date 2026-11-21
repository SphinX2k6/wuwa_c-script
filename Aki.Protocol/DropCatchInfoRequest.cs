using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003F0 RID: 1008
	[NetMessage(EMessageId.DropCatchInfoRequest)]
	public sealed class DropCatchInfoRequest : IMessage<DropCatchInfoRequest>, IMessage, IEquatable<DropCatchInfoRequest>, IDeepCloneable<DropCatchInfoRequest>, IBufferMessage
	{
		// Token: 0x060061E9 RID: 25065 RVA: 0x000EC29D File Offset: 0x000EA49D
		[NullableContext(1)]
		public static DropCatchInfoRequest Create()
		{
			return new DropCatchInfoRequest();
		}

		// Token: 0x1700123C RID: 4668
		// (get) Token: 0x060061EA RID: 25066 RVA: 0x000EC2A4 File Offset: 0x000EA4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700123D RID: 4669
		// (get) Token: 0x060061EB RID: 25067 RVA: 0x000EC2A7 File Offset: 0x000EA4A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DropCatchInfoRequest.Descriptor;
			}
		}

		// Token: 0x060061EC RID: 25068 RVA: 0x000EC2AE File Offset: 0x000EA4AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchInfoRequest()
		{
		}

		// Token: 0x060061ED RID: 25069 RVA: 0x000EC2B6 File Offset: 0x000EA4B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchInfoRequest(DropCatchInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060061EE RID: 25070 RVA: 0x000EC2CF File Offset: 0x000EA4CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchInfoRequest Clone()
		{
			return new DropCatchInfoRequest(this);
		}

		// Token: 0x060061EF RID: 25071 RVA: 0x000EC2D7 File Offset: 0x000EA4D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DropCatchInfoRequest);
		}

		// Token: 0x060061F0 RID: 25072 RVA: 0x000EC2E5 File Offset: 0x000EA4E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DropCatchInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060061F1 RID: 25073 RVA: 0x000EC304 File Offset: 0x000EA504
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

		// Token: 0x060061F2 RID: 25074 RVA: 0x000EC32A File Offset: 0x000EA52A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060061F3 RID: 25075 RVA: 0x000EC337 File Offset: 0x000EA537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060061F4 RID: 25076 RVA: 0x000EC340 File Offset: 0x000EA540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060061F5 RID: 25077 RVA: 0x000EC358 File Offset: 0x000EA558
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

		// Token: 0x060061F6 RID: 25078 RVA: 0x000EC37E File Offset: 0x000EA57E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DropCatchInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060061F7 RID: 25079 RVA: 0x000EC39B File Offset: 0x000EA59B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060061F8 RID: 25080 RVA: 0x000EC3A4 File Offset: 0x000EA5A4
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

		// Token: 0x04003814 RID: 14356
		private UnknownFieldSet _unknownFields;
	}
}
