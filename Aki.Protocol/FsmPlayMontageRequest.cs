using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200065A RID: 1626
	[NetMessage(EMessageId.FsmPlayMontageRequest)]
	public sealed class FsmPlayMontageRequest : IMessage<FsmPlayMontageRequest>, IMessage, IEquatable<FsmPlayMontageRequest>, IDeepCloneable<FsmPlayMontageRequest>, IBufferMessage
	{
		// Token: 0x060095A1 RID: 38305 RVA: 0x001697FF File Offset: 0x001679FF
		[NullableContext(1)]
		public static FsmPlayMontageRequest Create()
		{
			return new FsmPlayMontageRequest();
		}

		// Token: 0x17001DC7 RID: 7623
		// (get) Token: 0x060095A2 RID: 38306 RVA: 0x00169806 File Offset: 0x00167A06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DC8 RID: 7624
		// (get) Token: 0x060095A3 RID: 38307 RVA: 0x00169809 File Offset: 0x00167A09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FsmPlayMontageRequest.Descriptor;
			}
		}

		// Token: 0x060095A4 RID: 38308 RVA: 0x00169810 File Offset: 0x00167A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmPlayMontageRequest()
		{
		}

		// Token: 0x060095A5 RID: 38309 RVA: 0x00169830 File Offset: 0x00167A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmPlayMontageRequest(FsmPlayMontageRequest other) : this()
		{
			this.montageName_ = other.montageName_;
			this.montageHashCode_ = other.montageHashCode_;
			this.speedRatio_ = other.speedRatio_;
			this.startSection_ = other.startSection_;
			this.startTimeSeconds_ = other.startTimeSeconds_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060095A6 RID: 38310 RVA: 0x00169890 File Offset: 0x00167A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmPlayMontageRequest Clone()
		{
			return new FsmPlayMontageRequest(this);
		}

		// Token: 0x17001DC9 RID: 7625
		// (get) Token: 0x060095A7 RID: 38311 RVA: 0x00169898 File Offset: 0x00167A98
		// (set) Token: 0x060095A8 RID: 38312 RVA: 0x001698A0 File Offset: 0x00167AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string MontageName
		{
			get
			{
				return this.montageName_;
			}
			set
			{
				this.montageName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001DCA RID: 7626
		// (get) Token: 0x060095A9 RID: 38313 RVA: 0x001698B3 File Offset: 0x00167AB3
		// (set) Token: 0x060095AA RID: 38314 RVA: 0x001698BB File Offset: 0x00167ABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MontageHashCode
		{
			get
			{
				return this.montageHashCode_;
			}
			set
			{
				this.montageHashCode_ = value;
			}
		}

		// Token: 0x17001DCB RID: 7627
		// (get) Token: 0x060095AB RID: 38315 RVA: 0x001698C4 File Offset: 0x00167AC4
		// (set) Token: 0x060095AC RID: 38316 RVA: 0x001698CC File Offset: 0x00167ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float SpeedRatio
		{
			get
			{
				return this.speedRatio_;
			}
			set
			{
				this.speedRatio_ = value;
			}
		}

		// Token: 0x17001DCC RID: 7628
		// (get) Token: 0x060095AD RID: 38317 RVA: 0x001698D5 File Offset: 0x00167AD5
		// (set) Token: 0x060095AE RID: 38318 RVA: 0x001698DD File Offset: 0x00167ADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string StartSection
		{
			get
			{
				return this.startSection_;
			}
			set
			{
				this.startSection_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001DCD RID: 7629
		// (get) Token: 0x060095AF RID: 38319 RVA: 0x001698F0 File Offset: 0x00167AF0
		// (set) Token: 0x060095B0 RID: 38320 RVA: 0x001698F8 File Offset: 0x00167AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float StartTimeSeconds
		{
			get
			{
				return this.startTimeSeconds_;
			}
			set
			{
				this.startTimeSeconds_ = value;
			}
		}

		// Token: 0x060095B1 RID: 38321 RVA: 0x00169901 File Offset: 0x00167B01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FsmPlayMontageRequest);
		}

		// Token: 0x060095B2 RID: 38322 RVA: 0x00169910 File Offset: 0x00167B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FsmPlayMontageRequest other)
		{
			return other != null && (other == this || (!(this.MontageName != other.MontageName) && this.MontageHashCode == other.MontageHashCode && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.SpeedRatio, other.SpeedRatio) && !(this.StartSection != other.StartSection) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.StartTimeSeconds, other.StartTimeSeconds) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060095B3 RID: 38323 RVA: 0x001699A8 File Offset: 0x00167BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MontageName.Length != 0)
			{
				num ^= this.MontageName.GetHashCode();
			}
			if (this.MontageHashCode != 0)
			{
				num ^= this.MontageHashCode.GetHashCode();
			}
			if (this.SpeedRatio != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.SpeedRatio);
			}
			if (this.StartSection.Length != 0)
			{
				num ^= this.StartSection.GetHashCode();
			}
			if (this.StartTimeSeconds != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.StartTimeSeconds);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060095B4 RID: 38324 RVA: 0x00169A5D File Offset: 0x00167C5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060095B5 RID: 38325 RVA: 0x00169A6A File Offset: 0x00167C6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060095B6 RID: 38326 RVA: 0x00169A74 File Offset: 0x00167C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StartTimeSeconds != 0f)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.StartTimeSeconds);
			}
			if (this.SpeedRatio != 0f)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.SpeedRatio);
			}
			if (this.MontageName.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.MontageName);
			}
			if (this.StartSection.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteString(this.StartSection);
			}
			if (this.MontageHashCode != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.MontageHashCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060095B7 RID: 38327 RVA: 0x00169B38 File Offset: 0x00167D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MontageName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.MontageName);
			}
			if (this.MontageHashCode != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MontageHashCode);
			}
			if (this.SpeedRatio != 0f)
			{
				num += 5;
			}
			if (this.StartSection.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.StartSection);
			}
			if (this.StartTimeSeconds != 0f)
			{
				num += 5;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060095B8 RID: 38328 RVA: 0x00169BD4 File Offset: 0x00167DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FsmPlayMontageRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MontageName.Length != 0)
			{
				this.MontageName = other.MontageName;
			}
			if (other.MontageHashCode != 0)
			{
				this.MontageHashCode = other.MontageHashCode;
			}
			if (other.SpeedRatio != 0f)
			{
				this.SpeedRatio = other.SpeedRatio;
			}
			if (other.StartSection.Length != 0)
			{
				this.StartSection = other.StartSection;
			}
			if (other.StartTimeSeconds != 0f)
			{
				this.StartTimeSeconds = other.StartTimeSeconds;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060095B9 RID: 38329 RVA: 0x00169C74 File Offset: 0x00167E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060095BA RID: 38330 RVA: 0x00169C80 File Offset: 0x00167E80
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
				if (num <= 29U)
				{
					if (num == 13U)
					{
						this.StartTimeSeconds = input.ReadFloat();
						continue;
					}
					if (num == 29U)
					{
						this.SpeedRatio = input.ReadFloat();
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						this.MontageName = input.ReadString();
						continue;
					}
					if (num == 98U)
					{
						this.StartSection = input.ReadString();
						continue;
					}
					if (num == 112U)
					{
						this.MontageHashCode = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040047D2 RID: 18386
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047D3 RID: 18387
		public const int MontageNameFieldNumber = 8;

		// Token: 0x040047D4 RID: 18388
		private string montageName_ = "";

		// Token: 0x040047D5 RID: 18389
		public const int MontageHashCodeFieldNumber = 14;

		// Token: 0x040047D6 RID: 18390
		private int montageHashCode_;

		// Token: 0x040047D7 RID: 18391
		public const int SpeedRatioFieldNumber = 3;

		// Token: 0x040047D8 RID: 18392
		private float speedRatio_;

		// Token: 0x040047D9 RID: 18393
		public const int StartSectionFieldNumber = 12;

		// Token: 0x040047DA RID: 18394
		private string startSection_ = "";

		// Token: 0x040047DB RID: 18395
		public const int StartTimeSecondsFieldNumber = 1;

		// Token: 0x040047DC RID: 18396
		private float startTimeSeconds_;
	}
}
