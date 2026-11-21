using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014BE RID: 5310
	[NetMessage(EMessageId.TrapDefenseSlotUpdateRequest)]
	public sealed class TrapDefenseSlotUpdateRequest : IMessage<TrapDefenseSlotUpdateRequest>, IMessage, IEquatable<TrapDefenseSlotUpdateRequest>, IDeepCloneable<TrapDefenseSlotUpdateRequest>, IBufferMessage
	{
		// Token: 0x0601C2CD RID: 115405 RVA: 0x0041710E File Offset: 0x0041530E
		[NullableContext(1)]
		public static TrapDefenseSlotUpdateRequest Create()
		{
			return new TrapDefenseSlotUpdateRequest();
		}

		// Token: 0x17005F60 RID: 24416
		// (get) Token: 0x0601C2CE RID: 115406 RVA: 0x00417115 File Offset: 0x00415315
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F61 RID: 24417
		// (get) Token: 0x0601C2CF RID: 115407 RVA: 0x00417118 File Offset: 0x00415318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseSlotUpdateRequest.Descriptor;
			}
		}

		// Token: 0x0601C2D0 RID: 115408 RVA: 0x0041711F File Offset: 0x0041531F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSlotUpdateRequest()
		{
		}

		// Token: 0x0601C2D1 RID: 115409 RVA: 0x00417132 File Offset: 0x00415332
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSlotUpdateRequest(TrapDefenseSlotUpdateRequest other) : this()
		{
			this.slot_ = other.slot_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C2D2 RID: 115410 RVA: 0x0041715C File Offset: 0x0041535C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSlotUpdateRequest Clone()
		{
			return new TrapDefenseSlotUpdateRequest(this);
		}

		// Token: 0x17005F62 RID: 24418
		// (get) Token: 0x0601C2D3 RID: 115411 RVA: 0x00417164 File Offset: 0x00415364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseSlot> Slot
		{
			get
			{
				return this.slot_;
			}
		}

		// Token: 0x0601C2D4 RID: 115412 RVA: 0x0041716C File Offset: 0x0041536C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseSlotUpdateRequest);
		}

		// Token: 0x0601C2D5 RID: 115413 RVA: 0x0041717A File Offset: 0x0041537A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseSlotUpdateRequest other)
		{
			return other != null && (other == this || (this.slot_.Equals(other.slot_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C2D6 RID: 115414 RVA: 0x004171B0 File Offset: 0x004153B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.slot_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C2D7 RID: 115415 RVA: 0x004171E4 File Offset: 0x004153E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C2D8 RID: 115416 RVA: 0x004171F1 File Offset: 0x004153F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C2D9 RID: 115417 RVA: 0x004171FA File Offset: 0x004153FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.slot_.WriteTo(ref output, TrapDefenseSlotUpdateRequest._repeated_slot_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C2DA RID: 115418 RVA: 0x00417224 File Offset: 0x00415424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.slot_.CalculateSize(TrapDefenseSlotUpdateRequest._repeated_slot_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C2DB RID: 115419 RVA: 0x0041725D File Offset: 0x0041545D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseSlotUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.slot_.Add(other.slot_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C2DC RID: 115420 RVA: 0x0041728B File Offset: 0x0041548B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C2DD RID: 115421 RVA: 0x00417294 File Offset: 0x00415494
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.slot_.AddEntriesFrom(ref input, TrapDefenseSlotUpdateRequest._repeated_slot_codec);
				}
			}
		}

		// Token: 0x0400A2FD RID: 41725
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A2FE RID: 41726
		public const int SlotFieldNumber = 13;

		// Token: 0x0400A2FF RID: 41727
		private static readonly FieldCodec<TrapDefenseSlot> _repeated_slot_codec = FieldCodec.ForMessage<TrapDefenseSlot>(106U, TrapDefenseSlot.Parser);

		// Token: 0x0400A300 RID: 41728
		private readonly RepeatedField<TrapDefenseSlot> slot_ = new RepeatedField<TrapDefenseSlot>();
	}
}
