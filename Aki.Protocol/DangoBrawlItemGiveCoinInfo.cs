using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000367 RID: 871
	public sealed class DangoBrawlItemGiveCoinInfo : IMessage<DangoBrawlItemGiveCoinInfo>, IMessage, IEquatable<DangoBrawlItemGiveCoinInfo>, IDeepCloneable<DangoBrawlItemGiveCoinInfo>, IBufferMessage
	{
		// Token: 0x0600570F RID: 22287 RVA: 0x000D4F87 File Offset: 0x000D3187
		[NullableContext(1)]
		public static DangoBrawlItemGiveCoinInfo Create()
		{
			return new DangoBrawlItemGiveCoinInfo();
		}

		// Token: 0x17000FFD RID: 4093
		// (get) Token: 0x06005710 RID: 22288 RVA: 0x000D4F8E File Offset: 0x000D318E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DangoBrawlItemGiveCoinInfo> Parser
		{
			get
			{
				return DangoBrawlItemGiveCoinInfo._parser;
			}
		}

		// Token: 0x17000FFE RID: 4094
		// (get) Token: 0x06005711 RID: 22289 RVA: 0x000D4F95 File Offset: 0x000D3195
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FFF RID: 4095
		// (get) Token: 0x06005712 RID: 22290 RVA: 0x000D4F98 File Offset: 0x000D3198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlItemGiveCoinInfo.Descriptor;
			}
		}

		// Token: 0x06005713 RID: 22291 RVA: 0x000D4F9F File Offset: 0x000D319F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlItemGiveCoinInfo()
		{
		}

		// Token: 0x06005714 RID: 22292 RVA: 0x000D4FA7 File Offset: 0x000D31A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlItemGiveCoinInfo(DangoBrawlItemGiveCoinInfo other) : this()
		{
			this.itemUId_ = other.itemUId_;
			this.delta_ = other.delta_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005715 RID: 22293 RVA: 0x000D4FD8 File Offset: 0x000D31D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlItemGiveCoinInfo Clone()
		{
			return new DangoBrawlItemGiveCoinInfo(this);
		}

		// Token: 0x17001000 RID: 4096
		// (get) Token: 0x06005716 RID: 22294 RVA: 0x000D4FE0 File Offset: 0x000D31E0
		// (set) Token: 0x06005717 RID: 22295 RVA: 0x000D4FE8 File Offset: 0x000D31E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemUId
		{
			get
			{
				return this.itemUId_;
			}
			set
			{
				this.itemUId_ = value;
			}
		}

		// Token: 0x17001001 RID: 4097
		// (get) Token: 0x06005718 RID: 22296 RVA: 0x000D4FF1 File Offset: 0x000D31F1
		// (set) Token: 0x06005719 RID: 22297 RVA: 0x000D4FF9 File Offset: 0x000D31F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Delta
		{
			get
			{
				return this.delta_;
			}
			set
			{
				this.delta_ = value;
			}
		}

		// Token: 0x0600571A RID: 22298 RVA: 0x000D5002 File Offset: 0x000D3202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlItemGiveCoinInfo);
		}

		// Token: 0x0600571B RID: 22299 RVA: 0x000D5010 File Offset: 0x000D3210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlItemGiveCoinInfo other)
		{
			return other != null && (other == this || (this.ItemUId == other.ItemUId && this.Delta == other.Delta && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600571C RID: 22300 RVA: 0x000D5050 File Offset: 0x000D3250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemUId != 0)
			{
				num ^= this.ItemUId.GetHashCode();
			}
			if (this.Delta != 0)
			{
				num ^= this.Delta.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600571D RID: 22301 RVA: 0x000D50A8 File Offset: 0x000D32A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600571E RID: 22302 RVA: 0x000D50B5 File Offset: 0x000D32B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600571F RID: 22303 RVA: 0x000D50C0 File Offset: 0x000D32C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemUId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemUId);
			}
			if (this.Delta != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Delta);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005720 RID: 22304 RVA: 0x000D5118 File Offset: 0x000D3318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemUId);
			}
			if (this.Delta != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Delta);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005721 RID: 22305 RVA: 0x000D5170 File Offset: 0x000D3370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlItemGiveCoinInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemUId != 0)
			{
				this.ItemUId = other.ItemUId;
			}
			if (other.Delta != 0)
			{
				this.Delta = other.Delta;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005722 RID: 22306 RVA: 0x000D51C0 File Offset: 0x000D33C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005723 RID: 22307 RVA: 0x000D51CC File Offset: 0x000D33CC
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Delta = input.ReadInt32();
					}
				}
				else
				{
					this.ItemUId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003503 RID: 13571
		private static readonly MessageParser<DangoBrawlItemGiveCoinInfo> _parser = new MessageParser<DangoBrawlItemGiveCoinInfo>(() => new DangoBrawlItemGiveCoinInfo());

		// Token: 0x04003504 RID: 13572
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003505 RID: 13573
		public const int ItemUIdFieldNumber = 1;

		// Token: 0x04003506 RID: 13574
		private int itemUId_;

		// Token: 0x04003507 RID: 13575
		public const int DeltaFieldNumber = 2;

		// Token: 0x04003508 RID: 13576
		private int delta_;
	}
}
