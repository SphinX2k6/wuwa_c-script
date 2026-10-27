using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D98 RID: 3480
	[NetMessage(EMessageId.PlayerLivingStatesNotify)]
	public sealed class PlayerLivingStatesNotify : IMessage<PlayerLivingStatesNotify>, IMessage, IEquatable<PlayerLivingStatesNotify>, IDeepCloneable<PlayerLivingStatesNotify>, IBufferMessage
	{
		// Token: 0x06012C26 RID: 76838 RVA: 0x002BCC00 File Offset: 0x002BAE00
		[NullableContext(1)]
		public static PlayerLivingStatesNotify Create()
		{
			return new PlayerLivingStatesNotify();
		}

		// Token: 0x17003E40 RID: 15936
		// (get) Token: 0x06012C27 RID: 76839 RVA: 0x002BCC07 File Offset: 0x002BAE07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E41 RID: 15937
		// (get) Token: 0x06012C28 RID: 76840 RVA: 0x002BCC0A File Offset: 0x002BAE0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerLivingStatesNotify.Descriptor;
			}
		}

		// Token: 0x06012C29 RID: 76841 RVA: 0x002BCC11 File Offset: 0x002BAE11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerLivingStatesNotify()
		{
		}

		// Token: 0x06012C2A RID: 76842 RVA: 0x002BCC24 File Offset: 0x002BAE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerLivingStatesNotify(PlayerLivingStatesNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.livingList_ = other.livingList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012C2B RID: 76843 RVA: 0x002BCC5A File Offset: 0x002BAE5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerLivingStatesNotify Clone()
		{
			return new PlayerLivingStatesNotify(this);
		}

		// Token: 0x17003E42 RID: 15938
		// (get) Token: 0x06012C2C RID: 76844 RVA: 0x002BCC62 File Offset: 0x002BAE62
		// (set) Token: 0x06012C2D RID: 76845 RVA: 0x002BCC6A File Offset: 0x002BAE6A
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

		// Token: 0x17003E43 RID: 15939
		// (get) Token: 0x06012C2E RID: 76846 RVA: 0x002BCC73 File Offset: 0x002BAE73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LivingState> LivingList
		{
			get
			{
				return this.livingList_;
			}
		}

		// Token: 0x06012C2F RID: 76847 RVA: 0x002BCC7B File Offset: 0x002BAE7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerLivingStatesNotify);
		}

		// Token: 0x06012C30 RID: 76848 RVA: 0x002BCC8C File Offset: 0x002BAE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerLivingStatesNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.livingList_.Equals(other.livingList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012C31 RID: 76849 RVA: 0x002BCCDC File Offset: 0x002BAEDC
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

		// Token: 0x06012C32 RID: 76850 RVA: 0x002BCD29 File Offset: 0x002BAF29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012C33 RID: 76851 RVA: 0x002BCD36 File Offset: 0x002BAF36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012C34 RID: 76852 RVA: 0x002BCD40 File Offset: 0x002BAF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.livingList_.WriteTo(ref output, PlayerLivingStatesNotify._repeated_livingList_codec);
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012C35 RID: 76853 RVA: 0x002BCD90 File Offset: 0x002BAF90
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

		// Token: 0x06012C36 RID: 76854 RVA: 0x002BCDE4 File Offset: 0x002BAFE4
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

		// Token: 0x06012C37 RID: 76855 RVA: 0x002BCE31 File Offset: 0x002BB031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012C38 RID: 76856 RVA: 0x002BCE3C File Offset: 0x002BB03C
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
					if (num != 40U)
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
					this.livingList_.AddEntriesFrom(ref input, PlayerLivingStatesNotify._repeated_livingList_codec);
				}
			}
		}

		// Token: 0x04007448 RID: 29768
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007449 RID: 29769
		public const int PlayerIdFieldNumber = 5;

		// Token: 0x0400744A RID: 29770
		private int playerId_;

		// Token: 0x0400744B RID: 29771
		public const int LivingListFieldNumber = 3;

		// Token: 0x0400744C RID: 29772
		private static readonly FieldCodec<LivingState> _repeated_livingList_codec = FieldCodec.ForMessage<LivingState>(26U, LivingState.Parser);

		// Token: 0x0400744D RID: 29773
		private readonly RepeatedField<LivingState> livingList_ = new RepeatedField<LivingState>();
	}
}
