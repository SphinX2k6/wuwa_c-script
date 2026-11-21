using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000273 RID: 627
	[NetMessage(EMessageId.ChapterResultRewardResponse)]
	public sealed class ChapterResultRewardResponse : IMessage<ChapterResultRewardResponse>, IMessage, IEquatable<ChapterResultRewardResponse>, IDeepCloneable<ChapterResultRewardResponse>, IBufferMessage
	{
		// Token: 0x06004242 RID: 16962 RVA: 0x000A3067 File Offset: 0x000A1267
		[NullableContext(1)]
		public static ChapterResultRewardResponse Create()
		{
			return new ChapterResultRewardResponse();
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x06004243 RID: 16963 RVA: 0x000A306E File Offset: 0x000A126E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x06004244 RID: 16964 RVA: 0x000A3071 File Offset: 0x000A1271
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChapterResultRewardResponse.Descriptor;
			}
		}

		// Token: 0x06004245 RID: 16965 RVA: 0x000A3078 File Offset: 0x000A1278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChapterResultRewardResponse()
		{
		}

		// Token: 0x06004246 RID: 16966 RVA: 0x000A3080 File Offset: 0x000A1280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChapterResultRewardResponse(ChapterResultRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004247 RID: 16967 RVA: 0x000A30A5 File Offset: 0x000A12A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChapterResultRewardResponse Clone()
		{
			return new ChapterResultRewardResponse(this);
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x06004248 RID: 16968 RVA: 0x000A30AD File Offset: 0x000A12AD
		// (set) Token: 0x06004249 RID: 16969 RVA: 0x000A30B5 File Offset: 0x000A12B5
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

		// Token: 0x0600424A RID: 16970 RVA: 0x000A30BE File Offset: 0x000A12BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChapterResultRewardResponse);
		}

		// Token: 0x0600424B RID: 16971 RVA: 0x000A30CC File Offset: 0x000A12CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChapterResultRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600424C RID: 16972 RVA: 0x000A30FC File Offset: 0x000A12FC
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

		// Token: 0x0600424D RID: 16973 RVA: 0x000A3141 File Offset: 0x000A1341
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600424E RID: 16974 RVA: 0x000A314E File Offset: 0x000A134E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600424F RID: 16975 RVA: 0x000A3157 File Offset: 0x000A1357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004250 RID: 16976 RVA: 0x000A318C File Offset: 0x000A138C
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

		// Token: 0x06004251 RID: 16977 RVA: 0x000A31CA File Offset: 0x000A13CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChapterResultRewardResponse other)
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

		// Token: 0x06004252 RID: 16978 RVA: 0x000A31FB File Offset: 0x000A13FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004253 RID: 16979 RVA: 0x000A3204 File Offset: 0x000A1404
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002E4E RID: 11854
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E4F RID: 11855
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04002E50 RID: 11856
		private ErrorCode errorCode_;
	}
}
