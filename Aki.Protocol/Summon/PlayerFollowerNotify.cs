using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Summon
{
	// Token: 0x02001676 RID: 5750
	[NetMessage(EMessageId.PlayerFollowerNotify)]
	public sealed class PlayerFollowerNotify : IMessage<PlayerFollowerNotify>, IMessage, IEquatable<PlayerFollowerNotify>, IDeepCloneable<PlayerFollowerNotify>, IBufferMessage
	{
		// Token: 0x0601CAF7 RID: 117495 RVA: 0x00424068 File Offset: 0x00422268
		[NullableContext(1)]
		public static PlayerFollowerNotify Create()
		{
			return new PlayerFollowerNotify();
		}

		// Token: 0x170060AE RID: 24750
		// (get) Token: 0x0601CAF8 RID: 117496 RVA: 0x0042406F File Offset: 0x0042226F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060AF RID: 24751
		// (get) Token: 0x0601CAF9 RID: 117497 RVA: 0x00424072 File Offset: 0x00422272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerFollowerNotify.Descriptor;
			}
		}

		// Token: 0x0601CAFA RID: 117498 RVA: 0x00424079 File Offset: 0x00422279
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFollowerNotify()
		{
		}

		// Token: 0x0601CAFB RID: 117499 RVA: 0x0042408C File Offset: 0x0042228C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFollowerNotify(PlayerFollowerNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.listPlayerFollowerPb_ = other.listPlayerFollowerPb_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CAFC RID: 117500 RVA: 0x004240C2 File Offset: 0x004222C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFollowerNotify Clone()
		{
			return new PlayerFollowerNotify(this);
		}

		// Token: 0x170060B0 RID: 24752
		// (get) Token: 0x0601CAFD RID: 117501 RVA: 0x004240CA File Offset: 0x004222CA
		// (set) Token: 0x0601CAFE RID: 117502 RVA: 0x004240D2 File Offset: 0x004222D2
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

		// Token: 0x170060B1 RID: 24753
		// (get) Token: 0x0601CAFF RID: 117503 RVA: 0x004240DB File Offset: 0x004222DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerFollowerPb> ListPlayerFollowerPb
		{
			get
			{
				return this.listPlayerFollowerPb_;
			}
		}

		// Token: 0x0601CB00 RID: 117504 RVA: 0x004240E3 File Offset: 0x004222E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerFollowerNotify);
		}

		// Token: 0x0601CB01 RID: 117505 RVA: 0x004240F4 File Offset: 0x004222F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerFollowerNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.listPlayerFollowerPb_.Equals(other.listPlayerFollowerPb_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CB02 RID: 117506 RVA: 0x00424144 File Offset: 0x00422344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			num ^= this.listPlayerFollowerPb_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CB03 RID: 117507 RVA: 0x00424191 File Offset: 0x00422391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CB04 RID: 117508 RVA: 0x0042419E File Offset: 0x0042239E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CB05 RID: 117509 RVA: 0x004241A8 File Offset: 0x004223A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.listPlayerFollowerPb_.WriteTo(ref output, PlayerFollowerNotify._repeated_listPlayerFollowerPb_codec);
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CB06 RID: 117510 RVA: 0x004241F8 File Offset: 0x004223F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			num += this.listPlayerFollowerPb_.CalculateSize(PlayerFollowerNotify._repeated_listPlayerFollowerPb_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CB07 RID: 117511 RVA: 0x0042424C File Offset: 0x0042244C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerFollowerNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this.listPlayerFollowerPb_.Add(other.listPlayerFollowerPb_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CB08 RID: 117512 RVA: 0x00424299 File Offset: 0x00422499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CB09 RID: 117513 RVA: 0x004242A4 File Offset: 0x004224A4
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
				if (num != 82U)
				{
					if (num != 104U)
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
					this.listPlayerFollowerPb_.AddEntriesFrom(ref input, PlayerFollowerNotify._repeated_listPlayerFollowerPb_codec);
				}
			}
		}

		// Token: 0x0400C1CE RID: 49614
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C1CF RID: 49615
		public const int PlayerIdFieldNumber = 13;

		// Token: 0x0400C1D0 RID: 49616
		private int playerId_;

		// Token: 0x0400C1D1 RID: 49617
		public const int ListPlayerFollowerPbFieldNumber = 10;

		// Token: 0x0400C1D2 RID: 49618
		private static readonly FieldCodec<PlayerFollowerPb> _repeated_listPlayerFollowerPb_codec = FieldCodec.ForMessage<PlayerFollowerPb>(82U, PlayerFollowerPb.Parser);

		// Token: 0x0400C1D3 RID: 49619
		private readonly RepeatedField<PlayerFollowerPb> listPlayerFollowerPb_ = new RepeatedField<PlayerFollowerPb>();
	}
}
