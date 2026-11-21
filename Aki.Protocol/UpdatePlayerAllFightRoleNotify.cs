using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001516 RID: 5398
	[NetMessage(EMessageId.UpdatePlayerAllFightRoleNotify)]
	public sealed class UpdatePlayerAllFightRoleNotify : IMessage<UpdatePlayerAllFightRoleNotify>, IMessage, IEquatable<UpdatePlayerAllFightRoleNotify>, IDeepCloneable<UpdatePlayerAllFightRoleNotify>, IBufferMessage
	{
		// Token: 0x0601C99C RID: 117148 RVA: 0x004251A0 File Offset: 0x004233A0
		[NullableContext(1)]
		public static UpdatePlayerAllFightRoleNotify Create()
		{
			return new UpdatePlayerAllFightRoleNotify();
		}

		// Token: 0x170060BF RID: 24767
		// (get) Token: 0x0601C99D RID: 117149 RVA: 0x004251A7 File Offset: 0x004233A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060C0 RID: 24768
		// (get) Token: 0x0601C99E RID: 117150 RVA: 0x004251AA File Offset: 0x004233AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdatePlayerAllFightRoleNotify.Descriptor;
			}
		}

		// Token: 0x0601C99F RID: 117151 RVA: 0x004251B1 File Offset: 0x004233B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePlayerAllFightRoleNotify()
		{
		}

		// Token: 0x0601C9A0 RID: 117152 RVA: 0x004251C4 File Offset: 0x004233C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePlayerAllFightRoleNotify(UpdatePlayerAllFightRoleNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.fightRoleInfos_ = other.fightRoleInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C9A1 RID: 117153 RVA: 0x004251FA File Offset: 0x004233FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePlayerAllFightRoleNotify Clone()
		{
			return new UpdatePlayerAllFightRoleNotify(this);
		}

		// Token: 0x170060C1 RID: 24769
		// (get) Token: 0x0601C9A2 RID: 117154 RVA: 0x00425202 File Offset: 0x00423402
		// (set) Token: 0x0601C9A3 RID: 117155 RVA: 0x0042520A File Offset: 0x0042340A
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

		// Token: 0x170060C2 RID: 24770
		// (get) Token: 0x0601C9A4 RID: 117156 RVA: 0x00425213 File Offset: 0x00423413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FightRoleInformation> FightRoleInfos
		{
			get
			{
				return this.fightRoleInfos_;
			}
		}

		// Token: 0x0601C9A5 RID: 117157 RVA: 0x0042521B File Offset: 0x0042341B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdatePlayerAllFightRoleNotify);
		}

		// Token: 0x0601C9A6 RID: 117158 RVA: 0x0042522C File Offset: 0x0042342C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdatePlayerAllFightRoleNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.fightRoleInfos_.Equals(other.fightRoleInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C9A7 RID: 117159 RVA: 0x0042527C File Offset: 0x0042347C
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

		// Token: 0x0601C9A8 RID: 117160 RVA: 0x004252C9 File Offset: 0x004234C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C9A9 RID: 117161 RVA: 0x004252D6 File Offset: 0x004234D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C9AA RID: 117162 RVA: 0x004252E0 File Offset: 0x004234E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.fightRoleInfos_.WriteTo(ref output, UpdatePlayerAllFightRoleNotify._repeated_fightRoleInfos_codec);
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C9AB RID: 117163 RVA: 0x00425330 File Offset: 0x00423530
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

		// Token: 0x0601C9AC RID: 117164 RVA: 0x00425384 File Offset: 0x00423584
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

		// Token: 0x0601C9AD RID: 117165 RVA: 0x004253D1 File Offset: 0x004235D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C9AE RID: 117166 RVA: 0x004253DC File Offset: 0x004235DC
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
				if (num != 114U)
				{
					if (num != 120U)
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

		// Token: 0x0400A4D4 RID: 42196
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A4D5 RID: 42197
		public const int PlayerIdFieldNumber = 15;

		// Token: 0x0400A4D6 RID: 42198
		private int playerId_;

		// Token: 0x0400A4D7 RID: 42199
		public const int FightRoleInfosFieldNumber = 14;

		// Token: 0x0400A4D8 RID: 42200
		private static readonly FieldCodec<FightRoleInformation> _repeated_fightRoleInfos_codec = FieldCodec.ForMessage<FightRoleInformation>(114U, FightRoleInformation.Parser);

		// Token: 0x0400A4D9 RID: 42201
		private readonly RepeatedField<FightRoleInformation> fightRoleInfos_ = new RepeatedField<FightRoleInformation>();
	}
}
