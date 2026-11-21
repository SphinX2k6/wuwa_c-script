using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007BC RID: 1980
	[NetMessage(EMessageId.InfluenceInfoResponse)]
	public sealed class InfluenceInfoResponse : IMessage<InfluenceInfoResponse>, IMessage, IEquatable<InfluenceInfoResponse>, IDeepCloneable<InfluenceInfoResponse>, IBufferMessage
	{
		// Token: 0x0600B276 RID: 45686 RVA: 0x001AB922 File Offset: 0x001A9B22
		[NullableContext(1)]
		public static InfluenceInfoResponse Create()
		{
			return new InfluenceInfoResponse();
		}

		// Token: 0x170023FE RID: 9214
		// (get) Token: 0x0600B277 RID: 45687 RVA: 0x001AB929 File Offset: 0x001A9B29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023FF RID: 9215
		// (get) Token: 0x0600B278 RID: 45688 RVA: 0x001AB92C File Offset: 0x001A9B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfluenceInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600B279 RID: 45689 RVA: 0x001AB933 File Offset: 0x001A9B33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfluenceInfoResponse()
		{
		}

		// Token: 0x0600B27A RID: 45690 RVA: 0x001AB946 File Offset: 0x001A9B46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfluenceInfoResponse(InfluenceInfoResponse other) : this()
		{
			this.influenceInfos_ = other.influenceInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B27B RID: 45691 RVA: 0x001AB970 File Offset: 0x001A9B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfluenceInfoResponse Clone()
		{
			return new InfluenceInfoResponse(this);
		}

		// Token: 0x17002400 RID: 9216
		// (get) Token: 0x0600B27C RID: 45692 RVA: 0x001AB978 File Offset: 0x001A9B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneInfluenceInfo> InfluenceInfos
		{
			get
			{
				return this.influenceInfos_;
			}
		}

		// Token: 0x0600B27D RID: 45693 RVA: 0x001AB980 File Offset: 0x001A9B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfluenceInfoResponse);
		}

		// Token: 0x0600B27E RID: 45694 RVA: 0x001AB98E File Offset: 0x001A9B8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfluenceInfoResponse other)
		{
			return other != null && (other == this || (this.influenceInfos_.Equals(other.influenceInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B27F RID: 45695 RVA: 0x001AB9C4 File Offset: 0x001A9BC4
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

		// Token: 0x0600B280 RID: 45696 RVA: 0x001AB9F8 File Offset: 0x001A9BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B281 RID: 45697 RVA: 0x001ABA05 File Offset: 0x001A9C05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B282 RID: 45698 RVA: 0x001ABA0E File Offset: 0x001A9C0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.influenceInfos_.WriteTo(ref output, InfluenceInfoResponse._repeated_influenceInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B283 RID: 45699 RVA: 0x001ABA38 File Offset: 0x001A9C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.influenceInfos_.CalculateSize(InfluenceInfoResponse._repeated_influenceInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B284 RID: 45700 RVA: 0x001ABA71 File Offset: 0x001A9C71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfluenceInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.influenceInfos_.Add(other.influenceInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B285 RID: 45701 RVA: 0x001ABA9F File Offset: 0x001A9C9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B286 RID: 45702 RVA: 0x001ABAA8 File Offset: 0x001A9CA8
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.influenceInfos_.AddEntriesFrom(ref input, InfluenceInfoResponse._repeated_influenceInfos_codec);
				}
			}
		}

		// Token: 0x0400501E RID: 20510
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400501F RID: 20511
		public const int InfluenceInfosFieldNumber = 3;

		// Token: 0x04005020 RID: 20512
		private static readonly FieldCodec<OneInfluenceInfo> _repeated_influenceInfos_codec = FieldCodec.ForMessage<OneInfluenceInfo>(26U, OneInfluenceInfo.Parser);

		// Token: 0x04005021 RID: 20513
		private readonly RepeatedField<OneInfluenceInfo> influenceInfos_ = new RepeatedField<OneInfluenceInfo>();
	}
}
