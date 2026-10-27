using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C39 RID: 3129
	[NetMessage(EMessageId.PhantomBattleBuffTriggerInfoNotify)]
	public sealed class PhantomBattleBuffTriggerInfoNotify : IMessage<PhantomBattleBuffTriggerInfoNotify>, IMessage, IEquatable<PhantomBattleBuffTriggerInfoNotify>, IDeepCloneable<PhantomBattleBuffTriggerInfoNotify>, IBufferMessage
	{
		// Token: 0x06010F8A RID: 69514 RVA: 0x0027C1E3 File Offset: 0x0027A3E3
		[NullableContext(1)]
		public static PhantomBattleBuffTriggerInfoNotify Create()
		{
			return new PhantomBattleBuffTriggerInfoNotify();
		}

		// Token: 0x1700380E RID: 14350
		// (get) Token: 0x06010F8B RID: 69515 RVA: 0x0027C1EA File Offset: 0x0027A3EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700380F RID: 14351
		// (get) Token: 0x06010F8C RID: 69516 RVA: 0x0027C1ED File Offset: 0x0027A3ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBuffTriggerInfoNotify.Descriptor;
			}
		}

		// Token: 0x06010F8D RID: 69517 RVA: 0x0027C1F4 File Offset: 0x0027A3F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBuffTriggerInfoNotify()
		{
		}

		// Token: 0x06010F8E RID: 69518 RVA: 0x0027C207 File Offset: 0x0027A407
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBuffTriggerInfoNotify(PhantomBattleBuffTriggerInfoNotify other) : this()
		{
			this.phantomBattleBuffTriggerInfo_ = other.phantomBattleBuffTriggerInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010F8F RID: 69519 RVA: 0x0027C231 File Offset: 0x0027A431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBuffTriggerInfoNotify Clone()
		{
			return new PhantomBattleBuffTriggerInfoNotify(this);
		}

		// Token: 0x17003810 RID: 14352
		// (get) Token: 0x06010F90 RID: 69520 RVA: 0x0027C239 File Offset: 0x0027A439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleBuffTriggerInfo> PhantomBattleBuffTriggerInfo
		{
			get
			{
				return this.phantomBattleBuffTriggerInfo_;
			}
		}

		// Token: 0x06010F91 RID: 69521 RVA: 0x0027C241 File Offset: 0x0027A441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBuffTriggerInfoNotify);
		}

		// Token: 0x06010F92 RID: 69522 RVA: 0x0027C24F File Offset: 0x0027A44F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBuffTriggerInfoNotify other)
		{
			return other != null && (other == this || (this.phantomBattleBuffTriggerInfo_.Equals(other.phantomBattleBuffTriggerInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010F93 RID: 69523 RVA: 0x0027C284 File Offset: 0x0027A484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantomBattleBuffTriggerInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010F94 RID: 69524 RVA: 0x0027C2B8 File Offset: 0x0027A4B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010F95 RID: 69525 RVA: 0x0027C2C5 File Offset: 0x0027A4C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010F96 RID: 69526 RVA: 0x0027C2CE File Offset: 0x0027A4CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomBattleBuffTriggerInfo_.WriteTo(ref output, PhantomBattleBuffTriggerInfoNotify._repeated_phantomBattleBuffTriggerInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010F97 RID: 69527 RVA: 0x0027C2F8 File Offset: 0x0027A4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantomBattleBuffTriggerInfo_.CalculateSize(PhantomBattleBuffTriggerInfoNotify._repeated_phantomBattleBuffTriggerInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010F98 RID: 69528 RVA: 0x0027C331 File Offset: 0x0027A531
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleBuffTriggerInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.phantomBattleBuffTriggerInfo_.Add(other.phantomBattleBuffTriggerInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010F99 RID: 69529 RVA: 0x0027C35F File Offset: 0x0027A55F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010F9A RID: 69530 RVA: 0x0027C368 File Offset: 0x0027A568
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.phantomBattleBuffTriggerInfo_.AddEntriesFrom(ref input, PhantomBattleBuffTriggerInfoNotify._repeated_phantomBattleBuffTriggerInfo_codec);
				}
			}
		}

		// Token: 0x04006B9A RID: 27546
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B9B RID: 27547
		public const int PhantomBattleBuffTriggerInfoFieldNumber = 4;

		// Token: 0x04006B9C RID: 27548
		private static readonly FieldCodec<PhantomBattleBuffTriggerInfo> _repeated_phantomBattleBuffTriggerInfo_codec = FieldCodec.ForMessage<PhantomBattleBuffTriggerInfo>(34U, Aki.Protocol.PhantomBattleBuffTriggerInfo.Parser);

		// Token: 0x04006B9D RID: 27549
		private readonly RepeatedField<PhantomBattleBuffTriggerInfo> phantomBattleBuffTriggerInfo_ = new RepeatedField<PhantomBattleBuffTriggerInfo>();
	}
}
