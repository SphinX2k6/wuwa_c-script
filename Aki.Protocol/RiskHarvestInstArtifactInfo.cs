using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F4D RID: 3917
	public sealed class RiskHarvestInstArtifactInfo : IMessage<RiskHarvestInstArtifactInfo>, IMessage, IEquatable<RiskHarvestInstArtifactInfo>, IDeepCloneable<RiskHarvestInstArtifactInfo>, IBufferMessage
	{
		// Token: 0x06014FA8 RID: 85928 RVA: 0x0030BA85 File Offset: 0x00309C85
		[NullableContext(1)]
		public static RiskHarvestInstArtifactInfo Create()
		{
			return new RiskHarvestInstArtifactInfo();
		}

		// Token: 0x170045CD RID: 17869
		// (get) Token: 0x06014FA9 RID: 85929 RVA: 0x0030BA8C File Offset: 0x00309C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045CE RID: 17870
		// (get) Token: 0x06014FAA RID: 85930 RVA: 0x0030BA8F File Offset: 0x00309C8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestInstArtifactInfo.Descriptor;
			}
		}

		// Token: 0x06014FAB RID: 85931 RVA: 0x0030BA96 File Offset: 0x00309C96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstArtifactInfo()
		{
		}

		// Token: 0x06014FAC RID: 85932 RVA: 0x0030BAAC File Offset: 0x00309CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstArtifactInfo(RiskHarvestInstArtifactInfo other) : this()
		{
			this.id_ = other.id_;
			this.progress_ = other.progress_;
			this.buffs_ = other.buffs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014FAD RID: 85933 RVA: 0x0030BAF9 File Offset: 0x00309CF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstArtifactInfo Clone()
		{
			return new RiskHarvestInstArtifactInfo(this);
		}

		// Token: 0x170045CF RID: 17871
		// (get) Token: 0x06014FAE RID: 85934 RVA: 0x0030BB01 File Offset: 0x00309D01
		// (set) Token: 0x06014FAF RID: 85935 RVA: 0x0030BB09 File Offset: 0x00309D09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170045D0 RID: 17872
		// (get) Token: 0x06014FB0 RID: 85936 RVA: 0x0030BB12 File Offset: 0x00309D12
		// (set) Token: 0x06014FB1 RID: 85937 RVA: 0x0030BB1A File Offset: 0x00309D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Progress
		{
			get
			{
				return this.progress_;
			}
			set
			{
				this.progress_ = value;
			}
		}

		// Token: 0x170045D1 RID: 17873
		// (get) Token: 0x06014FB2 RID: 85938 RVA: 0x0030BB23 File Offset: 0x00309D23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RiskHarvestInstBuffInfo> Buffs
		{
			get
			{
				return this.buffs_;
			}
		}

		// Token: 0x06014FB3 RID: 85939 RVA: 0x0030BB2B File Offset: 0x00309D2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestInstArtifactInfo);
		}

		// Token: 0x06014FB4 RID: 85940 RVA: 0x0030BB3C File Offset: 0x00309D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestInstArtifactInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Progress == other.Progress && this.buffs_.Equals(other.buffs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014FB5 RID: 85941 RVA: 0x0030BB9C File Offset: 0x00309D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Progress != 0)
			{
				num ^= this.Progress.GetHashCode();
			}
			num ^= this.buffs_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014FB6 RID: 85942 RVA: 0x0030BC02 File Offset: 0x00309E02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014FB7 RID: 85943 RVA: 0x0030BC0F File Offset: 0x00309E0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014FB8 RID: 85944 RVA: 0x0030BC18 File Offset: 0x00309E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Progress != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Progress);
			}
			this.buffs_.WriteTo(ref output, RiskHarvestInstArtifactInfo._repeated_buffs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014FB9 RID: 85945 RVA: 0x0030BC84 File Offset: 0x00309E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Progress != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Progress);
			}
			num += this.buffs_.CalculateSize(RiskHarvestInstArtifactInfo._repeated_buffs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014FBA RID: 85946 RVA: 0x0030BCF0 File Offset: 0x00309EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RiskHarvestInstArtifactInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Progress != 0)
			{
				this.Progress = other.Progress;
			}
			this.buffs_.Add(other.buffs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014FBB RID: 85947 RVA: 0x0030BD51 File Offset: 0x00309F51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014FBC RID: 85948 RVA: 0x0030BD5C File Offset: 0x00309F5C
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.buffs_.AddEntriesFrom(ref input, RiskHarvestInstArtifactInfo._repeated_buffs_codec);
						}
					}
					else
					{
						this.Progress = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007EE3 RID: 32483
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007EE4 RID: 32484
		public const int IdFieldNumber = 1;

		// Token: 0x04007EE5 RID: 32485
		private int id_;

		// Token: 0x04007EE6 RID: 32486
		public const int ProgressFieldNumber = 2;

		// Token: 0x04007EE7 RID: 32487
		private int progress_;

		// Token: 0x04007EE8 RID: 32488
		public const int BuffsFieldNumber = 3;

		// Token: 0x04007EE9 RID: 32489
		private static readonly FieldCodec<RiskHarvestInstBuffInfo> _repeated_buffs_codec = FieldCodec.ForMessage<RiskHarvestInstBuffInfo>(26U, RiskHarvestInstBuffInfo.Parser);

		// Token: 0x04007EEA RID: 32490
		private readonly RepeatedField<RiskHarvestInstBuffInfo> buffs_ = new RepeatedField<RiskHarvestInstBuffInfo>();
	}
}
