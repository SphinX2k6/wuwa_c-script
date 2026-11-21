using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F40 RID: 3904
	[NetMessage(EMessageId.RhythmTaskOneKeyRewardResponse)]
	public sealed class RhythmTaskOneKeyRewardResponse : IMessage<RhythmTaskOneKeyRewardResponse>, IMessage, IEquatable<RhythmTaskOneKeyRewardResponse>, IDeepCloneable<RhythmTaskOneKeyRewardResponse>, IBufferMessage
	{
		// Token: 0x06014EAA RID: 85674 RVA: 0x003098A8 File Offset: 0x00307AA8
		[NullableContext(1)]
		public static RhythmTaskOneKeyRewardResponse Create()
		{
			return new RhythmTaskOneKeyRewardResponse();
		}

		// Token: 0x17004599 RID: 17817
		// (get) Token: 0x06014EAB RID: 85675 RVA: 0x003098AF File Offset: 0x00307AAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700459A RID: 17818
		// (get) Token: 0x06014EAC RID: 85676 RVA: 0x003098B2 File Offset: 0x00307AB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmTaskOneKeyRewardResponse.Descriptor;
			}
		}

		// Token: 0x06014EAD RID: 85677 RVA: 0x003098B9 File Offset: 0x00307AB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmTaskOneKeyRewardResponse()
		{
		}

		// Token: 0x06014EAE RID: 85678 RVA: 0x003098C1 File Offset: 0x00307AC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmTaskOneKeyRewardResponse(RhythmTaskOneKeyRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014EAF RID: 85679 RVA: 0x003098E6 File Offset: 0x00307AE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmTaskOneKeyRewardResponse Clone()
		{
			return new RhythmTaskOneKeyRewardResponse(this);
		}

		// Token: 0x1700459B RID: 17819
		// (get) Token: 0x06014EB0 RID: 85680 RVA: 0x003098EE File Offset: 0x00307AEE
		// (set) Token: 0x06014EB1 RID: 85681 RVA: 0x003098F6 File Offset: 0x00307AF6
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

		// Token: 0x06014EB2 RID: 85682 RVA: 0x003098FF File Offset: 0x00307AFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmTaskOneKeyRewardResponse);
		}

		// Token: 0x06014EB3 RID: 85683 RVA: 0x0030990D File Offset: 0x00307B0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmTaskOneKeyRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014EB4 RID: 85684 RVA: 0x0030993C File Offset: 0x00307B3C
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

		// Token: 0x06014EB5 RID: 85685 RVA: 0x00309981 File Offset: 0x00307B81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014EB6 RID: 85686 RVA: 0x0030998E File Offset: 0x00307B8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014EB7 RID: 85687 RVA: 0x00309997 File Offset: 0x00307B97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
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

		// Token: 0x06014EB8 RID: 85688 RVA: 0x003099CC File Offset: 0x00307BCC
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

		// Token: 0x06014EB9 RID: 85689 RVA: 0x00309A0A File Offset: 0x00307C0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmTaskOneKeyRewardResponse other)
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

		// Token: 0x06014EBA RID: 85690 RVA: 0x00309A3B File Offset: 0x00307C3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014EBB RID: 85691 RVA: 0x00309A44 File Offset: 0x00307C44
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007E99 RID: 32409
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E9A RID: 32410
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04007E9B RID: 32411
		private ErrorCode errorCode_;
	}
}
