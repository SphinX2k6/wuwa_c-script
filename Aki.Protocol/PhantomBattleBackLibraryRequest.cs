using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C2B RID: 3115
	[NetMessage(EMessageId.PhantomBattleBackLibraryRequest)]
	public sealed class PhantomBattleBackLibraryRequest : IMessage<PhantomBattleBackLibraryRequest>, IMessage, IEquatable<PhantomBattleBackLibraryRequest>, IDeepCloneable<PhantomBattleBackLibraryRequest>, IBufferMessage
	{
		// Token: 0x06010E68 RID: 69224 RVA: 0x00279ADE File Offset: 0x00277CDE
		[NullableContext(1)]
		public static PhantomBattleBackLibraryRequest Create()
		{
			return new PhantomBattleBackLibraryRequest();
		}

		// Token: 0x170037D0 RID: 14288
		// (get) Token: 0x06010E69 RID: 69225 RVA: 0x00279AE5 File Offset: 0x00277CE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037D1 RID: 14289
		// (get) Token: 0x06010E6A RID: 69226 RVA: 0x00279AE8 File Offset: 0x00277CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBackLibraryRequest.Descriptor;
			}
		}

		// Token: 0x06010E6B RID: 69227 RVA: 0x00279AEF File Offset: 0x00277CEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBackLibraryRequest()
		{
		}

		// Token: 0x06010E6C RID: 69228 RVA: 0x00279AF7 File Offset: 0x00277CF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBackLibraryRequest(PhantomBattleBackLibraryRequest other) : this()
		{
			this.cardUid_ = other.cardUid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010E6D RID: 69229 RVA: 0x00279B1C File Offset: 0x00277D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBackLibraryRequest Clone()
		{
			return new PhantomBattleBackLibraryRequest(this);
		}

		// Token: 0x170037D2 RID: 14290
		// (get) Token: 0x06010E6E RID: 69230 RVA: 0x00279B24 File Offset: 0x00277D24
		// (set) Token: 0x06010E6F RID: 69231 RVA: 0x00279B2C File Offset: 0x00277D2C
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

		// Token: 0x06010E70 RID: 69232 RVA: 0x00279B35 File Offset: 0x00277D35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBackLibraryRequest);
		}

		// Token: 0x06010E71 RID: 69233 RVA: 0x00279B43 File Offset: 0x00277D43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBackLibraryRequest other)
		{
			return other != null && (other == this || (this.CardUid == other.CardUid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010E72 RID: 69234 RVA: 0x00279B74 File Offset: 0x00277D74
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

		// Token: 0x06010E73 RID: 69235 RVA: 0x00279BB3 File Offset: 0x00277DB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010E74 RID: 69236 RVA: 0x00279BC0 File Offset: 0x00277DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010E75 RID: 69237 RVA: 0x00279BC9 File Offset: 0x00277DC9
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

		// Token: 0x06010E76 RID: 69238 RVA: 0x00279BFC File Offset: 0x00277DFC
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

		// Token: 0x06010E77 RID: 69239 RVA: 0x00279C3A File Offset: 0x00277E3A
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

		// Token: 0x06010E78 RID: 69240 RVA: 0x00279C6B File Offset: 0x00277E6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010E79 RID: 69241 RVA: 0x00279C74 File Offset: 0x00277E74
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

		// Token: 0x04006B45 RID: 27461
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B46 RID: 27462
		public const int CardUidFieldNumber = 8;

		// Token: 0x04006B47 RID: 27463
		private int cardUid_;
	}
}
