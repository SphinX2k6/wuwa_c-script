using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000C2 RID: 194
	public sealed class AdventureRewardData : IMessage<AdventureRewardData>, IMessage, IEquatable<AdventureRewardData>, IDeepCloneable<AdventureRewardData>, IBufferMessage
	{
		// Token: 0x06001F25 RID: 7973 RVA: 0x00055166 File Offset: 0x00053366
		[NullableContext(1)]
		public static AdventureRewardData Create()
		{
			return new AdventureRewardData();
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06001F26 RID: 7974 RVA: 0x0005516D File Offset: 0x0005336D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AdventureRewardData> Parser
		{
			get
			{
				return AdventureRewardData._parser;
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06001F27 RID: 7975 RVA: 0x00055174 File Offset: 0x00053374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06001F28 RID: 7976 RVA: 0x00055177 File Offset: 0x00053377
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdventureRewardData.Descriptor;
			}
		}

		// Token: 0x06001F29 RID: 7977 RVA: 0x0005517E File Offset: 0x0005337E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureRewardData()
		{
		}

		// Token: 0x06001F2A RID: 7978 RVA: 0x00055191 File Offset: 0x00053391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureRewardData(AdventureRewardData other) : this()
		{
			this.dropId_ = other.dropId_;
			this.items_ = other.items_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001F2B RID: 7979 RVA: 0x000551C7 File Offset: 0x000533C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureRewardData Clone()
		{
			return new AdventureRewardData(this);
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06001F2C RID: 7980 RVA: 0x000551CF File Offset: 0x000533CF
		// (set) Token: 0x06001F2D RID: 7981 RVA: 0x000551D7 File Offset: 0x000533D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DropId
		{
			get
			{
				return this.dropId_;
			}
			set
			{
				this.dropId_ = value;
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06001F2E RID: 7982 RVA: 0x000551E0 File Offset: 0x000533E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AdventureItemData> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x000551E8 File Offset: 0x000533E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdventureRewardData);
		}

		// Token: 0x06001F30 RID: 7984 RVA: 0x000551F8 File Offset: 0x000533F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdventureRewardData other)
		{
			return other != null && (other == this || (this.DropId == other.DropId && this.items_.Equals(other.items_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001F31 RID: 7985 RVA: 0x00055248 File Offset: 0x00053448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DropId != 0)
			{
				num ^= this.DropId.GetHashCode();
			}
			num ^= this.items_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001F32 RID: 7986 RVA: 0x00055295 File Offset: 0x00053495
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001F33 RID: 7987 RVA: 0x000552A2 File Offset: 0x000534A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001F34 RID: 7988 RVA: 0x000552AC File Offset: 0x000534AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DropId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DropId);
			}
			this.items_.WriteTo(ref output, AdventureRewardData._repeated_items_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001F35 RID: 7989 RVA: 0x000552FC File Offset: 0x000534FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DropId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DropId);
			}
			num += this.items_.CalculateSize(AdventureRewardData._repeated_items_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001F36 RID: 7990 RVA: 0x00055350 File Offset: 0x00053550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdventureRewardData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DropId != 0)
			{
				this.DropId = other.DropId;
			}
			this.items_.Add(other.items_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001F37 RID: 7991 RVA: 0x0005539D File Offset: 0x0005359D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001F38 RID: 7992 RVA: 0x000553A8 File Offset: 0x000535A8
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.items_.AddEntriesFrom(ref input, AdventureRewardData._repeated_items_codec);
					}
				}
				else
				{
					this.DropId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040023F6 RID: 9206
		private static readonly MessageParser<AdventureRewardData> _parser = new MessageParser<AdventureRewardData>(() => new AdventureRewardData());

		// Token: 0x040023F7 RID: 9207
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023F8 RID: 9208
		public const int DropIdFieldNumber = 1;

		// Token: 0x040023F9 RID: 9209
		private int dropId_;

		// Token: 0x040023FA RID: 9210
		public const int ItemsFieldNumber = 2;

		// Token: 0x040023FB RID: 9211
		private static readonly FieldCodec<AdventureItemData> _repeated_items_codec = FieldCodec.ForMessage<AdventureItemData>(18U, AdventureItemData.Parser);

		// Token: 0x040023FC RID: 9212
		private readonly RepeatedField<AdventureItemData> items_ = new RepeatedField<AdventureItemData>();
	}
}
