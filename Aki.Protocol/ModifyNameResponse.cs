using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009DC RID: 2524
	[NetMessage(EMessageId.ModifyNameResponse)]
	public sealed class ModifyNameResponse : IMessage<ModifyNameResponse>, IMessage, IEquatable<ModifyNameResponse>, IDeepCloneable<ModifyNameResponse>, IBufferMessage
	{
		// Token: 0x0600DD75 RID: 56693 RVA: 0x002080B1 File Offset: 0x002062B1
		[NullableContext(1)]
		public static ModifyNameResponse Create()
		{
			return new ModifyNameResponse();
		}

		// Token: 0x17002CDD RID: 11485
		// (get) Token: 0x0600DD76 RID: 56694 RVA: 0x002080B8 File Offset: 0x002062B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CDE RID: 11486
		// (get) Token: 0x0600DD77 RID: 56695 RVA: 0x002080BB File Offset: 0x002062BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ModifyNameResponse.Descriptor;
			}
		}

		// Token: 0x0600DD78 RID: 56696 RVA: 0x002080C2 File Offset: 0x002062C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyNameResponse()
		{
		}

		// Token: 0x0600DD79 RID: 56697 RVA: 0x002080E0 File Offset: 0x002062E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyNameResponse(ModifyNameResponse other) : this()
		{
			this.name_ = other.name_;
			this.errorCode_ = other.errorCode_;
			this.lastModifyNameTime_ = other.lastModifyNameTime_;
			this.modifyName_ = other.modifyName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DD7A RID: 56698 RVA: 0x00208134 File Offset: 0x00206334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyNameResponse Clone()
		{
			return new ModifyNameResponse(this);
		}

		// Token: 0x17002CDF RID: 11487
		// (get) Token: 0x0600DD7B RID: 56699 RVA: 0x0020813C File Offset: 0x0020633C
		// (set) Token: 0x0600DD7C RID: 56700 RVA: 0x00208144 File Offset: 0x00206344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002CE0 RID: 11488
		// (get) Token: 0x0600DD7D RID: 56701 RVA: 0x00208157 File Offset: 0x00206357
		// (set) Token: 0x0600DD7E RID: 56702 RVA: 0x0020815F File Offset: 0x0020635F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17002CE1 RID: 11489
		// (get) Token: 0x0600DD7F RID: 56703 RVA: 0x00208168 File Offset: 0x00206368
		// (set) Token: 0x0600DD80 RID: 56704 RVA: 0x00208170 File Offset: 0x00206370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LastModifyNameTime
		{
			get
			{
				return this.lastModifyNameTime_;
			}
			set
			{
				this.lastModifyNameTime_ = value;
			}
		}

		// Token: 0x17002CE2 RID: 11490
		// (get) Token: 0x0600DD81 RID: 56705 RVA: 0x00208179 File Offset: 0x00206379
		// (set) Token: 0x0600DD82 RID: 56706 RVA: 0x00208181 File Offset: 0x00206381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ModifyName
		{
			get
			{
				return this.modifyName_;
			}
			set
			{
				this.modifyName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600DD83 RID: 56707 RVA: 0x00208194 File Offset: 0x00206394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ModifyNameResponse);
		}

		// Token: 0x0600DD84 RID: 56708 RVA: 0x002081A4 File Offset: 0x002063A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ModifyNameResponse other)
		{
			return other != null && (other == this || (!(this.Name != other.Name) && this.ErrorCode == other.ErrorCode && this.LastModifyNameTime == other.LastModifyNameTime && !(this.ModifyName != other.ModifyName) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DD85 RID: 56709 RVA: 0x00208218 File Offset: 0x00206418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.LastModifyNameTime != 0L)
			{
				num ^= this.LastModifyNameTime.GetHashCode();
			}
			if (this.ModifyName.Length != 0)
			{
				num ^= this.ModifyName.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DD86 RID: 56710 RVA: 0x002082AC File Offset: 0x002064AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DD87 RID: 56711 RVA: 0x002082B9 File Offset: 0x002064B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DD88 RID: 56712 RVA: 0x002082C4 File Offset: 0x002064C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Name);
			}
			if (this.LastModifyNameTime != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.LastModifyNameTime);
			}
			if (this.ModifyName.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteString(this.ModifyName);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DD89 RID: 56713 RVA: 0x00208360 File Offset: 0x00206560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.LastModifyNameTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LastModifyNameTime);
			}
			if (this.ModifyName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ModifyName);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DD8A RID: 56714 RVA: 0x002083F0 File Offset: 0x002065F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ModifyNameResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.LastModifyNameTime != 0L)
			{
				this.LastModifyNameTime = other.LastModifyNameTime;
			}
			if (other.ModifyName.Length != 0)
			{
				this.ModifyName = other.ModifyName;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DD8B RID: 56715 RVA: 0x00208472 File Offset: 0x00206672
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DD8C RID: 56716 RVA: 0x0020847C File Offset: 0x0020667C
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
				if (num <= 88U)
				{
					if (num == 18U)
					{
						this.Name = input.ReadString();
						continue;
					}
					if (num == 88U)
					{
						this.LastModifyNameTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						this.ModifyName = input.ReadString();
						continue;
					}
					if (num == 120U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005BE4 RID: 23524
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BE5 RID: 23525
		public const int NameFieldNumber = 2;

		// Token: 0x04005BE6 RID: 23526
		private string name_ = "";

		// Token: 0x04005BE7 RID: 23527
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04005BE8 RID: 23528
		private ErrorCode errorCode_;

		// Token: 0x04005BE9 RID: 23529
		public const int LastModifyNameTimeFieldNumber = 11;

		// Token: 0x04005BEA RID: 23530
		private long lastModifyNameTime_;

		// Token: 0x04005BEB RID: 23531
		public const int ModifyNameFieldNumber = 12;

		// Token: 0x04005BEC RID: 23532
		private string modifyName_ = "";
	}
}
