using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Summon
{
	// Token: 0x02001678 RID: 5752
	public sealed class PlayerFollowersComponentPb : IMessage<PlayerFollowersComponentPb>, IMessage, IEquatable<PlayerFollowersComponentPb>, IDeepCloneable<PlayerFollowersComponentPb>, IBufferMessage
	{
		// Token: 0x0601CB21 RID: 117537 RVA: 0x004245CF File Offset: 0x004227CF
		[NullableContext(1)]
		public static PlayerFollowersComponentPb Create()
		{
			return new PlayerFollowersComponentPb();
		}

		// Token: 0x170060B7 RID: 24759
		// (get) Token: 0x0601CB22 RID: 117538 RVA: 0x004245D6 File Offset: 0x004227D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060B8 RID: 24760
		// (get) Token: 0x0601CB23 RID: 117539 RVA: 0x004245D9 File Offset: 0x004227D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerFollowersComponentPb.Descriptor;
			}
		}

		// Token: 0x0601CB24 RID: 117540 RVA: 0x004245E0 File Offset: 0x004227E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFollowersComponentPb()
		{
		}

		// Token: 0x0601CB25 RID: 117541 RVA: 0x004245F3 File Offset: 0x004227F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFollowersComponentPb(PlayerFollowersComponentPb other) : this()
		{
			this.listPlayerFollowerPb_ = other.listPlayerFollowerPb_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CB26 RID: 117542 RVA: 0x0042461D File Offset: 0x0042281D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFollowersComponentPb Clone()
		{
			return new PlayerFollowersComponentPb(this);
		}

		// Token: 0x170060B9 RID: 24761
		// (get) Token: 0x0601CB27 RID: 117543 RVA: 0x00424625 File Offset: 0x00422825
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerFollowerPb> ListPlayerFollowerPb
		{
			get
			{
				return this.listPlayerFollowerPb_;
			}
		}

		// Token: 0x0601CB28 RID: 117544 RVA: 0x0042462D File Offset: 0x0042282D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerFollowersComponentPb);
		}

		// Token: 0x0601CB29 RID: 117545 RVA: 0x0042463B File Offset: 0x0042283B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerFollowersComponentPb other)
		{
			return other != null && (other == this || (this.listPlayerFollowerPb_.Equals(other.listPlayerFollowerPb_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CB2A RID: 117546 RVA: 0x00424670 File Offset: 0x00422870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.listPlayerFollowerPb_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CB2B RID: 117547 RVA: 0x004246A4 File Offset: 0x004228A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CB2C RID: 117548 RVA: 0x004246B1 File Offset: 0x004228B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CB2D RID: 117549 RVA: 0x004246BA File Offset: 0x004228BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.listPlayerFollowerPb_.WriteTo(ref output, PlayerFollowersComponentPb._repeated_listPlayerFollowerPb_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CB2E RID: 117550 RVA: 0x004246E4 File Offset: 0x004228E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.listPlayerFollowerPb_.CalculateSize(PlayerFollowersComponentPb._repeated_listPlayerFollowerPb_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CB2F RID: 117551 RVA: 0x0042471D File Offset: 0x0042291D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerFollowersComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			this.listPlayerFollowerPb_.Add(other.listPlayerFollowerPb_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CB30 RID: 117552 RVA: 0x0042474B File Offset: 0x0042294B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CB31 RID: 117553 RVA: 0x00424754 File Offset: 0x00422954
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.listPlayerFollowerPb_.AddEntriesFrom(ref input, PlayerFollowersComponentPb._repeated_listPlayerFollowerPb_codec);
				}
			}
		}

		// Token: 0x0400C1DA RID: 49626
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C1DB RID: 49627
		public const int ListPlayerFollowerPbFieldNumber = 1;

		// Token: 0x0400C1DC RID: 49628
		private static readonly FieldCodec<PlayerFollowerPb> _repeated_listPlayerFollowerPb_codec = FieldCodec.ForMessage<PlayerFollowerPb>(10U, PlayerFollowerPb.Parser);

		// Token: 0x0400C1DD RID: 49629
		private readonly RepeatedField<PlayerFollowerPb> listPlayerFollowerPb_ = new RepeatedField<PlayerFollowerPb>();
	}
}
