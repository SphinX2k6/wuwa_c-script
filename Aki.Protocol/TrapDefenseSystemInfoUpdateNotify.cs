using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014C8 RID: 5320
	[NetMessage(EMessageId.TrapDefenseSystemInfoUpdateNotify)]
	public sealed class TrapDefenseSystemInfoUpdateNotify : IMessage<TrapDefenseSystemInfoUpdateNotify>, IMessage, IEquatable<TrapDefenseSystemInfoUpdateNotify>, IDeepCloneable<TrapDefenseSystemInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601C393 RID: 115603 RVA: 0x00418CB3 File Offset: 0x00416EB3
		[NullableContext(1)]
		public static TrapDefenseSystemInfoUpdateNotify Create()
		{
			return new TrapDefenseSystemInfoUpdateNotify();
		}

		// Token: 0x17005F89 RID: 24457
		// (get) Token: 0x0601C394 RID: 115604 RVA: 0x00418CBA File Offset: 0x00416EBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F8A RID: 24458
		// (get) Token: 0x0601C395 RID: 115605 RVA: 0x00418CBD File Offset: 0x00416EBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseSystemInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601C396 RID: 115606 RVA: 0x00418CC4 File Offset: 0x00416EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSystemInfoUpdateNotify()
		{
		}

		// Token: 0x0601C397 RID: 115607 RVA: 0x00418CD7 File Offset: 0x00416ED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSystemInfoUpdateNotify(TrapDefenseSystemInfoUpdateNotify other) : this()
		{
			this.slots_ = other.slots_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C398 RID: 115608 RVA: 0x00418D01 File Offset: 0x00416F01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSystemInfoUpdateNotify Clone()
		{
			return new TrapDefenseSystemInfoUpdateNotify(this);
		}

		// Token: 0x17005F8B RID: 24459
		// (get) Token: 0x0601C399 RID: 115609 RVA: 0x00418D09 File Offset: 0x00416F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseSlot> Slots
		{
			get
			{
				return this.slots_;
			}
		}

		// Token: 0x0601C39A RID: 115610 RVA: 0x00418D11 File Offset: 0x00416F11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseSystemInfoUpdateNotify);
		}

		// Token: 0x0601C39B RID: 115611 RVA: 0x00418D1F File Offset: 0x00416F1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseSystemInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.slots_.Equals(other.slots_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C39C RID: 115612 RVA: 0x00418D54 File Offset: 0x00416F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.slots_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C39D RID: 115613 RVA: 0x00418D88 File Offset: 0x00416F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C39E RID: 115614 RVA: 0x00418D95 File Offset: 0x00416F95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C39F RID: 115615 RVA: 0x00418D9E File Offset: 0x00416F9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.slots_.WriteTo(ref output, TrapDefenseSystemInfoUpdateNotify._repeated_slots_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C3A0 RID: 115616 RVA: 0x00418DC8 File Offset: 0x00416FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.slots_.CalculateSize(TrapDefenseSystemInfoUpdateNotify._repeated_slots_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C3A1 RID: 115617 RVA: 0x00418E01 File Offset: 0x00417001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseSystemInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.slots_.Add(other.slots_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C3A2 RID: 115618 RVA: 0x00418E2F File Offset: 0x0041702F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C3A3 RID: 115619 RVA: 0x00418E38 File Offset: 0x00417038
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
					this.slots_.AddEntriesFrom(ref input, TrapDefenseSystemInfoUpdateNotify._repeated_slots_codec);
				}
			}
		}

		// Token: 0x0400A335 RID: 41781
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A336 RID: 41782
		public const int SlotsFieldNumber = 10;

		// Token: 0x0400A337 RID: 41783
		private static readonly FieldCodec<TrapDefenseSlot> _repeated_slots_codec = FieldCodec.ForMessage<TrapDefenseSlot>(82U, TrapDefenseSlot.Parser);

		// Token: 0x0400A338 RID: 41784
		private readonly RepeatedField<TrapDefenseSlot> slots_ = new RepeatedField<TrapDefenseSlot>();
	}
}
