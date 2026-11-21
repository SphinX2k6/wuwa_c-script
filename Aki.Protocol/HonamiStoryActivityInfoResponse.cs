using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200074C RID: 1868
	[NetMessage(EMessageId.HonamiStoryActivityInfoResponse)]
	public sealed class HonamiStoryActivityInfoResponse : IMessage<HonamiStoryActivityInfoResponse>, IMessage, IEquatable<HonamiStoryActivityInfoResponse>, IDeepCloneable<HonamiStoryActivityInfoResponse>, IBufferMessage
	{
		// Token: 0x0600A993 RID: 43411 RVA: 0x00198D35 File Offset: 0x00196F35
		[NullableContext(1)]
		public static HonamiStoryActivityInfoResponse Create()
		{
			return new HonamiStoryActivityInfoResponse();
		}

		// Token: 0x17002229 RID: 8745
		// (get) Token: 0x0600A994 RID: 43412 RVA: 0x00198D3C File Offset: 0x00196F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700222A RID: 8746
		// (get) Token: 0x0600A995 RID: 43413 RVA: 0x00198D3F File Offset: 0x00196F3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryActivityInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600A996 RID: 43414 RVA: 0x00198D46 File Offset: 0x00196F46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryActivityInfoResponse()
		{
		}

		// Token: 0x0600A997 RID: 43415 RVA: 0x00198D50 File Offset: 0x00196F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryActivityInfoResponse(HonamiStoryActivityInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.honamiStoryActivityInfo_ = ((other.honamiStoryActivityInfo_ != null) ? other.honamiStoryActivityInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A998 RID: 43416 RVA: 0x00198D9C File Offset: 0x00196F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryActivityInfoResponse Clone()
		{
			return new HonamiStoryActivityInfoResponse(this);
		}

		// Token: 0x1700222B RID: 8747
		// (get) Token: 0x0600A999 RID: 43417 RVA: 0x00198DA4 File Offset: 0x00196FA4
		// (set) Token: 0x0600A99A RID: 43418 RVA: 0x00198DAC File Offset: 0x00196FAC
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

		// Token: 0x1700222C RID: 8748
		// (get) Token: 0x0600A99B RID: 43419 RVA: 0x00198DB5 File Offset: 0x00196FB5
		// (set) Token: 0x0600A99C RID: 43420 RVA: 0x00198DBD File Offset: 0x00196FBD
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

		// Token: 0x0600A99D RID: 43421 RVA: 0x00198DC6 File Offset: 0x00196FC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryActivityInfoResponse);
		}

		// Token: 0x0600A99E RID: 43422 RVA: 0x00198DD4 File Offset: 0x00196FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryActivityInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.HonamiStoryActivityInfo, other.HonamiStoryActivityInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A99F RID: 43423 RVA: 0x00198E24 File Offset: 0x00197024
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

		// Token: 0x0600A9A0 RID: 43424 RVA: 0x00198E7F File Offset: 0x0019707F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A9A1 RID: 43425 RVA: 0x00198E8C File Offset: 0x0019708C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A9A2 RID: 43426 RVA: 0x00198E98 File Offset: 0x00197098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.honamiStoryActivityInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.HonamiStoryActivityInfo);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A9A3 RID: 43427 RVA: 0x00198EF4 File Offset: 0x001970F4
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

		// Token: 0x0600A9A4 RID: 43428 RVA: 0x00198F4C File Offset: 0x0019714C
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

		// Token: 0x0600A9A5 RID: 43429 RVA: 0x00198FB4 File Offset: 0x001971B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A9A6 RID: 43430 RVA: 0x00198FC0 File Offset: 0x001971C0
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
				if (num != 18U)
				{
					if (num != 64U)
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

		// Token: 0x04004DAD RID: 19885
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DAE RID: 19886
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04004DAF RID: 19887
		private ErrorCode errorCode_;

		// Token: 0x04004DB0 RID: 19888
		public const int HonamiStoryActivityInfoFieldNumber = 2;

		// Token: 0x04004DB1 RID: 19889
		private HonamiStoryActivityInfo honamiStoryActivityInfo_;
	}
}
