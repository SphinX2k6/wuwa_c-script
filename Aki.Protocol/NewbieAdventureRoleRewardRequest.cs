using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AF9 RID: 2809
	[NetMessage(EMessageId.NewbieAdventureRoleRewardRequest)]
	public sealed class NewbieAdventureRoleRewardRequest : IMessage<NewbieAdventureRoleRewardRequest>, IMessage, IEquatable<NewbieAdventureRoleRewardRequest>, IDeepCloneable<NewbieAdventureRoleRewardRequest>, IBufferMessage
	{
		// Token: 0x0600F439 RID: 62521 RVA: 0x0023A7E9 File Offset: 0x002389E9
		[NullableContext(1)]
		public static NewbieAdventureRoleRewardRequest Create()
		{
			return new NewbieAdventureRoleRewardRequest();
		}

		// Token: 0x170031BF RID: 12735
		// (get) Token: 0x0600F43A RID: 62522 RVA: 0x0023A7F0 File Offset: 0x002389F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031C0 RID: 12736
		// (get) Token: 0x0600F43B RID: 62523 RVA: 0x0023A7F3 File Offset: 0x002389F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieAdventureRoleRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600F43C RID: 62524 RVA: 0x0023A7FA File Offset: 0x002389FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureRoleRewardRequest()
		{
		}

		// Token: 0x0600F43D RID: 62525 RVA: 0x0023A802 File Offset: 0x00238A02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureRoleRewardRequest(NewbieAdventureRoleRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.chapterId_ = other.chapterId_;
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F43E RID: 62526 RVA: 0x0023A83F File Offset: 0x00238A3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureRoleRewardRequest Clone()
		{
			return new NewbieAdventureRoleRewardRequest(this);
		}

		// Token: 0x170031C1 RID: 12737
		// (get) Token: 0x0600F43F RID: 62527 RVA: 0x0023A847 File Offset: 0x00238A47
		// (set) Token: 0x0600F440 RID: 62528 RVA: 0x0023A84F File Offset: 0x00238A4F
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

		// Token: 0x170031C2 RID: 12738
		// (get) Token: 0x0600F441 RID: 62529 RVA: 0x0023A858 File Offset: 0x00238A58
		// (set) Token: 0x0600F442 RID: 62530 RVA: 0x0023A860 File Offset: 0x00238A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChapterId
		{
			get
			{
				return this.chapterId_;
			}
			set
			{
				this.chapterId_ = value;
			}
		}

		// Token: 0x170031C3 RID: 12739
		// (get) Token: 0x0600F443 RID: 62531 RVA: 0x0023A869 File Offset: 0x00238A69
		// (set) Token: 0x0600F444 RID: 62532 RVA: 0x0023A871 File Offset: 0x00238A71
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

		// Token: 0x0600F445 RID: 62533 RVA: 0x0023A87A File Offset: 0x00238A7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieAdventureRoleRewardRequest);
		}

		// Token: 0x0600F446 RID: 62534 RVA: 0x0023A888 File Offset: 0x00238A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieAdventureRoleRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.ChapterId == other.ChapterId && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F447 RID: 62535 RVA: 0x0023A8E4 File Offset: 0x00238AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.ChapterId != 0)
			{
				num ^= this.ChapterId.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F448 RID: 62536 RVA: 0x0023A955 File Offset: 0x00238B55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F449 RID: 62537 RVA: 0x0023A962 File Offset: 0x00238B62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F44A RID: 62538 RVA: 0x0023A96C File Offset: 0x00238B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChapterId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ChapterId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ActivityId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F44B RID: 62539 RVA: 0x0023A9E4 File Offset: 0x00238BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.ChapterId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChapterId);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F44C RID: 62540 RVA: 0x0023AA54 File Offset: 0x00238C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieAdventureRoleRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.ChapterId != 0)
			{
				this.ChapterId = other.ChapterId;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F44D RID: 62541 RVA: 0x0023AAB8 File Offset: 0x00238CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F44E RID: 62542 RVA: 0x0023AAC4 File Offset: 0x00238CC4
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
					if (num != 56U)
					{
						if (num != 120U)
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
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.ChapterId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400625D RID: 25181
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400625E RID: 25182
		public const int ActivityIdFieldNumber = 7;

		// Token: 0x0400625F RID: 25183
		private int activityId_;

		// Token: 0x04006260 RID: 25184
		public const int ChapterIdFieldNumber = 2;

		// Token: 0x04006261 RID: 25185
		private int chapterId_;

		// Token: 0x04006262 RID: 25186
		public const int RoleIdFieldNumber = 15;

		// Token: 0x04006263 RID: 25187
		private int roleId_;
	}
}
