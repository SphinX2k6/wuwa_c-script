using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006B5 RID: 1717
	[NetMessage(EMessageId.GatewayEchoRequest)]
	public sealed class GatewayEchoRequest : IMessage<GatewayEchoRequest>, IMessage, IEquatable<GatewayEchoRequest>, IDeepCloneable<GatewayEchoRequest>, IBufferMessage
	{
		// Token: 0x06009D60 RID: 40288 RVA: 0x0017E979 File Offset: 0x0017CB79
		[NullableContext(1)]
		public static GatewayEchoRequest Create()
		{
			return new GatewayEchoRequest();
		}

		// Token: 0x17001FA4 RID: 8100
		// (get) Token: 0x06009D61 RID: 40289 RVA: 0x0017E980 File Offset: 0x0017CB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FA5 RID: 8101
		// (get) Token: 0x06009D62 RID: 40290 RVA: 0x0017E983 File Offset: 0x0017CB83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GatewayEchoRequest.Descriptor;
			}
		}

		// Token: 0x06009D63 RID: 40291 RVA: 0x0017E98A File Offset: 0x0017CB8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatewayEchoRequest()
		{
		}

		// Token: 0x06009D64 RID: 40292 RVA: 0x0017E99D File Offset: 0x0017CB9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatewayEchoRequest(GatewayEchoRequest other) : this()
		{
			this.content_ = other.content_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009D65 RID: 40293 RVA: 0x0017E9C2 File Offset: 0x0017CBC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatewayEchoRequest Clone()
		{
			return new GatewayEchoRequest(this);
		}

		// Token: 0x17001FA6 RID: 8102
		// (get) Token: 0x06009D66 RID: 40294 RVA: 0x0017E9CA File Offset: 0x0017CBCA
		// (set) Token: 0x06009D67 RID: 40295 RVA: 0x0017E9D2 File Offset: 0x0017CBD2
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

		// Token: 0x06009D68 RID: 40296 RVA: 0x0017E9E5 File Offset: 0x0017CBE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GatewayEchoRequest);
		}

		// Token: 0x06009D69 RID: 40297 RVA: 0x0017E9F3 File Offset: 0x0017CBF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GatewayEchoRequest other)
		{
			return other != null && (other == this || (!(this.Content != other.Content) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009D6A RID: 40298 RVA: 0x0017EA28 File Offset: 0x0017CC28
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

		// Token: 0x06009D6B RID: 40299 RVA: 0x0017EA69 File Offset: 0x0017CC69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009D6C RID: 40300 RVA: 0x0017EA76 File Offset: 0x0017CC76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009D6D RID: 40301 RVA: 0x0017EA7F File Offset: 0x0017CC7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Content.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.Content);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009D6E RID: 40302 RVA: 0x0017EAB8 File Offset: 0x0017CCB8
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

		// Token: 0x06009D6F RID: 40303 RVA: 0x0017EAFB File Offset: 0x0017CCFB
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

		// Token: 0x06009D70 RID: 40304 RVA: 0x0017EB31 File Offset: 0x0017CD31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009D71 RID: 40305 RVA: 0x0017EB3C File Offset: 0x0017CD3C
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Content = input.ReadString();
				}
			}
		}

		// Token: 0x040049F6 RID: 18934
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049F7 RID: 18935
		public const int ContentFieldNumber = 9;

		// Token: 0x040049F8 RID: 18936
		private string content_ = "";
	}
}
