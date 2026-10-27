using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001061 RID: 4193
	[NetMessage(EMessageId.RoleConfigInfoUpdateNotify)]
	public sealed class RoleConfigInfoUpdateNotify : IMessage<RoleConfigInfoUpdateNotify>, IMessage, IEquatable<RoleConfigInfoUpdateNotify>, IDeepCloneable<RoleConfigInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06016670 RID: 91760 RVA: 0x003414F5 File Offset: 0x0033F6F5
		[NullableContext(1)]
		public static RoleConfigInfoUpdateNotify Create()
		{
			return new RoleConfigInfoUpdateNotify();
		}

		// Token: 0x17004AF2 RID: 19186
		// (get) Token: 0x06016671 RID: 91761 RVA: 0x003414FC File Offset: 0x0033F6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004AF3 RID: 19187
		// (get) Token: 0x06016672 RID: 91762 RVA: 0x003414FF File Offset: 0x0033F6FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleConfigInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06016673 RID: 91763 RVA: 0x00341506 File Offset: 0x0033F706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleConfigInfoUpdateNotify()
		{
		}

		// Token: 0x06016674 RID: 91764 RVA: 0x00341519 File Offset: 0x0033F719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleConfigInfoUpdateNotify(RoleConfigInfoUpdateNotify other) : this()
		{
			this.roleConfigs_ = other.roleConfigs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016675 RID: 91765 RVA: 0x00341543 File Offset: 0x0033F743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleConfigInfoUpdateNotify Clone()
		{
			return new RoleConfigInfoUpdateNotify(this);
		}

		// Token: 0x17004AF4 RID: 19188
		// (get) Token: 0x06016676 RID: 91766 RVA: 0x0034154B File Offset: 0x0033F74B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleConfigInfo> RoleConfigs
		{
			get
			{
				return this.roleConfigs_;
			}
		}

		// Token: 0x06016677 RID: 91767 RVA: 0x00341553 File Offset: 0x0033F753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleConfigInfoUpdateNotify);
		}

		// Token: 0x06016678 RID: 91768 RVA: 0x00341561 File Offset: 0x0033F761
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleConfigInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.roleConfigs_.Equals(other.roleConfigs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016679 RID: 91769 RVA: 0x00341594 File Offset: 0x0033F794
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

		// Token: 0x0601667A RID: 91770 RVA: 0x003415C8 File Offset: 0x0033F7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601667B RID: 91771 RVA: 0x003415D5 File Offset: 0x0033F7D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601667C RID: 91772 RVA: 0x003415DE File Offset: 0x0033F7DE
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

		// Token: 0x0601667D RID: 91773 RVA: 0x00341608 File Offset: 0x0033F808
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

		// Token: 0x0601667E RID: 91774 RVA: 0x00341641 File Offset: 0x0033F841
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

		// Token: 0x0601667F RID: 91775 RVA: 0x0034166F File Offset: 0x0033F86F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016680 RID: 91776 RVA: 0x00341678 File Offset: 0x0033F878
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.roleConfigs_.AddEntriesFrom(ref input, RoleConfigInfoUpdateNotify._repeated_roleConfigs_codec);
				}
			}
		}

		// Token: 0x040085F1 RID: 34289
		private UnknownFieldSet _unknownFields;

		// Token: 0x040085F2 RID: 34290
		public const int RoleConfigsFieldNumber = 8;

		// Token: 0x040085F3 RID: 34291
		private static readonly FieldCodec<RoleConfigInfo> _repeated_roleConfigs_codec = FieldCodec.ForMessage<RoleConfigInfo>(66U, RoleConfigInfo.Parser);

		// Token: 0x040085F4 RID: 34292
		private readonly RepeatedField<RoleConfigInfo> roleConfigs_ = new RepeatedField<RoleConfigInfo>();
	}
}
