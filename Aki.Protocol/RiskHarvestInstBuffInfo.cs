using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F4E RID: 3918
	public sealed class RiskHarvestInstBuffInfo : IMessage<RiskHarvestInstBuffInfo>, IMessage, IEquatable<RiskHarvestInstBuffInfo>, IDeepCloneable<RiskHarvestInstBuffInfo>, IBufferMessage
	{
		// Token: 0x06014FBE RID: 85950 RVA: 0x0030BDDE File Offset: 0x00309FDE
		[NullableContext(1)]
		public static RiskHarvestInstBuffInfo Create()
		{
			return new RiskHarvestInstBuffInfo();
		}

		// Token: 0x170045D2 RID: 17874
		// (get) Token: 0x06014FBF RID: 85951 RVA: 0x0030BDE5 File Offset: 0x00309FE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RiskHarvestInstBuffInfo> Parser
		{
			get
			{
				return RiskHarvestInstBuffInfo._parser;
			}
		}

		// Token: 0x170045D3 RID: 17875
		// (get) Token: 0x06014FC0 RID: 85952 RVA: 0x0030BDEC File Offset: 0x00309FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045D4 RID: 17876
		// (get) Token: 0x06014FC1 RID: 85953 RVA: 0x0030BDEF File Offset: 0x00309FEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestInstBuffInfo.Descriptor;
			}
		}

		// Token: 0x06014FC2 RID: 85954 RVA: 0x0030BDF6 File Offset: 0x00309FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstBuffInfo()
		{
		}

		// Token: 0x06014FC3 RID: 85955 RVA: 0x0030BDFE File Offset: 0x00309FFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstBuffInfo(RiskHarvestInstBuffInfo other) : this()
		{
			this.id_ = other.id_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014FC4 RID: 85956 RVA: 0x0030BE2F File Offset: 0x0030A02F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstBuffInfo Clone()
		{
			return new RiskHarvestInstBuffInfo(this);
		}

		// Token: 0x170045D5 RID: 17877
		// (get) Token: 0x06014FC5 RID: 85957 RVA: 0x0030BE37 File Offset: 0x0030A037
		// (set) Token: 0x06014FC6 RID: 85958 RVA: 0x0030BE3F File Offset: 0x0030A03F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170045D6 RID: 17878
		// (get) Token: 0x06014FC7 RID: 85959 RVA: 0x0030BE48 File Offset: 0x0030A048
		// (set) Token: 0x06014FC8 RID: 85960 RVA: 0x0030BE50 File Offset: 0x0030A050
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

		// Token: 0x06014FC9 RID: 85961 RVA: 0x0030BE59 File Offset: 0x0030A059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestInstBuffInfo);
		}

		// Token: 0x06014FCA RID: 85962 RVA: 0x0030BE67 File Offset: 0x0030A067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestInstBuffInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014FCB RID: 85963 RVA: 0x0030BEA8 File Offset: 0x0030A0A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014FCC RID: 85964 RVA: 0x0030BF00 File Offset: 0x0030A100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014FCD RID: 85965 RVA: 0x0030BF0D File Offset: 0x0030A10D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014FCE RID: 85966 RVA: 0x0030BF18 File Offset: 0x0030A118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014FCF RID: 85967 RVA: 0x0030BF70 File Offset: 0x0030A170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014FD0 RID: 85968 RVA: 0x0030BFC8 File Offset: 0x0030A1C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RiskHarvestInstBuffInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014FD1 RID: 85969 RVA: 0x0030C018 File Offset: 0x0030A218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014FD2 RID: 85970 RVA: 0x0030C024 File Offset: 0x0030A224
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
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007EEB RID: 32491
		private static readonly MessageParser<RiskHarvestInstBuffInfo> _parser = new MessageParser<RiskHarvestInstBuffInfo>(() => new RiskHarvestInstBuffInfo());

		// Token: 0x04007EEC RID: 32492
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007EED RID: 32493
		public const int IdFieldNumber = 1;

		// Token: 0x04007EEE RID: 32494
		private int id_;

		// Token: 0x04007EEF RID: 32495
		public const int CountFieldNumber = 2;

		// Token: 0x04007EF0 RID: 32496
		private int count_;
	}
}
