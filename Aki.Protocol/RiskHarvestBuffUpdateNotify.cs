using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F4B RID: 3915
	[NetMessage(EMessageId.RiskHarvestBuffUpdateNotify)]
	public sealed class RiskHarvestBuffUpdateNotify : IMessage<RiskHarvestBuffUpdateNotify>, IMessage, IEquatable<RiskHarvestBuffUpdateNotify>, IDeepCloneable<RiskHarvestBuffUpdateNotify>, IBufferMessage
	{
		// Token: 0x06014F77 RID: 85879 RVA: 0x0030B1AD File Offset: 0x003093AD
		[NullableContext(1)]
		public static RiskHarvestBuffUpdateNotify Create()
		{
			return new RiskHarvestBuffUpdateNotify();
		}

		// Token: 0x170045C0 RID: 17856
		// (get) Token: 0x06014F78 RID: 85880 RVA: 0x0030B1B4 File Offset: 0x003093B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045C1 RID: 17857
		// (get) Token: 0x06014F79 RID: 85881 RVA: 0x0030B1B7 File Offset: 0x003093B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestBuffUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06014F7A RID: 85882 RVA: 0x0030B1BE File Offset: 0x003093BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestBuffUpdateNotify()
		{
		}

		// Token: 0x06014F7B RID: 85883 RVA: 0x0030B1DC File Offset: 0x003093DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestBuffUpdateNotify(RiskHarvestBuffUpdateNotify other) : this()
		{
			this.artifactInfo_ = ((other.artifactInfo_ != null) ? other.artifactInfo_.Clone() : null);
			this.addBuffGroups_ = other.addBuffGroups_.Clone();
			this.removeBuffGroups_ = other.removeBuffGroups_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014F7C RID: 85884 RVA: 0x0030B23E File Offset: 0x0030943E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestBuffUpdateNotify Clone()
		{
			return new RiskHarvestBuffUpdateNotify(this);
		}

		// Token: 0x170045C2 RID: 17858
		// (get) Token: 0x06014F7D RID: 85885 RVA: 0x0030B246 File Offset: 0x00309446
		// (set) Token: 0x06014F7E RID: 85886 RVA: 0x0030B24E File Offset: 0x0030944E
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

		// Token: 0x170045C3 RID: 17859
		// (get) Token: 0x06014F7F RID: 85887 RVA: 0x0030B257 File Offset: 0x00309457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> AddBuffGroups
		{
			get
			{
				return this.addBuffGroups_;
			}
		}

		// Token: 0x170045C4 RID: 17860
		// (get) Token: 0x06014F80 RID: 85888 RVA: 0x0030B25F File Offset: 0x0030945F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RemoveBuffGroups
		{
			get
			{
				return this.removeBuffGroups_;
			}
		}

		// Token: 0x06014F81 RID: 85889 RVA: 0x0030B267 File Offset: 0x00309467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestBuffUpdateNotify);
		}

		// Token: 0x06014F82 RID: 85890 RVA: 0x0030B278 File Offset: 0x00309478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestBuffUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ArtifactInfo, other.ArtifactInfo) && this.addBuffGroups_.Equals(other.addBuffGroups_) && this.removeBuffGroups_.Equals(other.removeBuffGroups_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014F83 RID: 85891 RVA: 0x0030B2E0 File Offset: 0x003094E0
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

		// Token: 0x06014F84 RID: 85892 RVA: 0x0030B338 File Offset: 0x00309538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014F85 RID: 85893 RVA: 0x0030B345 File Offset: 0x00309545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014F86 RID: 85894 RVA: 0x0030B350 File Offset: 0x00309550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.removeBuffGroups_.WriteTo(ref output, RiskHarvestBuffUpdateNotify._repeated_removeBuffGroups_codec);
			this.addBuffGroups_.WriteTo(ref output, RiskHarvestBuffUpdateNotify._repeated_addBuffGroups_codec);
			if (this.artifactInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.ArtifactInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014F87 RID: 85895 RVA: 0x0030B3B0 File Offset: 0x003095B0
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

		// Token: 0x06014F88 RID: 85896 RVA: 0x0030B414 File Offset: 0x00309614
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

		// Token: 0x06014F89 RID: 85897 RVA: 0x0030B48A File Offset: 0x0030968A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014F8A RID: 85898 RVA: 0x0030B494 File Offset: 0x00309694
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
				if (num <= 50U)
				{
					if (num == 48U || num == 50U)
					{
						this.removeBuffGroups_.AddEntriesFrom(ref input, RiskHarvestBuffUpdateNotify._repeated_removeBuffGroups_codec);
						continue;
					}
				}
				else
				{
					if (num == 80U || num == 82U)
					{
						this.addBuffGroups_.AddEntriesFrom(ref input, RiskHarvestBuffUpdateNotify._repeated_addBuffGroups_codec);
						continue;
					}
					if (num == 114U)
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

		// Token: 0x04007ECD RID: 32461
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007ECE RID: 32462
		public const int ArtifactInfoFieldNumber = 14;

		// Token: 0x04007ECF RID: 32463
		private RiskHarvestInstArtifactInfo artifactInfo_;

		// Token: 0x04007ED0 RID: 32464
		public const int AddBuffGroupsFieldNumber = 10;

		// Token: 0x04007ED1 RID: 32465
		private static readonly FieldCodec<int> _repeated_addBuffGroups_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04007ED2 RID: 32466
		private readonly RepeatedField<int> addBuffGroups_ = new RepeatedField<int>();

		// Token: 0x04007ED3 RID: 32467
		public const int RemoveBuffGroupsFieldNumber = 6;

		// Token: 0x04007ED4 RID: 32468
		private static readonly FieldCodec<int> _repeated_removeBuffGroups_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04007ED5 RID: 32469
		private readonly RepeatedField<int> removeBuffGroups_ = new RepeatedField<int>();
	}
}
