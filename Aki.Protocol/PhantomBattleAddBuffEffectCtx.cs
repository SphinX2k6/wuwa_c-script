using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C25 RID: 3109
	public sealed class PhantomBattleAddBuffEffectCtx : IMessage<PhantomBattleAddBuffEffectCtx>, IMessage, IEquatable<PhantomBattleAddBuffEffectCtx>, IDeepCloneable<PhantomBattleAddBuffEffectCtx>, IBufferMessage
	{
		// Token: 0x06010DF9 RID: 69113 RVA: 0x00278E19 File Offset: 0x00277019
		[NullableContext(1)]
		public static PhantomBattleAddBuffEffectCtx Create()
		{
			return new PhantomBattleAddBuffEffectCtx();
		}

		// Token: 0x170037BC RID: 14268
		// (get) Token: 0x06010DFA RID: 69114 RVA: 0x00278E20 File Offset: 0x00277020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleAddBuffEffectCtx> Parser
		{
			get
			{
				return PhantomBattleAddBuffEffectCtx._parser;
			}
		}

		// Token: 0x170037BD RID: 14269
		// (get) Token: 0x06010DFB RID: 69115 RVA: 0x00278E27 File Offset: 0x00277027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037BE RID: 14270
		// (get) Token: 0x06010DFC RID: 69116 RVA: 0x00278E2A File Offset: 0x0027702A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleAddBuffEffectCtx.Descriptor;
			}
		}

		// Token: 0x06010DFD RID: 69117 RVA: 0x00278E31 File Offset: 0x00277031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAddBuffEffectCtx()
		{
		}

		// Token: 0x06010DFE RID: 69118 RVA: 0x00278E44 File Offset: 0x00277044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAddBuffEffectCtx(PhantomBattleAddBuffEffectCtx other) : this()
		{
			this.phantomBattleBuffId_ = other.phantomBattleBuffId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010DFF RID: 69119 RVA: 0x00278E6E File Offset: 0x0027706E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAddBuffEffectCtx Clone()
		{
			return new PhantomBattleAddBuffEffectCtx(this);
		}

		// Token: 0x170037BF RID: 14271
		// (get) Token: 0x06010E00 RID: 69120 RVA: 0x00278E76 File Offset: 0x00277076
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PhantomBattleBuffId
		{
			get
			{
				return this.phantomBattleBuffId_;
			}
		}

		// Token: 0x06010E01 RID: 69121 RVA: 0x00278E7E File Offset: 0x0027707E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleAddBuffEffectCtx);
		}

		// Token: 0x06010E02 RID: 69122 RVA: 0x00278E8C File Offset: 0x0027708C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleAddBuffEffectCtx other)
		{
			return other != null && (other == this || (this.phantomBattleBuffId_.Equals(other.phantomBattleBuffId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010E03 RID: 69123 RVA: 0x00278EC0 File Offset: 0x002770C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantomBattleBuffId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010E04 RID: 69124 RVA: 0x00278EF4 File Offset: 0x002770F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010E05 RID: 69125 RVA: 0x00278F01 File Offset: 0x00277101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010E06 RID: 69126 RVA: 0x00278F0A File Offset: 0x0027710A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomBattleBuffId_.WriteTo(ref output, PhantomBattleAddBuffEffectCtx._repeated_phantomBattleBuffId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010E07 RID: 69127 RVA: 0x00278F34 File Offset: 0x00277134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantomBattleBuffId_.CalculateSize(PhantomBattleAddBuffEffectCtx._repeated_phantomBattleBuffId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010E08 RID: 69128 RVA: 0x00278F6D File Offset: 0x0027716D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleAddBuffEffectCtx other)
		{
			if (other == null)
			{
				return;
			}
			this.phantomBattleBuffId_.Add(other.phantomBattleBuffId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010E09 RID: 69129 RVA: 0x00278F9B File Offset: 0x0027719B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010E0A RID: 69130 RVA: 0x00278FA4 File Offset: 0x002771A4
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.phantomBattleBuffId_.AddEntriesFrom(ref input, PhantomBattleAddBuffEffectCtx._repeated_phantomBattleBuffId_codec);
				}
			}
		}

		// Token: 0x04006B2E RID: 27438
		private static readonly MessageParser<PhantomBattleAddBuffEffectCtx> _parser = new MessageParser<PhantomBattleAddBuffEffectCtx>(() => new PhantomBattleAddBuffEffectCtx());

		// Token: 0x04006B2F RID: 27439
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B30 RID: 27440
		public const int PhantomBattleBuffIdFieldNumber = 1;

		// Token: 0x04006B31 RID: 27441
		private static readonly FieldCodec<int> _repeated_phantomBattleBuffId_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04006B32 RID: 27442
		private readonly RepeatedField<int> phantomBattleBuffId_ = new RepeatedField<int>();
	}
}
