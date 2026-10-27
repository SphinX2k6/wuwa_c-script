using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F5D RID: 3933
	public sealed class RiskHarvestInstArtifactInfo : IMessage<RiskHarvestInstArtifactInfo>, IMessage, IEquatable<RiskHarvestInstArtifactInfo>, IDeepCloneable<RiskHarvestInstArtifactInfo>, IBufferMessage
	{
		// Token: 0x0601508D RID: 86157 RVA: 0x0030D138 File Offset: 0x0030B338
		[NullableContext(1)]
		public static RiskHarvestInstArtifactInfo Create()
		{
			return new RiskHarvestInstArtifactInfo();
		}

		// Token: 0x170045F7 RID: 17911
		// (get) Token: 0x0601508E RID: 86158 RVA: 0x0030D13F File Offset: 0x0030B33F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045F8 RID: 17912
		// (get) Token: 0x0601508F RID: 86159 RVA: 0x0030D142 File Offset: 0x0030B342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestInstArtifactInfo.Descriptor;
			}
		}

		// Token: 0x06015090 RID: 86160 RVA: 0x0030D149 File Offset: 0x0030B349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstArtifactInfo()
		{
		}

		// Token: 0x06015091 RID: 86161 RVA: 0x0030D15C File Offset: 0x0030B35C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstArtifactInfo(RiskHarvestInstArtifactInfo other) : this()
		{
			this.id_ = other.id_;
			this.progress_ = other.progress_;
			this.buffs_ = other.buffs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015092 RID: 86162 RVA: 0x0030D1A9 File Offset: 0x0030B3A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstArtifactInfo Clone()
		{
			return new RiskHarvestInstArtifactInfo(this);
		}

		// Token: 0x170045F9 RID: 17913
		// (get) Token: 0x06015093 RID: 86163 RVA: 0x0030D1B1 File Offset: 0x0030B3B1
		// (set) Token: 0x06015094 RID: 86164 RVA: 0x0030D1B9 File Offset: 0x0030B3B9
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

		// Token: 0x170045FA RID: 17914
		// (get) Token: 0x06015095 RID: 86165 RVA: 0x0030D1C2 File Offset: 0x0030B3C2
		// (set) Token: 0x06015096 RID: 86166 RVA: 0x0030D1CA File Offset: 0x0030B3CA
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

		// Token: 0x170045FB RID: 17915
		// (get) Token: 0x06015097 RID: 86167 RVA: 0x0030D1D3 File Offset: 0x0030B3D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RiskHarvestInstBuffInfo> Buffs
		{
			get
			{
				return this.buffs_;
			}
		}

		// Token: 0x06015098 RID: 86168 RVA: 0x0030D1DB File Offset: 0x0030B3DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestInstArtifactInfo);
		}

		// Token: 0x06015099 RID: 86169 RVA: 0x0030D1EC File Offset: 0x0030B3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestInstArtifactInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Progress == other.Progress && this.buffs_.Equals(other.buffs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601509A RID: 86170 RVA: 0x0030D24C File Offset: 0x0030B44C
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

		// Token: 0x0601509B RID: 86171 RVA: 0x0030D2B2 File Offset: 0x0030B4B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601509C RID: 86172 RVA: 0x0030D2BF File Offset: 0x0030B4BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601509D RID: 86173 RVA: 0x0030D2C8 File Offset: 0x0030B4C8
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

		// Token: 0x0601509E RID: 86174 RVA: 0x0030D334 File Offset: 0x0030B534
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

		// Token: 0x0601509F RID: 86175 RVA: 0x0030D3A0 File Offset: 0x0030B5A0
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

		// Token: 0x060150A0 RID: 86176 RVA: 0x0030D401 File Offset: 0x0030B601
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060150A1 RID: 86177 RVA: 0x0030D40C File Offset: 0x0030B60C
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

		// Token: 0x04007EB9 RID: 32441
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007EBA RID: 32442
		public const int IdFieldNumber = 1;

		// Token: 0x04007EBB RID: 32443
		private int id_;

		// Token: 0x04007EBC RID: 32444
		public const int ProgressFieldNumber = 2;

		// Token: 0x04007EBD RID: 32445
		private int progress_;

		// Token: 0x04007EBE RID: 32446
		public const int BuffsFieldNumber = 3;

		// Token: 0x04007EBF RID: 32447
		private static readonly FieldCodec<RiskHarvestInstBuffInfo> _repeated_buffs_codec = FieldCodec.ForMessage<RiskHarvestInstBuffInfo>(26U, RiskHarvestInstBuffInfo.Parser);

		// Token: 0x04007EC0 RID: 32448
		private readonly RepeatedField<RiskHarvestInstBuffInfo> buffs_ = new RepeatedField<RiskHarvestInstBuffInfo>();
	}
}
