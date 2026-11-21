using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200148B RID: 5259
	[NetMessage(EMessageId.TrapDefenseChallengeQuitRequest)]
	public sealed class TrapDefenseChallengeQuitRequest : IMessage<TrapDefenseChallengeQuitRequest>, IMessage, IEquatable<TrapDefenseChallengeQuitRequest>, IDeepCloneable<TrapDefenseChallengeQuitRequest>, IBufferMessage
	{
		// Token: 0x0601BED7 RID: 114391 RVA: 0x0040EC9A File Offset: 0x0040CE9A
		[NullableContext(1)]
		public static TrapDefenseChallengeQuitRequest Create()
		{
			return new TrapDefenseChallengeQuitRequest();
		}

		// Token: 0x17005E93 RID: 24211
		// (get) Token: 0x0601BED8 RID: 114392 RVA: 0x0040ECA1 File Offset: 0x0040CEA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E94 RID: 24212
		// (get) Token: 0x0601BED9 RID: 114393 RVA: 0x0040ECA4 File Offset: 0x0040CEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseChallengeQuitRequest.Descriptor;
			}
		}

		// Token: 0x0601BEDA RID: 114394 RVA: 0x0040ECAB File Offset: 0x0040CEAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseChallengeQuitRequest()
		{
		}

		// Token: 0x0601BEDB RID: 114395 RVA: 0x0040ECB3 File Offset: 0x0040CEB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseChallengeQuitRequest(TrapDefenseChallengeQuitRequest other) : this()
		{
			this.settle_ = other.settle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BEDC RID: 114396 RVA: 0x0040ECD8 File Offset: 0x0040CED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseChallengeQuitRequest Clone()
		{
			return new TrapDefenseChallengeQuitRequest(this);
		}

		// Token: 0x17005E95 RID: 24213
		// (get) Token: 0x0601BEDD RID: 114397 RVA: 0x0040ECE0 File Offset: 0x0040CEE0
		// (set) Token: 0x0601BEDE RID: 114398 RVA: 0x0040ECE8 File Offset: 0x0040CEE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Settle
		{
			get
			{
				return this.settle_;
			}
			set
			{
				this.settle_ = value;
			}
		}

		// Token: 0x0601BEDF RID: 114399 RVA: 0x0040ECF1 File Offset: 0x0040CEF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseChallengeQuitRequest);
		}

		// Token: 0x0601BEE0 RID: 114400 RVA: 0x0040ECFF File Offset: 0x0040CEFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseChallengeQuitRequest other)
		{
			return other != null && (other == this || (this.Settle == other.Settle && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BEE1 RID: 114401 RVA: 0x0040ED30 File Offset: 0x0040CF30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Settle)
			{
				num ^= this.Settle.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BEE2 RID: 114402 RVA: 0x0040ED6F File Offset: 0x0040CF6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BEE3 RID: 114403 RVA: 0x0040ED7C File Offset: 0x0040CF7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BEE4 RID: 114404 RVA: 0x0040ED85 File Offset: 0x0040CF85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Settle)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.Settle);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BEE5 RID: 114405 RVA: 0x0040EDB8 File Offset: 0x0040CFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Settle)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BEE6 RID: 114406 RVA: 0x0040EDEA File Offset: 0x0040CFEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseChallengeQuitRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Settle)
			{
				this.Settle = other.Settle;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BEE7 RID: 114407 RVA: 0x0040EE1B File Offset: 0x0040D01B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BEE8 RID: 114408 RVA: 0x0040EE24 File Offset: 0x0040D024
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Settle = input.ReadBool();
				}
			}
		}

		// Token: 0x0400A1F9 RID: 41465
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A1FA RID: 41466
		public const int SettleFieldNumber = 11;

		// Token: 0x0400A1FB RID: 41467
		private bool settle_;
	}
}
