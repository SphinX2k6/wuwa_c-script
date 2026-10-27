using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D20 RID: 3360
	[NetMessage(EMessageId.PhBaPlanSetPlanStatusResponse)]
	public sealed class PhBaPlanSetPlanStatusResponse : IMessage<PhBaPlanSetPlanStatusResponse>, IMessage, IEquatable<PhBaPlanSetPlanStatusResponse>, IDeepCloneable<PhBaPlanSetPlanStatusResponse>, IBufferMessage
	{
		// Token: 0x06012253 RID: 74323 RVA: 0x002A67C5 File Offset: 0x002A49C5
		[NullableContext(1)]
		public static PhBaPlanSetPlanStatusResponse Create()
		{
			return new PhBaPlanSetPlanStatusResponse();
		}

		// Token: 0x17003C1D RID: 15389
		// (get) Token: 0x06012254 RID: 74324 RVA: 0x002A67CC File Offset: 0x002A49CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C1E RID: 15390
		// (get) Token: 0x06012255 RID: 74325 RVA: 0x002A67CF File Offset: 0x002A49CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaPlanSetPlanStatusResponse.Descriptor;
			}
		}

		// Token: 0x06012256 RID: 74326 RVA: 0x002A67D6 File Offset: 0x002A49D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSetPlanStatusResponse()
		{
		}

		// Token: 0x06012257 RID: 74327 RVA: 0x002A67DE File Offset: 0x002A49DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSetPlanStatusResponse(PhBaPlanSetPlanStatusResponse other) : this()
		{
			this.code_ = other.code_;
			this.towPlanSame_ = other.towPlanSame_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012258 RID: 74328 RVA: 0x002A680F File Offset: 0x002A4A0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSetPlanStatusResponse Clone()
		{
			return new PhBaPlanSetPlanStatusResponse(this);
		}

		// Token: 0x17003C1F RID: 15391
		// (get) Token: 0x06012259 RID: 74329 RVA: 0x002A6817 File Offset: 0x002A4A17
		// (set) Token: 0x0601225A RID: 74330 RVA: 0x002A681F File Offset: 0x002A4A1F
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

		// Token: 0x17003C20 RID: 15392
		// (get) Token: 0x0601225B RID: 74331 RVA: 0x002A6828 File Offset: 0x002A4A28
		// (set) Token: 0x0601225C RID: 74332 RVA: 0x002A6830 File Offset: 0x002A4A30
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

		// Token: 0x0601225D RID: 74333 RVA: 0x002A6839 File Offset: 0x002A4A39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaPlanSetPlanStatusResponse);
		}

		// Token: 0x0601225E RID: 74334 RVA: 0x002A6847 File Offset: 0x002A4A47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaPlanSetPlanStatusResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.TowPlanSame == other.TowPlanSame && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601225F RID: 74335 RVA: 0x002A6888 File Offset: 0x002A4A88
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

		// Token: 0x06012260 RID: 74336 RVA: 0x002A68E6 File Offset: 0x002A4AE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012261 RID: 74337 RVA: 0x002A68F3 File Offset: 0x002A4AF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012262 RID: 74338 RVA: 0x002A68FC File Offset: 0x002A4AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TowPlanSame)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.TowPlanSame);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012263 RID: 74339 RVA: 0x002A6958 File Offset: 0x002A4B58
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

		// Token: 0x06012264 RID: 74340 RVA: 0x002A69A4 File Offset: 0x002A4BA4
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

		// Token: 0x06012265 RID: 74341 RVA: 0x002A69F4 File Offset: 0x002A4BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012266 RID: 74342 RVA: 0x002A6A00 File Offset: 0x002A4C00
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
				if (num != 96U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Code = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.TowPlanSame = input.ReadBool();
				}
			}
		}

		// Token: 0x04007162 RID: 29026
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007163 RID: 29027
		public const int CodeFieldNumber = 13;

		// Token: 0x04007164 RID: 29028
		private ErrorCode code_;

		// Token: 0x04007165 RID: 29029
		public const int TowPlanSameFieldNumber = 12;

		// Token: 0x04007166 RID: 29030
		private bool towPlanSame_;
	}
}
