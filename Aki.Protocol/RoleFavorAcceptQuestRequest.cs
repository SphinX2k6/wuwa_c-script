using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200105D RID: 4189
	[NetMessage(EMessageId.RoleFavorAcceptQuestRequest)]
	public sealed class RoleFavorAcceptQuestRequest : IMessage<RoleFavorAcceptQuestRequest>, IMessage, IEquatable<RoleFavorAcceptQuestRequest>, IDeepCloneable<RoleFavorAcceptQuestRequest>, IBufferMessage
	{
		// Token: 0x060166A8 RID: 91816 RVA: 0x00342FC6 File Offset: 0x003411C6
		[NullableContext(1)]
		public static RoleFavorAcceptQuestRequest Create()
		{
			return new RoleFavorAcceptQuestRequest();
		}

		// Token: 0x17004B14 RID: 19220
		// (get) Token: 0x060166A9 RID: 91817 RVA: 0x00342FCD File Offset: 0x003411CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B15 RID: 19221
		// (get) Token: 0x060166AA RID: 91818 RVA: 0x00342FD0 File Offset: 0x003411D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFavorAcceptQuestRequest.Descriptor;
			}
		}

		// Token: 0x060166AB RID: 91819 RVA: 0x00342FD7 File Offset: 0x003411D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorAcceptQuestRequest()
		{
		}

		// Token: 0x060166AC RID: 91820 RVA: 0x00342FDF File Offset: 0x003411DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorAcceptQuestRequest(RoleFavorAcceptQuestRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.questType_ = other.questType_;
			this.chapter_ = other.chapter_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060166AD RID: 91821 RVA: 0x0034301C File Offset: 0x0034121C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorAcceptQuestRequest Clone()
		{
			return new RoleFavorAcceptQuestRequest(this);
		}

		// Token: 0x17004B16 RID: 19222
		// (get) Token: 0x060166AE RID: 91822 RVA: 0x00343024 File Offset: 0x00341224
		// (set) Token: 0x060166AF RID: 91823 RVA: 0x0034302C File Offset: 0x0034122C
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

		// Token: 0x17004B17 RID: 19223
		// (get) Token: 0x060166B0 RID: 91824 RVA: 0x00343035 File Offset: 0x00341235
		// (set) Token: 0x060166B1 RID: 91825 RVA: 0x0034303D File Offset: 0x0034123D
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

		// Token: 0x17004B18 RID: 19224
		// (get) Token: 0x060166B2 RID: 91826 RVA: 0x00343046 File Offset: 0x00341246
		// (set) Token: 0x060166B3 RID: 91827 RVA: 0x0034304E File Offset: 0x0034124E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Chapter
		{
			get
			{
				return this.chapter_;
			}
			set
			{
				this.chapter_ = value;
			}
		}

		// Token: 0x060166B4 RID: 91828 RVA: 0x00343057 File Offset: 0x00341257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFavorAcceptQuestRequest);
		}

		// Token: 0x060166B5 RID: 91829 RVA: 0x00343068 File Offset: 0x00341268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFavorAcceptQuestRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.QuestType == other.QuestType && this.Chapter == other.Chapter && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060166B6 RID: 91830 RVA: 0x003430C4 File Offset: 0x003412C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.QuestType != FavorQuestType.Talk)
			{
				num ^= this.QuestType.GetHashCode();
			}
			if (this.Chapter != 0)
			{
				num ^= this.Chapter.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060166B7 RID: 91831 RVA: 0x0034313B File Offset: 0x0034133B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060166B8 RID: 91832 RVA: 0x00343148 File Offset: 0x00341348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060166B9 RID: 91833 RVA: 0x00343154 File Offset: 0x00341354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Chapter != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Chapter);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.RoleId);
			}
			if (this.QuestType != FavorQuestType.Talk)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.QuestType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060166BA RID: 91834 RVA: 0x003431CC File Offset: 0x003413CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.QuestType != FavorQuestType.Talk)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.QuestType);
			}
			if (this.Chapter != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Chapter);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060166BB RID: 91835 RVA: 0x0034323C File Offset: 0x0034143C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleFavorAcceptQuestRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.QuestType != FavorQuestType.Talk)
			{
				this.QuestType = other.QuestType;
			}
			if (other.Chapter != 0)
			{
				this.Chapter = other.Chapter;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060166BC RID: 91836 RVA: 0x003432A0 File Offset: 0x003414A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060166BD RID: 91837 RVA: 0x003432AC File Offset: 0x003414AC
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
				if (num != 16U)
				{
					if (num != 48U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.QuestType = (FavorQuestType)input.ReadEnum();
						}
					}
					else
					{
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					this.Chapter = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400869A RID: 34458
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400869B RID: 34459
		public const int RoleIdFieldNumber = 6;

		// Token: 0x0400869C RID: 34460
		private int roleId_;

		// Token: 0x0400869D RID: 34461
		public const int QuestTypeFieldNumber = 10;

		// Token: 0x0400869E RID: 34462
		private FavorQuestType questType_;

		// Token: 0x0400869F RID: 34463
		public const int ChapterFieldNumber = 2;

		// Token: 0x040086A0 RID: 34464
		private int chapter_;
	}
}
