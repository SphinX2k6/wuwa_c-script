using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Debug
{
	// Token: 0x0200169D RID: 5789
	[NetMessage(EMessageId.OutputDebugInfoRequest)]
	public sealed class OutputDebugInfoRequest : IMessage<OutputDebugInfoRequest>, IMessage, IEquatable<OutputDebugInfoRequest>, IDeepCloneable<OutputDebugInfoRequest>, IBufferMessage
	{
		// Token: 0x0601D03B RID: 118843 RVA: 0x0043F3FE File Offset: 0x0043D5FE
		[NullableContext(1)]
		public static OutputDebugInfoRequest Create()
		{
			return new OutputDebugInfoRequest();
		}

		// Token: 0x17006273 RID: 25203
		// (get) Token: 0x0601D03C RID: 118844 RVA: 0x0043F405 File Offset: 0x0043D605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006274 RID: 25204
		// (get) Token: 0x0601D03D RID: 118845 RVA: 0x0043F408 File Offset: 0x0043D608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OutputDebugInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601D03E RID: 118846 RVA: 0x0043F40F File Offset: 0x0043D60F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OutputDebugInfoRequest()
		{
		}

		// Token: 0x0601D03F RID: 118847 RVA: 0x0043F422 File Offset: 0x0043D622
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OutputDebugInfoRequest(OutputDebugInfoRequest other) : this()
		{
			this.clientInfo_ = other.clientInfo_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D040 RID: 118848 RVA: 0x0043F447 File Offset: 0x0043D647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OutputDebugInfoRequest Clone()
		{
			return new OutputDebugInfoRequest(this);
		}

		// Token: 0x17006275 RID: 25205
		// (get) Token: 0x0601D041 RID: 118849 RVA: 0x0043F44F File Offset: 0x0043D64F
		// (set) Token: 0x0601D042 RID: 118850 RVA: 0x0043F457 File Offset: 0x0043D657
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ClientInfo
		{
			get
			{
				return this.clientInfo_;
			}
			set
			{
				this.clientInfo_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0601D043 RID: 118851 RVA: 0x0043F46A File Offset: 0x0043D66A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OutputDebugInfoRequest);
		}

		// Token: 0x0601D044 RID: 118852 RVA: 0x0043F478 File Offset: 0x0043D678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OutputDebugInfoRequest other)
		{
			return other != null && (other == this || (!(this.ClientInfo != other.ClientInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D045 RID: 118853 RVA: 0x0043F4AC File Offset: 0x0043D6AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ClientInfo.Length != 0)
			{
				num ^= this.ClientInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D046 RID: 118854 RVA: 0x0043F4ED File Offset: 0x0043D6ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D047 RID: 118855 RVA: 0x0043F4FA File Offset: 0x0043D6FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D048 RID: 118856 RVA: 0x0043F503 File Offset: 0x0043D703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ClientInfo.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.ClientInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D049 RID: 118857 RVA: 0x0043F53C File Offset: 0x0043D73C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ClientInfo.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClientInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D04A RID: 118858 RVA: 0x0043F57F File Offset: 0x0043D77F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OutputDebugInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ClientInfo.Length != 0)
			{
				this.ClientInfo = other.ClientInfo;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D04B RID: 118859 RVA: 0x0043F5B5 File Offset: 0x0043D7B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D04C RID: 118860 RVA: 0x0043F5C0 File Offset: 0x0043D7C0
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
					this.ClientInfo = input.ReadString();
				}
			}
		}

		// Token: 0x0400C3DE RID: 50142
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C3DF RID: 50143
		public const int ClientInfoFieldNumber = 10;

		// Token: 0x0400C3E0 RID: 50144
		private string clientInfo_ = "";
	}
}
