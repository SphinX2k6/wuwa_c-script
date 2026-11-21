using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C20 RID: 3104
	[NetMessage(EMessageId.PhantomBattleBadgeInfoUpdateNotify)]
	public sealed class PhantomBattleBadgeInfoUpdateNotify : IMessage<PhantomBattleBadgeInfoUpdateNotify>, IMessage, IEquatable<PhantomBattleBadgeInfoUpdateNotify>, IDeepCloneable<PhantomBattleBadgeInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06010DCE RID: 69070 RVA: 0x00278A77 File Offset: 0x00276C77
		[NullableContext(1)]
		public static PhantomBattleBadgeInfoUpdateNotify Create()
		{
			return new PhantomBattleBadgeInfoUpdateNotify();
		}

		// Token: 0x170037AE RID: 14254
		// (get) Token: 0x06010DCF RID: 69071 RVA: 0x00278A7E File Offset: 0x00276C7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037AF RID: 14255
		// (get) Token: 0x06010DD0 RID: 69072 RVA: 0x00278A81 File Offset: 0x00276C81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBadgeInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06010DD1 RID: 69073 RVA: 0x00278A88 File Offset: 0x00276C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBadgeInfoUpdateNotify()
		{
		}

		// Token: 0x06010DD2 RID: 69074 RVA: 0x00278A9B File Offset: 0x00276C9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBadgeInfoUpdateNotify(PhantomBattleBadgeInfoUpdateNotify other) : this()
		{
			this.phantomBattleBadgeInfos_ = other.phantomBattleBadgeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010DD3 RID: 69075 RVA: 0x00278AC5 File Offset: 0x00276CC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBadgeInfoUpdateNotify Clone()
		{
			return new PhantomBattleBadgeInfoUpdateNotify(this);
		}

		// Token: 0x170037B0 RID: 14256
		// (get) Token: 0x06010DD4 RID: 69076 RVA: 0x00278ACD File Offset: 0x00276CCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleBadgeInfo> PhantomBattleBadgeInfos
		{
			get
			{
				return this.phantomBattleBadgeInfos_;
			}
		}

		// Token: 0x06010DD5 RID: 69077 RVA: 0x00278AD5 File Offset: 0x00276CD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBadgeInfoUpdateNotify);
		}

		// Token: 0x06010DD6 RID: 69078 RVA: 0x00278AE3 File Offset: 0x00276CE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBadgeInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.phantomBattleBadgeInfos_.Equals(other.phantomBattleBadgeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010DD7 RID: 69079 RVA: 0x00278B18 File Offset: 0x00276D18
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

		// Token: 0x06010DD8 RID: 69080 RVA: 0x00278B4C File Offset: 0x00276D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010DD9 RID: 69081 RVA: 0x00278B59 File Offset: 0x00276D59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010DDA RID: 69082 RVA: 0x00278B62 File Offset: 0x00276D62
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

		// Token: 0x06010DDB RID: 69083 RVA: 0x00278B8C File Offset: 0x00276D8C
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

		// Token: 0x06010DDC RID: 69084 RVA: 0x00278BC5 File Offset: 0x00276DC5
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

		// Token: 0x06010DDD RID: 69085 RVA: 0x00278BF3 File Offset: 0x00276DF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010DDE RID: 69086 RVA: 0x00278BFC File Offset: 0x00276DFC
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
					this.phantomBattleBadgeInfos_.AddEntriesFrom(ref input, PhantomBattleBadgeInfoUpdateNotify._repeated_phantomBattleBadgeInfos_codec);
				}
			}
		}

		// Token: 0x04006B73 RID: 27507
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B74 RID: 27508
		public const int PhantomBattleBadgeInfosFieldNumber = 1;

		// Token: 0x04006B75 RID: 27509
		private static readonly FieldCodec<PhantomBattleBadgeInfo> _repeated_phantomBattleBadgeInfos_codec = FieldCodec.ForMessage<PhantomBattleBadgeInfo>(10U, PhantomBattleBadgeInfo.Parser);

		// Token: 0x04006B76 RID: 27510
		private readonly RepeatedField<PhantomBattleBadgeInfo> phantomBattleBadgeInfos_ = new RepeatedField<PhantomBattleBadgeInfo>();
	}
}
