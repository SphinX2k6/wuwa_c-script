using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002A4 RID: 676
	[NetMessage(EMessageId.ClientPullResourcePackageRequest)]
	public sealed class ClientPullResourcePackageRequest : IMessage<ClientPullResourcePackageRequest>, IMessage, IEquatable<ClientPullResourcePackageRequest>, IDeepCloneable<ClientPullResourcePackageRequest>, IBufferMessage
	{
		// Token: 0x06004687 RID: 18055 RVA: 0x000ADA29 File Offset: 0x000ABC29
		[NullableContext(1)]
		public static ClientPullResourcePackageRequest Create()
		{
			return new ClientPullResourcePackageRequest();
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x06004688 RID: 18056 RVA: 0x000ADA30 File Offset: 0x000ABC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x06004689 RID: 18057 RVA: 0x000ADA33 File Offset: 0x000ABC33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientPullResourcePackageRequest.Descriptor;
			}
		}

		// Token: 0x0600468A RID: 18058 RVA: 0x000ADA3A File Offset: 0x000ABC3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientPullResourcePackageRequest()
		{
		}

		// Token: 0x0600468B RID: 18059 RVA: 0x000ADA42 File Offset: 0x000ABC42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientPullResourcePackageRequest(ClientPullResourcePackageRequest other) : this()
		{
			this.holder_ = other.holder_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600468C RID: 18060 RVA: 0x000ADA67 File Offset: 0x000ABC67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientPullResourcePackageRequest Clone()
		{
			return new ClientPullResourcePackageRequest(this);
		}

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x0600468D RID: 18061 RVA: 0x000ADA6F File Offset: 0x000ABC6F
		// (set) Token: 0x0600468E RID: 18062 RVA: 0x000ADA77 File Offset: 0x000ABC77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Holder
		{
			get
			{
				return this.holder_;
			}
			set
			{
				this.holder_ = value;
			}
		}

		// Token: 0x0600468F RID: 18063 RVA: 0x000ADA80 File Offset: 0x000ABC80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientPullResourcePackageRequest);
		}

		// Token: 0x06004690 RID: 18064 RVA: 0x000ADA8E File Offset: 0x000ABC8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientPullResourcePackageRequest other)
		{
			return other != null && (other == this || (this.Holder == other.Holder && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004691 RID: 18065 RVA: 0x000ADABC File Offset: 0x000ABCBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Holder)
			{
				num ^= this.Holder.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004692 RID: 18066 RVA: 0x000ADAFB File Offset: 0x000ABCFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004693 RID: 18067 RVA: 0x000ADB08 File Offset: 0x000ABD08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004694 RID: 18068 RVA: 0x000ADB11 File Offset: 0x000ABD11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Holder)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.Holder);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004695 RID: 18069 RVA: 0x000ADB44 File Offset: 0x000ABD44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Holder)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004696 RID: 18070 RVA: 0x000ADB76 File Offset: 0x000ABD76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClientPullResourcePackageRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Holder)
			{
				this.Holder = other.Holder;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004697 RID: 18071 RVA: 0x000ADBA7 File Offset: 0x000ABDA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004698 RID: 18072 RVA: 0x000ADBB0 File Offset: 0x000ABDB0
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Holder = input.ReadBool();
				}
			}
		}

		// Token: 0x04002FB7 RID: 12215
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FB8 RID: 12216
		public const int HolderFieldNumber = 11;

		// Token: 0x04002FB9 RID: 12217
		private bool holder_;
	}
}
