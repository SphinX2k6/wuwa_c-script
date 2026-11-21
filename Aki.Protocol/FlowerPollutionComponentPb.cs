using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005E5 RID: 1509
	public sealed class FlowerPollutionComponentPb : IMessage<FlowerPollutionComponentPb>, IMessage, IEquatable<FlowerPollutionComponentPb>, IDeepCloneable<FlowerPollutionComponentPb>, IBufferMessage
	{
		// Token: 0x06008C32 RID: 35890 RVA: 0x00154A41 File Offset: 0x00152C41
		[NullableContext(1)]
		public static FlowerPollutionComponentPb Create()
		{
			return new FlowerPollutionComponentPb();
		}

		// Token: 0x17001BC7 RID: 7111
		// (get) Token: 0x06008C33 RID: 35891 RVA: 0x00154A48 File Offset: 0x00152C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BC8 RID: 7112
		// (get) Token: 0x06008C34 RID: 35892 RVA: 0x00154A4B File Offset: 0x00152C4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowerPollutionComponentPb.Descriptor;
			}
		}

		// Token: 0x06008C35 RID: 35893 RVA: 0x00154A52 File Offset: 0x00152C52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowerPollutionComponentPb()
		{
		}

		// Token: 0x06008C36 RID: 35894 RVA: 0x00154A65 File Offset: 0x00152C65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowerPollutionComponentPb(FlowerPollutionComponentPb other) : this()
		{
			this.unPollutionSpline_ = other.unPollutionSpline_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008C37 RID: 35895 RVA: 0x00154A8F File Offset: 0x00152C8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowerPollutionComponentPb Clone()
		{
			return new FlowerPollutionComponentPb(this);
		}

		// Token: 0x17001BC9 RID: 7113
		// (get) Token: 0x06008C38 RID: 35896 RVA: 0x00154A97 File Offset: 0x00152C97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnPollutionSpline
		{
			get
			{
				return this.unPollutionSpline_;
			}
		}

		// Token: 0x06008C39 RID: 35897 RVA: 0x00154A9F File Offset: 0x00152C9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowerPollutionComponentPb);
		}

		// Token: 0x06008C3A RID: 35898 RVA: 0x00154AAD File Offset: 0x00152CAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowerPollutionComponentPb other)
		{
			return other != null && (other == this || (this.unPollutionSpline_.Equals(other.unPollutionSpline_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008C3B RID: 35899 RVA: 0x00154AE0 File Offset: 0x00152CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unPollutionSpline_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008C3C RID: 35900 RVA: 0x00154B14 File Offset: 0x00152D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008C3D RID: 35901 RVA: 0x00154B21 File Offset: 0x00152D21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008C3E RID: 35902 RVA: 0x00154B2A File Offset: 0x00152D2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unPollutionSpline_.WriteTo(ref output, FlowerPollutionComponentPb._repeated_unPollutionSpline_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008C3F RID: 35903 RVA: 0x00154B54 File Offset: 0x00152D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unPollutionSpline_.CalculateSize(FlowerPollutionComponentPb._repeated_unPollutionSpline_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008C40 RID: 35904 RVA: 0x00154B8D File Offset: 0x00152D8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlowerPollutionComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			this.unPollutionSpline_.Add(other.unPollutionSpline_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008C41 RID: 35905 RVA: 0x00154BBB File Offset: 0x00152DBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008C42 RID: 35906 RVA: 0x00154BC4 File Offset: 0x00152DC4
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unPollutionSpline_.AddEntriesFrom(ref input, FlowerPollutionComponentPb._repeated_unPollutionSpline_codec);
				}
			}
		}

		// Token: 0x04004510 RID: 17680
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004511 RID: 17681
		public const int UnPollutionSplineFieldNumber = 1;

		// Token: 0x04004512 RID: 17682
		private static readonly FieldCodec<int> _repeated_unPollutionSpline_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04004513 RID: 17683
		private readonly RepeatedField<int> unPollutionSpline_ = new RepeatedField<int>();
	}
}
