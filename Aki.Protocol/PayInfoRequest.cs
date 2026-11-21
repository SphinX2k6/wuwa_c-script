using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BD2 RID: 3026
	[NetMessage(EMessageId.PayInfoRequest)]
	public sealed class PayInfoRequest : IMessage<PayInfoRequest>, IMessage, IEquatable<PayInfoRequest>, IDeepCloneable<PayInfoRequest>, IBufferMessage
	{
		// Token: 0x060106B2 RID: 67250 RVA: 0x00265EF5 File Offset: 0x002640F5
		[NullableContext(1)]
		public static PayInfoRequest Create()
		{
			return new PayInfoRequest();
		}

		// Token: 0x170035E5 RID: 13797
		// (get) Token: 0x060106B3 RID: 67251 RVA: 0x00265EFC File Offset: 0x002640FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170035E6 RID: 13798
		// (get) Token: 0x060106B4 RID: 67252 RVA: 0x00265EFF File Offset: 0x002640FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayInfoRequest.Descriptor;
			}
		}

		// Token: 0x060106B5 RID: 67253 RVA: 0x00265F06 File Offset: 0x00264106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayInfoRequest()
		{
		}

		// Token: 0x060106B6 RID: 67254 RVA: 0x00265F19 File Offset: 0x00264119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayInfoRequest(PayInfoRequest other) : this()
		{
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060106B7 RID: 67255 RVA: 0x00265F3E File Offset: 0x0026413E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayInfoRequest Clone()
		{
			return new PayInfoRequest(this);
		}

		// Token: 0x170035E7 RID: 13799
		// (get) Token: 0x060106B8 RID: 67256 RVA: 0x00265F46 File Offset: 0x00264146
		// (set) Token: 0x060106B9 RID: 67257 RVA: 0x00265F4E File Offset: 0x0026414E
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

		// Token: 0x060106BA RID: 67258 RVA: 0x00265F61 File Offset: 0x00264161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayInfoRequest);
		}

		// Token: 0x060106BB RID: 67259 RVA: 0x00265F6F File Offset: 0x0026416F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayInfoRequest other)
		{
			return other != null && (other == this || (!(this.Version != other.Version) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060106BC RID: 67260 RVA: 0x00265FA4 File Offset: 0x002641A4
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

		// Token: 0x060106BD RID: 67261 RVA: 0x00265FE5 File Offset: 0x002641E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060106BE RID: 67262 RVA: 0x00265FF2 File Offset: 0x002641F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060106BF RID: 67263 RVA: 0x00265FFB File Offset: 0x002641FB
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

		// Token: 0x060106C0 RID: 67264 RVA: 0x00266034 File Offset: 0x00264234
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

		// Token: 0x060106C1 RID: 67265 RVA: 0x00266077 File Offset: 0x00264277
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

		// Token: 0x060106C2 RID: 67266 RVA: 0x002660AD File Offset: 0x002642AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060106C3 RID: 67267 RVA: 0x002660B8 File Offset: 0x002642B8
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

		// Token: 0x040068A4 RID: 26788
		private UnknownFieldSet _unknownFields;

		// Token: 0x040068A5 RID: 26789
		public const int VersionFieldNumber = 10;

		// Token: 0x040068A6 RID: 26790
		private string version_ = "";
	}
}
