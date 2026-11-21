using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CC7 RID: 3271
	[NetMessage(EMessageId.PhantomInteractionEquipRequest)]
	public sealed class PhantomInteractionEquipRequest : IMessage<PhantomInteractionEquipRequest>, IMessage, IEquatable<PhantomInteractionEquipRequest>, IDeepCloneable<PhantomInteractionEquipRequest>, IBufferMessage
	{
		// Token: 0x06011BA5 RID: 72613 RVA: 0x0029893F File Offset: 0x00296B3F
		[NullableContext(1)]
		public static PhantomInteractionEquipRequest Create()
		{
			return new PhantomInteractionEquipRequest();
		}

		// Token: 0x17003ABC RID: 15036
		// (get) Token: 0x06011BA6 RID: 72614 RVA: 0x00298946 File Offset: 0x00296B46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003ABD RID: 15037
		// (get) Token: 0x06011BA7 RID: 72615 RVA: 0x00298949 File Offset: 0x00296B49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomInteractionEquipRequest.Descriptor;
			}
		}

		// Token: 0x06011BA8 RID: 72616 RVA: 0x00298950 File Offset: 0x00296B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomInteractionEquipRequest()
		{
		}

		// Token: 0x06011BA9 RID: 72617 RVA: 0x00298963 File Offset: 0x00296B63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomInteractionEquipRequest(PhantomInteractionEquipRequest other) : this()
		{
			this.equipedMonsterIds_ = other.equipedMonsterIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011BAA RID: 72618 RVA: 0x0029898D File Offset: 0x00296B8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomInteractionEquipRequest Clone()
		{
			return new PhantomInteractionEquipRequest(this);
		}

		// Token: 0x17003ABE RID: 15038
		// (get) Token: 0x06011BAB RID: 72619 RVA: 0x00298995 File Offset: 0x00296B95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EquipedMonsterIds
		{
			get
			{
				return this.equipedMonsterIds_;
			}
		}

		// Token: 0x06011BAC RID: 72620 RVA: 0x0029899D File Offset: 0x00296B9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomInteractionEquipRequest);
		}

		// Token: 0x06011BAD RID: 72621 RVA: 0x002989AB File Offset: 0x00296BAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomInteractionEquipRequest other)
		{
			return other != null && (other == this || (this.equipedMonsterIds_.Equals(other.equipedMonsterIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011BAE RID: 72622 RVA: 0x002989E0 File Offset: 0x00296BE0
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

		// Token: 0x06011BAF RID: 72623 RVA: 0x00298A14 File Offset: 0x00296C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011BB0 RID: 72624 RVA: 0x00298A21 File Offset: 0x00296C21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011BB1 RID: 72625 RVA: 0x00298A2A File Offset: 0x00296C2A
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

		// Token: 0x06011BB2 RID: 72626 RVA: 0x00298A54 File Offset: 0x00296C54
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

		// Token: 0x06011BB3 RID: 72627 RVA: 0x00298A8D File Offset: 0x00296C8D
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

		// Token: 0x06011BB4 RID: 72628 RVA: 0x00298ABB File Offset: 0x00296CBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011BB5 RID: 72629 RVA: 0x00298AC4 File Offset: 0x00296CC4
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
				if (num != 32U && num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.equipedMonsterIds_.AddEntriesFrom(ref input, PhantomInteractionEquipRequest._repeated_equipedMonsterIds_codec);
				}
			}
		}

		// Token: 0x04006FD4 RID: 28628
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006FD5 RID: 28629
		public const int EquipedMonsterIdsFieldNumber = 4;

		// Token: 0x04006FD6 RID: 28630
		private static readonly FieldCodec<int> _repeated_equipedMonsterIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04006FD7 RID: 28631
		private readonly RepeatedField<int> equipedMonsterIds_ = new RepeatedField<int>();
	}
}
