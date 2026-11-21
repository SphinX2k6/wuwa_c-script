using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014A1 RID: 5281
	[NetMessage(EMessageId.TrapDefenseItemUpdateNotify)]
	public sealed class TrapDefenseItemUpdateNotify : IMessage<TrapDefenseItemUpdateNotify>, IMessage, IEquatable<TrapDefenseItemUpdateNotify>, IDeepCloneable<TrapDefenseItemUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601C07E RID: 114814 RVA: 0x004120B6 File Offset: 0x004102B6
		[NullableContext(1)]
		public static TrapDefenseItemUpdateNotify Create()
		{
			return new TrapDefenseItemUpdateNotify();
		}

		// Token: 0x17005EE3 RID: 24291
		// (get) Token: 0x0601C07F RID: 114815 RVA: 0x004120BD File Offset: 0x004102BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EE4 RID: 24292
		// (get) Token: 0x0601C080 RID: 114816 RVA: 0x004120C0 File Offset: 0x004102C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseItemUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601C081 RID: 114817 RVA: 0x004120C7 File Offset: 0x004102C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseItemUpdateNotify()
		{
		}

		// Token: 0x0601C082 RID: 114818 RVA: 0x004120DA File Offset: 0x004102DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseItemUpdateNotify(TrapDefenseItemUpdateNotify other) : this()
		{
			this.itemDatas_ = other.itemDatas_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C083 RID: 114819 RVA: 0x00412104 File Offset: 0x00410304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseItemUpdateNotify Clone()
		{
			return new TrapDefenseItemUpdateNotify(this);
		}

		// Token: 0x17005EE5 RID: 24293
		// (get) Token: 0x0601C084 RID: 114820 RVA: 0x0041210C File Offset: 0x0041030C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseItemPbData> ItemDatas
		{
			get
			{
				return this.itemDatas_;
			}
		}

		// Token: 0x0601C085 RID: 114821 RVA: 0x00412114 File Offset: 0x00410314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseItemUpdateNotify);
		}

		// Token: 0x0601C086 RID: 114822 RVA: 0x00412122 File Offset: 0x00410322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseItemUpdateNotify other)
		{
			return other != null && (other == this || (this.itemDatas_.Equals(other.itemDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C087 RID: 114823 RVA: 0x00412158 File Offset: 0x00410358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.itemDatas_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C088 RID: 114824 RVA: 0x0041218C File Offset: 0x0041038C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C089 RID: 114825 RVA: 0x00412199 File Offset: 0x00410399
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C08A RID: 114826 RVA: 0x004121A2 File Offset: 0x004103A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemDatas_.WriteTo(ref output, TrapDefenseItemUpdateNotify._repeated_itemDatas_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C08B RID: 114827 RVA: 0x004121CC File Offset: 0x004103CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.itemDatas_.CalculateSize(TrapDefenseItemUpdateNotify._repeated_itemDatas_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C08C RID: 114828 RVA: 0x00412205 File Offset: 0x00410405
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseItemUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.itemDatas_.Add(other.itemDatas_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C08D RID: 114829 RVA: 0x00412233 File Offset: 0x00410433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C08E RID: 114830 RVA: 0x0041223C File Offset: 0x0041043C
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
					this.itemDatas_.AddEntriesFrom(ref input, TrapDefenseItemUpdateNotify._repeated_itemDatas_codec);
				}
			}
		}

		// Token: 0x0400A256 RID: 41558
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A257 RID: 41559
		public const int ItemDatasFieldNumber = 1;

		// Token: 0x0400A258 RID: 41560
		private static readonly FieldCodec<TrapDefenseItemPbData> _repeated_itemDatas_codec = FieldCodec.ForMessage<TrapDefenseItemPbData>(10U, TrapDefenseItemPbData.Parser);

		// Token: 0x0400A259 RID: 41561
		private readonly RepeatedField<TrapDefenseItemPbData> itemDatas_ = new RepeatedField<TrapDefenseItemPbData>();
	}
}
