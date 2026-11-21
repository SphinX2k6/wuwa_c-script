using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Summon
{
	// Token: 0x020016F2 RID: 5874
	[NetMessage(EMessageId.PlayerFollowerNotify)]
	public sealed class PlayerFollowerNotify : IMessage<PlayerFollowerNotify>, IMessage, IEquatable<PlayerFollowerNotify>, IDeepCloneable<PlayerFollowerNotify>, IBufferMessage
	{
		// Token: 0x0601D5C2 RID: 120258 RVA: 0x0043FC88 File Offset: 0x0043DE88
		[NullableContext(1)]
		public static PlayerFollowerNotify Create()
		{
			return new PlayerFollowerNotify();
		}

		// Token: 0x17006351 RID: 25425
		// (get) Token: 0x0601D5C3 RID: 120259 RVA: 0x0043FC8F File Offset: 0x0043DE8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006352 RID: 25426
		// (get) Token: 0x0601D5C4 RID: 120260 RVA: 0x0043FC92 File Offset: 0x0043DE92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerFollowerNotify.Descriptor;
			}
		}

		// Token: 0x0601D5C5 RID: 120261 RVA: 0x0043FC99 File Offset: 0x0043DE99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFollowerNotify()
		{
		}

		// Token: 0x0601D5C6 RID: 120262 RVA: 0x0043FCAC File Offset: 0x0043DEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFollowerNotify(PlayerFollowerNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.listPlayerFollowerPb_ = other.listPlayerFollowerPb_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D5C7 RID: 120263 RVA: 0x0043FCE2 File Offset: 0x0043DEE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFollowerNotify Clone()
		{
			return new PlayerFollowerNotify(this);
		}

		// Token: 0x17006353 RID: 25427
		// (get) Token: 0x0601D5C8 RID: 120264 RVA: 0x0043FCEA File Offset: 0x0043DEEA
		// (set) Token: 0x0601D5C9 RID: 120265 RVA: 0x0043FCF2 File Offset: 0x0043DEF2
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

		// Token: 0x17006354 RID: 25428
		// (get) Token: 0x0601D5CA RID: 120266 RVA: 0x0043FCFB File Offset: 0x0043DEFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerFollowerPb> ListPlayerFollowerPb
		{
			get
			{
				return this.listPlayerFollowerPb_;
			}
		}

		// Token: 0x0601D5CB RID: 120267 RVA: 0x0043FD03 File Offset: 0x0043DF03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerFollowerNotify);
		}

		// Token: 0x0601D5CC RID: 120268 RVA: 0x0043FD14 File Offset: 0x0043DF14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerFollowerNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.listPlayerFollowerPb_.Equals(other.listPlayerFollowerPb_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D5CD RID: 120269 RVA: 0x0043FD64 File Offset: 0x0043DF64
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

		// Token: 0x0601D5CE RID: 120270 RVA: 0x0043FDB1 File Offset: 0x0043DFB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D5CF RID: 120271 RVA: 0x0043FDBE File Offset: 0x0043DFBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D5D0 RID: 120272 RVA: 0x0043FDC8 File Offset: 0x0043DFC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.listPlayerFollowerPb_.WriteTo(ref output, PlayerFollowerNotify._repeated_listPlayerFollowerPb_codec);
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D5D1 RID: 120273 RVA: 0x0043FE18 File Offset: 0x0043E018
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

		// Token: 0x0601D5D2 RID: 120274 RVA: 0x0043FE6C File Offset: 0x0043E06C
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

		// Token: 0x0601D5D3 RID: 120275 RVA: 0x0043FEB9 File Offset: 0x0043E0B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D5D4 RID: 120276 RVA: 0x0043FEC4 File Offset: 0x0043E0C4
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
					if (num != 48U)
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

		// Token: 0x0400C6F7 RID: 50935
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C6F8 RID: 50936
		public const int PlayerIdFieldNumber = 6;

		// Token: 0x0400C6F9 RID: 50937
		private int playerId_;

		// Token: 0x0400C6FA RID: 50938
		public const int ListPlayerFollowerPbFieldNumber = 3;

		// Token: 0x0400C6FB RID: 50939
		private static readonly FieldCodec<PlayerFollowerPb> _repeated_listPlayerFollowerPb_codec = FieldCodec.ForMessage<PlayerFollowerPb>(26U, PlayerFollowerPb.Parser);

		// Token: 0x0400C6FC RID: 50940
		private readonly RepeatedField<PlayerFollowerPb> listPlayerFollowerPb_ = new RepeatedField<PlayerFollowerPb>();
	}
}
