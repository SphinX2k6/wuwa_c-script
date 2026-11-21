using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000764 RID: 1892
	[NetMessage(EMessageId.HonamiStoryEquipRoleResponse)]
	public sealed class HonamiStoryEquipRoleResponse : IMessage<HonamiStoryEquipRoleResponse>, IMessage, IEquatable<HonamiStoryEquipRoleResponse>, IDeepCloneable<HonamiStoryEquipRoleResponse>, IBufferMessage
	{
		// Token: 0x0600AB6E RID: 43886 RVA: 0x0019C9BC File Offset: 0x0019ABBC
		[NullableContext(1)]
		public static HonamiStoryEquipRoleResponse Create()
		{
			return new HonamiStoryEquipRoleResponse();
		}

		// Token: 0x17002288 RID: 8840
		// (get) Token: 0x0600AB6F RID: 43887 RVA: 0x0019C9C3 File Offset: 0x0019ABC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002289 RID: 8841
		// (get) Token: 0x0600AB70 RID: 43888 RVA: 0x0019C9C6 File Offset: 0x0019ABC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryEquipRoleResponse.Descriptor;
			}
		}

		// Token: 0x0600AB71 RID: 43889 RVA: 0x0019C9CD File Offset: 0x0019ABCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryEquipRoleResponse()
		{
		}

		// Token: 0x0600AB72 RID: 43890 RVA: 0x0019C9E0 File Offset: 0x0019ABE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryEquipRoleResponse(HonamiStoryEquipRoleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.activityId_ = other.activityId_;
			this.roleId_ = other.roleId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AB73 RID: 43891 RVA: 0x0019CA2D File Offset: 0x0019AC2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryEquipRoleResponse Clone()
		{
			return new HonamiStoryEquipRoleResponse(this);
		}

		// Token: 0x1700228A RID: 8842
		// (get) Token: 0x0600AB74 RID: 43892 RVA: 0x0019CA35 File Offset: 0x0019AC35
		// (set) Token: 0x0600AB75 RID: 43893 RVA: 0x0019CA3D File Offset: 0x0019AC3D
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

		// Token: 0x1700228B RID: 8843
		// (get) Token: 0x0600AB76 RID: 43894 RVA: 0x0019CA46 File Offset: 0x0019AC46
		// (set) Token: 0x0600AB77 RID: 43895 RVA: 0x0019CA4E File Offset: 0x0019AC4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x1700228C RID: 8844
		// (get) Token: 0x0600AB78 RID: 43896 RVA: 0x0019CA57 File Offset: 0x0019AC57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleId
		{
			get
			{
				return this.roleId_;
			}
		}

		// Token: 0x0600AB79 RID: 43897 RVA: 0x0019CA5F File Offset: 0x0019AC5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryEquipRoleResponse);
		}

		// Token: 0x0600AB7A RID: 43898 RVA: 0x0019CA70 File Offset: 0x0019AC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryEquipRoleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ActivityId == other.ActivityId && this.roleId_.Equals(other.roleId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AB7B RID: 43899 RVA: 0x0019CAD0 File Offset: 0x0019ACD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.roleId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AB7C RID: 43900 RVA: 0x0019CB3C File Offset: 0x0019AD3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AB7D RID: 43901 RVA: 0x0019CB49 File Offset: 0x0019AD49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AB7E RID: 43902 RVA: 0x0019CB54 File Offset: 0x0019AD54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleId_.WriteTo(ref output, HonamiStoryEquipRoleResponse._repeated_roleId_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AB7F RID: 43903 RVA: 0x0019CBC0 File Offset: 0x0019ADC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.roleId_.CalculateSize(HonamiStoryEquipRoleResponse._repeated_roleId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AB80 RID: 43904 RVA: 0x0019CC2C File Offset: 0x0019AE2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryEquipRoleResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.roleId_.Add(other.roleId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AB81 RID: 43905 RVA: 0x0019CC8D File Offset: 0x0019AE8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AB82 RID: 43906 RVA: 0x0019CC98 File Offset: 0x0019AE98
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
				if (num <= 42U)
				{
					if (num == 40U || num == 42U)
					{
						this.roleId_.AddEntriesFrom(ref input, HonamiStoryEquipRoleResponse._repeated_roleId_codec);
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 64U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004E2A RID: 20010
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E2B RID: 20011
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04004E2C RID: 20012
		private ErrorCode errorCode_;

		// Token: 0x04004E2D RID: 20013
		public const int ActivityIdFieldNumber = 8;

		// Token: 0x04004E2E RID: 20014
		private int activityId_;

		// Token: 0x04004E2F RID: 20015
		public const int RoleIdFieldNumber = 5;

		// Token: 0x04004E30 RID: 20016
		private static readonly FieldCodec<int> _repeated_roleId_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04004E31 RID: 20017
		private readonly RepeatedField<int> roleId_ = new RepeatedField<int>();
	}
}
