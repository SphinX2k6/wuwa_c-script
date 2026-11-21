using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012B1 RID: 4785
	[NetMessage(EMessageId.SolarSchoolLoadResponse)]
	public sealed class SolarSchoolLoadResponse : IMessage<SolarSchoolLoadResponse>, IMessage, IEquatable<SolarSchoolLoadResponse>, IDeepCloneable<SolarSchoolLoadResponse>, IBufferMessage
	{
		// Token: 0x060198AA RID: 104618 RVA: 0x003B9C42 File Offset: 0x003B7E42
		[NullableContext(1)]
		public static SolarSchoolLoadResponse Create()
		{
			return new SolarSchoolLoadResponse();
		}

		// Token: 0x17005672 RID: 22130
		// (get) Token: 0x060198AB RID: 104619 RVA: 0x003B9C49 File Offset: 0x003B7E49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005673 RID: 22131
		// (get) Token: 0x060198AC RID: 104620 RVA: 0x003B9C4C File Offset: 0x003B7E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolLoadResponse.Descriptor;
			}
		}

		// Token: 0x060198AD RID: 104621 RVA: 0x003B9C53 File Offset: 0x003B7E53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolLoadResponse()
		{
		}

		// Token: 0x060198AE RID: 104622 RVA: 0x003B9C68 File Offset: 0x003B7E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolLoadResponse(SolarSchoolLoadResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.savePb_ = ((other.savePb_ != null) ? other.savePb_.Clone() : null);
			this.flow_ = other.flow_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060198AF RID: 104623 RVA: 0x003B9CC5 File Offset: 0x003B7EC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolLoadResponse Clone()
		{
			return new SolarSchoolLoadResponse(this);
		}

		// Token: 0x17005674 RID: 22132
		// (get) Token: 0x060198B0 RID: 104624 RVA: 0x003B9CCD File Offset: 0x003B7ECD
		// (set) Token: 0x060198B1 RID: 104625 RVA: 0x003B9CD5 File Offset: 0x003B7ED5
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

		// Token: 0x17005675 RID: 22133
		// (get) Token: 0x060198B2 RID: 104626 RVA: 0x003B9CDE File Offset: 0x003B7EDE
		// (set) Token: 0x060198B3 RID: 104627 RVA: 0x003B9CE6 File Offset: 0x003B7EE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSavePb SavePb
		{
			get
			{
				return this.savePb_;
			}
			set
			{
				this.savePb_ = value;
			}
		}

		// Token: 0x17005676 RID: 22134
		// (get) Token: 0x060198B4 RID: 104628 RVA: 0x003B9CEF File Offset: 0x003B7EEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SolarSchoolFlowPb> Flow
		{
			get
			{
				return this.flow_;
			}
		}

		// Token: 0x060198B5 RID: 104629 RVA: 0x003B9CF7 File Offset: 0x003B7EF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolLoadResponse);
		}

		// Token: 0x060198B6 RID: 104630 RVA: 0x003B9D08 File Offset: 0x003B7F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolLoadResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.SavePb, other.SavePb) && this.flow_.Equals(other.flow_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060198B7 RID: 104631 RVA: 0x003B9D6C File Offset: 0x003B7F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.savePb_ != null)
			{
				num ^= this.SavePb.GetHashCode();
			}
			num ^= this.flow_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060198B8 RID: 104632 RVA: 0x003B9DD5 File Offset: 0x003B7FD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060198B9 RID: 104633 RVA: 0x003B9DE2 File Offset: 0x003B7FE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060198BA RID: 104634 RVA: 0x003B9DEC File Offset: 0x003B7FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.flow_.WriteTo(ref output, SolarSchoolLoadResponse._repeated_flow_codec);
			if (this.savePb_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.SavePb);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060198BB RID: 104635 RVA: 0x003B9E58 File Offset: 0x003B8058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.savePb_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SavePb);
			}
			num += this.flow_.CalculateSize(SolarSchoolLoadResponse._repeated_flow_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060198BC RID: 104636 RVA: 0x003B9EC4 File Offset: 0x003B80C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolLoadResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.savePb_ != null)
			{
				if (this.savePb_ == null)
				{
					this.SavePb = new SolarSchoolSavePb();
				}
				this.SavePb.MergeFrom(other.SavePb);
			}
			this.flow_.Add(other.flow_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060198BD RID: 104637 RVA: 0x003B9F3D File Offset: 0x003B813D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060198BE RID: 104638 RVA: 0x003B9F48 File Offset: 0x003B8148
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
				if (num != 24U)
				{
					if (num != 82U)
					{
						if (num != 98U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.savePb_ == null)
							{
								this.SavePb = new SolarSchoolSavePb();
							}
							input.ReadMessage(this.SavePb);
						}
					}
					else
					{
						this.flow_.AddEntriesFrom(ref input, SolarSchoolLoadResponse._repeated_flow_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040096EB RID: 38635
		private UnknownFieldSet _unknownFields;

		// Token: 0x040096EC RID: 38636
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x040096ED RID: 38637
		private ErrorCode errorCode_;

		// Token: 0x040096EE RID: 38638
		public const int SavePbFieldNumber = 12;

		// Token: 0x040096EF RID: 38639
		private SolarSchoolSavePb savePb_;

		// Token: 0x040096F0 RID: 38640
		public const int FlowFieldNumber = 10;

		// Token: 0x040096F1 RID: 38641
		private static readonly FieldCodec<SolarSchoolFlowPb> _repeated_flow_codec = FieldCodec.ForMessage<SolarSchoolFlowPb>(82U, SolarSchoolFlowPb.Parser);

		// Token: 0x040096F2 RID: 38642
		private readonly RepeatedField<SolarSchoolFlowPb> flow_ = new RepeatedField<SolarSchoolFlowPb>();
	}
}
