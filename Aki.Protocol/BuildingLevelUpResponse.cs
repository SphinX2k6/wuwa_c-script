using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000213 RID: 531
	[NetMessage(EMessageId.BuildingLevelUpResponse)]
	public sealed class BuildingLevelUpResponse : IMessage<BuildingLevelUpResponse>, IMessage, IEquatable<BuildingLevelUpResponse>, IDeepCloneable<BuildingLevelUpResponse>, IBufferMessage
	{
		// Token: 0x06003A96 RID: 14998 RVA: 0x000923ED File Offset: 0x000905ED
		[NullableContext(1)]
		public static BuildingLevelUpResponse Create()
		{
			return new BuildingLevelUpResponse();
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06003A97 RID: 14999 RVA: 0x000923F4 File Offset: 0x000905F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06003A98 RID: 15000 RVA: 0x000923F7 File Offset: 0x000905F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuildingLevelUpResponse.Descriptor;
			}
		}

		// Token: 0x06003A99 RID: 15001 RVA: 0x000923FE File Offset: 0x000905FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuildingLevelUpResponse()
		{
		}

		// Token: 0x06003A9A RID: 15002 RVA: 0x00092408 File Offset: 0x00090608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuildingLevelUpResponse(BuildingLevelUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.buildingInfo_ = ((other.buildingInfo_ != null) ? other.buildingInfo_.Clone() : null);
			this.peopleLike_ = other.peopleLike_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003A9B RID: 15003 RVA: 0x00092460 File Offset: 0x00090660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuildingLevelUpResponse Clone()
		{
			return new BuildingLevelUpResponse(this);
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06003A9C RID: 15004 RVA: 0x00092468 File Offset: 0x00090668
		// (set) Token: 0x06003A9D RID: 15005 RVA: 0x00092470 File Offset: 0x00090670
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

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06003A9E RID: 15006 RVA: 0x00092479 File Offset: 0x00090679
		// (set) Token: 0x06003A9F RID: 15007 RVA: 0x00092481 File Offset: 0x00090681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuildingInfo BuildingInfo
		{
			get
			{
				return this.buildingInfo_;
			}
			set
			{
				this.buildingInfo_ = value;
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06003AA0 RID: 15008 RVA: 0x0009248A File Offset: 0x0009068A
		// (set) Token: 0x06003AA1 RID: 15009 RVA: 0x00092492 File Offset: 0x00090692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PeopleLike
		{
			get
			{
				return this.peopleLike_;
			}
			set
			{
				this.peopleLike_ = value;
			}
		}

		// Token: 0x06003AA2 RID: 15010 RVA: 0x0009249B File Offset: 0x0009069B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuildingLevelUpResponse);
		}

		// Token: 0x06003AA3 RID: 15011 RVA: 0x000924AC File Offset: 0x000906AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuildingLevelUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.BuildingInfo, other.BuildingInfo) && this.PeopleLike == other.PeopleLike && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003AA4 RID: 15012 RVA: 0x0009250C File Offset: 0x0009070C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.buildingInfo_ != null)
			{
				num ^= this.BuildingInfo.GetHashCode();
			}
			if (this.PeopleLike != 0)
			{
				num ^= this.PeopleLike.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003AA5 RID: 15013 RVA: 0x00092580 File Offset: 0x00090780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003AA6 RID: 15014 RVA: 0x0009258D File Offset: 0x0009078D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003AA7 RID: 15015 RVA: 0x00092598 File Offset: 0x00090798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.buildingInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.BuildingInfo);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.PeopleLike != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.PeopleLike);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003AA8 RID: 15016 RVA: 0x00092610 File Offset: 0x00090810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.buildingInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BuildingInfo);
			}
			if (this.PeopleLike != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PeopleLike);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003AA9 RID: 15017 RVA: 0x00092680 File Offset: 0x00090880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuildingLevelUpResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.buildingInfo_ != null)
			{
				if (this.buildingInfo_ == null)
				{
					this.BuildingInfo = new BuildingInfo();
				}
				this.BuildingInfo.MergeFrom(other.BuildingInfo);
			}
			if (other.PeopleLike != 0)
			{
				this.PeopleLike = other.PeopleLike;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003AAA RID: 15018 RVA: 0x000926FC File Offset: 0x000908FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003AAB RID: 15019 RVA: 0x00092708 File Offset: 0x00090908
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
				if (num != 34U)
				{
					if (num != 96U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.PeopleLike = input.ReadInt32();
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.buildingInfo_ == null)
					{
						this.BuildingInfo = new BuildingInfo();
					}
					input.ReadMessage(this.BuildingInfo);
				}
			}
		}

		// Token: 0x04002C32 RID: 11314
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C33 RID: 11315
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04002C34 RID: 11316
		private ErrorCode errorCode_;

		// Token: 0x04002C35 RID: 11317
		public const int BuildingInfoFieldNumber = 4;

		// Token: 0x04002C36 RID: 11318
		private BuildingInfo buildingInfo_;

		// Token: 0x04002C37 RID: 11319
		public const int PeopleLikeFieldNumber = 15;

		// Token: 0x04002C38 RID: 11320
		private int peopleLike_;
	}
}
