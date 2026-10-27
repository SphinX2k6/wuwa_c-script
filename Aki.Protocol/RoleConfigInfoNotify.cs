using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001060 RID: 4192
	[NetMessage(EMessageId.RoleConfigInfoNotify)]
	public sealed class RoleConfigInfoNotify : IMessage<RoleConfigInfoNotify>, IMessage, IEquatable<RoleConfigInfoNotify>, IDeepCloneable<RoleConfigInfoNotify>, IBufferMessage
	{
		// Token: 0x0601665E RID: 91742 RVA: 0x00341313 File Offset: 0x0033F513
		[NullableContext(1)]
		public static RoleConfigInfoNotify Create()
		{
			return new RoleConfigInfoNotify();
		}

		// Token: 0x17004AEF RID: 19183
		// (get) Token: 0x0601665F RID: 91743 RVA: 0x0034131A File Offset: 0x0033F51A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004AF0 RID: 19184
		// (get) Token: 0x06016660 RID: 91744 RVA: 0x0034131D File Offset: 0x0033F51D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleConfigInfoNotify.Descriptor;
			}
		}

		// Token: 0x06016661 RID: 91745 RVA: 0x00341324 File Offset: 0x0033F524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleConfigInfoNotify()
		{
		}

		// Token: 0x06016662 RID: 91746 RVA: 0x00341337 File Offset: 0x0033F537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleConfigInfoNotify(RoleConfigInfoNotify other) : this()
		{
			this.roleConfigs_ = other.roleConfigs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016663 RID: 91747 RVA: 0x00341361 File Offset: 0x0033F561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleConfigInfoNotify Clone()
		{
			return new RoleConfigInfoNotify(this);
		}

		// Token: 0x17004AF1 RID: 19185
		// (get) Token: 0x06016664 RID: 91748 RVA: 0x00341369 File Offset: 0x0033F569
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleConfigInfo> RoleConfigs
		{
			get
			{
				return this.roleConfigs_;
			}
		}

		// Token: 0x06016665 RID: 91749 RVA: 0x00341371 File Offset: 0x0033F571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleConfigInfoNotify);
		}

		// Token: 0x06016666 RID: 91750 RVA: 0x0034137F File Offset: 0x0033F57F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleConfigInfoNotify other)
		{
			return other != null && (other == this || (this.roleConfigs_.Equals(other.roleConfigs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016667 RID: 91751 RVA: 0x003413B4 File Offset: 0x0033F5B4
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

		// Token: 0x06016668 RID: 91752 RVA: 0x003413E8 File Offset: 0x0033F5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016669 RID: 91753 RVA: 0x003413F5 File Offset: 0x0033F5F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601666A RID: 91754 RVA: 0x003413FE File Offset: 0x0033F5FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleConfigs_.WriteTo(ref output, RoleConfigInfoNotify._repeated_roleConfigs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601666B RID: 91755 RVA: 0x00341428 File Offset: 0x0033F628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roleConfigs_.CalculateSize(RoleConfigInfoNotify._repeated_roleConfigs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601666C RID: 91756 RVA: 0x00341461 File Offset: 0x0033F661
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleConfigInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.roleConfigs_.Add(other.roleConfigs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601666D RID: 91757 RVA: 0x0034148F File Offset: 0x0033F68F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601666E RID: 91758 RVA: 0x00341498 File Offset: 0x0033F698
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.roleConfigs_.AddEntriesFrom(ref input, RoleConfigInfoNotify._repeated_roleConfigs_codec);
				}
			}
		}

		// Token: 0x040085ED RID: 34285
		private UnknownFieldSet _unknownFields;

		// Token: 0x040085EE RID: 34286
		public const int RoleConfigsFieldNumber = 7;

		// Token: 0x040085EF RID: 34287
		private static readonly FieldCodec<RoleConfigInfo> _repeated_roleConfigs_codec = FieldCodec.ForMessage<RoleConfigInfo>(58U, RoleConfigInfo.Parser);

		// Token: 0x040085F0 RID: 34288
		private readonly RepeatedField<RoleConfigInfo> roleConfigs_ = new RepeatedField<RoleConfigInfo>();
	}
}
