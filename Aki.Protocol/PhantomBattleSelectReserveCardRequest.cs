using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CB0 RID: 3248
	[NetMessage(EMessageId.PhantomBattleSelectReserveCardRequest)]
	public sealed class PhantomBattleSelectReserveCardRequest : IMessage<PhantomBattleSelectReserveCardRequest>, IMessage, IEquatable<PhantomBattleSelectReserveCardRequest>, IDeepCloneable<PhantomBattleSelectReserveCardRequest>, IBufferMessage
	{
		// Token: 0x06011982 RID: 72066 RVA: 0x00293960 File Offset: 0x00291B60
		[NullableContext(1)]
		public static PhantomBattleSelectReserveCardRequest Create()
		{
			return new PhantomBattleSelectReserveCardRequest();
		}

		// Token: 0x17003A49 RID: 14921
		// (get) Token: 0x06011983 RID: 72067 RVA: 0x00293967 File Offset: 0x00291B67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A4A RID: 14922
		// (get) Token: 0x06011984 RID: 72068 RVA: 0x0029396A File Offset: 0x00291B6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleSelectReserveCardRequest.Descriptor;
			}
		}

		// Token: 0x06011985 RID: 72069 RVA: 0x00293971 File Offset: 0x00291B71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSelectReserveCardRequest()
		{
		}

		// Token: 0x06011986 RID: 72070 RVA: 0x00293984 File Offset: 0x00291B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSelectReserveCardRequest(PhantomBattleSelectReserveCardRequest other) : this()
		{
			this.reserveCardUIds_ = other.reserveCardUIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011987 RID: 72071 RVA: 0x002939AE File Offset: 0x00291BAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSelectReserveCardRequest Clone()
		{
			return new PhantomBattleSelectReserveCardRequest(this);
		}

		// Token: 0x17003A4B RID: 14923
		// (get) Token: 0x06011988 RID: 72072 RVA: 0x002939B6 File Offset: 0x00291BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ReserveCardUIds
		{
			get
			{
				return this.reserveCardUIds_;
			}
		}

		// Token: 0x06011989 RID: 72073 RVA: 0x002939BE File Offset: 0x00291BBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleSelectReserveCardRequest);
		}

		// Token: 0x0601198A RID: 72074 RVA: 0x002939CC File Offset: 0x00291BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleSelectReserveCardRequest other)
		{
			return other != null && (other == this || (this.reserveCardUIds_.Equals(other.reserveCardUIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601198B RID: 72075 RVA: 0x00293A00 File Offset: 0x00291C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.reserveCardUIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601198C RID: 72076 RVA: 0x00293A34 File Offset: 0x00291C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601198D RID: 72077 RVA: 0x00293A41 File Offset: 0x00291C41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601198E RID: 72078 RVA: 0x00293A4A File Offset: 0x00291C4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.reserveCardUIds_.WriteTo(ref output, PhantomBattleSelectReserveCardRequest._repeated_reserveCardUIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601198F RID: 72079 RVA: 0x00293A74 File Offset: 0x00291C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.reserveCardUIds_.CalculateSize(PhantomBattleSelectReserveCardRequest._repeated_reserveCardUIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011990 RID: 72080 RVA: 0x00293AAD File Offset: 0x00291CAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleSelectReserveCardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.reserveCardUIds_.Add(other.reserveCardUIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011991 RID: 72081 RVA: 0x00293ADB File Offset: 0x00291CDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011992 RID: 72082 RVA: 0x00293AE4 File Offset: 0x00291CE4
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
					this.reserveCardUIds_.AddEntriesFrom(ref input, PhantomBattleSelectReserveCardRequest._repeated_reserveCardUIds_codec);
				}
			}
		}

		// Token: 0x04006ED3 RID: 28371
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006ED4 RID: 28372
		public const int ReserveCardUIdsFieldNumber = 6;

		// Token: 0x04006ED5 RID: 28373
		private static readonly FieldCodec<int> _repeated_reserveCardUIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04006ED6 RID: 28374
		private readonly RepeatedField<int> reserveCardUIds_ = new RepeatedField<int>();
	}
}
