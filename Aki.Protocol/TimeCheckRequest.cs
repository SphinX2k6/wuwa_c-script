using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200136D RID: 4973
	[NetMessage(EMessageId.TimeCheckRequest)]
	public sealed class TimeCheckRequest : IMessage<TimeCheckRequest>, IMessage, IEquatable<TimeCheckRequest>, IDeepCloneable<TimeCheckRequest>, IBufferMessage
	{
		// Token: 0x0601A680 RID: 108160 RVA: 0x003D5713 File Offset: 0x003D3913
		[NullableContext(1)]
		public static TimeCheckRequest Create()
		{
			return new TimeCheckRequest();
		}

		// Token: 0x17005910 RID: 22800
		// (get) Token: 0x0601A681 RID: 108161 RVA: 0x003D571A File Offset: 0x003D391A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005911 RID: 22801
		// (get) Token: 0x0601A682 RID: 108162 RVA: 0x003D571D File Offset: 0x003D391D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimeCheckRequest.Descriptor;
			}
		}

		// Token: 0x0601A683 RID: 108163 RVA: 0x003D5724 File Offset: 0x003D3924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeCheckRequest()
		{
		}

		// Token: 0x0601A684 RID: 108164 RVA: 0x003D572C File Offset: 0x003D392C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeCheckRequest(TimeCheckRequest other) : this()
		{
			this.clientTime_ = other.clientTime_;
			this.dilation_ = other.dilation_;
			this.rDilation_ = other.rDilation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A685 RID: 108165 RVA: 0x003D5769 File Offset: 0x003D3969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeCheckRequest Clone()
		{
			return new TimeCheckRequest(this);
		}

		// Token: 0x17005912 RID: 22802
		// (get) Token: 0x0601A686 RID: 108166 RVA: 0x003D5771 File Offset: 0x003D3971
		// (set) Token: 0x0601A687 RID: 108167 RVA: 0x003D5779 File Offset: 0x003D3979
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

		// Token: 0x17005913 RID: 22803
		// (get) Token: 0x0601A688 RID: 108168 RVA: 0x003D5782 File Offset: 0x003D3982
		// (set) Token: 0x0601A689 RID: 108169 RVA: 0x003D578A File Offset: 0x003D398A
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

		// Token: 0x17005914 RID: 22804
		// (get) Token: 0x0601A68A RID: 108170 RVA: 0x003D5793 File Offset: 0x003D3993
		// (set) Token: 0x0601A68B RID: 108171 RVA: 0x003D579B File Offset: 0x003D399B
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

		// Token: 0x0601A68C RID: 108172 RVA: 0x003D57A4 File Offset: 0x003D39A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimeCheckRequest);
		}

		// Token: 0x0601A68D RID: 108173 RVA: 0x003D57B4 File Offset: 0x003D39B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimeCheckRequest other)
		{
			return other != null && (other == this || (this.ClientTime == other.ClientTime && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Dilation, other.Dilation) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.RDilation, other.RDilation) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A68E RID: 108174 RVA: 0x003D5824 File Offset: 0x003D3A24
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

		// Token: 0x0601A68F RID: 108175 RVA: 0x003D58A3 File Offset: 0x003D3AA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A690 RID: 108176 RVA: 0x003D58B0 File Offset: 0x003D3AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A691 RID: 108177 RVA: 0x003D58BC File Offset: 0x003D3ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Dilation != 0f)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.Dilation);
			}
			if (this.ClientTime != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.ClientTime);
			}
			if (this.RDilation != 0f)
			{
				output.WriteRawTag(77);
				output.WriteFloat(this.RDilation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A692 RID: 108178 RVA: 0x003D593C File Offset: 0x003D3B3C
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

		// Token: 0x0601A693 RID: 108179 RVA: 0x003D599C File Offset: 0x003D3B9C
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

		// Token: 0x0601A694 RID: 108180 RVA: 0x003D5A0A File Offset: 0x003D3C0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A695 RID: 108181 RVA: 0x003D5A14 File Offset: 0x003D3C14
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
				if (num != 13U)
				{
					if (num != 32U)
					{
						if (num != 77U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.RDilation = input.ReadFloat();
						}
					}
					else
					{
						this.ClientTime = input.ReadInt64();
					}
				}
				else
				{
					this.Dilation = input.ReadFloat();
				}
			}
		}

		// Token: 0x040099C5 RID: 39365
		private UnknownFieldSet _unknownFields;

		// Token: 0x040099C6 RID: 39366
		public const int ClientTimeFieldNumber = 4;

		// Token: 0x040099C7 RID: 39367
		private long clientTime_;

		// Token: 0x040099C8 RID: 39368
		public const int DilationFieldNumber = 1;

		// Token: 0x040099C9 RID: 39369
		private float dilation_;

		// Token: 0x040099CA RID: 39370
		public const int RDilationFieldNumber = 9;

		// Token: 0x040099CB RID: 39371
		private float rDilation_;
	}
}
