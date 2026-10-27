using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011B0 RID: 4528
	[NetMessage(EMessageId.SecGetReportData2FlowRequest)]
	public sealed class SecGetReportData2FlowRequest : IMessage<SecGetReportData2FlowRequest>, IMessage, IEquatable<SecGetReportData2FlowRequest>, IDeepCloneable<SecGetReportData2FlowRequest>, IBufferMessage
	{
		// Token: 0x0601822D RID: 98861 RVA: 0x00381E7B File Offset: 0x0038007B
		[NullableContext(1)]
		public static SecGetReportData2FlowRequest Create()
		{
			return new SecGetReportData2FlowRequest();
		}

		// Token: 0x1700512D RID: 20781
		// (get) Token: 0x0601822E RID: 98862 RVA: 0x00381E82 File Offset: 0x00380082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700512E RID: 20782
		// (get) Token: 0x0601822F RID: 98863 RVA: 0x00381E85 File Offset: 0x00380085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SecGetReportData2FlowRequest.Descriptor;
			}
		}

		// Token: 0x06018230 RID: 98864 RVA: 0x00381E8C File Offset: 0x0038008C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecGetReportData2FlowRequest()
		{
		}

		// Token: 0x06018231 RID: 98865 RVA: 0x00381E9F File Offset: 0x0038009F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecGetReportData2FlowRequest(SecGetReportData2FlowRequest other) : this()
		{
			this.reportData_ = other.reportData_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018232 RID: 98866 RVA: 0x00381EC4 File Offset: 0x003800C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecGetReportData2FlowRequest Clone()
		{
			return new SecGetReportData2FlowRequest(this);
		}

		// Token: 0x1700512F RID: 20783
		// (get) Token: 0x06018233 RID: 98867 RVA: 0x00381ECC File Offset: 0x003800CC
		// (set) Token: 0x06018234 RID: 98868 RVA: 0x00381ED4 File Offset: 0x003800D4
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

		// Token: 0x06018235 RID: 98869 RVA: 0x00381EE7 File Offset: 0x003800E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SecGetReportData2FlowRequest);
		}

		// Token: 0x06018236 RID: 98870 RVA: 0x00381EF5 File Offset: 0x003800F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SecGetReportData2FlowRequest other)
		{
			return other != null && (other == this || (!(this.ReportData != other.ReportData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018237 RID: 98871 RVA: 0x00381F28 File Offset: 0x00380128
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

		// Token: 0x06018238 RID: 98872 RVA: 0x00381F69 File Offset: 0x00380169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018239 RID: 98873 RVA: 0x00381F76 File Offset: 0x00380176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601823A RID: 98874 RVA: 0x00381F7F File Offset: 0x0038017F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ReportData.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteBytes(this.ReportData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601823B RID: 98875 RVA: 0x00381FB8 File Offset: 0x003801B8
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

		// Token: 0x0601823C RID: 98876 RVA: 0x00381FFB File Offset: 0x003801FB
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

		// Token: 0x0601823D RID: 98877 RVA: 0x00382031 File Offset: 0x00380231
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601823E RID: 98878 RVA: 0x0038203C File Offset: 0x0038023C
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ReportData = input.ReadBytes();
				}
			}
		}

		// Token: 0x04008EEA RID: 36586
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008EEB RID: 36587
		public const int ReportDataFieldNumber = 5;

		// Token: 0x04008EEC RID: 36588
		private ByteString reportData_ = ByteString.Empty;
	}
}
