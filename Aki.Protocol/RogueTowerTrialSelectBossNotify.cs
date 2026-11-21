using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001012 RID: 4114
	[NetMessage(EMessageId.RogueTowerTrialSelectBossNotify)]
	public sealed class RogueTowerTrialSelectBossNotify : IMessage<RogueTowerTrialSelectBossNotify>, IMessage, IEquatable<RogueTowerTrialSelectBossNotify>, IDeepCloneable<RogueTowerTrialSelectBossNotify>, IBufferMessage
	{
		// Token: 0x0601605B RID: 90203 RVA: 0x00334022 File Offset: 0x00332222
		[NullableContext(1)]
		public static RogueTowerTrialSelectBossNotify Create()
		{
			return new RogueTowerTrialSelectBossNotify();
		}

		// Token: 0x170049A3 RID: 18851
		// (get) Token: 0x0601605C RID: 90204 RVA: 0x00334029 File Offset: 0x00332229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049A4 RID: 18852
		// (get) Token: 0x0601605D RID: 90205 RVA: 0x0033402C File Offset: 0x0033222C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTowerTrialSelectBossNotify.Descriptor;
			}
		}

		// Token: 0x0601605E RID: 90206 RVA: 0x00334033 File Offset: 0x00332233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialSelectBossNotify()
		{
		}

		// Token: 0x0601605F RID: 90207 RVA: 0x00334046 File Offset: 0x00332246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialSelectBossNotify(RogueTowerTrialSelectBossNotify other) : this()
		{
			this.bossInfos_ = other.bossInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016060 RID: 90208 RVA: 0x00334070 File Offset: 0x00332270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialSelectBossNotify Clone()
		{
			return new RogueTowerTrialSelectBossNotify(this);
		}

		// Token: 0x170049A5 RID: 18853
		// (get) Token: 0x06016061 RID: 90209 RVA: 0x00334078 File Offset: 0x00332278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueTowerTrialBossInfo> BossInfos
		{
			get
			{
				return this.bossInfos_;
			}
		}

		// Token: 0x06016062 RID: 90210 RVA: 0x00334080 File Offset: 0x00332280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTowerTrialSelectBossNotify);
		}

		// Token: 0x06016063 RID: 90211 RVA: 0x0033408E File Offset: 0x0033228E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTowerTrialSelectBossNotify other)
		{
			return other != null && (other == this || (this.bossInfos_.Equals(other.bossInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016064 RID: 90212 RVA: 0x003340C4 File Offset: 0x003322C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.bossInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016065 RID: 90213 RVA: 0x003340F8 File Offset: 0x003322F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016066 RID: 90214 RVA: 0x00334105 File Offset: 0x00332305
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016067 RID: 90215 RVA: 0x0033410E File Offset: 0x0033230E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.bossInfos_.WriteTo(ref output, RogueTowerTrialSelectBossNotify._repeated_bossInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016068 RID: 90216 RVA: 0x00334138 File Offset: 0x00332338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.bossInfos_.CalculateSize(RogueTowerTrialSelectBossNotify._repeated_bossInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016069 RID: 90217 RVA: 0x00334171 File Offset: 0x00332371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTowerTrialSelectBossNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.bossInfos_.Add(other.bossInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601606A RID: 90218 RVA: 0x0033419F File Offset: 0x0033239F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601606B RID: 90219 RVA: 0x003341A8 File Offset: 0x003323A8
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.bossInfos_.AddEntriesFrom(ref input, RogueTowerTrialSelectBossNotify._repeated_bossInfos_codec);
				}
			}
		}

		// Token: 0x0400847A RID: 33914
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400847B RID: 33915
		public const int BossInfosFieldNumber = 12;

		// Token: 0x0400847C RID: 33916
		private static readonly FieldCodec<RogueTowerTrialBossInfo> _repeated_bossInfos_codec = FieldCodec.ForMessage<RogueTowerTrialBossInfo>(98U, RogueTowerTrialBossInfo.Parser);

		// Token: 0x0400847D RID: 33917
		private readonly RepeatedField<RogueTowerTrialBossInfo> bossInfos_ = new RepeatedField<RogueTowerTrialBossInfo>();
	}
}
