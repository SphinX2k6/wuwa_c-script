using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D10 RID: 3344
	[NetMessage(EMessageId.PhBaPlanSetPlanStatusResponse)]
	public sealed class PhBaPlanSetPlanStatusResponse : IMessage<PhBaPlanSetPlanStatusResponse>, IMessage, IEquatable<PhBaPlanSetPlanStatusResponse>, IDeepCloneable<PhBaPlanSetPlanStatusResponse>, IBufferMessage
	{
		// Token: 0x06012157 RID: 74071 RVA: 0x002A4BA1 File Offset: 0x002A2DA1
		[NullableContext(1)]
		public static PhBaPlanSetPlanStatusResponse Create()
		{
			return new PhBaPlanSetPlanStatusResponse();
		}

		// Token: 0x17003BE8 RID: 15336
		// (get) Token: 0x06012158 RID: 74072 RVA: 0x002A4BA8 File Offset: 0x002A2DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BE9 RID: 15337
		// (get) Token: 0x06012159 RID: 74073 RVA: 0x002A4BAB File Offset: 0x002A2DAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaPlanSetPlanStatusResponse.Descriptor;
			}
		}

		// Token: 0x0601215A RID: 74074 RVA: 0x002A4BB2 File Offset: 0x002A2DB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSetPlanStatusResponse()
		{
		}

		// Token: 0x0601215B RID: 74075 RVA: 0x002A4BBA File Offset: 0x002A2DBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSetPlanStatusResponse(PhBaPlanSetPlanStatusResponse other) : this()
		{
			this.code_ = other.code_;
			this.towPlanSame_ = other.towPlanSame_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601215C RID: 74076 RVA: 0x002A4BEB File Offset: 0x002A2DEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSetPlanStatusResponse Clone()
		{
			return new PhBaPlanSetPlanStatusResponse(this);
		}

		// Token: 0x17003BEA RID: 15338
		// (get) Token: 0x0601215D RID: 74077 RVA: 0x002A4BF3 File Offset: 0x002A2DF3
		// (set) Token: 0x0601215E RID: 74078 RVA: 0x002A4BFB File Offset: 0x002A2DFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x17003BEB RID: 15339
		// (get) Token: 0x0601215F RID: 74079 RVA: 0x002A4C04 File Offset: 0x002A2E04
		// (set) Token: 0x06012160 RID: 74080 RVA: 0x002A4C0C File Offset: 0x002A2E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool TowPlanSame
		{
			get
			{
				return this.towPlanSame_;
			}
			set
			{
				this.towPlanSame_ = value;
			}
		}

		// Token: 0x06012161 RID: 74081 RVA: 0x002A4C15 File Offset: 0x002A2E15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaPlanSetPlanStatusResponse);
		}

		// Token: 0x06012162 RID: 74082 RVA: 0x002A4C23 File Offset: 0x002A2E23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaPlanSetPlanStatusResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.TowPlanSame == other.TowPlanSame && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012163 RID: 74083 RVA: 0x002A4C64 File Offset: 0x002A2E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.TowPlanSame)
			{
				num ^= this.TowPlanSame.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012164 RID: 74084 RVA: 0x002A4CC2 File Offset: 0x002A2EC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012165 RID: 74085 RVA: 0x002A4CCF File Offset: 0x002A2ECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012166 RID: 74086 RVA: 0x002A4CD8 File Offset: 0x002A2ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Code);
			}
			if (this.TowPlanSame)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.TowPlanSame);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012167 RID: 74087 RVA: 0x002A4D34 File Offset: 0x002A2F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.TowPlanSame)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012168 RID: 74088 RVA: 0x002A4D80 File Offset: 0x002A2F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhBaPlanSetPlanStatusResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.TowPlanSame)
			{
				this.TowPlanSame = other.TowPlanSame;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012169 RID: 74089 RVA: 0x002A4DD0 File Offset: 0x002A2FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601216A RID: 74090 RVA: 0x002A4DDC File Offset: 0x002A2FDC
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
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TowPlanSame = input.ReadBool();
					}
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400717A RID: 29050
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400717B RID: 29051
		public const int CodeFieldNumber = 2;

		// Token: 0x0400717C RID: 29052
		private ErrorCode code_;

		// Token: 0x0400717D RID: 29053
		public const int TowPlanSameFieldNumber = 14;

		// Token: 0x0400717E RID: 29054
		private bool towPlanSame_;
	}
}
