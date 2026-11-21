using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001330 RID: 4912
	[NetMessage(EMessageId.SurvivorsChallengeInfoUpdateNotify)]
	public sealed class SurvivorsChallengeInfoUpdateNotify : IMessage<SurvivorsChallengeInfoUpdateNotify>, IMessage, IEquatable<SurvivorsChallengeInfoUpdateNotify>, IDeepCloneable<SurvivorsChallengeInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601A2F9 RID: 107257 RVA: 0x003D123C File Offset: 0x003CF43C
		[NullableContext(1)]
		public static SurvivorsChallengeInfoUpdateNotify Create()
		{
			return new SurvivorsChallengeInfoUpdateNotify();
		}

		// Token: 0x170058AE RID: 22702
		// (get) Token: 0x0601A2FA RID: 107258 RVA: 0x003D1243 File Offset: 0x003CF443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058AF RID: 22703
		// (get) Token: 0x0601A2FB RID: 107259 RVA: 0x003D1246 File Offset: 0x003CF446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsChallengeInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601A2FC RID: 107260 RVA: 0x003D124D File Offset: 0x003CF44D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsChallengeInfoUpdateNotify()
		{
		}

		// Token: 0x0601A2FD RID: 107261 RVA: 0x003D1260 File Offset: 0x003CF460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsChallengeInfoUpdateNotify(SurvivorsChallengeInfoUpdateNotify other) : this()
		{
			this.survivorsChallengeInfos_ = other.survivorsChallengeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A2FE RID: 107262 RVA: 0x003D128A File Offset: 0x003CF48A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsChallengeInfoUpdateNotify Clone()
		{
			return new SurvivorsChallengeInfoUpdateNotify(this);
		}

		// Token: 0x170058B0 RID: 22704
		// (get) Token: 0x0601A2FF RID: 107263 RVA: 0x003D1292 File Offset: 0x003CF492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SurvivorsChallengeInfo> SurvivorsChallengeInfos
		{
			get
			{
				return this.survivorsChallengeInfos_;
			}
		}

		// Token: 0x0601A300 RID: 107264 RVA: 0x003D129A File Offset: 0x003CF49A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsChallengeInfoUpdateNotify);
		}

		// Token: 0x0601A301 RID: 107265 RVA: 0x003D12A8 File Offset: 0x003CF4A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsChallengeInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.survivorsChallengeInfos_.Equals(other.survivorsChallengeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A302 RID: 107266 RVA: 0x003D12DC File Offset: 0x003CF4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.survivorsChallengeInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A303 RID: 107267 RVA: 0x003D1310 File Offset: 0x003CF510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A304 RID: 107268 RVA: 0x003D131D File Offset: 0x003CF51D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A305 RID: 107269 RVA: 0x003D1326 File Offset: 0x003CF526
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.survivorsChallengeInfos_.WriteTo(ref output, SurvivorsChallengeInfoUpdateNotify._repeated_survivorsChallengeInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A306 RID: 107270 RVA: 0x003D1350 File Offset: 0x003CF550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.survivorsChallengeInfos_.CalculateSize(SurvivorsChallengeInfoUpdateNotify._repeated_survivorsChallengeInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A307 RID: 107271 RVA: 0x003D1389 File Offset: 0x003CF589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsChallengeInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.survivorsChallengeInfos_.Add(other.survivorsChallengeInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A308 RID: 107272 RVA: 0x003D13B7 File Offset: 0x003CF5B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A309 RID: 107273 RVA: 0x003D13C0 File Offset: 0x003CF5C0
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.survivorsChallengeInfos_.AddEntriesFrom(ref input, SurvivorsChallengeInfoUpdateNotify._repeated_survivorsChallengeInfos_codec);
				}
			}
		}

		// Token: 0x04009A10 RID: 39440
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A11 RID: 39441
		public const int SurvivorsChallengeInfosFieldNumber = 11;

		// Token: 0x04009A12 RID: 39442
		private static readonly FieldCodec<SurvivorsChallengeInfo> _repeated_survivorsChallengeInfos_codec = FieldCodec.ForMessage<SurvivorsChallengeInfo>(90U, SurvivorsChallengeInfo.Parser);

		// Token: 0x04009A13 RID: 39443
		private readonly RepeatedField<SurvivorsChallengeInfo> survivorsChallengeInfos_ = new RepeatedField<SurvivorsChallengeInfo>();
	}
}
