using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200116F RID: 4463
	[NetMessage(EMessageId.RTimeStopAnimRequest)]
	public sealed class RTimeStopAnimRequest : IMessage<RTimeStopAnimRequest>, IMessage, IEquatable<RTimeStopAnimRequest>, IDeepCloneable<RTimeStopAnimRequest>, IBufferMessage
	{
		// Token: 0x06017D8B RID: 97675 RVA: 0x00378CB4 File Offset: 0x00376EB4
		[NullableContext(1)]
		public static RTimeStopAnimRequest Create()
		{
			return new RTimeStopAnimRequest();
		}

		// Token: 0x17005048 RID: 20552
		// (get) Token: 0x06017D8C RID: 97676 RVA: 0x00378CBB File Offset: 0x00376EBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005049 RID: 20553
		// (get) Token: 0x06017D8D RID: 97677 RVA: 0x00378CBE File Offset: 0x00376EBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RTimeStopAnimRequest.Descriptor;
			}
		}

		// Token: 0x06017D8E RID: 97678 RVA: 0x00378CC5 File Offset: 0x00376EC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopAnimRequest()
		{
		}

		// Token: 0x06017D8F RID: 97679 RVA: 0x00378CCD File Offset: 0x00376ECD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopAnimRequest(RTimeStopAnimRequest other) : this()
		{
			this.duration_ = other.duration_;
			this.dilation_ = other.dilation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017D90 RID: 97680 RVA: 0x00378CFE File Offset: 0x00376EFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopAnimRequest Clone()
		{
			return new RTimeStopAnimRequest(this);
		}

		// Token: 0x1700504A RID: 20554
		// (get) Token: 0x06017D91 RID: 97681 RVA: 0x00378D06 File Offset: 0x00376F06
		// (set) Token: 0x06017D92 RID: 97682 RVA: 0x00378D0E File Offset: 0x00376F0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Duration
		{
			get
			{
				return this.duration_;
			}
			set
			{
				this.duration_ = value;
			}
		}

		// Token: 0x1700504B RID: 20555
		// (get) Token: 0x06017D93 RID: 97683 RVA: 0x00378D17 File Offset: 0x00376F17
		// (set) Token: 0x06017D94 RID: 97684 RVA: 0x00378D1F File Offset: 0x00376F1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Dilation
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

		// Token: 0x06017D95 RID: 97685 RVA: 0x00378D28 File Offset: 0x00376F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RTimeStopAnimRequest);
		}

		// Token: 0x06017D96 RID: 97686 RVA: 0x00378D36 File Offset: 0x00376F36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RTimeStopAnimRequest other)
		{
			return other != null && (other == this || (this.Duration == other.Duration && this.Dilation == other.Dilation && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017D97 RID: 97687 RVA: 0x00378D74 File Offset: 0x00376F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Duration != 0)
			{
				num ^= this.Duration.GetHashCode();
			}
			if (this.Dilation != 0)
			{
				num ^= this.Dilation.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017D98 RID: 97688 RVA: 0x00378DCC File Offset: 0x00376FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017D99 RID: 97689 RVA: 0x00378DD9 File Offset: 0x00376FD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017D9A RID: 97690 RVA: 0x00378DE4 File Offset: 0x00376FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Duration != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Duration);
			}
			if (this.Dilation != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Dilation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017D9B RID: 97691 RVA: 0x00378E40 File Offset: 0x00377040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Duration != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Duration);
			}
			if (this.Dilation != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Dilation);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017D9C RID: 97692 RVA: 0x00378E98 File Offset: 0x00377098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RTimeStopAnimRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Duration != 0)
			{
				this.Duration = other.Duration;
			}
			if (other.Dilation != 0)
			{
				this.Dilation = other.Dilation;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017D9D RID: 97693 RVA: 0x00378EE8 File Offset: 0x003770E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017D9E RID: 97694 RVA: 0x00378EF4 File Offset: 0x003770F4
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
				if (num != 16U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Dilation = input.ReadInt32();
					}
				}
				else
				{
					this.Duration = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008E3C RID: 36412
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E3D RID: 36413
		public const int DurationFieldNumber = 2;

		// Token: 0x04008E3E RID: 36414
		private int duration_;

		// Token: 0x04008E3F RID: 36415
		public const int DilationFieldNumber = 7;

		// Token: 0x04008E40 RID: 36416
		private int dilation_;
	}
}
