using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000760 RID: 1888
	[NetMessage(EMessageId.HonamiStoryActivityInfoResponse)]
	public sealed class HonamiStoryActivityInfoResponse : IMessage<HonamiStoryActivityInfoResponse>, IMessage, IEquatable<HonamiStoryActivityInfoResponse>, IDeepCloneable<HonamiStoryActivityInfoResponse>, IBufferMessage
	{
		// Token: 0x0600AAE9 RID: 43753 RVA: 0x0019B75D File Offset: 0x0019995D
		[NullableContext(1)]
		public static HonamiStoryActivityInfoResponse Create()
		{
			return new HonamiStoryActivityInfoResponse();
		}

		// Token: 0x17002273 RID: 8819
		// (get) Token: 0x0600AAEA RID: 43754 RVA: 0x0019B764 File Offset: 0x00199964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002274 RID: 8820
		// (get) Token: 0x0600AAEB RID: 43755 RVA: 0x0019B767 File Offset: 0x00199967
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryActivityInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600AAEC RID: 43756 RVA: 0x0019B76E File Offset: 0x0019996E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryActivityInfoResponse()
		{
		}

		// Token: 0x0600AAED RID: 43757 RVA: 0x0019B778 File Offset: 0x00199978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryActivityInfoResponse(HonamiStoryActivityInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.honamiStoryActivityInfo_ = ((other.honamiStoryActivityInfo_ != null) ? other.honamiStoryActivityInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AAEE RID: 43758 RVA: 0x0019B7C4 File Offset: 0x001999C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryActivityInfoResponse Clone()
		{
			return new HonamiStoryActivityInfoResponse(this);
		}

		// Token: 0x17002275 RID: 8821
		// (get) Token: 0x0600AAEF RID: 43759 RVA: 0x0019B7CC File Offset: 0x001999CC
		// (set) Token: 0x0600AAF0 RID: 43760 RVA: 0x0019B7D4 File Offset: 0x001999D4
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

		// Token: 0x17002276 RID: 8822
		// (get) Token: 0x0600AAF1 RID: 43761 RVA: 0x0019B7DD File Offset: 0x001999DD
		// (set) Token: 0x0600AAF2 RID: 43762 RVA: 0x0019B7E5 File Offset: 0x001999E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryActivityInfo HonamiStoryActivityInfo
		{
			get
			{
				return this.honamiStoryActivityInfo_;
			}
			set
			{
				this.honamiStoryActivityInfo_ = value;
			}
		}

		// Token: 0x0600AAF3 RID: 43763 RVA: 0x0019B7EE File Offset: 0x001999EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryActivityInfoResponse);
		}

		// Token: 0x0600AAF4 RID: 43764 RVA: 0x0019B7FC File Offset: 0x001999FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryActivityInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.HonamiStoryActivityInfo, other.HonamiStoryActivityInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AAF5 RID: 43765 RVA: 0x0019B84C File Offset: 0x00199A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.honamiStoryActivityInfo_ != null)
			{
				num ^= this.HonamiStoryActivityInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AAF6 RID: 43766 RVA: 0x0019B8A7 File Offset: 0x00199AA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AAF7 RID: 43767 RVA: 0x0019B8B4 File Offset: 0x00199AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AAF8 RID: 43768 RVA: 0x0019B8C0 File Offset: 0x00199AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.honamiStoryActivityInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.HonamiStoryActivityInfo);
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

		// Token: 0x0600AAF9 RID: 43769 RVA: 0x0019B91C File Offset: 0x00199B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.honamiStoryActivityInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HonamiStoryActivityInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AAFA RID: 43770 RVA: 0x0019B974 File Offset: 0x00199B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryActivityInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.honamiStoryActivityInfo_ != null)
			{
				if (this.honamiStoryActivityInfo_ == null)
				{
					this.HonamiStoryActivityInfo = new HonamiStoryActivityInfo();
				}
				this.HonamiStoryActivityInfo.MergeFrom(other.HonamiStoryActivityInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AAFB RID: 43771 RVA: 0x0019B9DC File Offset: 0x00199BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AAFC RID: 43772 RVA: 0x0019B9E8 File Offset: 0x00199BE8
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
					if (this.honamiStoryActivityInfo_ == null)
					{
						this.HonamiStoryActivityInfo = new HonamiStoryActivityInfo();
					}
					input.ReadMessage(this.HonamiStoryActivityInfo);
				}
			}
		}

		// Token: 0x04004DB4 RID: 19892
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DB5 RID: 19893
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04004DB6 RID: 19894
		private ErrorCode errorCode_;

		// Token: 0x04004DB7 RID: 19895
		public const int HonamiStoryActivityInfoFieldNumber = 5;

		// Token: 0x04004DB8 RID: 19896
		private HonamiStoryActivityInfo honamiStoryActivityInfo_;
	}
}
