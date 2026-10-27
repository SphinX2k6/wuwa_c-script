using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D10 RID: 3344
	[NetMessage(EMessageId.PhantomVicePolishRequest)]
	public sealed class PhantomVicePolishRequest : IMessage<PhantomVicePolishRequest>, IMessage, IEquatable<PhantomVicePolishRequest>, IDeepCloneable<PhantomVicePolishRequest>, IBufferMessage
	{
		// Token: 0x06012116 RID: 74006 RVA: 0x002A3F5B File Offset: 0x002A215B
		[NullableContext(1)]
		public static PhantomVicePolishRequest Create()
		{
			return new PhantomVicePolishRequest();
		}

		// Token: 0x17003BDD RID: 15325
		// (get) Token: 0x06012117 RID: 74007 RVA: 0x002A3F62 File Offset: 0x002A2162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BDE RID: 15326
		// (get) Token: 0x06012118 RID: 74008 RVA: 0x002A3F65 File Offset: 0x002A2165
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomVicePolishRequest.Descriptor;
			}
		}

		// Token: 0x06012119 RID: 74009 RVA: 0x002A3F6C File Offset: 0x002A216C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomVicePolishRequest()
		{
		}

		// Token: 0x0601211A RID: 74010 RVA: 0x002A3F7F File Offset: 0x002A217F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomVicePolishRequest(PhantomVicePolishRequest other) : this()
		{
			this.incrId_ = other.incrId_;
			this.lockPropIndex_ = other.lockPropIndex_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601211B RID: 74011 RVA: 0x002A3FB5 File Offset: 0x002A21B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomVicePolishRequest Clone()
		{
			return new PhantomVicePolishRequest(this);
		}

		// Token: 0x17003BDF RID: 15327
		// (get) Token: 0x0601211C RID: 74012 RVA: 0x002A3FBD File Offset: 0x002A21BD
		// (set) Token: 0x0601211D RID: 74013 RVA: 0x002A3FC5 File Offset: 0x002A21C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncrId
		{
			get
			{
				return this.incrId_;
			}
			set
			{
				this.incrId_ = value;
			}
		}

		// Token: 0x17003BE0 RID: 15328
		// (get) Token: 0x0601211E RID: 74014 RVA: 0x002A3FCE File Offset: 0x002A21CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> LockPropIndex
		{
			get
			{
				return this.lockPropIndex_;
			}
		}

		// Token: 0x0601211F RID: 74015 RVA: 0x002A3FD6 File Offset: 0x002A21D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomVicePolishRequest);
		}

		// Token: 0x06012120 RID: 74016 RVA: 0x002A3FE4 File Offset: 0x002A21E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomVicePolishRequest other)
		{
			return other != null && (other == this || (this.IncrId == other.IncrId && this.lockPropIndex_.Equals(other.lockPropIndex_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012121 RID: 74017 RVA: 0x002A4034 File Offset: 0x002A2234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncrId != 0)
			{
				num ^= this.IncrId.GetHashCode();
			}
			num ^= this.lockPropIndex_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012122 RID: 74018 RVA: 0x002A4081 File Offset: 0x002A2281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012123 RID: 74019 RVA: 0x002A408E File Offset: 0x002A228E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012124 RID: 74020 RVA: 0x002A4098 File Offset: 0x002A2298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.lockPropIndex_.WriteTo(ref output, PhantomVicePolishRequest._repeated_lockPropIndex_codec);
			if (this.IncrId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.IncrId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012125 RID: 74021 RVA: 0x002A40E8 File Offset: 0x002A22E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncrId);
			}
			num += this.lockPropIndex_.CalculateSize(PhantomVicePolishRequest._repeated_lockPropIndex_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012126 RID: 74022 RVA: 0x002A413C File Offset: 0x002A233C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomVicePolishRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			this.lockPropIndex_.Add(other.lockPropIndex_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012127 RID: 74023 RVA: 0x002A4189 File Offset: 0x002A2389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012128 RID: 74024 RVA: 0x002A4194 File Offset: 0x002A2394
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
				if (num != 80U && num != 82U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IncrId = input.ReadInt32();
					}
				}
				else
				{
					this.lockPropIndex_.AddEntriesFrom(ref input, PhantomVicePolishRequest._repeated_lockPropIndex_codec);
				}
			}
		}

		// Token: 0x0400710E RID: 28942
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400710F RID: 28943
		public const int IncrIdFieldNumber = 14;

		// Token: 0x04007110 RID: 28944
		private int incrId_;

		// Token: 0x04007111 RID: 28945
		public const int LockPropIndexFieldNumber = 10;

		// Token: 0x04007112 RID: 28946
		private static readonly FieldCodec<int> _repeated_lockPropIndex_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04007113 RID: 28947
		private readonly RepeatedField<int> lockPropIndex_ = new RepeatedField<int>();
	}
}
