using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000431 RID: 1073
	[NetMessage(EMessageId.EnergyUpdateNotify)]
	public sealed class EnergyUpdateNotify : IMessage<EnergyUpdateNotify>, IMessage, IEquatable<EnergyUpdateNotify>, IDeepCloneable<EnergyUpdateNotify>, IBufferMessage
	{
		// Token: 0x06006743 RID: 26435 RVA: 0x000F8A40 File Offset: 0x000F6C40
		[NullableContext(1)]
		public static EnergyUpdateNotify Create()
		{
			return new EnergyUpdateNotify();
		}

		// Token: 0x1700136B RID: 4971
		// (get) Token: 0x06006744 RID: 26436 RVA: 0x000F8A47 File Offset: 0x000F6C47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700136C RID: 4972
		// (get) Token: 0x06006745 RID: 26437 RVA: 0x000F8A4A File Offset: 0x000F6C4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnergyUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06006746 RID: 26438 RVA: 0x000F8A51 File Offset: 0x000F6C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnergyUpdateNotify()
		{
		}

		// Token: 0x06006747 RID: 26439 RVA: 0x000F8A64 File Offset: 0x000F6C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnergyUpdateNotify(EnergyUpdateNotify other) : this()
		{
			this.updateInfoList_ = other.updateInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006748 RID: 26440 RVA: 0x000F8A8E File Offset: 0x000F6C8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnergyUpdateNotify Clone()
		{
			return new EnergyUpdateNotify(this);
		}

		// Token: 0x1700136D RID: 4973
		// (get) Token: 0x06006749 RID: 26441 RVA: 0x000F8A96 File Offset: 0x000F6C96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EnergyInfo> UpdateInfoList
		{
			get
			{
				return this.updateInfoList_;
			}
		}

		// Token: 0x0600674A RID: 26442 RVA: 0x000F8A9E File Offset: 0x000F6C9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnergyUpdateNotify);
		}

		// Token: 0x0600674B RID: 26443 RVA: 0x000F8AAC File Offset: 0x000F6CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnergyUpdateNotify other)
		{
			return other != null && (other == this || (this.updateInfoList_.Equals(other.updateInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600674C RID: 26444 RVA: 0x000F8AE0 File Offset: 0x000F6CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.updateInfoList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600674D RID: 26445 RVA: 0x000F8B14 File Offset: 0x000F6D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600674E RID: 26446 RVA: 0x000F8B21 File Offset: 0x000F6D21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600674F RID: 26447 RVA: 0x000F8B2A File Offset: 0x000F6D2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.updateInfoList_.WriteTo(ref output, EnergyUpdateNotify._repeated_updateInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006750 RID: 26448 RVA: 0x000F8B54 File Offset: 0x000F6D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.updateInfoList_.CalculateSize(EnergyUpdateNotify._repeated_updateInfoList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006751 RID: 26449 RVA: 0x000F8B8D File Offset: 0x000F6D8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnergyUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.updateInfoList_.Add(other.updateInfoList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006752 RID: 26450 RVA: 0x000F8BBB File Offset: 0x000F6DBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006753 RID: 26451 RVA: 0x000F8BC4 File Offset: 0x000F6DC4
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.updateInfoList_.AddEntriesFrom(ref input, EnergyUpdateNotify._repeated_updateInfoList_codec);
				}
			}
		}

		// Token: 0x040039BF RID: 14783
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039C0 RID: 14784
		public const int UpdateInfoListFieldNumber = 14;

		// Token: 0x040039C1 RID: 14785
		private static readonly FieldCodec<EnergyInfo> _repeated_updateInfoList_codec = FieldCodec.ForMessage<EnergyInfo>(114U, EnergyInfo.Parser);

		// Token: 0x040039C2 RID: 14786
		private readonly RepeatedField<EnergyInfo> updateInfoList_ = new RepeatedField<EnergyInfo>();
	}
}
