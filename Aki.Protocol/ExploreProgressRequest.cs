using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004F8 RID: 1272
	[NetMessage(EMessageId.ExploreProgressRequest)]
	public sealed class ExploreProgressRequest : IMessage<ExploreProgressRequest>, IMessage, IEquatable<ExploreProgressRequest>, IDeepCloneable<ExploreProgressRequest>, IBufferMessage
	{
		// Token: 0x06007816 RID: 30742 RVA: 0x00124A1D File Offset: 0x00122C1D
		[NullableContext(1)]
		public static ExploreProgressRequest Create()
		{
			return new ExploreProgressRequest();
		}

		// Token: 0x17001747 RID: 5959
		// (get) Token: 0x06007817 RID: 30743 RVA: 0x00124A24 File Offset: 0x00122C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001748 RID: 5960
		// (get) Token: 0x06007818 RID: 30744 RVA: 0x00124A27 File Offset: 0x00122C27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreProgressRequest.Descriptor;
			}
		}

		// Token: 0x06007819 RID: 30745 RVA: 0x00124A2E File Offset: 0x00122C2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreProgressRequest()
		{
		}

		// Token: 0x0600781A RID: 30746 RVA: 0x00124A41 File Offset: 0x00122C41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreProgressRequest(ExploreProgressRequest other) : this()
		{
			this.areaIds_ = other.areaIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600781B RID: 30747 RVA: 0x00124A6B File Offset: 0x00122C6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreProgressRequest Clone()
		{
			return new ExploreProgressRequest(this);
		}

		// Token: 0x17001749 RID: 5961
		// (get) Token: 0x0600781C RID: 30748 RVA: 0x00124A73 File Offset: 0x00122C73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> AreaIds
		{
			get
			{
				return this.areaIds_;
			}
		}

		// Token: 0x0600781D RID: 30749 RVA: 0x00124A7B File Offset: 0x00122C7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreProgressRequest);
		}

		// Token: 0x0600781E RID: 30750 RVA: 0x00124A89 File Offset: 0x00122C89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreProgressRequest other)
		{
			return other != null && (other == this || (this.areaIds_.Equals(other.areaIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600781F RID: 30751 RVA: 0x00124ABC File Offset: 0x00122CBC
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

		// Token: 0x06007820 RID: 30752 RVA: 0x00124AF0 File Offset: 0x00122CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007821 RID: 30753 RVA: 0x00124AFD File Offset: 0x00122CFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007822 RID: 30754 RVA: 0x00124B06 File Offset: 0x00122D06
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

		// Token: 0x06007823 RID: 30755 RVA: 0x00124B30 File Offset: 0x00122D30
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

		// Token: 0x06007824 RID: 30756 RVA: 0x00124B69 File Offset: 0x00122D69
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

		// Token: 0x06007825 RID: 30757 RVA: 0x00124B97 File Offset: 0x00122D97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007826 RID: 30758 RVA: 0x00124BA0 File Offset: 0x00122DA0
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
				if (num != 24U && num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.areaIds_.AddEntriesFrom(ref input, ExploreProgressRequest._repeated_areaIds_codec);
				}
			}
		}

		// Token: 0x04003E54 RID: 15956
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E55 RID: 15957
		public const int AreaIdsFieldNumber = 3;

		// Token: 0x04003E56 RID: 15958
		private static readonly FieldCodec<int> _repeated_areaIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04003E57 RID: 15959
		private readonly RepeatedField<int> areaIds_ = new RepeatedField<int>();
	}
}
