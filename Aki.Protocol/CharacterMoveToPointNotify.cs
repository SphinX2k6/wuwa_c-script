using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000279 RID: 633
	[NetMessage(EMessageId.CharacterMoveToPointNotify)]
	public sealed class CharacterMoveToPointNotify : IMessage<CharacterMoveToPointNotify>, IMessage, IEquatable<CharacterMoveToPointNotify>, IDeepCloneable<CharacterMoveToPointNotify>, IBufferMessage
	{
		// Token: 0x0600427D RID: 17021 RVA: 0x000A3130 File Offset: 0x000A1330
		[NullableContext(1)]
		public static CharacterMoveToPointNotify Create()
		{
			return new CharacterMoveToPointNotify();
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x0600427E RID: 17022 RVA: 0x000A3137 File Offset: 0x000A1337
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x0600427F RID: 17023 RVA: 0x000A313A File Offset: 0x000A133A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CharacterMoveToPointNotify.Descriptor;
			}
		}

		// Token: 0x06004280 RID: 17024 RVA: 0x000A3141 File Offset: 0x000A1341
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterMoveToPointNotify()
		{
		}

		// Token: 0x06004281 RID: 17025 RVA: 0x000A314C File Offset: 0x000A134C
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

		// Token: 0x06004282 RID: 17026 RVA: 0x000A31B0 File Offset: 0x000A13B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterMoveToPointNotify Clone()
		{
			return new CharacterMoveToPointNotify(this);
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x06004283 RID: 17027 RVA: 0x000A31B8 File Offset: 0x000A13B8
		// (set) Token: 0x06004284 RID: 17028 RVA: 0x000A31C0 File Offset: 0x000A13C0
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

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x06004285 RID: 17029 RVA: 0x000A31C9 File Offset: 0x000A13C9
		// (set) Token: 0x06004286 RID: 17030 RVA: 0x000A31D1 File Offset: 0x000A13D1
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

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x06004287 RID: 17031 RVA: 0x000A31DA File Offset: 0x000A13DA
		// (set) Token: 0x06004288 RID: 17032 RVA: 0x000A31E2 File Offset: 0x000A13E2
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

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x06004289 RID: 17033 RVA: 0x000A31EB File Offset: 0x000A13EB
		// (set) Token: 0x0600428A RID: 17034 RVA: 0x000A31F3 File Offset: 0x000A13F3
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

		// Token: 0x0600428B RID: 17035 RVA: 0x000A31FC File Offset: 0x000A13FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CharacterMoveToPointNotify);
		}

		// Token: 0x0600428C RID: 17036 RVA: 0x000A320C File Offset: 0x000A140C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CharacterMoveToPointNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.EntityId == other.EntityId && object.Equals(this.Config, other.Config) && this.MoveStatus == other.MoveStatus && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600428D RID: 17037 RVA: 0x000A327C File Offset: 0x000A147C
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

		// Token: 0x0600428E RID: 17038 RVA: 0x000A3309 File Offset: 0x000A1509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600428F RID: 17039 RVA: 0x000A3316 File Offset: 0x000A1516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004290 RID: 17040 RVA: 0x000A3320 File Offset: 0x000A1520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.EntityId);
			}
			if (this.config_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Config);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.PlayerId);
			}
			if (this.MoveStatus != MoveStatus.Stop)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.MoveStatus);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004291 RID: 17041 RVA: 0x000A33B4 File Offset: 0x000A15B4
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

		// Token: 0x06004292 RID: 17042 RVA: 0x000A343C File Offset: 0x000A163C
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

		// Token: 0x06004293 RID: 17043 RVA: 0x000A34CC File Offset: 0x000A16CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004294 RID: 17044 RVA: 0x000A34D8 File Offset: 0x000A16D8
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
					if (num == 32U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 42U)
					{
						if (this.config_ == null)
						{
							this.Config = new CharacterMoveToPointConfig();
						}
						input.ReadMessage(this.Config);
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.MoveStatus = (MoveStatus)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002E08 RID: 11784
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E09 RID: 11785
		public const int PlayerIdFieldNumber = 6;

		// Token: 0x04002E0A RID: 11786
		private int playerId_;

		// Token: 0x04002E0B RID: 11787
		public const int EntityIdFieldNumber = 4;

		// Token: 0x04002E0C RID: 11788
		private long entityId_;

		// Token: 0x04002E0D RID: 11789
		public const int ConfigFieldNumber = 5;

		// Token: 0x04002E0E RID: 11790
		private CharacterMoveToPointConfig config_;

		// Token: 0x04002E0F RID: 11791
		public const int MoveStatusFieldNumber = 13;

		// Token: 0x04002E10 RID: 11792
		private MoveStatus moveStatus_;
	}
}
