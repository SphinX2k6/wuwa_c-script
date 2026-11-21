using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000566 RID: 1382
	[NetMessage(EMessageId.FishingSellRequest)]
	public sealed class FishingSellRequest : IMessage<FishingSellRequest>, IMessage, IEquatable<FishingSellRequest>, IDeepCloneable<FishingSellRequest>, IBufferMessage
	{
		// Token: 0x06008102 RID: 33026 RVA: 0x00137EAA File Offset: 0x001360AA
		[NullableContext(1)]
		public static FishingSellRequest Create()
		{
			return new FishingSellRequest();
		}

		// Token: 0x1700191F RID: 6431
		// (get) Token: 0x06008103 RID: 33027 RVA: 0x00137EB1 File Offset: 0x001360B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001920 RID: 6432
		// (get) Token: 0x06008104 RID: 33028 RVA: 0x00137EB4 File Offset: 0x001360B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingSellRequest.Descriptor;
			}
		}

		// Token: 0x06008105 RID: 33029 RVA: 0x00137EBB File Offset: 0x001360BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSellRequest()
		{
		}

		// Token: 0x06008106 RID: 33030 RVA: 0x00137ECE File Offset: 0x001360CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSellRequest(FishingSellRequest other) : this()
		{
			this.incrIds_ = other.incrIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008107 RID: 33031 RVA: 0x00137EF8 File Offset: 0x001360F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSellRequest Clone()
		{
			return new FishingSellRequest(this);
		}

		// Token: 0x17001921 RID: 6433
		// (get) Token: 0x06008108 RID: 33032 RVA: 0x00137F00 File Offset: 0x00136100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> IncrIds
		{
			get
			{
				return this.incrIds_;
			}
		}

		// Token: 0x06008109 RID: 33033 RVA: 0x00137F08 File Offset: 0x00136108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingSellRequest);
		}

		// Token: 0x0600810A RID: 33034 RVA: 0x00137F16 File Offset: 0x00136116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingSellRequest other)
		{
			return other != null && (other == this || (this.incrIds_.Equals(other.incrIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600810B RID: 33035 RVA: 0x00137F4C File Offset: 0x0013614C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.incrIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600810C RID: 33036 RVA: 0x00137F80 File Offset: 0x00136180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600810D RID: 33037 RVA: 0x00137F8D File Offset: 0x0013618D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600810E RID: 33038 RVA: 0x00137F96 File Offset: 0x00136196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.incrIds_.WriteTo(ref output, FishingSellRequest._repeated_incrIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600810F RID: 33039 RVA: 0x00137FC0 File Offset: 0x001361C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.incrIds_.CalculateSize(FishingSellRequest._repeated_incrIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008110 RID: 33040 RVA: 0x00137FF9 File Offset: 0x001361F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingSellRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.incrIds_.Add(other.incrIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008111 RID: 33041 RVA: 0x00138027 File Offset: 0x00136227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008112 RID: 33042 RVA: 0x00138030 File Offset: 0x00136230
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
				if (num != 88U && num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.incrIds_.AddEntriesFrom(ref input, FishingSellRequest._repeated_incrIds_codec);
				}
			}
		}

		// Token: 0x04004135 RID: 16693
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004136 RID: 16694
		public const int IncrIdsFieldNumber = 11;

		// Token: 0x04004137 RID: 16695
		private static readonly FieldCodec<int> _repeated_incrIds_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04004138 RID: 16696
		private readonly RepeatedField<int> incrIds_ = new RepeatedField<int>();
	}
}
