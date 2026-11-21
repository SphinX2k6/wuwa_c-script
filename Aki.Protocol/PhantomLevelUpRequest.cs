using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CD3 RID: 3283
	[NetMessage(EMessageId.PhantomLevelUpRequest)]
	public sealed class PhantomLevelUpRequest : IMessage<PhantomLevelUpRequest>, IMessage, IEquatable<PhantomLevelUpRequest>, IDeepCloneable<PhantomLevelUpRequest>, IBufferMessage
	{
		// Token: 0x06011C9B RID: 72859 RVA: 0x0029ACC9 File Offset: 0x00298EC9
		[NullableContext(1)]
		public static PhantomLevelUpRequest Create()
		{
			return new PhantomLevelUpRequest();
		}

		// Token: 0x17003AF3 RID: 15091
		// (get) Token: 0x06011C9C RID: 72860 RVA: 0x0029ACD0 File Offset: 0x00298ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AF4 RID: 15092
		// (get) Token: 0x06011C9D RID: 72861 RVA: 0x0029ACD3 File Offset: 0x00298ED3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomLevelUpRequest.Descriptor;
			}
		}

		// Token: 0x06011C9E RID: 72862 RVA: 0x0029ACDA File Offset: 0x00298EDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomLevelUpRequest()
		{
		}

		// Token: 0x06011C9F RID: 72863 RVA: 0x0029ACF0 File Offset: 0x00298EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomLevelUpRequest(PhantomLevelUpRequest other) : this()
		{
			this.incId_ = other.incId_;
			this.consumeList_ = other.consumeList_.Clone();
			this.identifyCount_ = other.identifyCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011CA0 RID: 72864 RVA: 0x0029AD3D File Offset: 0x00298F3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomLevelUpRequest Clone()
		{
			return new PhantomLevelUpRequest(this);
		}

		// Token: 0x17003AF5 RID: 15093
		// (get) Token: 0x06011CA1 RID: 72865 RVA: 0x0029AD45 File Offset: 0x00298F45
		// (set) Token: 0x06011CA2 RID: 72866 RVA: 0x0029AD4D File Offset: 0x00298F4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x17003AF6 RID: 15094
		// (get) Token: 0x06011CA3 RID: 72867 RVA: 0x0029AD56 File Offset: 0x00298F56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomConsumeItem> ConsumeList
		{
			get
			{
				return this.consumeList_;
			}
		}

		// Token: 0x17003AF7 RID: 15095
		// (get) Token: 0x06011CA4 RID: 72868 RVA: 0x0029AD5E File Offset: 0x00298F5E
		// (set) Token: 0x06011CA5 RID: 72869 RVA: 0x0029AD66 File Offset: 0x00298F66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IdentifyCount
		{
			get
			{
				return this.identifyCount_;
			}
			set
			{
				this.identifyCount_ = value;
			}
		}

		// Token: 0x06011CA6 RID: 72870 RVA: 0x0029AD6F File Offset: 0x00298F6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomLevelUpRequest);
		}

		// Token: 0x06011CA7 RID: 72871 RVA: 0x0029AD80 File Offset: 0x00298F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomLevelUpRequest other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.consumeList_.Equals(other.consumeList_) && this.IdentifyCount == other.IdentifyCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011CA8 RID: 72872 RVA: 0x0029ADE0 File Offset: 0x00298FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			num ^= this.consumeList_.GetHashCode();
			if (this.IdentifyCount != 0)
			{
				num ^= this.IdentifyCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011CA9 RID: 72873 RVA: 0x0029AE46 File Offset: 0x00299046
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011CAA RID: 72874 RVA: 0x0029AE53 File Offset: 0x00299053
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011CAB RID: 72875 RVA: 0x0029AE5C File Offset: 0x0029905C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IdentifyCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.IdentifyCount);
			}
			this.consumeList_.WriteTo(ref output, PhantomLevelUpRequest._repeated_consumeList_codec);
			if (this.IncId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011CAC RID: 72876 RVA: 0x0029AEC8 File Offset: 0x002990C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			num += this.consumeList_.CalculateSize(PhantomLevelUpRequest._repeated_consumeList_codec);
			if (this.IdentifyCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IdentifyCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011CAD RID: 72877 RVA: 0x0029AF34 File Offset: 0x00299134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomLevelUpRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			this.consumeList_.Add(other.consumeList_);
			if (other.IdentifyCount != 0)
			{
				this.IdentifyCount = other.IdentifyCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011CAE RID: 72878 RVA: 0x0029AF95 File Offset: 0x00299195
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011CAF RID: 72879 RVA: 0x0029AFA0 File Offset: 0x002991A0
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
				if (num != 16U)
				{
					if (num != 66U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IncId = input.ReadInt32();
						}
					}
					else
					{
						this.consumeList_.AddEntriesFrom(ref input, PhantomLevelUpRequest._repeated_consumeList_codec);
					}
				}
				else
				{
					this.IdentifyCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400702C RID: 28716
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400702D RID: 28717
		public const int IncIdFieldNumber = 14;

		// Token: 0x0400702E RID: 28718
		private int incId_;

		// Token: 0x0400702F RID: 28719
		public const int ConsumeListFieldNumber = 8;

		// Token: 0x04007030 RID: 28720
		private static readonly FieldCodec<PhantomConsumeItem> _repeated_consumeList_codec = FieldCodec.ForMessage<PhantomConsumeItem>(66U, PhantomConsumeItem.Parser);

		// Token: 0x04007031 RID: 28721
		private readonly RepeatedField<PhantomConsumeItem> consumeList_ = new RepeatedField<PhantomConsumeItem>();

		// Token: 0x04007032 RID: 28722
		public const int IdentifyCountFieldNumber = 2;

		// Token: 0x04007033 RID: 28723
		private int identifyCount_;
	}
}
