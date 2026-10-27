using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FB8 RID: 4024
	[NetMessage(EMessageId.RoguelikeSeasonDataResponse)]
	public sealed class RoguelikeSeasonDataResponse : IMessage<RoguelikeSeasonDataResponse>, IMessage, IEquatable<RoguelikeSeasonDataResponse>, IDeepCloneable<RoguelikeSeasonDataResponse>, IBufferMessage
	{
		// Token: 0x0601583F RID: 88127 RVA: 0x0031F7E5 File Offset: 0x0031D9E5
		[NullableContext(1)]
		public static RoguelikeSeasonDataResponse Create()
		{
			return new RoguelikeSeasonDataResponse();
		}

		// Token: 0x170047BC RID: 18364
		// (get) Token: 0x06015840 RID: 88128 RVA: 0x0031F7EC File Offset: 0x0031D9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047BD RID: 18365
		// (get) Token: 0x06015841 RID: 88129 RVA: 0x0031F7EF File Offset: 0x0031D9EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeSeasonDataResponse.Descriptor;
			}
		}

		// Token: 0x06015842 RID: 88130 RVA: 0x0031F7F6 File Offset: 0x0031D9F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeSeasonDataResponse()
		{
		}

		// Token: 0x06015843 RID: 88131 RVA: 0x0031F800 File Offset: 0x0031DA00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeSeasonDataResponse(RoguelikeSeasonDataResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.seasonData_ = ((other.seasonData_ != null) ? other.seasonData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015844 RID: 88132 RVA: 0x0031F84C File Offset: 0x0031DA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeSeasonDataResponse Clone()
		{
			return new RoguelikeSeasonDataResponse(this);
		}

		// Token: 0x170047BE RID: 18366
		// (get) Token: 0x06015845 RID: 88133 RVA: 0x0031F854 File Offset: 0x0031DA54
		// (set) Token: 0x06015846 RID: 88134 RVA: 0x0031F85C File Offset: 0x0031DA5C
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

		// Token: 0x170047BF RID: 18367
		// (get) Token: 0x06015847 RID: 88135 RVA: 0x0031F865 File Offset: 0x0031DA65
		// (set) Token: 0x06015848 RID: 88136 RVA: 0x0031F86D File Offset: 0x0031DA6D
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

		// Token: 0x06015849 RID: 88137 RVA: 0x0031F876 File Offset: 0x0031DA76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeSeasonDataResponse);
		}

		// Token: 0x0601584A RID: 88138 RVA: 0x0031F884 File Offset: 0x0031DA84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeSeasonDataResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.SeasonData, other.SeasonData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601584B RID: 88139 RVA: 0x0031F8D4 File Offset: 0x0031DAD4
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

		// Token: 0x0601584C RID: 88140 RVA: 0x0031F92F File Offset: 0x0031DB2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601584D RID: 88141 RVA: 0x0031F93C File Offset: 0x0031DB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601584E RID: 88142 RVA: 0x0031F948 File Offset: 0x0031DB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.seasonData_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.SeasonData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601584F RID: 88143 RVA: 0x0031F9A4 File Offset: 0x0031DBA4
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

		// Token: 0x06015850 RID: 88144 RVA: 0x0031F9FC File Offset: 0x0031DBFC
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

		// Token: 0x06015851 RID: 88145 RVA: 0x0031FA64 File Offset: 0x0031DC64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015852 RID: 88146 RVA: 0x0031FA70 File Offset: 0x0031DC70
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
				if (num != 96U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008150 RID: 33104
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008151 RID: 33105
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04008152 RID: 33106
		private ErrorCode errorCode_;

		// Token: 0x04008153 RID: 33107
		public const int SeasonDataFieldNumber = 15;

		// Token: 0x04008154 RID: 33108
		private SeasonData seasonData_;
	}
}
