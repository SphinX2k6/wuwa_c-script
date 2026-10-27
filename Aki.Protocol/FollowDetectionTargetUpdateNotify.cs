using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000615 RID: 1557
	[NetMessage(EMessageId.FollowDetectionTargetUpdateNotify)]
	public sealed class FollowDetectionTargetUpdateNotify : IMessage<FollowDetectionTargetUpdateNotify>, IMessage, IEquatable<FollowDetectionTargetUpdateNotify>, IDeepCloneable<FollowDetectionTargetUpdateNotify>, IBufferMessage
	{
		// Token: 0x06008FC8 RID: 36808 RVA: 0x0015C1D1 File Offset: 0x0015A3D1
		[NullableContext(1)]
		public static FollowDetectionTargetUpdateNotify Create()
		{
			return new FollowDetectionTargetUpdateNotify();
		}

		// Token: 0x17001C8A RID: 7306
		// (get) Token: 0x06008FC9 RID: 36809 RVA: 0x0015C1D8 File Offset: 0x0015A3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C8B RID: 7307
		// (get) Token: 0x06008FCA RID: 36810 RVA: 0x0015C1DB File Offset: 0x0015A3DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FollowDetectionTargetUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06008FCB RID: 36811 RVA: 0x0015C1E2 File Offset: 0x0015A3E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FollowDetectionTargetUpdateNotify()
		{
		}

		// Token: 0x06008FCC RID: 36812 RVA: 0x0015C1F5 File Offset: 0x0015A3F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FollowDetectionTargetUpdateNotify(FollowDetectionTargetUpdateNotify other) : this()
		{
			this.detectionTarget_ = other.detectionTarget_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008FCD RID: 36813 RVA: 0x0015C21F File Offset: 0x0015A41F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FollowDetectionTargetUpdateNotify Clone()
		{
			return new FollowDetectionTargetUpdateNotify(this);
		}

		// Token: 0x17001C8C RID: 7308
		// (get) Token: 0x06008FCE RID: 36814 RVA: 0x0015C227 File Offset: 0x0015A427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DetectionTarget> DetectionTarget
		{
			get
			{
				return this.detectionTarget_;
			}
		}

		// Token: 0x06008FCF RID: 36815 RVA: 0x0015C22F File Offset: 0x0015A42F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FollowDetectionTargetUpdateNotify);
		}

		// Token: 0x06008FD0 RID: 36816 RVA: 0x0015C23D File Offset: 0x0015A43D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FollowDetectionTargetUpdateNotify other)
		{
			return other != null && (other == this || (this.detectionTarget_.Equals(other.detectionTarget_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008FD1 RID: 36817 RVA: 0x0015C270 File Offset: 0x0015A470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.detectionTarget_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008FD2 RID: 36818 RVA: 0x0015C2A4 File Offset: 0x0015A4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008FD3 RID: 36819 RVA: 0x0015C2B1 File Offset: 0x0015A4B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008FD4 RID: 36820 RVA: 0x0015C2BA File Offset: 0x0015A4BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.detectionTarget_.WriteTo(ref output, FollowDetectionTargetUpdateNotify._repeated_detectionTarget_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008FD5 RID: 36821 RVA: 0x0015C2E4 File Offset: 0x0015A4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.detectionTarget_.CalculateSize(FollowDetectionTargetUpdateNotify._repeated_detectionTarget_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008FD6 RID: 36822 RVA: 0x0015C31D File Offset: 0x0015A51D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FollowDetectionTargetUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.detectionTarget_.Add(other.detectionTarget_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008FD7 RID: 36823 RVA: 0x0015C34B File Offset: 0x0015A54B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008FD8 RID: 36824 RVA: 0x0015C354 File Offset: 0x0015A554
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
					this.detectionTarget_.AddEntriesFrom(ref input, FollowDetectionTargetUpdateNotify._repeated_detectionTarget_codec);
				}
			}
		}

		// Token: 0x040045B8 RID: 17848
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045B9 RID: 17849
		public const int DetectionTargetFieldNumber = 11;

		// Token: 0x040045BA RID: 17850
		private static readonly FieldCodec<DetectionTarget> _repeated_detectionTarget_codec = FieldCodec.ForMessage<DetectionTarget>(90U, Aki.Protocol.DetectionTarget.Parser);

		// Token: 0x040045BB RID: 17851
		private readonly RepeatedField<DetectionTarget> detectionTarget_ = new RepeatedField<DetectionTarget>();
	}
}
