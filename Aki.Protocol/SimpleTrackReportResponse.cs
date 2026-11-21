using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001268 RID: 4712
	[NetMessage(EMessageId.SimpleTrackReportResponse)]
	public sealed class SimpleTrackReportResponse : IMessage<SimpleTrackReportResponse>, IMessage, IEquatable<SimpleTrackReportResponse>, IDeepCloneable<SimpleTrackReportResponse>, IBufferMessage
	{
		// Token: 0x0601927D RID: 103037 RVA: 0x003AB48A File Offset: 0x003A968A
		[NullableContext(1)]
		public static SimpleTrackReportResponse Create()
		{
			return new SimpleTrackReportResponse();
		}

		// Token: 0x17005509 RID: 21769
		// (get) Token: 0x0601927E RID: 103038 RVA: 0x003AB491 File Offset: 0x003A9691
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700550A RID: 21770
		// (get) Token: 0x0601927F RID: 103039 RVA: 0x003AB494 File Offset: 0x003A9694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SimpleTrackReportResponse.Descriptor;
			}
		}

		// Token: 0x06019280 RID: 103040 RVA: 0x003AB49B File Offset: 0x003A969B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleTrackReportResponse()
		{
		}

		// Token: 0x06019281 RID: 103041 RVA: 0x003AB4AE File Offset: 0x003A96AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleTrackReportResponse(SimpleTrackReportResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.simpleTrackReportMsgs_ = other.simpleTrackReportMsgs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019282 RID: 103042 RVA: 0x003AB4E4 File Offset: 0x003A96E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleTrackReportResponse Clone()
		{
			return new SimpleTrackReportResponse(this);
		}

		// Token: 0x1700550B RID: 21771
		// (get) Token: 0x06019283 RID: 103043 RVA: 0x003AB4EC File Offset: 0x003A96EC
		// (set) Token: 0x06019284 RID: 103044 RVA: 0x003AB4F4 File Offset: 0x003A96F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x1700550C RID: 21772
		// (get) Token: 0x06019285 RID: 103045 RVA: 0x003AB4FD File Offset: 0x003A96FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SimpleTrackReportMsg> SimpleTrackReportMsgs
		{
			get
			{
				return this.simpleTrackReportMsgs_;
			}
		}

		// Token: 0x06019286 RID: 103046 RVA: 0x003AB505 File Offset: 0x003A9705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SimpleTrackReportResponse);
		}

		// Token: 0x06019287 RID: 103047 RVA: 0x003AB514 File Offset: 0x003A9714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SimpleTrackReportResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.simpleTrackReportMsgs_.Equals(other.simpleTrackReportMsgs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019288 RID: 103048 RVA: 0x003AB564 File Offset: 0x003A9764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.simpleTrackReportMsgs_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019289 RID: 103049 RVA: 0x003AB5B7 File Offset: 0x003A97B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601928A RID: 103050 RVA: 0x003AB5C4 File Offset: 0x003A97C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601928B RID: 103051 RVA: 0x003AB5D0 File Offset: 0x003A97D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.simpleTrackReportMsgs_.WriteTo(ref output, SimpleTrackReportResponse._repeated_simpleTrackReportMsgs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601928C RID: 103052 RVA: 0x003AB620 File Offset: 0x003A9820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.simpleTrackReportMsgs_.CalculateSize(SimpleTrackReportResponse._repeated_simpleTrackReportMsgs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601928D RID: 103053 RVA: 0x003AB674 File Offset: 0x003A9874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SimpleTrackReportResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.simpleTrackReportMsgs_.Add(other.simpleTrackReportMsgs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601928E RID: 103054 RVA: 0x003AB6C1 File Offset: 0x003A98C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601928F RID: 103055 RVA: 0x003AB6CC File Offset: 0x003A98CC
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
				if (num != 48U)
				{
					if (num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.simpleTrackReportMsgs_.AddEntriesFrom(ref input, SimpleTrackReportResponse._repeated_simpleTrackReportMsgs_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040094EE RID: 38126
		private UnknownFieldSet _unknownFields;

		// Token: 0x040094EF RID: 38127
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x040094F0 RID: 38128
		private ErrorCode errorCode_;

		// Token: 0x040094F1 RID: 38129
		public const int SimpleTrackReportMsgsFieldNumber = 8;

		// Token: 0x040094F2 RID: 38130
		private static readonly FieldCodec<SimpleTrackReportMsg> _repeated_simpleTrackReportMsgs_codec = FieldCodec.ForMessage<SimpleTrackReportMsg>(66U, SimpleTrackReportMsg.Parser);

		// Token: 0x040094F3 RID: 38131
		private readonly RepeatedField<SimpleTrackReportMsg> simpleTrackReportMsgs_ = new RepeatedField<SimpleTrackReportMsg>();
	}
}
