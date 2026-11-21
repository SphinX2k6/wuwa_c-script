using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001472 RID: 5234
	public sealed class TransitionWithCustomLoadingPb : IMessage<TransitionWithCustomLoadingPb>, IMessage, IEquatable<TransitionWithCustomLoadingPb>, IDeepCloneable<TransitionWithCustomLoadingPb>, IBufferMessage
	{
		// Token: 0x0601BCB4 RID: 113844 RVA: 0x00409CB8 File Offset: 0x00407EB8
		[NullableContext(1)]
		public static TransitionWithCustomLoadingPb Create()
		{
			return new TransitionWithCustomLoadingPb();
		}

		// Token: 0x17005E14 RID: 24084
		// (get) Token: 0x0601BCB5 RID: 113845 RVA: 0x00409CBF File Offset: 0x00407EBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E15 RID: 24085
		// (get) Token: 0x0601BCB6 RID: 113846 RVA: 0x00409CC2 File Offset: 0x00407EC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TransitionWithCustomLoadingPb.Descriptor;
			}
		}

		// Token: 0x0601BCB7 RID: 113847 RVA: 0x00409CC9 File Offset: 0x00407EC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionWithCustomLoadingPb()
		{
		}

		// Token: 0x0601BCB8 RID: 113848 RVA: 0x00409CD1 File Offset: 0x00407ED1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionWithCustomLoadingPb(TransitionWithCustomLoadingPb other) : this()
		{
			this.configId_ = other.configId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BCB9 RID: 113849 RVA: 0x00409CF6 File Offset: 0x00407EF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionWithCustomLoadingPb Clone()
		{
			return new TransitionWithCustomLoadingPb(this);
		}

		// Token: 0x17005E16 RID: 24086
		// (get) Token: 0x0601BCBA RID: 113850 RVA: 0x00409CFE File Offset: 0x00407EFE
		// (set) Token: 0x0601BCBB RID: 113851 RVA: 0x00409D06 File Offset: 0x00407F06
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

		// Token: 0x0601BCBC RID: 113852 RVA: 0x00409D0F File Offset: 0x00407F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TransitionWithCustomLoadingPb);
		}

		// Token: 0x0601BCBD RID: 113853 RVA: 0x00409D1D File Offset: 0x00407F1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TransitionWithCustomLoadingPb other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BCBE RID: 113854 RVA: 0x00409D4C File Offset: 0x00407F4C
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

		// Token: 0x0601BCBF RID: 113855 RVA: 0x00409D8B File Offset: 0x00407F8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BCC0 RID: 113856 RVA: 0x00409D98 File Offset: 0x00407F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BCC1 RID: 113857 RVA: 0x00409DA1 File Offset: 0x00407FA1
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

		// Token: 0x0601BCC2 RID: 113858 RVA: 0x00409DD4 File Offset: 0x00407FD4
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

		// Token: 0x0601BCC3 RID: 113859 RVA: 0x00409E12 File Offset: 0x00408012
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

		// Token: 0x0601BCC4 RID: 113860 RVA: 0x00409E43 File Offset: 0x00408043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BCC5 RID: 113861 RVA: 0x00409E4C File Offset: 0x0040804C
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

		// Token: 0x0400A145 RID: 41285
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A146 RID: 41286
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x0400A147 RID: 41287
		private int configId_;
	}
}
