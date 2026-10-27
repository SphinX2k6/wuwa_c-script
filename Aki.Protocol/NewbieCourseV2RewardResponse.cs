using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B0E RID: 2830
	[NetMessage(EMessageId.NewbieCourseV2RewardResponse)]
	public sealed class NewbieCourseV2RewardResponse : IMessage<NewbieCourseV2RewardResponse>, IMessage, IEquatable<NewbieCourseV2RewardResponse>, IDeepCloneable<NewbieCourseV2RewardResponse>, IBufferMessage
	{
		// Token: 0x0600F5D4 RID: 62932 RVA: 0x0023DC3C File Offset: 0x0023BE3C
		[NullableContext(1)]
		public static NewbieCourseV2RewardResponse Create()
		{
			return new NewbieCourseV2RewardResponse();
		}

		// Token: 0x17003210 RID: 12816
		// (get) Token: 0x0600F5D5 RID: 62933 RVA: 0x0023DC43 File Offset: 0x0023BE43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003211 RID: 12817
		// (get) Token: 0x0600F5D6 RID: 62934 RVA: 0x0023DC46 File Offset: 0x0023BE46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieCourseV2RewardResponse.Descriptor;
			}
		}

		// Token: 0x0600F5D7 RID: 62935 RVA: 0x0023DC4D File Offset: 0x0023BE4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCourseV2RewardResponse()
		{
		}

		// Token: 0x0600F5D8 RID: 62936 RVA: 0x0023DC55 File Offset: 0x0023BE55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCourseV2RewardResponse(NewbieCourseV2RewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F5D9 RID: 62937 RVA: 0x0023DC7A File Offset: 0x0023BE7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCourseV2RewardResponse Clone()
		{
			return new NewbieCourseV2RewardResponse(this);
		}

		// Token: 0x17003212 RID: 12818
		// (get) Token: 0x0600F5DA RID: 62938 RVA: 0x0023DC82 File Offset: 0x0023BE82
		// (set) Token: 0x0600F5DB RID: 62939 RVA: 0x0023DC8A File Offset: 0x0023BE8A
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

		// Token: 0x0600F5DC RID: 62940 RVA: 0x0023DC93 File Offset: 0x0023BE93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieCourseV2RewardResponse);
		}

		// Token: 0x0600F5DD RID: 62941 RVA: 0x0023DCA1 File Offset: 0x0023BEA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieCourseV2RewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F5DE RID: 62942 RVA: 0x0023DCD0 File Offset: 0x0023BED0
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

		// Token: 0x0600F5DF RID: 62943 RVA: 0x0023DD15 File Offset: 0x0023BF15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F5E0 RID: 62944 RVA: 0x0023DD22 File Offset: 0x0023BF22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F5E1 RID: 62945 RVA: 0x0023DD2B File Offset: 0x0023BF2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F5E2 RID: 62946 RVA: 0x0023DD60 File Offset: 0x0023BF60
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

		// Token: 0x0600F5E3 RID: 62947 RVA: 0x0023DD9E File Offset: 0x0023BF9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieCourseV2RewardResponse other)
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

		// Token: 0x0600F5E4 RID: 62948 RVA: 0x0023DDCF File Offset: 0x0023BFCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F5E5 RID: 62949 RVA: 0x0023DDD8 File Offset: 0x0023BFD8
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040062CC RID: 25292
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062CD RID: 25293
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x040062CE RID: 25294
		private ErrorCode errorCode_;
	}
}
