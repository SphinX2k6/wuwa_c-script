using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001043 RID: 4163
	[NetMessage(EMessageId.RogueWhiteCatRecordResponse)]
	public sealed class RogueWhiteCatRecordResponse : IMessage<RogueWhiteCatRecordResponse>, IMessage, IEquatable<RogueWhiteCatRecordResponse>, IDeepCloneable<RogueWhiteCatRecordResponse>, IBufferMessage
	{
		// Token: 0x0601645F RID: 91231 RVA: 0x0033D2EC File Offset: 0x0033B4EC
		[NullableContext(1)]
		public static RogueWhiteCatRecordResponse Create()
		{
			return new RogueWhiteCatRecordResponse();
		}

		// Token: 0x17004A85 RID: 19077
		// (get) Token: 0x06016460 RID: 91232 RVA: 0x0033D2F3 File Offset: 0x0033B4F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A86 RID: 19078
		// (get) Token: 0x06016461 RID: 91233 RVA: 0x0033D2F6 File Offset: 0x0033B4F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWhiteCatRecordResponse.Descriptor;
			}
		}

		// Token: 0x06016462 RID: 91234 RVA: 0x0033D2FD File Offset: 0x0033B4FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatRecordResponse()
		{
		}

		// Token: 0x06016463 RID: 91235 RVA: 0x0033D305 File Offset: 0x0033B505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatRecordResponse(RogueWhiteCatRecordResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016464 RID: 91236 RVA: 0x0033D32A File Offset: 0x0033B52A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatRecordResponse Clone()
		{
			return new RogueWhiteCatRecordResponse(this);
		}

		// Token: 0x17004A87 RID: 19079
		// (get) Token: 0x06016465 RID: 91237 RVA: 0x0033D332 File Offset: 0x0033B532
		// (set) Token: 0x06016466 RID: 91238 RVA: 0x0033D33A File Offset: 0x0033B53A
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

		// Token: 0x06016467 RID: 91239 RVA: 0x0033D343 File Offset: 0x0033B543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWhiteCatRecordResponse);
		}

		// Token: 0x06016468 RID: 91240 RVA: 0x0033D351 File Offset: 0x0033B551
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWhiteCatRecordResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016469 RID: 91241 RVA: 0x0033D380 File Offset: 0x0033B580
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

		// Token: 0x0601646A RID: 91242 RVA: 0x0033D3C5 File Offset: 0x0033B5C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601646B RID: 91243 RVA: 0x0033D3D2 File Offset: 0x0033B5D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601646C RID: 91244 RVA: 0x0033D3DB File Offset: 0x0033B5DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601646D RID: 91245 RVA: 0x0033D410 File Offset: 0x0033B610
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

		// Token: 0x0601646E RID: 91246 RVA: 0x0033D44E File Offset: 0x0033B64E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWhiteCatRecordResponse other)
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

		// Token: 0x0601646F RID: 91247 RVA: 0x0033D47F File Offset: 0x0033B67F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016470 RID: 91248 RVA: 0x0033D488 File Offset: 0x0033B688
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040085BB RID: 34235
		private UnknownFieldSet _unknownFields;

		// Token: 0x040085BC RID: 34236
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x040085BD RID: 34237
		private ErrorCode errorCode_;
	}
}
