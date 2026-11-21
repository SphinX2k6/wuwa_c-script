using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010C8 RID: 4296
	public sealed class RoleTowerFloorInfo : IMessage<RoleTowerFloorInfo>, IMessage, IEquatable<RoleTowerFloorInfo>, IDeepCloneable<RoleTowerFloorInfo>, IBufferMessage
	{
		// Token: 0x06016F57 RID: 94039 RVA: 0x0035697D File Offset: 0x00354B7D
		[NullableContext(1)]
		public static RoleTowerFloorInfo Create()
		{
			return new RoleTowerFloorInfo();
		}

		// Token: 0x17004CFE RID: 19710
		// (get) Token: 0x06016F58 RID: 94040 RVA: 0x00356984 File Offset: 0x00354B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleTowerFloorInfo> Parser
		{
			get
			{
				return RoleTowerFloorInfo._parser;
			}
		}

		// Token: 0x17004CFF RID: 19711
		// (get) Token: 0x06016F59 RID: 94041 RVA: 0x0035698B File Offset: 0x00354B8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D00 RID: 19712
		// (get) Token: 0x06016F5A RID: 94042 RVA: 0x0035698E File Offset: 0x00354B8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerFloorInfo.Descriptor;
			}
		}

		// Token: 0x06016F5B RID: 94043 RVA: 0x00356995 File Offset: 0x00354B95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerFloorInfo()
		{
		}

		// Token: 0x06016F5C RID: 94044 RVA: 0x003569A8 File Offset: 0x00354BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerFloorInfo(RoleTowerFloorInfo other) : this()
		{
			this.floorId_ = other.floorId_;
			this.floorType_ = other.floorType_;
			this.hasBranch_ = other.hasBranch_;
			this.branchInfos_ = other.branchInfos_.Clone();
			this.passRemainTimeMs_ = other.passRemainTimeMs_;
			this.isPassed_ = other.isPassed_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016F5D RID: 94045 RVA: 0x00356A19 File Offset: 0x00354C19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerFloorInfo Clone()
		{
			return new RoleTowerFloorInfo(this);
		}

		// Token: 0x17004D01 RID: 19713
		// (get) Token: 0x06016F5E RID: 94046 RVA: 0x00356A21 File Offset: 0x00354C21
		// (set) Token: 0x06016F5F RID: 94047 RVA: 0x00356A29 File Offset: 0x00354C29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FloorId
		{
			get
			{
				return this.floorId_;
			}
			set
			{
				this.floorId_ = value;
			}
		}

		// Token: 0x17004D02 RID: 19714
		// (get) Token: 0x06016F60 RID: 94048 RVA: 0x00356A32 File Offset: 0x00354C32
		// (set) Token: 0x06016F61 RID: 94049 RVA: 0x00356A3A File Offset: 0x00354C3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerFloorType FloorType
		{
			get
			{
				return this.floorType_;
			}
			set
			{
				this.floorType_ = value;
			}
		}

		// Token: 0x17004D03 RID: 19715
		// (get) Token: 0x06016F62 RID: 94050 RVA: 0x00356A43 File Offset: 0x00354C43
		// (set) Token: 0x06016F63 RID: 94051 RVA: 0x00356A4B File Offset: 0x00354C4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasBranch
		{
			get
			{
				return this.hasBranch_;
			}
			set
			{
				this.hasBranch_ = value;
			}
		}

		// Token: 0x17004D04 RID: 19716
		// (get) Token: 0x06016F64 RID: 94052 RVA: 0x00356A54 File Offset: 0x00354C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleTowerFloorBranchInfo> BranchInfos
		{
			get
			{
				return this.branchInfos_;
			}
		}

		// Token: 0x17004D05 RID: 19717
		// (get) Token: 0x06016F65 RID: 94053 RVA: 0x00356A5C File Offset: 0x00354C5C
		// (set) Token: 0x06016F66 RID: 94054 RVA: 0x00356A64 File Offset: 0x00354C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PassRemainTimeMs
		{
			get
			{
				return this.passRemainTimeMs_;
			}
			set
			{
				this.passRemainTimeMs_ = value;
			}
		}

		// Token: 0x17004D06 RID: 19718
		// (get) Token: 0x06016F67 RID: 94055 RVA: 0x00356A6D File Offset: 0x00354C6D
		// (set) Token: 0x06016F68 RID: 94056 RVA: 0x00356A75 File Offset: 0x00354C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsPassed
		{
			get
			{
				return this.isPassed_;
			}
			set
			{
				this.isPassed_ = value;
			}
		}

		// Token: 0x06016F69 RID: 94057 RVA: 0x00356A7E File Offset: 0x00354C7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerFloorInfo);
		}

		// Token: 0x06016F6A RID: 94058 RVA: 0x00356A8C File Offset: 0x00354C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerFloorInfo other)
		{
			return other != null && (other == this || (this.FloorId == other.FloorId && this.FloorType == other.FloorType && this.HasBranch == other.HasBranch && this.branchInfos_.Equals(other.branchInfos_) && this.PassRemainTimeMs == other.PassRemainTimeMs && this.IsPassed == other.IsPassed && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016F6B RID: 94059 RVA: 0x00356B1C File Offset: 0x00354D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FloorId != 0)
			{
				num ^= this.FloorId.GetHashCode();
			}
			if (this.FloorType != RoleTowerFloorType.Normal)
			{
				num ^= this.FloorType.GetHashCode();
			}
			if (this.HasBranch)
			{
				num ^= this.HasBranch.GetHashCode();
			}
			num ^= this.branchInfos_.GetHashCode();
			if (this.PassRemainTimeMs != 0L)
			{
				num ^= this.PassRemainTimeMs.GetHashCode();
			}
			if (this.IsPassed)
			{
				num ^= this.IsPassed.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016F6C RID: 94060 RVA: 0x00356BD4 File Offset: 0x00354DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016F6D RID: 94061 RVA: 0x00356BE1 File Offset: 0x00354DE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016F6E RID: 94062 RVA: 0x00356BEC File Offset: 0x00354DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FloorId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FloorId);
			}
			if (this.FloorType != RoleTowerFloorType.Normal)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.FloorType);
			}
			if (this.HasBranch)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.HasBranch);
			}
			this.branchInfos_.WriteTo(ref output, RoleTowerFloorInfo._repeated_branchInfos_codec);
			if (this.PassRemainTimeMs != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.PassRemainTimeMs);
			}
			if (this.IsPassed)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsPassed);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016F6F RID: 94063 RVA: 0x00356CAC File Offset: 0x00354EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FloorId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FloorId);
			}
			if (this.FloorType != RoleTowerFloorType.Normal)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.FloorType);
			}
			if (this.HasBranch)
			{
				num += 2;
			}
			num += this.branchInfos_.CalculateSize(RoleTowerFloorInfo._repeated_branchInfos_codec);
			if (this.PassRemainTimeMs != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.PassRemainTimeMs);
			}
			if (this.IsPassed)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016F70 RID: 94064 RVA: 0x00356D48 File Offset: 0x00354F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerFloorInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FloorId != 0)
			{
				this.FloorId = other.FloorId;
			}
			if (other.FloorType != RoleTowerFloorType.Normal)
			{
				this.FloorType = other.FloorType;
			}
			if (other.HasBranch)
			{
				this.HasBranch = other.HasBranch;
			}
			this.branchInfos_.Add(other.branchInfos_);
			if (other.PassRemainTimeMs != 0L)
			{
				this.PassRemainTimeMs = other.PassRemainTimeMs;
			}
			if (other.IsPassed)
			{
				this.IsPassed = other.IsPassed;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016F71 RID: 94065 RVA: 0x00356DE5 File Offset: 0x00354FE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016F72 RID: 94066 RVA: 0x00356DF0 File Offset: 0x00354FF0
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.FloorId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.FloorType = (RoleTowerFloorType)input.ReadEnum();
						continue;
					}
					if (num == 24U)
					{
						this.HasBranch = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 34U)
					{
						this.branchInfos_.AddEntriesFrom(ref input, RoleTowerFloorInfo._repeated_branchInfos_codec);
						continue;
					}
					if (num == 48U)
					{
						this.PassRemainTimeMs = input.ReadInt64();
						continue;
					}
					if (num == 56U)
					{
						this.IsPassed = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008961 RID: 35169
		private static readonly MessageParser<RoleTowerFloorInfo> _parser = new MessageParser<RoleTowerFloorInfo>(() => new RoleTowerFloorInfo());

		// Token: 0x04008962 RID: 35170
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008963 RID: 35171
		public const int FloorIdFieldNumber = 1;

		// Token: 0x04008964 RID: 35172
		private int floorId_;

		// Token: 0x04008965 RID: 35173
		public const int FloorTypeFieldNumber = 2;

		// Token: 0x04008966 RID: 35174
		private RoleTowerFloorType floorType_;

		// Token: 0x04008967 RID: 35175
		public const int HasBranchFieldNumber = 3;

		// Token: 0x04008968 RID: 35176
		private bool hasBranch_;

		// Token: 0x04008969 RID: 35177
		public const int BranchInfosFieldNumber = 4;

		// Token: 0x0400896A RID: 35178
		private static readonly FieldCodec<RoleTowerFloorBranchInfo> _repeated_branchInfos_codec = FieldCodec.ForMessage<RoleTowerFloorBranchInfo>(34U, RoleTowerFloorBranchInfo.Parser);

		// Token: 0x0400896B RID: 35179
		private readonly RepeatedField<RoleTowerFloorBranchInfo> branchInfos_ = new RepeatedField<RoleTowerFloorBranchInfo>();

		// Token: 0x0400896C RID: 35180
		public const int PassRemainTimeMsFieldNumber = 6;

		// Token: 0x0400896D RID: 35181
		private long passRemainTimeMs_;

		// Token: 0x0400896E RID: 35182
		public const int IsPassedFieldNumber = 7;

		// Token: 0x0400896F RID: 35183
		private bool isPassed_;
	}
}
