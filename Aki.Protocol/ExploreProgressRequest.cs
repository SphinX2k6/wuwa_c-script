using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004E2 RID: 1250
	[NetMessage(EMessageId.ExploreProgressRequest)]
	public sealed class ExploreProgressRequest : IMessage<ExploreProgressRequest>, IMessage, IEquatable<ExploreProgressRequest>, IDeepCloneable<ExploreProgressRequest>, IBufferMessage
	{
		// Token: 0x0600769A RID: 30362 RVA: 0x00121B89 File Offset: 0x0011FD89
		[NullableContext(1)]
		public static ExploreProgressRequest Create()
		{
			return new ExploreProgressRequest();
		}

		// Token: 0x170016F6 RID: 5878
		// (get) Token: 0x0600769B RID: 30363 RVA: 0x00121B90 File Offset: 0x0011FD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016F7 RID: 5879
		// (get) Token: 0x0600769C RID: 30364 RVA: 0x00121B93 File Offset: 0x0011FD93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreProgressRequest.Descriptor;
			}
		}

		// Token: 0x0600769D RID: 30365 RVA: 0x00121B9A File Offset: 0x0011FD9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreProgressRequest()
		{
		}

		// Token: 0x0600769E RID: 30366 RVA: 0x00121BAD File Offset: 0x0011FDAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreProgressRequest(ExploreProgressRequest other) : this()
		{
			this.areaIds_ = other.areaIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600769F RID: 30367 RVA: 0x00121BD7 File Offset: 0x0011FDD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreProgressRequest Clone()
		{
			return new ExploreProgressRequest(this);
		}

		// Token: 0x170016F8 RID: 5880
		// (get) Token: 0x060076A0 RID: 30368 RVA: 0x00121BDF File Offset: 0x0011FDDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> AreaIds
		{
			get
			{
				return this.areaIds_;
			}
		}

		// Token: 0x060076A1 RID: 30369 RVA: 0x00121BE7 File Offset: 0x0011FDE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreProgressRequest);
		}

		// Token: 0x060076A2 RID: 30370 RVA: 0x00121BF5 File Offset: 0x0011FDF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreProgressRequest other)
		{
			return other != null && (other == this || (this.areaIds_.Equals(other.areaIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060076A3 RID: 30371 RVA: 0x00121C28 File Offset: 0x0011FE28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.areaIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060076A4 RID: 30372 RVA: 0x00121C5C File Offset: 0x0011FE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060076A5 RID: 30373 RVA: 0x00121C69 File Offset: 0x0011FE69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060076A6 RID: 30374 RVA: 0x00121C72 File Offset: 0x0011FE72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.areaIds_.WriteTo(ref output, ExploreProgressRequest._repeated_areaIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060076A7 RID: 30375 RVA: 0x00121C9C File Offset: 0x0011FE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.areaIds_.CalculateSize(ExploreProgressRequest._repeated_areaIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060076A8 RID: 30376 RVA: 0x00121CD5 File Offset: 0x0011FED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreProgressRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.areaIds_.Add(other.areaIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060076A9 RID: 30377 RVA: 0x00121D03 File Offset: 0x0011FF03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060076AA RID: 30378 RVA: 0x00121D0C File Offset: 0x0011FF0C
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
				if (num != 16U && num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.areaIds_.AddEntriesFrom(ref input, ExploreProgressRequest._repeated_areaIds_codec);
				}
			}
		}

		// Token: 0x04003E45 RID: 15941
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E46 RID: 15942
		public const int AreaIdsFieldNumber = 2;

		// Token: 0x04003E47 RID: 15943
		private static readonly FieldCodec<int> _repeated_areaIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04003E48 RID: 15944
		private readonly RepeatedField<int> areaIds_ = new RepeatedField<int>();
	}
}
