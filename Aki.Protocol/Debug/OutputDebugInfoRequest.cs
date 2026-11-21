using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Debug
{
	// Token: 0x02001719 RID: 5913
	[NetMessage(EMessageId.OutputDebugInfoRequest)]
	public sealed class OutputDebugInfoRequest : IMessage<OutputDebugInfoRequest>, IMessage, IEquatable<OutputDebugInfoRequest>, IDeepCloneable<OutputDebugInfoRequest>, IBufferMessage
	{
		// Token: 0x0601DB0A RID: 121610 RVA: 0x0045B13E File Offset: 0x0045933E
		[NullableContext(1)]
		public static OutputDebugInfoRequest Create()
		{
			return new OutputDebugInfoRequest();
		}

		// Token: 0x17006518 RID: 25880
		// (get) Token: 0x0601DB0B RID: 121611 RVA: 0x0045B145 File Offset: 0x00459345
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006519 RID: 25881
		// (get) Token: 0x0601DB0C RID: 121612 RVA: 0x0045B148 File Offset: 0x00459348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OutputDebugInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601DB0D RID: 121613 RVA: 0x0045B14F File Offset: 0x0045934F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OutputDebugInfoRequest()
		{
		}

		// Token: 0x0601DB0E RID: 121614 RVA: 0x0045B162 File Offset: 0x00459362
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OutputDebugInfoRequest(OutputDebugInfoRequest other) : this()
		{
			this.clientInfo_ = other.clientInfo_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DB0F RID: 121615 RVA: 0x0045B187 File Offset: 0x00459387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OutputDebugInfoRequest Clone()
		{
			return new OutputDebugInfoRequest(this);
		}

		// Token: 0x1700651A RID: 25882
		// (get) Token: 0x0601DB10 RID: 121616 RVA: 0x0045B18F File Offset: 0x0045938F
		// (set) Token: 0x0601DB11 RID: 121617 RVA: 0x0045B197 File Offset: 0x00459397
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

		// Token: 0x0601DB12 RID: 121618 RVA: 0x0045B1AA File Offset: 0x004593AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OutputDebugInfoRequest);
		}

		// Token: 0x0601DB13 RID: 121619 RVA: 0x0045B1B8 File Offset: 0x004593B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OutputDebugInfoRequest other)
		{
			return other != null && (other == this || (!(this.ClientInfo != other.ClientInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DB14 RID: 121620 RVA: 0x0045B1EC File Offset: 0x004593EC
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

		// Token: 0x0601DB15 RID: 121621 RVA: 0x0045B22D File Offset: 0x0045942D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DB16 RID: 121622 RVA: 0x0045B23A File Offset: 0x0045943A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DB17 RID: 121623 RVA: 0x0045B243 File Offset: 0x00459443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ClientInfo.Length != 0)
			{
				output.WriteRawTag(106);
				output.WriteString(this.ClientInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DB18 RID: 121624 RVA: 0x0045B27C File Offset: 0x0045947C
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

		// Token: 0x0601DB19 RID: 121625 RVA: 0x0045B2BF File Offset: 0x004594BF
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

		// Token: 0x0601DB1A RID: 121626 RVA: 0x0045B2F5 File Offset: 0x004594F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DB1B RID: 121627 RVA: 0x0045B300 File Offset: 0x00459500
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ClientInfo = input.ReadString();
				}
			}
		}

		// Token: 0x0400C90D RID: 51469
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C90E RID: 51470
		public const int ClientInfoFieldNumber = 13;

		// Token: 0x0400C90F RID: 51471
		private string clientInfo_ = "";
	}
}
