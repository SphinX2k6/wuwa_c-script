using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012C2 RID: 4802
	[NetMessage(EMessageId.SolarSchoolSaveResponse)]
	public sealed class SolarSchoolSaveResponse : IMessage<SolarSchoolSaveResponse>, IMessage, IEquatable<SolarSchoolSaveResponse>, IDeepCloneable<SolarSchoolSaveResponse>, IBufferMessage
	{
		// Token: 0x06019A27 RID: 104999 RVA: 0x003BDA4F File Offset: 0x003BBC4F
		[NullableContext(1)]
		public static SolarSchoolSaveResponse Create()
		{
			return new SolarSchoolSaveResponse();
		}

		// Token: 0x170056CE RID: 22222
		// (get) Token: 0x06019A28 RID: 105000 RVA: 0x003BDA56 File Offset: 0x003BBC56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056CF RID: 22223
		// (get) Token: 0x06019A29 RID: 105001 RVA: 0x003BDA59 File Offset: 0x003BBC59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolSaveResponse.Descriptor;
			}
		}

		// Token: 0x06019A2A RID: 105002 RVA: 0x003BDA60 File Offset: 0x003BBC60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSaveResponse()
		{
		}

		// Token: 0x06019A2B RID: 105003 RVA: 0x003BDA73 File Offset: 0x003BBC73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSaveResponse(SolarSchoolSaveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.flow_ = other.flow_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019A2C RID: 105004 RVA: 0x003BDAA9 File Offset: 0x003BBCA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSaveResponse Clone()
		{
			return new SolarSchoolSaveResponse(this);
		}

		// Token: 0x170056D0 RID: 22224
		// (get) Token: 0x06019A2D RID: 105005 RVA: 0x003BDAB1 File Offset: 0x003BBCB1
		// (set) Token: 0x06019A2E RID: 105006 RVA: 0x003BDAB9 File Offset: 0x003BBCB9
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

		// Token: 0x170056D1 RID: 22225
		// (get) Token: 0x06019A2F RID: 105007 RVA: 0x003BDAC2 File Offset: 0x003BBCC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SolarSchoolFlowPb> Flow
		{
			get
			{
				return this.flow_;
			}
		}

		// Token: 0x06019A30 RID: 105008 RVA: 0x003BDACA File Offset: 0x003BBCCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolSaveResponse);
		}

		// Token: 0x06019A31 RID: 105009 RVA: 0x003BDAD8 File Offset: 0x003BBCD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolSaveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.flow_.Equals(other.flow_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019A32 RID: 105010 RVA: 0x003BDB28 File Offset: 0x003BBD28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.flow_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019A33 RID: 105011 RVA: 0x003BDB7B File Offset: 0x003BBD7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019A34 RID: 105012 RVA: 0x003BDB88 File Offset: 0x003BBD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019A35 RID: 105013 RVA: 0x003BDB94 File Offset: 0x003BBD94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.flow_.WriteTo(ref output, SolarSchoolSaveResponse._repeated_flow_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019A36 RID: 105014 RVA: 0x003BDBE4 File Offset: 0x003BBDE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.flow_.CalculateSize(SolarSchoolSaveResponse._repeated_flow_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019A37 RID: 105015 RVA: 0x003BDC38 File Offset: 0x003BBE38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolSaveResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.flow_.Add(other.flow_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019A38 RID: 105016 RVA: 0x003BDC85 File Offset: 0x003BBE85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019A39 RID: 105017 RVA: 0x003BDC90 File Offset: 0x003BBE90
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
				if (num != 90U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.flow_.AddEntriesFrom(ref input, SolarSchoolSaveResponse._repeated_flow_codec);
				}
			}
		}

		// Token: 0x0400977A RID: 38778
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400977B RID: 38779
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x0400977C RID: 38780
		private ErrorCode errorCode_;

		// Token: 0x0400977D RID: 38781
		public const int FlowFieldNumber = 11;

		// Token: 0x0400977E RID: 38782
		private static readonly FieldCodec<SolarSchoolFlowPb> _repeated_flow_codec = FieldCodec.ForMessage<SolarSchoolFlowPb>(90U, SolarSchoolFlowPb.Parser);

		// Token: 0x0400977F RID: 38783
		private readonly RepeatedField<SolarSchoolFlowPb> flow_ = new RepeatedField<SolarSchoolFlowPb>();
	}
}
