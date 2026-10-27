using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200029E RID: 670
	[NetMessage(EMessageId.ClientPullResourcePackageRequest)]
	public sealed class ClientPullResourcePackageRequest : IMessage<ClientPullResourcePackageRequest>, IMessage, IEquatable<ClientPullResourcePackageRequest>, IDeepCloneable<ClientPullResourcePackageRequest>, IBufferMessage
	{
		// Token: 0x060045C0 RID: 17856 RVA: 0x000AB816 File Offset: 0x000A9A16
		[NullableContext(1)]
		public static ClientPullResourcePackageRequest Create()
		{
			return new ClientPullResourcePackageRequest();
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x060045C1 RID: 17857 RVA: 0x000AB81D File Offset: 0x000A9A1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x060045C2 RID: 17858 RVA: 0x000AB820 File Offset: 0x000A9A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientPullResourcePackageRequest.Descriptor;
			}
		}

		// Token: 0x060045C3 RID: 17859 RVA: 0x000AB827 File Offset: 0x000A9A27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientPullResourcePackageRequest()
		{
		}

		// Token: 0x060045C4 RID: 17860 RVA: 0x000AB82F File Offset: 0x000A9A2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientPullResourcePackageRequest(ClientPullResourcePackageRequest other) : this()
		{
			this.holder_ = other.holder_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060045C5 RID: 17861 RVA: 0x000AB854 File Offset: 0x000A9A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientPullResourcePackageRequest Clone()
		{
			return new ClientPullResourcePackageRequest(this);
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x060045C6 RID: 17862 RVA: 0x000AB85C File Offset: 0x000A9A5C
		// (set) Token: 0x060045C7 RID: 17863 RVA: 0x000AB864 File Offset: 0x000A9A64
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

		// Token: 0x060045C8 RID: 17864 RVA: 0x000AB86D File Offset: 0x000A9A6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientPullResourcePackageRequest);
		}

		// Token: 0x060045C9 RID: 17865 RVA: 0x000AB87B File Offset: 0x000A9A7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientPullResourcePackageRequest other)
		{
			return other != null && (other == this || (this.Holder == other.Holder && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060045CA RID: 17866 RVA: 0x000AB8AC File Offset: 0x000A9AAC
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

		// Token: 0x060045CB RID: 17867 RVA: 0x000AB8EB File Offset: 0x000A9AEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060045CC RID: 17868 RVA: 0x000AB8F8 File Offset: 0x000A9AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060045CD RID: 17869 RVA: 0x000AB901 File Offset: 0x000A9B01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Holder)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Holder);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060045CE RID: 17870 RVA: 0x000AB934 File Offset: 0x000A9B34
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

		// Token: 0x060045CF RID: 17871 RVA: 0x000AB966 File Offset: 0x000A9B66
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

		// Token: 0x060045D0 RID: 17872 RVA: 0x000AB997 File Offset: 0x000A9B97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060045D1 RID: 17873 RVA: 0x000AB9A0 File Offset: 0x000A9BA0
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Holder = input.ReadBool();
				}
			}
		}

		// Token: 0x04002F24 RID: 12068
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F25 RID: 12069
		public const int HolderFieldNumber = 2;

		// Token: 0x04002F26 RID: 12070
		private bool holder_;
	}
}
