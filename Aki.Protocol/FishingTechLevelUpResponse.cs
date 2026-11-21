using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000579 RID: 1401
	[NetMessage(EMessageId.FishingTechLevelUpResponse)]
	public sealed class FishingTechLevelUpResponse : IMessage<FishingTechLevelUpResponse>, IMessage, IEquatable<FishingTechLevelUpResponse>, IDeepCloneable<FishingTechLevelUpResponse>, IBufferMessage
	{
		// Token: 0x0600826C RID: 33388 RVA: 0x0013A9A1 File Offset: 0x00138BA1
		[NullableContext(1)]
		public static FishingTechLevelUpResponse Create()
		{
			return new FishingTechLevelUpResponse();
		}

		// Token: 0x17001962 RID: 6498
		// (get) Token: 0x0600826D RID: 33389 RVA: 0x0013A9A8 File Offset: 0x00138BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001963 RID: 6499
		// (get) Token: 0x0600826E RID: 33390 RVA: 0x0013A9AB File Offset: 0x00138BAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingTechLevelUpResponse.Descriptor;
			}
		}

		// Token: 0x0600826F RID: 33391 RVA: 0x0013A9B2 File Offset: 0x00138BB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTechLevelUpResponse()
		{
		}

		// Token: 0x06008270 RID: 33392 RVA: 0x0013A9BC File Offset: 0x00138BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTechLevelUpResponse(FishingTechLevelUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.fishingTech_ = ((other.fishingTech_ != null) ? other.fishingTech_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008271 RID: 33393 RVA: 0x0013AA08 File Offset: 0x00138C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTechLevelUpResponse Clone()
		{
			return new FishingTechLevelUpResponse(this);
		}

		// Token: 0x17001964 RID: 6500
		// (get) Token: 0x06008272 RID: 33394 RVA: 0x0013AA10 File Offset: 0x00138C10
		// (set) Token: 0x06008273 RID: 33395 RVA: 0x0013AA18 File Offset: 0x00138C18
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

		// Token: 0x17001965 RID: 6501
		// (get) Token: 0x06008274 RID: 33396 RVA: 0x0013AA21 File Offset: 0x00138C21
		// (set) Token: 0x06008275 RID: 33397 RVA: 0x0013AA29 File Offset: 0x00138C29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTechInfo FishingTech
		{
			get
			{
				return this.fishingTech_;
			}
			set
			{
				this.fishingTech_ = value;
			}
		}

		// Token: 0x06008276 RID: 33398 RVA: 0x0013AA32 File Offset: 0x00138C32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingTechLevelUpResponse);
		}

		// Token: 0x06008277 RID: 33399 RVA: 0x0013AA40 File Offset: 0x00138C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingTechLevelUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.FishingTech, other.FishingTech) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008278 RID: 33400 RVA: 0x0013AA90 File Offset: 0x00138C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.fishingTech_ != null)
			{
				num ^= this.FishingTech.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008279 RID: 33401 RVA: 0x0013AAEB File Offset: 0x00138CEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600827A RID: 33402 RVA: 0x0013AAF8 File Offset: 0x00138CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600827B RID: 33403 RVA: 0x0013AB04 File Offset: 0x00138D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.fishingTech_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.FishingTech);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600827C RID: 33404 RVA: 0x0013AB60 File Offset: 0x00138D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.fishingTech_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FishingTech);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600827D RID: 33405 RVA: 0x0013ABB8 File Offset: 0x00138DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingTechLevelUpResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.fishingTech_ != null)
			{
				if (this.fishingTech_ == null)
				{
					this.FishingTech = new FishingTechInfo();
				}
				this.FishingTech.MergeFrom(other.FishingTech);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600827E RID: 33406 RVA: 0x0013AC20 File Offset: 0x00138E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600827F RID: 33407 RVA: 0x0013AC2C File Offset: 0x00138E2C
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
				if (num != 50U)
				{
					if (num != 64U)
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
					if (this.fishingTech_ == null)
					{
						this.FishingTech = new FishingTechInfo();
					}
					input.ReadMessage(this.FishingTech);
				}
			}
		}

		// Token: 0x04004184 RID: 16772
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004185 RID: 16773
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04004186 RID: 16774
		private ErrorCode errorCode_;

		// Token: 0x04004187 RID: 16775
		public const int FishingTechFieldNumber = 6;

		// Token: 0x04004188 RID: 16776
		private FishingTechInfo fishingTech_;
	}
}
