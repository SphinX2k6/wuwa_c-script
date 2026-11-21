using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011EB RID: 4587
	[NetMessage(EMessageId.SecGetReportData2FlowResponse)]
	public sealed class SecGetReportData2FlowResponse : IMessage<SecGetReportData2FlowResponse>, IMessage, IEquatable<SecGetReportData2FlowResponse>, IDeepCloneable<SecGetReportData2FlowResponse>, IBufferMessage
	{
		// Token: 0x060187E0 RID: 100320 RVA: 0x003913E9 File Offset: 0x0038F5E9
		[NullableContext(1)]
		public static SecGetReportData2FlowResponse Create()
		{
			return new SecGetReportData2FlowResponse();
		}

		// Token: 0x1700529C RID: 21148
		// (get) Token: 0x060187E1 RID: 100321 RVA: 0x003913F0 File Offset: 0x0038F5F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700529D RID: 21149
		// (get) Token: 0x060187E2 RID: 100322 RVA: 0x003913F3 File Offset: 0x0038F5F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SecGetReportData2FlowResponse.Descriptor;
			}
		}

		// Token: 0x060187E3 RID: 100323 RVA: 0x003913FA File Offset: 0x0038F5FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecGetReportData2FlowResponse()
		{
		}

		// Token: 0x060187E4 RID: 100324 RVA: 0x00391402 File Offset: 0x0038F602
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecGetReportData2FlowResponse(SecGetReportData2FlowResponse other) : this()
		{
			this.error_ = ((other.error_ != null) ? other.error_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060187E5 RID: 100325 RVA: 0x00391437 File Offset: 0x0038F637
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecGetReportData2FlowResponse Clone()
		{
			return new SecGetReportData2FlowResponse(this);
		}

		// Token: 0x1700529E RID: 21150
		// (get) Token: 0x060187E6 RID: 100326 RVA: 0x0039143F File Offset: 0x0038F63F
		// (set) Token: 0x060187E7 RID: 100327 RVA: 0x00391447 File Offset: 0x0038F647
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

		// Token: 0x060187E8 RID: 100328 RVA: 0x00391450 File Offset: 0x0038F650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SecGetReportData2FlowResponse);
		}

		// Token: 0x060187E9 RID: 100329 RVA: 0x0039145E File Offset: 0x0038F65E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SecGetReportData2FlowResponse other)
		{
			return other != null && (other == this || (object.Equals(this.Error, other.Error) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060187EA RID: 100330 RVA: 0x00391494 File Offset: 0x0038F694
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

		// Token: 0x060187EB RID: 100331 RVA: 0x003914D0 File Offset: 0x0038F6D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060187EC RID: 100332 RVA: 0x003914DD File Offset: 0x0038F6DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060187ED RID: 100333 RVA: 0x003914E6 File Offset: 0x0038F6E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.error_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.Error);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060187EE RID: 100334 RVA: 0x00391518 File Offset: 0x0038F718
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

		// Token: 0x060187EF RID: 100335 RVA: 0x00391558 File Offset: 0x0038F758
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

		// Token: 0x060187F0 RID: 100336 RVA: 0x003915AC File Offset: 0x0038F7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060187F1 RID: 100337 RVA: 0x003915B8 File Offset: 0x0038F7B8
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
				if (num != 98U)
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

		// Token: 0x04009180 RID: 37248
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009181 RID: 37249
		public const int ErrorFieldNumber = 12;

		// Token: 0x04009182 RID: 37250
		private DErrorResult error_;
	}
}
