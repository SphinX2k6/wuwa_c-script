using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000778 RID: 1912
	[NetMessage(EMessageId.HonamiStoryEquipRoleResponse)]
	public sealed class HonamiStoryEquipRoleResponse : IMessage<HonamiStoryEquipRoleResponse>, IMessage, IEquatable<HonamiStoryEquipRoleResponse>, IDeepCloneable<HonamiStoryEquipRoleResponse>, IBufferMessage
	{
		// Token: 0x0600ACC4 RID: 44228 RVA: 0x0019F3E4 File Offset: 0x0019D5E4
		[NullableContext(1)]
		public static HonamiStoryEquipRoleResponse Create()
		{
			return new HonamiStoryEquipRoleResponse();
		}

		// Token: 0x170022D2 RID: 8914
		// (get) Token: 0x0600ACC5 RID: 44229 RVA: 0x0019F3EB File Offset: 0x0019D5EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022D3 RID: 8915
		// (get) Token: 0x0600ACC6 RID: 44230 RVA: 0x0019F3EE File Offset: 0x0019D5EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryEquipRoleResponse.Descriptor;
			}
		}

		// Token: 0x0600ACC7 RID: 44231 RVA: 0x0019F3F5 File Offset: 0x0019D5F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryEquipRoleResponse()
		{
		}

		// Token: 0x0600ACC8 RID: 44232 RVA: 0x0019F408 File Offset: 0x0019D608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryEquipRoleResponse(HonamiStoryEquipRoleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.activityId_ = other.activityId_;
			this.roleId_ = other.roleId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ACC9 RID: 44233 RVA: 0x0019F455 File Offset: 0x0019D655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryEquipRoleResponse Clone()
		{
			return new HonamiStoryEquipRoleResponse(this);
		}

		// Token: 0x170022D4 RID: 8916
		// (get) Token: 0x0600ACCA RID: 44234 RVA: 0x0019F45D File Offset: 0x0019D65D
		// (set) Token: 0x0600ACCB RID: 44235 RVA: 0x0019F465 File Offset: 0x0019D665
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

		// Token: 0x170022D5 RID: 8917
		// (get) Token: 0x0600ACCC RID: 44236 RVA: 0x0019F46E File Offset: 0x0019D66E
		// (set) Token: 0x0600ACCD RID: 44237 RVA: 0x0019F476 File Offset: 0x0019D676
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

		// Token: 0x170022D6 RID: 8918
		// (get) Token: 0x0600ACCE RID: 44238 RVA: 0x0019F47F File Offset: 0x0019D67F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleId
		{
			get
			{
				return this.roleId_;
			}
		}

		// Token: 0x0600ACCF RID: 44239 RVA: 0x0019F487 File Offset: 0x0019D687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryEquipRoleResponse);
		}

		// Token: 0x0600ACD0 RID: 44240 RVA: 0x0019F498 File Offset: 0x0019D698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryEquipRoleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ActivityId == other.ActivityId && this.roleId_.Equals(other.roleId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ACD1 RID: 44241 RVA: 0x0019F4F8 File Offset: 0x0019D6F8
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

		// Token: 0x0600ACD2 RID: 44242 RVA: 0x0019F564 File Offset: 0x0019D764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ACD3 RID: 44243 RVA: 0x0019F571 File Offset: 0x0019D771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ACD4 RID: 44244 RVA: 0x0019F57C File Offset: 0x0019D77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.roleId_.WriteTo(ref output, HonamiStoryEquipRoleResponse._repeated_roleId_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ACD5 RID: 44245 RVA: 0x0019F5E8 File Offset: 0x0019D7E8
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

		// Token: 0x0600ACD6 RID: 44246 RVA: 0x0019F654 File Offset: 0x0019D854
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

		// Token: 0x0600ACD7 RID: 44247 RVA: 0x0019F6B5 File Offset: 0x0019D8B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ACD8 RID: 44248 RVA: 0x0019F6C0 File Offset: 0x0019D8C0
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
				if (num <= 56U)
				{
					if (num == 16U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 56U)
					{
						goto IL_46;
					}
				}
				else
				{
					if (num == 58U)
					{
						goto IL_46;
					}
					if (num == 88U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_46:
				this.roleId_.AddEntriesFrom(ref input, HonamiStoryEquipRoleResponse._repeated_roleId_codec);
			}
		}

		// Token: 0x04004E31 RID: 20017
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E32 RID: 20018
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04004E33 RID: 20019
		private ErrorCode errorCode_;

		// Token: 0x04004E34 RID: 20020
		public const int ActivityIdFieldNumber = 11;

		// Token: 0x04004E35 RID: 20021
		private int activityId_;

		// Token: 0x04004E36 RID: 20022
		public const int RoleIdFieldNumber = 7;

		// Token: 0x04004E37 RID: 20023
		private static readonly FieldCodec<int> _repeated_roleId_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04004E38 RID: 20024
		private readonly RepeatedField<int> roleId_ = new RepeatedField<int>();
	}
}
