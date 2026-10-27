using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200127B RID: 4731
	[NetMessage(EMessageId.SpringFestivalTaskRewardResponse)]
	public sealed class SpringFestivalTaskRewardResponse : IMessage<SpringFestivalTaskRewardResponse>, IMessage, IEquatable<SpringFestivalTaskRewardResponse>, IDeepCloneable<SpringFestivalTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x06019334 RID: 103220 RVA: 0x003AA974 File Offset: 0x003A8B74
		[NullableContext(1)]
		public static SpringFestivalTaskRewardResponse Create()
		{
			return new SpringFestivalTaskRewardResponse();
		}

		// Token: 0x17005505 RID: 21765
		// (get) Token: 0x06019335 RID: 103221 RVA: 0x003AA97B File Offset: 0x003A8B7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005506 RID: 21766
		// (get) Token: 0x06019336 RID: 103222 RVA: 0x003AA97E File Offset: 0x003A8B7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringFestivalTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x06019337 RID: 103223 RVA: 0x003AA985 File Offset: 0x003A8B85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalTaskRewardResponse()
		{
		}

		// Token: 0x06019338 RID: 103224 RVA: 0x003AA98D File Offset: 0x003A8B8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalTaskRewardResponse(SpringFestivalTaskRewardResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019339 RID: 103225 RVA: 0x003AA9B2 File Offset: 0x003A8BB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalTaskRewardResponse Clone()
		{
			return new SpringFestivalTaskRewardResponse(this);
		}

		// Token: 0x17005507 RID: 21767
		// (get) Token: 0x0601933A RID: 103226 RVA: 0x003AA9BA File Offset: 0x003A8BBA
		// (set) Token: 0x0601933B RID: 103227 RVA: 0x003AA9C2 File Offset: 0x003A8BC2
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

		// Token: 0x0601933C RID: 103228 RVA: 0x003AA9CB File Offset: 0x003A8BCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringFestivalTaskRewardResponse);
		}

		// Token: 0x0601933D RID: 103229 RVA: 0x003AA9D9 File Offset: 0x003A8BD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringFestivalTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601933E RID: 103230 RVA: 0x003AAA08 File Offset: 0x003A8C08
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

		// Token: 0x0601933F RID: 103231 RVA: 0x003AAA4D File Offset: 0x003A8C4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019340 RID: 103232 RVA: 0x003AAA5A File Offset: 0x003A8C5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019341 RID: 103233 RVA: 0x003AAA63 File Offset: 0x003A8C63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019342 RID: 103234 RVA: 0x003AAA98 File Offset: 0x003A8C98
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

		// Token: 0x06019343 RID: 103235 RVA: 0x003AAAD6 File Offset: 0x003A8CD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringFestivalTaskRewardResponse other)
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

		// Token: 0x06019344 RID: 103236 RVA: 0x003AAB07 File Offset: 0x003A8D07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019345 RID: 103237 RVA: 0x003AAB10 File Offset: 0x003A8D10
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009458 RID: 37976
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009459 RID: 37977
		public const int ErrCodeFieldNumber = 15;

		// Token: 0x0400945A RID: 37978
		private ErrorCode errCode_;
	}
}
