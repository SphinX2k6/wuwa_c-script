using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003E7 RID: 999
	public sealed class DragonPoolConf : IMessage<DragonPoolConf>, IMessage, IEquatable<DragonPoolConf>, IDeepCloneable<DragonPoolConf>, IBufferMessage
	{
		// Token: 0x0600612A RID: 24874 RVA: 0x000EA89C File Offset: 0x000E8A9C
		[NullableContext(1)]
		public static DragonPoolConf Create()
		{
			return new DragonPoolConf();
		}

		// Token: 0x17001212 RID: 4626
		// (get) Token: 0x0600612B RID: 24875 RVA: 0x000EA8A3 File Offset: 0x000E8AA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001213 RID: 4627
		// (get) Token: 0x0600612C RID: 24876 RVA: 0x000EA8A6 File Offset: 0x000E8AA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DragonPoolConf.Descriptor;
			}
		}

		// Token: 0x0600612D RID: 24877 RVA: 0x000EA8AD File Offset: 0x000E8AAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DragonPoolConf()
		{
		}

		// Token: 0x0600612E RID: 24878 RVA: 0x000EA8CC File Offset: 0x000E8ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DragonPoolConf(DragonPoolConf other) : this()
		{
			this.dragonPoolId_ = other.dragonPoolId_;
			this.dropIds_ = other.dropIds_.Clone();
			this.dropItems_ = other.dropItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600612F RID: 24879 RVA: 0x000EA91E File Offset: 0x000E8B1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DragonPoolConf Clone()
		{
			return new DragonPoolConf(this);
		}

		// Token: 0x17001214 RID: 4628
		// (get) Token: 0x06006130 RID: 24880 RVA: 0x000EA926 File Offset: 0x000E8B26
		// (set) Token: 0x06006131 RID: 24881 RVA: 0x000EA92E File Offset: 0x000E8B2E
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

		// Token: 0x17001215 RID: 4629
		// (get) Token: 0x06006132 RID: 24882 RVA: 0x000EA937 File Offset: 0x000E8B37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DropIds
		{
			get
			{
				return this.dropIds_;
			}
		}

		// Token: 0x17001216 RID: 4630
		// (get) Token: 0x06006133 RID: 24883 RVA: 0x000EA93F File Offset: 0x000E8B3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ItemDict> DropItems
		{
			get
			{
				return this.dropItems_;
			}
		}

		// Token: 0x06006134 RID: 24884 RVA: 0x000EA947 File Offset: 0x000E8B47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DragonPoolConf);
		}

		// Token: 0x06006135 RID: 24885 RVA: 0x000EA958 File Offset: 0x000E8B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DragonPoolConf other)
		{
			return other != null && (other == this || (this.DragonPoolId == other.DragonPoolId && this.dropIds_.Equals(other.dropIds_) && this.dropItems_.Equals(other.dropItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006136 RID: 24886 RVA: 0x000EA9BC File Offset: 0x000E8BBC
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

		// Token: 0x06006137 RID: 24887 RVA: 0x000EAA17 File Offset: 0x000E8C17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006138 RID: 24888 RVA: 0x000EAA24 File Offset: 0x000E8C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006139 RID: 24889 RVA: 0x000EAA30 File Offset: 0x000E8C30
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

		// Token: 0x0600613A RID: 24890 RVA: 0x000EAA90 File Offset: 0x000E8C90
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

		// Token: 0x0600613B RID: 24891 RVA: 0x000EAAF4 File Offset: 0x000E8CF4
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

		// Token: 0x0600613C RID: 24892 RVA: 0x000EAB52 File Offset: 0x000E8D52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600613D RID: 24893 RVA: 0x000EAB5C File Offset: 0x000E8D5C
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

		// Token: 0x040037DA RID: 14298
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037DB RID: 14299
		public const int DragonPoolIdFieldNumber = 1;

		// Token: 0x040037DC RID: 14300
		private int dragonPoolId_;

		// Token: 0x040037DD RID: 14301
		public const int DropIdsFieldNumber = 2;

		// Token: 0x040037DE RID: 14302
		private static readonly FieldCodec<int> _repeated_dropIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040037DF RID: 14303
		private readonly RepeatedField<int> dropIds_ = new RepeatedField<int>();

		// Token: 0x040037E0 RID: 14304
		public const int DropItemsFieldNumber = 3;

		// Token: 0x040037E1 RID: 14305
		private static readonly FieldCodec<ItemDict> _repeated_dropItems_codec = FieldCodec.ForMessage<ItemDict>(26U, ItemDict.Parser);

		// Token: 0x040037E2 RID: 14306
		private readonly RepeatedField<ItemDict> dropItems_ = new RepeatedField<ItemDict>();
	}
}
