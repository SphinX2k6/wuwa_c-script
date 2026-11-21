using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006A2 RID: 1698
	[NetMessage(EMessageId.GatewayEchoResponse)]
	public sealed class GatewayEchoResponse : IMessage<GatewayEchoResponse>, IMessage, IEquatable<GatewayEchoResponse>, IDeepCloneable<GatewayEchoResponse>, IBufferMessage
	{
		// Token: 0x06009C1C RID: 39964 RVA: 0x0017C151 File Offset: 0x0017A351
		[NullableContext(1)]
		public static GatewayEchoResponse Create()
		{
			return new GatewayEchoResponse();
		}

		// Token: 0x17001F5D RID: 8029
		// (get) Token: 0x06009C1D RID: 39965 RVA: 0x0017C158 File Offset: 0x0017A358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F5E RID: 8030
		// (get) Token: 0x06009C1E RID: 39966 RVA: 0x0017C15B File Offset: 0x0017A35B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GatewayEchoResponse.Descriptor;
			}
		}

		// Token: 0x06009C1F RID: 39967 RVA: 0x0017C162 File Offset: 0x0017A362
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatewayEchoResponse()
		{
		}

		// Token: 0x06009C20 RID: 39968 RVA: 0x0017C175 File Offset: 0x0017A375
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatewayEchoResponse(GatewayEchoResponse other) : this()
		{
			this.content_ = other.content_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009C21 RID: 39969 RVA: 0x0017C19A File Offset: 0x0017A39A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatewayEchoResponse Clone()
		{
			return new GatewayEchoResponse(this);
		}

		// Token: 0x17001F5F RID: 8031
		// (get) Token: 0x06009C22 RID: 39970 RVA: 0x0017C1A2 File Offset: 0x0017A3A2
		// (set) Token: 0x06009C23 RID: 39971 RVA: 0x0017C1AA File Offset: 0x0017A3AA
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

		// Token: 0x06009C24 RID: 39972 RVA: 0x0017C1BD File Offset: 0x0017A3BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GatewayEchoResponse);
		}

		// Token: 0x06009C25 RID: 39973 RVA: 0x0017C1CB File Offset: 0x0017A3CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GatewayEchoResponse other)
		{
			return other != null && (other == this || (!(this.Content != other.Content) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009C26 RID: 39974 RVA: 0x0017C200 File Offset: 0x0017A400
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

		// Token: 0x06009C27 RID: 39975 RVA: 0x0017C241 File Offset: 0x0017A441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009C28 RID: 39976 RVA: 0x0017C24E File Offset: 0x0017A44E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009C29 RID: 39977 RVA: 0x0017C257 File Offset: 0x0017A457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Content.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteString(this.Content);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009C2A RID: 39978 RVA: 0x0017C290 File Offset: 0x0017A490
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

		// Token: 0x06009C2B RID: 39979 RVA: 0x0017C2D3 File Offset: 0x0017A4D3
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

		// Token: 0x06009C2C RID: 39980 RVA: 0x0017C309 File Offset: 0x0017A509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009C2D RID: 39981 RVA: 0x0017C314 File Offset: 0x0017A514
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Content = input.ReadString();
				}
			}
		}

		// Token: 0x040049F2 RID: 18930
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049F3 RID: 18931
		public const int ContentFieldNumber = 11;

		// Token: 0x040049F4 RID: 18932
		private string content_ = "";
	}
}
