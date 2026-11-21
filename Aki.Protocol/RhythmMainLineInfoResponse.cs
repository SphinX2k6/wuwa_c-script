using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F2C RID: 3884
	[NetMessage(EMessageId.RhythmMainLineInfoResponse)]
	public sealed class RhythmMainLineInfoResponse : IMessage<RhythmMainLineInfoResponse>, IMessage, IEquatable<RhythmMainLineInfoResponse>, IDeepCloneable<RhythmMainLineInfoResponse>, IBufferMessage
	{
		// Token: 0x06014CF7 RID: 85239 RVA: 0x0030572E File Offset: 0x0030392E
		[NullableContext(1)]
		public static RhythmMainLineInfoResponse Create()
		{
			return new RhythmMainLineInfoResponse();
		}

		// Token: 0x17004535 RID: 17717
		// (get) Token: 0x06014CF8 RID: 85240 RVA: 0x00305735 File Offset: 0x00303935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004536 RID: 17718
		// (get) Token: 0x06014CF9 RID: 85241 RVA: 0x00305738 File Offset: 0x00303938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmMainLineInfoResponse.Descriptor;
			}
		}

		// Token: 0x06014CFA RID: 85242 RVA: 0x0030573F File Offset: 0x0030393F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmMainLineInfoResponse()
		{
		}

		// Token: 0x06014CFB RID: 85243 RVA: 0x00305748 File Offset: 0x00303948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmMainLineInfoResponse(RhythmMainLineInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.rhythmMainLinePb_ = ((other.rhythmMainLinePb_ != null) ? other.rhythmMainLinePb_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014CFC RID: 85244 RVA: 0x00305794 File Offset: 0x00303994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmMainLineInfoResponse Clone()
		{
			return new RhythmMainLineInfoResponse(this);
		}

		// Token: 0x17004537 RID: 17719
		// (get) Token: 0x06014CFD RID: 85245 RVA: 0x0030579C File Offset: 0x0030399C
		// (set) Token: 0x06014CFE RID: 85246 RVA: 0x003057A4 File Offset: 0x003039A4
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

		// Token: 0x17004538 RID: 17720
		// (get) Token: 0x06014CFF RID: 85247 RVA: 0x003057AD File Offset: 0x003039AD
		// (set) Token: 0x06014D00 RID: 85248 RVA: 0x003057B5 File Offset: 0x003039B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmActivityPb RhythmMainLinePb
		{
			get
			{
				return this.rhythmMainLinePb_;
			}
			set
			{
				this.rhythmMainLinePb_ = value;
			}
		}

		// Token: 0x06014D01 RID: 85249 RVA: 0x003057BE File Offset: 0x003039BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmMainLineInfoResponse);
		}

		// Token: 0x06014D02 RID: 85250 RVA: 0x003057CC File Offset: 0x003039CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmMainLineInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.RhythmMainLinePb, other.RhythmMainLinePb) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014D03 RID: 85251 RVA: 0x0030581C File Offset: 0x00303A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.rhythmMainLinePb_ != null)
			{
				num ^= this.RhythmMainLinePb.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014D04 RID: 85252 RVA: 0x00305877 File Offset: 0x00303A77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014D05 RID: 85253 RVA: 0x00305884 File Offset: 0x00303A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014D06 RID: 85254 RVA: 0x00305890 File Offset: 0x00303A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rhythmMainLinePb_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RhythmMainLinePb);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014D07 RID: 85255 RVA: 0x003058EC File Offset: 0x00303AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.rhythmMainLinePb_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RhythmMainLinePb);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014D08 RID: 85256 RVA: 0x00305944 File Offset: 0x00303B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmMainLineInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.rhythmMainLinePb_ != null)
			{
				if (this.rhythmMainLinePb_ == null)
				{
					this.RhythmMainLinePb = new RhythmActivityPb();
				}
				this.RhythmMainLinePb.MergeFrom(other.RhythmMainLinePb);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014D09 RID: 85257 RVA: 0x003059AC File Offset: 0x00303BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014D0A RID: 85258 RVA: 0x003059B8 File Offset: 0x00303BB8
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
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.rhythmMainLinePb_ == null)
					{
						this.RhythmMainLinePb = new RhythmActivityPb();
					}
					input.ReadMessage(this.RhythmMainLinePb);
				}
			}
		}

		// Token: 0x04007E07 RID: 32263
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E08 RID: 32264
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04007E09 RID: 32265
		private ErrorCode errorCode_;

		// Token: 0x04007E0A RID: 32266
		public const int RhythmMainLinePbFieldNumber = 1;

		// Token: 0x04007E0B RID: 32267
		private RhythmActivityPb rhythmMainLinePb_;
	}
}
