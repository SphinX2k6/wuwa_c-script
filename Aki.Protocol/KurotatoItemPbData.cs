using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200089B RID: 2203
	public sealed class KurotatoItemPbData : IMessage<KurotatoItemPbData>, IMessage, IEquatable<KurotatoItemPbData>, IDeepCloneable<KurotatoItemPbData>, IBufferMessage
	{
		// Token: 0x0600C3C6 RID: 50118 RVA: 0x001D0611 File Offset: 0x001CE811
		[NullableContext(1)]
		public static KurotatoItemPbData Create()
		{
			return new KurotatoItemPbData();
		}

		// Token: 0x17002792 RID: 10130
		// (get) Token: 0x0600C3C7 RID: 50119 RVA: 0x001D0618 File Offset: 0x001CE818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KurotatoItemPbData> Parser
		{
			get
			{
				return KurotatoItemPbData._parser;
			}
		}

		// Token: 0x17002793 RID: 10131
		// (get) Token: 0x0600C3C8 RID: 50120 RVA: 0x001D061F File Offset: 0x001CE81F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002794 RID: 10132
		// (get) Token: 0x0600C3C9 RID: 50121 RVA: 0x001D0622 File Offset: 0x001CE822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoItemPbData.Descriptor;
			}
		}

		// Token: 0x0600C3CA RID: 50122 RVA: 0x001D0629 File Offset: 0x001CE829
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemPbData()
		{
		}

		// Token: 0x0600C3CB RID: 50123 RVA: 0x001D0631 File Offset: 0x001CE831
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemPbData(KurotatoItemPbData other) : this()
		{
			this.itemId_ = other.itemId_;
			this.count_ = other.count_;
			this.preWaveDealtDamage_ = other.preWaveDealtDamage_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C3CC RID: 50124 RVA: 0x001D066E File Offset: 0x001CE86E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemPbData Clone()
		{
			return new KurotatoItemPbData(this);
		}

		// Token: 0x17002795 RID: 10133
		// (get) Token: 0x0600C3CD RID: 50125 RVA: 0x001D0676 File Offset: 0x001CE876
		// (set) Token: 0x0600C3CE RID: 50126 RVA: 0x001D067E File Offset: 0x001CE87E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17002796 RID: 10134
		// (get) Token: 0x0600C3CF RID: 50127 RVA: 0x001D0687 File Offset: 0x001CE887
		// (set) Token: 0x0600C3D0 RID: 50128 RVA: 0x001D068F File Offset: 0x001CE88F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x17002797 RID: 10135
		// (get) Token: 0x0600C3D1 RID: 50129 RVA: 0x001D0698 File Offset: 0x001CE898
		// (set) Token: 0x0600C3D2 RID: 50130 RVA: 0x001D06A0 File Offset: 0x001CE8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PreWaveDealtDamage
		{
			get
			{
				return this.preWaveDealtDamage_;
			}
			set
			{
				this.preWaveDealtDamage_ = value;
			}
		}

		// Token: 0x0600C3D3 RID: 50131 RVA: 0x001D06A9 File Offset: 0x001CE8A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoItemPbData);
		}

		// Token: 0x0600C3D4 RID: 50132 RVA: 0x001D06B8 File Offset: 0x001CE8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoItemPbData other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Count == other.Count && this.PreWaveDealtDamage == other.PreWaveDealtDamage && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C3D5 RID: 50133 RVA: 0x001D0714 File Offset: 0x001CE914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this.PreWaveDealtDamage != 0)
			{
				num ^= this.PreWaveDealtDamage.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C3D6 RID: 50134 RVA: 0x001D0785 File Offset: 0x001CE985
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C3D7 RID: 50135 RVA: 0x001D0792 File Offset: 0x001CE992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C3D8 RID: 50136 RVA: 0x001D079C File Offset: 0x001CE99C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this.PreWaveDealtDamage != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PreWaveDealtDamage);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C3D9 RID: 50137 RVA: 0x001D0810 File Offset: 0x001CEA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this.PreWaveDealtDamage != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PreWaveDealtDamage);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C3DA RID: 50138 RVA: 0x001D0880 File Offset: 0x001CEA80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoItemPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			if (other.PreWaveDealtDamage != 0)
			{
				this.PreWaveDealtDamage = other.PreWaveDealtDamage;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C3DB RID: 50139 RVA: 0x001D08E4 File Offset: 0x001CEAE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C3DC RID: 50140 RVA: 0x001D08F0 File Offset: 0x001CEAF0
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.PreWaveDealtDamage = input.ReadInt32();
						}
					}
					else
					{
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005488 RID: 21640
		private static readonly MessageParser<KurotatoItemPbData> _parser = new MessageParser<KurotatoItemPbData>(() => new KurotatoItemPbData());

		// Token: 0x04005489 RID: 21641
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400548A RID: 21642
		public const int ItemIdFieldNumber = 1;

		// Token: 0x0400548B RID: 21643
		private int itemId_;

		// Token: 0x0400548C RID: 21644
		public const int CountFieldNumber = 2;

		// Token: 0x0400548D RID: 21645
		private int count_;

		// Token: 0x0400548E RID: 21646
		public const int PreWaveDealtDamageFieldNumber = 3;

		// Token: 0x0400548F RID: 21647
		private int preWaveDealtDamage_;
	}
}
