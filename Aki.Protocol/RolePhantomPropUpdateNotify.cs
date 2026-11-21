using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001089 RID: 4233
	[NetMessage(EMessageId.RolePhantomPropUpdateNotify)]
	public sealed class RolePhantomPropUpdateNotify : IMessage<RolePhantomPropUpdateNotify>, IMessage, IEquatable<RolePhantomPropUpdateNotify>, IDeepCloneable<RolePhantomPropUpdateNotify>, IBufferMessage
	{
		// Token: 0x06016A3F RID: 92735 RVA: 0x0034B266 File Offset: 0x00349466
		[NullableContext(1)]
		public static RolePhantomPropUpdateNotify Create()
		{
			return new RolePhantomPropUpdateNotify();
		}

		// Token: 0x17004BE1 RID: 19425
		// (get) Token: 0x06016A40 RID: 92736 RVA: 0x0034B26D File Offset: 0x0034946D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BE2 RID: 19426
		// (get) Token: 0x06016A41 RID: 92737 RVA: 0x0034B270 File Offset: 0x00349470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RolePhantomPropUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06016A42 RID: 92738 RVA: 0x0034B277 File Offset: 0x00349477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePhantomPropUpdateNotify()
		{
		}

		// Token: 0x06016A43 RID: 92739 RVA: 0x0034B28A File Offset: 0x0034948A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePhantomPropUpdateNotify(RolePhantomPropUpdateNotify other) : this()
		{
			this.propInfo_ = other.propInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016A44 RID: 92740 RVA: 0x0034B2B4 File Offset: 0x003494B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePhantomPropUpdateNotify Clone()
		{
			return new RolePhantomPropUpdateNotify(this);
		}

		// Token: 0x17004BE3 RID: 19427
		// (get) Token: 0x06016A45 RID: 92741 RVA: 0x0034B2BC File Offset: 0x003494BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RolePhantomPropInfo> PropInfo
		{
			get
			{
				return this.propInfo_;
			}
		}

		// Token: 0x06016A46 RID: 92742 RVA: 0x0034B2C4 File Offset: 0x003494C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RolePhantomPropUpdateNotify);
		}

		// Token: 0x06016A47 RID: 92743 RVA: 0x0034B2D2 File Offset: 0x003494D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RolePhantomPropUpdateNotify other)
		{
			return other != null && (other == this || (this.propInfo_.Equals(other.propInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016A48 RID: 92744 RVA: 0x0034B308 File Offset: 0x00349508
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

		// Token: 0x06016A49 RID: 92745 RVA: 0x0034B33C File Offset: 0x0034953C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016A4A RID: 92746 RVA: 0x0034B349 File Offset: 0x00349549
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016A4B RID: 92747 RVA: 0x0034B352 File Offset: 0x00349552
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

		// Token: 0x06016A4C RID: 92748 RVA: 0x0034B37C File Offset: 0x0034957C
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

		// Token: 0x06016A4D RID: 92749 RVA: 0x0034B3B5 File Offset: 0x003495B5
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

		// Token: 0x06016A4E RID: 92750 RVA: 0x0034B3E3 File Offset: 0x003495E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016A4F RID: 92751 RVA: 0x0034B3EC File Offset: 0x003495EC
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
					this.propInfo_.AddEntriesFrom(ref input, RolePhantomPropUpdateNotify._repeated_propInfo_codec);
				}
			}
		}

		// Token: 0x040087C5 RID: 34757
		private UnknownFieldSet _unknownFields;

		// Token: 0x040087C6 RID: 34758
		public const int PropInfoFieldNumber = 15;

		// Token: 0x040087C7 RID: 34759
		private static readonly FieldCodec<RolePhantomPropInfo> _repeated_propInfo_codec = FieldCodec.ForMessage<RolePhantomPropInfo>(122U, RolePhantomPropInfo.Parser);

		// Token: 0x040087C8 RID: 34760
		private readonly RepeatedField<RolePhantomPropInfo> propInfo_ = new RepeatedField<RolePhantomPropInfo>();
	}
}
