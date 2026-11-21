using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200027E RID: 638
	[NetMessage(EMessageId.CharacterMoveToPointNotify)]
	public sealed class CharacterMoveToPointNotify : IMessage<CharacterMoveToPointNotify>, IMessage, IEquatable<CharacterMoveToPointNotify>, IDeepCloneable<CharacterMoveToPointNotify>, IBufferMessage
	{
		// Token: 0x06004324 RID: 17188 RVA: 0x000A4DFC File Offset: 0x000A2FFC
		[NullableContext(1)]
		public static CharacterMoveToPointNotify Create()
		{
			return new CharacterMoveToPointNotify();
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x06004325 RID: 17189 RVA: 0x000A4E03 File Offset: 0x000A3003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x06004326 RID: 17190 RVA: 0x000A4E06 File Offset: 0x000A3006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CharacterMoveToPointNotify.Descriptor;
			}
		}

		// Token: 0x06004327 RID: 17191 RVA: 0x000A4E0D File Offset: 0x000A300D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterMoveToPointNotify()
		{
		}

		// Token: 0x06004328 RID: 17192 RVA: 0x000A4E18 File Offset: 0x000A3018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterMoveToPointNotify(CharacterMoveToPointNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.entityId_ = other.entityId_;
			this.config_ = ((other.config_ != null) ? other.config_.Clone() : null);
			this.moveStatus_ = other.moveStatus_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004329 RID: 17193 RVA: 0x000A4E7C File Offset: 0x000A307C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterMoveToPointNotify Clone()
		{
			return new CharacterMoveToPointNotify(this);
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x0600432A RID: 17194 RVA: 0x000A4E84 File Offset: 0x000A3084
		// (set) Token: 0x0600432B RID: 17195 RVA: 0x000A4E8C File Offset: 0x000A308C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x0600432C RID: 17196 RVA: 0x000A4E95 File Offset: 0x000A3095
		// (set) Token: 0x0600432D RID: 17197 RVA: 0x000A4E9D File Offset: 0x000A309D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x0600432E RID: 17198 RVA: 0x000A4EA6 File Offset: 0x000A30A6
		// (set) Token: 0x0600432F RID: 17199 RVA: 0x000A4EAE File Offset: 0x000A30AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterMoveToPointConfig Config
		{
			get
			{
				return this.config_;
			}
			set
			{
				this.config_ = value;
			}
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06004330 RID: 17200 RVA: 0x000A4EB7 File Offset: 0x000A30B7
		// (set) Token: 0x06004331 RID: 17201 RVA: 0x000A4EBF File Offset: 0x000A30BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveStatus MoveStatus
		{
			get
			{
				return this.moveStatus_;
			}
			set
			{
				this.moveStatus_ = value;
			}
		}

		// Token: 0x06004332 RID: 17202 RVA: 0x000A4EC8 File Offset: 0x000A30C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CharacterMoveToPointNotify);
		}

		// Token: 0x06004333 RID: 17203 RVA: 0x000A4ED8 File Offset: 0x000A30D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CharacterMoveToPointNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.EntityId == other.EntityId && object.Equals(this.Config, other.Config) && this.MoveStatus == other.MoveStatus && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004334 RID: 17204 RVA: 0x000A4F48 File Offset: 0x000A3148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.config_ != null)
			{
				num ^= this.Config.GetHashCode();
			}
			if (this.MoveStatus != MoveStatus.Stop)
			{
				num ^= this.MoveStatus.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004335 RID: 17205 RVA: 0x000A4FD5 File Offset: 0x000A31D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004336 RID: 17206 RVA: 0x000A4FE2 File Offset: 0x000A31E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004337 RID: 17207 RVA: 0x000A4FEC File Offset: 0x000A31EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MoveStatus != MoveStatus.Stop)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.MoveStatus);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EntityId);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.PlayerId);
			}
			if (this.config_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Config);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004338 RID: 17208 RVA: 0x000A5080 File Offset: 0x000A3280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.config_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Config);
			}
			if (this.MoveStatus != MoveStatus.Stop)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.MoveStatus);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004339 RID: 17209 RVA: 0x000A5108 File Offset: 0x000A3308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CharacterMoveToPointNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.config_ != null)
			{
				if (this.config_ == null)
				{
					this.Config = new CharacterMoveToPointConfig();
				}
				this.Config.MergeFrom(other.Config);
			}
			if (other.MoveStatus != MoveStatus.Stop)
			{
				this.MoveStatus = other.MoveStatus;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600433A RID: 17210 RVA: 0x000A5198 File Offset: 0x000A3398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600433B RID: 17211 RVA: 0x000A51A4 File Offset: 0x000A33A4
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
				if (num <= 24U)
				{
					if (num == 16U)
					{
						this.MoveStatus = (MoveStatus)input.ReadEnum();
						continue;
					}
					if (num == 24U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 114U)
					{
						if (this.config_ == null)
						{
							this.Config = new CharacterMoveToPointConfig();
						}
						input.ReadMessage(this.Config);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002E8C RID: 11916
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E8D RID: 11917
		public const int PlayerIdFieldNumber = 11;

		// Token: 0x04002E8E RID: 11918
		private int playerId_;

		// Token: 0x04002E8F RID: 11919
		public const int EntityIdFieldNumber = 3;

		// Token: 0x04002E90 RID: 11920
		private long entityId_;

		// Token: 0x04002E91 RID: 11921
		public const int ConfigFieldNumber = 14;

		// Token: 0x04002E92 RID: 11922
		private CharacterMoveToPointConfig config_;

		// Token: 0x04002E93 RID: 11923
		public const int MoveStatusFieldNumber = 2;

		// Token: 0x04002E94 RID: 11924
		private MoveStatus moveStatus_;
	}
}
