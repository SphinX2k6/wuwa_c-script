using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200076F RID: 1903
	public sealed class HonamiStoryItemUidInfo : IMessage<HonamiStoryItemUidInfo>, IMessage, IEquatable<HonamiStoryItemUidInfo>, IDeepCloneable<HonamiStoryItemUidInfo>, IBufferMessage
	{
		// Token: 0x0600AC6E RID: 44142 RVA: 0x0019F223 File Offset: 0x0019D423
		[NullableContext(1)]
		public static HonamiStoryItemUidInfo Create()
		{
			return new HonamiStoryItemUidInfo();
		}

		// Token: 0x170022C6 RID: 8902
		// (get) Token: 0x0600AC6F RID: 44143 RVA: 0x0019F22A File Offset: 0x0019D42A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HonamiStoryItemUidInfo> Parser
		{
			get
			{
				return HonamiStoryItemUidInfo._parser;
			}
		}

		// Token: 0x170022C7 RID: 8903
		// (get) Token: 0x0600AC70 RID: 44144 RVA: 0x0019F231 File Offset: 0x0019D431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022C8 RID: 8904
		// (get) Token: 0x0600AC71 RID: 44145 RVA: 0x0019F234 File Offset: 0x0019D434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryItemUidInfo.Descriptor;
			}
		}

		// Token: 0x0600AC72 RID: 44146 RVA: 0x0019F23B File Offset: 0x0019D43B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemUidInfo()
		{
		}

		// Token: 0x0600AC73 RID: 44147 RVA: 0x0019F24E File Offset: 0x0019D44E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemUidInfo(HonamiStoryItemUidInfo other) : this()
		{
			this.itemUId_ = other.itemUId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AC74 RID: 44148 RVA: 0x0019F278 File Offset: 0x0019D478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemUidInfo Clone()
		{
			return new HonamiStoryItemUidInfo(this);
		}

		// Token: 0x170022C9 RID: 8905
		// (get) Token: 0x0600AC75 RID: 44149 RVA: 0x0019F280 File Offset: 0x0019D480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ItemUId
		{
			get
			{
				return this.itemUId_;
			}
		}

		// Token: 0x0600AC76 RID: 44150 RVA: 0x0019F288 File Offset: 0x0019D488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryItemUidInfo);
		}

		// Token: 0x0600AC77 RID: 44151 RVA: 0x0019F296 File Offset: 0x0019D496
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryItemUidInfo other)
		{
			return other != null && (other == this || (this.itemUId_.Equals(other.itemUId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AC78 RID: 44152 RVA: 0x0019F2CC File Offset: 0x0019D4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.itemUId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AC79 RID: 44153 RVA: 0x0019F300 File Offset: 0x0019D500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AC7A RID: 44154 RVA: 0x0019F30D File Offset: 0x0019D50D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AC7B RID: 44155 RVA: 0x0019F316 File Offset: 0x0019D516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemUId_.WriteTo(ref output, HonamiStoryItemUidInfo._repeated_itemUId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AC7C RID: 44156 RVA: 0x0019F340 File Offset: 0x0019D540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.itemUId_.CalculateSize(HonamiStoryItemUidInfo._repeated_itemUId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AC7D RID: 44157 RVA: 0x0019F379 File Offset: 0x0019D579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryItemUidInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.itemUId_.Add(other.itemUId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AC7E RID: 44158 RVA: 0x0019F3A7 File Offset: 0x0019D5A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AC7F RID: 44159 RVA: 0x0019F3B0 File Offset: 0x0019D5B0
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
				if (num != 16U && num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.itemUId_.AddEntriesFrom(ref input, HonamiStoryItemUidInfo._repeated_itemUId_codec);
				}
			}
		}

		// Token: 0x04004E88 RID: 20104
		private static readonly MessageParser<HonamiStoryItemUidInfo> _parser = new MessageParser<HonamiStoryItemUidInfo>(() => new HonamiStoryItemUidInfo());

		// Token: 0x04004E89 RID: 20105
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E8A RID: 20106
		public const int ItemUIdFieldNumber = 2;

		// Token: 0x04004E8B RID: 20107
		private static readonly FieldCodec<int> _repeated_itemUId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04004E8C RID: 20108
		private readonly RepeatedField<int> itemUId_ = new RepeatedField<int>();
	}
}
