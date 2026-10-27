using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000397 RID: 919
	public sealed class DarkTideBagInfo : IMessage<DarkTideBagInfo>, IMessage, IEquatable<DarkTideBagInfo>, IDeepCloneable<DarkTideBagInfo>, IBufferMessage
	{
		// Token: 0x06005AA8 RID: 23208 RVA: 0x000DC929 File Offset: 0x000DAB29
		[NullableContext(1)]
		public static DarkTideBagInfo Create()
		{
			return new DarkTideBagInfo();
		}

		// Token: 0x170010C3 RID: 4291
		// (get) Token: 0x06005AA9 RID: 23209 RVA: 0x000DC930 File Offset: 0x000DAB30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DarkTideBagInfo> Parser
		{
			get
			{
				return DarkTideBagInfo._parser;
			}
		}

		// Token: 0x170010C4 RID: 4292
		// (get) Token: 0x06005AAA RID: 23210 RVA: 0x000DC937 File Offset: 0x000DAB37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010C5 RID: 4293
		// (get) Token: 0x06005AAB RID: 23211 RVA: 0x000DC93A File Offset: 0x000DAB3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkTideBagInfo.Descriptor;
			}
		}

		// Token: 0x06005AAC RID: 23212 RVA: 0x000DC941 File Offset: 0x000DAB41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideBagInfo()
		{
		}

		// Token: 0x06005AAD RID: 23213 RVA: 0x000DC954 File Offset: 0x000DAB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideBagInfo(DarkTideBagInfo other) : this()
		{
			this.type_ = other.type_;
			this.bag_ = other.bag_.Clone();
			this.selectedId_ = other.selectedId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005AAE RID: 23214 RVA: 0x000DC9A1 File Offset: 0x000DABA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideBagInfo Clone()
		{
			return new DarkTideBagInfo(this);
		}

		// Token: 0x170010C6 RID: 4294
		// (get) Token: 0x06005AAF RID: 23215 RVA: 0x000DC9A9 File Offset: 0x000DABA9
		// (set) Token: 0x06005AB0 RID: 23216 RVA: 0x000DC9B1 File Offset: 0x000DABB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideItemType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x170010C7 RID: 4295
		// (get) Token: 0x06005AB1 RID: 23217 RVA: 0x000DC9BA File Offset: 0x000DABBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DarkTideBagItemPb> Bag
		{
			get
			{
				return this.bag_;
			}
		}

		// Token: 0x170010C8 RID: 4296
		// (get) Token: 0x06005AB2 RID: 23218 RVA: 0x000DC9C2 File Offset: 0x000DABC2
		// (set) Token: 0x06005AB3 RID: 23219 RVA: 0x000DC9CA File Offset: 0x000DABCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SelectedId
		{
			get
			{
				return this.selectedId_;
			}
			set
			{
				this.selectedId_ = value;
			}
		}

		// Token: 0x06005AB4 RID: 23220 RVA: 0x000DC9D3 File Offset: 0x000DABD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkTideBagInfo);
		}

		// Token: 0x06005AB5 RID: 23221 RVA: 0x000DC9E4 File Offset: 0x000DABE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkTideBagInfo other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.bag_.Equals(other.bag_) && this.SelectedId == other.SelectedId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005AB6 RID: 23222 RVA: 0x000DCA44 File Offset: 0x000DAC44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != DarkTideItemType.DarkTideItemWeapon)
			{
				num ^= this.Type.GetHashCode();
			}
			num ^= this.bag_.GetHashCode();
			if (this.SelectedId != 0)
			{
				num ^= this.SelectedId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005AB7 RID: 23223 RVA: 0x000DCAB0 File Offset: 0x000DACB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005AB8 RID: 23224 RVA: 0x000DCABD File Offset: 0x000DACBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005AB9 RID: 23225 RVA: 0x000DCAC8 File Offset: 0x000DACC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != DarkTideItemType.DarkTideItemWeapon)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Type);
			}
			this.bag_.WriteTo(ref output, DarkTideBagInfo._repeated_bag_codec);
			if (this.SelectedId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SelectedId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005ABA RID: 23226 RVA: 0x000DCB34 File Offset: 0x000DAD34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != DarkTideItemType.DarkTideItemWeapon)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			num += this.bag_.CalculateSize(DarkTideBagInfo._repeated_bag_codec);
			if (this.SelectedId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SelectedId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005ABB RID: 23227 RVA: 0x000DCBA0 File Offset: 0x000DADA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DarkTideBagInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != DarkTideItemType.DarkTideItemWeapon)
			{
				this.Type = other.Type;
			}
			this.bag_.Add(other.bag_);
			if (other.SelectedId != 0)
			{
				this.SelectedId = other.SelectedId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005ABC RID: 23228 RVA: 0x000DCC01 File Offset: 0x000DAE01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005ABD RID: 23229 RVA: 0x000DCC0C File Offset: 0x000DAE0C
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SelectedId = input.ReadInt32();
						}
					}
					else
					{
						this.bag_.AddEntriesFrom(ref input, DarkTideBagInfo._repeated_bag_codec);
					}
				}
				else
				{
					this.Type = (DarkTideItemType)input.ReadEnum();
				}
			}
		}

		// Token: 0x040035C7 RID: 13767
		private static readonly MessageParser<DarkTideBagInfo> _parser = new MessageParser<DarkTideBagInfo>(() => new DarkTideBagInfo());

		// Token: 0x040035C8 RID: 13768
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035C9 RID: 13769
		public const int TypeFieldNumber = 1;

		// Token: 0x040035CA RID: 13770
		private DarkTideItemType type_;

		// Token: 0x040035CB RID: 13771
		public const int BagFieldNumber = 2;

		// Token: 0x040035CC RID: 13772
		private static readonly FieldCodec<DarkTideBagItemPb> _repeated_bag_codec = FieldCodec.ForMessage<DarkTideBagItemPb>(18U, DarkTideBagItemPb.Parser);

		// Token: 0x040035CD RID: 13773
		private readonly RepeatedField<DarkTideBagItemPb> bag_ = new RepeatedField<DarkTideBagItemPb>();

		// Token: 0x040035CE RID: 13774
		public const int SelectedIdFieldNumber = 3;

		// Token: 0x040035CF RID: 13775
		private int selectedId_;
	}
}
