using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FA8 RID: 4008
	[NetMessage(EMessageId.RoguelikeSeasonDataResponse)]
	public sealed class RoguelikeSeasonDataResponse : IMessage<RoguelikeSeasonDataResponse>, IMessage, IEquatable<RoguelikeSeasonDataResponse>, IDeepCloneable<RoguelikeSeasonDataResponse>, IBufferMessage
	{
		// Token: 0x0601575A RID: 87898 RVA: 0x0031E139 File Offset: 0x0031C339
		[NullableContext(1)]
		public static RoguelikeSeasonDataResponse Create()
		{
			return new RoguelikeSeasonDataResponse();
		}

		// Token: 0x17004792 RID: 18322
		// (get) Token: 0x0601575B RID: 87899 RVA: 0x0031E140 File Offset: 0x0031C340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004793 RID: 18323
		// (get) Token: 0x0601575C RID: 87900 RVA: 0x0031E143 File Offset: 0x0031C343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeSeasonDataResponse.Descriptor;
			}
		}

		// Token: 0x0601575D RID: 87901 RVA: 0x0031E14A File Offset: 0x0031C34A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeSeasonDataResponse()
		{
		}

		// Token: 0x0601575E RID: 87902 RVA: 0x0031E154 File Offset: 0x0031C354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeSeasonDataResponse(RoguelikeSeasonDataResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.seasonData_ = ((other.seasonData_ != null) ? other.seasonData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601575F RID: 87903 RVA: 0x0031E1A0 File Offset: 0x0031C3A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeSeasonDataResponse Clone()
		{
			return new RoguelikeSeasonDataResponse(this);
		}

		// Token: 0x17004794 RID: 18324
		// (get) Token: 0x06015760 RID: 87904 RVA: 0x0031E1A8 File Offset: 0x0031C3A8
		// (set) Token: 0x06015761 RID: 87905 RVA: 0x0031E1B0 File Offset: 0x0031C3B0
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

		// Token: 0x17004795 RID: 18325
		// (get) Token: 0x06015762 RID: 87906 RVA: 0x0031E1B9 File Offset: 0x0031C3B9
		// (set) Token: 0x06015763 RID: 87907 RVA: 0x0031E1C1 File Offset: 0x0031C3C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeasonData SeasonData
		{
			get
			{
				return this.seasonData_;
			}
			set
			{
				this.seasonData_ = value;
			}
		}

		// Token: 0x06015764 RID: 87908 RVA: 0x0031E1CA File Offset: 0x0031C3CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeSeasonDataResponse);
		}

		// Token: 0x06015765 RID: 87909 RVA: 0x0031E1D8 File Offset: 0x0031C3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeSeasonDataResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.SeasonData, other.SeasonData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015766 RID: 87910 RVA: 0x0031E228 File Offset: 0x0031C428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.seasonData_ != null)
			{
				num ^= this.SeasonData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015767 RID: 87911 RVA: 0x0031E283 File Offset: 0x0031C483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015768 RID: 87912 RVA: 0x0031E290 File Offset: 0x0031C490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015769 RID: 87913 RVA: 0x0031E29C File Offset: 0x0031C49C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.seasonData_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.SeasonData);
			}
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

		// Token: 0x0601576A RID: 87914 RVA: 0x0031E2F8 File Offset: 0x0031C4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.seasonData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SeasonData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601576B RID: 87915 RVA: 0x0031E350 File Offset: 0x0031C550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeSeasonDataResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.seasonData_ != null)
			{
				if (this.seasonData_ == null)
				{
					this.SeasonData = new SeasonData();
				}
				this.SeasonData.MergeFrom(other.SeasonData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601576C RID: 87916 RVA: 0x0031E3B8 File Offset: 0x0031C5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601576D RID: 87917 RVA: 0x0031E3C4 File Offset: 0x0031C5C4
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
					if (num != 88U)
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
					if (this.seasonData_ == null)
					{
						this.SeasonData = new SeasonData();
					}
					input.ReadMessage(this.SeasonData);
				}
			}
		}

		// Token: 0x0400817A RID: 33146
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400817B RID: 33147
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x0400817C RID: 33148
		private ErrorCode errorCode_;

		// Token: 0x0400817D RID: 33149
		public const int SeasonDataFieldNumber = 5;

		// Token: 0x0400817E RID: 33150
		private SeasonData seasonData_;
	}
}
