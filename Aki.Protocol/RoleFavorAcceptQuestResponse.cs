using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200105E RID: 4190
	[NetMessage(EMessageId.RoleFavorAcceptQuestResponse)]
	public sealed class RoleFavorAcceptQuestResponse : IMessage<RoleFavorAcceptQuestResponse>, IMessage, IEquatable<RoleFavorAcceptQuestResponse>, IDeepCloneable<RoleFavorAcceptQuestResponse>, IBufferMessage
	{
		// Token: 0x060166BE RID: 91838 RVA: 0x00343317 File Offset: 0x00341517
		[NullableContext(1)]
		public static RoleFavorAcceptQuestResponse Create()
		{
			return new RoleFavorAcceptQuestResponse();
		}

		// Token: 0x17004B19 RID: 19225
		// (get) Token: 0x060166BF RID: 91839 RVA: 0x0034331E File Offset: 0x0034151E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B1A RID: 19226
		// (get) Token: 0x060166C0 RID: 91840 RVA: 0x00343321 File Offset: 0x00341521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFavorAcceptQuestResponse.Descriptor;
			}
		}

		// Token: 0x060166C1 RID: 91841 RVA: 0x00343328 File Offset: 0x00341528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorAcceptQuestResponse()
		{
		}

		// Token: 0x060166C2 RID: 91842 RVA: 0x00343330 File Offset: 0x00341530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorAcceptQuestResponse(RoleFavorAcceptQuestResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.roleId_ = other.roleId_;
			this.questType_ = other.questType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060166C3 RID: 91843 RVA: 0x0034336D File Offset: 0x0034156D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorAcceptQuestResponse Clone()
		{
			return new RoleFavorAcceptQuestResponse(this);
		}

		// Token: 0x17004B1B RID: 19227
		// (get) Token: 0x060166C4 RID: 91844 RVA: 0x00343375 File Offset: 0x00341575
		// (set) Token: 0x060166C5 RID: 91845 RVA: 0x0034337D File Offset: 0x0034157D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x17004B1C RID: 19228
		// (get) Token: 0x060166C6 RID: 91846 RVA: 0x00343386 File Offset: 0x00341586
		// (set) Token: 0x060166C7 RID: 91847 RVA: 0x0034338E File Offset: 0x0034158E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17004B1D RID: 19229
		// (get) Token: 0x060166C8 RID: 91848 RVA: 0x00343397 File Offset: 0x00341597
		// (set) Token: 0x060166C9 RID: 91849 RVA: 0x0034339F File Offset: 0x0034159F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FavorQuestType QuestType
		{
			get
			{
				return this.questType_;
			}
			set
			{
				this.questType_ = value;
			}
		}

		// Token: 0x060166CA RID: 91850 RVA: 0x003433A8 File Offset: 0x003415A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFavorAcceptQuestResponse);
		}

		// Token: 0x060166CB RID: 91851 RVA: 0x003433B8 File Offset: 0x003415B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFavorAcceptQuestResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.RoleId == other.RoleId && this.QuestType == other.QuestType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060166CC RID: 91852 RVA: 0x00343414 File Offset: 0x00341614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.QuestType != FavorQuestType.Talk)
			{
				num ^= this.QuestType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060166CD RID: 91853 RVA: 0x00343491 File Offset: 0x00341691
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060166CE RID: 91854 RVA: 0x0034349E File Offset: 0x0034169E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060166CF RID: 91855 RVA: 0x003434A8 File Offset: 0x003416A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.QuestType != FavorQuestType.Talk)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.QuestType);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RoleId);
			}
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060166D0 RID: 91856 RVA: 0x00343520 File Offset: 0x00341720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.QuestType != FavorQuestType.Talk)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.QuestType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060166D1 RID: 91857 RVA: 0x00343590 File Offset: 0x00341790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleFavorAcceptQuestResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.QuestType != FavorQuestType.Talk)
			{
				this.QuestType = other.QuestType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060166D2 RID: 91858 RVA: 0x003435F4 File Offset: 0x003417F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060166D3 RID: 91859 RVA: 0x00343600 File Offset: 0x00341800
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
				if (num != 24U)
				{
					if (num != 32U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ErrCode = (ErrorCode)input.ReadEnum();
						}
					}
					else
					{
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					this.QuestType = (FavorQuestType)input.ReadEnum();
				}
			}
		}

		// Token: 0x040086A1 RID: 34465
		private UnknownFieldSet _unknownFields;

		// Token: 0x040086A2 RID: 34466
		public const int ErrCodeFieldNumber = 12;

		// Token: 0x040086A3 RID: 34467
		private ErrorCode errCode_;

		// Token: 0x040086A4 RID: 34468
		public const int RoleIdFieldNumber = 4;

		// Token: 0x040086A5 RID: 34469
		private int roleId_;

		// Token: 0x040086A6 RID: 34470
		public const int QuestTypeFieldNumber = 3;

		// Token: 0x040086A7 RID: 34471
		private FavorQuestType questType_;
	}
}
