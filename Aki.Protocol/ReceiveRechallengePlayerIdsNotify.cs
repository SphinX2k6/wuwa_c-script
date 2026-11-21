using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EBE RID: 3774
	[NetMessage(EMessageId.ReceiveRechallengePlayerIdsNotify)]
	public sealed class ReceiveRechallengePlayerIdsNotify : IMessage<ReceiveRechallengePlayerIdsNotify>, IMessage, IEquatable<ReceiveRechallengePlayerIdsNotify>, IDeepCloneable<ReceiveRechallengePlayerIdsNotify>, IBufferMessage
	{
		// Token: 0x0601442D RID: 82989 RVA: 0x002F2654 File Offset: 0x002F0854
		[NullableContext(1)]
		public static ReceiveRechallengePlayerIdsNotify Create()
		{
			return new ReceiveRechallengePlayerIdsNotify();
		}

		// Token: 0x1700435E RID: 17246
		// (get) Token: 0x0601442E RID: 82990 RVA: 0x002F265B File Offset: 0x002F085B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700435F RID: 17247
		// (get) Token: 0x0601442F RID: 82991 RVA: 0x002F265E File Offset: 0x002F085E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReceiveRechallengePlayerIdsNotify.Descriptor;
			}
		}

		// Token: 0x06014430 RID: 82992 RVA: 0x002F2665 File Offset: 0x002F0865
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReceiveRechallengePlayerIdsNotify()
		{
		}

		// Token: 0x06014431 RID: 82993 RVA: 0x002F2678 File Offset: 0x002F0878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReceiveRechallengePlayerIdsNotify(ReceiveRechallengePlayerIdsNotify other) : this()
		{
			this.playerIds_ = other.playerIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014432 RID: 82994 RVA: 0x002F26A2 File Offset: 0x002F08A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReceiveRechallengePlayerIdsNotify Clone()
		{
			return new ReceiveRechallengePlayerIdsNotify(this);
		}

		// Token: 0x17004360 RID: 17248
		// (get) Token: 0x06014433 RID: 82995 RVA: 0x002F26AA File Offset: 0x002F08AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PlayerIds
		{
			get
			{
				return this.playerIds_;
			}
		}

		// Token: 0x06014434 RID: 82996 RVA: 0x002F26B2 File Offset: 0x002F08B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReceiveRechallengePlayerIdsNotify);
		}

		// Token: 0x06014435 RID: 82997 RVA: 0x002F26C0 File Offset: 0x002F08C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReceiveRechallengePlayerIdsNotify other)
		{
			return other != null && (other == this || (this.playerIds_.Equals(other.playerIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014436 RID: 82998 RVA: 0x002F26F4 File Offset: 0x002F08F4
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

		// Token: 0x06014437 RID: 82999 RVA: 0x002F2728 File Offset: 0x002F0928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014438 RID: 83000 RVA: 0x002F2735 File Offset: 0x002F0935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014439 RID: 83001 RVA: 0x002F273E File Offset: 0x002F093E
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

		// Token: 0x0601443A RID: 83002 RVA: 0x002F2768 File Offset: 0x002F0968
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

		// Token: 0x0601443B RID: 83003 RVA: 0x002F27A1 File Offset: 0x002F09A1
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

		// Token: 0x0601443C RID: 83004 RVA: 0x002F27CF File Offset: 0x002F09CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601443D RID: 83005 RVA: 0x002F27D8 File Offset: 0x002F09D8
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
					this.playerIds_.AddEntriesFrom(ref input, ReceiveRechallengePlayerIdsNotify._repeated_playerIds_codec);
				}
			}
		}

		// Token: 0x04007B8D RID: 31629
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B8E RID: 31630
		public const int PlayerIdsFieldNumber = 1;

		// Token: 0x04007B8F RID: 31631
		private static readonly FieldCodec<int> _repeated_playerIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04007B90 RID: 31632
		private readonly RepeatedField<int> playerIds_ = new RepeatedField<int>();
	}
}
