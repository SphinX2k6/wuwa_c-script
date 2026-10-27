using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200142C RID: 5164
	public sealed class TrapDefenseGoldenCoinPbData : IMessage<TrapDefenseGoldenCoinPbData>, IMessage, IEquatable<TrapDefenseGoldenCoinPbData>, IDeepCloneable<TrapDefenseGoldenCoinPbData>, IBufferMessage
	{
		// Token: 0x0601B5C9 RID: 112073 RVA: 0x003F68A2 File Offset: 0x003F4AA2
		[NullableContext(1)]
		public static TrapDefenseGoldenCoinPbData Create()
		{
			return new TrapDefenseGoldenCoinPbData();
		}

		// Token: 0x17005C45 RID: 23621
		// (get) Token: 0x0601B5CA RID: 112074 RVA: 0x003F68A9 File Offset: 0x003F4AA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C46 RID: 23622
		// (get) Token: 0x0601B5CB RID: 112075 RVA: 0x003F68AC File Offset: 0x003F4AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseGoldenCoinPbData.Descriptor;
			}
		}

		// Token: 0x0601B5CC RID: 112076 RVA: 0x003F68B3 File Offset: 0x003F4AB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGoldenCoinPbData()
		{
		}

		// Token: 0x0601B5CD RID: 112077 RVA: 0x003F68BB File Offset: 0x003F4ABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGoldenCoinPbData(TrapDefenseGoldenCoinPbData other) : this()
		{
			this.configId_ = other.configId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B5CE RID: 112078 RVA: 0x003F68E0 File Offset: 0x003F4AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGoldenCoinPbData Clone()
		{
			return new TrapDefenseGoldenCoinPbData(this);
		}

		// Token: 0x17005C47 RID: 23623
		// (get) Token: 0x0601B5CF RID: 112079 RVA: 0x003F68E8 File Offset: 0x003F4AE8
		// (set) Token: 0x0601B5D0 RID: 112080 RVA: 0x003F68F0 File Offset: 0x003F4AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x0601B5D1 RID: 112081 RVA: 0x003F68F9 File Offset: 0x003F4AF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseGoldenCoinPbData);
		}

		// Token: 0x0601B5D2 RID: 112082 RVA: 0x003F6907 File Offset: 0x003F4B07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseGoldenCoinPbData other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B5D3 RID: 112083 RVA: 0x003F6938 File Offset: 0x003F4B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B5D4 RID: 112084 RVA: 0x003F6977 File Offset: 0x003F4B77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B5D5 RID: 112085 RVA: 0x003F6984 File Offset: 0x003F4B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B5D6 RID: 112086 RVA: 0x003F698D File Offset: 0x003F4B8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B5D7 RID: 112087 RVA: 0x003F69C0 File Offset: 0x003F4BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B5D8 RID: 112088 RVA: 0x003F69FE File Offset: 0x003F4BFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseGoldenCoinPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B5D9 RID: 112089 RVA: 0x003F6A2F File Offset: 0x003F4C2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B5DA RID: 112090 RVA: 0x003F6A38 File Offset: 0x003F4C38
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009E04 RID: 40452
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E05 RID: 40453
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x04009E06 RID: 40454
		private int configId_;
	}
}
