using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200058B RID: 1419
	[NetMessage(EMessageId.FlagChallengeUnlockTeleporterNotify)]
	public sealed class FlagChallengeUnlockTeleporterNotify : IMessage<FlagChallengeUnlockTeleporterNotify>, IMessage, IEquatable<FlagChallengeUnlockTeleporterNotify>, IDeepCloneable<FlagChallengeUnlockTeleporterNotify>, IBufferMessage
	{
		// Token: 0x060083D1 RID: 33745 RVA: 0x0013D9EB File Offset: 0x0013BBEB
		[NullableContext(1)]
		public static FlagChallengeUnlockTeleporterNotify Create()
		{
			return new FlagChallengeUnlockTeleporterNotify();
		}

		// Token: 0x170019AA RID: 6570
		// (get) Token: 0x060083D2 RID: 33746 RVA: 0x0013D9F2 File Offset: 0x0013BBF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019AB RID: 6571
		// (get) Token: 0x060083D3 RID: 33747 RVA: 0x0013D9F5 File Offset: 0x0013BBF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlagChallengeUnlockTeleporterNotify.Descriptor;
			}
		}

		// Token: 0x060083D4 RID: 33748 RVA: 0x0013D9FC File Offset: 0x0013BBFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeUnlockTeleporterNotify()
		{
		}

		// Token: 0x060083D5 RID: 33749 RVA: 0x0013DA0F File Offset: 0x0013BC0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeUnlockTeleporterNotify(FlagChallengeUnlockTeleporterNotify other) : this()
		{
			this.teleporterId_ = other.teleporterId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060083D6 RID: 33750 RVA: 0x0013DA39 File Offset: 0x0013BC39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeUnlockTeleporterNotify Clone()
		{
			return new FlagChallengeUnlockTeleporterNotify(this);
		}

		// Token: 0x170019AC RID: 6572
		// (get) Token: 0x060083D7 RID: 33751 RVA: 0x0013DA41 File Offset: 0x0013BC41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TeleporterId
		{
			get
			{
				return this.teleporterId_;
			}
		}

		// Token: 0x060083D8 RID: 33752 RVA: 0x0013DA49 File Offset: 0x0013BC49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlagChallengeUnlockTeleporterNotify);
		}

		// Token: 0x060083D9 RID: 33753 RVA: 0x0013DA57 File Offset: 0x0013BC57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlagChallengeUnlockTeleporterNotify other)
		{
			return other != null && (other == this || (this.teleporterId_.Equals(other.teleporterId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060083DA RID: 33754 RVA: 0x0013DA8C File Offset: 0x0013BC8C
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

		// Token: 0x060083DB RID: 33755 RVA: 0x0013DAC0 File Offset: 0x0013BCC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060083DC RID: 33756 RVA: 0x0013DACD File Offset: 0x0013BCCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060083DD RID: 33757 RVA: 0x0013DAD6 File Offset: 0x0013BCD6
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

		// Token: 0x060083DE RID: 33758 RVA: 0x0013DB00 File Offset: 0x0013BD00
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

		// Token: 0x060083DF RID: 33759 RVA: 0x0013DB39 File Offset: 0x0013BD39
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

		// Token: 0x060083E0 RID: 33760 RVA: 0x0013DB67 File Offset: 0x0013BD67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060083E1 RID: 33761 RVA: 0x0013DB70 File Offset: 0x0013BD70
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
				if (num != 64U && num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.teleporterId_.AddEntriesFrom(ref input, FlagChallengeUnlockTeleporterNotify._repeated_teleporterId_codec);
				}
			}
		}

		// Token: 0x040041E4 RID: 16868
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041E5 RID: 16869
		public const int TeleporterIdFieldNumber = 8;

		// Token: 0x040041E6 RID: 16870
		private static readonly FieldCodec<int> _repeated_teleporterId_codec = FieldCodec.ForInt32(66U);

		// Token: 0x040041E7 RID: 16871
		private readonly RepeatedField<int> teleporterId_ = new RepeatedField<int>();
	}
}
