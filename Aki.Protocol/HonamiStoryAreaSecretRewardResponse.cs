using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000751 RID: 1873
	[NetMessage(EMessageId.HonamiStoryAreaSecretRewardResponse)]
	public sealed class HonamiStoryAreaSecretRewardResponse : IMessage<HonamiStoryAreaSecretRewardResponse>, IMessage, IEquatable<HonamiStoryAreaSecretRewardResponse>, IDeepCloneable<HonamiStoryAreaSecretRewardResponse>, IBufferMessage
	{
		// Token: 0x0600A9F5 RID: 43509 RVA: 0x0019992D File Offset: 0x00197B2D
		[NullableContext(1)]
		public static HonamiStoryAreaSecretRewardResponse Create()
		{
			return new HonamiStoryAreaSecretRewardResponse();
		}

		// Token: 0x1700223C RID: 8764
		// (get) Token: 0x0600A9F6 RID: 43510 RVA: 0x00199934 File Offset: 0x00197B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700223D RID: 8765
		// (get) Token: 0x0600A9F7 RID: 43511 RVA: 0x00199937 File Offset: 0x00197B37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryAreaSecretRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600A9F8 RID: 43512 RVA: 0x0019993E File Offset: 0x00197B3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAreaSecretRewardResponse()
		{
		}

		// Token: 0x0600A9F9 RID: 43513 RVA: 0x00199946 File Offset: 0x00197B46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAreaSecretRewardResponse(HonamiStoryAreaSecretRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A9FA RID: 43514 RVA: 0x0019996B File Offset: 0x00197B6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAreaSecretRewardResponse Clone()
		{
			return new HonamiStoryAreaSecretRewardResponse(this);
		}

		// Token: 0x1700223E RID: 8766
		// (get) Token: 0x0600A9FB RID: 43515 RVA: 0x00199973 File Offset: 0x00197B73
		// (set) Token: 0x0600A9FC RID: 43516 RVA: 0x0019997B File Offset: 0x00197B7B
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

		// Token: 0x0600A9FD RID: 43517 RVA: 0x00199984 File Offset: 0x00197B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryAreaSecretRewardResponse);
		}

		// Token: 0x0600A9FE RID: 43518 RVA: 0x00199992 File Offset: 0x00197B92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryAreaSecretRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A9FF RID: 43519 RVA: 0x001999C0 File Offset: 0x00197BC0
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

		// Token: 0x0600AA00 RID: 43520 RVA: 0x00199A05 File Offset: 0x00197C05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AA01 RID: 43521 RVA: 0x00199A12 File Offset: 0x00197C12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AA02 RID: 43522 RVA: 0x00199A1B File Offset: 0x00197C1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AA03 RID: 43523 RVA: 0x00199A50 File Offset: 0x00197C50
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

		// Token: 0x0600AA04 RID: 43524 RVA: 0x00199A8E File Offset: 0x00197C8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryAreaSecretRewardResponse other)
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

		// Token: 0x0600AA05 RID: 43525 RVA: 0x00199ABF File Offset: 0x00197CBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AA06 RID: 43526 RVA: 0x00199AC8 File Offset: 0x00197CC8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004DC5 RID: 19909
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DC6 RID: 19910
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04004DC7 RID: 19911
		private ErrorCode errorCode_;
	}
}
