using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DC3 RID: 3523
	public sealed class PreOpenDetectionCtx : IMessage<PreOpenDetectionCtx>, IMessage, IEquatable<PreOpenDetectionCtx>, IDeepCloneable<PreOpenDetectionCtx>, IBufferMessage
	{
		// Token: 0x06012FE6 RID: 77798 RVA: 0x002C54DE File Offset: 0x002C36DE
		[NullableContext(1)]
		public static PreOpenDetectionCtx Create()
		{
			return new PreOpenDetectionCtx();
		}

		// Token: 0x17003F0B RID: 16139
		// (get) Token: 0x06012FE7 RID: 77799 RVA: 0x002C54E5 File Offset: 0x002C36E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F0C RID: 16140
		// (get) Token: 0x06012FE8 RID: 77800 RVA: 0x002C54E8 File Offset: 0x002C36E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PreOpenDetectionCtx.Descriptor;
			}
		}

		// Token: 0x06012FE9 RID: 77801 RVA: 0x002C54EF File Offset: 0x002C36EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreOpenDetectionCtx()
		{
		}

		// Token: 0x06012FEA RID: 77802 RVA: 0x002C54F7 File Offset: 0x002C36F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreOpenDetectionCtx(PreOpenDetectionCtx other) : this()
		{
			this.configId_ = other.configId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012FEB RID: 77803 RVA: 0x002C551C File Offset: 0x002C371C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreOpenDetectionCtx Clone()
		{
			return new PreOpenDetectionCtx(this);
		}

		// Token: 0x17003F0D RID: 16141
		// (get) Token: 0x06012FEC RID: 77804 RVA: 0x002C5524 File Offset: 0x002C3724
		// (set) Token: 0x06012FED RID: 77805 RVA: 0x002C552C File Offset: 0x002C372C
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

		// Token: 0x06012FEE RID: 77806 RVA: 0x002C5535 File Offset: 0x002C3735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PreOpenDetectionCtx);
		}

		// Token: 0x06012FEF RID: 77807 RVA: 0x002C5543 File Offset: 0x002C3743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PreOpenDetectionCtx other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012FF0 RID: 77808 RVA: 0x002C5574 File Offset: 0x002C3774
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

		// Token: 0x06012FF1 RID: 77809 RVA: 0x002C55B3 File Offset: 0x002C37B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012FF2 RID: 77810 RVA: 0x002C55C0 File Offset: 0x002C37C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012FF3 RID: 77811 RVA: 0x002C55C9 File Offset: 0x002C37C9
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

		// Token: 0x06012FF4 RID: 77812 RVA: 0x002C55FC File Offset: 0x002C37FC
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

		// Token: 0x06012FF5 RID: 77813 RVA: 0x002C563A File Offset: 0x002C383A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PreOpenDetectionCtx other)
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

		// Token: 0x06012FF6 RID: 77814 RVA: 0x002C566B File Offset: 0x002C386B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012FF7 RID: 77815 RVA: 0x002C5674 File Offset: 0x002C3874
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

		// Token: 0x040075BB RID: 30139
		private UnknownFieldSet _unknownFields;

		// Token: 0x040075BC RID: 30140
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x040075BD RID: 30141
		private int configId_;
	}
}
