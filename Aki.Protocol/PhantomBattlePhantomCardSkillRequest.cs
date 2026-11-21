using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C8D RID: 3213
	[NetMessage(EMessageId.PhantomBattlePhantomCardSkillRequest)]
	public sealed class PhantomBattlePhantomCardSkillRequest : IMessage<PhantomBattlePhantomCardSkillRequest>, IMessage, IEquatable<PhantomBattlePhantomCardSkillRequest>, IDeepCloneable<PhantomBattlePhantomCardSkillRequest>, IBufferMessage
	{
		// Token: 0x060116F7 RID: 71415 RVA: 0x0028E659 File Offset: 0x0028C859
		[NullableContext(1)]
		public static PhantomBattlePhantomCardSkillRequest Create()
		{
			return new PhantomBattlePhantomCardSkillRequest();
		}

		// Token: 0x170039BE RID: 14782
		// (get) Token: 0x060116F8 RID: 71416 RVA: 0x0028E660 File Offset: 0x0028C860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039BF RID: 14783
		// (get) Token: 0x060116F9 RID: 71417 RVA: 0x0028E663 File Offset: 0x0028C863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattlePhantomCardSkillRequest.Descriptor;
			}
		}

		// Token: 0x060116FA RID: 71418 RVA: 0x0028E66A File Offset: 0x0028C86A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattlePhantomCardSkillRequest()
		{
		}

		// Token: 0x060116FB RID: 71419 RVA: 0x0028E672 File Offset: 0x0028C872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattlePhantomCardSkillRequest(PhantomBattlePhantomCardSkillRequest other) : this()
		{
			this.cardUid_ = other.cardUid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060116FC RID: 71420 RVA: 0x0028E697 File Offset: 0x0028C897
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattlePhantomCardSkillRequest Clone()
		{
			return new PhantomBattlePhantomCardSkillRequest(this);
		}

		// Token: 0x170039C0 RID: 14784
		// (get) Token: 0x060116FD RID: 71421 RVA: 0x0028E69F File Offset: 0x0028C89F
		// (set) Token: 0x060116FE RID: 71422 RVA: 0x0028E6A7 File Offset: 0x0028C8A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardUid
		{
			get
			{
				return this.cardUid_;
			}
			set
			{
				this.cardUid_ = value;
			}
		}

		// Token: 0x060116FF RID: 71423 RVA: 0x0028E6B0 File Offset: 0x0028C8B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattlePhantomCardSkillRequest);
		}

		// Token: 0x06011700 RID: 71424 RVA: 0x0028E6BE File Offset: 0x0028C8BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattlePhantomCardSkillRequest other)
		{
			return other != null && (other == this || (this.CardUid == other.CardUid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011701 RID: 71425 RVA: 0x0028E6EC File Offset: 0x0028C8EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CardUid != 0)
			{
				num ^= this.CardUid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011702 RID: 71426 RVA: 0x0028E72B File Offset: 0x0028C92B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011703 RID: 71427 RVA: 0x0028E738 File Offset: 0x0028C938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011704 RID: 71428 RVA: 0x0028E741 File Offset: 0x0028C941
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardUid != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CardUid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011705 RID: 71429 RVA: 0x0028E774 File Offset: 0x0028C974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CardUid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardUid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011706 RID: 71430 RVA: 0x0028E7B2 File Offset: 0x0028C9B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattlePhantomCardSkillRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CardUid != 0)
			{
				this.CardUid = other.CardUid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011707 RID: 71431 RVA: 0x0028E7E3 File Offset: 0x0028C9E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011708 RID: 71432 RVA: 0x0028E7EC File Offset: 0x0028C9EC
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CardUid = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006E70 RID: 28272
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E71 RID: 28273
		public const int CardUidFieldNumber = 1;

		// Token: 0x04006E72 RID: 28274
		private int cardUid_;
	}
}
