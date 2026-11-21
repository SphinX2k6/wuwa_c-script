using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012C5 RID: 4805
	[NetMessage(EMessageId.SolarSchoolSetFlowResponse)]
	public sealed class SolarSchoolSetFlowResponse : IMessage<SolarSchoolSetFlowResponse>, IMessage, IEquatable<SolarSchoolSetFlowResponse>, IDeepCloneable<SolarSchoolSetFlowResponse>, IBufferMessage
	{
		// Token: 0x06019A61 RID: 105057 RVA: 0x003BE18C File Offset: 0x003BC38C
		[NullableContext(1)]
		public static SolarSchoolSetFlowResponse Create()
		{
			return new SolarSchoolSetFlowResponse();
		}

		// Token: 0x170056D9 RID: 22233
		// (get) Token: 0x06019A62 RID: 105058 RVA: 0x003BE193 File Offset: 0x003BC393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056DA RID: 22234
		// (get) Token: 0x06019A63 RID: 105059 RVA: 0x003BE196 File Offset: 0x003BC396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolSetFlowResponse.Descriptor;
			}
		}

		// Token: 0x06019A64 RID: 105060 RVA: 0x003BE19D File Offset: 0x003BC39D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSetFlowResponse()
		{
		}

		// Token: 0x06019A65 RID: 105061 RVA: 0x003BE1A5 File Offset: 0x003BC3A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSetFlowResponse(SolarSchoolSetFlowResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019A66 RID: 105062 RVA: 0x003BE1CA File Offset: 0x003BC3CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSetFlowResponse Clone()
		{
			return new SolarSchoolSetFlowResponse(this);
		}

		// Token: 0x170056DB RID: 22235
		// (get) Token: 0x06019A67 RID: 105063 RVA: 0x003BE1D2 File Offset: 0x003BC3D2
		// (set) Token: 0x06019A68 RID: 105064 RVA: 0x003BE1DA File Offset: 0x003BC3DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x06019A69 RID: 105065 RVA: 0x003BE1E3 File Offset: 0x003BC3E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolSetFlowResponse);
		}

		// Token: 0x06019A6A RID: 105066 RVA: 0x003BE1F1 File Offset: 0x003BC3F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolSetFlowResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019A6B RID: 105067 RVA: 0x003BE220 File Offset: 0x003BC420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019A6C RID: 105068 RVA: 0x003BE265 File Offset: 0x003BC465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019A6D RID: 105069 RVA: 0x003BE272 File Offset: 0x003BC472
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019A6E RID: 105070 RVA: 0x003BE27B File Offset: 0x003BC47B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019A6F RID: 105071 RVA: 0x003BE2B0 File Offset: 0x003BC4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019A70 RID: 105072 RVA: 0x003BE2EE File Offset: 0x003BC4EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolSetFlowResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019A71 RID: 105073 RVA: 0x003BE31F File Offset: 0x003BC51F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019A72 RID: 105074 RVA: 0x003BE328 File Offset: 0x003BC528
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400978A RID: 38794
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400978B RID: 38795
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x0400978C RID: 38796
		private ErrorCode errorCode_;
	}
}
