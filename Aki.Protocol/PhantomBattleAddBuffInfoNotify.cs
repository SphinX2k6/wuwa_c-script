using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C26 RID: 3110
	[NetMessage(EMessageId.PhantomBattleAddBuffInfoNotify)]
	public sealed class PhantomBattleAddBuffInfoNotify : IMessage<PhantomBattleAddBuffInfoNotify>, IMessage, IEquatable<PhantomBattleAddBuffInfoNotify>, IDeepCloneable<PhantomBattleAddBuffInfoNotify>, IBufferMessage
	{
		// Token: 0x06010E0C RID: 69132 RVA: 0x0027901A File Offset: 0x0027721A
		[NullableContext(1)]
		public static PhantomBattleAddBuffInfoNotify Create()
		{
			return new PhantomBattleAddBuffInfoNotify();
		}

		// Token: 0x170037C0 RID: 14272
		// (get) Token: 0x06010E0D RID: 69133 RVA: 0x00279021 File Offset: 0x00277221
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037C1 RID: 14273
		// (get) Token: 0x06010E0E RID: 69134 RVA: 0x00279024 File Offset: 0x00277224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleAddBuffInfoNotify.Descriptor;
			}
		}

		// Token: 0x06010E0F RID: 69135 RVA: 0x0027902B File Offset: 0x0027722B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAddBuffInfoNotify()
		{
		}

		// Token: 0x06010E10 RID: 69136 RVA: 0x0027903E File Offset: 0x0027723E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAddBuffInfoNotify(PhantomBattleAddBuffInfoNotify other) : this()
		{
			this.addBuffs_ = other.addBuffs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010E11 RID: 69137 RVA: 0x00279068 File Offset: 0x00277268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAddBuffInfoNotify Clone()
		{
			return new PhantomBattleAddBuffInfoNotify(this);
		}

		// Token: 0x170037C2 RID: 14274
		// (get) Token: 0x06010E12 RID: 69138 RVA: 0x00279070 File Offset: 0x00277270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, PhantomBattleAddBuffEffectCtx> AddBuffs
		{
			get
			{
				return this.addBuffs_;
			}
		}

		// Token: 0x06010E13 RID: 69139 RVA: 0x00279078 File Offset: 0x00277278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleAddBuffInfoNotify);
		}

		// Token: 0x06010E14 RID: 69140 RVA: 0x00279086 File Offset: 0x00277286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleAddBuffInfoNotify other)
		{
			return other != null && (other == this || (this.AddBuffs.Equals(other.AddBuffs) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010E15 RID: 69141 RVA: 0x002790BC File Offset: 0x002772BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.AddBuffs.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010E16 RID: 69142 RVA: 0x002790F0 File Offset: 0x002772F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010E17 RID: 69143 RVA: 0x002790FD File Offset: 0x002772FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010E18 RID: 69144 RVA: 0x00279106 File Offset: 0x00277306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.addBuffs_.WriteTo(ref output, PhantomBattleAddBuffInfoNotify._map_addBuffs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010E19 RID: 69145 RVA: 0x00279130 File Offset: 0x00277330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.addBuffs_.CalculateSize(PhantomBattleAddBuffInfoNotify._map_addBuffs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010E1A RID: 69146 RVA: 0x00279169 File Offset: 0x00277369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleAddBuffInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.addBuffs_.MergeFrom(other.addBuffs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010E1B RID: 69147 RVA: 0x00279197 File Offset: 0x00277397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010E1C RID: 69148 RVA: 0x002791A0 File Offset: 0x002773A0
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.addBuffs_.AddEntriesFrom(ref input, PhantomBattleAddBuffInfoNotify._map_addBuffs_codec);
				}
			}
		}

		// Token: 0x04006B33 RID: 27443
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B34 RID: 27444
		public const int AddBuffsFieldNumber = 10;

		// Token: 0x04006B35 RID: 27445
		private static readonly MapField<int, PhantomBattleAddBuffEffectCtx>.Codec _map_addBuffs_codec = new MapField<int, PhantomBattleAddBuffEffectCtx>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<PhantomBattleAddBuffEffectCtx>(18U, PhantomBattleAddBuffEffectCtx.Parser), 82U);

		// Token: 0x04006B36 RID: 27446
		private readonly MapField<int, PhantomBattleAddBuffEffectCtx> addBuffs_ = new MapField<int, PhantomBattleAddBuffEffectCtx>();
	}
}
