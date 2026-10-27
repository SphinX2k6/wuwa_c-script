using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005A0 RID: 1440
	[NetMessage(EMessageId.FlagChallengeUnlockTeleporterNotify)]
	public sealed class FlagChallengeUnlockTeleporterNotify : IMessage<FlagChallengeUnlockTeleporterNotify>, IMessage, IEquatable<FlagChallengeUnlockTeleporterNotify>, IDeepCloneable<FlagChallengeUnlockTeleporterNotify>, IBufferMessage
	{
		// Token: 0x06008539 RID: 34105 RVA: 0x001405F3 File Offset: 0x0013E7F3
		[NullableContext(1)]
		public static FlagChallengeUnlockTeleporterNotify Create()
		{
			return new FlagChallengeUnlockTeleporterNotify();
		}

		// Token: 0x170019F7 RID: 6647
		// (get) Token: 0x0600853A RID: 34106 RVA: 0x001405FA File Offset: 0x0013E7FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019F8 RID: 6648
		// (get) Token: 0x0600853B RID: 34107 RVA: 0x001405FD File Offset: 0x0013E7FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlagChallengeUnlockTeleporterNotify.Descriptor;
			}
		}

		// Token: 0x0600853C RID: 34108 RVA: 0x00140604 File Offset: 0x0013E804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeUnlockTeleporterNotify()
		{
		}

		// Token: 0x0600853D RID: 34109 RVA: 0x00140617 File Offset: 0x0013E817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeUnlockTeleporterNotify(FlagChallengeUnlockTeleporterNotify other) : this()
		{
			this.teleporterId_ = other.teleporterId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600853E RID: 34110 RVA: 0x00140641 File Offset: 0x0013E841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeUnlockTeleporterNotify Clone()
		{
			return new FlagChallengeUnlockTeleporterNotify(this);
		}

		// Token: 0x170019F9 RID: 6649
		// (get) Token: 0x0600853F RID: 34111 RVA: 0x00140649 File Offset: 0x0013E849
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TeleporterId
		{
			get
			{
				return this.teleporterId_;
			}
		}

		// Token: 0x06008540 RID: 34112 RVA: 0x00140651 File Offset: 0x0013E851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlagChallengeUnlockTeleporterNotify);
		}

		// Token: 0x06008541 RID: 34113 RVA: 0x0014065F File Offset: 0x0013E85F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlagChallengeUnlockTeleporterNotify other)
		{
			return other != null && (other == this || (this.teleporterId_.Equals(other.teleporterId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008542 RID: 34114 RVA: 0x00140694 File Offset: 0x0013E894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.teleporterId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008543 RID: 34115 RVA: 0x001406C8 File Offset: 0x0013E8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008544 RID: 34116 RVA: 0x001406D5 File Offset: 0x0013E8D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008545 RID: 34117 RVA: 0x001406DE File Offset: 0x0013E8DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.teleporterId_.WriteTo(ref output, FlagChallengeUnlockTeleporterNotify._repeated_teleporterId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008546 RID: 34118 RVA: 0x00140708 File Offset: 0x0013E908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.teleporterId_.CalculateSize(FlagChallengeUnlockTeleporterNotify._repeated_teleporterId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008547 RID: 34119 RVA: 0x00140741 File Offset: 0x0013E941
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlagChallengeUnlockTeleporterNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.teleporterId_.Add(other.teleporterId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008548 RID: 34120 RVA: 0x0014076F File Offset: 0x0013E96F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008549 RID: 34121 RVA: 0x00140778 File Offset: 0x0013E978
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.teleporterId_.AddEntriesFrom(ref input, FlagChallengeUnlockTeleporterNotify._repeated_teleporterId_codec);
				}
			}
		}

		// Token: 0x040041EE RID: 16878
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041EF RID: 16879
		public const int TeleporterIdFieldNumber = 1;

		// Token: 0x040041F0 RID: 16880
		private static readonly FieldCodec<int> _repeated_teleporterId_codec = FieldCodec.ForInt32(10U);

		// Token: 0x040041F1 RID: 16881
		private readonly RepeatedField<int> teleporterId_ = new RepeatedField<int>();
	}
}
