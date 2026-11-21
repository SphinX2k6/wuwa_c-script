using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F1D RID: 3869
	public sealed class ResonInfo : IMessage<ResonInfo>, IMessage, IEquatable<ResonInfo>, IDeepCloneable<ResonInfo>, IBufferMessage
	{
		// Token: 0x06014BAF RID: 84911 RVA: 0x0030283B File Offset: 0x00300A3B
		[NullableContext(1)]
		public static ResonInfo Create()
		{
			return new ResonInfo();
		}

		// Token: 0x170044E9 RID: 17641
		// (get) Token: 0x06014BB0 RID: 84912 RVA: 0x00302842 File Offset: 0x00300A42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ResonInfo> Parser
		{
			get
			{
				return ResonInfo._parser;
			}
		}

		// Token: 0x170044EA RID: 17642
		// (get) Token: 0x06014BB1 RID: 84913 RVA: 0x00302849 File Offset: 0x00300A49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044EB RID: 17643
		// (get) Token: 0x06014BB2 RID: 84914 RVA: 0x0030284C File Offset: 0x00300A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ResonInfo.Descriptor;
			}
		}

		// Token: 0x06014BB3 RID: 84915 RVA: 0x00302853 File Offset: 0x00300A53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResonInfo()
		{
		}

		// Token: 0x06014BB4 RID: 84916 RVA: 0x0030285B File Offset: 0x00300A5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResonInfo(ResonInfo other) : this()
		{
			this.resonId_ = other.resonId_;
			this.isOpen_ = other.isOpen_;
			this.increase_ = other.increase_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014BB5 RID: 84917 RVA: 0x00302898 File Offset: 0x00300A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResonInfo Clone()
		{
			return new ResonInfo(this);
		}

		// Token: 0x170044EC RID: 17644
		// (get) Token: 0x06014BB6 RID: 84918 RVA: 0x003028A0 File Offset: 0x00300AA0
		// (set) Token: 0x06014BB7 RID: 84919 RVA: 0x003028A8 File Offset: 0x00300AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ResonId
		{
			get
			{
				return this.resonId_;
			}
			set
			{
				this.resonId_ = value;
			}
		}

		// Token: 0x170044ED RID: 17645
		// (get) Token: 0x06014BB8 RID: 84920 RVA: 0x003028B1 File Offset: 0x00300AB1
		// (set) Token: 0x06014BB9 RID: 84921 RVA: 0x003028B9 File Offset: 0x00300AB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsOpen
		{
			get
			{
				return this.isOpen_;
			}
			set
			{
				this.isOpen_ = value;
			}
		}

		// Token: 0x170044EE RID: 17646
		// (get) Token: 0x06014BBA RID: 84922 RVA: 0x003028C2 File Offset: 0x00300AC2
		// (set) Token: 0x06014BBB RID: 84923 RVA: 0x003028CA File Offset: 0x00300ACA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Increase
		{
			get
			{
				return this.increase_;
			}
			set
			{
				this.increase_ = value;
			}
		}

		// Token: 0x06014BBC RID: 84924 RVA: 0x003028D3 File Offset: 0x00300AD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ResonInfo);
		}

		// Token: 0x06014BBD RID: 84925 RVA: 0x003028E4 File Offset: 0x00300AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ResonInfo other)
		{
			return other != null && (other == this || (this.ResonId == other.ResonId && this.IsOpen == other.IsOpen && this.Increase == other.Increase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014BBE RID: 84926 RVA: 0x00302940 File Offset: 0x00300B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ResonId != 0)
			{
				num ^= this.ResonId.GetHashCode();
			}
			if (this.IsOpen)
			{
				num ^= this.IsOpen.GetHashCode();
			}
			if (this.Increase != 0)
			{
				num ^= this.Increase.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014BBF RID: 84927 RVA: 0x003029B1 File Offset: 0x00300BB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014BC0 RID: 84928 RVA: 0x003029BE File Offset: 0x00300BBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014BC1 RID: 84929 RVA: 0x003029C8 File Offset: 0x00300BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ResonId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ResonId);
			}
			if (this.IsOpen)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsOpen);
			}
			if (this.Increase != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Increase);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014BC2 RID: 84930 RVA: 0x00302A3C File Offset: 0x00300C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ResonId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ResonId);
			}
			if (this.IsOpen)
			{
				num += 2;
			}
			if (this.Increase != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Increase);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014BC3 RID: 84931 RVA: 0x00302AA0 File Offset: 0x00300CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ResonInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ResonId != 0)
			{
				this.ResonId = other.ResonId;
			}
			if (other.IsOpen)
			{
				this.IsOpen = other.IsOpen;
			}
			if (other.Increase != 0)
			{
				this.Increase = other.Increase;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014BC4 RID: 84932 RVA: 0x00302B04 File Offset: 0x00300D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014BC5 RID: 84933 RVA: 0x00302B10 File Offset: 0x00300D10
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
							this.Increase = input.ReadInt32();
						}
					}
					else
					{
						this.IsOpen = input.ReadBool();
					}
				}
				else
				{
					this.ResonId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007D9B RID: 32155
		private static readonly MessageParser<ResonInfo> _parser = new MessageParser<ResonInfo>(() => new ResonInfo());

		// Token: 0x04007D9C RID: 32156
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D9D RID: 32157
		public const int ResonIdFieldNumber = 1;

		// Token: 0x04007D9E RID: 32158
		private int resonId_;

		// Token: 0x04007D9F RID: 32159
		public const int IsOpenFieldNumber = 2;

		// Token: 0x04007DA0 RID: 32160
		private bool isOpen_;

		// Token: 0x04007DA1 RID: 32161
		public const int IncreaseFieldNumber = 3;

		// Token: 0x04007DA2 RID: 32162
		private int increase_;
	}
}
