using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C1B RID: 3099
	[NetMessage(EMessageId.PhantomBattleBackLibraryRequest)]
	public sealed class PhantomBattleBackLibraryRequest : IMessage<PhantomBattleBackLibraryRequest>, IMessage, IEquatable<PhantomBattleBackLibraryRequest>, IDeepCloneable<PhantomBattleBackLibraryRequest>, IBufferMessage
	{
		// Token: 0x06010D68 RID: 68968 RVA: 0x00277D7A File Offset: 0x00275F7A
		[NullableContext(1)]
		public static PhantomBattleBackLibraryRequest Create()
		{
			return new PhantomBattleBackLibraryRequest();
		}

		// Token: 0x17003799 RID: 14233
		// (get) Token: 0x06010D69 RID: 68969 RVA: 0x00277D81 File Offset: 0x00275F81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700379A RID: 14234
		// (get) Token: 0x06010D6A RID: 68970 RVA: 0x00277D84 File Offset: 0x00275F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBackLibraryRequest.Descriptor;
			}
		}

		// Token: 0x06010D6B RID: 68971 RVA: 0x00277D8B File Offset: 0x00275F8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBackLibraryRequest()
		{
		}

		// Token: 0x06010D6C RID: 68972 RVA: 0x00277D93 File Offset: 0x00275F93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBackLibraryRequest(PhantomBattleBackLibraryRequest other) : this()
		{
			this.cardUid_ = other.cardUid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010D6D RID: 68973 RVA: 0x00277DB8 File Offset: 0x00275FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBackLibraryRequest Clone()
		{
			return new PhantomBattleBackLibraryRequest(this);
		}

		// Token: 0x1700379B RID: 14235
		// (get) Token: 0x06010D6E RID: 68974 RVA: 0x00277DC0 File Offset: 0x00275FC0
		// (set) Token: 0x06010D6F RID: 68975 RVA: 0x00277DC8 File Offset: 0x00275FC8
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

		// Token: 0x06010D70 RID: 68976 RVA: 0x00277DD1 File Offset: 0x00275FD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBackLibraryRequest);
		}

		// Token: 0x06010D71 RID: 68977 RVA: 0x00277DDF File Offset: 0x00275FDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBackLibraryRequest other)
		{
			return other != null && (other == this || (this.CardUid == other.CardUid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010D72 RID: 68978 RVA: 0x00277E10 File Offset: 0x00276010
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

		// Token: 0x06010D73 RID: 68979 RVA: 0x00277E4F File Offset: 0x0027604F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010D74 RID: 68980 RVA: 0x00277E5C File Offset: 0x0027605C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010D75 RID: 68981 RVA: 0x00277E65 File Offset: 0x00276065
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardUid != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CardUid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010D76 RID: 68982 RVA: 0x00277E98 File Offset: 0x00276098
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

		// Token: 0x06010D77 RID: 68983 RVA: 0x00277ED6 File Offset: 0x002760D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleBackLibraryRequest other)
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

		// Token: 0x06010D78 RID: 68984 RVA: 0x00277F07 File Offset: 0x00276107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010D79 RID: 68985 RVA: 0x00277F10 File Offset: 0x00276110
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CardUid = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006B59 RID: 27481
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B5A RID: 27482
		public const int CardUidFieldNumber = 2;

		// Token: 0x04006B5B RID: 27483
		private int cardUid_;
	}
}
