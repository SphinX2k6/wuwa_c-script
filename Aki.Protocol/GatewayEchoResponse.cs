using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006B6 RID: 1718
	[NetMessage(EMessageId.GatewayEchoResponse)]
	public sealed class GatewayEchoResponse : IMessage<GatewayEchoResponse>, IMessage, IEquatable<GatewayEchoResponse>, IDeepCloneable<GatewayEchoResponse>, IBufferMessage
	{
		// Token: 0x06009D72 RID: 40306 RVA: 0x0017EB81 File Offset: 0x0017CD81
		[NullableContext(1)]
		public static GatewayEchoResponse Create()
		{
			return new GatewayEchoResponse();
		}

		// Token: 0x17001FA7 RID: 8103
		// (get) Token: 0x06009D73 RID: 40307 RVA: 0x0017EB88 File Offset: 0x0017CD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FA8 RID: 8104
		// (get) Token: 0x06009D74 RID: 40308 RVA: 0x0017EB8B File Offset: 0x0017CD8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GatewayEchoResponse.Descriptor;
			}
		}

		// Token: 0x06009D75 RID: 40309 RVA: 0x0017EB92 File Offset: 0x0017CD92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatewayEchoResponse()
		{
		}

		// Token: 0x06009D76 RID: 40310 RVA: 0x0017EBA5 File Offset: 0x0017CDA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatewayEchoResponse(GatewayEchoResponse other) : this()
		{
			this.content_ = other.content_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009D77 RID: 40311 RVA: 0x0017EBCA File Offset: 0x0017CDCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatewayEchoResponse Clone()
		{
			return new GatewayEchoResponse(this);
		}

		// Token: 0x17001FA9 RID: 8105
		// (get) Token: 0x06009D78 RID: 40312 RVA: 0x0017EBD2 File Offset: 0x0017CDD2
		// (set) Token: 0x06009D79 RID: 40313 RVA: 0x0017EBDA File Offset: 0x0017CDDA
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

		// Token: 0x06009D7A RID: 40314 RVA: 0x0017EBED File Offset: 0x0017CDED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GatewayEchoResponse);
		}

		// Token: 0x06009D7B RID: 40315 RVA: 0x0017EBFB File Offset: 0x0017CDFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GatewayEchoResponse other)
		{
			return other != null && (other == this || (!(this.Content != other.Content) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009D7C RID: 40316 RVA: 0x0017EC30 File Offset: 0x0017CE30
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

		// Token: 0x06009D7D RID: 40317 RVA: 0x0017EC71 File Offset: 0x0017CE71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009D7E RID: 40318 RVA: 0x0017EC7E File Offset: 0x0017CE7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009D7F RID: 40319 RVA: 0x0017EC87 File Offset: 0x0017CE87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Content.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.Content);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009D80 RID: 40320 RVA: 0x0017ECC0 File Offset: 0x0017CEC0
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

		// Token: 0x06009D81 RID: 40321 RVA: 0x0017ED03 File Offset: 0x0017CF03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GatewayEchoResponse other)
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

		// Token: 0x06009D82 RID: 40322 RVA: 0x0017ED39 File Offset: 0x0017CF39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009D83 RID: 40323 RVA: 0x0017ED44 File Offset: 0x0017CF44
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Content = input.ReadString();
				}
			}
		}

		// Token: 0x040049F9 RID: 18937
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049FA RID: 18938
		public const int ContentFieldNumber = 8;

		// Token: 0x040049FB RID: 18939
		private string content_ = "";
	}
}
