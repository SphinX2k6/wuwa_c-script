using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001099 RID: 4249
	[NetMessage(EMessageId.RolePhantomPropUpdateNotify)]
	public sealed class RolePhantomPropUpdateNotify : IMessage<RolePhantomPropUpdateNotify>, IMessage, IEquatable<RolePhantomPropUpdateNotify>, IDeepCloneable<RolePhantomPropUpdateNotify>, IBufferMessage
	{
		// Token: 0x06016B24 RID: 92964 RVA: 0x0034C942 File Offset: 0x0034AB42
		[NullableContext(1)]
		public static RolePhantomPropUpdateNotify Create()
		{
			return new RolePhantomPropUpdateNotify();
		}

		// Token: 0x17004C0B RID: 19467
		// (get) Token: 0x06016B25 RID: 92965 RVA: 0x0034C949 File Offset: 0x0034AB49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C0C RID: 19468
		// (get) Token: 0x06016B26 RID: 92966 RVA: 0x0034C94C File Offset: 0x0034AB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RolePhantomPropUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06016B27 RID: 92967 RVA: 0x0034C953 File Offset: 0x0034AB53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePhantomPropUpdateNotify()
		{
		}

		// Token: 0x06016B28 RID: 92968 RVA: 0x0034C966 File Offset: 0x0034AB66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePhantomPropUpdateNotify(RolePhantomPropUpdateNotify other) : this()
		{
			this.propInfo_ = other.propInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016B29 RID: 92969 RVA: 0x0034C990 File Offset: 0x0034AB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePhantomPropUpdateNotify Clone()
		{
			return new RolePhantomPropUpdateNotify(this);
		}

		// Token: 0x17004C0D RID: 19469
		// (get) Token: 0x06016B2A RID: 92970 RVA: 0x0034C998 File Offset: 0x0034AB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RolePhantomPropInfo> PropInfo
		{
			get
			{
				return this.propInfo_;
			}
		}

		// Token: 0x06016B2B RID: 92971 RVA: 0x0034C9A0 File Offset: 0x0034ABA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RolePhantomPropUpdateNotify);
		}

		// Token: 0x06016B2C RID: 92972 RVA: 0x0034C9AE File Offset: 0x0034ABAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RolePhantomPropUpdateNotify other)
		{
			return other != null && (other == this || (this.propInfo_.Equals(other.propInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016B2D RID: 92973 RVA: 0x0034C9E4 File Offset: 0x0034ABE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.propInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016B2E RID: 92974 RVA: 0x0034CA18 File Offset: 0x0034AC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016B2F RID: 92975 RVA: 0x0034CA25 File Offset: 0x0034AC25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016B30 RID: 92976 RVA: 0x0034CA2E File Offset: 0x0034AC2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.propInfo_.WriteTo(ref output, RolePhantomPropUpdateNotify._repeated_propInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016B31 RID: 92977 RVA: 0x0034CA58 File Offset: 0x0034AC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.propInfo_.CalculateSize(RolePhantomPropUpdateNotify._repeated_propInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016B32 RID: 92978 RVA: 0x0034CA91 File Offset: 0x0034AC91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RolePhantomPropUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.propInfo_.Add(other.propInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016B33 RID: 92979 RVA: 0x0034CABF File Offset: 0x0034ACBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016B34 RID: 92980 RVA: 0x0034CAC8 File Offset: 0x0034ACC8
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
					this.propInfo_.AddEntriesFrom(ref input, RolePhantomPropUpdateNotify._repeated_propInfo_codec);
				}
			}
		}

		// Token: 0x0400879B RID: 34715
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400879C RID: 34716
		public const int PropInfoFieldNumber = 7;

		// Token: 0x0400879D RID: 34717
		private static readonly FieldCodec<RolePhantomPropInfo> _repeated_propInfo_codec = FieldCodec.ForMessage<RolePhantomPropInfo>(58U, RolePhantomPropInfo.Parser);

		// Token: 0x0400879E RID: 34718
		private readonly RepeatedField<RolePhantomPropInfo> propInfo_ = new RepeatedField<RolePhantomPropInfo>();
	}
}
