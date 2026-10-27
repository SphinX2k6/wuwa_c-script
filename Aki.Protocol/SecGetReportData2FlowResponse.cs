using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011B1 RID: 4529
	[NetMessage(EMessageId.SecGetReportData2FlowResponse)]
	public sealed class SecGetReportData2FlowResponse : IMessage<SecGetReportData2FlowResponse>, IMessage, IEquatable<SecGetReportData2FlowResponse>, IDeepCloneable<SecGetReportData2FlowResponse>, IBufferMessage
	{
		// Token: 0x0601823F RID: 98879 RVA: 0x00382081 File Offset: 0x00380281
		[NullableContext(1)]
		public static SecGetReportData2FlowResponse Create()
		{
			return new SecGetReportData2FlowResponse();
		}

		// Token: 0x17005130 RID: 20784
		// (get) Token: 0x06018240 RID: 98880 RVA: 0x00382088 File Offset: 0x00380288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005131 RID: 20785
		// (get) Token: 0x06018241 RID: 98881 RVA: 0x0038208B File Offset: 0x0038028B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SecGetReportData2FlowResponse.Descriptor;
			}
		}

		// Token: 0x06018242 RID: 98882 RVA: 0x00382092 File Offset: 0x00380292
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecGetReportData2FlowResponse()
		{
		}

		// Token: 0x06018243 RID: 98883 RVA: 0x0038209A File Offset: 0x0038029A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecGetReportData2FlowResponse(SecGetReportData2FlowResponse other) : this()
		{
			this.error_ = ((other.error_ != null) ? other.error_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018244 RID: 98884 RVA: 0x003820CF File Offset: 0x003802CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecGetReportData2FlowResponse Clone()
		{
			return new SecGetReportData2FlowResponse(this);
		}

		// Token: 0x17005132 RID: 20786
		// (get) Token: 0x06018245 RID: 98885 RVA: 0x003820D7 File Offset: 0x003802D7
		// (set) Token: 0x06018246 RID: 98886 RVA: 0x003820DF File Offset: 0x003802DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DErrorResult Error
		{
			get
			{
				return this.error_;
			}
			set
			{
				this.error_ = value;
			}
		}

		// Token: 0x06018247 RID: 98887 RVA: 0x003820E8 File Offset: 0x003802E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SecGetReportData2FlowResponse);
		}

		// Token: 0x06018248 RID: 98888 RVA: 0x003820F6 File Offset: 0x003802F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SecGetReportData2FlowResponse other)
		{
			return other != null && (other == this || (object.Equals(this.Error, other.Error) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018249 RID: 98889 RVA: 0x0038212C File Offset: 0x0038032C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.error_ != null)
			{
				num ^= this.Error.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601824A RID: 98890 RVA: 0x00382168 File Offset: 0x00380368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601824B RID: 98891 RVA: 0x00382175 File Offset: 0x00380375
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601824C RID: 98892 RVA: 0x0038217E File Offset: 0x0038037E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.error_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Error);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601824D RID: 98893 RVA: 0x003821B0 File Offset: 0x003803B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.error_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Error);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601824E RID: 98894 RVA: 0x003821F0 File Offset: 0x003803F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SecGetReportData2FlowResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.error_ != null)
			{
				if (this.error_ == null)
				{
					this.Error = new DErrorResult();
				}
				this.Error.MergeFrom(other.Error);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601824F RID: 98895 RVA: 0x00382244 File Offset: 0x00380444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018250 RID: 98896 RVA: 0x00382250 File Offset: 0x00380450
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
					if (this.error_ == null)
					{
						this.Error = new DErrorResult();
					}
					input.ReadMessage(this.Error);
				}
			}
		}

		// Token: 0x04008EED RID: 36589
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008EEE RID: 36590
		public const int ErrorFieldNumber = 15;

		// Token: 0x04008EEF RID: 36591
		private DErrorResult error_;
	}
}
