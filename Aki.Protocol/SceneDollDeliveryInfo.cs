using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200114D RID: 4429
	public sealed class SceneDollDeliveryInfo : IMessage<SceneDollDeliveryInfo>, IMessage, IEquatable<SceneDollDeliveryInfo>, IDeepCloneable<SceneDollDeliveryInfo>, IBufferMessage
	{
		// Token: 0x060179C9 RID: 96713 RVA: 0x0036D8BD File Offset: 0x0036BABD
		[NullableContext(1)]
		public static SceneDollDeliveryInfo Create()
		{
			return new SceneDollDeliveryInfo();
		}

		// Token: 0x17004F3D RID: 20285
		// (get) Token: 0x060179CA RID: 96714 RVA: 0x0036D8C4 File Offset: 0x0036BAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneDollDeliveryInfo> Parser
		{
			get
			{
				return SceneDollDeliveryInfo._parser;
			}
		}

		// Token: 0x17004F3E RID: 20286
		// (get) Token: 0x060179CB RID: 96715 RVA: 0x0036D8CB File Offset: 0x0036BACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F3F RID: 20287
		// (get) Token: 0x060179CC RID: 96716 RVA: 0x0036D8CE File Offset: 0x0036BACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneDollDeliveryInfo.Descriptor;
			}
		}

		// Token: 0x060179CD RID: 96717 RVA: 0x0036D8D5 File Offset: 0x0036BAD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneDollDeliveryInfo()
		{
		}

		// Token: 0x060179CE RID: 96718 RVA: 0x0036D8E8 File Offset: 0x0036BAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneDollDeliveryInfo(SceneDollDeliveryInfo other) : this()
		{
			this.instId_ = other.instId_;
			this.dollDeliveryInfos_ = other.dollDeliveryInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060179CF RID: 96719 RVA: 0x0036D91E File Offset: 0x0036BB1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneDollDeliveryInfo Clone()
		{
			return new SceneDollDeliveryInfo(this);
		}

		// Token: 0x17004F40 RID: 20288
		// (get) Token: 0x060179D0 RID: 96720 RVA: 0x0036D926 File Offset: 0x0036BB26
		// (set) Token: 0x060179D1 RID: 96721 RVA: 0x0036D92E File Offset: 0x0036BB2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x17004F41 RID: 20289
		// (get) Token: 0x060179D2 RID: 96722 RVA: 0x0036D937 File Offset: 0x0036BB37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DollDeliveryInfo> DollDeliveryInfos
		{
			get
			{
				return this.dollDeliveryInfos_;
			}
		}

		// Token: 0x060179D3 RID: 96723 RVA: 0x0036D93F File Offset: 0x0036BB3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneDollDeliveryInfo);
		}

		// Token: 0x060179D4 RID: 96724 RVA: 0x0036D950 File Offset: 0x0036BB50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneDollDeliveryInfo other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.dollDeliveryInfos_.Equals(other.dollDeliveryInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060179D5 RID: 96725 RVA: 0x0036D9A0 File Offset: 0x0036BBA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			num ^= this.dollDeliveryInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060179D6 RID: 96726 RVA: 0x0036D9ED File Offset: 0x0036BBED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060179D7 RID: 96727 RVA: 0x0036D9FA File Offset: 0x0036BBFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060179D8 RID: 96728 RVA: 0x0036DA04 File Offset: 0x0036BC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InstId);
			}
			this.dollDeliveryInfos_.WriteTo(ref output, SceneDollDeliveryInfo._repeated_dollDeliveryInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060179D9 RID: 96729 RVA: 0x0036DA54 File Offset: 0x0036BC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			num += this.dollDeliveryInfos_.CalculateSize(SceneDollDeliveryInfo._repeated_dollDeliveryInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060179DA RID: 96730 RVA: 0x0036DAA8 File Offset: 0x0036BCA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneDollDeliveryInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this.dollDeliveryInfos_.Add(other.dollDeliveryInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060179DB RID: 96731 RVA: 0x0036DAF5 File Offset: 0x0036BCF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060179DC RID: 96732 RVA: 0x0036DB00 File Offset: 0x0036BD00
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.dollDeliveryInfos_.AddEntriesFrom(ref input, SceneDollDeliveryInfo._repeated_dollDeliveryInfos_codec);
					}
				}
				else
				{
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008C2C RID: 35884
		private static readonly MessageParser<SceneDollDeliveryInfo> _parser = new MessageParser<SceneDollDeliveryInfo>(() => new SceneDollDeliveryInfo());

		// Token: 0x04008C2D RID: 35885
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008C2E RID: 35886
		public const int InstIdFieldNumber = 1;

		// Token: 0x04008C2F RID: 35887
		private int instId_;

		// Token: 0x04008C30 RID: 35888
		public const int DollDeliveryInfosFieldNumber = 2;

		// Token: 0x04008C31 RID: 35889
		private static readonly FieldCodec<DollDeliveryInfo> _repeated_dollDeliveryInfos_codec = FieldCodec.ForMessage<DollDeliveryInfo>(18U, DollDeliveryInfo.Parser);

		// Token: 0x04008C32 RID: 35890
		private readonly RepeatedField<DollDeliveryInfo> dollDeliveryInfos_ = new RepeatedField<DollDeliveryInfo>();
	}
}
