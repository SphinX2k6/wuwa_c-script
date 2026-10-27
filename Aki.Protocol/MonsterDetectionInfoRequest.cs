using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009F9 RID: 2553
	[NetMessage(EMessageId.MonsterDetectionInfoRequest)]
	public sealed class MonsterDetectionInfoRequest : IMessage<MonsterDetectionInfoRequest>, IMessage, IEquatable<MonsterDetectionInfoRequest>, IDeepCloneable<MonsterDetectionInfoRequest>, IBufferMessage
	{
		// Token: 0x0600DF8C RID: 57228 RVA: 0x0020C6B3 File Offset: 0x0020A8B3
		[NullableContext(1)]
		public static MonsterDetectionInfoRequest Create()
		{
			return new MonsterDetectionInfoRequest();
		}

		// Token: 0x17002D53 RID: 11603
		// (get) Token: 0x0600DF8D RID: 57229 RVA: 0x0020C6BA File Offset: 0x0020A8BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D54 RID: 11604
		// (get) Token: 0x0600DF8E RID: 57230 RVA: 0x0020C6BD File Offset: 0x0020A8BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterDetectionInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600DF8F RID: 57231 RVA: 0x0020C6C4 File Offset: 0x0020A8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterDetectionInfoRequest()
		{
		}

		// Token: 0x0600DF90 RID: 57232 RVA: 0x0020C6D7 File Offset: 0x0020A8D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterDetectionInfoRequest(MonsterDetectionInfoRequest other) : this()
		{
			this.params_ = other.params_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DF91 RID: 57233 RVA: 0x0020C701 File Offset: 0x0020A901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterDetectionInfoRequest Clone()
		{
			return new MonsterDetectionInfoRequest(this);
		}

		// Token: 0x17002D55 RID: 11605
		// (get) Token: 0x0600DF92 RID: 57234 RVA: 0x0020C709 File Offset: 0x0020A909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DetectionTarget> Params
		{
			get
			{
				return this.params_;
			}
		}

		// Token: 0x0600DF93 RID: 57235 RVA: 0x0020C711 File Offset: 0x0020A911
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterDetectionInfoRequest);
		}

		// Token: 0x0600DF94 RID: 57236 RVA: 0x0020C71F File Offset: 0x0020A91F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterDetectionInfoRequest other)
		{
			return other != null && (other == this || (this.params_.Equals(other.params_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DF95 RID: 57237 RVA: 0x0020C754 File Offset: 0x0020A954
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

		// Token: 0x0600DF96 RID: 57238 RVA: 0x0020C788 File Offset: 0x0020A988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DF97 RID: 57239 RVA: 0x0020C795 File Offset: 0x0020A995
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DF98 RID: 57240 RVA: 0x0020C79E File Offset: 0x0020A99E
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

		// Token: 0x0600DF99 RID: 57241 RVA: 0x0020C7C8 File Offset: 0x0020A9C8
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

		// Token: 0x0600DF9A RID: 57242 RVA: 0x0020C801 File Offset: 0x0020AA01
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

		// Token: 0x0600DF9B RID: 57243 RVA: 0x0020C82F File Offset: 0x0020AA2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DF9C RID: 57244 RVA: 0x0020C838 File Offset: 0x0020AA38
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

		// Token: 0x04005C2B RID: 23595
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C2C RID: 23596
		public const int ParamsFieldNumber = 1;

		// Token: 0x04005C2D RID: 23597
		private static readonly FieldCodec<DetectionTarget> _repeated_params_codec = FieldCodec.ForMessage<DetectionTarget>(10U, DetectionTarget.Parser);

		// Token: 0x04005C2E RID: 23598
		private readonly RepeatedField<DetectionTarget> params_ = new RepeatedField<DetectionTarget>();
	}
}
