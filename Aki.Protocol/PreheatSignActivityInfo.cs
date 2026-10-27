using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DCC RID: 3532
	public sealed class PreheatSignActivityInfo : IMessage<PreheatSignActivityInfo>, IMessage, IEquatable<PreheatSignActivityInfo>, IDeepCloneable<PreheatSignActivityInfo>, IBufferMessage
	{
		// Token: 0x0601303D RID: 77885 RVA: 0x002C58DA File Offset: 0x002C3ADA
		[NullableContext(1)]
		public static PreheatSignActivityInfo Create()
		{
			return new PreheatSignActivityInfo();
		}

		// Token: 0x17003F18 RID: 16152
		// (get) Token: 0x0601303E RID: 77886 RVA: 0x002C58E1 File Offset: 0x002C3AE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F19 RID: 16153
		// (get) Token: 0x0601303F RID: 77887 RVA: 0x002C58E4 File Offset: 0x002C3AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PreheatSignActivityInfo.Descriptor;
			}
		}

		// Token: 0x06013040 RID: 77888 RVA: 0x002C58EB File Offset: 0x002C3AEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignActivityInfo()
		{
		}

		// Token: 0x06013041 RID: 77889 RVA: 0x002C58FE File Offset: 0x002C3AFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignActivityInfo(PreheatSignActivityInfo other) : this()
		{
			this.preheatSignNodeInfos_ = other.preheatSignNodeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013042 RID: 77890 RVA: 0x002C5928 File Offset: 0x002C3B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignActivityInfo Clone()
		{
			return new PreheatSignActivityInfo(this);
		}

		// Token: 0x17003F1A RID: 16154
		// (get) Token: 0x06013043 RID: 77891 RVA: 0x002C5930 File Offset: 0x002C3B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PreheatSignNodeInfo> PreheatSignNodeInfos
		{
			get
			{
				return this.preheatSignNodeInfos_;
			}
		}

		// Token: 0x06013044 RID: 77892 RVA: 0x002C5938 File Offset: 0x002C3B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PreheatSignActivityInfo);
		}

		// Token: 0x06013045 RID: 77893 RVA: 0x002C5946 File Offset: 0x002C3B46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PreheatSignActivityInfo other)
		{
			return other != null && (other == this || (this.preheatSignNodeInfos_.Equals(other.preheatSignNodeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013046 RID: 77894 RVA: 0x002C597C File Offset: 0x002C3B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.preheatSignNodeInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013047 RID: 77895 RVA: 0x002C59B0 File Offset: 0x002C3BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013048 RID: 77896 RVA: 0x002C59BD File Offset: 0x002C3BBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013049 RID: 77897 RVA: 0x002C59C6 File Offset: 0x002C3BC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.preheatSignNodeInfos_.WriteTo(ref output, PreheatSignActivityInfo._repeated_preheatSignNodeInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601304A RID: 77898 RVA: 0x002C59F0 File Offset: 0x002C3BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.preheatSignNodeInfos_.CalculateSize(PreheatSignActivityInfo._repeated_preheatSignNodeInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601304B RID: 77899 RVA: 0x002C5A29 File Offset: 0x002C3C29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PreheatSignActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.preheatSignNodeInfos_.Add(other.preheatSignNodeInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601304C RID: 77900 RVA: 0x002C5A57 File Offset: 0x002C3C57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601304D RID: 77901 RVA: 0x002C5A60 File Offset: 0x002C3C60
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.preheatSignNodeInfos_.AddEntriesFrom(ref input, PreheatSignActivityInfo._repeated_preheatSignNodeInfos_codec);
				}
			}
		}

		// Token: 0x0400756C RID: 30060
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400756D RID: 30061
		public const int PreheatSignNodeInfosFieldNumber = 1;

		// Token: 0x0400756E RID: 30062
		private static readonly FieldCodec<PreheatSignNodeInfo> _repeated_preheatSignNodeInfos_codec = FieldCodec.ForMessage<PreheatSignNodeInfo>(10U, PreheatSignNodeInfo.Parser);

		// Token: 0x0400756F RID: 30063
		private readonly RepeatedField<PreheatSignNodeInfo> preheatSignNodeInfos_ = new RepeatedField<PreheatSignNodeInfo>();
	}
}
