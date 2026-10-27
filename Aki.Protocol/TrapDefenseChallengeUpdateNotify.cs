using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200141B RID: 5147
	[NetMessage(EMessageId.TrapDefenseChallengeUpdateNotify)]
	public sealed class TrapDefenseChallengeUpdateNotify : IMessage<TrapDefenseChallengeUpdateNotify>, IMessage, IEquatable<TrapDefenseChallengeUpdateNotify>, IDeepCloneable<TrapDefenseChallengeUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601B482 RID: 111746 RVA: 0x003F3F9C File Offset: 0x003F219C
		[NullableContext(1)]
		public static TrapDefenseChallengeUpdateNotify Create()
		{
			return new TrapDefenseChallengeUpdateNotify();
		}

		// Token: 0x17005C07 RID: 23559
		// (get) Token: 0x0601B483 RID: 111747 RVA: 0x003F3FA3 File Offset: 0x003F21A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C08 RID: 23560
		// (get) Token: 0x0601B484 RID: 111748 RVA: 0x003F3FA6 File Offset: 0x003F21A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseChallengeUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601B485 RID: 111749 RVA: 0x003F3FAD File Offset: 0x003F21AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseChallengeUpdateNotify()
		{
		}

		// Token: 0x0601B486 RID: 111750 RVA: 0x003F3FC0 File Offset: 0x003F21C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseChallengeUpdateNotify(TrapDefenseChallengeUpdateNotify other) : this()
		{
			this.challengeInfo_ = other.challengeInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B487 RID: 111751 RVA: 0x003F3FEA File Offset: 0x003F21EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseChallengeUpdateNotify Clone()
		{
			return new TrapDefenseChallengeUpdateNotify(this);
		}

		// Token: 0x17005C09 RID: 23561
		// (get) Token: 0x0601B488 RID: 111752 RVA: 0x003F3FF2 File Offset: 0x003F21F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseChallengeInfo> ChallengeInfo
		{
			get
			{
				return this.challengeInfo_;
			}
		}

		// Token: 0x0601B489 RID: 111753 RVA: 0x003F3FFA File Offset: 0x003F21FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseChallengeUpdateNotify);
		}

		// Token: 0x0601B48A RID: 111754 RVA: 0x003F4008 File Offset: 0x003F2208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseChallengeUpdateNotify other)
		{
			return other != null && (other == this || (this.challengeInfo_.Equals(other.challengeInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B48B RID: 111755 RVA: 0x003F403C File Offset: 0x003F223C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.challengeInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B48C RID: 111756 RVA: 0x003F4070 File Offset: 0x003F2270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B48D RID: 111757 RVA: 0x003F407D File Offset: 0x003F227D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B48E RID: 111758 RVA: 0x003F4086 File Offset: 0x003F2286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.challengeInfo_.WriteTo(ref output, TrapDefenseChallengeUpdateNotify._repeated_challengeInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B48F RID: 111759 RVA: 0x003F40B0 File Offset: 0x003F22B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.challengeInfo_.CalculateSize(TrapDefenseChallengeUpdateNotify._repeated_challengeInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B490 RID: 111760 RVA: 0x003F40E9 File Offset: 0x003F22E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseChallengeUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.challengeInfo_.Add(other.challengeInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B491 RID: 111761 RVA: 0x003F4117 File Offset: 0x003F2317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B492 RID: 111762 RVA: 0x003F4120 File Offset: 0x003F2320
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
					this.challengeInfo_.AddEntriesFrom(ref input, TrapDefenseChallengeUpdateNotify._repeated_challengeInfo_codec);
				}
			}
		}

		// Token: 0x04009DBB RID: 40379
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DBC RID: 40380
		public const int ChallengeInfoFieldNumber = 4;

		// Token: 0x04009DBD RID: 40381
		private static readonly FieldCodec<TrapDefenseChallengeInfo> _repeated_challengeInfo_codec = FieldCodec.ForMessage<TrapDefenseChallengeInfo>(34U, TrapDefenseChallengeInfo.Parser);

		// Token: 0x04009DBE RID: 40382
		private readonly RepeatedField<TrapDefenseChallengeInfo> challengeInfo_ = new RepeatedField<TrapDefenseChallengeInfo>();
	}
}
