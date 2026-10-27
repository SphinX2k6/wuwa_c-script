using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004D9 RID: 1241
	[NetMessage(EMessageId.EquipTakeOnNotify)]
	public sealed class EquipTakeOnNotify : IMessage<EquipTakeOnNotify>, IMessage, IEquatable<EquipTakeOnNotify>, IDeepCloneable<EquipTakeOnNotify>, IBufferMessage
	{
		// Token: 0x060075BE RID: 30142 RVA: 0x00120169 File Offset: 0x0011E369
		[NullableContext(1)]
		public static EquipTakeOnNotify Create()
		{
			return new EquipTakeOnNotify();
		}

		// Token: 0x170016D4 RID: 5844
		// (get) Token: 0x060075BF RID: 30143 RVA: 0x00120170 File Offset: 0x0011E370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016D5 RID: 5845
		// (get) Token: 0x060075C0 RID: 30144 RVA: 0x00120173 File Offset: 0x0011E373
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EquipTakeOnNotify.Descriptor;
			}
		}

		// Token: 0x060075C1 RID: 30145 RVA: 0x0012017A File Offset: 0x0011E37A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipTakeOnNotify()
		{
		}

		// Token: 0x060075C2 RID: 30146 RVA: 0x0012018D File Offset: 0x0011E38D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipTakeOnNotify(EquipTakeOnNotify other) : this()
		{
			this.dataList_ = other.dataList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060075C3 RID: 30147 RVA: 0x001201B7 File Offset: 0x0011E3B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipTakeOnNotify Clone()
		{
			return new EquipTakeOnNotify(this);
		}

		// Token: 0x170016D6 RID: 5846
		// (get) Token: 0x060075C4 RID: 30148 RVA: 0x001201BF File Offset: 0x0011E3BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleLoadEquipData> DataList
		{
			get
			{
				return this.dataList_;
			}
		}

		// Token: 0x060075C5 RID: 30149 RVA: 0x001201C7 File Offset: 0x0011E3C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EquipTakeOnNotify);
		}

		// Token: 0x060075C6 RID: 30150 RVA: 0x001201D5 File Offset: 0x0011E3D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EquipTakeOnNotify other)
		{
			return other != null && (other == this || (this.dataList_.Equals(other.dataList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060075C7 RID: 30151 RVA: 0x00120208 File Offset: 0x0011E408
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

		// Token: 0x060075C8 RID: 30152 RVA: 0x0012023C File Offset: 0x0011E43C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060075C9 RID: 30153 RVA: 0x00120249 File Offset: 0x0011E449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060075CA RID: 30154 RVA: 0x00120252 File Offset: 0x0011E452
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

		// Token: 0x060075CB RID: 30155 RVA: 0x0012027C File Offset: 0x0011E47C
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

		// Token: 0x060075CC RID: 30156 RVA: 0x001202B5 File Offset: 0x0011E4B5
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

		// Token: 0x060075CD RID: 30157 RVA: 0x001202E3 File Offset: 0x0011E4E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060075CE RID: 30158 RVA: 0x001202EC File Offset: 0x0011E4EC
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
					this.dataList_.AddEntriesFrom(ref input, EquipTakeOnNotify._repeated_dataList_codec);
				}
			}
		}

		// Token: 0x04003DC2 RID: 15810
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DC3 RID: 15811
		public const int DataListFieldNumber = 5;

		// Token: 0x04003DC4 RID: 15812
		private static readonly FieldCodec<RoleLoadEquipData> _repeated_dataList_codec = FieldCodec.ForMessage<RoleLoadEquipData>(42U, RoleLoadEquipData.Parser);

		// Token: 0x04003DC5 RID: 15813
		private readonly RepeatedField<RoleLoadEquipData> dataList_ = new RepeatedField<RoleLoadEquipData>();
	}
}
