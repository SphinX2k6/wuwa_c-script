using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000106 RID: 262
	[NetMessage(EMessageId.ApplyJoinWorldRequest)]
	public sealed class ApplyJoinWorldRequest : IMessage<ApplyJoinWorldRequest>, IMessage, IEquatable<ApplyJoinWorldRequest>, IDeepCloneable<ApplyJoinWorldRequest>, IBufferMessage
	{
		// Token: 0x060024F3 RID: 9459 RVA: 0x00063130 File Offset: 0x00061330
		[NullableContext(1)]
		public static ApplyJoinWorldRequest Create()
		{
			return new ApplyJoinWorldRequest();
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x060024F4 RID: 9460 RVA: 0x00063137 File Offset: 0x00061337
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x060024F5 RID: 9461 RVA: 0x0006313A File Offset: 0x0006133A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ApplyJoinWorldRequest.Descriptor;
			}
		}

		// Token: 0x060024F6 RID: 9462 RVA: 0x00063141 File Offset: 0x00061341
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyJoinWorldRequest()
		{
		}

		// Token: 0x060024F7 RID: 9463 RVA: 0x00063149 File Offset: 0x00061349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyJoinWorldRequest(ApplyJoinWorldRequest other) : this()
		{
			this.playerId_ = other.playerId_;
			this.ways_ = other.ways_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060024F8 RID: 9464 RVA: 0x0006317A File Offset: 0x0006137A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyJoinWorldRequest Clone()
		{
			return new ApplyJoinWorldRequest(this);
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x060024F9 RID: 9465 RVA: 0x00063182 File Offset: 0x00061382
		// (set) Token: 0x060024FA RID: 9466 RVA: 0x0006318A File Offset: 0x0006138A
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

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x060024FB RID: 9467 RVA: 0x00063193 File Offset: 0x00061393
		// (set) Token: 0x060024FC RID: 9468 RVA: 0x0006319B File Offset: 0x0006139B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldEnterWay Ways
		{
			get
			{
				return this.ways_;
			}
			set
			{
				this.ways_ = value;
			}
		}

		// Token: 0x060024FD RID: 9469 RVA: 0x000631A4 File Offset: 0x000613A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ApplyJoinWorldRequest);
		}

		// Token: 0x060024FE RID: 9470 RVA: 0x000631B2 File Offset: 0x000613B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ApplyJoinWorldRequest other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.Ways == other.Ways && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060024FF RID: 9471 RVA: 0x000631F0 File Offset: 0x000613F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.Ways != WorldEnterWay.LobbyJoin)
			{
				num ^= this.Ways.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002500 RID: 9472 RVA: 0x0006324E File Offset: 0x0006144E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002501 RID: 9473 RVA: 0x0006325B File Offset: 0x0006145B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002502 RID: 9474 RVA: 0x00063264 File Offset: 0x00061464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Ways != WorldEnterWay.LobbyJoin)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.Ways);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002503 RID: 9475 RVA: 0x000632C0 File Offset: 0x000614C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.Ways != WorldEnterWay.LobbyJoin)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Ways);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002504 RID: 9476 RVA: 0x00063318 File Offset: 0x00061518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ApplyJoinWorldRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.Ways != WorldEnterWay.LobbyJoin)
			{
				this.Ways = other.Ways;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002505 RID: 9477 RVA: 0x00063368 File Offset: 0x00061568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002506 RID: 9478 RVA: 0x00063374 File Offset: 0x00061574
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
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Ways = (WorldEnterWay)input.ReadEnum();
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040025F1 RID: 9713
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025F2 RID: 9714
		public const int PlayerIdFieldNumber = 5;

		// Token: 0x040025F3 RID: 9715
		private int playerId_;

		// Token: 0x040025F4 RID: 9716
		public const int WaysFieldNumber = 6;

		// Token: 0x040025F5 RID: 9717
		private WorldEnterWay ways_;
	}
}
