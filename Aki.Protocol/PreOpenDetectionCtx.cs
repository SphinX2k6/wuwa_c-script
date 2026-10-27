using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DD3 RID: 3539
	public sealed class PreOpenDetectionCtx : IMessage<PreOpenDetectionCtx>, IMessage, IEquatable<PreOpenDetectionCtx>, IDeepCloneable<PreOpenDetectionCtx>, IBufferMessage
	{
		// Token: 0x060130CB RID: 78027 RVA: 0x002C6BA3 File Offset: 0x002C4DA3
		[NullableContext(1)]
		public static PreOpenDetectionCtx Create()
		{
			return new PreOpenDetectionCtx();
		}

		// Token: 0x17003F35 RID: 16181
		// (get) Token: 0x060130CC RID: 78028 RVA: 0x002C6BAA File Offset: 0x002C4DAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F36 RID: 16182
		// (get) Token: 0x060130CD RID: 78029 RVA: 0x002C6BAD File Offset: 0x002C4DAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PreOpenDetectionCtx.Descriptor;
			}
		}

		// Token: 0x060130CE RID: 78030 RVA: 0x002C6BB4 File Offset: 0x002C4DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreOpenDetectionCtx()
		{
		}

		// Token: 0x060130CF RID: 78031 RVA: 0x002C6BBC File Offset: 0x002C4DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreOpenDetectionCtx(PreOpenDetectionCtx other) : this()
		{
			this.configId_ = other.configId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060130D0 RID: 78032 RVA: 0x002C6BE1 File Offset: 0x002C4DE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreOpenDetectionCtx Clone()
		{
			return new PreOpenDetectionCtx(this);
		}

		// Token: 0x17003F37 RID: 16183
		// (get) Token: 0x060130D1 RID: 78033 RVA: 0x002C6BE9 File Offset: 0x002C4DE9
		// (set) Token: 0x060130D2 RID: 78034 RVA: 0x002C6BF1 File Offset: 0x002C4DF1
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

		// Token: 0x060130D3 RID: 78035 RVA: 0x002C6BFA File Offset: 0x002C4DFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PreOpenDetectionCtx);
		}

		// Token: 0x060130D4 RID: 78036 RVA: 0x002C6C08 File Offset: 0x002C4E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PreOpenDetectionCtx other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060130D5 RID: 78037 RVA: 0x002C6C38 File Offset: 0x002C4E38
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

		// Token: 0x060130D6 RID: 78038 RVA: 0x002C6C77 File Offset: 0x002C4E77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060130D7 RID: 78039 RVA: 0x002C6C84 File Offset: 0x002C4E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060130D8 RID: 78040 RVA: 0x002C6C8D File Offset: 0x002C4E8D
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

		// Token: 0x060130D9 RID: 78041 RVA: 0x002C6CC0 File Offset: 0x002C4EC0
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

		// Token: 0x060130DA RID: 78042 RVA: 0x002C6CFE File Offset: 0x002C4EFE
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

		// Token: 0x060130DB RID: 78043 RVA: 0x002C6D2F File Offset: 0x002C4F2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060130DC RID: 78044 RVA: 0x002C6D38 File Offset: 0x002C4F38
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

		// Token: 0x04007591 RID: 30097
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007592 RID: 30098
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x04007593 RID: 30099
		private int configId_;
	}
}
