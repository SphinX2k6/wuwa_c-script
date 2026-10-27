using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F27 RID: 3879
	[NetMessage(EMessageId.ResetSpecialBonusNotify)]
	public sealed class ResetSpecialBonusNotify : IMessage<ResetSpecialBonusNotify>, IMessage, IEquatable<ResetSpecialBonusNotify>, IDeepCloneable<ResetSpecialBonusNotify>, IBufferMessage
	{
		// Token: 0x06014C20 RID: 85024 RVA: 0x00303155 File Offset: 0x00301355
		[NullableContext(1)]
		public static ResetSpecialBonusNotify Create()
		{
			return new ResetSpecialBonusNotify();
		}

		// Token: 0x170044FD RID: 17661
		// (get) Token: 0x06014C21 RID: 85025 RVA: 0x0030315C File Offset: 0x0030135C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044FE RID: 17662
		// (get) Token: 0x06014C22 RID: 85026 RVA: 0x0030315F File Offset: 0x0030135F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ResetSpecialBonusNotify.Descriptor;
			}
		}

		// Token: 0x06014C23 RID: 85027 RVA: 0x00303166 File Offset: 0x00301366
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetSpecialBonusNotify()
		{
		}

		// Token: 0x06014C24 RID: 85028 RVA: 0x00303179 File Offset: 0x00301379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetSpecialBonusNotify(ResetSpecialBonusNotify other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014C25 RID: 85029 RVA: 0x003031A3 File Offset: 0x003013A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetSpecialBonusNotify Clone()
		{
			return new ResetSpecialBonusNotify(this);
		}

		// Token: 0x170044FF RID: 17663
		// (get) Token: 0x06014C26 RID: 85030 RVA: 0x003031AB File Offset: 0x003013AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x06014C27 RID: 85031 RVA: 0x003031B3 File Offset: 0x003013B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ResetSpecialBonusNotify);
		}

		// Token: 0x06014C28 RID: 85032 RVA: 0x003031C1 File Offset: 0x003013C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ResetSpecialBonusNotify other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014C29 RID: 85033 RVA: 0x003031F4 File Offset: 0x003013F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014C2A RID: 85034 RVA: 0x00303228 File Offset: 0x00301428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014C2B RID: 85035 RVA: 0x00303235 File Offset: 0x00301435
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014C2C RID: 85036 RVA: 0x0030323E File Offset: 0x0030143E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, ResetSpecialBonusNotify._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014C2D RID: 85037 RVA: 0x00303268 File Offset: 0x00301468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(ResetSpecialBonusNotify._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014C2E RID: 85038 RVA: 0x003032A1 File Offset: 0x003014A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ResetSpecialBonusNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014C2F RID: 85039 RVA: 0x003032CF File Offset: 0x003014CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014C30 RID: 85040 RVA: 0x003032D8 File Offset: 0x003014D8
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
					this.ids_.AddEntriesFrom(ref input, ResetSpecialBonusNotify._repeated_ids_codec);
				}
			}
		}

		// Token: 0x04007D56 RID: 32086
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D57 RID: 32087
		public const int IdsFieldNumber = 6;

		// Token: 0x04007D58 RID: 32088
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04007D59 RID: 32089
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
