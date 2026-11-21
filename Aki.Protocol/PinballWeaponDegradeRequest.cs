using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D5C RID: 3420
	[NetMessage(EMessageId.PinballWeaponDegradeRequest)]
	public sealed class PinballWeaponDegradeRequest : IMessage<PinballWeaponDegradeRequest>, IMessage, IEquatable<PinballWeaponDegradeRequest>, IDeepCloneable<PinballWeaponDegradeRequest>, IBufferMessage
	{
		// Token: 0x06012772 RID: 75634 RVA: 0x002B232E File Offset: 0x002B052E
		[NullableContext(1)]
		public static PinballWeaponDegradeRequest Create()
		{
			return new PinballWeaponDegradeRequest();
		}

		// Token: 0x17003D35 RID: 15669
		// (get) Token: 0x06012773 RID: 75635 RVA: 0x002B2335 File Offset: 0x002B0535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D36 RID: 15670
		// (get) Token: 0x06012774 RID: 75636 RVA: 0x002B2338 File Offset: 0x002B0538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballWeaponDegradeRequest.Descriptor;
			}
		}

		// Token: 0x06012775 RID: 75637 RVA: 0x002B233F File Offset: 0x002B053F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeaponDegradeRequest()
		{
		}

		// Token: 0x06012776 RID: 75638 RVA: 0x002B2352 File Offset: 0x002B0552
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeaponDegradeRequest(PinballWeaponDegradeRequest other) : this()
		{
			this.weaponIncIds_ = other.weaponIncIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012777 RID: 75639 RVA: 0x002B237C File Offset: 0x002B057C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeaponDegradeRequest Clone()
		{
			return new PinballWeaponDegradeRequest(this);
		}

		// Token: 0x17003D37 RID: 15671
		// (get) Token: 0x06012778 RID: 75640 RVA: 0x002B2384 File Offset: 0x002B0584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> WeaponIncIds
		{
			get
			{
				return this.weaponIncIds_;
			}
		}

		// Token: 0x06012779 RID: 75641 RVA: 0x002B238C File Offset: 0x002B058C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballWeaponDegradeRequest);
		}

		// Token: 0x0601277A RID: 75642 RVA: 0x002B239A File Offset: 0x002B059A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballWeaponDegradeRequest other)
		{
			return other != null && (other == this || (this.weaponIncIds_.Equals(other.weaponIncIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601277B RID: 75643 RVA: 0x002B23D0 File Offset: 0x002B05D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.weaponIncIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601277C RID: 75644 RVA: 0x002B2404 File Offset: 0x002B0604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601277D RID: 75645 RVA: 0x002B2411 File Offset: 0x002B0611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601277E RID: 75646 RVA: 0x002B241A File Offset: 0x002B061A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.weaponIncIds_.WriteTo(ref output, PinballWeaponDegradeRequest._repeated_weaponIncIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601277F RID: 75647 RVA: 0x002B2444 File Offset: 0x002B0644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.weaponIncIds_.CalculateSize(PinballWeaponDegradeRequest._repeated_weaponIncIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012780 RID: 75648 RVA: 0x002B247D File Offset: 0x002B067D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballWeaponDegradeRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.weaponIncIds_.Add(other.weaponIncIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012781 RID: 75649 RVA: 0x002B24AB File Offset: 0x002B06AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012782 RID: 75650 RVA: 0x002B24B4 File Offset: 0x002B06B4
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
				if (num != 40U && num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.weaponIncIds_.AddEntriesFrom(ref input, PinballWeaponDegradeRequest._repeated_weaponIncIds_codec);
				}
			}
		}

		// Token: 0x04007337 RID: 29495
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007338 RID: 29496
		public const int WeaponIncIdsFieldNumber = 5;

		// Token: 0x04007339 RID: 29497
		private static readonly FieldCodec<int> _repeated_weaponIncIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x0400733A RID: 29498
		private readonly RepeatedField<int> weaponIncIds_ = new RepeatedField<int>();
	}
}
