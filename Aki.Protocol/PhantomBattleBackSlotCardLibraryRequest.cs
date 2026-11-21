using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C1D RID: 3101
	[NetMessage(EMessageId.PhantomBattleBackSlotCardLibraryRequest)]
	public sealed class PhantomBattleBackSlotCardLibraryRequest : IMessage<PhantomBattleBackSlotCardLibraryRequest>, IMessage, IEquatable<PhantomBattleBackSlotCardLibraryRequest>, IDeepCloneable<PhantomBattleBackSlotCardLibraryRequest>, IBufferMessage
	{
		// Token: 0x06010D90 RID: 69008 RVA: 0x002782A3 File Offset: 0x002764A3
		[NullableContext(1)]
		public static PhantomBattleBackSlotCardLibraryRequest Create()
		{
			return new PhantomBattleBackSlotCardLibraryRequest();
		}

		// Token: 0x170037A1 RID: 14241
		// (get) Token: 0x06010D91 RID: 69009 RVA: 0x002782AA File Offset: 0x002764AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037A2 RID: 14242
		// (get) Token: 0x06010D92 RID: 69010 RVA: 0x002782AD File Offset: 0x002764AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBackSlotCardLibraryRequest.Descriptor;
			}
		}

		// Token: 0x06010D93 RID: 69011 RVA: 0x002782B4 File Offset: 0x002764B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBackSlotCardLibraryRequest()
		{
		}

		// Token: 0x06010D94 RID: 69012 RVA: 0x002782BC File Offset: 0x002764BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBackSlotCardLibraryRequest(PhantomBattleBackSlotCardLibraryRequest other) : this()
		{
			this.cardUid_ = other.cardUid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010D95 RID: 69013 RVA: 0x002782E1 File Offset: 0x002764E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBackSlotCardLibraryRequest Clone()
		{
			return new PhantomBattleBackSlotCardLibraryRequest(this);
		}

		// Token: 0x170037A3 RID: 14243
		// (get) Token: 0x06010D96 RID: 69014 RVA: 0x002782E9 File Offset: 0x002764E9
		// (set) Token: 0x06010D97 RID: 69015 RVA: 0x002782F1 File Offset: 0x002764F1
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

		// Token: 0x06010D98 RID: 69016 RVA: 0x002782FA File Offset: 0x002764FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBackSlotCardLibraryRequest);
		}

		// Token: 0x06010D99 RID: 69017 RVA: 0x00278308 File Offset: 0x00276508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBackSlotCardLibraryRequest other)
		{
			return other != null && (other == this || (this.CardUid == other.CardUid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010D9A RID: 69018 RVA: 0x00278338 File Offset: 0x00276538
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

		// Token: 0x06010D9B RID: 69019 RVA: 0x00278377 File Offset: 0x00276577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010D9C RID: 69020 RVA: 0x00278384 File Offset: 0x00276584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010D9D RID: 69021 RVA: 0x0027838D File Offset: 0x0027658D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardUid != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.CardUid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010D9E RID: 69022 RVA: 0x002783C0 File Offset: 0x002765C0
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

		// Token: 0x06010D9F RID: 69023 RVA: 0x002783FE File Offset: 0x002765FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleBackSlotCardLibraryRequest other)
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

		// Token: 0x06010DA0 RID: 69024 RVA: 0x0027842F File Offset: 0x0027662F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010DA1 RID: 69025 RVA: 0x00278438 File Offset: 0x00276638
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CardUid = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006B63 RID: 27491
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B64 RID: 27492
		public const int CardUidFieldNumber = 15;

		// Token: 0x04006B65 RID: 27493
		private int cardUid_;
	}
}
