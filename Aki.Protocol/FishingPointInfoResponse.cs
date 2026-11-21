using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200055A RID: 1370
	[NetMessage(EMessageId.FishingPointInfoResponse)]
	public sealed class FishingPointInfoResponse : IMessage<FishingPointInfoResponse>, IMessage, IEquatable<FishingPointInfoResponse>, IDeepCloneable<FishingPointInfoResponse>, IBufferMessage
	{
		// Token: 0x0600801F RID: 32799 RVA: 0x001362DD File Offset: 0x001344DD
		[NullableContext(1)]
		public static FishingPointInfoResponse Create()
		{
			return new FishingPointInfoResponse();
		}

		// Token: 0x170018F5 RID: 6389
		// (get) Token: 0x06008020 RID: 32800 RVA: 0x001362E4 File Offset: 0x001344E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018F6 RID: 6390
		// (get) Token: 0x06008021 RID: 32801 RVA: 0x001362E7 File Offset: 0x001344E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingPointInfoResponse.Descriptor;
			}
		}

		// Token: 0x06008022 RID: 32802 RVA: 0x001362EE File Offset: 0x001344EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingPointInfoResponse()
		{
		}

		// Token: 0x06008023 RID: 32803 RVA: 0x001362F8 File Offset: 0x001344F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingPointInfoResponse(FishingPointInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.fishPointInfo_ = ((other.fishPointInfo_ != null) ? other.fishPointInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008024 RID: 32804 RVA: 0x00136344 File Offset: 0x00134544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingPointInfoResponse Clone()
		{
			return new FishingPointInfoResponse(this);
		}

		// Token: 0x170018F7 RID: 6391
		// (get) Token: 0x06008025 RID: 32805 RVA: 0x0013634C File Offset: 0x0013454C
		// (set) Token: 0x06008026 RID: 32806 RVA: 0x00136354 File Offset: 0x00134554
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

		// Token: 0x170018F8 RID: 6392
		// (get) Token: 0x06008027 RID: 32807 RVA: 0x0013635D File Offset: 0x0013455D
		// (set) Token: 0x06008028 RID: 32808 RVA: 0x00136365 File Offset: 0x00134565
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

		// Token: 0x06008029 RID: 32809 RVA: 0x0013636E File Offset: 0x0013456E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingPointInfoResponse);
		}

		// Token: 0x0600802A RID: 32810 RVA: 0x0013637C File Offset: 0x0013457C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingPointInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.FishPointInfo, other.FishPointInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600802B RID: 32811 RVA: 0x001363CC File Offset: 0x001345CC
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

		// Token: 0x0600802C RID: 32812 RVA: 0x00136427 File Offset: 0x00134627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600802D RID: 32813 RVA: 0x00136434 File Offset: 0x00134634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600802E RID: 32814 RVA: 0x00136440 File Offset: 0x00134640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.fishPointInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.FishPointInfo);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600802F RID: 32815 RVA: 0x0013649C File Offset: 0x0013469C
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

		// Token: 0x06008030 RID: 32816 RVA: 0x001364F4 File Offset: 0x001346F4
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

		// Token: 0x06008031 RID: 32817 RVA: 0x0013655C File Offset: 0x0013475C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008032 RID: 32818 RVA: 0x00136568 File Offset: 0x00134768
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
					if (num != 88U)
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

		// Token: 0x04004100 RID: 16640
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004101 RID: 16641
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04004102 RID: 16642
		private ErrorCode errorCode_;

		// Token: 0x04004103 RID: 16643
		public const int FishPointInfoFieldNumber = 5;

		// Token: 0x04004104 RID: 16644
		private OneFishPointInfo fishPointInfo_;
	}
}
