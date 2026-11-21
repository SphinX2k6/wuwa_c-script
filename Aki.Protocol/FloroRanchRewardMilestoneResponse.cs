using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005C7 RID: 1479
	[NetMessage(EMessageId.FloroRanchRewardMilestoneResponse)]
	public sealed class FloroRanchRewardMilestoneResponse : IMessage<FloroRanchRewardMilestoneResponse>, IMessage, IEquatable<FloroRanchRewardMilestoneResponse>, IDeepCloneable<FloroRanchRewardMilestoneResponse>, IBufferMessage
	{
		// Token: 0x0600895F RID: 35167 RVA: 0x0014CC50 File Offset: 0x0014AE50
		[NullableContext(1)]
		public static FloroRanchRewardMilestoneResponse Create()
		{
			return new FloroRanchRewardMilestoneResponse();
		}

		// Token: 0x17001B11 RID: 6929
		// (get) Token: 0x06008960 RID: 35168 RVA: 0x0014CC57 File Offset: 0x0014AE57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B12 RID: 6930
		// (get) Token: 0x06008961 RID: 35169 RVA: 0x0014CC5A File Offset: 0x0014AE5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchRewardMilestoneResponse.Descriptor;
			}
		}

		// Token: 0x06008962 RID: 35170 RVA: 0x0014CC61 File Offset: 0x0014AE61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchRewardMilestoneResponse()
		{
		}

		// Token: 0x06008963 RID: 35171 RVA: 0x0014CC69 File Offset: 0x0014AE69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchRewardMilestoneResponse(FloroRanchRewardMilestoneResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008964 RID: 35172 RVA: 0x0014CC8E File Offset: 0x0014AE8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchRewardMilestoneResponse Clone()
		{
			return new FloroRanchRewardMilestoneResponse(this);
		}

		// Token: 0x17001B13 RID: 6931
		// (get) Token: 0x06008965 RID: 35173 RVA: 0x0014CC96 File Offset: 0x0014AE96
		// (set) Token: 0x06008966 RID: 35174 RVA: 0x0014CC9E File Offset: 0x0014AE9E
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

		// Token: 0x06008967 RID: 35175 RVA: 0x0014CCA7 File Offset: 0x0014AEA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchRewardMilestoneResponse);
		}

		// Token: 0x06008968 RID: 35176 RVA: 0x0014CCB5 File Offset: 0x0014AEB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchRewardMilestoneResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008969 RID: 35177 RVA: 0x0014CCE4 File Offset: 0x0014AEE4
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

		// Token: 0x0600896A RID: 35178 RVA: 0x0014CD29 File Offset: 0x0014AF29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600896B RID: 35179 RVA: 0x0014CD36 File Offset: 0x0014AF36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600896C RID: 35180 RVA: 0x0014CD3F File Offset: 0x0014AF3F
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

		// Token: 0x0600896D RID: 35181 RVA: 0x0014CD74 File Offset: 0x0014AF74
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

		// Token: 0x0600896E RID: 35182 RVA: 0x0014CDB2 File Offset: 0x0014AFB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchRewardMilestoneResponse other)
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

		// Token: 0x0600896F RID: 35183 RVA: 0x0014CDE3 File Offset: 0x0014AFE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008970 RID: 35184 RVA: 0x0014CDEC File Offset: 0x0014AFEC
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

		// Token: 0x04004413 RID: 17427
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004414 RID: 17428
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04004415 RID: 17429
		private ErrorCode errorCode_;
	}
}
