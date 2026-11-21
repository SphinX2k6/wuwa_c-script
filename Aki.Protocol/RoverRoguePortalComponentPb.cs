using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200114E RID: 4430
	public sealed class RoverRoguePortalComponentPb : IMessage<RoverRoguePortalComponentPb>, IMessage, IEquatable<RoverRoguePortalComponentPb>, IDeepCloneable<RoverRoguePortalComponentPb>, IBufferMessage
	{
		// Token: 0x06017AB9 RID: 96953 RVA: 0x00371F0A File Offset: 0x0037010A
		[NullableContext(1)]
		public static RoverRoguePortalComponentPb Create()
		{
			return new RoverRoguePortalComponentPb();
		}

		// Token: 0x17004FA1 RID: 20385
		// (get) Token: 0x06017ABA RID: 96954 RVA: 0x00371F11 File Offset: 0x00370111
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004FA2 RID: 20386
		// (get) Token: 0x06017ABB RID: 96955 RVA: 0x00371F14 File Offset: 0x00370114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRoguePortalComponentPb.Descriptor;
			}
		}

		// Token: 0x06017ABC RID: 96956 RVA: 0x00371F1B File Offset: 0x0037011B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRoguePortalComponentPb()
		{
		}

		// Token: 0x06017ABD RID: 96957 RVA: 0x00371F23 File Offset: 0x00370123
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRoguePortalComponentPb(RoverRoguePortalComponentPb other) : this()
		{
			this.rewardType_ = other.rewardType_;
			this.blessRoleId_ = other.blessRoleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017ABE RID: 96958 RVA: 0x00371F54 File Offset: 0x00370154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRoguePortalComponentPb Clone()
		{
			return new RoverRoguePortalComponentPb(this);
		}

		// Token: 0x17004FA3 RID: 20387
		// (get) Token: 0x06017ABF RID: 96959 RVA: 0x00371F5C File Offset: 0x0037015C
		// (set) Token: 0x06017AC0 RID: 96960 RVA: 0x00371F64 File Offset: 0x00370164
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

		// Token: 0x17004FA4 RID: 20388
		// (get) Token: 0x06017AC1 RID: 96961 RVA: 0x00371F6D File Offset: 0x0037016D
		// (set) Token: 0x06017AC2 RID: 96962 RVA: 0x00371F75 File Offset: 0x00370175
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

		// Token: 0x06017AC3 RID: 96963 RVA: 0x00371F7E File Offset: 0x0037017E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRoguePortalComponentPb);
		}

		// Token: 0x06017AC4 RID: 96964 RVA: 0x00371F8C File Offset: 0x0037018C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRoguePortalComponentPb other)
		{
			return other != null && (other == this || (this.RewardType == other.RewardType && this.BlessRoleId == other.BlessRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017AC5 RID: 96965 RVA: 0x00371FCC File Offset: 0x003701CC
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

		// Token: 0x06017AC6 RID: 96966 RVA: 0x00372024 File Offset: 0x00370224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017AC7 RID: 96967 RVA: 0x00372031 File Offset: 0x00370231
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017AC8 RID: 96968 RVA: 0x0037203C File Offset: 0x0037023C
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

		// Token: 0x06017AC9 RID: 96969 RVA: 0x00372094 File Offset: 0x00370294
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

		// Token: 0x06017ACA RID: 96970 RVA: 0x003720EC File Offset: 0x003702EC
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

		// Token: 0x06017ACB RID: 96971 RVA: 0x0037213C File Offset: 0x0037033C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017ACC RID: 96972 RVA: 0x00372148 File Offset: 0x00370348
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

		// Token: 0x04008D42 RID: 36162
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D43 RID: 36163
		public const int RewardTypeFieldNumber = 1;

		// Token: 0x04008D44 RID: 36164
		private int rewardType_;

		// Token: 0x04008D45 RID: 36165
		public const int BlessRoleIdFieldNumber = 2;

		// Token: 0x04008D46 RID: 36166
		private int blessRoleId_;
	}
}
