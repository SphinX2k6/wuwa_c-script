using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001056 RID: 4182
	public sealed class RoleDevelopConfigs : IMessage<RoleDevelopConfigs>, IMessage, IEquatable<RoleDevelopConfigs>, IDeepCloneable<RoleDevelopConfigs>, IBufferMessage
	{
		// Token: 0x060165EF RID: 91631 RVA: 0x00340BA3 File Offset: 0x0033EDA3
		[NullableContext(1)]
		public static RoleDevelopConfigs Create()
		{
			return new RoleDevelopConfigs();
		}

		// Token: 0x17004ADD RID: 19165
		// (get) Token: 0x060165F0 RID: 91632 RVA: 0x00340BAA File Offset: 0x0033EDAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004ADE RID: 19166
		// (get) Token: 0x060165F1 RID: 91633 RVA: 0x00340BAD File Offset: 0x0033EDAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleDevelopConfigs.Descriptor;
			}
		}

		// Token: 0x060165F2 RID: 91634 RVA: 0x00340BB4 File Offset: 0x0033EDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDevelopConfigs()
		{
		}

		// Token: 0x060165F3 RID: 91635 RVA: 0x00340BE0 File Offset: 0x0033EDE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDevelopConfigs(RoleDevelopConfigs other) : this()
		{
			this.devPropsList_ = other.devPropsList_.Clone();
			this.devTargetRole_ = other.devTargetRole_;
			this.devPropsProjectList_ = other.devPropsProjectList_.Clone();
			this.version_ = other.version_;
			this.devTargetPlanId_ = other.devTargetPlanId_;
			this.devTargetFirstPhantomId_ = other.devTargetFirstPhantomId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060165F4 RID: 91636 RVA: 0x00340C56 File Offset: 0x0033EE56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDevelopConfigs Clone()
		{
			return new RoleDevelopConfigs(this);
		}

		// Token: 0x17004ADF RID: 19167
		// (get) Token: 0x060165F5 RID: 91637 RVA: 0x00340C5E File Offset: 0x0033EE5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleDevPropsConfig> DevPropsList
		{
			get
			{
				return this.devPropsList_;
			}
		}

		// Token: 0x17004AE0 RID: 19168
		// (get) Token: 0x060165F6 RID: 91638 RVA: 0x00340C66 File Offset: 0x0033EE66
		// (set) Token: 0x060165F7 RID: 91639 RVA: 0x00340C6E File Offset: 0x0033EE6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DevTargetRole
		{
			get
			{
				return this.devTargetRole_;
			}
			set
			{
				this.devTargetRole_ = value;
			}
		}

		// Token: 0x17004AE1 RID: 19169
		// (get) Token: 0x060165F8 RID: 91640 RVA: 0x00340C77 File Offset: 0x0033EE77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleDevPropsProjectConfig> DevPropsProjectList
		{
			get
			{
				return this.devPropsProjectList_;
			}
		}

		// Token: 0x17004AE2 RID: 19170
		// (get) Token: 0x060165F9 RID: 91641 RVA: 0x00340C7F File Offset: 0x0033EE7F
		// (set) Token: 0x060165FA RID: 91642 RVA: 0x00340C87 File Offset: 0x0033EE87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Version
		{
			get
			{
				return this.version_;
			}
			set
			{
				this.version_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17004AE3 RID: 19171
		// (get) Token: 0x060165FB RID: 91643 RVA: 0x00340C9A File Offset: 0x0033EE9A
		// (set) Token: 0x060165FC RID: 91644 RVA: 0x00340CA2 File Offset: 0x0033EEA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DevTargetPlanId
		{
			get
			{
				return this.devTargetPlanId_;
			}
			set
			{
				this.devTargetPlanId_ = value;
			}
		}

		// Token: 0x17004AE4 RID: 19172
		// (get) Token: 0x060165FD RID: 91645 RVA: 0x00340CAB File Offset: 0x0033EEAB
		// (set) Token: 0x060165FE RID: 91646 RVA: 0x00340CB3 File Offset: 0x0033EEB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DevTargetFirstPhantomId
		{
			get
			{
				return this.devTargetFirstPhantomId_;
			}
			set
			{
				this.devTargetFirstPhantomId_ = value;
			}
		}

		// Token: 0x060165FF RID: 91647 RVA: 0x00340CBC File Offset: 0x0033EEBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleDevelopConfigs);
		}

		// Token: 0x06016600 RID: 91648 RVA: 0x00340CCC File Offset: 0x0033EECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleDevelopConfigs other)
		{
			return other != null && (other == this || (this.devPropsList_.Equals(other.devPropsList_) && this.DevTargetRole == other.DevTargetRole && this.devPropsProjectList_.Equals(other.devPropsProjectList_) && !(this.Version != other.Version) && this.DevTargetPlanId == other.DevTargetPlanId && this.DevTargetFirstPhantomId == other.DevTargetFirstPhantomId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016601 RID: 91649 RVA: 0x00340D64 File Offset: 0x0033EF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.devPropsList_.GetHashCode();
			if (this.DevTargetRole != 0)
			{
				num ^= this.DevTargetRole.GetHashCode();
			}
			num ^= this.devPropsProjectList_.GetHashCode();
			if (this.Version.Length != 0)
			{
				num ^= this.Version.GetHashCode();
			}
			if (this.DevTargetPlanId != 0)
			{
				num ^= this.DevTargetPlanId.GetHashCode();
			}
			if (this.DevTargetFirstPhantomId != 0)
			{
				num ^= this.DevTargetFirstPhantomId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016602 RID: 91650 RVA: 0x00340E0C File Offset: 0x0033F00C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016603 RID: 91651 RVA: 0x00340E19 File Offset: 0x0033F019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016604 RID: 91652 RVA: 0x00340E24 File Offset: 0x0033F024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.devPropsList_.WriteTo(ref output, RoleDevelopConfigs._repeated_devPropsList_codec);
			if (this.DevTargetRole != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.DevTargetRole);
			}
			this.devPropsProjectList_.WriteTo(ref output, RoleDevelopConfigs._repeated_devPropsProjectList_codec);
			if (this.Version.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Version);
			}
			if (this.DevTargetPlanId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.DevTargetPlanId);
			}
			if (this.DevTargetFirstPhantomId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.DevTargetFirstPhantomId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016605 RID: 91653 RVA: 0x00340EDC File Offset: 0x0033F0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.devPropsList_.CalculateSize(RoleDevelopConfigs._repeated_devPropsList_codec);
			if (this.DevTargetRole != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DevTargetRole);
			}
			num += this.devPropsProjectList_.CalculateSize(RoleDevelopConfigs._repeated_devPropsProjectList_codec);
			if (this.Version.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Version);
			}
			if (this.DevTargetPlanId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DevTargetPlanId);
			}
			if (this.DevTargetFirstPhantomId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DevTargetFirstPhantomId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016606 RID: 91654 RVA: 0x00340F90 File Offset: 0x0033F190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleDevelopConfigs other)
		{
			if (other == null)
			{
				return;
			}
			this.devPropsList_.Add(other.devPropsList_);
			if (other.DevTargetRole != 0)
			{
				this.DevTargetRole = other.DevTargetRole;
			}
			this.devPropsProjectList_.Add(other.devPropsProjectList_);
			if (other.Version.Length != 0)
			{
				this.Version = other.Version;
			}
			if (other.DevTargetPlanId != 0)
			{
				this.DevTargetPlanId = other.DevTargetPlanId;
			}
			if (other.DevTargetFirstPhantomId != 0)
			{
				this.DevTargetFirstPhantomId = other.DevTargetFirstPhantomId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016607 RID: 91655 RVA: 0x0034102F File Offset: 0x0033F22F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016608 RID: 91656 RVA: 0x00341038 File Offset: 0x0033F238
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
				if (num <= 26U)
				{
					if (num == 10U)
					{
						this.devPropsList_.AddEntriesFrom(ref input, RoleDevelopConfigs._repeated_devPropsList_codec);
						continue;
					}
					if (num == 16U)
					{
						this.DevTargetRole = input.ReadInt32();
						continue;
					}
					if (num == 26U)
					{
						this.devPropsProjectList_.AddEntriesFrom(ref input, RoleDevelopConfigs._repeated_devPropsProjectList_codec);
						continue;
					}
				}
				else
				{
					if (num == 34U)
					{
						this.Version = input.ReadString();
						continue;
					}
					if (num == 40U)
					{
						this.DevTargetPlanId = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.DevTargetFirstPhantomId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400863A RID: 34362
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400863B RID: 34363
		public const int DevPropsListFieldNumber = 1;

		// Token: 0x0400863C RID: 34364
		private static readonly FieldCodec<RoleDevPropsConfig> _repeated_devPropsList_codec = FieldCodec.ForMessage<RoleDevPropsConfig>(10U, RoleDevPropsConfig.Parser);

		// Token: 0x0400863D RID: 34365
		private readonly RepeatedField<RoleDevPropsConfig> devPropsList_ = new RepeatedField<RoleDevPropsConfig>();

		// Token: 0x0400863E RID: 34366
		public const int DevTargetRoleFieldNumber = 2;

		// Token: 0x0400863F RID: 34367
		private int devTargetRole_;

		// Token: 0x04008640 RID: 34368
		public const int DevPropsProjectListFieldNumber = 3;

		// Token: 0x04008641 RID: 34369
		private static readonly FieldCodec<RoleDevPropsProjectConfig> _repeated_devPropsProjectList_codec = FieldCodec.ForMessage<RoleDevPropsProjectConfig>(26U, RoleDevPropsProjectConfig.Parser);

		// Token: 0x04008642 RID: 34370
		private readonly RepeatedField<RoleDevPropsProjectConfig> devPropsProjectList_ = new RepeatedField<RoleDevPropsProjectConfig>();

		// Token: 0x04008643 RID: 34371
		public const int VersionFieldNumber = 4;

		// Token: 0x04008644 RID: 34372
		private string version_ = "";

		// Token: 0x04008645 RID: 34373
		public const int DevTargetPlanIdFieldNumber = 5;

		// Token: 0x04008646 RID: 34374
		private int devTargetPlanId_;

		// Token: 0x04008647 RID: 34375
		public const int DevTargetFirstPhantomIdFieldNumber = 6;

		// Token: 0x04008648 RID: 34376
		private int devTargetFirstPhantomId_;
	}
}
