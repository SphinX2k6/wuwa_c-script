using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F62 RID: 3938
	[NetMessage(EMessageId.RiskHarvestInstUpdateNotify)]
	public sealed class RiskHarvestInstUpdateNotify : IMessage<RiskHarvestInstUpdateNotify>, IMessage, IEquatable<RiskHarvestInstUpdateNotify>, IDeepCloneable<RiskHarvestInstUpdateNotify>, IBufferMessage
	{
		// Token: 0x060150FC RID: 86268 RVA: 0x0030E0ED File Offset: 0x0030C2ED
		[NullableContext(1)]
		public static RiskHarvestInstUpdateNotify Create()
		{
			return new RiskHarvestInstUpdateNotify();
		}

		// Token: 0x17004611 RID: 17937
		// (get) Token: 0x060150FD RID: 86269 RVA: 0x0030E0F4 File Offset: 0x0030C2F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004612 RID: 17938
		// (get) Token: 0x060150FE RID: 86270 RVA: 0x0030E0F7 File Offset: 0x0030C2F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestInstUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060150FF RID: 86271 RVA: 0x0030E0FE File Offset: 0x0030C2FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstUpdateNotify()
		{
		}

		// Token: 0x06015100 RID: 86272 RVA: 0x0030E111 File Offset: 0x0030C311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstUpdateNotify(RiskHarvestInstUpdateNotify other) : this()
		{
			this.instInfos_ = other.instInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015101 RID: 86273 RVA: 0x0030E13B File Offset: 0x0030C33B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstUpdateNotify Clone()
		{
			return new RiskHarvestInstUpdateNotify(this);
		}

		// Token: 0x17004613 RID: 17939
		// (get) Token: 0x06015102 RID: 86274 RVA: 0x0030E143 File Offset: 0x0030C343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RiskHarvestInstInfo> InstInfos
		{
			get
			{
				return this.instInfos_;
			}
		}

		// Token: 0x06015103 RID: 86275 RVA: 0x0030E14B File Offset: 0x0030C34B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestInstUpdateNotify);
		}

		// Token: 0x06015104 RID: 86276 RVA: 0x0030E159 File Offset: 0x0030C359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestInstUpdateNotify other)
		{
			return other != null && (other == this || (this.instInfos_.Equals(other.instInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015105 RID: 86277 RVA: 0x0030E18C File Offset: 0x0030C38C
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

		// Token: 0x06015106 RID: 86278 RVA: 0x0030E1C0 File Offset: 0x0030C3C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015107 RID: 86279 RVA: 0x0030E1CD File Offset: 0x0030C3CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015108 RID: 86280 RVA: 0x0030E1D6 File Offset: 0x0030C3D6
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

		// Token: 0x06015109 RID: 86281 RVA: 0x0030E200 File Offset: 0x0030C400
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

		// Token: 0x0601510A RID: 86282 RVA: 0x0030E239 File Offset: 0x0030C439
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

		// Token: 0x0601510B RID: 86283 RVA: 0x0030E267 File Offset: 0x0030C467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601510C RID: 86284 RVA: 0x0030E270 File Offset: 0x0030C470
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

		// Token: 0x04007EDE RID: 32478
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007EDF RID: 32479
		public const int InstInfosFieldNumber = 4;

		// Token: 0x04007EE0 RID: 32480
		private static readonly FieldCodec<RiskHarvestInstInfo> _repeated_instInfos_codec = FieldCodec.ForMessage<RiskHarvestInstInfo>(34U, RiskHarvestInstInfo.Parser);

		// Token: 0x04007EE1 RID: 32481
		private readonly RepeatedField<RiskHarvestInstInfo> instInfos_ = new RepeatedField<RiskHarvestInstInfo>();
	}
}
