using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011ED RID: 4589
	[NetMessage(EMessageId.ShieldUpdateNotify)]
	public sealed class ShieldUpdateNotify : IMessage<ShieldUpdateNotify>, IMessage, IEquatable<ShieldUpdateNotify>, IDeepCloneable<ShieldUpdateNotify>, IBufferMessage
	{
		// Token: 0x06018768 RID: 100200 RVA: 0x0038E8DC File Offset: 0x0038CADC
		[NullableContext(1)]
		public static ShieldUpdateNotify Create()
		{
			return new ShieldUpdateNotify();
		}

		// Token: 0x1700525F RID: 21087
		// (get) Token: 0x06018769 RID: 100201 RVA: 0x0038E8E3 File Offset: 0x0038CAE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005260 RID: 21088
		// (get) Token: 0x0601876A RID: 100202 RVA: 0x0038E8E6 File Offset: 0x0038CAE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShieldUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601876B RID: 100203 RVA: 0x0038E8ED File Offset: 0x0038CAED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShieldUpdateNotify()
		{
		}

		// Token: 0x0601876C RID: 100204 RVA: 0x0038E900 File Offset: 0x0038CB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShieldUpdateNotify(ShieldUpdateNotify other) : this()
		{
			this.shields_ = other.shields_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601876D RID: 100205 RVA: 0x0038E92A File Offset: 0x0038CB2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShieldUpdateNotify Clone()
		{
			return new ShieldUpdateNotify(this);
		}

		// Token: 0x17005261 RID: 21089
		// (get) Token: 0x0601876E RID: 100206 RVA: 0x0038E932 File Offset: 0x0038CB32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ShieldUpdateInfo> Shields
		{
			get
			{
				return this.shields_;
			}
		}

		// Token: 0x0601876F RID: 100207 RVA: 0x0038E93A File Offset: 0x0038CB3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShieldUpdateNotify);
		}

		// Token: 0x06018770 RID: 100208 RVA: 0x0038E948 File Offset: 0x0038CB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShieldUpdateNotify other)
		{
			return other != null && (other == this || (this.shields_.Equals(other.shields_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018771 RID: 100209 RVA: 0x0038E97C File Offset: 0x0038CB7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.shields_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018772 RID: 100210 RVA: 0x0038E9B0 File Offset: 0x0038CBB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018773 RID: 100211 RVA: 0x0038E9BD File Offset: 0x0038CBBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018774 RID: 100212 RVA: 0x0038E9C6 File Offset: 0x0038CBC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.shields_.WriteTo(ref output, ShieldUpdateNotify._repeated_shields_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018775 RID: 100213 RVA: 0x0038E9F0 File Offset: 0x0038CBF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.shields_.CalculateSize(ShieldUpdateNotify._repeated_shields_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018776 RID: 100214 RVA: 0x0038EA29 File Offset: 0x0038CC29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShieldUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.shields_.Add(other.shields_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018777 RID: 100215 RVA: 0x0038EA57 File Offset: 0x0038CC57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018778 RID: 100216 RVA: 0x0038EA60 File Offset: 0x0038CC60
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.shields_.AddEntriesFrom(ref input, ShieldUpdateNotify._repeated_shields_codec);
				}
			}
		}

		// Token: 0x0400909E RID: 37022
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400909F RID: 37023
		public const int ShieldsFieldNumber = 15;

		// Token: 0x040090A0 RID: 37024
		private static readonly FieldCodec<ShieldUpdateInfo> _repeated_shields_codec = FieldCodec.ForMessage<ShieldUpdateInfo>(122U, ShieldUpdateInfo.Parser);

		// Token: 0x040090A1 RID: 37025
		private readonly RepeatedField<ShieldUpdateInfo> shields_ = new RepeatedField<ShieldUpdateInfo>();
	}
}
