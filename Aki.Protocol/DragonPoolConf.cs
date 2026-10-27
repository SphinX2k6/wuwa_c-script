using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003FE RID: 1022
	public sealed class DragonPoolConf : IMessage<DragonPoolConf>, IMessage, IEquatable<DragonPoolConf>, IDeepCloneable<DragonPoolConf>, IBufferMessage
	{
		// Token: 0x060062BA RID: 25274 RVA: 0x000EDA14 File Offset: 0x000EBC14
		[NullableContext(1)]
		public static DragonPoolConf Create()
		{
			return new DragonPoolConf();
		}

		// Token: 0x17001267 RID: 4711
		// (get) Token: 0x060062BB RID: 25275 RVA: 0x000EDA1B File Offset: 0x000EBC1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001268 RID: 4712
		// (get) Token: 0x060062BC RID: 25276 RVA: 0x000EDA1E File Offset: 0x000EBC1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DragonPoolConf.Descriptor;
			}
		}

		// Token: 0x060062BD RID: 25277 RVA: 0x000EDA25 File Offset: 0x000EBC25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DragonPoolConf()
		{
		}

		// Token: 0x060062BE RID: 25278 RVA: 0x000EDA44 File Offset: 0x000EBC44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DragonPoolConf(DragonPoolConf other) : this()
		{
			this.dragonPoolId_ = other.dragonPoolId_;
			this.dropIds_ = other.dropIds_.Clone();
			this.dropItems_ = other.dropItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060062BF RID: 25279 RVA: 0x000EDA96 File Offset: 0x000EBC96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DragonPoolConf Clone()
		{
			return new DragonPoolConf(this);
		}

		// Token: 0x17001269 RID: 4713
		// (get) Token: 0x060062C0 RID: 25280 RVA: 0x000EDA9E File Offset: 0x000EBC9E
		// (set) Token: 0x060062C1 RID: 25281 RVA: 0x000EDAA6 File Offset: 0x000EBCA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DragonPoolId
		{
			get
			{
				return this.dragonPoolId_;
			}
			set
			{
				this.dragonPoolId_ = value;
			}
		}

		// Token: 0x1700126A RID: 4714
		// (get) Token: 0x060062C2 RID: 25282 RVA: 0x000EDAAF File Offset: 0x000EBCAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DropIds
		{
			get
			{
				return this.dropIds_;
			}
		}

		// Token: 0x1700126B RID: 4715
		// (get) Token: 0x060062C3 RID: 25283 RVA: 0x000EDAB7 File Offset: 0x000EBCB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ItemDict> DropItems
		{
			get
			{
				return this.dropItems_;
			}
		}

		// Token: 0x060062C4 RID: 25284 RVA: 0x000EDABF File Offset: 0x000EBCBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DragonPoolConf);
		}

		// Token: 0x060062C5 RID: 25285 RVA: 0x000EDAD0 File Offset: 0x000EBCD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DragonPoolConf other)
		{
			return other != null && (other == this || (this.DragonPoolId == other.DragonPoolId && this.dropIds_.Equals(other.dropIds_) && this.dropItems_.Equals(other.dropItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060062C6 RID: 25286 RVA: 0x000EDB34 File Offset: 0x000EBD34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DragonPoolId != 0)
			{
				num ^= this.DragonPoolId.GetHashCode();
			}
			num ^= this.dropIds_.GetHashCode();
			num ^= this.dropItems_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060062C7 RID: 25287 RVA: 0x000EDB8F File Offset: 0x000EBD8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060062C8 RID: 25288 RVA: 0x000EDB9C File Offset: 0x000EBD9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060062C9 RID: 25289 RVA: 0x000EDBA8 File Offset: 0x000EBDA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DragonPoolId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DragonPoolId);
			}
			this.dropIds_.WriteTo(ref output, DragonPoolConf._repeated_dropIds_codec);
			this.dropItems_.WriteTo(ref output, DragonPoolConf._repeated_dropItems_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060062CA RID: 25290 RVA: 0x000EDC08 File Offset: 0x000EBE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DragonPoolId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DragonPoolId);
			}
			num += this.dropIds_.CalculateSize(DragonPoolConf._repeated_dropIds_codec);
			num += this.dropItems_.CalculateSize(DragonPoolConf._repeated_dropItems_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060062CB RID: 25291 RVA: 0x000EDC6C File Offset: 0x000EBE6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DragonPoolConf other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DragonPoolId != 0)
			{
				this.DragonPoolId = other.DragonPoolId;
			}
			this.dropIds_.Add(other.dropIds_);
			this.dropItems_.Add(other.dropItems_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060062CC RID: 25292 RVA: 0x000EDCCA File Offset: 0x000EBECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060062CD RID: 25293 RVA: 0x000EDCD4 File Offset: 0x000EBED4
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.DragonPoolId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						goto IL_45;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_45;
					}
					if (num == 26U)
					{
						this.dropItems_.AddEntriesFrom(ref input, DragonPoolConf._repeated_dropItems_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_45:
				this.dropIds_.AddEntriesFrom(ref input, DragonPoolConf._repeated_dropIds_codec);
			}
		}

		// Token: 0x040037ED RID: 14317
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037EE RID: 14318
		public const int DragonPoolIdFieldNumber = 1;

		// Token: 0x040037EF RID: 14319
		private int dragonPoolId_;

		// Token: 0x040037F0 RID: 14320
		public const int DropIdsFieldNumber = 2;

		// Token: 0x040037F1 RID: 14321
		private static readonly FieldCodec<int> _repeated_dropIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040037F2 RID: 14322
		private readonly RepeatedField<int> dropIds_ = new RepeatedField<int>();

		// Token: 0x040037F3 RID: 14323
		public const int DropItemsFieldNumber = 3;

		// Token: 0x040037F4 RID: 14324
		private static readonly FieldCodec<ItemDict> _repeated_dropItems_codec = FieldCodec.ForMessage<ItemDict>(26U, ItemDict.Parser);

		// Token: 0x040037F5 RID: 14325
		private readonly RepeatedField<ItemDict> dropItems_ = new RepeatedField<ItemDict>();
	}
}
