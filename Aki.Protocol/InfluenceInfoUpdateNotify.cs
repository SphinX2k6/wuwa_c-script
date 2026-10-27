using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007D1 RID: 2001
	[NetMessage(EMessageId.InfluenceInfoUpdateNotify)]
	public sealed class InfluenceInfoUpdateNotify : IMessage<InfluenceInfoUpdateNotify>, IMessage, IEquatable<InfluenceInfoUpdateNotify>, IDeepCloneable<InfluenceInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600B3DE RID: 46046 RVA: 0x001AE539 File Offset: 0x001AC739
		[NullableContext(1)]
		public static InfluenceInfoUpdateNotify Create()
		{
			return new InfluenceInfoUpdateNotify();
		}

		// Token: 0x1700244B RID: 9291
		// (get) Token: 0x0600B3DF RID: 46047 RVA: 0x001AE540 File Offset: 0x001AC740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700244C RID: 9292
		// (get) Token: 0x0600B3E0 RID: 46048 RVA: 0x001AE543 File Offset: 0x001AC743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfluenceInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600B3E1 RID: 46049 RVA: 0x001AE54A File Offset: 0x001AC74A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfluenceInfoUpdateNotify()
		{
		}

		// Token: 0x0600B3E2 RID: 46050 RVA: 0x001AE55D File Offset: 0x001AC75D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfluenceInfoUpdateNotify(InfluenceInfoUpdateNotify other) : this()
		{
			this.influenceInfos_ = other.influenceInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B3E3 RID: 46051 RVA: 0x001AE587 File Offset: 0x001AC787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfluenceInfoUpdateNotify Clone()
		{
			return new InfluenceInfoUpdateNotify(this);
		}

		// Token: 0x1700244D RID: 9293
		// (get) Token: 0x0600B3E4 RID: 46052 RVA: 0x001AE58F File Offset: 0x001AC78F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneInfluenceInfo> InfluenceInfos
		{
			get
			{
				return this.influenceInfos_;
			}
		}

		// Token: 0x0600B3E5 RID: 46053 RVA: 0x001AE597 File Offset: 0x001AC797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfluenceInfoUpdateNotify);
		}

		// Token: 0x0600B3E6 RID: 46054 RVA: 0x001AE5A5 File Offset: 0x001AC7A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfluenceInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.influenceInfos_.Equals(other.influenceInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B3E7 RID: 46055 RVA: 0x001AE5D8 File Offset: 0x001AC7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.influenceInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B3E8 RID: 46056 RVA: 0x001AE60C File Offset: 0x001AC80C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B3E9 RID: 46057 RVA: 0x001AE619 File Offset: 0x001AC819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B3EA RID: 46058 RVA: 0x001AE622 File Offset: 0x001AC822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.influenceInfos_.WriteTo(ref output, InfluenceInfoUpdateNotify._repeated_influenceInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B3EB RID: 46059 RVA: 0x001AE64C File Offset: 0x001AC84C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.influenceInfos_.CalculateSize(InfluenceInfoUpdateNotify._repeated_influenceInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B3EC RID: 46060 RVA: 0x001AE685 File Offset: 0x001AC885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfluenceInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.influenceInfos_.Add(other.influenceInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B3ED RID: 46061 RVA: 0x001AE6B3 File Offset: 0x001AC8B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B3EE RID: 46062 RVA: 0x001AE6BC File Offset: 0x001AC8BC
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.influenceInfos_.AddEntriesFrom(ref input, InfluenceInfoUpdateNotify._repeated_influenceInfos_codec);
				}
			}
		}

		// Token: 0x04005029 RID: 20521
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400502A RID: 20522
		public const int InfluenceInfosFieldNumber = 9;

		// Token: 0x0400502B RID: 20523
		private static readonly FieldCodec<OneInfluenceInfo> _repeated_influenceInfos_codec = FieldCodec.ForMessage<OneInfluenceInfo>(74U, OneInfluenceInfo.Parser);

		// Token: 0x0400502C RID: 20524
		private readonly RepeatedField<OneInfluenceInfo> influenceInfos_ = new RepeatedField<OneInfluenceInfo>();
	}
}
