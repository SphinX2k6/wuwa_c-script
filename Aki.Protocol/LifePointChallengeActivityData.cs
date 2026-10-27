using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000915 RID: 2325
	public sealed class LifePointChallengeActivityData : IMessage<LifePointChallengeActivityData>, IMessage, IEquatable<LifePointChallengeActivityData>, IDeepCloneable<LifePointChallengeActivityData>, IBufferMessage
	{
		// Token: 0x0600CD32 RID: 52530 RVA: 0x001E3CE1 File Offset: 0x001E1EE1
		[NullableContext(1)]
		public static LifePointChallengeActivityData Create()
		{
			return new LifePointChallengeActivityData();
		}

		// Token: 0x17002970 RID: 10608
		// (get) Token: 0x0600CD33 RID: 52531 RVA: 0x001E3CE8 File Offset: 0x001E1EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002971 RID: 10609
		// (get) Token: 0x0600CD34 RID: 52532 RVA: 0x001E3CEB File Offset: 0x001E1EEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LifePointChallengeActivityData.Descriptor;
			}
		}

		// Token: 0x0600CD35 RID: 52533 RVA: 0x001E3CF2 File Offset: 0x001E1EF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifePointChallengeActivityData()
		{
		}

		// Token: 0x0600CD36 RID: 52534 RVA: 0x001E3D05 File Offset: 0x001E1F05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifePointChallengeActivityData(LifePointChallengeActivityData other) : this()
		{
			this.challenges_ = other.challenges_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CD37 RID: 52535 RVA: 0x001E3D2F File Offset: 0x001E1F2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifePointChallengeActivityData Clone()
		{
			return new LifePointChallengeActivityData(this);
		}

		// Token: 0x17002972 RID: 10610
		// (get) Token: 0x0600CD38 RID: 52536 RVA: 0x001E3D37 File Offset: 0x001E1F37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LifePointChallengeData> Challenges
		{
			get
			{
				return this.challenges_;
			}
		}

		// Token: 0x0600CD39 RID: 52537 RVA: 0x001E3D3F File Offset: 0x001E1F3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LifePointChallengeActivityData);
		}

		// Token: 0x0600CD3A RID: 52538 RVA: 0x001E3D4D File Offset: 0x001E1F4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LifePointChallengeActivityData other)
		{
			return other != null && (other == this || (this.challenges_.Equals(other.challenges_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CD3B RID: 52539 RVA: 0x001E3D80 File Offset: 0x001E1F80
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

		// Token: 0x0600CD3C RID: 52540 RVA: 0x001E3DB4 File Offset: 0x001E1FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CD3D RID: 52541 RVA: 0x001E3DC1 File Offset: 0x001E1FC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CD3E RID: 52542 RVA: 0x001E3DCA File Offset: 0x001E1FCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.challenges_.WriteTo(ref output, LifePointChallengeActivityData._repeated_challenges_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CD3F RID: 52543 RVA: 0x001E3DF4 File Offset: 0x001E1FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.challenges_.CalculateSize(LifePointChallengeActivityData._repeated_challenges_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CD40 RID: 52544 RVA: 0x001E3E2D File Offset: 0x001E202D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LifePointChallengeActivityData other)
		{
			if (other == null)
			{
				return;
			}
			this.challenges_.Add(other.challenges_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CD41 RID: 52545 RVA: 0x001E3E5B File Offset: 0x001E205B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CD42 RID: 52546 RVA: 0x001E3E64 File Offset: 0x001E2064
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
					this.challenges_.AddEntriesFrom(ref input, LifePointChallengeActivityData._repeated_challenges_codec);
				}
			}
		}

		// Token: 0x040056E3 RID: 22243
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056E4 RID: 22244
		public const int ChallengesFieldNumber = 1;

		// Token: 0x040056E5 RID: 22245
		private static readonly FieldCodec<LifePointChallengeData> _repeated_challenges_codec = FieldCodec.ForMessage<LifePointChallengeData>(10U, LifePointChallengeData.Parser);

		// Token: 0x040056E6 RID: 22246
		private readonly RepeatedField<LifePointChallengeData> challenges_ = new RepeatedField<LifePointChallengeData>();
	}
}
