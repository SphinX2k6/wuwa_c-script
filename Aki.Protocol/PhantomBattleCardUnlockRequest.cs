using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C67 RID: 3175
	[NetMessage(EMessageId.PhantomBattleCardUnlockRequest)]
	public sealed class PhantomBattleCardUnlockRequest : IMessage<PhantomBattleCardUnlockRequest>, IMessage, IEquatable<PhantomBattleCardUnlockRequest>, IDeepCloneable<PhantomBattleCardUnlockRequest>, IBufferMessage
	{
		// Token: 0x06011362 RID: 70498 RVA: 0x00285138 File Offset: 0x00283338
		[NullableContext(1)]
		public static PhantomBattleCardUnlockRequest Create()
		{
			return new PhantomBattleCardUnlockRequest();
		}

		// Token: 0x170038E9 RID: 14569
		// (get) Token: 0x06011363 RID: 70499 RVA: 0x0028513F File Offset: 0x0028333F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038EA RID: 14570
		// (get) Token: 0x06011364 RID: 70500 RVA: 0x00285142 File Offset: 0x00283342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardUnlockRequest.Descriptor;
			}
		}

		// Token: 0x06011365 RID: 70501 RVA: 0x00285149 File Offset: 0x00283349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardUnlockRequest()
		{
		}

		// Token: 0x06011366 RID: 70502 RVA: 0x00285151 File Offset: 0x00283351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardUnlockRequest(PhantomBattleCardUnlockRequest other) : this()
		{
			this.cardId_ = other.cardId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011367 RID: 70503 RVA: 0x00285176 File Offset: 0x00283376
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardUnlockRequest Clone()
		{
			return new PhantomBattleCardUnlockRequest(this);
		}

		// Token: 0x170038EB RID: 14571
		// (get) Token: 0x06011368 RID: 70504 RVA: 0x0028517E File Offset: 0x0028337E
		// (set) Token: 0x06011369 RID: 70505 RVA: 0x00285186 File Offset: 0x00283386
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

		// Token: 0x0601136A RID: 70506 RVA: 0x0028518F File Offset: 0x0028338F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardUnlockRequest);
		}

		// Token: 0x0601136B RID: 70507 RVA: 0x0028519D File Offset: 0x0028339D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardUnlockRequest other)
		{
			return other != null && (other == this || (this.CardId == other.CardId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601136C RID: 70508 RVA: 0x002851CC File Offset: 0x002833CC
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

		// Token: 0x0601136D RID: 70509 RVA: 0x0028520B File Offset: 0x0028340B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601136E RID: 70510 RVA: 0x00285218 File Offset: 0x00283418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601136F RID: 70511 RVA: 0x00285221 File Offset: 0x00283421
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CardId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011370 RID: 70512 RVA: 0x00285254 File Offset: 0x00283454
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

		// Token: 0x06011371 RID: 70513 RVA: 0x00285292 File Offset: 0x00283492
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

		// Token: 0x06011372 RID: 70514 RVA: 0x002852C3 File Offset: 0x002834C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011373 RID: 70515 RVA: 0x002852CC File Offset: 0x002834CC
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CardId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006CDE RID: 27870
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006CDF RID: 27871
		public const int CardIdFieldNumber = 4;

		// Token: 0x04006CE0 RID: 27872
		private int cardId_;
	}
}
