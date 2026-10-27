using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200087F RID: 2175
	[NetMessage(EMessageId.KickMatchTeamPlayerRequest)]
	public sealed class KickMatchTeamPlayerRequest : IMessage<KickMatchTeamPlayerRequest>, IMessage, IEquatable<KickMatchTeamPlayerRequest>, IDeepCloneable<KickMatchTeamPlayerRequest>, IBufferMessage
	{
		// Token: 0x0600C1A6 RID: 49574 RVA: 0x001CC118 File Offset: 0x001CA318
		[NullableContext(1)]
		public static KickMatchTeamPlayerRequest Create()
		{
			return new KickMatchTeamPlayerRequest();
		}

		// Token: 0x17002726 RID: 10022
		// (get) Token: 0x0600C1A7 RID: 49575 RVA: 0x001CC11F File Offset: 0x001CA31F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002727 RID: 10023
		// (get) Token: 0x0600C1A8 RID: 49576 RVA: 0x001CC122 File Offset: 0x001CA322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KickMatchTeamPlayerRequest.Descriptor;
			}
		}

		// Token: 0x0600C1A9 RID: 49577 RVA: 0x001CC129 File Offset: 0x001CA329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KickMatchTeamPlayerRequest()
		{
		}

		// Token: 0x0600C1AA RID: 49578 RVA: 0x001CC131 File Offset: 0x001CA331
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KickMatchTeamPlayerRequest(KickMatchTeamPlayerRequest other) : this()
		{
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C1AB RID: 49579 RVA: 0x001CC156 File Offset: 0x001CA356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KickMatchTeamPlayerRequest Clone()
		{
			return new KickMatchTeamPlayerRequest(this);
		}

		// Token: 0x17002728 RID: 10024
		// (get) Token: 0x0600C1AC RID: 49580 RVA: 0x001CC15E File Offset: 0x001CA35E
		// (set) Token: 0x0600C1AD RID: 49581 RVA: 0x001CC166 File Offset: 0x001CA366
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

		// Token: 0x0600C1AE RID: 49582 RVA: 0x001CC16F File Offset: 0x001CA36F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KickMatchTeamPlayerRequest);
		}

		// Token: 0x0600C1AF RID: 49583 RVA: 0x001CC17D File Offset: 0x001CA37D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KickMatchTeamPlayerRequest other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C1B0 RID: 49584 RVA: 0x001CC1AC File Offset: 0x001CA3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C1B1 RID: 49585 RVA: 0x001CC1EB File Offset: 0x001CA3EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C1B2 RID: 49586 RVA: 0x001CC1F8 File Offset: 0x001CA3F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C1B3 RID: 49587 RVA: 0x001CC201 File Offset: 0x001CA401
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C1B4 RID: 49588 RVA: 0x001CC234 File Offset: 0x001CA434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C1B5 RID: 49589 RVA: 0x001CC272 File Offset: 0x001CA472
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KickMatchTeamPlayerRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C1B6 RID: 49590 RVA: 0x001CC2A3 File Offset: 0x001CA4A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C1B7 RID: 49591 RVA: 0x001CC2AC File Offset: 0x001CA4AC
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040053FA RID: 21498
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053FB RID: 21499
		public const int PlayerIdFieldNumber = 12;

		// Token: 0x040053FC RID: 21500
		private int playerId_;
	}
}
