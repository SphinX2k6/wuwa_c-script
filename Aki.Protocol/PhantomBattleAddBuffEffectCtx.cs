using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C15 RID: 3093
	public sealed class PhantomBattleAddBuffEffectCtx : IMessage<PhantomBattleAddBuffEffectCtx>, IMessage, IEquatable<PhantomBattleAddBuffEffectCtx>, IDeepCloneable<PhantomBattleAddBuffEffectCtx>, IBufferMessage
	{
		// Token: 0x06010CF9 RID: 68857 RVA: 0x002770B5 File Offset: 0x002752B5
		[NullableContext(1)]
		public static PhantomBattleAddBuffEffectCtx Create()
		{
			return new PhantomBattleAddBuffEffectCtx();
		}

		// Token: 0x17003785 RID: 14213
		// (get) Token: 0x06010CFA RID: 68858 RVA: 0x002770BC File Offset: 0x002752BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleAddBuffEffectCtx> Parser
		{
			get
			{
				return PhantomBattleAddBuffEffectCtx._parser;
			}
		}

		// Token: 0x17003786 RID: 14214
		// (get) Token: 0x06010CFB RID: 68859 RVA: 0x002770C3 File Offset: 0x002752C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003787 RID: 14215
		// (get) Token: 0x06010CFC RID: 68860 RVA: 0x002770C6 File Offset: 0x002752C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleAddBuffEffectCtx.Descriptor;
			}
		}

		// Token: 0x06010CFD RID: 68861 RVA: 0x002770CD File Offset: 0x002752CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAddBuffEffectCtx()
		{
		}

		// Token: 0x06010CFE RID: 68862 RVA: 0x002770E0 File Offset: 0x002752E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAddBuffEffectCtx(PhantomBattleAddBuffEffectCtx other) : this()
		{
			this.phantomBattleBuffId_ = other.phantomBattleBuffId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010CFF RID: 68863 RVA: 0x0027710A File Offset: 0x0027530A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAddBuffEffectCtx Clone()
		{
			return new PhantomBattleAddBuffEffectCtx(this);
		}

		// Token: 0x17003788 RID: 14216
		// (get) Token: 0x06010D00 RID: 68864 RVA: 0x00277112 File Offset: 0x00275312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PhantomBattleBuffId
		{
			get
			{
				return this.phantomBattleBuffId_;
			}
		}

		// Token: 0x06010D01 RID: 68865 RVA: 0x0027711A File Offset: 0x0027531A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleAddBuffEffectCtx);
		}

		// Token: 0x06010D02 RID: 68866 RVA: 0x00277128 File Offset: 0x00275328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleAddBuffEffectCtx other)
		{
			return other != null && (other == this || (this.phantomBattleBuffId_.Equals(other.phantomBattleBuffId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010D03 RID: 68867 RVA: 0x0027715C File Offset: 0x0027535C
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

		// Token: 0x06010D04 RID: 68868 RVA: 0x00277190 File Offset: 0x00275390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010D05 RID: 68869 RVA: 0x0027719D File Offset: 0x0027539D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010D06 RID: 68870 RVA: 0x002771A6 File Offset: 0x002753A6
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

		// Token: 0x06010D07 RID: 68871 RVA: 0x002771D0 File Offset: 0x002753D0
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

		// Token: 0x06010D08 RID: 68872 RVA: 0x00277209 File Offset: 0x00275409
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

		// Token: 0x06010D09 RID: 68873 RVA: 0x00277237 File Offset: 0x00275437
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010D0A RID: 68874 RVA: 0x00277240 File Offset: 0x00275440
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

		// Token: 0x04006B42 RID: 27458
		private static readonly MessageParser<PhantomBattleAddBuffEffectCtx> _parser = new MessageParser<PhantomBattleAddBuffEffectCtx>(() => new PhantomBattleAddBuffEffectCtx());

		// Token: 0x04006B43 RID: 27459
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B44 RID: 27460
		public const int PhantomBattleBuffIdFieldNumber = 1;

		// Token: 0x04006B45 RID: 27461
		private static readonly FieldCodec<int> _repeated_phantomBattleBuffId_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04006B46 RID: 27462
		private readonly RepeatedField<int> phantomBattleBuffId_ = new RepeatedField<int>();
	}
}
