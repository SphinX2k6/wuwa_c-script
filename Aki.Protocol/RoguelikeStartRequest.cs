using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FAB RID: 4011
	[NetMessage(EMessageId.RoguelikeStartRequest)]
	public sealed class RoguelikeStartRequest : IMessage<RoguelikeStartRequest>, IMessage, IEquatable<RoguelikeStartRequest>, IDeepCloneable<RoguelikeStartRequest>, IBufferMessage
	{
		// Token: 0x06015796 RID: 87958 RVA: 0x0031E992 File Offset: 0x0031CB92
		[NullableContext(1)]
		public static RoguelikeStartRequest Create()
		{
			return new RoguelikeStartRequest();
		}

		// Token: 0x1700479E RID: 18334
		// (get) Token: 0x06015797 RID: 87959 RVA: 0x0031E999 File Offset: 0x0031CB99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700479F RID: 18335
		// (get) Token: 0x06015798 RID: 87960 RVA: 0x0031E99C File Offset: 0x0031CB9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeStartRequest.Descriptor;
			}
		}

		// Token: 0x06015799 RID: 87961 RVA: 0x0031E9A3 File Offset: 0x0031CBA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeStartRequest()
		{
		}

		// Token: 0x0601579A RID: 87962 RVA: 0x0031E9B8 File Offset: 0x0031CBB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeStartRequest(RoguelikeStartRequest other) : this()
		{
			this.continueLastProgress_ = other.continueLastProgress_;
			this.instId_ = other.instId_;
			this.roleIds_ = other.roleIds_.Clone();
			this.seasonId_ = other.seasonId_;
			this.selectHotEntryGroupId_ = other.selectHotEntryGroupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601579B RID: 87963 RVA: 0x0031EA1D File Offset: 0x0031CC1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeStartRequest Clone()
		{
			return new RoguelikeStartRequest(this);
		}

		// Token: 0x170047A0 RID: 18336
		// (get) Token: 0x0601579C RID: 87964 RVA: 0x0031EA25 File Offset: 0x0031CC25
		// (set) Token: 0x0601579D RID: 87965 RVA: 0x0031EA2D File Offset: 0x0031CC2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ContinueLastProgress
		{
			get
			{
				return this.continueLastProgress_;
			}
			set
			{
				this.continueLastProgress_ = value;
			}
		}

		// Token: 0x170047A1 RID: 18337
		// (get) Token: 0x0601579E RID: 87966 RVA: 0x0031EA36 File Offset: 0x0031CC36
		// (set) Token: 0x0601579F RID: 87967 RVA: 0x0031EA3E File Offset: 0x0031CC3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x170047A2 RID: 18338
		// (get) Token: 0x060157A0 RID: 87968 RVA: 0x0031EA47 File Offset: 0x0031CC47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x170047A3 RID: 18339
		// (get) Token: 0x060157A1 RID: 87969 RVA: 0x0031EA4F File Offset: 0x0031CC4F
		// (set) Token: 0x060157A2 RID: 87970 RVA: 0x0031EA57 File Offset: 0x0031CC57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SeasonId
		{
			get
			{
				return this.seasonId_;
			}
			set
			{
				this.seasonId_ = value;
			}
		}

		// Token: 0x170047A4 RID: 18340
		// (get) Token: 0x060157A3 RID: 87971 RVA: 0x0031EA60 File Offset: 0x0031CC60
		// (set) Token: 0x060157A4 RID: 87972 RVA: 0x0031EA68 File Offset: 0x0031CC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SelectHotEntryGroupId
		{
			get
			{
				return this.selectHotEntryGroupId_;
			}
			set
			{
				this.selectHotEntryGroupId_ = value;
			}
		}

		// Token: 0x060157A5 RID: 87973 RVA: 0x0031EA71 File Offset: 0x0031CC71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeStartRequest);
		}

		// Token: 0x060157A6 RID: 87974 RVA: 0x0031EA80 File Offset: 0x0031CC80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeStartRequest other)
		{
			return other != null && (other == this || (this.ContinueLastProgress == other.ContinueLastProgress && this.InstId == other.InstId && this.roleIds_.Equals(other.roleIds_) && this.SeasonId == other.SeasonId && this.SelectHotEntryGroupId == other.SelectHotEntryGroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060157A7 RID: 87975 RVA: 0x0031EB00 File Offset: 0x0031CD00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ContinueLastProgress)
			{
				num ^= this.ContinueLastProgress.GetHashCode();
			}
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			num ^= this.roleIds_.GetHashCode();
			if (this.SeasonId != 0)
			{
				num ^= this.SeasonId.GetHashCode();
			}
			if (this.SelectHotEntryGroupId != 0)
			{
				num ^= this.SelectHotEntryGroupId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060157A8 RID: 87976 RVA: 0x0031EB98 File Offset: 0x0031CD98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060157A9 RID: 87977 RVA: 0x0031EBA5 File Offset: 0x0031CDA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060157AA RID: 87978 RVA: 0x0031EBB0 File Offset: 0x0031CDB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SelectHotEntryGroupId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SelectHotEntryGroupId);
			}
			this.roleIds_.WriteTo(ref output, RoguelikeStartRequest._repeated_roleIds_codec);
			if (this.InstId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.InstId);
			}
			if (this.SeasonId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.SeasonId);
			}
			if (this.ContinueLastProgress)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.ContinueLastProgress);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060157AB RID: 87979 RVA: 0x0031EC54 File Offset: 0x0031CE54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ContinueLastProgress)
			{
				num += 2;
			}
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			num += this.roleIds_.CalculateSize(RoguelikeStartRequest._repeated_roleIds_codec);
			if (this.SeasonId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SeasonId);
			}
			if (this.SelectHotEntryGroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SelectHotEntryGroupId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060157AC RID: 87980 RVA: 0x0031ECE4 File Offset: 0x0031CEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeStartRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ContinueLastProgress)
			{
				this.ContinueLastProgress = other.ContinueLastProgress;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this.roleIds_.Add(other.roleIds_);
			if (other.SeasonId != 0)
			{
				this.SeasonId = other.SeasonId;
			}
			if (other.SelectHotEntryGroupId != 0)
			{
				this.SelectHotEntryGroupId = other.SelectHotEntryGroupId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060157AD RID: 87981 RVA: 0x0031ED6D File Offset: 0x0031CF6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060157AE RID: 87982 RVA: 0x0031ED78 File Offset: 0x0031CF78
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
				if (num <= 82U)
				{
					if (num == 24U)
					{
						this.SelectHotEntryGroupId = input.ReadInt32();
						continue;
					}
					if (num == 80U || num == 82U)
					{
						this.roleIds_.AddEntriesFrom(ref input, RoguelikeStartRequest._repeated_roleIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.SeasonId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.ContinueLastProgress = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400818B RID: 33163
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400818C RID: 33164
		public const int ContinueLastProgressFieldNumber = 14;

		// Token: 0x0400818D RID: 33165
		private bool continueLastProgress_;

		// Token: 0x0400818E RID: 33166
		public const int InstIdFieldNumber = 12;

		// Token: 0x0400818F RID: 33167
		private int instId_;

		// Token: 0x04008190 RID: 33168
		public const int RoleIdsFieldNumber = 10;

		// Token: 0x04008191 RID: 33169
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04008192 RID: 33170
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();

		// Token: 0x04008193 RID: 33171
		public const int SeasonIdFieldNumber = 13;

		// Token: 0x04008194 RID: 33172
		private int seasonId_;

		// Token: 0x04008195 RID: 33173
		public const int SelectHotEntryGroupIdFieldNumber = 3;

		// Token: 0x04008196 RID: 33174
		private int selectHotEntryGroupId_;
	}
}
