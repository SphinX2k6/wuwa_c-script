using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F50 RID: 3920
	[NetMessage(EMessageId.RhythmTaskOneKeyRewardResponse)]
	public sealed class RhythmTaskOneKeyRewardResponse : IMessage<RhythmTaskOneKeyRewardResponse>, IMessage, IEquatable<RhythmTaskOneKeyRewardResponse>, IDeepCloneable<RhythmTaskOneKeyRewardResponse>, IBufferMessage
	{
		// Token: 0x06014F8F RID: 85903 RVA: 0x0030AF64 File Offset: 0x00309164
		[NullableContext(1)]
		public static RhythmTaskOneKeyRewardResponse Create()
		{
			return new RhythmTaskOneKeyRewardResponse();
		}

		// Token: 0x170045C3 RID: 17859
		// (get) Token: 0x06014F90 RID: 85904 RVA: 0x0030AF6B File Offset: 0x0030916B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045C4 RID: 17860
		// (get) Token: 0x06014F91 RID: 85905 RVA: 0x0030AF6E File Offset: 0x0030916E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmTaskOneKeyRewardResponse.Descriptor;
			}
		}

		// Token: 0x06014F92 RID: 85906 RVA: 0x0030AF75 File Offset: 0x00309175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmTaskOneKeyRewardResponse()
		{
		}

		// Token: 0x06014F93 RID: 85907 RVA: 0x0030AF7D File Offset: 0x0030917D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmTaskOneKeyRewardResponse(RhythmTaskOneKeyRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014F94 RID: 85908 RVA: 0x0030AFA2 File Offset: 0x003091A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmTaskOneKeyRewardResponse Clone()
		{
			return new RhythmTaskOneKeyRewardResponse(this);
		}

		// Token: 0x170045C5 RID: 17861
		// (get) Token: 0x06014F95 RID: 85909 RVA: 0x0030AFAA File Offset: 0x003091AA
		// (set) Token: 0x06014F96 RID: 85910 RVA: 0x0030AFB2 File Offset: 0x003091B2
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

		// Token: 0x06014F97 RID: 85911 RVA: 0x0030AFBB File Offset: 0x003091BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmTaskOneKeyRewardResponse);
		}

		// Token: 0x06014F98 RID: 85912 RVA: 0x0030AFC9 File Offset: 0x003091C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmTaskOneKeyRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014F99 RID: 85913 RVA: 0x0030AFF8 File Offset: 0x003091F8
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

		// Token: 0x06014F9A RID: 85914 RVA: 0x0030B03D File Offset: 0x0030923D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014F9B RID: 85915 RVA: 0x0030B04A File Offset: 0x0030924A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014F9C RID: 85916 RVA: 0x0030B053 File Offset: 0x00309253
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

		// Token: 0x06014F9D RID: 85917 RVA: 0x0030B088 File Offset: 0x00309288
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

		// Token: 0x06014F9E RID: 85918 RVA: 0x0030B0C6 File Offset: 0x003092C6
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

		// Token: 0x06014F9F RID: 85919 RVA: 0x0030B0F7 File Offset: 0x003092F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014FA0 RID: 85920 RVA: 0x0030B100 File Offset: 0x00309300
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

		// Token: 0x04007E6F RID: 32367
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E70 RID: 32368
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04007E71 RID: 32369
		private ErrorCode errorCode_;
	}
}
