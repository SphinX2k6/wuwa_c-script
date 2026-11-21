using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000420 RID: 1056
	public sealed class EncircleActivityPb : IMessage<EncircleActivityPb>, IMessage, IEquatable<EncircleActivityPb>, IDeepCloneable<EncircleActivityPb>, IBufferMessage
	{
		// Token: 0x060065D9 RID: 26073 RVA: 0x000F549F File Offset: 0x000F369F
		[NullableContext(1)]
		public static EncircleActivityPb Create()
		{
			return new EncircleActivityPb();
		}

		// Token: 0x1700131C RID: 4892
		// (get) Token: 0x060065DA RID: 26074 RVA: 0x000F54A6 File Offset: 0x000F36A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700131D RID: 4893
		// (get) Token: 0x060065DB RID: 26075 RVA: 0x000F54A9 File Offset: 0x000F36A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EncircleActivityPb.Descriptor;
			}
		}

		// Token: 0x060065DC RID: 26076 RVA: 0x000F54B0 File Offset: 0x000F36B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleActivityPb()
		{
		}

		// Token: 0x060065DD RID: 26077 RVA: 0x000F54C3 File Offset: 0x000F36C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleActivityPb(EncircleActivityPb other) : this()
		{
			this.challenges_ = other.challenges_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060065DE RID: 26078 RVA: 0x000F54ED File Offset: 0x000F36ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleActivityPb Clone()
		{
			return new EncircleActivityPb(this);
		}

		// Token: 0x1700131E RID: 4894
		// (get) Token: 0x060065DF RID: 26079 RVA: 0x000F54F5 File Offset: 0x000F36F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EncircleChallengePb> Challenges
		{
			get
			{
				return this.challenges_;
			}
		}

		// Token: 0x060065E0 RID: 26080 RVA: 0x000F54FD File Offset: 0x000F36FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EncircleActivityPb);
		}

		// Token: 0x060065E1 RID: 26081 RVA: 0x000F550B File Offset: 0x000F370B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EncircleActivityPb other)
		{
			return other != null && (other == this || (this.challenges_.Equals(other.challenges_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060065E2 RID: 26082 RVA: 0x000F5540 File Offset: 0x000F3740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.challenges_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060065E3 RID: 26083 RVA: 0x000F5574 File Offset: 0x000F3774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060065E4 RID: 26084 RVA: 0x000F5581 File Offset: 0x000F3781
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060065E5 RID: 26085 RVA: 0x000F558A File Offset: 0x000F378A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.challenges_.WriteTo(ref output, EncircleActivityPb._repeated_challenges_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060065E6 RID: 26086 RVA: 0x000F55B4 File Offset: 0x000F37B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.challenges_.CalculateSize(EncircleActivityPb._repeated_challenges_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060065E7 RID: 26087 RVA: 0x000F55ED File Offset: 0x000F37ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EncircleActivityPb other)
		{
			if (other == null)
			{
				return;
			}
			this.challenges_.Add(other.challenges_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060065E8 RID: 26088 RVA: 0x000F561B File Offset: 0x000F381B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060065E9 RID: 26089 RVA: 0x000F5624 File Offset: 0x000F3824
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
					this.challenges_.AddEntriesFrom(ref input, EncircleActivityPb._repeated_challenges_codec);
				}
			}
		}

		// Token: 0x04003952 RID: 14674
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003953 RID: 14675
		public const int ChallengesFieldNumber = 1;

		// Token: 0x04003954 RID: 14676
		private static readonly FieldCodec<EncircleChallengePb> _repeated_challenges_codec = FieldCodec.ForMessage<EncircleChallengePb>(10U, EncircleChallengePb.Parser);

		// Token: 0x04003955 RID: 14677
		private readonly RepeatedField<EncircleChallengePb> challenges_ = new RepeatedField<EncircleChallengePb>();
	}
}
