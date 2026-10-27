using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BE2 RID: 3042
	[NetMessage(EMessageId.PayInfoRequest)]
	public sealed class PayInfoRequest : IMessage<PayInfoRequest>, IMessage, IEquatable<PayInfoRequest>, IDeepCloneable<PayInfoRequest>, IBufferMessage
	{
		// Token: 0x060107B6 RID: 67510 RVA: 0x00267DB5 File Offset: 0x00265FB5
		[NullableContext(1)]
		public static PayInfoRequest Create()
		{
			return new PayInfoRequest();
		}

		// Token: 0x1700361E RID: 13854
		// (get) Token: 0x060107B7 RID: 67511 RVA: 0x00267DBC File Offset: 0x00265FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700361F RID: 13855
		// (get) Token: 0x060107B8 RID: 67512 RVA: 0x00267DBF File Offset: 0x00265FBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayInfoRequest.Descriptor;
			}
		}

		// Token: 0x060107B9 RID: 67513 RVA: 0x00267DC6 File Offset: 0x00265FC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayInfoRequest()
		{
		}

		// Token: 0x060107BA RID: 67514 RVA: 0x00267DD9 File Offset: 0x00265FD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayInfoRequest(PayInfoRequest other) : this()
		{
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060107BB RID: 67515 RVA: 0x00267DFE File Offset: 0x00265FFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayInfoRequest Clone()
		{
			return new PayInfoRequest(this);
		}

		// Token: 0x17003620 RID: 13856
		// (get) Token: 0x060107BC RID: 67516 RVA: 0x00267E06 File Offset: 0x00266006
		// (set) Token: 0x060107BD RID: 67517 RVA: 0x00267E0E File Offset: 0x0026600E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Version
		{
			get
			{
				return this.version_;
			}
			set
			{
				this.version_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x060107BE RID: 67518 RVA: 0x00267E21 File Offset: 0x00266021
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayInfoRequest);
		}

		// Token: 0x060107BF RID: 67519 RVA: 0x00267E2F File Offset: 0x0026602F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayInfoRequest other)
		{
			return other != null && (other == this || (!(this.Version != other.Version) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060107C0 RID: 67520 RVA: 0x00267E64 File Offset: 0x00266064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Version.Length != 0)
			{
				num ^= this.Version.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060107C1 RID: 67521 RVA: 0x00267EA5 File Offset: 0x002660A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060107C2 RID: 67522 RVA: 0x00267EB2 File Offset: 0x002660B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060107C3 RID: 67523 RVA: 0x00267EBB File Offset: 0x002660BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Version.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.Version);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060107C4 RID: 67524 RVA: 0x00267EF4 File Offset: 0x002660F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Version.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Version);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060107C5 RID: 67525 RVA: 0x00267F37 File Offset: 0x00266137
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Version.Length != 0)
			{
				this.Version = other.Version;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060107C6 RID: 67526 RVA: 0x00267F6D File Offset: 0x0026616D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060107C7 RID: 67527 RVA: 0x00267F78 File Offset: 0x00266178
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Version = input.ReadString();
				}
			}
		}

		// Token: 0x04006894 RID: 26772
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006895 RID: 26773
		public const int VersionFieldNumber = 10;

		// Token: 0x04006896 RID: 26774
		private string version_ = "";
	}
}
