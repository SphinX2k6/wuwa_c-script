using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D8D RID: 3469
	public sealed class PlayerFightFormations : IMessage<PlayerFightFormations>, IMessage, IEquatable<PlayerFightFormations>, IDeepCloneable<PlayerFightFormations>, IBufferMessage
	{
		// Token: 0x06012B54 RID: 76628 RVA: 0x002BB25C File Offset: 0x002B945C
		[NullableContext(1)]
		public static PlayerFightFormations Create()
		{
			return new PlayerFightFormations();
		}

		// Token: 0x17003E18 RID: 15896
		// (get) Token: 0x06012B55 RID: 76629 RVA: 0x002BB263 File Offset: 0x002B9463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerFightFormations> Parser
		{
			get
			{
				return PlayerFightFormations._parser;
			}
		}

		// Token: 0x17003E19 RID: 15897
		// (get) Token: 0x06012B56 RID: 76630 RVA: 0x002BB26A File Offset: 0x002B946A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E1A RID: 15898
		// (get) Token: 0x06012B57 RID: 76631 RVA: 0x002BB26D File Offset: 0x002B946D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerFightFormations.Descriptor;
			}
		}

		// Token: 0x06012B58 RID: 76632 RVA: 0x002BB274 File Offset: 0x002B9474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFightFormations()
		{
		}

		// Token: 0x06012B59 RID: 76633 RVA: 0x002BB287 File Offset: 0x002B9487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFightFormations(PlayerFightFormations other) : this()
		{
			this.playerId_ = other.playerId_;
			this.formations_ = other.formations_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012B5A RID: 76634 RVA: 0x002BB2BD File Offset: 0x002B94BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFightFormations Clone()
		{
			return new PlayerFightFormations(this);
		}

		// Token: 0x17003E1B RID: 15899
		// (get) Token: 0x06012B5B RID: 76635 RVA: 0x002BB2C5 File Offset: 0x002B94C5
		// (set) Token: 0x06012B5C RID: 76636 RVA: 0x002BB2CD File Offset: 0x002B94CD
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

		// Token: 0x17003E1C RID: 15900
		// (get) Token: 0x06012B5D RID: 76637 RVA: 0x002BB2D6 File Offset: 0x002B94D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FightFormationNotifyInfo> Formations
		{
			get
			{
				return this.formations_;
			}
		}

		// Token: 0x06012B5E RID: 76638 RVA: 0x002BB2DE File Offset: 0x002B94DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerFightFormations);
		}

		// Token: 0x06012B5F RID: 76639 RVA: 0x002BB2EC File Offset: 0x002B94EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerFightFormations other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.formations_.Equals(other.formations_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012B60 RID: 76640 RVA: 0x002BB33C File Offset: 0x002B953C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			num ^= this.formations_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012B61 RID: 76641 RVA: 0x002BB389 File Offset: 0x002B9589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012B62 RID: 76642 RVA: 0x002BB396 File Offset: 0x002B9596
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012B63 RID: 76643 RVA: 0x002BB3A0 File Offset: 0x002B95A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			this.formations_.WriteTo(ref output, PlayerFightFormations._repeated_formations_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012B64 RID: 76644 RVA: 0x002BB3F0 File Offset: 0x002B95F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			num += this.formations_.CalculateSize(PlayerFightFormations._repeated_formations_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012B65 RID: 76645 RVA: 0x002BB444 File Offset: 0x002B9644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerFightFormations other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this.formations_.Add(other.formations_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012B66 RID: 76646 RVA: 0x002BB491 File Offset: 0x002B9691
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012B67 RID: 76647 RVA: 0x002BB49C File Offset: 0x002B969C
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.formations_.AddEntriesFrom(ref input, PlayerFightFormations._repeated_formations_codec);
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007416 RID: 29718
		private static readonly MessageParser<PlayerFightFormations> _parser = new MessageParser<PlayerFightFormations>(() => new PlayerFightFormations());

		// Token: 0x04007417 RID: 29719
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007418 RID: 29720
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04007419 RID: 29721
		private int playerId_;

		// Token: 0x0400741A RID: 29722
		public const int FormationsFieldNumber = 2;

		// Token: 0x0400741B RID: 29723
		private static readonly FieldCodec<FightFormationNotifyInfo> _repeated_formations_codec = FieldCodec.ForMessage<FightFormationNotifyInfo>(18U, FightFormationNotifyInfo.Parser);

		// Token: 0x0400741C RID: 29724
		private readonly RepeatedField<FightFormationNotifyInfo> formations_ = new RepeatedField<FightFormationNotifyInfo>();
	}
}
