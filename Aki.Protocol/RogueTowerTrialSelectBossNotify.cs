using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001022 RID: 4130
	[NetMessage(EMessageId.RogueTowerTrialSelectBossNotify)]
	public sealed class RogueTowerTrialSelectBossNotify : IMessage<RogueTowerTrialSelectBossNotify>, IMessage, IEquatable<RogueTowerTrialSelectBossNotify>, IDeepCloneable<RogueTowerTrialSelectBossNotify>, IBufferMessage
	{
		// Token: 0x06016140 RID: 90432 RVA: 0x003356E3 File Offset: 0x003338E3
		[NullableContext(1)]
		public static RogueTowerTrialSelectBossNotify Create()
		{
			return new RogueTowerTrialSelectBossNotify();
		}

		// Token: 0x170049CD RID: 18893
		// (get) Token: 0x06016141 RID: 90433 RVA: 0x003356EA File Offset: 0x003338EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049CE RID: 18894
		// (get) Token: 0x06016142 RID: 90434 RVA: 0x003356ED File Offset: 0x003338ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTowerTrialSelectBossNotify.Descriptor;
			}
		}

		// Token: 0x06016143 RID: 90435 RVA: 0x003356F4 File Offset: 0x003338F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialSelectBossNotify()
		{
		}

		// Token: 0x06016144 RID: 90436 RVA: 0x00335707 File Offset: 0x00333907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialSelectBossNotify(RogueTowerTrialSelectBossNotify other) : this()
		{
			this.bossInfos_ = other.bossInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016145 RID: 90437 RVA: 0x00335731 File Offset: 0x00333931
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialSelectBossNotify Clone()
		{
			return new RogueTowerTrialSelectBossNotify(this);
		}

		// Token: 0x170049CF RID: 18895
		// (get) Token: 0x06016146 RID: 90438 RVA: 0x00335739 File Offset: 0x00333939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueTowerTrialBossInfo> BossInfos
		{
			get
			{
				return this.bossInfos_;
			}
		}

		// Token: 0x06016147 RID: 90439 RVA: 0x00335741 File Offset: 0x00333941
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTowerTrialSelectBossNotify);
		}

		// Token: 0x06016148 RID: 90440 RVA: 0x0033574F File Offset: 0x0033394F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTowerTrialSelectBossNotify other)
		{
			return other != null && (other == this || (this.bossInfos_.Equals(other.bossInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016149 RID: 90441 RVA: 0x00335784 File Offset: 0x00333984
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

		// Token: 0x0601614A RID: 90442 RVA: 0x003357B8 File Offset: 0x003339B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601614B RID: 90443 RVA: 0x003357C5 File Offset: 0x003339C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601614C RID: 90444 RVA: 0x003357CE File Offset: 0x003339CE
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

		// Token: 0x0601614D RID: 90445 RVA: 0x003357F8 File Offset: 0x003339F8
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

		// Token: 0x0601614E RID: 90446 RVA: 0x00335831 File Offset: 0x00333A31
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

		// Token: 0x0601614F RID: 90447 RVA: 0x0033585F File Offset: 0x00333A5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016150 RID: 90448 RVA: 0x00335868 File Offset: 0x00333A68
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.bossInfos_.AddEntriesFrom(ref input, RogueTowerTrialSelectBossNotify._repeated_bossInfos_codec);
				}
			}
		}

		// Token: 0x04008450 RID: 33872
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008451 RID: 33873
		public const int BossInfosFieldNumber = 10;

		// Token: 0x04008452 RID: 33874
		private static readonly FieldCodec<RogueTowerTrialBossInfo> _repeated_bossInfos_codec = FieldCodec.ForMessage<RogueTowerTrialBossInfo>(82U, RogueTowerTrialBossInfo.Parser);

		// Token: 0x04008453 RID: 33875
		private readonly RepeatedField<RogueTowerTrialBossInfo> bossInfos_ = new RepeatedField<RogueTowerTrialBossInfo>();
	}
}
