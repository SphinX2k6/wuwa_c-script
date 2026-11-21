using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200106D RID: 4205
	[NetMessage(EMessageId.RoleFlyEquipNotify)]
	public sealed class RoleFlyEquipNotify : IMessage<RoleFlyEquipNotify>, IMessage, IEquatable<RoleFlyEquipNotify>, IDeepCloneable<RoleFlyEquipNotify>, IBufferMessage
	{
		// Token: 0x060167ED RID: 92141 RVA: 0x00345C39 File Offset: 0x00343E39
		[NullableContext(1)]
		public static RoleFlyEquipNotify Create()
		{
			return new RoleFlyEquipNotify();
		}

		// Token: 0x17004B57 RID: 19287
		// (get) Token: 0x060167EE RID: 92142 RVA: 0x00345C40 File Offset: 0x00343E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B58 RID: 19288
		// (get) Token: 0x060167EF RID: 92143 RVA: 0x00345C43 File Offset: 0x00343E43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFlyEquipNotify.Descriptor;
			}
		}

		// Token: 0x060167F0 RID: 92144 RVA: 0x00345C4A File Offset: 0x00343E4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFlyEquipNotify()
		{
		}

		// Token: 0x060167F1 RID: 92145 RVA: 0x00345C5D File Offset: 0x00343E5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFlyEquipNotify(RoleFlyEquipNotify other) : this()
		{
			this.dataList_ = other.dataList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060167F2 RID: 92146 RVA: 0x00345C87 File Offset: 0x00343E87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFlyEquipNotify Clone()
		{
			return new RoleFlyEquipNotify(this);
		}

		// Token: 0x17004B59 RID: 19289
		// (get) Token: 0x060167F3 RID: 92147 RVA: 0x00345C8F File Offset: 0x00343E8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FlyEquipData> DataList
		{
			get
			{
				return this.dataList_;
			}
		}

		// Token: 0x060167F4 RID: 92148 RVA: 0x00345C97 File Offset: 0x00343E97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFlyEquipNotify);
		}

		// Token: 0x060167F5 RID: 92149 RVA: 0x00345CA5 File Offset: 0x00343EA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFlyEquipNotify other)
		{
			return other != null && (other == this || (this.dataList_.Equals(other.dataList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060167F6 RID: 92150 RVA: 0x00345CD8 File Offset: 0x00343ED8
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

		// Token: 0x060167F7 RID: 92151 RVA: 0x00345D0C File Offset: 0x00343F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060167F8 RID: 92152 RVA: 0x00345D19 File Offset: 0x00343F19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060167F9 RID: 92153 RVA: 0x00345D22 File Offset: 0x00343F22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dataList_.WriteTo(ref output, RoleFlyEquipNotify._repeated_dataList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060167FA RID: 92154 RVA: 0x00345D4C File Offset: 0x00343F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.dataList_.CalculateSize(RoleFlyEquipNotify._repeated_dataList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060167FB RID: 92155 RVA: 0x00345D85 File Offset: 0x00343F85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleFlyEquipNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.dataList_.Add(other.dataList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060167FC RID: 92156 RVA: 0x00345DB3 File Offset: 0x00343FB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060167FD RID: 92157 RVA: 0x00345DBC File Offset: 0x00343FBC
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
					this.dataList_.AddEntriesFrom(ref input, RoleFlyEquipNotify._repeated_dataList_codec);
				}
			}
		}

		// Token: 0x040086F6 RID: 34550
		private UnknownFieldSet _unknownFields;

		// Token: 0x040086F7 RID: 34551
		public const int DataListFieldNumber = 1;

		// Token: 0x040086F8 RID: 34552
		private static readonly FieldCodec<FlyEquipData> _repeated_dataList_codec = FieldCodec.ForMessage<FlyEquipData>(10U, FlyEquipData.Parser);

		// Token: 0x040086F9 RID: 34553
		private readonly RepeatedField<FlyEquipData> dataList_ = new RepeatedField<FlyEquipData>();
	}
}
