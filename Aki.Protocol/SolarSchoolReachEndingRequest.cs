using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012BC RID: 4796
	[NetMessage(EMessageId.SolarSchoolReachEndingRequest)]
	public sealed class SolarSchoolReachEndingRequest : IMessage<SolarSchoolReachEndingRequest>, IMessage, IEquatable<SolarSchoolReachEndingRequest>, IDeepCloneable<SolarSchoolReachEndingRequest>, IBufferMessage
	{
		// Token: 0x06019990 RID: 104848 RVA: 0x003BBD1F File Offset: 0x003B9F1F
		[NullableContext(1)]
		public static SolarSchoolReachEndingRequest Create()
		{
			return new SolarSchoolReachEndingRequest();
		}

		// Token: 0x170056A6 RID: 22182
		// (get) Token: 0x06019991 RID: 104849 RVA: 0x003BBD26 File Offset: 0x003B9F26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056A7 RID: 22183
		// (get) Token: 0x06019992 RID: 104850 RVA: 0x003BBD29 File Offset: 0x003B9F29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolReachEndingRequest.Descriptor;
			}
		}

		// Token: 0x06019993 RID: 104851 RVA: 0x003BBD30 File Offset: 0x003B9F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolReachEndingRequest()
		{
		}

		// Token: 0x06019994 RID: 104852 RVA: 0x003BBD43 File Offset: 0x003B9F43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolReachEndingRequest(SolarSchoolReachEndingRequest other) : this()
		{
			this.id_ = other.id_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019995 RID: 104853 RVA: 0x003BBD6D File Offset: 0x003B9F6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolReachEndingRequest Clone()
		{
			return new SolarSchoolReachEndingRequest(this);
		}

		// Token: 0x170056A8 RID: 22184
		// (get) Token: 0x06019996 RID: 104854 RVA: 0x003BBD75 File Offset: 0x003B9F75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Id
		{
			get
			{
				return this.id_;
			}
		}

		// Token: 0x06019997 RID: 104855 RVA: 0x003BBD7D File Offset: 0x003B9F7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolReachEndingRequest);
		}

		// Token: 0x06019998 RID: 104856 RVA: 0x003BBD8B File Offset: 0x003B9F8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolReachEndingRequest other)
		{
			return other != null && (other == this || (this.id_.Equals(other.id_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019999 RID: 104857 RVA: 0x003BBDC0 File Offset: 0x003B9FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.id_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601999A RID: 104858 RVA: 0x003BBDF4 File Offset: 0x003B9FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601999B RID: 104859 RVA: 0x003BBE01 File Offset: 0x003BA001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601999C RID: 104860 RVA: 0x003BBE0A File Offset: 0x003BA00A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.id_.WriteTo(ref output, SolarSchoolReachEndingRequest._repeated_id_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601999D RID: 104861 RVA: 0x003BBE34 File Offset: 0x003BA034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.id_.CalculateSize(SolarSchoolReachEndingRequest._repeated_id_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601999E RID: 104862 RVA: 0x003BBE6D File Offset: 0x003BA06D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolReachEndingRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.id_.Add(other.id_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601999F RID: 104863 RVA: 0x003BBE9B File Offset: 0x003BA09B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060199A0 RID: 104864 RVA: 0x003BBEA4 File Offset: 0x003BA0A4
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
				if (num != 104U && num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.id_.AddEntriesFrom(ref input, SolarSchoolReachEndingRequest._repeated_id_codec);
				}
			}
		}

		// Token: 0x0400973B RID: 38715
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400973C RID: 38716
		public const int IdFieldNumber = 13;

		// Token: 0x0400973D RID: 38717
		private static readonly FieldCodec<int> _repeated_id_codec = FieldCodec.ForInt32(106U);

		// Token: 0x0400973E RID: 38718
		private readonly RepeatedField<int> id_ = new RepeatedField<int>();
	}
}
