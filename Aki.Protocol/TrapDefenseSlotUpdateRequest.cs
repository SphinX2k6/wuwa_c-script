using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200144B RID: 5195
	[NetMessage(EMessageId.TrapDefenseSlotUpdateRequest)]
	public sealed class TrapDefenseSlotUpdateRequest : IMessage<TrapDefenseSlotUpdateRequest>, IMessage, IEquatable<TrapDefenseSlotUpdateRequest>, IDeepCloneable<TrapDefenseSlotUpdateRequest>, IBufferMessage
	{
		// Token: 0x0601B842 RID: 112706 RVA: 0x003FBE3A File Offset: 0x003FA03A
		[NullableContext(1)]
		public static TrapDefenseSlotUpdateRequest Create()
		{
			return new TrapDefenseSlotUpdateRequest();
		}

		// Token: 0x17005CCB RID: 23755
		// (get) Token: 0x0601B843 RID: 112707 RVA: 0x003FBE41 File Offset: 0x003FA041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CCC RID: 23756
		// (get) Token: 0x0601B844 RID: 112708 RVA: 0x003FBE44 File Offset: 0x003FA044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseSlotUpdateRequest.Descriptor;
			}
		}

		// Token: 0x0601B845 RID: 112709 RVA: 0x003FBE4B File Offset: 0x003FA04B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSlotUpdateRequest()
		{
		}

		// Token: 0x0601B846 RID: 112710 RVA: 0x003FBE5E File Offset: 0x003FA05E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSlotUpdateRequest(TrapDefenseSlotUpdateRequest other) : this()
		{
			this.slot_ = other.slot_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B847 RID: 112711 RVA: 0x003FBE88 File Offset: 0x003FA088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSlotUpdateRequest Clone()
		{
			return new TrapDefenseSlotUpdateRequest(this);
		}

		// Token: 0x17005CCD RID: 23757
		// (get) Token: 0x0601B848 RID: 112712 RVA: 0x003FBE90 File Offset: 0x003FA090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseSlot> Slot
		{
			get
			{
				return this.slot_;
			}
		}

		// Token: 0x0601B849 RID: 112713 RVA: 0x003FBE98 File Offset: 0x003FA098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseSlotUpdateRequest);
		}

		// Token: 0x0601B84A RID: 112714 RVA: 0x003FBEA6 File Offset: 0x003FA0A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseSlotUpdateRequest other)
		{
			return other != null && (other == this || (this.slot_.Equals(other.slot_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B84B RID: 112715 RVA: 0x003FBEDC File Offset: 0x003FA0DC
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

		// Token: 0x0601B84C RID: 112716 RVA: 0x003FBF10 File Offset: 0x003FA110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B84D RID: 112717 RVA: 0x003FBF1D File Offset: 0x003FA11D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B84E RID: 112718 RVA: 0x003FBF26 File Offset: 0x003FA126
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

		// Token: 0x0601B84F RID: 112719 RVA: 0x003FBF50 File Offset: 0x003FA150
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

		// Token: 0x0601B850 RID: 112720 RVA: 0x003FBF89 File Offset: 0x003FA189
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

		// Token: 0x0601B851 RID: 112721 RVA: 0x003FBFB7 File Offset: 0x003FA1B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B852 RID: 112722 RVA: 0x003FBFC0 File Offset: 0x003FA1C0
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.slot_.AddEntriesFrom(ref input, TrapDefenseSlotUpdateRequest._repeated_slot_codec);
				}
			}
		}

		// Token: 0x04009EB6 RID: 40630
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009EB7 RID: 40631
		public const int SlotFieldNumber = 14;

		// Token: 0x04009EB8 RID: 40632
		private static readonly FieldCodec<TrapDefenseSlot> _repeated_slot_codec = FieldCodec.ForMessage<TrapDefenseSlot>(114U, TrapDefenseSlot.Parser);

		// Token: 0x04009EB9 RID: 40633
		private readonly RepeatedField<TrapDefenseSlot> slot_ = new RepeatedField<TrapDefenseSlot>();
	}
}
