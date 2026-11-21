using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B6D RID: 2925
	[NetMessage(EMessageId.OccupationInfoNotify)]
	public sealed class OccupationInfoNotify : IMessage<OccupationInfoNotify>, IMessage, IEquatable<OccupationInfoNotify>, IDeepCloneable<OccupationInfoNotify>, IBufferMessage
	{
		// Token: 0x0600FDE4 RID: 64996 RVA: 0x00250E7F File Offset: 0x0024F07F
		[NullableContext(1)]
		public static OccupationInfoNotify Create()
		{
			return new OccupationInfoNotify();
		}

		// Token: 0x170033D2 RID: 13266
		// (get) Token: 0x0600FDE5 RID: 64997 RVA: 0x00250E86 File Offset: 0x0024F086
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170033D3 RID: 13267
		// (get) Token: 0x0600FDE6 RID: 64998 RVA: 0x00250E89 File Offset: 0x0024F089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OccupationInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600FDE7 RID: 64999 RVA: 0x00250E90 File Offset: 0x0024F090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OccupationInfoNotify()
		{
		}

		// Token: 0x0600FDE8 RID: 65000 RVA: 0x00250EA3 File Offset: 0x0024F0A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OccupationInfoNotify(OccupationInfoNotify other) : this()
		{
			this.occupationInfo_ = other.occupationInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FDE9 RID: 65001 RVA: 0x00250ECD File Offset: 0x0024F0CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OccupationInfoNotify Clone()
		{
			return new OccupationInfoNotify(this);
		}

		// Token: 0x170033D4 RID: 13268
		// (get) Token: 0x0600FDEA RID: 65002 RVA: 0x00250ED5 File Offset: 0x0024F0D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OccupationPbInfo> OccupationInfo
		{
			get
			{
				return this.occupationInfo_;
			}
		}

		// Token: 0x0600FDEB RID: 65003 RVA: 0x00250EDD File Offset: 0x0024F0DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OccupationInfoNotify);
		}

		// Token: 0x0600FDEC RID: 65004 RVA: 0x00250EEB File Offset: 0x0024F0EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OccupationInfoNotify other)
		{
			return other != null && (other == this || (this.occupationInfo_.Equals(other.occupationInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FDED RID: 65005 RVA: 0x00250F20 File Offset: 0x0024F120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.occupationInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FDEE RID: 65006 RVA: 0x00250F54 File Offset: 0x0024F154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FDEF RID: 65007 RVA: 0x00250F61 File Offset: 0x0024F161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FDF0 RID: 65008 RVA: 0x00250F6A File Offset: 0x0024F16A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.occupationInfo_.WriteTo(ref output, OccupationInfoNotify._repeated_occupationInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FDF1 RID: 65009 RVA: 0x00250F94 File Offset: 0x0024F194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.occupationInfo_.CalculateSize(OccupationInfoNotify._repeated_occupationInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FDF2 RID: 65010 RVA: 0x00250FCD File Offset: 0x0024F1CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OccupationInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.occupationInfo_.Add(other.occupationInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FDF3 RID: 65011 RVA: 0x00250FFB File Offset: 0x0024F1FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FDF4 RID: 65012 RVA: 0x00251004 File Offset: 0x0024F204
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.occupationInfo_.AddEntriesFrom(ref input, OccupationInfoNotify._repeated_occupationInfo_codec);
				}
			}
		}

		// Token: 0x040065A0 RID: 26016
		private UnknownFieldSet _unknownFields;

		// Token: 0x040065A1 RID: 26017
		public const int OccupationInfoFieldNumber = 1;

		// Token: 0x040065A2 RID: 26018
		private static readonly FieldCodec<OccupationPbInfo> _repeated_occupationInfo_codec = FieldCodec.ForMessage<OccupationPbInfo>(10U, OccupationPbInfo.Parser);

		// Token: 0x040065A3 RID: 26019
		private readonly RepeatedField<OccupationPbInfo> occupationInfo_ = new RepeatedField<OccupationPbInfo>();
	}
}
