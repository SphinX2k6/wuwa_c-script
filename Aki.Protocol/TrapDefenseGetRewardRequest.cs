using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001427 RID: 5159
	[NetMessage(EMessageId.TrapDefenseGetRewardRequest)]
	public sealed class TrapDefenseGetRewardRequest : IMessage<TrapDefenseGetRewardRequest>, IMessage, IEquatable<TrapDefenseGetRewardRequest>, IDeepCloneable<TrapDefenseGetRewardRequest>, IBufferMessage
	{
		// Token: 0x0601B571 RID: 111985 RVA: 0x003F5FE7 File Offset: 0x003F41E7
		[NullableContext(1)]
		public static TrapDefenseGetRewardRequest Create()
		{
			return new TrapDefenseGetRewardRequest();
		}

		// Token: 0x17005C37 RID: 23607
		// (get) Token: 0x0601B572 RID: 111986 RVA: 0x003F5FEE File Offset: 0x003F41EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C38 RID: 23608
		// (get) Token: 0x0601B573 RID: 111987 RVA: 0x003F5FF1 File Offset: 0x003F41F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseGetRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601B574 RID: 111988 RVA: 0x003F5FF8 File Offset: 0x003F41F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGetRewardRequest()
		{
		}

		// Token: 0x0601B575 RID: 111989 RVA: 0x003F600B File Offset: 0x003F420B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGetRewardRequest(TrapDefenseGetRewardRequest other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B576 RID: 111990 RVA: 0x003F6035 File Offset: 0x003F4235
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGetRewardRequest Clone()
		{
			return new TrapDefenseGetRewardRequest(this);
		}

		// Token: 0x17005C39 RID: 23609
		// (get) Token: 0x0601B577 RID: 111991 RVA: 0x003F603D File Offset: 0x003F423D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0601B578 RID: 111992 RVA: 0x003F6045 File Offset: 0x003F4245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseGetRewardRequest);
		}

		// Token: 0x0601B579 RID: 111993 RVA: 0x003F6053 File Offset: 0x003F4253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseGetRewardRequest other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B57A RID: 111994 RVA: 0x003F6088 File Offset: 0x003F4288
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

		// Token: 0x0601B57B RID: 111995 RVA: 0x003F60BC File Offset: 0x003F42BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B57C RID: 111996 RVA: 0x003F60C9 File Offset: 0x003F42C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B57D RID: 111997 RVA: 0x003F60D2 File Offset: 0x003F42D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, TrapDefenseGetRewardRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B57E RID: 111998 RVA: 0x003F60FC File Offset: 0x003F42FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(TrapDefenseGetRewardRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B57F RID: 111999 RVA: 0x003F6135 File Offset: 0x003F4335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseGetRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B580 RID: 112000 RVA: 0x003F6163 File Offset: 0x003F4363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B581 RID: 112001 RVA: 0x003F616C File Offset: 0x003F436C
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
				if (num != 80U && num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, TrapDefenseGetRewardRequest._repeated_ids_codec);
				}
			}
		}

		// Token: 0x04009DF5 RID: 40437
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DF6 RID: 40438
		public const int IdsFieldNumber = 10;

		// Token: 0x04009DF7 RID: 40439
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04009DF8 RID: 40440
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
