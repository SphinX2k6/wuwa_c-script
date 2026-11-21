using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006A1 RID: 1697
	[NetMessage(EMessageId.GatewayEchoRequest)]
	public sealed class GatewayEchoRequest : IMessage<GatewayEchoRequest>, IMessage, IEquatable<GatewayEchoRequest>, IDeepCloneable<GatewayEchoRequest>, IBufferMessage
	{
		// Token: 0x06009C0A RID: 39946 RVA: 0x0017BF49 File Offset: 0x0017A149
		[NullableContext(1)]
		public static GatewayEchoRequest Create()
		{
			return new GatewayEchoRequest();
		}

		// Token: 0x17001F5A RID: 8026
		// (get) Token: 0x06009C0B RID: 39947 RVA: 0x0017BF50 File Offset: 0x0017A150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F5B RID: 8027
		// (get) Token: 0x06009C0C RID: 39948 RVA: 0x0017BF53 File Offset: 0x0017A153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GatewayEchoRequest.Descriptor;
			}
		}

		// Token: 0x06009C0D RID: 39949 RVA: 0x0017BF5A File Offset: 0x0017A15A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatewayEchoRequest()
		{
		}

		// Token: 0x06009C0E RID: 39950 RVA: 0x0017BF6D File Offset: 0x0017A16D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatewayEchoRequest(GatewayEchoRequest other) : this()
		{
			this.content_ = other.content_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009C0F RID: 39951 RVA: 0x0017BF92 File Offset: 0x0017A192
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatewayEchoRequest Clone()
		{
			return new GatewayEchoRequest(this);
		}

		// Token: 0x17001F5C RID: 8028
		// (get) Token: 0x06009C10 RID: 39952 RVA: 0x0017BF9A File Offset: 0x0017A19A
		// (set) Token: 0x06009C11 RID: 39953 RVA: 0x0017BFA2 File Offset: 0x0017A1A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Content
		{
			get
			{
				return this.content_;
			}
			set
			{
				this.content_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06009C12 RID: 39954 RVA: 0x0017BFB5 File Offset: 0x0017A1B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GatewayEchoRequest);
		}

		// Token: 0x06009C13 RID: 39955 RVA: 0x0017BFC3 File Offset: 0x0017A1C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GatewayEchoRequest other)
		{
			return other != null && (other == this || (!(this.Content != other.Content) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009C14 RID: 39956 RVA: 0x0017BFF8 File Offset: 0x0017A1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Content.Length != 0)
			{
				num ^= this.Content.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009C15 RID: 39957 RVA: 0x0017C039 File Offset: 0x0017A239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009C16 RID: 39958 RVA: 0x0017C046 File Offset: 0x0017A246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009C17 RID: 39959 RVA: 0x0017C04F File Offset: 0x0017A24F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Content.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.Content);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009C18 RID: 39960 RVA: 0x0017C088 File Offset: 0x0017A288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Content.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Content);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009C19 RID: 39961 RVA: 0x0017C0CB File Offset: 0x0017A2CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GatewayEchoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Content.Length != 0)
			{
				this.Content = other.Content;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009C1A RID: 39962 RVA: 0x0017C101 File Offset: 0x0017A301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009C1B RID: 39963 RVA: 0x0017C10C File Offset: 0x0017A30C
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Content = input.ReadString();
				}
			}
		}

		// Token: 0x040049EF RID: 18927
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049F0 RID: 18928
		public const int ContentFieldNumber = 14;

		// Token: 0x040049F1 RID: 18929
		private string content_ = "";
	}
}
