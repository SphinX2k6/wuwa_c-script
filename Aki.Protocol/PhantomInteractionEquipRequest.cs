using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CD7 RID: 3287
	[NetMessage(EMessageId.PhantomInteractionEquipRequest)]
	public sealed class PhantomInteractionEquipRequest : IMessage<PhantomInteractionEquipRequest>, IMessage, IEquatable<PhantomInteractionEquipRequest>, IDeepCloneable<PhantomInteractionEquipRequest>, IBufferMessage
	{
		// Token: 0x06011CA1 RID: 72865 RVA: 0x0029A55B File Offset: 0x0029875B
		[NullableContext(1)]
		public static PhantomInteractionEquipRequest Create()
		{
			return new PhantomInteractionEquipRequest();
		}

		// Token: 0x17003AF1 RID: 15089
		// (get) Token: 0x06011CA2 RID: 72866 RVA: 0x0029A562 File Offset: 0x00298762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AF2 RID: 15090
		// (get) Token: 0x06011CA3 RID: 72867 RVA: 0x0029A565 File Offset: 0x00298765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomInteractionEquipRequest.Descriptor;
			}
		}

		// Token: 0x06011CA4 RID: 72868 RVA: 0x0029A56C File Offset: 0x0029876C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomInteractionEquipRequest()
		{
		}

		// Token: 0x06011CA5 RID: 72869 RVA: 0x0029A57F File Offset: 0x0029877F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomInteractionEquipRequest(PhantomInteractionEquipRequest other) : this()
		{
			this.equipedMonsterIds_ = other.equipedMonsterIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011CA6 RID: 72870 RVA: 0x0029A5A9 File Offset: 0x002987A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomInteractionEquipRequest Clone()
		{
			return new PhantomInteractionEquipRequest(this);
		}

		// Token: 0x17003AF3 RID: 15091
		// (get) Token: 0x06011CA7 RID: 72871 RVA: 0x0029A5B1 File Offset: 0x002987B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EquipedMonsterIds
		{
			get
			{
				return this.equipedMonsterIds_;
			}
		}

		// Token: 0x06011CA8 RID: 72872 RVA: 0x0029A5B9 File Offset: 0x002987B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomInteractionEquipRequest);
		}

		// Token: 0x06011CA9 RID: 72873 RVA: 0x0029A5C7 File Offset: 0x002987C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomInteractionEquipRequest other)
		{
			return other != null && (other == this || (this.equipedMonsterIds_.Equals(other.equipedMonsterIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011CAA RID: 72874 RVA: 0x0029A5FC File Offset: 0x002987FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.equipedMonsterIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011CAB RID: 72875 RVA: 0x0029A630 File Offset: 0x00298830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011CAC RID: 72876 RVA: 0x0029A63D File Offset: 0x0029883D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011CAD RID: 72877 RVA: 0x0029A646 File Offset: 0x00298846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.equipedMonsterIds_.WriteTo(ref output, PhantomInteractionEquipRequest._repeated_equipedMonsterIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011CAE RID: 72878 RVA: 0x0029A670 File Offset: 0x00298870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.equipedMonsterIds_.CalculateSize(PhantomInteractionEquipRequest._repeated_equipedMonsterIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011CAF RID: 72879 RVA: 0x0029A6A9 File Offset: 0x002988A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomInteractionEquipRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.equipedMonsterIds_.Add(other.equipedMonsterIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011CB0 RID: 72880 RVA: 0x0029A6D7 File Offset: 0x002988D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011CB1 RID: 72881 RVA: 0x0029A6E0 File Offset: 0x002988E0
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
				if (num != 48U && num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.equipedMonsterIds_.AddEntriesFrom(ref input, PhantomInteractionEquipRequest._repeated_equipedMonsterIds_codec);
				}
			}
		}

		// Token: 0x04006FBC RID: 28604
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006FBD RID: 28605
		public const int EquipedMonsterIdsFieldNumber = 6;

		// Token: 0x04006FBE RID: 28606
		private static readonly FieldCodec<int> _repeated_equipedMonsterIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04006FBF RID: 28607
		private readonly RepeatedField<int> equipedMonsterIds_ = new RepeatedField<int>();
	}
}
