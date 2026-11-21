using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C57 RID: 3159
	[NetMessage(EMessageId.PhantomBattleCardUnlockRequest)]
	public sealed class PhantomBattleCardUnlockRequest : IMessage<PhantomBattleCardUnlockRequest>, IMessage, IEquatable<PhantomBattleCardUnlockRequest>, IDeepCloneable<PhantomBattleCardUnlockRequest>, IBufferMessage
	{
		// Token: 0x06011262 RID: 70242 RVA: 0x002833C8 File Offset: 0x002815C8
		[NullableContext(1)]
		public static PhantomBattleCardUnlockRequest Create()
		{
			return new PhantomBattleCardUnlockRequest();
		}

		// Token: 0x170038B2 RID: 14514
		// (get) Token: 0x06011263 RID: 70243 RVA: 0x002833CF File Offset: 0x002815CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038B3 RID: 14515
		// (get) Token: 0x06011264 RID: 70244 RVA: 0x002833D2 File Offset: 0x002815D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardUnlockRequest.Descriptor;
			}
		}

		// Token: 0x06011265 RID: 70245 RVA: 0x002833D9 File Offset: 0x002815D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardUnlockRequest()
		{
		}

		// Token: 0x06011266 RID: 70246 RVA: 0x002833E1 File Offset: 0x002815E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardUnlockRequest(PhantomBattleCardUnlockRequest other) : this()
		{
			this.cardId_ = other.cardId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011267 RID: 70247 RVA: 0x00283406 File Offset: 0x00281606
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardUnlockRequest Clone()
		{
			return new PhantomBattleCardUnlockRequest(this);
		}

		// Token: 0x170038B4 RID: 14516
		// (get) Token: 0x06011268 RID: 70248 RVA: 0x0028340E File Offset: 0x0028160E
		// (set) Token: 0x06011269 RID: 70249 RVA: 0x00283416 File Offset: 0x00281616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardId
		{
			get
			{
				return this.cardId_;
			}
			set
			{
				this.cardId_ = value;
			}
		}

		// Token: 0x0601126A RID: 70250 RVA: 0x0028341F File Offset: 0x0028161F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardUnlockRequest);
		}

		// Token: 0x0601126B RID: 70251 RVA: 0x0028342D File Offset: 0x0028162D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardUnlockRequest other)
		{
			return other != null && (other == this || (this.CardId == other.CardId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601126C RID: 70252 RVA: 0x0028345C File Offset: 0x0028165C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CardId != 0)
			{
				num ^= this.CardId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601126D RID: 70253 RVA: 0x0028349B File Offset: 0x0028169B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601126E RID: 70254 RVA: 0x002834A8 File Offset: 0x002816A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601126F RID: 70255 RVA: 0x002834B1 File Offset: 0x002816B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.CardId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011270 RID: 70256 RVA: 0x002834E4 File Offset: 0x002816E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011271 RID: 70257 RVA: 0x00283522 File Offset: 0x00281722
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardUnlockRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CardId != 0)
			{
				this.CardId = other.CardId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011272 RID: 70258 RVA: 0x00283553 File Offset: 0x00281753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011273 RID: 70259 RVA: 0x0028355C File Offset: 0x0028175C
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CardId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006CF2 RID: 27890
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006CF3 RID: 27891
		public const int CardIdFieldNumber = 14;

		// Token: 0x04006CF4 RID: 27892
		private int cardId_;
	}
}
