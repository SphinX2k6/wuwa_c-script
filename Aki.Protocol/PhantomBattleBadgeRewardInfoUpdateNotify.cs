using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C32 RID: 3122
	[NetMessage(EMessageId.PhantomBattleBadgeRewardInfoUpdateNotify)]
	public sealed class PhantomBattleBadgeRewardInfoUpdateNotify : IMessage<PhantomBattleBadgeRewardInfoUpdateNotify>, IMessage, IEquatable<PhantomBattleBadgeRewardInfoUpdateNotify>, IDeepCloneable<PhantomBattleBadgeRewardInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06010EF8 RID: 69368 RVA: 0x0027AD16 File Offset: 0x00278F16
		[NullableContext(1)]
		public static PhantomBattleBadgeRewardInfoUpdateNotify Create()
		{
			return new PhantomBattleBadgeRewardInfoUpdateNotify();
		}

		// Token: 0x170037EE RID: 14318
		// (get) Token: 0x06010EF9 RID: 69369 RVA: 0x0027AD1D File Offset: 0x00278F1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037EF RID: 14319
		// (get) Token: 0x06010EFA RID: 69370 RVA: 0x0027AD20 File Offset: 0x00278F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBadgeRewardInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06010EFB RID: 69371 RVA: 0x0027AD27 File Offset: 0x00278F27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBadgeRewardInfoUpdateNotify()
		{
		}

		// Token: 0x06010EFC RID: 69372 RVA: 0x0027AD3A File Offset: 0x00278F3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBadgeRewardInfoUpdateNotify(PhantomBattleBadgeRewardInfoUpdateNotify other) : this()
		{
			this.phantomBattleBadgeRewardInfos_ = other.phantomBattleBadgeRewardInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010EFD RID: 69373 RVA: 0x0027AD64 File Offset: 0x00278F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBadgeRewardInfoUpdateNotify Clone()
		{
			return new PhantomBattleBadgeRewardInfoUpdateNotify(this);
		}

		// Token: 0x170037F0 RID: 14320
		// (get) Token: 0x06010EFE RID: 69374 RVA: 0x0027AD6C File Offset: 0x00278F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleBadgeRewardInfo> PhantomBattleBadgeRewardInfos
		{
			get
			{
				return this.phantomBattleBadgeRewardInfos_;
			}
		}

		// Token: 0x06010EFF RID: 69375 RVA: 0x0027AD74 File Offset: 0x00278F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBadgeRewardInfoUpdateNotify);
		}

		// Token: 0x06010F00 RID: 69376 RVA: 0x0027AD82 File Offset: 0x00278F82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBadgeRewardInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.phantomBattleBadgeRewardInfos_.Equals(other.phantomBattleBadgeRewardInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010F01 RID: 69377 RVA: 0x0027ADB8 File Offset: 0x00278FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantomBattleBadgeRewardInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010F02 RID: 69378 RVA: 0x0027ADEC File Offset: 0x00278FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010F03 RID: 69379 RVA: 0x0027ADF9 File Offset: 0x00278FF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010F04 RID: 69380 RVA: 0x0027AE02 File Offset: 0x00279002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomBattleBadgeRewardInfos_.WriteTo(ref output, PhantomBattleBadgeRewardInfoUpdateNotify._repeated_phantomBattleBadgeRewardInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010F05 RID: 69381 RVA: 0x0027AE2C File Offset: 0x0027902C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantomBattleBadgeRewardInfos_.CalculateSize(PhantomBattleBadgeRewardInfoUpdateNotify._repeated_phantomBattleBadgeRewardInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010F06 RID: 69382 RVA: 0x0027AE65 File Offset: 0x00279065
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleBadgeRewardInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.phantomBattleBadgeRewardInfos_.Add(other.phantomBattleBadgeRewardInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010F07 RID: 69383 RVA: 0x0027AE93 File Offset: 0x00279093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010F08 RID: 69384 RVA: 0x0027AE9C File Offset: 0x0027909C
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
					this.phantomBattleBadgeRewardInfos_.AddEntriesFrom(ref input, PhantomBattleBadgeRewardInfoUpdateNotify._repeated_phantomBattleBadgeRewardInfos_codec);
				}
			}
		}

		// Token: 0x04006B6B RID: 27499
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B6C RID: 27500
		public const int PhantomBattleBadgeRewardInfosFieldNumber = 12;

		// Token: 0x04006B6D RID: 27501
		private static readonly FieldCodec<PhantomBattleBadgeRewardInfo> _repeated_phantomBattleBadgeRewardInfos_codec = FieldCodec.ForMessage<PhantomBattleBadgeRewardInfo>(98U, PhantomBattleBadgeRewardInfo.Parser);

		// Token: 0x04006B6E RID: 27502
		private readonly RepeatedField<PhantomBattleBadgeRewardInfo> phantomBattleBadgeRewardInfos_ = new RepeatedField<PhantomBattleBadgeRewardInfo>();
	}
}
