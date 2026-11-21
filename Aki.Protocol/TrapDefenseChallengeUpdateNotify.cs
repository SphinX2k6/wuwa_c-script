using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200148E RID: 5262
	[NetMessage(EMessageId.TrapDefenseChallengeUpdateNotify)]
	public sealed class TrapDefenseChallengeUpdateNotify : IMessage<TrapDefenseChallengeUpdateNotify>, IMessage, IEquatable<TrapDefenseChallengeUpdateNotify>, IDeepCloneable<TrapDefenseChallengeUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601BF0D RID: 114445 RVA: 0x0040F270 File Offset: 0x0040D470
		[NullableContext(1)]
		public static TrapDefenseChallengeUpdateNotify Create()
		{
			return new TrapDefenseChallengeUpdateNotify();
		}

		// Token: 0x17005E9C RID: 24220
		// (get) Token: 0x0601BF0E RID: 114446 RVA: 0x0040F277 File Offset: 0x0040D477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E9D RID: 24221
		// (get) Token: 0x0601BF0F RID: 114447 RVA: 0x0040F27A File Offset: 0x0040D47A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseChallengeUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601BF10 RID: 114448 RVA: 0x0040F281 File Offset: 0x0040D481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseChallengeUpdateNotify()
		{
		}

		// Token: 0x0601BF11 RID: 114449 RVA: 0x0040F294 File Offset: 0x0040D494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseChallengeUpdateNotify(TrapDefenseChallengeUpdateNotify other) : this()
		{
			this.challengeInfo_ = other.challengeInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BF12 RID: 114450 RVA: 0x0040F2BE File Offset: 0x0040D4BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseChallengeUpdateNotify Clone()
		{
			return new TrapDefenseChallengeUpdateNotify(this);
		}

		// Token: 0x17005E9E RID: 24222
		// (get) Token: 0x0601BF13 RID: 114451 RVA: 0x0040F2C6 File Offset: 0x0040D4C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseChallengeInfo> ChallengeInfo
		{
			get
			{
				return this.challengeInfo_;
			}
		}

		// Token: 0x0601BF14 RID: 114452 RVA: 0x0040F2CE File Offset: 0x0040D4CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseChallengeUpdateNotify);
		}

		// Token: 0x0601BF15 RID: 114453 RVA: 0x0040F2DC File Offset: 0x0040D4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseChallengeUpdateNotify other)
		{
			return other != null && (other == this || (this.challengeInfo_.Equals(other.challengeInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BF16 RID: 114454 RVA: 0x0040F310 File Offset: 0x0040D510
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

		// Token: 0x0601BF17 RID: 114455 RVA: 0x0040F344 File Offset: 0x0040D544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BF18 RID: 114456 RVA: 0x0040F351 File Offset: 0x0040D551
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BF19 RID: 114457 RVA: 0x0040F35A File Offset: 0x0040D55A
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

		// Token: 0x0601BF1A RID: 114458 RVA: 0x0040F384 File Offset: 0x0040D584
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

		// Token: 0x0601BF1B RID: 114459 RVA: 0x0040F3BD File Offset: 0x0040D5BD
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

		// Token: 0x0601BF1C RID: 114460 RVA: 0x0040F3EB File Offset: 0x0040D5EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BF1D RID: 114461 RVA: 0x0040F3F4 File Offset: 0x0040D5F4
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
					this.challengeInfo_.AddEntriesFrom(ref input, TrapDefenseChallengeUpdateNotify._repeated_challengeInfo_codec);
				}
			}
		}

		// Token: 0x0400A202 RID: 41474
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A203 RID: 41475
		public const int ChallengeInfoFieldNumber = 1;

		// Token: 0x0400A204 RID: 41476
		private static readonly FieldCodec<TrapDefenseChallengeInfo> _repeated_challengeInfo_codec = FieldCodec.ForMessage<TrapDefenseChallengeInfo>(10U, TrapDefenseChallengeInfo.Parser);

		// Token: 0x0400A205 RID: 41477
		private readonly RepeatedField<TrapDefenseChallengeInfo> challengeInfo_ = new RepeatedField<TrapDefenseChallengeInfo>();
	}
}
