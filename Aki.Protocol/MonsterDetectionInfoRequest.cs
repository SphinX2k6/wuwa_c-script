using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009E8 RID: 2536
	[NetMessage(EMessageId.MonsterDetectionInfoRequest)]
	public sealed class MonsterDetectionInfoRequest : IMessage<MonsterDetectionInfoRequest>, IMessage, IEquatable<MonsterDetectionInfoRequest>, IDeepCloneable<MonsterDetectionInfoRequest>, IBufferMessage
	{
		// Token: 0x0600DE72 RID: 56946 RVA: 0x0020A4C7 File Offset: 0x002086C7
		[NullableContext(1)]
		public static MonsterDetectionInfoRequest Create()
		{
			return new MonsterDetectionInfoRequest();
		}

		// Token: 0x17002D15 RID: 11541
		// (get) Token: 0x0600DE73 RID: 56947 RVA: 0x0020A4CE File Offset: 0x002086CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D16 RID: 11542
		// (get) Token: 0x0600DE74 RID: 56948 RVA: 0x0020A4D1 File Offset: 0x002086D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterDetectionInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600DE75 RID: 56949 RVA: 0x0020A4D8 File Offset: 0x002086D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterDetectionInfoRequest()
		{
		}

		// Token: 0x0600DE76 RID: 56950 RVA: 0x0020A4EB File Offset: 0x002086EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterDetectionInfoRequest(MonsterDetectionInfoRequest other) : this()
		{
			this.params_ = other.params_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DE77 RID: 56951 RVA: 0x0020A515 File Offset: 0x00208715
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterDetectionInfoRequest Clone()
		{
			return new MonsterDetectionInfoRequest(this);
		}

		// Token: 0x17002D17 RID: 11543
		// (get) Token: 0x0600DE78 RID: 56952 RVA: 0x0020A51D File Offset: 0x0020871D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DetectionTarget> Params
		{
			get
			{
				return this.params_;
			}
		}

		// Token: 0x0600DE79 RID: 56953 RVA: 0x0020A525 File Offset: 0x00208725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterDetectionInfoRequest);
		}

		// Token: 0x0600DE7A RID: 56954 RVA: 0x0020A533 File Offset: 0x00208733
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterDetectionInfoRequest other)
		{
			return other != null && (other == this || (this.params_.Equals(other.params_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DE7B RID: 56955 RVA: 0x0020A568 File Offset: 0x00208768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.params_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DE7C RID: 56956 RVA: 0x0020A59C File Offset: 0x0020879C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DE7D RID: 56957 RVA: 0x0020A5A9 File Offset: 0x002087A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DE7E RID: 56958 RVA: 0x0020A5B2 File Offset: 0x002087B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.params_.WriteTo(ref output, MonsterDetectionInfoRequest._repeated_params_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DE7F RID: 56959 RVA: 0x0020A5DC File Offset: 0x002087DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.params_.CalculateSize(MonsterDetectionInfoRequest._repeated_params_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DE80 RID: 56960 RVA: 0x0020A615 File Offset: 0x00208815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonsterDetectionInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.params_.Add(other.params_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DE81 RID: 56961 RVA: 0x0020A643 File Offset: 0x00208843
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DE82 RID: 56962 RVA: 0x0020A64C File Offset: 0x0020884C
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
					this.params_.AddEntriesFrom(ref input, MonsterDetectionInfoRequest._repeated_params_codec);
				}
			}
		}

		// Token: 0x04005C34 RID: 23604
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C35 RID: 23605
		public const int ParamsFieldNumber = 1;

		// Token: 0x04005C36 RID: 23606
		private static readonly FieldCodec<DetectionTarget> _repeated_params_codec = FieldCodec.ForMessage<DetectionTarget>(10U, DetectionTarget.Parser);

		// Token: 0x04005C37 RID: 23607
		private readonly RepeatedField<DetectionTarget> params_ = new RepeatedField<DetectionTarget>();
	}
}
