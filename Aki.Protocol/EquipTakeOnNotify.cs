using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004C2 RID: 1218
	[NetMessage(EMessageId.EquipTakeOnNotify)]
	public sealed class EquipTakeOnNotify : IMessage<EquipTakeOnNotify>, IMessage, IEquatable<EquipTakeOnNotify>, IDeepCloneable<EquipTakeOnNotify>, IBufferMessage
	{
		// Token: 0x0600742E RID: 29742 RVA: 0x0011D051 File Offset: 0x0011B251
		[NullableContext(1)]
		public static EquipTakeOnNotify Create()
		{
			return new EquipTakeOnNotify();
		}

		// Token: 0x1700167F RID: 5759
		// (get) Token: 0x0600742F RID: 29743 RVA: 0x0011D058 File Offset: 0x0011B258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001680 RID: 5760
		// (get) Token: 0x06007430 RID: 29744 RVA: 0x0011D05B File Offset: 0x0011B25B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EquipTakeOnNotify.Descriptor;
			}
		}

		// Token: 0x06007431 RID: 29745 RVA: 0x0011D062 File Offset: 0x0011B262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipTakeOnNotify()
		{
		}

		// Token: 0x06007432 RID: 29746 RVA: 0x0011D075 File Offset: 0x0011B275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipTakeOnNotify(EquipTakeOnNotify other) : this()
		{
			this.dataList_ = other.dataList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007433 RID: 29747 RVA: 0x0011D09F File Offset: 0x0011B29F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipTakeOnNotify Clone()
		{
			return new EquipTakeOnNotify(this);
		}

		// Token: 0x17001681 RID: 5761
		// (get) Token: 0x06007434 RID: 29748 RVA: 0x0011D0A7 File Offset: 0x0011B2A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleLoadEquipData> DataList
		{
			get
			{
				return this.dataList_;
			}
		}

		// Token: 0x06007435 RID: 29749 RVA: 0x0011D0AF File Offset: 0x0011B2AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EquipTakeOnNotify);
		}

		// Token: 0x06007436 RID: 29750 RVA: 0x0011D0BD File Offset: 0x0011B2BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EquipTakeOnNotify other)
		{
			return other != null && (other == this || (this.dataList_.Equals(other.dataList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007437 RID: 29751 RVA: 0x0011D0F0 File Offset: 0x0011B2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.dataList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007438 RID: 29752 RVA: 0x0011D124 File Offset: 0x0011B324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007439 RID: 29753 RVA: 0x0011D131 File Offset: 0x0011B331
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600743A RID: 29754 RVA: 0x0011D13A File Offset: 0x0011B33A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dataList_.WriteTo(ref output, EquipTakeOnNotify._repeated_dataList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600743B RID: 29755 RVA: 0x0011D164 File Offset: 0x0011B364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.dataList_.CalculateSize(EquipTakeOnNotify._repeated_dataList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600743C RID: 29756 RVA: 0x0011D19D File Offset: 0x0011B39D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EquipTakeOnNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.dataList_.Add(other.dataList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600743D RID: 29757 RVA: 0x0011D1CB File Offset: 0x0011B3CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600743E RID: 29758 RVA: 0x0011D1D4 File Offset: 0x0011B3D4
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.dataList_.AddEntriesFrom(ref input, EquipTakeOnNotify._repeated_dataList_codec);
				}
			}
		}

		// Token: 0x04003DAE RID: 15790
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DAF RID: 15791
		public const int DataListFieldNumber = 8;

		// Token: 0x04003DB0 RID: 15792
		private static readonly FieldCodec<RoleLoadEquipData> _repeated_dataList_codec = FieldCodec.ForMessage<RoleLoadEquipData>(66U, RoleLoadEquipData.Parser);

		// Token: 0x04003DB1 RID: 15793
		private readonly RepeatedField<RoleLoadEquipData> dataList_ = new RepeatedField<RoleLoadEquipData>();
	}
}
