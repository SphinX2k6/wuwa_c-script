using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200056F RID: 1391
	[NetMessage(EMessageId.FishingPointInfoResponse)]
	public sealed class FishingPointInfoResponse : IMessage<FishingPointInfoResponse>, IMessage, IEquatable<FishingPointInfoResponse>, IDeepCloneable<FishingPointInfoResponse>, IBufferMessage
	{
		// Token: 0x06008187 RID: 33159 RVA: 0x00138EDD File Offset: 0x001370DD
		[NullableContext(1)]
		public static FishingPointInfoResponse Create()
		{
			return new FishingPointInfoResponse();
		}

		// Token: 0x17001942 RID: 6466
		// (get) Token: 0x06008188 RID: 33160 RVA: 0x00138EE4 File Offset: 0x001370E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001943 RID: 6467
		// (get) Token: 0x06008189 RID: 33161 RVA: 0x00138EE7 File Offset: 0x001370E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingPointInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600818A RID: 33162 RVA: 0x00138EEE File Offset: 0x001370EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingPointInfoResponse()
		{
		}

		// Token: 0x0600818B RID: 33163 RVA: 0x00138EF8 File Offset: 0x001370F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingPointInfoResponse(FishingPointInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.fishPointInfo_ = ((other.fishPointInfo_ != null) ? other.fishPointInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600818C RID: 33164 RVA: 0x00138F44 File Offset: 0x00137144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingPointInfoResponse Clone()
		{
			return new FishingPointInfoResponse(this);
		}

		// Token: 0x17001944 RID: 6468
		// (get) Token: 0x0600818D RID: 33165 RVA: 0x00138F4C File Offset: 0x0013714C
		// (set) Token: 0x0600818E RID: 33166 RVA: 0x00138F54 File Offset: 0x00137154
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

		// Token: 0x17001945 RID: 6469
		// (get) Token: 0x0600818F RID: 33167 RVA: 0x00138F5D File Offset: 0x0013715D
		// (set) Token: 0x06008190 RID: 33168 RVA: 0x00138F65 File Offset: 0x00137165
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneFishPointInfo FishPointInfo
		{
			get
			{
				return this.fishPointInfo_;
			}
			set
			{
				this.fishPointInfo_ = value;
			}
		}

		// Token: 0x06008191 RID: 33169 RVA: 0x00138F6E File Offset: 0x0013716E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingPointInfoResponse);
		}

		// Token: 0x06008192 RID: 33170 RVA: 0x00138F7C File Offset: 0x0013717C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingPointInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.FishPointInfo, other.FishPointInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008193 RID: 33171 RVA: 0x00138FCC File Offset: 0x001371CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.fishPointInfo_ != null)
			{
				num ^= this.FishPointInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008194 RID: 33172 RVA: 0x00139027 File Offset: 0x00137227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008195 RID: 33173 RVA: 0x00139034 File Offset: 0x00137234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008196 RID: 33174 RVA: 0x00139040 File Offset: 0x00137240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.fishPointInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.FishPointInfo);
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

		// Token: 0x06008197 RID: 33175 RVA: 0x0013909C File Offset: 0x0013729C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.fishPointInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FishPointInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008198 RID: 33176 RVA: 0x001390F4 File Offset: 0x001372F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingPointInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.fishPointInfo_ != null)
			{
				if (this.fishPointInfo_ == null)
				{
					this.FishPointInfo = new OneFishPointInfo();
				}
				this.FishPointInfo.MergeFrom(other.FishPointInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008199 RID: 33177 RVA: 0x0013915C File Offset: 0x0013735C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600819A RID: 33178 RVA: 0x00139168 File Offset: 0x00137368
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
					if (this.fishPointInfo_ == null)
					{
						this.FishPointInfo = new OneFishPointInfo();
					}
					input.ReadMessage(this.FishPointInfo);
				}
			}
		}

		// Token: 0x0400410A RID: 16650
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400410B RID: 16651
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x0400410C RID: 16652
		private ErrorCode errorCode_;

		// Token: 0x0400410D RID: 16653
		public const int FishPointInfoFieldNumber = 7;

		// Token: 0x0400410E RID: 16654
		private OneFishPointInfo fishPointInfo_;
	}
}
