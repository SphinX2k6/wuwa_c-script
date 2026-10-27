using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000891 RID: 2193
	public sealed class KurotatoEndlessLevelInfo : IMessage<KurotatoEndlessLevelInfo>, IMessage, IEquatable<KurotatoEndlessLevelInfo>, IDeepCloneable<KurotatoEndlessLevelInfo>, IBufferMessage
	{
		// Token: 0x0600C2FF RID: 49919 RVA: 0x001CEC7E File Offset: 0x001CCE7E
		[NullableContext(1)]
		public static KurotatoEndlessLevelInfo Create()
		{
			return new KurotatoEndlessLevelInfo();
		}

		// Token: 0x1700276A RID: 10090
		// (get) Token: 0x0600C300 RID: 49920 RVA: 0x001CEC85 File Offset: 0x001CCE85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700276B RID: 10091
		// (get) Token: 0x0600C301 RID: 49921 RVA: 0x001CEC88 File Offset: 0x001CCE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoEndlessLevelInfo.Descriptor;
			}
		}

		// Token: 0x0600C302 RID: 49922 RVA: 0x001CEC8F File Offset: 0x001CCE8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndlessLevelInfo()
		{
		}

		// Token: 0x0600C303 RID: 49923 RVA: 0x001CECA4 File Offset: 0x001CCEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndlessLevelInfo(KurotatoEndlessLevelInfo other) : this()
		{
			this.finishWave_ = other.finishWave_;
			this.totalKillCount_ = other.totalKillCount_;
			this.passRoleIds_ = other.passRoleIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C304 RID: 49924 RVA: 0x001CECF1 File Offset: 0x001CCEF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndlessLevelInfo Clone()
		{
			return new KurotatoEndlessLevelInfo(this);
		}

		// Token: 0x1700276C RID: 10092
		// (get) Token: 0x0600C305 RID: 49925 RVA: 0x001CECF9 File Offset: 0x001CCEF9
		// (set) Token: 0x0600C306 RID: 49926 RVA: 0x001CED01 File Offset: 0x001CCF01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FinishWave
		{
			get
			{
				return this.finishWave_;
			}
			set
			{
				this.finishWave_ = value;
			}
		}

		// Token: 0x1700276D RID: 10093
		// (get) Token: 0x0600C307 RID: 49927 RVA: 0x001CED0A File Offset: 0x001CCF0A
		// (set) Token: 0x0600C308 RID: 49928 RVA: 0x001CED12 File Offset: 0x001CCF12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalKillCount
		{
			get
			{
				return this.totalKillCount_;
			}
			set
			{
				this.totalKillCount_ = value;
			}
		}

		// Token: 0x1700276E RID: 10094
		// (get) Token: 0x0600C309 RID: 49929 RVA: 0x001CED1B File Offset: 0x001CCF1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PassRoleIds
		{
			get
			{
				return this.passRoleIds_;
			}
		}

		// Token: 0x0600C30A RID: 49930 RVA: 0x001CED23 File Offset: 0x001CCF23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoEndlessLevelInfo);
		}

		// Token: 0x0600C30B RID: 49931 RVA: 0x001CED34 File Offset: 0x001CCF34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoEndlessLevelInfo other)
		{
			return other != null && (other == this || (this.FinishWave == other.FinishWave && this.TotalKillCount == other.TotalKillCount && this.passRoleIds_.Equals(other.passRoleIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C30C RID: 49932 RVA: 0x001CED94 File Offset: 0x001CCF94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FinishWave != 0)
			{
				num ^= this.FinishWave.GetHashCode();
			}
			if (this.TotalKillCount != 0)
			{
				num ^= this.TotalKillCount.GetHashCode();
			}
			num ^= this.passRoleIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C30D RID: 49933 RVA: 0x001CEDFA File Offset: 0x001CCFFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C30E RID: 49934 RVA: 0x001CEE07 File Offset: 0x001CD007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C30F RID: 49935 RVA: 0x001CEE10 File Offset: 0x001CD010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FinishWave != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FinishWave);
			}
			if (this.TotalKillCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TotalKillCount);
			}
			this.passRoleIds_.WriteTo(ref output, KurotatoEndlessLevelInfo._repeated_passRoleIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C310 RID: 49936 RVA: 0x001CEE7C File Offset: 0x001CD07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FinishWave != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FinishWave);
			}
			if (this.TotalKillCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalKillCount);
			}
			num += this.passRoleIds_.CalculateSize(KurotatoEndlessLevelInfo._repeated_passRoleIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C311 RID: 49937 RVA: 0x001CEEE8 File Offset: 0x001CD0E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoEndlessLevelInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FinishWave != 0)
			{
				this.FinishWave = other.FinishWave;
			}
			if (other.TotalKillCount != 0)
			{
				this.TotalKillCount = other.TotalKillCount;
			}
			this.passRoleIds_.Add(other.passRoleIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C312 RID: 49938 RVA: 0x001CEF49 File Offset: 0x001CD149
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C313 RID: 49939 RVA: 0x001CEF54 File Offset: 0x001CD154
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.FinishWave = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.TotalKillCount = input.ReadInt32();
						continue;
					}
				}
				else if (num == 24U || num == 26U)
				{
					this.passRoleIds_.AddEntriesFrom(ref input, KurotatoEndlessLevelInfo._repeated_passRoleIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005454 RID: 21588
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005455 RID: 21589
		public const int FinishWaveFieldNumber = 1;

		// Token: 0x04005456 RID: 21590
		private int finishWave_;

		// Token: 0x04005457 RID: 21591
		public const int TotalKillCountFieldNumber = 2;

		// Token: 0x04005458 RID: 21592
		private int totalKillCount_;

		// Token: 0x04005459 RID: 21593
		public const int PassRoleIdsFieldNumber = 3;

		// Token: 0x0400545A RID: 21594
		private static readonly FieldCodec<int> _repeated_passRoleIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0400545B RID: 21595
		private readonly RepeatedField<int> passRoleIds_ = new RepeatedField<int>();
	}
}
