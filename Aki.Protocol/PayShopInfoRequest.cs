using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BE0 RID: 3040
	[NetMessage(EMessageId.PayShopInfoRequest)]
	public sealed class PayShopInfoRequest : IMessage<PayShopInfoRequest>, IMessage, IEquatable<PayShopInfoRequest>, IDeepCloneable<PayShopInfoRequest>, IBufferMessage
	{
		// Token: 0x06010804 RID: 67588 RVA: 0x00269A31 File Offset: 0x00267C31
		[NullableContext(1)]
		public static PayShopInfoRequest Create()
		{
			return new PayShopInfoRequest();
		}

		// Token: 0x1700363C RID: 13884
		// (get) Token: 0x06010805 RID: 67589 RVA: 0x00269A38 File Offset: 0x00267C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700363D RID: 13885
		// (get) Token: 0x06010806 RID: 67590 RVA: 0x00269A3B File Offset: 0x00267C3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopInfoRequest.Descriptor;
			}
		}

		// Token: 0x06010807 RID: 67591 RVA: 0x00269A42 File Offset: 0x00267C42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopInfoRequest()
		{
		}

		// Token: 0x06010808 RID: 67592 RVA: 0x00269A55 File Offset: 0x00267C55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopInfoRequest(PayShopInfoRequest other) : this()
		{
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010809 RID: 67593 RVA: 0x00269A7A File Offset: 0x00267C7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopInfoRequest Clone()
		{
			return new PayShopInfoRequest(this);
		}

		// Token: 0x1700363E RID: 13886
		// (get) Token: 0x0601080A RID: 67594 RVA: 0x00269A82 File Offset: 0x00267C82
		// (set) Token: 0x0601080B RID: 67595 RVA: 0x00269A8A File Offset: 0x00267C8A
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

		// Token: 0x0601080C RID: 67596 RVA: 0x00269A9D File Offset: 0x00267C9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopInfoRequest);
		}

		// Token: 0x0601080D RID: 67597 RVA: 0x00269AAB File Offset: 0x00267CAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopInfoRequest other)
		{
			return other != null && (other == this || (!(this.Version != other.Version) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601080E RID: 67598 RVA: 0x00269AE0 File Offset: 0x00267CE0
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

		// Token: 0x0601080F RID: 67599 RVA: 0x00269B21 File Offset: 0x00267D21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010810 RID: 67600 RVA: 0x00269B2E File Offset: 0x00267D2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010811 RID: 67601 RVA: 0x00269B37 File Offset: 0x00267D37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Version.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteString(this.Version);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010812 RID: 67602 RVA: 0x00269B70 File Offset: 0x00267D70
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

		// Token: 0x06010813 RID: 67603 RVA: 0x00269BB3 File Offset: 0x00267DB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayShopInfoRequest other)
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

		// Token: 0x06010814 RID: 67604 RVA: 0x00269BE9 File Offset: 0x00267DE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010815 RID: 67605 RVA: 0x00269BF4 File Offset: 0x00267DF4
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Version = input.ReadString();
				}
			}
		}

		// Token: 0x0400692D RID: 26925
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400692E RID: 26926
		public const int VersionFieldNumber = 15;

		// Token: 0x0400692F RID: 26927
		private string version_ = "";
	}
}
