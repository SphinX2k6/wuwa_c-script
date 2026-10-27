using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AE0 RID: 2784
	[NetMessage(EMessageId.MulMapTravelSoarRewardRequest)]
	public sealed class MulMapTravelSoarRewardRequest : IMessage<MulMapTravelSoarRewardRequest>, IMessage, IEquatable<MulMapTravelSoarRewardRequest>, IDeepCloneable<MulMapTravelSoarRewardRequest>, IBufferMessage
	{
		// Token: 0x0600F231 RID: 62001 RVA: 0x00235D2C File Offset: 0x00233F2C
		[NullableContext(1)]
		public static MulMapTravelSoarRewardRequest Create()
		{
			return new MulMapTravelSoarRewardRequest();
		}

		// Token: 0x17003150 RID: 12624
		// (get) Token: 0x0600F232 RID: 62002 RVA: 0x00235D33 File Offset: 0x00233F33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003151 RID: 12625
		// (get) Token: 0x0600F233 RID: 62003 RVA: 0x00235D36 File Offset: 0x00233F36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulMapTravelSoarRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600F234 RID: 62004 RVA: 0x00235D3D File Offset: 0x00233F3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulMapTravelSoarRewardRequest()
		{
		}

		// Token: 0x0600F235 RID: 62005 RVA: 0x00235D50 File Offset: 0x00233F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulMapTravelSoarRewardRequest(MulMapTravelSoarRewardRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F236 RID: 62006 RVA: 0x00235D7A File Offset: 0x00233F7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulMapTravelSoarRewardRequest Clone()
		{
			return new MulMapTravelSoarRewardRequest(this);
		}

		// Token: 0x17003152 RID: 12626
		// (get) Token: 0x0600F237 RID: 62007 RVA: 0x00235D82 File Offset: 0x00233F82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x0600F238 RID: 62008 RVA: 0x00235D8A File Offset: 0x00233F8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulMapTravelSoarRewardRequest);
		}

		// Token: 0x0600F239 RID: 62009 RVA: 0x00235D98 File Offset: 0x00233F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulMapTravelSoarRewardRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F23A RID: 62010 RVA: 0x00235DCC File Offset: 0x00233FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.taskIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F23B RID: 62011 RVA: 0x00235E00 File Offset: 0x00234000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F23C RID: 62012 RVA: 0x00235E0D File Offset: 0x0023400D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F23D RID: 62013 RVA: 0x00235E16 File Offset: 0x00234016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, MulMapTravelSoarRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F23E RID: 62014 RVA: 0x00235E40 File Offset: 0x00234040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskIds_.CalculateSize(MulMapTravelSoarRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F23F RID: 62015 RVA: 0x00235E79 File Offset: 0x00234079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MulMapTravelSoarRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F240 RID: 62016 RVA: 0x00235EA7 File Offset: 0x002340A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F241 RID: 62017 RVA: 0x00235EB0 File Offset: 0x002340B0
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
				if (num != 80U && num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskIds_.AddEntriesFrom(ref input, MulMapTravelSoarRewardRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x040061BC RID: 25020
		private UnknownFieldSet _unknownFields;

		// Token: 0x040061BD RID: 25021
		public const int TaskIdsFieldNumber = 10;

		// Token: 0x040061BE RID: 25022
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(82U);

		// Token: 0x040061BF RID: 25023
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
