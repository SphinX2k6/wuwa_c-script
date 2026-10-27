using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014A4 RID: 5284
	[NetMessage(EMessageId.UpdatePlayerSingleFightRoleNotify)]
	public sealed class UpdatePlayerSingleFightRoleNotify : IMessage<UpdatePlayerSingleFightRoleNotify>, IMessage, IEquatable<UpdatePlayerSingleFightRoleNotify>, IDeepCloneable<UpdatePlayerSingleFightRoleNotify>, IBufferMessage
	{
		// Token: 0x0601BF23 RID: 114467 RVA: 0x0040A099 File Offset: 0x00408299
		[NullableContext(1)]
		public static UpdatePlayerSingleFightRoleNotify Create()
		{
			return new UpdatePlayerSingleFightRoleNotify();
		}

		// Token: 0x17005E2D RID: 24109
		// (get) Token: 0x0601BF24 RID: 114468 RVA: 0x0040A0A0 File Offset: 0x004082A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E2E RID: 24110
		// (get) Token: 0x0601BF25 RID: 114469 RVA: 0x0040A0A3 File Offset: 0x004082A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdatePlayerSingleFightRoleNotify.Descriptor;
			}
		}

		// Token: 0x0601BF26 RID: 114470 RVA: 0x0040A0AA File Offset: 0x004082AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePlayerSingleFightRoleNotify()
		{
		}

		// Token: 0x0601BF27 RID: 114471 RVA: 0x0040A0B4 File Offset: 0x004082B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePlayerSingleFightRoleNotify(UpdatePlayerSingleFightRoleNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.fightRoleInfo_ = ((other.fightRoleInfo_ != null) ? other.fightRoleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BF28 RID: 114472 RVA: 0x0040A100 File Offset: 0x00408300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePlayerSingleFightRoleNotify Clone()
		{
			return new UpdatePlayerSingleFightRoleNotify(this);
		}

		// Token: 0x17005E2F RID: 24111
		// (get) Token: 0x0601BF29 RID: 114473 RVA: 0x0040A108 File Offset: 0x00408308
		// (set) Token: 0x0601BF2A RID: 114474 RVA: 0x0040A110 File Offset: 0x00408310
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

		// Token: 0x17005E30 RID: 24112
		// (get) Token: 0x0601BF2B RID: 114475 RVA: 0x0040A119 File Offset: 0x00408319
		// (set) Token: 0x0601BF2C RID: 114476 RVA: 0x0040A121 File Offset: 0x00408321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightRoleInformation FightRoleInfo
		{
			get
			{
				return this.fightRoleInfo_;
			}
			set
			{
				this.fightRoleInfo_ = value;
			}
		}

		// Token: 0x0601BF2D RID: 114477 RVA: 0x0040A12A File Offset: 0x0040832A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdatePlayerSingleFightRoleNotify);
		}

		// Token: 0x0601BF2E RID: 114478 RVA: 0x0040A138 File Offset: 0x00408338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdatePlayerSingleFightRoleNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && object.Equals(this.FightRoleInfo, other.FightRoleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BF2F RID: 114479 RVA: 0x0040A188 File Offset: 0x00408388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.fightRoleInfo_ != null)
			{
				num ^= this.FightRoleInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BF30 RID: 114480 RVA: 0x0040A1DD File Offset: 0x004083DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BF31 RID: 114481 RVA: 0x0040A1EA File Offset: 0x004083EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BF32 RID: 114482 RVA: 0x0040A1F4 File Offset: 0x004083F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.fightRoleInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.FightRoleInfo);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BF33 RID: 114483 RVA: 0x0040A250 File Offset: 0x00408450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.fightRoleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FightRoleInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BF34 RID: 114484 RVA: 0x0040A2A8 File Offset: 0x004084A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdatePlayerSingleFightRoleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.fightRoleInfo_ != null)
			{
				if (this.fightRoleInfo_ == null)
				{
					this.FightRoleInfo = new FightRoleInformation();
				}
				this.FightRoleInfo.MergeFrom(other.FightRoleInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BF35 RID: 114485 RVA: 0x0040A310 File Offset: 0x00408510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BF36 RID: 114486 RVA: 0x0040A31C File Offset: 0x0040851C
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
				if (num != 58U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					if (this.fightRoleInfo_ == null)
					{
						this.FightRoleInfo = new FightRoleInformation();
					}
					input.ReadMessage(this.FightRoleInfo);
				}
			}
		}

		// Token: 0x0400A08F RID: 41103
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A090 RID: 41104
		public const int PlayerIdFieldNumber = 11;

		// Token: 0x0400A091 RID: 41105
		private int playerId_;

		// Token: 0x0400A092 RID: 41106
		public const int FightRoleInfoFieldNumber = 7;

		// Token: 0x0400A093 RID: 41107
		private FightRoleInformation fightRoleInfo_;
	}
}
