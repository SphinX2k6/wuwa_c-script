using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200135E RID: 4958
	[NetMessage(EMessageId.ThirdPartySharedNotify)]
	public sealed class ThirdPartySharedNotify : IMessage<ThirdPartySharedNotify>, IMessage, IEquatable<ThirdPartySharedNotify>, IDeepCloneable<ThirdPartySharedNotify>, IBufferMessage
	{
		// Token: 0x0601A563 RID: 107875 RVA: 0x003D358D File Offset: 0x003D178D
		[NullableContext(1)]
		public static ThirdPartySharedNotify Create()
		{
			return new ThirdPartySharedNotify();
		}

		// Token: 0x170058DB RID: 22747
		// (get) Token: 0x0601A564 RID: 107876 RVA: 0x003D3594 File Offset: 0x003D1794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058DC RID: 22748
		// (get) Token: 0x0601A565 RID: 107877 RVA: 0x003D3597 File Offset: 0x003D1797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThirdPartySharedNotify.Descriptor;
			}
		}

		// Token: 0x0601A566 RID: 107878 RVA: 0x003D359E File Offset: 0x003D179E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThirdPartySharedNotify()
		{
		}

		// Token: 0x0601A567 RID: 107879 RVA: 0x003D35B1 File Offset: 0x003D17B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThirdPartySharedNotify(ThirdPartySharedNotify other) : this()
		{
			this.sharedIds_ = other.sharedIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A568 RID: 107880 RVA: 0x003D35DB File Offset: 0x003D17DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThirdPartySharedNotify Clone()
		{
			return new ThirdPartySharedNotify(this);
		}

		// Token: 0x170058DD RID: 22749
		// (get) Token: 0x0601A569 RID: 107881 RVA: 0x003D35E3 File Offset: 0x003D17E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SharedIds
		{
			get
			{
				return this.sharedIds_;
			}
		}

		// Token: 0x0601A56A RID: 107882 RVA: 0x003D35EB File Offset: 0x003D17EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThirdPartySharedNotify);
		}

		// Token: 0x0601A56B RID: 107883 RVA: 0x003D35F9 File Offset: 0x003D17F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThirdPartySharedNotify other)
		{
			return other != null && (other == this || (this.sharedIds_.Equals(other.sharedIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A56C RID: 107884 RVA: 0x003D362C File Offset: 0x003D182C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.sharedIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A56D RID: 107885 RVA: 0x003D3660 File Offset: 0x003D1860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A56E RID: 107886 RVA: 0x003D366D File Offset: 0x003D186D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A56F RID: 107887 RVA: 0x003D3676 File Offset: 0x003D1876
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.sharedIds_.WriteTo(ref output, ThirdPartySharedNotify._repeated_sharedIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A570 RID: 107888 RVA: 0x003D36A0 File Offset: 0x003D18A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.sharedIds_.CalculateSize(ThirdPartySharedNotify._repeated_sharedIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A571 RID: 107889 RVA: 0x003D36D9 File Offset: 0x003D18D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThirdPartySharedNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.sharedIds_.Add(other.sharedIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A572 RID: 107890 RVA: 0x003D3707 File Offset: 0x003D1907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A573 RID: 107891 RVA: 0x003D3710 File Offset: 0x003D1910
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
				if (num != 96U && num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.sharedIds_.AddEntriesFrom(ref input, ThirdPartySharedNotify._repeated_sharedIds_codec);
				}
			}
		}

		// Token: 0x04009985 RID: 39301
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009986 RID: 39302
		public const int SharedIdsFieldNumber = 12;

		// Token: 0x04009987 RID: 39303
		private static readonly FieldCodec<int> _repeated_sharedIds_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04009988 RID: 39304
		private readonly RepeatedField<int> sharedIds_ = new RepeatedField<int>();
	}
}
