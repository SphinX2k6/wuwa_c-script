using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F5B RID: 3931
	[NetMessage(EMessageId.RiskHarvestBuffUpdateNotify)]
	public sealed class RiskHarvestBuffUpdateNotify : IMessage<RiskHarvestBuffUpdateNotify>, IMessage, IEquatable<RiskHarvestBuffUpdateNotify>, IDeepCloneable<RiskHarvestBuffUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601505C RID: 86108 RVA: 0x0030C865 File Offset: 0x0030AA65
		[NullableContext(1)]
		public static RiskHarvestBuffUpdateNotify Create()
		{
			return new RiskHarvestBuffUpdateNotify();
		}

		// Token: 0x170045EA RID: 17898
		// (get) Token: 0x0601505D RID: 86109 RVA: 0x0030C86C File Offset: 0x0030AA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045EB RID: 17899
		// (get) Token: 0x0601505E RID: 86110 RVA: 0x0030C86F File Offset: 0x0030AA6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestBuffUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601505F RID: 86111 RVA: 0x0030C876 File Offset: 0x0030AA76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestBuffUpdateNotify()
		{
		}

		// Token: 0x06015060 RID: 86112 RVA: 0x0030C894 File Offset: 0x0030AA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestBuffUpdateNotify(RiskHarvestBuffUpdateNotify other) : this()
		{
			this.artifactInfo_ = ((other.artifactInfo_ != null) ? other.artifactInfo_.Clone() : null);
			this.addBuffGroups_ = other.addBuffGroups_.Clone();
			this.removeBuffGroups_ = other.removeBuffGroups_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015061 RID: 86113 RVA: 0x0030C8F6 File Offset: 0x0030AAF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestBuffUpdateNotify Clone()
		{
			return new RiskHarvestBuffUpdateNotify(this);
		}

		// Token: 0x170045EC RID: 17900
		// (get) Token: 0x06015062 RID: 86114 RVA: 0x0030C8FE File Offset: 0x0030AAFE
		// (set) Token: 0x06015063 RID: 86115 RVA: 0x0030C906 File Offset: 0x0030AB06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstArtifactInfo ArtifactInfo
		{
			get
			{
				return this.artifactInfo_;
			}
			set
			{
				this.artifactInfo_ = value;
			}
		}

		// Token: 0x170045ED RID: 17901
		// (get) Token: 0x06015064 RID: 86116 RVA: 0x0030C90F File Offset: 0x0030AB0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> AddBuffGroups
		{
			get
			{
				return this.addBuffGroups_;
			}
		}

		// Token: 0x170045EE RID: 17902
		// (get) Token: 0x06015065 RID: 86117 RVA: 0x0030C917 File Offset: 0x0030AB17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RemoveBuffGroups
		{
			get
			{
				return this.removeBuffGroups_;
			}
		}

		// Token: 0x06015066 RID: 86118 RVA: 0x0030C91F File Offset: 0x0030AB1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestBuffUpdateNotify);
		}

		// Token: 0x06015067 RID: 86119 RVA: 0x0030C930 File Offset: 0x0030AB30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestBuffUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ArtifactInfo, other.ArtifactInfo) && this.addBuffGroups_.Equals(other.addBuffGroups_) && this.removeBuffGroups_.Equals(other.removeBuffGroups_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015068 RID: 86120 RVA: 0x0030C998 File Offset: 0x0030AB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.artifactInfo_ != null)
			{
				num ^= this.ArtifactInfo.GetHashCode();
			}
			num ^= this.addBuffGroups_.GetHashCode();
			num ^= this.removeBuffGroups_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015069 RID: 86121 RVA: 0x0030C9F0 File Offset: 0x0030ABF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601506A RID: 86122 RVA: 0x0030C9FD File Offset: 0x0030ABFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601506B RID: 86123 RVA: 0x0030CA08 File Offset: 0x0030AC08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.removeBuffGroups_.WriteTo(ref output, RiskHarvestBuffUpdateNotify._repeated_removeBuffGroups_codec);
			this.addBuffGroups_.WriteTo(ref output, RiskHarvestBuffUpdateNotify._repeated_addBuffGroups_codec);
			if (this.artifactInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.ArtifactInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601506C RID: 86124 RVA: 0x0030CA68 File Offset: 0x0030AC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.artifactInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ArtifactInfo);
			}
			num += this.addBuffGroups_.CalculateSize(RiskHarvestBuffUpdateNotify._repeated_addBuffGroups_codec);
			num += this.removeBuffGroups_.CalculateSize(RiskHarvestBuffUpdateNotify._repeated_removeBuffGroups_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601506D RID: 86125 RVA: 0x0030CACC File Offset: 0x0030ACCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RiskHarvestBuffUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.artifactInfo_ != null)
			{
				if (this.artifactInfo_ == null)
				{
					this.ArtifactInfo = new RiskHarvestInstArtifactInfo();
				}
				this.ArtifactInfo.MergeFrom(other.ArtifactInfo);
			}
			this.addBuffGroups_.Add(other.addBuffGroups_);
			this.removeBuffGroups_.Add(other.removeBuffGroups_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601506E RID: 86126 RVA: 0x0030CB42 File Offset: 0x0030AD42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601506F RID: 86127 RVA: 0x0030CB4C File Offset: 0x0030AD4C
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
				if (num <= 18U)
				{
					if (num == 16U || num == 18U)
					{
						this.removeBuffGroups_.AddEntriesFrom(ref input, RiskHarvestBuffUpdateNotify._repeated_removeBuffGroups_codec);
						continue;
					}
				}
				else
				{
					if (num == 40U || num == 42U)
					{
						this.addBuffGroups_.AddEntriesFrom(ref input, RiskHarvestBuffUpdateNotify._repeated_addBuffGroups_codec);
						continue;
					}
					if (num == 90U)
					{
						if (this.artifactInfo_ == null)
						{
							this.ArtifactInfo = new RiskHarvestInstArtifactInfo();
						}
						input.ReadMessage(this.ArtifactInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007EA3 RID: 32419
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007EA4 RID: 32420
		public const int ArtifactInfoFieldNumber = 11;

		// Token: 0x04007EA5 RID: 32421
		private RiskHarvestInstArtifactInfo artifactInfo_;

		// Token: 0x04007EA6 RID: 32422
		public const int AddBuffGroupsFieldNumber = 5;

		// Token: 0x04007EA7 RID: 32423
		private static readonly FieldCodec<int> _repeated_addBuffGroups_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04007EA8 RID: 32424
		private readonly RepeatedField<int> addBuffGroups_ = new RepeatedField<int>();

		// Token: 0x04007EA9 RID: 32425
		public const int RemoveBuffGroupsFieldNumber = 2;

		// Token: 0x04007EAA RID: 32426
		private static readonly FieldCodec<int> _repeated_removeBuffGroups_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04007EAB RID: 32427
		private readonly RepeatedField<int> removeBuffGroups_ = new RepeatedField<int>();
	}
}
