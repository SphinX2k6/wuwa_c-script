using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007D0 RID: 2000
	[NetMessage(EMessageId.InfluenceInfoResponse)]
	public sealed class InfluenceInfoResponse : IMessage<InfluenceInfoResponse>, IMessage, IEquatable<InfluenceInfoResponse>, IDeepCloneable<InfluenceInfoResponse>, IBufferMessage
	{
		// Token: 0x0600B3CC RID: 46028 RVA: 0x001AE356 File Offset: 0x001AC556
		[NullableContext(1)]
		public static InfluenceInfoResponse Create()
		{
			return new InfluenceInfoResponse();
		}

		// Token: 0x17002448 RID: 9288
		// (get) Token: 0x0600B3CD RID: 46029 RVA: 0x001AE35D File Offset: 0x001AC55D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002449 RID: 9289
		// (get) Token: 0x0600B3CE RID: 46030 RVA: 0x001AE360 File Offset: 0x001AC560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfluenceInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600B3CF RID: 46031 RVA: 0x001AE367 File Offset: 0x001AC567
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfluenceInfoResponse()
		{
		}

		// Token: 0x0600B3D0 RID: 46032 RVA: 0x001AE37A File Offset: 0x001AC57A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfluenceInfoResponse(InfluenceInfoResponse other) : this()
		{
			this.influenceInfos_ = other.influenceInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B3D1 RID: 46033 RVA: 0x001AE3A4 File Offset: 0x001AC5A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfluenceInfoResponse Clone()
		{
			return new InfluenceInfoResponse(this);
		}

		// Token: 0x1700244A RID: 9290
		// (get) Token: 0x0600B3D2 RID: 46034 RVA: 0x001AE3AC File Offset: 0x001AC5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneInfluenceInfo> InfluenceInfos
		{
			get
			{
				return this.influenceInfos_;
			}
		}

		// Token: 0x0600B3D3 RID: 46035 RVA: 0x001AE3B4 File Offset: 0x001AC5B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfluenceInfoResponse);
		}

		// Token: 0x0600B3D4 RID: 46036 RVA: 0x001AE3C2 File Offset: 0x001AC5C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfluenceInfoResponse other)
		{
			return other != null && (other == this || (this.influenceInfos_.Equals(other.influenceInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B3D5 RID: 46037 RVA: 0x001AE3F8 File Offset: 0x001AC5F8
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

		// Token: 0x0600B3D6 RID: 46038 RVA: 0x001AE42C File Offset: 0x001AC62C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B3D7 RID: 46039 RVA: 0x001AE439 File Offset: 0x001AC639
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B3D8 RID: 46040 RVA: 0x001AE442 File Offset: 0x001AC642
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

		// Token: 0x0600B3D9 RID: 46041 RVA: 0x001AE46C File Offset: 0x001AC66C
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

		// Token: 0x0600B3DA RID: 46042 RVA: 0x001AE4A5 File Offset: 0x001AC6A5
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

		// Token: 0x0600B3DB RID: 46043 RVA: 0x001AE4D3 File Offset: 0x001AC6D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B3DC RID: 46044 RVA: 0x001AE4DC File Offset: 0x001AC6DC
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.influenceInfos_.AddEntriesFrom(ref input, InfluenceInfoResponse._repeated_influenceInfos_codec);
				}
			}
		}

		// Token: 0x04005025 RID: 20517
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005026 RID: 20518
		public const int InfluenceInfosFieldNumber = 4;

		// Token: 0x04005027 RID: 20519
		private static readonly FieldCodec<OneInfluenceInfo> _repeated_influenceInfos_codec = FieldCodec.ForMessage<OneInfluenceInfo>(34U, OneInfluenceInfo.Parser);

		// Token: 0x04005028 RID: 20520
		private readonly RepeatedField<OneInfluenceInfo> influenceInfos_ = new RepeatedField<OneInfluenceInfo>();
	}
}
