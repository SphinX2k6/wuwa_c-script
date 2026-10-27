using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200106D RID: 4205
	[NetMessage(EMessageId.RoleFavorAcceptQuestRequest)]
	public sealed class RoleFavorAcceptQuestRequest : IMessage<RoleFavorAcceptQuestRequest>, IMessage, IEquatable<RoleFavorAcceptQuestRequest>, IDeepCloneable<RoleFavorAcceptQuestRequest>, IBufferMessage
	{
		// Token: 0x0601678D RID: 92045 RVA: 0x00344696 File Offset: 0x00342896
		[NullableContext(1)]
		public static RoleFavorAcceptQuestRequest Create()
		{
			return new RoleFavorAcceptQuestRequest();
		}

		// Token: 0x17004B3E RID: 19262
		// (get) Token: 0x0601678E RID: 92046 RVA: 0x0034469D File Offset: 0x0034289D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B3F RID: 19263
		// (get) Token: 0x0601678F RID: 92047 RVA: 0x003446A0 File Offset: 0x003428A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFavorAcceptQuestRequest.Descriptor;
			}
		}

		// Token: 0x06016790 RID: 92048 RVA: 0x003446A7 File Offset: 0x003428A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorAcceptQuestRequest()
		{
		}

		// Token: 0x06016791 RID: 92049 RVA: 0x003446AF File Offset: 0x003428AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorAcceptQuestRequest(RoleFavorAcceptQuestRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.questType_ = other.questType_;
			this.chapter_ = other.chapter_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016792 RID: 92050 RVA: 0x003446EC File Offset: 0x003428EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorAcceptQuestRequest Clone()
		{
			return new RoleFavorAcceptQuestRequest(this);
		}

		// Token: 0x17004B40 RID: 19264
		// (get) Token: 0x06016793 RID: 92051 RVA: 0x003446F4 File Offset: 0x003428F4
		// (set) Token: 0x06016794 RID: 92052 RVA: 0x003446FC File Offset: 0x003428FC
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

		// Token: 0x17004B41 RID: 19265
		// (get) Token: 0x06016795 RID: 92053 RVA: 0x00344705 File Offset: 0x00342905
		// (set) Token: 0x06016796 RID: 92054 RVA: 0x0034470D File Offset: 0x0034290D
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

		// Token: 0x17004B42 RID: 19266
		// (get) Token: 0x06016797 RID: 92055 RVA: 0x00344716 File Offset: 0x00342916
		// (set) Token: 0x06016798 RID: 92056 RVA: 0x0034471E File Offset: 0x0034291E
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

		// Token: 0x06016799 RID: 92057 RVA: 0x00344727 File Offset: 0x00342927
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFavorAcceptQuestRequest);
		}

		// Token: 0x0601679A RID: 92058 RVA: 0x00344738 File Offset: 0x00342938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFavorAcceptQuestRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.QuestType == other.QuestType && this.Chapter == other.Chapter && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601679B RID: 92059 RVA: 0x00344794 File Offset: 0x00342994
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

		// Token: 0x0601679C RID: 92060 RVA: 0x0034480B File Offset: 0x00342A0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601679D RID: 92061 RVA: 0x00344818 File Offset: 0x00342A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601679E RID: 92062 RVA: 0x00344824 File Offset: 0x00342A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.QuestType != FavorQuestType.Talk)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.QuestType);
			}
			if (this.Chapter != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Chapter);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601679F RID: 92063 RVA: 0x0034489C File Offset: 0x00342A9C
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

		// Token: 0x060167A0 RID: 92064 RVA: 0x0034490C File Offset: 0x00342B0C
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

		// Token: 0x060167A1 RID: 92065 RVA: 0x00344970 File Offset: 0x00342B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060167A2 RID: 92066 RVA: 0x0034497C File Offset: 0x00342B7C
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
				if (num != 64U)
				{
					if (num != 80U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.QuestType = (FavorQuestType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008670 RID: 34416
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008671 RID: 34417
		public const int RoleIdFieldNumber = 13;

		// Token: 0x04008672 RID: 34418
		private int roleId_;

		// Token: 0x04008673 RID: 34419
		public const int QuestTypeFieldNumber = 8;

		// Token: 0x04008674 RID: 34420
		private FavorQuestType questType_;

		// Token: 0x04008675 RID: 34421
		public const int ChapterFieldNumber = 10;

		// Token: 0x04008676 RID: 34422
		private int chapter_;
	}
}
