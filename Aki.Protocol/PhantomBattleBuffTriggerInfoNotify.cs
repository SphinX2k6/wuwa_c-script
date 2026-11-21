using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C29 RID: 3113
	[NetMessage(EMessageId.PhantomBattleBuffTriggerInfoNotify)]
	public sealed class PhantomBattleBuffTriggerInfoNotify : IMessage<PhantomBattleBuffTriggerInfoNotify>, IMessage, IEquatable<PhantomBattleBuffTriggerInfoNotify>, IDeepCloneable<PhantomBattleBuffTriggerInfoNotify>, IBufferMessage
	{
		// Token: 0x06010E8A RID: 69258 RVA: 0x0027A483 File Offset: 0x00278683
		[NullableContext(1)]
		public static PhantomBattleBuffTriggerInfoNotify Create()
		{
			return new PhantomBattleBuffTriggerInfoNotify();
		}

		// Token: 0x170037D7 RID: 14295
		// (get) Token: 0x06010E8B RID: 69259 RVA: 0x0027A48A File Offset: 0x0027868A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037D8 RID: 14296
		// (get) Token: 0x06010E8C RID: 69260 RVA: 0x0027A48D File Offset: 0x0027868D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBuffTriggerInfoNotify.Descriptor;
			}
		}

		// Token: 0x06010E8D RID: 69261 RVA: 0x0027A494 File Offset: 0x00278694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBuffTriggerInfoNotify()
		{
		}

		// Token: 0x06010E8E RID: 69262 RVA: 0x0027A4A7 File Offset: 0x002786A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBuffTriggerInfoNotify(PhantomBattleBuffTriggerInfoNotify other) : this()
		{
			this.phantomBattleBuffTriggerInfo_ = other.phantomBattleBuffTriggerInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010E8F RID: 69263 RVA: 0x0027A4D1 File Offset: 0x002786D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBuffTriggerInfoNotify Clone()
		{
			return new PhantomBattleBuffTriggerInfoNotify(this);
		}

		// Token: 0x170037D9 RID: 14297
		// (get) Token: 0x06010E90 RID: 69264 RVA: 0x0027A4D9 File Offset: 0x002786D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleBuffTriggerInfo> PhantomBattleBuffTriggerInfo
		{
			get
			{
				return this.phantomBattleBuffTriggerInfo_;
			}
		}

		// Token: 0x06010E91 RID: 69265 RVA: 0x0027A4E1 File Offset: 0x002786E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBuffTriggerInfoNotify);
		}

		// Token: 0x06010E92 RID: 69266 RVA: 0x0027A4EF File Offset: 0x002786EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBuffTriggerInfoNotify other)
		{
			return other != null && (other == this || (this.phantomBattleBuffTriggerInfo_.Equals(other.phantomBattleBuffTriggerInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010E93 RID: 69267 RVA: 0x0027A524 File Offset: 0x00278724
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

		// Token: 0x06010E94 RID: 69268 RVA: 0x0027A558 File Offset: 0x00278758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010E95 RID: 69269 RVA: 0x0027A565 File Offset: 0x00278765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010E96 RID: 69270 RVA: 0x0027A56E File Offset: 0x0027876E
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

		// Token: 0x06010E97 RID: 69271 RVA: 0x0027A598 File Offset: 0x00278798
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

		// Token: 0x06010E98 RID: 69272 RVA: 0x0027A5D1 File Offset: 0x002787D1
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

		// Token: 0x06010E99 RID: 69273 RVA: 0x0027A5FF File Offset: 0x002787FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010E9A RID: 69274 RVA: 0x0027A608 File Offset: 0x00278808
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.phantomBattleBuffTriggerInfo_.AddEntriesFrom(ref input, PhantomBattleBuffTriggerInfoNotify._repeated_phantomBattleBuffTriggerInfo_codec);
				}
			}
		}

		// Token: 0x04006BAE RID: 27566
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006BAF RID: 27567
		public const int PhantomBattleBuffTriggerInfoFieldNumber = 12;

		// Token: 0x04006BB0 RID: 27568
		private static readonly FieldCodec<PhantomBattleBuffTriggerInfo> _repeated_phantomBattleBuffTriggerInfo_codec = FieldCodec.ForMessage<PhantomBattleBuffTriggerInfo>(98U, Aki.Protocol.PhantomBattleBuffTriggerInfo.Parser);

		// Token: 0x04006BB1 RID: 27569
		private readonly RepeatedField<PhantomBattleBuffTriggerInfo> phantomBattleBuffTriggerInfo_ = new RepeatedField<PhantomBattleBuffTriggerInfo>();
	}
}
