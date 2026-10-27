using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200074E RID: 1870
	[NetMessage(EMessageId.HeartbeatRequest)]
	public sealed class HeartbeatRequest : IMessage<HeartbeatRequest>, IMessage, IEquatable<HeartbeatRequest>, IDeepCloneable<HeartbeatRequest>, IBufferMessage
	{
		// Token: 0x0600A94C RID: 43340 RVA: 0x00197079 File Offset: 0x00195279
		[NullableContext(1)]
		public static HeartbeatRequest Create()
		{
			return new HeartbeatRequest();
		}

		// Token: 0x1700220C RID: 8716
		// (get) Token: 0x0600A94D RID: 43341 RVA: 0x00197080 File Offset: 0x00195280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700220D RID: 8717
		// (get) Token: 0x0600A94E RID: 43342 RVA: 0x00197083 File Offset: 0x00195283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeartbeatRequest.Descriptor;
			}
		}

		// Token: 0x0600A94F RID: 43343 RVA: 0x0019708A File Offset: 0x0019528A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeartbeatRequest()
		{
		}

		// Token: 0x0600A950 RID: 43344 RVA: 0x0019709D File Offset: 0x0019529D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeartbeatRequest(HeartbeatRequest other) : this()
		{
			this.reportData_ = other.reportData_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A951 RID: 43345 RVA: 0x001970C2 File Offset: 0x001952C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeartbeatRequest Clone()
		{
			return new HeartbeatRequest(this);
		}

		// Token: 0x1700220E RID: 8718
		// (get) Token: 0x0600A952 RID: 43346 RVA: 0x001970CA File Offset: 0x001952CA
		// (set) Token: 0x0600A953 RID: 43347 RVA: 0x001970D2 File Offset: 0x001952D2
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

		// Token: 0x0600A954 RID: 43348 RVA: 0x001970E5 File Offset: 0x001952E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeartbeatRequest);
		}

		// Token: 0x0600A955 RID: 43349 RVA: 0x001970F3 File Offset: 0x001952F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HeartbeatRequest other)
		{
			return other != null && (other == this || (!(this.ReportData != other.ReportData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A956 RID: 43350 RVA: 0x00197128 File Offset: 0x00195328
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

		// Token: 0x0600A957 RID: 43351 RVA: 0x00197169 File Offset: 0x00195369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A958 RID: 43352 RVA: 0x00197176 File Offset: 0x00195376
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A959 RID: 43353 RVA: 0x0019717F File Offset: 0x0019537F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ReportData.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteBytes(this.ReportData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A95A RID: 43354 RVA: 0x001971B8 File Offset: 0x001953B8
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

		// Token: 0x0600A95B RID: 43355 RVA: 0x001971FB File Offset: 0x001953FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HeartbeatRequest other)
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

		// Token: 0x0600A95C RID: 43356 RVA: 0x00197231 File Offset: 0x00195431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A95D RID: 43357 RVA: 0x0019723C File Offset: 0x0019543C
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ReportData = input.ReadBytes();
				}
			}
		}

		// Token: 0x04004D12 RID: 19730
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D13 RID: 19731
		public const int ReportDataFieldNumber = 1;

		// Token: 0x04004D14 RID: 19732
		private ByteString reportData_ = ByteString.Empty;
	}
}
