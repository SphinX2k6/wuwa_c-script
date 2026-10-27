using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200107D RID: 4221
	[NetMessage(EMessageId.RoleFlyEquipNotify)]
	public sealed class RoleFlyEquipNotify : IMessage<RoleFlyEquipNotify>, IMessage, IEquatable<RoleFlyEquipNotify>, IDeepCloneable<RoleFlyEquipNotify>, IBufferMessage
	{
		// Token: 0x060168D2 RID: 92370 RVA: 0x00347311 File Offset: 0x00345511
		[NullableContext(1)]
		public static RoleFlyEquipNotify Create()
		{
			return new RoleFlyEquipNotify();
		}

		// Token: 0x17004B81 RID: 19329
		// (get) Token: 0x060168D3 RID: 92371 RVA: 0x00347318 File Offset: 0x00345518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B82 RID: 19330
		// (get) Token: 0x060168D4 RID: 92372 RVA: 0x0034731B File Offset: 0x0034551B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFlyEquipNotify.Descriptor;
			}
		}

		// Token: 0x060168D5 RID: 92373 RVA: 0x00347322 File Offset: 0x00345522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFlyEquipNotify()
		{
		}

		// Token: 0x060168D6 RID: 92374 RVA: 0x00347335 File Offset: 0x00345535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFlyEquipNotify(RoleFlyEquipNotify other) : this()
		{
			this.dataList_ = other.dataList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060168D7 RID: 92375 RVA: 0x0034735F File Offset: 0x0034555F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFlyEquipNotify Clone()
		{
			return new RoleFlyEquipNotify(this);
		}

		// Token: 0x17004B83 RID: 19331
		// (get) Token: 0x060168D8 RID: 92376 RVA: 0x00347367 File Offset: 0x00345567
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FlyEquipData> DataList
		{
			get
			{
				return this.dataList_;
			}
		}

		// Token: 0x060168D9 RID: 92377 RVA: 0x0034736F File Offset: 0x0034556F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFlyEquipNotify);
		}

		// Token: 0x060168DA RID: 92378 RVA: 0x0034737D File Offset: 0x0034557D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFlyEquipNotify other)
		{
			return other != null && (other == this || (this.dataList_.Equals(other.dataList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060168DB RID: 92379 RVA: 0x003473B0 File Offset: 0x003455B0
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

		// Token: 0x060168DC RID: 92380 RVA: 0x003473E4 File Offset: 0x003455E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060168DD RID: 92381 RVA: 0x003473F1 File Offset: 0x003455F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060168DE RID: 92382 RVA: 0x003473FA File Offset: 0x003455FA
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

		// Token: 0x060168DF RID: 92383 RVA: 0x00347424 File Offset: 0x00345624
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

		// Token: 0x060168E0 RID: 92384 RVA: 0x0034745D File Offset: 0x0034565D
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

		// Token: 0x060168E1 RID: 92385 RVA: 0x0034748B File Offset: 0x0034568B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060168E2 RID: 92386 RVA: 0x00347494 File Offset: 0x00345694
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.dataList_.AddEntriesFrom(ref input, RoleFlyEquipNotify._repeated_dataList_codec);
				}
			}
		}

		// Token: 0x040086CC RID: 34508
		private UnknownFieldSet _unknownFields;

		// Token: 0x040086CD RID: 34509
		public const int DataListFieldNumber = 11;

		// Token: 0x040086CE RID: 34510
		private static readonly FieldCodec<FlyEquipData> _repeated_dataList_codec = FieldCodec.ForMessage<FlyEquipData>(90U, FlyEquipData.Parser);

		// Token: 0x040086CF RID: 34511
		private readonly RepeatedField<FlyEquipData> dataList_ = new RepeatedField<FlyEquipData>();
	}
}
