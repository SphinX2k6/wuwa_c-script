using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014A0 RID: 5280
	[NetMessage(EMessageId.UpdatePlayerAllFightRoleNotify)]
	public sealed class UpdatePlayerAllFightRoleNotify : IMessage<UpdatePlayerAllFightRoleNotify>, IMessage, IEquatable<UpdatePlayerAllFightRoleNotify>, IDeepCloneable<UpdatePlayerAllFightRoleNotify>, IBufferMessage
	{
		// Token: 0x0601BED5 RID: 114389 RVA: 0x004096E9 File Offset: 0x004078E9
		[NullableContext(1)]
		public static UpdatePlayerAllFightRoleNotify Create()
		{
			return new UpdatePlayerAllFightRoleNotify();
		}

		// Token: 0x17005E1E RID: 24094
		// (get) Token: 0x0601BED6 RID: 114390 RVA: 0x004096F0 File Offset: 0x004078F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E1F RID: 24095
		// (get) Token: 0x0601BED7 RID: 114391 RVA: 0x004096F3 File Offset: 0x004078F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdatePlayerAllFightRoleNotify.Descriptor;
			}
		}

		// Token: 0x0601BED8 RID: 114392 RVA: 0x004096FA File Offset: 0x004078FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePlayerAllFightRoleNotify()
		{
		}

		// Token: 0x0601BED9 RID: 114393 RVA: 0x0040970D File Offset: 0x0040790D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePlayerAllFightRoleNotify(UpdatePlayerAllFightRoleNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.fightRoleInfos_ = other.fightRoleInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BEDA RID: 114394 RVA: 0x00409743 File Offset: 0x00407943
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePlayerAllFightRoleNotify Clone()
		{
			return new UpdatePlayerAllFightRoleNotify(this);
		}

		// Token: 0x17005E20 RID: 24096
		// (get) Token: 0x0601BEDB RID: 114395 RVA: 0x0040974B File Offset: 0x0040794B
		// (set) Token: 0x0601BEDC RID: 114396 RVA: 0x00409753 File Offset: 0x00407953
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

		// Token: 0x17005E21 RID: 24097
		// (get) Token: 0x0601BEDD RID: 114397 RVA: 0x0040975C File Offset: 0x0040795C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FightRoleInformation> FightRoleInfos
		{
			get
			{
				return this.fightRoleInfos_;
			}
		}

		// Token: 0x0601BEDE RID: 114398 RVA: 0x00409764 File Offset: 0x00407964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdatePlayerAllFightRoleNotify);
		}

		// Token: 0x0601BEDF RID: 114399 RVA: 0x00409774 File Offset: 0x00407974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdatePlayerAllFightRoleNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.fightRoleInfos_.Equals(other.fightRoleInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BEE0 RID: 114400 RVA: 0x004097C4 File Offset: 0x004079C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			num ^= this.fightRoleInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BEE1 RID: 114401 RVA: 0x00409811 File Offset: 0x00407A11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BEE2 RID: 114402 RVA: 0x0040981E File Offset: 0x00407A1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BEE3 RID: 114403 RVA: 0x00409828 File Offset: 0x00407A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.fightRoleInfos_.WriteTo(ref output, UpdatePlayerAllFightRoleNotify._repeated_fightRoleInfos_codec);
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BEE4 RID: 114404 RVA: 0x00409878 File Offset: 0x00407A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			num += this.fightRoleInfos_.CalculateSize(UpdatePlayerAllFightRoleNotify._repeated_fightRoleInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BEE5 RID: 114405 RVA: 0x004098CC File Offset: 0x00407ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdatePlayerAllFightRoleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this.fightRoleInfos_.Add(other.fightRoleInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BEE6 RID: 114406 RVA: 0x00409919 File Offset: 0x00407B19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BEE7 RID: 114407 RVA: 0x00409924 File Offset: 0x00407B24
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
				if (num != 50U)
				{
					if (num != 72U)
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
					this.fightRoleInfos_.AddEntriesFrom(ref input, UpdatePlayerAllFightRoleNotify._repeated_fightRoleInfos_codec);
				}
			}
		}

		// Token: 0x0400A07B RID: 41083
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A07C RID: 41084
		public const int PlayerIdFieldNumber = 9;

		// Token: 0x0400A07D RID: 41085
		private int playerId_;

		// Token: 0x0400A07E RID: 41086
		public const int FightRoleInfosFieldNumber = 6;

		// Token: 0x0400A07F RID: 41087
		private static readonly FieldCodec<FightRoleInformation> _repeated_fightRoleInfos_codec = FieldCodec.ForMessage<FightRoleInformation>(50U, FightRoleInformation.Parser);

		// Token: 0x0400A080 RID: 41088
		private readonly RepeatedField<FightRoleInformation> fightRoleInfos_ = new RepeatedField<FightRoleInformation>();
	}
}
