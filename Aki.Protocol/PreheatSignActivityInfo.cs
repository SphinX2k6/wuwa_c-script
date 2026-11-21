using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DBC RID: 3516
	public sealed class PreheatSignActivityInfo : IMessage<PreheatSignActivityInfo>, IMessage, IEquatable<PreheatSignActivityInfo>, IDeepCloneable<PreheatSignActivityInfo>, IBufferMessage
	{
		// Token: 0x06012F58 RID: 77656 RVA: 0x002C421D File Offset: 0x002C241D
		[NullableContext(1)]
		public static PreheatSignActivityInfo Create()
		{
			return new PreheatSignActivityInfo();
		}

		// Token: 0x17003EEE RID: 16110
		// (get) Token: 0x06012F59 RID: 77657 RVA: 0x002C4224 File Offset: 0x002C2424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EEF RID: 16111
		// (get) Token: 0x06012F5A RID: 77658 RVA: 0x002C4227 File Offset: 0x002C2427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PreheatSignActivityInfo.Descriptor;
			}
		}

		// Token: 0x06012F5B RID: 77659 RVA: 0x002C422E File Offset: 0x002C242E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignActivityInfo()
		{
		}

		// Token: 0x06012F5C RID: 77660 RVA: 0x002C4241 File Offset: 0x002C2441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignActivityInfo(PreheatSignActivityInfo other) : this()
		{
			this.preheatSignNodeInfos_ = other.preheatSignNodeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012F5D RID: 77661 RVA: 0x002C426B File Offset: 0x002C246B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignActivityInfo Clone()
		{
			return new PreheatSignActivityInfo(this);
		}

		// Token: 0x17003EF0 RID: 16112
		// (get) Token: 0x06012F5E RID: 77662 RVA: 0x002C4273 File Offset: 0x002C2473
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PreheatSignNodeInfo> PreheatSignNodeInfos
		{
			get
			{
				return this.preheatSignNodeInfos_;
			}
		}

		// Token: 0x06012F5F RID: 77663 RVA: 0x002C427B File Offset: 0x002C247B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PreheatSignActivityInfo);
		}

		// Token: 0x06012F60 RID: 77664 RVA: 0x002C4289 File Offset: 0x002C2489
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PreheatSignActivityInfo other)
		{
			return other != null && (other == this || (this.preheatSignNodeInfos_.Equals(other.preheatSignNodeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012F61 RID: 77665 RVA: 0x002C42BC File Offset: 0x002C24BC
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

		// Token: 0x06012F62 RID: 77666 RVA: 0x002C42F0 File Offset: 0x002C24F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012F63 RID: 77667 RVA: 0x002C42FD File Offset: 0x002C24FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012F64 RID: 77668 RVA: 0x002C4306 File Offset: 0x002C2506
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

		// Token: 0x06012F65 RID: 77669 RVA: 0x002C4330 File Offset: 0x002C2530
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

		// Token: 0x06012F66 RID: 77670 RVA: 0x002C4369 File Offset: 0x002C2569
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

		// Token: 0x06012F67 RID: 77671 RVA: 0x002C4397 File Offset: 0x002C2597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012F68 RID: 77672 RVA: 0x002C43A0 File Offset: 0x002C25A0
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

		// Token: 0x04007596 RID: 30102
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007597 RID: 30103
		public const int PreheatSignNodeInfosFieldNumber = 1;

		// Token: 0x04007598 RID: 30104
		private static readonly FieldCodec<PreheatSignNodeInfo> _repeated_preheatSignNodeInfos_codec = FieldCodec.ForMessage<PreheatSignNodeInfo>(10U, PreheatSignNodeInfo.Parser);

		// Token: 0x04007599 RID: 30105
		private readonly RepeatedField<PreheatSignNodeInfo> preheatSignNodeInfos_ = new RepeatedField<PreheatSignNodeInfo>();
	}
}
