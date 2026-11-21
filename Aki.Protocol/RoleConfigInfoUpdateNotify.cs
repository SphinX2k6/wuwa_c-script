using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001051 RID: 4177
	[NetMessage(EMessageId.RoleConfigInfoUpdateNotify)]
	public sealed class RoleConfigInfoUpdateNotify : IMessage<RoleConfigInfoUpdateNotify>, IMessage, IEquatable<RoleConfigInfoUpdateNotify>, IDeepCloneable<RoleConfigInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601658B RID: 91531 RVA: 0x0033FE21 File Offset: 0x0033E021
		[NullableContext(1)]
		public static RoleConfigInfoUpdateNotify Create()
		{
			return new RoleConfigInfoUpdateNotify();
		}

		// Token: 0x17004AC8 RID: 19144
		// (get) Token: 0x0601658C RID: 91532 RVA: 0x0033FE28 File Offset: 0x0033E028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004AC9 RID: 19145
		// (get) Token: 0x0601658D RID: 91533 RVA: 0x0033FE2B File Offset: 0x0033E02B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleConfigInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601658E RID: 91534 RVA: 0x0033FE32 File Offset: 0x0033E032
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleConfigInfoUpdateNotify()
		{
		}

		// Token: 0x0601658F RID: 91535 RVA: 0x0033FE45 File Offset: 0x0033E045
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleConfigInfoUpdateNotify(RoleConfigInfoUpdateNotify other) : this()
		{
			this.roleConfigs_ = other.roleConfigs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016590 RID: 91536 RVA: 0x0033FE6F File Offset: 0x0033E06F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleConfigInfoUpdateNotify Clone()
		{
			return new RoleConfigInfoUpdateNotify(this);
		}

		// Token: 0x17004ACA RID: 19146
		// (get) Token: 0x06016591 RID: 91537 RVA: 0x0033FE77 File Offset: 0x0033E077
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleConfigInfo> RoleConfigs
		{
			get
			{
				return this.roleConfigs_;
			}
		}

		// Token: 0x06016592 RID: 91538 RVA: 0x0033FE7F File Offset: 0x0033E07F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleConfigInfoUpdateNotify);
		}

		// Token: 0x06016593 RID: 91539 RVA: 0x0033FE8D File Offset: 0x0033E08D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleConfigInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.roleConfigs_.Equals(other.roleConfigs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016594 RID: 91540 RVA: 0x0033FEC0 File Offset: 0x0033E0C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roleConfigs_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016595 RID: 91541 RVA: 0x0033FEF4 File Offset: 0x0033E0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016596 RID: 91542 RVA: 0x0033FF01 File Offset: 0x0033E101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016597 RID: 91543 RVA: 0x0033FF0A File Offset: 0x0033E10A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleConfigs_.WriteTo(ref output, RoleConfigInfoUpdateNotify._repeated_roleConfigs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016598 RID: 91544 RVA: 0x0033FF34 File Offset: 0x0033E134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roleConfigs_.CalculateSize(RoleConfigInfoUpdateNotify._repeated_roleConfigs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016599 RID: 91545 RVA: 0x0033FF6D File Offset: 0x0033E16D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleConfigInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.roleConfigs_.Add(other.roleConfigs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601659A RID: 91546 RVA: 0x0033FF9B File Offset: 0x0033E19B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601659B RID: 91547 RVA: 0x0033FFA4 File Offset: 0x0033E1A4
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.roleConfigs_.AddEntriesFrom(ref input, RoleConfigInfoUpdateNotify._repeated_roleConfigs_codec);
				}
			}
		}

		// Token: 0x0400861B RID: 34331
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400861C RID: 34332
		public const int RoleConfigsFieldNumber = 12;

		// Token: 0x0400861D RID: 34333
		private static readonly FieldCodec<RoleConfigInfo> _repeated_roleConfigs_codec = FieldCodec.ForMessage<RoleConfigInfo>(98U, RoleConfigInfo.Parser);

		// Token: 0x0400861E RID: 34334
		private readonly RepeatedField<RoleConfigInfo> roleConfigs_ = new RepeatedField<RoleConfigInfo>();
	}
}
