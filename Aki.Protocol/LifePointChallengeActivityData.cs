using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000904 RID: 2308
	public sealed class LifePointChallengeActivityData : IMessage<LifePointChallengeActivityData>, IMessage, IEquatable<LifePointChallengeActivityData>, IDeepCloneable<LifePointChallengeActivityData>, IBufferMessage
	{
		// Token: 0x0600CC16 RID: 52246 RVA: 0x001E1A11 File Offset: 0x001DFC11
		[NullableContext(1)]
		public static LifePointChallengeActivityData Create()
		{
			return new LifePointChallengeActivityData();
		}

		// Token: 0x17002931 RID: 10545
		// (get) Token: 0x0600CC17 RID: 52247 RVA: 0x001E1A18 File Offset: 0x001DFC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002932 RID: 10546
		// (get) Token: 0x0600CC18 RID: 52248 RVA: 0x001E1A1B File Offset: 0x001DFC1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LifePointChallengeActivityData.Descriptor;
			}
		}

		// Token: 0x0600CC19 RID: 52249 RVA: 0x001E1A22 File Offset: 0x001DFC22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifePointChallengeActivityData()
		{
		}

		// Token: 0x0600CC1A RID: 52250 RVA: 0x001E1A35 File Offset: 0x001DFC35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifePointChallengeActivityData(LifePointChallengeActivityData other) : this()
		{
			this.challenges_ = other.challenges_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CC1B RID: 52251 RVA: 0x001E1A5F File Offset: 0x001DFC5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifePointChallengeActivityData Clone()
		{
			return new LifePointChallengeActivityData(this);
		}

		// Token: 0x17002933 RID: 10547
		// (get) Token: 0x0600CC1C RID: 52252 RVA: 0x001E1A67 File Offset: 0x001DFC67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LifePointChallengeData> Challenges
		{
			get
			{
				return this.challenges_;
			}
		}

		// Token: 0x0600CC1D RID: 52253 RVA: 0x001E1A6F File Offset: 0x001DFC6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LifePointChallengeActivityData);
		}

		// Token: 0x0600CC1E RID: 52254 RVA: 0x001E1A7D File Offset: 0x001DFC7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LifePointChallengeActivityData other)
		{
			return other != null && (other == this || (this.challenges_.Equals(other.challenges_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CC1F RID: 52255 RVA: 0x001E1AB0 File Offset: 0x001DFCB0
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

		// Token: 0x0600CC20 RID: 52256 RVA: 0x001E1AE4 File Offset: 0x001DFCE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CC21 RID: 52257 RVA: 0x001E1AF1 File Offset: 0x001DFCF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CC22 RID: 52258 RVA: 0x001E1AFA File Offset: 0x001DFCFA
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

		// Token: 0x0600CC23 RID: 52259 RVA: 0x001E1B24 File Offset: 0x001DFD24
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

		// Token: 0x0600CC24 RID: 52260 RVA: 0x001E1B5D File Offset: 0x001DFD5D
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

		// Token: 0x0600CC25 RID: 52261 RVA: 0x001E1B8B File Offset: 0x001DFD8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CC26 RID: 52262 RVA: 0x001E1B94 File Offset: 0x001DFD94
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

		// Token: 0x040056EA RID: 22250
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056EB RID: 22251
		public const int ChallengesFieldNumber = 1;

		// Token: 0x040056EC RID: 22252
		private static readonly FieldCodec<LifePointChallengeData> _repeated_challenges_codec = FieldCodec.ForMessage<LifePointChallengeData>(10U, LifePointChallengeData.Parser);

		// Token: 0x040056ED RID: 22253
		private readonly RepeatedField<LifePointChallengeData> challenges_ = new RepeatedField<LifePointChallengeData>();
	}
}
