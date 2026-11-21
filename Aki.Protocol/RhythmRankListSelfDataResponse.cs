using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F32 RID: 3890
	[NetMessage(EMessageId.RhythmRankListSelfDataResponse)]
	public sealed class RhythmRankListSelfDataResponse : IMessage<RhythmRankListSelfDataResponse>, IMessage, IEquatable<RhythmRankListSelfDataResponse>, IDeepCloneable<RhythmRankListSelfDataResponse>, IBufferMessage
	{
		// Token: 0x06014D76 RID: 85366 RVA: 0x0030692D File Offset: 0x00304B2D
		[NullableContext(1)]
		public static RhythmRankListSelfDataResponse Create()
		{
			return new RhythmRankListSelfDataResponse();
		}

		// Token: 0x17004551 RID: 17745
		// (get) Token: 0x06014D77 RID: 85367 RVA: 0x00306934 File Offset: 0x00304B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004552 RID: 17746
		// (get) Token: 0x06014D78 RID: 85368 RVA: 0x00306937 File Offset: 0x00304B37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmRankListSelfDataResponse.Descriptor;
			}
		}

		// Token: 0x06014D79 RID: 85369 RVA: 0x0030693E File Offset: 0x00304B3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRankListSelfDataResponse()
		{
		}

		// Token: 0x06014D7A RID: 85370 RVA: 0x00306948 File Offset: 0x00304B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRankListSelfDataResponse(RhythmRankListSelfDataResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.selfData_ = ((other.selfData_ != null) ? other.selfData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014D7B RID: 85371 RVA: 0x00306994 File Offset: 0x00304B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRankListSelfDataResponse Clone()
		{
			return new RhythmRankListSelfDataResponse(this);
		}

		// Token: 0x17004553 RID: 17747
		// (get) Token: 0x06014D7C RID: 85372 RVA: 0x0030699C File Offset: 0x00304B9C
		// (set) Token: 0x06014D7D RID: 85373 RVA: 0x003069A4 File Offset: 0x00304BA4
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

		// Token: 0x17004554 RID: 17748
		// (get) Token: 0x06014D7E RID: 85374 RVA: 0x003069AD File Offset: 0x00304BAD
		// (set) Token: 0x06014D7F RID: 85375 RVA: 0x003069B5 File Offset: 0x00304BB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmPlayerRankingInfo SelfData
		{
			get
			{
				return this.selfData_;
			}
			set
			{
				this.selfData_ = value;
			}
		}

		// Token: 0x06014D80 RID: 85376 RVA: 0x003069BE File Offset: 0x00304BBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmRankListSelfDataResponse);
		}

		// Token: 0x06014D81 RID: 85377 RVA: 0x003069CC File Offset: 0x00304BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmRankListSelfDataResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.SelfData, other.SelfData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014D82 RID: 85378 RVA: 0x00306A1C File Offset: 0x00304C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.selfData_ != null)
			{
				num ^= this.SelfData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014D83 RID: 85379 RVA: 0x00306A77 File Offset: 0x00304C77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014D84 RID: 85380 RVA: 0x00306A84 File Offset: 0x00304C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014D85 RID: 85381 RVA: 0x00306A90 File Offset: 0x00304C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.selfData_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.SelfData);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014D86 RID: 85382 RVA: 0x00306AEC File Offset: 0x00304CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.selfData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SelfData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014D87 RID: 85383 RVA: 0x00306B44 File Offset: 0x00304D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmRankListSelfDataResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.selfData_ != null)
			{
				if (this.selfData_ == null)
				{
					this.SelfData = new RhythmPlayerRankingInfo();
				}
				this.SelfData.MergeFrom(other.SelfData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014D88 RID: 85384 RVA: 0x00306BAC File Offset: 0x00304DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014D89 RID: 85385 RVA: 0x00306BB8 File Offset: 0x00304DB8
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
				if (num != 42U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.selfData_ == null)
					{
						this.SelfData = new RhythmPlayerRankingInfo();
					}
					input.ReadMessage(this.SelfData);
				}
			}
		}

		// Token: 0x04007E2D RID: 32301
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E2E RID: 32302
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04007E2F RID: 32303
		private ErrorCode errorCode_;

		// Token: 0x04007E30 RID: 32304
		public const int SelfDataFieldNumber = 5;

		// Token: 0x04007E31 RID: 32305
		private RhythmPlayerRankingInfo selfData_;
	}
}
