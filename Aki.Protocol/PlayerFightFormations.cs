using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D7D RID: 3453
	public sealed class PlayerFightFormations : IMessage<PlayerFightFormations>, IMessage, IEquatable<PlayerFightFormations>, IDeepCloneable<PlayerFightFormations>, IBufferMessage
	{
		// Token: 0x06012A58 RID: 76376 RVA: 0x002B9638 File Offset: 0x002B7838
		[NullableContext(1)]
		public static PlayerFightFormations Create()
		{
			return new PlayerFightFormations();
		}

		// Token: 0x17003DE3 RID: 15843
		// (get) Token: 0x06012A59 RID: 76377 RVA: 0x002B963F File Offset: 0x002B783F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerFightFormations> Parser
		{
			get
			{
				return PlayerFightFormations._parser;
			}
		}

		// Token: 0x17003DE4 RID: 15844
		// (get) Token: 0x06012A5A RID: 76378 RVA: 0x002B9646 File Offset: 0x002B7846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DE5 RID: 15845
		// (get) Token: 0x06012A5B RID: 76379 RVA: 0x002B9649 File Offset: 0x002B7849
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerFightFormations.Descriptor;
			}
		}

		// Token: 0x06012A5C RID: 76380 RVA: 0x002B9650 File Offset: 0x002B7850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFightFormations()
		{
		}

		// Token: 0x06012A5D RID: 76381 RVA: 0x002B9663 File Offset: 0x002B7863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFightFormations(PlayerFightFormations other) : this()
		{
			this.playerId_ = other.playerId_;
			this.formations_ = other.formations_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012A5E RID: 76382 RVA: 0x002B9699 File Offset: 0x002B7899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFightFormations Clone()
		{
			return new PlayerFightFormations(this);
		}

		// Token: 0x17003DE6 RID: 15846
		// (get) Token: 0x06012A5F RID: 76383 RVA: 0x002B96A1 File Offset: 0x002B78A1
		// (set) Token: 0x06012A60 RID: 76384 RVA: 0x002B96A9 File Offset: 0x002B78A9
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

		// Token: 0x17003DE7 RID: 15847
		// (get) Token: 0x06012A61 RID: 76385 RVA: 0x002B96B2 File Offset: 0x002B78B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FightFormationNotifyInfo> Formations
		{
			get
			{
				return this.formations_;
			}
		}

		// Token: 0x06012A62 RID: 76386 RVA: 0x002B96BA File Offset: 0x002B78BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerFightFormations);
		}

		// Token: 0x06012A63 RID: 76387 RVA: 0x002B96C8 File Offset: 0x002B78C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerFightFormations other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.formations_.Equals(other.formations_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012A64 RID: 76388 RVA: 0x002B9718 File Offset: 0x002B7918
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

		// Token: 0x06012A65 RID: 76389 RVA: 0x002B9765 File Offset: 0x002B7965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012A66 RID: 76390 RVA: 0x002B9772 File Offset: 0x002B7972
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012A67 RID: 76391 RVA: 0x002B977C File Offset: 0x002B797C
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

		// Token: 0x06012A68 RID: 76392 RVA: 0x002B97CC File Offset: 0x002B79CC
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

		// Token: 0x06012A69 RID: 76393 RVA: 0x002B9820 File Offset: 0x002B7A20
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

		// Token: 0x06012A6A RID: 76394 RVA: 0x002B986D File Offset: 0x002B7A6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012A6B RID: 76395 RVA: 0x002B9878 File Offset: 0x002B7A78
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

		// Token: 0x0400742E RID: 29742
		private static readonly MessageParser<PlayerFightFormations> _parser = new MessageParser<PlayerFightFormations>(() => new PlayerFightFormations());

		// Token: 0x0400742F RID: 29743
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007430 RID: 29744
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04007431 RID: 29745
		private int playerId_;

		// Token: 0x04007432 RID: 29746
		public const int FormationsFieldNumber = 2;

		// Token: 0x04007433 RID: 29747
		private static readonly FieldCodec<FightFormationNotifyInfo> _repeated_formations_codec = FieldCodec.ForMessage<FightFormationNotifyInfo>(18U, FightFormationNotifyInfo.Parser);

		// Token: 0x04007434 RID: 29748
		private readonly RepeatedField<FightFormationNotifyInfo> formations_ = new RepeatedField<FightFormationNotifyInfo>();
	}
}
