using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AE8 RID: 2792
	[NetMessage(EMessageId.NewbieAdventureRoleRewardRequest)]
	public sealed class NewbieAdventureRoleRewardRequest : IMessage<NewbieAdventureRoleRewardRequest>, IMessage, IEquatable<NewbieAdventureRoleRewardRequest>, IDeepCloneable<NewbieAdventureRoleRewardRequest>, IBufferMessage
	{
		// Token: 0x0600F31F RID: 62239 RVA: 0x002385DC File Offset: 0x002367DC
		[NullableContext(1)]
		public static NewbieAdventureRoleRewardRequest Create()
		{
			return new NewbieAdventureRoleRewardRequest();
		}

		// Token: 0x17003181 RID: 12673
		// (get) Token: 0x0600F320 RID: 62240 RVA: 0x002385E3 File Offset: 0x002367E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003182 RID: 12674
		// (get) Token: 0x0600F321 RID: 62241 RVA: 0x002385E6 File Offset: 0x002367E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieAdventureRoleRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600F322 RID: 62242 RVA: 0x002385ED File Offset: 0x002367ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureRoleRewardRequest()
		{
		}

		// Token: 0x0600F323 RID: 62243 RVA: 0x002385F5 File Offset: 0x002367F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureRoleRewardRequest(NewbieAdventureRoleRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.chapterId_ = other.chapterId_;
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F324 RID: 62244 RVA: 0x00238632 File Offset: 0x00236832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureRoleRewardRequest Clone()
		{
			return new NewbieAdventureRoleRewardRequest(this);
		}

		// Token: 0x17003183 RID: 12675
		// (get) Token: 0x0600F325 RID: 62245 RVA: 0x0023863A File Offset: 0x0023683A
		// (set) Token: 0x0600F326 RID: 62246 RVA: 0x00238642 File Offset: 0x00236842
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

		// Token: 0x17003184 RID: 12676
		// (get) Token: 0x0600F327 RID: 62247 RVA: 0x0023864B File Offset: 0x0023684B
		// (set) Token: 0x0600F328 RID: 62248 RVA: 0x00238653 File Offset: 0x00236853
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

		// Token: 0x17003185 RID: 12677
		// (get) Token: 0x0600F329 RID: 62249 RVA: 0x0023865C File Offset: 0x0023685C
		// (set) Token: 0x0600F32A RID: 62250 RVA: 0x00238664 File Offset: 0x00236864
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

		// Token: 0x0600F32B RID: 62251 RVA: 0x0023866D File Offset: 0x0023686D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieAdventureRoleRewardRequest);
		}

		// Token: 0x0600F32C RID: 62252 RVA: 0x0023867C File Offset: 0x0023687C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieAdventureRoleRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.ChapterId == other.ChapterId && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F32D RID: 62253 RVA: 0x002386D8 File Offset: 0x002368D8
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

		// Token: 0x0600F32E RID: 62254 RVA: 0x00238749 File Offset: 0x00236949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F32F RID: 62255 RVA: 0x00238756 File Offset: 0x00236956
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F330 RID: 62256 RVA: 0x00238760 File Offset: 0x00236960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChapterId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ChapterId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.RoleId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F331 RID: 62257 RVA: 0x002387D8 File Offset: 0x002369D8
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

		// Token: 0x0600F332 RID: 62258 RVA: 0x00238848 File Offset: 0x00236A48
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

		// Token: 0x0600F333 RID: 62259 RVA: 0x002388AC File Offset: 0x00236AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F334 RID: 62260 RVA: 0x002388B8 File Offset: 0x00236AB8
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
					if (num != 40U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ActivityId = input.ReadInt32();
						}
					}
					else
					{
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					this.ChapterId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006266 RID: 25190
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006267 RID: 25191
		public const int ActivityIdFieldNumber = 10;

		// Token: 0x04006268 RID: 25192
		private int activityId_;

		// Token: 0x04006269 RID: 25193
		public const int ChapterIdFieldNumber = 2;

		// Token: 0x0400626A RID: 25194
		private int chapterId_;

		// Token: 0x0400626B RID: 25195
		public const int RoleIdFieldNumber = 5;

		// Token: 0x0400626C RID: 25196
		private int roleId_;
	}
}
