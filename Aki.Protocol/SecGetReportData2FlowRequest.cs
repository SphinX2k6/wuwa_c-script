using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011EA RID: 4586
	[NetMessage(EMessageId.SecGetReportData2FlowRequest)]
	public sealed class SecGetReportData2FlowRequest : IMessage<SecGetReportData2FlowRequest>, IMessage, IEquatable<SecGetReportData2FlowRequest>, IDeepCloneable<SecGetReportData2FlowRequest>, IBufferMessage
	{
		// Token: 0x060187CE RID: 100302 RVA: 0x003911E0 File Offset: 0x0038F3E0
		[NullableContext(1)]
		public static SecGetReportData2FlowRequest Create()
		{
			return new SecGetReportData2FlowRequest();
		}

		// Token: 0x17005299 RID: 21145
		// (get) Token: 0x060187CF RID: 100303 RVA: 0x003911E7 File Offset: 0x0038F3E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700529A RID: 21146
		// (get) Token: 0x060187D0 RID: 100304 RVA: 0x003911EA File Offset: 0x0038F3EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SecGetReportData2FlowRequest.Descriptor;
			}
		}

		// Token: 0x060187D1 RID: 100305 RVA: 0x003911F1 File Offset: 0x0038F3F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecGetReportData2FlowRequest()
		{
		}

		// Token: 0x060187D2 RID: 100306 RVA: 0x00391204 File Offset: 0x0038F404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecGetReportData2FlowRequest(SecGetReportData2FlowRequest other) : this()
		{
			this.reportData_ = other.reportData_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060187D3 RID: 100307 RVA: 0x00391229 File Offset: 0x0038F429
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecGetReportData2FlowRequest Clone()
		{
			return new SecGetReportData2FlowRequest(this);
		}

		// Token: 0x1700529B RID: 21147
		// (get) Token: 0x060187D4 RID: 100308 RVA: 0x00391231 File Offset: 0x0038F431
		// (set) Token: 0x060187D5 RID: 100309 RVA: 0x00391239 File Offset: 0x0038F439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ByteString ReportData
		{
			get
			{
				return this.reportData_;
			}
			set
			{
				this.reportData_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x060187D6 RID: 100310 RVA: 0x0039124C File Offset: 0x0038F44C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SecGetReportData2FlowRequest);
		}

		// Token: 0x060187D7 RID: 100311 RVA: 0x0039125A File Offset: 0x0038F45A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SecGetReportData2FlowRequest other)
		{
			return other != null && (other == this || (!(this.ReportData != other.ReportData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060187D8 RID: 100312 RVA: 0x00391290 File Offset: 0x0038F490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ReportData.Length != 0)
			{
				num ^= this.ReportData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060187D9 RID: 100313 RVA: 0x003912D1 File Offset: 0x0038F4D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060187DA RID: 100314 RVA: 0x003912DE File Offset: 0x0038F4DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060187DB RID: 100315 RVA: 0x003912E7 File Offset: 0x0038F4E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ReportData.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteBytes(this.ReportData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060187DC RID: 100316 RVA: 0x00391320 File Offset: 0x0038F520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ReportData.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.ReportData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060187DD RID: 100317 RVA: 0x00391363 File Offset: 0x0038F563
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SecGetReportData2FlowRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ReportData.Length != 0)
			{
				this.ReportData = other.ReportData;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060187DE RID: 100318 RVA: 0x00391399 File Offset: 0x0038F599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060187DF RID: 100319 RVA: 0x003913A4 File Offset: 0x0038F5A4
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ReportData = input.ReadBytes();
				}
			}
		}

		// Token: 0x0400917D RID: 37245
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400917E RID: 37246
		public const int ReportDataFieldNumber = 7;

		// Token: 0x0400917F RID: 37247
		private ByteString reportData_ = ByteString.Empty;
	}
}
