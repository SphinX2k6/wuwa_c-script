using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200126A RID: 4714
	public sealed class SingleGachaAwardPb : IMessage<SingleGachaAwardPb>, IMessage, IEquatable<SingleGachaAwardPb>, IDeepCloneable<SingleGachaAwardPb>, IBufferMessage
	{
		// Token: 0x060192B1 RID: 103089 RVA: 0x003ABD46 File Offset: 0x003A9F46
		[NullableContext(1)]
		public static SingleGachaAwardPb Create()
		{
			return new SingleGachaAwardPb();
		}

		// Token: 0x17005517 RID: 21783
		// (get) Token: 0x060192B2 RID: 103090 RVA: 0x003ABD4D File Offset: 0x003A9F4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SingleGachaAwardPb> Parser
		{
			get
			{
				return SingleGachaAwardPb._parser;
			}
		}

		// Token: 0x17005518 RID: 21784
		// (get) Token: 0x060192B3 RID: 103091 RVA: 0x003ABD54 File Offset: 0x003A9F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005519 RID: 21785
		// (get) Token: 0x060192B4 RID: 103092 RVA: 0x003ABD57 File Offset: 0x003A9F57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SingleGachaAwardPb.Descriptor;
			}
		}

		// Token: 0x060192B5 RID: 103093 RVA: 0x003ABD5E File Offset: 0x003A9F5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SingleGachaAwardPb()
		{
		}

		// Token: 0x060192B6 RID: 103094 RVA: 0x003ABD74 File Offset: 0x003A9F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SingleGachaAwardPb(SingleGachaAwardPb other) : this()
		{
			this.groupId_ = other.groupId_;
			this.times_ = other.times_;
			this.itemMap_ = other.itemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060192B7 RID: 103095 RVA: 0x003ABDC1 File Offset: 0x003A9FC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SingleGachaAwardPb Clone()
		{
			return new SingleGachaAwardPb(this);
		}

		// Token: 0x1700551A RID: 21786
		// (get) Token: 0x060192B8 RID: 103096 RVA: 0x003ABDC9 File Offset: 0x003A9FC9
		// (set) Token: 0x060192B9 RID: 103097 RVA: 0x003ABDD1 File Offset: 0x003A9FD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x1700551B RID: 21787
		// (get) Token: 0x060192BA RID: 103098 RVA: 0x003ABDDA File Offset: 0x003A9FDA
		// (set) Token: 0x060192BB RID: 103099 RVA: 0x003ABDE2 File Offset: 0x003A9FE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Times
		{
			get
			{
				return this.times_;
			}
			set
			{
				this.times_ = value;
			}
		}

		// Token: 0x1700551C RID: 21788
		// (get) Token: 0x060192BC RID: 103100 RVA: 0x003ABDEB File Offset: 0x003A9FEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x060192BD RID: 103101 RVA: 0x003ABDF3 File Offset: 0x003A9FF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SingleGachaAwardPb);
		}

		// Token: 0x060192BE RID: 103102 RVA: 0x003ABE04 File Offset: 0x003AA004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SingleGachaAwardPb other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && this.Times == other.Times && this.ItemMap.Equals(other.ItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060192BF RID: 103103 RVA: 0x003ABE64 File Offset: 0x003AA064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupId != 0)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.Times != 0)
			{
				num ^= this.Times.GetHashCode();
			}
			num ^= this.ItemMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060192C0 RID: 103104 RVA: 0x003ABECA File Offset: 0x003AA0CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060192C1 RID: 103105 RVA: 0x003ABED7 File Offset: 0x003AA0D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060192C2 RID: 103106 RVA: 0x003ABEE0 File Offset: 0x003AA0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GroupId);
			}
			if (this.Times != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Times);
			}
			this.itemMap_.WriteTo(ref output, SingleGachaAwardPb._map_itemMap_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060192C3 RID: 103107 RVA: 0x003ABF4C File Offset: 0x003AA14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GroupId);
			}
			if (this.Times != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Times);
			}
			num += this.itemMap_.CalculateSize(SingleGachaAwardPb._map_itemMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060192C4 RID: 103108 RVA: 0x003ABFB8 File Offset: 0x003AA1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SingleGachaAwardPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupId != 0)
			{
				this.GroupId = other.GroupId;
			}
			if (other.Times != 0)
			{
				this.Times = other.Times;
			}
			this.itemMap_.MergeFrom(other.itemMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060192C5 RID: 103109 RVA: 0x003AC019 File Offset: 0x003AA219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060192C6 RID: 103110 RVA: 0x003AC024 File Offset: 0x003AA224
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
					if (num != 16U)
					{
						if (num != 42U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.itemMap_.AddEntriesFrom(ref input, SingleGachaAwardPb._map_itemMap_codec);
						}
					}
					else
					{
						this.Times = input.ReadInt32();
					}
				}
				else
				{
					this.GroupId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009504 RID: 38148
		private static readonly MessageParser<SingleGachaAwardPb> _parser = new MessageParser<SingleGachaAwardPb>(() => new SingleGachaAwardPb());

		// Token: 0x04009505 RID: 38149
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009506 RID: 38150
		public const int GroupIdFieldNumber = 1;

		// Token: 0x04009507 RID: 38151
		private int groupId_;

		// Token: 0x04009508 RID: 38152
		public const int TimesFieldNumber = 2;

		// Token: 0x04009509 RID: 38153
		private int times_;

		// Token: 0x0400950A RID: 38154
		public const int ItemMapFieldNumber = 5;

		// Token: 0x0400950B RID: 38155
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 42U);

		// Token: 0x0400950C RID: 38156
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();
	}
}
