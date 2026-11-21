using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C99 RID: 3225
	[NetMessage(EMessageId.PhantomBattleRoleInfoUpdateNotify)]
	public sealed class PhantomBattleRoleInfoUpdateNotify : IMessage<PhantomBattleRoleInfoUpdateNotify>, IMessage, IEquatable<PhantomBattleRoleInfoUpdateNotify>, IDeepCloneable<PhantomBattleRoleInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06011801 RID: 71681 RVA: 0x00290D3A File Offset: 0x0028EF3A
		[NullableContext(1)]
		public static PhantomBattleRoleInfoUpdateNotify Create()
		{
			return new PhantomBattleRoleInfoUpdateNotify();
		}

		// Token: 0x170039FB RID: 14843
		// (get) Token: 0x06011802 RID: 71682 RVA: 0x00290D41 File Offset: 0x0028EF41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039FC RID: 14844
		// (get) Token: 0x06011803 RID: 71683 RVA: 0x00290D44 File Offset: 0x0028EF44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleRoleInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06011804 RID: 71684 RVA: 0x00290D4B File Offset: 0x0028EF4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoleInfoUpdateNotify()
		{
		}

		// Token: 0x06011805 RID: 71685 RVA: 0x00290D5E File Offset: 0x0028EF5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoleInfoUpdateNotify(PhantomBattleRoleInfoUpdateNotify other) : this()
		{
			this.phantomBattleRoleInfos_ = other.phantomBattleRoleInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011806 RID: 71686 RVA: 0x00290D88 File Offset: 0x0028EF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoleInfoUpdateNotify Clone()
		{
			return new PhantomBattleRoleInfoUpdateNotify(this);
		}

		// Token: 0x170039FD RID: 14845
		// (get) Token: 0x06011807 RID: 71687 RVA: 0x00290D90 File Offset: 0x0028EF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleRoleInfo> PhantomBattleRoleInfos
		{
			get
			{
				return this.phantomBattleRoleInfos_;
			}
		}

		// Token: 0x06011808 RID: 71688 RVA: 0x00290D98 File Offset: 0x0028EF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleRoleInfoUpdateNotify);
		}

		// Token: 0x06011809 RID: 71689 RVA: 0x00290DA6 File Offset: 0x0028EFA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleRoleInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.phantomBattleRoleInfos_.Equals(other.phantomBattleRoleInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601180A RID: 71690 RVA: 0x00290DDC File Offset: 0x0028EFDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantomBattleRoleInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601180B RID: 71691 RVA: 0x00290E10 File Offset: 0x0028F010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601180C RID: 71692 RVA: 0x00290E1D File Offset: 0x0028F01D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601180D RID: 71693 RVA: 0x00290E26 File Offset: 0x0028F026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomBattleRoleInfos_.WriteTo(ref output, PhantomBattleRoleInfoUpdateNotify._repeated_phantomBattleRoleInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601180E RID: 71694 RVA: 0x00290E50 File Offset: 0x0028F050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantomBattleRoleInfos_.CalculateSize(PhantomBattleRoleInfoUpdateNotify._repeated_phantomBattleRoleInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601180F RID: 71695 RVA: 0x00290E89 File Offset: 0x0028F089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleRoleInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.phantomBattleRoleInfos_.Add(other.phantomBattleRoleInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011810 RID: 71696 RVA: 0x00290EB7 File Offset: 0x0028F0B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011811 RID: 71697 RVA: 0x00290EC0 File Offset: 0x0028F0C0
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.phantomBattleRoleInfos_.AddEntriesFrom(ref input, PhantomBattleRoleInfoUpdateNotify._repeated_phantomBattleRoleInfos_codec);
				}
			}
		}

		// Token: 0x04006ECA RID: 28362
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006ECB RID: 28363
		public const int PhantomBattleRoleInfosFieldNumber = 5;

		// Token: 0x04006ECC RID: 28364
		private static readonly FieldCodec<PhantomBattleRoleInfo> _repeated_phantomBattleRoleInfos_codec = FieldCodec.ForMessage<PhantomBattleRoleInfo>(42U, PhantomBattleRoleInfo.Parser);

		// Token: 0x04006ECD RID: 28365
		private readonly RepeatedField<PhantomBattleRoleInfo> phantomBattleRoleInfos_ = new RepeatedField<PhantomBattleRoleInfo>();
	}
}
