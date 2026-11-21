using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003A4 RID: 932
	[NetMessage(EMessageId.DecalRemoveNotify)]
	public sealed class DecalRemoveNotify : IMessage<DecalRemoveNotify>, IMessage, IEquatable<DecalRemoveNotify>, IDeepCloneable<DecalRemoveNotify>, IBufferMessage
	{
		// Token: 0x06005BFD RID: 23549 RVA: 0x000DFDE7 File Offset: 0x000DDFE7
		[NullableContext(1)]
		public static DecalRemoveNotify Create()
		{
			return new DecalRemoveNotify();
		}

		// Token: 0x1700110A RID: 4362
		// (get) Token: 0x06005BFE RID: 23550 RVA: 0x000DFDEE File Offset: 0x000DDFEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700110B RID: 4363
		// (get) Token: 0x06005BFF RID: 23551 RVA: 0x000DFDF1 File Offset: 0x000DDFF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DecalRemoveNotify.Descriptor;
			}
		}

		// Token: 0x06005C00 RID: 23552 RVA: 0x000DFDF8 File Offset: 0x000DDFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DecalRemoveNotify()
		{
		}

		// Token: 0x06005C01 RID: 23553 RVA: 0x000DFE0B File Offset: 0x000DE00B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DecalRemoveNotify(DecalRemoveNotify other) : this()
		{
			this.info_ = other.info_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005C02 RID: 23554 RVA: 0x000DFE35 File Offset: 0x000DE035
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DecalRemoveNotify Clone()
		{
			return new DecalRemoveNotify(this);
		}

		// Token: 0x1700110C RID: 4364
		// (get) Token: 0x06005C03 RID: 23555 RVA: 0x000DFE3D File Offset: 0x000DE03D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DecalInfo> Info
		{
			get
			{
				return this.info_;
			}
		}

		// Token: 0x06005C04 RID: 23556 RVA: 0x000DFE45 File Offset: 0x000DE045
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DecalRemoveNotify);
		}

		// Token: 0x06005C05 RID: 23557 RVA: 0x000DFE53 File Offset: 0x000DE053
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DecalRemoveNotify other)
		{
			return other != null && (other == this || (this.info_.Equals(other.info_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005C06 RID: 23558 RVA: 0x000DFE88 File Offset: 0x000DE088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.info_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005C07 RID: 23559 RVA: 0x000DFEBC File Offset: 0x000DE0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005C08 RID: 23560 RVA: 0x000DFEC9 File Offset: 0x000DE0C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005C09 RID: 23561 RVA: 0x000DFED2 File Offset: 0x000DE0D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.info_.WriteTo(ref output, DecalRemoveNotify._repeated_info_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005C0A RID: 23562 RVA: 0x000DFEFC File Offset: 0x000DE0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.info_.CalculateSize(DecalRemoveNotify._repeated_info_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005C0B RID: 23563 RVA: 0x000DFF35 File Offset: 0x000DE135
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DecalRemoveNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.info_.Add(other.info_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005C0C RID: 23564 RVA: 0x000DFF63 File Offset: 0x000DE163
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005C0D RID: 23565 RVA: 0x000DFF6C File Offset: 0x000DE16C
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.info_.AddEntriesFrom(ref input, DecalRemoveNotify._repeated_info_codec);
				}
			}
		}

		// Token: 0x04003681 RID: 13953
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003682 RID: 13954
		public const int InfoFieldNumber = 10;

		// Token: 0x04003683 RID: 13955
		private static readonly FieldCodec<DecalInfo> _repeated_info_codec = FieldCodec.ForMessage<DecalInfo>(82U, DecalInfo.Parser);

		// Token: 0x04003684 RID: 13956
		private readonly RepeatedField<DecalInfo> info_ = new RepeatedField<DecalInfo>();
	}
}
