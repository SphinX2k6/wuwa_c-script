using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ECE RID: 3790
	[NetMessage(EMessageId.ReceiveRechallengePlayerIdsNotify)]
	public sealed class ReceiveRechallengePlayerIdsNotify : IMessage<ReceiveRechallengePlayerIdsNotify>, IMessage, IEquatable<ReceiveRechallengePlayerIdsNotify>, IDeepCloneable<ReceiveRechallengePlayerIdsNotify>, IBufferMessage
	{
		// Token: 0x06014512 RID: 83218 RVA: 0x002F3D08 File Offset: 0x002F1F08
		[NullableContext(1)]
		public static ReceiveRechallengePlayerIdsNotify Create()
		{
			return new ReceiveRechallengePlayerIdsNotify();
		}

		// Token: 0x17004388 RID: 17288
		// (get) Token: 0x06014513 RID: 83219 RVA: 0x002F3D0F File Offset: 0x002F1F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004389 RID: 17289
		// (get) Token: 0x06014514 RID: 83220 RVA: 0x002F3D12 File Offset: 0x002F1F12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReceiveRechallengePlayerIdsNotify.Descriptor;
			}
		}

		// Token: 0x06014515 RID: 83221 RVA: 0x002F3D19 File Offset: 0x002F1F19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReceiveRechallengePlayerIdsNotify()
		{
		}

		// Token: 0x06014516 RID: 83222 RVA: 0x002F3D2C File Offset: 0x002F1F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReceiveRechallengePlayerIdsNotify(ReceiveRechallengePlayerIdsNotify other) : this()
		{
			this.playerIds_ = other.playerIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014517 RID: 83223 RVA: 0x002F3D56 File Offset: 0x002F1F56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReceiveRechallengePlayerIdsNotify Clone()
		{
			return new ReceiveRechallengePlayerIdsNotify(this);
		}

		// Token: 0x1700438A RID: 17290
		// (get) Token: 0x06014518 RID: 83224 RVA: 0x002F3D5E File Offset: 0x002F1F5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PlayerIds
		{
			get
			{
				return this.playerIds_;
			}
		}

		// Token: 0x06014519 RID: 83225 RVA: 0x002F3D66 File Offset: 0x002F1F66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReceiveRechallengePlayerIdsNotify);
		}

		// Token: 0x0601451A RID: 83226 RVA: 0x002F3D74 File Offset: 0x002F1F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReceiveRechallengePlayerIdsNotify other)
		{
			return other != null && (other == this || (this.playerIds_.Equals(other.playerIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601451B RID: 83227 RVA: 0x002F3DA8 File Offset: 0x002F1FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.playerIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601451C RID: 83228 RVA: 0x002F3DDC File Offset: 0x002F1FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601451D RID: 83229 RVA: 0x002F3DE9 File Offset: 0x002F1FE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601451E RID: 83230 RVA: 0x002F3DF2 File Offset: 0x002F1FF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.playerIds_.WriteTo(ref output, ReceiveRechallengePlayerIdsNotify._repeated_playerIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601451F RID: 83231 RVA: 0x002F3E1C File Offset: 0x002F201C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.playerIds_.CalculateSize(ReceiveRechallengePlayerIdsNotify._repeated_playerIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014520 RID: 83232 RVA: 0x002F3E55 File Offset: 0x002F2055
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReceiveRechallengePlayerIdsNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.playerIds_.Add(other.playerIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014521 RID: 83233 RVA: 0x002F3E83 File Offset: 0x002F2083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014522 RID: 83234 RVA: 0x002F3E8C File Offset: 0x002F208C
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
				if (num != 32U && num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.playerIds_.AddEntriesFrom(ref input, ReceiveRechallengePlayerIdsNotify._repeated_playerIds_codec);
				}
			}
		}

		// Token: 0x04007B63 RID: 31587
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B64 RID: 31588
		public const int PlayerIdsFieldNumber = 4;

		// Token: 0x04007B65 RID: 31589
		private static readonly FieldCodec<int> _repeated_playerIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04007B66 RID: 31590
		private readonly RepeatedField<int> playerIds_ = new RepeatedField<int>();
	}
}
