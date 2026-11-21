using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200073A RID: 1850
	[NetMessage(EMessageId.HeartbeatRequest)]
	public sealed class HeartbeatRequest : IMessage<HeartbeatRequest>, IMessage, IEquatable<HeartbeatRequest>, IDeepCloneable<HeartbeatRequest>, IBufferMessage
	{
		// Token: 0x0600A7F6 RID: 42998 RVA: 0x0019464D File Offset: 0x0019284D
		[NullableContext(1)]
		public static HeartbeatRequest Create()
		{
			return new HeartbeatRequest();
		}

		// Token: 0x170021C2 RID: 8642
		// (get) Token: 0x0600A7F7 RID: 42999 RVA: 0x00194654 File Offset: 0x00192854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021C3 RID: 8643
		// (get) Token: 0x0600A7F8 RID: 43000 RVA: 0x00194657 File Offset: 0x00192857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeartbeatRequest.Descriptor;
			}
		}

		// Token: 0x0600A7F9 RID: 43001 RVA: 0x0019465E File Offset: 0x0019285E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeartbeatRequest()
		{
		}

		// Token: 0x0600A7FA RID: 43002 RVA: 0x00194671 File Offset: 0x00192871
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeartbeatRequest(HeartbeatRequest other) : this()
		{
			this.reportData_ = other.reportData_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A7FB RID: 43003 RVA: 0x00194696 File Offset: 0x00192896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeartbeatRequest Clone()
		{
			return new HeartbeatRequest(this);
		}

		// Token: 0x170021C4 RID: 8644
		// (get) Token: 0x0600A7FC RID: 43004 RVA: 0x0019469E File Offset: 0x0019289E
		// (set) Token: 0x0600A7FD RID: 43005 RVA: 0x001946A6 File Offset: 0x001928A6
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

		// Token: 0x0600A7FE RID: 43006 RVA: 0x001946B9 File Offset: 0x001928B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeartbeatRequest);
		}

		// Token: 0x0600A7FF RID: 43007 RVA: 0x001946C7 File Offset: 0x001928C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HeartbeatRequest other)
		{
			return other != null && (other == this || (!(this.ReportData != other.ReportData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A800 RID: 43008 RVA: 0x001946FC File Offset: 0x001928FC
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

		// Token: 0x0600A801 RID: 43009 RVA: 0x0019473D File Offset: 0x0019293D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A802 RID: 43010 RVA: 0x0019474A File Offset: 0x0019294A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A803 RID: 43011 RVA: 0x00194753 File Offset: 0x00192953
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

		// Token: 0x0600A804 RID: 43012 RVA: 0x0019478C File Offset: 0x0019298C
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

		// Token: 0x0600A805 RID: 43013 RVA: 0x001947CF File Offset: 0x001929CF
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

		// Token: 0x0600A806 RID: 43014 RVA: 0x00194805 File Offset: 0x00192A05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A807 RID: 43015 RVA: 0x00194810 File Offset: 0x00192A10
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

		// Token: 0x04004D0B RID: 19723
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D0C RID: 19724
		public const int ReportDataFieldNumber = 1;

		// Token: 0x04004D0D RID: 19725
		private ByteString reportData_ = ByteString.Empty;
	}
}
