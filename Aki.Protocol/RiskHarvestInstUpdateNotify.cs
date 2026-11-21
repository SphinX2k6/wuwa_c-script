using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F52 RID: 3922
	[NetMessage(EMessageId.RiskHarvestInstUpdateNotify)]
	public sealed class RiskHarvestInstUpdateNotify : IMessage<RiskHarvestInstUpdateNotify>, IMessage, IEquatable<RiskHarvestInstUpdateNotify>, IDeepCloneable<RiskHarvestInstUpdateNotify>, IBufferMessage
	{
		// Token: 0x06015017 RID: 86039 RVA: 0x0030CA3D File Offset: 0x0030AC3D
		[NullableContext(1)]
		public static RiskHarvestInstUpdateNotify Create()
		{
			return new RiskHarvestInstUpdateNotify();
		}

		// Token: 0x170045E7 RID: 17895
		// (get) Token: 0x06015018 RID: 86040 RVA: 0x0030CA44 File Offset: 0x0030AC44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045E8 RID: 17896
		// (get) Token: 0x06015019 RID: 86041 RVA: 0x0030CA47 File Offset: 0x0030AC47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestInstUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601501A RID: 86042 RVA: 0x0030CA4E File Offset: 0x0030AC4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstUpdateNotify()
		{
		}

		// Token: 0x0601501B RID: 86043 RVA: 0x0030CA61 File Offset: 0x0030AC61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstUpdateNotify(RiskHarvestInstUpdateNotify other) : this()
		{
			this.instInfos_ = other.instInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601501C RID: 86044 RVA: 0x0030CA8B File Offset: 0x0030AC8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstUpdateNotify Clone()
		{
			return new RiskHarvestInstUpdateNotify(this);
		}

		// Token: 0x170045E9 RID: 17897
		// (get) Token: 0x0601501D RID: 86045 RVA: 0x0030CA93 File Offset: 0x0030AC93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RiskHarvestInstInfo> InstInfos
		{
			get
			{
				return this.instInfos_;
			}
		}

		// Token: 0x0601501E RID: 86046 RVA: 0x0030CA9B File Offset: 0x0030AC9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestInstUpdateNotify);
		}

		// Token: 0x0601501F RID: 86047 RVA: 0x0030CAA9 File Offset: 0x0030ACA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestInstUpdateNotify other)
		{
			return other != null && (other == this || (this.instInfos_.Equals(other.instInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015020 RID: 86048 RVA: 0x0030CADC File Offset: 0x0030ACDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.instInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015021 RID: 86049 RVA: 0x0030CB10 File Offset: 0x0030AD10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015022 RID: 86050 RVA: 0x0030CB1D File Offset: 0x0030AD1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015023 RID: 86051 RVA: 0x0030CB26 File Offset: 0x0030AD26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.instInfos_.WriteTo(ref output, RiskHarvestInstUpdateNotify._repeated_instInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015024 RID: 86052 RVA: 0x0030CB50 File Offset: 0x0030AD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.instInfos_.CalculateSize(RiskHarvestInstUpdateNotify._repeated_instInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015025 RID: 86053 RVA: 0x0030CB89 File Offset: 0x0030AD89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RiskHarvestInstUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.instInfos_.Add(other.instInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015026 RID: 86054 RVA: 0x0030CBB7 File Offset: 0x0030ADB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015027 RID: 86055 RVA: 0x0030CBC0 File Offset: 0x0030ADC0
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
					this.instInfos_.AddEntriesFrom(ref input, RiskHarvestInstUpdateNotify._repeated_instInfos_codec);
				}
			}
		}

		// Token: 0x04007F08 RID: 32520
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F09 RID: 32521
		public const int InstInfosFieldNumber = 4;

		// Token: 0x04007F0A RID: 32522
		private static readonly FieldCodec<RiskHarvestInstInfo> _repeated_instInfos_codec = FieldCodec.ForMessage<RiskHarvestInstInfo>(34U, RiskHarvestInstInfo.Parser);

		// Token: 0x04007F0B RID: 32523
		private readonly RepeatedField<RiskHarvestInstInfo> instInfos_ = new RepeatedField<RiskHarvestInstInfo>();
	}
}
