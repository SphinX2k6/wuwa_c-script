using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B44 RID: 2884
	[NetMessage(EMessageId.NewTowerRewardRequest)]
	public sealed class NewTowerRewardRequest : IMessage<NewTowerRewardRequest>, IMessage, IEquatable<NewTowerRewardRequest>, IDeepCloneable<NewTowerRewardRequest>, IBufferMessage
	{
		// Token: 0x0600FA41 RID: 64065 RVA: 0x00247FB7 File Offset: 0x002461B7
		[NullableContext(1)]
		public static NewTowerRewardRequest Create()
		{
			return new NewTowerRewardRequest();
		}

		// Token: 0x1700330B RID: 13067
		// (get) Token: 0x0600FA42 RID: 64066 RVA: 0x00247FBE File Offset: 0x002461BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700330C RID: 13068
		// (get) Token: 0x0600FA43 RID: 64067 RVA: 0x00247FC1 File Offset: 0x002461C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600FA44 RID: 64068 RVA: 0x00247FC8 File Offset: 0x002461C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRewardRequest()
		{
		}

		// Token: 0x0600FA45 RID: 64069 RVA: 0x00247FDB File Offset: 0x002461DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRewardRequest(NewTowerRewardRequest other) : this()
		{
			this.indexs_ = other.indexs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FA46 RID: 64070 RVA: 0x00248005 File Offset: 0x00246205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRewardRequest Clone()
		{
			return new NewTowerRewardRequest(this);
		}

		// Token: 0x1700330D RID: 13069
		// (get) Token: 0x0600FA47 RID: 64071 RVA: 0x0024800D File Offset: 0x0024620D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Indexs
		{
			get
			{
				return this.indexs_;
			}
		}

		// Token: 0x0600FA48 RID: 64072 RVA: 0x00248015 File Offset: 0x00246215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerRewardRequest);
		}

		// Token: 0x0600FA49 RID: 64073 RVA: 0x00248023 File Offset: 0x00246223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerRewardRequest other)
		{
			return other != null && (other == this || (this.indexs_.Equals(other.indexs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FA4A RID: 64074 RVA: 0x00248058 File Offset: 0x00246258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.indexs_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FA4B RID: 64075 RVA: 0x0024808C File Offset: 0x0024628C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FA4C RID: 64076 RVA: 0x00248099 File Offset: 0x00246299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FA4D RID: 64077 RVA: 0x002480A2 File Offset: 0x002462A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.indexs_.WriteTo(ref output, NewTowerRewardRequest._repeated_indexs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FA4E RID: 64078 RVA: 0x002480CC File Offset: 0x002462CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.indexs_.CalculateSize(NewTowerRewardRequest._repeated_indexs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FA4F RID: 64079 RVA: 0x00248105 File Offset: 0x00246305
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.indexs_.Add(other.indexs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FA50 RID: 64080 RVA: 0x00248133 File Offset: 0x00246333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FA51 RID: 64081 RVA: 0x0024813C File Offset: 0x0024633C
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
				if (num != 120U && num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.indexs_.AddEntriesFrom(ref input, NewTowerRewardRequest._repeated_indexs_codec);
				}
			}
		}

		// Token: 0x0400643C RID: 25660
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400643D RID: 25661
		public const int IndexsFieldNumber = 15;

		// Token: 0x0400643E RID: 25662
		private static readonly FieldCodec<int> _repeated_indexs_codec = FieldCodec.ForInt32(122U);

		// Token: 0x0400643F RID: 25663
		private readonly RepeatedField<int> indexs_ = new RepeatedField<int>();
	}
}
