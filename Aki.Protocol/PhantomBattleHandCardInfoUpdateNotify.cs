using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C83 RID: 3203
	[NetMessage(EMessageId.PhantomBattleHandCardInfoUpdateNotify)]
	public sealed class PhantomBattleHandCardInfoUpdateNotify : IMessage<PhantomBattleHandCardInfoUpdateNotify>, IMessage, IEquatable<PhantomBattleHandCardInfoUpdateNotify>, IDeepCloneable<PhantomBattleHandCardInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06011632 RID: 71218 RVA: 0x0028CC9A File Offset: 0x0028AE9A
		[NullableContext(1)]
		public static PhantomBattleHandCardInfoUpdateNotify Create()
		{
			return new PhantomBattleHandCardInfoUpdateNotify();
		}

		// Token: 0x17003997 RID: 14743
		// (get) Token: 0x06011633 RID: 71219 RVA: 0x0028CCA1 File Offset: 0x0028AEA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003998 RID: 14744
		// (get) Token: 0x06011634 RID: 71220 RVA: 0x0028CCA4 File Offset: 0x0028AEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleHandCardInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06011635 RID: 71221 RVA: 0x0028CCAB File Offset: 0x0028AEAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleHandCardInfoUpdateNotify()
		{
		}

		// Token: 0x06011636 RID: 71222 RVA: 0x0028CCBE File Offset: 0x0028AEBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleHandCardInfoUpdateNotify(PhantomBattleHandCardInfoUpdateNotify other) : this()
		{
			this.phantomBattleHandCardInfo_ = other.phantomBattleHandCardInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011637 RID: 71223 RVA: 0x0028CCE8 File Offset: 0x0028AEE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleHandCardInfoUpdateNotify Clone()
		{
			return new PhantomBattleHandCardInfoUpdateNotify(this);
		}

		// Token: 0x17003999 RID: 14745
		// (get) Token: 0x06011638 RID: 71224 RVA: 0x0028CCF0 File Offset: 0x0028AEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleHandCardInfo> PhantomBattleHandCardInfo
		{
			get
			{
				return this.phantomBattleHandCardInfo_;
			}
		}

		// Token: 0x06011639 RID: 71225 RVA: 0x0028CCF8 File Offset: 0x0028AEF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleHandCardInfoUpdateNotify);
		}

		// Token: 0x0601163A RID: 71226 RVA: 0x0028CD06 File Offset: 0x0028AF06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleHandCardInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.phantomBattleHandCardInfo_.Equals(other.phantomBattleHandCardInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601163B RID: 71227 RVA: 0x0028CD3C File Offset: 0x0028AF3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantomBattleHandCardInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601163C RID: 71228 RVA: 0x0028CD70 File Offset: 0x0028AF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601163D RID: 71229 RVA: 0x0028CD7D File Offset: 0x0028AF7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601163E RID: 71230 RVA: 0x0028CD86 File Offset: 0x0028AF86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomBattleHandCardInfo_.WriteTo(ref output, PhantomBattleHandCardInfoUpdateNotify._repeated_phantomBattleHandCardInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601163F RID: 71231 RVA: 0x0028CDB0 File Offset: 0x0028AFB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantomBattleHandCardInfo_.CalculateSize(PhantomBattleHandCardInfoUpdateNotify._repeated_phantomBattleHandCardInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011640 RID: 71232 RVA: 0x0028CDE9 File Offset: 0x0028AFE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleHandCardInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.phantomBattleHandCardInfo_.Add(other.phantomBattleHandCardInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011641 RID: 71233 RVA: 0x0028CE17 File Offset: 0x0028B017
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011642 RID: 71234 RVA: 0x0028CE20 File Offset: 0x0028B020
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.phantomBattleHandCardInfo_.AddEntriesFrom(ref input, PhantomBattleHandCardInfoUpdateNotify._repeated_phantomBattleHandCardInfo_codec);
				}
			}
		}

		// Token: 0x04006E3C RID: 28220
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E3D RID: 28221
		public const int PhantomBattleHandCardInfoFieldNumber = 3;

		// Token: 0x04006E3E RID: 28222
		private static readonly FieldCodec<PhantomBattleHandCardInfo> _repeated_phantomBattleHandCardInfo_codec = FieldCodec.ForMessage<PhantomBattleHandCardInfo>(26U, Aki.Protocol.PhantomBattleHandCardInfo.Parser);

		// Token: 0x04006E3F RID: 28223
		private readonly RepeatedField<PhantomBattleHandCardInfo> phantomBattleHandCardInfo_ = new RepeatedField<PhantomBattleHandCardInfo>();
	}
}
