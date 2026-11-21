using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C22 RID: 3106
	[NetMessage(EMessageId.PhantomBattleBadgeRewardInfoUpdateNotify)]
	public sealed class PhantomBattleBadgeRewardInfoUpdateNotify : IMessage<PhantomBattleBadgeRewardInfoUpdateNotify>, IMessage, IEquatable<PhantomBattleBadgeRewardInfoUpdateNotify>, IDeepCloneable<PhantomBattleBadgeRewardInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06010DF8 RID: 69112 RVA: 0x00278FB2 File Offset: 0x002771B2
		[NullableContext(1)]
		public static PhantomBattleBadgeRewardInfoUpdateNotify Create()
		{
			return new PhantomBattleBadgeRewardInfoUpdateNotify();
		}

		// Token: 0x170037B7 RID: 14263
		// (get) Token: 0x06010DF9 RID: 69113 RVA: 0x00278FB9 File Offset: 0x002771B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037B8 RID: 14264
		// (get) Token: 0x06010DFA RID: 69114 RVA: 0x00278FBC File Offset: 0x002771BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBadgeRewardInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06010DFB RID: 69115 RVA: 0x00278FC3 File Offset: 0x002771C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBadgeRewardInfoUpdateNotify()
		{
		}

		// Token: 0x06010DFC RID: 69116 RVA: 0x00278FD6 File Offset: 0x002771D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBadgeRewardInfoUpdateNotify(PhantomBattleBadgeRewardInfoUpdateNotify other) : this()
		{
			this.phantomBattleBadgeRewardInfos_ = other.phantomBattleBadgeRewardInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010DFD RID: 69117 RVA: 0x00279000 File Offset: 0x00277200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBadgeRewardInfoUpdateNotify Clone()
		{
			return new PhantomBattleBadgeRewardInfoUpdateNotify(this);
		}

		// Token: 0x170037B9 RID: 14265
		// (get) Token: 0x06010DFE RID: 69118 RVA: 0x00279008 File Offset: 0x00277208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleBadgeRewardInfo> PhantomBattleBadgeRewardInfos
		{
			get
			{
				return this.phantomBattleBadgeRewardInfos_;
			}
		}

		// Token: 0x06010DFF RID: 69119 RVA: 0x00279010 File Offset: 0x00277210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBadgeRewardInfoUpdateNotify);
		}

		// Token: 0x06010E00 RID: 69120 RVA: 0x0027901E File Offset: 0x0027721E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBadgeRewardInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.phantomBattleBadgeRewardInfos_.Equals(other.phantomBattleBadgeRewardInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010E01 RID: 69121 RVA: 0x00279054 File Offset: 0x00277254
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

		// Token: 0x06010E02 RID: 69122 RVA: 0x00279088 File Offset: 0x00277288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010E03 RID: 69123 RVA: 0x00279095 File Offset: 0x00277295
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010E04 RID: 69124 RVA: 0x0027909E File Offset: 0x0027729E
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

		// Token: 0x06010E05 RID: 69125 RVA: 0x002790C8 File Offset: 0x002772C8
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

		// Token: 0x06010E06 RID: 69126 RVA: 0x00279101 File Offset: 0x00277301
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

		// Token: 0x06010E07 RID: 69127 RVA: 0x0027912F File Offset: 0x0027732F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010E08 RID: 69128 RVA: 0x00279138 File Offset: 0x00277338
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.phantomBattleBadgeRewardInfos_.AddEntriesFrom(ref input, PhantomBattleBadgeRewardInfoUpdateNotify._repeated_phantomBattleBadgeRewardInfos_codec);
				}
			}
		}

		// Token: 0x04006B7F RID: 27519
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B80 RID: 27520
		public const int PhantomBattleBadgeRewardInfosFieldNumber = 3;

		// Token: 0x04006B81 RID: 27521
		private static readonly FieldCodec<PhantomBattleBadgeRewardInfo> _repeated_phantomBattleBadgeRewardInfos_codec = FieldCodec.ForMessage<PhantomBattleBadgeRewardInfo>(26U, PhantomBattleBadgeRewardInfo.Parser);

		// Token: 0x04006B82 RID: 27522
		private readonly RepeatedField<PhantomBattleBadgeRewardInfo> phantomBattleBadgeRewardInfos_ = new RepeatedField<PhantomBattleBadgeRewardInfo>();
	}
}
