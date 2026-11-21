using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000758 RID: 1880
	[NetMessage(EMessageId.HonamiStoryBagOperateResponse)]
	public sealed class HonamiStoryBagOperateResponse : IMessage<HonamiStoryBagOperateResponse>, IMessage, IEquatable<HonamiStoryBagOperateResponse>, IDeepCloneable<HonamiStoryBagOperateResponse>, IBufferMessage
	{
		// Token: 0x0600AA80 RID: 43648 RVA: 0x0019AAC8 File Offset: 0x00198CC8
		[NullableContext(1)]
		public static HonamiStoryBagOperateResponse Create()
		{
			return new HonamiStoryBagOperateResponse();
		}

		// Token: 0x17002258 RID: 8792
		// (get) Token: 0x0600AA81 RID: 43649 RVA: 0x0019AACF File Offset: 0x00198CCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002259 RID: 8793
		// (get) Token: 0x0600AA82 RID: 43650 RVA: 0x0019AAD2 File Offset: 0x00198CD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryBagOperateResponse.Descriptor;
			}
		}

		// Token: 0x0600AA83 RID: 43651 RVA: 0x0019AAD9 File Offset: 0x00198CD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagOperateResponse()
		{
		}

		// Token: 0x0600AA84 RID: 43652 RVA: 0x0019AAE1 File Offset: 0x00198CE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagOperateResponse(HonamiStoryBagOperateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AA85 RID: 43653 RVA: 0x0019AB06 File Offset: 0x00198D06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagOperateResponse Clone()
		{
			return new HonamiStoryBagOperateResponse(this);
		}

		// Token: 0x1700225A RID: 8794
		// (get) Token: 0x0600AA86 RID: 43654 RVA: 0x0019AB0E File Offset: 0x00198D0E
		// (set) Token: 0x0600AA87 RID: 43655 RVA: 0x0019AB16 File Offset: 0x00198D16
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

		// Token: 0x0600AA88 RID: 43656 RVA: 0x0019AB1F File Offset: 0x00198D1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryBagOperateResponse);
		}

		// Token: 0x0600AA89 RID: 43657 RVA: 0x0019AB2D File Offset: 0x00198D2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryBagOperateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AA8A RID: 43658 RVA: 0x0019AB5C File Offset: 0x00198D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AA8B RID: 43659 RVA: 0x0019ABA1 File Offset: 0x00198DA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AA8C RID: 43660 RVA: 0x0019ABAE File Offset: 0x00198DAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AA8D RID: 43661 RVA: 0x0019ABB7 File Offset: 0x00198DB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AA8E RID: 43662 RVA: 0x0019ABEC File Offset: 0x00198DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AA8F RID: 43663 RVA: 0x0019AC2A File Offset: 0x00198E2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryBagOperateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AA90 RID: 43664 RVA: 0x0019AC5B File Offset: 0x00198E5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AA91 RID: 43665 RVA: 0x0019AC64 File Offset: 0x00198E64
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004DEB RID: 19947
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DEC RID: 19948
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04004DED RID: 19949
		private ErrorCode errorCode_;
	}
}
