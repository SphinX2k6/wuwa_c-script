using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000EC RID: 236
	[NetMessage(EMessageId.AnimationGameplayTagResponse)]
	public sealed class AnimationGameplayTagResponse : IMessage<AnimationGameplayTagResponse>, IMessage, IEquatable<AnimationGameplayTagResponse>, IDeepCloneable<AnimationGameplayTagResponse>, IBufferMessage
	{
		// Token: 0x06002222 RID: 8738 RVA: 0x0005ADDF File Offset: 0x00058FDF
		[NullableContext(1)]
		public static AnimationGameplayTagResponse Create()
		{
			return new AnimationGameplayTagResponse();
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06002223 RID: 8739 RVA: 0x0005ADE6 File Offset: 0x00058FE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06002224 RID: 8740 RVA: 0x0005ADE9 File Offset: 0x00058FE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimationGameplayTagResponse.Descriptor;
			}
		}

		// Token: 0x06002225 RID: 8741 RVA: 0x0005ADF0 File Offset: 0x00058FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationGameplayTagResponse()
		{
		}

		// Token: 0x06002226 RID: 8742 RVA: 0x0005ADF8 File Offset: 0x00058FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationGameplayTagResponse(AnimationGameplayTagResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002227 RID: 8743 RVA: 0x0005AE1D File Offset: 0x0005901D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationGameplayTagResponse Clone()
		{
			return new AnimationGameplayTagResponse(this);
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06002228 RID: 8744 RVA: 0x0005AE25 File Offset: 0x00059025
		// (set) Token: 0x06002229 RID: 8745 RVA: 0x0005AE2D File Offset: 0x0005902D
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

		// Token: 0x0600222A RID: 8746 RVA: 0x0005AE36 File Offset: 0x00059036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimationGameplayTagResponse);
		}

		// Token: 0x0600222B RID: 8747 RVA: 0x0005AE44 File Offset: 0x00059044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimationGameplayTagResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600222C RID: 8748 RVA: 0x0005AE74 File Offset: 0x00059074
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

		// Token: 0x0600222D RID: 8749 RVA: 0x0005AEB9 File Offset: 0x000590B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600222E RID: 8750 RVA: 0x0005AEC6 File Offset: 0x000590C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600222F RID: 8751 RVA: 0x0005AECF File Offset: 0x000590CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
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

		// Token: 0x06002230 RID: 8752 RVA: 0x0005AF04 File Offset: 0x00059104
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

		// Token: 0x06002231 RID: 8753 RVA: 0x0005AF42 File Offset: 0x00059142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AnimationGameplayTagResponse other)
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

		// Token: 0x06002232 RID: 8754 RVA: 0x0005AF73 File Offset: 0x00059173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002233 RID: 8755 RVA: 0x0005AF7C File Offset: 0x0005917C
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002463 RID: 9315
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002464 RID: 9316
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04002465 RID: 9317
		private ErrorCode errorCode_;
	}
}
