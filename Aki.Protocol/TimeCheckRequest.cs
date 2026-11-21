using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013E0 RID: 5088
	[NetMessage(EMessageId.TimeCheckRequest)]
	public sealed class TimeCheckRequest : IMessage<TimeCheckRequest>, IMessage, IEquatable<TimeCheckRequest>, IDeepCloneable<TimeCheckRequest>, IBufferMessage
	{
		// Token: 0x0601B109 RID: 110857 RVA: 0x003F0923 File Offset: 0x003EEB23
		[NullableContext(1)]
		public static TimeCheckRequest Create()
		{
			return new TimeCheckRequest();
		}

		// Token: 0x17005BA4 RID: 23460
		// (get) Token: 0x0601B10A RID: 110858 RVA: 0x003F092A File Offset: 0x003EEB2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BA5 RID: 23461
		// (get) Token: 0x0601B10B RID: 110859 RVA: 0x003F092D File Offset: 0x003EEB2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimeCheckRequest.Descriptor;
			}
		}

		// Token: 0x0601B10C RID: 110860 RVA: 0x003F0934 File Offset: 0x003EEB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeCheckRequest()
		{
		}

		// Token: 0x0601B10D RID: 110861 RVA: 0x003F093C File Offset: 0x003EEB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeCheckRequest(TimeCheckRequest other) : this()
		{
			this.clientTime_ = other.clientTime_;
			this.dilation_ = other.dilation_;
			this.rDilation_ = other.rDilation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B10E RID: 110862 RVA: 0x003F0979 File Offset: 0x003EEB79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeCheckRequest Clone()
		{
			return new TimeCheckRequest(this);
		}

		// Token: 0x17005BA6 RID: 23462
		// (get) Token: 0x0601B10F RID: 110863 RVA: 0x003F0981 File Offset: 0x003EEB81
		// (set) Token: 0x0601B110 RID: 110864 RVA: 0x003F0989 File Offset: 0x003EEB89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ClientTime
		{
			get
			{
				return this.clientTime_;
			}
			set
			{
				this.clientTime_ = value;
			}
		}

		// Token: 0x17005BA7 RID: 23463
		// (get) Token: 0x0601B111 RID: 110865 RVA: 0x003F0992 File Offset: 0x003EEB92
		// (set) Token: 0x0601B112 RID: 110866 RVA: 0x003F099A File Offset: 0x003EEB9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Dilation
		{
			get
			{
				return this.dilation_;
			}
			set
			{
				this.dilation_ = value;
			}
		}

		// Token: 0x17005BA8 RID: 23464
		// (get) Token: 0x0601B113 RID: 110867 RVA: 0x003F09A3 File Offset: 0x003EEBA3
		// (set) Token: 0x0601B114 RID: 110868 RVA: 0x003F09AB File Offset: 0x003EEBAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float RDilation
		{
			get
			{
				return this.rDilation_;
			}
			set
			{
				this.rDilation_ = value;
			}
		}

		// Token: 0x0601B115 RID: 110869 RVA: 0x003F09B4 File Offset: 0x003EEBB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimeCheckRequest);
		}

		// Token: 0x0601B116 RID: 110870 RVA: 0x003F09C4 File Offset: 0x003EEBC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimeCheckRequest other)
		{
			return other != null && (other == this || (this.ClientTime == other.ClientTime && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Dilation, other.Dilation) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.RDilation, other.RDilation) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B117 RID: 110871 RVA: 0x003F0A34 File Offset: 0x003EEC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ClientTime != 0L)
			{
				num ^= this.ClientTime.GetHashCode();
			}
			if (this.Dilation != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Dilation);
			}
			if (this.RDilation != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.RDilation);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B118 RID: 110872 RVA: 0x003F0AB3 File Offset: 0x003EECB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B119 RID: 110873 RVA: 0x003F0AC0 File Offset: 0x003EECC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B11A RID: 110874 RVA: 0x003F0ACC File Offset: 0x003EECCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RDilation != 0f)
			{
				output.WriteRawTag(61);
				output.WriteFloat(this.RDilation);
			}
			if (this.ClientTime != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.ClientTime);
			}
			if (this.Dilation != 0f)
			{
				output.WriteRawTag(125);
				output.WriteFloat(this.Dilation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B11B RID: 110875 RVA: 0x003F0B4C File Offset: 0x003EED4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ClientTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ClientTime);
			}
			if (this.Dilation != 0f)
			{
				num += 5;
			}
			if (this.RDilation != 0f)
			{
				num += 5;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B11C RID: 110876 RVA: 0x003F0BAC File Offset: 0x003EEDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimeCheckRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ClientTime != 0L)
			{
				this.ClientTime = other.ClientTime;
			}
			if (other.Dilation != 0f)
			{
				this.Dilation = other.Dilation;
			}
			if (other.RDilation != 0f)
			{
				this.RDilation = other.RDilation;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B11D RID: 110877 RVA: 0x003F0C1A File Offset: 0x003EEE1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B11E RID: 110878 RVA: 0x003F0C24 File Offset: 0x003EEE24
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
				if (num != 61U)
				{
					if (num != 64U)
					{
						if (num != 125U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Dilation = input.ReadFloat();
						}
					}
					else
					{
						this.ClientTime = input.ReadInt64();
					}
				}
				else
				{
					this.RDilation = input.ReadFloat();
				}
			}
		}

		// Token: 0x04009E0A RID: 40458
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E0B RID: 40459
		public const int ClientTimeFieldNumber = 8;

		// Token: 0x04009E0C RID: 40460
		private long clientTime_;

		// Token: 0x04009E0D RID: 40461
		public const int DilationFieldNumber = 15;

		// Token: 0x04009E0E RID: 40462
		private float dilation_;

		// Token: 0x04009E0F RID: 40463
		public const int RDilationFieldNumber = 7;

		// Token: 0x04009E10 RID: 40464
		private float rDilation_;
	}
}
