using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200135A RID: 4954
	[NetMessage(EMessageId.ThemePersonalScoreRequest)]
	public sealed class ThemePersonalScoreRequest : IMessage<ThemePersonalScoreRequest>, IMessage, IEquatable<ThemePersonalScoreRequest>, IDeepCloneable<ThemePersonalScoreRequest>, IBufferMessage
	{
		// Token: 0x0601A51B RID: 107803 RVA: 0x003D2E0C File Offset: 0x003D100C
		[NullableContext(1)]
		public static ThemePersonalScoreRequest Create()
		{
			return new ThemePersonalScoreRequest();
		}

		// Token: 0x170058CF RID: 22735
		// (get) Token: 0x0601A51C RID: 107804 RVA: 0x003D2E13 File Offset: 0x003D1013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058D0 RID: 22736
		// (get) Token: 0x0601A51D RID: 107805 RVA: 0x003D2E16 File Offset: 0x003D1016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThemePersonalScoreRequest.Descriptor;
			}
		}

		// Token: 0x0601A51E RID: 107806 RVA: 0x003D2E1D File Offset: 0x003D101D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemePersonalScoreRequest()
		{
		}

		// Token: 0x0601A51F RID: 107807 RVA: 0x003D2E30 File Offset: 0x003D1030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemePersonalScoreRequest(ThemePersonalScoreRequest other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A520 RID: 107808 RVA: 0x003D2E5A File Offset: 0x003D105A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemePersonalScoreRequest Clone()
		{
			return new ThemePersonalScoreRequest(this);
		}

		// Token: 0x170058D1 RID: 22737
		// (get) Token: 0x0601A521 RID: 107809 RVA: 0x003D2E62 File Offset: 0x003D1062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0601A522 RID: 107810 RVA: 0x003D2E6A File Offset: 0x003D106A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThemePersonalScoreRequest);
		}

		// Token: 0x0601A523 RID: 107811 RVA: 0x003D2E78 File Offset: 0x003D1078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThemePersonalScoreRequest other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A524 RID: 107812 RVA: 0x003D2EAC File Offset: 0x003D10AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A525 RID: 107813 RVA: 0x003D2EE0 File Offset: 0x003D10E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A526 RID: 107814 RVA: 0x003D2EED File Offset: 0x003D10ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A527 RID: 107815 RVA: 0x003D2EF6 File Offset: 0x003D10F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, ThemePersonalScoreRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A528 RID: 107816 RVA: 0x003D2F20 File Offset: 0x003D1120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(ThemePersonalScoreRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A529 RID: 107817 RVA: 0x003D2F59 File Offset: 0x003D1159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThemePersonalScoreRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A52A RID: 107818 RVA: 0x003D2F87 File Offset: 0x003D1187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A52B RID: 107819 RVA: 0x003D2F90 File Offset: 0x003D1190
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
				if (num != 40U && num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, ThemePersonalScoreRequest._repeated_ids_codec);
				}
			}
		}

		// Token: 0x04009977 RID: 39287
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009978 RID: 39288
		public const int IdsFieldNumber = 5;

		// Token: 0x04009979 RID: 39289
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(42U);

		// Token: 0x0400997A RID: 39290
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
