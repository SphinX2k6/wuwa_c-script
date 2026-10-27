using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C2D RID: 3117
	[NetMessage(EMessageId.PhantomBattleBackSlotCardLibraryRequest)]
	public sealed class PhantomBattleBackSlotCardLibraryRequest : IMessage<PhantomBattleBackSlotCardLibraryRequest>, IMessage, IEquatable<PhantomBattleBackSlotCardLibraryRequest>, IDeepCloneable<PhantomBattleBackSlotCardLibraryRequest>, IBufferMessage
	{
		// Token: 0x06010E90 RID: 69264 RVA: 0x0027A007 File Offset: 0x00278207
		[NullableContext(1)]
		public static PhantomBattleBackSlotCardLibraryRequest Create()
		{
			return new PhantomBattleBackSlotCardLibraryRequest();
		}

		// Token: 0x170037D8 RID: 14296
		// (get) Token: 0x06010E91 RID: 69265 RVA: 0x0027A00E File Offset: 0x0027820E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037D9 RID: 14297
		// (get) Token: 0x06010E92 RID: 69266 RVA: 0x0027A011 File Offset: 0x00278211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBackSlotCardLibraryRequest.Descriptor;
			}
		}

		// Token: 0x06010E93 RID: 69267 RVA: 0x0027A018 File Offset: 0x00278218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBackSlotCardLibraryRequest()
		{
		}

		// Token: 0x06010E94 RID: 69268 RVA: 0x0027A020 File Offset: 0x00278220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBackSlotCardLibraryRequest(PhantomBattleBackSlotCardLibraryRequest other) : this()
		{
			this.cardUid_ = other.cardUid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010E95 RID: 69269 RVA: 0x0027A045 File Offset: 0x00278245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBackSlotCardLibraryRequest Clone()
		{
			return new PhantomBattleBackSlotCardLibraryRequest(this);
		}

		// Token: 0x170037DA RID: 14298
		// (get) Token: 0x06010E96 RID: 69270 RVA: 0x0027A04D File Offset: 0x0027824D
		// (set) Token: 0x06010E97 RID: 69271 RVA: 0x0027A055 File Offset: 0x00278255
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

		// Token: 0x06010E98 RID: 69272 RVA: 0x0027A05E File Offset: 0x0027825E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBackSlotCardLibraryRequest);
		}

		// Token: 0x06010E99 RID: 69273 RVA: 0x0027A06C File Offset: 0x0027826C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBackSlotCardLibraryRequest other)
		{
			return other != null && (other == this || (this.CardUid == other.CardUid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010E9A RID: 69274 RVA: 0x0027A09C File Offset: 0x0027829C
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

		// Token: 0x06010E9B RID: 69275 RVA: 0x0027A0DB File Offset: 0x002782DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010E9C RID: 69276 RVA: 0x0027A0E8 File Offset: 0x002782E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010E9D RID: 69277 RVA: 0x0027A0F1 File Offset: 0x002782F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardUid != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.CardUid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010E9E RID: 69278 RVA: 0x0027A124 File Offset: 0x00278324
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

		// Token: 0x06010E9F RID: 69279 RVA: 0x0027A162 File Offset: 0x00278362
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

		// Token: 0x06010EA0 RID: 69280 RVA: 0x0027A193 File Offset: 0x00278393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010EA1 RID: 69281 RVA: 0x0027A19C File Offset: 0x0027839C
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CardUid = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006B4F RID: 27471
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B50 RID: 27472
		public const int CardUidFieldNumber = 8;

		// Token: 0x04006B51 RID: 27473
		private int cardUid_;
	}
}
