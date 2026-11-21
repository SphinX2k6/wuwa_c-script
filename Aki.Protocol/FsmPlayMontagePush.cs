using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000659 RID: 1625
	[NetMessage(EMessageId.FsmPlayMontagePush)]
	public sealed class FsmPlayMontagePush : IMessage<FsmPlayMontagePush>, IMessage, IEquatable<FsmPlayMontagePush>, IDeepCloneable<FsmPlayMontagePush>, IBufferMessage
	{
		// Token: 0x06009587 RID: 38279 RVA: 0x001692E3 File Offset: 0x001674E3
		[NullableContext(1)]
		public static FsmPlayMontagePush Create()
		{
			return new FsmPlayMontagePush();
		}

		// Token: 0x17001DC0 RID: 7616
		// (get) Token: 0x06009588 RID: 38280 RVA: 0x001692EA File Offset: 0x001674EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DC1 RID: 7617
		// (get) Token: 0x06009589 RID: 38281 RVA: 0x001692ED File Offset: 0x001674ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FsmPlayMontagePush.Descriptor;
			}
		}

		// Token: 0x0600958A RID: 38282 RVA: 0x001692F4 File Offset: 0x001674F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmPlayMontagePush()
		{
		}

		// Token: 0x0600958B RID: 38283 RVA: 0x00169314 File Offset: 0x00167514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmPlayMontagePush(FsmPlayMontagePush other) : this()
		{
			this.montageName_ = other.montageName_;
			this.montageHashCode_ = other.montageHashCode_;
			this.speedRatio_ = other.speedRatio_;
			this.startSection_ = other.startSection_;
			this.startTimeSeconds_ = other.startTimeSeconds_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600958C RID: 38284 RVA: 0x00169374 File Offset: 0x00167574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmPlayMontagePush Clone()
		{
			return new FsmPlayMontagePush(this);
		}

		// Token: 0x17001DC2 RID: 7618
		// (get) Token: 0x0600958D RID: 38285 RVA: 0x0016937C File Offset: 0x0016757C
		// (set) Token: 0x0600958E RID: 38286 RVA: 0x00169384 File Offset: 0x00167584
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

		// Token: 0x17001DC3 RID: 7619
		// (get) Token: 0x0600958F RID: 38287 RVA: 0x00169397 File Offset: 0x00167597
		// (set) Token: 0x06009590 RID: 38288 RVA: 0x0016939F File Offset: 0x0016759F
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

		// Token: 0x17001DC4 RID: 7620
		// (get) Token: 0x06009591 RID: 38289 RVA: 0x001693A8 File Offset: 0x001675A8
		// (set) Token: 0x06009592 RID: 38290 RVA: 0x001693B0 File Offset: 0x001675B0
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

		// Token: 0x17001DC5 RID: 7621
		// (get) Token: 0x06009593 RID: 38291 RVA: 0x001693B9 File Offset: 0x001675B9
		// (set) Token: 0x06009594 RID: 38292 RVA: 0x001693C1 File Offset: 0x001675C1
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

		// Token: 0x17001DC6 RID: 7622
		// (get) Token: 0x06009595 RID: 38293 RVA: 0x001693D4 File Offset: 0x001675D4
		// (set) Token: 0x06009596 RID: 38294 RVA: 0x001693DC File Offset: 0x001675DC
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

		// Token: 0x06009597 RID: 38295 RVA: 0x001693E5 File Offset: 0x001675E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FsmPlayMontagePush);
		}

		// Token: 0x06009598 RID: 38296 RVA: 0x001693F4 File Offset: 0x001675F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FsmPlayMontagePush other)
		{
			return other != null && (other == this || (!(this.MontageName != other.MontageName) && this.MontageHashCode == other.MontageHashCode && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.SpeedRatio, other.SpeedRatio) && !(this.StartSection != other.StartSection) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.StartTimeSeconds, other.StartTimeSeconds) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009599 RID: 38297 RVA: 0x0016948C File Offset: 0x0016768C
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

		// Token: 0x0600959A RID: 38298 RVA: 0x00169541 File Offset: 0x00167741
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600959B RID: 38299 RVA: 0x0016954E File Offset: 0x0016774E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600959C RID: 38300 RVA: 0x00169558 File Offset: 0x00167758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MontageHashCode != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MontageHashCode);
			}
			if (this.StartSection.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.StartSection);
			}
			if (this.MontageName.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteString(this.MontageName);
			}
			if (this.SpeedRatio != 0f)
			{
				output.WriteRawTag(109);
				output.WriteFloat(this.SpeedRatio);
			}
			if (this.StartTimeSeconds != 0f)
			{
				output.WriteRawTag(125);
				output.WriteFloat(this.StartTimeSeconds);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600959D RID: 38301 RVA: 0x0016961C File Offset: 0x0016781C
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

		// Token: 0x0600959E RID: 38302 RVA: 0x001696B8 File Offset: 0x001678B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FsmPlayMontagePush other)
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

		// Token: 0x0600959F RID: 38303 RVA: 0x00169758 File Offset: 0x00167958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060095A0 RID: 38304 RVA: 0x00169764 File Offset: 0x00167964
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
				if (num <= 74U)
				{
					if (num == 16U)
					{
						this.MontageHashCode = input.ReadInt32();
						continue;
					}
					if (num == 74U)
					{
						this.StartSection = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						this.MontageName = input.ReadString();
						continue;
					}
					if (num == 109U)
					{
						this.SpeedRatio = input.ReadFloat();
						continue;
					}
					if (num == 125U)
					{
						this.StartTimeSeconds = input.ReadFloat();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040047C7 RID: 18375
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047C8 RID: 18376
		public const int MontageNameFieldNumber = 12;

		// Token: 0x040047C9 RID: 18377
		private string montageName_ = "";

		// Token: 0x040047CA RID: 18378
		public const int MontageHashCodeFieldNumber = 2;

		// Token: 0x040047CB RID: 18379
		private int montageHashCode_;

		// Token: 0x040047CC RID: 18380
		public const int SpeedRatioFieldNumber = 13;

		// Token: 0x040047CD RID: 18381
		private float speedRatio_;

		// Token: 0x040047CE RID: 18382
		public const int StartSectionFieldNumber = 9;

		// Token: 0x040047CF RID: 18383
		private string startSection_ = "";

		// Token: 0x040047D0 RID: 18384
		public const int StartTimeSecondsFieldNumber = 15;

		// Token: 0x040047D1 RID: 18385
		private float startTimeSeconds_;
	}
}
