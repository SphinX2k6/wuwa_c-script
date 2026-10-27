using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002E3 RID: 739
	[NetMessage(EMessageId.ConsumptiveActivityInfoResponse)]
	public sealed class ConsumptiveActivityInfoResponse : IMessage<ConsumptiveActivityInfoResponse>, IMessage, IEquatable<ConsumptiveActivityInfoResponse>, IDeepCloneable<ConsumptiveActivityInfoResponse>, IBufferMessage
	{
		// Token: 0x06004B3F RID: 19263 RVA: 0x000B7676 File Offset: 0x000B5876
		[NullableContext(1)]
		public static ConsumptiveActivityInfoResponse Create()
		{
			return new ConsumptiveActivityInfoResponse();
		}

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x06004B40 RID: 19264 RVA: 0x000B767D File Offset: 0x000B587D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x06004B41 RID: 19265 RVA: 0x000B7680 File Offset: 0x000B5880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConsumptiveActivityInfoResponse.Descriptor;
			}
		}

		// Token: 0x06004B42 RID: 19266 RVA: 0x000B7687 File Offset: 0x000B5887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveActivityInfoResponse()
		{
		}

		// Token: 0x06004B43 RID: 19267 RVA: 0x000B7690 File Offset: 0x000B5890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveActivityInfoResponse(ConsumptiveActivityInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.consumptiveActivityInfo_ = ((other.consumptiveActivityInfo_ != null) ? other.consumptiveActivityInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004B44 RID: 19268 RVA: 0x000B76DC File Offset: 0x000B58DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveActivityInfoResponse Clone()
		{
			return new ConsumptiveActivityInfoResponse(this);
		}

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x06004B45 RID: 19269 RVA: 0x000B76E4 File Offset: 0x000B58E4
		// (set) Token: 0x06004B46 RID: 19270 RVA: 0x000B76EC File Offset: 0x000B58EC
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

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x06004B47 RID: 19271 RVA: 0x000B76F5 File Offset: 0x000B58F5
		// (set) Token: 0x06004B48 RID: 19272 RVA: 0x000B76FD File Offset: 0x000B58FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveActivityInfo ConsumptiveActivityInfo
		{
			get
			{
				return this.consumptiveActivityInfo_;
			}
			set
			{
				this.consumptiveActivityInfo_ = value;
			}
		}

		// Token: 0x06004B49 RID: 19273 RVA: 0x000B7706 File Offset: 0x000B5906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConsumptiveActivityInfoResponse);
		}

		// Token: 0x06004B4A RID: 19274 RVA: 0x000B7714 File Offset: 0x000B5914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConsumptiveActivityInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.ConsumptiveActivityInfo, other.ConsumptiveActivityInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004B4B RID: 19275 RVA: 0x000B7764 File Offset: 0x000B5964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.consumptiveActivityInfo_ != null)
			{
				num ^= this.ConsumptiveActivityInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004B4C RID: 19276 RVA: 0x000B77BF File Offset: 0x000B59BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004B4D RID: 19277 RVA: 0x000B77CC File Offset: 0x000B59CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004B4E RID: 19278 RVA: 0x000B77D8 File Offset: 0x000B59D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.consumptiveActivityInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.ConsumptiveActivityInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004B4F RID: 19279 RVA: 0x000B7834 File Offset: 0x000B5A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.consumptiveActivityInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ConsumptiveActivityInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004B50 RID: 19280 RVA: 0x000B788C File Offset: 0x000B5A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConsumptiveActivityInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.consumptiveActivityInfo_ != null)
			{
				if (this.consumptiveActivityInfo_ == null)
				{
					this.ConsumptiveActivityInfo = new ConsumptiveActivityInfo();
				}
				this.ConsumptiveActivityInfo.MergeFrom(other.ConsumptiveActivityInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004B51 RID: 19281 RVA: 0x000B78F4 File Offset: 0x000B5AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004B52 RID: 19282 RVA: 0x000B7900 File Offset: 0x000B5B00
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
				if (num != 40U)
				{
					if (num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.consumptiveActivityInfo_ == null)
						{
							this.ConsumptiveActivityInfo = new ConsumptiveActivityInfo();
						}
						input.ReadMessage(this.ConsumptiveActivityInfo);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040030A8 RID: 12456
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030A9 RID: 12457
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x040030AA RID: 12458
		private ErrorCode errorCode_;

		// Token: 0x040030AB RID: 12459
		public const int ConsumptiveActivityInfoFieldNumber = 7;

		// Token: 0x040030AC RID: 12460
		private ConsumptiveActivityInfo consumptiveActivityInfo_;
	}
}
