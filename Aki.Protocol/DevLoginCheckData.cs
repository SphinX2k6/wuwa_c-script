using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003D4 RID: 980
	public sealed class DevLoginCheckData : IMessage<DevLoginCheckData>, IMessage, IEquatable<DevLoginCheckData>, IDeepCloneable<DevLoginCheckData>, IBufferMessage
	{
		// Token: 0x06005F85 RID: 24453 RVA: 0x000E7341 File Offset: 0x000E5541
		[NullableContext(1)]
		public static DevLoginCheckData Create()
		{
			return new DevLoginCheckData();
		}

		// Token: 0x170011C7 RID: 4551
		// (get) Token: 0x06005F86 RID: 24454 RVA: 0x000E7348 File Offset: 0x000E5548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011C8 RID: 4552
		// (get) Token: 0x06005F87 RID: 24455 RVA: 0x000E734B File Offset: 0x000E554B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DevLoginCheckData.Descriptor;
			}
		}

		// Token: 0x06005F88 RID: 24456 RVA: 0x000E7352 File Offset: 0x000E5552
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DevLoginCheckData()
		{
		}

		// Token: 0x06005F89 RID: 24457 RVA: 0x000E7388 File Offset: 0x000E5588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DevLoginCheckData(DevLoginCheckData other) : this()
		{
			this.protoVersion_ = other.protoVersion_;
			this.protoMd5_ = other.protoMd5_;
			this.configVersion_ = other.configVersion_;
			this.configMd5_ = other.configMd5_;
			this.branchName_ = other.branchName_;
			this.protoSeedMd5_ = other.protoSeedMd5_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005F8A RID: 24458 RVA: 0x000E73F4 File Offset: 0x000E55F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DevLoginCheckData Clone()
		{
			return new DevLoginCheckData(this);
		}

		// Token: 0x170011C9 RID: 4553
		// (get) Token: 0x06005F8B RID: 24459 RVA: 0x000E73FC File Offset: 0x000E55FC
		// (set) Token: 0x06005F8C RID: 24460 RVA: 0x000E7404 File Offset: 0x000E5604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ProtoVersion
		{
			get
			{
				return this.protoVersion_;
			}
			set
			{
				this.protoVersion_ = value;
			}
		}

		// Token: 0x170011CA RID: 4554
		// (get) Token: 0x06005F8D RID: 24461 RVA: 0x000E740D File Offset: 0x000E560D
		// (set) Token: 0x06005F8E RID: 24462 RVA: 0x000E7415 File Offset: 0x000E5615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ProtoMd5
		{
			get
			{
				return this.protoMd5_;
			}
			set
			{
				this.protoMd5_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170011CB RID: 4555
		// (get) Token: 0x06005F8F RID: 24463 RVA: 0x000E7428 File Offset: 0x000E5628
		// (set) Token: 0x06005F90 RID: 24464 RVA: 0x000E7430 File Offset: 0x000E5630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigVersion
		{
			get
			{
				return this.configVersion_;
			}
			set
			{
				this.configVersion_ = value;
			}
		}

		// Token: 0x170011CC RID: 4556
		// (get) Token: 0x06005F91 RID: 24465 RVA: 0x000E7439 File Offset: 0x000E5639
		// (set) Token: 0x06005F92 RID: 24466 RVA: 0x000E7441 File Offset: 0x000E5641
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ConfigMd5
		{
			get
			{
				return this.configMd5_;
			}
			set
			{
				this.configMd5_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170011CD RID: 4557
		// (get) Token: 0x06005F93 RID: 24467 RVA: 0x000E7454 File Offset: 0x000E5654
		// (set) Token: 0x06005F94 RID: 24468 RVA: 0x000E745C File Offset: 0x000E565C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string BranchName
		{
			get
			{
				return this.branchName_;
			}
			set
			{
				this.branchName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170011CE RID: 4558
		// (get) Token: 0x06005F95 RID: 24469 RVA: 0x000E746F File Offset: 0x000E566F
		// (set) Token: 0x06005F96 RID: 24470 RVA: 0x000E7477 File Offset: 0x000E5677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ProtoSeedMd5
		{
			get
			{
				return this.protoSeedMd5_;
			}
			set
			{
				this.protoSeedMd5_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06005F97 RID: 24471 RVA: 0x000E748A File Offset: 0x000E568A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DevLoginCheckData);
		}

		// Token: 0x06005F98 RID: 24472 RVA: 0x000E7498 File Offset: 0x000E5698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DevLoginCheckData other)
		{
			return other != null && (other == this || (this.ProtoVersion == other.ProtoVersion && !(this.ProtoMd5 != other.ProtoMd5) && this.ConfigVersion == other.ConfigVersion && !(this.ConfigMd5 != other.ConfigMd5) && !(this.BranchName != other.BranchName) && !(this.ProtoSeedMd5 != other.ProtoSeedMd5) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005F99 RID: 24473 RVA: 0x000E7538 File Offset: 0x000E5738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ProtoVersion != 0)
			{
				num ^= this.ProtoVersion.GetHashCode();
			}
			if (this.ProtoMd5.Length != 0)
			{
				num ^= this.ProtoMd5.GetHashCode();
			}
			if (this.ConfigVersion != 0)
			{
				num ^= this.ConfigVersion.GetHashCode();
			}
			if (this.ConfigMd5.Length != 0)
			{
				num ^= this.ConfigMd5.GetHashCode();
			}
			if (this.BranchName.Length != 0)
			{
				num ^= this.BranchName.GetHashCode();
			}
			if (this.ProtoSeedMd5.Length != 0)
			{
				num ^= this.ProtoSeedMd5.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005F9A RID: 24474 RVA: 0x000E75FC File Offset: 0x000E57FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005F9B RID: 24475 RVA: 0x000E7609 File Offset: 0x000E5809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005F9C RID: 24476 RVA: 0x000E7614 File Offset: 0x000E5814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ProtoVersion != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ProtoVersion);
			}
			if (this.ProtoMd5.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.ProtoMd5);
			}
			if (this.ConfigVersion != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ConfigVersion);
			}
			if (this.ConfigMd5.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.ConfigMd5);
			}
			if (this.BranchName.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.BranchName);
			}
			if (this.ProtoSeedMd5.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.ProtoSeedMd5);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005F9D RID: 24477 RVA: 0x000E76F0 File Offset: 0x000E58F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ProtoVersion != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ProtoVersion);
			}
			if (this.ProtoMd5.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ProtoMd5);
			}
			if (this.ConfigVersion != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigVersion);
			}
			if (this.ConfigMd5.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ConfigMd5);
			}
			if (this.BranchName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.BranchName);
			}
			if (this.ProtoSeedMd5.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ProtoSeedMd5);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005F9E RID: 24478 RVA: 0x000E77BC File Offset: 0x000E59BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DevLoginCheckData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ProtoVersion != 0)
			{
				this.ProtoVersion = other.ProtoVersion;
			}
			if (other.ProtoMd5.Length != 0)
			{
				this.ProtoMd5 = other.ProtoMd5;
			}
			if (other.ConfigVersion != 0)
			{
				this.ConfigVersion = other.ConfigVersion;
			}
			if (other.ConfigMd5.Length != 0)
			{
				this.ConfigMd5 = other.ConfigMd5;
			}
			if (other.BranchName.Length != 0)
			{
				this.BranchName = other.BranchName;
			}
			if (other.ProtoSeedMd5.Length != 0)
			{
				this.ProtoSeedMd5 = other.ProtoSeedMd5;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005F9F RID: 24479 RVA: 0x000E7870 File Offset: 0x000E5A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005FA0 RID: 24480 RVA: 0x000E787C File Offset: 0x000E5A7C
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
						this.ProtoVersion = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						this.ProtoMd5 = input.ReadString();
						continue;
					}
					if (num == 24U)
					{
						this.ConfigVersion = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 34U)
					{
						this.ConfigMd5 = input.ReadString();
						continue;
					}
					if (num == 42U)
					{
						this.BranchName = input.ReadString();
						continue;
					}
					if (num == 50U)
					{
						this.ProtoSeedMd5 = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003723 RID: 14115
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003724 RID: 14116
		public const int ProtoVersionFieldNumber = 1;

		// Token: 0x04003725 RID: 14117
		private int protoVersion_;

		// Token: 0x04003726 RID: 14118
		public const int ProtoMd5FieldNumber = 2;

		// Token: 0x04003727 RID: 14119
		private string protoMd5_ = "";

		// Token: 0x04003728 RID: 14120
		public const int ConfigVersionFieldNumber = 3;

		// Token: 0x04003729 RID: 14121
		private int configVersion_;

		// Token: 0x0400372A RID: 14122
		public const int ConfigMd5FieldNumber = 4;

		// Token: 0x0400372B RID: 14123
		private string configMd5_ = "";

		// Token: 0x0400372C RID: 14124
		public const int BranchNameFieldNumber = 5;

		// Token: 0x0400372D RID: 14125
		private string branchName_ = "";

		// Token: 0x0400372E RID: 14126
		public const int ProtoSeedMd5FieldNumber = 6;

		// Token: 0x0400372F RID: 14127
		private string protoSeedMd5_ = "";
	}
}
