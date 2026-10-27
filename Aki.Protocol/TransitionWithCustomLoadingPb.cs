using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013FF RID: 5119
	public sealed class TransitionWithCustomLoadingPb : IMessage<TransitionWithCustomLoadingPb>, IMessage, IEquatable<TransitionWithCustomLoadingPb>, IDeepCloneable<TransitionWithCustomLoadingPb>, IBufferMessage
	{
		// Token: 0x0601B229 RID: 111145 RVA: 0x003EE9E4 File Offset: 0x003ECBE4
		[NullableContext(1)]
		public static TransitionWithCustomLoadingPb Create()
		{
			return new TransitionWithCustomLoadingPb();
		}

		// Token: 0x17005B7F RID: 23423
		// (get) Token: 0x0601B22A RID: 111146 RVA: 0x003EE9EB File Offset: 0x003ECBEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B80 RID: 23424
		// (get) Token: 0x0601B22B RID: 111147 RVA: 0x003EE9EE File Offset: 0x003ECBEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TransitionWithCustomLoadingPb.Descriptor;
			}
		}

		// Token: 0x0601B22C RID: 111148 RVA: 0x003EE9F5 File Offset: 0x003ECBF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionWithCustomLoadingPb()
		{
		}

		// Token: 0x0601B22D RID: 111149 RVA: 0x003EE9FD File Offset: 0x003ECBFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionWithCustomLoadingPb(TransitionWithCustomLoadingPb other) : this()
		{
			this.configId_ = other.configId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B22E RID: 111150 RVA: 0x003EEA22 File Offset: 0x003ECC22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionWithCustomLoadingPb Clone()
		{
			return new TransitionWithCustomLoadingPb(this);
		}

		// Token: 0x17005B81 RID: 23425
		// (get) Token: 0x0601B22F RID: 111151 RVA: 0x003EEA2A File Offset: 0x003ECC2A
		// (set) Token: 0x0601B230 RID: 111152 RVA: 0x003EEA32 File Offset: 0x003ECC32
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

		// Token: 0x0601B231 RID: 111153 RVA: 0x003EEA3B File Offset: 0x003ECC3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TransitionWithCustomLoadingPb);
		}

		// Token: 0x0601B232 RID: 111154 RVA: 0x003EEA49 File Offset: 0x003ECC49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TransitionWithCustomLoadingPb other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B233 RID: 111155 RVA: 0x003EEA78 File Offset: 0x003ECC78
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

		// Token: 0x0601B234 RID: 111156 RVA: 0x003EEAB7 File Offset: 0x003ECCB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B235 RID: 111157 RVA: 0x003EEAC4 File Offset: 0x003ECCC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B236 RID: 111158 RVA: 0x003EEACD File Offset: 0x003ECCCD
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

		// Token: 0x0601B237 RID: 111159 RVA: 0x003EEB00 File Offset: 0x003ECD00
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

		// Token: 0x0601B238 RID: 111160 RVA: 0x003EEB3E File Offset: 0x003ECD3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TransitionWithCustomLoadingPb other)
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

		// Token: 0x0601B239 RID: 111161 RVA: 0x003EEB6F File Offset: 0x003ECD6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B23A RID: 111162 RVA: 0x003EEB78 File Offset: 0x003ECD78
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

		// Token: 0x04009CFE RID: 40190
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009CFF RID: 40191
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x04009D00 RID: 40192
		private int configId_;
	}
}
