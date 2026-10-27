using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001114 RID: 4372
	public sealed class RoverRoguePortalComponentPb : IMessage<RoverRoguePortalComponentPb>, IMessage, IEquatable<RoverRoguePortalComponentPb>, IDeepCloneable<RoverRoguePortalComponentPb>, IBufferMessage
	{
		// Token: 0x06017518 RID: 95512 RVA: 0x00362BBE File Offset: 0x00360DBE
		[NullableContext(1)]
		public static RoverRoguePortalComponentPb Create()
		{
			return new RoverRoguePortalComponentPb();
		}

		// Token: 0x17004E35 RID: 20021
		// (get) Token: 0x06017519 RID: 95513 RVA: 0x00362BC5 File Offset: 0x00360DC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E36 RID: 20022
		// (get) Token: 0x0601751A RID: 95514 RVA: 0x00362BC8 File Offset: 0x00360DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRoguePortalComponentPb.Descriptor;
			}
		}

		// Token: 0x0601751B RID: 95515 RVA: 0x00362BCF File Offset: 0x00360DCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRoguePortalComponentPb()
		{
		}

		// Token: 0x0601751C RID: 95516 RVA: 0x00362BD7 File Offset: 0x00360DD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRoguePortalComponentPb(RoverRoguePortalComponentPb other) : this()
		{
			this.rewardType_ = other.rewardType_;
			this.blessRoleId_ = other.blessRoleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601751D RID: 95517 RVA: 0x00362C08 File Offset: 0x00360E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRoguePortalComponentPb Clone()
		{
			return new RoverRoguePortalComponentPb(this);
		}

		// Token: 0x17004E37 RID: 20023
		// (get) Token: 0x0601751E RID: 95518 RVA: 0x00362C10 File Offset: 0x00360E10
		// (set) Token: 0x0601751F RID: 95519 RVA: 0x00362C18 File Offset: 0x00360E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RewardType
		{
			get
			{
				return this.rewardType_;
			}
			set
			{
				this.rewardType_ = value;
			}
		}

		// Token: 0x17004E38 RID: 20024
		// (get) Token: 0x06017520 RID: 95520 RVA: 0x00362C21 File Offset: 0x00360E21
		// (set) Token: 0x06017521 RID: 95521 RVA: 0x00362C29 File Offset: 0x00360E29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BlessRoleId
		{
			get
			{
				return this.blessRoleId_;
			}
			set
			{
				this.blessRoleId_ = value;
			}
		}

		// Token: 0x06017522 RID: 95522 RVA: 0x00362C32 File Offset: 0x00360E32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRoguePortalComponentPb);
		}

		// Token: 0x06017523 RID: 95523 RVA: 0x00362C40 File Offset: 0x00360E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRoguePortalComponentPb other)
		{
			return other != null && (other == this || (this.RewardType == other.RewardType && this.BlessRoleId == other.BlessRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017524 RID: 95524 RVA: 0x00362C80 File Offset: 0x00360E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RewardType != 0)
			{
				num ^= this.RewardType.GetHashCode();
			}
			if (this.BlessRoleId != 0)
			{
				num ^= this.BlessRoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017525 RID: 95525 RVA: 0x00362CD8 File Offset: 0x00360ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017526 RID: 95526 RVA: 0x00362CE5 File Offset: 0x00360EE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017527 RID: 95527 RVA: 0x00362CF0 File Offset: 0x00360EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RewardType != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RewardType);
			}
			if (this.BlessRoleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.BlessRoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017528 RID: 95528 RVA: 0x00362D48 File Offset: 0x00360F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RewardType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RewardType);
			}
			if (this.BlessRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BlessRoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017529 RID: 95529 RVA: 0x00362DA0 File Offset: 0x00360FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRoguePortalComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RewardType != 0)
			{
				this.RewardType = other.RewardType;
			}
			if (other.BlessRoleId != 0)
			{
				this.BlessRoleId = other.BlessRoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601752A RID: 95530 RVA: 0x00362DF0 File Offset: 0x00360FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601752B RID: 95531 RVA: 0x00362DFC File Offset: 0x00360FFC
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BlessRoleId = input.ReadInt32();
					}
				}
				else
				{
					this.RewardType = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008AAF RID: 35503
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008AB0 RID: 35504
		public const int RewardTypeFieldNumber = 1;

		// Token: 0x04008AB1 RID: 35505
		private int rewardType_;

		// Token: 0x04008AB2 RID: 35506
		public const int BlessRoleIdFieldNumber = 2;

		// Token: 0x04008AB3 RID: 35507
		private int blessRoleId_;
	}
}
