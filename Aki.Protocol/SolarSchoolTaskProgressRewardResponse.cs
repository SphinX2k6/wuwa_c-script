using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012CD RID: 4813
	[NetMessage(EMessageId.SolarSchoolTaskProgressRewardResponse)]
	public sealed class SolarSchoolTaskProgressRewardResponse : IMessage<SolarSchoolTaskProgressRewardResponse>, IMessage, IEquatable<SolarSchoolTaskProgressRewardResponse>, IDeepCloneable<SolarSchoolTaskProgressRewardResponse>, IBufferMessage
	{
		// Token: 0x06019B12 RID: 105234 RVA: 0x003BFB2D File Offset: 0x003BDD2D
		[NullableContext(1)]
		public static SolarSchoolTaskProgressRewardResponse Create()
		{
			return new SolarSchoolTaskProgressRewardResponse();
		}

		// Token: 0x17005702 RID: 22274
		// (get) Token: 0x06019B13 RID: 105235 RVA: 0x003BFB34 File Offset: 0x003BDD34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005703 RID: 22275
		// (get) Token: 0x06019B14 RID: 105236 RVA: 0x003BFB37 File Offset: 0x003BDD37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolTaskProgressRewardResponse.Descriptor;
			}
		}

		// Token: 0x06019B15 RID: 105237 RVA: 0x003BFB3E File Offset: 0x003BDD3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolTaskProgressRewardResponse()
		{
		}

		// Token: 0x06019B16 RID: 105238 RVA: 0x003BFB48 File Offset: 0x003BDD48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolTaskProgressRewardResponse(SolarSchoolTaskProgressRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.activity_ = ((other.activity_ != null) ? other.activity_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019B17 RID: 105239 RVA: 0x003BFB94 File Offset: 0x003BDD94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolTaskProgressRewardResponse Clone()
		{
			return new SolarSchoolTaskProgressRewardResponse(this);
		}

		// Token: 0x17005704 RID: 22276
		// (get) Token: 0x06019B18 RID: 105240 RVA: 0x003BFB9C File Offset: 0x003BDD9C
		// (set) Token: 0x06019B19 RID: 105241 RVA: 0x003BFBA4 File Offset: 0x003BDDA4
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

		// Token: 0x17005705 RID: 22277
		// (get) Token: 0x06019B1A RID: 105242 RVA: 0x003BFBAD File Offset: 0x003BDDAD
		// (set) Token: 0x06019B1B RID: 105243 RVA: 0x003BFBB5 File Offset: 0x003BDDB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolActivityPb Activity
		{
			get
			{
				return this.activity_;
			}
			set
			{
				this.activity_ = value;
			}
		}

		// Token: 0x06019B1C RID: 105244 RVA: 0x003BFBBE File Offset: 0x003BDDBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolTaskProgressRewardResponse);
		}

		// Token: 0x06019B1D RID: 105245 RVA: 0x003BFBCC File Offset: 0x003BDDCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolTaskProgressRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Activity, other.Activity) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019B1E RID: 105246 RVA: 0x003BFC1C File Offset: 0x003BDE1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.activity_ != null)
			{
				num ^= this.Activity.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019B1F RID: 105247 RVA: 0x003BFC77 File Offset: 0x003BDE77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019B20 RID: 105248 RVA: 0x003BFC84 File Offset: 0x003BDE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019B21 RID: 105249 RVA: 0x003BFC90 File Offset: 0x003BDE90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.activity_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Activity);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019B22 RID: 105250 RVA: 0x003BFCEC File Offset: 0x003BDEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.activity_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Activity);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019B23 RID: 105251 RVA: 0x003BFD44 File Offset: 0x003BDF44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolTaskProgressRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.activity_ != null)
			{
				if (this.activity_ == null)
				{
					this.Activity = new SolarSchoolActivityPb();
				}
				this.Activity.MergeFrom(other.Activity);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019B24 RID: 105252 RVA: 0x003BFDAC File Offset: 0x003BDFAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019B25 RID: 105253 RVA: 0x003BFDB8 File Offset: 0x003BDFB8
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
				if (num != 74U)
				{
					if (num != 96U)
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
					if (this.activity_ == null)
					{
						this.Activity = new SolarSchoolActivityPb();
					}
					input.ReadMessage(this.Activity);
				}
			}
		}

		// Token: 0x040097C4 RID: 38852
		private UnknownFieldSet _unknownFields;

		// Token: 0x040097C5 RID: 38853
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x040097C6 RID: 38854
		private ErrorCode errorCode_;

		// Token: 0x040097C7 RID: 38855
		public const int ActivityFieldNumber = 9;

		// Token: 0x040097C8 RID: 38856
		private SolarSchoolActivityPb activity_;
	}
}
