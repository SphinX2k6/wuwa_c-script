using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010B9 RID: 4281
	[NetMessage(EMessageId.RoleTowerAttributeQueryResponse)]
	public sealed class RoleTowerAttributeQueryResponse : IMessage<RoleTowerAttributeQueryResponse>, IMessage, IEquatable<RoleTowerAttributeQueryResponse>, IDeepCloneable<RoleTowerAttributeQueryResponse>, IBufferMessage
	{
		// Token: 0x06016DFF RID: 93695 RVA: 0x00352EFA File Offset: 0x003510FA
		[NullableContext(1)]
		public static RoleTowerAttributeQueryResponse Create()
		{
			return new RoleTowerAttributeQueryResponse();
		}

		// Token: 0x17004CA7 RID: 19623
		// (get) Token: 0x06016E00 RID: 93696 RVA: 0x00352F01 File Offset: 0x00351101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CA8 RID: 19624
		// (get) Token: 0x06016E01 RID: 93697 RVA: 0x00352F04 File Offset: 0x00351104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerAttributeQueryResponse.Descriptor;
			}
		}

		// Token: 0x06016E02 RID: 93698 RVA: 0x00352F0B File Offset: 0x0035110B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerAttributeQueryResponse()
		{
		}

		// Token: 0x06016E03 RID: 93699 RVA: 0x00352F20 File Offset: 0x00351120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerAttributeQueryResponse(RoleTowerAttributeQueryResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomLevel_ = other.phantomLevel_;
			this.roleInfos_ = other.roleInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016E04 RID: 93700 RVA: 0x00352F6D File Offset: 0x0035116D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerAttributeQueryResponse Clone()
		{
			return new RoleTowerAttributeQueryResponse(this);
		}

		// Token: 0x17004CA9 RID: 19625
		// (get) Token: 0x06016E05 RID: 93701 RVA: 0x00352F75 File Offset: 0x00351175
		// (set) Token: 0x06016E06 RID: 93702 RVA: 0x00352F7D File Offset: 0x0035117D
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

		// Token: 0x17004CAA RID: 19626
		// (get) Token: 0x06016E07 RID: 93703 RVA: 0x00352F86 File Offset: 0x00351186
		// (set) Token: 0x06016E08 RID: 93704 RVA: 0x00352F8E File Offset: 0x0035118E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PhantomLevel
		{
			get
			{
				return this.phantomLevel_;
			}
			set
			{
				this.phantomLevel_ = value;
			}
		}

		// Token: 0x17004CAB RID: 19627
		// (get) Token: 0x06016E09 RID: 93705 RVA: 0x00352F97 File Offset: 0x00351197
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleTowerRoleAttributeInfo> RoleInfos
		{
			get
			{
				return this.roleInfos_;
			}
		}

		// Token: 0x06016E0A RID: 93706 RVA: 0x00352F9F File Offset: 0x0035119F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerAttributeQueryResponse);
		}

		// Token: 0x06016E0B RID: 93707 RVA: 0x00352FB0 File Offset: 0x003511B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerAttributeQueryResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.PhantomLevel == other.PhantomLevel && this.roleInfos_.Equals(other.roleInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016E0C RID: 93708 RVA: 0x00353010 File Offset: 0x00351210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.PhantomLevel != 0)
			{
				num ^= this.PhantomLevel.GetHashCode();
			}
			num ^= this.roleInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016E0D RID: 93709 RVA: 0x0035307C File Offset: 0x0035127C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016E0E RID: 93710 RVA: 0x00353089 File Offset: 0x00351289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016E0F RID: 93711 RVA: 0x00353094 File Offset: 0x00351294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleInfos_.WriteTo(ref output, RoleTowerAttributeQueryResponse._repeated_roleInfos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.PhantomLevel != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.PhantomLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016E10 RID: 93712 RVA: 0x00353100 File Offset: 0x00351300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.PhantomLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PhantomLevel);
			}
			num += this.roleInfos_.CalculateSize(RoleTowerAttributeQueryResponse._repeated_roleInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016E11 RID: 93713 RVA: 0x0035316C File Offset: 0x0035136C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerAttributeQueryResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.PhantomLevel != 0)
			{
				this.PhantomLevel = other.PhantomLevel;
			}
			this.roleInfos_.Add(other.roleInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016E12 RID: 93714 RVA: 0x003531CD File Offset: 0x003513CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016E13 RID: 93715 RVA: 0x003531D8 File Offset: 0x003513D8
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
				if (num != 66U)
				{
					if (num != 80U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.PhantomLevel = input.ReadInt32();
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.roleInfos_.AddEntriesFrom(ref input, RoleTowerAttributeQueryResponse._repeated_roleInfos_codec);
				}
			}
		}

		// Token: 0x040088D4 RID: 35028
		private UnknownFieldSet _unknownFields;

		// Token: 0x040088D5 RID: 35029
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x040088D6 RID: 35030
		private ErrorCode errorCode_;

		// Token: 0x040088D7 RID: 35031
		public const int PhantomLevelFieldNumber = 13;

		// Token: 0x040088D8 RID: 35032
		private int phantomLevel_;

		// Token: 0x040088D9 RID: 35033
		public const int RoleInfosFieldNumber = 8;

		// Token: 0x040088DA RID: 35034
		private static readonly FieldCodec<RoleTowerRoleAttributeInfo> _repeated_roleInfos_codec = FieldCodec.ForMessage<RoleTowerRoleAttributeInfo>(66U, RoleTowerRoleAttributeInfo.Parser);

		// Token: 0x040088DB RID: 35035
		private readonly RepeatedField<RoleTowerRoleAttributeInfo> roleInfos_ = new RepeatedField<RoleTowerRoleAttributeInfo>();
	}
}
