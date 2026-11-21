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
		// Token: 0x06002259 RID: 8793 RVA: 0x0005B8B4 File Offset: 0x00059AB4
		[NullableContext(1)]
		public static AnimationGameplayTagResponse Create()
		{
			return new AnimationGameplayTagResponse();
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x0600225A RID: 8794 RVA: 0x0005B8BB File Offset: 0x00059ABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x0600225B RID: 8795 RVA: 0x0005B8BE File Offset: 0x00059ABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimationGameplayTagResponse.Descriptor;
			}
		}

		// Token: 0x0600225C RID: 8796 RVA: 0x0005B8C5 File Offset: 0x00059AC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationGameplayTagResponse()
		{
		}

		// Token: 0x0600225D RID: 8797 RVA: 0x0005B8CD File Offset: 0x00059ACD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationGameplayTagResponse(AnimationGameplayTagResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600225E RID: 8798 RVA: 0x0005B8F2 File Offset: 0x00059AF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationGameplayTagResponse Clone()
		{
			return new AnimationGameplayTagResponse(this);
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x0600225F RID: 8799 RVA: 0x0005B8FA File Offset: 0x00059AFA
		// (set) Token: 0x06002260 RID: 8800 RVA: 0x0005B902 File Offset: 0x00059B02
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

		// Token: 0x06002261 RID: 8801 RVA: 0x0005B90B File Offset: 0x00059B0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimationGameplayTagResponse);
		}

		// Token: 0x06002262 RID: 8802 RVA: 0x0005B919 File Offset: 0x00059B19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimationGameplayTagResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002263 RID: 8803 RVA: 0x0005B948 File Offset: 0x00059B48
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

		// Token: 0x06002264 RID: 8804 RVA: 0x0005B98D File Offset: 0x00059B8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002265 RID: 8805 RVA: 0x0005B99A File Offset: 0x00059B9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002266 RID: 8806 RVA: 0x0005B9A3 File Offset: 0x00059BA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002267 RID: 8807 RVA: 0x0005B9D4 File Offset: 0x00059BD4
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

		// Token: 0x06002268 RID: 8808 RVA: 0x0005BA12 File Offset: 0x00059C12
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

		// Token: 0x06002269 RID: 8809 RVA: 0x0005BA43 File Offset: 0x00059C43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600226A RID: 8810 RVA: 0x0005BA4C File Offset: 0x00059C4C
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040024C2 RID: 9410
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024C3 RID: 9411
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040024C4 RID: 9412
		private ErrorCode errorCode_;
	}
}
