using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000B3 RID: 179
	public sealed class AddTokenView : IMessage<AddTokenView>, IMessage, IEquatable<AddTokenView>, IDeepCloneable<AddTokenView>, IBufferMessage
	{
		// Token: 0x06001DB7 RID: 7607 RVA: 0x0005197C File Offset: 0x0004FB7C
		[NullableContext(1)]
		public static AddTokenView Create()
		{
			return new AddTokenView();
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06001DB8 RID: 7608 RVA: 0x00051983 File Offset: 0x0004FB83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06001DB9 RID: 7609 RVA: 0x00051986 File Offset: 0x0004FB86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddTokenView.Descriptor;
			}
		}

		// Token: 0x06001DBA RID: 7610 RVA: 0x0005198D File Offset: 0x0004FB8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTokenView()
		{
		}

		// Token: 0x06001DBB RID: 7611 RVA: 0x000519A0 File Offset: 0x0004FBA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTokenView(AddTokenView other) : this()
		{
			this.type_ = other.type_;
			this.rogueResGainDatas_ = other.rogueResGainDatas_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001DBC RID: 7612 RVA: 0x000519D6 File Offset: 0x0004FBD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTokenView Clone()
		{
			return new AddTokenView(this);
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06001DBD RID: 7613 RVA: 0x000519DE File Offset: 0x0004FBDE
		// (set) Token: 0x06001DBE RID: 7614 RVA: 0x000519E6 File Offset: 0x0004FBE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Type
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

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06001DBF RID: 7615 RVA: 0x000519EF File Offset: 0x0004FBEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueResGainData> RogueResGainDatas
		{
			get
			{
				return this.rogueResGainDatas_;
			}
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x000519F7 File Offset: 0x0004FBF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddTokenView);
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x00051A08 File Offset: 0x0004FC08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddTokenView other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.rogueResGainDatas_.Equals(other.rogueResGainDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x00051A58 File Offset: 0x0004FC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			num ^= this.rogueResGainDatas_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001DC3 RID: 7619 RVA: 0x00051AA5 File Offset: 0x0004FCA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x00051AB2 File Offset: 0x0004FCB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x00051ABC File Offset: 0x0004FCBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Type);
			}
			this.rogueResGainDatas_.WriteTo(ref output, AddTokenView._repeated_rogueResGainDatas_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x00051B0C File Offset: 0x0004FD0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			num += this.rogueResGainDatas_.CalculateSize(AddTokenView._repeated_rogueResGainDatas_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x00051B60 File Offset: 0x0004FD60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddTokenView other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != 0)
			{
				this.Type = other.Type;
			}
			this.rogueResGainDatas_.Add(other.rogueResGainDatas_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001DC8 RID: 7624 RVA: 0x00051BAD File Offset: 0x0004FDAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001DC9 RID: 7625 RVA: 0x00051BB8 File Offset: 0x0004FDB8
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
						this.rogueResGainDatas_.AddEntriesFrom(ref input, AddTokenView._repeated_rogueResGainDatas_codec);
					}
				}
				else
				{
					this.Type = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400232E RID: 9006
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400232F RID: 9007
		public const int TypeFieldNumber = 1;

		// Token: 0x04002330 RID: 9008
		private int type_;

		// Token: 0x04002331 RID: 9009
		public const int RogueResGainDatasFieldNumber = 2;

		// Token: 0x04002332 RID: 9010
		private static readonly FieldCodec<RogueResGainData> _repeated_rogueResGainDatas_codec = FieldCodec.ForMessage<RogueResGainData>(18U, RogueResGainData.Parser);

		// Token: 0x04002333 RID: 9011
		private readonly RepeatedField<RogueResGainData> rogueResGainDatas_ = new RepeatedField<RogueResGainData>();
	}
}
