using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200020E RID: 526
	[NetMessage(EMessageId.BuildingLevelUpResponse)]
	public sealed class BuildingLevelUpResponse : IMessage<BuildingLevelUpResponse>, IMessage, IEquatable<BuildingLevelUpResponse>, IDeepCloneable<BuildingLevelUpResponse>, IBufferMessage
	{
		// Token: 0x060039F1 RID: 14833 RVA: 0x000907D8 File Offset: 0x0008E9D8
		[NullableContext(1)]
		public static BuildingLevelUpResponse Create()
		{
			return new BuildingLevelUpResponse();
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x060039F2 RID: 14834 RVA: 0x000907DF File Offset: 0x0008E9DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x060039F3 RID: 14835 RVA: 0x000907E2 File Offset: 0x0008E9E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuildingLevelUpResponse.Descriptor;
			}
		}

		// Token: 0x060039F4 RID: 14836 RVA: 0x000907E9 File Offset: 0x0008E9E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuildingLevelUpResponse()
		{
		}

		// Token: 0x060039F5 RID: 14837 RVA: 0x000907F4 File Offset: 0x0008E9F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuildingLevelUpResponse(BuildingLevelUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.buildingInfo_ = ((other.buildingInfo_ != null) ? other.buildingInfo_.Clone() : null);
			this.peopleLike_ = other.peopleLike_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060039F6 RID: 14838 RVA: 0x0009084C File Offset: 0x0008EA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuildingLevelUpResponse Clone()
		{
			return new BuildingLevelUpResponse(this);
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x060039F7 RID: 14839 RVA: 0x00090854 File Offset: 0x0008EA54
		// (set) Token: 0x060039F8 RID: 14840 RVA: 0x0009085C File Offset: 0x0008EA5C
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

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x060039F9 RID: 14841 RVA: 0x00090865 File Offset: 0x0008EA65
		// (set) Token: 0x060039FA RID: 14842 RVA: 0x0009086D File Offset: 0x0008EA6D
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

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x060039FB RID: 14843 RVA: 0x00090876 File Offset: 0x0008EA76
		// (set) Token: 0x060039FC RID: 14844 RVA: 0x0009087E File Offset: 0x0008EA7E
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

		// Token: 0x060039FD RID: 14845 RVA: 0x00090887 File Offset: 0x0008EA87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuildingLevelUpResponse);
		}

		// Token: 0x060039FE RID: 14846 RVA: 0x00090898 File Offset: 0x0008EA98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuildingLevelUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.BuildingInfo, other.BuildingInfo) && this.PeopleLike == other.PeopleLike && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060039FF RID: 14847 RVA: 0x000908F8 File Offset: 0x0008EAF8
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

		// Token: 0x06003A00 RID: 14848 RVA: 0x0009096C File Offset: 0x0008EB6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003A01 RID: 14849 RVA: 0x00090979 File Offset: 0x0008EB79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003A02 RID: 14850 RVA: 0x00090984 File Offset: 0x0008EB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PeopleLike != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.PeopleLike);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.buildingInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.BuildingInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003A03 RID: 14851 RVA: 0x000909FC File Offset: 0x0008EBFC
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

		// Token: 0x06003A04 RID: 14852 RVA: 0x00090A6C File Offset: 0x0008EC6C
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

		// Token: 0x06003A05 RID: 14853 RVA: 0x00090AE8 File Offset: 0x0008ECE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003A06 RID: 14854 RVA: 0x00090AF4 File Offset: 0x0008ECF4
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
				if (num != 48U)
				{
					if (num != 112U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.PeopleLike = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002BB0 RID: 11184
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BB1 RID: 11185
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04002BB2 RID: 11186
		private ErrorCode errorCode_;

		// Token: 0x04002BB3 RID: 11187
		public const int BuildingInfoFieldNumber = 15;

		// Token: 0x04002BB4 RID: 11188
		private BuildingInfo buildingInfo_;

		// Token: 0x04002BB5 RID: 11189
		public const int PeopleLikeFieldNumber = 6;

		// Token: 0x04002BB6 RID: 11190
		private int peopleLike_;
	}
}
