using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012C4 RID: 4804
	[NetMessage(EMessageId.SolarSchoolSetFlowRequest)]
	public sealed class SolarSchoolSetFlowRequest : IMessage<SolarSchoolSetFlowRequest>, IMessage, IEquatable<SolarSchoolSetFlowRequest>, IDeepCloneable<SolarSchoolSetFlowRequest>, IBufferMessage
	{
		// Token: 0x06019A4D RID: 105037 RVA: 0x003BDEE1 File Offset: 0x003BC0E1
		[NullableContext(1)]
		public static SolarSchoolSetFlowRequest Create()
		{
			return new SolarSchoolSetFlowRequest();
		}

		// Token: 0x170056D5 RID: 22229
		// (get) Token: 0x06019A4E RID: 105038 RVA: 0x003BDEE8 File Offset: 0x003BC0E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056D6 RID: 22230
		// (get) Token: 0x06019A4F RID: 105039 RVA: 0x003BDEEB File Offset: 0x003BC0EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolSetFlowRequest.Descriptor;
			}
		}

		// Token: 0x06019A50 RID: 105040 RVA: 0x003BDEF2 File Offset: 0x003BC0F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSetFlowRequest()
		{
		}

		// Token: 0x06019A51 RID: 105041 RVA: 0x003BDF05 File Offset: 0x003BC105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSetFlowRequest(SolarSchoolSetFlowRequest other) : this()
		{
			this.solarSchoolFlowId_ = other.solarSchoolFlowId_;
			this.readPlot_ = other.readPlot_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019A52 RID: 105042 RVA: 0x003BDF3B File Offset: 0x003BC13B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSetFlowRequest Clone()
		{
			return new SolarSchoolSetFlowRequest(this);
		}

		// Token: 0x170056D7 RID: 22231
		// (get) Token: 0x06019A53 RID: 105043 RVA: 0x003BDF43 File Offset: 0x003BC143
		// (set) Token: 0x06019A54 RID: 105044 RVA: 0x003BDF4B File Offset: 0x003BC14B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SolarSchoolFlowId
		{
			get
			{
				return this.solarSchoolFlowId_;
			}
			set
			{
				this.solarSchoolFlowId_ = value;
			}
		}

		// Token: 0x170056D8 RID: 22232
		// (get) Token: 0x06019A55 RID: 105045 RVA: 0x003BDF54 File Offset: 0x003BC154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ReadPlot
		{
			get
			{
				return this.readPlot_;
			}
		}

		// Token: 0x06019A56 RID: 105046 RVA: 0x003BDF5C File Offset: 0x003BC15C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolSetFlowRequest);
		}

		// Token: 0x06019A57 RID: 105047 RVA: 0x003BDF6C File Offset: 0x003BC16C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolSetFlowRequest other)
		{
			return other != null && (other == this || (this.SolarSchoolFlowId == other.SolarSchoolFlowId && this.readPlot_.Equals(other.readPlot_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019A58 RID: 105048 RVA: 0x003BDFBC File Offset: 0x003BC1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SolarSchoolFlowId != 0)
			{
				num ^= this.SolarSchoolFlowId.GetHashCode();
			}
			num ^= this.readPlot_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019A59 RID: 105049 RVA: 0x003BE009 File Offset: 0x003BC209
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019A5A RID: 105050 RVA: 0x003BE016 File Offset: 0x003BC216
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019A5B RID: 105051 RVA: 0x003BE020 File Offset: 0x003BC220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SolarSchoolFlowId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SolarSchoolFlowId);
			}
			this.readPlot_.WriteTo(ref output, SolarSchoolSetFlowRequest._repeated_readPlot_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019A5C RID: 105052 RVA: 0x003BE070 File Offset: 0x003BC270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SolarSchoolFlowId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SolarSchoolFlowId);
			}
			num += this.readPlot_.CalculateSize(SolarSchoolSetFlowRequest._repeated_readPlot_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019A5D RID: 105053 RVA: 0x003BE0C4 File Offset: 0x003BC2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolSetFlowRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SolarSchoolFlowId != 0)
			{
				this.SolarSchoolFlowId = other.SolarSchoolFlowId;
			}
			this.readPlot_.Add(other.readPlot_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019A5E RID: 105054 RVA: 0x003BE111 File Offset: 0x003BC311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019A5F RID: 105055 RVA: 0x003BE11C File Offset: 0x003BC31C
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
				if (num != 40U)
				{
					if (num != 48U && num != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.readPlot_.AddEntriesFrom(ref input, SolarSchoolSetFlowRequest._repeated_readPlot_codec);
					}
				}
				else
				{
					this.SolarSchoolFlowId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009784 RID: 38788
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009785 RID: 38789
		public const int SolarSchoolFlowIdFieldNumber = 5;

		// Token: 0x04009786 RID: 38790
		private int solarSchoolFlowId_;

		// Token: 0x04009787 RID: 38791
		public const int ReadPlotFieldNumber = 6;

		// Token: 0x04009788 RID: 38792
		private static readonly FieldCodec<int> _repeated_readPlot_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04009789 RID: 38793
		private readonly RepeatedField<int> readPlot_ = new RepeatedField<int>();
	}
}
