using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006C5 RID: 1733
	public sealed class GiantEcoInfoPb : IMessage<GiantEcoInfoPb>, IMessage, IEquatable<GiantEcoInfoPb>, IDeepCloneable<GiantEcoInfoPb>, IBufferMessage
	{
		// Token: 0x06009EB9 RID: 40633 RVA: 0x001810F3 File Offset: 0x0017F2F3
		[NullableContext(1)]
		public static GiantEcoInfoPb Create()
		{
			return new GiantEcoInfoPb();
		}

		// Token: 0x17001FDB RID: 8155
		// (get) Token: 0x06009EBA RID: 40634 RVA: 0x001810FA File Offset: 0x0017F2FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GiantEcoInfoPb> Parser
		{
			get
			{
				return GiantEcoInfoPb._parser;
			}
		}

		// Token: 0x17001FDC RID: 8156
		// (get) Token: 0x06009EBB RID: 40635 RVA: 0x00181101 File Offset: 0x0017F301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FDD RID: 8157
		// (get) Token: 0x06009EBC RID: 40636 RVA: 0x00181104 File Offset: 0x0017F304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantEcoInfoPb.Descriptor;
			}
		}

		// Token: 0x06009EBD RID: 40637 RVA: 0x0018110B File Offset: 0x0017F30B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantEcoInfoPb()
		{
		}

		// Token: 0x06009EBE RID: 40638 RVA: 0x00181114 File Offset: 0x0017F314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantEcoInfoPb(GiantEcoInfoPb other) : this()
		{
			this.giantEcoType_ = other.giantEcoType_;
			this.level_ = other.level_;
			this.stableValue_ = other.stableValue_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009EBF RID: 40639 RVA: 0x00181168 File Offset: 0x0017F368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantEcoInfoPb Clone()
		{
			return new GiantEcoInfoPb(this);
		}

		// Token: 0x17001FDE RID: 8158
		// (get) Token: 0x06009EC0 RID: 40640 RVA: 0x00181170 File Offset: 0x0017F370
		// (set) Token: 0x06009EC1 RID: 40641 RVA: 0x00181178 File Offset: 0x0017F378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantEcoNetType GiantEcoType
		{
			get
			{
				return this.giantEcoType_;
			}
			set
			{
				this.giantEcoType_ = value;
			}
		}

		// Token: 0x17001FDF RID: 8159
		// (get) Token: 0x06009EC2 RID: 40642 RVA: 0x00181181 File Offset: 0x0017F381
		// (set) Token: 0x06009EC3 RID: 40643 RVA: 0x00181189 File Offset: 0x0017F389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17001FE0 RID: 8160
		// (get) Token: 0x06009EC4 RID: 40644 RVA: 0x00181192 File Offset: 0x0017F392
		// (set) Token: 0x06009EC5 RID: 40645 RVA: 0x0018119A File Offset: 0x0017F39A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StableValue
		{
			get
			{
				return this.stableValue_;
			}
			set
			{
				this.stableValue_ = value;
			}
		}

		// Token: 0x17001FE1 RID: 8161
		// (get) Token: 0x06009EC6 RID: 40646 RVA: 0x001811A3 File Offset: 0x0017F3A3
		// (set) Token: 0x06009EC7 RID: 40647 RVA: 0x001811AB File Offset: 0x0017F3AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantEcoNetStatus Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x06009EC8 RID: 40648 RVA: 0x001811B4 File Offset: 0x0017F3B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantEcoInfoPb);
		}

		// Token: 0x06009EC9 RID: 40649 RVA: 0x001811C4 File Offset: 0x0017F3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantEcoInfoPb other)
		{
			return other != null && (other == this || (this.GiantEcoType == other.GiantEcoType && this.Level == other.Level && this.StableValue == other.StableValue && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009ECA RID: 40650 RVA: 0x00181230 File Offset: 0x0017F430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GiantEcoType != GiantEcoNetType.Fire)
			{
				num ^= this.GiantEcoType.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.StableValue != 0)
			{
				num ^= this.StableValue.GetHashCode();
			}
			if (this.Status != GiantEcoNetStatus.Lock)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009ECB RID: 40651 RVA: 0x001812C6 File Offset: 0x0017F4C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009ECC RID: 40652 RVA: 0x001812D3 File Offset: 0x0017F4D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009ECD RID: 40653 RVA: 0x001812DC File Offset: 0x0017F4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GiantEcoType != GiantEcoNetType.Fire)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.GiantEcoType);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Level);
			}
			if (this.StableValue != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.StableValue);
			}
			if (this.Status != GiantEcoNetStatus.Lock)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009ECE RID: 40654 RVA: 0x0018136C File Offset: 0x0017F56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GiantEcoType != GiantEcoNetType.Fire)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.GiantEcoType);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.StableValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StableValue);
			}
			if (this.Status != GiantEcoNetStatus.Lock)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009ECF RID: 40655 RVA: 0x001813F4 File Offset: 0x0017F5F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiantEcoInfoPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GiantEcoType != GiantEcoNetType.Fire)
			{
				this.GiantEcoType = other.GiantEcoType;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.StableValue != 0)
			{
				this.StableValue = other.StableValue;
			}
			if (other.Status != GiantEcoNetStatus.Lock)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009ED0 RID: 40656 RVA: 0x0018146C File Offset: 0x0017F66C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009ED1 RID: 40657 RVA: 0x00181478 File Offset: 0x0017F678
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
						this.GiantEcoType = (GiantEcoNetType)input.ReadEnum();
						continue;
					}
					if (num == 16U)
					{
						this.Level = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.StableValue = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Status = (GiantEcoNetStatus)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004A8E RID: 19086
		private static readonly MessageParser<GiantEcoInfoPb> _parser = new MessageParser<GiantEcoInfoPb>(() => new GiantEcoInfoPb());

		// Token: 0x04004A8F RID: 19087
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A90 RID: 19088
		public const int GiantEcoTypeFieldNumber = 1;

		// Token: 0x04004A91 RID: 19089
		private GiantEcoNetType giantEcoType_;

		// Token: 0x04004A92 RID: 19090
		public const int LevelFieldNumber = 2;

		// Token: 0x04004A93 RID: 19091
		private int level_;

		// Token: 0x04004A94 RID: 19092
		public const int StableValueFieldNumber = 3;

		// Token: 0x04004A95 RID: 19093
		private int stableValue_;

		// Token: 0x04004A96 RID: 19094
		public const int StatusFieldNumber = 4;

		// Token: 0x04004A97 RID: 19095
		private GiantEcoNetStatus status_;
	}
}
