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
		// Token: 0x060024BC RID: 9404 RVA: 0x0006265C File Offset: 0x0006085C
		[NullableContext(1)]
		public static ApplyJoinWorldRequest Create()
		{
			return new ApplyJoinWorldRequest();
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x060024BD RID: 9405 RVA: 0x00062663 File Offset: 0x00060863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x060024BE RID: 9406 RVA: 0x00062666 File Offset: 0x00060866
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ApplyJoinWorldRequest.Descriptor;
			}
		}

		// Token: 0x060024BF RID: 9407 RVA: 0x0006266D File Offset: 0x0006086D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyJoinWorldRequest()
		{
		}

		// Token: 0x060024C0 RID: 9408 RVA: 0x00062675 File Offset: 0x00060875
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyJoinWorldRequest(ApplyJoinWorldRequest other) : this()
		{
			this.playerId_ = other.playerId_;
			this.ways_ = other.ways_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060024C1 RID: 9409 RVA: 0x000626A6 File Offset: 0x000608A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyJoinWorldRequest Clone()
		{
			return new ApplyJoinWorldRequest(this);
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x060024C2 RID: 9410 RVA: 0x000626AE File Offset: 0x000608AE
		// (set) Token: 0x060024C3 RID: 9411 RVA: 0x000626B6 File Offset: 0x000608B6
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

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x060024C4 RID: 9412 RVA: 0x000626BF File Offset: 0x000608BF
		// (set) Token: 0x060024C5 RID: 9413 RVA: 0x000626C7 File Offset: 0x000608C7
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

		// Token: 0x060024C6 RID: 9414 RVA: 0x000626D0 File Offset: 0x000608D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ApplyJoinWorldRequest);
		}

		// Token: 0x060024C7 RID: 9415 RVA: 0x000626DE File Offset: 0x000608DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ApplyJoinWorldRequest other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.Ways == other.Ways && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060024C8 RID: 9416 RVA: 0x0006271C File Offset: 0x0006091C
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

		// Token: 0x060024C9 RID: 9417 RVA: 0x0006277A File Offset: 0x0006097A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060024CA RID: 9418 RVA: 0x00062787 File Offset: 0x00060987
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060024CB RID: 9419 RVA: 0x00062790 File Offset: 0x00060990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Ways != WorldEnterWay.LobbyJoin)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Ways);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060024CC RID: 9420 RVA: 0x000627E8 File Offset: 0x000609E8
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

		// Token: 0x060024CD RID: 9421 RVA: 0x00062840 File Offset: 0x00060A40
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

		// Token: 0x060024CE RID: 9422 RVA: 0x00062890 File Offset: 0x00060A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x0006289C File Offset: 0x00060A9C
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
				if (num != 8U)
				{
					if (num != 120U)
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

		// Token: 0x04002592 RID: 9618
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002593 RID: 9619
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04002594 RID: 9620
		private int playerId_;

		// Token: 0x04002595 RID: 9621
		public const int WaysFieldNumber = 15;

		// Token: 0x04002596 RID: 9622
		private WorldEnterWay ways_;
	}
}
