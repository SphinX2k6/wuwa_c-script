using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D88 RID: 3464
	[NetMessage(EMessageId.PlayerLivingStatesNotify)]
	public sealed class PlayerLivingStatesNotify : IMessage<PlayerLivingStatesNotify>, IMessage, IEquatable<PlayerLivingStatesNotify>, IDeepCloneable<PlayerLivingStatesNotify>, IBufferMessage
	{
		// Token: 0x06012B2A RID: 76586 RVA: 0x002BAFDC File Offset: 0x002B91DC
		[NullableContext(1)]
		public static PlayerLivingStatesNotify Create()
		{
			return new PlayerLivingStatesNotify();
		}

		// Token: 0x17003E0B RID: 15883
		// (get) Token: 0x06012B2B RID: 76587 RVA: 0x002BAFE3 File Offset: 0x002B91E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E0C RID: 15884
		// (get) Token: 0x06012B2C RID: 76588 RVA: 0x002BAFE6 File Offset: 0x002B91E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerLivingStatesNotify.Descriptor;
			}
		}

		// Token: 0x06012B2D RID: 76589 RVA: 0x002BAFED File Offset: 0x002B91ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerLivingStatesNotify()
		{
		}

		// Token: 0x06012B2E RID: 76590 RVA: 0x002BB000 File Offset: 0x002B9200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerLivingStatesNotify(PlayerLivingStatesNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.livingList_ = other.livingList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012B2F RID: 76591 RVA: 0x002BB036 File Offset: 0x002B9236
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerLivingStatesNotify Clone()
		{
			return new PlayerLivingStatesNotify(this);
		}

		// Token: 0x17003E0D RID: 15885
		// (get) Token: 0x06012B30 RID: 76592 RVA: 0x002BB03E File Offset: 0x002B923E
		// (set) Token: 0x06012B31 RID: 76593 RVA: 0x002BB046 File Offset: 0x002B9246
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

		// Token: 0x17003E0E RID: 15886
		// (get) Token: 0x06012B32 RID: 76594 RVA: 0x002BB04F File Offset: 0x002B924F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LivingState> LivingList
		{
			get
			{
				return this.livingList_;
			}
		}

		// Token: 0x06012B33 RID: 76595 RVA: 0x002BB057 File Offset: 0x002B9257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerLivingStatesNotify);
		}

		// Token: 0x06012B34 RID: 76596 RVA: 0x002BB068 File Offset: 0x002B9268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerLivingStatesNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.livingList_.Equals(other.livingList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012B35 RID: 76597 RVA: 0x002BB0B8 File Offset: 0x002B92B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			num ^= this.livingList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012B36 RID: 76598 RVA: 0x002BB105 File Offset: 0x002B9305
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012B37 RID: 76599 RVA: 0x002BB112 File Offset: 0x002B9312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012B38 RID: 76600 RVA: 0x002BB11C File Offset: 0x002B931C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PlayerId);
			}
			this.livingList_.WriteTo(ref output, PlayerLivingStatesNotify._repeated_livingList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012B39 RID: 76601 RVA: 0x002BB16C File Offset: 0x002B936C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			num += this.livingList_.CalculateSize(PlayerLivingStatesNotify._repeated_livingList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012B3A RID: 76602 RVA: 0x002BB1C0 File Offset: 0x002B93C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerLivingStatesNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this.livingList_.Add(other.livingList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012B3B RID: 76603 RVA: 0x002BB20D File Offset: 0x002B940D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012B3C RID: 76604 RVA: 0x002BB218 File Offset: 0x002B9418
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
				if (num != 24U)
				{
					if (num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.livingList_.AddEntriesFrom(ref input, PlayerLivingStatesNotify._repeated_livingList_codec);
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007460 RID: 29792
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007461 RID: 29793
		public const int PlayerIdFieldNumber = 3;

		// Token: 0x04007462 RID: 29794
		private int playerId_;

		// Token: 0x04007463 RID: 29795
		public const int LivingListFieldNumber = 7;

		// Token: 0x04007464 RID: 29796
		private static readonly FieldCodec<LivingState> _repeated_livingList_codec = FieldCodec.ForMessage<LivingState>(58U, LivingState.Parser);

		// Token: 0x04007465 RID: 29797
		private readonly RepeatedField<LivingState> livingList_ = new RepeatedField<LivingState>();
	}
}
