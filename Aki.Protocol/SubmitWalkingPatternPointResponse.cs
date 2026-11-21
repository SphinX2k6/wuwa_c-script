using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001317 RID: 4887
	[NetMessage(EMessageId.SubmitWalkingPatternPointResponse)]
	public sealed class SubmitWalkingPatternPointResponse : IMessage<SubmitWalkingPatternPointResponse>, IMessage, IEquatable<SubmitWalkingPatternPointResponse>, IDeepCloneable<SubmitWalkingPatternPointResponse>, IBufferMessage
	{
		// Token: 0x0601A0EC RID: 106732 RVA: 0x003CC501 File Offset: 0x003CA701
		[NullableContext(1)]
		public static SubmitWalkingPatternPointResponse Create()
		{
			return new SubmitWalkingPatternPointResponse();
		}

		// Token: 0x1700583B RID: 22587
		// (get) Token: 0x0601A0ED RID: 106733 RVA: 0x003CC508 File Offset: 0x003CA708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700583C RID: 22588
		// (get) Token: 0x0601A0EE RID: 106734 RVA: 0x003CC50B File Offset: 0x003CA70B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubmitWalkingPatternPointResponse.Descriptor;
			}
		}

		// Token: 0x0601A0EF RID: 106735 RVA: 0x003CC512 File Offset: 0x003CA712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitWalkingPatternPointResponse()
		{
		}

		// Token: 0x0601A0F0 RID: 106736 RVA: 0x003CC51A File Offset: 0x003CA71A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitWalkingPatternPointResponse(SubmitWalkingPatternPointResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A0F1 RID: 106737 RVA: 0x003CC53F File Offset: 0x003CA73F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitWalkingPatternPointResponse Clone()
		{
			return new SubmitWalkingPatternPointResponse(this);
		}

		// Token: 0x1700583D RID: 22589
		// (get) Token: 0x0601A0F2 RID: 106738 RVA: 0x003CC547 File Offset: 0x003CA747
		// (set) Token: 0x0601A0F3 RID: 106739 RVA: 0x003CC54F File Offset: 0x003CA74F
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

		// Token: 0x0601A0F4 RID: 106740 RVA: 0x003CC558 File Offset: 0x003CA758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubmitWalkingPatternPointResponse);
		}

		// Token: 0x0601A0F5 RID: 106741 RVA: 0x003CC566 File Offset: 0x003CA766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SubmitWalkingPatternPointResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A0F6 RID: 106742 RVA: 0x003CC594 File Offset: 0x003CA794
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

		// Token: 0x0601A0F7 RID: 106743 RVA: 0x003CC5D9 File Offset: 0x003CA7D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A0F8 RID: 106744 RVA: 0x003CC5E6 File Offset: 0x003CA7E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A0F9 RID: 106745 RVA: 0x003CC5EF File Offset: 0x003CA7EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A0FA RID: 106746 RVA: 0x003CC624 File Offset: 0x003CA824
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

		// Token: 0x0601A0FB RID: 106747 RVA: 0x003CC662 File Offset: 0x003CA862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SubmitWalkingPatternPointResponse other)
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

		// Token: 0x0601A0FC RID: 106748 RVA: 0x003CC693 File Offset: 0x003CA893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A0FD RID: 106749 RVA: 0x003CC69C File Offset: 0x003CA89C
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400996B RID: 39275
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400996C RID: 39276
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x0400996D RID: 39277
		private ErrorCode errorCode_;
	}
}
