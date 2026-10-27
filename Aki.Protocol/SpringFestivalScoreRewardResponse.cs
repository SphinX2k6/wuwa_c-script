using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001279 RID: 4729
	[NetMessage(EMessageId.SpringFestivalScoreRewardResponse)]
	public sealed class SpringFestivalScoreRewardResponse : IMessage<SpringFestivalScoreRewardResponse>, IMessage, IEquatable<SpringFestivalScoreRewardResponse>, IDeepCloneable<SpringFestivalScoreRewardResponse>, IBufferMessage
	{
		// Token: 0x0601930E RID: 103182 RVA: 0x003AA4E8 File Offset: 0x003A86E8
		[NullableContext(1)]
		public static SpringFestivalScoreRewardResponse Create()
		{
			return new SpringFestivalScoreRewardResponse();
		}

		// Token: 0x170054FE RID: 21758
		// (get) Token: 0x0601930F RID: 103183 RVA: 0x003AA4EF File Offset: 0x003A86EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054FF RID: 21759
		// (get) Token: 0x06019310 RID: 103184 RVA: 0x003AA4F2 File Offset: 0x003A86F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringFestivalScoreRewardResponse.Descriptor;
			}
		}

		// Token: 0x06019311 RID: 103185 RVA: 0x003AA4F9 File Offset: 0x003A86F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalScoreRewardResponse()
		{
		}

		// Token: 0x06019312 RID: 103186 RVA: 0x003AA501 File Offset: 0x003A8701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalScoreRewardResponse(SpringFestivalScoreRewardResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019313 RID: 103187 RVA: 0x003AA526 File Offset: 0x003A8726
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalScoreRewardResponse Clone()
		{
			return new SpringFestivalScoreRewardResponse(this);
		}

		// Token: 0x17005500 RID: 21760
		// (get) Token: 0x06019314 RID: 103188 RVA: 0x003AA52E File Offset: 0x003A872E
		// (set) Token: 0x06019315 RID: 103189 RVA: 0x003AA536 File Offset: 0x003A8736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x06019316 RID: 103190 RVA: 0x003AA53F File Offset: 0x003A873F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringFestivalScoreRewardResponse);
		}

		// Token: 0x06019317 RID: 103191 RVA: 0x003AA54D File Offset: 0x003A874D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringFestivalScoreRewardResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019318 RID: 103192 RVA: 0x003AA57C File Offset: 0x003A877C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019319 RID: 103193 RVA: 0x003AA5C1 File Offset: 0x003A87C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601931A RID: 103194 RVA: 0x003AA5CE File Offset: 0x003A87CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601931B RID: 103195 RVA: 0x003AA5D7 File Offset: 0x003A87D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601931C RID: 103196 RVA: 0x003AA60C File Offset: 0x003A880C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601931D RID: 103197 RVA: 0x003AA64A File Offset: 0x003A884A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringFestivalScoreRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601931E RID: 103198 RVA: 0x003AA67B File Offset: 0x003A887B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601931F RID: 103199 RVA: 0x003AA684 File Offset: 0x003A8884
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400944F RID: 37967
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009450 RID: 37968
		public const int ErrCodeFieldNumber = 9;

		// Token: 0x04009451 RID: 37969
		private ErrorCode errCode_;
	}
}
