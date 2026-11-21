using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011CF RID: 4559
	public sealed class SceneUnlimitedScoreInfo : IMessage<SceneUnlimitedScoreInfo>, IMessage, IEquatable<SceneUnlimitedScoreInfo>, IDeepCloneable<SceneUnlimitedScoreInfo>, IBufferMessage
	{
		// Token: 0x06018571 RID: 99697 RVA: 0x0038B16E File Offset: 0x0038936E
		[NullableContext(1)]
		public static SceneUnlimitedScoreInfo Create()
		{
			return new SceneUnlimitedScoreInfo();
		}

		// Token: 0x17005209 RID: 21001
		// (get) Token: 0x06018572 RID: 99698 RVA: 0x0038B175 File Offset: 0x00389375
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneUnlimitedScoreInfo> Parser
		{
			get
			{
				return SceneUnlimitedScoreInfo._parser;
			}
		}

		// Token: 0x1700520A RID: 21002
		// (get) Token: 0x06018573 RID: 99699 RVA: 0x0038B17C File Offset: 0x0038937C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700520B RID: 21003
		// (get) Token: 0x06018574 RID: 99700 RVA: 0x0038B17F File Offset: 0x0038937F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneUnlimitedScoreInfo.Descriptor;
			}
		}

		// Token: 0x06018575 RID: 99701 RVA: 0x0038B186 File Offset: 0x00389386
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneUnlimitedScoreInfo()
		{
		}

		// Token: 0x06018576 RID: 99702 RVA: 0x0038B199 File Offset: 0x00389399
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneUnlimitedScoreInfo(SceneUnlimitedScoreInfo other) : this()
		{
			this.instId_ = other.instId_;
			this.unlimitedScoreInfos_ = other.unlimitedScoreInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018577 RID: 99703 RVA: 0x0038B1CF File Offset: 0x003893CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneUnlimitedScoreInfo Clone()
		{
			return new SceneUnlimitedScoreInfo(this);
		}

		// Token: 0x1700520C RID: 21004
		// (get) Token: 0x06018578 RID: 99704 RVA: 0x0038B1D7 File Offset: 0x003893D7
		// (set) Token: 0x06018579 RID: 99705 RVA: 0x0038B1DF File Offset: 0x003893DF
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

		// Token: 0x1700520D RID: 21005
		// (get) Token: 0x0601857A RID: 99706 RVA: 0x0038B1E8 File Offset: 0x003893E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<UnlimitedScoreInfo> UnlimitedScoreInfos
		{
			get
			{
				return this.unlimitedScoreInfos_;
			}
		}

		// Token: 0x0601857B RID: 99707 RVA: 0x0038B1F0 File Offset: 0x003893F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneUnlimitedScoreInfo);
		}

		// Token: 0x0601857C RID: 99708 RVA: 0x0038B200 File Offset: 0x00389400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneUnlimitedScoreInfo other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.unlimitedScoreInfos_.Equals(other.unlimitedScoreInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601857D RID: 99709 RVA: 0x0038B250 File Offset: 0x00389450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			num ^= this.unlimitedScoreInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601857E RID: 99710 RVA: 0x0038B29D File Offset: 0x0038949D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601857F RID: 99711 RVA: 0x0038B2AA File Offset: 0x003894AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018580 RID: 99712 RVA: 0x0038B2B4 File Offset: 0x003894B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InstId);
			}
			this.unlimitedScoreInfos_.WriteTo(ref output, SceneUnlimitedScoreInfo._repeated_unlimitedScoreInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018581 RID: 99713 RVA: 0x0038B304 File Offset: 0x00389504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			num += this.unlimitedScoreInfos_.CalculateSize(SceneUnlimitedScoreInfo._repeated_unlimitedScoreInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018582 RID: 99714 RVA: 0x0038B358 File Offset: 0x00389558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneUnlimitedScoreInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this.unlimitedScoreInfos_.Add(other.unlimitedScoreInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018583 RID: 99715 RVA: 0x0038B3A5 File Offset: 0x003895A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018584 RID: 99716 RVA: 0x0038B3B0 File Offset: 0x003895B0
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
						this.unlimitedScoreInfos_.AddEntriesFrom(ref input, SceneUnlimitedScoreInfo._repeated_unlimitedScoreInfos_codec);
					}
				}
				else
				{
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040090AA RID: 37034
		private static readonly MessageParser<SceneUnlimitedScoreInfo> _parser = new MessageParser<SceneUnlimitedScoreInfo>(() => new SceneUnlimitedScoreInfo());

		// Token: 0x040090AB RID: 37035
		private UnknownFieldSet _unknownFields;

		// Token: 0x040090AC RID: 37036
		public const int InstIdFieldNumber = 1;

		// Token: 0x040090AD RID: 37037
		private int instId_;

		// Token: 0x040090AE RID: 37038
		public const int UnlimitedScoreInfosFieldNumber = 2;

		// Token: 0x040090AF RID: 37039
		private static readonly FieldCodec<UnlimitedScoreInfo> _repeated_unlimitedScoreInfos_codec = FieldCodec.ForMessage<UnlimitedScoreInfo>(18U, UnlimitedScoreInfo.Parser);

		// Token: 0x040090B0 RID: 37040
		private readonly RepeatedField<UnlimitedScoreInfo> unlimitedScoreInfos_ = new RepeatedField<UnlimitedScoreInfo>();
	}
}
