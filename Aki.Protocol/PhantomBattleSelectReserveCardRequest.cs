using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CA0 RID: 3232
	[NetMessage(EMessageId.PhantomBattleSelectReserveCardRequest)]
	public sealed class PhantomBattleSelectReserveCardRequest : IMessage<PhantomBattleSelectReserveCardRequest>, IMessage, IEquatable<PhantomBattleSelectReserveCardRequest>, IDeepCloneable<PhantomBattleSelectReserveCardRequest>, IBufferMessage
	{
		// Token: 0x06011882 RID: 71810 RVA: 0x00291BF4 File Offset: 0x0028FDF4
		[NullableContext(1)]
		public static PhantomBattleSelectReserveCardRequest Create()
		{
			return new PhantomBattleSelectReserveCardRequest();
		}

		// Token: 0x17003A12 RID: 14866
		// (get) Token: 0x06011883 RID: 71811 RVA: 0x00291BFB File Offset: 0x0028FDFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A13 RID: 14867
		// (get) Token: 0x06011884 RID: 71812 RVA: 0x00291BFE File Offset: 0x0028FDFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleSelectReserveCardRequest.Descriptor;
			}
		}

		// Token: 0x06011885 RID: 71813 RVA: 0x00291C05 File Offset: 0x0028FE05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSelectReserveCardRequest()
		{
		}

		// Token: 0x06011886 RID: 71814 RVA: 0x00291C18 File Offset: 0x0028FE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSelectReserveCardRequest(PhantomBattleSelectReserveCardRequest other) : this()
		{
			this.reserveCardUIds_ = other.reserveCardUIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011887 RID: 71815 RVA: 0x00291C42 File Offset: 0x0028FE42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSelectReserveCardRequest Clone()
		{
			return new PhantomBattleSelectReserveCardRequest(this);
		}

		// Token: 0x17003A14 RID: 14868
		// (get) Token: 0x06011888 RID: 71816 RVA: 0x00291C4A File Offset: 0x0028FE4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ReserveCardUIds
		{
			get
			{
				return this.reserveCardUIds_;
			}
		}

		// Token: 0x06011889 RID: 71817 RVA: 0x00291C52 File Offset: 0x0028FE52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleSelectReserveCardRequest);
		}

		// Token: 0x0601188A RID: 71818 RVA: 0x00291C60 File Offset: 0x0028FE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleSelectReserveCardRequest other)
		{
			return other != null && (other == this || (this.reserveCardUIds_.Equals(other.reserveCardUIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601188B RID: 71819 RVA: 0x00291C94 File Offset: 0x0028FE94
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

		// Token: 0x0601188C RID: 71820 RVA: 0x00291CC8 File Offset: 0x0028FEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601188D RID: 71821 RVA: 0x00291CD5 File Offset: 0x0028FED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601188E RID: 71822 RVA: 0x00291CDE File Offset: 0x0028FEDE
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

		// Token: 0x0601188F RID: 71823 RVA: 0x00291D08 File Offset: 0x0028FF08
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

		// Token: 0x06011890 RID: 71824 RVA: 0x00291D41 File Offset: 0x0028FF41
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

		// Token: 0x06011891 RID: 71825 RVA: 0x00291D6F File Offset: 0x0028FF6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011892 RID: 71826 RVA: 0x00291D78 File Offset: 0x0028FF78
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
				if (num != 16U && num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.reserveCardUIds_.AddEntriesFrom(ref input, PhantomBattleSelectReserveCardRequest._repeated_reserveCardUIds_codec);
				}
			}
		}

		// Token: 0x04006EE7 RID: 28391
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006EE8 RID: 28392
		public const int ReserveCardUIdsFieldNumber = 2;

		// Token: 0x04006EE9 RID: 28393
		private static readonly FieldCodec<int> _repeated_reserveCardUIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04006EEA RID: 28394
		private readonly RepeatedField<int> reserveCardUIds_ = new RepeatedField<int>();
	}
}
