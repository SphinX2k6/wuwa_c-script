using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A11 RID: 2577
	[NetMessage(EMessageId.MoonPhaseRandomResponse)]
	public sealed class MoonPhaseRandomResponse : IMessage<MoonPhaseRandomResponse>, IMessage, IEquatable<MoonPhaseRandomResponse>, IDeepCloneable<MoonPhaseRandomResponse>, IBufferMessage
	{
		// Token: 0x0600E16E RID: 57710 RVA: 0x0021050E File Offset: 0x0020E70E
		[NullableContext(1)]
		public static MoonPhaseRandomResponse Create()
		{
			return new MoonPhaseRandomResponse();
		}

		// Token: 0x17002DB4 RID: 11700
		// (get) Token: 0x0600E16F RID: 57711 RVA: 0x00210515 File Offset: 0x0020E715
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DB5 RID: 11701
		// (get) Token: 0x0600E170 RID: 57712 RVA: 0x00210518 File Offset: 0x0020E718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoonPhaseRandomResponse.Descriptor;
			}
		}

		// Token: 0x0600E171 RID: 57713 RVA: 0x0021051F File Offset: 0x0020E71F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseRandomResponse()
		{
		}

		// Token: 0x0600E172 RID: 57714 RVA: 0x00210528 File Offset: 0x0020E728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseRandomResponse(MoonPhaseRandomResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.result_ = ((other.result_ != null) ? other.result_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E173 RID: 57715 RVA: 0x00210574 File Offset: 0x0020E774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseRandomResponse Clone()
		{
			return new MoonPhaseRandomResponse(this);
		}

		// Token: 0x17002DB6 RID: 11702
		// (get) Token: 0x0600E174 RID: 57716 RVA: 0x0021057C File Offset: 0x0020E77C
		// (set) Token: 0x0600E175 RID: 57717 RVA: 0x00210584 File Offset: 0x0020E784
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

		// Token: 0x17002DB7 RID: 11703
		// (get) Token: 0x0600E176 RID: 57718 RVA: 0x0021058D File Offset: 0x0020E78D
		// (set) Token: 0x0600E177 RID: 57719 RVA: 0x00210595 File Offset: 0x0020E795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseSelect Result
		{
			get
			{
				return this.result_;
			}
			set
			{
				this.result_ = value;
			}
		}

		// Token: 0x0600E178 RID: 57720 RVA: 0x0021059E File Offset: 0x0020E79E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoonPhaseRandomResponse);
		}

		// Token: 0x0600E179 RID: 57721 RVA: 0x002105AC File Offset: 0x0020E7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoonPhaseRandomResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Result, other.Result) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E17A RID: 57722 RVA: 0x002105FC File Offset: 0x0020E7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.result_ != null)
			{
				num ^= this.Result.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E17B RID: 57723 RVA: 0x00210657 File Offset: 0x0020E857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E17C RID: 57724 RVA: 0x00210664 File Offset: 0x0020E864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E17D RID: 57725 RVA: 0x00210670 File Offset: 0x0020E870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.result_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Result);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E17E RID: 57726 RVA: 0x002106CC File Offset: 0x0020E8CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.result_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Result);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E17F RID: 57727 RVA: 0x00210724 File Offset: 0x0020E924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MoonPhaseRandomResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.result_ != null)
			{
				if (this.result_ == null)
				{
					this.Result = new MoonPhaseSelect();
				}
				this.Result.MergeFrom(other.Result);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E180 RID: 57728 RVA: 0x0021078C File Offset: 0x0020E98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E181 RID: 57729 RVA: 0x00210798 File Offset: 0x0020E998
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
				if (num != 26U)
				{
					if (num != 56U)
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
					if (this.result_ == null)
					{
						this.Result = new MoonPhaseSelect();
					}
					input.ReadMessage(this.Result);
				}
			}
		}

		// Token: 0x04005CA8 RID: 23720
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005CA9 RID: 23721
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04005CAA RID: 23722
		private ErrorCode errorCode_;

		// Token: 0x04005CAB RID: 23723
		public const int ResultFieldNumber = 3;

		// Token: 0x04005CAC RID: 23724
		private MoonPhaseSelect result_;
	}
}
