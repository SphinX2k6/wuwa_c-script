using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C30 RID: 3120
	[NetMessage(EMessageId.PhantomBattleBadgeInfoUpdateNotify)]
	public sealed class PhantomBattleBadgeInfoUpdateNotify : IMessage<PhantomBattleBadgeInfoUpdateNotify>, IMessage, IEquatable<PhantomBattleBadgeInfoUpdateNotify>, IDeepCloneable<PhantomBattleBadgeInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06010ECE RID: 69326 RVA: 0x0027A7DB File Offset: 0x002789DB
		[NullableContext(1)]
		public static PhantomBattleBadgeInfoUpdateNotify Create()
		{
			return new PhantomBattleBadgeInfoUpdateNotify();
		}

		// Token: 0x170037E5 RID: 14309
		// (get) Token: 0x06010ECF RID: 69327 RVA: 0x0027A7E2 File Offset: 0x002789E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037E6 RID: 14310
		// (get) Token: 0x06010ED0 RID: 69328 RVA: 0x0027A7E5 File Offset: 0x002789E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBadgeInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06010ED1 RID: 69329 RVA: 0x0027A7EC File Offset: 0x002789EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBadgeInfoUpdateNotify()
		{
		}

		// Token: 0x06010ED2 RID: 69330 RVA: 0x0027A7FF File Offset: 0x002789FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBadgeInfoUpdateNotify(PhantomBattleBadgeInfoUpdateNotify other) : this()
		{
			this.phantomBattleBadgeInfos_ = other.phantomBattleBadgeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010ED3 RID: 69331 RVA: 0x0027A829 File Offset: 0x00278A29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBadgeInfoUpdateNotify Clone()
		{
			return new PhantomBattleBadgeInfoUpdateNotify(this);
		}

		// Token: 0x170037E7 RID: 14311
		// (get) Token: 0x06010ED4 RID: 69332 RVA: 0x0027A831 File Offset: 0x00278A31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleBadgeInfo> PhantomBattleBadgeInfos
		{
			get
			{
				return this.phantomBattleBadgeInfos_;
			}
		}

		// Token: 0x06010ED5 RID: 69333 RVA: 0x0027A839 File Offset: 0x00278A39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBadgeInfoUpdateNotify);
		}

		// Token: 0x06010ED6 RID: 69334 RVA: 0x0027A847 File Offset: 0x00278A47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBadgeInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.phantomBattleBadgeInfos_.Equals(other.phantomBattleBadgeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010ED7 RID: 69335 RVA: 0x0027A87C File Offset: 0x00278A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantomBattleBadgeInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010ED8 RID: 69336 RVA: 0x0027A8B0 File Offset: 0x00278AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010ED9 RID: 69337 RVA: 0x0027A8BD File Offset: 0x00278ABD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010EDA RID: 69338 RVA: 0x0027A8C6 File Offset: 0x00278AC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomBattleBadgeInfos_.WriteTo(ref output, PhantomBattleBadgeInfoUpdateNotify._repeated_phantomBattleBadgeInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010EDB RID: 69339 RVA: 0x0027A8F0 File Offset: 0x00278AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantomBattleBadgeInfos_.CalculateSize(PhantomBattleBadgeInfoUpdateNotify._repeated_phantomBattleBadgeInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010EDC RID: 69340 RVA: 0x0027A929 File Offset: 0x00278B29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleBadgeInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.phantomBattleBadgeInfos_.Add(other.phantomBattleBadgeInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010EDD RID: 69341 RVA: 0x0027A957 File Offset: 0x00278B57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010EDE RID: 69342 RVA: 0x0027A960 File Offset: 0x00278B60
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.phantomBattleBadgeInfos_.AddEntriesFrom(ref input, PhantomBattleBadgeInfoUpdateNotify._repeated_phantomBattleBadgeInfos_codec);
				}
			}
		}

		// Token: 0x04006B5F RID: 27487
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B60 RID: 27488
		public const int PhantomBattleBadgeInfosFieldNumber = 9;

		// Token: 0x04006B61 RID: 27489
		private static readonly FieldCodec<PhantomBattleBadgeInfo> _repeated_phantomBattleBadgeInfos_codec = FieldCodec.ForMessage<PhantomBattleBadgeInfo>(74U, PhantomBattleBadgeInfo.Parser);

		// Token: 0x04006B62 RID: 27490
		private readonly RepeatedField<PhantomBattleBadgeInfo> phantomBattleBadgeInfos_ = new RepeatedField<PhantomBattleBadgeInfo>();
	}
}
