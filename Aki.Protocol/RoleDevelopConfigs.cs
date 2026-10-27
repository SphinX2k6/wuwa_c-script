using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001066 RID: 4198
	public sealed class RoleDevelopConfigs : IMessage<RoleDevelopConfigs>, IMessage, IEquatable<RoleDevelopConfigs>, IDeepCloneable<RoleDevelopConfigs>, IBufferMessage
	{
		// Token: 0x060166D4 RID: 91860 RVA: 0x00342277 File Offset: 0x00340477
		[NullableContext(1)]
		public static RoleDevelopConfigs Create()
		{
			return new RoleDevelopConfigs();
		}

		// Token: 0x17004B07 RID: 19207
		// (get) Token: 0x060166D5 RID: 91861 RVA: 0x0034227E File Offset: 0x0034047E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B08 RID: 19208
		// (get) Token: 0x060166D6 RID: 91862 RVA: 0x00342281 File Offset: 0x00340481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleDevelopConfigs.Descriptor;
			}
		}

		// Token: 0x060166D7 RID: 91863 RVA: 0x00342288 File Offset: 0x00340488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDevelopConfigs()
		{
		}

		// Token: 0x060166D8 RID: 91864 RVA: 0x003422B4 File Offset: 0x003404B4
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

		// Token: 0x060166D9 RID: 91865 RVA: 0x0034232A File Offset: 0x0034052A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDevelopConfigs Clone()
		{
			return new RoleDevelopConfigs(this);
		}

		// Token: 0x17004B09 RID: 19209
		// (get) Token: 0x060166DA RID: 91866 RVA: 0x00342332 File Offset: 0x00340532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleDevPropsConfig> DevPropsList
		{
			get
			{
				return this.devPropsList_;
			}
		}

		// Token: 0x17004B0A RID: 19210
		// (get) Token: 0x060166DB RID: 91867 RVA: 0x0034233A File Offset: 0x0034053A
		// (set) Token: 0x060166DC RID: 91868 RVA: 0x00342342 File Offset: 0x00340542
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

		// Token: 0x17004B0B RID: 19211
		// (get) Token: 0x060166DD RID: 91869 RVA: 0x0034234B File Offset: 0x0034054B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleDevPropsProjectConfig> DevPropsProjectList
		{
			get
			{
				return this.devPropsProjectList_;
			}
		}

		// Token: 0x17004B0C RID: 19212
		// (get) Token: 0x060166DE RID: 91870 RVA: 0x00342353 File Offset: 0x00340553
		// (set) Token: 0x060166DF RID: 91871 RVA: 0x0034235B File Offset: 0x0034055B
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

		// Token: 0x17004B0D RID: 19213
		// (get) Token: 0x060166E0 RID: 91872 RVA: 0x0034236E File Offset: 0x0034056E
		// (set) Token: 0x060166E1 RID: 91873 RVA: 0x00342376 File Offset: 0x00340576
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

		// Token: 0x17004B0E RID: 19214
		// (get) Token: 0x060166E2 RID: 91874 RVA: 0x0034237F File Offset: 0x0034057F
		// (set) Token: 0x060166E3 RID: 91875 RVA: 0x00342387 File Offset: 0x00340587
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

		// Token: 0x060166E4 RID: 91876 RVA: 0x00342390 File Offset: 0x00340590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleDevelopConfigs);
		}

		// Token: 0x060166E5 RID: 91877 RVA: 0x003423A0 File Offset: 0x003405A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleDevelopConfigs other)
		{
			return other != null && (other == this || (this.devPropsList_.Equals(other.devPropsList_) && this.DevTargetRole == other.DevTargetRole && this.devPropsProjectList_.Equals(other.devPropsProjectList_) && !(this.Version != other.Version) && this.DevTargetPlanId == other.DevTargetPlanId && this.DevTargetFirstPhantomId == other.DevTargetFirstPhantomId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060166E6 RID: 91878 RVA: 0x00342438 File Offset: 0x00340638
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

		// Token: 0x060166E7 RID: 91879 RVA: 0x003424E0 File Offset: 0x003406E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060166E8 RID: 91880 RVA: 0x003424ED File Offset: 0x003406ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060166E9 RID: 91881 RVA: 0x003424F8 File Offset: 0x003406F8
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

		// Token: 0x060166EA RID: 91882 RVA: 0x003425B0 File Offset: 0x003407B0
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

		// Token: 0x060166EB RID: 91883 RVA: 0x00342664 File Offset: 0x00340864
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

		// Token: 0x060166EC RID: 91884 RVA: 0x00342703 File Offset: 0x00340903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060166ED RID: 91885 RVA: 0x0034270C File Offset: 0x0034090C
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

		// Token: 0x04008610 RID: 34320
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008611 RID: 34321
		public const int DevPropsListFieldNumber = 1;

		// Token: 0x04008612 RID: 34322
		private static readonly FieldCodec<RoleDevPropsConfig> _repeated_devPropsList_codec = FieldCodec.ForMessage<RoleDevPropsConfig>(10U, RoleDevPropsConfig.Parser);

		// Token: 0x04008613 RID: 34323
		private readonly RepeatedField<RoleDevPropsConfig> devPropsList_ = new RepeatedField<RoleDevPropsConfig>();

		// Token: 0x04008614 RID: 34324
		public const int DevTargetRoleFieldNumber = 2;

		// Token: 0x04008615 RID: 34325
		private int devTargetRole_;

		// Token: 0x04008616 RID: 34326
		public const int DevPropsProjectListFieldNumber = 3;

		// Token: 0x04008617 RID: 34327
		private static readonly FieldCodec<RoleDevPropsProjectConfig> _repeated_devPropsProjectList_codec = FieldCodec.ForMessage<RoleDevPropsProjectConfig>(26U, RoleDevPropsProjectConfig.Parser);

		// Token: 0x04008618 RID: 34328
		private readonly RepeatedField<RoleDevPropsProjectConfig> devPropsProjectList_ = new RepeatedField<RoleDevPropsProjectConfig>();

		// Token: 0x04008619 RID: 34329
		public const int VersionFieldNumber = 4;

		// Token: 0x0400861A RID: 34330
		private string version_ = "";

		// Token: 0x0400861B RID: 34331
		public const int DevTargetPlanIdFieldNumber = 5;

		// Token: 0x0400861C RID: 34332
		private int devTargetPlanId_;

		// Token: 0x0400861D RID: 34333
		public const int DevTargetFirstPhantomIdFieldNumber = 6;

		// Token: 0x0400861E RID: 34334
		private int devTargetFirstPhantomId_;
	}
}
