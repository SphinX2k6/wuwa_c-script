using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014AF RID: 5295
	[NetMessage(EMessageId.UpdateWorldTeamPlayerFightInfoNotify)]
	public sealed class UpdateWorldTeamPlayerFightInfoNotify : IMessage<UpdateWorldTeamPlayerFightInfoNotify>, IMessage, IEquatable<UpdateWorldTeamPlayerFightInfoNotify>, IDeepCloneable<UpdateWorldTeamPlayerFightInfoNotify>, IBufferMessage
	{
		// Token: 0x0601C005 RID: 114693 RVA: 0x0040BFD6 File Offset: 0x0040A1D6
		[NullableContext(1)]
		public static UpdateWorldTeamPlayerFightInfoNotify Create()
		{
			return new UpdateWorldTeamPlayerFightInfoNotify();
		}

		// Token: 0x17005E5C RID: 24156
		// (get) Token: 0x0601C006 RID: 114694 RVA: 0x0040BFDD File Offset: 0x0040A1DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E5D RID: 24157
		// (get) Token: 0x0601C007 RID: 114695 RVA: 0x0040BFE0 File Offset: 0x0040A1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateWorldTeamPlayerFightInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601C008 RID: 114696 RVA: 0x0040BFE7 File Offset: 0x0040A1E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateWorldTeamPlayerFightInfoNotify()
		{
		}

		// Token: 0x0601C009 RID: 114697 RVA: 0x0040BFF0 File Offset: 0x0040A1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateWorldTeamPlayerFightInfoNotify(UpdateWorldTeamPlayerFightInfoNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.fightInfo_ = ((other.fightInfo_ != null) ? other.fightInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C00A RID: 114698 RVA: 0x0040C03C File Offset: 0x0040A23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateWorldTeamPlayerFightInfoNotify Clone()
		{
			return new UpdateWorldTeamPlayerFightInfoNotify(this);
		}

		// Token: 0x17005E5E RID: 24158
		// (get) Token: 0x0601C00B RID: 114699 RVA: 0x0040C044 File Offset: 0x0040A244
		// (set) Token: 0x0601C00C RID: 114700 RVA: 0x0040C04C File Offset: 0x0040A24C
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

		// Token: 0x17005E5F RID: 24159
		// (get) Token: 0x0601C00D RID: 114701 RVA: 0x0040C055 File Offset: 0x0040A255
		// (set) Token: 0x0601C00E RID: 114702 RVA: 0x0040C05D File Offset: 0x0040A25D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldTeamPlayerFightInfo FightInfo
		{
			get
			{
				return this.fightInfo_;
			}
			set
			{
				this.fightInfo_ = value;
			}
		}

		// Token: 0x0601C00F RID: 114703 RVA: 0x0040C066 File Offset: 0x0040A266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateWorldTeamPlayerFightInfoNotify);
		}

		// Token: 0x0601C010 RID: 114704 RVA: 0x0040C074 File Offset: 0x0040A274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateWorldTeamPlayerFightInfoNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && object.Equals(this.FightInfo, other.FightInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C011 RID: 114705 RVA: 0x0040C0C4 File Offset: 0x0040A2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.fightInfo_ != null)
			{
				num ^= this.FightInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C012 RID: 114706 RVA: 0x0040C119 File Offset: 0x0040A319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C013 RID: 114707 RVA: 0x0040C126 File Offset: 0x0040A326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C014 RID: 114708 RVA: 0x0040C130 File Offset: 0x0040A330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.fightInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.FightInfo);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C015 RID: 114709 RVA: 0x0040C18C File Offset: 0x0040A38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.fightInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FightInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C016 RID: 114710 RVA: 0x0040C1E4 File Offset: 0x0040A3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateWorldTeamPlayerFightInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.fightInfo_ != null)
			{
				if (this.fightInfo_ == null)
				{
					this.FightInfo = new WorldTeamPlayerFightInfo();
				}
				this.FightInfo.MergeFrom(other.FightInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C017 RID: 114711 RVA: 0x0040C24C File Offset: 0x0040A44C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C018 RID: 114712 RVA: 0x0040C258 File Offset: 0x0040A458
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
				if (num != 26U)
				{
					if (num != 64U)
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
					if (this.fightInfo_ == null)
					{
						this.FightInfo = new WorldTeamPlayerFightInfo();
					}
					input.ReadMessage(this.FightInfo);
				}
			}
		}

		// Token: 0x0400A0D1 RID: 41169
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A0D2 RID: 41170
		public const int PlayerIdFieldNumber = 8;

		// Token: 0x0400A0D3 RID: 41171
		private int playerId_;

		// Token: 0x0400A0D4 RID: 41172
		public const int FightInfoFieldNumber = 3;

		// Token: 0x0400A0D5 RID: 41173
		private WorldTeamPlayerFightInfo fightInfo_;
	}
}
