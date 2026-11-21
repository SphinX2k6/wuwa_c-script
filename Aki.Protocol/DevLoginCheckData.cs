using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003BD RID: 957
	public sealed class DevLoginCheckData : IMessage<DevLoginCheckData>, IMessage, IEquatable<DevLoginCheckData>, IDeepCloneable<DevLoginCheckData>, IBufferMessage
	{
		// Token: 0x06005DF5 RID: 24053 RVA: 0x000E41C1 File Offset: 0x000E23C1
		[NullableContext(1)]
		public static DevLoginCheckData Create()
		{
			return new DevLoginCheckData();
		}

		// Token: 0x17001172 RID: 4466
		// (get) Token: 0x06005DF6 RID: 24054 RVA: 0x000E41C8 File Offset: 0x000E23C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001173 RID: 4467
		// (get) Token: 0x06005DF7 RID: 24055 RVA: 0x000E41CB File Offset: 0x000E23CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DevLoginCheckData.Descriptor;
			}
		}

		// Token: 0x06005DF8 RID: 24056 RVA: 0x000E41D2 File Offset: 0x000E23D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DevLoginCheckData()
		{
		}

		// Token: 0x06005DF9 RID: 24057 RVA: 0x000E4208 File Offset: 0x000E2408
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

		// Token: 0x06005DFA RID: 24058 RVA: 0x000E4274 File Offset: 0x000E2474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DevLoginCheckData Clone()
		{
			return new DevLoginCheckData(this);
		}

		// Token: 0x17001174 RID: 4468
		// (get) Token: 0x06005DFB RID: 24059 RVA: 0x000E427C File Offset: 0x000E247C
		// (set) Token: 0x06005DFC RID: 24060 RVA: 0x000E4284 File Offset: 0x000E2484
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

		// Token: 0x17001175 RID: 4469
		// (get) Token: 0x06005DFD RID: 24061 RVA: 0x000E428D File Offset: 0x000E248D
		// (set) Token: 0x06005DFE RID: 24062 RVA: 0x000E4295 File Offset: 0x000E2495
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

		// Token: 0x17001176 RID: 4470
		// (get) Token: 0x06005DFF RID: 24063 RVA: 0x000E42A8 File Offset: 0x000E24A8
		// (set) Token: 0x06005E00 RID: 24064 RVA: 0x000E42B0 File Offset: 0x000E24B0
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

		// Token: 0x17001177 RID: 4471
		// (get) Token: 0x06005E01 RID: 24065 RVA: 0x000E42B9 File Offset: 0x000E24B9
		// (set) Token: 0x06005E02 RID: 24066 RVA: 0x000E42C1 File Offset: 0x000E24C1
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

		// Token: 0x17001178 RID: 4472
		// (get) Token: 0x06005E03 RID: 24067 RVA: 0x000E42D4 File Offset: 0x000E24D4
		// (set) Token: 0x06005E04 RID: 24068 RVA: 0x000E42DC File Offset: 0x000E24DC
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

		// Token: 0x17001179 RID: 4473
		// (get) Token: 0x06005E05 RID: 24069 RVA: 0x000E42EF File Offset: 0x000E24EF
		// (set) Token: 0x06005E06 RID: 24070 RVA: 0x000E42F7 File Offset: 0x000E24F7
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

		// Token: 0x06005E07 RID: 24071 RVA: 0x000E430A File Offset: 0x000E250A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DevLoginCheckData);
		}

		// Token: 0x06005E08 RID: 24072 RVA: 0x000E4318 File Offset: 0x000E2518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DevLoginCheckData other)
		{
			return other != null && (other == this || (this.ProtoVersion == other.ProtoVersion && !(this.ProtoMd5 != other.ProtoMd5) && this.ConfigVersion == other.ConfigVersion && !(this.ConfigMd5 != other.ConfigMd5) && !(this.BranchName != other.BranchName) && !(this.ProtoSeedMd5 != other.ProtoSeedMd5) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005E09 RID: 24073 RVA: 0x000E43B8 File Offset: 0x000E25B8
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

		// Token: 0x06005E0A RID: 24074 RVA: 0x000E447C File Offset: 0x000E267C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005E0B RID: 24075 RVA: 0x000E4489 File Offset: 0x000E2689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005E0C RID: 24076 RVA: 0x000E4494 File Offset: 0x000E2694
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

		// Token: 0x06005E0D RID: 24077 RVA: 0x000E4570 File Offset: 0x000E2770
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

		// Token: 0x06005E0E RID: 24078 RVA: 0x000E463C File Offset: 0x000E283C
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

		// Token: 0x06005E0F RID: 24079 RVA: 0x000E46F0 File Offset: 0x000E28F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005E10 RID: 24080 RVA: 0x000E46FC File Offset: 0x000E28FC
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

		// Token: 0x04003710 RID: 14096
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003711 RID: 14097
		public const int ProtoVersionFieldNumber = 1;

		// Token: 0x04003712 RID: 14098
		private int protoVersion_;

		// Token: 0x04003713 RID: 14099
		public const int ProtoMd5FieldNumber = 2;

		// Token: 0x04003714 RID: 14100
		private string protoMd5_ = "";

		// Token: 0x04003715 RID: 14101
		public const int ConfigVersionFieldNumber = 3;

		// Token: 0x04003716 RID: 14102
		private int configVersion_;

		// Token: 0x04003717 RID: 14103
		public const int ConfigMd5FieldNumber = 4;

		// Token: 0x04003718 RID: 14104
		private string configMd5_ = "";

		// Token: 0x04003719 RID: 14105
		public const int BranchNameFieldNumber = 5;

		// Token: 0x0400371A RID: 14106
		private string branchName_ = "";

		// Token: 0x0400371B RID: 14107
		public const int ProtoSeedMd5FieldNumber = 6;

		// Token: 0x0400371C RID: 14108
		private string protoSeedMd5_ = "";
	}
}
