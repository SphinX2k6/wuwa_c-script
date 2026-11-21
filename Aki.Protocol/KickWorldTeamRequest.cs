using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000870 RID: 2160
	[NetMessage(EMessageId.KickWorldTeamRequest)]
	public sealed class KickWorldTeamRequest : IMessage<KickWorldTeamRequest>, IMessage, IEquatable<KickWorldTeamRequest>, IDeepCloneable<KickWorldTeamRequest>, IBufferMessage
	{
		// Token: 0x0600C0AE RID: 49326 RVA: 0x001CA1E9 File Offset: 0x001C83E9
		[NullableContext(1)]
		public static KickWorldTeamRequest Create()
		{
			return new KickWorldTeamRequest();
		}

		// Token: 0x170026ED RID: 9965
		// (get) Token: 0x0600C0AF RID: 49327 RVA: 0x001CA1F0 File Offset: 0x001C83F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026EE RID: 9966
		// (get) Token: 0x0600C0B0 RID: 49328 RVA: 0x001CA1F3 File Offset: 0x001C83F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KickWorldTeamRequest.Descriptor;
			}
		}

		// Token: 0x0600C0B1 RID: 49329 RVA: 0x001CA1FA File Offset: 0x001C83FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KickWorldTeamRequest()
		{
		}

		// Token: 0x0600C0B2 RID: 49330 RVA: 0x001CA202 File Offset: 0x001C8402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KickWorldTeamRequest(KickWorldTeamRequest other) : this()
		{
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C0B3 RID: 49331 RVA: 0x001CA227 File Offset: 0x001C8427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KickWorldTeamRequest Clone()
		{
			return new KickWorldTeamRequest(this);
		}

		// Token: 0x170026EF RID: 9967
		// (get) Token: 0x0600C0B4 RID: 49332 RVA: 0x001CA22F File Offset: 0x001C842F
		// (set) Token: 0x0600C0B5 RID: 49333 RVA: 0x001CA237 File Offset: 0x001C8437
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

		// Token: 0x0600C0B6 RID: 49334 RVA: 0x001CA240 File Offset: 0x001C8440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KickWorldTeamRequest);
		}

		// Token: 0x0600C0B7 RID: 49335 RVA: 0x001CA24E File Offset: 0x001C844E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KickWorldTeamRequest other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C0B8 RID: 49336 RVA: 0x001CA27C File Offset: 0x001C847C
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

		// Token: 0x0600C0B9 RID: 49337 RVA: 0x001CA2BB File Offset: 0x001C84BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C0BA RID: 49338 RVA: 0x001CA2C8 File Offset: 0x001C84C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C0BB RID: 49339 RVA: 0x001CA2D1 File Offset: 0x001C84D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
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

		// Token: 0x0600C0BC RID: 49340 RVA: 0x001CA304 File Offset: 0x001C8504
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

		// Token: 0x0600C0BD RID: 49341 RVA: 0x001CA342 File Offset: 0x001C8542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KickWorldTeamRequest other)
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

		// Token: 0x0600C0BE RID: 49342 RVA: 0x001CA373 File Offset: 0x001C8573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C0BF RID: 49343 RVA: 0x001CA37C File Offset: 0x001C857C
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005407 RID: 21511
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005408 RID: 21512
		public const int PlayerIdFieldNumber = 5;

		// Token: 0x04005409 RID: 21513
		private int playerId_;
	}
}
